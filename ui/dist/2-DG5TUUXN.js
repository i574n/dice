var D=Object.defineProperty;var U=(e,n)=>{for(var t in n)D(e,t,{get:n[t],enumerable:!0})};var B={};U(B,{IntoUnderlyingByteSource:()=>T,IntoUnderlyingSink:()=>L,IntoUnderlyingSource:()=>R,default:()=>N,initSync:()=>on,set_inner_messages:()=>nn,set_inner_messages_async:()=>Y,set_inner_messages_state:()=>en,set_outer_messages:()=>Z,set_outer_messages_async:()=>X,set_outer_messages_state:()=>tn});var b,y=new Array(128).fill(void 0);y.push(void 0,null,!0,!1);var E=y.length;function u(e){E===y.length&&y.push(y.length+1);let n=E;return E=y[n],y[n]=e,n}function _(e){return y[e]}function P(e){e<132||(y[e]=E,E=e)}function m(e){let n=_(e);return P(e),n}var C=typeof TextDecoder<"u"?new TextDecoder("utf-8",{ignoreBOM:!0,fatal:!0}):{decode:()=>{throw Error("TextDecoder not available")}};typeof TextDecoder<"u"&&C.decode();var v=null;function M(){return(v===null||v.byteLength===0)&&(v=new Uint8Array(b.memory.buffer)),v}function j(e,n){return e=e>>>0,C.decode(M().subarray(e,e+n))}function l(e){return e==null}var x=null;function $(){return(x===null||x.byteLength===0)&&(x=new Float64Array(b.memory.buffer)),x}var A=null;function f(){return(A===null||A.byteLength===0)&&(A=new Int32Array(b.memory.buffer)),A}var w=0,O=typeof TextEncoder<"u"?new TextEncoder("utf-8"):{encode:()=>{throw Error("TextEncoder not available")}},H=typeof O.encodeInto=="function"?function(e,n){return O.encodeInto(e,n)}:function(e,n){let t=O.encode(e);return n.set(t),{read:e.length,written:t.length}};function d(e,n,t){if(t===void 0){let a=O.encode(e),p=n(a.length,1)>>>0;return M().subarray(p,p+a.length).set(a),w=a.length,p}let r=e.length,o=n(r,1)>>>0,c=M(),s=0;for(;s<r;s++){let a=e.charCodeAt(s);if(a>127)break;c[o+s]=a}if(s!==r){s!==0&&(e=e.slice(s)),o=t(o,r,r=s+e.length*3,1)>>>0;let a=M().subarray(o+s,o+r),p=H(e,a);s+=p.written}return w=s,o}var S=null;function z(){return(S===null||S.byteLength===0)&&(S=new BigInt64Array(b.memory.buffer)),S}function k(e){let n=typeof e;if(n=="number"||n=="boolean"||e==null)return`${e}`;if(n=="string")return`"${e}"`;if(n=="symbol"){let o=e.description;return o==null?"Symbol":`Symbol(${o})`}if(n=="function"){let o=e.name;return typeof o=="string"&&o.length>0?`Function(${o})`:"Function"}if(Array.isArray(e)){let o=e.length,c="[";o>0&&(c+=k(e[0]));for(let s=1;s<o;s++)c+=", "+k(e[s]);return c+="]",c}let t=/\[object ([^\]]+)\]/.exec(toString.call(e)),r;if(t.length>1)r=t[1];else return toString.call(e);if(r=="Object")try{return"Object("+JSON.stringify(e)+")"}catch{return"Object"}return e instanceof Error?`${e.name}: ${e.message}
${e.stack}`:r}function h(e,n,t,r){let o={a:e,b:n,cnt:1,dtor:t},c=(...s)=>{o.cnt++;let a=o.a;o.a=0;try{return r(a,o.b,...s)}finally{--o.cnt===0?b.__wbindgen_export_2.get(o.dtor)(a,o.b):o.a=a}};return c.original=o,c}function V(e,n){b.__wbindgen_export_3(e,n)}function I(e,n,t){b.__wbindgen_export_4(e,n,u(t))}function J(e,n,t){try{let c=b.__wbindgen_add_to_stack_pointer(-16);b.__wbindgen_export_5(c,e,n,u(t));var r=f()[c/4+0],o=f()[c/4+1];if(o)throw m(r)}finally{b.__wbindgen_add_to_stack_pointer(16)}}function G(e,n,t,r){let o={a:e,b:n,cnt:1,dtor:t},c=(...s)=>{o.cnt++;try{return r(o.a,o.b,...s)}finally{--o.cnt===0&&(b.__wbindgen_export_2.get(o.dtor)(o.a,o.b),o.a=0)}};return c.original=o,c}function Q(e,n){b.__wbindgen_export_6(e,n)}function g(e,n){return e===0?_(n):j(e,n)}function i(e,n){try{return e.apply(this,n)}catch(t){b.__wbindgen_export_8(u(t))}}function X(e){let n=d(e,b.__wbindgen_export_0,b.__wbindgen_export_1),t=w,r=b.set_outer_messages_async(n,t);return m(r)}function Y(e){let n=d(e,b.__wbindgen_export_0,b.__wbindgen_export_1),t=w,r=b.set_inner_messages_async(n,t);return m(r)}function Z(e){try{let o=b.__wbindgen_add_to_stack_pointer(-16),c=d(e,b.__wbindgen_export_0,b.__wbindgen_export_1),s=w;b.set_outer_messages(o,c,s);var n=f()[o/4+0],t=f()[o/4+1],r=f()[o/4+2];if(r)throw m(t);return m(n)}finally{b.__wbindgen_add_to_stack_pointer(16)}}function nn(e){try{let o=b.__wbindgen_add_to_stack_pointer(-16),c=d(e,b.__wbindgen_export_0,b.__wbindgen_export_1),s=w;b.set_inner_messages(o,c,s);var n=f()[o/4+0],t=f()[o/4+1],r=f()[o/4+2];if(r)throw m(t);return m(n)}finally{b.__wbindgen_add_to_stack_pointer(16)}}function tn(e){let n=d(e,b.__wbindgen_export_0,b.__wbindgen_export_1),t=w,r=b.set_outer_messages_state(n,t);return m(r)}function en(e){let n=d(e,b.__wbindgen_export_0,b.__wbindgen_export_1),t=w,r=b.set_inner_messages_state(n,t);return m(r)}function rn(e,n,t,r){b.__wbindgen_export_9(e,n,u(t),u(r))}var T=class{__destroy_into_raw(){let n=this.__wbg_ptr;return this.__wbg_ptr=0,n}free(){let n=this.__destroy_into_raw();b.__wbg_intounderlyingbytesource_free(n)}get type(){try{let o=b.__wbindgen_add_to_stack_pointer(-16);b.intounderlyingbytesource_type(o,this.__wbg_ptr);var n=f()[o/4+0],t=f()[o/4+1],r=g(n,t);return n!==0&&b.__wbindgen_export_7(n,t,1),r}finally{b.__wbindgen_add_to_stack_pointer(16)}}get autoAllocateChunkSize(){return b.intounderlyingbytesource_autoAllocateChunkSize(this.__wbg_ptr)>>>0}start(n){b.intounderlyingbytesource_start(this.__wbg_ptr,u(n))}pull(n){let t=b.intounderlyingbytesource_pull(this.__wbg_ptr,u(n));return m(t)}cancel(){let n=this.__destroy_into_raw();b.intounderlyingbytesource_cancel(n)}},L=class{__destroy_into_raw(){let n=this.__wbg_ptr;return this.__wbg_ptr=0,n}free(){let n=this.__destroy_into_raw();b.__wbg_intounderlyingsink_free(n)}write(n){let t=b.intounderlyingsink_write(this.__wbg_ptr,u(n));return m(t)}close(){let n=this.__destroy_into_raw(),t=b.intounderlyingsink_close(n);return m(t)}abort(n){let t=this.__destroy_into_raw(),r=b.intounderlyingsink_abort(t,u(n));return m(r)}},R=class{__destroy_into_raw(){let n=this.__wbg_ptr;return this.__wbg_ptr=0,n}free(){let n=this.__destroy_into_raw();b.__wbg_intounderlyingsource_free(n)}pull(n){let t=b.intounderlyingsource_pull(this.__wbg_ptr,u(n));return m(t)}cancel(){let n=this.__destroy_into_raw();b.intounderlyingsource_cancel(n)}};async function _n(e,n){if(typeof Response=="function"&&e instanceof Response){if(typeof WebAssembly.instantiateStreaming=="function")try{return await WebAssembly.instantiateStreaming(e,n)}catch(r){if(e.headers.get("Content-Type")!="application/wasm")console.warn("`WebAssembly.instantiateStreaming` failed because your server does not serve wasm with `application/wasm` MIME type. Falling back to `WebAssembly.instantiate` which is slower. Original error:\n",r);else throw r}let t=await e.arrayBuffer();return await WebAssembly.instantiate(t,n)}else{let t=await WebAssembly.instantiate(e,n);return t instanceof WebAssembly.Instance?{instance:t,module:e}:t}}function F(){let e={};return e.wbg={},e.wbg.__wbindgen_number_new=function(n){return u(n)},e.wbg.__wbg_new_a9d80688888b4894=function(n){let t=new Date(_(n));return u(t)},e.wbg.__wbg_getTimezoneOffset_840b552f34917133=function(n){return _(n).getTimezoneOffset()},e.wbg.__wbg_new_abda76e883ba8a5f=function(){let n=new Error;return u(n)},e.wbg.__wbg_stack_658279fe44541cf6=function(n,t){let r=_(t).stack,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_error_f851667af71bcfc6=function(n,t){var r=g(n,t);n!==0&&b.__wbindgen_export_7(n,t,1),console.error(r)},e.wbg.__wbindgen_object_drop_ref=function(n){m(n)},e.wbg.__wbindgen_object_clone_ref=function(n){let t=_(n);return u(t)},e.wbg.__wbindgen_string_new=function(n,t){let r=j(n,t);return u(r)},e.wbg.__wbg_setStartBefore_30168c9b319d25ea=function(){return i(function(n,t){_(n).setStartBefore(_(t))},arguments)},e.wbg.__wbg_setEndBefore_cca4b1d4f0751d73=function(){return i(function(n,t){_(n).setEndBefore(_(t))},arguments)},e.wbg.__wbg_deleteContents_2568bbe46ed98ae7=function(){return i(function(n){_(n).deleteContents()},arguments)},e.wbg.__wbg_settextContent_1493ae8928df81aa=function(n,t,r){var o=g(t,r);_(n).textContent=o},e.wbg.__wbg_append_fd99b0b80132b946=function(){return i(function(n,t){_(n).append(_(t))},arguments)},e.wbg.__wbg_createDocumentFragment_ba4b959e9d93916b=function(n){let t=_(n).createDocumentFragment();return u(t)},e.wbg.__wbg_localStorage_3d538af21ea07fcc=function(){return i(function(n){let t=_(n).localStorage;return l(t)?0:u(t)},arguments)},e.wbg.__wbg_new_75208e29bddfd88c=function(){let n=new Array;return u(n)},e.wbg.__wbg_push_0239ee92f127e807=function(n,t){return _(n).push(_(t))},e.wbg.__wbg_set_79c308ecd9a1d091=function(n,t,r){_(n)[t>>>0]=m(r)},e.wbg.__wbg_put_9806ff25ff20486b=function(){return i(function(n,t){let r=_(n).put(_(t));return u(r)},arguments)},e.wbg.__wbg_put_f5ab898915aa0ec4=function(){return i(function(n,t,r){let o=_(n).put(_(t),_(r));return u(o)},arguments)},e.wbg.__wbg_setoncomplete_d9643b9200c8bfcb=function(n,t){_(n).oncomplete=_(t)},e.wbg.__wbg_setonerror_493ac3af685d641e=function(n,t){_(n).onerror=_(t)},e.wbg.__wbindgen_cb_drop=function(n){let t=m(n).original;return t.cnt--==1?(t.a=0,!0):!1},e.wbg.__wbg_setonsuccess_07be5f02db609d40=function(n,t){_(n).onsuccess=_(t)},e.wbg.__wbg_setonerror_4042c0d324fafcf9=function(n,t){_(n).onerror=_(t)},e.wbg.__wbg_String_de2361487bf84fa6=function(n,t){let r=String(_(t)),o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbindgen_boolean_get=function(n){let t=_(n);return typeof t=="boolean"?t?1:0:2},e.wbg.__wbindgen_is_bigint=function(n){return typeof _(n)=="bigint"},e.wbg.__wbindgen_number_get=function(n,t){let r=_(t),o=typeof r=="number"?r:void 0;$()[n/8+1]=l(o)?0:o,f()[n/4+0]=!l(o)},e.wbg.__wbg_isSafeInteger_a23a66ee7c41b273=function(n){return Number.isSafeInteger(_(n))},e.wbg.__wbindgen_bigint_from_i64=function(n){return u(n)},e.wbg.__wbg_length_161c0d89c6535c1d=function(n){return _(n).length},e.wbg.__wbindgen_is_object=function(n){let t=_(n);return typeof t=="object"&&t!==null},e.wbg.__wbg_iterator_40027cdd598da26b=function(){return u(Symbol.iterator)},e.wbg.__wbindgen_in=function(n,t){return _(n)in _(t)},e.wbg.__wbindgen_bigint_from_u64=function(n){let t=BigInt.asUintN(64,n);return u(t)},e.wbg.__wbindgen_error_new=function(n,t){let r=new Error(j(n,t));return u(r)},e.wbg.__wbg_entries_488960b196cfb6a5=function(n){let t=Object.entries(_(n));return u(t)},e.wbg.__wbindgen_jsval_eq=function(n,t){return _(n)===_(t)},e.wbg.__wbindgen_string_get=function(n,t){let r=_(t),o=typeof r=="string"?r:void 0;var c=l(o)?0:d(o,b.__wbindgen_export_0,b.__wbindgen_export_1),s=w;f()[n/4+1]=s,f()[n/4+0]=c},e.wbg.__wbg_get_a511742412eef1ff=function(){return i(function(n,t){let r=_(n).get(_(t));return u(r)},arguments)},e.wbg.__wbg_instanceof_IdbFactory_ce39c85191908177=function(n){let t;try{t=_(n)instanceof IDBFactory}catch{t=!1}return t},e.wbg.__wbg_open_dda0623a9d03ec08=function(){return i(function(n,t,r){var o=g(t,r);let c=_(n).open(o);return u(c)},arguments)},e.wbg.__wbg_open_e75f6c89e35c2edf=function(){return i(function(n,t,r,o){var c=g(t,r);let s=_(n).open(c,o>>>0);return u(s)},arguments)},e.wbg.__wbg_setonupgradeneeded_704b0c0061756fd9=function(n,t){_(n).onupgradeneeded=_(t)},e.wbg.__wbg_text_24a1c9b21feed3de=function(){return i(function(n){let t=_(n).text();return u(t)},arguments)},e.wbg.__wbg_new_632630b5cec17f21=function(){let n=new Object;return u(n)},e.wbg.__wbg_new_4db22fd5d40c5665=function(){return i(function(){let n=new Headers;return u(n)},arguments)},e.wbg.__wbg_new_b1f2d6842d615181=function(n){let t=new Uint8Array(_(n));return u(t)},e.wbg.__wbg_append_b2e8ed692fc5eb6e=function(){return i(function(n,t,r,o,c){var s=g(t,r),a=g(o,c);_(n).append(s,a)},arguments)},e.wbg.__wbg_newwithstrandinit_11fbc38beb4c26b0=function(){return i(function(n,t,r){var o=g(n,t);let c=new Request(o,_(r));return u(c)},arguments)},e.wbg.__wbg_has_ad45eb020184f624=function(){return i(function(n,t){return Reflect.has(_(n),_(t))},arguments)},e.wbg.__wbg_fetch_10edd7d7da150227=function(n,t){let r=_(n).fetch(_(t));return u(r)},e.wbg.__wbg_fetch_43b95fc3417395cd=function(n){let t=fetch(_(n));return u(t)},e.wbg.__wbg_instanceof_Response_b5451a06784a2404=function(n){let t;try{t=_(n)instanceof Response}catch{t=!1}return t},e.wbg.__wbg_status_bea567d1049f0b6a=function(n){return _(n).status},e.wbg.__wbg_url_e319aee56d26ddf1=function(n,t){let r=_(t).url,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_headers_96d9457941f08a33=function(n){let t=_(n).headers;return u(t)},e.wbg.__wbg_stringify_865daa6fb8c83d5a=function(){return i(function(n){let t=JSON.stringify(_(n));return u(t)},arguments)},e.wbg.__wbg_set_3cc50a75382b2797=function(){return i(function(n,t,r,o,c){var s=g(t,r),a=g(o,c);_(n)[s]=a},arguments)},e.wbg.__wbg_setInnerMessagesAsync_1243a9d3ec40d294=function(){return i(function(n,t){var r=g(n,t);let o=setInnerMessagesAsync(r);return u(o)},arguments)},e.wbg.__wbg_setOuterMessagesAsync_b3e9268407a3656f=function(){return i(function(n,t){var r=g(n,t);let o=setOuterMessagesAsync(r);return u(o)},arguments)},e.wbg.__wbg_new_70828a4353259d4b=function(n,t){try{var r={a:n,b:t},o=(s,a)=>{let p=r.a;r.a=0;try{return rn(p,r.b,s,a)}finally{r.a=p}};let c=new Promise(o);return u(c)}finally{r.a=r.b=0}},e.wbg.__wbg_setOuterMessages_2079664d21fa8113=function(){return i(function(n,t){var r=g(n,t);let o=setOuterMessages(r);return u(o)},arguments)},e.wbg.__wbg_setInnerMessages_390ddfebf5a51260=function(){return i(function(n,t){var r=g(n,t);let o=setInnerMessages(r);return u(o)},arguments)},e.wbg.__wbindgen_is_string=function(n){return typeof _(n)=="string"},e.wbg.__wbindgen_is_function=function(n){return typeof _(n)=="function"},e.wbg.__wbg_call_3f093dd26d5569f8=function(){return i(function(n,t){let r=_(n).call(_(t));return u(r)},arguments)},e.wbg.__wbg_get_0ee8ea3c7c984c45=function(n,t){let r=_(n)[t>>>0];return u(r)},e.wbg.__wbg_next_b2d3366343a208b3=function(){return i(function(n){let t=_(n).next();return u(t)},arguments)},e.wbg.__wbg_done_90b14d6f6eacc42f=function(n){return _(n).done},e.wbg.__wbg_value_3158be908c80a75e=function(n){let t=_(n).value;return u(t)},e.wbg.__wbg_next_586204376d2ed373=function(n){let t=_(n).next;return u(t)},e.wbg.__wbg_get_3fddfed2c83f434c=function(){return i(function(n,t){let r=Reflect.get(_(n),_(t));return u(r)},arguments)},e.wbg.__wbg_self_05040bd9523805b9=function(){return i(function(){let n=self.self;return u(n)},arguments)},e.wbg.__wbg_window_adc720039f2cb14f=function(){return i(function(){let n=window.window;return u(n)},arguments)},e.wbg.__wbg_globalThis_622105db80c1457d=function(){return i(function(){let n=globalThis.globalThis;return u(n)},arguments)},e.wbg.__wbg_global_f56b013ed9bcf359=function(){return i(function(){let n=global.global;return u(n)},arguments)},e.wbg.__wbindgen_is_undefined=function(n){return _(n)===void 0},e.wbg.__wbg_newnoargs_cfecb3965268594c=function(n,t){var r=g(n,t);let o=new Function(r);return u(o)},e.wbg.__wbg_decodeURI_495987abb10b5303=function(){return i(function(n,t){var r=g(n,t);let o=decodeURI(r);return u(o)},arguments)},e.wbg.__wbg_isArray_e783c41d0dd19b44=function(n){return Array.isArray(_(n))},e.wbg.__wbg_call_67f2111acd2dfdb6=function(){return i(function(n,t,r){let o=_(n).call(_(t),_(r));return u(o)},arguments)},e.wbg.__wbg_is_bd5dc4ae269cba1c=function(n,t){return Object.is(_(n),_(t))},e.wbg.__wbg_set_961700853a212a39=function(){return i(function(n,t,r){return Reflect.set(_(n),_(t),_(r))},arguments)},e.wbg.__wbg_exec_c6eab43c76cafa2f=function(n,t,r){var o=g(t,r);let c=_(n).exec(o);return l(c)?0:u(c)},e.wbg.__wbg_new_d4c086f687604999=function(n,t,r,o){var c=g(n,t),s=g(r,o);let a=new RegExp(c,s);return u(a)},e.wbg.__wbindgen_memory=function(){let n=b.memory;return u(n)},e.wbg.__wbg_buffer_b914fb8b50ebbc3e=function(n){let t=_(n).buffer;return u(t)},e.wbg.__wbg_newwithbyteoffsetandlength_0de9ee56e9f6ee6e=function(n,t,r){let o=new Uint8Array(_(n),t>>>0,r>>>0);return u(o)},e.wbg.__wbg_set_7d988c98e6ced92d=function(n,t,r){_(n).set(_(t),r>>>0)},e.wbg.__wbg_length_21c4b0ae73cba59d=function(n){return _(n).length},e.wbg.__wbg_remove_dea714b8c5f17b97=function(){return i(function(n,t,r){var o=g(t,r);_(n).remove(o)},arguments)},e.wbg.__wbg_add_73b81757e03ad37a=function(){return i(function(n,t,r){var o=g(t,r);_(n).add(o)},arguments)},e.wbg.__wbg_error_b834525fe62708f5=function(n){console.error(_(n))},e.wbg.__wbg_setdata_3f18cd2879ddb8d5=function(n,t,r){var o=g(t,r);_(n).data=o},e.wbg.__wbg_remove_f7de42c5f9035d0e=function(n){_(n).remove()},e.wbg.__wbg_childNodes_535387effca84f4e=function(n){let t=_(n).childNodes;return u(t)},e.wbg.__wbg_length_8a9352f7b7360c37=function(n){return _(n).length},e.wbg.__wbg_document_eb7fd66bde3ee213=function(n){let t=_(n).document;return l(t)?0:u(t)},e.wbg.__wbg_createComment_5c92617cda72a113=function(n,t,r){var o=g(t,r);let c=_(n).createComment(o);return u(c)},e.wbg.__wbg_new_2b3744f6bd384bcf=function(){return i(function(){let n=new Range;return u(n)},arguments)},e.wbg.__wbg_composedPath_bd8a0336a042e053=function(n){let t=_(n).composedPath();return u(t)},e.wbg.__wbindgen_is_falsy=function(n){return!_(n)},e.wbg.__wbg_cancelBubble_ae95595adf5ae83d=function(n){return _(n).cancelBubble},e.wbg.__wbg_instanceof_ShadowRoot_ef56f954a86c7472=function(n){let t;try{t=_(n)instanceof ShadowRoot}catch{t=!1}return t},e.wbg.__wbg_host_dfffc3b2ba786fb8=function(n){let t=_(n).host;return u(t)},e.wbg.__wbindgen_is_null=function(n){return _(n)===null},e.wbg.__wbg_addEventListener_bc4a7ad4cc72c6bf=function(){return i(function(n,t,r,o,c){var s=g(t,r);_(n).addEventListener(s,_(o),_(c))},arguments)},e.wbg.__wbg_location_b17760ac7977a47a=function(n){let t=_(n).location;return u(t)},e.wbg.__wbg_requestAnimationFrame_fdbeaff9e8f3f77d=function(){return i(function(n,t){return _(n).requestAnimationFrame(_(t))},arguments)},e.wbg.__wbg_removeEventListener_acfc154b998d806b=function(){return i(function(n,t,r,o){var c=g(t,r);_(n).removeEventListener(c,_(o))},arguments)},e.wbg.__wbg_log_79d3c56888567995=function(n){console.log(_(n))},e.wbg.__wbg_warn_2a68e3ab54e55f28=function(n){console.warn(_(n))},e.wbg.__wbg_classList_e98b57addeeb384e=function(n){let t=_(n).classList;return u(t)},e.wbg.__wbg_createTextNode_ea32ad2506f7ae78=function(n,t,r){var o=g(t,r);let c=_(n).createTextNode(o);return u(c)},e.wbg.__wbg_search_6b70a3bf2ceb3f63=function(n,t){let r=_(t).search,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_searchParams_d1d6990d2adb9a23=function(n){let t=_(n).searchParams;return u(t)},e.wbg.__wbg_hash_6169ffe1f1446fd4=function(n,t){let r=_(t).hash,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_getElementById_77f2dfdddee12e05=function(n,t,r){var o=g(t,r);let c=_(n).getElementById(o);return l(c)?0:u(c)},e.wbg.__wbg_scrollIntoView_68275288fdd93eff=function(n){_(n).scrollIntoView()},e.wbg.__wbg_scrollTo_d3f0a8157bc0964a=function(n,t,r){_(n).scrollTo(t,r)},e.wbg.__wbg_href_14a0154147810c9c=function(n,t){let r=_(t).href,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_sethref_5f2e449a509e644b=function(){return i(function(n,t,r){var o=g(t,r);_(n).href=o},arguments)},e.wbg.__wbg_defaultPrevented_f985e9e1fcb557ed=function(n){return _(n).defaultPrevented},e.wbg.__wbg_button_43d11b000a7126cf=function(n){return _(n).button},e.wbg.__wbg_metaKey_35f1fd33c4e0c5df=function(n){return _(n).metaKey},e.wbg.__wbg_altKey_d4801ef04e1f1e33=function(n){return _(n).altKey},e.wbg.__wbg_ctrlKey_2817108375a63e7c=function(n){return _(n).ctrlKey},e.wbg.__wbg_shiftKey_87d2a9527cefdf3d=function(n){return _(n).shiftKey},e.wbg.__wbg_href_32f69263c7029db6=function(n,t){let r=_(t).href,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_target_d86ce47fcec86e65=function(n,t){let r=_(t).target,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_getAttribute_706ae88bd37410fa=function(n,t,r,o){var c=g(r,o);let s=_(t).getAttribute(c);var a=l(s)?0:d(s,b.__wbindgen_export_0,b.__wbindgen_export_1),p=w;f()[n/4+1]=p,f()[n/4+0]=a},e.wbg.__wbg_preventDefault_657cbf753df1396c=function(n){_(n).preventDefault()},e.wbg.__wbg_instanceof_HtmlAnchorElement_9b05407929158ee7=function(n){let t;try{t=_(n)instanceof HTMLAnchorElement}catch{t=!1}return t},e.wbg.__wbg_pushState_01f73865f6d8789a=function(){return i(function(n,t,r,o,c,s){var a=g(r,o),p=g(c,s);_(n).pushState(_(t),a,p)},arguments)},e.wbg.__wbg_replaceState_05b49e34dd5c56f9=function(){return i(function(n,t,r,o,c,s){var a=g(r,o),p=g(c,s);_(n).replaceState(_(t),a,p)},arguments)},e.wbg.__wbg_state_dce1712758f75ed1=function(){return i(function(n){let t=_(n).state;return u(t)},arguments)},e.wbg.__wbg_pathname_d98d0a003b664ef0=function(){return i(function(n,t){let r=_(t).pathname,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},arguments)},e.wbg.__wbg_search_40927d5af164fdfe=function(){return i(function(n,t){let r=_(t).search,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},arguments)},e.wbg.__wbg_objectStoreNames_2ecdd48caeba004f=function(n){let t=_(n).objectStoreNames;return u(t)},e.wbg.__wbg_length_f4c93968efbcbe64=function(n){return _(n).length},e.wbg.__wbg_deleteObjectStore_a858b88892001cfb=function(){return i(function(n,t,r){var o=g(t,r);_(n).deleteObjectStore(o)},arguments)},e.wbg.__wbg_createObjectStore_b94c8c593fd6d249=function(){return i(function(n,t,r,o){var c=g(t,r);let s=_(n).createObjectStore(c,_(o));return u(s)},arguments)},e.wbg.__wbg_transaction_75ade65c1c881217=function(n){let t=_(n).transaction;return l(t)?0:u(t)},e.wbg.__wbg_indexNames_8bd628ce8dc4bc30=function(n){let t=_(n).indexNames;return u(t)},e.wbg.__wbg_deleteIndex_99e3acff010af182=function(){return i(function(n,t,r){var o=g(t,r);_(n).deleteIndex(o)},arguments)},e.wbg.__wbg_createIndex_2b4d8db40f62b4a6=function(){return i(function(n,t,r,o,c){var s=g(t,r);let a=_(n).createIndex(s,_(o),_(c));return u(a)},arguments)},e.wbg.__wbg_error_180ee1f6d813554e=function(){return i(function(n){let t=_(n).error;return l(t)?0:u(t)},arguments)},e.wbg.__wbg_toString_07f01913ec9af122=function(n){let t=_(n).toString();return u(t)},e.wbg.__wbindgen_jsval_loose_eq=function(n,t){return _(n)==_(t)},e.wbg.__wbg_instanceof_Uint8Array_c299a4ee232e76ba=function(n){let t;try{t=_(n)instanceof Uint8Array}catch{t=!1}return t},e.wbg.__wbg_instanceof_ArrayBuffer_9221fa854ffb71b5=function(n){let t;try{t=_(n)instanceof ArrayBuffer}catch{t=!1}return t},e.wbg.__wbindgen_bigint_get_as_i64=function(n,t){let r=_(t),o=typeof r=="bigint"?r:void 0;z()[n/8+1]=l(o)?BigInt(0):o,f()[n/4+0]=!l(o)},e.wbg.__wbindgen_debug_string=function(n,t){let r=k(_(t)),o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbindgen_throw=function(n,t){throw new Error(j(n,t))},e.wbg.__wbg_then_f9e58f5a50f43eae=function(n,t){let r=_(n).then(_(t));return u(r)},e.wbg.__wbg_queueMicrotask_f61ee94ee663068b=function(n){queueMicrotask(_(n))},e.wbg.__wbg_then_20a5920e447d1cb1=function(n,t,r){let o=_(n).then(_(t),_(r));return u(o)},e.wbg.__wbg_queueMicrotask_f82fc5d1e8f816ae=function(n){let t=_(n).queueMicrotask;return u(t)},e.wbg.__wbg_resolve_5da6faf2c96fd1d5=function(n){let t=Promise.resolve(_(n));return u(t)},e.wbg.__wbg_byobRequest_643426f0037311f0=function(n){let t=_(n).byobRequest;return l(t)?0:u(t)},e.wbg.__wbg_view_38a0bacb59ad00ee=function(n){let t=_(n).view;return l(t)?0:u(t)},e.wbg.__wbg_byteLength_4f4b58172d990c0a=function(n){return _(n).byteLength},e.wbg.__wbg_close_0b618a762cdb578b=function(){return i(function(n){_(n).close()},arguments)},e.wbg.__wbg_new_73a5987615ec8862=function(n,t){var r=g(n,t);let o=new Error(r);return u(o)},e.wbg.__wbg_buffer_67e624f5a0ab2319=function(n){let t=_(n).buffer;return u(t)},e.wbg.__wbg_byteOffset_adbd2a554609eb4e=function(n){return _(n).byteOffset},e.wbg.__wbg_close_23aa806471e38253=function(){return i(function(n){_(n).close()},arguments)},e.wbg.__wbg_enqueue_fe9e340e2bc8714b=function(){return i(function(n,t){_(n).enqueue(_(t))},arguments)},e.wbg.__wbg_instanceof_Window_cee7a886d55e7df5=function(n){let t;try{t=_(n)instanceof Window}catch{t=!1}return t},e.wbg.__wbg_body_874ccb42daaab363=function(n){let t=_(n).body;return l(t)?0:u(t)},e.wbg.__wbg_createElement_03cf347ddad1c8c0=function(){return i(function(n,t,r){var o=g(t,r);let c=_(n).createElement(o);return u(c)},arguments)},e.wbg.__wbg_createElementNS_93f8de4acdef6da8=function(){return i(function(n,t,r,o,c){var s=g(t,r),a=g(o,c);let p=_(n).createElementNS(s,a);return u(p)},arguments)},e.wbg.__wbg_append_125fff38dadbc15f=function(){return i(function(n,t){_(n).append(_(t))},arguments)},e.wbg.__wbg_contains_387aaee89de6826b=function(n,t,r){var o=g(t,r);return _(n).contains(o)},e.wbg.__wbg_get_de1356a147af67e3=function(n,t,r){let o=_(t)[r>>>0];var c=l(o)?0:d(o,b.__wbindgen_export_0,b.__wbindgen_export_1),s=w;f()[n/4+1]=s,f()[n/4+0]=c},e.wbg.__wbg_setinnerHTML_95222f1a2e797983=function(n,t,r){var o=g(t,r);_(n).innerHTML=o},e.wbg.__wbg_hasAttribute_e0b4c51b50660221=function(n,t,r){var o=g(t,r);return _(n).hasAttribute(o)},e.wbg.__wbg_removeAttribute_0c021c98a4dc7402=function(){return i(function(n,t,r){var o=g(t,r);_(n).removeAttribute(o)},arguments)},e.wbg.__wbg_setAttribute_f7ffa687ef977957=function(){return i(function(n,t,r,o,c){var s=g(t,r),a=g(o,c);_(n).setAttribute(s,a)},arguments)},e.wbg.__wbg_before_6ea6598a4cb72792=function(){return i(function(n,t){_(n).before(_(t))},arguments)},e.wbg.__wbg_target_6795373f170fd786=function(n){let t=_(n).target;return l(t)?0:u(t)},e.wbg.__wbg_addEventListener_f984e99465a6a7f4=function(){return i(function(n,t,r,o){var c=g(t,r);_(n).addEventListener(c,_(o))},arguments)},e.wbg.__wbg_transaction_b46588e9ee3c2219=function(){return i(function(n,t,r){let o=_(n).transaction(_(t),m(r));return u(o)},arguments)},e.wbg.__wbg_result_43ea35e72f0fa7c7=function(){return i(function(n){let t=_(n).result;return u(t)},arguments)},e.wbg.__wbg_objectStore_402a3923882f9f3f=function(){return i(function(n,t,r){var o=g(t,r);let c=_(n).objectStore(o);return u(c)},arguments)},e.wbg.__wbg_origin_305402044aa148ce=function(){return i(function(n,t){let r=_(t).origin,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},arguments)},e.wbg.__wbg_hash_163703b5971e593c=function(){return i(function(n,t){let r=_(t).hash,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},arguments)},e.wbg.__wbg_parentNode_e3a5ee563364a613=function(n){let t=_(n).parentNode;return l(t)?0:u(t)},e.wbg.__wbg_previousSibling_28df8137ae6104f8=function(n){let t=_(n).previousSibling;return l(t)?0:u(t)},e.wbg.__wbg_nextSibling_87d2b32dfbf09fe3=function(n){let t=_(n).nextSibling;return l(t)?0:u(t)},e.wbg.__wbg_appendChild_4153ba1b5d54d73b=function(){return i(function(n,t){let r=_(n).appendChild(_(t));return u(r)},arguments)},e.wbg.__wbg_cloneNode_ea49a704f0699b2e=function(){return i(function(n){let t=_(n).cloneNode();return u(t)},arguments)},e.wbg.__wbg_respond_fee44bba73c2fc8a=function(){return i(function(n,t){_(n).respond(t>>>0)},arguments)},e.wbg.__wbg_getItem_5c179cd36e9529e8=function(){return i(function(n,t,r,o){var c=g(r,o);let s=_(t).getItem(c);var a=l(s)?0:d(s,b.__wbindgen_export_0,b.__wbindgen_export_1),p=w;f()[n/4+1]=p,f()[n/4+0]=a},arguments)},e.wbg.__wbg_origin_ecca884a2f9bd239=function(n,t){let r=_(t).origin,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_pathname_3bec400c9c042d62=function(n,t){let r=_(t).pathname,o=d(r,b.__wbindgen_export_0,b.__wbindgen_export_1),c=w;f()[n/4+1]=c,f()[n/4+0]=o},e.wbg.__wbg_newwithbase_98813076a95cdc23=function(){return i(function(n,t,r,o){var c=g(n,t),s=g(r,o);let a=new URL(c,s);return u(a)},arguments)},e.wbg.__wbg_history_6882f83324841599=function(){return i(function(n){let t=_(n).history;return u(t)},arguments)},e.wbg.__wbindgen_closure_wrapper594=function(n,t,r){let o=h(n,t,155,V);return u(o)},e.wbg.__wbindgen_closure_wrapper1004=function(n,t,r){let o=h(n,t,73,I);return u(o)},e.wbg.__wbindgen_closure_wrapper1322=function(n,t,r){let o=h(n,t,120,I);return u(o)},e.wbg.__wbindgen_closure_wrapper1770=function(n,t,r){let o=h(n,t,73,J);return u(o)},e.wbg.__wbindgen_closure_wrapper2087=function(n,t,r){let o=G(n,t,73,Q);return u(o)},e.wbg.__wbindgen_closure_wrapper2152=function(n,t,r){let o=h(n,t,120,I);return u(o)},e.wbg.__wbindgen_closure_wrapper3699=function(n,t,r){let o=h(n,t,155,I);return u(o)},e}function W(e,n){return b=e.exports,q.__wbindgen_wasm_module=n,S=null,x=null,A=null,v=null,b.__wbindgen_start(),b}function on(e){if(b!==void 0)return b;let n=F();e instanceof WebAssembly.Module||(e=new WebAssembly.Module(e));let t=new WebAssembly.Instance(e,n);return W(t,e)}async function q(e){if(b!==void 0)return b;typeof e>"u"&&(e=new URL("./dice_ui-b3b89147d2e8474b_bg.wasm?hash=60be9f1c",import.meta.url));let n=F();(typeof e=="string"||typeof Request=="function"&&e instanceof Request||typeof URL=="function"&&e instanceof URL)&&(e=fetch(e));let{instance:t,module:r}=await _n(await e,n);return W(t,r)}var N=q;N("./dice_ui-b3b89147d2e8474b_bg.wasm");window.wasmBindings=B;
//# sourceMappingURL=2-DG5TUUXN.js.map
