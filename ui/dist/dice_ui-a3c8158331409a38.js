let ad=8,a3=`number`,ab=2,X=null,ai=149,Z=`undefined`,a4=`boolean`,Y=1,a2=`function`,aj=70,aa=4,a7=`Object`,a0=0,a9=16,a5=`string`,_=`utf-8`,ac=`bigint`,V=Array,a6=Array.isArray,af=BigInt,$=Error,a8=JSON.stringify,ae=Object,ah=Promise,ag=Reflect,a1=Uint8Array,W=undefined;var z=((b,c,e)=>{a.__wbindgen_export_4(b,c,d(e))});var w=(a=>{const b=typeof a;if(b==a3||b==a4||a==X){return `${a}`};if(b==a5){return `"${a}"`};if(b==`symbol`){const b=a.description;if(b==X){return `Symbol`}else{return `Symbol(${b})`}};if(b==a2){const b=a.name;if(typeof b==a5&&b.length>a0){return `Function(${b})`}else{return `Function`}};if(a6(a)){const b=a.length;let c=`[`;if(b>a0){c+=w(a[a0])};for(let d=Y;d<b;d++){c+=`, `+ w(a[d])};c+=`]`;return c};const c=/\[object ([^\]]+)\]/.exec(toString.call(a));let d;if(c.length>Y){d=c[Y]}else{return toString.call(a)};if(d==a7){try{return `Object(`+ a8(a)+ `)`}catch(a){return a7}};if(a instanceof $){return `${a.name}: ${a.message}\n${a.stack}`};return d});var R=((a,b)=>{});var y=((b,c)=>{a.__wbindgen_export_3(b,c)});var g=(a=>{const b=e(a);f(a);return b});var d=(a=>{if(c===b.length)b.push(b.length+ Y);const d=c;c=b[d];b[d]=a;return d});var U=(async(b)=>{if(a!==W)return a;if(typeof b===Z){b=new URL(`dice_ui-a3c8158331409a38_bg.wasm`,import.meta.url)};const c=Q();if(typeof b===a5||typeof Request===a2&&b instanceof Request||typeof URL===a2&&b instanceof URL){b=fetch(b)};R(c);const {instance:d,module:e}=await P(await b,c);return S(d,e)});var T=(b=>{if(a!==W)return a;const c=Q();R(c);if(!(b instanceof WebAssembly.Module)){b=new WebAssembly.Module(b)};const d=new WebAssembly.Instance(b,c);return S(d,b)});var S=((b,c)=>{a=b.exports;U.__wbindgen_wasm_module=c;u=X;m=X;o=X;i=X;a.__wbindgen_start();return a});var Q=(()=>{const b={};b.wbg={};b.wbg.__wbindgen_number_new=(a=>{const b=a;return d(b)});b.wbg.__wbg_new_a9d80688888b4894=(a=>{const b=new Date(e(a));return d(b)});b.wbg.__wbg_getTimezoneOffset_840b552f34917133=(a=>{const b=e(a).getTimezoneOffset();return b});b.wbg.__wbg_new_abda76e883ba8a5f=(()=>{const a=new $();return d(a)});b.wbg.__wbg_stack_658279fe44541cf6=((b,c)=>{const d=e(c).stack;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_error_f851667af71bcfc6=((b,c)=>{var d=D(b,c);if(b!==a0){a.__wbindgen_export_7(b,c,Y)};console.error(d)});b.wbg.__wbindgen_object_drop_ref=(a=>{g(a)});b.wbg.__wbindgen_object_clone_ref=(a=>{const b=e(a);return d(b)});b.wbg.__wbindgen_string_new=((a,b)=>{const c=k(a,b);return d(c)});b.wbg.__wbg_setStartBefore_30168c9b319d25ea=function(){return E(((a,b)=>{e(a).setStartBefore(e(b))}),arguments)};b.wbg.__wbg_setEndBefore_cca4b1d4f0751d73=function(){return E(((a,b)=>{e(a).setEndBefore(e(b))}),arguments)};b.wbg.__wbg_deleteContents_2568bbe46ed98ae7=function(){return E((a=>{e(a).deleteContents()}),arguments)};b.wbg.__wbg_settextContent_1493ae8928df81aa=((a,b,c)=>{var d=D(b,c);e(a).textContent=d});b.wbg.__wbg_append_fd99b0b80132b946=function(){return E(((a,b)=>{e(a).append(e(b))}),arguments)};b.wbg.__wbg_createDocumentFragment_ba4b959e9d93916b=(a=>{const b=e(a).createDocumentFragment();return d(b)});b.wbg.__wbg_localStorage_3d538af21ea07fcc=function(){return E((a=>{const b=e(a).localStorage;return l(b)?a0:d(b)}),arguments)};b.wbg.__wbg_new_75208e29bddfd88c=(()=>{const a=new V();return d(a)});b.wbg.__wbg_push_0239ee92f127e807=((a,b)=>{const c=e(a).push(e(b));return c});b.wbg.__wbg_set_79c308ecd9a1d091=((a,b,c)=>{e(a)[b>>>a0]=g(c)});b.wbg.__wbg_put_9806ff25ff20486b=function(){return E(((a,b)=>{const c=e(a).put(e(b));return d(c)}),arguments)};b.wbg.__wbg_put_f5ab898915aa0ec4=function(){return E(((a,b,c)=>{const f=e(a).put(e(b),e(c));return d(f)}),arguments)};b.wbg.__wbg_setoncomplete_d9643b9200c8bfcb=((a,b)=>{e(a).oncomplete=e(b)});b.wbg.__wbg_setonerror_493ac3af685d641e=((a,b)=>{e(a).onerror=e(b)});b.wbg.__wbindgen_cb_drop=(a=>{const b=g(a).original;if(b.cnt--==Y){b.a=a0;return !0};const c=!1;return c});b.wbg.__wbg_setonsuccess_07be5f02db609d40=((a,b)=>{e(a).onsuccess=e(b)});b.wbg.__wbg_setonerror_4042c0d324fafcf9=((a,b)=>{e(a).onerror=e(b)});b.wbg.__wbg_String_de2361487bf84fa6=((b,c)=>{const d=String(e(c));const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbindgen_boolean_get=(a=>{const b=e(a);const c=typeof b===a4?(b?Y:a0):ab;return c});b.wbg.__wbindgen_is_bigint=(a=>{const b=typeof e(a)===ac;return b});b.wbg.__wbindgen_number_get=((a,b)=>{const c=e(b);const d=typeof c===a3?c:W;n()[a/ad+ Y]=l(d)?a0:d;p()[a/aa+ a0]=!l(d)});b.wbg.__wbg_isSafeInteger_a23a66ee7c41b273=(a=>{const b=Number.isSafeInteger(e(a));return b});b.wbg.__wbindgen_bigint_from_i64=(a=>{const b=a;return d(b)});b.wbg.__wbg_length_161c0d89c6535c1d=(a=>{const b=e(a).length;return b});b.wbg.__wbindgen_is_object=(a=>{const b=e(a);const c=typeof b===`object`&&b!==X;return c});b.wbg.__wbg_iterator_40027cdd598da26b=(()=>{const a=Symbol.iterator;return d(a)});b.wbg.__wbindgen_in=((a,b)=>{const c=e(a) in e(b);return c});b.wbg.__wbg_entries_488960b196cfb6a5=(a=>{const b=ae.entries(e(a));return d(b)});b.wbg.__wbindgen_bigint_from_u64=(a=>{const b=af.asUintN(64,a);return d(b)});b.wbg.__wbindgen_error_new=((a,b)=>{const c=new $(k(a,b));return d(c)});b.wbg.__wbindgen_jsval_eq=((a,b)=>{const c=e(a)===e(b);return c});b.wbg.__wbindgen_string_get=((b,c)=>{const d=e(c);const f=typeof d===a5?d:W;var g=l(f)?a0:t(f,a.__wbindgen_export_0,a.__wbindgen_export_1);var h=q;p()[b/aa+ Y]=h;p()[b/aa+ a0]=g});b.wbg.__wbg_get_a511742412eef1ff=function(){return E(((a,b)=>{const c=e(a).get(e(b));return d(c)}),arguments)};b.wbg.__wbg_instanceof_IdbFactory_ce39c85191908177=(a=>{let b;try{b=e(a) instanceof IDBFactory}catch(a){b=!1}const c=b;return c});b.wbg.__wbg_open_dda0623a9d03ec08=function(){return E(((a,b,c)=>{var f=D(b,c);const g=e(a).open(f);return d(g)}),arguments)};b.wbg.__wbg_open_e75f6c89e35c2edf=function(){return E(((a,b,c,f)=>{var g=D(b,c);const h=e(a).open(g,f>>>a0);return d(h)}),arguments)};b.wbg.__wbg_setonupgradeneeded_704b0c0061756fd9=((a,b)=>{e(a).onupgradeneeded=e(b)});b.wbg.__wbg_text_24a1c9b21feed3de=function(){return E((a=>{const b=e(a).text();return d(b)}),arguments)};b.wbg.__wbg_new_632630b5cec17f21=(()=>{const a=new ae();return d(a)});b.wbg.__wbg_new_4db22fd5d40c5665=function(){return E((()=>{const a=new Headers();return d(a)}),arguments)};b.wbg.__wbg_new_b1f2d6842d615181=(a=>{const b=new a1(e(a));return d(b)});b.wbg.__wbg_append_b2e8ed692fc5eb6e=function(){return E(((a,b,c,d,f)=>{var g=D(b,c);var h=D(d,f);e(a).append(g,h)}),arguments)};b.wbg.__wbg_newwithstrandinit_11fbc38beb4c26b0=function(){return E(((a,b,c)=>{var f=D(a,b);const g=new Request(f,e(c));return d(g)}),arguments)};b.wbg.__wbg_has_ad45eb020184f624=function(){return E(((a,b)=>{const c=ag.has(e(a),e(b));return c}),arguments)};b.wbg.__wbg_fetch_10edd7d7da150227=((a,b)=>{const c=e(a).fetch(e(b));return d(c)});b.wbg.__wbg_fetch_43b95fc3417395cd=(a=>{const b=fetch(e(a));return d(b)});b.wbg.__wbg_instanceof_Response_b5451a06784a2404=(a=>{let b;try{b=e(a) instanceof Response}catch(a){b=!1}const c=b;return c});b.wbg.__wbg_status_bea567d1049f0b6a=(a=>{const b=e(a).status;return b});b.wbg.__wbg_url_e319aee56d26ddf1=((b,c)=>{const d=e(c).url;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_headers_96d9457941f08a33=(a=>{const b=e(a).headers;return d(b)});b.wbg.__wbg_stringify_865daa6fb8c83d5a=function(){return E((a=>{const b=a8(e(a));return d(b)}),arguments)};b.wbg.__wbg_set_3cc50a75382b2797=function(){return E(((a,b,c,d,f)=>{var g=D(b,c);var h=D(d,f);e(a)[g]=h}),arguments)};b.wbg.__wbg_setOuterMessagesAsync_b3e9268407a3656f=function(){return E(((a,b)=>{var c=D(a,b);const e=setOuterMessagesAsync(c);return d(e)}),arguments)};b.wbg.__wbg_setInnerMessagesAsync_1243a9d3ec40d294=function(){return E(((a,b)=>{var c=D(a,b);const e=setInnerMessagesAsync(c);return d(e)}),arguments)};b.wbg.__wbg_new_70828a4353259d4b=((a,b)=>{try{var c={a:a,b:b};var e=(a,b)=>{const d=c.a;c.a=a0;try{return L(d,c.b,a,b)}finally{c.a=d}};const f=new ah(e);return d(f)}finally{c.a=c.b=a0}});b.wbg.__wbg_setOuterMessages_2079664d21fa8113=function(){return E(((a,b)=>{var c=D(a,b);const e=setOuterMessages(c);return d(e)}),arguments)};b.wbg.__wbg_setInnerMessages_390ddfebf5a51260=function(){return E(((a,b)=>{var c=D(a,b);const e=setInnerMessages(c);return d(e)}),arguments)};b.wbg.__wbindgen_is_string=(a=>{const b=typeof e(a)===a5;return b});b.wbg.__wbindgen_is_function=(a=>{const b=typeof e(a)===a2;return b});b.wbg.__wbg_call_3f093dd26d5569f8=function(){return E(((a,b)=>{const c=e(a).call(e(b));return d(c)}),arguments)};b.wbg.__wbg_get_0ee8ea3c7c984c45=((a,b)=>{const c=e(a)[b>>>a0];return d(c)});b.wbg.__wbg_next_b2d3366343a208b3=function(){return E((a=>{const b=e(a).next();return d(b)}),arguments)};b.wbg.__wbg_done_90b14d6f6eacc42f=(a=>{const b=e(a).done;return b});b.wbg.__wbg_value_3158be908c80a75e=(a=>{const b=e(a).value;return d(b)});b.wbg.__wbg_next_586204376d2ed373=(a=>{const b=e(a).next;return d(b)});b.wbg.__wbg_get_3fddfed2c83f434c=function(){return E(((a,b)=>{const c=ag.get(e(a),e(b));return d(c)}),arguments)};b.wbg.__wbg_self_05040bd9523805b9=function(){return E((()=>{const a=self.self;return d(a)}),arguments)};b.wbg.__wbg_window_adc720039f2cb14f=function(){return E((()=>{const a=window.window;return d(a)}),arguments)};b.wbg.__wbg_globalThis_622105db80c1457d=function(){return E((()=>{const a=globalThis.globalThis;return d(a)}),arguments)};b.wbg.__wbg_global_f56b013ed9bcf359=function(){return E((()=>{const a=global.global;return d(a)}),arguments)};b.wbg.__wbindgen_is_undefined=(a=>{const b=e(a)===W;return b});b.wbg.__wbg_newnoargs_cfecb3965268594c=((a,b)=>{var c=D(a,b);const e=new Function(c);return d(e)});b.wbg.__wbg_decodeURI_495987abb10b5303=function(){return E(((a,b)=>{var c=D(a,b);const e=decodeURI(c);return d(e)}),arguments)};b.wbg.__wbg_isArray_e783c41d0dd19b44=(a=>{const b=a6(e(a));return b});b.wbg.__wbg_call_67f2111acd2dfdb6=function(){return E(((a,b,c)=>{const f=e(a).call(e(b),e(c));return d(f)}),arguments)};b.wbg.__wbg_is_bd5dc4ae269cba1c=((a,b)=>{const c=ae.is(e(a),e(b));return c});b.wbg.__wbg_set_961700853a212a39=function(){return E(((a,b,c)=>{const d=ag.set(e(a),e(b),e(c));return d}),arguments)};b.wbg.__wbg_exec_c6eab43c76cafa2f=((a,b,c)=>{var f=D(b,c);const g=e(a).exec(f);return l(g)?a0:d(g)});b.wbg.__wbg_new_d4c086f687604999=((a,b,c,e)=>{var f=D(a,b);var g=D(c,e);const h=new RegExp(f,g);return d(h)});b.wbg.__wbindgen_memory=(()=>{const b=a.memory;return d(b)});b.wbg.__wbg_buffer_b914fb8b50ebbc3e=(a=>{const b=e(a).buffer;return d(b)});b.wbg.__wbg_newwithbyteoffsetandlength_0de9ee56e9f6ee6e=((a,b,c)=>{const f=new a1(e(a),b>>>a0,c>>>a0);return d(f)});b.wbg.__wbg_set_7d988c98e6ced92d=((a,b,c)=>{e(a).set(e(b),c>>>a0)});b.wbg.__wbg_length_21c4b0ae73cba59d=(a=>{const b=e(a).length;return b});b.wbg.__wbg_error_b834525fe62708f5=(a=>{console.error(e(a))});b.wbg.__wbg_remove_dea714b8c5f17b97=function(){return E(((a,b,c)=>{var d=D(b,c);e(a).remove(d)}),arguments)};b.wbg.__wbg_add_73b81757e03ad37a=function(){return E(((a,b,c)=>{var d=D(b,c);e(a).add(d)}),arguments)};b.wbg.__wbg_remove_f7de42c5f9035d0e=(a=>{e(a).remove()});b.wbg.__wbg_setdata_3f18cd2879ddb8d5=((a,b,c)=>{var d=D(b,c);e(a).data=d});b.wbg.__wbg_childNodes_535387effca84f4e=(a=>{const b=e(a).childNodes;return d(b)});b.wbg.__wbg_length_8a9352f7b7360c37=(a=>{const b=e(a).length;return b});b.wbg.__wbg_document_eb7fd66bde3ee213=(a=>{const b=e(a).document;return l(b)?a0:d(b)});b.wbg.__wbg_new_2b3744f6bd384bcf=function(){return E((()=>{const a=new Range();return d(a)}),arguments)};b.wbg.__wbg_createComment_5c92617cda72a113=((a,b,c)=>{var f=D(b,c);const g=e(a).createComment(f);return d(g)});b.wbg.__wbg_composedPath_bd8a0336a042e053=(a=>{const b=e(a).composedPath();return d(b)});b.wbg.__wbindgen_is_falsy=(a=>{const b=!e(a);return b});b.wbg.__wbg_cancelBubble_ae95595adf5ae83d=(a=>{const b=e(a).cancelBubble;return b});b.wbg.__wbg_instanceof_ShadowRoot_ef56f954a86c7472=(a=>{let b;try{b=e(a) instanceof ShadowRoot}catch(a){b=!1}const c=b;return c});b.wbg.__wbg_host_dfffc3b2ba786fb8=(a=>{const b=e(a).host;return d(b)});b.wbg.__wbindgen_is_null=(a=>{const b=e(a)===X;return b});b.wbg.__wbg_addEventListener_bc4a7ad4cc72c6bf=function(){return E(((a,b,c,d,f)=>{var g=D(b,c);e(a).addEventListener(g,e(d),e(f))}),arguments)};b.wbg.__wbg_location_b17760ac7977a47a=(a=>{const b=e(a).location;return d(b)});b.wbg.__wbg_requestAnimationFrame_fdbeaff9e8f3f77d=function(){return E(((a,b)=>{const c=e(a).requestAnimationFrame(e(b));return c}),arguments)};b.wbg.__wbg_removeEventListener_acfc154b998d806b=function(){return E(((a,b,c,d)=>{var f=D(b,c);e(a).removeEventListener(f,e(d))}),arguments)};b.wbg.__wbg_log_79d3c56888567995=(a=>{console.log(e(a))});b.wbg.__wbg_warn_2a68e3ab54e55f28=(a=>{console.warn(e(a))});b.wbg.__wbg_classList_e98b57addeeb384e=(a=>{const b=e(a).classList;return d(b)});b.wbg.__wbg_createTextNode_ea32ad2506f7ae78=((a,b,c)=>{var f=D(b,c);const g=e(a).createTextNode(f);return d(g)});b.wbg.__wbg_search_6b70a3bf2ceb3f63=((b,c)=>{const d=e(c).search;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_searchParams_d1d6990d2adb9a23=(a=>{const b=e(a).searchParams;return d(b)});b.wbg.__wbg_hash_6169ffe1f1446fd4=((b,c)=>{const d=e(c).hash;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_getElementById_77f2dfdddee12e05=((a,b,c)=>{var f=D(b,c);const g=e(a).getElementById(f);return l(g)?a0:d(g)});b.wbg.__wbg_scrollIntoView_68275288fdd93eff=(a=>{e(a).scrollIntoView()});b.wbg.__wbg_scrollTo_d3f0a8157bc0964a=((a,b,c)=>{e(a).scrollTo(b,c)});b.wbg.__wbg_href_14a0154147810c9c=((b,c)=>{const d=e(c).href;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_sethref_5f2e449a509e644b=function(){return E(((a,b,c)=>{var d=D(b,c);e(a).href=d}),arguments)};b.wbg.__wbg_defaultPrevented_f985e9e1fcb557ed=(a=>{const b=e(a).defaultPrevented;return b});b.wbg.__wbg_button_43d11b000a7126cf=(a=>{const b=e(a).button;return b});b.wbg.__wbg_metaKey_35f1fd33c4e0c5df=(a=>{const b=e(a).metaKey;return b});b.wbg.__wbg_altKey_d4801ef04e1f1e33=(a=>{const b=e(a).altKey;return b});b.wbg.__wbg_ctrlKey_2817108375a63e7c=(a=>{const b=e(a).ctrlKey;return b});b.wbg.__wbg_shiftKey_87d2a9527cefdf3d=(a=>{const b=e(a).shiftKey;return b});b.wbg.__wbg_href_32f69263c7029db6=((b,c)=>{const d=e(c).href;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_target_d86ce47fcec86e65=((b,c)=>{const d=e(c).target;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_getAttribute_706ae88bd37410fa=((b,c,d,f)=>{var g=D(d,f);const h=e(c).getAttribute(g);var i=l(h)?a0:t(h,a.__wbindgen_export_0,a.__wbindgen_export_1);var j=q;p()[b/aa+ Y]=j;p()[b/aa+ a0]=i});b.wbg.__wbg_preventDefault_657cbf753df1396c=(a=>{e(a).preventDefault()});b.wbg.__wbg_instanceof_HtmlAnchorElement_9b05407929158ee7=(a=>{let b;try{b=e(a) instanceof HTMLAnchorElement}catch(a){b=!1}const c=b;return c});b.wbg.__wbg_pushState_01f73865f6d8789a=function(){return E(((a,b,c,d,f,g)=>{var h=D(c,d);var i=D(f,g);e(a).pushState(e(b),h,i)}),arguments)};b.wbg.__wbg_replaceState_05b49e34dd5c56f9=function(){return E(((a,b,c,d,f,g)=>{var h=D(c,d);var i=D(f,g);e(a).replaceState(e(b),h,i)}),arguments)};b.wbg.__wbg_state_dce1712758f75ed1=function(){return E((a=>{const b=e(a).state;return d(b)}),arguments)};b.wbg.__wbg_pathname_d98d0a003b664ef0=function(){return E(((b,c)=>{const d=e(c).pathname;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f}),arguments)};b.wbg.__wbg_search_40927d5af164fdfe=function(){return E(((b,c)=>{const d=e(c).search;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f}),arguments)};b.wbg.__wbg_objectStoreNames_2ecdd48caeba004f=(a=>{const b=e(a).objectStoreNames;return d(b)});b.wbg.__wbg_length_f4c93968efbcbe64=(a=>{const b=e(a).length;return b});b.wbg.__wbg_deleteObjectStore_a858b88892001cfb=function(){return E(((a,b,c)=>{var d=D(b,c);e(a).deleteObjectStore(d)}),arguments)};b.wbg.__wbg_createObjectStore_b94c8c593fd6d249=function(){return E(((a,b,c,f)=>{var g=D(b,c);const h=e(a).createObjectStore(g,e(f));return d(h)}),arguments)};b.wbg.__wbg_transaction_75ade65c1c881217=(a=>{const b=e(a).transaction;return l(b)?a0:d(b)});b.wbg.__wbg_indexNames_8bd628ce8dc4bc30=(a=>{const b=e(a).indexNames;return d(b)});b.wbg.__wbg_deleteIndex_99e3acff010af182=function(){return E(((a,b,c)=>{var d=D(b,c);e(a).deleteIndex(d)}),arguments)};b.wbg.__wbg_createIndex_2b4d8db40f62b4a6=function(){return E(((a,b,c,f,g)=>{var h=D(b,c);const i=e(a).createIndex(h,e(f),e(g));return d(i)}),arguments)};b.wbg.__wbg_error_180ee1f6d813554e=function(){return E((a=>{const b=e(a).error;return l(b)?a0:d(b)}),arguments)};b.wbg.__wbg_toString_07f01913ec9af122=(a=>{const b=e(a).toString();return d(b)});b.wbg.__wbindgen_jsval_loose_eq=((a,b)=>{const c=e(a)==e(b);return c});b.wbg.__wbg_instanceof_Uint8Array_c299a4ee232e76ba=(a=>{let b;try{b=e(a) instanceof a1}catch(a){b=!1}const c=b;return c});b.wbg.__wbg_instanceof_ArrayBuffer_9221fa854ffb71b5=(a=>{let b;try{b=e(a) instanceof ArrayBuffer}catch(a){b=!1}const c=b;return c});b.wbg.__wbindgen_bigint_get_as_i64=((a,b)=>{const c=e(b);const d=typeof c===ac?c:W;v()[a/ad+ Y]=l(d)?af(a0):d;p()[a/aa+ a0]=!l(d)});b.wbg.__wbindgen_debug_string=((b,c)=>{const d=w(e(c));const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbindgen_throw=((a,b)=>{throw new $(k(a,b))});b.wbg.__wbg_then_f9e58f5a50f43eae=((a,b)=>{const c=e(a).then(e(b));return d(c)});b.wbg.__wbg_queueMicrotask_f61ee94ee663068b=(a=>{queueMicrotask(e(a))});b.wbg.__wbg_then_20a5920e447d1cb1=((a,b,c)=>{const f=e(a).then(e(b),e(c));return d(f)});b.wbg.__wbg_queueMicrotask_f82fc5d1e8f816ae=(a=>{const b=e(a).queueMicrotask;return d(b)});b.wbg.__wbg_resolve_5da6faf2c96fd1d5=(a=>{const b=ah.resolve(e(a));return d(b)});b.wbg.__wbg_close_23aa806471e38253=function(){return E((a=>{e(a).close()}),arguments)};b.wbg.__wbg_enqueue_fe9e340e2bc8714b=function(){return E(((a,b)=>{e(a).enqueue(e(b))}),arguments)};b.wbg.__wbg_byobRequest_643426f0037311f0=(a=>{const b=e(a).byobRequest;return l(b)?a0:d(b)});b.wbg.__wbg_view_38a0bacb59ad00ee=(a=>{const b=e(a).view;return l(b)?a0:d(b)});b.wbg.__wbg_byteLength_4f4b58172d990c0a=(a=>{const b=e(a).byteLength;return b});b.wbg.__wbg_close_0b618a762cdb578b=function(){return E((a=>{e(a).close()}),arguments)};b.wbg.__wbg_new_73a5987615ec8862=((a,b)=>{var c=D(a,b);const e=new $(c);return d(e)});b.wbg.__wbg_buffer_67e624f5a0ab2319=(a=>{const b=e(a).buffer;return d(b)});b.wbg.__wbg_byteOffset_adbd2a554609eb4e=(a=>{const b=e(a).byteOffset;return b});b.wbg.__wbg_instanceof_Window_cee7a886d55e7df5=(a=>{let b;try{b=e(a) instanceof Window}catch(a){b=!1}const c=b;return c});b.wbg.__wbg_body_874ccb42daaab363=(a=>{const b=e(a).body;return l(b)?a0:d(b)});b.wbg.__wbg_createElement_03cf347ddad1c8c0=function(){return E(((a,b,c)=>{var f=D(b,c);const g=e(a).createElement(f);return d(g)}),arguments)};b.wbg.__wbg_createElementNS_93f8de4acdef6da8=function(){return E(((a,b,c,f,g)=>{var h=D(b,c);var i=D(f,g);const j=e(a).createElementNS(h,i);return d(j)}),arguments)};b.wbg.__wbg_append_125fff38dadbc15f=function(){return E(((a,b)=>{e(a).append(e(b))}),arguments)};b.wbg.__wbg_contains_387aaee89de6826b=((a,b,c)=>{var d=D(b,c);const f=e(a).contains(d);return f});b.wbg.__wbg_get_de1356a147af67e3=((b,c,d)=>{const f=e(c)[d>>>a0];var g=l(f)?a0:t(f,a.__wbindgen_export_0,a.__wbindgen_export_1);var h=q;p()[b/aa+ Y]=h;p()[b/aa+ a0]=g});b.wbg.__wbg_setinnerHTML_95222f1a2e797983=((a,b,c)=>{var d=D(b,c);e(a).innerHTML=d});b.wbg.__wbg_hasAttribute_e0b4c51b50660221=((a,b,c)=>{var d=D(b,c);const f=e(a).hasAttribute(d);return f});b.wbg.__wbg_removeAttribute_0c021c98a4dc7402=function(){return E(((a,b,c)=>{var d=D(b,c);e(a).removeAttribute(d)}),arguments)};b.wbg.__wbg_setAttribute_f7ffa687ef977957=function(){return E(((a,b,c,d,f)=>{var g=D(b,c);var h=D(d,f);e(a).setAttribute(g,h)}),arguments)};b.wbg.__wbg_before_6ea6598a4cb72792=function(){return E(((a,b)=>{e(a).before(e(b))}),arguments)};b.wbg.__wbg_target_6795373f170fd786=(a=>{const b=e(a).target;return l(b)?a0:d(b)});b.wbg.__wbg_addEventListener_f984e99465a6a7f4=function(){return E(((a,b,c,d)=>{var f=D(b,c);e(a).addEventListener(f,e(d))}),arguments)};b.wbg.__wbg_transaction_b46588e9ee3c2219=function(){return E(((a,b,c)=>{const f=e(a).transaction(e(b),g(c));return d(f)}),arguments)};b.wbg.__wbg_result_43ea35e72f0fa7c7=function(){return E((a=>{const b=e(a).result;return d(b)}),arguments)};b.wbg.__wbg_objectStore_402a3923882f9f3f=function(){return E(((a,b,c)=>{var f=D(b,c);const g=e(a).objectStore(f);return d(g)}),arguments)};b.wbg.__wbg_origin_305402044aa148ce=function(){return E(((b,c)=>{const d=e(c).origin;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f}),arguments)};b.wbg.__wbg_hash_163703b5971e593c=function(){return E(((b,c)=>{const d=e(c).hash;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f}),arguments)};b.wbg.__wbg_parentNode_e3a5ee563364a613=(a=>{const b=e(a).parentNode;return l(b)?a0:d(b)});b.wbg.__wbg_previousSibling_28df8137ae6104f8=(a=>{const b=e(a).previousSibling;return l(b)?a0:d(b)});b.wbg.__wbg_nextSibling_87d2b32dfbf09fe3=(a=>{const b=e(a).nextSibling;return l(b)?a0:d(b)});b.wbg.__wbg_appendChild_4153ba1b5d54d73b=function(){return E(((a,b)=>{const c=e(a).appendChild(e(b));return d(c)}),arguments)};b.wbg.__wbg_cloneNode_ea49a704f0699b2e=function(){return E((a=>{const b=e(a).cloneNode();return d(b)}),arguments)};b.wbg.__wbg_respond_fee44bba73c2fc8a=function(){return E(((a,b)=>{e(a).respond(b>>>a0)}),arguments)};b.wbg.__wbg_getItem_5c179cd36e9529e8=function(){return E(((b,c,d,f)=>{var g=D(d,f);const h=e(c).getItem(g);var i=l(h)?a0:t(h,a.__wbindgen_export_0,a.__wbindgen_export_1);var j=q;p()[b/aa+ Y]=j;p()[b/aa+ a0]=i}),arguments)};b.wbg.__wbg_origin_ecca884a2f9bd239=((b,c)=>{const d=e(c).origin;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_pathname_3bec400c9c042d62=((b,c)=>{const d=e(c).pathname;const f=t(d,a.__wbindgen_export_0,a.__wbindgen_export_1);const g=q;p()[b/aa+ Y]=g;p()[b/aa+ a0]=f});b.wbg.__wbg_newwithbase_98813076a95cdc23=function(){return E(((a,b,c,e)=>{var f=D(a,b);var g=D(c,e);const h=new URL(f,g);return d(h)}),arguments)};b.wbg.__wbg_history_6882f83324841599=function(){return E((a=>{const b=e(a).history;return d(b)}),arguments)};b.wbg.__wbindgen_closure_wrapper550=((a,b,c)=>{const e=x(a,b,ai,y);return d(e)});b.wbg.__wbindgen_closure_wrapper995=((a,b,c)=>{const e=x(a,b,aj,z);return d(e)});b.wbg.__wbindgen_closure_wrapper1087=((a,b,c)=>{const e=x(a,b,117,z);return d(e)});b.wbg.__wbindgen_closure_wrapper1753=((a,b,c)=>{const e=x(a,b,aj,A);return d(e)});b.wbg.__wbindgen_closure_wrapper2066=((a,b,c)=>{const e=B(a,b,aj,C);return d(e)});b.wbg.__wbindgen_closure_wrapper3658=((a,b,c)=>{const e=x(a,b,ai,z);return d(e)});return b});function E(b,c){try{return b.apply(this,c)}catch(b){a.__wbindgen_export_8(d(b))}}var D=((a,b)=>{if(a===a0){return e(b)}else{return k(a,b)}});var P=(async(a,b)=>{if(typeof Response===a2&&a instanceof Response){if(typeof WebAssembly.instantiateStreaming===a2){try{return await WebAssembly.instantiateStreaming(a,b)}catch(b){if(a.headers.get(`Content-Type`)!=`application/wasm`){console.warn(`\`WebAssembly.instantiateStreaming\` failed because your server does not serve wasm with \`application/wasm\` MIME type. Falling back to \`WebAssembly.instantiate\` which is slower. Original error:\\n`,b)}else{throw b}}};const c=await a.arrayBuffer();return await WebAssembly.instantiate(c,b)}else{const c=await WebAssembly.instantiate(a,b);if(c instanceof WebAssembly.Instance){return {instance:c,module:a}}else{return c}}});var p=(()=>{if(o===X||o.byteLength===a0){o=new Int32Array(a.memory.buffer)};return o});var l=(a=>a===W||a===X);var e=(a=>b[a]);var L=((b,c,e,f)=>{a.__wbindgen_export_9(b,c,d(e),d(f))});var v=(()=>{if(u===X||u.byteLength===a0){u=new BigInt64Array(a.memory.buffer)};return u});var B=((b,c,d,e)=>{const f={a:b,b:c,cnt:Y,dtor:d};const g=(...b)=>{f.cnt++;try{return e(f.a,f.b,...b)}finally{if(--f.cnt===a0){a.__wbindgen_export_2.get(f.dtor)(f.a,f.b);f.a=a0}}};g.original=f;return g});var n=(()=>{if(m===X||m.byteLength===a0){m=new Float64Array(a.memory.buffer)};return m});var A=((b,c,e)=>{try{const i=a.__wbindgen_add_to_stack_pointer(-a9);a.__wbindgen_export_5(i,b,c,d(e));var f=p()[i/aa+ a0];var h=p()[i/aa+ Y];if(h){throw g(f)}}finally{a.__wbindgen_add_to_stack_pointer(a9)}});var f=(a=>{if(a<132)return;b[a]=c;c=a});var x=((b,c,d,e)=>{const f={a:b,b:c,cnt:Y,dtor:d};const g=(...b)=>{f.cnt++;const c=f.a;f.a=a0;try{return e(c,f.b,...b)}finally{if(--f.cnt===a0){a.__wbindgen_export_2.get(f.dtor)(c,f.b)}else{f.a=c}}};g.original=f;return g});var t=((a,b,c)=>{if(c===W){const c=r.encode(a);const d=b(c.length,Y)>>>a0;j().subarray(d,d+ c.length).set(c);q=c.length;return d};let d=a.length;let e=b(d,Y)>>>a0;const f=j();let g=a0;for(;g<d;g++){const b=a.charCodeAt(g);if(b>127)break;f[e+ g]=b};if(g!==d){if(g!==a0){a=a.slice(g)};e=c(e,d,d=g+ a.length*3,Y)>>>a0;const b=j().subarray(e+ g,e+ d);const f=s(a,b);g+=f.written};q=g;return e});var j=(()=>{if(i===X||i.byteLength===a0){i=new a1(a.memory.buffer)};return i});var k=((a,b)=>{a=a>>>a0;return h.decode(j().subarray(a,a+ b))});var C=((b,c)=>{a.__wbindgen_export_6(b,c)});let a;const b=new V(128).fill(W);b.push(W,X,!0,!1);let c=b.length;const h=typeof TextDecoder!==Z?new TextDecoder(_,{ignoreBOM:!0,fatal:!0}):{decode:()=>{throw $(`TextDecoder not available`)}};if(typeof TextDecoder!==Z){h.decode()};let i=X;let m=X;let o=X;let q=a0;const r=typeof TextEncoder!==Z?new TextEncoder(_):{encode:()=>{throw $(`TextEncoder not available`)}};const s=typeof r.encodeInto===a2?((a,b)=>r.encodeInto(a,b)):((a,b)=>{const c=r.encode(a);b.set(c);return {read:a.length,written:c.length}});let u=X;function F(b){const c=t(b,a.__wbindgen_export_0,a.__wbindgen_export_1);const d=q;const e=a.set_outer_messages_async(c,d);return g(e)}function G(b){const c=t(b,a.__wbindgen_export_0,a.__wbindgen_export_1);const d=q;const e=a.set_inner_messages_async(c,d);return g(e)}function H(b){try{const f=a.__wbindgen_add_to_stack_pointer(-a9);const h=t(b,a.__wbindgen_export_0,a.__wbindgen_export_1);const i=q;a.set_outer_messages(f,h,i);var c=p()[f/aa+ a0];var d=p()[f/aa+ Y];var e=p()[f/aa+ ab];if(e){throw g(d)};return g(c)}finally{a.__wbindgen_add_to_stack_pointer(a9)}}function I(b){try{const f=a.__wbindgen_add_to_stack_pointer(-a9);const h=t(b,a.__wbindgen_export_0,a.__wbindgen_export_1);const i=q;a.set_inner_messages(f,h,i);var c=p()[f/aa+ a0];var d=p()[f/aa+ Y];var e=p()[f/aa+ ab];if(e){throw g(d)};return g(c)}finally{a.__wbindgen_add_to_stack_pointer(a9)}}function J(b){const c=t(b,a.__wbindgen_export_0,a.__wbindgen_export_1);const d=q;const e=a.set_outer_messages_state(c,d);return g(e)}function K(b){const c=t(b,a.__wbindgen_export_0,a.__wbindgen_export_1);const d=q;const e=a.set_inner_messages_state(c,d);return g(e)}class M{__destroy_into_raw(){const a=this.__wbg_ptr;this.__wbg_ptr=a0;return a}free(){const b=this.__destroy_into_raw();a.__wbg_intounderlyingbytesource_free(b)}type(){try{const e=a.__wbindgen_add_to_stack_pointer(-a9);a.intounderlyingbytesource_type(e,this.__wbg_ptr);var b=p()[e/aa+ a0];var c=p()[e/aa+ Y];var d=D(b,c);if(b!==a0){a.__wbindgen_export_7(b,c,Y)};return d}finally{a.__wbindgen_add_to_stack_pointer(a9)}}autoAllocateChunkSize(){const b=a.intounderlyingbytesource_autoAllocateChunkSize(this.__wbg_ptr);return b>>>a0}start(b){a.intounderlyingbytesource_start(this.__wbg_ptr,d(b))}pull(b){const c=a.intounderlyingbytesource_pull(this.__wbg_ptr,d(b));return g(c)}cancel(){const b=this.__destroy_into_raw();a.intounderlyingbytesource_cancel(b)}}class N{__destroy_into_raw(){const a=this.__wbg_ptr;this.__wbg_ptr=a0;return a}free(){const b=this.__destroy_into_raw();a.__wbg_intounderlyingsink_free(b)}write(b){const c=a.intounderlyingsink_write(this.__wbg_ptr,d(b));return g(c)}close(){const b=this.__destroy_into_raw();const c=a.intounderlyingsink_close(b);return g(c)}abort(b){const c=this.__destroy_into_raw();const e=a.intounderlyingsink_abort(c,d(b));return g(e)}}class O{__destroy_into_raw(){const a=this.__wbg_ptr;this.__wbg_ptr=a0;return a}free(){const b=this.__destroy_into_raw();a.__wbg_intounderlyingsource_free(b)}pull(b){const c=a.intounderlyingsource_pull(this.__wbg_ptr,d(b));return g(c)}cancel(){const b=this.__destroy_into_raw();a.intounderlyingsource_cancel(b)}}export default U;export{F as set_outer_messages_async,G as set_inner_messages_async,H as set_outer_messages,I as set_inner_messages,J as set_outer_messages_state,K as set_inner_messages_state,M as IntoUnderlyingByteSource,N as IntoUnderlyingSink,O as IntoUnderlyingSource,T as initSync}