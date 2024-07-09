#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::JoinAll<$0>")>]
#endif
type futures_future_JoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::prelude::stream::Fuse<$0>")>]
#endif
type futures_future_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::task::JoinHandle<$0>")>]
#endif
type tokio_task_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio_stream::StreamExt")>]
#endif
type tokio_stream_StreamExt = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
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
and Heap0 = {l0 : Vec<(bool * std_string_String)>; l1 : std_string_String option; l2 : int32; l3 : int32; l4 : US1}
and Heap1 = {l0 : leptos_RwSignal<bool>; l1 : leptos_RwSignal<bool>; l2 : leptos_RwSignal<std_string_String>; l3 : leptos_RwSignal<Heap0>}
and  Heap2 = {l0 : leptos_RwSignal<Heap1>; l1 : leptos_RwSignal<std_collections_HashMap<std_string_String, leptos_RwSignal<bool>>>}
and [<Struct>] US2 =
    | US2_0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : rexie_Rexie
    | US3_1 of f1_0 : rexie_Error
and Heap3 = {l0 : bool; l1 : bool; l2 : std_string_String; l3 : Heap0}
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
and Mut2 = {mutable l0 : int32; mutable l1 : Vec<struct (string * US25 * string * bool * bool)>}
and Mut3 = {mutable l0 : int32; mutable l1 : Vec<string>}
and Heap4 = {l0 : std_string_String}
and [<Struct>] US26 =
    | US26_0 of f0_0 : Heap4 option
    | US26_1 of f1_0 : std_string_String
and [<Struct>] US27 =
    | US27_0 of f0_0 : Heap4
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : Result<Vec<Heap4 option>, std_string_String>
    | US28_1
and [<Struct>] US30 =
    | US30_0 of f0_0 : Vec<US27>
    | US30_1 of f1_0 : std_string_String
and [<Struct>] US29 =
    | US29_0 of f0_0 : US30
    | US29_1
and [<Struct>] US31 =
    | US31_0 of f0_0 : Vec<Heap4 option>
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
and [<Struct>] US39 =
    | US39_0 of f0_0 : (US27 [])
    | US39_1 of f1_0 : std_string_String
and [<Struct>] US38 =
    | US38_0 of f0_0 : US39
    | US38_1
and [<Struct>] US40 =
    | US40_0 of f0_0 : Result<Vec<string option>, std_string_String>
    | US40_1
and [<Struct>] US42 =
    | US42_0 of f0_0 : Vec<string option>
    | US42_1 of f1_0 : std_string_String
and [<Struct>] US41 =
    | US41_0 of f0_0 : US42
    | US41_1
and [<Struct>] US44 =
    | US44_0 of f0_0 : Vec<US34>
    | US44_1 of f1_0 : std_string_String
and [<Struct>] US43 =
    | US43_0 of f0_0 : US44
    | US43_1
and [<Struct>] US45 =
    | US45_0 of f0_0 : US34
    | US45_1
and Heap5 = {l0 : std_string_String; l1 : std_string_String; l2 : std_string_String; l3 : std_string_String; l4 : std_string_String; l5 : std_string_String; l6 : uint32; l7 : (struct (std_string_String * std_string_String option) []); l8 : float; l9 : bool; l10 : float; l11 : (std_string_String [])}
and [<Struct>] US46 =
    | US46_0 of f0_0 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option
    | US46_1 of f1_0 : std_string_String
and [<Struct>] US48 =
    | US48_0 of f0_0 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) [])
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
    | US58_0 of f0_0 : (struct (string * US25 * string * bool * bool) [])
    | US58_1
and [<Struct>] US57 =
    | US57_0 of f0_0 : US58
    | US57_1 of f1_0 : std_string_String
and [<Struct>] US59 =
    | US59_0 of f0_0 : (struct (string * US25 * string * bool * bool) []) option
    | US59_1 of f1_0 : std_string_String
and Heap6 = {l0 : int32}
and [<Struct>] US60 =
    | US60_0 of f0_0 : std_string_String * f0_1 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * f0_2 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * f0_3 : std_string_String option
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
    | US64_0 of f0_0 : std_string_String * f0_1 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * f0_2 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * f0_3 : std_string_String option
    | US64_1 of f1_0 : std_string_String
and [<Struct>] US65 =
    | US65_0 of f0_0 : US62
    | US65_1
and [<Struct>] US66 =
    | US66_0 of f0_0 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option
    | US66_1 of f1_0 : std_string_String
and [<Struct>] US67 =
    | US67_0 of f0_0 : std_string_String * f0_1 : std_string_String * f0_2 : struct (std_string_String option * std_string_String option) option * f0_3 : int32 * f0_4 : std_string_String * f0_5 : std_string_String
    | US67_1
and [<Struct>] US68 =
    | US68_0 of f0_0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>
    | US68_1
and [<Struct>] US69 =
    | US69_0 of f0_0 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>
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
and method8 (v0 : int64, v1 : string) : string =
    let v2 : int64 = System.Convert.ToInt64 v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : (int64 -> float) = float
        let v5 : float = v4 v0
        let v6 : float = v5 / 2.0
        let v7 : (float -> float) = ceil
        let v8 : float = v7 v6
        let v9 : (float -> int64) = int64
        let v10 : int64 = v9 v8
        let v11 : (float -> float) = floor
        let v12 : float = v11 v6
        let v13 : (float -> int64) = int64
        let v14 : int64 = v13 v12
        let v15 : int64 = v10 - 1L
        let v16 : string = v1.[int 0L..int v15]
        let v17 : int64 = v2 - v14
        let v18 : int64 = v2 - 1L
        let v19 : string = v1.[int v17..int v18]
        let v20 : string = "..."
        let v21 : (string []) = [|v16; v20; v19|]
        let v24 : string seq = v21 |> Seq.ofArray
        let v33 : (string -> (string seq -> string)) = String.concat
        let v34 : string = ""
        let v35 : (string seq -> string) = v33 v34
        v35 v24
and method9 (v0 : rexie_Rexie) : rexie_Rexie =
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
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let v22 : string = "v15 " + v19 + "); " + v21 + " //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "__result"
    let v24 : std_pin_Pin<Box<Dyn<std_future_Future<US3>>>> = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "v24.await"
    let v26 : US3 = Fable.Core.RustInterop.emitRustExpr () v25 
    let v32 : rexie_Rexie =
        match v26 with
        | US3_1(v28) -> (* Error *)
            let v29 : string = $"resultm.get / Result value was Error: {v28}"
            failwith<rexie_Rexie> v29
        | US3_0(v27) -> (* Ok *)
            v27
    let v35 : string = $"%A{v32}"
    let v42 : string = "state_core.use_database (3) / database create_local_resource / result: " + string v35 + ""
    let v43 : int64 = 200L
    let v44 : string = method8(v43, v42)
    let v45 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v46 : bool = Fable.Core.RustInterop.emitRustExpr v44 v45 
    let v47 : rexie_Rexie = method9(v32)
    let v48 : string = v16 + v17 
    let v49 : string = v48 + v17 
    let v50 : string = v49 + v17 
    let v51 : string = v50 + v17 
    let v52 : string = v16 + v20 
    let v53 : string = v52 + v20 
    let v54 : string = v53 + v20 
    let v55 : string = "v47 " + v51 + "); " + v54 + " //"
    Fable.Core.RustInterop.emitRustExpr () v55 
    let v56 : string = "__result"
    let v57 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = Fable.Core.RustInterop.emitRustExpr () v56 
    v57
and method10 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> =
    v0
and method5 () : leptos_Resource<US2, rexie_Rexie> =
    let v0 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v1 : (unit -> US2) = closure5()
    Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v2 : string = "x"
    let v3 : US2 = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = method6()
    let v5 : std_pin_Pin<Box<Dyn<std_future_Future<rexie_Rexie>>>> = method10(v4)
    let v6 : string = "v5.await"
    let v7 : rexie_Rexie = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = ""
    let v9 : string = "}"
    let v10 : string = v8 + v9 
    let v11 : string = v10 + v9 
    let v12 : string = "{"
    let v13 : string = v8 + v12 
    let v14 : string = "v7 " + v11 + "); " + v13 + " //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "__result"
    let v16 : leptos_Resource<US2, rexie_Rexie> = Fable.Core.RustInterop.emitRustExpr () v15 
    v16
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
and method15 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure10 () (v0 : rexie_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method16 () : (rexie_Error -> std_string_String) =
    closure10()
and method17 () : string =
    let v0 : string = "store"
    v0
and closure11 () (v0 : rexie_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method18 () : (rexie_Error -> std_string_String) =
    closure11()
and method19 (v0 : string) : string =
    v0
and closure12 () (v0 : rexie_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method20 () : (rexie_Error -> std_string_String) =
    closure12()
and method21 (v0 : wasm_bindgen_JsValue) : wasm_bindgen_JsValue =
    v0
and closure13 () (v0 : serde_wasm_bindgen_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method22 () : (serde_wasm_bindgen_Error -> std_string_String) =
    closure13()
and method23 (v0 : serde_json_Value) : serde_json_Value =
    v0
and closure14 () (v0 : serde_json_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method24 () : (serde_json_Error -> std_string_String) =
    closure14()
and closure15 () (v0 : borsh_io_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method25 () : (borsh_io_Error -> std_string_String) =
    closure15()
and method26 (v0 : Result<Heap3 option option, std_string_String>) : Result<Heap3 option option, std_string_String> =
    v0
and method14 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> =
    let v2 : string = "state_core.get_data () / id: " + v0 + ""
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = "store"
    let v7 : (string []) = [|v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v11 : (string -> std_string_String) = closure9()
    let v12 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10 
    let v13 : rexie_Rexie = method15(v1)
    let v14 : string = "v13.transaction(&v12, rexie::TransactionMode::ReadOnly)"
    let v15 : Result<rexie_Transaction, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : (rexie_Error -> std_string_String) = method16()
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<rexie_Transaction, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let v19 : string = "$0?"
    let v20 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = method17()
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "v20.store(v23)"
    let v25 : Result<rexie_Store, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : (rexie_Error -> std_string_String) = method18()
    let v27 : string = "$0.map_err(|x| $1(x))"
    let v28 : Result<rexie_Store, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v25, v26) v27 
    let v29 : string = "$0?"
    let v30 : rexie_Store = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : string = method19(v0)
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "wasm_bindgen::JsValue::from_str(v33)"
    let v35 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"Box::pin(rexie::Store::get(&v30, &v35))"
    let v37 : std_pin_Pin<Box<Dyn<std_future_Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "v37.await"
    let v39 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : (rexie_Error -> std_string_String) = method20()
    let v41 : string = "$0.map_err(|x| $1(x))"
    let v42 : Result<wasm_bindgen_JsValue, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v39, v40) v41 
    let v43 : string = "$0?"
    let v44 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let v45 : wasm_bindgen_JsValue = method21(v44)
    let v46 : string = "serde_wasm_bindgen::from_value(v45)"
    let v47 : Result<serde_json_Value option, serde_wasm_bindgen_Error> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : (serde_wasm_bindgen_Error -> std_string_String) = method22()
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<serde_json_Value option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49 
    let v51 : string = "$0?"
    let v52 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v55 : US7 option = None
    let _v55 = ref v55 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v56 : serde_json_Value = x
    let v57 : US7 = US7_0(v56)
    v57 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v55.Value <- x
    let v58 : US7 option = _v55.Value 
    let v81 : US7 = US7_1
    let v82 : US7 = v58 |> Option.defaultValue v81 
    let v121 : US6 =
        match v82 with
        | US7_1 -> (* None *)
            US6_1
        | US7_0(v90) -> (* Some *)
            let v91 : serde_json_Value = method23(v90)
            let v92 : string = "serde_json::from_value(v91)"
            let v93 : Result<Vec<uint8>, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v92 
            let v94 : (serde_json_Error -> std_string_String) = method24()
            let v95 : string = "$0.map_err(|x| $1(x))"
            let v96 : Result<Vec<uint8>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v93, v94) v95 
            let v97 : string = "$0?"
            let v98 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v96 v97 
            let v99 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v100 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v98 v99 
            let v101 : int32 = v100.Length
            let v102 : string = "state_core.get_data () / data_len: " + string v101 + ""
            let v103 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v104 : bool = Fable.Core.RustInterop.emitRustExpr v102 v103 
            let v105 : string = "$0.to_vec()"
            let v106 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v100 v105 
            let v107 : string = "v106.as_slice()"
            let v108 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v107 
            let v109 : string = "true; let mut v108 = v108"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
            let v111 : string = "borsh::BorshDeserialize::deserialize(&mut v108)"
            let v112 : Result<Heap3 option, borsh_io_Error> = Fable.Core.RustInterop.emitRustExpr () v111 
            let v113 : (borsh_io_Error -> std_string_String) = method25()
            let v114 : string = "$0.map_err(|x| $1(x))"
            let v115 : Result<Heap3 option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v112, v113) v114 
            let v116 : string = "$0?"
            let v117 : Heap3 option = Fable.Core.RustInterop.emitRustExpr v115 v116 
            US6_0(v117)
    let v134 : Heap3 option option =
        match v121 with
        | US6_1 -> (* None *)
            let v132 : Heap3 option option = None
            v132
        | US6_0(v122) -> (* Some *)
            let v125 : Heap3 option option = Some v122 
            v125
    let v135 : Result<Heap3 option option, std_string_String> = Ok v134 
    let v136 : Result<Heap3 option option, std_string_String> = method26(v135)
    let v137 : string = ""
    let v138 : string = "}"
    let v139 : string = v137 + v138 
    let v140 : string = v139 + v138 
    let v141 : string = v140 + v138 
    let v142 : string = "{"
    let v143 : string = v137 + v142 
    let v144 : string = v143 + v142 
    let v145 : string = "v136 " + v141 + "); " + v144 + " //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "__result"
    let v147 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v146 
    v147
and method13 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> =
    method14(v0, v1)
and closure16 () (v0 : Heap3 option option) : US8 =
    US8_0(v0)
and closure17 () (v0 : std_string_String) : US8 =
    US8_1(v0)
and method27 (v0 : US4) : US4 =
    v0
and method12 (v0 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v4 : string = $"%A{v0}"
    let v11 : string = "state_core.use_core_database (2) / core_state_heap create_local_resource / database: " + v4 + ""
    let v12 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v16 : US5 option = None
    let _v16 = ref v16 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v17 : rexie_Rexie = x
    let v18 : US5 = US5_0(v17)
    v18 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v16.Value <- x
    let v19 : US5 option = _v16.Value 
    let v42 : US5 = US5_1
    let v43 : US5 = v19 |> Option.defaultValue v42 
    let v106 : US6 =
        match v43 with
        | US5_1 -> (* None *)
            US6_1
        | US5_0(v51) -> (* Some *)
            let v52 : string = "core-state-heap"
            let v53 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap3 option option, std_string_String>>>>> = method13(v52, v51)
            let v54 : string = "v53.await"
            let v55 : Result<Heap3 option option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v54 
            let v56 : (Heap3 option option -> US8) = closure16()
            let v57 : (std_string_String -> US8) = closure17()
            let v58 : US8 = match v55 with Ok x -> v56 x | Error x -> v57 x
            match v58 with
            | US8_1(v97) -> (* Error *)
                let v98 : string = "state_core.use_core_database (3) / error: " + string v97 + ""
                let v99 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                US6_1
            | US8_0(v59) -> (* Ok *)
                let v62 : US6 option = None
                let _v62 = ref v62 
                match v59 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v63 : Heap3 option = x
                let v64 : US6 = US6_0(v63)
                v64 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v62.Value <- x
                let v65 : US6 option = _v62.Value 
                let v88 : US6 = US6_1
                let v89 : US6 = v65 |> Option.defaultValue v88 
                v89
    let v148 : US9 =
        match v106 with
        | US6_1 -> (* None *)
            US9_1
        | US6_0(v107) -> (* Some *)
            let v110 : US4 option = None
            let _v110 = ref v110 
            match v107 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v111 : Heap3 = x
            let v112 : US4 = US4_0(v111)
            v112 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v110.Value <- x
            let v113 : US4 option = _v110.Value 
            let v136 : US4 = US4_1
            let v137 : US4 = v113 |> Option.defaultValue v136 
            US9_0(v137)
    let v155 : US4 =
        match v148 with
        | US9_0(v149) -> (* Some *)
            match v149 with
            | US4_0(v150) -> (* Some *)
                US4_0(v150)
            | _ ->
                US4_1
        | _ ->
            US4_1
    let v156 : US4 = method27(v155)
    let v157 : string = ""
    let v158 : string = "}"
    let v159 : string = v157 + v158 
    let v160 : string = v159 + v158 
    let v161 : string = v160 + v158 
    let v162 : string = "{"
    let v163 : string = v157 + v162 
    let v164 : string = v163 + v162 
    let v165 : string = "v156 " + v161 + "); " + v164 + " //"
    Fable.Core.RustInterop.emitRustExpr () v165 
    let v166 : string = "__result"
    let v167 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = Fable.Core.RustInterop.emitRustExpr () v166 
    v167
and method28 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> =
    v0
and method11 (v0 : leptos_Resource<US2, rexie_Rexie>) : leptos_Resource<rexie_Rexie option, US4> =
    let v1 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v2 : (unit -> rexie_Rexie option) = closure8(v0)
    Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v3 : string = "x"
    let v4 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = method12(v4)
    let v6 : std_pin_Pin<Box<Dyn<std_future_Future<US4>>>> = method28(v5)
    let v7 : string = "v6.await"
    let v8 : US4 = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let v15 : string = "v8 " + v12 + "); " + v14 + " //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "__result"
    let v17 : leptos_Resource<rexie_Rexie option, US4> = Fable.Core.RustInterop.emitRustExpr () v16 
    v17
and method29 () : web_sys_Window =
    let v0 : string = "leptos::leptos_dom::window()"
    let v1 : web_sys_Window = Fable.Core.RustInterop.emitRustExpr () v0 
    v1
and method30 (v0 : web_sys_Window) : Result<web_sys_Storage option, wasm_bindgen_JsValue> =
    let v1 : string = "$0.local_storage()"
    let v2 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure19 () (v0 : web_sys_Storage option) : US10 =
    US10_0(v0)
and closure20 () (v0 : wasm_bindgen_JsValue) : US10 =
    US10_1(v0)
and method31 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method32 () : string =
    let v0 : string = "core-state-heap"
    v0
and closure21 () (v0 : std_string_String option) : US13 =
    US13_0(v0)
and closure22 () (v0 : wasm_bindgen_JsValue) : US13 =
    US13_1(v0)
and method33 (v0 : std_string_String option) : std_string_String option =
    v0
and method34 (v0 : string) : string =
    v0
and closure23 () (v0 : serde_json_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method35 () : (serde_json_Error -> std_string_String) =
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
    let v5 : bool = v0.l1
    v5
and closure27 (v0 : Heap3) (v1 : std_string_String) : std_string_String =
    let v2 : string = "state_core.use_core_database (9) / effect core_state_heap / url_hash signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : std_string_String = v0.l2
    v5
and closure28 (v0 : Heap3) (v1 : Heap0) : Heap0 =
    let v2 : string = "state_core.use_core_database (10) / effect core_state_heap / data signal_update"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : Heap0 = v0.l3
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
    let v11 : leptos_RwSignal<bool> = v10.l1
    let v12 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v13 : (bool -> bool) = closure26(v1)
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v12 
    let v15 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v16 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v15 
    let v17 : leptos_RwSignal<std_string_String> = v16.l2
    let v18 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v19 : (std_string_String -> std_string_String) = closure27(v1)
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v22 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v21 
    let v23 : leptos_RwSignal<Heap0> = v22.l3
    let v24 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v25 : (Heap0 -> Heap0) = closure28(v1)
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr struct (v23, v25) v24 
    ()
and closure18 (v0 : Heap2, v1 : leptos_Resource<rexie_Rexie option, US4>) () : unit =
    let v2 : string = "state_core.use_core_database (4) / effect core_state_heap / ##1"
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : web_sys_Window = method29()
    let v6 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method30(v5)
    let v7 : (web_sys_Storage option -> US10) = closure19()
    let v8 : (wasm_bindgen_JsValue -> US10) = closure20()
    let v9 : US10 = match v6 with Ok x -> v7 x | Error x -> v8 x
    let v52 : US11 =
        match v9 with
        | US10_1(v49) -> (* Error *)
            US11_1(v49)
        | US10_0(v10) -> (* Ok *)
            let v13 : US12 option = None
            let _v13 = ref v13 
            match v10 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v14 : web_sys_Storage = x
            let v15 : US12 = US12_0(v14)
            v15 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v13.Value <- x
            let v16 : US12 option = _v13.Value 
            let v39 : US12 = US12_1
            let v40 : US12 = v16 |> Option.defaultValue v39 
            US11_0(v40)
    match v52 with
    | US11_0(v53) -> (* Ok *)
        match v53 with
        | US12_0(v54) -> (* Some *)
            let v55 : string = $"leptos::SignalGet::get(&$0)"
            let v56 : US4 option = Fable.Core.RustInterop.emitRustExpr v1 v55 
            let v59 : US9 option = None
            let _v59 = ref v59 
            match v56 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v60 : US4 = x
            let v61 : US9 = US9_0(v60)
            v61 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v59.Value <- x
            let v62 : US9 option = _v59.Value 
            let v85 : US9 = US9_1
            let v86 : US9 = v62 |> Option.defaultValue v85 
            let v96 : string = $"%A{v86}"
            let v103 : string = "state_core.use_core_database (5) / effect core_state_heap / ##2 / core_state_heap: " + v96 + ""
            let v104 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v105 : bool = Fable.Core.RustInterop.emitRustExpr v103 v104 
            let v604 : US4 =
                match v86 with
                | US9_0(v106) -> (* Some *)
                    match v106 with
                    | US4_0(v107) -> (* Some *)
                        US4_0(v107)
                    | _ ->
                        let v109 : web_sys_Storage = method31(v54)
                        let v110 : string = method32()
                        let v111 : string = "&*$0"
                        let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v110 v111 
                        let v113 : string = $"web_sys::Storage::get_item(&v109, v112)"
                        let v114 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v113 
                        let v115 : (std_string_String option -> US13) = closure21()
                        let v116 : (wasm_bindgen_JsValue -> US13) = closure22()
                        let v117 : US13 = match v114 with Ok x -> v115 x | Error x -> v116 x
                        let v163 : US14 =
                            match v117 with
                            | US13_1(v160) -> (* Error *)
                                US14_1(v160)
                            | US13_0(v118) -> (* Ok *)
                                let v119 : std_string_String option = method33(v118)
                                let v120 : string = "serde_json::from_value(v119.into()).unwrap()"
                                let v121 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v120 
                                let v124 : US15 option = None
                                let _v124 = ref v124 
                                match v121 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v125 : std_string_String = x
                                let v126 : US15 = US15_0(v125)
                                v126 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v124.Value <- x
                                let v127 : US15 option = _v124.Value 
                                let v150 : US15 = US15_1
                                let v151 : US15 = v127 |> Option.defaultValue v150 
                                US14_0(v151)
                        let v169 : US16 =
                            match v163 with
                            | US14_1(v166) -> (* Error *)
                                US16_1
                            | US14_0(v164) -> (* Ok *)
                                US16_0(v164)
                        let v176 : US15 =
                            match v169 with
                            | US16_0(v170) -> (* Some *)
                                match v170 with
                                | US15_0(v171) -> (* Some *)
                                    US15_0(v171)
                                | _ ->
                                    US15_1
                            | _ ->
                                US15_1
                        let v189 : std_string_String option =
                            match v176 with
                            | US15_1 -> (* None *)
                                let v187 : std_string_String option = None
                                v187
                            | US15_0(v177) -> (* Some *)
                                let v180 : std_string_String option = Some v177 
                                v180
                        let v192 : US4 option = None
                        let _v192 = ref v192 
                        match v189 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v193 : std_string_String = x
                        let v194 : string = "fable_library_rust::String_::fromString($0)"
                        let v195 : string = Fable.Core.RustInterop.emitRustExpr v193 v194 
                        let v196 : string = method34(v195)
                        let v197 : string = "&*$0"
                        let v198 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v196 v197 
                        let v199 : string = "serde_json::from_str(&v198)"
                        let v200 : Result<Heap3, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v199 
                        let v201 : (serde_json_Error -> std_string_String) = method35()
                        let v202 : string = "$0.map_err(|x| $1(x))"
                        let v203 : Result<Heap3, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v200, v201) v202 
                        let v204 : string = "v203.ok()"
                        let v205 : Heap3 option = Fable.Core.RustInterop.emitRustExpr () v204 
                        let v208 : US4 option = None
                        let _v208 = ref v208 
                        match v205 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v209 : Heap3 = x
                        let v210 : US4 = US4_0(v209)
                        v210 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v208.Value <- x
                        let v211 : US4 option = _v208.Value 
                        let v234 : US4 = US4_1
                        let v235 : US4 = v211 |> Option.defaultValue v234 
                        v235 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v192.Value <- x
                        let v243 : US4 option = _v192.Value 
                        let v314 : US9 option = None
                        let _v314 = ref v314 
                        match v243 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v315 : US4 = x
                        let v316 : US9 = US9_0(v315)
                        v316 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v314.Value <- x
                        let v317 : US9 option = _v314.Value 
                        let v340 : US9 = US9_1
                        let v341 : US9 = v317 |> Option.defaultValue v340 
                        match v341 with
                        | US9_0(v349) -> (* Some *)
                            match v349 with
                            | US4_0(v350) -> (* Some *)
                                US4_0(v350)
                            | _ ->
                                US4_1
                        | _ ->
                            US4_1
                | _ ->
                    let v357 : web_sys_Storage = method31(v54)
                    let v358 : string = method32()
                    let v359 : string = "&*$0"
                    let v360 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v358 v359 
                    let v361 : string = $"web_sys::Storage::get_item(&v357, v360)"
                    let v362 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v361 
                    let v363 : (std_string_String option -> US13) = closure21()
                    let v364 : (wasm_bindgen_JsValue -> US13) = closure22()
                    let v365 : US13 = match v362 with Ok x -> v363 x | Error x -> v364 x
                    let v411 : US14 =
                        match v365 with
                        | US13_1(v408) -> (* Error *)
                            US14_1(v408)
                        | US13_0(v366) -> (* Ok *)
                            let v367 : std_string_String option = method33(v366)
                            let v368 : string = "serde_json::from_value(v367.into()).unwrap()"
                            let v369 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v368 
                            let v372 : US15 option = None
                            let _v372 = ref v372 
                            match v369 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v373 : std_string_String = x
                            let v374 : US15 = US15_0(v373)
                            v374 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v372.Value <- x
                            let v375 : US15 option = _v372.Value 
                            let v398 : US15 = US15_1
                            let v399 : US15 = v375 |> Option.defaultValue v398 
                            US14_0(v399)
                    let v417 : US16 =
                        match v411 with
                        | US14_1(v414) -> (* Error *)
                            US16_1
                        | US14_0(v412) -> (* Ok *)
                            US16_0(v412)
                    let v424 : US15 =
                        match v417 with
                        | US16_0(v418) -> (* Some *)
                            match v418 with
                            | US15_0(v419) -> (* Some *)
                                US15_0(v419)
                            | _ ->
                                US15_1
                        | _ ->
                            US15_1
                    let v437 : std_string_String option =
                        match v424 with
                        | US15_1 -> (* None *)
                            let v435 : std_string_String option = None
                            v435
                        | US15_0(v425) -> (* Some *)
                            let v428 : std_string_String option = Some v425 
                            v428
                    let v440 : US4 option = None
                    let _v440 = ref v440 
                    match v437 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v441 : std_string_String = x
                    let v442 : string = "fable_library_rust::String_::fromString($0)"
                    let v443 : string = Fable.Core.RustInterop.emitRustExpr v441 v442 
                    let v444 : string = method34(v443)
                    let v445 : string = "&*$0"
                    let v446 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v444 v445 
                    let v447 : string = "serde_json::from_str(&v446)"
                    let v448 : Result<Heap3, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v447 
                    let v449 : (serde_json_Error -> std_string_String) = method35()
                    let v450 : string = "$0.map_err(|x| $1(x))"
                    let v451 : Result<Heap3, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v448, v449) v450 
                    let v452 : string = "v451.ok()"
                    let v453 : Heap3 option = Fable.Core.RustInterop.emitRustExpr () v452 
                    let v456 : US4 option = None
                    let _v456 = ref v456 
                    match v453 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v457 : Heap3 = x
                    let v458 : US4 = US4_0(v457)
                    v458 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v456.Value <- x
                    let v459 : US4 option = _v456.Value 
                    let v482 : US4 = US4_1
                    let v483 : US4 = v459 |> Option.defaultValue v482 
                    v483 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v440.Value <- x
                    let v491 : US4 option = _v440.Value 
                    let v562 : US9 option = None
                    let _v562 = ref v562 
                    match v491 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v563 : US4 = x
                    let v564 : US9 = US9_0(v563)
                    v564 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v562.Value <- x
                    let v565 : US9 option = _v562.Value 
                    let v588 : US9 = US9_1
                    let v589 : US9 = v565 |> Option.defaultValue v588 
                    match v589 with
                    | US9_0(v597) -> (* Some *)
                        match v597 with
                        | US4_0(v598) -> (* Some *)
                            US4_0(v598)
                        | _ ->
                            US4_1
                    | _ ->
                        US4_1
            let v607 : string = $"%A{v604}"
            let v614 : string = "state_core.use_core_database (6) / effect core_state_heap / ##3 / core_state_heap: " + v607 + ""
            let v615 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v616 : bool = Fable.Core.RustInterop.emitRustExpr v614 v615 
            match v604 with
            | US4_0(v617) -> (* Some *)
                let v618 : string = "true; leptos::batch(move || $0());"
                let v619 : (unit -> unit) = closure24(v0, v617)
                let v620 : bool = Fable.Core.RustInterop.emitRustExpr v619 v618 
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
and method36 () : string =
    let v0 : string = "core-state-heap"
    v0
and method37 (v0 : Result<unit, rexie_Error>) : Result<unit, rexie_Error> =
    v0
and closure31 () () : US17 =
    US17_0
and closure32 () (v0 : rexie_Error) : US17 =
    US17_1(v0)
and method38 () : unit =
    ()
and closure30 (v0 : leptos_Resource<US2, rexie_Rexie>) (v1 : Heap3) : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> =
    let v4 : string = $"%A{v1}"
    let v11 : string = $"leptos::SignalGet::get(&$0)"
    let v12 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let v15 : US5 option = None
    let _v15 = ref v15 
    match v12 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v16 : rexie_Rexie = x
    let v17 : US5 = US5_0(v16)
    v17 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v15.Value <- x
    let v18 : US5 option = _v15.Value 
    let v41 : US5 = US5_1
    let v42 : US5 = v18 |> Option.defaultValue v41 
    let v50 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    match v42 with
    | US5_1 -> (* None *)
        let v106 : string = "state_core.use_core_database (13) / set_core_state_heap_action / database=None"
        let v107 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
        ()
    | US5_0(v51) -> (* Some *)
        let v52 : string = "state_core.use_core_database (12) / set_core_state_heap_action / value: " + string v4 + ""
        let v53 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v54 : bool = Fable.Core.RustInterop.emitRustExpr v52 v53 
        let v57 : string = $"%A{v1}"
        let v64 : int64 = System.Convert.ToInt64 v57.Length
        let v65 : string = "state_core.set_data () / data_len: " + string v64 + ""
        let v66 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v67 : bool = Fable.Core.RustInterop.emitRustExpr v65 v66 
        let v68 : string = "let __result = Box::pin(async move { //"
        Fable.Core.RustInterop.emitRustExpr () v68 
        let v69 : string = "$0.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
        let v70 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v51 v69 
        let v71 : string = "v70.store(\"store\")?"
        let v72 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v71 
        let v73 : string = "true; let mut data = Vec::new()"
        let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
        let v75 : string = "true; borsh::BorshSerialize::serialize(&$0, &mut data).unwrap()"
        let v76 : bool = Fable.Core.RustInterop.emitRustExpr v1 v75 
        let v77 : string = "data"
        let v78 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v77 
        let v79 : string = "serde_wasm_bindgen::to_value(&v78).unwrap()"
        let v80 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v79 
        let v81 : string = method36()
        let v82 : string = "&*$0"
        let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v81 v82 
        let v84 : string = "true; v72.put(&v80, Some(&v83.into())).await?"
        let v85 : bool = Fable.Core.RustInterop.emitRustExpr () v84 
        let v86 : string = "true; v70.done().await?"
        let v87 : bool = Fable.Core.RustInterop.emitRustExpr () v86 
        let v88 : Result<unit, rexie_Error> = Ok () 
        let v89 : Result<unit, rexie_Error> = method37(v88)
        let v90 : string = ""
        let v91 : string = "}"
        let v92 : string = v90 + v91 
        let v93 : string = v92 + v91 
        let v94 : string = "{"
        let v95 : string = v90 + v94 
        let v96 : string = "v89 " + v93 + "); " + v95 + " //"
        Fable.Core.RustInterop.emitRustExpr () v96 
        let v97 : string = "__result"
        let v98 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v97 
        let v99 : string = "v98.await"
        let v100 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v99 
        let v101 : (unit -> US17) = closure31()
        let v102 : (rexie_Error -> US17) = closure32()
        let v103 : US17 = match v100 with Ok () -> v101 () | Error x -> v102 x
        match v103 with
        | US17_1(v104) -> (* Error *)
            let v105 : string = $"resultm.get / Result value was Error: {v104}"
            failwith<unit> v105
        | US17_0 -> (* Ok *)
            ()
    method38()
    let v109 : string = ""
    let v110 : string = "}"
    let v111 : string = v109 + v110 
    let v112 : string = v111 + v110 
    let v113 : string = "{"
    let v114 : string = v109 + v113 
    let v115 : string = "() " + v112 + "); " + v114 + " //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "__result"
    let v117 : std_pin_Pin<Box<Dyn<std_future_Future<unit>>>> = Fable.Core.RustInterop.emitRustExpr () v116 
    v117
and method39 (v0 : std_string_String) : std_string_String =
    v0
and closure34 () (v0 : bool) : bool =
    let v1 : string = "state_core.use_core_database (17) / effect new_core_state_heap / set_loaded |> signal_update true"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2 
    true
and method40 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method41 () : string =
    let v0 : string = "core-state-heap"
    v0
and method42 (v0 : Heap3) : Heap3 =
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
    let v18 : leptos_RwSignal<bool> = v17.l1
    let v19 : string = $"leptos::SignalGet::get(&$0)"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v22 : Heap1 = Fable.Core.RustInterop.emitRustExpr v10 v21 
    let v23 : leptos_RwSignal<std_string_String> = v22.l2
    let v24 : string = $"leptos::SignalGet::get(&$0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v27 : Heap1 = Fable.Core.RustInterop.emitRustExpr v10 v26 
    let v28 : leptos_RwSignal<Heap0> = v27.l3
    let v29 : string = $"leptos::SignalGet::get(&$0)"
    let v30 : Heap0 = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : Heap3 = {l0 = v15; l1 = v20; l2 = v25; l3 = v30} : Heap3
    let v34 : string = $"%A{v31}"
    let v41 : string = "state_core.use_core_database (15) / effect new_core_state_heap / ##2 / new_core_state_heap: " + string v34 + ""
    let v42 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = $"$0()"
    let v45 : std_collections_HashMap<std_string_String, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr v1 v44 
    let v46 : string = "&*$0"
    let v47 : string = "dark_mode_key"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v46 
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : std_string_String = method39(v50)
    let v52 : string = "std::collections::HashMap::get(&$0, &v51).map(|x| x).cloned()"
    let v53 : leptos_RwSignal<bool> option = Fable.Core.RustInterop.emitRustExpr v45 v52 
    let v56 : US18 option = None
    let _v56 = ref v56 
    match v53 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : leptos_RwSignal<bool> = x
    let v58 : US18 = US18_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US18 option = _v56.Value 
    let v82 : US18 = US18_1
    let v83 : US18 = v59 |> Option.defaultValue v82 
    let v97 : US19 =
        match v83 with
        | US18_1 -> (* None *)
            US19_1
        | US18_0(v91) -> (* Some *)
            let v92 : string = $"leptos::SignalGet::get(&$0)"
            let v93 : bool = Fable.Core.RustInterop.emitRustExpr v91 v92 
            US19_0(v93)
    let v100 : bool =
        match v97 with
        | US19_1 -> (* None *)
            false
        | US19_0(v98) -> (* Some *)
            v98
    let v101 : string = "state_core.use_core_database (16) / effect new_core_state_heap / ##3 / dark_mode_loading: " + string v100 + ""
    let v102 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : bool = v100 = false
    if v104 then
        let v105 : bool = v6 = false
        if v105 then
            let v106 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
            let v107 : (bool -> bool) = closure34()
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v107) v106 
            ()
        else
            let v109 : string = "state_core.use_core_database (18) / effect new_core_state_heap / ##4"
            let v110 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v111 : bool = Fable.Core.RustInterop.emitRustExpr v109 v110 
            let v112 : web_sys_Window = method29()
            let v113 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method30(v112)
            let v114 : (web_sys_Storage option -> US10) = closure19()
            let v115 : (wasm_bindgen_JsValue -> US10) = closure20()
            let v116 : US10 = match v113 with Ok x -> v114 x | Error x -> v115 x
            let v159 : US11 =
                match v116 with
                | US10_1(v156) -> (* Error *)
                    US11_1(v156)
                | US10_0(v117) -> (* Ok *)
                    let v120 : US12 option = None
                    let _v120 = ref v120 
                    match v117 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v121 : web_sys_Storage = x
                    let v122 : US12 = US12_0(v121)
                    v122 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v120.Value <- x
                    let v123 : US12 option = _v120.Value 
                    let v146 : US12 = US12_1
                    let v147 : US12 = v123 |> Option.defaultValue v146 
                    US11_0(v147)
            match v159 with
            | US11_0(v160) -> (* Ok *)
                match v160 with
                | US12_0(v161) -> (* Some *)
                    let v162 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
                    let v163 : bool = Fable.Core.RustInterop.emitRustExpr struct (v4, v31) v162 
                    let v164 : web_sys_Storage = method40(v161)
                    let v165 : string = method41()
                    let v166 : string = "&*$0"
                    let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v165 v166 
                    let v168 : Heap3 = method42(v31)
                    let v169 : string = "serde_json::json!(v168).to_string()"
                    let v170 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v169 
                    let v171 : string = "$0.as_str()"
                    let v172 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v170 v171 
                    let v173 : string = $"web_sys::Storage::set(&v164, v167, v172).unwrap()"
                    Fable.Core.RustInterop.emitRustExpr () v173 
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
and method43 (v0 : Heap2) : (unit -> bool) =
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
and method45 (v0 : std_string_String) : std_string_String =
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
        let v19 : std_string_String = method45(v11)
        let v20 : string = "v19 == \"\""
        let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
        if v21 then
            let v22 : leptos_RwSignal<Heap1> = v3.l0
            let v23 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v24 : Heap1 = Fable.Core.RustInterop.emitRustExpr v22 v23 
            let v25 : leptos_RwSignal<std_string_String> = v24.l2
            let v26 : string = $"leptos::SignalGet::get(&$0)"
            let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26 
            let v28 : string = "fable_library_rust::String_::fromString($0)"
            let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
            let v30 : string = "content.render () / effect 1 / url_hash: " + v29 + ""
            let v31 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v32 : bool = Fable.Core.RustInterop.emitRustExpr v30 v31 
            let v35 : string = "#"
            let v36 : bool = v29.Contains v35 
            if v36 then
                let v43 : string = "&*$0"
                let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v29 v43 
                let v45 : string = "$0(v44, Default::default())"
                Fable.Core.RustInterop.emitRustExpr v1 v45 
                ()
        let v46 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v47 : bool = Fable.Core.RustInterop.emitRustExpr struct (v4, true) v46 
        ()
    else
        let v48 : leptos_RwSignal<Heap1> = v3.l0
        let v49 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
        let v50 : Heap1 = Fable.Core.RustInterop.emitRustExpr v48 v49 
        let v51 : leptos_RwSignal<std_string_String> = v50.l2
        let v52 : string = "&*$0"
        let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v52 
        let v54 : string = "String::from($0)"
        let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54 
        let v56 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v57 : bool = Fable.Core.RustInterop.emitRustExpr struct (v51, v55) v56 
        ()
and method46 (v0 : std_string_String) : std_string_String =
    v0
and closure40 () (v0 : leptos_router_Url) : US22 =
    US22_0(v0)
and closure41 () (v0 : std_string_String) : US22 =
    US22_1(v0)
and method47 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure39 (v0 : leptos_router_Location, v1 : leptos_WriteSignal<US20>) () : unit =
    let v2 : string = "$0.hash"
    let v3 : leptos_Memo<std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = $"$0()"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : std_string_String = method46(v5)
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
    let v21 : bool = true
    let mutable _v21 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = "format!(\"{:#?}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = "format!(\"{:#?}\", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v24 
    v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = "format!(\"{:#?}\", $0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v26 
    v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : std_string_String = null |> unbox<std_string_String>
    v39 
    #endif
#else
    let v48 : std_string_String = null |> unbox<std_string_String>
    v48 
    #endif
    |> fun x -> _v21 <- Some x
    let v55 : std_string_String = match _v21 with Some x -> x | None -> failwith "base.run_target / _v21=None"
    let v70 : string = "content.render () / effect 2 / hash_url: " + string v55 + ""
    let v71 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v72 : bool = Fable.Core.RustInterop.emitRustExpr v70 v71 
    match v18 with
    | US22_1(v172) -> (* Error *)
        let v173 : string = "content.render () / effect 2 / hash_url error: " + string v172 + ""
        let v174 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v175 : bool = Fable.Core.RustInterop.emitRustExpr v173 v174 
        ()
    | US22_0(v73) -> (* Ok *)
        let v74 : US21 = US21_0
        let v75 : US20 = US20_1(v74)
        let v76 : US20 = US20_2
        let v77 : US20 = US20_3
        let v78 : US20 = US20_4
        let v79 : (US20 []) = [|v75; v76; v77; v78|]
        let v80 : int32 = v79.Length
        let v81 : US23 = US23_1
        let v82 : Mut0 = {l0 = 0; l1 = v81} : Mut0
        while method47(v80, v82) do
            let v84 : int32 = v82.l0
            let v85 : US23 = v82.l1
            let v86 : US20 = v79.[int v84]
            let v109 : US23 =
                match v85 with
                | US23_1 -> (* None *)
                    let v98 : string =
                        match v86 with
                        | US20_0 -> (* Blank *)
                            v9
                        | US20_1(v89) -> (* Dice *)
                            let v90 : string = "dice"
                            v90
                        | US20_2 -> (* Lists *)
                            let v91 : string = "lists"
                            v91
                        | US20_4 -> (* Settings *)
                            let v93 : string = "settings"
                            v93
                        | US20_3 -> (* Transactions *)
                            let v92 : string = "transactions"
                            v92
                    let v99 : string = "$0.pathname"
                    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v73 v99 
                    let v101 : string = "fable_library_rust::String_::fromString($0)"
                    let v102 : string = Fable.Core.RustInterop.emitRustExpr v100 v101 
                    let v103 : string = "/" + v98 + ""
                    let v104 : bool = v102.StartsWith v103 
                    if v104 then
                        US23_0(v86)
                    else
                        US23_1
                | US23_0(v87) -> (* Some *)
                    US23_0(v87)
            let v110 : int32 = v84 + 1
            v82.l0 <- v110
            v82.l1 <- v109
            ()
        let v111 : US23 = v82.l1
        let v112 : US20 = v79.[int 0]
        let v115 : US20 =
            match v111 with
            | US23_1 -> (* None *)
                v112
            | US23_0(v113) -> (* Some *)
                v113
        let v118 : bool = true
        let mutable _v118 : std_string_String option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v119 : string = "format!(\"{:#?}\", $0)"
        let v120 : std_string_String = Fable.Core.RustInterop.emitRustExpr v115 v119 
        v120 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v121 : string = "format!(\"{:#?}\", $0)"
        let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr v115 v121 
        v122 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v123 : string = "format!(\"{:#?}\", $0)"
        let v124 : std_string_String = Fable.Core.RustInterop.emitRustExpr v115 v123 
        v124 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v127 : std_string_String = null |> unbox<std_string_String>
        v127 
        #endif
#if FABLE_COMPILER_PYTHON
        let v136 : std_string_String = null |> unbox<std_string_String>
        v136 
        #endif
#else
        let v145 : std_string_String = null |> unbox<std_string_String>
        v145 
        #endif
        |> fun x -> _v118 <- Some x
        let v152 : std_string_String = match _v118 with Some x -> x | None -> failwith "base.run_target / _v118=None"
        let v167 : string = "content.render () / effect 2 / new_tab: " + string v152 + ""
        let v168 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
        let v169 : bool = Fable.Core.RustInterop.emitRustExpr v167 v168 
        let v170 : string = $"true; leptos::SignalSet::set(&$0, $1);"
        let v171 : bool = Fable.Core.RustInterop.emitRustExpr struct (v1, v115) v170 
        ()
and closure46 () (v0 : (bool * std_string_String)) : struct (bool * std_string_String) =
    let (a, b) = v0 
    let v3 : bool = a
    let v4 : std_string_String = b
    struct (v3, v4)
and closure47 () struct (v0 : bool, v1 : std_string_String) : bool =
    v0
and method51 () : (struct (bool * std_string_String) -> bool) =
    closure47()
and method52 (v0 : Vec<struct (bool * std_string_String)>) : Vec<struct (bool * std_string_String)> =
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
    let v4 : leptos_RwSignal<Heap0> = v3.l3
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : Vec<(bool * std_string_String)> = v6.l0
    let v8 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v9 : ((bool * std_string_String) -> struct (bool * std_string_String)) = closure46()
    let v10 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8 
    let v11 : (struct (bool * std_string_String) -> bool) = method51()
    let v12 : Vec<struct (bool * std_string_String)> = method52(v10)
    let v13 : string = "v12.into_iter().filter(|x| v11(x.clone().clone())).collect::<Vec<_>>()"
    let v14 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v16 : (struct (bool * std_string_String) -> std_string_String) = closure48()
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (std_string_String -> string) = closure49()
    let v20 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v23 : string = $"%A{v20}"
    let v30 : string = "use_transactions.render (2) / accounts create_memo / result: " + string v23 + ""
    let v31 : int64 = 200L
    let v32 : string = method8(v31, v30)
    let v33 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v34 : bool = Fable.Core.RustInterop.emitRustExpr v32 v33 
    v20
and closure51 () (v0 : string) : struct (string * US25 * string * bool * bool) =
    let v1 : string = "https://api3.nearblocks.io/v1/account/" + v0 + ""
    let v2 : US25 = US25_0
    let v3 : string = ""
    struct (v1, v2, v3, false, true)
and closure50 (v0 : leptos_Memo<Vec<string>>) () : (struct (string * US25 * string * bool * bool) []) =
    let v1 : string = $"$0()"
    let v2 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : (string -> struct (string * US25 * string * bool * bool)) = closure51()
    let v5 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct (string * US25 * string * bool * bool) []) = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v10 : string = $"%A{v7}"
    let v17 : string = "use_transactions.render (3) / accounts_metadata create_memo / result: " + string v10 + ""
    let v18 : int64 = 200L
    let v19 : string = method8(v18, v17)
    let v20 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v19 v20 
    v7
and method53 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure54 (v0 : string) (v1 : int32) : struct (string * US25 * string * bool * bool) =
    let v2 : int32 = v1 + 1
    let v3 : string = "https://api3.nearblocks.io/v1/account/" + v0 + "/txns?&order=desc&page=" + string v2 + "&per_page=" + string 25 + ""
    let v4 : US25 = US25_0
    let v5 : string = ""
    struct (v3, v4, v5, false, true)
and closure53 (v0 : Heap0) (v1 : string) : struct (string * Vec<struct (string * US25 * string * bool * bool)>) =
    let v2 : int32 = v0.l3
    let v3 : (int32 []) = Array.zeroCreate<int32> (v2)
    let v4 : Mut1 = {l0 = 0} : Mut1
    while method53(v2, v4) do
        let v6 : int32 = v4.l0
        v3.[int v6] <- v6
        let v7 : int32 = v6 + 1
        v4.l0 <- v7
        ()
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<int32> = Fable.Core.RustInterop.emitRustExpr v3 v8 
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v11 : (int32 -> struct (string * US25 * string * bool * bool)) = closure54(v1)
    let v12 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10 
    struct (v1, v12)
and closure52 (v0 : Heap2, v1 : leptos_Memo<Vec<string>>) () : Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)> =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : leptos_RwSignal<Heap0> = v4.l3
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = $"$0()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1 v8 
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v11 : (string -> struct (string * Vec<struct (string * US25 * string * bool * bool)>)) = closure53(v7)
    let v12 : Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10 
    let v15 : string = $"%A{v12}"
    let v22 : string = "use_transactions.render (4) / accounts_requests create_memo / result: " + string v15 + ""
    let v23 : int64 = 200L
    let v24 : string = method8(v23, v22)
    let v25 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v12
and closure56 () struct (v0 : string, v1 : Vec<struct (string * US25 * string * bool * bool)>) : Vec<struct (string * US25 * string * bool * bool)> =
    v1
and method54 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method55 (v0 : Vec<struct (string * US25 * string * bool * bool)>) : Vec<struct (string * US25 * string * bool * bool)> =
    v0
and method56 (v0 : Vec<struct (string * US25 * string * bool * bool)>) : Vec<struct (string * US25 * string * bool * bool)> =
    v0
and closure55 (v0 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>>) () : Vec<struct (string * US25 * string * bool * bool)> =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : (struct (string * Vec<struct (string * US25 * string * bool * bool)>) -> Vec<struct (string * US25 * string * bool * bool)>) = closure56()
    let v5 : Vec<Vec<struct (string * US25 * string * bool * bool)>> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : (struct (string * US25 * string * bool * bool) []) = [||]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : (Vec<struct (string * US25 * string * bool * bool)> []) = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let v11 : int32 = v10.Length
    let v12 : Mut2 = {l0 = 0; l1 = v8} : Mut2
    while method54(v11, v12) do
        let v14 : int32 = v12.l0
        let v15 : Vec<struct (string * US25 * string * bool * bool)> = v12.l1
        let v16 : Vec<struct (string * US25 * string * bool * bool)> = v10.[int v14]
        let v17 : Vec<struct (string * US25 * string * bool * bool)> = method55(v16)
        let v18 : Vec<struct (string * US25 * string * bool * bool)> = method56(v15)
        let v19 : string = "true; let mut v18 = v18"
        let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19 
        let v21 : string = "true; v18.extend(v17)"
        let v22 : bool = Fable.Core.RustInterop.emitRustExpr () v21 
        let v23 : string = "v18"
        let v24 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr () v23 
        let v25 : int32 = v14 + 1
        v12.l0 <- v25
        v12.l1 <- v24
        ()
    let v26 : Vec<struct (string * US25 * string * bool * bool)> = v12.l1
    let v29 : string = $"%A{v26}"
    let v36 : string = "use_transactions.render (5) / txns_requests create_memo / result: " + string v29 + ""
    let v37 : int64 = 200L
    let v38 : string = method8(v37, v36)
    let v39 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v40 : bool = Fable.Core.RustInterop.emitRustExpr v38 v39 
    v26
and closure59 (v0 : string) struct (v1 : string, v2 : US25, v3 : string, v4 : bool, v5 : bool) : string =
    v0
and closure58 () struct (v0 : string, v1 : Vec<struct (string * US25 * string * bool * bool)>) : Vec<string> =
    let v2 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v3 : (struct (string * US25 * string * bool * bool) -> string) = closure59(v0)
    let v4 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v1, v3) v2 
    v4
and method57 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method58 (v0 : Vec<string>) : Vec<string> =
    v0
and method59 (v0 : Vec<string>) : Vec<string> =
    v0
and closure57 (v0 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>>) () : (string []) =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : (struct (string * Vec<struct (string * US25 * string * bool * bool)>) -> Vec<string>) = closure58()
    let v5 : Vec<Vec<string>> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : (string []) = [||]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v10 : (Vec<string> []) = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let v11 : int32 = v10.Length
    let v12 : Mut3 = {l0 = 0; l1 = v8} : Mut3
    while method57(v11, v12) do
        let v14 : int32 = v12.l0
        let v15 : Vec<string> = v12.l1
        let v16 : Vec<string> = v10.[int v14]
        let v17 : Vec<string> = method58(v16)
        let v18 : Vec<string> = method59(v15)
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
    let v31 : string = $"%A{v28}"
    let v38 : string = "use_transactions.render (6) / urls_accounts create_memo / result: " + string v31 + ""
    let v39 : int64 = 200L
    let v40 : string = method8(v39, v38)
    let v41 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr v40 v41 
    v28
and closure62 () (v0 : crate_model_near_nearblocks_Action) : struct (std_string_String * std_string_String option) =
    let v1 : string = "$0.action"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.method"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3 
    struct (v2, v4)
and method60 (v0 : (struct (std_string_String * std_string_String option) [])) : (struct (std_string_String * std_string_String option) []) =
    v0
and closure61 () (v0 : crate_model_near_nearblocks_Txn) : struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) =
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
    let v19 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v20 : (crate_model_near_nearblocks_Action -> struct (std_string_String * std_string_String option)) = closure62()
    let v21 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19 
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (struct (std_string_String * std_string_String option) []) = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : (struct (std_string_String * std_string_String option) []) = method60(v23)
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
    let v41 : (std_string_String []) option = None
    let _v41 = ref v41 
    match v38 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v42 : Vec<std_string_String> = x
    let v43 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v44 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v42 v43 
    v44 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v41.Value <- x
    let v45 : (std_string_String []) option = _v41.Value 
    let v67 : (std_string_String []) = [||]
    let v70 : (std_string_String []) = v45 |> Option.defaultValue v67 
    struct (v2, v4, v6, v8, v10, v12, v16, v24, v28, v32, v36, v70)
and method61 (v0 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) [])) : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) =
    v0
and closure60 () (v0 : crate_model_near_nearblocks_Root) : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) =
    let v1 : string = "$0.txns"
    let v2 : Vec<crate_model_near_nearblocks_Txn> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : (crate_model_near_nearblocks_Txn -> struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))) = closure61()
    let v5 : Vec<struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) = method61(v7)
    v8
and closure63 (v0 : leptos_Resource<US2, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : string = "state_core.use_requests (2) / database_memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5
and closure64 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Resource<US2, rexie_Rexie>) () : struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>) =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = $"$0()"
    let v5 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    struct (v3, v5)
and method67 (v0 : Result<Heap4 option, std_string_String>) : Result<Heap4 option, std_string_String> =
    v0
and method66 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    let v2 : string = "state_core.get_data () / id: " + v0 + ""
    let v3 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = "store"
    let v7 : (string []) = [|v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v11 : (string -> std_string_String) = closure9()
    let v12 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10 
    let v13 : rexie_Rexie = method15(v1)
    let v14 : string = "v13.transaction(&v12, rexie::TransactionMode::ReadOnly)"
    let v15 : Result<rexie_Transaction, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : (rexie_Error -> std_string_String) = method16()
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<rexie_Transaction, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let v19 : string = "$0?"
    let v20 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = method17()
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "v20.store(v23)"
    let v25 : Result<rexie_Store, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : (rexie_Error -> std_string_String) = method18()
    let v27 : string = "$0.map_err(|x| $1(x))"
    let v28 : Result<rexie_Store, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v25, v26) v27 
    let v29 : string = "$0?"
    let v30 : rexie_Store = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : string = method19(v0)
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "wasm_bindgen::JsValue::from_str(v33)"
    let v35 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"Box::pin(rexie::Store::get(&v30, &v35))"
    let v37 : std_pin_Pin<Box<Dyn<std_future_Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "v37.await"
    let v39 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : (rexie_Error -> std_string_String) = method20()
    let v41 : string = "$0.map_err(|x| $1(x))"
    let v42 : Result<wasm_bindgen_JsValue, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v39, v40) v41 
    let v43 : string = "$0?"
    let v44 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let v45 : wasm_bindgen_JsValue = method21(v44)
    let v46 : string = "serde_wasm_bindgen::from_value(v45)"
    let v47 : Result<serde_json_Value option, serde_wasm_bindgen_Error> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : (serde_wasm_bindgen_Error -> std_string_String) = method22()
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<serde_json_Value option, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49 
    let v51 : string = "$0?"
    let v52 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v55 : US7 option = None
    let _v55 = ref v55 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v56 : serde_json_Value = x
    let v57 : US7 = US7_0(v56)
    v57 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v55.Value <- x
    let v58 : US7 option = _v55.Value 
    let v81 : US7 = US7_1
    let v82 : US7 = v58 |> Option.defaultValue v81 
    let v121 : US27 =
        match v82 with
        | US7_1 -> (* None *)
            US27_1
        | US7_0(v90) -> (* Some *)
            let v91 : serde_json_Value = method23(v90)
            let v92 : string = "serde_json::from_value(v91)"
            let v93 : Result<Vec<uint8>, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v92 
            let v94 : (serde_json_Error -> std_string_String) = method24()
            let v95 : string = "$0.map_err(|x| $1(x))"
            let v96 : Result<Vec<uint8>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v93, v94) v95 
            let v97 : string = "$0?"
            let v98 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v96 v97 
            let v99 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v100 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v98 v99 
            let v101 : int32 = v100.Length
            let v102 : string = "state_core.get_data () / data_len: " + string v101 + ""
            let v103 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v104 : bool = Fable.Core.RustInterop.emitRustExpr v102 v103 
            let v105 : string = "$0.to_vec()"
            let v106 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v100 v105 
            let v107 : string = "v106.as_slice()"
            let v108 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v107 
            let v109 : string = "true; let mut v108 = v108"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
            let v111 : string = "borsh::BorshDeserialize::deserialize(&mut v108)"
            let v112 : Result<Heap4, borsh_io_Error> = Fable.Core.RustInterop.emitRustExpr () v111 
            let v113 : (borsh_io_Error -> std_string_String) = method25()
            let v114 : string = "$0.map_err(|x| $1(x))"
            let v115 : Result<Heap4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v112, v113) v114 
            let v116 : string = "$0?"
            let v117 : Heap4 = Fable.Core.RustInterop.emitRustExpr v115 v116 
            US27_0(v117)
    let v134 : Heap4 option =
        match v121 with
        | US27_1 -> (* None *)
            let v132 : Heap4 option = None
            v132
        | US27_0(v122) -> (* Some *)
            let v125 : Heap4 option = Some v122 
            v125
    let v135 : Result<Heap4 option, std_string_String> = Ok v134 
    let v136 : Result<Heap4 option, std_string_String> = method67(v135)
    let v137 : string = ""
    let v138 : string = "}"
    let v139 : string = v137 + v138 
    let v140 : string = v139 + v138 
    let v141 : string = v140 + v138 
    let v142 : string = "{"
    let v143 : string = v137 + v142 
    let v144 : string = v143 + v142 
    let v145 : string = "v136 " + v141 + "); " + v144 + " //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "__result"
    let v147 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v146 
    v147
and method65 (v0 : string, v1 : rexie_Rexie) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    method66(v0, v1)
and closure66 () (v0 : Heap4 option) : US26 =
    US26_0(v0)
and closure67 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and closure65 (v0 : rexie_Rexie option) struct (v1 : string, v2 : US25, v3 : string, v4 : bool, v5 : bool) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> =
    let v6 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v9 : US5 option = None
    let _v9 = ref v9 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : rexie_Rexie = x
    let v11 : US5 = US5_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US5 option = _v9.Value 
    let v35 : US5 = US5_1
    let v36 : US5 = v12 |> Option.defaultValue v35 
    let v58 : US26 =
        match v36 with
        | US5_0(v44) -> (* Some *)
            let v45 : string = "url[" + v1 + "](" + $"%A{v3}" + ")"
            let v46 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = method65(v45, v44)
            let v47 : string = "v46.await"
            let v48 : Result<Heap4 option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v47 
            let v49 : (Heap4 option -> US26) = closure66()
            let v50 : (std_string_String -> US26) = closure67()
            let v51 : US26 = match v48 with Ok x -> v49 x | Error x -> v50 x
            v51
        | _ ->
            let v52 : string = "&*$0"
            let v53 : string = "database=None"
            let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v52 
            let v55 : string = "String::from($0)"
            let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v55 
            US26_1(v56)
    let v64 : Result<Heap4 option, std_string_String> =
        match v58 with
        | US26_1(v61) -> (* Error *)
            let v62 : Result<Heap4 option, std_string_String> = Error v61 
            v62
        | US26_0(v59) -> (* Ok *)
            let v60 : Result<Heap4 option, std_string_String> = Ok v59 
            v60
    let v65 : Result<Heap4 option, std_string_String> = method67(v64)
    let v66 : string = ""
    let v67 : string = "}"
    let v68 : string = v66 + v67 
    let v69 : string = v68 + v67 
    let v70 : string = v69 + v67 
    let v71 : string = "{"
    let v72 : string = v66 + v71 
    let v73 : string = v72 + v71 
    let v74 : string = "v65 " + v70 + "); " + v73 + " //"
    Fable.Core.RustInterop.emitRustExpr () v74 
    let v75 : string = "__result"
    let v76 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v75 
    v76
and method68 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> =
    v0
and method69 (v0 : Result<Vec<Heap4 option>, std_string_String>) : Result<Vec<Heap4 option>, std_string_String> =
    v0
and method64 (v0 : Vec<struct (string * US25 * string * bool * bool)>, v1 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v5 : string = $"%A{v1}"
    let v14 : string = $"%A{v0}"
    let v21 : int64 = 400L
    let v22 : string = method8(v21, v14)
    let v23 : string = "state_core.use_requests (3) / state_data_resource create_local_resource / request : " + string v22 + " / database: " + string v5 + ""
    let v24 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v27 : (struct (string * US25 * string * bool * bool) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>) = closure65(v1)
    let v28 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v0, v27) v26 
    let v29 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = method68(v28)
    let v30 : string = "futures::future::try_join_all(v29)"
    let v31 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<Heap4 option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "v31.await"
    let v33 : Result<Vec<Heap4 option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "$0?"
    let v35 : Vec<Heap4 option> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : Result<Vec<Heap4 option>, std_string_String> = Ok v35 
    let v39 : string = $"%A{v36}"
    let v46 : string = "state_core.use_requests (4) / state_data_resource create_local_resource / result: " + string v39 + ""
    let v47 : int64 = 200L
    let v48 : string = method8(v47, v46)
    let v49 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v50 : bool = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : Result<Vec<Heap4 option>, std_string_String> = method69(v36)
    let v52 : string = ""
    let v53 : string = "}"
    let v54 : string = v52 + v53 
    let v55 : string = v54 + v53 
    let v56 : string = "{"
    let v57 : string = v52 + v56 
    let v58 : string = "v51 " + v55 + "); " + v57 + " //"
    Fable.Core.RustInterop.emitRustExpr () v58 
    let v59 : string = "__result"
    let v60 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v59 
    v60
and method70 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> =
    v0
and method63 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Resource<US2, rexie_Rexie>) : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>> =
    let v2 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v3 : (unit -> struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>)) = closure64(v0, v1)
    Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v4 : string = "x"
    let struct (v5 : rexie_Rexie option, v6 : Vec<struct (string * US25 * string * bool * bool)>) = Fable.Core.RustInterop.emitRustExpr () v4 
    let v7 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = method64(v6, v5)
    let v8 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Heap4 option>, std_string_String>>>>> = method70(v7)
    let v9 : string = "v8.await"
    let v10 : Result<Vec<Heap4 option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : string = ""
    let v12 : string = "}"
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v12 
    let v15 : string = "{"
    let v16 : string = v11 + v15 
    let v17 : string = "v10 " + v14 + "); " + v16 + " //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "__result"
    let v19 : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v18 
    v19
and closure68 (v0 : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>>) () : Result<Vec<Heap4 option>, std_string_String> option =
    let v1 : string = "state_core.use_requests (5) / state_data_func"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : web_sys_Window = method29()
    let v5 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method30(v4)
    let v6 : (web_sys_Storage option -> US10) = closure19()
    let v7 : (wasm_bindgen_JsValue -> US10) = closure20()
    let v8 : US10 = match v5 with Ok x -> v6 x | Error x -> v7 x
    let v51 : US11 =
        match v8 with
        | US10_1(v48) -> (* Error *)
            US11_1(v48)
        | US10_0(v9) -> (* Ok *)
            let v12 : US12 option = None
            let _v12 = ref v12 
            match v9 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v13 : web_sys_Storage = x
            let v14 : US12 = US12_0(v13)
            v14 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v12.Value <- x
            let v15 : US12 option = _v12.Value 
            let v38 : US12 = US12_1
            let v39 : US12 = v15 |> Option.defaultValue v38 
            US11_0(v39)
    let v59 : Result<Vec<Heap4 option>, std_string_String> option =
        match v51 with
        | US11_0(v52) -> (* Ok *)
            match v52 with
            | US12_0(v53) -> (* Some *)
                let v54 : string = $"leptos::SignalGet::get(&$0)"
                let v55 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v0 v54 
                v55
            | _ ->
                let v56 : Result<Vec<Heap4 option>, std_string_String> option = None
                v56
        | _ ->
            let v58 : Result<Vec<Heap4 option>, std_string_String> option = None
            v58
    let v62 : string = $"%A{v59}"
    let v69 : string = "state_core.use_requests (6) / state_data_func func0 / result: " + string v62 + ""
    let v70 : int64 = 200L
    let v71 : string = method8(v70, v69)
    let v72 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v73 : bool = Fable.Core.RustInterop.emitRustExpr v71 v72 
    v59
and closure69 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Memo<Result<Vec<Heap4 option>, std_string_String> option>) () : struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option) =
    let v2 : string = $"$0()"
    let v3 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = $"$0()"
    let v5 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v4 
    struct (v3, v5)
and closure70 () (v0 : Vec<Heap4 option>) : US31 =
    US31_0(v0)
and closure71 () (v0 : std_string_String) : US31 =
    US31_1(v0)
and closure72 () (v0 : Heap4 option) : US27 =
    let v3 : US27 option = None
    let _v3 = ref v3 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : Heap4 = x
    let v5 : US27 = US27_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US27 option = _v3.Value 
    let v29 : US27 = US27_1
    let v30 : US27 = v6 |> Option.defaultValue v29 
    v30
and method74 (v0 : US25) : US25 =
    v0
and method75 (v0 : string) : string =
    v0
and method76 (v0 : std_string_String) : std_string_String =
    v0
and method77 (v0 : string) : string =
    v0
and method78 (v0 : std_string_String) : std_string_String =
    v0
and method79 (v0 : reqwest_RequestBuilder) : reqwest_RequestBuilder =
    v0
and method80 (v0 : reqwest_RequestBuilder) : reqwest_RequestBuilder =
    v0
and closure75 () (v0 : reqwest_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method81 () : (reqwest_Error -> std_string_String) =
    closure75()
and method82 (v0 : Result<string option, std_string_String>) : Result<string option, std_string_String> =
    v0
and closure74 (v0 : US29, v1 : int32) struct (v2 : string, v3 : US25, v4 : string, v5 : bool, v6 : bool) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v73 : US32 =
        match v0 with
        | US29_1 -> (* None *)
            US32_1
        | US29_0(v8) -> (* Some *)
            let v69 : US33 =
                match v8 with
                | US30_1(v66) -> (* Error *)
                    US33_1(v66)
                | US30_0(v9) -> (* Ok *)
                    let v10 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v11 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v9 v10 
                    let v12 : US27 option = v11 |> Array.tryItem v1 
                    let v15 : US35 option = None
                    let _v15 = ref v15 
                    match v12 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v16 : US27 = x
                    let v17 : US35 = US35_0(v16)
                    v17 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v15.Value <- x
                    let v18 : US35 option = _v15.Value 
                    let v41 : US35 = US35_1
                    let v42 : US35 = v18 |> Option.defaultValue v41 
                    let v56 : US27 =
                        match v42 with
                        | US35_0(v50) -> (* Some *)
                            match v50 with
                            | US27_0(v51) -> (* Some *)
                                US27_0(v51)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v64 : US34 =
                        match v56 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v57) -> (* Some *)
                            let v58 : std_string_String = v57.l0
                            let v59 : string = "fable_library_rust::String_::fromString($0)"
                            let v60 : string = Fable.Core.RustInterop.emitRustExpr v58 v59 
                            US34_0(v60)
                    US33_0(v64)
            US32_0(v69)
    let v76 : string = $"%A{struct (v3, v5, v6)}"
    let v83 : int64 = 400L
    let v84 : string = method8(v83, v76)
    let v87 : string = $"%A{v0}"
    let v94 : int64 = 400L
    let v95 : string = method8(v94, v87)
    let v98 : string = $"%A{v73}"
    let v105 : int64 = 400L
    let v106 : string = method8(v105, v98)
    let v131 : bool =
        if v6 then
            true
        else
            match v0 with
            | US29_0(v107) -> (* Some *)
                match v107 with
                | US30_0(v108) -> (* Ok *)
                    let v109 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v110 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v108 v109 
                    let v111 : int32 = v110.Length
                    let v112 : bool = v111 = 0
                    if v112 then
                        false
                    else
                        match v73 with
                        | US32_0(v113) -> (* Some *)
                            match v113 with
                            | US33_0(v114) -> (* Ok *)
                                match v114 with
                                | US34_1 -> (* None *)
                                    true
                                | _ ->
                                    false
                            | _ ->
                                false
                        | _ ->
                            false
                | _ ->
                    match v73 with
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
                match v73 with
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
    let v132 : string = "state_core.use_requests (9) / result memo / state_data: " + string v95 + " / state_data': " + string v106 + " / request: " + string v84 + " / should_fetch: " + string v131 + ""
    let v133 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v134 : bool = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let v135 : bool = v131 = false
    let v214 : US36 =
        if v135 then
            let v136 : string option = None
            US36_0(v136)
        else
            let v138 : US25 = method74(v3)
            let v156 : reqwest_RequestBuilder =
                match v138 with
                | US25_0 -> (* Get *)
                    let v139 : string = method75(v2)
                    let v140 : string = "&*$0"
                    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v139 v140 
                    let v142 : string = "String::from($0)"
                    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr v141 v142 
                    let v144 : std_string_String = method76(v143)
                    let v145 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.get(v144)"
                    let v146 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v145 
                    v146
                | US25_1 -> (* Post *)
                    let v147 : string = method77(v2)
                    let v148 : string = "&*$0"
                    let v149 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v147 v148 
                    let v150 : string = "String::from($0)"
                    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr v149 v150 
                    let v152 : std_string_String = method78(v151)
                    let v153 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.post(v152)"
                    let v154 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v153 
                    v154
            let v157 : string = "&*$0"
            let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v157 
            let v159 : string = "String::from($0)"
            let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v159 
            let v161 : string = "reqwest_wasm::RequestBuilder::body(v156, v160)"
            let v162 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v161 
            let v163 : bool = v5 = false
            let v182 : reqwest_RequestBuilder =
                if v163 then
                    let v164 : string = "v162"
                    let v165 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v164 
                    v165
                else
                    let v166 : string = "reqwest_wasm::header::CONTENT_TYPE.to_string()"
                    let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v166 
                    let v168 : string = "fable_library_rust::String_::fromString($0)"
                    let v169 : string = Fable.Core.RustInterop.emitRustExpr v167 v168 
                    let v170 : reqwest_RequestBuilder = method79(v162)
                    let v171 : string = "&*$0"
                    let v172 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v169 v171 
                    let v173 : string = "String::from($0)"
                    let v174 : std_string_String = Fable.Core.RustInterop.emitRustExpr v172 v173 
                    let v175 : string = "&*$0"
                    let v176 : string = "application/json"
                    let v177 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v176 v175 
                    let v178 : string = "String::from($0)"
                    let v179 : std_string_String = Fable.Core.RustInterop.emitRustExpr v177 v178 
                    let v180 : string = "reqwest_wasm::RequestBuilder::header(v170, v174, v179)"
                    let v181 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v180 
                    v181
            let v183 : reqwest_RequestBuilder = method80(v182)
            let v184 : string = "Box::pin(reqwest_wasm::RequestBuilder::send(v183))"
            let v185 : std_pin_Pin<Box<Dyn<std_future_Future<Result<reqwest_Response, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v184 
            let v186 : string = "v185.await"
            let v187 : Result<reqwest_Response, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v186 
            let v188 : (reqwest_Error -> std_string_String) = method81()
            let v189 : string = "$0.map_err(|x| $1(x))"
            let v190 : Result<reqwest_Response, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v187, v188) v189 
            let v191 : string = "$0?"
            let v192 : reqwest_Response = Fable.Core.RustInterop.emitRustExpr v190 v191 
            let v193 : string = "Box::pin(reqwest_wasm::Response::text(v192))"
            let v194 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_string_String, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v193 
            let v195 : string = "v194.await"
            let v196 : Result<std_string_String, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v195 
            let v197 : (reqwest_Error -> std_string_String) = method81()
            let v198 : string = "$0.map_err(|x| $1(x))"
            let v199 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v196, v197) v198 
            let v200 : string = "$0?"
            let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v199 v200 
            let v202 : string = "fable_library_rust::String_::fromString($0)"
            let v203 : string = Fable.Core.RustInterop.emitRustExpr v201 v202 
            let v206 : string option = Some v203 
            US36_0(v206)
    let v220 : Result<string option, std_string_String> =
        match v214 with
        | US36_1(v217) -> (* Error *)
            let v218 : Result<string option, std_string_String> = Error v217 
            v218
        | US36_0(v215) -> (* Ok *)
            let v216 : Result<string option, std_string_String> = Ok v215 
            v216
    let v221 : Result<string option, std_string_String> = method82(v220)
    let v222 : string = ""
    let v223 : string = "}"
    let v224 : string = v222 + v223 
    let v225 : string = v224 + v223 
    let v226 : string = "{"
    let v227 : string = v222 + v226 
    let v228 : string = "v221 " + v225 + "); " + v227 + " //"
    Fable.Core.RustInterop.emitRustExpr () v228 
    let v229 : string = "__result"
    let v230 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v229 
    v230
and closure73 (v0 : US29) (v1 : int32) : (struct (string * US25 * string * bool * bool) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>) =
    closure74(v0, v1)
and method73 (v0 : US29) : (int32 -> (struct (string * US25 * string * bool * bool) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>)) =
    closure73(v0)
and method83 (v0 : Vec<struct (string * US25 * string * bool * bool)>) : Vec<struct (string * US25 * string * bool * bool)> =
    v0
and method84 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> =
    v0
and method85 (v0 : Result<Vec<string option>, std_string_String>) : Result<Vec<string option>, std_string_String> =
    v0
and method72 (v0 : Result<Vec<Heap4 option>, std_string_String> option, v1 : Vec<struct (string * US25 * string * bool * bool)>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<string option>, std_string_String>>>>> =
    let v4 : string = $"%A{v1}"
    let v11 : int64 = 400L
    let v12 : string = method8(v11, v4)
    let v13 : string = "state_core.use_requests (7) / json create_local_resource / requests: " + string v12 + ""
    let v14 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v19 : US28 option = None
    let _v19 = ref v19 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v20 : Result<Vec<Heap4 option>, std_string_String> = x
    let v21 : US28 = US28_0(v20)
    v21 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v19.Value <- x
    let v22 : US28 option = _v19.Value 
    let v45 : US28 = US28_1
    let v46 : US28 = v22 |> Option.defaultValue v45 
    let v70 : US29 =
        match v46 with
        | US28_1 -> (* None *)
            US29_1
        | US28_0(v54) -> (* Some *)
            let v55 : (Vec<Heap4 option> -> US31) = closure70()
            let v56 : (std_string_String -> US31) = closure71()
            let v57 : US31 = match v54 with Ok x -> v55 x | Error x -> v56 x
            let v66 : US30 =
                match v57 with
                | US31_1(v63) -> (* Error *)
                    US30_1(v63)
                | US31_0(v58) -> (* Ok *)
                    let v59 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v60 : (Heap4 option -> US27) = closure72()
                    let v61 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v58, v60) v59 
                    US30_0(v61)
            US29_0(v66)
    let v73 : string = $"%A{v70}"
    let v80 : int64 = 400L
    let v81 : string = method8(v80, v73)
    let v82 : string = "state_core.use_requests (8) / result_memo / state_data: " + string v81 + ""
    let v83 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : (int32 -> (struct (string * US25 * string * bool * bool) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>)) = method73(v70)
    let v86 : Vec<struct (string * US25 * string * bool * bool)> = method83(v1)
    let v87 : string = "v86.iter().enumerate().map(|(i, x)| v85(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v88 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = method84(v88)
    let v90 : string = "futures::future::try_join_all(v89)"
    let v91 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<string option, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = "v91.await"
    let v93 : Result<Vec<string option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : string = "$0?"
    let v95 : Vec<string option> = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let v96 : Result<Vec<string option>, std_string_String> = Ok v95 
    let v97 : Result<Vec<string option>, std_string_String> = method85(v96)
    let v98 : string = ""
    let v99 : string = "}"
    let v100 : string = v98 + v99 
    let v101 : string = v100 + v99 
    let v102 : string = v101 + v99 
    let v103 : string = "{"
    let v104 : string = v98 + v103 
    let v105 : string = v104 + v103 
    let v106 : string = "v97 " + v102 + "); " + v105 + " //"
    Fable.Core.RustInterop.emitRustExpr () v106 
    let v107 : string = "__result"
    let v108 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<string option>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v107 
    v108
and method86 (v0 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<string option>, std_string_String>>>>>) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<string option>, std_string_String>>>>> =
    v0
and method71 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Memo<Result<Vec<Heap4 option>, std_string_String> option>) : leptos_Resource<struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option), Result<Vec<string option>, std_string_String>> =
    let v2 : string = "let __result = leptos::create_local_resource(move || $0(), |x| async move { //"
    let v3 : (unit -> struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option)) = closure69(v0, v1)
    Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v4 : string = "x"
    let struct (v5 : Vec<struct (string * US25 * string * bool * bool)>, v6 : Result<Vec<Heap4 option>, std_string_String> option) = Fable.Core.RustInterop.emitRustExpr () v4 
    let v7 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<string option>, std_string_String>>>>> = method72(v6, v5)
    let v8 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<string option>, std_string_String>>>>> = method86(v7)
    let v9 : string = "v8.await"
    let v10 : Result<Vec<string option>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : string = ""
    let v12 : string = "}"
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v12 
    let v15 : string = "{"
    let v16 : string = v11 + v15 
    let v17 : string = "v10 " + v14 + "); " + v16 + " //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "__result"
    let v19 : leptos_Resource<struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option), Result<Vec<string option>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v18 
    v19
and method87 (v0 : string) : string =
    v0
and closure78 () (v0 : rexie_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method88 () : (rexie_Error -> std_string_String) =
    closure78()
and method89 (v0 : Result<unit, std_string_String>) : Result<unit, std_string_String> =
    v0
and closure77 (v0 : Heap4, v1 : US5) struct (v2 : string, v3 : US25, v4 : string, v5 : bool, v6 : bool) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v68 : US37 =
        match v1 with
        | US5_0(v8) -> (* Some *)
            let v9 : string = "state_core.use_requests (11) / set_state_data_action / database=Some(_) / url: " + v2 + ""
            let v10 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
            let v12 : string = "url[" + v2 + "](" + $"%A{v4}" + ")"
            let v15 : string = $"%A{v0}"
            let v22 : int64 = System.Convert.ToInt64 v15.Length
            let v23 : string = "state_core.set_data () / data_len: " + string v22 + ""
            let v24 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v25 : bool = Fable.Core.RustInterop.emitRustExpr v23 v24 
            let v26 : string = "let __result = Box::pin(async move { //"
            Fable.Core.RustInterop.emitRustExpr () v26 
            let v27 : string = "$0.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
            let v28 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr v8 v27 
            let v29 : string = "v28.store(\"store\")?"
            let v30 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v29 
            let v31 : string = "true; let mut data = Vec::new()"
            let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : string = "true; borsh::BorshSerialize::serialize(&$0, &mut data).unwrap()"
            let v34 : bool = Fable.Core.RustInterop.emitRustExpr v0 v33 
            let v35 : string = "data"
            let v36 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v35 
            let v37 : string = "serde_wasm_bindgen::to_value(&v36).unwrap()"
            let v38 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v37 
            let v39 : string = method87(v12)
            let v40 : string = "&*$0"
            let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v39 v40 
            let v42 : string = "true; v30.put(&v38, Some(&v41.into())).await?"
            let v43 : bool = Fable.Core.RustInterop.emitRustExpr () v42 
            let v44 : string = "true; v28.done().await?"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
            let v46 : Result<unit, rexie_Error> = Ok () 
            let v47 : Result<unit, rexie_Error> = method37(v46)
            let v48 : string = ""
            let v49 : string = "}"
            let v50 : string = v48 + v49 
            let v51 : string = v50 + v49 
            let v52 : string = "{"
            let v53 : string = v48 + v52 
            let v54 : string = "v47 " + v51 + "); " + v53 + " //"
            Fable.Core.RustInterop.emitRustExpr () v54 
            let v55 : string = "__result"
            let v56 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v55 
            let v57 : string = "v56.await"
            let v58 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v57 
            let v59 : (rexie_Error -> std_string_String) = method88()
            let v60 : string = "$0.map_err(|x| $1(x))"
            let v61 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v58, v59) v60 
            let v62 : string = "$0?"
            Fable.Core.RustInterop.emitRustExpr v61 v62 
            US37_0
        | _ ->
            let v64 : string = "state_core.use_requests (12) / set_state_data_action / database,request=None"
            let v65 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v66 : bool = Fable.Core.RustInterop.emitRustExpr v64 v65 
            US37_0
    let v73 : Result<unit, std_string_String> =
        match v68 with
        | US37_1(v70) -> (* Error *)
            let v71 : Result<unit, std_string_String> = Error v70 
            v71
        | US37_0 -> (* Ok *)
            let v69 : Result<unit, std_string_String> = Ok () 
            v69
    let v74 : Result<unit, std_string_String> = method89(v73)
    let v75 : string = ""
    let v76 : string = "}"
    let v77 : string = v75 + v76 
    let v78 : string = v77 + v76 
    let v79 : string = "{"
    let v80 : string = v75 + v79 
    let v81 : string = "v74 " + v78 + "); " + v80 + " //"
    Fable.Core.RustInterop.emitRustExpr () v81 
    let v82 : string = "__result"
    let v83 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v82 
    v83
and method90 (v0 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>>) : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> =
    v0
and method91 (v0 : Result<Vec<unit>, std_string_String>) : Result<Vec<unit>, std_string_String> =
    v0
and closure76 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Memo<rexie_Rexie option>) (v2 : Heap4) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> =
    let v5 : string = $"%A{v2}"
    let v12 : int64 = System.Convert.ToInt64 v5.Length
    let v13 : string = "state_core.use_requests (10) / set_state_data_action / value_len: " + string v12 + ""
    let v14 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v18 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr v1 v17 
    let v21 : US5 option = None
    let _v21 = ref v21 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v22 : rexie_Rexie = x
    let v23 : US5 = US5_0(v22)
    v23 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v21.Value <- x
    let v24 : US5 option = _v21.Value 
    let v47 : US5 = US5_1
    let v48 : US5 = v24 |> Option.defaultValue v47 
    let v56 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v57 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v0 v56 
    let v58 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v59 : (struct (string * US25 * string * bool * bool) -> std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>) = closure77(v2, v48)
    let v60 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v57, v59) v58 
    let v61 : Vec<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = method90(v60)
    let v62 : string = "futures::future::try_join_all(v61)"
    let v63 : futures_future_TryJoinAll<std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>>> = Fable.Core.RustInterop.emitRustExpr () v62 
    let v64 : string = "v63.await"
    let v65 : Result<Vec<unit>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = "$0?"
    let v67 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr v65 v66 
    let v68 : Result<Vec<unit>, std_string_String> = Ok v67 
    let v69 : Result<Vec<unit>, std_string_String> = method91(v68)
    let v70 : string = ""
    let v71 : string = "}"
    let v72 : string = v70 + v71 
    let v73 : string = v72 + v71 
    let v74 : string = v73 + v71 
    let v75 : string = "{"
    let v76 : string = v70 + v75 
    let v77 : string = v76 + v75 
    let v78 : string = "v69 " + v74 + "); " + v77 + " //"
    Fable.Core.RustInterop.emitRustExpr () v78 
    let v79 : string = "__result"
    let v80 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v79 
    v80
and closure80 () (v0 : Vec<string option>) : US42 =
    US42_0(v0)
and closure81 () (v0 : std_string_String) : US42 =
    US42_1(v0)
and closure82 () (v0 : string option) : US34 =
    let v3 : US34 option = None
    let _v3 = ref v3 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : string = x
    let v5 : US34 = US34_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US34 option = _v3.Value 
    let v29 : US34 = US34_1
    let v30 : US34 = v6 |> Option.defaultValue v29 
    v30
and closure83 (v0 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) (v1 : US34) : unit =
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
and closure86 () (v0 : crate_model_near_nearblocks_Root) : crate_model_near_nearblocks_Root option =
    let v3 : crate_model_near_nearblocks_Root option = Some v0 
    v3
and method93 () : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) =
    closure86()
and method94 (v0 : Result<crate_model_near_nearblocks_Root, std_string_String>) : Result<crate_model_near_nearblocks_Root, std_string_String> =
    v0
and closure85 (v0 : US38, v1 : US44, v2 : int32) struct (v3 : string, v4 : US25, v5 : string, v6 : bool, v7 : bool) : Result<crate_model_near_nearblocks_Root option, std_string_String> =
    let v71 : US32 =
        match v0 with
        | US38_1 -> (* None *)
            US32_1
        | US38_0(v8) -> (* Some *)
            let v67 : US33 =
                match v8 with
                | US39_1(v64) -> (* Error *)
                    US33_1(v64)
                | US39_0(v9) -> (* Ok *)
                    let v10 : US27 option = v9 |> Array.tryItem v2 
                    let v13 : US35 option = None
                    let _v13 = ref v13 
                    match v10 with
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
                    let v39 : US35 = US35_1
                    let v40 : US35 = v16 |> Option.defaultValue v39 
                    let v54 : US27 =
                        match v40 with
                        | US35_0(v48) -> (* Some *)
                            match v48 with
                            | US27_0(v49) -> (* Some *)
                                US27_0(v49)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v62 : US34 =
                        match v54 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v55) -> (* Some *)
                            let v56 : std_string_String = v55.l0
                            let v57 : string = "fable_library_rust::String_::fromString($0)"
                            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
                            US34_0(v58)
                    US33_0(v62)
            US32_0(v67)
    let v74 : string = $"%A{struct (v3, v4, v5, v6, v7)}"
    let v81 : int64 = 400L
    let v82 : string = method8(v81, v74)
    let v85 : string = $"%A{v71}"
    let v92 : int64 = 400L
    let v93 : string = method8(v92, v85)
    let v94 : string = "state_core.use_request (15) / result memo / request: " + string v82 + " / state_data: " + string v93 + ""
    let v95 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v96 : bool = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let v99 : string = $"%A{v1}"
    let v106 : int64 = 400L
    let v107 : string = method8(v106, v99)
    let v108 : string = "state_core.use_request (16) / effect / json: " + string v107 + ""
    let v109 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
    let v162 : US34 =
        match v1 with
        | US44_1(v159) -> (* Error *)
            US34_1
        | US44_0(v111) -> (* Ok *)
            let v112 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v113 : (US34 []) = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : US34 option = v113 |> Array.tryItem v2 
            let v117 : US45 option = None
            let _v117 = ref v117 
            match v114 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v118 : US34 = x
            let v119 : US45 = US45_0(v118)
            v119 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v117.Value <- x
            let v120 : US45 option = _v117.Value 
            let v143 : US45 = US45_1
            let v144 : US45 = v120 |> Option.defaultValue v143 
            match v144 with
            | US45_0(v152) -> (* Some *)
                match v152 with
                | US34_0(v153) -> (* Some *)
                    US34_0(v153)
                | _ ->
                    US34_1
            | _ ->
                US34_1
    match v162 with
    | US34_0(v163) -> (* Some *)
        let v164 : string = method34(v163)
        let v165 : string = "&*$0"
        let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v164 v165 
        let v167 : string = "serde_json::from_str(&v166)"
        let v168 : Result<crate_model_near_nearblocks_Root, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v167 
        let v169 : (serde_json_Error -> std_string_String) = method35()
        let v170 : string = "$0.map_err(|x| $1(x))"
        let v171 : Result<crate_model_near_nearblocks_Root, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v168, v169) v170 
        let v172 : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) = method93()
        let v173 : Result<crate_model_near_nearblocks_Root, std_string_String> = method94(v171)
        let v174 : string = "v173.map(|x| v172(x))"
        let v175 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v174 
        v175
    | _ ->
        match v71 with
        | US32_0(v176) -> (* Some *)
            match v176 with
            | US33_0(v177) -> (* Ok *)
                match v177 with
                | US34_0(v178) -> (* Some *)
                    let v179 : string = method34(v178)
                    let v180 : string = "&*$0"
                    let v181 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v179 v180 
                    let v182 : string = "serde_json::from_str(&v181)"
                    let v183 : Result<crate_model_near_nearblocks_Root, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v182 
                    let v184 : (serde_json_Error -> std_string_String) = method35()
                    let v185 : string = "$0.map_err(|x| $1(x))"
                    let v186 : Result<crate_model_near_nearblocks_Root, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v183, v184) v185 
                    let v187 : (crate_model_near_nearblocks_Root -> crate_model_near_nearblocks_Root option) = method93()
                    let v188 : Result<crate_model_near_nearblocks_Root, std_string_String> = method94(v186)
                    let v189 : string = "v188.map(|x| v187(x))"
                    let v190 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v189 
                    v190
                | _ ->
                    let v193 : string = $"%A{struct (v162, v71)}"
                    let v200 : string = "state_core.use_request (17) / json Error / value: " + string v193 + ""
                    let v201 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                    let v202 : bool = Fable.Core.RustInterop.emitRustExpr v200 v201 
                    let v203 : crate_model_near_nearblocks_Root option = None
                    let v204 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v203 
                    v204
            | _ ->
                let v208 : string = $"%A{struct (v162, v71)}"
                let v215 : string = "state_core.use_request (17) / json Error / value: " + string v208 + ""
                let v216 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v217 : bool = Fable.Core.RustInterop.emitRustExpr v215 v216 
                let v218 : crate_model_near_nearblocks_Root option = None
                let v219 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v218 
                v219
        | _ ->
            let v223 : string = $"%A{struct (v162, v71)}"
            let v230 : string = "state_core.use_request (17) / json Error / value: " + string v223 + ""
            let v231 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v232 : bool = Fable.Core.RustInterop.emitRustExpr v230 v231 
            let v233 : crate_model_near_nearblocks_Root option = None
            let v234 : Result<crate_model_near_nearblocks_Root option, std_string_String> = Ok v233 
            v234
and closure84 (v0 : US38, v1 : US44) (v2 : int32) : (struct (string * US25 * string * bool * bool) -> Result<crate_model_near_nearblocks_Root option, std_string_String>) =
    closure85(v0, v1, v2)
and method92 (v0 : US38, v1 : US44) : (int32 -> (struct (string * US25 * string * bool * bool) -> Result<crate_model_near_nearblocks_Root option, std_string_String>)) =
    closure84(v0, v1)
and closure79 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Memo<Result<Vec<Heap4 option>, std_string_String> option>, v2 : leptos_Resource<struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option), Result<Vec<string option>, std_string_String>>, v3 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) () : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) =
    let v4 : string = $"$0()"
    let v5 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v8 : string = $"%A{v5}"
    let v15 : string = "state_core.use_requests (13) / result memo / requests: " + string v8 + ""
    let v16 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = $"$0()"
    let v19 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v18 
    let v22 : US28 option = None
    let _v22 = ref v22 
    match v19 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : Result<Vec<Heap4 option>, std_string_String> = x
    let v24 : US28 = US28_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US28 option = _v22.Value 
    let v48 : US28 = US28_1
    let v49 : US28 = v25 |> Option.defaultValue v48 
    let v75 : US38 =
        match v49 with
        | US28_1 -> (* None *)
            US38_1
        | US28_0(v57) -> (* Some *)
            let v58 : (Vec<Heap4 option> -> US31) = closure70()
            let v59 : (std_string_String -> US31) = closure71()
            let v60 : US31 = match v57 with Ok x -> v58 x | Error x -> v59 x
            let v71 : US39 =
                match v60 with
                | US31_1(v68) -> (* Error *)
                    US39_1(v68)
                | US31_0(v61) -> (* Ok *)
                    let v62 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v63 : (Heap4 option -> US27) = closure72()
                    let v64 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v62 
                    let v65 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v66 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v64 v65 
                    US39_0(v66)
            US38_0(v71)
    let v78 : string = $"%A{v75}"
    let v85 : int64 = 400L
    let v86 : string = method8(v85, v78)
    let v87 : string = "state_core.use_request (14) / result_memo / state_data: " + string v86 + ""
    let v88 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = $"leptos::SignalGet::get(&$0)"
    let v91 : Result<Vec<string option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v90 
    let v94 : US40 option = None
    let _v94 = ref v94 
    match v91 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v95 : Result<Vec<string option>, std_string_String> = x
    let v96 : US40 = US40_0(v95)
    v96 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v94.Value <- x
    let v97 : US40 option = _v94.Value 
    let v120 : US40 = US40_1
    let v121 : US40 = v97 |> Option.defaultValue v120 
    let v136 : US41 =
        match v121 with
        | US40_1 -> (* None *)
            US41_1
        | US40_0(v129) -> (* Some *)
            let v130 : (Vec<string option> -> US42) = closure80()
            let v131 : (std_string_String -> US42) = closure81()
            let v132 : US42 = match v129 with Ok x -> v130 x | Error x -> v131 x
            US41_0(v132)
    let v150 : US43 =
        match v136 with
        | US41_1 -> (* None *)
            US43_1
        | US41_0(v137) -> (* Some *)
            let v146 : US44 =
                match v137 with
                | US42_1(v143) -> (* Error *)
                    US44_1(v143)
                | US42_0(v138) -> (* Ok *)
                    let v139 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v140 : (string option -> US34) = closure82()
                    let v141 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr struct (v138, v140) v139 
                    US44_0(v141)
            US43_0(v146)
    let v151 : (US34 []) = [||]
    let v152 : string = "$0.to_vec()"
    let v153 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr v151 v152 
    let v157 : US44 =
        match v150 with
        | US43_1 -> (* None *)
            US44_0(v153)
        | US43_0(v154) -> (* Some *)
            v154
    match v157 with
    | US44_1(v162) -> (* Error *)
        ()
    | US44_0(v158) -> (* Ok *)
        let v159 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
        let v160 : (US34 -> unit) = closure83(v3)
        let v161 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr struct (v158, v160) v159 
        ()
    let v163 : (int32 -> (struct (string * US25 * string * bool * bool) -> Result<crate_model_near_nearblocks_Root option, std_string_String>)) = method92(v75, v157)
    let v164 : Vec<struct (string * US25 * string * bool * bool)> = method83(v5)
    let v165 : string = "v164.iter().enumerate().map(|(i, x)| v163(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v166 : Vec<Result<crate_model_near_nearblocks_Root option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v168 : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v166 v167 
    let v171 : string = $"%A{v168}"
    let v178 : string = "state_core.use_requests (18) / result_func func0 / result: " + string v171 + ""
    let v179 : int64 = 200L
    let v180 : string = method8(v179, v178)
    let v181 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v182 : bool = Fable.Core.RustInterop.emitRustExpr v180 v181 
    v168
and closure89 (v0 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []))) (v1 : crate_model_near_nearblocks_Root option) : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option =
    let v4 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option = None
    let _v4 = ref v4 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v5 : crate_model_near_nearblocks_Root = x
    let v6 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) = v0 v5
    v6 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v4.Value <- x
    let v7 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option = _v4.Value 
    v7
and method95 (v0 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []))) : (crate_model_near_nearblocks_Root option -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option) =
    closure89(v0)
and method96 (v0 : Result<crate_model_near_nearblocks_Root option, std_string_String>) : Result<crate_model_near_nearblocks_Root option, std_string_String> =
    v0
and closure88 (v0 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []))) (v1 : Result<crate_model_near_nearblocks_Root option, std_string_String>) : Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String> =
    let v2 : (crate_model_near_nearblocks_Root option -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option) = method95(v0)
    let v3 : Result<crate_model_near_nearblocks_Root option, std_string_String> = method96(v1)
    let v4 : string = "v3.map(|x| v2(x))"
    let v5 : Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure87 (v0 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) [])), v1 : leptos_Resource<US2, rexie_Rexie>, v2 : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>>, v3 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])>) () : Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>> =
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
    let v16 : US5 option = None
    let _v16 = ref v16 
    match v13 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v17 : rexie_Rexie = x
    let v18 : US5 = US5_0(v17)
    v18 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v16.Value <- x
    let v19 : US5 option = _v16.Value 
    let v42 : US5 = US5_1
    let v43 : US5 = v19 |> Option.defaultValue v42 
    let v51 : string = $"leptos::SignalGet::get(&$0)"
    let v52 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v51 
    let v55 : US28 option = None
    let _v55 = ref v55 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v56 : Result<Vec<Heap4 option>, std_string_String> = x
    let v57 : US28 = US28_0(v56)
    v57 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v55.Value <- x
    let v58 : US28 option = _v55.Value 
    let v81 : US28 = US28_1
    let v82 : US28 = v58 |> Option.defaultValue v81 
    let v108 : US38 =
        match v82 with
        | US28_1 -> (* None *)
            US38_1
        | US28_0(v90) -> (* Some *)
            let v91 : (Vec<Heap4 option> -> US31) = closure70()
            let v92 : (std_string_String -> US31) = closure71()
            let v93 : US31 = match v90 with Ok x -> v91 x | Error x -> v92 x
            let v104 : US39 =
                match v93 with
                | US31_1(v101) -> (* Error *)
                    US39_1(v101)
                | US31_0(v94) -> (* Ok *)
                    let v95 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v96 : (Heap4 option -> US27) = closure72()
                    let v97 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v94, v96) v95 
                    let v98 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v99 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    US39_0(v99)
            US38_0(v104)
    let v111 : string = $"%A{v43}"
    let v118 : int64 = 400L
    let v119 : string = method8(v118, v111)
    let v122 : string = $"%A{v108}"
    let v129 : int64 = 400L
    let v130 : string = method8(v129, v122)
    let v131 : string = "state_core.use_request (19) / result move / database: " + string v119 + " / database_loading: " + string v7 + " / state_data: " + string v130 + " / state_data_loading: " + string v11 + ""
    let v132 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v133 : bool = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = $"$0()"
    let v135 : (Result<crate_model_near_nearblocks_Root option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v3 v134 
    let v136 : string = "$0.to_vec()"
    let v137 : Vec<Result<crate_model_near_nearblocks_Root option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let v138 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v139 : (Result<crate_model_near_nearblocks_Root option, std_string_String> -> Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>) = closure88(v0)
    let v140 : Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v137, v139) v138 
    let v143 : string = $"%A{v140}"
    let v150 : string = "state_core.use_requests (20) / result func0 / result: " + string v143 + ""
    let v151 : int64 = 200L
    let v152 : string = method8(v151, v150)
    let v153 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v154 : bool = Fable.Core.RustInterop.emitRustExpr v152 v153 
    v140
and method62 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []))) : leptos_Memo<Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>> =
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
    let v14 : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>> = method63(v0, v8)
    let v15 : string = "$0"
    let v16 : (unit -> Result<Vec<Heap4 option>, std_string_String> option) = closure68(v14)
    let v17 : (unit -> Result<Vec<Heap4 option>, std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v16 v15 
    let v18 : string = "leptos::create_memo(move |_| { v17(()) })"
    let v19 : leptos_Memo<Result<Vec<Heap4 option>, std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v18 
    let v20 : leptos_Resource<struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option), Result<Vec<string option>, std_string_String>> = method71(v0, v19)
    let v21 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap4>| $0(value.clone()))"
    let v22 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure76(v0, v13)
    let v23 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v22 v21 
    let v24 : string = "$0"
    let v25 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = closure79(v0, v19, v20, v23)
    let v26 : (unit -> (Result<crate_model_near_nearblocks_Root option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v25 v24 
    let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
    let v28 : leptos_Memo<(Result<crate_model_near_nearblocks_Root option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "$0"
    let v30 : (unit -> Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>) = closure87(v1, v8, v14, v28)
    let v31 : (unit -> Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>) = Fable.Core.RustInterop.emitRustExpr v30 v29 
    let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
    let v33 : leptos_Memo<Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v32 
    v33
and closure92 () (v0 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option) : US46 =
    US46_0(v0)
and closure93 () (v0 : std_string_String) : US46 =
    US46_1(v0)
and closure91 () (v0 : Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>) : US46 =
    let v1 : ((struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option -> US46) = closure92()
    let v2 : (std_string_String -> US46) = closure93()
    let v3 : US46 = match v0 with Ok x -> v1 x | Error x -> v2 x
    v3
and closure94 () (v0 : US46) : US47 =
    match v0 with
    | US46_1(v40) -> (* Error *)
        US47_1(v40)
    | US46_0(v1) -> (* Ok *)
        let v4 : US48 option = None
        let _v4 = ref v4 
        match v1 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5 : (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) = x
        let v6 : US48 = US48_0(v5)
        v6 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4.Value <- x
        let v7 : US48 option = _v4.Value 
        let v30 : US48 = US48_1
        let v31 : US48 = v7 |> Option.defaultValue v30 
        US47_0(v31)
and closure95 () (v0 : US47) : bool =
    match v0 with
    | US47_0(v1) -> (* Ok *)
        match v1 with
        | US48_1 -> (* None *)
            true
        | _ ->
            false
    | _ ->
        false
and method97 () : (US47 -> bool) =
    closure95()
and method98 (v0 : Vec<US47>) : Vec<US47> =
    v0
and closure98 () (v0 : (unativeint * struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])))) : struct (unativeint * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) =
    let (a, b) = v0 
    let v3 : unativeint = a
    let struct (v4 : std_string_String, v5 : std_string_String, v6 : std_string_String, v7 : std_string_String, v8 : std_string_String, v9 : std_string_String, v10 : uint32, v11 : (struct (std_string_String * std_string_String option) []), v12 : float, v13 : bool, v14 : float, v15 : (std_string_String [])) = b
    struct (v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15)
and closure99 (v0 : int32, v1 : string) struct (v2 : unativeint, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : std_string_String, v7 : std_string_String, v8 : std_string_String, v9 : uint32, v10 : (struct (std_string_String * std_string_String option) []), v11 : float, v12 : bool, v13 : float, v14 : (std_string_String [])) : struct (string * unativeint * Heap5) =
    let v17 : unativeint = v0 |> unativeint 
    let v24 : Heap5 = {l0 = v3; l1 = v4; l2 = v5; l3 = v6; l4 = v7; l5 = v8; l6 = v9; l7 = v10; l8 = v11; l9 = v12; l10 = v13; l11 = v14} : Heap5
    struct (v1, v17, v24)
and closure97 (v0 : (string []), v1 : int32) (v2 : US47) : US51 =
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
                let v7 : Vec<struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))> = Fable.Core.RustInterop.emitRustExpr v5 v6 
                let v8 : string = "v7.into_iter()"
                let v9 : _ = Fable.Core.RustInterop.emitRustExpr () v8 
                let v10 : string = "v9.enumerate().map(std::sync::Arc::new)"
                let v11 : _ = Fable.Core.RustInterop.emitRustExpr () v10 
                let v12 : string = "v11.collect::<Vec<_>>()"
                let v13 : Vec<(unativeint * struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])))> = Fable.Core.RustInterop.emitRustExpr () v12 
                let v14 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v15 : ((unativeint * struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))) -> struct (unativeint * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))) = closure98()
                let v16 : Vec<struct (unativeint * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14 
                let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v18 : (struct (unativeint * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) = Fable.Core.RustInterop.emitRustExpr v16 v17 
                let v19 : string = "$0.to_vec()"
                let v20 : Vec<struct (unativeint * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String []))> = Fable.Core.RustInterop.emitRustExpr v18 v19 
                let v21 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v22 : (struct (unativeint * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) -> struct (string * unativeint * Heap5)) = closure99(v1, v3)
                let v23 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr struct (v20, v22) v21 
                US52_0(v23)
        US51_0(v27)
and closure96 (v0 : (string [])) (v1 : int32) : (US47 -> US51) =
    closure97(v0, v1)
and method99 (v0 : (string [])) : (int32 -> (US47 -> US51)) =
    closure96(v0)
and method100 (v0 : Vec<US47>) : Vec<US47> =
    v0
and closure100 () (v0 : US51) : US53 =
    match v0 with
    | US51_1(v16) -> (* Error *)
        US53_1(v16)
    | US51_0(v1) -> (* Ok *)
        let v14 : Vec<struct (string * unativeint * Heap5)> option =
            match v1 with
            | US52_1 -> (* None *)
                let v12 : Vec<struct (string * unativeint * Heap5)> option = None
                v12
            | US52_0(v2) -> (* Some *)
                let v5 : Vec<struct (string * unativeint * Heap5)> option = Some v2 
                v5
        US53_0(v14)
and closure101 () (v0 : US53) : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> =
    match v0 with
    | US53_1(v3) -> (* Error *)
        let v4 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = Error v3 
        v4
    | US53_0(v1) -> (* Ok *)
        let v2 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = Ok v1 
        v2
and method101 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure102 () (v0 : Vec<struct (string * unativeint * Heap5)> option) : US53 =
    US53_0(v0)
and closure103 () (v0 : std_string_String) : US53 =
    US53_1(v0)
and method102 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method103 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and method104 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure104 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : std_string_String =
    let v3 : std_string_String = v2.l5
    v3
and method105 () : (struct (string * unativeint * Heap5) -> std_string_String) =
    closure104()
and method106 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure90 (v0 : leptos_Memo<(string [])>, v1 : leptos_Memo<Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>>) () : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> =
    let v2 : string = $"$0()"
    let v3 : Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v5 : (Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String> -> US46) = closure91()
    let v6 : Vec<US46> = Fable.Core.RustInterop.emitRustExpr struct (v3, v5) v4 
    let v7 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v8 : (US46 -> US47) = closure94()
    let v9 : Vec<US47> = Fable.Core.RustInterop.emitRustExpr struct (v6, v8) v7 
    let v12 : string = $"%A{v9}"
    let v19 : int64 = 400L
    let v20 : string = method8(v19, v12)
    let v21 : string = "transactions.render (8) / txns move / root: " + string v20 + ""
    let v22 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : (US47 -> bool) = method97()
    let v25 : Vec<US47> = method98(v9)
    let v26 : string = "v25.into_iter().filter(|x| v24(x.clone().clone())).collect::<Vec<_>>()"
    let v27 : Vec<US47> = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v29 : (US47 []) = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : int32 = v29.Length
    let v31 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v32 : (US47 []) = Fable.Core.RustInterop.emitRustExpr v9 v31 
    let v33 : int32 = v32.Length
    let v34 : bool = v30 = v33
    let v166 : US49 =
        if v34 then
            let v35 : US50 = US50_1
            US49_0(v35)
        else
            let v37 : string = $"$0()"
            let v38 : (string []) = Fable.Core.RustInterop.emitRustExpr v0 v37 
            let v39 : (int32 -> (US47 -> US51)) = method99(v38)
            let v40 : Vec<US47> = method100(v9)
            let v41 : string = "v40.iter().enumerate().map(|(i, x)| v39(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
            let v42 : Vec<US51> = Fable.Core.RustInterop.emitRustExpr () v41 
            let v43 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v44 : (US51 -> US53) = closure100()
            let v45 : Vec<US53> = Fable.Core.RustInterop.emitRustExpr struct (v42, v44) v43 
            let v46 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v47 : (US53 -> Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String>) = closure101()
            let v48 : Vec<Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v45, v47) v46 
            let v49 : (struct (string * unativeint * Heap5) []) = [||]
            let v50 : string = "$0.to_vec()"
            let v51 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v53 : (Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v48 v52 
            let v54 : int32 = v53.Length
            let v55 : US54 = US54_0(v51)
            let v56 : Mut4 = {l0 = 0; l1 = v55} : Mut4
            while method101(v54, v56) do
                let v58 : int32 = v56.l0
                let v59 : US54 = v56.l1
                let v60 : Result<Vec<struct (string * unativeint * Heap5)> option, std_string_String> = v53.[int v58]
                let v61 : (Vec<struct (string * unativeint * Heap5)> option -> US53) = closure102()
                let v62 : (std_string_String -> US53) = closure103()
                let v63 : US53 = match v60 with Ok x -> v61 x | Error x -> v62 x
                let v106 : US51 =
                    match v63 with
                    | US53_1(v103) -> (* Error *)
                        US51_1(v103)
                    | US53_0(v64) -> (* Ok *)
                        let v67 : US52 option = None
                        let _v67 = ref v67 
                        match v64 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v68 : Vec<struct (string * unativeint * Heap5)> = x
                        let v69 : US52 = US52_0(v68)
                        v69 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v67.Value <- x
                        let v70 : US52 option = _v67.Value 
                        let v93 : US52 = US52_1
                        let v94 : US52 = v70 |> Option.defaultValue v93 
                        US51_0(v94)
                let v127 : US54 =
                    match v59 with
                    | US54_0(v107) -> (* Ok *)
                        match v106 with
                        | US51_1(v120) -> (* Error *)
                            US54_1(v120)
                        | US51_0(v108) -> (* Ok *)
                            match v108 with
                            | US52_0(v109) -> (* Some *)
                                let v110 : Vec<struct (string * unativeint * Heap5)> = method102(v109)
                                let v111 : Vec<struct (string * unativeint * Heap5)> = method103(v107)
                                let v112 : string = "true; let mut v111 = v111"
                                let v113 : bool = Fable.Core.RustInterop.emitRustExpr () v112 
                                let v114 : string = "true; v111.extend(v110)"
                                let v115 : bool = Fable.Core.RustInterop.emitRustExpr () v114 
                                let v116 : string = "v111"
                                let v117 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v116 
                                US54_0(v117)
                            | _ ->
                                v59
                    | _ ->
                        match v106 with
                        | US51_1(v124) -> (* Error *)
                            US54_1(v124)
                        | _ ->
                            v59
                let v128 : int32 = v58 + 1
                v56.l0 <- v128
                v56.l1 <- v127
                ()
            let v129 : US54 = v56.l1
            let v143 : US54 =
                match v129 with
                | US54_1(v140) -> (* Error *)
                    US54_1(v140)
                | US54_0(v130) -> (* Ok *)
                    let v131 : Vec<struct (string * unativeint * Heap5)> = method104(v130)
                    let v132 : (struct (string * unativeint * Heap5) -> std_string_String) = method105()
                    let v133 : string = "true; let mut v131 = v131"
                    let v134 : bool = Fable.Core.RustInterop.emitRustExpr () v133 
                    let v135 : string = "true; v131.sort_by_key(|x| v132(x.clone()))"
                    let v136 : bool = Fable.Core.RustInterop.emitRustExpr () v135 
                    let v137 : string = "v131"
                    let v138 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v137 
                    US54_0(v138)
            let v158 : US55 =
                match v143 with
                | US54_1(v155) -> (* Error *)
                    US55_1(v155)
                | US54_0(v144) -> (* Ok *)
                    let v145 : Vec<struct (string * unativeint * Heap5)> = method106(v144)
                    let v146 : string = "true; let mut v145 = v145"
                    let v147 : bool = Fable.Core.RustInterop.emitRustExpr () v146 
                    let v148 : string = "true; v145.reverse()"
                    let v149 : bool = Fable.Core.RustInterop.emitRustExpr () v148 
                    let v150 : string = "v145"
                    let v151 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v150 
                    let v152 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v153 : (struct (string * unativeint * Heap5) []) = Fable.Core.RustInterop.emitRustExpr v151 v152 
                    US55_0(v153)
            match v158 with
            | US55_1(v162) -> (* Error *)
                US49_1(v162)
            | US55_0(v159) -> (* Ok *)
                let v160 : US50 = US50_0(v159)
                US49_0(v160)
    let v185 : US56 =
        match v166 with
        | US49_1(v182) -> (* Error *)
            US56_1(v182)
        | US49_0(v167) -> (* Ok *)
            let v180 : (struct (string * unativeint * Heap5) []) option =
                match v167 with
                | US50_1 -> (* None *)
                    let v178 : (struct (string * unativeint * Heap5) []) option = None
                    v178
                | US50_0(v168) -> (* Some *)
                    let v171 : (struct (string * unativeint * Heap5) []) option = Some v168 
                    v171
            US56_0(v180)
    let v191 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> =
        match v185 with
        | US56_1(v188) -> (* Error *)
            let v189 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Error v188 
            v189
        | US56_0(v186) -> (* Ok *)
            let v187 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Ok v186 
            v187
    let v194 : string = $"%A{v191}"
    let v201 : string = "use_transactions.render (9) / txns create_memo / result: " + string v194 + " / loading: " + string v34 + ""
    let v202 : int64 = 200L
    let v203 : string = method8(v202, v201)
    let v204 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v205 : bool = Fable.Core.RustInterop.emitRustExpr v203 v204 
    v191
and closure106 () (v0 : (struct (string * unativeint * Heap5) []) option) : US56 =
    US56_0(v0)
and closure107 () (v0 : std_string_String) : US56 =
    US56_1(v0)
and closure109 () (v0 : serde_json_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method107 () : (serde_json_Error -> std_string_String) =
    closure109()
and method108 () : (std_string_String -> string) =
    closure49()
and method109 (v0 : Result<std_string_String, std_string_String>) : Result<std_string_String, std_string_String> =
    v0
and closure110 () (v0 : string) : struct (string * US25 * string * bool * bool) =
    let v1 : string = "https://rpc.mainnet.near.org"
    let v2 : US25 = US25_1
    struct (v1, v2, v0, true, false)
and method110 () : (string -> struct (string * US25 * string * bool * bool)) =
    closure110()
and method111 (v0 : Result<string, std_string_String>) : Result<string, std_string_String> =
    v0
and closure108 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : Result<struct (string * US25 * string * bool * bool), std_string_String> =
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
    let v18 : std_string_String = v2.l3
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
    let v31 : (serde_json_Error -> std_string_String) = method107()
    let v32 : string = "$0.map_err(|x| $1(x))"
    let v33 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32 
    let v34 : (std_string_String -> string) = method108()
    let v35 : Result<std_string_String, std_string_String> = method109(v33)
    let v36 : string = "v35.map(|x| v34(x))"
    let v37 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : (string -> struct (string * US25 * string * bool * bool)) = method110()
    let v39 : Result<string, std_string_String> = method111(v37)
    let v40 : string = "v39.map(|x| v38(x))"
    let v41 : Result<struct (string * US25 * string * bool * bool), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v40 
    v41
and closure105 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String> =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure106()
    let v4 : (std_string_String -> US56) = closure107()
    let v5 : US56 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v48 : US49 =
        match v5 with
        | US56_1(v45) -> (* Error *)
            US49_1(v45)
        | US56_0(v6) -> (* Ok *)
            let v9 : US50 option = None
            let _v9 = ref v9 
            match v6 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v10 : (struct (string * unativeint * Heap5) []) = x
            let v11 : US50 = US50_0(v10)
            v11 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v9.Value <- x
            let v12 : US50 option = _v9.Value 
            let v35 : US50 = US50_1
            let v36 : US50 = v12 |> Option.defaultValue v35 
            US49_0(v36)
    let v70 : US57 =
        match v48 with
        | US49_1(v67) -> (* Error *)
            US57_1(v67)
        | US49_0(v49) -> (* Ok *)
            match v49 with
            | US50_0(v50) -> (* Some *)
                let v51 : string = "$0.to_vec()"
                let v52 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v50 v51 
                let v53 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v54 : (struct (string * unativeint * Heap5) -> Result<struct (string * US25 * string * bool * bool), std_string_String>) = closure108()
                let v55 : Vec<Result<struct (string * US25 * string * bool * bool), std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v52, v54) v53 
                let v56 : string = "v55.into_iter().collect()"
                let v57 : Result<Vec<struct (string * US25 * string * bool * bool)>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v56 
                let v58 : string = "$0?"
                let v59 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v57 v58 
                let v60 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v61 : (struct (string * US25 * string * bool * bool) []) = Fable.Core.RustInterop.emitRustExpr v59 v60 
                let v62 : US58 = US58_0(v61)
                US57_0(v62)
            | _ ->
                let v64 : US58 = US58_1
                US57_0(v64)
    let v89 : US59 =
        match v70 with
        | US57_1(v86) -> (* Error *)
            US59_1(v86)
        | US57_0(v71) -> (* Ok *)
            let v84 : (struct (string * US25 * string * bool * bool) []) option =
                match v71 with
                | US58_1 -> (* None *)
                    let v82 : (struct (string * US25 * string * bool * bool) []) option = None
                    v82
                | US58_0(v72) -> (* Some *)
                    let v75 : (struct (string * US25 * string * bool * bool) []) option = Some v72 
                    v75
            US59_0(v84)
    let v95 : Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String> =
        match v89 with
        | US59_1(v92) -> (* Error *)
            let v93 : Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String> = Error v92 
            v93
        | US59_0(v90) -> (* Ok *)
            let v91 : Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String> = Ok v90 
            v91
    let v98 : string = $"%A{v95}"
    let v105 : string = "use_transactions.render (10) / rpc_requests create_memo / result: " + string v98 + ""
    let v106 : int64 = 200L
    let v107 : string = method8(v106, v105)
    let v108 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    v95
and closure112 () (v0 : (struct (string * US25 * string * bool * bool) []) option) : US59 =
    US59_0(v0)
and closure113 () (v0 : std_string_String) : US59 =
    US59_1(v0)
and closure111 (v0 : leptos_Memo<Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>>) () : Vec<struct (string * US25 * string * bool * bool)> =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : ((struct (string * US25 * string * bool * bool) []) option -> US59) = closure112()
    let v4 : (std_string_String -> US59) = closure113()
    let v5 : US59 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v48 : US57 =
        match v5 with
        | US59_1(v45) -> (* Error *)
            US57_1(v45)
        | US59_0(v6) -> (* Ok *)
            let v9 : US58 option = None
            let _v9 = ref v9 
            match v6 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v10 : (struct (string * US25 * string * bool * bool) []) = x
            let v11 : US58 = US58_0(v10)
            v11 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v9.Value <- x
            let v12 : US58 option = _v9.Value 
            let v35 : US58 = US58_1
            let v36 : US58 = v12 |> Option.defaultValue v35 
            US57_0(v36)
    let v54 : (struct (string * US25 * string * bool * bool) []) =
        match v48 with
        | US57_0(v49) -> (* Ok *)
            match v49 with
            | US58_0(v50) -> (* Some *)
                v50
            | _ ->
                [||]
        | _ ->
            [||]
    let v55 : string = "$0.to_vec()"
    let v56 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v59 : string = $"%A{v56}"
    let v66 : string = "use_transactions.render (11) / rpc_requests' create_memo / result: " + string v59 + ""
    let v67 : int64 = 200L
    let v68 : string = method8(v67, v66)
    let v69 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v70 : bool = Fable.Core.RustInterop.emitRustExpr v68 v69 
    v56
and closure118 () (v0 : crate_model_near_rpc_TransferDetail) : struct (std_string_String * std_string_String option * float option * std_string_String option) =
    let v1 : string = "$0.deposit"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.args"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "$0.gas"
    let v6 : float option = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let v7 : string = "$0.method_name"
    let v8 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v7 
    struct (v2, v4, v6, v8)
and closure117 () (v0 : std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail>) : std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> =
    let v1 : string = "$0.into_iter().map(|(k, v)| (k, $1(v))).collect()"
    let v2 : (crate_model_near_rpc_TransferDetail -> struct (std_string_String * std_string_String option * float option * std_string_String option)) = closure118()
    let v3 : std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1 
    v3
and closure116 () (v0 : crate_model_near_rpc_Receipt) : struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.predecessor_id"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.receipt"
    let v4 : crate_model_near_rpc_ReceiptDetail = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "$0.action"
    let v6 : crate_model_near_rpc_ActionDetail = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "$0.actions"
    let v8 : Vec<std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail>> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v10 : (std_collections_HashMap<std_string_String, crate_model_near_rpc_TransferDetail> -> std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)>) = closure117()
    let v11 : Vec<std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)>> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9 
    let v12 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v13 : (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) = Fable.Core.RustInterop.emitRustExpr v11 v12 
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
and closure120 () (v0 : crate_model_near_rpc_GasProfile) : struct (std_string_String * std_string_String * std_string_String) =
    let v1 : string = "$0.cost"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.cost_category"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "$0.gas_used"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5 
    struct (v2, v4, v6)
and closure122 () (v0 : crate_model_near_rpc_Proof) : struct (std_string_String * std_string_String) =
    let v1 : string = "$0.direction"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.hash"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3 
    struct (v2, v4)
and closure121 () (v0 : Vec<crate_model_near_rpc_Proof>) : (struct (std_string_String * std_string_String) []) =
    let v1 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v2 : (crate_model_near_rpc_Proof -> struct (std_string_String * std_string_String)) = closure122()
    let v3 : Vec<struct (std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1 
    let v4 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v5 : (struct (std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v3 v4 
    v5
and closure119 () (v0 : crate_model_near_rpc_ReceiptsOutcome) : struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) =
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
    let v19 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v20 : (crate_model_near_rpc_GasProfile -> struct (std_string_String * std_string_String * std_string_String)) = closure120()
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
    let v38 : (Vec<crate_model_near_rpc_Proof> -> (struct (std_string_String * std_string_String) [])) = closure121()
    let v39 : (struct (std_string_String * std_string_String) []) option = v35 |> Option.map v38 
    let v78 : (struct (std_string_String * std_string_String) []) = [||]
    let v81 : (struct (std_string_String * std_string_String) []) = v39 |> Option.defaultValue v78 
    struct (v2, v4, v8, v10, v14, v23, v25, v29, v31, v33, v81)
and closure115 () (v0 : crate_model_near_rpc_TransactionStatus) : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) =
    let v1 : string = "$0.receipts"
    let v2 : Vec<crate_model_near_rpc_Receipt> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : (crate_model_near_rpc_Receipt -> struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String)) = closure116()
    let v5 : Vec<struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.receipts_outcome"
    let v9 : Vec<crate_model_near_rpc_ReceiptsOutcome> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v11 : (crate_model_near_rpc_ReceiptsOutcome -> struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []))) = closure119()
    let v12 : Vec<struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) []))> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10 
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) []) = Fable.Core.RustInterop.emitRustExpr v12 v13 
    struct (v7, v14)
and closure124 () (v0 : crate_model_near_rpc_ErrorCauseInfo) : struct (std_string_String option * std_string_String option) =
    let v1 : string = "$0.error_message"
    let v2 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.requested_transaction_hash"
    let v4 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v3 
    struct (v2, v4)
and closure123 () (v0 : crate_model_near_rpc_RpcError) : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) =
    let v1 : string = "$0.name"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.cause"
    let v4 : crate_model_near_rpc_ErrorCause = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "$0.name"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "$0.info"
    let v8 : crate_model_near_rpc_ErrorCauseInfo option = Fable.Core.RustInterop.emitRustExpr v4 v7 
    let v11 : (crate_model_near_rpc_ErrorCauseInfo -> struct (std_string_String option * std_string_String option)) = closure124()
    let v12 : struct (std_string_String option * std_string_String option) option = v8 |> Option.map v11 
    let v50 : string = "$0.code"
    let v51 : int32 = Fable.Core.RustInterop.emitRustExpr v0 v50 
    let v52 : string = "$0.message"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v52 
    let v54 : string = "$0.data"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v54 
    struct (v2, v6, v12, v51, v53, v55)
and closure114 () (v0 : crate_model_near_rpc_RpcResponse) : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) =
    let v1 : string = "$0.jsonrpc"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.result"
    let v4 : crate_model_near_rpc_TransactionStatus option = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v7 : (crate_model_near_rpc_TransactionStatus -> struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) []))) = closure115()
    let v8 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option = v4 |> Option.map v7 
    let v64 : string = "$0.error"
    let v65 : crate_model_near_rpc_RpcError option = Fable.Core.RustInterop.emitRustExpr v0 v64 
    let v68 : (crate_model_near_rpc_RpcError -> struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String)) = closure123()
    let v69 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option = v65 |> Option.map v68 
    let v208 : string = "$0.id"
    let v209 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v208 
    struct (v2, v8, v69, v209)
and closure128 () (v0 : crate_model_near_rpc_RpcResponse) : crate_model_near_rpc_RpcResponse option =
    let v3 : crate_model_near_rpc_RpcResponse option = Some v0 
    v3
and method114 () : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) =
    closure128()
and method115 (v0 : Result<crate_model_near_rpc_RpcResponse, std_string_String>) : Result<crate_model_near_rpc_RpcResponse, std_string_String> =
    v0
and closure127 (v0 : US38, v1 : US44, v2 : int32) struct (v3 : string, v4 : US25, v5 : string, v6 : bool, v7 : bool) : Result<crate_model_near_rpc_RpcResponse option, std_string_String> =
    let v71 : US32 =
        match v0 with
        | US38_1 -> (* None *)
            US32_1
        | US38_0(v8) -> (* Some *)
            let v67 : US33 =
                match v8 with
                | US39_1(v64) -> (* Error *)
                    US33_1(v64)
                | US39_0(v9) -> (* Ok *)
                    let v10 : US27 option = v9 |> Array.tryItem v2 
                    let v13 : US35 option = None
                    let _v13 = ref v13 
                    match v10 with
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
                    let v39 : US35 = US35_1
                    let v40 : US35 = v16 |> Option.defaultValue v39 
                    let v54 : US27 =
                        match v40 with
                        | US35_0(v48) -> (* Some *)
                            match v48 with
                            | US27_0(v49) -> (* Some *)
                                US27_0(v49)
                            | _ ->
                                US27_1
                        | _ ->
                            US27_1
                    let v62 : US34 =
                        match v54 with
                        | US27_1 -> (* None *)
                            US34_1
                        | US27_0(v55) -> (* Some *)
                            let v56 : std_string_String = v55.l0
                            let v57 : string = "fable_library_rust::String_::fromString($0)"
                            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
                            US34_0(v58)
                    US33_0(v62)
            US32_0(v67)
    let v74 : string = $"%A{struct (v3, v4, v5, v6, v7)}"
    let v81 : int64 = 400L
    let v82 : string = method8(v81, v74)
    let v85 : string = $"%A{v71}"
    let v92 : int64 = 400L
    let v93 : string = method8(v92, v85)
    let v94 : string = "state_core.use_request (15) / result memo / request: " + string v82 + " / state_data: " + string v93 + ""
    let v95 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v96 : bool = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let v99 : string = $"%A{v1}"
    let v106 : int64 = 400L
    let v107 : string = method8(v106, v99)
    let v108 : string = "state_core.use_request (16) / effect / json: " + string v107 + ""
    let v109 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
    let v162 : US34 =
        match v1 with
        | US44_1(v159) -> (* Error *)
            US34_1
        | US44_0(v111) -> (* Ok *)
            let v112 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v113 : (US34 []) = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : US34 option = v113 |> Array.tryItem v2 
            let v117 : US45 option = None
            let _v117 = ref v117 
            match v114 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v118 : US34 = x
            let v119 : US45 = US45_0(v118)
            v119 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v117.Value <- x
            let v120 : US45 option = _v117.Value 
            let v143 : US45 = US45_1
            let v144 : US45 = v120 |> Option.defaultValue v143 
            match v144 with
            | US45_0(v152) -> (* Some *)
                match v152 with
                | US34_0(v153) -> (* Some *)
                    US34_0(v153)
                | _ ->
                    US34_1
            | _ ->
                US34_1
    match v162 with
    | US34_0(v163) -> (* Some *)
        let v164 : string = method34(v163)
        let v165 : string = "&*$0"
        let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v164 v165 
        let v167 : string = "serde_json::from_str(&v166)"
        let v168 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v167 
        let v169 : (serde_json_Error -> std_string_String) = method35()
        let v170 : string = "$0.map_err(|x| $1(x))"
        let v171 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v168, v169) v170 
        let v172 : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) = method114()
        let v173 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = method115(v171)
        let v174 : string = "v173.map(|x| v172(x))"
        let v175 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v174 
        v175
    | _ ->
        match v71 with
        | US32_0(v176) -> (* Some *)
            match v176 with
            | US33_0(v177) -> (* Ok *)
                match v177 with
                | US34_0(v178) -> (* Some *)
                    let v179 : string = method34(v178)
                    let v180 : string = "&*$0"
                    let v181 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v179 v180 
                    let v182 : string = "serde_json::from_str(&v181)"
                    let v183 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v182 
                    let v184 : (serde_json_Error -> std_string_String) = method35()
                    let v185 : string = "$0.map_err(|x| $1(x))"
                    let v186 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v183, v184) v185 
                    let v187 : (crate_model_near_rpc_RpcResponse -> crate_model_near_rpc_RpcResponse option) = method114()
                    let v188 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = method115(v186)
                    let v189 : string = "v188.map(|x| v187(x))"
                    let v190 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v189 
                    v190
                | _ ->
                    let v193 : string = $"%A{struct (v162, v71)}"
                    let v200 : string = "state_core.use_request (17) / json Error / value: " + string v193 + ""
                    let v201 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                    let v202 : bool = Fable.Core.RustInterop.emitRustExpr v200 v201 
                    let v203 : crate_model_near_rpc_RpcResponse option = None
                    let v204 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v203 
                    v204
            | _ ->
                let v208 : string = $"%A{struct (v162, v71)}"
                let v215 : string = "state_core.use_request (17) / json Error / value: " + string v208 + ""
                let v216 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                let v217 : bool = Fable.Core.RustInterop.emitRustExpr v215 v216 
                let v218 : crate_model_near_rpc_RpcResponse option = None
                let v219 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v218 
                v219
        | _ ->
            let v223 : string = $"%A{struct (v162, v71)}"
            let v230 : string = "state_core.use_request (17) / json Error / value: " + string v223 + ""
            let v231 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v232 : bool = Fable.Core.RustInterop.emitRustExpr v230 v231 
            let v233 : crate_model_near_rpc_RpcResponse option = None
            let v234 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = Ok v233 
            v234
and closure126 (v0 : US38, v1 : US44) (v2 : int32) : (struct (string * US25 * string * bool * bool) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>) =
    closure127(v0, v1, v2)
and method113 (v0 : US38, v1 : US44) : (int32 -> (struct (string * US25 * string * bool * bool) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>)) =
    closure126(v0, v1)
and closure125 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : leptos_Memo<Result<Vec<Heap4 option>, std_string_String> option>, v2 : leptos_Resource<struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option), Result<Vec<string option>, std_string_String>>, v3 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>>) () : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) =
    let v4 : string = $"$0()"
    let v5 : Vec<struct (string * US25 * string * bool * bool)> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v8 : string = $"%A{v5}"
    let v15 : string = "state_core.use_requests (13) / result memo / requests: " + string v8 + ""
    let v16 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = $"$0()"
    let v19 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v1 v18 
    let v22 : US28 option = None
    let _v22 = ref v22 
    match v19 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : Result<Vec<Heap4 option>, std_string_String> = x
    let v24 : US28 = US28_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US28 option = _v22.Value 
    let v48 : US28 = US28_1
    let v49 : US28 = v25 |> Option.defaultValue v48 
    let v75 : US38 =
        match v49 with
        | US28_1 -> (* None *)
            US38_1
        | US28_0(v57) -> (* Some *)
            let v58 : (Vec<Heap4 option> -> US31) = closure70()
            let v59 : (std_string_String -> US31) = closure71()
            let v60 : US31 = match v57 with Ok x -> v58 x | Error x -> v59 x
            let v71 : US39 =
                match v60 with
                | US31_1(v68) -> (* Error *)
                    US39_1(v68)
                | US31_0(v61) -> (* Ok *)
                    let v62 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v63 : (Heap4 option -> US27) = closure72()
                    let v64 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v62 
                    let v65 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v66 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v64 v65 
                    US39_0(v66)
            US38_0(v71)
    let v78 : string = $"%A{v75}"
    let v85 : int64 = 400L
    let v86 : string = method8(v85, v78)
    let v87 : string = "state_core.use_request (14) / result_memo / state_data: " + string v86 + ""
    let v88 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = $"leptos::SignalGet::get(&$0)"
    let v91 : Result<Vec<string option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v90 
    let v94 : US40 option = None
    let _v94 = ref v94 
    match v91 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v95 : Result<Vec<string option>, std_string_String> = x
    let v96 : US40 = US40_0(v95)
    v96 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v94.Value <- x
    let v97 : US40 option = _v94.Value 
    let v120 : US40 = US40_1
    let v121 : US40 = v97 |> Option.defaultValue v120 
    let v136 : US41 =
        match v121 with
        | US40_1 -> (* None *)
            US41_1
        | US40_0(v129) -> (* Some *)
            let v130 : (Vec<string option> -> US42) = closure80()
            let v131 : (std_string_String -> US42) = closure81()
            let v132 : US42 = match v129 with Ok x -> v130 x | Error x -> v131 x
            US41_0(v132)
    let v150 : US43 =
        match v136 with
        | US41_1 -> (* None *)
            US43_1
        | US41_0(v137) -> (* Some *)
            let v146 : US44 =
                match v137 with
                | US42_1(v143) -> (* Error *)
                    US44_1(v143)
                | US42_0(v138) -> (* Ok *)
                    let v139 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v140 : (string option -> US34) = closure82()
                    let v141 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr struct (v138, v140) v139 
                    US44_0(v141)
            US43_0(v146)
    let v151 : (US34 []) = [||]
    let v152 : string = "$0.to_vec()"
    let v153 : Vec<US34> = Fable.Core.RustInterop.emitRustExpr v151 v152 
    let v157 : US44 =
        match v150 with
        | US43_1 -> (* None *)
            US44_0(v153)
        | US43_0(v154) -> (* Some *)
            v154
    match v157 with
    | US44_1(v162) -> (* Error *)
        ()
    | US44_0(v158) -> (* Ok *)
        let v159 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
        let v160 : (US34 -> unit) = closure83(v3)
        let v161 : Vec<unit> = Fable.Core.RustInterop.emitRustExpr struct (v158, v160) v159 
        ()
    let v163 : (int32 -> (struct (string * US25 * string * bool * bool) -> Result<crate_model_near_rpc_RpcResponse option, std_string_String>)) = method113(v75, v157)
    let v164 : Vec<struct (string * US25 * string * bool * bool)> = method83(v5)
    let v165 : string = "v164.iter().enumerate().map(|(i, x)| v163(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v166 : Vec<Result<crate_model_near_rpc_RpcResponse option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v168 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v166 v167 
    let v171 : string = $"%A{v168}"
    let v178 : string = "state_core.use_requests (18) / result_func func0 / result: " + string v171 + ""
    let v179 : int64 = 200L
    let v180 : string = method8(v179, v178)
    let v181 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v182 : bool = Fable.Core.RustInterop.emitRustExpr v180 v181 
    v168
and closure131 (v0 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option))) (v1 : crate_model_near_rpc_RpcResponse option) : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option =
    let v4 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option = None
    let _v4 = ref v4 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v5 : crate_model_near_rpc_RpcResponse = x
    let struct (v6 : std_string_String, v7 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option, v8 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option, v9 : std_string_String option) = v0 v5
    struct (v6, v7, v8, v9) 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v4.Value <- x
    let v10 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option = _v4.Value 
    v10
and method116 (v0 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option))) : (crate_model_near_rpc_RpcResponse option -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option) =
    closure131(v0)
and method117 (v0 : Result<crate_model_near_rpc_RpcResponse option, std_string_String>) : Result<crate_model_near_rpc_RpcResponse option, std_string_String> =
    v0
and closure130 (v0 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option))) (v1 : Result<crate_model_near_rpc_RpcResponse option, std_string_String>) : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> =
    let v2 : (crate_model_near_rpc_RpcResponse option -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option) = method116(v0)
    let v3 : Result<crate_model_near_rpc_RpcResponse option, std_string_String> = method117(v1)
    let v4 : string = "v3.map(|x| v2(x))"
    let v5 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure129 (v0 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option)), v1 : leptos_Resource<US2, rexie_Rexie>, v2 : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>>, v3 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])>) () : Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>> =
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
    let v16 : US5 option = None
    let _v16 = ref v16 
    match v13 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v17 : rexie_Rexie = x
    let v18 : US5 = US5_0(v17)
    v18 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v16.Value <- x
    let v19 : US5 option = _v16.Value 
    let v42 : US5 = US5_1
    let v43 : US5 = v19 |> Option.defaultValue v42 
    let v51 : string = $"leptos::SignalGet::get(&$0)"
    let v52 : Result<Vec<Heap4 option>, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v51 
    let v55 : US28 option = None
    let _v55 = ref v55 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v56 : Result<Vec<Heap4 option>, std_string_String> = x
    let v57 : US28 = US28_0(v56)
    v57 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v55.Value <- x
    let v58 : US28 option = _v55.Value 
    let v81 : US28 = US28_1
    let v82 : US28 = v58 |> Option.defaultValue v81 
    let v108 : US38 =
        match v82 with
        | US28_1 -> (* None *)
            US38_1
        | US28_0(v90) -> (* Some *)
            let v91 : (Vec<Heap4 option> -> US31) = closure70()
            let v92 : (std_string_String -> US31) = closure71()
            let v93 : US31 = match v90 with Ok x -> v91 x | Error x -> v92 x
            let v104 : US39 =
                match v93 with
                | US31_1(v101) -> (* Error *)
                    US39_1(v101)
                | US31_0(v94) -> (* Ok *)
                    let v95 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v96 : (Heap4 option -> US27) = closure72()
                    let v97 : Vec<US27> = Fable.Core.RustInterop.emitRustExpr struct (v94, v96) v95 
                    let v98 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v99 : (US27 []) = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    US39_0(v99)
            US38_0(v104)
    let v111 : string = $"%A{v43}"
    let v118 : int64 = 400L
    let v119 : string = method8(v118, v111)
    let v122 : string = $"%A{v108}"
    let v129 : int64 = 400L
    let v130 : string = method8(v129, v122)
    let v131 : string = "state_core.use_request (19) / result move / database: " + string v119 + " / database_loading: " + string v7 + " / state_data: " + string v130 + " / state_data_loading: " + string v11 + ""
    let v132 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v133 : bool = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = $"$0()"
    let v135 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v3 v134 
    let v136 : string = "$0.to_vec()"
    let v137 : Vec<Result<crate_model_near_rpc_RpcResponse option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let v138 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v139 : (Result<crate_model_near_rpc_RpcResponse option, std_string_String> -> Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) = closure130(v0)
    let v140 : Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v137, v139) v138 
    let v143 : string = $"%A{v140}"
    let v150 : string = "state_core.use_requests (20) / result func0 / result: " + string v143 + ""
    let v151 : int64 = 200L
    let v152 : string = method8(v151, v150)
    let v153 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v154 : bool = Fable.Core.RustInterop.emitRustExpr v152 v153 
    v140
and method112 (v0 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>>, v1 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option))) : leptos_Memo<Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>> =
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
    let v14 : leptos_Resource<struct (rexie_Rexie option * Vec<struct (string * US25 * string * bool * bool)>), Result<Vec<Heap4 option>, std_string_String>> = method63(v0, v8)
    let v15 : string = "$0"
    let v16 : (unit -> Result<Vec<Heap4 option>, std_string_String> option) = closure68(v14)
    let v17 : (unit -> Result<Vec<Heap4 option>, std_string_String> option) = Fable.Core.RustInterop.emitRustExpr v16 v15 
    let v18 : string = "leptos::create_memo(move |_| { v17(()) })"
    let v19 : leptos_Memo<Result<Vec<Heap4 option>, std_string_String> option> = Fable.Core.RustInterop.emitRustExpr () v18 
    let v20 : leptos_Resource<struct (Vec<struct (string * US25 * string * bool * bool)> * Result<Vec<Heap4 option>, std_string_String> option), Result<Vec<string option>, std_string_String>> = method71(v0, v19)
    let v21 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap4>| $0(value.clone()))"
    let v22 : (Heap4 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<unit>, std_string_String>>>>>) = closure76(v0, v13)
    let v23 : leptos_Action<Heap4, Result<Vec<unit>, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v22 v21 
    let v24 : string = "$0"
    let v25 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = closure125(v0, v19, v20, v23)
    let v26 : (unit -> (Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])) = Fable.Core.RustInterop.emitRustExpr v25 v24 
    let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
    let v28 : leptos_Memo<(Result<crate_model_near_rpc_RpcResponse option, std_string_String> [])> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "$0"
    let v30 : (unit -> Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>) = closure129(v1, v8, v14, v28)
    let v31 : (unit -> Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>) = Fable.Core.RustInterop.emitRustExpr v30 v29 
    let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
    let v33 : leptos_Memo<Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v32 
    v33
and method118 () : string =
    let v0 : string = "https://rpc.mainnet.near.org"
    v0
and closure133 () (v0 : US15) : US61 =
    US61_0(v0)
and closure134 () (v0 : std_string_String) : US61 =
    US61_1(v0)
and closure135 () (v0 : crate_model_near_rpc_RpcResponse) : US63 =
    US63_0(v0)
and closure136 () (v0 : std_string_String) : US63 =
    US63_1(v0)
and method119 (v0 : Result<US60, std_string_String>) : Result<US60, std_string_String> =
    v0
and closure132 () (v0 : Heap6) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> =
    let v3 : string = $"%A{v0}"
    let v10 : string = "dice_view.render (2) / set_max_action / value: " + string v3 + ""
    let v11 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "&*$0"
    let v15 : string = "2.0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v14 
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v19 : string = "&*$0"
    let v20 : string = "dontcare"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v20 v19 
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "&*$0"
    let v25 : string = "EXPERIMENTAL_tx_status"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v24 
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "&*$0"
    let v30 : string = "9JgptZpFQGtUvusnoF9ysVqHXD8fXCri8mFxPTMnt3kS"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v29 
    let v32 : string = "String::from($0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "&*$0"
    let v35 : string = "bowen"
    let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v34 
    let v37 : string = "String::from($0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : (std_string_String []) = [|v33; v38|]
    let v40 : string = "$0.to_vec()"
    let v41 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "crate::model::near::rpc::RpcInput { jsonrpc: v18, id: v23, method: v28, params: v41 }"
    let v43 : crate_model_near_rpc_RpcInput = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method118()
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v44 v45 
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : std_string_String = method78(v48)
    let v50 : string = "reqwest_wasm::Client::builder().build().map_err(|err| err.to_string())?.post(v49)"
    let v51 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : string = "reqwest_wasm::RequestBuilder::json(v51, &v43)"
    let v53 : reqwest_RequestBuilder = Fable.Core.RustInterop.emitRustExpr () v52 
    let v54 : reqwest_RequestBuilder = method80(v53)
    let v55 : string = "Box::pin(reqwest_wasm::RequestBuilder::send(v54))"
    let v56 : std_pin_Pin<Box<Dyn<std_future_Future<Result<reqwest_Response, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = "v56.await"
    let v58 : Result<reqwest_Response, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : (reqwest_Error -> std_string_String) = method81()
    let v60 : string = "$0.map_err(|x| $1(x))"
    let v61 : Result<reqwest_Response, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v58, v59) v60 
    let v62 : string = "$0?"
    let v63 : reqwest_Response = Fable.Core.RustInterop.emitRustExpr v61 v62 
    let v64 : string = "Box::pin(reqwest_wasm::Response::text(v63))"
    let v65 : std_pin_Pin<Box<Dyn<std_future_Future<Result<std_string_String, reqwest_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = "v65.await"
    let v67 : Result<std_string_String, reqwest_Error> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : (reqwest_Error -> std_string_String) = method81()
    let v69 : string = "$0.map_err(|x| $1(x))"
    let v70 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v67, v68) v69 
    let v71 : string = "$0?"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let v73 : US15 = US15_0(v72)
    let v74 : Result<US15, std_string_String> = Ok v73 
    let v77 : string = $"%A{v74}"
    let v84 : string = "dice_view.render (x) / roll_action create_action / result1 / result: " + string v77 + ""
    let v85 : int64 = 200L
    let v86 : string = method8(v85, v84)
    let v87 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v88 : bool = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : (US15 -> US61) = closure133()
    let v90 : (std_string_String -> US61) = closure134()
    let v91 : US61 = match v74 with Ok x -> v89 x | Error x -> v90 x
    let v337 : US62 =
        match v91 with
        | US61_0(v92) -> (* Ok *)
            match v92 with
            | US15_0(v93) -> (* Some *)
                let v94 : string = "fable_library_rust::String_::fromString($0)"
                let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
                let v96 : string = method34(v95)
                let v97 : string = "&*$0"
                let v98 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v96 v97 
                let v99 : string = "serde_json::from_str(&v98)"
                let v100 : Result<crate_model_near_rpc_RpcResponse, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v99 
                let v101 : (serde_json_Error -> std_string_String) = method35()
                let v102 : string = "$0.map_err(|x| $1(x))"
                let v103 : Result<crate_model_near_rpc_RpcResponse, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v100, v101) v102 
                let v104 : (crate_model_near_rpc_RpcResponse -> US63) = closure135()
                let v105 : (std_string_String -> US63) = closure136()
                let v106 : US63 = match v103 with Ok x -> v104 x | Error x -> v105 x
                let v321 : US64 =
                    match v106 with
                    | US63_1(v318) -> (* Error *)
                        US64_1(v318)
                    | US63_0(v107) -> (* Ok *)
                        let v108 : string = "$0.jsonrpc"
                        let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v107 v108 
                        let v110 : string = "$0.result"
                        let v111 : crate_model_near_rpc_TransactionStatus option = Fable.Core.RustInterop.emitRustExpr v107 v110 
                        let v114 : (crate_model_near_rpc_TransactionStatus -> struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) []))) = closure115()
                        let v115 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option = v111 |> Option.map v114 
                        let v171 : string = "$0.error"
                        let v172 : crate_model_near_rpc_RpcError option = Fable.Core.RustInterop.emitRustExpr v107 v171 
                        let v175 : (crate_model_near_rpc_RpcError -> struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String)) = closure123()
                        let v176 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option = v172 |> Option.map v175 
                        let v315 : string = "$0.id"
                        let v316 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v107 v315 
                        US64_0(v109, v115, v176, v316)
                match v321 with
                | US64_1(v328) -> (* Error *)
                    US62_1(v328)
                | US64_0(v322, v323, v324, v325) -> (* Ok *)
                    let v326 : US60 = US60_0(v322, v323, v324, v325)
                    US62_0(v326)
            | _ ->
                let v332 : US60 = US60_1
                US62_0(v332)
        | _ ->
            let v335 : US60 = US60_1
            US62_0(v335)
    let v343 : Result<US60, std_string_String> =
        match v337 with
        | US62_1(v340) -> (* Error *)
            let v341 : Result<US60, std_string_String> = Error v340 
            v341
        | US62_0(v338) -> (* Ok *)
            let v339 : Result<US60, std_string_String> = Ok v338 
            v339
    let v346 : string = $"%A{v343}"
    let v353 : string = "dice_view.render (x) / roll_action create_action / result2 / result: " + string v346 + ""
    let v354 : int64 = 200L
    let v355 : string = method8(v354, v353)
    let v356 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v357 : bool = Fable.Core.RustInterop.emitRustExpr v355 v356 
    let v358 : Result<US60, std_string_String> = method119(v343)
    let v359 : string = ""
    let v360 : string = "}"
    let v361 : string = v359 + v360 
    let v362 : string = v361 + v360 
    let v363 : string = "{"
    let v364 : string = v359 + v363 
    let v365 : string = "v358 " + v362 + "); " + v364 + " //"
    Fable.Core.RustInterop.emitRustExpr () v365 
    let v366 : string = "__result"
    let v367 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v366 
    v367
and closure139 () (v0 : US60) : US62 =
    US62_0(v0)
and closure140 () (v0 : std_string_String) : US62 =
    US62_1(v0)
and closure138 () (v0 : Result<US60, std_string_String>) : US62 =
    let v1 : (US60 -> US62) = closure139()
    let v2 : (std_string_String -> US62) = closure140()
    let v3 : US62 = match v0 with Ok x -> v1 x | Error x -> v2 x
    v3
and closure137 (v0 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> =
    let v1 : string = "leptos::Action::value(&$0)"
    let v2 : leptos_RwSignal<Result<US60, std_string_String> option> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : Result<US60, std_string_String> option = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v7 : (Result<US60, std_string_String> -> US62) = closure138()
    let v8 : US62 option = v4 |> Option.map v7 
    let v44 : US65 option = None
    let _v44 = ref v44 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v45 : US62 = x
    let v46 : US65 = US65_0(v45)
    v46 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v44.Value <- x
    let v47 : US65 option = _v44.Value 
    let v70 : US65 = US65_1
    let v71 : US65 = v47 |> Option.defaultValue v70 
    let v96 : US62 =
        match v71 with
        | US65_0(v79) -> (* Some *)
            match v79 with
            | US62_1(v80) -> (* Error *)
                US62_1(v80)
            | US62_0(v82) -> (* Ok *)
                match v82 with
                | US60_0(v83, v84, v85, v86) -> (* Some *)
                    let v87 : US60 = US60_0(v83, v84, v85, v86)
                    US62_0(v87)
                | _ ->
                    let v89 : US60 = US60_1
                    US62_0(v89)
        | _ ->
            let v94 : US60 = US60_1
            US62_0(v94)
    let v118 : US66 =
        match v96 with
        | US62_1(v115) -> (* Error *)
            US66_1(v115)
        | US62_0(v97) -> (* Ok *)
            let v113 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option =
                match v97 with
                | US60_1 -> (* None *)
                    let v111 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option = None
                    v111
                | US60_0(v98, v99, v100, v101) -> (* Some *)
                    let v104 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option = Some struct (v98, v99, v100, v101) 
                    v104
            US66_0(v113)
    let v124 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> =
        match v118 with
        | US66_1(v121) -> (* Error *)
            let v122 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> = Error v121 
            v122
        | US66_0(v119) -> (* Ok *)
            let v120 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> = Ok v119 
            v120
    let v127 : string = $"%A{v124}"
    let v134 : string = "dice_view.render (x) / roll create_memo / result: " + string v127 + ""
    let v135 : int64 = 200L
    let v136 : string = method8(v135, v134)
    let v137 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v138 : bool = Fable.Core.RustInterop.emitRustExpr v136 v137 
    v124
and closure142 () (v0 : struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option) : US66 =
    US66_0(v0)
and closure143 () (v0 : std_string_String) : US66 =
    US66_1(v0)
and closure141 (v0 : leptos_Memo<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>) () : string option =
    let v1 : string = $"$0()"
    let v2 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : (struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option -> US66) = closure142()
    let v4 : (std_string_String -> US66) = closure143()
    let v5 : US66 = match v2 with Ok x -> v3 x | Error x -> v4 x
    let v54 : US62 =
        match v5 with
        | US66_1(v51) -> (* Error *)
            US62_1(v51)
        | US66_0(v6) -> (* Ok *)
            let v9 : US60 option = None
            let _v9 = ref v9 
            match v6 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let struct (v10 : std_string_String, v11 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option, v12 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option, v13 : std_string_String option) = x
            let v14 : US60 = US60_0(v10, v11, v12, v13)
            v14 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v9.Value <- x
            let v15 : US60 option = _v9.Value 
            let v41 : US60 = US60_1
            let v42 : US60 = v15 |> Option.defaultValue v41 
            US62_0(v42)
    let v120 : US34 =
        match v54 with
        | US62_0(v55) -> (* Ok *)
            match v55 with
            | US60_0(v56, v57, v58, v59) -> (* Some *)
                let v62 : US67 option = None
                let _v62 = ref v62 
                match v58 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let struct (v63 : std_string_String, v64 : std_string_String, v65 : struct (std_string_String option * std_string_String option) option, v66 : int32, v67 : std_string_String, v68 : std_string_String) = x
                let v69 : US67 = US67_0(v63, v64, v65, v66, v67, v68)
                v69 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v62.Value <- x
                let v70 : US67 option = _v62.Value 
                let v98 : US67 = US67_1
                let v99 : US67 = v70 |> Option.defaultValue v98 
                match v99 with
                | US67_0(v107, v108, v109, v110, v111, v112) -> (* Some *)
                    let v113 : string = string v107 + ": " + string v111 + " - " + string v112 + " (" + string v108 + ")"
                    US34_0(v113)
                | _ ->
                    US34_1
            | _ ->
                US34_1
        | _ ->
            US34_1
    let v133 : string option =
        match v120 with
        | US34_1 -> (* None *)
            let v131 : string option = None
            v131
        | US34_0(v121) -> (* Some *)
            let v124 : string option = Some v121 
            v124
    let v136 : string = $"%A{v133}"
    let v143 : string = "dice_view.render (x) / error_message create_memo / result: " + string v136 + ""
    let v144 : int64 = 200L
    let v145 : string = method8(v144, v143)
    let v146 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v147 : bool = Fable.Core.RustInterop.emitRustExpr v145 v146 
    v133
and closure144 (v0 : Heap2) () : US34 =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<Heap0> = v3.l3
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : std_string_String option = v6.l1
    let v10 : US15 option = None
    let _v10 = ref v10 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v11 : std_string_String = x
    let v12 : US15 = US15_0(v11)
    v12 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v10.Value <- x
    let v13 : US15 option = _v10.Value 
    let v36 : US15 = US15_1
    let v37 : US15 = v13 |> Option.defaultValue v36 
    match v37 with
    | US15_1 -> (* None *)
        US34_1
    | US15_0(v45) -> (* Some *)
        let v46 : string = "fable_library_rust::String_::fromString($0)"
        let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46 
        US34_0(v47)
and closure147 (v0 : int32) (v1 : std_string_String) : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) =
    let v2 : string = $"leptos::create_signal($0)"
    let struct (v3 : leptos_ReadSignal<std_string_String>, v4 : leptos_WriteSignal<std_string_String>) = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v5 : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) = v0, struct (v3, v4) 
    v5
and closure146 () (v0 : int32) : (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))) =
    closure147(v0)
and method120 () : (int32 -> (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)))) =
    closure146()
and method121 (v0 : Vec<std_string_String>) : Vec<std_string_String> =
    v0
and closure145 (v0 : Heap2) () : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<Heap0> = v3.l3
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : Vec<(bool * std_string_String)> = v6.l0
    let v8 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v9 : ((bool * std_string_String) -> struct (bool * std_string_String)) = closure46()
    let v10 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8 
    let v11 : (struct (bool * std_string_String) -> bool) = method51()
    let v12 : Vec<struct (bool * std_string_String)> = method52(v10)
    let v13 : string = "v12.into_iter().filter(|x| v11(x.clone().clone())).collect::<Vec<_>>()"
    let v14 : Vec<struct (bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v16 : (struct (bool * std_string_String) -> std_string_String) = closure48()
    let v17 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v14, v16) v15 
    let v18 : (int32 -> (std_string_String -> (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)))) = method120()
    let v19 : Vec<std_string_String> = method121(v17)
    let v20 : string = "v19.iter().enumerate().map(|(i, x)| v18(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v21 : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> = Fable.Core.RustInterop.emitRustExpr () v20 
    v21
and closure149 () (v0 : (int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))) : struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>) =
    let (a, b) = v0 
    let v3 : int32 = a
    let struct (v4 : leptos_ReadSignal<std_string_String>, v5 : leptos_WriteSignal<std_string_String>) = b
    struct (v3, v4, v5)
and closure150 () struct (v0 : int32, v1 : leptos_ReadSignal<std_string_String>, v2 : leptos_WriteSignal<std_string_String>) : struct (int32 * leptos_ReadSignal<std_string_String>) =
    struct (v0, v1)
and closure148 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>>) () : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> =
    let v1 : string = $"$0()"
    let v2 : Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : ((int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) -> struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)) = closure149()
    let v5 : Vec<struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v7 : (struct (int32 * leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>) -> struct (int32 * leptos_ReadSignal<std_string_String>)) = closure150()
    let v8 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6 
    v8
and method122 (v0 : (leptos_View [])) : (leptos_View []) =
    v0
and closure159 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method131 () : (unit -> leptos_Fragment) =
    closure159()
and method132 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    v0
and closure160 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
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
and method133 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure160(v0)
and closure161 () (v0 : leptos_HtmlElement<leptos_svg_Path>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure158 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M6 18L18 6M6 6l12 12\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method130 () : (unit -> leptos_Fragment) =
    closure158()
and closure157 () () : leptos_Fragment =
    let v0 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v1 : string = "fill=\"none\""
    let v2 : string = "height=\"100%\""
    let v3 : string = "viewBox=\"0 0 24 24\""
    let v4 : string = "stroke-width=\"1.5\""
    let v5 : string = "stroke=\"currentColor\""
    let v6 : string = "class=\"text-red-700\""
    let v7 : (unit -> leptos_Fragment) = method130()
    let v8 : string = ""
    let v9 : string = " " + v0 + v8 + ""
    let v10 : string = " " + v1 + v9 + ""
    let v11 : string = " " + v2 + v10 + ""
    let v12 : string = " " + v3 + v11 + ""
    let v13 : string = " " + v4 + v12 + ""
    let v14 : string = " " + v5 + v13 + ""
    let v15 : string = " " + v6 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v7)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method129 () : (unit -> leptos_Fragment) =
    closure157()
and closure162 () () : leptos_Fragment =
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
and method134 () : (unit -> leptos_Fragment) =
    closure162()
and closure156 () () : leptos_Fragment =
    let v0 : string = "class=\"[height:17px]\""
    let v1 : (unit -> leptos_Fragment) = method129()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "span"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Span> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v14 : (unit -> leptos_Fragment) = method134()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method128 () : (unit -> leptos_Fragment) =
    closure156()
and method135 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> =
    v0
and closure163 () struct (v0 : int32, v1 : leptos_ReadSignal<std_string_String>) : int32 =
    v0
and method136 () : (struct (int32 * leptos_ReadSignal<std_string_String>) -> int32) =
    closure163()
and method138 (v0 : std_string_String) : std_string_String =
    v0
and closure165 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : int32, v4 : std_string_String) () : unit =
    let v5 : string = "fable_library_rust::String_::fromString($0)"
    let v6 : string = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : leptos_RwSignal<Heap1> = v2.l0
    let v8 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v9 : Heap1 = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : leptos_RwSignal<Heap0> = v9.l3
    let v11 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v12 : Heap0 = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : Vec<(bool * std_string_String)> = v12.l0
    let v14 : std_string_String option = v12.l1
    let v15 : int32 = v12.l2
    let v16 : int32 = v12.l3
    let v17 : US1 = v12.l4
    let v18 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v19 : Heap1 = Fable.Core.RustInterop.emitRustExpr v7 v18 
    let v20 : leptos_RwSignal<Heap0> = v19.l3
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v21 
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v27 : std_string_String option = Some v24 
    let v34 : Heap0 = {l0 = v13; l1 = v27; l2 = v15; l3 = v16; l4 = v17} : Heap0
    let v35 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr struct (v20, v34) v35 
    ()
and closure167 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure169 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method141 () : (unit -> leptos_Fragment) =
    closure169()
and closure168 () () : leptos_Fragment =
    let v0 : string = "cx=\"12\""
    let v1 : string = "cy=\"12\""
    let v2 : string = "r=\"9\""
    let v3 : string = "stroke-linecap=\"round\""
    let v4 : string = "stroke-linejoin=\"round\""
    let v5 : (unit -> leptos_Fragment) = method141()
    let v6 : string = ""
    let v7 : string = " " + v0 + v6 + ""
    let v8 : string = " " + v1 + v7 + ""
    let v9 : string = " " + v2 + v8 + ""
    let v10 : string = " " + v3 + v9 + ""
    let v11 : string = " " + v4 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v5)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
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
    let v24 : (unit -> leptos_Fragment) = method131()
    let v25 : string = " " + v21 + v6 + ""
    let v26 : string = " " + v22 + v25 + ""
    let v27 : string = " " + v23 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method132(v24)
    let v29 : (unit -> leptos_Fragment) = method133(v28)
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
and method140 () : (unit -> leptos_Fragment) =
    closure168()
and closure166 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : std_string_String) () : leptos_Fragment =
    let v4 : string = "fable_library_rust::String_::fromString($0)"
    let v5 : string = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v8 : US70 option = None
    let _v8 = ref v8 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v9 : leptos_Memo<US34> = x
    let v10 : US70 = US70_0(v9)
    v10 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v8.Value <- x
    let v11 : US70 option = _v8.Value 
    let v34 : US70 = US70_1
    let v35 : US70 = v11 |> Option.defaultValue v34 
    let v49 : US45 =
        match v35 with
        | US70_1 -> (* None *)
            US45_1
        | US70_0(v43) -> (* Some *)
            let v44 : string = $"$0()"
            let v45 : US34 = Fable.Core.RustInterop.emitRustExpr v43 v44 
            US45_0(v45)
    let v56 : US34 =
        match v49 with
        | US45_0(v50) -> (* Some *)
            match v50 with
            | US34_0(v51) -> (* Some *)
                US34_0(v51)
            | _ ->
                US34_1
        | _ ->
            US34_1
    let v94 : leptos_View =
        match v56 with
        | US34_0(v57) -> (* Some *)
            let v58 : bool = v5 = v57
            if v58 then
                let v59 : string = "$0"
                let v60 : (unit -> string) = closure167()
                let v61 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v60 v59 
                let v62 : string = "xmlns=\"http://www.w3.org/2000/svg\""
                let v63 : string = "fill=\"none\""
                let v64 : string = "viewBox=\"0 0 24 24\""
                let v65 : string = "stroke-width=\"1.5\""
                let v66 : string = "stroke=\"currentColor\""
                let v67 : string = "class=move || \" \".to_owned() + &v61(())"
                let v68 : (unit -> leptos_Fragment) = method140()
                let v69 : string = ""
                let v70 : string = " " + v62 + v69 + ""
                let v71 : string = " " + v63 + v70 + ""
                let v72 : string = " " + v64 + v71 + ""
                let v73 : string = " " + v65 + v72 + ""
                let v74 : string = " " + v66 + v73 + ""
                let v75 : string = " " + v67 + v74 + ""
                let v76 : (unit -> leptos_Fragment) = method132(v68)
                let v77 : (unit -> leptos_Fragment) = method133(v76)
                let v78 : string = "svg"
                let v79 : string = "<" + v78 + " " + v75 + ">{v77()}</" + v78 + ">"
                let v80 : string = "leptos::view! { " + v79 + " }"
                let v81 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v80 
                let v82 : leptos_HtmlElement<leptos_svg_Svg> = v81 |> unbox
                let v83 : string = "leptos::IntoView::into_view($0)"
                let v84 : leptos_View = Fable.Core.RustInterop.emitRustExpr v82 v83 
                v84
            else
                let v85 : (leptos_View []) = [||]
                let v86 : (leptos_View []) = method122(v85)
                let v87 : string = "leptos::CollectView::collect_view($0.to_vec())"
                let v88 : leptos_View = Fable.Core.RustInterop.emitRustExpr v86 v87 
                v88
        | _ ->
            let v90 : (leptos_View []) = [||]
            let v91 : (leptos_View []) = method122(v90)
            let v92 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v93 : leptos_View = Fable.Core.RustInterop.emitRustExpr v91 v92 
            v93
    let v95 : string = "&*$0"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v95 
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "leptos::html::text($0)"
    let v100 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v98 v99 
    let v101 : string = "leptos::IntoView::into_view($0)"
    let v102 : leptos_View = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let v103 : (leptos_View []) = [|v94; v102|]
    let v104 : string = "$0.to_vec()"
    let v105 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v103 v104 
    let v106 : string = "leptos::Fragment::new($0)"
    let v107 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v105 v106 
    v107
and method139 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : std_string_String) : (unit -> leptos_Fragment) =
    closure166(v0, v1, v2, v3)
and closure170 () (v0 : leptos_HtmlElement<leptos_html_Button>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure164 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) struct (v3 : int32, v4 : leptos_ReadSignal<std_string_String>) : leptos_Fragment =
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : std_string_String = method138(v6)
    let v8 : (unit -> unit) = closure165(v0, v1, v2, v3, v6)
    let v9 : string = "let v8 = $0"
    Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v10 : string = "class=\"flex flex-1 gap-[10px] [align-items:center] [justify-content:center] inline-block rounded border border-gray-400 hover:bg-gray-100 px-[22px] py-1 text-sm text-gray-900 bg-gray-200 hover:text-gray-600 focus:outline-none focus:ring active:text-gray-500\""
    let v11 : string = "on:click=move |_| v8()"
    let v12 : string = "aria-label=v7"
    let v13 : (unit -> leptos_Fragment) = method139(v0, v1, v2, v6)
    let v14 : string = ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : string = " " + v12 + v16 + ""
    let v18 : (unit -> leptos_Fragment) = method132(v13)
    let v19 : (unit -> leptos_Fragment) = method133(v18)
    let v20 : string = "button"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : leptos_HtmlElement<leptos_html_Button> = v23 |> unbox
    let v25 : (leptos_HtmlElement<leptos_html_Button> []) = [|v24|]
    let v26 : string = "$0.to_vec()"
    let v27 : Vec<leptos_HtmlElement<leptos_html_Button>> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v29 : (leptos_HtmlElement<leptos_html_Button> -> leptos_View) = closure170()
    let v30 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v28 
    let v31 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v32 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v30 v31 
    let v33 : string = "$0.to_vec()"
    let v34 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : string = "leptos::Fragment::new($0)"
    let v36 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v34 v35 
    v36
and method137 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (struct (int32 * leptos_ReadSignal<std_string_String>) -> leptos_Fragment) =
    closure164(v0, v1, v2)
and closure155 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v5 : US68 option = None
    let _v5 = ref v5 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v6 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = x
    let v7 : US68 = US68_0(v6)
    v7 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v5.Value <- x
    let v8 : US68 option = _v5.Value 
    let v31 : US68 = US68_1
    let v32 : US68 = v8 |> Option.defaultValue v31 
    let v46 : US69 =
        match v32 with
        | US68_1 -> (* None *)
            US69_1
        | US68_0(v40) -> (* Some *)
            let v41 : string = $"$0()"
            let v42 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr v40 v41 
            US69_0(v42)
    let v47 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) = [||]
    let v48 : string = "$0.to_vec()"
    let v49 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let v52 : Vec<struct (int32 * leptos_ReadSignal<std_string_String>)> =
        match v46 with
        | US69_1 -> (* None *)
            v49
        | US69_0(v50) -> (* Some *)
            v50
    let v53 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v54 : (struct (int32 * leptos_ReadSignal<std_string_String>) []) = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : uint64 = System.Convert.ToUInt64 v54.Length
    let v56 : bool = v55 = 0UL
    if v56 then
        let v57 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
        let v58 : (unit -> leptos_Fragment) = method128()
        let v59 : string = ""
        let v60 : string = " " + v57 + v59 + ""
        let v61 : (unit -> leptos_Fragment) = method132(v58)
        let v62 : (unit -> leptos_Fragment) = method133(v61)
        let v63 : string = "div"
        let v64 : string = "<" + v63 + " " + v60 + ">{v62()}</" + v63 + ">"
        let v65 : string = "leptos::view! { " + v64 + " }"
        let v66 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v65 
        let v67 : leptos_HtmlElement<leptos_html_Div> = v66 |> unbox
        let v68 : string = "leptos::IntoView::into_view($0)"
        let v69 : leptos_View = Fable.Core.RustInterop.emitRustExpr v67 v68 
        let v70 : (leptos_View []) = [|v69|]
        let v71 : string = "$0.to_vec()"
        let v72 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v70 v71 
        let v73 : string = "leptos::Fragment::new($0)"
        let v74 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v72 v73 
        v74
    else
        let v77 : US68 option = None
        let _v77 = ref v77 
        match v0 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v78 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = x
        let v79 : US68 = US68_0(v78)
        v79 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v77.Value <- x
        let v80 : US68 option = _v77.Value 
        let v103 : US68 = US68_1
        let v104 : US68 = v80 |> Option.defaultValue v103 
        match v104 with
        | US68_1 -> (* None *)
            let v134 : (leptos_View []) = [||]
            let v135 : string = "$0.to_vec()"
            let v136 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v134 v135 
            let v137 : string = "leptos::Fragment::new($0)"
            let v138 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v136 v137 
            v138
        | US68_0(v112) -> (* Some *)
            let v113 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = method135(v112)
            let v114 : (struct (int32 * leptos_ReadSignal<std_string_String>) -> int32) = method136()
            let v115 : (struct (int32 * leptos_ReadSignal<std_string_String>) -> leptos_Fragment) = method137(v0, v1, v2)
            let v116 : string = "each=v113"
            let v117 : string = "key=move |x| v114(x.to_owned())"
            let v118 : string = "let:x"
            let v119 : string = "children=move |x| v115(x)"
            let v120 : string = ""
            let v121 : string = " " + v116 + v120 + ""
            let v122 : string = " " + v117 + v121 + ""
            let v123 : string = " " + v118 + v122 + ""
            let v124 : string = " " + v119 + v123 + ""
            let v125 : string = "leptos::For"
            let v126 : string = "<" + v125 + " " + v124 + " />"
            let v127 : string = "leptos::IntoView::into_view(leptos::view! { " + v126 + " })"
            let v128 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v127 
            let v129 : (leptos_View []) = [|v128|]
            let v130 : string = "$0.to_vec()"
            let v131 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v129 v130 
            let v132 : string = "leptos::Fragment::new($0)"
            let v133 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v131 v132 
            v133
and method127 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure155(v0, v1, v2)
and closure154 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : string = "class=\"flex flex-1 flex-col p-[10px] gap-[7px] [border-left-width:1px] [border-bottom-width:1px] border-gray-200 bg-gray-100\""
    let v4 : (unit -> leptos_Fragment) = method127(v0, v1, v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method132(v4)
    let v8 : (unit -> leptos_Fragment) = method133(v7)
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
and method126 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure154(v0, v1, v2)
and closure171 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
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
and method142 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure171(v0)
and closure173 () () : string =
    let v0 : string = "[align-self:flex-start]"
    v0
and closure174 () () : bool =
    false
and closure175 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (leptos_View []) = [|v0|]
    let v2 : string = "$0.to_vec()"
    let v3 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "leptos::Fragment::new($0)"
    let v5 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v3 v4 
    v5
and method144 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure175(v0)
and closure177 () () : string =
    let v0 : string = "py-[4px]"
    v0
and closure178 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : Ref<Lifetime<StaticLifetime, Str>> =
    let v6 : string = ""
    let v7 : string = "r#\"" + v6 + "\"#"
    let v8 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v7 
    v8
and closure181 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : string =
    let v5 : US70 option = None
    let _v5 = ref v5 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v6 : leptos_Memo<US34> = x
    let v7 : US70 = US70_0(v6)
    v7 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v5.Value <- x
    let v8 : US70 option = _v5.Value 
    let v31 : US70 = US70_1
    let v32 : US70 = v8 |> Option.defaultValue v31 
    let v46 : US45 =
        match v32 with
        | US70_1 -> (* None *)
            US45_1
        | US70_0(v40) -> (* Some *)
            let v41 : string = $"$0()"
            let v42 : US34 = Fable.Core.RustInterop.emitRustExpr v40 v41 
            US45_0(v42)
    let v53 : US34 =
        match v46 with
        | US45_0(v47) -> (* Some *)
            match v47 with
            | US34_0(v48) -> (* Some *)
                US34_0(v48)
            | _ ->
                US34_1
        | _ ->
            US34_1
    match v53 with
    | US34_1 -> (* None *)
        let v55 : string = "Select..."
        v55
    | US34_0(v54) -> (* Some *)
        v54
and method148 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> string) =
    closure181(v0, v1, v2)
and closure182 (v0 : (unit -> string)) () : leptos_Fragment =
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
and method149 (v0 : (unit -> string)) : (unit -> leptos_Fragment) =
    closure182(v0)
and closure180 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : (unit -> string) = method148(v0, v1, v2)
    let v4 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v5 : (unit -> leptos_Fragment) = method149(v3)
    let v6 : string = ""
    let v7 : string = " " + v4 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v5)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
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
and method147 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure180(v0, v1, v2)
and closure184 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure185 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method151 () : (unit -> leptos_Fragment) =
    closure185()
and closure183 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure184()
    let v2 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v3 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v4 : string = "viewBox=\"0 0 20 20\""
    let v5 : string = "fill=\"currentColor\""
    let v6 : string = "class=move || \" \".to_owned() + &v2(())"
    let v7 : (unit -> leptos_Fragment) = method151()
    let v8 : string = ""
    let v9 : string = " " + v3 + v8 + ""
    let v10 : string = " " + v4 + v9 + ""
    let v11 : string = " " + v5 + v10 + ""
    let v12 : string = " " + v6 + v11 + ""
    let v13 : (unit -> leptos_Fragment) = method132(v7)
    let v14 : (unit -> leptos_Fragment) = method133(v13)
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
and method150 () : (unit -> leptos_Fragment) =
    closure183()
and closure179 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) () : leptos_Fragment =
    let v3 : string = "class=\"flex items-center gap-2\""
    let v4 : (unit -> leptos_Fragment) = method147(v0, v1, v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method132(v4)
    let v8 : (unit -> leptos_Fragment) = method133(v7)
    let v9 : string = "div"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : leptos_HtmlElement<leptos_html_Div> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v17 : (unit -> leptos_Fragment) = method150()
    let v18 : string = " " + v16 + v5 + ""
    let v19 : (unit -> leptos_Fragment) = method132(v17)
    let v20 : (unit -> leptos_Fragment) = method133(v19)
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
and method146 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure179(v0, v1, v2)
and closure186 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    v0 ()
and method152 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure186(v0)
and closure176 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure177()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "$0"
    let v8 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure178(v0, v1, v2)
    let v9 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v8 v7 
    let v10 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v9(()) + \" \" + &v6(())"
    let v11 : (unit -> leptos_Fragment) = method146(v0, v1, v2)
    let v12 : string = ""
    let v13 : string = " " + v10 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method132(v11)
    let v15 : (unit -> leptos_Fragment) = method133(v14)
    let v16 : string = "summary"
    let v17 : string = "<" + v16 + " " + v13 + ">{v15()}</" + v16 + ">"
    let v18 : string = "leptos::view! { " + v17 + " }"
    let v19 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v18 
    let v20 : leptos_HtmlElement<leptos_html_Summary> = v19 |> unbox
    let v21 : string = "leptos::IntoView::into_view($0)"
    let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "class=\"flex flex-1 flex-col\""
    let v24 : (unit -> leptos_Fragment) = method152(v3)
    let v25 : string = " " + v23 + v12 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v24)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method145 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure176(v0, v1, v2, v3)
and closure172 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : leptos_View, v4 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure173()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "$0"
    let v9 : (unit -> bool) = closure174()
    let v10 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v9 v8 
    let v11 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v12 : (unit -> leptos_Fragment) = method144(v3)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method132(v12)
    let v16 : (unit -> leptos_Fragment) = method133(v15)
    let v17 : string = "div"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : leptos_HtmlElement<leptos_html_Div> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v7(())"
    let v25 : string = "open=move || v10(())"
    let v26 : (unit -> leptos_Fragment) = method145(v0, v1, v2, v4)
    let v27 : string = " " + v24 + v13 + ""
    let v28 : string = " " + v25 + v27 + ""
    let v29 : (unit -> leptos_Fragment) = method132(v26)
    let v30 : (unit -> leptos_Fragment) = method133(v29)
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
and method143 (v0 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option, v1 : leptos_Memo<US34> option, v2 : Heap2, v3 : leptos_View, v4 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure172(v0, v1, v2, v3, v4)
and closure153 (v0 : Heap2, v1 : leptos_Memo<US34>, v2 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
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
    let v16 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> option = Some v2 
    let v25 : leptos_Memo<US34> option = Some v1 
    let v32 : (leptos_View []) = [||]
    let v33 : (leptos_View []) = method122(v32)
    let v34 : string = "leptos::CollectView::collect_view($0.to_vec())"
    let v35 : leptos_View = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : (unit -> leptos_Fragment) = method126(v16, v25, v0)
    let v37 : (unit -> leptos_Fragment) = method142(v36)
    let v38 : string = "class=\"flex flex-col [position:relative]\""
    let v39 : (unit -> leptos_Fragment) = method143(v16, v25, v0, v35, v37)
    let v40 : string = ""
    let v41 : string = " " + v38 + v40 + ""
    let v42 : (unit -> leptos_Fragment) = method132(v39)
    let v43 : (unit -> leptos_Fragment) = method133(v42)
    let v44 : string = "div"
    let v45 : string = "<" + v44 + " " + v41 + ">{v43()}</" + v44 + ">"
    let v46 : string = "leptos::view! { " + v45 + " }"
    let v47 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : leptos_HtmlElement<leptos_html_Div> = v47 |> unbox
    let v49 : string = "leptos::IntoView::into_view($0)"
    let v50 : leptos_View = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : (leptos_View []) = [|v11; v50|]
    let v52 : string = "$0.to_vec()"
    let v53 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let v54 : string = "leptos::Fragment::new($0)"
    let v55 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v53 v54 
    v55
and method125 (v0 : Heap2, v1 : leptos_Memo<US34>, v2 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure153(v0, v1, v2)
and closure188 (v0 : Heap2) () : int32 =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<Heap0> = v3.l3
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : int32 = v6.l2
    v7
and method154 (v0 : Heap2) : (unit -> int32) =
    closure188(v0)
and closure189 (v0 : Heap2) (v1 : std_string_String) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : leptos_RwSignal<Heap0> = v4.l3
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : Vec<(bool * std_string_String)> = v7.l0
    let v9 : std_string_String option = v7.l1
    let v10 : int32 = v7.l2
    let v11 : int32 = v7.l3
    let v12 : US1 = v7.l4
    let v13 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v14 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v13 
    let v15 : leptos_RwSignal<Heap0> = v14.l3
    let v18 : (std_string_String -> string) = _.ToString()
    let v19 : string = v18 v1
    let v26 : bool = "" = v19
    let v29 : int32 =
        if v26 then
            1
        else
            let v27 : (string -> int32) = int32
            v27 v19
    let v30 : Heap0 = {l0 = v8; l1 = v9; l2 = v29; l3 = v11; l4 = v12} : Heap0
    let v31 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr struct (v15, v30) v31 
    ()
and method155 (v0 : Heap2) : (std_string_String -> unit) =
    closure189(v0)
and closure190 () () : string =
    let v0 : string = ""
    v0
and closure187 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "&*$0"
    let v2 : string = "Max"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "leptos::html::text($0)"
    let v7 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "leptos::IntoView::into_view($0)"
    let v9 : leptos_View = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : (unit -> int32) = method154(v0)
    let v11 : (std_string_String -> unit) = method155(v0)
    let v12 : string = "$0"
    let v13 : (unit -> string) = closure190()
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
and method153 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure187(v0)
and closure192 (v0 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : bool =
    let v1 : string = "leptos::Action::pending(&$0)"
    let v2 : leptos_ReadSignal<bool> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = $"leptos::SignalGet::get(&$0)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method157 (v0 : Func0<bool>) : Func0<bool> =
    v0
and closure193 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>) () : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : leptos_RwSignal<Heap0> = v4.l3
    let v6 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v7 : Heap0 = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : int32 = v7.l2
    let v9 : Heap6 = {l0 = v8} : Heap6
    let v10 : string = "true; leptos::Action::dispatch(&$0, $1.clone())"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr struct (v1, v9) v10 
    ()
and closure195 () () : string =
    let v0 : string = "[width:15px] [height:14px]"
    v0
and closure198 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method161 () : (unit -> leptos_Fragment) =
    closure198()
and closure197 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method161()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method132(v6)
    let v15 : (unit -> leptos_Fragment) = method133(v14)
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
    let v29 : (unit -> leptos_Fragment) = method161()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method132(v29)
    let v37 : (unit -> leptos_Fragment) = method133(v36)
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
    let v50 : (unit -> leptos_Fragment) = method161()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method132(v50)
    let v58 : (unit -> leptos_Fragment) = method133(v57)
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
and method160 () : (unit -> leptos_Fragment) =
    closure197()
and closure199 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0.15s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method161()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method132(v6)
    let v15 : (unit -> leptos_Fragment) = method133(v14)
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
    let v29 : (unit -> leptos_Fragment) = method161()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method132(v29)
    let v37 : (unit -> leptos_Fragment) = method133(v36)
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
    let v50 : (unit -> leptos_Fragment) = method161()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method132(v50)
    let v58 : (unit -> leptos_Fragment) = method133(v57)
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
and method162 () : (unit -> leptos_Fragment) =
    closure199()
and closure200 () () : leptos_Fragment =
    let v0 : string = "attributeName=\"opacity\""
    let v1 : string = "attributeType=\"XML\""
    let v2 : string = "values=\"0.2; 1; .2\""
    let v3 : string = "begin=\"0.3s\""
    let v4 : string = "dur=\"0.6s\""
    let v5 : string = "repeatCount=\"indefinite\""
    let v6 : (unit -> leptos_Fragment) = method161()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method132(v6)
    let v15 : (unit -> leptos_Fragment) = method133(v14)
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
    let v29 : (unit -> leptos_Fragment) = method161()
    let v30 : string = " " + v23 + v7 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : string = " " + v27 + v33 + ""
    let v35 : string = " " + v28 + v34 + ""
    let v36 : (unit -> leptos_Fragment) = method132(v29)
    let v37 : (unit -> leptos_Fragment) = method133(v36)
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
    let v50 : (unit -> leptos_Fragment) = method161()
    let v51 : string = " " + v44 + v7 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : string = " " + v46 + v52 + ""
    let v54 : string = " " + v47 + v53 + ""
    let v55 : string = " " + v48 + v54 + ""
    let v56 : string = " " + v49 + v55 + ""
    let v57 : (unit -> leptos_Fragment) = method132(v50)
    let v58 : (unit -> leptos_Fragment) = method133(v57)
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
and closure201 () (v0 : leptos_HtmlElement<leptos_svg_Rect>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure196 () () : leptos_Fragment =
    let v0 : string = "x=\"0\""
    let v1 : string = "y=\"10\""
    let v2 : string = "width=\"4\""
    let v3 : string = "height=\"10\""
    let v4 : string = "fill=\"#333\""
    let v5 : string = "opacity=\"0.2\""
    let v6 : (unit -> leptos_Fragment) = method160()
    let v7 : string = ""
    let v8 : string = " " + v0 + v7 + ""
    let v9 : string = " " + v1 + v8 + ""
    let v10 : string = " " + v2 + v9 + ""
    let v11 : string = " " + v3 + v10 + ""
    let v12 : string = " " + v4 + v11 + ""
    let v13 : string = " " + v5 + v12 + ""
    let v14 : (unit -> leptos_Fragment) = method132(v6)
    let v15 : (unit -> leptos_Fragment) = method133(v14)
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
    let v27 : (unit -> leptos_Fragment) = method162()
    let v28 : string = " " + v21 + v7 + ""
    let v29 : string = " " + v22 + v28 + ""
    let v30 : string = " " + v23 + v29 + ""
    let v31 : string = " " + v24 + v30 + ""
    let v32 : string = " " + v25 + v31 + ""
    let v33 : string = " " + v26 + v32 + ""
    let v34 : (unit -> leptos_Fragment) = method132(v27)
    let v35 : (unit -> leptos_Fragment) = method133(v34)
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
    let v46 : (unit -> leptos_Fragment) = method163()
    let v47 : string = " " + v40 + v7 + ""
    let v48 : string = " " + v41 + v47 + ""
    let v49 : string = " " + v42 + v48 + ""
    let v50 : string = " " + v43 + v49 + ""
    let v51 : string = " " + v44 + v50 + ""
    let v52 : string = " " + v45 + v51 + ""
    let v53 : (unit -> leptos_Fragment) = method132(v46)
    let v54 : (unit -> leptos_Fragment) = method133(v53)
    let v55 : string = "<" + v16 + " " + v52 + ">{v54()}</" + v16 + ">"
    let v56 : string = "leptos::view! { " + v55 + " }"
    let v57 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v56 
    let v58 : leptos_HtmlElement<leptos_svg_Rect> = v57 |> unbox
    let v59 : (leptos_HtmlElement<leptos_svg_Rect> []) = [|v20; v39; v58|]
    let v60 : string = "$0.to_vec()"
    let v61 : Vec<leptos_HtmlElement<leptos_svg_Rect>> = Fable.Core.RustInterop.emitRustExpr v59 v60 
    let v62 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v63 : (leptos_HtmlElement<leptos_svg_Rect> -> leptos_View) = closure201()
    let v64 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v62 
    let v65 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v66 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : string = "$0.to_vec()"
    let v68 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let v69 : string = "leptos::Fragment::new($0)"
    let v70 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v68 v69 
    v70
and method159 () : (unit -> leptos_Fragment) =
    closure196()
and closure194 (v0 : Func0<bool>) () : leptos_Fragment =
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
            let v13 : (unit -> string) = closure195()
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
            let v24 : (unit -> leptos_Fragment) = method159()
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
            let v35 : (unit -> leptos_Fragment) = method132(v24)
            let v36 : (unit -> leptos_Fragment) = method133(v35)
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
            let v45 : (leptos_View []) = method122(v44)
            let v46 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46 
            v47
    let v49 : (leptos_View []) = [|v9; v48|]
    let v50 : string = "$0.to_vec()"
    let v51 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v49 v50 
    let v52 : string = "leptos::Fragment::new($0)"
    let v53 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v51 v52 
    v53
and method158 (v0 : Func0<bool>) : (unit -> leptos_Fragment) =
    closure194(v0)
and closure203 (v0 : string) () : leptos_Fragment =
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
and method165 (v0 : string) : (unit -> leptos_Fragment) =
    closure203(v0)
and closure202 (v0 : string) () : leptos_Fragment =
    let v1 : string = "class=\"[height:17px]\""
    let v2 : (unit -> leptos_Fragment) = method129()
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v15 : (unit -> leptos_Fragment) = method165(v0)
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v15)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
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
and method164 (v0 : string) : (unit -> leptos_Fragment) =
    closure202(v0)
and closure191 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>) () : leptos_Fragment =
    let v3 : string = "Func0::new(move || $0())"
    let v4 : (unit -> bool) = closure192(v1)
    let v5 : Func0<bool> = Fable.Core.RustInterop.emitRustExpr v4 v3 
    let v6 : Func0<bool> = method157(v5)
    let v7 : (unit -> unit) = closure193(v0, v1)
    let v8 : string = "let v7 = $0"
    Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v9 : string = "class=\"flex gap-[10px] [align-items:center] inline-block rounded border border-gray-400 hover:bg-gray-400 px-4 py-1 text-sm font-medium text-gray-900 bg-transparent hover:text-gray-600 focus:outline-none focus:ring active:text-gray-500\""
    let v10 : string = "prop:disabled=move || v6()"
    let v11 : string = "on:click=move |_| v7()"
    let v12 : (unit -> leptos_Fragment) = method158(v5)
    let v13 : string = ""
    let v14 : string = " " + v9 + v13 + ""
    let v15 : string = " " + v10 + v14 + ""
    let v16 : string = " " + v11 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v12)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
    let v19 : string = "button"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : leptos_HtmlElement<leptos_html_Button> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = $"$0()"
    let v27 : string option = Fable.Core.RustInterop.emitRustExpr v2 v26 
    let v30 : US34 option = None
    let _v30 = ref v30 
    match v27 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v31 : string = x
    let v32 : US34 = US34_0(v31)
    v32 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v30.Value <- x
    let v33 : US34 option = _v30.Value 
    let v56 : US34 = US34_1
    let v57 : US34 = v33 |> Option.defaultValue v56 
    let v82 : leptos_View =
        match v57 with
        | US34_0(v65) -> (* Some *)
            let v66 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v67 : (unit -> leptos_Fragment) = method164(v65)
            let v68 : string = " " + v66 + v13 + ""
            let v69 : (unit -> leptos_Fragment) = method132(v67)
            let v70 : (unit -> leptos_Fragment) = method133(v69)
            let v71 : string = "div"
            let v72 : string = "<" + v71 + " " + v68 + ">{v70()}</" + v71 + ">"
            let v73 : string = "leptos::view! { " + v72 + " }"
            let v74 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v73 
            let v75 : leptos_HtmlElement<leptos_html_Div> = v74 |> unbox
            let v76 : string = "leptos::IntoView::into_view($0)"
            let v77 : leptos_View = Fable.Core.RustInterop.emitRustExpr v75 v76 
            v77
        | _ ->
            let v78 : (leptos_View []) = [||]
            let v79 : (leptos_View []) = method122(v78)
            let v80 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v81 : leptos_View = Fable.Core.RustInterop.emitRustExpr v79 v80 
            v81
    let v83 : (leptos_View []) = [|v25; v82|]
    let v84 : string = "$0.to_vec()"
    let v85 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "leptos::Fragment::new($0)"
    let v87 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v85 v86 
    v87
and method156 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>) : (unit -> leptos_Fragment) =
    closure191(v0, v1, v2)
and closure152 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v5 : string = "class=\"flex [flex-direction:column] [gap:2px] [align-items:flex-start]\""
    let v6 : (unit -> leptos_Fragment) = method125(v0, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=\"flex [flex-direction:column] [gap:2px] [align-items:flex-start]\""
    let v19 : (unit -> leptos_Fragment) = method153(v0)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
    let v23 : string = "<" + v11 + " " + v20 + ">{v22()}</" + v11 + ">"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : leptos_HtmlElement<leptos_html_Div> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "class=\"flex\""
    let v30 : (unit -> leptos_Fragment) = method156(v0, v1, v2)
    let v31 : string = " " + v29 + v7 + ""
    let v32 : (unit -> leptos_Fragment) = method132(v30)
    let v33 : (unit -> leptos_Fragment) = method133(v32)
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
and method124 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure152(v0, v1, v2, v3, v4)
and closure204 () (v0 : leptos_HtmlElement<leptos_html_Div>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure151 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) () : leptos_Fragment =
    let v5 : string = "class=\"flex flex-col p-[10px] gap-[11px]\""
    let v6 : (unit -> leptos_Fragment) = method124(v0, v1, v2, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "div"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Div> = v14 |> unbox
    let v16 : (leptos_HtmlElement<leptos_html_Div> []) = [|v15|]
    let v17 : string = "$0.to_vec()"
    let v18 : Vec<leptos_HtmlElement<leptos_html_Div>> = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v19 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v20 : (leptos_HtmlElement<leptos_html_Div> -> leptos_View) = closure204()
    let v21 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19 
    let v22 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v23 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "leptos::Fragment::new($0)"
    let v27 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v25 v26 
    v27
and method123 (v0 : Heap2, v1 : leptos_Action<Heap6, Result<US60, std_string_String>>, v2 : leptos_Memo<string option>, v3 : leptos_Memo<US34>, v4 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>>) : (unit -> leptos_Fragment) =
    closure151(v0, v1, v2, v3, v4)
and closure206 () () : string =
    let v0 : string = ""
    v0
and closure207 () () : bool =
    true
and closure209 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure210 () () : Ref<Lifetime<StaticLifetime, Str>> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure213 () () : string =
    let v0 : string = "Roll"
    v0
and method170 () : (unit -> string) =
    closure213()
and closure212 () () : leptos_Fragment =
    let v0 : (unit -> string) = method170()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method149(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method169 () : (unit -> leptos_Fragment) =
    closure212()
and closure211 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method169()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method150()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method168 () : (unit -> leptos_Fragment) =
    closure211()
and closure208 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure209()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v4 : string = "$0"
    let v5 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure210()
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method168()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method132(v8)
    let v12 : (unit -> leptos_Fragment) = method133(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method152(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method132(v21)
    let v24 : (unit -> leptos_Fragment) = method133(v23)
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
and method167 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure208(v0)
and closure205 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method167(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method166 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure205(v0, v1)
and closure216 () () : leptos_Fragment =
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
and method173 () : (unit -> leptos_Fragment) =
    closure216()
and closure215 () () : leptos_Fragment =
    let v0 : string = "class=\"[height:17px]\""
    let v1 : (unit -> leptos_Fragment) = method129()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "span"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Span> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"[overflow-y:auto] [text-wrap:wrap]\""
    let v14 : (unit -> leptos_Fragment) = method173()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method172 () : (unit -> leptos_Fragment) =
    closure215()
and closure218 () struct (v0 : std_string_String, v1 : std_string_String option) : struct (string * US34) =
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v6 : US15 option = None
    let _v6 = ref v6 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v7 : std_string_String = x
    let v8 : US15 = US15_0(v7)
    v8 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v6.Value <- x
    let v9 : US15 option = _v6.Value 
    let v32 : US15 = US15_1
    let v33 : US15 = v9 |> Option.defaultValue v32 
    let v47 : US34 =
        match v33 with
        | US15_1 -> (* None *)
            US34_1
        | US15_0(v41) -> (* Some *)
            let v42 : string = "fable_library_rust::String_::fromString($0)"
            let v43 : string = Fable.Core.RustInterop.emitRustExpr v41 v42 
            US34_0(v43)
    struct (v3, v47)
and closure219 () struct (v0 : string, v1 : US34) : bool =
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
and method175 () : (struct (string * US34) -> bool) =
    closure219()
and method176 (v0 : Vec<struct (string * US34)>) : Vec<struct (string * US34)> =
    v0
and closure217 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : bool =
    let v3 : (struct (std_string_String * std_string_String option) []) = v2.l7
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v7 : (struct (std_string_String * std_string_String option) -> struct (string * US34)) = closure218()
    let v8 : Vec<struct (string * US34)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6 
    let v9 : (struct (string * US34) -> bool) = method175()
    let v10 : Vec<struct (string * US34)> = method176(v8)
    let v11 : string = "v10.into_iter().filter(|x| v9(x.clone().clone())).collect::<Vec<_>>()"
    let v12 : Vec<struct (string * US34)> = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (struct (string * US34) []) = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : int32 = v14.Length
    let v16 : bool = v15 > 0
    let v17 : std_string_String = v2.l2
    let v18 : string = "fable_library_rust::String_::fromString($0)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : bool = v0 = v19
    let v21 : bool = v16 && v20
    v21
and method174 () : (struct (string * unativeint * Heap5) -> bool) =
    closure217()
and method177 (v0 : Vec<struct (string * unativeint * Heap5)>) : Vec<struct (string * unativeint * Heap5)> =
    v0
and closure221 () () : leptos_Fragment =
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
and method179 () : (unit -> leptos_Fragment) =
    closure221()
and closure222 () () : leptos_Fragment =
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
and method180 () : (unit -> leptos_Fragment) =
    closure222()
and closure223 () () : leptos_Fragment =
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
and method181 () : (unit -> leptos_Fragment) =
    closure223()
and closure224 () () : leptos_Fragment =
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
and method182 () : (unit -> leptos_Fragment) =
    closure224()
and closure225 () () : leptos_Fragment =
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
and method183 () : (unit -> leptos_Fragment) =
    closure225()
and closure226 () () : leptos_Fragment =
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
and method184 () : (unit -> leptos_Fragment) =
    closure226()
and closure220 () () : leptos_Fragment =
    let v0 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v1 : (unit -> leptos_Fragment) = method179()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "th"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Th> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v14 : (unit -> leptos_Fragment) = method180()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
    let v18 : string = "<" + v6 + " " + v15 + ">{v17()}</" + v6 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : leptos_HtmlElement<leptos_html_Th> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v25 : (unit -> leptos_Fragment) = method181()
    let v26 : string = " " + v24 + v2 + ""
    let v27 : (unit -> leptos_Fragment) = method132(v25)
    let v28 : (unit -> leptos_Fragment) = method133(v27)
    let v29 : string = "<" + v6 + " " + v26 + ">{v28()}</" + v6 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : leptos_HtmlElement<leptos_html_Th> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v36 : (unit -> leptos_Fragment) = method182()
    let v37 : string = " " + v35 + v2 + ""
    let v38 : (unit -> leptos_Fragment) = method132(v36)
    let v39 : (unit -> leptos_Fragment) = method133(v38)
    let v40 : string = "<" + v6 + " " + v37 + ">{v39()}</" + v6 + ">"
    let v41 : string = "leptos::view! { " + v40 + " }"
    let v42 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : leptos_HtmlElement<leptos_html_Th> = v42 |> unbox
    let v44 : string = "leptos::IntoView::into_view($0)"
    let v45 : leptos_View = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let v46 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v47 : (unit -> leptos_Fragment) = method183()
    let v48 : string = " " + v46 + v2 + ""
    let v49 : (unit -> leptos_Fragment) = method132(v47)
    let v50 : (unit -> leptos_Fragment) = method133(v49)
    let v51 : string = "<" + v6 + " " + v48 + ">{v50()}</" + v6 + ">"
    let v52 : string = "leptos::view! { " + v51 + " }"
    let v53 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v52 
    let v54 : leptos_HtmlElement<leptos_html_Th> = v53 |> unbox
    let v55 : string = "leptos::IntoView::into_view($0)"
    let v56 : leptos_View = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v58 : (unit -> leptos_Fragment) = method184()
    let v59 : string = " " + v57 + v2 + ""
    let v60 : (unit -> leptos_Fragment) = method132(v58)
    let v61 : (unit -> leptos_Fragment) = method133(v60)
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
and method178 () : (unit -> leptos_Fragment) =
    closure220()
and method187 (v0 : int64) : int64 =
    v0
and closure229 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l5
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : (string -> int64) = int64
    let v5 : int64 = v4 v3
    let v6 : int64 = method187(v5)
    let v7 : int64 = v6 / 1000L
    let v8 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v9 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v12 : US71 option = None
    let _v12 = ref v12 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v13 : chrono_DateTime<chrono_Utc> = x
    let v14 : US71 = US71_0(v13)
    v14 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v12.Value <- x
    let v15 : US71 option = _v12.Value 
    let v38 : US71 = US71_1
    let v39 : US71 = v15 |> Option.defaultValue v38 
    let v62 : US34 =
        match v39 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v47) -> (* Some *)
            let v48 : string = "$0.naive_utc()"
            let v49 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v51 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : string = "%Y-%m-%d %H:%M:%S"
            let v53 : string = "r#\"" + v52 + "\"#"
            let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "$0.format($1).to_string()"
            let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v51, v54) v55 
            let v57 : string = "fable_library_rust::String_::fromString($0)"
            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
            US34_0(v58)
    let v68 : US72 =
        match v62 with
        | US34_1 -> (* None *)
            let v65 : string = "resultm.from_option / Option does not have a value."
            US72_1(v65)
        | US34_0(v63) -> (* Some *)
            US72_0(v63)
    let v73 : string =
        match v68 with
        | US72_1(v70) -> (* Error *)
            let v71 : string = "sm'.to_string result / Error: " + v70 + ""
            v71
        | US72_0(v69) -> (* Ok *)
            v69
    let v74 : string = "&*$0"
    let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v74 
    let v76 : string = "String::from($0)"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "leptos::html::text($0)"
    let v79 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let v80 : string = "leptos::IntoView::into_view($0)"
    let v81 : leptos_View = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : (leptos_View []) = [|v81|]
    let v83 : string = "$0.to_vec()"
    let v84 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "leptos::Fragment::new($0)"
    let v86 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v84 v85 
    v86
and method186 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure229(v0)
and closure230 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l1
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
and method188 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure230(v0)
and closure231 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l2
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
and method189 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure231(v0)
and closure232 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l10
    let v4 : (float -> string) = _.ToString()
    let v5 : string = v4 v1
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v12 
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
and method190 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure232(v0)
and method192 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure233 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (std_string_String []) = v0.l11
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
        while method192(v18, v20) do
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
and method191 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure233(v0)
and closure234 (v0 : Heap5, v1 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) () : leptos_Fragment =
    let v2 : bool = v0.l9
    let v5 : string =
        if v2 then
            let v3 : string = "Ok"
            v3
        else
            let v4 : string = "Outcome Error"
            v4
    let v6 : (struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option -> US66) = closure142()
    let v7 : (std_string_String -> US66) = closure143()
    let v8 : US66 = match v1 with Ok x -> v6 x | Error x -> v7 x
    let v57 : US62 =
        match v8 with
        | US66_1(v54) -> (* Error *)
            US62_1(v54)
        | US66_0(v9) -> (* Ok *)
            let v12 : US60 option = None
            let _v12 = ref v12 
            match v9 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let struct (v13 : std_string_String, v14 : struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option, v15 : struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option, v16 : std_string_String option) = x
            let v17 : US60 = US60_0(v13, v14, v15, v16)
            v17 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v12.Value <- x
            let v18 : US60 option = _v12.Value 
            let v44 : US60 = US60_1
            let v45 : US60 = v18 |> Option.defaultValue v44 
            US62_0(v45)
    let v221 : US72 =
        match v57 with
        | US62_1(v216) -> (* Error *)
            let v217 : string = "fable_library_rust::String_::fromString($0)"
            let v218 : string = Fable.Core.RustInterop.emitRustExpr v216 v217 
            US72_1(v218)
        | US62_0(v58) -> (* Ok *)
            match v58 with
            | US60_0(v59, v60, v61, v62) -> (* Some *)
                let v65 : US67 option = None
                let _v65 = ref v65 
                match v61 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let struct (v66 : std_string_String, v67 : std_string_String, v68 : struct (std_string_String option * std_string_String option) option, v69 : int32, v70 : std_string_String, v71 : std_string_String) = x
                let v72 : US67 = US67_0(v66, v67, v68, v69, v70, v71)
                v72 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v65.Value <- x
                let v73 : US67 option = _v65.Value 
                let v101 : US67 = US67_1
                let v102 : US67 = v73 |> Option.defaultValue v101 
                match v102 with
                | US67_1 -> (* None *)
                    let v190 : string = $"%A{struct (v59, v60, v61, v62)}"
                    let v197 : int64 = 400L
                    let v198 : string = method8(v197, v190)
                    US72_0(v198)
                | US67_0(v110, v111, v112, v113, v114, v115) -> (* Some *)
                    let v118 : US67 option = None
                    let _v118 = ref v118 
                    match v61 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let struct (v119 : std_string_String, v120 : std_string_String, v121 : struct (std_string_String option * std_string_String option) option, v122 : int32, v123 : std_string_String, v124 : std_string_String) = x
                    let v125 : US67 = US67_0(v119, v120, v121, v122, v123, v124)
                    v125 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v118.Value <- x
                    let v126 : US67 option = _v118.Value 
                    let v154 : US67 = US67_1
                    let v155 : US67 = v126 |> Option.defaultValue v154 
                    let v172 : US34 =
                        match v155 with
                        | US67_0(v163, v164, v165, v166, v167, v168) -> (* Some *)
                            let v169 : string = string v163 + ": " + string v167 + " - " + string v168 + " (" + string v164 + ")"
                            US34_0(v169)
                        | _ ->
                            US34_1
                    let v186 : string =
                        match v172 with
                        | US34_1 -> (* None *)
                            let v176 : string = $"%A{()}"
                            let v183 : int64 = 400L
                            method8(v183, v176)
                        | US34_0(v173) -> (* Some *)
                            v173
                    US72_1(v186)
            | _ ->
                let v204 : string = $"%A{v57}"
                let v211 : int64 = 400L
                let v212 : string = method8(v211, v204)
                let v213 : string = $"RPC Response: {v212}"
                US72_1(v213)
    let v238 : string =
        match v221 with
        | US72_1(v235) -> (* Error *)
            let v236 : string = $"Error: {v235}"
            v236
        | US72_0(v222) -> (* Ok *)
            let v225 : string = $"%A{v222}"
            let v232 : int64 = 400L
            let v233 : string = method8(v232, v225)
            let v234 : string = $"RPC Response: {v233}"
            v234
    let v239 : string = $"{v5} / {v238}"
    let v240 : string = "&*$0"
    let v241 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v239 v240 
    let v242 : string = "String::from($0)"
    let v243 : std_string_String = Fable.Core.RustInterop.emitRustExpr v241 v242 
    let v244 : string = "leptos::html::text($0)"
    let v245 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v243 v244 
    let v246 : string = "leptos::IntoView::into_view($0)"
    let v247 : leptos_View = Fable.Core.RustInterop.emitRustExpr v245 v246 
    let v248 : (leptos_View []) = [|v247|]
    let v249 : string = "$0.to_vec()"
    let v250 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v248 v249 
    let v251 : string = "leptos::Fragment::new($0)"
    let v252 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v250 v251 
    v252
and method193 (v0 : Heap5, v1 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) : (unit -> leptos_Fragment) =
    closure234(v0, v1)
and closure228 (v0 : Heap5, v1 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) () : leptos_Fragment =
    let v2 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v3 : (unit -> leptos_Fragment) = method186(v0)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method132(v3)
    let v7 : (unit -> leptos_Fragment) = method133(v6)
    let v8 : string = "td"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : leptos_HtmlElement<leptos_html_Td> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v16 : (unit -> leptos_Fragment) = method188(v0)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method132(v16)
    let v19 : (unit -> leptos_Fragment) = method133(v18)
    let v20 : string = "<" + v8 + " " + v17 + ">{v19()}</" + v8 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : leptos_HtmlElement<leptos_html_Td> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v27 : (unit -> leptos_Fragment) = method189(v0)
    let v28 : string = " " + v26 + v4 + ""
    let v29 : (unit -> leptos_Fragment) = method132(v27)
    let v30 : (unit -> leptos_Fragment) = method133(v29)
    let v31 : string = "<" + v8 + " " + v28 + ">{v30()}</" + v8 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : leptos_HtmlElement<leptos_html_Td> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v38 : (unit -> leptos_Fragment) = method190(v0)
    let v39 : string = " " + v37 + v4 + ""
    let v40 : (unit -> leptos_Fragment) = method132(v38)
    let v41 : (unit -> leptos_Fragment) = method133(v40)
    let v42 : string = "<" + v8 + " " + v39 + ">{v41()}</" + v8 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : leptos_HtmlElement<leptos_html_Td> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v49 : (unit -> leptos_Fragment) = method191(v0)
    let v50 : string = " " + v48 + v4 + ""
    let v51 : (unit -> leptos_Fragment) = method132(v49)
    let v52 : (unit -> leptos_Fragment) = method133(v51)
    let v53 : string = "<" + v8 + " " + v50 + ">{v52()}</" + v8 + ">"
    let v54 : string = "leptos::view! { " + v53 + " }"
    let v55 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v54 
    let v56 : leptos_HtmlElement<leptos_html_Td> = v55 |> unbox
    let v57 : string = "leptos::IntoView::into_view($0)"
    let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let v59 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v60 : (unit -> leptos_Fragment) = method193(v0, v1)
    let v61 : string = " " + v59 + v4 + ""
    let v62 : (unit -> leptos_Fragment) = method132(v60)
    let v63 : (unit -> leptos_Fragment) = method133(v62)
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
and method185 (v0 : Heap5, v1 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) : (unit -> leptos_Fragment) =
    closure228(v0, v1)
and closure227 (v0 : Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>) struct (v1 : string, v2 : unativeint, v3 : Heap5) : leptos_View =
    let v4 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v5 : (Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> []) = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : (unativeint -> int32) = int32
    let v7 : int32 = v6 v2
    let v8 : Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String> = v5.[int v7]
    let v9 : string = "class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\""
    let v10 : (unit -> leptos_Fragment) = method185(v3, v8)
    let v11 : string = ""
    let v12 : string = " " + v9 + v11 + ""
    let v13 : (unit -> leptos_Fragment) = method132(v10)
    let v14 : (unit -> leptos_Fragment) = method133(v13)
    let v15 : string = "tr"
    let v16 : string = "<" + v15 + " " + v12 + ">{v14()}</" + v15 + ">"
    let v17 : string = "leptos::view! { " + v16 + " }"
    let v18 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : leptos_HtmlElement<leptos_html_Tr> = v18 |> unbox
    let v20 : string = "leptos::IntoView::into_view($0)"
    let v21 : leptos_View = Fable.Core.RustInterop.emitRustExpr v19 v20 
    v21
and closure236 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method195 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure236(v0)
and closure237 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method196 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure237(v0)
and closure235 (v0 : leptos_Fragment, v1 : leptos_Fragment) () : leptos_Fragment =
    let v2 : string = "class=\"ltr:text-left rtl:text-right\""
    let v3 : (unit -> leptos_Fragment) = method195(v0)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method132(v3)
    let v7 : (unit -> leptos_Fragment) = method133(v6)
    let v8 : string = "thead"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : leptos_HtmlElement<leptos_html_Thead> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "class=\"divide-y divide-gray-200 dark:divide-gray-700\""
    let v16 : (unit -> leptos_Fragment) = method196(v1)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method132(v16)
    let v19 : (unit -> leptos_Fragment) = method133(v18)
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
and method194 (v0 : leptos_Fragment, v1 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure235(v0, v1)
and closure240 () () : string =
    let v0 : string = "[width:24px] [height:30px]"
    v0
and closure239 () () : leptos_Fragment =
    let v0 : string = "$0"
    let v1 : (unit -> string) = closure240()
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
    let v12 : (unit -> leptos_Fragment) = method159()
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
    let v23 : (unit -> leptos_Fragment) = method132(v12)
    let v24 : (unit -> leptos_Fragment) = method133(v23)
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
and method198 () : (unit -> leptos_Fragment) =
    closure239()
and closure238 () () : leptos_Fragment =
    let v0 : string = "class=\"flex flex-1 [gap:4px] items-center\""
    let v1 : (unit -> leptos_Fragment) = method198()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
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
and method197 () : (unit -> leptos_Fragment) =
    closure238()
and closure214 (v0 : leptos_Memo<Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>>, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>>) () : leptos_Fragment =
    let v3 : string = $"$0()"
    let v4 : Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v6 : (struct (string * Vec<struct (string * US25 * string * bool * bool)>) []) = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : uint64 = System.Convert.ToUInt64 v6.Length
    let v8 : bool = v7 = 0UL
    let v149 : leptos_View =
        if v8 then
            let v9 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v10 : (unit -> leptos_Fragment) = method172()
            let v11 : string = ""
            let v12 : string = " " + v9 + v11 + ""
            let v13 : (unit -> leptos_Fragment) = method132(v10)
            let v14 : (unit -> leptos_Fragment) = method133(v13)
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
            let v24 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure106()
            let v25 : (std_string_String -> US56) = closure107()
            let v26 : US56 = match v23 with Ok x -> v24 x | Error x -> v25 x
            let v69 : US49 =
                match v26 with
                | US56_1(v66) -> (* Error *)
                    US49_1(v66)
                | US56_0(v27) -> (* Ok *)
                    let v30 : US50 option = None
                    let _v30 = ref v30 
                    match v27 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v31 : (struct (string * unativeint * Heap5) []) = x
                    let v32 : US50 = US50_0(v31)
                    v32 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v30.Value <- x
                    let v33 : US50 option = _v30.Value 
                    let v56 : US50 = US50_1
                    let v57 : US50 = v33 |> Option.defaultValue v56 
                    US49_0(v57)
            match v69 with
            | US49_1(v131) -> (* Error *)
                let v132 : string = "fable_library_rust::String_::fromString($0)"
                let v133 : string = Fable.Core.RustInterop.emitRustExpr v131 v132 
                let v134 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
                let v135 : (unit -> leptos_Fragment) = method164(v133)
                let v136 : string = ""
                let v137 : string = " " + v134 + v136 + ""
                let v138 : (unit -> leptos_Fragment) = method132(v135)
                let v139 : (unit -> leptos_Fragment) = method133(v138)
                let v140 : string = "div"
                let v141 : string = "<" + v140 + " " + v137 + ">{v139()}</" + v140 + ">"
                let v142 : string = "leptos::view! { " + v141 + " }"
                let v143 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v142 
                let v144 : leptos_HtmlElement<leptos_html_Div> = v143 |> unbox
                let v145 : string = "leptos::IntoView::into_view($0)"
                let v146 : leptos_View = Fable.Core.RustInterop.emitRustExpr v144 v145 
                v146
            | US49_0(v70) -> (* Ok *)
                match v70 with
                | US50_0(v71) -> (* Some *)
                    let v72 : string = "$0.to_vec()"
                    let v73 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v71 v72 
                    let v74 : (struct (string * unativeint * Heap5) -> bool) = method174()
                    let v75 : Vec<struct (string * unativeint * Heap5)> = method177(v73)
                    let v76 : string = "v75.into_iter().filter(|x| v74(x.clone().clone())).collect::<Vec<_>>()"
                    let v77 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr () v76 
                    let v78 : (unit -> leptos_Fragment) = method178()
                    let v79 : (unit -> leptos_Fragment) = method132(v78)
                    let v80 : (unit -> leptos_Fragment) = method133(v79)
                    let v81 : string = "tr"
                    let v82 : string = ""
                    let v83 : string = "<" + v81 + " " + v82 + ">{v80()}</" + v81 + ">"
                    let v84 : string = "leptos::view! { " + v83 + " }"
                    let v85 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v84 
                    let v86 : leptos_HtmlElement<leptos_html_Tr> = v85 |> unbox
                    let v87 : string = "leptos::IntoView::into_view($0)"
                    let v88 : leptos_View = Fable.Core.RustInterop.emitRustExpr v86 v87 
                    let v89 : (leptos_View []) = [|v88|]
                    let v90 : string = "$0.to_vec()"
                    let v91 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v89 v90 
                    let v92 : string = "leptos::Fragment::new($0)"
                    let v93 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v91 v92 
                    let v94 : string = $"$0()"
                    let v95 : Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v0 v94 
                    let v96 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v97 : (struct (string * unativeint * Heap5) -> leptos_View) = closure227(v95)
                    let v98 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v77, v97) v96 
                    let v99 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v100 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : string = "$0.to_vec()"
                    let v102 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v100 v101 
                    let v103 : string = "leptos::Fragment::new($0)"
                    let v104 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v102 v103 
                    let v105 : string = "class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\""
                    let v106 : (unit -> leptos_Fragment) = method194(v93, v104)
                    let v107 : string = " " + v105 + v82 + ""
                    let v108 : (unit -> leptos_Fragment) = method132(v106)
                    let v109 : (unit -> leptos_Fragment) = method133(v108)
                    let v110 : string = "table"
                    let v111 : string = "<" + v110 + " " + v107 + ">{v109()}</" + v110 + ">"
                    let v112 : string = "leptos::view! { " + v111 + " }"
                    let v113 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v112 
                    let v114 : leptos_HtmlElement<leptos_html_Table> = v113 |> unbox
                    let v115 : string = "leptos::IntoView::into_view($0)"
                    let v116 : leptos_View = Fable.Core.RustInterop.emitRustExpr v114 v115 
                    v116
                | _ ->
                    let v117 : string = "class=\"grid place-content-center py-[10vh]\""
                    let v118 : (unit -> leptos_Fragment) = method197()
                    let v119 : string = ""
                    let v120 : string = " " + v117 + v119 + ""
                    let v121 : (unit -> leptos_Fragment) = method132(v118)
                    let v122 : (unit -> leptos_Fragment) = method133(v121)
                    let v123 : string = "div"
                    let v124 : string = "<" + v123 + " " + v120 + ">{v122()}</" + v123 + ">"
                    let v125 : string = "leptos::view! { " + v124 + " }"
                    let v126 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v125 
                    let v127 : leptos_HtmlElement<leptos_html_Div> = v126 |> unbox
                    let v128 : string = "leptos::IntoView::into_view($0)"
                    let v129 : leptos_View = Fable.Core.RustInterop.emitRustExpr v127 v128 
                    v129
    let v150 : (leptos_View []) = [|v149|]
    let v151 : string = "$0.to_vec()"
    let v152 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v150 v151 
    let v153 : string = "leptos::Fragment::new($0)"
    let v154 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v152 v153 
    v154
and method171 (v0 : leptos_Memo<Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>>, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>>) : (unit -> leptos_Fragment) =
    closure214(v0, v1, v2)
and closure243 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure244 () () : Ref<Lifetime<StaticLifetime, Str>> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure247 () () : string =
    let v0 : string = "History"
    v0
and method203 () : (unit -> string) =
    closure247()
and closure246 () () : leptos_Fragment =
    let v0 : (unit -> string) = method203()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method149(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method202 () : (unit -> leptos_Fragment) =
    closure246()
and closure245 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method202()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method150()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method201 () : (unit -> leptos_Fragment) =
    closure245()
and closure242 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure243()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v4 : string = "$0"
    let v5 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure244()
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method201()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method132(v8)
    let v12 : (unit -> leptos_Fragment) = method133(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method152(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method132(v21)
    let v24 : (unit -> leptos_Fragment) = method133(v23)
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
and method200 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure242(v0)
and closure241 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method200(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method199 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure241(v0, v1)
and closure250 (v0 : int32) (v1 : (bool * std_string_String)) : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) =
    let v2 : string = $"leptos::create_signal($0)"
    let struct (v3 : leptos_ReadSignal<(bool * std_string_String)>, v4 : leptos_WriteSignal<(bool * std_string_String)>) = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v5 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = v0, struct (v3, v4) 
    v5
and closure249 () (v0 : int32) : ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) =
    closure250(v0)
and method204 () : (int32 -> ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)))) =
    closure249()
and method205 (v0 : Vec<(bool * std_string_String)>) : Vec<(bool * std_string_String)> =
    v0
and closure248 (v0 : Heap2) () : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<Heap0> = v3.l3
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : Vec<(bool * std_string_String)> = v6.l0
    let v8 : (int32 -> ((bool * std_string_String) -> (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)))) = method204()
    let v9 : Vec<(bool * std_string_String)> = method205(v7)
    let v10 : string = "v9.iter().enumerate().map(|(i, x)| v8(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v11 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v10 
    v11
and closure252 () (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>) =
    let (a, b) = v0 
    let v3 : int32 = a
    let struct (v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : leptos_WriteSignal<(bool * std_string_String)>) = b
    struct (v3, v4, v5)
and closure253 (v0 : int32) struct (v1 : int32, v2 : leptos_ReadSignal<(bool * std_string_String)>, v3 : leptos_WriteSignal<(bool * std_string_String)>) : struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) =
    struct (v0, v1, v2)
and closure251 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v1 : leptos_ReadSignal<int32>) () : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> =
    let v2 : string = $"leptos::SignalGet::get(&$0)"
    let v3 : int32 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = $"$0()"
    let v5 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v7 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = closure252()
    let v8 : Vec<struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6 
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v10 : (struct (int32 * leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>) -> struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)) = closure253(v3)
    let v11 : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9 
    v11
and closure254 (v0 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>) () : int32 =
    let v1 : string = $"$0()"
    let v2 : Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v4 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) []) = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : int32 = v4.Length
    v5
and method206 (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) =
    v0
and method207 (v0 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    v0
and closure258 () (v0 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : (bool * std_string_String) =
    let (a, b) = v0 
    let v3 : int32 = a
    let struct (v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : leptos_WriteSignal<(bool * std_string_String)>) = b
    let v16 : string = $"leptos::SignalGet::get(&$0)"
    let v17 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v4 v16 
    v17
and closure257 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>) (v1 : Heap0) : Heap0 =
    let v2 : Vec<(bool * std_string_String)> = v1.l0
    let v3 : std_string_String option = v1.l1
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
    let v22 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) = method206(v21)
    let v23 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = method207(v8)
    let v24 : string = "true; let mut v23 = v23"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "true; v23.push(v22)"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "v23"
    let v29 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v31 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> (bool * std_string_String)) = closure258()
    let v32 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v30 
    {l0 = v32; l1 = v3; l2 = v4; l3 = v5; l4 = v6} : Heap0
and closure259 () (v0 : int32) : int32 =
    let v1 : int32 = 1 + v0
    v1
and closure256 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>) () : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : leptos_RwSignal<Heap0> = v5.l3
    let v7 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v8 : (Heap0 -> Heap0) = closure257(v1)
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr struct (v6, v8) v7 
    let v10 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v11 : (int32 -> int32) = closure259()
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v11) v10 
    ()
and closure255 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>) () : unit =
    let v3 : string = "true; leptos::batch(move || $0());"
    let v4 : (unit -> unit) = closure256(v0, v1, v2)
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v4 v3 
    ()
and closure260 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure261 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M12 6v12m6-6H6\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method208 () : (unit -> leptos_Fragment) =
    closure261()
and closure262 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = " bg-gray-300 hover:bg-gray-200"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and closure263 (v0 : leptos_HtmlElement<leptos_svg_Svg>) () : leptos_Fragment =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : (leptos_View []) = [|v2|]
    let v4 : string = "$0.to_vec()"
    let v5 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "leptos::Fragment::new($0)"
    let v7 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v5 v6 
    v7
and method209 (v0 : leptos_HtmlElement<leptos_svg_Svg>) : (unit -> leptos_Fragment) =
    closure263(v0)
and method212 (v0 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>) : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> =
    v0
and closure266 () struct (v0 : int32, v1 : int32, v2 : leptos_ReadSignal<(bool * std_string_String)>) : struct (int32 * int32) =
    struct (v0, v1)
and method213 () : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> struct (int32 * int32)) =
    closure266()
and method216 (v0 : int32) : int32 =
    v0
and closure269 (v0 : int32) () : std_string_String =
    let v1 : string = "account-" + string v0 + ""
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    v5
and method219 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure273 (v0 : int32, v1 : int32) (v2 : (bool * std_string_String)) : (bool * std_string_String) =
    let v3 : bool = v1 = v0
    let v4 : bool = method219(v3)
    if v4 then
        v2
    else
        let (a, b) = v2 
        let v7 : bool = a
        let v8 : std_string_String = b
        let v17 : bool = v7 = false
        let v18 : (bool * std_string_String) = v17, v8 
        v18
and closure272 (v0 : int32) (v1 : int32) : ((bool * std_string_String) -> (bool * std_string_String)) =
    closure273(v0, v1)
and method218 (v0 : int32) : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) =
    closure272(v0)
and closure271 (v0 : Heap2, v1 : int32) (v2 : leptos_ev_Event) : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : leptos_RwSignal<Heap0> = v5.l3
    let v7 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v8 : Heap0 = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : Vec<(bool * std_string_String)> = v8.l0
    let v10 : std_string_String option = v8.l1
    let v11 : int32 = v8.l2
    let v12 : int32 = v8.l3
    let v13 : US1 = v8.l4
    let v14 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v15 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v14 
    let v16 : leptos_RwSignal<Heap0> = v15.l3
    let v17 : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) = method218(v1)
    let v18 : Vec<(bool * std_string_String)> = method205(v9)
    let v19 : string = "v18.iter().enumerate().map(|(i, x)| v17(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : Heap0 = {l0 = v20; l1 = v10; l2 = v11; l3 = v12; l4 = v13} : Heap0
    let v22 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr struct (v16, v21) v22 
    ()
and closure274 (v0 : leptos_ReadSignal<(bool * std_string_String)>) () : bool =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let (a, b) = v2 
    let v5 : bool = a
    let v6 : std_string_String = b
    v5
and method220 (v0 : leptos_ReadSignal<(bool * std_string_String)>) : (unit -> bool) =
    closure274(v0)
and method221 (v0 : int32) : (unit -> std_string_String) =
    closure269(v0)
and closure276 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method223 () : (unit -> leptos_Fragment) =
    closure276()
and closure277 () () : leptos_Fragment =
    let v0 : string = "fill-rule=\"evenodd\""
    let v1 : string = "d=\"M16.707 5.293a1 1 0 010 1.414l-8 8a1 1 0 01-1.414 0l-4-4a1 1 0 011.414-1.414L8 12.586l7.293-7.293a1 1 0 011.414 0z\""
    let v2 : string = "clip-rule=\"evenodd\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method224 () : (unit -> leptos_Fragment) =
    closure277()
and closure278 () (v0 : leptos_HtmlElement<leptos_svg_Svg>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure275 () () : leptos_Fragment =
    let v0 : string = "data-unchecked-icon"
    let v1 : string = "xmlns=\"http://www.w3.org/2000/svg\""
    let v2 : string = "class=\"h-4 w-4\""
    let v3 : string = "viewBox=\"0 0 20 20\""
    let v4 : string = "fill=\"currentColor\""
    let v5 : (unit -> leptos_Fragment) = method223()
    let v6 : string = ""
    let v7 : string = " " + v0 + v6 + ""
    let v8 : string = " " + v1 + v7 + ""
    let v9 : string = " " + v2 + v8 + ""
    let v10 : string = " " + v3 + v9 + ""
    let v11 : string = " " + v4 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v5)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
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
    let v24 : (unit -> leptos_Fragment) = method224()
    let v25 : string = " " + v19 + v6 + ""
    let v26 : string = " " + v20 + v25 + ""
    let v27 : string = " " + v21 + v26 + ""
    let v28 : string = " " + v22 + v27 + ""
    let v29 : string = " " + v23 + v28 + ""
    let v30 : (unit -> leptos_Fragment) = method132(v24)
    let v31 : (unit -> leptos_Fragment) = method133(v30)
    let v32 : string = "<" + v14 + " " + v29 + ">{v31()}</" + v14 + ">"
    let v33 : string = "leptos::view! { " + v32 + " }"
    let v34 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : leptos_HtmlElement<leptos_svg_Svg> = v34 |> unbox
    let v36 : (leptos_HtmlElement<leptos_svg_Svg> []) = [|v18; v35|]
    let v37 : string = "$0.to_vec()"
    let v38 : Vec<leptos_HtmlElement<leptos_svg_Svg>> = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v40 : (leptos_HtmlElement<leptos_svg_Svg> -> leptos_View) = closure278()
    let v41 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v38, v40) v39 
    let v42 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v43 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "$0.to_vec()"
    let v45 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let v46 : string = "leptos::Fragment::new($0)"
    let v47 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v45 v46 
    v47
and method222 () : (unit -> leptos_Fragment) =
    closure275()
and closure279 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method225 () : (unit -> leptos_Fragment) =
    closure279()
and closure270 (v0 : int32, v1 : leptos_ReadSignal<(bool * std_string_String)>, v2 : Heap2) () : leptos_Fragment =
    let v3 : (leptos_ev_Event -> unit) = closure271(v2, v0)
    let v4 : string = "let v3 = $0"
    Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v5 : (unit -> bool) = method220(v1)
    let v6 : (unit -> std_string_String) = method221(v0)
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
    let v26 : (unit -> leptos_Fragment) = method222()
    let v27 : string = " " + v25 + v12 + ""
    let v28 : (unit -> leptos_Fragment) = method132(v26)
    let v29 : (unit -> leptos_Fragment) = method133(v28)
    let v30 : string = "span"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : leptos_HtmlElement<leptos_html_Span> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v38 : (unit -> leptos_Fragment) = method225()
    let v39 : string = " " + v37 + v12 + ""
    let v40 : (unit -> leptos_Fragment) = method132(v38)
    let v41 : (unit -> leptos_Fragment) = method133(v40)
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
and method217 (v0 : int32, v1 : leptos_ReadSignal<(bool * std_string_String)>, v2 : Heap2) : (unit -> leptos_Fragment) =
    closure270(v0, v1, v2)
and closure280 (v0 : leptos_ReadSignal<(bool * std_string_String)>) () : std_string_String =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : (bool * std_string_String) = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let (a, b) = v2 
    let v5 : bool = a
    let v6 : std_string_String = b
    v6
and method226 (v0 : leptos_ReadSignal<(bool * std_string_String)>) : (unit -> std_string_String) =
    closure280(v0)
and method229 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure283 (v0 : int32, v1 : std_string_String, v2 : int32) (v3 : (bool * std_string_String)) : (bool * std_string_String) =
    let v4 : bool = v2 = v0
    let v5 : bool = method229(v4)
    if v5 then
        v3
    else
        let (a, b) = v3 
        let v8 : bool = a
        let v9 : std_string_String = b
        let v18 : (bool * std_string_String) = v8, v1 
        v18
and closure282 (v0 : int32, v1 : std_string_String) (v2 : int32) : ((bool * std_string_String) -> (bool * std_string_String)) =
    closure283(v0, v1, v2)
and method228 (v0 : int32, v1 : std_string_String) : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) =
    closure282(v0, v1)
and closure281 (v0 : Heap2, v1 : int32) (v2 : std_string_String) : unit =
    let v3 : leptos_RwSignal<Heap1> = v0.l0
    let v4 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v5 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : leptos_RwSignal<Heap0> = v5.l3
    let v7 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v8 : Heap0 = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : Vec<(bool * std_string_String)> = v8.l0
    let v10 : std_string_String option = v8.l1
    let v11 : int32 = v8.l2
    let v12 : int32 = v8.l3
    let v13 : US1 = v8.l4
    let v14 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v15 : Heap1 = Fable.Core.RustInterop.emitRustExpr v3 v14 
    let v16 : leptos_RwSignal<Heap0> = v15.l3
    let v17 : (int32 -> ((bool * std_string_String) -> (bool * std_string_String))) = method228(v1, v2)
    let v18 : Vec<(bool * std_string_String)> = method205(v9)
    let v19 : string = "v18.iter().enumerate().map(|(i, x)| v17(i.try_into().unwrap())(x.clone())).collect::<Vec<_>>()"
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : Heap0 = {l0 = v20; l1 = v10; l2 = v11; l3 = v12; l4 = v13} : Heap0
    let v22 : string = $"true; leptos::SignalSet::set(&$0, $1);"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr struct (v16, v21) v22 
    ()
and method227 (v0 : Heap2, v1 : int32) : (std_string_String -> unit) =
    closure281(v0, v1)
and closure284 () () : string =
    let v0 : string = "flex-1"
    v0
and method230 (v0 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> =
    v0
and closure289 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method232 () : (bool -> bool) =
    closure289()
and closure288 (v0 : int32) (v1 : (int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))) : bool =
    let (a, b) = v1 
    let v4 : int32 = a
    let struct (v5 : leptos_ReadSignal<(bool * std_string_String)>, v6 : leptos_WriteSignal<(bool * std_string_String)>) = b
    let v17 : bool = v4 = v0
    let v18 : (bool -> bool) = method232()
    v18 v17
and method231 (v0 : int32) : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> bool) =
    closure288(v0)
and closure287 (v0 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v1 : int32) (v2 : Heap0) : Heap0 =
    let v3 : Vec<(bool * std_string_String)> = v2.l0
    let v4 : std_string_String option = v2.l1
    let v5 : int32 = v2.l2
    let v6 : int32 = v2.l3
    let v7 : US1 = v2.l4
    let v8 : string = $"$0()"
    let v9 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = method230(v9)
    let v11 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> bool) = method231(v1)
    let v12 : string = "true; let mut v10 = v10"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "true; v10.retain(|x| v11(x.clone()))"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "v10"
    let v17 : Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : ((int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>)) -> (bool * std_string_String)) = closure258()
    let v20 : Vec<(bool * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    {l0 = v20; l1 = v4; l2 = v5; l3 = v6; l4 = v7} : Heap0
and closure286 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>, v3 : int32) () : unit =
    let v4 : leptos_RwSignal<Heap1> = v0.l0
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v6 : Heap1 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : leptos_RwSignal<Heap0> = v6.l3
    let v8 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v9 : (Heap0 -> Heap0) = closure287(v1, v3)
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8 
    let v11 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v12 : (int32 -> int32) = closure259()
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr struct (v2, v12) v11 
    ()
and closure285 (v0 : Heap2, v1 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v2 : leptos_WriteSignal<int32>, v3 : int32) () : unit =
    let v4 : string = "true; leptos::batch(move || $0());"
    let v5 : (unit -> unit) = closure286(v0, v1, v2, v3)
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v5 v4 
    ()
and closure290 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure291 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M6 6l12 12m0-12L6 18\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method233 () : (unit -> leptos_Fragment) =
    closure291()
and closure292 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = " pr-[7px] pl-[5px]"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and closure268 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>, v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : int32) () : leptos_Fragment =
    let v6 : int32 = method216(v5)
    let v7 : (unit -> std_string_String) = closure269(v6)
    let v8 : string = "let v7 = $0"
    Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v9 : string = "for=move || v7()"
    let v10 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v11 : (unit -> leptos_Fragment) = method217(v6, v4, v0)
    let v12 : string = ""
    let v13 : string = " " + v9 + v12 + ""
    let v14 : string = " " + v10 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method132(v11)
    let v16 : (unit -> leptos_Fragment) = method133(v15)
    let v17 : string = "label"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : leptos_HtmlElement<leptos_html_Label> = v20 |> unbox
    let v22 : string = "leptos::IntoView::into_view($0)"
    let v23 : leptos_View = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : (unit -> std_string_String) = method226(v4)
    let v25 : (std_string_String -> unit) = method227(v0, v6)
    let v26 : string = "$0"
    let v27 : (unit -> string) = closure284()
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
            let v46 : (leptos_View []) = method122(v45)
            let v47 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v48 : leptos_View = Fable.Core.RustInterop.emitRustExpr v46 v47 
            v48
        else
            let v49 : (unit -> unit) = closure285(v0, v2, v3, v6)
            let v50 : string = "let v49 = $0"
            Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v51 : string = "$0"
            let v52 : (unit -> string) = closure290()
            let v53 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v52 v51 
            let v54 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v55 : string = "fill=\"none\""
            let v56 : string = "viewBox=\"0 0 24 24\""
            let v57 : string = "stroke-width=\"1.5\""
            let v58 : string = "stroke=\"currentColor\""
            let v59 : string = "class=move || \" \".to_owned() + &v53(())"
            let v60 : (unit -> leptos_Fragment) = method233()
            let v61 : string = " " + v54 + v12 + ""
            let v62 : string = " " + v55 + v61 + ""
            let v63 : string = " " + v56 + v62 + ""
            let v64 : string = " " + v57 + v63 + ""
            let v65 : string = " " + v58 + v64 + ""
            let v66 : string = " " + v59 + v65 + ""
            let v67 : (unit -> leptos_Fragment) = method132(v60)
            let v68 : (unit -> leptos_Fragment) = method133(v67)
            let v69 : string = "svg"
            let v70 : string = "<" + v69 + " " + v66 + ">{v68()}</" + v69 + ">"
            let v71 : string = "leptos::view! { " + v70 + " }"
            let v72 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v71 
            let v73 : leptos_HtmlElement<leptos_svg_Svg> = v72 |> unbox
            let v74 : string = "on:click=move |_| v49()"
            let v75 : string = "aria-label=\"Delete\""
            let v76 : string = "$0"
            let v77 : (unit -> std_string_String) = closure292()
            let v78 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v77 v76 
            let v79 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v78(())"
            let v80 : (unit -> leptos_Fragment) = method209(v73)
            let v81 : string = " " + v79 + v12 + ""
            let v82 : string = " " + v74 + v81 + ""
            let v83 : string = " " + v75 + v82 + ""
            let v84 : (unit -> leptos_Fragment) = method132(v80)
            let v85 : (unit -> leptos_Fragment) = method133(v84)
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
and method215 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>, v4 : leptos_ReadSignal<(bool * std_string_String)>, v5 : int32) : (unit -> leptos_Fragment) =
    closure268(v0, v1, v2, v3, v4, v5)
and closure267 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>) struct (v4 : int32, v5 : int32, v6 : leptos_ReadSignal<(bool * std_string_String)>) : leptos_Fragment =
    let v7 : string = "class=\"flex gap-[8px] [align-items:center]\""
    let v8 : (unit -> leptos_Fragment) = method215(v0, v1, v2, v3, v6, v5)
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method132(v8)
    let v12 : (unit -> leptos_Fragment) = method133(v11)
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
and method214 (v0 : Heap2, v1 : leptos_Memo<int32>, v2 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v3 : leptos_WriteSignal<int32>) : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> leptos_Fragment) =
    closure267(v0, v1, v2, v3)
and closure265 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) () : leptos_Fragment =
    let v5 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> = method212(v1)
    let v6 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> struct (int32 * int32)) = method213()
    let v7 : (struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>) -> leptos_Fragment) = method214(v0, v2, v3, v4)
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
and method211 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) : (unit -> leptos_Fragment) =
    closure265(v0, v1, v2, v3, v4)
and closure264 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) () : leptos_Fragment =
    let v5 : string = "class=\"flex flex-1 flex-col p-[8px] gap-[8px]\""
    let v6 : (unit -> leptos_Fragment) = method211(v0, v1, v2, v3, v4)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
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
and method210 (v0 : Heap2, v1 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>>, v2 : leptos_Memo<int32>, v3 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>>, v4 : leptos_WriteSignal<int32>) : (unit -> leptos_Fragment) =
    closure264(v0, v1, v2, v3, v4)
and closure295 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure296 (v0 : leptos_View) () : Ref<Lifetime<StaticLifetime, Str>> =
    let v4 : string = "[margin-right:40px]"
    let v5 : string = "r#\"" + v4 + "\"#"
    let v6 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v5 
    v6
and closure299 () () : string =
    let v0 : string = "Accounts"
    v0
and method238 (v0 : leptos_View) : (unit -> string) =
    closure299()
and closure298 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (unit -> string) = method238(v0)
    let v2 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v3 : (unit -> leptos_Fragment) = method149(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method132(v3)
    let v7 : (unit -> leptos_Fragment) = method133(v6)
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
and method237 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure298(v0)
and closure297 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : string = "class=\"flex items-center gap-2\""
    let v2 : (unit -> leptos_Fragment) = method237(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v15 : (unit -> leptos_Fragment) = method150()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v15)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
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
and method236 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure297(v0)
and closure294 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure295()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure296(v0)
    let v7 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v7(()) + \" \" + &v4(())"
    let v9 : (unit -> leptos_Fragment) = method236(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "summary"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Summary> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=\"flex flex-1 flex-col\""
    let v22 : (unit -> leptos_Fragment) = method152(v1)
    let v23 : string = " " + v21 + v10 + ""
    let v24 : (unit -> leptos_Fragment) = method132(v22)
    let v25 : (unit -> leptos_Fragment) = method133(v24)
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
and method235 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure294(v0, v1)
and closure293 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method235(v0, v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method234 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure293(v0, v1)
and closure302 () () : leptos_Fragment =
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
and method241 () : (unit -> leptos_Fragment) =
    closure302()
and closure304 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = "dark-mode"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and closure307 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and closure306 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : leptos_RwSignal<bool> = v4.l0
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure307()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6 
    ()
and closure308 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<bool> = v3.l0
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    v6
and method244 (v0 : Heap2) : (unit -> bool) =
    closure308(v0)
and method245 () : (unit -> std_string_String) =
    closure304()
and closure305 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure306(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v3 : (unit -> bool) = method244(v0)
    let v4 : (unit -> std_string_String) = method245()
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
    let v24 : (unit -> leptos_Fragment) = method222()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v24)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method225()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method132(v36)
    let v39 : (unit -> leptos_Fragment) = method133(v38)
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
and method243 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure305(v0)
and closure303 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure304()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method243(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v5)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
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
and method242 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure303(v0)
and closure309 () () : string =
    let v0 : string = "items-center p-0"
    v0
and closure310 () () : string =
    let v0 : string = "pt-[9px] pr-[10px] pb-[11px] pl-[10px]"
    v0
and closure311 () () : string =
    let v0 : string = "sm:grid-cols-[150px_repeat(2,minmax(0,1fr))]"
    v0
and closure313 () () : string =
    let v0 : string = "[overflow:auto]"
    v0
and method247 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    v0
and closure312 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method246 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure312(v0, v1)
and closure314 () () : leptos_Fragment =
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
and method248 () : (unit -> leptos_Fragment) =
    closure314()
and closure316 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = "debug"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and closure318 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : leptos_RwSignal<bool> = v4.l1
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (bool -> bool) = closure307()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6 
    ()
and closure319 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<bool> = v3.l1
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    v6
and method251 (v0 : Heap2) : (unit -> bool) =
    closure319(v0)
and method252 () : (unit -> std_string_String) =
    closure316()
and closure317 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure318(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v3 : (unit -> bool) = method251(v0)
    let v4 : (unit -> std_string_String) = method252()
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
    let v24 : (unit -> leptos_Fragment) = method222()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v24)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method225()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method132(v36)
    let v39 : (unit -> leptos_Fragment) = method133(v38)
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
and method250 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure317(v0)
and closure315 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure316()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method250(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v5)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
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
and method249 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure315(v0)
and closure320 () () : string =
    let v0 : string = "items-center p-0"
    v0
and closure321 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method253 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure321(v0, v1)
and closure322 () (v0 : leptos_HtmlElement<leptos_html_Dl>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure301 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> leptos_Fragment) = method241()
    let v2 : (unit -> leptos_Fragment) = method242(v0)
    let v3 : string = "$0"
    let v4 : (unit -> string) = closure309()
    let v5 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v4 v3 
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure310()
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6 
    let v9 : string = "$0"
    let v10 : (unit -> string) = closure311()
    let v11 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v10 v9 
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v11(()) + \" \" + &v8(()) + \" \" + &v5(())"
    let v13 : (unit -> leptos_Fragment) = method246(v1, v2)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v13)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : (unit -> leptos_Fragment) = method248()
    let v24 : (unit -> leptos_Fragment) = method249(v0)
    let v25 : string = "$0"
    let v26 : (unit -> string) = closure320()
    let v27 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v26 v25 
    let v28 : string = "$0"
    let v29 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v28 
    let v30 : string = "$0"
    let v31 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v10 v30 
    let v32 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v31(()) + \" \" + &v29(()) + \" \" + &v27(())"
    let v33 : (unit -> leptos_Fragment) = method253(v23, v24)
    let v34 : string = " " + v32 + v14 + ""
    let v35 : (unit -> leptos_Fragment) = method132(v33)
    let v36 : (unit -> leptos_Fragment) = method133(v35)
    let v37 : string = "<" + v18 + " " + v34 + ">{v36()}</" + v18 + ">"
    let v38 : string = "leptos::view! { " + v37 + " }"
    let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : leptos_HtmlElement<leptos_html_Dl> = v39 |> unbox
    let v41 : (leptos_HtmlElement<leptos_html_Dl> []) = [|v22; v40|]
    let v42 : string = "$0.to_vec()"
    let v43 : Vec<leptos_HtmlElement<leptos_html_Dl>> = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v45 : (leptos_HtmlElement<leptos_html_Dl> -> leptos_View) = closure322()
    let v46 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v44 
    let v47 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v48 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : string = "$0.to_vec()"
    let v50 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "leptos::Fragment::new($0)"
    let v52 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v50 v51 
    v52
and method240 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure301(v0)
and closure300 (v0 : Heap2) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col p-[11px] gap-[11px]\""
    let v2 : (unit -> leptos_Fragment) = method240(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method239 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure300(v0)
and closure325 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure326 () () : Ref<Lifetime<StaticLifetime, Str>> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure329 () () : string =
    let v0 : string = "View"
    v0
and method258 () : (unit -> string) =
    closure329()
and closure328 () () : leptos_Fragment =
    let v0 : (unit -> string) = method258()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method149(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method257 () : (unit -> leptos_Fragment) =
    closure328()
and closure327 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method257()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method150()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method256 () : (unit -> leptos_Fragment) =
    closure327()
and closure324 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure325()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v4 : string = "$0"
    let v5 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure326()
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method256()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method132(v8)
    let v12 : (unit -> leptos_Fragment) = method133(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method152(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method132(v21)
    let v24 : (unit -> leptos_Fragment) = method133(v23)
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
and method255 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure324(v0)
and closure323 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method255(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method254 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure323(v0, v1)
and closure331 () () : leptos_Fragment =
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
and method260 () : (unit -> leptos_Fragment) =
    closure331()
and method262 (v0 : Heap2) : Heap2 =
    v0
and closure334 () (v0 : std_string_String) : US73 =
    US73_0(v0)
and closure335 () (v0 : std_string_String) : US73 =
    US73_1(v0)
and closure333 (v0 : Heap2) () : string =
    let v1 : string = "settings_view.global_state_log_render () / global_state_json memo"
    let v2 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : Heap2 = method262(v0)
    let v5 : string = "serde_json::to_string_pretty(&v4).map_err(|x| x.to_string())"
    let v6 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (std_string_String -> US73) = closure334()
    let v8 : (std_string_String -> US73) = closure335()
    let v9 : US73 = match v6 with Ok x -> v7 x | Error x -> v8 x
    match v9 with
    | US73_1(v13) -> (* Error *)
        let v14 : string = "Error: " + string v13 + ""
        v14
    | US73_0(v10) -> (* Ok *)
        let v11 : string = "fable_library_rust::String_::fromString($0)"
        let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11 
        v12
and closure336 () () : string =
    let v0 : string = ""
    v0
and closure337 (v0 : string) () : leptos_Fragment =
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
and method263 (v0 : string) : (unit -> leptos_Fragment) =
    closure337(v0)
and closure332 () () : leptos_Fragment =
    let v0 : string = "settings_view.global_state_log_render ()"
    let v1 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
    let v4 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "$0.unwrap()"
    let v6 : Heap2 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure333(v6)
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7 
    let v10 : string = "leptos::create_memo(move |_| { v9(()) })"
    let v11 : leptos_Memo<string> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : string = $"$0()"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0"
    let v15 : (unit -> string) = closure336()
    let v16 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v15 v14 
    let v17 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v16(())"
    let v18 : (unit -> leptos_Fragment) = method263(v13)
    let v19 : string = ""
    let v20 : string = " " + v17 + v19 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v18)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method261 () : (unit -> leptos_Fragment) =
    closure332()
and closure338 () () : string =
    let v0 : string = ""
    v0
and closure339 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method264 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure339(v0, v1)
and closure330 () () : leptos_Fragment =
    let v0 : (unit -> leptos_Fragment) = method260()
    let v1 : (unit -> leptos_Fragment) = method261()
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure338()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> string) = closure310()
    let v7 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "$0"
    let v9 : (unit -> string) = closure311()
    let v10 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v9 v8 
    let v11 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v10(()) + \" \" + &v7(()) + \" \" + &v4(())"
    let v12 : (unit -> leptos_Fragment) = method264(v0, v1)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method132(v12)
    let v16 : (unit -> leptos_Fragment) = method133(v15)
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
and method259 () : (unit -> leptos_Fragment) =
    closure330()
and closure342 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure343 () () : Ref<Lifetime<StaticLifetime, Str>> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure346 () () : string =
    let v0 : string = "Debug"
    v0
and method269 () : (unit -> string) =
    closure346()
and closure345 () () : leptos_Fragment =
    let v0 : (unit -> string) = method269()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method149(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method268 () : (unit -> leptos_Fragment) =
    closure345()
and closure344 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method268()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method150()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method267 () : (unit -> leptos_Fragment) =
    closure344()
and closure341 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure342()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v4 : string = "$0"
    let v5 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure343()
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method267()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method132(v8)
    let v12 : (unit -> leptos_Fragment) = method133(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method152(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method132(v21)
    let v24 : (unit -> leptos_Fragment) = method133(v23)
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
and method266 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure341(v0)
and closure340 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method266(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method265 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure340(v0, v1)
and closure347 (v0 : leptos_WriteSignal<bool>) () : unit =
    let v1 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v2 : (bool -> bool) = closure307()
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v2) v1 
    ()
and closure348 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure349 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M10.343 3.94c.09-.542.56-.94 1.11-.94h1.093c.55 0 1.02.398 1.11.94l.149.894c.07.424.384.764.78.93.398.164.855.142 1.205-.108l.737-.527a1.125 1.125 0 011.45.12l.773.774c.39.389.44 1.002.12 1.45l-.527.737c-.25.35-.272.806-.107 1.204.165.397.505.71.93.78l.893.15c.543.09.94.56.94 1.109v1.094c0 .55-.397 1.02-.94 1.11l-.893.149c-.425.07-.765.383-.93.78-.165.398-.143.854.107 1.204l.527.738c.32.447.269 1.06-.12 1.45l-.774.773a1.125 1.125 0 01-1.449.12l-.738-.527c-.35-.25-.806-.272-1.203-.107-.397.165-.71.505-.781.929l-.149.894c-.09.542-.56.94-1.11.94h-1.094c-.55 0-1.019-.398-1.11-.94l-.148-.894c-.071-.424-.384-.764-.781-.93-.398-.164-.854-.142-1.204.108l-.738.527c-.447.32-1.06.269-1.45-.12l-.773-.774a1.125 1.125 0 01-.12-1.45l.527-.737c.25-.35.273-.806.108-1.204-.165-.397-.505-.71-.93-.78l-.894-.15c-.542-.09-.94-.56-.94-1.109v-1.094c0-.55.398-1.02.94-1.11l.894-.149c.424-.07.765-.383.93-.78.165-.398.143-.854-.107-1.204l-.527-.738a1.125 1.125 0 01.12-1.45l.773-.773a1.125 1.125 0 011.45-.12l.737.527c.35.25.807.272 1.204.107.397-.165.71-.505.78-.929l.15-.894z\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
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
    let v20 : (unit -> leptos_Fragment) = method131()
    let v21 : string = " " + v17 + v4 + ""
    let v22 : string = " " + v18 + v21 + ""
    let v23 : string = " " + v19 + v22 + ""
    let v24 : (unit -> leptos_Fragment) = method132(v20)
    let v25 : (unit -> leptos_Fragment) = method133(v24)
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
and method270 () : (unit -> leptos_Fragment) =
    closure349()
and method271 (v0 : Ref<Lifetime<StaticLifetime, Str>>) : Ref<Lifetime<StaticLifetime, Str>> =
    v0
and closure350 (v0 : leptos_ReadSignal<bool>) () : std_string_String =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v9 : Ref<Lifetime<StaticLifetime, Str>> =
        if v2 then
            let v3 : string = ""
            let v4 : string = "r#\"" + v3 + "\"#"
            let v5 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v4 
            v5
        else
            let v6 : string = "bg-gray-300 hover:bg-gray-200"
            let v7 : string = "r#\"" + v6 + "\"#"
            let v8 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v7 
            v8
    let v10 : Ref<Lifetime<StaticLifetime, Str>> = method271(v9)
    let v11 : string = "v10.to_owned() + \" hover:bg-gray-200\""
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11 
    v12
and closure353 () () : leptos_Fragment =
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
and method274 () : (unit -> leptos_Fragment) =
    closure353()
and closure354 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
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
and method275 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure354(v0)
and closure356 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    v0 ()
and method277 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure356(v0)
and closure357 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method278 () : (unit -> leptos_Fragment) =
    closure357()
and closure355 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "class=\"pr-[15px] [font-size:13px]\""
    let v2 : (unit -> leptos_Fragment) = method277(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
    let v7 : string = "span"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : leptos_HtmlElement<leptos_html_Span> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "class=\"h-px flex-1 bg-gray-300\""
    let v15 : (unit -> leptos_Fragment) = method278()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v15)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
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
and method276 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure355(v0)
and closure358 () () : leptos_Fragment =
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
and method279 () : (unit -> leptos_Fragment) =
    closure358()
and closure360 () () : std_string_String =
    let v0 : string = "&*$0"
    let v1 : string = "table-view"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v0 
    let v3 : string = "String::from($0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and closure363 () (v0 : Heap0) : Heap0 =
    let v1 : Vec<(bool * std_string_String)> = v0.l0
    let v2 : std_string_String option = v0.l1
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
and closure362 (v0 : Heap2) (v1 : leptos_ev_Event) : unit =
    let v2 : leptos_RwSignal<Heap1> = v0.l0
    let v3 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v4 : Heap1 = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : leptos_RwSignal<Heap0> = v4.l3
    let v6 : string = "true; leptos::SignalUpdate::update(&$0, |x| { *x = $1(x.clone()) });"
    let v7 : (Heap0 -> Heap0) = closure363()
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6 
    ()
and closure364 (v0 : Heap2) () : bool =
    let v1 : leptos_RwSignal<Heap1> = v0.l0
    let v2 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
    let v3 : Heap1 = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : leptos_RwSignal<Heap0> = v3.l3
    let v5 : string = $"leptos::SignalGet::get(&$0)"
    let v6 : Heap0 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : US1 = v6.l4
    match v7 with
    | US1_1 -> (* Table *)
        true
    | _ ->
        false
and method282 (v0 : Heap2) : (unit -> bool) =
    closure364(v0)
and method283 () : (unit -> std_string_String) =
    closure360()
and closure361 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (leptos_ev_Event -> unit) = closure362(v0)
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v3 : (unit -> bool) = method282(v0)
    let v4 : (unit -> std_string_String) = method283()
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
    let v24 : (unit -> leptos_Fragment) = method222()
    let v25 : string = " " + v23 + v10 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v24)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
    let v28 : string = "span"
    let v29 : string = "<" + v28 + " " + v25 + ">{v27()}</" + v28 + ">"
    let v30 : string = "leptos::view! { " + v29 + " }"
    let v31 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : leptos_HtmlElement<leptos_html_Span> = v31 |> unbox
    let v33 : string = "leptos::IntoView::into_view($0)"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : string = "class=\"absolute inset-0 rounded-full bg-gray-200 dark:bg-gray-200 transition peer-checked:bg-gray-300\""
    let v36 : (unit -> leptos_Fragment) = method225()
    let v37 : string = " " + v35 + v10 + ""
    let v38 : (unit -> leptos_Fragment) = method132(v36)
    let v39 : (unit -> leptos_Fragment) = method133(v38)
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
and method281 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure361(v0)
and closure359 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> std_string_String) = closure360()
    let v2 : string = "let v1 = $0"
    Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v3 : string = "for=move || v1()"
    let v4 : string = "class=\"block relative h-8 w-14 cursor-pointer [-webkit-tap-highlight-color:_transparent]\""
    let v5 : (unit -> leptos_Fragment) = method281(v0)
    let v6 : string = ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : string = " " + v4 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v5)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
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
and method280 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure359(v0)
and closure365 () () : string =
    let v0 : string = "items-center"
    v0
and closure366 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method284 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure366(v0, v1)
and closure352 (v0 : Heap2) () : leptos_Fragment =
    let v1 : (unit -> leptos_Fragment) = method274()
    let v2 : (unit -> leptos_Fragment) = method275(v1)
    let v3 : string = "class=\"flex items-center pb-[6px]\""
    let v4 : (unit -> leptos_Fragment) = method276(v2)
    let v5 : string = ""
    let v6 : string = " " + v3 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method132(v4)
    let v8 : (unit -> leptos_Fragment) = method133(v7)
    let v9 : string = "span"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : leptos_HtmlElement<leptos_html_Span> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : (unit -> leptos_Fragment) = method279()
    let v17 : (unit -> leptos_Fragment) = method280(v0)
    let v18 : string = "$0"
    let v19 : (unit -> string) = closure365()
    let v20 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v19 v18 
    let v21 : string = "$0"
    let v22 : (unit -> string) = closure310()
    let v23 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v21 
    let v24 : string = "$0"
    let v25 : (unit -> string) = closure311()
    let v26 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v25 v24 
    let v27 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v26(()) + \" \" + &v23(()) + \" \" + &v20(())"
    let v28 : (unit -> leptos_Fragment) = method284(v16, v17)
    let v29 : string = " " + v27 + v5 + ""
    let v30 : (unit -> leptos_Fragment) = method132(v28)
    let v31 : (unit -> leptos_Fragment) = method133(v30)
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
and method273 (v0 : Heap2) : (unit -> leptos_Fragment) =
    closure352(v0)
and closure370 (v0 : int64) () : leptos_Fragment =
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
and method287 (v0 : int64) : (unit -> leptos_Fragment) =
    closure370(v0)
and closure372 () () : leptos_Fragment =
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
and method289 () : (unit -> leptos_Fragment) =
    closure372()
and closure373 (v0 : string) () : leptos_Fragment =
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
and method290 (v0 : string) : (unit -> leptos_Fragment) =
    closure373(v0)
and closure374 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure375 () () : string =
    let v0 : string = ""
    v0
and closure376 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method291 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure376(v0, v1)
and closure377 () () : leptos_Fragment =
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
and method292 () : (unit -> leptos_Fragment) =
    closure377()
and closure378 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let v14 : (string -> int64) = int64
    let v15 : int64 = v14 v13
    let v16 : int64 = method187(v15)
    let v17 : int64 = v16 / 1000L
    let v18 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v19 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v22 : US71 option = None
    let _v22 = ref v22 
    match v19 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : chrono_DateTime<chrono_Utc> = x
    let v24 : US71 = US71_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US71 option = _v22.Value 
    let v48 : US71 = US71_1
    let v49 : US71 = v25 |> Option.defaultValue v48 
    let v72 : US34 =
        match v49 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v57) -> (* Some *)
            let v58 : string = "$0.naive_utc()"
            let v59 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v57 v58 
            let v60 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v61 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v59 v60 
            let v62 : string = "%Y-%m-%d %H:%M:%S"
            let v63 : string = "r#\"" + v62 + "\"#"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v63 
            let v65 : string = "$0.format($1).to_string()"
            let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v61, v64) v65 
            let v67 : string = "fable_library_rust::String_::fromString($0)"
            let v68 : string = Fable.Core.RustInterop.emitRustExpr v66 v67 
            US34_0(v68)
    let v78 : US72 =
        match v72 with
        | US34_1 -> (* None *)
            let v75 : string = "resultm.from_option / Option does not have a value."
            US72_1(v75)
        | US34_0(v73) -> (* Some *)
            US72_0(v73)
    let v83 : string =
        match v78 with
        | US72_1(v80) -> (* Error *)
            let v81 : string = "sm'.to_string result / Error: " + v80 + ""
            v81
        | US72_0(v79) -> (* Ok *)
            v79
    let v84 : string = "&*$0"
    let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "String::from($0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "leptos::html::text($0)"
    let v89 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = "leptos::IntoView::into_view($0)"
    let v91 : leptos_View = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : (leptos_View []) = [|v91|]
    let v93 : string = "$0.to_vec()"
    let v94 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : string = "leptos::Fragment::new($0)"
    let v96 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v94 v95 
    v96
and method293 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure378(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure379 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure380 () () : string =
    let v0 : string = ""
    v0
and closure381 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method294 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure381(v0, v1)
and closure382 () () : leptos_Fragment =
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
and method295 () : (unit -> leptos_Fragment) =
    closure382()
and closure383 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v1 v12 
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
and method296 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure383(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure384 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure385 () () : string =
    let v0 : string = ""
    v0
and closure386 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method297 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure386(v0, v1)
and closure387 () () : leptos_Fragment =
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
and method298 () : (unit -> leptos_Fragment) =
    closure387()
and closure388 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v2 v12 
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
and method299 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure388(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure389 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure390 () () : string =
    let v0 : string = ""
    v0
and closure391 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method300 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure391(v0, v1)
and closure392 () () : leptos_Fragment =
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
and method301 () : (unit -> leptos_Fragment) =
    closure392()
and closure395 (v0 : std_string_String) () : leptos_Fragment =
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
and method303 (v0 : std_string_String) : (unit -> leptos_Fragment) =
    closure395(v0)
and closure398 () () : leptos_Fragment =
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
and method306 () : (unit -> leptos_Fragment) =
    closure398()
and closure399 (v0 : std_string_String option) () : leptos_Fragment =
    let v3 : US15 option = None
    let _v3 = ref v3 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : std_string_String = x
    let v5 : US15 = US15_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US15 option = _v3.Value 
    let v29 : US15 = US15_1
    let v30 : US15 = v6 |> Option.defaultValue v29 
    match v30 with
    | US15_1 -> (* None *)
        let v54 : string = "&*$0"
        let v55 : string = "None"
        let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v55 v54 
        let v57 : string = "String::from($0)"
        let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v56 v57 
        let v59 : string = "leptos::html::text($0)"
        let v60 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v58 v59 
        let v61 : string = "leptos::IntoView::into_view($0)"
        let v62 : leptos_View = Fable.Core.RustInterop.emitRustExpr v60 v61 
        let v63 : (leptos_View []) = [|v62|]
        let v64 : string = "$0.to_vec()"
        let v65 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v63 v64 
        let v66 : string = "leptos::Fragment::new($0)"
        let v67 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v65 v66 
        v67
    | US15_0(v38) -> (* Some *)
        let v39 : string = "fable_library_rust::String_::fromString($0)"
        let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39 
        let v41 : string = "&*$0"
        let v42 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v40 v41 
        let v43 : string = "String::from($0)"
        let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v42 v43 
        let v45 : string = "leptos::html::text($0)"
        let v46 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v44 v45 
        let v47 : string = "leptos::IntoView::into_view($0)"
        let v48 : leptos_View = Fable.Core.RustInterop.emitRustExpr v46 v47 
        let v49 : (leptos_View []) = [|v48|]
        let v50 : string = "$0.to_vec()"
        let v51 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v49 v50 
        let v52 : string = "leptos::Fragment::new($0)"
        let v53 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v51 v52 
        v53
and method307 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure399(v0)
and closure400 () () : string =
    let v0 : string = ""
    v0
and closure401 () () : string =
    let v0 : string = ""
    v0
and closure403 () () : string =
    let v0 : string = ""
    v0
and closure402 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure403()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method308 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure402(v0, v1)
and closure397 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : (unit -> leptos_Fragment) = method306()
    let v2 : (unit -> leptos_Fragment) = method307(v0)
    let v3 : string = "$0"
    let v4 : (unit -> string) = closure400()
    let v5 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v4 v3 
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure401()
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6 
    let v9 : string = "$0"
    let v10 : (unit -> string) = closure311()
    let v11 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v10 v9 
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v11(()) + \" \" + &v8(()) + \" \" + &v5(())"
    let v13 : (unit -> leptos_Fragment) = method308(v1, v2)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v13)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method305 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure397(v0)
and closure396 (v0 : std_string_String option) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col\""
    let v2 : (unit -> leptos_Fragment) = method305(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method304 (v0 : std_string_String option) : (unit -> leptos_Fragment) =
    closure396(v0)
and closure404 () () : string =
    let v0 : string = ""
    v0
and closure405 () () : string =
    let v0 : string = "items-center"
    v0
and closure406 () () : string =
    let v0 : string = ""
    v0
and closure408 () () : string =
    let v0 : string = ""
    v0
and closure407 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure408()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method309 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure407(v0, v1)
and closure394 () struct (v0 : std_string_String, v1 : std_string_String option) : leptos_View =
    let v2 : (unit -> leptos_Fragment) = method303(v0)
    let v3 : (unit -> leptos_Fragment) = method304(v1)
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure404()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure405()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7 
    let v10 : string = "$0"
    let v11 : (unit -> string) = closure406()
    let v12 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v11 v10 
    let v13 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v12(()) + \" \" + &v9(()) + \" \" + &v6(())"
    let v14 : (unit -> leptos_Fragment) = method309(v2, v3)
    let v15 : string = ""
    let v16 : string = " " + v13 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v14)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
    let v19 : string = "dl"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : leptos_HtmlElement<leptos_html_Dl> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24 
    v25
and closure393 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v7 v12 
    let v14 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v15 : (struct (std_string_String * std_string_String option) -> leptos_View) = closure394()
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14 
    let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v18 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v19 : string = "$0.to_vec()"
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "leptos::Fragment::new($0)"
    let v22 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v20 v21 
    v22
and method302 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure393(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure409 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure410 () () : string =
    let v0 : string = "sm:pr-[10px]"
    v0
and closure412 () () : string =
    let v0 : string = "[flex-direction:column]"
    v0
and closure411 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure412()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method310 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure411(v0, v1)
and closure413 () () : leptos_Fragment =
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
and method311 () : (unit -> leptos_Fragment) =
    closure413()
and closure414 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v14 : (float -> string) = _.ToString()
    let v15 : string = v14 v8
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v22 
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
and method312 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure414(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure415 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure416 () () : string =
    let v0 : string = ""
    v0
and closure417 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
    closure417(v0, v1)
and closure418 () () : leptos_Fragment =
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
and method314 () : (unit -> leptos_Fragment) =
    closure418()
and closure419 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v14 : (bool -> string) = _.ToString()
    let v15 : string = v14 v9
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v22 
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
and method315 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure419(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure420 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure421 () () : string =
    let v0 : string = ""
    v0
and closure422 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method316 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure422(v0, v1)
and closure423 () () : leptos_Fragment =
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
and method317 () : (unit -> leptos_Fragment) =
    closure423()
and closure424 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v14 : (float -> string) = _.ToString()
    let v15 : string = v14 v10
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v22 
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
and method318 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure424(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure425 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure426 () () : string =
    let v0 : string = ""
    v0
and closure427 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method319 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure427(v0, v1)
and closure428 () () : leptos_Fragment =
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
and method320 () : (unit -> leptos_Fragment) =
    closure428()
and closure429 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v14 : (uint32 -> string) = _.ToString()
    let v15 : string = v14 v6
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v22 
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
and method321 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure429(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure430 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure431 () () : string =
    let v0 : string = ""
    v0
and closure432 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
    closure432(v0, v1)
and closure433 () () : leptos_Fragment =
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
and method323 () : (unit -> leptos_Fragment) =
    closure433()
and closure434 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v3 v12 
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
and method324 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure434(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure435 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure436 () () : string =
    let v0 : string = ""
    v0
and closure437 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method325 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure437(v0, v1)
and closure438 () () : leptos_Fragment =
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
and method326 () : (unit -> leptos_Fragment) =
    closure438()
and closure439 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
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
and method327 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure439(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure440 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure441 () () : string =
    let v0 : string = ""
    v0
and closure442 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method328 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure442(v0, v1)
and closure443 () () : leptos_Fragment =
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
and method329 () : (unit -> leptos_Fragment) =
    closure443()
and closure444 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v0 v12 
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
and method330 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure444(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure445 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure446 () () : string =
    let v0 : string = ""
    v0
and closure447 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method331 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure447(v0, v1)
and closure448 () () : leptos_Fragment =
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
and method332 () : (unit -> leptos_Fragment) =
    closure448()
and closure450 () () : string =
    let v0 : string = "[max-height:20vh]"
    v0
and closure449 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) () : leptos_Fragment =
    let v12 : string = "$0.to_vec()"
    let v13 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v15 : (std_string_String -> string) = closure49()
    let v16 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v14 
    let v17 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v18 : (string []) = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v21 : string seq = v18 |> Seq.ofArray
    let v30 : (string -> (string seq -> string)) = String.concat
    let v31 : string = "\n"
    let v32 : (string seq -> string) = v30 v31
    let v33 : string = v32 v21
    let v40 : string = "\\n"
    let v41 : string = v33.Replace (v40, v31)
    let v42 : string = "$0"
    let v43 : (unit -> string) = closure450()
    let v44 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v43 v42 
    let v45 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v44(())"
    let v46 : (unit -> leptos_Fragment) = method263(v41)
    let v47 : string = ""
    let v48 : string = " " + v45 + v47 + ""
    let v49 : (unit -> leptos_Fragment) = method132(v46)
    let v50 : (unit -> leptos_Fragment) = method133(v49)
    let v51 : string = "pre"
    let v52 : string = "<" + v51 + " " + v48 + ">{v50()}</" + v51 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : leptos_HtmlElement<leptos_html_Pre> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let v58 : (leptos_View []) = [|v57|]
    let v59 : string = "$0.to_vec()"
    let v60 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "leptos::Fragment::new($0)"
    let v62 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v60 v61 
    v62
and method333 (v0 : std_string_String, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : uint32, v7 : (struct (std_string_String * std_string_String option) []), v8 : float, v9 : bool, v10 : float, v11 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure449(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)
and closure451 () () : string =
    let v0 : string = "items-center py-[4px]"
    v0
and closure452 () () : string =
    let v0 : string = ""
    v0
and closure453 (v0 : (unit -> leptos_Fragment), v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure313()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "class=\"[font-size:12px] text-gray-400\""
    let v6 : (unit -> leptos_Fragment) = method247(v0)
    let v7 : string = ""
    let v8 : string = " " + v5 + v7 + ""
    let v9 : (unit -> leptos_Fragment) = method132(v6)
    let v10 : (unit -> leptos_Fragment) = method133(v9)
    let v11 : string = "dt"
    let v12 : string = "<" + v11 + " " + v8 + ">{v10()}</" + v11 + ">"
    let v13 : string = "leptos::view! { " + v12 + " }"
    let v14 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : leptos_HtmlElement<leptos_html_Dt> = v14 |> unbox
    let v16 : string = "leptos::IntoView::into_view($0)"
    let v17 : leptos_View = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "class=move || \"text-gray-700 sm:col-span-2 flex flex-1 \".to_owned () + &v4(())"
    let v19 : (unit -> leptos_Fragment) = method247(v1)
    let v20 : string = " " + v18 + v7 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v19)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
    closure453(v0, v1)
and closure371 (v0 : string, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : std_string_String, v7 : uint32, v8 : (struct (std_string_String * std_string_String option) []), v9 : float, v10 : bool, v11 : float, v12 : (std_string_String [])) () : leptos_Fragment =
    let v13 : (unit -> leptos_Fragment) = method289()
    let v14 : (unit -> leptos_Fragment) = method290(v0)
    let v15 : string = "$0"
    let v16 : (unit -> string) = closure374()
    let v17 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v16 v15 
    let v18 : string = "$0"
    let v19 : (unit -> string) = closure375()
    let v20 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v19 v18 
    let v21 : string = "$0"
    let v22 : (unit -> string) = closure311()
    let v23 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v21 
    let v24 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v23(()) + \" \" + &v20(()) + \" \" + &v17(())"
    let v25 : (unit -> leptos_Fragment) = method291(v13, v14)
    let v26 : string = ""
    let v27 : string = " " + v24 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method132(v25)
    let v29 : (unit -> leptos_Fragment) = method133(v28)
    let v30 : string = "dl"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : leptos_HtmlElement<leptos_html_Dl> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : (unit -> leptos_Fragment) = method292()
    let v38 : (unit -> leptos_Fragment) = method293(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v39 : string = "$0"
    let v40 : (unit -> string) = closure379()
    let v41 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v40 v39 
    let v42 : string = "$0"
    let v43 : (unit -> string) = closure380()
    let v44 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v43 v42 
    let v45 : string = "$0"
    let v46 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v45 
    let v47 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v46(()) + \" \" + &v44(()) + \" \" + &v41(())"
    let v48 : (unit -> leptos_Fragment) = method294(v37, v38)
    let v49 : string = " " + v47 + v26 + ""
    let v50 : (unit -> leptos_Fragment) = method132(v48)
    let v51 : (unit -> leptos_Fragment) = method133(v50)
    let v52 : string = "<" + v30 + " " + v49 + ">{v51()}</" + v30 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : leptos_HtmlElement<leptos_html_Dl> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let v58 : (unit -> leptos_Fragment) = method295()
    let v59 : (unit -> leptos_Fragment) = method296(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v60 : string = "$0"
    let v61 : (unit -> string) = closure384()
    let v62 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v61 v60 
    let v63 : string = "$0"
    let v64 : (unit -> string) = closure385()
    let v65 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v64 v63 
    let v66 : string = "$0"
    let v67 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v66 
    let v68 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v67(()) + \" \" + &v65(()) + \" \" + &v62(())"
    let v69 : (unit -> leptos_Fragment) = method297(v58, v59)
    let v70 : string = " " + v68 + v26 + ""
    let v71 : (unit -> leptos_Fragment) = method132(v69)
    let v72 : (unit -> leptos_Fragment) = method133(v71)
    let v73 : string = "<" + v30 + " " + v70 + ">{v72()}</" + v30 + ">"
    let v74 : string = "leptos::view! { " + v73 + " }"
    let v75 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v74 
    let v76 : leptos_HtmlElement<leptos_html_Dl> = v75 |> unbox
    let v77 : string = "leptos::IntoView::into_view($0)"
    let v78 : leptos_View = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : (unit -> leptos_Fragment) = method298()
    let v80 : (unit -> leptos_Fragment) = method299(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v81 : string = "$0"
    let v82 : (unit -> string) = closure389()
    let v83 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v82 v81 
    let v84 : string = "$0"
    let v85 : (unit -> string) = closure390()
    let v86 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v85 v84 
    let v87 : string = "$0"
    let v88 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v87 
    let v89 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v88(()) + \" \" + &v86(()) + \" \" + &v83(())"
    let v90 : (unit -> leptos_Fragment) = method300(v79, v80)
    let v91 : string = " " + v89 + v26 + ""
    let v92 : (unit -> leptos_Fragment) = method132(v90)
    let v93 : (unit -> leptos_Fragment) = method133(v92)
    let v94 : string = "<" + v30 + " " + v91 + ">{v93()}</" + v30 + ">"
    let v95 : string = "leptos::view! { " + v94 + " }"
    let v96 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : leptos_HtmlElement<leptos_html_Dl> = v96 |> unbox
    let v98 : string = "leptos::IntoView::into_view($0)"
    let v99 : leptos_View = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : (unit -> leptos_Fragment) = method301()
    let v101 : (unit -> leptos_Fragment) = method302(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v102 : string = "$0"
    let v103 : (unit -> string) = closure409()
    let v104 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v103 v102 
    let v105 : string = "$0"
    let v106 : (unit -> string) = closure410()
    let v107 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v106 v105 
    let v108 : string = "$0"
    let v109 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v108 
    let v110 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v109(()) + \" \" + &v107(()) + \" \" + &v104(())"
    let v111 : (unit -> leptos_Fragment) = method310(v100, v101)
    let v112 : string = " " + v110 + v26 + ""
    let v113 : (unit -> leptos_Fragment) = method132(v111)
    let v114 : (unit -> leptos_Fragment) = method133(v113)
    let v115 : string = "<" + v30 + " " + v112 + ">{v114()}</" + v30 + ">"
    let v116 : string = "leptos::view! { " + v115 + " }"
    let v117 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v116 
    let v118 : leptos_HtmlElement<leptos_html_Dl> = v117 |> unbox
    let v119 : string = "leptos::IntoView::into_view($0)"
    let v120 : leptos_View = Fable.Core.RustInterop.emitRustExpr v118 v119 
    let v121 : (unit -> leptos_Fragment) = method311()
    let v122 : (unit -> leptos_Fragment) = method312(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v123 : string = "$0"
    let v124 : (unit -> string) = closure415()
    let v125 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v124 v123 
    let v126 : string = "$0"
    let v127 : (unit -> string) = closure416()
    let v128 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v127 v126 
    let v129 : string = "$0"
    let v130 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v129 
    let v131 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v130(()) + \" \" + &v128(()) + \" \" + &v125(())"
    let v132 : (unit -> leptos_Fragment) = method313(v121, v122)
    let v133 : string = " " + v131 + v26 + ""
    let v134 : (unit -> leptos_Fragment) = method132(v132)
    let v135 : (unit -> leptos_Fragment) = method133(v134)
    let v136 : string = "<" + v30 + " " + v133 + ">{v135()}</" + v30 + ">"
    let v137 : string = "leptos::view! { " + v136 + " }"
    let v138 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v137 
    let v139 : leptos_HtmlElement<leptos_html_Dl> = v138 |> unbox
    let v140 : string = "leptos::IntoView::into_view($0)"
    let v141 : leptos_View = Fable.Core.RustInterop.emitRustExpr v139 v140 
    let v142 : (unit -> leptos_Fragment) = method314()
    let v143 : (unit -> leptos_Fragment) = method315(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v144 : string = "$0"
    let v145 : (unit -> string) = closure420()
    let v146 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v145 v144 
    let v147 : string = "$0"
    let v148 : (unit -> string) = closure421()
    let v149 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v148 v147 
    let v150 : string = "$0"
    let v151 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v150 
    let v152 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v151(()) + \" \" + &v149(()) + \" \" + &v146(())"
    let v153 : (unit -> leptos_Fragment) = method316(v142, v143)
    let v154 : string = " " + v152 + v26 + ""
    let v155 : (unit -> leptos_Fragment) = method132(v153)
    let v156 : (unit -> leptos_Fragment) = method133(v155)
    let v157 : string = "<" + v30 + " " + v154 + ">{v156()}</" + v30 + ">"
    let v158 : string = "leptos::view! { " + v157 + " }"
    let v159 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v158 
    let v160 : leptos_HtmlElement<leptos_html_Dl> = v159 |> unbox
    let v161 : string = "leptos::IntoView::into_view($0)"
    let v162 : leptos_View = Fable.Core.RustInterop.emitRustExpr v160 v161 
    let v163 : (unit -> leptos_Fragment) = method317()
    let v164 : (unit -> leptos_Fragment) = method318(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v165 : string = "$0"
    let v166 : (unit -> string) = closure425()
    let v167 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v166 v165 
    let v168 : string = "$0"
    let v169 : (unit -> string) = closure426()
    let v170 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v169 v168 
    let v171 : string = "$0"
    let v172 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v171 
    let v173 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v172(()) + \" \" + &v170(()) + \" \" + &v167(())"
    let v174 : (unit -> leptos_Fragment) = method319(v163, v164)
    let v175 : string = " " + v173 + v26 + ""
    let v176 : (unit -> leptos_Fragment) = method132(v174)
    let v177 : (unit -> leptos_Fragment) = method133(v176)
    let v178 : string = "<" + v30 + " " + v175 + ">{v177()}</" + v30 + ">"
    let v179 : string = "leptos::view! { " + v178 + " }"
    let v180 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v179 
    let v181 : leptos_HtmlElement<leptos_html_Dl> = v180 |> unbox
    let v182 : string = "leptos::IntoView::into_view($0)"
    let v183 : leptos_View = Fable.Core.RustInterop.emitRustExpr v181 v182 
    let v184 : (unit -> leptos_Fragment) = method320()
    let v185 : (unit -> leptos_Fragment) = method321(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v186 : string = "$0"
    let v187 : (unit -> string) = closure430()
    let v188 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v187 v186 
    let v189 : string = "$0"
    let v190 : (unit -> string) = closure431()
    let v191 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v190 v189 
    let v192 : string = "$0"
    let v193 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v192 
    let v194 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v193(()) + \" \" + &v191(()) + \" \" + &v188(())"
    let v195 : (unit -> leptos_Fragment) = method322(v184, v185)
    let v196 : string = " " + v194 + v26 + ""
    let v197 : (unit -> leptos_Fragment) = method132(v195)
    let v198 : (unit -> leptos_Fragment) = method133(v197)
    let v199 : string = "<" + v30 + " " + v196 + ">{v198()}</" + v30 + ">"
    let v200 : string = "leptos::view! { " + v199 + " }"
    let v201 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v200 
    let v202 : leptos_HtmlElement<leptos_html_Dl> = v201 |> unbox
    let v203 : string = "leptos::IntoView::into_view($0)"
    let v204 : leptos_View = Fable.Core.RustInterop.emitRustExpr v202 v203 
    let v205 : (unit -> leptos_Fragment) = method323()
    let v206 : (unit -> leptos_Fragment) = method324(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v207 : string = "$0"
    let v208 : (unit -> string) = closure435()
    let v209 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v208 v207 
    let v210 : string = "$0"
    let v211 : (unit -> string) = closure436()
    let v212 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v211 v210 
    let v213 : string = "$0"
    let v214 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v213 
    let v215 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v214(()) + \" \" + &v212(()) + \" \" + &v209(())"
    let v216 : (unit -> leptos_Fragment) = method325(v205, v206)
    let v217 : string = " " + v215 + v26 + ""
    let v218 : (unit -> leptos_Fragment) = method132(v216)
    let v219 : (unit -> leptos_Fragment) = method133(v218)
    let v220 : string = "<" + v30 + " " + v217 + ">{v219()}</" + v30 + ">"
    let v221 : string = "leptos::view! { " + v220 + " }"
    let v222 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v221 
    let v223 : leptos_HtmlElement<leptos_html_Dl> = v222 |> unbox
    let v224 : string = "leptos::IntoView::into_view($0)"
    let v225 : leptos_View = Fable.Core.RustInterop.emitRustExpr v223 v224 
    let v226 : (unit -> leptos_Fragment) = method326()
    let v227 : (unit -> leptos_Fragment) = method327(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v228 : string = "$0"
    let v229 : (unit -> string) = closure440()
    let v230 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v229 v228 
    let v231 : string = "$0"
    let v232 : (unit -> string) = closure441()
    let v233 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v232 v231 
    let v234 : string = "$0"
    let v235 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v234 
    let v236 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v235(()) + \" \" + &v233(()) + \" \" + &v230(())"
    let v237 : (unit -> leptos_Fragment) = method328(v226, v227)
    let v238 : string = " " + v236 + v26 + ""
    let v239 : (unit -> leptos_Fragment) = method132(v237)
    let v240 : (unit -> leptos_Fragment) = method133(v239)
    let v241 : string = "<" + v30 + " " + v238 + ">{v240()}</" + v30 + ">"
    let v242 : string = "leptos::view! { " + v241 + " }"
    let v243 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v242 
    let v244 : leptos_HtmlElement<leptos_html_Dl> = v243 |> unbox
    let v245 : string = "leptos::IntoView::into_view($0)"
    let v246 : leptos_View = Fable.Core.RustInterop.emitRustExpr v244 v245 
    let v247 : (unit -> leptos_Fragment) = method329()
    let v248 : (unit -> leptos_Fragment) = method330(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
    let v249 : string = "$0"
    let v250 : (unit -> string) = closure445()
    let v251 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v250 v249 
    let v252 : string = "$0"
    let v253 : (unit -> string) = closure446()
    let v254 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v253 v252 
    let v255 : string = "$0"
    let v256 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v255 
    let v257 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v256(()) + \" \" + &v254(()) + \" \" + &v251(())"
    let v258 : (unit -> leptos_Fragment) = method331(v247, v248)
    let v259 : string = " " + v257 + v26 + ""
    let v260 : (unit -> leptos_Fragment) = method132(v258)
    let v261 : (unit -> leptos_Fragment) = method133(v260)
    let v262 : string = "<" + v30 + " " + v259 + ">{v261()}</" + v30 + ">"
    let v263 : string = "leptos::view! { " + v262 + " }"
    let v264 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : leptos_HtmlElement<leptos_html_Dl> = v264 |> unbox
    let v266 : string = "leptos::IntoView::into_view($0)"
    let v267 : leptos_View = Fable.Core.RustInterop.emitRustExpr v265 v266 
    let v268 : uint64 = System.Convert.ToUInt64 v12.Length
    let v269 : bool = v268 = 0UL
    let v295 : leptos_View =
        if v269 then
            let v270 : (leptos_View []) = [||]
            let v271 : (leptos_View []) = method122(v270)
            let v272 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v273 : leptos_View = Fable.Core.RustInterop.emitRustExpr v271 v272 
            v273
        else
            let v274 : (unit -> leptos_Fragment) = method332()
            let v275 : (unit -> leptos_Fragment) = method333(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
            let v276 : string = "$0"
            let v277 : (unit -> string) = closure451()
            let v278 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v277 v276 
            let v279 : string = "$0"
            let v280 : (unit -> string) = closure452()
            let v281 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v280 v279 
            let v282 : string = "$0"
            let v283 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v22 v282 
            let v284 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v283(()) + \" \" + &v281(()) + \" \" + &v278(())"
            let v285 : (unit -> leptos_Fragment) = method334(v274, v275)
            let v286 : string = " " + v284 + v26 + ""
            let v287 : (unit -> leptos_Fragment) = method132(v285)
            let v288 : (unit -> leptos_Fragment) = method133(v287)
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
and method288 (v0 : string, v1 : std_string_String, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : std_string_String, v7 : uint32, v8 : (struct (std_string_String * std_string_String option) []), v9 : float, v10 : bool, v11 : float, v12 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure371(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)
and closure369 (v0 : string, v1 : int64, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : std_string_String, v7 : std_string_String, v8 : uint32, v9 : (struct (std_string_String * std_string_String option) []), v10 : float, v11 : bool, v12 : float, v13 : (std_string_String [])) () : leptos_Fragment =
    let v14 : (unit -> leptos_Fragment) = method287(v1)
    let v15 : (unit -> leptos_Fragment) = method275(v14)
    let v16 : string = "class=\"flex items-center pb-[6px]\""
    let v17 : (unit -> leptos_Fragment) = method276(v15)
    let v18 : string = ""
    let v19 : string = " " + v16 + v18 + ""
    let v20 : (unit -> leptos_Fragment) = method132(v17)
    let v21 : (unit -> leptos_Fragment) = method133(v20)
    let v22 : string = "span"
    let v23 : string = "<" + v22 + " " + v19 + ">{v21()}</" + v22 + ">"
    let v24 : string = "leptos::view! { " + v23 + " }"
    let v25 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : leptos_HtmlElement<leptos_html_Span> = v25 |> unbox
    let v27 : string = "leptos::IntoView::into_view($0)"
    let v28 : leptos_View = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "class=\"grid flex-1 divide-y-[1px] divide-gray-500/[.10]\""
    let v30 : (unit -> leptos_Fragment) = method288(v0, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
    let v31 : string = " " + v29 + v18 + ""
    let v32 : (unit -> leptos_Fragment) = method132(v30)
    let v33 : (unit -> leptos_Fragment) = method133(v32)
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
and method286 (v0 : string, v1 : int64, v2 : std_string_String, v3 : std_string_String, v4 : std_string_String, v5 : std_string_String, v6 : std_string_String, v7 : std_string_String, v8 : uint32, v9 : (struct (std_string_String * std_string_String option) []), v10 : float, v11 : bool, v12 : float, v13 : (std_string_String [])) : (unit -> leptos_Fragment) =
    closure369(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)
and closure368 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : leptos_View =
    let v3 : std_string_String = v2.l0
    let v4 : std_string_String = v2.l1
    let v5 : std_string_String = v2.l2
    let v6 : std_string_String = v2.l3
    let v7 : std_string_String = v2.l4
    let v8 : std_string_String = v2.l5
    let v9 : uint32 = v2.l6
    let v10 : (struct (std_string_String * std_string_String option) []) = v2.l7
    let v11 : float = v2.l8
    let v12 : bool = v2.l9
    let v13 : float = v2.l10
    let v14 : (std_string_String []) = v2.l11
    let v15 : (unativeint -> int64) = int64
    let v16 : int64 = v15 v1
    let v17 : string = "transaction.render (1)"
    let v18 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
    let v21 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "$0.unwrap()"
    let v23 : Heap2 = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "class=\"flex flex-1 flex-col overflow-x-auto\""
    let v25 : (unit -> leptos_Fragment) = method286(v0, v16, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14)
    let v26 : string = ""
    let v27 : string = " " + v24 + v26 + ""
    let v28 : (unit -> leptos_Fragment) = method132(v25)
    let v29 : (unit -> leptos_Fragment) = method133(v28)
    let v30 : string = "div"
    let v31 : string = "<" + v30 + " " + v27 + ">{v29()}</" + v30 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : leptos_HtmlElement<leptos_html_Div> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35 
    v36
and closure367 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v4 : (struct (string * unativeint * Heap5) -> leptos_View) = closure368()
    let v5 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v2, v4) v3 
    let v6 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v7 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "leptos::Fragment::new($0)"
    let v11 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v9 v10 
    v11
and method285 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure367(v0)
and closure456 (v0 : string) () : leptos_Fragment =
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
and method336 (v0 : string) : (unit -> leptos_Fragment) =
    closure456(v0)
and closure457 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l5
    let v2 : string = "fable_library_rust::String_::fromString($0)"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : (string -> int64) = int64
    let v5 : int64 = v4 v3
    let v6 : int64 = method187(v5)
    let v7 : int64 = v6 / 1000L
    let v8 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v9 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v12 : US71 option = None
    let _v12 = ref v12 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v13 : chrono_DateTime<chrono_Utc> = x
    let v14 : US71 = US71_0(v13)
    v14 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v12.Value <- x
    let v15 : US71 option = _v12.Value 
    let v38 : US71 = US71_1
    let v39 : US71 = v15 |> Option.defaultValue v38 
    let v62 : US34 =
        match v39 with
        | US71_1 -> (* None *)
            US34_1
        | US71_0(v47) -> (* Some *)
            let v48 : string = "$0.naive_utc()"
            let v49 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v51 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : string = "%Y-%m-%d %H:%M:%S"
            let v53 : string = "r#\"" + v52 + "\"#"
            let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "$0.format($1).to_string()"
            let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v51, v54) v55 
            let v57 : string = "fable_library_rust::String_::fromString($0)"
            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
            US34_0(v58)
    let v68 : US72 =
        match v62 with
        | US34_1 -> (* None *)
            let v65 : string = "resultm.from_option / Option does not have a value."
            US72_1(v65)
        | US34_0(v63) -> (* Some *)
            US72_0(v63)
    let v73 : string =
        match v68 with
        | US72_1(v70) -> (* Error *)
            let v71 : string = "sm'.to_string result / Error: " + v70 + ""
            v71
        | US72_0(v69) -> (* Ok *)
            v69
    let v74 : string = "&*$0"
    let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v74 
    let v76 : string = "String::from($0)"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "leptos::html::text($0)"
    let v79 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let v80 : string = "leptos::IntoView::into_view($0)"
    let v81 : leptos_View = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : (leptos_View []) = [|v81|]
    let v83 : string = "$0.to_vec()"
    let v84 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "leptos::Fragment::new($0)"
    let v86 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v84 v85 
    v86
and method337 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure457(v0)
and closure458 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l1
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
and method338 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure458(v0)
and closure459 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l2
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
and method339 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure459(v0)
and closure461 () struct (v0 : std_string_String, v1 : std_string_String option) : leptos_View =
    let v2 : (unit -> leptos_Fragment) = method303(v0)
    let v3 : (unit -> leptos_Fragment) = method304(v1)
    let v4 : string = "$0"
    let v5 : (unit -> string) = closure404()
    let v6 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "$0"
    let v8 : (unit -> string) = closure405()
    let v9 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v8 v7 
    let v10 : string = "$0"
    let v11 : (unit -> string) = closure406()
    let v12 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v11 v10 
    let v13 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v12(()) + \" \" + &v9(()) + \" \" + &v6(())"
    let v14 : (unit -> leptos_Fragment) = method309(v2, v3)
    let v15 : string = ""
    let v16 : string = " " + v13 + v15 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v14)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
    let v19 : string = "dl"
    let v20 : string = "<" + v19 + " " + v16 + ">{v18()}</" + v19 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : leptos_HtmlElement<leptos_html_Dl> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24 
    v25
and closure460 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (struct (std_string_String * std_string_String option) []) = v0.l7
    let v2 : string = "$0.to_vec()"
    let v3 : Vec<struct (std_string_String * std_string_String option)> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v5 : (struct (std_string_String * std_string_String option) -> leptos_View) = closure461()
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v3, v5) v4 
    let v7 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v8 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.to_vec()"
    let v10 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "leptos::Fragment::new($0)"
    let v12 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v10 v11 
    v12
and method340 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure460(v0)
and closure462 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l8
    let v4 : (float -> string) = _.ToString()
    let v5 : string = v4 v1
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v12 
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
and method341 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure462(v0)
and closure463 (v0 : Heap5) () : leptos_Fragment =
    let v1 : float = v0.l10
    let v4 : (float -> string) = _.ToString()
    let v5 : string = v4 v1
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v12 
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
and method342 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure463(v0)
and closure464 (v0 : Heap5) () : leptos_Fragment =
    let v1 : uint32 = v0.l6
    let v4 : (uint32 -> string) = _.ToString()
    let v5 : string = v4 v1
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v12 
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
and method343 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure464(v0)
and closure466 () () : string =
    let v0 : string = "[max-height:20vh] [width:100vw] [max-width:100vw]"
    v0
and closure465 (v0 : Heap5) () : leptos_Fragment =
    let v1 : (std_string_String []) = v0.l11
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
        let v20 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
        let v21 : (std_string_String -> string) = closure49()
        let v22 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v19, v21) v20 
        let v23 : string = "fable_library_rust::NativeArray_::array_from($0)"
        let v24 : (string []) = Fable.Core.RustInterop.emitRustExpr v22 v23 
        let v27 : string seq = v24 |> Seq.ofArray
        let v36 : (string -> (string seq -> string)) = String.concat
        let v37 : string = "\n"
        let v38 : (string seq -> string) = v36 v37
        let v39 : string = v38 v27
        let v46 : string = "\\n"
        let v47 : string = v39.Replace (v46, v37)
        let v48 : string = "$0"
        let v49 : (unit -> string) = closure466()
        let v50 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v49 v48 
        let v51 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v50(())"
        let v52 : (unit -> leptos_Fragment) = method263(v47)
        let v53 : string = ""
        let v54 : string = " " + v51 + v53 + ""
        let v55 : (unit -> leptos_Fragment) = method132(v52)
        let v56 : (unit -> leptos_Fragment) = method133(v55)
        let v57 : string = "pre"
        let v58 : string = "<" + v57 + " " + v54 + ">{v56()}</" + v57 + ">"
        let v59 : string = "leptos::view! { " + v58 + " }"
        let v60 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v59 
        let v61 : leptos_HtmlElement<leptos_html_Pre> = v60 |> unbox
        let v62 : string = "leptos::IntoView::into_view($0)"
        let v63 : leptos_View = Fable.Core.RustInterop.emitRustExpr v61 v62 
        let v64 : (leptos_View []) = [|v63|]
        let v65 : string = "$0.to_vec()"
        let v66 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v64 v65 
        let v67 : string = "leptos::Fragment::new($0)"
        let v68 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v66 v67 
        v68
and method344 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure465(v0)
and closure467 (v0 : Heap5) () : leptos_Fragment =
    let v1 : bool = v0.l9
    let v4 : (bool -> string) = _.ToString()
    let v5 : string = v4 v1
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v12 
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
and method345 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure467(v0)
and closure468 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l3
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
and method346 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure468(v0)
and closure469 (v0 : Heap5) () : leptos_Fragment =
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
and method347 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure469(v0)
and closure470 (v0 : Heap5) () : leptos_Fragment =
    let v1 : std_string_String = v0.l0
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
and method348 (v0 : Heap5) : (unit -> leptos_Fragment) =
    closure470(v0)
and closure455 (v0 : Heap5, v1 : string) () : leptos_Fragment =
    let v2 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v3 : (unit -> leptos_Fragment) = method336(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method132(v3)
    let v7 : (unit -> leptos_Fragment) = method133(v6)
    let v8 : string = "td"
    let v9 : string = "<" + v8 + " " + v5 + ">{v7()}</" + v8 + ">"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : leptos_HtmlElement<leptos_html_Td> = v11 |> unbox
    let v13 : string = "leptos::IntoView::into_view($0)"
    let v14 : leptos_View = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v16 : (unit -> leptos_Fragment) = method337(v0)
    let v17 : string = " " + v15 + v4 + ""
    let v18 : (unit -> leptos_Fragment) = method132(v16)
    let v19 : (unit -> leptos_Fragment) = method133(v18)
    let v20 : string = "<" + v8 + " " + v17 + ">{v19()}</" + v8 + ">"
    let v21 : string = "leptos::view! { " + v20 + " }"
    let v22 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : leptos_HtmlElement<leptos_html_Td> = v22 |> unbox
    let v24 : string = "leptos::IntoView::into_view($0)"
    let v25 : leptos_View = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v27 : (unit -> leptos_Fragment) = method338(v0)
    let v28 : string = " " + v26 + v4 + ""
    let v29 : (unit -> leptos_Fragment) = method132(v27)
    let v30 : (unit -> leptos_Fragment) = method133(v29)
    let v31 : string = "<" + v8 + " " + v28 + ">{v30()}</" + v8 + ">"
    let v32 : string = "leptos::view! { " + v31 + " }"
    let v33 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : leptos_HtmlElement<leptos_html_Td> = v33 |> unbox
    let v35 : string = "leptos::IntoView::into_view($0)"
    let v36 : leptos_View = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v38 : (unit -> leptos_Fragment) = method339(v0)
    let v39 : string = " " + v37 + v4 + ""
    let v40 : (unit -> leptos_Fragment) = method132(v38)
    let v41 : (unit -> leptos_Fragment) = method133(v40)
    let v42 : string = "<" + v8 + " " + v39 + ">{v41()}</" + v8 + ">"
    let v43 : string = "leptos::view! { " + v42 + " }"
    let v44 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : leptos_HtmlElement<leptos_html_Td> = v44 |> unbox
    let v46 : string = "leptos::IntoView::into_view($0)"
    let v47 : leptos_View = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v49 : (unit -> leptos_Fragment) = method340(v0)
    let v50 : string = " " + v48 + v4 + ""
    let v51 : (unit -> leptos_Fragment) = method132(v49)
    let v52 : (unit -> leptos_Fragment) = method133(v51)
    let v53 : string = "<" + v8 + " " + v50 + ">{v52()}</" + v8 + ">"
    let v54 : string = "leptos::view! { " + v53 + " }"
    let v55 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v54 
    let v56 : leptos_HtmlElement<leptos_html_Td> = v55 |> unbox
    let v57 : string = "leptos::IntoView::into_view($0)"
    let v58 : leptos_View = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let v59 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v60 : (unit -> leptos_Fragment) = method341(v0)
    let v61 : string = " " + v59 + v4 + ""
    let v62 : (unit -> leptos_Fragment) = method132(v60)
    let v63 : (unit -> leptos_Fragment) = method133(v62)
    let v64 : string = "<" + v8 + " " + v61 + ">{v63()}</" + v8 + ">"
    let v65 : string = "leptos::view! { " + v64 + " }"
    let v66 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v65 
    let v67 : leptos_HtmlElement<leptos_html_Td> = v66 |> unbox
    let v68 : string = "leptos::IntoView::into_view($0)"
    let v69 : leptos_View = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let v70 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v71 : (unit -> leptos_Fragment) = method342(v0)
    let v72 : string = " " + v70 + v4 + ""
    let v73 : (unit -> leptos_Fragment) = method132(v71)
    let v74 : (unit -> leptos_Fragment) = method133(v73)
    let v75 : string = "<" + v8 + " " + v72 + ">{v74()}</" + v8 + ">"
    let v76 : string = "leptos::view! { " + v75 + " }"
    let v77 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : leptos_HtmlElement<leptos_html_Td> = v77 |> unbox
    let v79 : string = "leptos::IntoView::into_view($0)"
    let v80 : leptos_View = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v82 : (unit -> leptos_Fragment) = method343(v0)
    let v83 : string = " " + v81 + v4 + ""
    let v84 : (unit -> leptos_Fragment) = method132(v82)
    let v85 : (unit -> leptos_Fragment) = method133(v84)
    let v86 : string = "<" + v8 + " " + v83 + ">{v85()}</" + v8 + ">"
    let v87 : string = "leptos::view! { " + v86 + " }"
    let v88 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : leptos_HtmlElement<leptos_html_Td> = v88 |> unbox
    let v90 : string = "leptos::IntoView::into_view($0)"
    let v91 : leptos_View = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500 [overflow:auto]\""
    let v93 : (unit -> leptos_Fragment) = method344(v0)
    let v94 : string = " " + v92 + v4 + ""
    let v95 : (unit -> leptos_Fragment) = method132(v93)
    let v96 : (unit -> leptos_Fragment) = method133(v95)
    let v97 : string = "<" + v8 + " " + v94 + ">{v96()}</" + v8 + ">"
    let v98 : string = "leptos::view! { " + v97 + " }"
    let v99 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : leptos_HtmlElement<leptos_html_Td> = v99 |> unbox
    let v101 : string = "leptos::IntoView::into_view($0)"
    let v102 : leptos_View = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let v103 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v104 : (unit -> leptos_Fragment) = method345(v0)
    let v105 : string = " " + v103 + v4 + ""
    let v106 : (unit -> leptos_Fragment) = method132(v104)
    let v107 : (unit -> leptos_Fragment) = method133(v106)
    let v108 : string = "<" + v8 + " " + v105 + ">{v107()}</" + v8 + ">"
    let v109 : string = "leptos::view! { " + v108 + " }"
    let v110 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : leptos_HtmlElement<leptos_html_Td> = v110 |> unbox
    let v112 : string = "leptos::IntoView::into_view($0)"
    let v113 : leptos_View = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v114 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v115 : (unit -> leptos_Fragment) = method346(v0)
    let v116 : string = " " + v114 + v4 + ""
    let v117 : (unit -> leptos_Fragment) = method132(v115)
    let v118 : (unit -> leptos_Fragment) = method133(v117)
    let v119 : string = "<" + v8 + " " + v116 + ">{v118()}</" + v8 + ">"
    let v120 : string = "leptos::view! { " + v119 + " }"
    let v121 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v120 
    let v122 : leptos_HtmlElement<leptos_html_Td> = v121 |> unbox
    let v123 : string = "leptos::IntoView::into_view($0)"
    let v124 : leptos_View = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let v125 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v126 : (unit -> leptos_Fragment) = method347(v0)
    let v127 : string = " " + v125 + v4 + ""
    let v128 : (unit -> leptos_Fragment) = method132(v126)
    let v129 : (unit -> leptos_Fragment) = method133(v128)
    let v130 : string = "<" + v8 + " " + v127 + ">{v129()}</" + v8 + ">"
    let v131 : string = "leptos::view! { " + v130 + " }"
    let v132 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : leptos_HtmlElement<leptos_html_Td> = v132 |> unbox
    let v134 : string = "leptos::IntoView::into_view($0)"
    let v135 : leptos_View = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "class=\"whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-500\""
    let v137 : (unit -> leptos_Fragment) = method348(v0)
    let v138 : string = " " + v136 + v4 + ""
    let v139 : (unit -> leptos_Fragment) = method132(v137)
    let v140 : (unit -> leptos_Fragment) = method133(v139)
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
and method335 (v0 : Heap5, v1 : string) : (unit -> leptos_Fragment) =
    closure455(v0, v1)
and closure454 () struct (v0 : string, v1 : unativeint, v2 : Heap5) : leptos_HtmlElement<leptos_html_Tr> =
    let v3 : string = "transaction.tr_render (1)"
    let v4 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "class=\"odd:bg-gray-50 dark:odd:bg-gray-800/50\""
    let v7 : (unit -> leptos_Fragment) = method335(v2, v0)
    let v8 : string = ""
    let v9 : string = " " + v6 + v8 + ""
    let v10 : (unit -> leptos_Fragment) = method132(v7)
    let v11 : (unit -> leptos_Fragment) = method133(v10)
    let v12 : string = "tr"
    let v13 : string = "<" + v12 + " " + v9 + ">{v11()}</" + v12 + ">"
    let v14 : string = "leptos::view! { " + v13 + " }"
    let v15 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : leptos_HtmlElement<leptos_html_Tr> = v15 |> unbox
    v16
and closure471 () (v0 : leptos_HtmlElement<leptos_html_Tr>) : leptos_View =
    let v1 : string = "leptos::IntoView::into_view($0)"
    let v2 : leptos_View = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and closure473 () () : leptos_Fragment =
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
and method350 () : (unit -> leptos_Fragment) =
    closure473()
and closure474 () () : leptos_Fragment =
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
and method351 () : (unit -> leptos_Fragment) =
    closure474()
and closure475 () () : leptos_Fragment =
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
and method352 () : (unit -> leptos_Fragment) =
    closure475()
and closure476 () () : leptos_Fragment =
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
and method353 () : (unit -> leptos_Fragment) =
    closure476()
and closure477 () () : leptos_Fragment =
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
and method354 () : (unit -> leptos_Fragment) =
    closure477()
and closure478 () () : leptos_Fragment =
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
and method355 () : (unit -> leptos_Fragment) =
    closure478()
and closure479 () () : leptos_Fragment =
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
and method356 () : (unit -> leptos_Fragment) =
    closure479()
and closure480 () () : leptos_Fragment =
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
and method357 () : (unit -> leptos_Fragment) =
    closure480()
and method360 (v0 : (std_string_String []), v1 : int32) : bool =
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
            method360(v0, v9)
    else
        false
and method359 (v0 : (struct (string * unativeint * Heap5) []), v1 : int32) : bool =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 < v2
    if v3 then
        let struct (v4 : string, v5 : unativeint, v6 : Heap5) = v0.[int v1]
        let v7 : (std_string_String []) = v6.l11
        let v8 : int32 = 0
        let v9 : bool = method360(v7, v8)
        if v9 then
            true
        else
            let v10 : int32 = v1 + 1
            method359(v0, v10)
    else
        false
and closure481 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : int32 = 0
    let v2 : bool = method359(v0, v1)
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
and method358 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure481(v0)
and closure482 () () : leptos_Fragment =
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
and method361 () : (unit -> leptos_Fragment) =
    closure482()
and closure483 () () : leptos_Fragment =
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
and method362 () : (unit -> leptos_Fragment) =
    closure483()
and closure484 () () : leptos_Fragment =
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
and method363 () : (unit -> leptos_Fragment) =
    closure484()
and closure485 () () : leptos_Fragment =
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
and method364 () : (unit -> leptos_Fragment) =
    closure485()
and closure472 (v0 : (struct (string * unativeint * Heap5) [])) () : leptos_Fragment =
    let v1 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v2 : (unit -> leptos_Fragment) = method350()
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
    let v7 : string = "th"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : leptos_HtmlElement<leptos_html_Th> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v15 : (unit -> leptos_Fragment) = method351()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v15)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
    let v19 : string = "<" + v7 + " " + v16 + ">{v18()}</" + v7 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : leptos_HtmlElement<leptos_html_Th> = v21 |> unbox
    let v23 : string = "leptos::IntoView::into_view($0)"
    let v24 : leptos_View = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v26 : (unit -> leptos_Fragment) = method352()
    let v27 : string = " " + v25 + v3 + ""
    let v28 : (unit -> leptos_Fragment) = method132(v26)
    let v29 : (unit -> leptos_Fragment) = method133(v28)
    let v30 : string = "<" + v7 + " " + v27 + ">{v29()}</" + v7 + ">"
    let v31 : string = "leptos::view! { " + v30 + " }"
    let v32 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : leptos_HtmlElement<leptos_html_Th> = v32 |> unbox
    let v34 : string = "leptos::IntoView::into_view($0)"
    let v35 : leptos_View = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v37 : (unit -> leptos_Fragment) = method353()
    let v38 : string = " " + v36 + v3 + ""
    let v39 : (unit -> leptos_Fragment) = method132(v37)
    let v40 : (unit -> leptos_Fragment) = method133(v39)
    let v41 : string = "<" + v7 + " " + v38 + ">{v40()}</" + v7 + ">"
    let v42 : string = "leptos::view! { " + v41 + " }"
    let v43 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : leptos_HtmlElement<leptos_html_Th> = v43 |> unbox
    let v45 : string = "leptos::IntoView::into_view($0)"
    let v46 : leptos_View = Fable.Core.RustInterop.emitRustExpr v44 v45 
    let v47 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v48 : (unit -> leptos_Fragment) = method354()
    let v49 : string = " " + v47 + v3 + ""
    let v50 : (unit -> leptos_Fragment) = method132(v48)
    let v51 : (unit -> leptos_Fragment) = method133(v50)
    let v52 : string = "<" + v7 + " " + v49 + ">{v51()}</" + v7 + ">"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : leptos_HtmlElement<leptos_html_Th> = v54 |> unbox
    let v56 : string = "leptos::IntoView::into_view($0)"
    let v57 : leptos_View = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let v58 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v59 : (unit -> leptos_Fragment) = method355()
    let v60 : string = " " + v58 + v3 + ""
    let v61 : (unit -> leptos_Fragment) = method132(v59)
    let v62 : (unit -> leptos_Fragment) = method133(v61)
    let v63 : string = "<" + v7 + " " + v60 + ">{v62()}</" + v7 + ">"
    let v64 : string = "leptos::view! { " + v63 + " }"
    let v65 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : leptos_HtmlElement<leptos_html_Th> = v65 |> unbox
    let v67 : string = "leptos::IntoView::into_view($0)"
    let v68 : leptos_View = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let v69 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v70 : (unit -> leptos_Fragment) = method356()
    let v71 : string = " " + v69 + v3 + ""
    let v72 : (unit -> leptos_Fragment) = method132(v70)
    let v73 : (unit -> leptos_Fragment) = method133(v72)
    let v74 : string = "<" + v7 + " " + v71 + ">{v73()}</" + v7 + ">"
    let v75 : string = "leptos::view! { " + v74 + " }"
    let v76 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v75 
    let v77 : leptos_HtmlElement<leptos_html_Th> = v76 |> unbox
    let v78 : string = "leptos::IntoView::into_view($0)"
    let v79 : leptos_View = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let v80 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v81 : (unit -> leptos_Fragment) = method357()
    let v82 : string = " " + v80 + v3 + ""
    let v83 : (unit -> leptos_Fragment) = method132(v81)
    let v84 : (unit -> leptos_Fragment) = method133(v83)
    let v85 : string = "<" + v7 + " " + v82 + ">{v84()}</" + v7 + ">"
    let v86 : string = "leptos::view! { " + v85 + " }"
    let v87 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : leptos_HtmlElement<leptos_html_Th> = v87 |> unbox
    let v89 : string = "leptos::IntoView::into_view($0)"
    let v90 : leptos_View = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v92 : (unit -> leptos_Fragment) = method358(v0)
    let v93 : string = " " + v91 + v3 + ""
    let v94 : (unit -> leptos_Fragment) = method132(v92)
    let v95 : (unit -> leptos_Fragment) = method133(v94)
    let v96 : string = "<" + v7 + " " + v93 + ">{v95()}</" + v7 + ">"
    let v97 : string = "leptos::view! { " + v96 + " }"
    let v98 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : leptos_HtmlElement<leptos_html_Th> = v98 |> unbox
    let v100 : string = "leptos::IntoView::into_view($0)"
    let v101 : leptos_View = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v103 : (unit -> leptos_Fragment) = method361()
    let v104 : string = " " + v102 + v3 + ""
    let v105 : (unit -> leptos_Fragment) = method132(v103)
    let v106 : (unit -> leptos_Fragment) = method133(v105)
    let v107 : string = "<" + v7 + " " + v104 + ">{v106()}</" + v7 + ">"
    let v108 : string = "leptos::view! { " + v107 + " }"
    let v109 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v108 
    let v110 : leptos_HtmlElement<leptos_html_Th> = v109 |> unbox
    let v111 : string = "leptos::IntoView::into_view($0)"
    let v112 : leptos_View = Fable.Core.RustInterop.emitRustExpr v110 v111 
    let v113 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v114 : (unit -> leptos_Fragment) = method362()
    let v115 : string = " " + v113 + v3 + ""
    let v116 : (unit -> leptos_Fragment) = method132(v114)
    let v117 : (unit -> leptos_Fragment) = method133(v116)
    let v118 : string = "<" + v7 + " " + v115 + ">{v117()}</" + v7 + ">"
    let v119 : string = "leptos::view! { " + v118 + " }"
    let v120 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v119 
    let v121 : leptos_HtmlElement<leptos_html_Th> = v120 |> unbox
    let v122 : string = "leptos::IntoView::into_view($0)"
    let v123 : leptos_View = Fable.Core.RustInterop.emitRustExpr v121 v122 
    let v124 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v125 : (unit -> leptos_Fragment) = method363()
    let v126 : string = " " + v124 + v3 + ""
    let v127 : (unit -> leptos_Fragment) = method132(v125)
    let v128 : (unit -> leptos_Fragment) = method133(v127)
    let v129 : string = "<" + v7 + " " + v126 + ">{v128()}</" + v7 + ">"
    let v130 : string = "leptos::view! { " + v129 + " }"
    let v131 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : leptos_HtmlElement<leptos_html_Th> = v131 |> unbox
    let v133 : string = "leptos::IntoView::into_view($0)"
    let v134 : leptos_View = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let v135 : string = "class=\"whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white\""
    let v136 : (unit -> leptos_Fragment) = method364()
    let v137 : string = " " + v135 + v3 + ""
    let v138 : (unit -> leptos_Fragment) = method132(v136)
    let v139 : (unit -> leptos_Fragment) = method133(v138)
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
and method349 (v0 : (struct (string * unativeint * Heap5) [])) : (unit -> leptos_Fragment) =
    closure472(v0)
and closure351 (v0 : Heap2, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>>, v3 : leptos_ReadSignal<bool>) () : leptos_Fragment =
    let v4 : string = $"leptos::SignalGet::get(&$0)"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v23 : leptos_View =
        if v5 then
            let v6 : string = "class=\"px-[12px] py-[10px]\""
            let v7 : (unit -> leptos_Fragment) = method273(v0)
            let v8 : string = ""
            let v9 : string = " " + v6 + v8 + ""
            let v10 : (unit -> leptos_Fragment) = method132(v7)
            let v11 : (unit -> leptos_Fragment) = method133(v10)
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
            let v20 : (leptos_View []) = method122(v19)
            let v21 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v22 : leptos_View = Fable.Core.RustInterop.emitRustExpr v20 v21 
            v22
    let v24 : string = $"$0()"
    let v25 : Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)> = Fable.Core.RustInterop.emitRustExpr v2 v24 
    let v26 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v27 : (struct (string * Vec<struct (string * US25 * string * bool * bool)>) []) = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : uint64 = System.Convert.ToUInt64 v27.Length
    let v29 : bool = v28 = 0UL
    let v193 : leptos_View =
        if v29 then
            let v30 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
            let v31 : (unit -> leptos_Fragment) = method172()
            let v32 : string = ""
            let v33 : string = " " + v30 + v32 + ""
            let v34 : (unit -> leptos_Fragment) = method132(v31)
            let v35 : (unit -> leptos_Fragment) = method133(v34)
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
            let v45 : ((struct (string * unativeint * Heap5) []) option -> US56) = closure106()
            let v46 : (std_string_String -> US56) = closure107()
            let v47 : US56 = match v44 with Ok x -> v45 x | Error x -> v46 x
            let v90 : US49 =
                match v47 with
                | US56_1(v87) -> (* Error *)
                    US49_1(v87)
                | US56_0(v48) -> (* Ok *)
                    let v51 : US50 option = None
                    let _v51 = ref v51 
                    match v48 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v52 : (struct (string * unativeint * Heap5) []) = x
                    let v53 : US50 = US50_0(v52)
                    v53 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v51.Value <- x
                    let v54 : US50 option = _v51.Value 
                    let v77 : US50 = US50_1
                    let v78 : US50 = v54 |> Option.defaultValue v77 
                    US49_0(v78)
            match v90 with
            | US49_1(v175) -> (* Error *)
                let v176 : string = "fable_library_rust::String_::fromString($0)"
                let v177 : string = Fable.Core.RustInterop.emitRustExpr v175 v176 
                let v178 : string = "class=\"flex flex-1 items-center [gap:4px] [padding:5px]\""
                let v179 : (unit -> leptos_Fragment) = method164(v177)
                let v180 : string = ""
                let v181 : string = " " + v178 + v180 + ""
                let v182 : (unit -> leptos_Fragment) = method132(v179)
                let v183 : (unit -> leptos_Fragment) = method133(v182)
                let v184 : string = "div"
                let v185 : string = "<" + v184 + " " + v181 + ">{v183()}</" + v184 + ">"
                let v186 : string = "leptos::view! { " + v185 + " }"
                let v187 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v186 
                let v188 : leptos_HtmlElement<leptos_html_Div> = v187 |> unbox
                let v189 : string = "leptos::IntoView::into_view($0)"
                let v190 : leptos_View = Fable.Core.RustInterop.emitRustExpr v188 v189 
                v190
            | US49_0(v91) -> (* Ok *)
                match v91 with
                | US50_0(v92) -> (* Some *)
                    let v93 : leptos_RwSignal<Heap1> = v0.l0
                    let v94 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
                    let v95 : Heap1 = Fable.Core.RustInterop.emitRustExpr v93 v94 
                    let v96 : leptos_RwSignal<Heap0> = v95.l3
                    let v97 : string = $"leptos::SignalGet::get(&$0)"
                    let v98 : Heap0 = Fable.Core.RustInterop.emitRustExpr v96 v97 
                    let v99 : US1 = v98.l4
                    let v101 : bool =
                        match v99 with
                        | US1_0 -> (* Details *)
                            true
                        | _ ->
                            false
                    if v101 then
                        let v102 : string = "class=\"grid flex-1 py-[10px] px-[12px] [gap:15px] sm:[grid-template-columns:repeat(auto-fill,minmax(500px,1fr))]\""
                        let v103 : (unit -> leptos_Fragment) = method285(v92)
                        let v104 : string = ""
                        let v105 : string = " " + v102 + v104 + ""
                        let v106 : (unit -> leptos_Fragment) = method132(v103)
                        let v107 : (unit -> leptos_Fragment) = method133(v106)
                        let v108 : string = "div"
                        let v109 : string = "<" + v108 + " " + v105 + ">{v107()}</" + v108 + ">"
                        let v110 : string = "leptos::view! { " + v109 + " }"
                        let v111 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v110 
                        let v112 : leptos_HtmlElement<leptos_html_Div> = v111 |> unbox
                        let v113 : string = "leptos::IntoView::into_view($0)"
                        let v114 : leptos_View = Fable.Core.RustInterop.emitRustExpr v112 v113 
                        v114
                    else
                        let v115 : string = "$0.to_vec()"
                        let v116 : Vec<struct (string * unativeint * Heap5)> = Fable.Core.RustInterop.emitRustExpr v92 v115 
                        let v117 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                        let v118 : (struct (string * unativeint * Heap5) -> leptos_HtmlElement<leptos_html_Tr>) = closure454()
                        let v119 : Vec<leptos_HtmlElement<leptos_html_Tr>> = Fable.Core.RustInterop.emitRustExpr struct (v116, v118) v117 
                        let v120 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                        let v121 : (leptos_HtmlElement<leptos_html_Tr> -> leptos_View) = closure471()
                        let v122 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v119, v121) v120 
                        let v123 : string = "fable_library_rust::NativeArray_::array_from($0)"
                        let v124 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v122 v123 
                        let v125 : string = "$0.to_vec()"
                        let v126 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v124 v125 
                        let v127 : string = "leptos::Fragment::new($0)"
                        let v128 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v126 v127 
                        let v129 : string = "transaction.tr_head_render (1)"
                        let v130 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
                        let v131 : bool = Fable.Core.RustInterop.emitRustExpr v129 v130 
                        let v132 : (unit -> leptos_Fragment) = method349(v92)
                        let v133 : (unit -> leptos_Fragment) = method132(v132)
                        let v134 : (unit -> leptos_Fragment) = method133(v133)
                        let v135 : string = "tr"
                        let v136 : string = ""
                        let v137 : string = "<" + v135 + " " + v136 + ">{v134()}</" + v135 + ">"
                        let v138 : string = "leptos::view! { " + v137 + " }"
                        let v139 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v138 
                        let v140 : leptos_HtmlElement<leptos_html_Tr> = v139 |> unbox
                        let v141 : string = "leptos::IntoView::into_view($0)"
                        let v142 : leptos_View = Fable.Core.RustInterop.emitRustExpr v140 v141 
                        let v143 : (leptos_View []) = [|v142|]
                        let v144 : string = "$0.to_vec()"
                        let v145 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v143 v144 
                        let v146 : string = "leptos::Fragment::new($0)"
                        let v147 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v145 v146 
                        let v148 : string = "class=\"flex-1 min-w-full divide-y-2 divide-gray-200 text-sm dark:divide-gray-700\""
                        let v149 : (unit -> leptos_Fragment) = method194(v147, v128)
                        let v150 : string = " " + v148 + v136 + ""
                        let v151 : (unit -> leptos_Fragment) = method132(v149)
                        let v152 : (unit -> leptos_Fragment) = method133(v151)
                        let v153 : string = "table"
                        let v154 : string = "<" + v153 + " " + v150 + ">{v152()}</" + v153 + ">"
                        let v155 : string = "leptos::view! { " + v154 + " }"
                        let v156 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v155 
                        let v157 : leptos_HtmlElement<leptos_html_Table> = v156 |> unbox
                        let v158 : string = "leptos::IntoView::into_view($0)"
                        let v159 : leptos_View = Fable.Core.RustInterop.emitRustExpr v157 v158 
                        v159
                | _ ->
                    let v161 : string = "class=\"grid place-content-center py-[10vh]\""
                    let v162 : (unit -> leptos_Fragment) = method197()
                    let v163 : string = ""
                    let v164 : string = " " + v161 + v163 + ""
                    let v165 : (unit -> leptos_Fragment) = method132(v162)
                    let v166 : (unit -> leptos_Fragment) = method133(v165)
                    let v167 : string = "div"
                    let v168 : string = "<" + v167 + " " + v164 + ">{v166()}</" + v167 + ">"
                    let v169 : string = "leptos::view! { " + v168 + " }"
                    let v170 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v169 
                    let v171 : leptos_HtmlElement<leptos_html_Div> = v170 |> unbox
                    let v172 : string = "leptos::IntoView::into_view($0)"
                    let v173 : leptos_View = Fable.Core.RustInterop.emitRustExpr v171 v172 
                    v173
    let v194 : (leptos_View []) = [|v23; v193|]
    let v195 : string = "$0.to_vec()"
    let v196 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v194 v195 
    let v197 : string = "leptos::Fragment::new($0)"
    let v198 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v196 v197 
    v198
and method272 (v0 : Heap2, v1 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>, v2 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>>, v3 : leptos_ReadSignal<bool>) : (unit -> leptos_Fragment) =
    closure351(v0, v1, v2, v3)
and closure488 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure489 (v0 : leptos_View) () : Ref<Lifetime<StaticLifetime, Str>> =
    let v4 : string = "[margin-right:40px]"
    let v5 : string = "r#\"" + v4 + "\"#"
    let v6 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v5 
    v6
and closure492 () () : string =
    let v0 : string = "Transactions"
    v0
and method369 (v0 : leptos_View) : (unit -> string) =
    closure492()
and closure491 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : (unit -> string) = method369(v0)
    let v2 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v3 : (unit -> leptos_Fragment) = method149(v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method132(v3)
    let v7 : (unit -> leptos_Fragment) = method133(v6)
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
and method368 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure491(v0)
and closure490 (v0 : leptos_View) () : leptos_Fragment =
    let v1 : string = "class=\"flex items-center gap-2\""
    let v2 : (unit -> leptos_Fragment) = method368(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
    let v7 : string = "div"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : leptos_HtmlElement<leptos_html_Div> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v15 : (unit -> leptos_Fragment) = method150()
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v15)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
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
and method367 (v0 : leptos_View) : (unit -> leptos_Fragment) =
    closure490(v0)
and closure487 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure488()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure489(v0)
    let v7 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v7(()) + \" \" + &v4(())"
    let v9 : (unit -> leptos_Fragment) = method367(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "summary"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Summary> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=\"flex flex-1 flex-col\""
    let v22 : (unit -> leptos_Fragment) = method152(v1)
    let v23 : string = " " + v21 + v10 + ""
    let v24 : (unit -> leptos_Fragment) = method132(v22)
    let v25 : (unit -> leptos_Fragment) = method133(v24)
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
and method366 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure487(v0, v1)
and closure486 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method366(v0, v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method365 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure486(v0, v1)
and closure494 () () : leptos_Fragment =
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
and method371 () : (unit -> leptos_Fragment) =
    closure494()
and closure496 () () : string =
    let v0 : string = "[max-height:70vh]"
    v0
and closure495 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : leptos_Fragment =
    let v1 : string = $"$0()"
    let v2 : Result<(struct (string * unativeint * Heap5) []) option, std_string_String> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v5 : bool = true
    let mutable _v5 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{:#?}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{:#?}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{:#?}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v10 
    v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : std_string_String = null |> unbox<std_string_String>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : std_string_String = null |> unbox<std_string_String>
    v23 
    #endif
#else
    let v32 : std_string_String = null |> unbox<std_string_String>
    v32 
    #endif
    |> fun x -> _v5 <- Some x
    let v39 : std_string_String = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    let v54 : string = "fable_library_rust::String_::fromString($0)"
    let v55 : string = Fable.Core.RustInterop.emitRustExpr v39 v54 
    let v56 : string = "$0"
    let v57 : (unit -> string) = closure496()
    let v58 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v57 v56 
    let v59 : string = "class=move || \"[padding:1px] [font-size:12px] [line-height:12px] [text-wrap:pretty] \".to_owned() + &v58(())"
    let v60 : (unit -> leptos_Fragment) = method263(v55)
    let v61 : string = ""
    let v62 : string = " " + v59 + v61 + ""
    let v63 : (unit -> leptos_Fragment) = method132(v60)
    let v64 : (unit -> leptos_Fragment) = method133(v63)
    let v65 : string = "pre"
    let v66 : string = "<" + v65 + " " + v62 + ">{v64()}</" + v65 + ">"
    let v67 : string = "leptos::view! { " + v66 + " }"
    let v68 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : leptos_HtmlElement<leptos_html_Pre> = v68 |> unbox
    let v70 : string = "leptos::IntoView::into_view($0)"
    let v71 : leptos_View = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let v72 : (leptos_View []) = [|v71|]
    let v73 : string = "$0.to_vec()"
    let v74 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v72 v73 
    let v75 : string = "leptos::Fragment::new($0)"
    let v76 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v74 v75 
    v76
and method372 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) : (unit -> leptos_Fragment) =
    closure495(v0)
and closure493 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) () : leptos_Fragment =
    let v1 : (unit -> leptos_Fragment) = method371()
    let v2 : (unit -> leptos_Fragment) = method372(v0)
    let v3 : string = "$0"
    let v4 : (unit -> string) = closure338()
    let v5 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v4 v3 
    let v6 : string = "$0"
    let v7 : (unit -> string) = closure310()
    let v8 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v7 v6 
    let v9 : string = "$0"
    let v10 : (unit -> string) = closure311()
    let v11 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v10 v9 
    let v12 : string = "class=move || \"grid gap-[1px] flex-1 even:bg-gray-50 [inline-size:max-content] [width:100%] [grid-auto-columns:max-content] \".to_owned() + &v11(()) + \" \" + &v8(()) + \" \" + &v5(())"
    let v13 : (unit -> leptos_Fragment) = method264(v1, v2)
    let v14 : string = ""
    let v15 : string = " " + v12 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v13)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
    let v18 : string = "dl"
    let v19 : string = "<" + v18 + " " + v15 + ">{v17()}</" + v18 + ">"
    let v20 : string = "leptos::view! { " + v19 + " }"
    let v21 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : leptos_HtmlElement<leptos_html_Dl> = v21 |> unbox
    let v23 : (leptos_HtmlElement<leptos_html_Dl> []) = [|v22|]
    let v24 : string = "$0.to_vec()"
    let v25 : Vec<leptos_HtmlElement<leptos_html_Dl>> = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v27 : (leptos_HtmlElement<leptos_html_Dl> -> leptos_View) = closure322()
    let v28 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v26 
    let v29 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v30 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : string = "$0.to_vec()"
    let v32 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v30 v31 
    let v33 : string = "leptos::Fragment::new($0)"
    let v34 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v32 v33 
    v34
and method370 (v0 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>>) : (unit -> leptos_Fragment) =
    closure493(v0)
and closure499 () () : string =
    let v0 : string = "py-[7px]"
    v0
and closure500 () () : Ref<Lifetime<StaticLifetime, Str>> =
    let v3 : string = ""
    let v4 : string = "r#\"" + v3 + "\"#"
    let v5 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v4 
    v5
and closure503 () () : string =
    let v0 : string = "Debug"
    v0
and method377 () : (unit -> string) =
    closure503()
and closure502 () () : leptos_Fragment =
    let v0 : (unit -> string) = method377()
    let v1 : string = "class=\"[font-size:14px] [line-height:21px] [padding-right:11px]\""
    let v2 : (unit -> leptos_Fragment) = method149(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method376 () : (unit -> leptos_Fragment) =
    closure502()
and closure501 () () : leptos_Fragment =
    let v0 : string = "class=\"flex items-center gap-2\""
    let v1 : (unit -> leptos_Fragment) = method376()
    let v2 : string = ""
    let v3 : string = " " + v0 + v2 + ""
    let v4 : (unit -> leptos_Fragment) = method132(v1)
    let v5 : (unit -> leptos_Fragment) = method133(v4)
    let v6 : string = "div"
    let v7 : string = "<" + v6 + " " + v3 + ">{v5()}</" + v6 + ">"
    let v8 : string = "leptos::view! { " + v7 + " }"
    let v9 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : leptos_HtmlElement<leptos_html_Div> = v9 |> unbox
    let v11 : string = "leptos::IntoView::into_view($0)"
    let v12 : leptos_View = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "class=\"shrink-0 transition duration-300 pt-[2px]\""
    let v14 : (unit -> leptos_Fragment) = method150()
    let v15 : string = " " + v13 + v2 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v14)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
and method375 () : (unit -> leptos_Fragment) =
    closure501()
and closure498 (v0 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v1 : string = "$0"
    let v2 : (unit -> string) = closure499()
    let v3 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v2 v1 
    let v4 : string = "$0"
    let v5 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure500()
    let v6 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "class=move || \"flex flex-1 items-center justify-between px-4 cursor-pointer text-gray-600 hover:text-gray-700 bg-gray-300 hover:bg-gray-200 \".to_owned() + v6(()) + \" \" + &v3(())"
    let v8 : (unit -> leptos_Fragment) = method375()
    let v9 : string = ""
    let v10 : string = " " + v7 + v9 + ""
    let v11 : (unit -> leptos_Fragment) = method132(v8)
    let v12 : (unit -> leptos_Fragment) = method133(v11)
    let v13 : string = "summary"
    let v14 : string = "<" + v13 + " " + v10 + ">{v12()}</" + v13 + ">"
    let v15 : string = "leptos::view! { " + v14 + " }"
    let v16 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : leptos_HtmlElement<leptos_html_Summary> = v16 |> unbox
    let v18 : string = "leptos::IntoView::into_view($0)"
    let v19 : leptos_View = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "class=\"flex flex-1 flex-col\""
    let v21 : (unit -> leptos_Fragment) = method152(v0)
    let v22 : string = " " + v20 + v9 + ""
    let v23 : (unit -> leptos_Fragment) = method132(v21)
    let v24 : (unit -> leptos_Fragment) = method133(v23)
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
and method374 (v0 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure498(v0)
and closure497 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) () : leptos_Fragment =
    let v2 : string = "$0"
    let v3 : (unit -> string) = closure206()
    let v4 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v3 v2 
    let v5 : string = "$0"
    let v6 : (unit -> bool) = closure207()
    let v7 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "class=\"[position:absolute] [right:0] [top:0]\""
    let v9 : (unit -> leptos_Fragment) = method144(v0)
    let v10 : string = ""
    let v11 : string = " " + v8 + v10 + ""
    let v12 : (unit -> leptos_Fragment) = method132(v9)
    let v13 : (unit -> leptos_Fragment) = method133(v12)
    let v14 : string = "div"
    let v15 : string = "<" + v14 + " " + v11 + ">{v13()}</" + v14 + ">"
    let v16 : string = "leptos::view! { " + v15 + " }"
    let v17 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : leptos_HtmlElement<leptos_html_Div> = v17 |> unbox
    let v19 : string = "leptos::IntoView::into_view($0)"
    let v20 : leptos_View = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "class=move || \"flex flex-1 [&_summary::-webkit-details-marker]:hidden [&>summary>span]:open:-rotate-180 \".to_owned() + &v4(())"
    let v22 : string = "open=move || v7(())"
    let v23 : (unit -> leptos_Fragment) = method374(v1)
    let v24 : string = " " + v21 + v10 + ""
    let v25 : string = " " + v22 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v23)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
and method373 (v0 : leptos_View, v1 : (unit -> leptos_Fragment)) : (unit -> leptos_Fragment) =
    closure497(v0, v1)
and closure504 (v0 : leptos_Fragment) () : leptos_Fragment =
    v0
and method378 (v0 : leptos_Fragment) : (unit -> leptos_Fragment) =
    closure504(v0)
and closure44 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = $"leptos::SignalGet::get(&$0)"
    let v2 : US20 = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v503 : US24 =
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
            let v20 : (unit -> (struct (string * US25 * string * bool * bool) [])) = closure50(v18)
            let v21 : (unit -> (struct (string * US25 * string * bool * bool) [])) = Fable.Core.RustInterop.emitRustExpr v20 v19 
            let v22 : string = "leptos::create_memo(move |_| { v21(()) })"
            let v23 : leptos_Memo<(struct (string * US25 * string * bool * bool) [])> = Fable.Core.RustInterop.emitRustExpr () v22 
            let v24 : string = "$0"
            let v25 : (unit -> Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>) = closure52(v10, v18)
            let v26 : (unit -> Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>) = Fable.Core.RustInterop.emitRustExpr v25 v24 
            let v27 : string = "leptos::create_memo(move |_| { v26(()) })"
            let v28 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>> = Fable.Core.RustInterop.emitRustExpr () v27 
            let v29 : string = "$0"
            let v30 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = closure55(v28)
            let v31 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = Fable.Core.RustInterop.emitRustExpr v30 v29 
            let v32 : string = "leptos::create_memo(move |_| { v31(()) })"
            let v33 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>> = Fable.Core.RustInterop.emitRustExpr () v32 
            let v34 : string = "$0"
            let v35 : (unit -> (string [])) = closure57(v28)
            let v36 : (unit -> (string [])) = Fable.Core.RustInterop.emitRustExpr v35 v34 
            let v37 : string = "leptos::create_memo(move |_| { v36(()) })"
            let v38 : leptos_Memo<(string [])> = Fable.Core.RustInterop.emitRustExpr () v37 
            let v39 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) [])) = closure60()
            let v40 : leptos_Memo<Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>> = method62(v33, v39)
            let v43 : string = $"%A{v40}"
            let v50 : string = "use_transactions.render (7) / root func0 / result: " + string v43 + ""
            let v51 : int64 = 200L
            let v52 : string = method8(v51, v50)
            let v53 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v54 : bool = Fable.Core.RustInterop.emitRustExpr v52 v53 
            let v55 : string = "$0"
            let v56 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = closure90(v38, v40)
            let v57 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v56 v55 
            let v58 : string = "leptos::create_memo(move |_| { v57(()) })"
            let v59 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v58 
            let v60 : string = "$0"
            let v61 : (unit -> Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>) = closure105(v59)
            let v62 : (unit -> Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v61 v60 
            let v63 : string = "leptos::create_memo(move |_| { v62(()) })"
            let v64 : leptos_Memo<Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v63 
            let v65 : string = "$0"
            let v66 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = closure111(v64)
            let v67 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = Fable.Core.RustInterop.emitRustExpr v66 v65 
            let v68 : string = "leptos::create_memo(move |_| { v67(()) })"
            let v69 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>> = Fable.Core.RustInterop.emitRustExpr () v68 
            let v70 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option)) = closure114()
            let v71 : leptos_Memo<Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>> = method112(v69, v70)
            let v74 : string = $"%A{v71}"
            let v81 : string = "use_transactions.render (12) / rpc_response func0 / result: " + string v74 + ""
            let v82 : int64 = 200L
            let v83 : string = method8(v82, v81)
            let v84 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "leptos::create_action(move |value: &std::sync::Arc<Heap6>| $0(value.clone()))"
            let v87 : (Heap6 -> std_pin_Pin<Box<Dyn<std_future_Future<Result<US60, std_string_String>>>>>) = closure132()
            let v88 : leptos_Action<Heap6, Result<US60, std_string_String>> = Fable.Core.RustInterop.emitRustExpr v87 v86 
            let v89 : string = "$0"
            let v90 : (unit -> Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) = closure137(v88)
            let v91 : (unit -> Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v90 v89 
            let v92 : string = "leptos::create_memo(move |_| { v91(()) })"
            let v93 : leptos_Memo<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v92 
            let v94 : string = "$0"
            let v95 : (unit -> string option) = closure141(v93)
            let v96 : (unit -> string option) = Fable.Core.RustInterop.emitRustExpr v95 v94 
            let v97 : string = "leptos::create_memo(move |_| { v96(()) })"
            let v98 : leptos_Memo<string option> = Fable.Core.RustInterop.emitRustExpr () v97 
            let v99 : string = "$0"
            let v100 : (unit -> US34) = closure144(v10)
            let v101 : (unit -> US34) = Fable.Core.RustInterop.emitRustExpr v100 v99 
            let v102 : string = "leptos::create_memo(move |_| { v101(()) })"
            let v103 : leptos_Memo<US34> = Fable.Core.RustInterop.emitRustExpr () v102 
            let v104 : string = "$0"
            let v105 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>) = closure145(v10)
            let v106 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>) = Fable.Core.RustInterop.emitRustExpr v105 v104 
            let v107 : string = "leptos::create_memo(move |_| { v106(()) })"
            let v108 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<std_string_String> * leptos_WriteSignal<std_string_String>))>> = Fable.Core.RustInterop.emitRustExpr () v107 
            let v109 : string = "$0"
            let v110 : (unit -> Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>) = closure148(v108)
            let v111 : (unit -> Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>) = Fable.Core.RustInterop.emitRustExpr v110 v109 
            let v112 : string = "leptos::create_memo(move |_| { v111(()) })"
            let v113 : leptos_Memo<Vec<struct (int32 * leptos_ReadSignal<std_string_String>)>> = Fable.Core.RustInterop.emitRustExpr () v112 
            let v114 : (leptos_View []) = [||]
            let v115 : (leptos_View []) = method122(v114)
            let v116 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v117 : leptos_View = Fable.Core.RustInterop.emitRustExpr v115 v116 
            let v118 : (unit -> leptos_Fragment) = method123(v10, v88, v98, v103, v113)
            let v119 : (unit -> leptos_Fragment) = method142(v118)
            let v120 : string = "class=\"flex flex-col [position:relative]\""
            let v121 : (unit -> leptos_Fragment) = method166(v117, v119)
            let v122 : string = ""
            let v123 : string = " " + v120 + v122 + ""
            let v124 : (unit -> leptos_Fragment) = method132(v121)
            let v125 : (unit -> leptos_Fragment) = method133(v124)
            let v126 : string = "div"
            let v127 : string = "<" + v126 + " " + v123 + ">{v125()}</" + v126 + ">"
            let v128 : string = "leptos::view! { " + v127 + " }"
            let v129 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v128 
            let v130 : leptos_HtmlElement<leptos_html_Div> = v129 |> unbox
            let v131 : string = "leptos::IntoView::into_view($0)"
            let v132 : leptos_View = Fable.Core.RustInterop.emitRustExpr v130 v131 
            let v133 : (leptos_View []) = [||]
            let v134 : (leptos_View []) = method122(v133)
            let v135 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v136 : leptos_View = Fable.Core.RustInterop.emitRustExpr v134 v135 
            let v137 : (unit -> leptos_Fragment) = method171(v71, v59, v28)
            let v138 : (unit -> leptos_Fragment) = method142(v137)
            let v139 : string = "class=\"flex flex-col [position:relative]\""
            let v140 : (unit -> leptos_Fragment) = method199(v136, v138)
            let v141 : string = " " + v139 + v122 + ""
            let v142 : (unit -> leptos_Fragment) = method132(v140)
            let v143 : (unit -> leptos_Fragment) = method133(v142)
            let v144 : string = "<" + v126 + " " + v141 + ">{v143()}</" + v126 + ">"
            let v145 : string = "leptos::view! { " + v144 + " }"
            let v146 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v145 
            let v147 : leptos_HtmlElement<leptos_html_Div> = v146 |> unbox
            let v148 : string = "leptos::IntoView::into_view($0)"
            let v149 : leptos_View = Fable.Core.RustInterop.emitRustExpr v147 v148 
            let v150 : (leptos_View []) = [|v132; v149|]
            let v151 : string = "$0.to_vec()"
            let v152 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v150 v151 
            let v153 : string = "leptos::Fragment::new($0)"
            let v154 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v152 v153 
            US24_0(v154)
        | US20_2 -> (* Lists *)
            let v156 : string = "lists_view.render ()"
            let v157 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v158 : bool = Fable.Core.RustInterop.emitRustExpr v156 v157 
            let v159 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v160 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v159 
            let v161 : string = "$0.unwrap()"
            let v162 : Heap2 = Fable.Core.RustInterop.emitRustExpr v160 v161 
            let v163 : string = "&*$0"
            let v164 : string = "???"
            let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v164 v163 
            let v166 : string = "String::from($0)"
            let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v165 v166 
            let v168 : string = "leptos::html::text($0)"
            let v169 : leptos_dom_Text = Fable.Core.RustInterop.emitRustExpr v167 v168 
            let v170 : string = "leptos::IntoView::into_view($0)"
            let v171 : leptos_View = Fable.Core.RustInterop.emitRustExpr v169 v170 
            let v172 : (leptos_View []) = [|v171|]
            let v173 : string = "$0.to_vec()"
            let v174 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v172 v173 
            let v175 : string = "leptos::Fragment::new($0)"
            let v176 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v174 v175 
            US24_0(v176)
        | US20_4 -> (* Settings *)
            let v360 : string = "settings_view.render ()"
            let v361 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v362 : bool = Fable.Core.RustInterop.emitRustExpr v360 v361 
            let v363 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v364 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v363 
            let v365 : string = "$0.unwrap()"
            let v366 : Heap2 = Fable.Core.RustInterop.emitRustExpr v364 v365 
            let v367 : string = "$0"
            let v368 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) = closure248(v366)
            let v369 : (unit -> Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>) = Fable.Core.RustInterop.emitRustExpr v368 v367 
            let v370 : string = "leptos::create_memo(move |_| { v369(()) })"
            let v371 : leptos_Memo<Vec<(int32 * struct (leptos_ReadSignal<(bool * std_string_String)> * leptos_WriteSignal<(bool * std_string_String)>))>> = Fable.Core.RustInterop.emitRustExpr () v370 
            let v372 : string = $"leptos::create_signal($0)"
            let struct (v373 : leptos_ReadSignal<int32>, v374 : leptos_WriteSignal<int32>) = Fable.Core.RustInterop.emitRustExpr 0 v372 
            let v375 : string = "$0"
            let v376 : (unit -> Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>) = closure251(v371, v373)
            let v377 : (unit -> Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>) = Fable.Core.RustInterop.emitRustExpr v376 v375 
            let v378 : string = "leptos::create_memo(move |_| { v377(()) })"
            let v379 : leptos_Memo<Vec<struct (int32 * int32 * leptos_ReadSignal<(bool * std_string_String)>)>> = Fable.Core.RustInterop.emitRustExpr () v378 
            let v380 : string = "$0"
            let v381 : (unit -> int32) = closure254(v379)
            let v382 : (unit -> int32) = Fable.Core.RustInterop.emitRustExpr v381 v380 
            let v383 : string = "leptos::create_memo(move |_| { v382(()) })"
            let v384 : leptos_Memo<int32> = Fable.Core.RustInterop.emitRustExpr () v383 
            let v385 : (unit -> unit) = closure255(v366, v371, v374)
            let v386 : string = "let v385 = $0"
            Fable.Core.RustInterop.emitRustExpr v385 v386 
            let v387 : string = "$0"
            let v388 : (unit -> string) = closure260()
            let v389 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v388 v387 
            let v390 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v391 : string = "fill=\"none\""
            let v392 : string = "viewBox=\"0 0 24 24\""
            let v393 : string = "stroke-width=\"1.5\""
            let v394 : string = "stroke=\"currentColor\""
            let v395 : string = "class=move || \" \".to_owned() + &v389(())"
            let v396 : (unit -> leptos_Fragment) = method208()
            let v397 : string = ""
            let v398 : string = " " + v390 + v397 + ""
            let v399 : string = " " + v391 + v398 + ""
            let v400 : string = " " + v392 + v399 + ""
            let v401 : string = " " + v393 + v400 + ""
            let v402 : string = " " + v394 + v401 + ""
            let v403 : string = " " + v395 + v402 + ""
            let v404 : (unit -> leptos_Fragment) = method132(v396)
            let v405 : (unit -> leptos_Fragment) = method133(v404)
            let v406 : string = "svg"
            let v407 : string = "<" + v406 + " " + v403 + ">{v405()}</" + v406 + ">"
            let v408 : string = "leptos::view! { " + v407 + " }"
            let v409 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v408 
            let v410 : leptos_HtmlElement<leptos_svg_Svg> = v409 |> unbox
            let v411 : string = "on:click=move |_| v385()"
            let v412 : string = "aria-label=\"Add\""
            let v413 : string = "$0"
            let v414 : (unit -> std_string_String) = closure262()
            let v415 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v414 v413 
            let v416 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v415(())"
            let v417 : (unit -> leptos_Fragment) = method209(v410)
            let v418 : string = " " + v416 + v397 + ""
            let v419 : string = " " + v411 + v418 + ""
            let v420 : string = " " + v412 + v419 + ""
            let v421 : (unit -> leptos_Fragment) = method132(v417)
            let v422 : (unit -> leptos_Fragment) = method133(v421)
            let v423 : string = "button"
            let v424 : string = "<" + v423 + " " + v420 + ">{v422()}</" + v423 + ">"
            let v425 : string = "leptos::view! { " + v424 + " }"
            let v426 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v425 
            let v427 : leptos_HtmlElement<leptos_html_Button> = v426 |> unbox
            let v428 : string = "leptos::IntoView::into_view($0)"
            let v429 : leptos_View = Fable.Core.RustInterop.emitRustExpr v427 v428 
            let v430 : (leptos_View []) = [||]
            let v431 : (leptos_View []) = method122(v430)
            let v432 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v433 : leptos_View = Fable.Core.RustInterop.emitRustExpr v431 v432 
            let v434 : (unit -> leptos_Fragment) = method210(v366, v379, v384, v371, v374)
            let v435 : (unit -> leptos_Fragment) = method142(v434)
            let v436 : string = "class=\"flex flex-col [position:relative]\""
            let v437 : (unit -> leptos_Fragment) = method234(v429, v435)
            let v438 : string = " " + v436 + v397 + ""
            let v439 : (unit -> leptos_Fragment) = method132(v437)
            let v440 : (unit -> leptos_Fragment) = method133(v439)
            let v441 : string = "div"
            let v442 : string = "<" + v441 + " " + v438 + ">{v440()}</" + v441 + ">"
            let v443 : string = "leptos::view! { " + v442 + " }"
            let v444 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v443 
            let v445 : leptos_HtmlElement<leptos_html_Div> = v444 |> unbox
            let v446 : string = "leptos::IntoView::into_view($0)"
            let v447 : leptos_View = Fable.Core.RustInterop.emitRustExpr v445 v446 
            let v448 : (leptos_View []) = [||]
            let v449 : (leptos_View []) = method122(v448)
            let v450 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v451 : leptos_View = Fable.Core.RustInterop.emitRustExpr v449 v450 
            let v452 : (unit -> leptos_Fragment) = method239(v366)
            let v453 : (unit -> leptos_Fragment) = method142(v452)
            let v454 : string = "class=\"flex flex-col [position:relative]\""
            let v455 : (unit -> leptos_Fragment) = method254(v451, v453)
            let v456 : string = " " + v454 + v397 + ""
            let v457 : (unit -> leptos_Fragment) = method132(v455)
            let v458 : (unit -> leptos_Fragment) = method133(v457)
            let v459 : string = "<" + v441 + " " + v456 + ">{v458()}</" + v441 + ">"
            let v460 : string = "leptos::view! { " + v459 + " }"
            let v461 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v460 
            let v462 : leptos_HtmlElement<leptos_html_Div> = v461 |> unbox
            let v463 : string = "leptos::IntoView::into_view($0)"
            let v464 : leptos_View = Fable.Core.RustInterop.emitRustExpr v462 v463 
            let v465 : leptos_RwSignal<Heap1> = v366.l0
            let v466 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v467 : Heap1 = Fable.Core.RustInterop.emitRustExpr v465 v466 
            let v468 : leptos_RwSignal<bool> = v467.l1
            let v469 : string = $"leptos::SignalGet::get(&$0)"
            let v470 : bool = Fable.Core.RustInterop.emitRustExpr v468 v469 
            let v492 : leptos_View =
                if v470 then
                    let v471 : (leptos_View []) = [||]
                    let v472 : (leptos_View []) = method122(v471)
                    let v473 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v474 : leptos_View = Fable.Core.RustInterop.emitRustExpr v472 v473 
                    let v475 : (unit -> leptos_Fragment) = method259()
                    let v476 : (unit -> leptos_Fragment) = method142(v475)
                    let v477 : string = "class=\"flex flex-col [position:relative]\""
                    let v478 : (unit -> leptos_Fragment) = method265(v474, v476)
                    let v479 : string = " " + v477 + v397 + ""
                    let v480 : (unit -> leptos_Fragment) = method132(v478)
                    let v481 : (unit -> leptos_Fragment) = method133(v480)
                    let v482 : string = "<" + v441 + " " + v479 + ">{v481()}</" + v441 + ">"
                    let v483 : string = "leptos::view! { " + v482 + " }"
                    let v484 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v483 
                    let v485 : leptos_HtmlElement<leptos_html_Div> = v484 |> unbox
                    let v486 : string = "leptos::IntoView::into_view($0)"
                    let v487 : leptos_View = Fable.Core.RustInterop.emitRustExpr v485 v486 
                    v487
                else
                    let v488 : (leptos_View []) = [||]
                    let v489 : (leptos_View []) = method122(v488)
                    let v490 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v491 : leptos_View = Fable.Core.RustInterop.emitRustExpr v489 v490 
                    v491
            let v493 : (leptos_View []) = [|v447; v464; v492|]
            let v494 : string = "$0.to_vec()"
            let v495 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v493 v494 
            let v496 : string = "leptos::Fragment::new($0)"
            let v497 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v495 v496 
            US24_0(v497)
        | US20_3 -> (* Transactions *)
            let v178 : string = "transactions_view.render (1)"
            let v179 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v180 : bool = Fable.Core.RustInterop.emitRustExpr v178 v179 
            let v181 : string = "leptos::use_context::<std::sync::Arc<Heap2>>()"
            let v182 : Heap2 option = Fable.Core.RustInterop.emitRustExpr () v181 
            let v183 : string = "$0.unwrap()"
            let v184 : Heap2 = Fable.Core.RustInterop.emitRustExpr v182 v183 
            let v185 : string = "use_transactions.render (1)"
            let v186 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v187 : bool = Fable.Core.RustInterop.emitRustExpr v185 v186 
            let v188 : string = "$0"
            let v189 : (unit -> Vec<string>) = closure45(v184)
            let v190 : (unit -> Vec<string>) = Fable.Core.RustInterop.emitRustExpr v189 v188 
            let v191 : string = "leptos::create_memo(move |_| { v190(()) })"
            let v192 : leptos_Memo<Vec<string>> = Fable.Core.RustInterop.emitRustExpr () v191 
            let v193 : string = "$0"
            let v194 : (unit -> (struct (string * US25 * string * bool * bool) [])) = closure50(v192)
            let v195 : (unit -> (struct (string * US25 * string * bool * bool) [])) = Fable.Core.RustInterop.emitRustExpr v194 v193 
            let v196 : string = "leptos::create_memo(move |_| { v195(()) })"
            let v197 : leptos_Memo<(struct (string * US25 * string * bool * bool) [])> = Fable.Core.RustInterop.emitRustExpr () v196 
            let v198 : string = "$0"
            let v199 : (unit -> Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>) = closure52(v184, v192)
            let v200 : (unit -> Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>) = Fable.Core.RustInterop.emitRustExpr v199 v198 
            let v201 : string = "leptos::create_memo(move |_| { v200(()) })"
            let v202 : leptos_Memo<Vec<struct (string * Vec<struct (string * US25 * string * bool * bool)>)>> = Fable.Core.RustInterop.emitRustExpr () v201 
            let v203 : string = "$0"
            let v204 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = closure55(v202)
            let v205 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = Fable.Core.RustInterop.emitRustExpr v204 v203 
            let v206 : string = "leptos::create_memo(move |_| { v205(()) })"
            let v207 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>> = Fable.Core.RustInterop.emitRustExpr () v206 
            let v208 : string = "$0"
            let v209 : (unit -> (string [])) = closure57(v202)
            let v210 : (unit -> (string [])) = Fable.Core.RustInterop.emitRustExpr v209 v208 
            let v211 : string = "leptos::create_memo(move |_| { v210(()) })"
            let v212 : leptos_Memo<(string [])> = Fable.Core.RustInterop.emitRustExpr () v211 
            let v213 : (crate_model_near_nearblocks_Root -> (struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) [])) = closure60()
            let v214 : leptos_Memo<Vec<Result<(struct (std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * std_string_String * uint32 * (struct (std_string_String * std_string_String option) []) * float * bool * float * (std_string_String [])) []) option, std_string_String>>> = method62(v207, v213)
            let v217 : string = $"%A{v214}"
            let v224 : string = "use_transactions.render (7) / root func0 / result: " + string v217 + ""
            let v225 : int64 = 200L
            let v226 : string = method8(v225, v224)
            let v227 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v228 : bool = Fable.Core.RustInterop.emitRustExpr v226 v227 
            let v229 : string = "$0"
            let v230 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = closure90(v212, v214)
            let v231 : (unit -> Result<(struct (string * unativeint * Heap5) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v230 v229 
            let v232 : string = "leptos::create_memo(move |_| { v231(()) })"
            let v233 : leptos_Memo<Result<(struct (string * unativeint * Heap5) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v232 
            let v234 : string = "$0"
            let v235 : (unit -> Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>) = closure105(v233)
            let v236 : (unit -> Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>) = Fable.Core.RustInterop.emitRustExpr v235 v234 
            let v237 : string = "leptos::create_memo(move |_| { v236(()) })"
            let v238 : leptos_Memo<Result<(struct (string * US25 * string * bool * bool) []) option, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v237 
            let v239 : string = "$0"
            let v240 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = closure111(v238)
            let v241 : (unit -> Vec<struct (string * US25 * string * bool * bool)>) = Fable.Core.RustInterop.emitRustExpr v240 v239 
            let v242 : string = "leptos::create_memo(move |_| { v241(()) })"
            let v243 : leptos_Memo<Vec<struct (string * US25 * string * bool * bool)>> = Fable.Core.RustInterop.emitRustExpr () v242 
            let v244 : (crate_model_near_rpc_RpcResponse -> struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option)) = closure114()
            let v245 : leptos_Memo<Vec<Result<struct (std_string_String * struct ((struct (std_string_String * (std_collections_HashMap<std_string_String, struct (std_string_String * std_string_String option * float option * std_string_String option)> []) * std_string_String * (std_string_String []) * (std_string_String []) * std_string_String * std_string_String * std_string_String * std_string_String) []) * (struct (std_string_String * std_string_String * std_string_String * uint64 * (std_string_String []) * (struct (std_string_String * std_string_String * std_string_String) []) * uint8 * (std_string_String []) * std_collections_HashMap<std_string_String, std_string_String> * std_string_String option * (struct (std_string_String * std_string_String) [])) [])) option * struct (std_string_String * std_string_String * struct (std_string_String option * std_string_String option) option * int32 * std_string_String * std_string_String) option * std_string_String option) option, std_string_String>>> = method112(v243, v244)
            let v248 : string = $"%A{v245}"
            let v255 : string = "use_transactions.render (12) / rpc_response func0 / result: " + string v248 + ""
            let v256 : int64 = 200L
            let v257 : string = method8(v256, v255)
            let v258 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = $"leptos::create_signal($0)"
            let struct (v261 : leptos_ReadSignal<bool>, v262 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr false v260 
            let v263 : (unit -> unit) = closure347(v262)
            let v264 : string = "let v263 = $0"
            Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v265 : string = "$0"
            let v266 : (unit -> string) = closure348()
            let v267 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v266 v265 
            let v268 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v269 : string = "fill=\"none\""
            let v270 : string = "viewBox=\"0 0 24 24\""
            let v271 : string = "stroke-width=\"1.5\""
            let v272 : string = "stroke=\"currentColor\""
            let v273 : string = "class=move || \" \".to_owned() + &v267(())"
            let v274 : (unit -> leptos_Fragment) = method270()
            let v275 : string = ""
            let v276 : string = " " + v268 + v275 + ""
            let v277 : string = " " + v269 + v276 + ""
            let v278 : string = " " + v270 + v277 + ""
            let v279 : string = " " + v271 + v278 + ""
            let v280 : string = " " + v272 + v279 + ""
            let v281 : string = " " + v273 + v280 + ""
            let v282 : (unit -> leptos_Fragment) = method132(v274)
            let v283 : (unit -> leptos_Fragment) = method133(v282)
            let v284 : string = "svg"
            let v285 : string = "<" + v284 + " " + v281 + ">{v283()}</" + v284 + ">"
            let v286 : string = "leptos::view! { " + v285 + " }"
            let v287 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v286 
            let v288 : leptos_HtmlElement<leptos_svg_Svg> = v287 |> unbox
            let v289 : string = "on:click=move |_| v263()"
            let v290 : string = "aria-label=\"Settings\""
            let v291 : string = "$0"
            let v292 : (unit -> std_string_String) = closure350(v261)
            let v293 : (unit -> std_string_String) = Fable.Core.RustInterop.emitRustExpr v292 v291 
            let v294 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] pb-[8px] pt-[8px] px-[12px] \".to_owned() + &v293(())"
            let v295 : (unit -> leptos_Fragment) = method209(v288)
            let v296 : string = " " + v294 + v275 + ""
            let v297 : string = " " + v289 + v296 + ""
            let v298 : string = " " + v290 + v297 + ""
            let v299 : (unit -> leptos_Fragment) = method132(v295)
            let v300 : (unit -> leptos_Fragment) = method133(v299)
            let v301 : string = "button"
            let v302 : string = "<" + v301 + " " + v298 + ">{v300()}</" + v301 + ">"
            let v303 : string = "leptos::view! { " + v302 + " }"
            let v304 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v303 
            let v305 : leptos_HtmlElement<leptos_html_Button> = v304 |> unbox
            let v306 : string = "leptos::IntoView::into_view($0)"
            let v307 : leptos_View = Fable.Core.RustInterop.emitRustExpr v305 v306 
            let v308 : (leptos_View []) = [||]
            let v309 : (leptos_View []) = method122(v308)
            let v310 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v311 : leptos_View = Fable.Core.RustInterop.emitRustExpr v309 v310 
            let v312 : (unit -> leptos_Fragment) = method272(v184, v233, v202, v261)
            let v313 : (unit -> leptos_Fragment) = method142(v312)
            let v314 : string = "class=\"flex flex-col [position:relative]\""
            let v315 : (unit -> leptos_Fragment) = method365(v307, v313)
            let v316 : string = " " + v314 + v275 + ""
            let v317 : (unit -> leptos_Fragment) = method132(v315)
            let v318 : (unit -> leptos_Fragment) = method133(v317)
            let v319 : string = "div"
            let v320 : string = "<" + v319 + " " + v316 + ">{v318()}</" + v319 + ">"
            let v321 : string = "leptos::view! { " + v320 + " }"
            let v322 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v321 
            let v323 : leptos_HtmlElement<leptos_html_Div> = v322 |> unbox
            let v324 : string = "leptos::IntoView::into_view($0)"
            let v325 : leptos_View = Fable.Core.RustInterop.emitRustExpr v323 v324 
            let v326 : leptos_RwSignal<Heap1> = v184.l0
            let v327 : string = $"leptos::SignalGetUntracked::get_untracked(&$0)"
            let v328 : Heap1 = Fable.Core.RustInterop.emitRustExpr v326 v327 
            let v329 : leptos_RwSignal<bool> = v328.l1
            let v330 : string = $"leptos::SignalGet::get(&$0)"
            let v331 : bool = Fable.Core.RustInterop.emitRustExpr v329 v330 
            let v353 : leptos_View =
                if v331 then
                    let v332 : (leptos_View []) = [||]
                    let v333 : (leptos_View []) = method122(v332)
                    let v334 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v335 : leptos_View = Fable.Core.RustInterop.emitRustExpr v333 v334 
                    let v336 : (unit -> leptos_Fragment) = method370(v233)
                    let v337 : (unit -> leptos_Fragment) = method142(v336)
                    let v338 : string = "class=\"flex flex-col [position:relative]\""
                    let v339 : (unit -> leptos_Fragment) = method373(v335, v337)
                    let v340 : string = " " + v338 + v275 + ""
                    let v341 : (unit -> leptos_Fragment) = method132(v339)
                    let v342 : (unit -> leptos_Fragment) = method133(v341)
                    let v343 : string = "<" + v319 + " " + v340 + ">{v342()}</" + v319 + ">"
                    let v344 : string = "leptos::view! { " + v343 + " }"
                    let v345 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v344 
                    let v346 : leptos_HtmlElement<leptos_html_Div> = v345 |> unbox
                    let v347 : string = "leptos::IntoView::into_view($0)"
                    let v348 : leptos_View = Fable.Core.RustInterop.emitRustExpr v346 v347 
                    v348
                else
                    let v349 : (leptos_View []) = [||]
                    let v350 : (leptos_View []) = method122(v349)
                    let v351 : string = "leptos::CollectView::collect_view($0.to_vec())"
                    let v352 : leptos_View = Fable.Core.RustInterop.emitRustExpr v350 v351 
                    v352
            let v354 : (leptos_View []) = [|v325; v353|]
            let v355 : string = "$0.to_vec()"
            let v356 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v354 v355 
            let v357 : string = "leptos::Fragment::new($0)"
            let v358 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v356 v357 
            US24_0(v358)
        | _ ->
            US24_1
    let v523 : leptos_View =
        match v503 with
        | US24_1 -> (* None *)
            let v518 : (leptos_View []) = [||]
            let v519 : (leptos_View []) = method122(v518)
            let v520 : string = "leptos::CollectView::collect_view($0.to_vec())"
            let v521 : leptos_View = Fable.Core.RustInterop.emitRustExpr v519 v520 
            v521
        | US24_0(v504) -> (* Some *)
            let v505 : string = "class=\"flex flex-1 flex-col [overflow-y:auto]\""
            let v506 : (unit -> leptos_Fragment) = method378(v504)
            let v507 : string = ""
            let v508 : string = " " + v505 + v507 + ""
            let v509 : (unit -> leptos_Fragment) = method132(v506)
            let v510 : (unit -> leptos_Fragment) = method133(v509)
            let v511 : string = "div"
            let v512 : string = "<" + v511 + " " + v508 + ">{v510()}</" + v511 + ">"
            let v513 : string = "leptos::view! { " + v512 + " }"
            let v514 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v513 
            let v515 : leptos_HtmlElement<leptos_html_Div> = v514 |> unbox
            let v516 : string = "leptos::IntoView::into_view($0)"
            let v517 : leptos_View = Fable.Core.RustInterop.emitRustExpr v515 v516 
            v517
    let v524 : (leptos_View []) = [|v523|]
    let v525 : string = "$0.to_vec()"
    let v526 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v524 v525 
    let v527 : string = "leptos::Fragment::new($0)"
    let v528 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v526 v527 
    v528
and method50 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure44(v0)
and closure507 () () : leptos_Fragment =
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
and method381 () : (unit -> leptos_Fragment) =
    closure507()
and closure510 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : bool =
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
and method383 (v0 : leptos_ReadSignal<US20>, v1 : US20) : (unit -> bool) =
    closure510(v0, v1)
and closure511 (v0 : string) () : leptos_Fragment =
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
and method384 (v0 : string) : (unit -> leptos_Fragment) =
    closure511(v0)
and closure509 (v0 : leptos_ReadSignal<US20>) (v1 : US20) : leptos_View =
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
    let v13 : (unit -> bool) = method383(v0, v1)
    let v14 : string = "select=v13()"
    let v15 : (unit -> leptos_Fragment) = method384(v12)
    let v16 : string = ""
    let v17 : string = " " + v14 + v16 + ""
    let v18 : (unit -> leptos_Fragment) = method132(v15)
    let v19 : (unit -> leptos_Fragment) = method133(v18)
    let v20 : string = "option"
    let v21 : string = "<" + v20 + " " + v17 + ">{v19()}</" + v20 + ">"
    let v22 : string = "leptos::view! { " + v21 + " }"
    let v23 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : leptos_HtmlElement<leptos_html_Option> = v23 |> unbox
    let v25 : string = "leptos::IntoView::into_view($0)"
    let v26 : leptos_View = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and closure508 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : US21 = US21_0
    let v2 : US20 = US20_1(v1)
    let v3 : US20 = US20_2
    let v4 : US20 = US20_3
    let v5 : US20 = US20_4
    let v6 : (US20 []) = [|v2; v3; v4; v5|]
    let v7 : string = "$0.to_vec()"
    let v8 : Vec<US20> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v10 : (US20 -> leptos_View) = closure509(v0)
    let v11 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v8, v10) v9 
    let v12 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v13 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0.to_vec()"
    let v15 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "leptos::Fragment::new($0)"
    let v17 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v15 v16 
    v17
and method382 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure508(v0)
and closure506 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "for=\"Tab\""
    let v2 : string = "class=\"sr-only\""
    let v3 : (unit -> leptos_Fragment) = method381()
    let v4 : string = ""
    let v5 : string = " " + v1 + v4 + ""
    let v6 : string = " " + v2 + v5 + ""
    let v7 : (unit -> leptos_Fragment) = method132(v3)
    let v8 : (unit -> leptos_Fragment) = method133(v7)
    let v9 : string = "label"
    let v10 : string = "<" + v9 + " " + v6 + ">{v8()}</" + v9 + ">"
    let v11 : string = "leptos::view! { " + v10 + " }"
    let v12 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : leptos_HtmlElement<leptos_html_Label> = v12 |> unbox
    let v14 : string = "leptos::IntoView::into_view($0)"
    let v15 : leptos_View = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "id=\"Tab\""
    let v17 : string = "class=\"w-full rounded-md border-gray-200\""
    let v18 : (unit -> leptos_Fragment) = method382(v0)
    let v19 : string = " " + v16 + v4 + ""
    let v20 : string = " " + v17 + v19 + ""
    let v21 : (unit -> leptos_Fragment) = method132(v18)
    let v22 : (unit -> leptos_Fragment) = method133(v21)
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
and method380 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure506(v0)
and closure516 () () : string =
    let v0 : string = "h-5 w-5"
    v0
and closure518 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method389 () : (unit -> leptos_Fragment) =
    closure518()
and closure517 () () : leptos_Fragment =
    let v0 : string = "x=\"3\""
    let v1 : string = "y=\"3\""
    let v2 : string = "width=\"18\""
    let v3 : string = "height=\"18\""
    let v4 : string = "rx=\"2\""
    let v5 : string = "stroke-linecap=\"round\""
    let v6 : string = "stroke-linejoin=\"round\""
    let v7 : (unit -> leptos_Fragment) = method389()
    let v8 : string = ""
    let v9 : string = " " + v0 + v8 + ""
    let v10 : string = " " + v1 + v9 + ""
    let v11 : string = " " + v2 + v10 + ""
    let v12 : string = " " + v3 + v11 + ""
    let v13 : string = " " + v4 + v12 + ""
    let v14 : string = " " + v5 + v13 + ""
    let v15 : string = " " + v6 + v14 + ""
    let v16 : (unit -> leptos_Fragment) = method132(v7)
    let v17 : (unit -> leptos_Fragment) = method133(v16)
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
    let v29 : (unit -> leptos_Fragment) = method141()
    let v30 : string = " " + v25 + v8 + ""
    let v31 : string = " " + v26 + v30 + ""
    let v32 : string = " " + v27 + v31 + ""
    let v33 : string = " " + v28 + v32 + ""
    let v34 : (unit -> leptos_Fragment) = method132(v29)
    let v35 : (unit -> leptos_Fragment) = method133(v34)
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
    let v47 : (unit -> leptos_Fragment) = method141()
    let v48 : string = " " + v43 + v8 + ""
    let v49 : string = " " + v44 + v48 + ""
    let v50 : string = " " + v45 + v49 + ""
    let v51 : string = " " + v46 + v50 + ""
    let v52 : (unit -> leptos_Fragment) = method132(v47)
    let v53 : (unit -> leptos_Fragment) = method133(v52)
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
    let v64 : (unit -> leptos_Fragment) = method141()
    let v65 : string = " " + v60 + v8 + ""
    let v66 : string = " " + v61 + v65 + ""
    let v67 : string = " " + v62 + v66 + ""
    let v68 : string = " " + v63 + v67 + ""
    let v69 : (unit -> leptos_Fragment) = method132(v64)
    let v70 : (unit -> leptos_Fragment) = method133(v69)
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
    let v81 : (unit -> leptos_Fragment) = method141()
    let v82 : string = " " + v77 + v8 + ""
    let v83 : string = " " + v78 + v82 + ""
    let v84 : string = " " + v79 + v83 + ""
    let v85 : string = " " + v80 + v84 + ""
    let v86 : (unit -> leptos_Fragment) = method132(v81)
    let v87 : (unit -> leptos_Fragment) = method133(v86)
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
    let v98 : (unit -> leptos_Fragment) = method141()
    let v99 : string = " " + v94 + v8 + ""
    let v100 : string = " " + v95 + v99 + ""
    let v101 : string = " " + v96 + v100 + ""
    let v102 : string = " " + v97 + v101 + ""
    let v103 : (unit -> leptos_Fragment) = method132(v98)
    let v104 : (unit -> leptos_Fragment) = method133(v103)
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
and method388 () : (unit -> leptos_Fragment) =
    closure517()
and closure519 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M4.75 6.75h14.5M4.75 12h14.5M4.75 17.25h14.5\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
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
    let v21 : (unit -> leptos_Fragment) = method141()
    let v22 : string = " " + v17 + v4 + ""
    let v23 : string = " " + v18 + v22 + ""
    let v24 : string = " " + v19 + v23 + ""
    let v25 : string = " " + v20 + v24 + ""
    let v26 : (unit -> leptos_Fragment) = method132(v21)
    let v27 : (unit -> leptos_Fragment) = method133(v26)
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
    let v39 : (unit -> leptos_Fragment) = method141()
    let v40 : string = " " + v35 + v4 + ""
    let v41 : string = " " + v36 + v40 + ""
    let v42 : string = " " + v37 + v41 + ""
    let v43 : string = " " + v38 + v42 + ""
    let v44 : (unit -> leptos_Fragment) = method132(v39)
    let v45 : (unit -> leptos_Fragment) = method133(v44)
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
    let v56 : (unit -> leptos_Fragment) = method141()
    let v57 : string = " " + v52 + v4 + ""
    let v58 : string = " " + v53 + v57 + ""
    let v59 : string = " " + v54 + v58 + ""
    let v60 : string = " " + v55 + v59 + ""
    let v61 : (unit -> leptos_Fragment) = method132(v56)
    let v62 : (unit -> leptos_Fragment) = method133(v61)
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
and method390 () : (unit -> leptos_Fragment) =
    closure519()
and closure520 () () : leptos_Fragment =
    let v0 : string = "stroke-linecap=\"round\""
    let v1 : string = "stroke-linejoin=\"round\""
    let v2 : string = "d=\"M4 12h16m-7-7l7 7-7 7m-2-14l-7 7 7 7\""
    let v3 : (unit -> leptos_Fragment) = method131()
    let v4 : string = ""
    let v5 : string = " " + v0 + v4 + ""
    let v6 : string = " " + v1 + v5 + ""
    let v7 : string = " " + v2 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v3)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
    let v10 : string = "path"
    let v11 : string = "<" + v10 + " " + v7 + ">{v9()}</" + v10 + ">"
    let v12 : string = "leptos::view! { " + v11 + " }"
    let v13 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : leptos_HtmlElement<leptos_svg_Path> = v13 |> unbox
    let v15 : (leptos_HtmlElement<leptos_svg_Path> []) = [|v14|]
    let v16 : string = "$0.to_vec()"
    let v17 : Vec<leptos_HtmlElement<leptos_svg_Path>> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v19 : (leptos_HtmlElement<leptos_svg_Path> -> leptos_View) = closure161()
    let v20 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v18 
    let v21 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v22 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "$0.to_vec()"
    let v24 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "leptos::Fragment::new($0)"
    let v26 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26
and method391 () : (unit -> leptos_Fragment) =
    closure520()
and closure521 (v0 : leptos_Memo<string>, v1 : string) () : std_string_String =
    let v2 : string = $"$0()"
    let v3 : string = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = v3 + "#/" + v1 + ""
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7 
    v8
and closure522 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : bool =
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
and closure523 (v0 : leptos_ReadSignal<US20>, v1 : US20) () : Ref<Lifetime<StaticLifetime, Str>> =
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
        let v10 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v9 
        v10
    else
        let v11 : string = "border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700"
        let v12 : string = "r#\"" + v11 + "\"#"
        let v13 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v12 
        v13
and closure524 (v0 : leptos_Fragment, v1 : string) () : leptos_Fragment =
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
and method392 (v0 : leptos_Fragment, v1 : string) : (unit -> leptos_Fragment) =
    closure524(v0, v1)
and closure515 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) (v2 : US20) : leptos_View =
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
            let v16 : (unit -> string) = closure516()
            let v17 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v16 v15 
            let v18 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v19 : string = "fill=\"none\""
            let v20 : string = "viewBox=\"0 0 24 24\""
            let v21 : string = "stroke-width=\"1.5\""
            let v22 : string = "stroke=\"currentColor\""
            let v23 : string = "class=move || \" \".to_owned() + &v17(())"
            let v24 : (unit -> leptos_Fragment) = method388()
            let v25 : string = ""
            let v26 : string = " " + v18 + v25 + ""
            let v27 : string = " " + v19 + v26 + ""
            let v28 : string = " " + v20 + v27 + ""
            let v29 : string = " " + v21 + v28 + ""
            let v30 : string = " " + v22 + v29 + ""
            let v31 : string = " " + v23 + v30 + ""
            let v32 : (unit -> leptos_Fragment) = method132(v24)
            let v33 : (unit -> leptos_Fragment) = method133(v32)
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
            let v47 : (unit -> string) = closure516()
            let v48 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v47 v46 
            let v49 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v50 : string = "fill=\"none\""
            let v51 : string = "height=\"100%\""
            let v52 : string = "viewBox=\"0 0 24 24\""
            let v53 : string = "stroke-width=\"1.5\""
            let v54 : string = "stroke=\"currentColor\""
            let v55 : string = "class=move || \"text-gray-700 \".to_owned() + &v48(())"
            let v56 : (unit -> leptos_Fragment) = method390()
            let v57 : string = ""
            let v58 : string = " " + v49 + v57 + ""
            let v59 : string = " " + v50 + v58 + ""
            let v60 : string = " " + v51 + v59 + ""
            let v61 : string = " " + v52 + v60 + ""
            let v62 : string = " " + v53 + v61 + ""
            let v63 : string = " " + v54 + v62 + ""
            let v64 : string = " " + v55 + v63 + ""
            let v65 : (unit -> leptos_Fragment) = method132(v56)
            let v66 : (unit -> leptos_Fragment) = method133(v65)
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
            let v113 : (unit -> string) = closure516()
            let v114 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v113 v112 
            let v115 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v116 : string = "fill=\"none\""
            let v117 : string = "viewBox=\"0 0 24 24\""
            let v118 : string = "stroke-width=\"1.5\""
            let v119 : string = "stroke=\"currentColor\""
            let v120 : string = "class=move || \" \".to_owned() + &v114(())"
            let v121 : (unit -> leptos_Fragment) = method270()
            let v122 : string = ""
            let v123 : string = " " + v115 + v122 + ""
            let v124 : string = " " + v116 + v123 + ""
            let v125 : string = " " + v117 + v124 + ""
            let v126 : string = " " + v118 + v125 + ""
            let v127 : string = " " + v119 + v126 + ""
            let v128 : string = " " + v120 + v127 + ""
            let v129 : (unit -> leptos_Fragment) = method132(v121)
            let v130 : (unit -> leptos_Fragment) = method133(v129)
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
            let v80 : (unit -> string) = closure516()
            let v81 : (unit -> string) = Fable.Core.RustInterop.emitRustExpr v80 v79 
            let v82 : string = "xmlns=\"http://www.w3.org/2000/svg\""
            let v83 : string = "fill=\"none\""
            let v84 : string = "height=\"100%\""
            let v85 : string = "viewBox=\"0 0 24 24\""
            let v86 : string = "stroke-width=\"1.5\""
            let v87 : string = "stroke=\"currentColor\""
            let v88 : string = "class=move || \"text-gray-700 \".to_owned() + &v81(())"
            let v89 : (unit -> leptos_Fragment) = method391()
            let v90 : string = ""
            let v91 : string = " " + v82 + v90 + ""
            let v92 : string = " " + v83 + v91 + ""
            let v93 : string = " " + v84 + v92 + ""
            let v94 : string = " " + v85 + v93 + ""
            let v95 : string = " " + v86 + v94 + ""
            let v96 : string = " " + v87 + v95 + ""
            let v97 : string = " " + v88 + v96 + ""
            let v98 : (unit -> leptos_Fragment) = method132(v89)
            let v99 : (unit -> leptos_Fragment) = method133(v98)
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
    let v163 : (unit -> std_string_String) = closure521(v1, v13)
    let v164 : string = "let v163 = $0"
    Fable.Core.RustInterop.emitRustExpr v163 v164 
    let v165 : string = "$0"
    let v166 : (unit -> bool) = closure522(v0, v2)
    let v167 : (unit -> bool) = Fable.Core.RustInterop.emitRustExpr v166 v165 
    let v168 : string = "$0"
    let v169 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = closure523(v0, v2)
    let v170 : (unit -> Ref<Lifetime<StaticLifetime, Str>>) = Fable.Core.RustInterop.emitRustExpr v169 v168 
    let v171 : string = "href=move || v163()"
    let v172 : string = "class=move || \"inline-flex shrink-0 items-center [justify-content:center] flex-1 gap-2 border-t-2 [white-space:nowrap] mb-[11px] pt-[8px] pr-[15px] pl-[15px] text-sm font-medium \".to_owned() + v170(())"
    let v173 : string = "aria-current=move || if v167(()) { \"page\" } else { \"\" }"
    let v174 : (unit -> leptos_Fragment) = method392(v151, v162)
    let v175 : string = ""
    let v176 : string = " " + v171 + v175 + ""
    let v177 : string = " " + v172 + v176 + ""
    let v178 : string = " " + v173 + v177 + ""
    let v179 : (unit -> leptos_Fragment) = method132(v174)
    let v180 : (unit -> leptos_Fragment) = method133(v179)
    let v181 : string = "a"
    let v182 : string = "<" + v181 + " " + v178 + ">{v180()}</" + v181 + ">"
    let v183 : string = "leptos::view! { " + v182 + " }"
    let v184 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v183 
    let v185 : leptos_HtmlElement<leptos_html_A> = v184 |> unbox
    let v186 : string = "leptos::IntoView::into_view($0)"
    let v187 : leptos_View = Fable.Core.RustInterop.emitRustExpr v185 v186 
    v187
and closure514 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : US21 = US21_0
    let v3 : US20 = US20_1(v2)
    let v4 : US20 = US20_2
    let v5 : US20 = US20_3
    let v6 : US20 = US20_4
    let v7 : (US20 []) = [|v3; v4; v5; v6|]
    let v8 : string = "$0.to_vec()"
    let v9 : Vec<US20> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v11 : (US20 -> leptos_View) = closure515(v0, v1)
    let v12 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v9, v11) v10 
    let v13 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v14 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "leptos::Fragment::new($0)"
    let v18 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v16 v17 
    v18
and method387 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure514(v0, v1)
and closure513 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : string = "class=\"-mb-px flex [flex-flow:wrap] [flex-grow:1] [flex-shrink:0] gap-[3px] [overflow-wrap:anywhere]\""
    let v3 : string = "aria-label=\"Tabs\""
    let v4 : (unit -> leptos_Fragment) = method387(v0, v1)
    let v5 : string = ""
    let v6 : string = " " + v2 + v5 + ""
    let v7 : string = " " + v3 + v6 + ""
    let v8 : (unit -> leptos_Fragment) = method132(v4)
    let v9 : (unit -> leptos_Fragment) = method133(v8)
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
and method386 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure513(v0, v1)
and closure512 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) () : leptos_Fragment =
    let v2 : string = "class=\"flex flex-1 border-t border-gray-200\""
    let v3 : (unit -> leptos_Fragment) = method386(v0, v1)
    let v4 : string = ""
    let v5 : string = " " + v2 + v4 + ""
    let v6 : (unit -> leptos_Fragment) = method132(v3)
    let v7 : (unit -> leptos_Fragment) = method133(v6)
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
and method385 (v0 : leptos_ReadSignal<US20>, v1 : leptos_Memo<string>) : (unit -> leptos_Fragment) =
    closure512(v0, v1)
and closure505 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
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
    let v12 : (unit -> leptos_Fragment) = method380(v0)
    let v13 : string = ""
    let v14 : string = " " + v11 + v13 + ""
    let v15 : (unit -> leptos_Fragment) = method132(v12)
    let v16 : (unit -> leptos_Fragment) = method133(v15)
    let v17 : string = "div"
    let v18 : string = "<" + v17 + " " + v14 + ">{v16()}</" + v17 + ">"
    let v19 : string = "leptos::view! { " + v18 + " }"
    let v20 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : leptos_HtmlElement<leptos_html_Div> = v20 |> unbox
    let v22 : string = "class=\"flex flex-1 [overflow-x:auto] [overflow-y:hidden]\""
    let v23 : (unit -> leptos_Fragment) = method385(v0, v10)
    let v24 : string = " " + v22 + v13 + ""
    let v25 : (unit -> leptos_Fragment) = method132(v23)
    let v26 : (unit -> leptos_Fragment) = method133(v25)
    let v27 : string = "<" + v17 + " " + v24 + ">{v26()}</" + v17 + ">"
    let v28 : string = "leptos::view! { " + v27 + " }"
    let v29 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : leptos_HtmlElement<leptos_html_Div> = v29 |> unbox
    let v31 : (leptos_HtmlElement<leptos_html_Div> []) = [|v21; v30|]
    let v32 : string = "$0.to_vec()"
    let v33 : Vec<leptos_HtmlElement<leptos_html_Div>> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v35 : (leptos_HtmlElement<leptos_html_Div> -> leptos_View) = closure204()
    let v36 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v34 
    let v37 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v38 : (leptos_View []) = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : string = "$0.to_vec()"
    let v40 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v38 v39 
    let v41 : string = "leptos::Fragment::new($0)"
    let v42 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v40 v41 
    v42
and method379 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure505(v0)
and closure43 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col [overflow:hidden]\""
    let v2 : (unit -> leptos_Fragment) = method50(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
    let v7 : string = "main"
    let v8 : string = "<" + v7 + " " + v4 + ">{v6()}</" + v7 + ">"
    let v9 : string = "leptos::view! { " + v8 + " }"
    let v10 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : leptos_HtmlElement<leptos_html_Main> = v10 |> unbox
    let v12 : string = "leptos::IntoView::into_view($0)"
    let v13 : leptos_View = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "class=\"flex\""
    let v15 : (unit -> leptos_Fragment) = method379(v0)
    let v16 : string = " " + v14 + v3 + ""
    let v17 : (unit -> leptos_Fragment) = method132(v15)
    let v18 : (unit -> leptos_Fragment) = method133(v17)
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
and method49 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
    closure43(v0)
and closure42 (v0 : leptos_ReadSignal<US20>) () : leptos_Fragment =
    let v1 : string = "class=\"flex flex-1 flex-col [width:100vw] [max-width:100vw] max-[100px]:[min-width:800px] [height:100vh] [max-height:100dvh] [max-height:-webkit-fill-available] max-[60px]:[min-height:600px] bg-gray-50 text-gray-700 text-sm\""
    let v2 : (unit -> leptos_Fragment) = method49(v0)
    let v3 : string = ""
    let v4 : string = " " + v1 + v3 + ""
    let v5 : (unit -> leptos_Fragment) = method132(v2)
    let v6 : (unit -> leptos_Fragment) = method133(v5)
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
and method48 (v0 : leptos_ReadSignal<US20>) : (unit -> leptos_Fragment) =
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
    let v36 : (unit -> leptos_Fragment) = method48(v20)
    let v37 : string = ""
    let v38 : string = " " + v35 + v37 + ""
    let v39 : (unit -> leptos_Fragment) = method132(v36)
    let v40 : (unit -> leptos_Fragment) = method133(v39)
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
and method44 () : (unit -> leptos_Fragment) =
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
    let v15 : leptos_Resource<rexie_Rexie option, US4> = method11(v11)
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
    let v38 : (unit -> bool) = method43(v7)
    let v39 : string = "class:dark"
    let v40 : string = "" + v39 + "={move || v38()}"
    let v41 : (unit -> leptos_Fragment) = method44()
    let v42 : string = ""
    let v43 : string = " " + v37 + v42 + ""
    let v44 : string = " " + v40 + v43 + ""
    let v45 : (unit -> leptos_Fragment) = method132(v41)
    let v46 : (unit -> leptos_Fragment) = method133(v45)
    let v47 : string = "div"
    let v48 : string = "<" + v47 + " " + v44 + ">{v46()}</" + v47 + ">"
    let v49 : string = "leptos::view! { " + v48 + " }"
    let v50 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : leptos_HtmlElement<leptos_html_Div> = v50 |> unbox
    v51
and method4 () : (int32 -> leptos_HtmlElement<leptos_html_Div>) =
    closure4()
and method393 () : string =
    let v0 : string = ""
    v0
and closure525 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 1
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7 
    v8
and method394 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure525(v0)
and closure526 () () : leptos_Fragment =
    let v0 : (leptos_View []) = [||]
    let v1 : string = "$0.to_vec()"
    let v2 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "leptos::Fragment::new($0)"
    let v4 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v2 v3 
    v4
and method395 () : (unit -> leptos_Fragment) =
    closure526()
and method396 () : string =
    let v0 : string = "/"
    v0
and closure527 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 2
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7 
    v8
and method397 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure527(v0)
and method398 () : string =
    let v0 : string = "/*"
    v0
and closure528 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 3
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7 
    v8
and method399 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure528(v0)
and method400 () : string =
    let v0 : string = "*"
    v0
and closure529 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) () : leptos_Fragment =
    let v1 : leptos_HtmlElement<leptos_html_Div> = v0 4
    let v2 : string = "leptos::IntoView::into_view($0)"
    let v3 : leptos_View = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : (leptos_View []) = [|v3|]
    let v5 : string = "$0.to_vec()"
    let v6 : Vec<leptos_View> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "leptos::Fragment::new($0)"
    let v8 : leptos_Fragment = Fable.Core.RustInterop.emitRustExpr v6 v7 
    v8
and method401 (v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>)) : (unit -> leptos_Fragment) =
    closure529(v0)
and closure3 () () : leptos_Fragment =
    let v0 : (int32 -> leptos_HtmlElement<leptos_html_Div>) = method4()
    let v1 : string = method393()
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : (unit -> leptos_Fragment) = method394(v0)
    let v7 : (unit -> leptos_Fragment) = method395()
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
    let v19 : string = method396()
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20 
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : (unit -> leptos_Fragment) = method397(v0)
    let v25 : (unit -> leptos_Fragment) = method395()
    let v26 : string = "path=v23"
    let v27 : string = "view=move || v24()"
    let v28 : string = "children=Box::new(move || v25())"
    let v29 : string = " " + v26 + v11 + ""
    let v30 : string = " " + v27 + v29 + ""
    let v31 : string = " " + v28 + v30 + ""
    let v32 : string = "<" + v15 + " " + v31 + " />"
    let v33 : string = "leptos::IntoView::into_view(leptos::view! { " + v32 + " })"
    let v34 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = method398()
    let v36 : string = "&*$0"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : (unit -> leptos_Fragment) = method399(v0)
    let v41 : (unit -> leptos_Fragment) = method395()
    let v42 : string = "path=v39"
    let v43 : string = "view=move || v40()"
    let v44 : string = "children=Box::new(move || v41())"
    let v45 : string = " " + v42 + v11 + ""
    let v46 : string = " " + v43 + v45 + ""
    let v47 : string = " " + v44 + v46 + ""
    let v48 : string = "<" + v15 + " " + v47 + " />"
    let v49 : string = "leptos::IntoView::into_view(leptos::view! { " + v48 + " })"
    let v50 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = method400()
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let v54 : string = "String::from($0)"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54 
    let v56 : (unit -> leptos_Fragment) = method401(v0)
    let v57 : (unit -> leptos_Fragment) = method395()
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
    let v33 : Heap0 = {l0 = v30; l1 = v31; l2 = 1; l3 = 1; l4 = v32} : Heap0
    let v34 : string = $"leptos::create_rw_signal($0)"
    let v35 : leptos_RwSignal<Heap0> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : Heap1 = {l0 = v6; l1 = v8; l2 = v15; l3 = v35} : Heap1
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
and closure530 () () : unit =
    method2()
and method402 () : (unit -> unit) =
    closure530()
and method403 (v0 : Box<Dyn<FnUnit>>) : Box<Dyn<FnUnit>> =
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
    let v10 : US0 option = None
    let _v10 = ref v10 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v11 : web_sys_HtmlElement = x
    let v12 : US0 = US0_0(v11)
    v12 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v10.Value <- x
    let v13 : US0 option = _v10.Value 
    let v36 : US0 = US0_1
    let v37 : US0 = v13 |> Option.defaultValue v36 
    let v47 : string = $"%A{v37}"
    let v54 : string = "main / mount_to_body / body: " + string v47 + ""
    let v55 : string = @$"true; leptos::logging::log!(""{{}}"", $0)"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55 
    match v37 with
    | US0_0(v57) -> (* Some *)
        let v58 : string = method0()
        let v59 : string = "&*$0"
        let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v59 
        let v61 : web_sys_HtmlElement = method1(v57)
        let v62 : string = "v61.set_inner_html(v60)"
        Fable.Core.RustInterop.emitRustExpr () v62 
        method2()
    | _ ->
        let v63 : (unit -> unit) = method402()
        let v64 : string = "Box::new(move || v63())"
        let v65 : Box<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v64 
        let v66 : Box<Dyn<FnUnit>> = method403(v65)
        let v67 : string = "wasm_bindgen::closure::Closure::wrap(v66)"
        let v68 : wasm_bindgen_closure_Closure<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v67 
        let v69 : string = "wasm_bindgen::closure::Closure::as_ref(&v68)"
        let v70 : Ref<wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v69 
        let v71 : string = "wasm_bindgen::JsCast::unchecked_ref(v70)"
        let v72 : Ref<js_sys_Function> = Fable.Core.RustInterop.emitRustExpr () v71 
        let v73 : string = "leptos::document().add_event_listener_with_callback(\"DOMContentLoaded\", v72).unwrap()"
        Fable.Core.RustInterop.emitRustExpr () v73 
        let v74 : string = "v68.forget()"
        Fable.Core.RustInterop.emitRustExpr () v74 
        ()
    0
let v126 : ((string []) -> int32) = closure0()
let main args = v126 args
()
