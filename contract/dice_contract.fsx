#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::store::vec::Vector<$0>")>]
#endif
type near_sdk_store_vec_Vector<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_token::NearToken")>]
#endif
type near_token_NearToken = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::AccountId")>]
#endif
type near_sdk_AccountId = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("u128")>]
#endif
type u128 = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US3
    | US4_1 of f1_0 : US3
    | US4_2 of f2_0 : US3
    | US4_3 of f3_0 : US3
    | US4_4 of f4_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
and UH0 =
    | UH0_0
    | UH0_1 of uint8 * UH0
and UH1 =
    | UH1_0 of uint8 * (unit -> UH1)
    | UH1_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : (unit -> UH1)
    | US6_1 of f1_0 : UH1
and Mut5 = {mutable l0 : US6}
and [<Struct>] US7 =
    | US7_0 of f0_0 : uint8
    | US7_1
and Mut6 = {mutable l0 : US7}
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint64 * f0_1 : UH0
    | US8_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : uint64
    | US9_1
let rec method4 (v0 : string) : string =
    v0
and method5 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US5 =
    US5_0(v0)
and method6 () : (string -> US5) =
    closure3()
and method3 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method4(v0)
    let v3 : string = "std::env::var(&*$0)"
    let v4 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "x"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "fable_library_rust::String_::fromString($0)"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "true; $0 })"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "_result_map_"
    let v14 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = method5()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let _v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US3 = US3_1
    let v19 : US4 = US4_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US3 = US3_2
    let v23 : US4 = US4_2(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "process.env[$0] ?? \"\""
    let v27 : string = Fable.Core.JsInterop.emitJsExpr v0 v26 
    let _v1 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : string = "os"
    let v29 : IOsEnviron = Fable.Core.PyInterop.importAll v28 
    let v30 : string = "v29.environ"
    let v31 : obj = Fable.Core.PyInterop.emitPyExpr () v30 
    let v34 : string = "v31.get($0)"
    let v35 : string = Fable.Core.PyInterop.emitPyExpr v0 v34 
    let mutable _v35 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v38 : (string -> string option) = Option.ofObj
    let v39 : string option = v38 v35
    v39 
    #else
    Some v35 
    #endif
    |> fun x -> _v35 <- Some x
    let v40 : string option = match _v35 with Some x -> x | None -> failwith "optionm'.of_obj / _v35=None"
    let v43 : (string -> US5) = method6()
    let v44 : US5 option = v40 |> Option.map v43 
    let v55 : US5 = US5_1
    let v56 : US5 = v44 |> Option.defaultValue v55 
    let v63 : string =
        match v56 with
        | US5_1 -> (* None *)
            let v61 : string = ""
            v61
        | US5_0(v60) -> (* Some *)
            v60
    let _v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US3 = US3_1
    let v65 : US4 = US4_0(v64)
    let v66 : string = $"env.get_environment_variable / target: {v65} / var: {v0}"
    let v67 : string = failwith<string> v66
    let _v1 = v67 
    #endif
#else
    let v68 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v69 : string = v68 v0
    let mutable _v69 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v70 : (string -> string option) = Option.ofObj
    let v71 : string option = v70 v69
    v71 
    #else
    Some v69 
    #endif
    |> fun x -> _v69 <- Some x
    let v72 : string option = match _v69 with Some x -> x | None -> failwith "optionm'.of_obj / _v69=None"
    let v75 : (string -> US5) = method6()
    let v76 : US5 option = v72 |> Option.map v75 
    let v87 : US5 = US5_1
    let v88 : US5 = v76 |> Option.defaultValue v87 
    let v95 : string =
        match v88 with
        | US5_1 -> (* None *)
            let v93 : string = ""
            v93
        | US5_0(v92) -> (* Some *)
            v92
    let _v1 = v95 
    #endif
    let v96 : string = _v1 
    v96
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US1 =
        if v2 then
            let v3 : US0 = US0_0
            US1_0(v3)
        else
            US1_1
    let v47 : US1 =
        match v6 with
        | US1_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US1 =
                if v9 then
                    let v10 : US0 = US0_1
                    US1_0(v10)
                else
                    US1_1
            match v13 with
            | US1_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US1 =
                    if v16 then
                        let v17 : US0 = US0_2
                        US1_0(v17)
                    else
                        US1_1
                match v20 with
                | US1_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US1 =
                        if v23 then
                            let v24 : US0 = US0_3
                            US1_0(v24)
                        else
                            US1_1
                    match v27 with
                    | US1_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US1 =
                            if v30 then
                                let v31 : US0 = US0_4
                                US1_0(v31)
                            else
                                US1_1
                        match v34 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v35) -> (* Some *)
                            US1_0(v35)
                    | US1_0(v28) -> (* Some *)
                        US1_0(v28)
                | US1_0(v21) -> (* Some *)
                    US1_0(v21)
            | US1_0(v14) -> (* Some *)
                US1_0(v14)
        | US1_0(v7) -> (* Some *)
            US1_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method3(v48)
    let v50 : string = "True"
    let v51 : bool = v49 <> v50 
    let v107 : US2 =
        if v51 then
            US2_1
        else
            let v55 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : System.DateTime = System.DateTime.Now
            let _v55 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : System.DateTime = System.DateTime.Now
            let _v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : System.DateTime = null |> unbox<System.DateTime>
            let _v55 = v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : System.DateTime = System.DateTime.Now
            let _v55 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : System.DateTime = System.DateTime.Now
            let _v55 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : System.DateTime = System.DateTime.Now
            let _v55 = v63 
            #endif
#else
            let v64 : System.DateTime = System.DateTime.Now
            let _v55 = v64 
            #endif
            let v65 : System.DateTime = _v55 
            let v70 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : (System.DateTime -> int64) = _.Ticks
            let v72 : int64 = v71 v65
            let _v70 = v72 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73 : (System.DateTime -> int64) = _.Ticks
            let v74 : int64 = v73 v65
            let _v70 = v74 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : int64 = null |> unbox<int64>
            let _v70 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : (System.DateTime -> int64) = _.Ticks
            let v79 : int64 = v78 v65
            let _v70 = v79 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80 : (System.DateTime -> int64) = _.Ticks
            let v81 : int64 = v80 v65
            let _v70 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : (System.DateTime -> int64) = _.Ticks
            let v83 : int64 = v82 v65
            let _v70 = v83 
            #endif
#else
            let v84 : (System.DateTime -> int64) = _.Ticks
            let v85 : int64 = v84 v65
            let _v70 = v85 
            #endif
            let v86 : int64 = _v70 
            let v103 : int64 = v86 |> int64 
            US2_0(v103)
    struct (v47, v107)
and closure4 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US1, v3 : US2) = method2()
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US1 = US1_1
    let v5 : US2 = US2_1
    let _v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v23 
    #endif
#else
    let v26 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v26 
    #endif
    let v29 : std_string_String = _v10 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v29 v34 
    let _v7 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39 
    let _v38 = v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41 
    let _v38 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43 
    let _v38 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v48 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v51 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v51 
    #endif
#else
    let v54 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v54 
    #endif
    let v57 : std_string_String = _v38 
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v57 v62 
    let _v7 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "String::from($0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v69 
    let _v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = "String::from($0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v79 
    #endif
#else
    let v82 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v82 
    #endif
    let v85 : std_string_String = _v66 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v7 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : string = null |> unbox<string>
    let _v7 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : string = null |> unbox<string>
    let _v7 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    let _v7 = v98 
    #endif
#else
    let v101 : string = null |> unbox<string>
    let _v7 = v101 
    #endif
    let v104 : string = _v7 
    let v109 : string = "True"
    let v110 : bool = v104 <> v109 
    let v121 : US2 =
        if v110 then
            US2_1
        else
            let v114 : string = $"near_sdk::env::block_timestamp()"
            let v115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : (uint64 -> int64) = int64
            let v117 : int64 = v116 v115
            US2_0(v117)
    let v122 : US1 = US1_1
    let _v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US1, v124 : US2) = method2()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US1, v126 : US2) = method2()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US1, v128 : US2) = method2()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US1, v130 : US2) = method2()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US1, v132 : US2) = _v1 
    let v137 : Mut0 = {l0 = 1L} : Mut0
    let v138 : (string -> unit) = closure4()
    let v139 : Mut1 = {l0 = v138} : Mut1
    let v140 : Mut2 = {l0 = true} : Mut2
    let v141 : string = ""
    let v142 : Mut3 = {l0 = v141} : Mut3
    let v145 : US0 =
        match v131 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v143) -> (* Some *)
            v143
    let v146 : Mut4 = {l0 = v145} : Mut4
    let v153 : int64 option =
        match v132 with
        | US2_1 -> (* None *)
            let v151 : int64 option = None
            v151
        | US2_0(v147) -> (* Some *)
            let v148 : int64 option = Some v147 
            v148
    struct (v137, v139, v140, v142, v146, v153)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method0 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
and closure5 () (v0 : int64) : US2 =
    US2_0(v0)
and method8 () : (int64 -> US2) =
    closure5()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method8()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v117 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            let v101 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v102 : System.DateTime = System.DateTime.Now
            let _v101 = v102 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v103 : System.DateTime = System.DateTime.Now
            let _v101 = v103 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104 : System.DateTime = null |> unbox<System.DateTime>
            let _v101 = v104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107 : System.DateTime = System.DateTime.Now
            let _v101 = v107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v101 = v108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v109 : System.DateTime = System.DateTime.Now
            let _v101 = v109 
            #endif
#else
            let v110 : System.DateTime = System.DateTime.Now
            let _v101 = v110 
            #endif
            let v111 : System.DateTime = _v101 
            v111
        | US2_0(v24) -> (* Some *)
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : System.DateTime = System.DateTime.Now
            let _v25 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : System.DateTime = System.DateTime.Now
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : System.DateTime = null |> unbox<System.DateTime>
            let _v25 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : System.DateTime = System.DateTime.Now
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : System.DateTime = System.DateTime.Now
            let _v25 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System.DateTime = System.DateTime.Now
            let _v25 = v33 
            #endif
#else
            let v34 : System.DateTime = System.DateTime.Now
            let _v25 = v34 
            #endif
            let v35 : System.DateTime = _v25 
            let v40 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v35
            let _v40 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v35
            let _v40 = v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : int64 = null |> unbox<int64>
            let _v40 = v45 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v35
            let _v40 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : (System.DateTime -> int64) = _.Ticks
            let v51 : int64 = v50 v35
            let _v40 = v51 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52 : (System.DateTime -> int64) = _.Ticks
            let v53 : int64 = v52 v35
            let _v40 = v53 
            #endif
#else
            let v54 : (System.DateTime -> int64) = _.Ticks
            let v55 : int64 = v54 v35
            let _v40 = v55 
            #endif
            let v56 : int64 = _v40 
            let v73 : int64 = v56 |> int64 
            let v76 : int64 = v73 - v24
            let v77 : System.TimeSpan = v76 |> System.TimeSpan 
            let v82 : (System.TimeSpan -> int32) = _.Hours
            let v83 : int32 = v82 v77
            let v86 : (System.TimeSpan -> int32) = _.Minutes
            let v87 : int32 = v86 v77
            let v90 : (System.TimeSpan -> int32) = _.Seconds
            let v91 : int32 = v90 v77
            let v94 : (System.TimeSpan -> int32) = _.Milliseconds
            let v95 : int32 = v94 v77
            let v98 : System.DateTime = System.DateTime (1, 1, 1, v83, v87, v91, v95)
            v98
    let v118 : string = method9()
    let v121 : bool = v118 = ""
    let v123 : string =
        if v121 then
            let v122 : string = "M-d-y hh:mm:ss tt"
            v122
        else
            v118
    let v124 : (string -> string) = v117.ToString
    let v125 : string = v124 v123
    let _v6 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : (int64 -> US2) = method8()
    let v140 : US2 option = v5 |> Option.map v139 
    let v151 : US2 = US2_1
    let v152 : US2 = v140 |> Option.defaultValue v151 
    let v249 : System.DateTime =
        match v152 with
        | US2_1 -> (* None *)
            let v233 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : System.DateTime = System.DateTime.Now
            let _v233 = v234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235 : System.DateTime = System.DateTime.Now
            let _v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : System.DateTime = null |> unbox<System.DateTime>
            let _v233 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v239 : System.DateTime = System.DateTime.Now
            let _v233 = v239 
            #endif
#if FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _v233 = v240 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : System.DateTime = System.DateTime.Now
            let _v233 = v241 
            #endif
#else
            let v242 : System.DateTime = System.DateTime.Now
            let _v233 = v242 
            #endif
            let v243 : System.DateTime = _v233 
            v243
        | US2_0(v156) -> (* Some *)
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : System.DateTime = System.DateTime.Now
            let _v157 = v158 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v159 : System.DateTime = System.DateTime.Now
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v160 : System.DateTime = null |> unbox<System.DateTime>
            let _v157 = v160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : System.DateTime = System.DateTime.Now
            let _v157 = v163 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : System.DateTime = System.DateTime.Now
            let _v157 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165 : System.DateTime = System.DateTime.Now
            let _v157 = v165 
            #endif
#else
            let v166 : System.DateTime = System.DateTime.Now
            let _v157 = v166 
            #endif
            let v167 : System.DateTime = _v157 
            let v172 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v167
            let _v172 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v175 : (System.DateTime -> int64) = _.Ticks
            let v176 : int64 = v175 v167
            let _v172 = v176 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v177 : int64 = null |> unbox<int64>
            let _v172 = v177 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v167
            let _v172 = v181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v182 : (System.DateTime -> int64) = _.Ticks
            let v183 : int64 = v182 v167
            let _v172 = v183 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v184 : (System.DateTime -> int64) = _.Ticks
            let v185 : int64 = v184 v167
            let _v172 = v185 
            #endif
#else
            let v186 : (System.DateTime -> int64) = _.Ticks
            let v187 : int64 = v186 v167
            let _v172 = v187 
            #endif
            let v188 : int64 = _v172 
            let v205 : int64 = v188 |> int64 
            let v208 : int64 = v205 - v156
            let v209 : System.TimeSpan = v208 |> System.TimeSpan 
            let v214 : (System.TimeSpan -> int32) = _.Hours
            let v215 : int32 = v214 v209
            let v218 : (System.TimeSpan -> int32) = _.Minutes
            let v219 : int32 = v218 v209
            let v222 : (System.TimeSpan -> int32) = _.Seconds
            let v223 : int32 = v222 v209
            let v226 : (System.TimeSpan -> int32) = _.Milliseconds
            let v227 : int32 = v226 v209
            let v230 : System.DateTime = System.DateTime (1, 1, 1, v215, v219, v223, v227)
            v230
    let v250 : string = method9()
    let v253 : bool = v250 = ""
    let v255 : string =
        if v253 then
            let v254 : string = "M-d-y hh:mm:ss tt"
            v254
        else
            v250
    let v256 : (string -> string) = v249.ToString
    let v257 : string = v256 v255
    let _v6 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = $"near_sdk::env::block_timestamp()"
    let v272 : uint64 = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : (int64 -> US2) = method8()
    let v274 : US2 option = v5 |> Option.map v273 
    let v285 : US2 = US2_1
    let v286 : US2 = v274 |> Option.defaultValue v285 
    let v297 : uint64 =
        match v286 with
        | US2_1 -> (* None *)
            v272
        | US2_0(v290) -> (* Some *)
            let v291 : (int64 -> uint64) = uint64
            let v292 : uint64 = v291 v290
            let v295 : uint64 = v272 - v292
            v295
    let v298 : uint64 = v297 / 1000000000UL
    let v299 : uint64 = v298 % 60UL
    let v300 : uint64 = v298 / 60UL
    let v301 : uint64 = v300 % 60UL
    let v302 : uint64 = v298 / 3600UL
    let v303 : uint64 = v302 % 24UL
    let v304 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v305 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v303, v301, v299) v304 
    let v306 : string = "fable_library_rust::String_::fromString($0)"
    let v307 : string = Fable.Core.RustInterop.emitRustExpr v305 v306 
    let _v6 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : (int64 -> US2) = method8()
    let v309 : US2 option = v5 |> Option.map v308 
    let v320 : US2 = US2_1
    let v321 : US2 = v309 |> Option.defaultValue v320 
    let v418 : System.DateTime =
        match v321 with
        | US2_1 -> (* None *)
            let v402 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : System.DateTime = System.DateTime.Now
            let _v402 = v403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : System.DateTime = System.DateTime.Now
            let _v402 = v404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v405 : System.DateTime = null |> unbox<System.DateTime>
            let _v402 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : System.DateTime = System.DateTime.Now
            let _v402 = v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : System.DateTime = System.DateTime.Now
            let _v402 = v409 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v410 : System.DateTime = System.DateTime.Now
            let _v402 = v410 
            #endif
#else
            let v411 : System.DateTime = System.DateTime.Now
            let _v402 = v411 
            #endif
            let v412 : System.DateTime = _v402 
            v412
        | US2_0(v325) -> (* Some *)
            let v326 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v327 : System.DateTime = System.DateTime.Now
            let _v326 = v327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v328 : System.DateTime = System.DateTime.Now
            let _v326 = v328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : System.DateTime = null |> unbox<System.DateTime>
            let _v326 = v329 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v332 : System.DateTime = System.DateTime.Now
            let _v326 = v332 
            #endif
#if FABLE_COMPILER_PYTHON
            let v333 : System.DateTime = System.DateTime.Now
            let _v326 = v333 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v334 : System.DateTime = System.DateTime.Now
            let _v326 = v334 
            #endif
#else
            let v335 : System.DateTime = System.DateTime.Now
            let _v326 = v335 
            #endif
            let v336 : System.DateTime = _v326 
            let v341 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v342 : (System.DateTime -> int64) = _.Ticks
            let v343 : int64 = v342 v336
            let _v341 = v343 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v336
            let _v341 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v346 : int64 = null |> unbox<int64>
            let _v341 = v346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v349 : (System.DateTime -> int64) = _.Ticks
            let v350 : int64 = v349 v336
            let _v341 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : (System.DateTime -> int64) = _.Ticks
            let v352 : int64 = v351 v336
            let _v341 = v352 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v353 : (System.DateTime -> int64) = _.Ticks
            let v354 : int64 = v353 v336
            let _v341 = v354 
            #endif
#else
            let v355 : (System.DateTime -> int64) = _.Ticks
            let v356 : int64 = v355 v336
            let _v341 = v356 
            #endif
            let v357 : int64 = _v341 
            let v374 : int64 = v357 |> int64 
            let v377 : int64 = v374 - v325
            let v378 : System.TimeSpan = v377 |> System.TimeSpan 
            let v383 : (System.TimeSpan -> int32) = _.Hours
            let v384 : int32 = v383 v378
            let v387 : (System.TimeSpan -> int32) = _.Minutes
            let v388 : int32 = v387 v378
            let v391 : (System.TimeSpan -> int32) = _.Seconds
            let v392 : int32 = v391 v378
            let v395 : (System.TimeSpan -> int32) = _.Milliseconds
            let v396 : int32 = v395 v378
            let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
            v399
    let v419 : string = method10()
    let v422 : bool = v419 = ""
    let v424 : string =
        if v422 then
            let v423 : string = "M-d-y hh:mm:ss tt"
            v423
        else
            v419
    let v425 : (string -> string) = v418.ToString
    let v426 : string = v425 v424
    let _v6 = v426 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : (int64 -> US2) = method8()
    let v441 : US2 option = v5 |> Option.map v440 
    let v452 : US2 = US2_1
    let v453 : US2 = v441 |> Option.defaultValue v452 
    let v550 : System.DateTime =
        match v453 with
        | US2_1 -> (* None *)
            let v534 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v535 : System.DateTime = System.DateTime.Now
            let _v534 = v535 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v536 : System.DateTime = System.DateTime.Now
            let _v534 = v536 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v537 : System.DateTime = null |> unbox<System.DateTime>
            let _v534 = v537 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v540 : System.DateTime = System.DateTime.Now
            let _v534 = v540 
            #endif
#if FABLE_COMPILER_PYTHON
            let v541 : System.DateTime = System.DateTime.Now
            let _v534 = v541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v542 : System.DateTime = System.DateTime.Now
            let _v534 = v542 
            #endif
#else
            let v543 : System.DateTime = System.DateTime.Now
            let _v534 = v543 
            #endif
            let v544 : System.DateTime = _v534 
            v544
        | US2_0(v457) -> (* Some *)
            let v458 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : System.DateTime = System.DateTime.Now
            let _v458 = v459 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v460 : System.DateTime = System.DateTime.Now
            let _v458 = v460 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : System.DateTime = null |> unbox<System.DateTime>
            let _v458 = v461 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v464 : System.DateTime = System.DateTime.Now
            let _v458 = v464 
            #endif
#if FABLE_COMPILER_PYTHON
            let v465 : System.DateTime = System.DateTime.Now
            let _v458 = v465 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v466 : System.DateTime = System.DateTime.Now
            let _v458 = v466 
            #endif
#else
            let v467 : System.DateTime = System.DateTime.Now
            let _v458 = v467 
            #endif
            let v468 : System.DateTime = _v458 
            let v473 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : (System.DateTime -> int64) = _.Ticks
            let v475 : int64 = v474 v468
            let _v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : (System.DateTime -> int64) = _.Ticks
            let v477 : int64 = v476 v468
            let _v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : int64 = null |> unbox<int64>
            let _v473 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : (System.DateTime -> int64) = _.Ticks
            let v482 : int64 = v481 v468
            let _v473 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v483 : (System.DateTime -> int64) = _.Ticks
            let v484 : int64 = v483 v468
            let _v473 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v485 : (System.DateTime -> int64) = _.Ticks
            let v486 : int64 = v485 v468
            let _v473 = v486 
            #endif
#else
            let v487 : (System.DateTime -> int64) = _.Ticks
            let v488 : int64 = v487 v468
            let _v473 = v488 
            #endif
            let v489 : int64 = _v473 
            let v506 : int64 = v489 |> int64 
            let v509 : int64 = v506 - v457
            let v510 : System.TimeSpan = v509 |> System.TimeSpan 
            let v515 : (System.TimeSpan -> int32) = _.Hours
            let v516 : int32 = v515 v510
            let v519 : (System.TimeSpan -> int32) = _.Minutes
            let v520 : int32 = v519 v510
            let v523 : (System.TimeSpan -> int32) = _.Seconds
            let v524 : int32 = v523 v510
            let v527 : (System.TimeSpan -> int32) = _.Milliseconds
            let v528 : int32 = v527 v510
            let v531 : System.DateTime = System.DateTime (1, 1, 1, v516, v520, v524, v528)
            v531
    let v551 : string = method10()
    let v554 : bool = v551 = ""
    let v556 : string =
        if v554 then
            let v555 : string = "M-d-y hh:mm:ss tt"
            v555
        else
            v551
    let v557 : (string -> string) = v550.ToString
    let v558 : string = v557 v556
    let _v6 = v558 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v572 : (int64 -> US2) = method8()
    let v573 : US2 option = v5 |> Option.map v572 
    let v584 : US2 = US2_1
    let v585 : US2 = v573 |> Option.defaultValue v584 
    let v682 : System.DateTime =
        match v585 with
        | US2_1 -> (* None *)
            let v666 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v667 : System.DateTime = System.DateTime.Now
            let _v666 = v667 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v668 : System.DateTime = System.DateTime.Now
            let _v666 = v668 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v669 : System.DateTime = null |> unbox<System.DateTime>
            let _v666 = v669 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v672 : System.DateTime = System.DateTime.Now
            let _v666 = v672 
            #endif
#if FABLE_COMPILER_PYTHON
            let v673 : System.DateTime = System.DateTime.Now
            let _v666 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : System.DateTime = System.DateTime.Now
            let _v666 = v674 
            #endif
#else
            let v675 : System.DateTime = System.DateTime.Now
            let _v666 = v675 
            #endif
            let v676 : System.DateTime = _v666 
            v676
        | US2_0(v589) -> (* Some *)
            let v590 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v591 : System.DateTime = System.DateTime.Now
            let _v590 = v591 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v592 : System.DateTime = System.DateTime.Now
            let _v590 = v592 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v593 : System.DateTime = null |> unbox<System.DateTime>
            let _v590 = v593 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v596 : System.DateTime = System.DateTime.Now
            let _v590 = v596 
            #endif
#if FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _v590 = v597 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v598 : System.DateTime = System.DateTime.Now
            let _v590 = v598 
            #endif
#else
            let v599 : System.DateTime = System.DateTime.Now
            let _v590 = v599 
            #endif
            let v600 : System.DateTime = _v590 
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : (System.DateTime -> int64) = _.Ticks
            let v607 : int64 = v606 v600
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v600
            let _v605 = v609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v610 : int64 = null |> unbox<int64>
            let _v605 = v610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v613 : (System.DateTime -> int64) = _.Ticks
            let v614 : int64 = v613 v600
            let _v605 = v614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v615 : (System.DateTime -> int64) = _.Ticks
            let v616 : int64 = v615 v600
            let _v605 = v616 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v617 : (System.DateTime -> int64) = _.Ticks
            let v618 : int64 = v617 v600
            let _v605 = v618 
            #endif
#else
            let v619 : (System.DateTime -> int64) = _.Ticks
            let v620 : int64 = v619 v600
            let _v605 = v620 
            #endif
            let v621 : int64 = _v605 
            let v638 : int64 = v621 |> int64 
            let v641 : int64 = v638 - v589
            let v642 : System.TimeSpan = v641 |> System.TimeSpan 
            let v647 : (System.TimeSpan -> int32) = _.Hours
            let v648 : int32 = v647 v642
            let v651 : (System.TimeSpan -> int32) = _.Minutes
            let v652 : int32 = v651 v642
            let v655 : (System.TimeSpan -> int32) = _.Seconds
            let v656 : int32 = v655 v642
            let v659 : (System.TimeSpan -> int32) = _.Milliseconds
            let v660 : int32 = v659 v642
            let v663 : System.DateTime = System.DateTime (1, 1, 1, v648, v652, v656, v660)
            v663
    let v683 : string = method10()
    let v686 : bool = v683 = ""
    let v688 : string =
        if v686 then
            let v687 : string = "M-d-y hh:mm:ss tt"
            v687
        else
            v683
    let v689 : (string -> string) = v682.ToString
    let v690 : string = v689 v688
    let _v6 = v690 
    #endif
#else
    let v704 : (int64 -> US2) = method8()
    let v705 : US2 option = v5 |> Option.map v704 
    let v716 : US2 = US2_1
    let v717 : US2 = v705 |> Option.defaultValue v716 
    let v814 : System.DateTime =
        match v717 with
        | US2_1 -> (* None *)
            let v798 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v799 : System.DateTime = System.DateTime.Now
            let _v798 = v799 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v800 : System.DateTime = System.DateTime.Now
            let _v798 = v800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v801 : System.DateTime = null |> unbox<System.DateTime>
            let _v798 = v801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v804 : System.DateTime = System.DateTime.Now
            let _v798 = v804 
            #endif
#if FABLE_COMPILER_PYTHON
            let v805 : System.DateTime = System.DateTime.Now
            let _v798 = v805 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v806 : System.DateTime = System.DateTime.Now
            let _v798 = v806 
            #endif
#else
            let v807 : System.DateTime = System.DateTime.Now
            let _v798 = v807 
            #endif
            let v808 : System.DateTime = _v798 
            v808
        | US2_0(v721) -> (* Some *)
            let v722 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.DateTime = System.DateTime.Now
            let _v722 = v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v724 : System.DateTime = System.DateTime.Now
            let _v722 = v724 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : System.DateTime = null |> unbox<System.DateTime>
            let _v722 = v725 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : System.DateTime = System.DateTime.Now
            let _v722 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v729 : System.DateTime = System.DateTime.Now
            let _v722 = v729 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v730 : System.DateTime = System.DateTime.Now
            let _v722 = v730 
            #endif
#else
            let v731 : System.DateTime = System.DateTime.Now
            let _v722 = v731 
            #endif
            let v732 : System.DateTime = _v722 
            let v737 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : (System.DateTime -> int64) = _.Ticks
            let v739 : int64 = v738 v732
            let _v737 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : (System.DateTime -> int64) = _.Ticks
            let v741 : int64 = v740 v732
            let _v737 = v741 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : int64 = null |> unbox<int64>
            let _v737 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : (System.DateTime -> int64) = _.Ticks
            let v746 : int64 = v745 v732
            let _v737 = v746 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v732
            let _v737 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v732
            let _v737 = v750 
            #endif
#else
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v732
            let _v737 = v752 
            #endif
            let v753 : int64 = _v737 
            let v770 : int64 = v753 |> int64 
            let v773 : int64 = v770 - v721
            let v774 : System.TimeSpan = v773 |> System.TimeSpan 
            let v779 : (System.TimeSpan -> int32) = _.Hours
            let v780 : int32 = v779 v774
            let v783 : (System.TimeSpan -> int32) = _.Minutes
            let v784 : int32 = v783 v774
            let v787 : (System.TimeSpan -> int32) = _.Seconds
            let v788 : int32 = v787 v774
            let v791 : (System.TimeSpan -> int32) = _.Milliseconds
            let v792 : int32 = v791 v774
            let v795 : System.DateTime = System.DateTime (1, 1, 1, v780, v784, v788, v792)
            v795
    let v815 : string = method10()
    let v818 : bool = v815 = ""
    let v820 : string =
        if v818 then
            let v819 : string = "M-d-y hh:mm:ss tt"
            v819
        else
            v815
    let v821 : (string -> string) = v814.ToString
    let v822 : string = v821 v820
    let _v6 = v822 
    #endif
    let v836 : string = _v6 
    v836
and method13 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure6(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_blue"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_blue"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[94m"
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method16 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "seed_excess_len"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "seed_excess"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method17 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v30 : char list = []
    let v31 : char list = '/' :: v30 
    let v34 : char list = ' ' :: v31 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v6.TrimEnd v38 
    v41
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method16(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "dice_contract.contribute_seed"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure7 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure9 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure8 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method18 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure7(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure8()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v20.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v0
        else
            let v46 : bool = v0 = ""
            if v46 then
                let v47 : string = v20.l0
                v47
            else
                let v48 : string = v20.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v0 
                v51
    let v54 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v55 
    let _v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v57 
    let _v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v59 
    let _v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
#else
    let v70 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v70 
    #endif
    let v73 : Ref<Str> = _v54 
    let v78 : string = $"$0.chars()"
    let v79 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v73 v78 
    let v80 : string = "$0"
    let v81 : _ = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.collect::<Vec<_>>()"
    let v83 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v85 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v87 : bool = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "x"
    let v89 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "String::from_iter($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "true; $0 }).collect::<Vec<_>>()"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : string = "_vec_map"
    let v95 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "$0.len()"
    let v97 : unativeint = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : int32 = v97 |> int32 
    let v105 : string = ""
    let v106 : bool = v0 <> v105 
    let v110 : bool =
        if v106 then
            let v109 : bool = v98 <= 1
            v109
        else
            false
    if v110 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v105
        let v111 : string = "true; $0.into_iter().for_each(|x| { //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr v95 v111 
        let v113 : string = "x"
        let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v113 
        let v115 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v116 : bool = Fable.Core.RustInterop.emitRustExpr v114 v115 
        let v117 : string = $"true"
        let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117 
        let v119 : string = "true; }); //"
        let v120 : bool = Fable.Core.RustInterop.emitRustExpr () v119 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#else
    v40 v0
    #endif
    // run_target_args' is_unit
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure1 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure2()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = $"%A{v1}"
        let v43 : string = method15(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method18(v43)
and closure10 () () : unit =
    ()
and method19 () : (unit -> unit) =
    closure10()
and method20 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure2()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure7(v16)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = ""
    let v40 : (string -> unit) = closure8()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v19.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v39
        else
            let v46 : bool = v39 = ""
            if v46 then
                let v47 : string = v19.l0
                v47
            else
                let v48 : string = v19.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v39 
                v51
    let v54 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v55 
    let _v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v57 
    let _v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v59 
    let _v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
#else
    let v70 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v70 
    #endif
    let v73 : Ref<Str> = _v54 
    let v78 : string = $"$0.chars()"
    let v79 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v73 v78 
    let v80 : string = "$0"
    let v81 : _ = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.collect::<Vec<_>>()"
    let v83 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v85 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v87 : bool = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "x"
    let v89 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "String::from_iter($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "true; $0 }).collect::<Vec<_>>()"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : string = "_vec_map"
    let v95 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "$0.len()"
    let v97 : unativeint = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : int32 = v97 |> int32 
    let v105 : bool = v39 <> v39 
    let v109 : bool =
        if v105 then
            let v108 : bool = v98 <= 1
            v108
        else
            false
    if v109 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v39
        let v110 : string = "true; $0.into_iter().for_each(|x| { //"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr v95 v110 
        let v112 : string = "x"
        let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v115 : bool = Fable.Core.RustInterop.emitRustExpr v113 v114 
        let v116 : string = $"true"
        let v117 : bool = Fable.Core.RustInterop.emitRustExpr () v116 
        let v118 : string = "true; }); //"
        let v119 : bool = Fable.Core.RustInterop.emitRustExpr () v118 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v39
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v39
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v39
    #endif
#else
    v40 v39
    #endif
    // run_target_args' is_unit
    let v120 : (string -> unit) = v17.l0
    v120 v39
and closure11 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method20()
and closure13 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure12 () (v0 : uint8) : (UH0 -> UH0) =
    closure13(v0)
and method21 () : (uint8 -> (UH0 -> UH0)) =
    closure12()
and closure14 (v0 : UH1) () : UH1 =
    v0
and method22 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method22(v3, v1)
        let v5 : (unit -> UH1) = closure14(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure15 (v0 : UH1) () : UH1 =
    v0
and method23 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method23(v4, v1)
        let v6 : int64 = int64 v2
        let v7 : int64 = v6 - 1L
        let v8 : int64 = v7 + 6L
        let v9 : int64 = v8 % 6L
        let v10 : int64 = v9 + 1L
        let v11 : uint8 = uint8 v10
        let v12 : (unit -> UH1) = closure15(v5)
        UH1_0(v11, v12)
    | UH1_1 -> (* StreamNil *)
        v1
and method24 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method24(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method25 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method25(v3, v1)
        let v5 : uint8 list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and method27 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : std_string_String, v9 : string, v10 : string, v11 : unativeint, v12 : string, v13 : string, v14 : string) : string =
    let v15 : string = method13()
    let v16 : Mut3 = {l0 = v15} : Mut3
    let v17 : string = "{ "
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure6(v16, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v26 : string = "max"
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure6(v16, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v35 : string = " = "
    let v36 : string = $"{v35}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure6(v16, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v44 : string = $"{v0}"
    let v47 : unit = ()
    let v48 : (unit -> unit) = closure6(v16, v44)
    let v49 : unit = (fun () -> v48 (); v47) ()
    let v52 : string = "; "
    let v53 : string = $"{v52}"
    let v56 : unit = ()
    let v57 : (unit -> unit) = closure6(v16, v53)
    let v58 : unit = (fun () -> v57 (); v56) ()
    let v61 : string = "key"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure6(v16, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v70 : string = $"{v35}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure6(v16, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v78 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v79 : string = "format!(\"{:#?}\", $0)"
    let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v79 
    let v81 : string = "fable_library_rust::String_::fromString($0)"
    let v82 : string = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let _v78 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "format!(\"{:#?}\", $0)"
    let v84 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v83 
    let v85 : string = "fable_library_rust::String_::fromString($0)"
    let v86 : string = Fable.Core.RustInterop.emitRustExpr v84 v85 
    let _v78 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "format!(\"{:#?}\", $0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v87 
    let v89 : string = "fable_library_rust::String_::fromString($0)"
    let v90 : string = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let _v78 = v90 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v91 : string = $"%A{v1}"
    let _v78 = v91 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v1}"
    let _v78 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v97 : string = $"%A{v1}"
    let _v78 = v97 
    #endif
#else
    let v100 : string = $"%A{v1}"
    let _v78 = v100 
    #endif
    let v103 : string = _v78 
    let v108 : string = $"{v103}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v16, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = $"{v52}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure6(v16, v116)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v124 : string = "proof"
    let v125 : string = $"{v124}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v16, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v35}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure6(v16, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v142 : string = "format!(\"{:#?}\", $0)"
    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v142 
    let v144 : string = "fable_library_rust::String_::fromString($0)"
    let v145 : string = Fable.Core.RustInterop.emitRustExpr v143 v144 
    let _v141 = v145 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v146 : string = "format!(\"{:#?}\", $0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v146 
    let v148 : string = "fable_library_rust::String_::fromString($0)"
    let v149 : string = Fable.Core.RustInterop.emitRustExpr v147 v148 
    let _v141 = v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : string = "format!(\"{:#?}\", $0)"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v150 
    let v152 : string = "fable_library_rust::String_::fromString($0)"
    let v153 : string = Fable.Core.RustInterop.emitRustExpr v151 v152 
    let _v141 = v153 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v154 : string = $"%A{v2}"
    let _v141 = v154 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : string = $"%A{v2}"
    let _v141 = v157 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v160 : string = $"%A{v2}"
    let _v141 = v160 
    #endif
#else
    let v163 : string = $"%A{v2}"
    let _v141 = v163 
    #endif
    let v166 : string = _v141 
    let v171 : string = $"{v166}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure6(v16, v171)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v179 : string = $"{v52}"
    let v182 : unit = ()
    let v183 : (unit -> unit) = closure6(v16, v179)
    let v184 : unit = (fun () -> v183 (); v182) ()
    let v187 : string = "block_timestamp"
    let v188 : string = $"{v187}"
    let v191 : unit = ()
    let v192 : (unit -> unit) = closure6(v16, v188)
    let v193 : unit = (fun () -> v192 (); v191) ()
    let v196 : string = $"{v35}"
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure6(v16, v196)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v204 : string = $"{v3}"
    let v207 : unit = ()
    let v208 : (unit -> unit) = closure6(v16, v204)
    let v209 : unit = (fun () -> v208 (); v207) ()
    let v212 : string = $"{v52}"
    let v215 : unit = ()
    let v216 : (unit -> unit) = closure6(v16, v212)
    let v217 : unit = (fun () -> v216 (); v215) ()
    let v220 : string = "block_height"
    let v221 : string = $"{v220}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure6(v16, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v229 : string = $"{v35}"
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure6(v16, v229)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v237 : string = $"{v4}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure6(v16, v237)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v245 : string = $"{v52}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure6(v16, v245)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v253 : string = "epoch_height"
    let v254 : string = $"{v253}"
    let v257 : unit = ()
    let v258 : (unit -> unit) = closure6(v16, v254)
    let v259 : unit = (fun () -> v258 (); v257) ()
    let v262 : string = $"{v35}"
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure6(v16, v262)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v270 : string = $"{v5}"
    let v273 : unit = ()
    let v274 : (unit -> unit) = closure6(v16, v270)
    let v275 : unit = (fun () -> v274 (); v273) ()
    let v278 : string = $"{v52}"
    let v281 : unit = ()
    let v282 : (unit -> unit) = closure6(v16, v278)
    let v283 : unit = (fun () -> v282 (); v281) ()
    let v286 : string = "account_balance"
    let v287 : string = $"{v286}"
    let v290 : unit = ()
    let v291 : (unit -> unit) = closure6(v16, v287)
    let v292 : unit = (fun () -> v291 (); v290) ()
    let v295 : string = $"{v35}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure6(v16, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v303 : string = $"{v6}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure6(v16, v303)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v311 : string = $"{v52}"
    let v314 : unit = ()
    let v315 : (unit -> unit) = closure6(v16, v311)
    let v316 : unit = (fun () -> v315 (); v314) ()
    let v319 : string = "signer_account_id"
    let v320 : string = $"{v319}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure6(v16, v320)
    let v325 : unit = (fun () -> v324 (); v323) ()
    let v328 : string = $"{v35}"
    let v331 : unit = ()
    let v332 : (unit -> unit) = closure6(v16, v328)
    let v333 : unit = (fun () -> v332 (); v331) ()
    let v336 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v337 : string = "format!(\"{:#?}\", $0)"
    let v338 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v337 
    let v339 : string = "fable_library_rust::String_::fromString($0)"
    let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339 
    let _v336 = v340 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v341 : string = "format!(\"{:#?}\", $0)"
    let v342 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v341 
    let v343 : string = "fable_library_rust::String_::fromString($0)"
    let v344 : string = Fable.Core.RustInterop.emitRustExpr v342 v343 
    let _v336 = v344 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v345 : string = "format!(\"{:#?}\", $0)"
    let v346 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v345 
    let v347 : string = "fable_library_rust::String_::fromString($0)"
    let v348 : string = Fable.Core.RustInterop.emitRustExpr v346 v347 
    let _v336 = v348 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v349 : string = $"%A{v7}"
    let _v336 = v349 
    #endif
#if FABLE_COMPILER_PYTHON
    let v352 : string = $"%A{v7}"
    let _v336 = v352 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v355 : string = $"%A{v7}"
    let _v336 = v355 
    #endif
#else
    let v358 : string = $"%A{v7}"
    let _v336 = v358 
    #endif
    let v361 : string = _v336 
    let v366 : string = $"{v361}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure6(v16, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    let v374 : string = $"{v52}"
    let v377 : unit = ()
    let v378 : (unit -> unit) = closure6(v16, v374)
    let v379 : unit = (fun () -> v378 (); v377) ()
    let v382 : string = "predecessor_account_id"
    let v383 : string = $"{v382}"
    let v386 : unit = ()
    let v387 : (unit -> unit) = closure6(v16, v383)
    let v388 : unit = (fun () -> v387 (); v386) ()
    let v391 : string = $"{v35}"
    let v394 : unit = ()
    let v395 : (unit -> unit) = closure6(v16, v391)
    let v396 : unit = (fun () -> v395 (); v394) ()
    let v399 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v400 : string = "format!(\"{:#?}\", $0)"
    let v401 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v400 
    let v402 : string = "fable_library_rust::String_::fromString($0)"
    let v403 : string = Fable.Core.RustInterop.emitRustExpr v401 v402 
    let _v399 = v403 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v404 : string = "format!(\"{:#?}\", $0)"
    let v405 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v404 
    let v406 : string = "fable_library_rust::String_::fromString($0)"
    let v407 : string = Fable.Core.RustInterop.emitRustExpr v405 v406 
    let _v399 = v407 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v408 : string = "format!(\"{:#?}\", $0)"
    let v409 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v408 
    let v410 : string = "fable_library_rust::String_::fromString($0)"
    let v411 : string = Fable.Core.RustInterop.emitRustExpr v409 v410 
    let _v399 = v411 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v412 : string = $"%A{v8}"
    let _v399 = v412 
    #endif
#if FABLE_COMPILER_PYTHON
    let v415 : string = $"%A{v8}"
    let _v399 = v415 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v418 : string = $"%A{v8}"
    let _v399 = v418 
    #endif
#else
    let v421 : string = $"%A{v8}"
    let _v399 = v421 
    #endif
    let v424 : string = _v399 
    let v429 : string = $"{v424}"
    let v432 : unit = ()
    let v433 : (unit -> unit) = closure6(v16, v429)
    let v434 : unit = (fun () -> v433 (); v432) ()
    let v437 : string = $"{v52}"
    let v440 : unit = ()
    let v441 : (unit -> unit) = closure6(v16, v437)
    let v442 : unit = (fun () -> v441 (); v440) ()
    let v445 : string = "seed"
    let v446 : string = $"{v445}"
    let v449 : unit = ()
    let v450 : (unit -> unit) = closure6(v16, v446)
    let v451 : unit = (fun () -> v450 (); v449) ()
    let v454 : string = $"{v35}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure6(v16, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v462 : string = $"{v9}"
    let v465 : unit = ()
    let v466 : (unit -> unit) = closure6(v16, v462)
    let v467 : unit = (fun () -> v466 (); v465) ()
    let v470 : string = $"{v52}"
    let v473 : unit = ()
    let v474 : (unit -> unit) = closure6(v16, v470)
    let v475 : unit = (fun () -> v474 (); v473) ()
    let v478 : string = "seeds"
    let v479 : string = $"{v478}"
    let v482 : unit = ()
    let v483 : (unit -> unit) = closure6(v16, v479)
    let v484 : unit = (fun () -> v483 (); v482) ()
    let v487 : string = $"{v35}"
    let v490 : unit = ()
    let v491 : (unit -> unit) = closure6(v16, v487)
    let v492 : unit = (fun () -> v491 (); v490) ()
    let v495 : string = $"{v10}"
    let v498 : unit = ()
    let v499 : (unit -> unit) = closure6(v16, v495)
    let v500 : unit = (fun () -> v499 (); v498) ()
    let v503 : string = $"{v52}"
    let v506 : unit = ()
    let v507 : (unit -> unit) = closure6(v16, v503)
    let v508 : unit = (fun () -> v507 (); v506) ()
    let v511 : string = "entropy_len"
    let v512 : string = $"{v511}"
    let v515 : unit = ()
    let v516 : (unit -> unit) = closure6(v16, v512)
    let v517 : unit = (fun () -> v516 (); v515) ()
    let v520 : string = $"{v35}"
    let v523 : unit = ()
    let v524 : (unit -> unit) = closure6(v16, v520)
    let v525 : unit = (fun () -> v524 (); v523) ()
    let v528 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v529 : string = "format!(\"{:#?}\", $0)"
    let v530 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v529 
    let v531 : string = "fable_library_rust::String_::fromString($0)"
    let v532 : string = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let _v528 = v532 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v533 : string = "format!(\"{:#?}\", $0)"
    let v534 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v533 
    let v535 : string = "fable_library_rust::String_::fromString($0)"
    let v536 : string = Fable.Core.RustInterop.emitRustExpr v534 v535 
    let _v528 = v536 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v537 : string = "format!(\"{:#?}\", $0)"
    let v538 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v537 
    let v539 : string = "fable_library_rust::String_::fromString($0)"
    let v540 : string = Fable.Core.RustInterop.emitRustExpr v538 v539 
    let _v528 = v540 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v541 : string = $"%A{v11}"
    let _v528 = v541 
    #endif
#if FABLE_COMPILER_PYTHON
    let v544 : string = $"%A{v11}"
    let _v528 = v544 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v547 : string = $"%A{v11}"
    let _v528 = v547 
    #endif
#else
    let v550 : string = $"%A{v11}"
    let _v528 = v550 
    #endif
    let v553 : string = _v528 
    let v558 : string = $"{v553}"
    let v561 : unit = ()
    let v562 : (unit -> unit) = closure6(v16, v558)
    let v563 : unit = (fun () -> v562 (); v561) ()
    let v566 : string = $"{v52}"
    let v569 : unit = ()
    let v570 : (unit -> unit) = closure6(v16, v566)
    let v571 : unit = (fun () -> v570 (); v569) ()
    let v574 : string = "entropy"
    let v575 : string = $"{v574}"
    let v578 : unit = ()
    let v579 : (unit -> unit) = closure6(v16, v575)
    let v580 : unit = (fun () -> v579 (); v578) ()
    let v583 : string = $"{v35}"
    let v586 : unit = ()
    let v587 : (unit -> unit) = closure6(v16, v583)
    let v588 : unit = (fun () -> v587 (); v586) ()
    let v591 : string = $"{v12}"
    let v594 : unit = ()
    let v595 : (unit -> unit) = closure6(v16, v591)
    let v596 : unit = (fun () -> v595 (); v594) ()
    let v599 : string = $"{v52}"
    let v602 : unit = ()
    let v603 : (unit -> unit) = closure6(v16, v599)
    let v604 : unit = (fun () -> v603 (); v602) ()
    let v607 : string = "hash_u8"
    let v608 : string = $"{v607}"
    let v611 : unit = ()
    let v612 : (unit -> unit) = closure6(v16, v608)
    let v613 : unit = (fun () -> v612 (); v611) ()
    let v616 : string = $"{v35}"
    let v619 : unit = ()
    let v620 : (unit -> unit) = closure6(v16, v616)
    let v621 : unit = (fun () -> v620 (); v619) ()
    let v624 : string = $"{v13}"
    let v627 : unit = ()
    let v628 : (unit -> unit) = closure6(v16, v624)
    let v629 : unit = (fun () -> v628 (); v627) ()
    let v632 : string = $"{v52}"
    let v635 : unit = ()
    let v636 : (unit -> unit) = closure6(v16, v632)
    let v637 : unit = (fun () -> v636 (); v635) ()
    let v640 : string = "rolls"
    let v641 : string = $"{v640}"
    let v644 : unit = ()
    let v645 : (unit -> unit) = closure6(v16, v641)
    let v646 : unit = (fun () -> v645 (); v644) ()
    let v649 : string = $"{v35}"
    let v652 : unit = ()
    let v653 : (unit -> unit) = closure6(v16, v649)
    let v654 : unit = (fun () -> v653 (); v652) ()
    let v657 : string = $"{v14}"
    let v660 : unit = ()
    let v661 : (unit -> unit) = closure6(v16, v657)
    let v662 : unit = (fun () -> v661 (); v660) ()
    let v665 : string = " }"
    let v666 : string = $"{v665}"
    let v669 : unit = ()
    let v670 : (unit -> unit) = closure6(v16, v666)
    let v671 : unit = (fun () -> v670 (); v669) ()
    let v674 : string = v16.l0
    v674
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method27(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v24 : int64 = v0.l0
    let v25 : string = "dice_contract.generate_random_number"
    let v26 : string = $"{v6} {v7} #{v24} %s{v25} / {v23}"
    method17(v26)
and closure16 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v14 : US0 = US0_1
    let v15 : bool = method0(v14)
    if v15 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure2()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v32 : Mut0, v33 : Mut1, v34 : Mut2, v35 : Mut3, v36 : Mut4, v37 : int64 option) = TraceState.trace_state.Value
        let v50 : string = method7(v32, v33, v34, v35, v36, v37)
        let v51 : string = method11()
        let v52 : string = $"%A{v8}"
        let v55 : string = $"v9.to_string()"
        let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v55 
        let v57 : string = $"v10.to_string()"
        let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v57 
        let v59 : string = $"%A{v4}"
        let v62 : string = $"%A{v0}"
        let v65 : string = "$0.len()"
        let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v65 
        let v67 : string = $"%A{v11}"
        let v70 : string = $"%A{v12}"
        let v73 : uint8 list = []
        let v74 : uint8 list = method25(v13, v73)
        let v75 : (uint8 list -> (uint8 [])) = List.toArray
        let v76 : (uint8 []) = v75 v74
        let v79 : string = "$0.to_vec()"
        let v80 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v76 v79 
        let v81 : string = $"%A{v80}"
        let v84 : string = method26(v32, v33, v34, v35, v36, v37, v50, v51, v3, v1, v2, v7, v6, v5, v52, v56, v58, v59, v62, v66, v67, v70, v81)
        method18(v84)
and method28 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method28(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method29 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method29(v3, v1)
        UH0_1(v2, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure17 (v0 : UH1) () : UH1 =
    v0
and closure18 (v0 : UH1, v1 : Mut5) () : UH1 =
    let v2 : US6 = v1.l0
    match v2 with
    | US6_1(v3) -> (* Computed *)
        v3
    | US6_0(v4) -> (* NotComputed *)
        let v5 : UH1 = v4 ()
        let v12 : UH1 =
            match v5 with
            | UH1_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH1) = method30(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US6 = US6_1(v12)
        v1.l0 <- v13
        v12
and method30 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US6 = US6_0(v1)
    let v3 : Mut5 = {l0 = v2} : Mut5
    closure18(v0, v3)
and method33 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "p"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "n"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method33(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.calculate_dice_count"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure19 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = method32(v21, v22, v23, v24, v25, v26, v39, v40, v0, v2, v1)
        method18(v41)
and method31 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method31(v0, v6, v4)
        else
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure19(v0, v1, v2)
            let v10 : unit = (fun () -> v9 (); v8) ()
            v1
    else
        let v51 : unit = ()
        let v52 : (unit -> unit) = closure19(v0, v1, v2)
        let v53 : unit = (fun () -> v52 (); v51) ()
        v1
and method37 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "current_index"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure6(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure6(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure6(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure6(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure6(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "len"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure6(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure6(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure6(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "last_item"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure6(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure6(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method37(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.create_sequential_roller / roll"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure20 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure2()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = $"%A{v3}"
        let v45 : string = method36(v22, v23, v24, v25, v26, v27, v40, v41, v0, v1, v2, v42)
        method18(v45)
and method38 (v0 : int64, v1 : UH1) : US7 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US7_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method38(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US7_1
and method40 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method40()
    let v9 : int64 = v0.l0
    let v10 : string = "dice.create_sequential_roller / roll / None"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
and closure21 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure2()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method39(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and method35 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US7 = v4.l0
    let v15 : uint8 option =
        match v8 with
        | US7_1 -> (* None *)
            let v13 : uint8 option = None
            v13
        | US7_0(v9) -> (* Some *)
            let v10 : uint8 option = Some v9 
            v10
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure20(v5, v6, v7, v15)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v61 : UH1 = v0 ()
    let v62 : int64 = v1.l0
    let v63 : US7 = method38(v62, v61)
    match v63 with
    | US7_1 -> (* None *)
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure21()
        let v70 : unit = (fun () -> v69 (); v68) ()
        let v110 : int64 = v3.l0
        let v111 : bool = v110 = -1L
        if v111 then
            let v112 : int64 = v1.l0
            v3.l0 <- v112
            ()
        let v113 : int64 = v2.l0
        let v114 : int64 = v3.l0
        let v115 : bool = v113 >= v114
        let v118 : int64 =
            if v115 then
                1L
            else
                let v116 : int64 = v2.l0
                let v117 : int64 = v116 + 1L
                v117
        v2.l0 <- v118
        let v119 : int64 = v2.l0
        let v120 : int64 = v119 - 1L
        v1.l0 <- v120
        let v121 : US7 = US7_1
        v4.l0 <- v121
        method35(v0, v1, v2, v3, v4)
    | US7_0(v64) -> (* Some *)
        let v65 : int64 = v1.l0
        let v66 : int64 = v65 + 1L
        v1.l0 <- v66
        let v67 : US7 = US7_0(v64)
        v4.l0 <- v67
        v64
and method43 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method43(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = method42(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method18(v41)
and closure86 () () : UH2 =
    UH2_1
and closure85 () () : UH2 =
    let v0 : (unit -> UH2) = closure86()
    UH2_0(9223372036854775808UL, v0)
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(4611686018427387904UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(6917529027641081856UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(1152921504606846976UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(15564440312192434176UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(11817445422220181504UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(5044031582654955520UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(6989586621679009792UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(16537217831704461312UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(11979575008805519360UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(14294425217273954304UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(2382404202878992384UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(6545982058383015936UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(10314369046585278464UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(4793518853382471680UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(3873377154515337216UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(645562859085889536UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(107593809847648256UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(3092389647259533312UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(9738770311398031360UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(16995415113324298240UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(8981483876790566912UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(13794743361938128896UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(2299123893656354816UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(3457644661227651072UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(576274110204608512UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(6244960376270618624UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(13338656111851470848UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(14520938734448279552UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(14717985838214414336UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(5527454985320660992UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(16293529225644736512UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(11938960241128898560UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(8138741398091333632UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(7505371590918406144UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(16623181993244360704UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(8919445023443910656UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(4561031516192243712UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(9983543956220149760UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(4738381338321616896UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(789730223053602816UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(131621703842267136UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(21936950640377856UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(3656158440062976UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(609359740010496UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(101559956668416UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(16926659444736UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(2821109907456UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(470184984576UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(78364164096UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(13060694016UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(2176782336UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(362797056UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(60466176UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(10077696UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(1679616UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(279936UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(46656UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(7776UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(1296UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(216UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(36UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(6UL, v0)
and method44 (v0 : int8, v1 : UH2) : US9 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US9_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method44(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US9_1
and method46 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "power"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure6(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure6(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure6(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure6(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure6(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "roll"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure6(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure6(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure6(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "value"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure6(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure6(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method45 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method46(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure2()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = method45(v22, v23, v24, v25, v26, v27, v40, v41, v1, v0, v2, v3)
        method18(v42)
and method48 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "roll"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method47 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method48(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = method47(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method18(v41)
and method41 (v0 : int8, v1 : UH0, v2 : uint64) : US8 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure22(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US8_0(v4, v1)
    else
        match v1 with
        | UH0_1(v49, v50) -> (* Cons *)
            let v51 : bool = v49 > 1uy
            if v51 then
                let v52 : uint64 = 1UL
                let v53 : (unit -> UH2) = closure23()
                let v54 : UH2 = UH2_0(v52, v53)
                let v55 : US9 = method44(v0, v54)
                let v59 : uint64 =
                    match v55 with
                    | US9_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US9_0(v56) -> (* Some *)
                        v56
                let v60 : uint8 = v49 - 1uy
                let v61 : uint64 = uint64 v60
                let v62 : uint64 = v61 * v59
                let v63 : unit = ()
                let v64 : (unit -> unit) = closure87(v2, v0, v49, v62)
                let v65 : unit = (fun () -> v64 (); v63) ()
                let v105 : uint64 = v2 + v62
                let v106 : int8 = v0 - 1y
                method41(v106, v50, v105)
            else
                let v108 : unit = ()
                let v109 : (unit -> unit) = closure88(v2, v0, v49)
                let v110 : unit = (fun () -> v109 (); v108) ()
                let v150 : int8 = v0 - 1y
                method41(v150, v50, v2)
        | UH0_0 -> (* Nil *)
            US8_1
and method49 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut6, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method35(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method49(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method50 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method35(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method34(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US8 = method41(v6, v7, v13)
        match v14 with
        | US8_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method49(v6, v0, v1, v2, v3, v4, v18)
                method50(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method49(v6, v0, v1, v2, v3, v4, v22)
            method50(v0, v1, v2, v3, v4, v5, v6, v23)
and method34 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method35(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method34(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US8 = method41(v6, v7, v15)
        match v16 with
        | US8_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method49(v6, v0, v1, v2, v3, v4, v20)
                method50(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method49(v6, v0, v1, v2, v3, v4, v24)
            method50(v0, v1, v2, v3, v4, v5, v6, v25)
and method51 () : (unit -> unit) =
    closure10()
and closure89 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method20()
and method52 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method52(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method54 (v0 : uint64, v1 : string, v2 : string) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "rolls"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method53 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method54(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice_contract.roll_within_bounds"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure90 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = $"%A{v1}"
        let v44 : string = $"%A{v2}"
        let v47 : string = method53(v21, v22, v23, v24, v25, v26, v39, v40, v0, v41, v44)
        method18(v47)
and method55 () : (unit -> unit) =
    closure10()
and closure91 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method20()
and closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = "pub struct OldState { //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "    version: u32, //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "    seeds: near_sdk::store::vec::Vector<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v21 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "        Self((old_state.version + 1, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "true; /*"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v36 : string = "true; */"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "seeds"
    let v39 : string = "b\"" + v38 + "\""
    let v40 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : string = "near_sdk::store::vec::Vector::new($0)"
    let v42 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _result = struct (2u, v42) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v43 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v47 : bool = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = $"&mut self.0.1"
    let v54 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : string = $"seed"
    let v56 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = "true; v54.extend($0); //"
    let v58 : bool = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let v59 : string = $"v54.len()"
    let v60 : uint32 = Fable.Core.RustInterop.emitRustExpr () v59 
    let v61 : int32 = v60 |> int32 
    let v68 : unativeint = 100 |> unativeint 
    let v71 : int32 = v68 |> int32 
    let v78 : int32 = v61 - v71
    let v79 : bool = v78 > 0
    if v79 then
        let v80 : string = "v54.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v81 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v78 v80 
        let v82 : unit = ()
        let v83 : (unit -> unit) = closure1(v78, v81)
        let v84 : unit = (fun () -> v83 (); v82) ()
        ()
    let v127 : (unit -> unit) = method19()
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure11(v127)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v169 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v171 
    let v172 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v172 
    let v173 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v174 : bool = Fable.Core.RustInterop.emitRustExpr () v173 
    let v175 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr () v175 
    let v177 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v177 
    let v178 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v180 
    let v181 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v181 
    let v182 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v182 
    let v183 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v184 : bool = Fable.Core.RustInterop.emitRustExpr () v183 
    let v185 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v186 : bool = Fable.Core.RustInterop.emitRustExpr () v185 
    let v187 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v187 
    let v188 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v188 
    let v189 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v189 
    let v190 : string = $"key"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v190 
    let v192 : string = $"proof"
    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = $"max"
    let v195 : uint64 = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = $"&mut self.0.1"
    let v197 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : string = $"near_sdk::env::random_seed()"
    let v199 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v198 
    let v200 : string = $"near_sdk::env::epoch_height()"
    let v201 : uint64 = Fable.Core.RustInterop.emitRustExpr () v200 
    let v202 : string = $"near_sdk::env::block_height()"
    let v203 : uint64 = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = $"near_sdk::env::block_timestamp()"
    let v205 : uint64 = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = $"near_sdk::env::account_balance()"
    let v207 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v206 
    let v208 : string = $"near_sdk::env::signer_account_id()"
    let v209 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v208 
    let v210 : string = $"near_sdk::env::predecessor_account_id()"
    let v211 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v210 
    let v212 : string = $"&*v197"
    let v213 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v212 
    let v214 : string = $"v213.iter().map(|x| *x).collect::<Vec<_>>()"
    let v215 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v214 
    let v216 : string = $"v201.to_le_bytes()"
    let v217 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v216 
    let v218 : string = $"v217.to_vec()"
    let v219 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v218 
    let v220 : string = $"v203.to_le_bytes()"
    let v221 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v220 
    let v222 : string = $"v221.to_vec()"
    let v223 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v222 
    let v224 : string = $"v205.to_le_bytes()"
    let v225 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v224 
    let v226 : string = $"v225.to_vec()"
    let v227 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v226 
    let v228 : string = "$0.as_yoctonear()"
    let v229 : u128 = Fable.Core.RustInterop.emitRustExpr v207 v228 
    let v230 : string = $"v229.to_le_bytes()"
    let v231 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = $"v231.to_vec()"
    let v233 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v232 
    let v234 : string = $"v209.as_bytes()"
    let v235 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v234 
    let v236 : string = $"v235.to_vec()"
    let v237 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v236 
    let v238 : string = $"v211.as_bytes()"
    let v239 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v238 
    let v240 : string = $"v239.to_vec()"
    let v241 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v240 
    let v242 : string = $"$0.into_bytes()"
    let v243 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v193 v242 
    let v244 : string = $"$0.into_bytes()"
    let v245 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v191 v244 
    let v246 : (Vec<uint8> []) = [|v199; v215; v219; v223; v227; v233; v237; v241; v243; v245|]
    let v247 : string = "$0.to_vec()"
    let v248 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v246 v247 
    let v249 : string = $"v248.concat()"
    let v250 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v249 
    let v251 : string = $"near_sdk::env::keccak512(&$0)"
    let v252 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v250 v251 
    let v253 : string = "true; v197.extend($0); //"
    let v254 : bool = Fable.Core.RustInterop.emitRustExpr v252 v253 
    let v255 : string = $"v197.len()"
    let v256 : uint32 = Fable.Core.RustInterop.emitRustExpr () v255 
    let v257 : int32 = v256 |> int32 
    let v264 : unativeint = 100 |> unativeint 
    let v267 : int32 = v264 |> int32 
    let v274 : int32 = v257 - v267
    let v275 : bool = v274 > 0
    if v275 then
        let v276 : string = "v197.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v277 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v274 v276 
        let v278 : unit = ()
        let v279 : (unit -> unit) = closure1(v274, v277)
        let v280 : unit = (fun () -> v279 (); v278) ()
        ()
    let v323 : (unit -> unit) = method19()
    let v324 : unit = ()
    let v325 : (unit -> unit) = closure11(v323)
    let v326 : unit = (fun () -> v325 (); v324) ()
    let v365 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v366 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v252 v365 
    let v367 : uint8 list = v366 |> Array.toList
    let v370 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v371 : (uint8 -> (UH0 -> UH0)) = method21()
    let v372 : (uint8 list -> (UH0 -> UH0)) = v370 v371
    let v373 : (UH0 -> UH0) = v372 v367
    let v374 : UH0 = UH0_0
    let v375 : UH0 = v373 v374
    let v397 : UH1 = UH1_1
    let v398 : UH1 = method22(v375, v397)
    let v399 : UH1 = UH1_1
    let v400 : UH1 = method23(v398, v399)
    let v401 : UH0 = UH0_0
    let v402 : UH0 = method24(v400, v401)
    let v403 : unit = ()
    let v404 : (unit -> unit) = closure16(v197, v191, v193, v195, v199, v201, v203, v205, v207, v209, v211, v250, v252, v402)
    let v405 : unit = (fun () -> v404 (); v403) ()
    let v477 : UH0 = UH0_0
    let v478 : UH0 = method28(v402, v477)
    let v479 : UH0 = method29(v402, v478)
    let v480 : UH1 = UH1_1
    let v481 : UH1 = method22(v479, v480)
    let v482 : (unit -> UH1) = closure17(v481)
    let v483 : (unit -> UH1) = method30(v481, v482)
    let v484 : Mut0 = {l0 = 0L} : Mut0
    let v485 : Mut0 = {l0 = 1L} : Mut0
    let v486 : Mut0 = {l0 = -1L} : Mut0
    let v487 : US7 = US7_1
    let v488 : Mut6 = {l0 = v487} : Mut6
    let v489 : bool = v195 = 1UL
    let v493 : int8 =
        if v489 then
            1y
        else
            let v490 : int8 = 0y
            let v491 : uint64 = 1UL
            method31(v195, v490, v491)
    let v494 : int8 = v493 - 1y
    let v495 : UH0 = UH0_0
    let v496 : int8 = 0y
    let v497 : uint64 = method34(v483, v484, v485, v486, v488, v195, v494, v495, v496)
    let v498 : (unit -> unit) = method51()
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure89(v498)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v540 : string = "v497 //"
    Fable.Core.RustInterop.emitRustExpr () v540 
    let v541 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v541 
    let v542 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v542 
    let v543 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v543 
    let v544 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v544 
    let v545 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v546 : bool = Fable.Core.RustInterop.emitRustExpr () v545 
    let v547 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v548 : bool = Fable.Core.RustInterop.emitRustExpr () v547 
    let v549 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v549 
    let v550 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v550 
    let v551 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v551 
    let v552 : string = $"max"
    let v553 : uint64 = Fable.Core.RustInterop.emitRustExpr () v552 
    let v554 : string = $"rolls"
    let v555 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v554 
    let v556 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v557 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v555 v556 
    let v558 : uint8 list = v557 |> Array.toList
    let v561 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v562 : (uint8 -> (UH0 -> UH0)) = method21()
    let v563 : (uint8 list -> (UH0 -> UH0)) = v561 v562
    let v564 : (UH0 -> UH0) = v563 v558
    let v565 : UH0 = UH0_0
    let v566 : UH0 = v564 v565
    let v588 : int8 = 0y
    let v589 : int8 = method52(v566, v588)
    let v590 : int8 = v589 - 1y
    let v591 : uint64 = 0UL
    let v592 : US8 = method41(v590, v566, v591)
    let v602 : US9 =
        match v592 with
        | US8_0(v593, v594) -> (* Some *)
            let v595 : bool = v593 >= 1UL
            let v597 : bool =
                if v595 then
                    let v596 : bool = v593 <= v553
                    v596
                else
                    false
            if v597 then
                US9_0(v593)
            else
                US9_1
        | _ ->
            US9_1
    let v609 : uint64 option =
        match v602 with
        | US9_1 -> (* None *)
            let v607 : uint64 option = None
            v607
        | US9_0(v603) -> (* Some *)
            let v604 : uint64 option = Some v603 
            v604
    let v610 : unit = ()
    let v611 : (unit -> unit) = closure90(v553, v555, v609)
    let v612 : unit = (fun () -> v611 (); v610) ()
    let v658 : (unit -> unit) = method55()
    let v659 : unit = ()
    let v660 : (unit -> unit) = closure91(v658)
    let v661 : unit = (fun () -> v660 (); v659) ()
    let v700 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v609 v700 
    let v701 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v701 
    let v702 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v702 
    let v703 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v703 
    let v704 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v705 : bool = Fable.Core.RustInterop.emitRustExpr () v704 
    let v706 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v707 : bool = Fable.Core.RustInterop.emitRustExpr () v706 
    let v708 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v708 
    let v709 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v709 
    let v710 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v710 
    let v711 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v711 
    let v712 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v712 
    let v713 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v713 
    let v714 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v714 
    let v715 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v715 
    let v716 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v716 
    let v717 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v717 
    let v718 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v718 
    let v719 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v720 : bool = Fable.Core.RustInterop.emitRustExpr () v719 
    let v721 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v722 : bool = Fable.Core.RustInterop.emitRustExpr () v721 
    let v723 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v723 
    let v724 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v724 
    let v725 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v726 : bool = Fable.Core.RustInterop.emitRustExpr () v725 
    let v727 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v728 : bool = Fable.Core.RustInterop.emitRustExpr () v727 
    let v729 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v730 : bool = Fable.Core.RustInterop.emitRustExpr () v729 
    let v731 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v732 : bool = Fable.Core.RustInterop.emitRustExpr () v731 
    let v733 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v734 : bool = Fable.Core.RustInterop.emitRustExpr () v733 
    let v735 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v736 : bool = Fable.Core.RustInterop.emitRustExpr () v735 
    let v737 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v738 : bool = Fable.Core.RustInterop.emitRustExpr () v737 
    let v739 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v740 : bool = Fable.Core.RustInterop.emitRustExpr () v739 
    let v741 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v742 : bool = Fable.Core.RustInterop.emitRustExpr () v741 
    let v743 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v744 : bool = Fable.Core.RustInterop.emitRustExpr () v743 
    let v745 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v746 : bool = Fable.Core.RustInterop.emitRustExpr () v745 
    let v747 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v748 : bool = Fable.Core.RustInterop.emitRustExpr () v747 
    let v749 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v750 : bool = Fable.Core.RustInterop.emitRustExpr () v749 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
