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
    | US4_5 of f5_0 : US3
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
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v0)
    let v7 : string = "std::env::var(&*$0)"
    let v8 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "x"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "true; $0 })"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "_result_map_"
    let v18 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : string = method5()
    let v20 : string = "$0.unwrap_or($1)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v20 
    let _run_target_args'_v5 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US3 = US3_1
    let v23 : US4 = US4_3(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v5 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : US3 = US3_2
    let v27 : US4 = US4_3(v26)
    let v28 : string = $"env.get_environment_variable / target: {v27} / var: {v0}"
    let v29 : string = failwith<string> v28
    let _run_target_args'_v5 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "process.env[$0] ?? \"\""
    let v31 : string = Fable.Core.JsInterop.emitJsExpr v0 v30 
    let _run_target_args'_v5 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : string = "os"
    let v34 : IOsEnviron = Fable.Core.PyInterop.importAll v33 
    let v35 : string = "v34.environ"
    let v36 : obj = Fable.Core.PyInterop.emitPyExpr () v35 
    let v40 : string = "v36.get($0)"
    let v41 : string = Fable.Core.PyInterop.emitPyExpr v0 v40 
    let mutable _v41 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v45 : (string -> string option) = Option.ofObj
    let v46 : string option = v45 v41
    v46 
    #else
    Some v41 
    #endif
    |> fun x -> _v41 <- Some x
    let v47 : string option = match _v41 with Some x -> x | None -> failwith "optionm'.of_obj / _v41=None"
    let v51 : (string -> US5) = method6()
    let v52 : US5 option = v47 |> Option.map v51 
    let v65 : US5 = US5_1
    let v66 : US5 = v52 |> Option.defaultValue v65 
    let v73 : string =
        match v66 with
        | US5_1 -> (* None *)
            let v71 : string = ""
            v71
        | US5_0(v70) -> (* Some *)
            v70
    let _run_target_args'_v5 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v74 : US3 = US3_1
    let v75 : US4 = US4_1(v74)
    let v76 : string = $"env.get_environment_variable / target: {v75} / var: {v0}"
    let v77 : string = failwith<string> v76
    let _run_target_args'_v5 = v77 
    #endif
#else
    let v78 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v79 : string = v78 v0
    let mutable _v79 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v81 : (string -> string option) = Option.ofObj
    let v82 : string option = v81 v79
    v82 
    #else
    Some v79 
    #endif
    |> fun x -> _v79 <- Some x
    let v83 : string option = match _v79 with Some x -> x | None -> failwith "optionm'.of_obj / _v79=None"
    let v87 : (string -> US5) = method6()
    let v88 : US5 option = v83 |> Option.map v87 
    let v101 : US5 = US5_1
    let v102 : US5 = v88 |> Option.defaultValue v101 
    let v109 : string =
        match v102 with
        | US5_1 -> (* None *)
            let v107 : string = ""
            v107
        | US5_0(v106) -> (* Some *)
            v106
    let _run_target_args'_v5 = v109 
    #endif
    let v110 : string = _run_target_args'_v5 
    v110
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
    let v52 : string = "True"
    let v53 : bool = v49 <> v52 
    let v120 : US2 =
        if v53 then
            US2_1
        else
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v60 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v61 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v63 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v66 
            #endif
#if FABLE_COMPILER_PYTHON
            let v67 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v67 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v68 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v68 
            #endif
#else
            let v69 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v59 = v69 
            #endif
            let v70 : System.DateTime = _run_target_args'_v59 
            (* run_target_args'
            let v78 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : (System.DateTime -> int64) = _.Ticks
            let v80 : int64 = v79 v70
            let _run_target_args'_v78 = v80 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v81 : (System.DateTime -> int64) = _.Ticks
            let v82 : int64 = v81 v70
            let _run_target_args'_v78 = v82 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v84 : int64 = null |> unbox<int64>
            let _run_target_args'_v78 = v84 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87 : (System.DateTime -> int64) = _.Ticks
            let v88 : int64 = v87 v70
            let _run_target_args'_v78 = v88 
            #endif
#if FABLE_COMPILER_PYTHON
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v70
            let _run_target_args'_v78 = v90 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v91 : (System.DateTime -> int64) = _.Ticks
            let v92 : int64 = v91 v70
            let _run_target_args'_v78 = v92 
            #endif
#else
            let v93 : (System.DateTime -> int64) = _.Ticks
            let v94 : int64 = v93 v70
            let _run_target_args'_v78 = v94 
            #endif
            let v95 : int64 = _run_target_args'_v78 
            let v116 : int64 = v95 |> int64 
            US2_0(v116)
    struct (v47, v120)
and closure4 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US1, v5 : US2) = method2()
    let _run_target_args'_v3 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : US1 = US1_1
    let v7 : US2 = US2_1
    let _run_target_args'_v3 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "AUTOMATION"
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "String::from($0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : std_string_String = _run_target_args'_v20 
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v43 v49 
    let _run_target_args'_v13 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51 
    (* run_target_args'
    let v57 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "String::from($0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v58 
    let _run_target_args'_v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v60 
    let _run_target_args'_v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "String::from($0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v62 
    let _run_target_args'_v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v69 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v73 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v73 
    #endif
#else
    let v77 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v77 
    #endif
    let v80 : std_string_String = _run_target_args'_v57 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v80 v86 
    let _run_target_args'_v13 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v88 
    (* run_target_args'
    let v94 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v95 
    let _run_target_args'_v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v97 
    let _run_target_args'_v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v99 
    let _run_target_args'_v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v102 
    #endif
#if FABLE_COMPILER_PYTHON
    let v106 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v110 
    #endif
#else
    let v114 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v114 
    #endif
    let v117 : std_string_String = _run_target_args'_v94 
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v117 v123 
    let _run_target_args'_v13 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : string = null |> unbox<string>
    let _run_target_args'_v13 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : string = null |> unbox<string>
    let _run_target_args'_v13 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v134 : string = null |> unbox<string>
    let _run_target_args'_v13 = v134 
    #endif
#else
    let v138 : string = null |> unbox<string>
    let _run_target_args'_v13 = v138 
    #endif
    let v141 : string = _run_target_args'_v13 
    let v149 : string = "True"
    let v150 : bool = v141 <> v149 
    let v162 : US2 =
        if v150 then
            US2_1
        else
            let v154 : string = $"near_sdk::env::block_timestamp()"
            let v155 : uint64 = Fable.Core.RustInterop.emitRustExpr () v154 
            let v157 : (uint64 -> int64) = int64
            let v158 : int64 = v157 v155
            US2_0(v158)
    let v163 : US1 = US1_1
    let _run_target_args'_v3 = struct (v163, v162) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v164 : US1, v165 : US2) = method2()
    let _run_target_args'_v3 = struct (v164, v165) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v166 : US1, v167 : US2) = method2()
    let _run_target_args'_v3 = struct (v166, v167) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v168 : US1, v169 : US2) = method2()
    let _run_target_args'_v3 = struct (v168, v169) 
    #endif
#else
    let struct (v170 : US1, v171 : US2) = method2()
    let _run_target_args'_v3 = struct (v170, v171) 
    #endif
    let struct (v172 : US1, v173 : US2) = _run_target_args'_v3 
    let v178 : Mut0 = {l0 = 1L} : Mut0
    let v179 : (string -> unit) = closure4()
    let v180 : Mut1 = {l0 = v179} : Mut1
    let v181 : Mut2 = {l0 = true} : Mut2
    let v182 : string = ""
    let v183 : Mut3 = {l0 = v182} : Mut3
    let v186 : US0 =
        match v172 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v184) -> (* Some *)
            v184
    let v187 : Mut4 = {l0 = v186} : Mut4
    let v195 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v193 : int64 option = None
            v193
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v195)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method0 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : US0 = v28.l0
    let v43 : bool = v26.l0
    let v44 : bool = v43 = false
    if v44 then
        false
    else
        let v45 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v46 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v42
        let v47 : bool = v45 >= v46
        v47
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
    (* run_target_args'
    let v165 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : (int64 -> US2) = method8()
    let v168 : US2 option = v5 |> Option.map v167 
    let v181 : US2 = US2_1
    let v182 : US2 = v168 |> Option.defaultValue v181 
    let v300 : System.DateTime =
        match v182 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v283 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v284 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v284 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v285 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v285 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v287 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v283 = v287 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v290 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v290 
            #endif
#if FABLE_COMPILER_PYTHON
            let v291 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v291 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v292 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v292 
            #endif
#else
            let v293 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v283 = v293 
            #endif
            let v294 : System.DateTime = _run_target_args'_v283 
            v294
        | US2_0(v186) -> (* Some *)
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v189 = v193 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v196 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v196 
            #endif
#if FABLE_COMPILER_PYTHON
            let v197 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v197 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v198 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v198 
            #endif
#else
            let v199 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v189 = v199 
            #endif
            let v200 : System.DateTime = _run_target_args'_v189 
            (* run_target_args'
            let v208 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v209 : (System.DateTime -> int64) = _.Ticks
            let v210 : int64 = v209 v200
            let _run_target_args'_v208 = v210 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v211 : (System.DateTime -> int64) = _.Ticks
            let v212 : int64 = v211 v200
            let _run_target_args'_v208 = v212 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v214 : int64 = null |> unbox<int64>
            let _run_target_args'_v208 = v214 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v217 : (System.DateTime -> int64) = _.Ticks
            let v218 : int64 = v217 v200
            let _run_target_args'_v208 = v218 
            #endif
#if FABLE_COMPILER_PYTHON
            let v219 : (System.DateTime -> int64) = _.Ticks
            let v220 : int64 = v219 v200
            let _run_target_args'_v208 = v220 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v221 : (System.DateTime -> int64) = _.Ticks
            let v222 : int64 = v221 v200
            let _run_target_args'_v208 = v222 
            #endif
#else
            let v223 : (System.DateTime -> int64) = _.Ticks
            let v224 : int64 = v223 v200
            let _run_target_args'_v208 = v224 
            #endif
            let v225 : int64 = _run_target_args'_v208 
            let v246 : int64 = v225 |> int64 
            let v249 : int64 = v246 - v186
            let v252 : System.TimeSpan = v249 |> System.TimeSpan 
            let v258 : (System.TimeSpan -> int32) = _.Hours
            let v259 : int32 = v258 v252
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v252
            let v268 : (System.TimeSpan -> int32) = _.Seconds
            let v269 : int32 = v268 v252
            let v273 : (System.TimeSpan -> int32) = _.Milliseconds
            let v274 : int32 = v273 v252
            let v278 : System.DateTime = System.DateTime (1, 1, 1, v259, v264, v269, v274)
            v278
    let v302 : string = method9()
    let v306 : bool = v302 = ""
    let v308 : string =
        if v306 then
            let v307 : string = "M-d-y hh:mm:ss tt"
            v307
        else
            v302
    let v309 : (string -> string) = v300.ToString
    let v310 : string = v309 v308
    let _run_target_args'_v165 = v310 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v326 : (int64 -> US2) = method8()
    let v327 : US2 option = v5 |> Option.map v326 
    let v340 : US2 = US2_1
    let v341 : US2 = v327 |> Option.defaultValue v340 
    let v459 : System.DateTime =
        match v341 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v442 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v443 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v443 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v444 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v444 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v446 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v442 = v446 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v449 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v449 
            #endif
#if FABLE_COMPILER_PYTHON
            let v450 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v450 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v451 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v451 
            #endif
#else
            let v452 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v442 = v452 
            #endif
            let v453 : System.DateTime = _run_target_args'_v442 
            v453
        | US2_0(v345) -> (* Some *)
            (* run_target_args'
            let v348 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v349 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v349 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v350 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v350 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v352 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v348 = v352 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v355 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v355 
            #endif
#if FABLE_COMPILER_PYTHON
            let v356 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v356 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v357 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v357 
            #endif
#else
            let v358 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v348 = v358 
            #endif
            let v359 : System.DateTime = _run_target_args'_v348 
            (* run_target_args'
            let v367 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v368 : (System.DateTime -> int64) = _.Ticks
            let v369 : int64 = v368 v359
            let _run_target_args'_v367 = v369 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v370 : (System.DateTime -> int64) = _.Ticks
            let v371 : int64 = v370 v359
            let _run_target_args'_v367 = v371 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v373 : int64 = null |> unbox<int64>
            let _run_target_args'_v367 = v373 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v376 : (System.DateTime -> int64) = _.Ticks
            let v377 : int64 = v376 v359
            let _run_target_args'_v367 = v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v378 : (System.DateTime -> int64) = _.Ticks
            let v379 : int64 = v378 v359
            let _run_target_args'_v367 = v379 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v380 : (System.DateTime -> int64) = _.Ticks
            let v381 : int64 = v380 v359
            let _run_target_args'_v367 = v381 
            #endif
#else
            let v382 : (System.DateTime -> int64) = _.Ticks
            let v383 : int64 = v382 v359
            let _run_target_args'_v367 = v383 
            #endif
            let v384 : int64 = _run_target_args'_v367 
            let v405 : int64 = v384 |> int64 
            let v408 : int64 = v405 - v345
            let v411 : System.TimeSpan = v408 |> System.TimeSpan 
            let v417 : (System.TimeSpan -> int32) = _.Hours
            let v418 : int32 = v417 v411
            let v422 : (System.TimeSpan -> int32) = _.Minutes
            let v423 : int32 = v422 v411
            let v427 : (System.TimeSpan -> int32) = _.Seconds
            let v428 : int32 = v427 v411
            let v432 : (System.TimeSpan -> int32) = _.Milliseconds
            let v433 : int32 = v432 v411
            let v437 : System.DateTime = System.DateTime (1, 1, 1, v418, v423, v428, v433)
            v437
    let v461 : string = method9()
    let v465 : bool = v461 = ""
    let v467 : string =
        if v465 then
            let v466 : string = "M-d-y hh:mm:ss tt"
            v466
        else
            v461
    let v468 : (string -> string) = v459.ToString
    let v469 : string = v468 v467
    let _run_target_args'_v165 = v469 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v484 : string = $"near_sdk::env::block_timestamp()"
    let v485 : uint64 = Fable.Core.RustInterop.emitRustExpr () v484 
    let v487 : (int64 -> US2) = method8()
    let v488 : US2 option = v5 |> Option.map v487 
    let v501 : US2 = US2_1
    let v502 : US2 = v488 |> Option.defaultValue v501 
    let v514 : uint64 =
        match v502 with
        | US2_1 -> (* None *)
            v485
        | US2_0(v506) -> (* Some *)
            let v508 : (int64 -> uint64) = uint64
            let v509 : uint64 = v508 v506
            let v512 : uint64 = v485 - v509
            v512
    let v515 : uint64 = v514 / 1000000000UL
    let v516 : uint64 = v515 % 60UL
    let v517 : uint64 = v515 / 60UL
    let v518 : uint64 = v517 % 60UL
    let v519 : uint64 = v515 / 3600UL
    let v520 : uint64 = v519 % 24UL
    let v521 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v522 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v520, v518, v516) v521 
    let v523 : string = "fable_library_rust::String_::fromString($0)"
    let v524 : string = Fable.Core.RustInterop.emitRustExpr v522 v523 
    let _run_target_args'_v165 = v524 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v526 : (int64 -> US2) = method8()
    let v527 : US2 option = v5 |> Option.map v526 
    let v540 : US2 = US2_1
    let v541 : US2 = v527 |> Option.defaultValue v540 
    let v659 : System.DateTime =
        match v541 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v642 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v643 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v643 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v644 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v644 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v646 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v642 = v646 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v649 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v649 
            #endif
#if FABLE_COMPILER_PYTHON
            let v650 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v650 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v651 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v651 
            #endif
#else
            let v652 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v642 = v652 
            #endif
            let v653 : System.DateTime = _run_target_args'_v642 
            v653
        | US2_0(v545) -> (* Some *)
            (* run_target_args'
            let v548 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v549 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v549 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v550 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v550 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v552 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v548 = v552 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v555 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v555 
            #endif
#if FABLE_COMPILER_PYTHON
            let v556 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v556 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v557 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v557 
            #endif
#else
            let v558 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v548 = v558 
            #endif
            let v559 : System.DateTime = _run_target_args'_v548 
            (* run_target_args'
            let v567 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v568 : (System.DateTime -> int64) = _.Ticks
            let v569 : int64 = v568 v559
            let _run_target_args'_v567 = v569 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v570 : (System.DateTime -> int64) = _.Ticks
            let v571 : int64 = v570 v559
            let _run_target_args'_v567 = v571 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v573 : int64 = null |> unbox<int64>
            let _run_target_args'_v567 = v573 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v576 : (System.DateTime -> int64) = _.Ticks
            let v577 : int64 = v576 v559
            let _run_target_args'_v567 = v577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v578 : (System.DateTime -> int64) = _.Ticks
            let v579 : int64 = v578 v559
            let _run_target_args'_v567 = v579 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v580 : (System.DateTime -> int64) = _.Ticks
            let v581 : int64 = v580 v559
            let _run_target_args'_v567 = v581 
            #endif
#else
            let v582 : (System.DateTime -> int64) = _.Ticks
            let v583 : int64 = v582 v559
            let _run_target_args'_v567 = v583 
            #endif
            let v584 : int64 = _run_target_args'_v567 
            let v605 : int64 = v584 |> int64 
            let v608 : int64 = v605 - v545
            let v611 : System.TimeSpan = v608 |> System.TimeSpan 
            let v617 : (System.TimeSpan -> int32) = _.Hours
            let v618 : int32 = v617 v611
            let v622 : (System.TimeSpan -> int32) = _.Minutes
            let v623 : int32 = v622 v611
            let v627 : (System.TimeSpan -> int32) = _.Seconds
            let v628 : int32 = v627 v611
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v611
            let v637 : System.DateTime = System.DateTime (1, 1, 1, v618, v623, v628, v633)
            v637
    let v661 : string = method10()
    let v665 : bool = v661 = ""
    let v667 : string =
        if v665 then
            let v666 : string = "M-d-y hh:mm:ss tt"
            v666
        else
            v661
    let v668 : (string -> string) = v659.ToString
    let v669 : string = v668 v667
    let _run_target_args'_v165 = v669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v685 : (int64 -> US2) = method8()
    let v686 : US2 option = v5 |> Option.map v685 
    let v699 : US2 = US2_1
    let v700 : US2 = v686 |> Option.defaultValue v699 
    let v818 : System.DateTime =
        match v700 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v801 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v802 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v802 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v803 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v803 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v805 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v801 = v805 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v808 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v808 
            #endif
#if FABLE_COMPILER_PYTHON
            let v809 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v809 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v810 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v810 
            #endif
#else
            let v811 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v801 = v811 
            #endif
            let v812 : System.DateTime = _run_target_args'_v801 
            v812
        | US2_0(v704) -> (* Some *)
            (* run_target_args'
            let v707 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v708 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v708 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v709 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v709 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v711 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v707 = v711 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v714 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v714 
            #endif
#if FABLE_COMPILER_PYTHON
            let v715 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v715 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v716 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v716 
            #endif
#else
            let v717 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v707 = v717 
            #endif
            let v718 : System.DateTime = _run_target_args'_v707 
            (* run_target_args'
            let v726 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v727 : (System.DateTime -> int64) = _.Ticks
            let v728 : int64 = v727 v718
            let _run_target_args'_v726 = v728 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v729 : (System.DateTime -> int64) = _.Ticks
            let v730 : int64 = v729 v718
            let _run_target_args'_v726 = v730 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v732 : int64 = null |> unbox<int64>
            let _run_target_args'_v726 = v732 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v735 : (System.DateTime -> int64) = _.Ticks
            let v736 : int64 = v735 v718
            let _run_target_args'_v726 = v736 
            #endif
#if FABLE_COMPILER_PYTHON
            let v737 : (System.DateTime -> int64) = _.Ticks
            let v738 : int64 = v737 v718
            let _run_target_args'_v726 = v738 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v739 : (System.DateTime -> int64) = _.Ticks
            let v740 : int64 = v739 v718
            let _run_target_args'_v726 = v740 
            #endif
#else
            let v741 : (System.DateTime -> int64) = _.Ticks
            let v742 : int64 = v741 v718
            let _run_target_args'_v726 = v742 
            #endif
            let v743 : int64 = _run_target_args'_v726 
            let v764 : int64 = v743 |> int64 
            let v767 : int64 = v764 - v704
            let v770 : System.TimeSpan = v767 |> System.TimeSpan 
            let v776 : (System.TimeSpan -> int32) = _.Hours
            let v777 : int32 = v776 v770
            let v781 : (System.TimeSpan -> int32) = _.Minutes
            let v782 : int32 = v781 v770
            let v786 : (System.TimeSpan -> int32) = _.Seconds
            let v787 : int32 = v786 v770
            let v791 : (System.TimeSpan -> int32) = _.Milliseconds
            let v792 : int32 = v791 v770
            let v796 : System.DateTime = System.DateTime (1, 1, 1, v777, v782, v787, v792)
            v796
    let v820 : string = method10()
    let v824 : bool = v820 = ""
    let v826 : string =
        if v824 then
            let v825 : string = "M-d-y hh:mm:ss tt"
            v825
        else
            v820
    let v827 : (string -> string) = v818.ToString
    let v828 : string = v827 v826
    let _run_target_args'_v165 = v828 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v844 : (int64 -> US2) = method8()
    let v845 : US2 option = v5 |> Option.map v844 
    let v858 : US2 = US2_1
    let v859 : US2 = v845 |> Option.defaultValue v858 
    let v977 : System.DateTime =
        match v859 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v960 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v961 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v961 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v962 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v962 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v964 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v960 = v964 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v967 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v967 
            #endif
#if FABLE_COMPILER_PYTHON
            let v968 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v968 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v969 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v969 
            #endif
#else
            let v970 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v960 = v970 
            #endif
            let v971 : System.DateTime = _run_target_args'_v960 
            v971
        | US2_0(v863) -> (* Some *)
            (* run_target_args'
            let v866 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v867 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v867 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v868 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v868 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v870 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v866 = v870 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v873 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v873 
            #endif
#if FABLE_COMPILER_PYTHON
            let v874 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v874 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v875 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v875 
            #endif
#else
            let v876 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v866 = v876 
            #endif
            let v877 : System.DateTime = _run_target_args'_v866 
            (* run_target_args'
            let v885 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v886 : (System.DateTime -> int64) = _.Ticks
            let v887 : int64 = v886 v877
            let _run_target_args'_v885 = v887 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v888 : (System.DateTime -> int64) = _.Ticks
            let v889 : int64 = v888 v877
            let _run_target_args'_v885 = v889 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v891 : int64 = null |> unbox<int64>
            let _run_target_args'_v885 = v891 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v894 : (System.DateTime -> int64) = _.Ticks
            let v895 : int64 = v894 v877
            let _run_target_args'_v885 = v895 
            #endif
#if FABLE_COMPILER_PYTHON
            let v896 : (System.DateTime -> int64) = _.Ticks
            let v897 : int64 = v896 v877
            let _run_target_args'_v885 = v897 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v898 : (System.DateTime -> int64) = _.Ticks
            let v899 : int64 = v898 v877
            let _run_target_args'_v885 = v899 
            #endif
#else
            let v900 : (System.DateTime -> int64) = _.Ticks
            let v901 : int64 = v900 v877
            let _run_target_args'_v885 = v901 
            #endif
            let v902 : int64 = _run_target_args'_v885 
            let v923 : int64 = v902 |> int64 
            let v926 : int64 = v923 - v863
            let v929 : System.TimeSpan = v926 |> System.TimeSpan 
            let v935 : (System.TimeSpan -> int32) = _.Hours
            let v936 : int32 = v935 v929
            let v940 : (System.TimeSpan -> int32) = _.Minutes
            let v941 : int32 = v940 v929
            let v945 : (System.TimeSpan -> int32) = _.Seconds
            let v946 : int32 = v945 v929
            let v950 : (System.TimeSpan -> int32) = _.Milliseconds
            let v951 : int32 = v950 v929
            let v955 : System.DateTime = System.DateTime (1, 1, 1, v936, v941, v946, v951)
            v955
    let v979 : string = method10()
    let v983 : bool = v979 = ""
    let v985 : string =
        if v983 then
            let v984 : string = "M-d-y hh:mm:ss tt"
            v984
        else
            v979
    let v986 : (string -> string) = v977.ToString
    let v987 : string = v986 v985
    let _run_target_args'_v165 = v987 
    #endif
#else
    let v1003 : (int64 -> US2) = method8()
    let v1004 : US2 option = v5 |> Option.map v1003 
    let v1017 : US2 = US2_1
    let v1018 : US2 = v1004 |> Option.defaultValue v1017 
    let v1136 : System.DateTime =
        match v1018 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1119 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1120 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1120 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1121 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1121 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1123 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1119 = v1123 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1126 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1126 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1127 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1127 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1128 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1128 
            #endif
#else
            let v1129 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1119 = v1129 
            #endif
            let v1130 : System.DateTime = _run_target_args'_v1119 
            v1130
        | US2_0(v1022) -> (* Some *)
            (* run_target_args'
            let v1025 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1026 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1027 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1027 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1029 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1025 = v1029 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1032 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1032 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1033 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1033 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1034 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1034 
            #endif
#else
            let v1035 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1025 = v1035 
            #endif
            let v1036 : System.DateTime = _run_target_args'_v1025 
            (* run_target_args'
            let v1044 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1045 : (System.DateTime -> int64) = _.Ticks
            let v1046 : int64 = v1045 v1036
            let _run_target_args'_v1044 = v1046 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1047 : (System.DateTime -> int64) = _.Ticks
            let v1048 : int64 = v1047 v1036
            let _run_target_args'_v1044 = v1048 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1050 : int64 = null |> unbox<int64>
            let _run_target_args'_v1044 = v1050 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1053 : (System.DateTime -> int64) = _.Ticks
            let v1054 : int64 = v1053 v1036
            let _run_target_args'_v1044 = v1054 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1055 : (System.DateTime -> int64) = _.Ticks
            let v1056 : int64 = v1055 v1036
            let _run_target_args'_v1044 = v1056 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1057 : (System.DateTime -> int64) = _.Ticks
            let v1058 : int64 = v1057 v1036
            let _run_target_args'_v1044 = v1058 
            #endif
#else
            let v1059 : (System.DateTime -> int64) = _.Ticks
            let v1060 : int64 = v1059 v1036
            let _run_target_args'_v1044 = v1060 
            #endif
            let v1061 : int64 = _run_target_args'_v1044 
            let v1082 : int64 = v1061 |> int64 
            let v1085 : int64 = v1082 - v1022
            let v1088 : System.TimeSpan = v1085 |> System.TimeSpan 
            let v1094 : (System.TimeSpan -> int32) = _.Hours
            let v1095 : int32 = v1094 v1088
            let v1099 : (System.TimeSpan -> int32) = _.Minutes
            let v1100 : int32 = v1099 v1088
            let v1104 : (System.TimeSpan -> int32) = _.Seconds
            let v1105 : int32 = v1104 v1088
            let v1109 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1110 : int32 = v1109 v1088
            let v1114 : System.DateTime = System.DateTime (1, 1, 1, v1095, v1100, v1105, v1110)
            v1114
    let v1138 : string = method10()
    let v1142 : bool = v1138 = ""
    let v1144 : string =
        if v1142 then
            let v1143 : string = "M-d-y hh:mm:ss tt"
            v1143
        else
            v1138
    let v1145 : (string -> string) = v1136.ToString
    let v1146 : string = v1145 v1144
    let _run_target_args'_v165 = v1146 
    #endif
    let v1161 : string = _run_target_args'_v165 
    v1161
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
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure6(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v1 : string = "Debug"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method12(v6)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "inline_colorization::color_bright_blue"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v13 
    (* run_target_args'
    let v19 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "&*$0"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v20 
    let _run_target_args'_v19 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v22 
    let _run_target_args'_v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v24 
    let _run_target_args'_v19 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v35 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v35 
    #endif
#else
    let v39 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v19 = v39 
    #endif
    let v42 : Ref<Str> = _run_target_args'_v19 
    let v48 : string = "inline_colorization::color_reset"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v14, v42, v49) v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v12 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "inline_colorization::color_bright_blue"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "&*$0"
    let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "&*$0"
    let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : Ref<Str> = _run_target_args'_v60 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v55, v83, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v12 = v94 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v95 : string = "inline_colorization::color_bright_blue"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    (* run_target_args'
    let v101 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "&*$0"
    let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v102 
    let _run_target_args'_v101 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "&*$0"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v104 
    let _run_target_args'_v101 = v105 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = "&*$0"
    let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v106 
    let _run_target_args'_v101 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v117 
    #endif
#else
    let v121 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v101 = v121 
    #endif
    let v124 : Ref<Str> = _run_target_args'_v101 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v96, v124, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v12 = v135 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : string = "\u001b[94m"
    let v137 : string = method14()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[94m"
    let v141 : string = method14()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[94m"
    let v145 : string = method14()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[94m"
    let v149 : string = method14()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method16 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v3, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v15 : string = "seed_excess_len"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure6(v3, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure6(v3, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v35 : string = $"{v0}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure6(v3, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v44 : string = "; "
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure6(v3, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v54 : string = "seed_excess"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure6(v3, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v64 : string = $"{v25}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure6(v3, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v73 : string = $"{v1}"
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure6(v3, v73)
    let v78 : unit = (fun () -> v77 (); v76) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v3, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = v3.l0
    v91
and method17 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v37 : char list = []
    let v39 : char list = '/' :: v37 
    let v43 : char list = ' ' :: v39 
    let v48 : (char list -> (char [])) = List.toArray
    let v49 : (char []) = v48 v43
    let v52 : string = v8.TrimEnd v49 
    v52
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method16(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "dice_contract.contribute_seed"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method17(v14)
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
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure7(v24)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : (string -> unit) = closure8()
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = v27.l0
    let v52 : bool = v51 = ""
    let v60 : string =
        if v52 then
            v0
        else
            let v53 : bool = v0 = ""
            if v53 then
                let v54 : string = v27.l0
                v54
            else
                let v55 : string = v27.l0
                let v56 : string = "\n"
                let v57 : string = v55 + v56 
                let v58 : string = v57 + v0 
                v58
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "&*$0"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v77 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v81 
    #endif
#else
    let v85 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v85 
    #endif
    let v88 : Ref<Str> = _run_target_args'_v65 
    let v94 : string = $"$0.chars()"
    let v95 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let v96 : string = "$0"
    let v97 : _ = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.collect::<Vec<_>>()"
    let v99 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v101 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : string = "x"
    let v105 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v104 
    let v106 : string = "String::from_iter($0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "true; $0 }).collect::<Vec<_>>()"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "_vec_map"
    let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v110 
    let v112 : string = "$0.len()"
    let v113 : unativeint = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v119 : int32 = v113 |> int32 
    let v129 : string = ""
    let v130 : bool = v0 <> v129 
    let v134 : bool =
        if v130 then
            let v133 : bool = v119 <= 1
            v133
        else
            false
    if v134 then
        v27.l0 <- v60
        ()
    else
        v27.l0 <- v129
        let v135 : string = "true; $0.into_iter().for_each(|x| { //"
        let v136 : bool = Fable.Core.RustInterop.emitRustExpr v111 v135 
        let v137 : string = "x"
        let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v137 
        let v139 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v140 : bool = Fable.Core.RustInterop.emitRustExpr v138 v139 
        let v141 : string = $"true"
        let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
        let v143 : string = "true; }); //"
        let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v47 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#else
    v47 v0
    #endif
    // run_target_args' is_unit
    let v145 : (string -> unit) = v25.l0
    v145 v0
and closure1 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure2()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method7(v27, v28, v29, v30, v31, v32)
        let v46 : string = method11()
        let v48 : string = $"%A{v1}"
        let v51 : string = method15(v27, v28, v29, v30, v31, v32, v45, v46, v0, v48)
        method18(v51)
and closure10 () () : unit =
    ()
and method19 () : (unit -> unit) =
    closure10()
and method20 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure2()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : Mut4, v28 : int64 option) = TraceState.trace_state.Value
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure7(v23)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v46 : string = ""
    let v47 : (string -> unit) = closure8()
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v46 v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v46 v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = v26.l0
    let v52 : bool = v51 = ""
    let v60 : string =
        if v52 then
            v46
        else
            let v53 : bool = v46 = ""
            if v53 then
                let v54 : string = v26.l0
                v54
            else
                let v55 : string = v26.l0
                let v56 : string = "\n"
                let v57 : string = v55 + v56 
                let v58 : string = v57 + v46 
                v58
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "&*$0"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v77 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v81 
    #endif
#else
    let v85 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v85 
    #endif
    let v88 : Ref<Str> = _run_target_args'_v65 
    let v94 : string = $"$0.chars()"
    let v95 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let v96 : string = "$0"
    let v97 : _ = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.collect::<Vec<_>>()"
    let v99 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v101 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : string = "x"
    let v105 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v104 
    let v106 : string = "String::from_iter($0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "true; $0 }).collect::<Vec<_>>()"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "_vec_map"
    let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v110 
    let v112 : string = "$0.len()"
    let v113 : unativeint = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v119 : int32 = v113 |> int32 
    let v128 : bool = v46 <> v46 
    let v132 : bool =
        if v128 then
            let v131 : bool = v119 <= 1
            v131
        else
            false
    if v132 then
        v26.l0 <- v60
        ()
    else
        v26.l0 <- v46
        let v133 : string = "true; $0.into_iter().for_each(|x| { //"
        let v134 : bool = Fable.Core.RustInterop.emitRustExpr v111 v133 
        let v135 : string = "x"
        let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v135 
        let v137 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v138 : bool = Fable.Core.RustInterop.emitRustExpr v136 v137 
        let v139 : string = $"true"
        let v140 : bool = Fable.Core.RustInterop.emitRustExpr () v139 
        let v141 : string = "true; }); //"
        let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v47 v46
    #endif
#if FABLE_COMPILER_PYTHON
    v47 v46
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v47 v46
    #endif
#else
    v47 v46
    #endif
    // run_target_args' is_unit
    let v143 : (string -> unit) = v24.l0
    v143 v46
and closure11 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
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
        let v6 : uint8 list = v2 :: v4 
        v6
    | UH0_0 -> (* Nil *)
        v1
and method27 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : std_string_String, v9 : string, v10 : string, v11 : unativeint, v12 : string, v13 : string, v14 : string) : string =
    let v15 : string = method13()
    let v16 : Mut3 = {l0 = v15} : Mut3
    let v18 : string = "{ "
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure6(v16, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v28 : string = "max"
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure6(v16, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    let v38 : string = " = "
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure6(v16, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v48 : string = $"{v0}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure6(v16, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v57 : string = "; "
    let v58 : string = $"{v57}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v16, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v67 : string = "key"
    let v68 : string = $"{v67}"
    let v71 : unit = ()
    let v72 : (unit -> unit) = closure6(v16, v68)
    let v73 : unit = (fun () -> v72 (); v71) ()
    let v77 : string = $"{v38}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure6(v16, v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    (* run_target_args'
    let v89 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "format!(\"{:#?}\", $0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v90 
    let v92 : string = "fable_library_rust::String_::fromString($0)"
    let v93 : string = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let _run_target_args'_v89 = v93 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v94 : string = "format!(\"{:#?}\", $0)"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v94 
    let v96 : string = "fable_library_rust::String_::fromString($0)"
    let v97 : string = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let _run_target_args'_v89 = v97 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v98 : string = "format!(\"{:#?}\", $0)"
    let v99 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v98 
    let v100 : string = "fable_library_rust::String_::fromString($0)"
    let v101 : string = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let _run_target_args'_v89 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : string = $"%A{v1}"
    let _run_target_args'_v89 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : string = $"%A{v1}"
    let _run_target_args'_v89 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : string = $"%A{v1}"
    let _run_target_args'_v89 = v111 
    #endif
#else
    let v115 : string = $"%A{v1}"
    let _run_target_args'_v89 = v115 
    #endif
    let v118 : string = _run_target_args'_v89 
    let v125 : string = $"{v118}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v16, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v134 : string = $"{v57}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure6(v16, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v143 : string = "proof"
    let v144 : string = $"{v143}"
    let v147 : unit = ()
    let v148 : (unit -> unit) = closure6(v16, v144)
    let v149 : unit = (fun () -> v148 (); v147) ()
    let v153 : string = $"{v38}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure6(v16, v153)
    let v158 : unit = (fun () -> v157 (); v156) ()
    (* run_target_args'
    let v165 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v166 : string = "format!(\"{:#?}\", $0)"
    let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v166 
    let v168 : string = "fable_library_rust::String_::fromString($0)"
    let v169 : string = Fable.Core.RustInterop.emitRustExpr v167 v168 
    let _run_target_args'_v165 = v169 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v170 : string = "format!(\"{:#?}\", $0)"
    let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v170 
    let v172 : string = "fable_library_rust::String_::fromString($0)"
    let v173 : string = Fable.Core.RustInterop.emitRustExpr v171 v172 
    let _run_target_args'_v165 = v173 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v174 : string = "format!(\"{:#?}\", $0)"
    let v175 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v174 
    let v176 : string = "fable_library_rust::String_::fromString($0)"
    let v177 : string = Fable.Core.RustInterop.emitRustExpr v175 v176 
    let _run_target_args'_v165 = v177 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v179 : string = $"%A{v2}"
    let _run_target_args'_v165 = v179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v183 : string = $"%A{v2}"
    let _run_target_args'_v165 = v183 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v187 : string = $"%A{v2}"
    let _run_target_args'_v165 = v187 
    #endif
#else
    let v191 : string = $"%A{v2}"
    let _run_target_args'_v165 = v191 
    #endif
    let v194 : string = _run_target_args'_v165 
    let v201 : string = $"{v194}"
    let v204 : unit = ()
    let v205 : (unit -> unit) = closure6(v16, v201)
    let v206 : unit = (fun () -> v205 (); v204) ()
    let v210 : string = $"{v57}"
    let v213 : unit = ()
    let v214 : (unit -> unit) = closure6(v16, v210)
    let v215 : unit = (fun () -> v214 (); v213) ()
    let v219 : string = "block_timestamp"
    let v220 : string = $"{v219}"
    let v223 : unit = ()
    let v224 : (unit -> unit) = closure6(v16, v220)
    let v225 : unit = (fun () -> v224 (); v223) ()
    let v229 : string = $"{v38}"
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure6(v16, v229)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v238 : string = $"{v3}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure6(v16, v238)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v247 : string = $"{v57}"
    let v250 : unit = ()
    let v251 : (unit -> unit) = closure6(v16, v247)
    let v252 : unit = (fun () -> v251 (); v250) ()
    let v256 : string = "block_height"
    let v257 : string = $"{v256}"
    let v260 : unit = ()
    let v261 : (unit -> unit) = closure6(v16, v257)
    let v262 : unit = (fun () -> v261 (); v260) ()
    let v266 : string = $"{v38}"
    let v269 : unit = ()
    let v270 : (unit -> unit) = closure6(v16, v266)
    let v271 : unit = (fun () -> v270 (); v269) ()
    let v275 : string = $"{v4}"
    let v278 : unit = ()
    let v279 : (unit -> unit) = closure6(v16, v275)
    let v280 : unit = (fun () -> v279 (); v278) ()
    let v284 : string = $"{v57}"
    let v287 : unit = ()
    let v288 : (unit -> unit) = closure6(v16, v284)
    let v289 : unit = (fun () -> v288 (); v287) ()
    let v293 : string = "epoch_height"
    let v294 : string = $"{v293}"
    let v297 : unit = ()
    let v298 : (unit -> unit) = closure6(v16, v294)
    let v299 : unit = (fun () -> v298 (); v297) ()
    let v303 : string = $"{v38}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure6(v16, v303)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v312 : string = $"{v5}"
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure6(v16, v312)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v321 : string = $"{v57}"
    let v324 : unit = ()
    let v325 : (unit -> unit) = closure6(v16, v321)
    let v326 : unit = (fun () -> v325 (); v324) ()
    let v330 : string = "account_balance"
    let v331 : string = $"{v330}"
    let v334 : unit = ()
    let v335 : (unit -> unit) = closure6(v16, v331)
    let v336 : unit = (fun () -> v335 (); v334) ()
    let v340 : string = $"{v38}"
    let v343 : unit = ()
    let v344 : (unit -> unit) = closure6(v16, v340)
    let v345 : unit = (fun () -> v344 (); v343) ()
    let v349 : string = $"{v6}"
    let v352 : unit = ()
    let v353 : (unit -> unit) = closure6(v16, v349)
    let v354 : unit = (fun () -> v353 (); v352) ()
    let v358 : string = $"{v57}"
    let v361 : unit = ()
    let v362 : (unit -> unit) = closure6(v16, v358)
    let v363 : unit = (fun () -> v362 (); v361) ()
    let v367 : string = "signer_account_id"
    let v368 : string = $"{v367}"
    let v371 : unit = ()
    let v372 : (unit -> unit) = closure6(v16, v368)
    let v373 : unit = (fun () -> v372 (); v371) ()
    let v377 : string = $"{v38}"
    let v380 : unit = ()
    let v381 : (unit -> unit) = closure6(v16, v377)
    let v382 : unit = (fun () -> v381 (); v380) ()
    (* run_target_args'
    let v389 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : string = "format!(\"{:#?}\", $0)"
    let v391 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v390 
    let v392 : string = "fable_library_rust::String_::fromString($0)"
    let v393 : string = Fable.Core.RustInterop.emitRustExpr v391 v392 
    let _run_target_args'_v389 = v393 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v394 : string = "format!(\"{:#?}\", $0)"
    let v395 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v394 
    let v396 : string = "fable_library_rust::String_::fromString($0)"
    let v397 : string = Fable.Core.RustInterop.emitRustExpr v395 v396 
    let _run_target_args'_v389 = v397 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v398 : string = "format!(\"{:#?}\", $0)"
    let v399 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v398 
    let v400 : string = "fable_library_rust::String_::fromString($0)"
    let v401 : string = Fable.Core.RustInterop.emitRustExpr v399 v400 
    let _run_target_args'_v389 = v401 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v403 : string = $"%A{v7}"
    let _run_target_args'_v389 = v403 
    #endif
#if FABLE_COMPILER_PYTHON
    let v407 : string = $"%A{v7}"
    let _run_target_args'_v389 = v407 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v411 : string = $"%A{v7}"
    let _run_target_args'_v389 = v411 
    #endif
#else
    let v415 : string = $"%A{v7}"
    let _run_target_args'_v389 = v415 
    #endif
    let v418 : string = _run_target_args'_v389 
    let v425 : string = $"{v418}"
    let v428 : unit = ()
    let v429 : (unit -> unit) = closure6(v16, v425)
    let v430 : unit = (fun () -> v429 (); v428) ()
    let v434 : string = $"{v57}"
    let v437 : unit = ()
    let v438 : (unit -> unit) = closure6(v16, v434)
    let v439 : unit = (fun () -> v438 (); v437) ()
    let v443 : string = "predecessor_account_id"
    let v444 : string = $"{v443}"
    let v447 : unit = ()
    let v448 : (unit -> unit) = closure6(v16, v444)
    let v449 : unit = (fun () -> v448 (); v447) ()
    let v453 : string = $"{v38}"
    let v456 : unit = ()
    let v457 : (unit -> unit) = closure6(v16, v453)
    let v458 : unit = (fun () -> v457 (); v456) ()
    (* run_target_args'
    let v465 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v466 : string = "format!(\"{:#?}\", $0)"
    let v467 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v466 
    let v468 : string = "fable_library_rust::String_::fromString($0)"
    let v469 : string = Fable.Core.RustInterop.emitRustExpr v467 v468 
    let _run_target_args'_v465 = v469 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v470 : string = "format!(\"{:#?}\", $0)"
    let v471 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v470 
    let v472 : string = "fable_library_rust::String_::fromString($0)"
    let v473 : string = Fable.Core.RustInterop.emitRustExpr v471 v472 
    let _run_target_args'_v465 = v473 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v474 : string = "format!(\"{:#?}\", $0)"
    let v475 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v474 
    let v476 : string = "fable_library_rust::String_::fromString($0)"
    let v477 : string = Fable.Core.RustInterop.emitRustExpr v475 v476 
    let _run_target_args'_v465 = v477 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v479 : string = $"%A{v8}"
    let _run_target_args'_v465 = v479 
    #endif
#if FABLE_COMPILER_PYTHON
    let v483 : string = $"%A{v8}"
    let _run_target_args'_v465 = v483 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v487 : string = $"%A{v8}"
    let _run_target_args'_v465 = v487 
    #endif
#else
    let v491 : string = $"%A{v8}"
    let _run_target_args'_v465 = v491 
    #endif
    let v494 : string = _run_target_args'_v465 
    let v501 : string = $"{v494}"
    let v504 : unit = ()
    let v505 : (unit -> unit) = closure6(v16, v501)
    let v506 : unit = (fun () -> v505 (); v504) ()
    let v510 : string = $"{v57}"
    let v513 : unit = ()
    let v514 : (unit -> unit) = closure6(v16, v510)
    let v515 : unit = (fun () -> v514 (); v513) ()
    let v519 : string = "seed"
    let v520 : string = $"{v519}"
    let v523 : unit = ()
    let v524 : (unit -> unit) = closure6(v16, v520)
    let v525 : unit = (fun () -> v524 (); v523) ()
    let v529 : string = $"{v38}"
    let v532 : unit = ()
    let v533 : (unit -> unit) = closure6(v16, v529)
    let v534 : unit = (fun () -> v533 (); v532) ()
    let v538 : string = $"{v9}"
    let v541 : unit = ()
    let v542 : (unit -> unit) = closure6(v16, v538)
    let v543 : unit = (fun () -> v542 (); v541) ()
    let v547 : string = $"{v57}"
    let v550 : unit = ()
    let v551 : (unit -> unit) = closure6(v16, v547)
    let v552 : unit = (fun () -> v551 (); v550) ()
    let v556 : string = "seeds"
    let v557 : string = $"{v556}"
    let v560 : unit = ()
    let v561 : (unit -> unit) = closure6(v16, v557)
    let v562 : unit = (fun () -> v561 (); v560) ()
    let v566 : string = $"{v38}"
    let v569 : unit = ()
    let v570 : (unit -> unit) = closure6(v16, v566)
    let v571 : unit = (fun () -> v570 (); v569) ()
    let v575 : string = $"{v10}"
    let v578 : unit = ()
    let v579 : (unit -> unit) = closure6(v16, v575)
    let v580 : unit = (fun () -> v579 (); v578) ()
    let v584 : string = $"{v57}"
    let v587 : unit = ()
    let v588 : (unit -> unit) = closure6(v16, v584)
    let v589 : unit = (fun () -> v588 (); v587) ()
    let v593 : string = "entropy_len"
    let v594 : string = $"{v593}"
    let v597 : unit = ()
    let v598 : (unit -> unit) = closure6(v16, v594)
    let v599 : unit = (fun () -> v598 (); v597) ()
    let v603 : string = $"{v38}"
    let v606 : unit = ()
    let v607 : (unit -> unit) = closure6(v16, v603)
    let v608 : unit = (fun () -> v607 (); v606) ()
    (* run_target_args'
    let v615 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v616 : string = "format!(\"{:#?}\", $0)"
    let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v616 
    let v618 : string = "fable_library_rust::String_::fromString($0)"
    let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
    let _run_target_args'_v615 = v619 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v620 : string = "format!(\"{:#?}\", $0)"
    let v621 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v620 
    let v622 : string = "fable_library_rust::String_::fromString($0)"
    let v623 : string = Fable.Core.RustInterop.emitRustExpr v621 v622 
    let _run_target_args'_v615 = v623 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v624 : string = "format!(\"{:#?}\", $0)"
    let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v624 
    let v626 : string = "fable_library_rust::String_::fromString($0)"
    let v627 : string = Fable.Core.RustInterop.emitRustExpr v625 v626 
    let _run_target_args'_v615 = v627 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v629 : string = $"%A{v11}"
    let _run_target_args'_v615 = v629 
    #endif
#if FABLE_COMPILER_PYTHON
    let v633 : string = $"%A{v11}"
    let _run_target_args'_v615 = v633 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v637 : string = $"%A{v11}"
    let _run_target_args'_v615 = v637 
    #endif
#else
    let v641 : string = $"%A{v11}"
    let _run_target_args'_v615 = v641 
    #endif
    let v644 : string = _run_target_args'_v615 
    let v651 : string = $"{v644}"
    let v654 : unit = ()
    let v655 : (unit -> unit) = closure6(v16, v651)
    let v656 : unit = (fun () -> v655 (); v654) ()
    let v660 : string = $"{v57}"
    let v663 : unit = ()
    let v664 : (unit -> unit) = closure6(v16, v660)
    let v665 : unit = (fun () -> v664 (); v663) ()
    let v669 : string = "entropy"
    let v670 : string = $"{v669}"
    let v673 : unit = ()
    let v674 : (unit -> unit) = closure6(v16, v670)
    let v675 : unit = (fun () -> v674 (); v673) ()
    let v679 : string = $"{v38}"
    let v682 : unit = ()
    let v683 : (unit -> unit) = closure6(v16, v679)
    let v684 : unit = (fun () -> v683 (); v682) ()
    let v688 : string = $"{v12}"
    let v691 : unit = ()
    let v692 : (unit -> unit) = closure6(v16, v688)
    let v693 : unit = (fun () -> v692 (); v691) ()
    let v697 : string = $"{v57}"
    let v700 : unit = ()
    let v701 : (unit -> unit) = closure6(v16, v697)
    let v702 : unit = (fun () -> v701 (); v700) ()
    let v706 : string = "hash_u8"
    let v707 : string = $"{v706}"
    let v710 : unit = ()
    let v711 : (unit -> unit) = closure6(v16, v707)
    let v712 : unit = (fun () -> v711 (); v710) ()
    let v716 : string = $"{v38}"
    let v719 : unit = ()
    let v720 : (unit -> unit) = closure6(v16, v716)
    let v721 : unit = (fun () -> v720 (); v719) ()
    let v725 : string = $"{v13}"
    let v728 : unit = ()
    let v729 : (unit -> unit) = closure6(v16, v725)
    let v730 : unit = (fun () -> v729 (); v728) ()
    let v734 : string = $"{v57}"
    let v737 : unit = ()
    let v738 : (unit -> unit) = closure6(v16, v734)
    let v739 : unit = (fun () -> v738 (); v737) ()
    let v743 : string = "rolls"
    let v744 : string = $"{v743}"
    let v747 : unit = ()
    let v748 : (unit -> unit) = closure6(v16, v744)
    let v749 : unit = (fun () -> v748 (); v747) ()
    let v753 : string = $"{v38}"
    let v756 : unit = ()
    let v757 : (unit -> unit) = closure6(v16, v753)
    let v758 : unit = (fun () -> v757 (); v756) ()
    let v762 : string = $"{v14}"
    let v765 : unit = ()
    let v766 : (unit -> unit) = closure6(v16, v762)
    let v767 : unit = (fun () -> v766 (); v765) ()
    let v771 : string = " }"
    let v772 : string = $"{v771}"
    let v775 : unit = ()
    let v776 : (unit -> unit) = closure6(v16, v772)
    let v777 : unit = (fun () -> v776 (); v775) ()
    let v780 : string = v16.l0
    v780
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method27(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v24 : int64 = v0.l0
    let v26 : string = "dice_contract.generate_random_number"
    let v27 : string = $"{v6} {v7} #{v24} %s{v26} / {v23}"
    method17(v27)
and closure16 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v14 : US0 = US0_1
    let v15 : bool = method0(v14)
    if v15 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure2()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = TraceState.trace_state.Value
        let v57 : string = method7(v39, v40, v41, v42, v43, v44)
        let v58 : string = method11()
        let v60 : string = $"%A{v8}"
        let v63 : string = $"v9.to_string()"
        let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v63 
        let v65 : string = $"v10.to_string()"
        let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v65 
        let v68 : string = $"%A{v4}"
        let v72 : string = $"%A{v0}"
        let v75 : string = "$0.len()"
        let v76 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v75 
        let v78 : string = $"%A{v11}"
        let v82 : string = $"%A{v12}"
        let v85 : uint8 list = []
        let v86 : uint8 list = method25(v13, v85)
        let v88 : (uint8 list -> (uint8 [])) = List.toArray
        let v89 : (uint8 []) = v88 v86
        let v92 : string = "$0.to_vec()"
        let v93 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v89 v92 
        let v95 : string = $"%A{v93}"
        let v98 : string = method26(v39, v40, v41, v42, v43, v44, v57, v58, v3, v1, v2, v7, v6, v5, v60, v64, v66, v68, v72, v76, v78, v82, v95)
        method18(v98)
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
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "max"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure6(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure6(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure6(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure6(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "p"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure6(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "n"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure6(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure6(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure6(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method33(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.calculate_dice_count"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method17(v15)
and closure19 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method7(v28, v29, v30, v31, v32, v33)
        let v47 : string = method11()
        let v48 : string = method32(v28, v29, v30, v31, v32, v33, v46, v47, v0, v2, v1)
        method18(v48)
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
        let v58 : unit = ()
        let v59 : (unit -> unit) = closure19(v0, v1, v2)
        let v60 : unit = (fun () -> v59 (); v58) ()
        v1
and method37 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure6(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "current_index"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure6(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure6(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure6(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure6(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "acc"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure6(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure6(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "len"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure6(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure6(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure6(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "last_item"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure6(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure6(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure6(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure6(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method37(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.create_sequential_roller / roll"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method17(v16)
and closure20 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure2()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method7(v29, v30, v31, v32, v33, v34)
        let v48 : string = method11()
        let v50 : string = $"%A{v3}"
        let v53 : string = method36(v29, v30, v31, v32, v33, v34, v47, v48, v0, v1, v2, v50)
        method18(v53)
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
    let v11 : string = "dice.create_sequential_roller / roll / None"
    let v12 : string = $"{v6} {v7} #{v9} %s{v11} / {v8}"
    method17(v12)
and closure21 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure2()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v25 : Mut0, v26 : Mut1, v27 : Mut2, v28 : Mut3, v29 : Mut4, v30 : int64 option) = TraceState.trace_state.Value
        let v43 : string = method7(v25, v26, v27, v28, v29, v30)
        let v44 : string = method11()
        let v45 : string = method39(v25, v26, v27, v28, v29, v30, v43, v44)
        method18(v45)
and method35 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US7 = v4.l0
    let v16 : uint8 option =
        match v8 with
        | US7_1 -> (* None *)
            let v14 : uint8 option = None
            v14
        | US7_0(v9) -> (* Some *)
            let v11 : uint8 option = Some v9 
            v11
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure20(v5, v6, v7, v16)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v70 : UH1 = v0 ()
    let v71 : int64 = v1.l0
    let v72 : US7 = method38(v71, v70)
    match v72 with
    | US7_1 -> (* None *)
        let v77 : unit = ()
        let v78 : (unit -> unit) = closure21()
        let v79 : unit = (fun () -> v78 (); v77) ()
        let v126 : int64 = v3.l0
        let v127 : bool = v126 = -1L
        if v127 then
            let v128 : int64 = v1.l0
            v3.l0 <- v128
            ()
        let v129 : int64 = v2.l0
        let v130 : int64 = v3.l0
        let v131 : bool = v129 >= v130
        let v134 : int64 =
            if v131 then
                1L
            else
                let v132 : int64 = v2.l0
                let v133 : int64 = v132 + 1L
                v133
        v2.l0 <- v134
        let v135 : int64 = v2.l0
        let v136 : int64 = v135 - 1L
        v1.l0 <- v136
        let v137 : US7 = US7_1
        v4.l0 <- v137
        method35(v0, v1, v2, v3, v4)
    | US7_0(v73) -> (* Some *)
        let v74 : int64 = v1.l0
        let v75 : int64 = v74 + 1L
        v1.l0 <- v75
        let v76 : US7 = US7_0(v73)
        v4.l0 <- v76
        v73
and method43 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "power"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure6(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure6(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure6(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure6(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "acc"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure6(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure6(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure6(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure6(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method43(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method17(v15)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method7(v28, v29, v30, v31, v32, v33)
        let v47 : string = method11()
        let v48 : string = method42(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method18(v48)
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
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure6(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "power"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure6(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure6(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure6(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure6(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "acc"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure6(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure6(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "roll"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure6(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure6(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure6(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "value"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure6(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure6(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure6(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure6(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method45 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method46(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method17(v16)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure2()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method7(v29, v30, v31, v32, v33, v34)
        let v48 : string = method11()
        let v49 : string = method45(v29, v30, v31, v32, v33, v34, v47, v48, v1, v0, v2, v3)
        method18(v49)
and method48 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "power"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure6(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure6(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure6(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure6(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "acc"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure6(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "roll"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure6(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure6(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure6(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method47 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method48(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method17(v15)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method7(v28, v29, v30, v31, v32, v33)
        let v47 : string = method11()
        let v48 : string = method47(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method18(v48)
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
        | UH0_1(v56, v57) -> (* Cons *)
            let v58 : bool = v56 > 1uy
            if v58 then
                let v59 : uint64 = 1UL
                let v60 : (unit -> UH2) = closure23()
                let v61 : UH2 = UH2_0(v59, v60)
                let v62 : US9 = method44(v0, v61)
                let v66 : uint64 =
                    match v62 with
                    | US9_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US9_0(v63) -> (* Some *)
                        v63
                let v67 : uint8 = v56 - 1uy
                let v68 : uint64 = uint64 v67
                let v69 : uint64 = v68 * v66
                let v70 : unit = ()
                let v71 : (unit -> unit) = closure87(v2, v0, v56, v69)
                let v72 : unit = (fun () -> v71 (); v70) ()
                let v119 : uint64 = v2 + v69
                let v120 : int8 = v0 - 1y
                method41(v120, v57, v119)
            else
                let v122 : unit = ()
                let v123 : (unit -> unit) = closure88(v2, v0, v56)
                let v124 : unit = (fun () -> v123 (); v122) ()
                let v171 : int8 = v0 - 1y
                method41(v171, v57, v2)
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
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
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
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "max"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure6(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure6(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure6(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure6(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "rolls"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure6(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure6(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure6(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure6(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method53 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method54(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice_contract.roll_within_bounds"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method17(v15)
and closure90 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut0, v29 : Mut1, v30 : Mut2, v31 : Mut3, v32 : Mut4, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method7(v28, v29, v30, v31, v32, v33)
        let v47 : string = method11()
        let v49 : string = $"%A{v1}"
        let v53 : string = $"%A{v2}"
        let v56 : string = method53(v28, v29, v30, v31, v32, v33, v46, v47, v0, v49, v53)
        method18(v56)
and method55 () : (unit -> unit) =
    closure10()
and closure91 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
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
    let v19 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v22 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "        Self((old_state.version + 1, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "true; /*"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v35 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v38 : string = "true; */"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "seeds"
    let v41 : string = "b\"" + v40 + "\""
    let v42 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "near_sdk::store::vec::Vector::new($0)"
    let v44 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _result = struct (2u, v44) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v45 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v51 : bool = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v54 
    let v55 : string = $"&mut self.0.1"
    let v56 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = $"seed"
    let v58 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "true; v56.extend($0); //"
    let v60 : bool = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = $"v56.len()"
    let v62 : uint32 = Fable.Core.RustInterop.emitRustExpr () v61 
    let v68 : int32 = v62 |> int32 
    let v77 : unativeint = 100 |> unativeint 
    let v85 : int32 = v77 |> int32 
    let v93 : int32 = v68 - v85
    let v94 : bool = v93 > 0
    if v94 then
        let v95 : string = "v56.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v96 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v93 v95 
        let v97 : unit = ()
        let v98 : (unit -> unit) = closure1(v93, v96)
        let v99 : unit = (fun () -> v98 (); v97) ()
        ()
    let v150 : (unit -> unit) = method19()
    let v151 : unit = ()
    let v152 : (unit -> unit) = closure11(v150)
    let v153 : unit = (fun () -> v152 (); v151) ()
    let v199 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v199 
    let v200 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v200 
    let v201 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v201 
    let v202 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v202 
    let v203 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v204 : bool = Fable.Core.RustInterop.emitRustExpr () v203 
    let v205 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v206 : bool = Fable.Core.RustInterop.emitRustExpr () v205 
    let v207 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v207 
    let v208 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v208 
    let v209 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v209 
    let v210 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v210 
    let v211 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v211 
    let v212 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v212 
    let v213 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v214 : bool = Fable.Core.RustInterop.emitRustExpr () v213 
    let v215 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v216 : bool = Fable.Core.RustInterop.emitRustExpr () v215 
    let v217 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v217 
    let v218 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v218 
    let v219 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v219 
    let v220 : string = $"key"
    let v221 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v220 
    let v222 : string = $"proof"
    let v223 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v222 
    let v224 : string = $"max"
    let v225 : uint64 = Fable.Core.RustInterop.emitRustExpr () v224 
    let v226 : string = $"&mut self.0.1"
    let v227 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v226 
    let v228 : string = $"near_sdk::env::random_seed()"
    let v229 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = $"near_sdk::env::epoch_height()"
    let v231 : uint64 = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = $"near_sdk::env::block_height()"
    let v233 : uint64 = Fable.Core.RustInterop.emitRustExpr () v232 
    let v234 : string = $"near_sdk::env::block_timestamp()"
    let v235 : uint64 = Fable.Core.RustInterop.emitRustExpr () v234 
    let v236 : string = $"near_sdk::env::account_balance()"
    let v237 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v236 
    let v238 : string = $"near_sdk::env::signer_account_id()"
    let v239 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v238 
    let v240 : string = $"near_sdk::env::predecessor_account_id()"
    let v241 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v240 
    let v242 : string = $"&*v227"
    let v243 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v242 
    let v244 : string = $"v243.iter().map(|x| *x).collect::<Vec<_>>()"
    let v245 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v244 
    let v246 : string = $"v231.to_le_bytes()"
    let v247 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v246 
    let v248 : string = $"v247.to_vec()"
    let v249 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v248 
    let v250 : string = $"v233.to_le_bytes()"
    let v251 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v250 
    let v252 : string = $"v251.to_vec()"
    let v253 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v252 
    let v254 : string = $"v235.to_le_bytes()"
    let v255 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v254 
    let v256 : string = $"v255.to_vec()"
    let v257 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v256 
    let v258 : string = "$0.as_yoctonear()"
    let v259 : u128 = Fable.Core.RustInterop.emitRustExpr v237 v258 
    let v260 : string = $"v259.to_le_bytes()"
    let v261 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v260 
    let v262 : string = $"v261.to_vec()"
    let v263 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = $"v239.as_bytes()"
    let v265 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v264 
    let v266 : string = $"v265.to_vec()"
    let v267 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v266 
    let v268 : string = $"v241.as_bytes()"
    let v269 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v268 
    let v270 : string = $"v269.to_vec()"
    let v271 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v270 
    let v272 : string = $"$0.into_bytes()"
    let v273 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v223 v272 
    let v274 : string = $"$0.into_bytes()"
    let v275 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v221 v274 
    let v276 : (Vec<uint8> []) = [|v229; v245; v249; v253; v257; v263; v267; v271; v273; v275|]
    let v277 : string = "$0.to_vec()"
    let v278 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v276 v277 
    let v279 : string = $"v278.concat()"
    let v280 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v279 
    let v281 : string = $"near_sdk::env::keccak512(&$0)"
    let v282 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v280 v281 
    let v283 : string = "true; v227.extend($0); //"
    let v284 : bool = Fable.Core.RustInterop.emitRustExpr v282 v283 
    let v285 : string = $"v227.len()"
    let v286 : uint32 = Fable.Core.RustInterop.emitRustExpr () v285 
    let v292 : int32 = v286 |> int32 
    let v301 : unativeint = 100 |> unativeint 
    let v309 : int32 = v301 |> int32 
    let v317 : int32 = v292 - v309
    let v318 : bool = v317 > 0
    if v318 then
        let v319 : string = "v227.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v320 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v317 v319 
        let v321 : unit = ()
        let v322 : (unit -> unit) = closure1(v317, v320)
        let v323 : unit = (fun () -> v322 (); v321) ()
        ()
    let v374 : (unit -> unit) = method19()
    let v375 : unit = ()
    let v376 : (unit -> unit) = closure11(v374)
    let v377 : unit = (fun () -> v376 (); v375) ()
    let v423 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v424 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v282 v423 
    let v426 : uint8 list = v424 |> Array.toList
    let v430 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v431 : (uint8 -> (UH0 -> UH0)) = method21()
    let v432 : (uint8 list -> (UH0 -> UH0)) = v430 v431
    let v433 : (UH0 -> UH0) = v432 v426
    let v434 : UH0 = UH0_0
    let v435 : UH0 = v433 v434
    let v460 : UH1 = UH1_1
    let v461 : UH1 = method22(v435, v460)
    let v462 : UH1 = UH1_1
    let v463 : UH1 = method23(v461, v462)
    let v464 : UH0 = UH0_0
    let v465 : UH0 = method24(v463, v464)
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure16(v227, v221, v223, v225, v229, v231, v233, v235, v237, v239, v241, v280, v282, v465)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v554 : UH0 = UH0_0
    let v555 : UH0 = method28(v465, v554)
    let v556 : UH0 = method29(v465, v555)
    let v557 : UH1 = UH1_1
    let v558 : UH1 = method22(v556, v557)
    let v559 : (unit -> UH1) = closure17(v558)
    let v560 : (unit -> UH1) = method30(v558, v559)
    let v561 : Mut0 = {l0 = 0L} : Mut0
    let v562 : Mut0 = {l0 = 1L} : Mut0
    let v563 : Mut0 = {l0 = -1L} : Mut0
    let v564 : US7 = US7_1
    let v565 : Mut6 = {l0 = v564} : Mut6
    let v566 : bool = v225 = 1UL
    let v570 : int8 =
        if v566 then
            1y
        else
            let v567 : int8 = 0y
            let v568 : uint64 = 1UL
            method31(v225, v567, v568)
    let v571 : int8 = v570 - 1y
    let v572 : UH0 = UH0_0
    let v573 : int8 = 0y
    let v574 : uint64 = method34(v560, v561, v562, v563, v565, v225, v571, v572, v573)
    let v575 : (unit -> unit) = method51()
    let v576 : unit = ()
    let v577 : (unit -> unit) = closure89(v575)
    let v578 : unit = (fun () -> v577 (); v576) ()
    let v624 : string = "v574 //"
    Fable.Core.RustInterop.emitRustExpr () v624 
    let v625 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v625 
    let v626 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v626 
    let v627 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v627 
    let v628 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v628 
    let v629 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v630 : bool = Fable.Core.RustInterop.emitRustExpr () v629 
    let v631 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v632 : bool = Fable.Core.RustInterop.emitRustExpr () v631 
    let v633 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v633 
    let v634 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v634 
    let v635 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v635 
    let v636 : string = $"max"
    let v637 : uint64 = Fable.Core.RustInterop.emitRustExpr () v636 
    let v638 : string = $"rolls"
    let v639 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v638 
    let v640 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v641 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v639 v640 
    let v643 : uint8 list = v641 |> Array.toList
    let v647 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v648 : (uint8 -> (UH0 -> UH0)) = method21()
    let v649 : (uint8 list -> (UH0 -> UH0)) = v647 v648
    let v650 : (UH0 -> UH0) = v649 v643
    let v651 : UH0 = UH0_0
    let v652 : UH0 = v650 v651
    let v677 : int8 = 0y
    let v678 : int8 = method52(v652, v677)
    let v679 : int8 = v678 - 1y
    let v680 : uint64 = 0UL
    let v681 : US8 = method41(v679, v652, v680)
    let v691 : US9 =
        match v681 with
        | US8_0(v682, v683) -> (* Some *)
            let v684 : bool = v682 >= 1UL
            let v686 : bool =
                if v684 then
                    let v685 : bool = v682 <= v637
                    v685
                else
                    false
            if v686 then
                US9_0(v682)
            else
                US9_1
        | _ ->
            US9_1
    let v699 : uint64 option =
        match v691 with
        | US9_1 -> (* None *)
            let v697 : uint64 option = None
            v697
        | US9_0(v692) -> (* Some *)
            let v694 : uint64 option = Some v692 
            v694
    let v700 : unit = ()
    let v701 : (unit -> unit) = closure90(v637, v639, v699)
    let v702 : unit = (fun () -> v701 (); v700) ()
    let v757 : (unit -> unit) = method55()
    let v758 : unit = ()
    let v759 : (unit -> unit) = closure91(v757)
    let v760 : unit = (fun () -> v759 (); v758) ()
    let v806 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v699 v806 
    let v807 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v807 
    let v808 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v808 
    let v809 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v809 
    let v810 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v811 : bool = Fable.Core.RustInterop.emitRustExpr () v810 
    let v812 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v813 : bool = Fable.Core.RustInterop.emitRustExpr () v812 
    let v814 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v814 
    let v815 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v815 
    let v816 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v816 
    let v817 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v817 
    let v818 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v818 
    let v819 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v819 
    let v820 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v820 
    let v821 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v821 
    let v822 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v822 
    let v823 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v823 
    let v824 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v824 
    let v825 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v826 : bool = Fable.Core.RustInterop.emitRustExpr () v825 
    let v827 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v828 : bool = Fable.Core.RustInterop.emitRustExpr () v827 
    let v829 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v829 
    let v830 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v830 
    let v831 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v832 : bool = Fable.Core.RustInterop.emitRustExpr () v831 
    let v833 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v834 : bool = Fable.Core.RustInterop.emitRustExpr () v833 
    let v835 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v836 : bool = Fable.Core.RustInterop.emitRustExpr () v835 
    let v837 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v838 : bool = Fable.Core.RustInterop.emitRustExpr () v837 
    let v839 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v840 : bool = Fable.Core.RustInterop.emitRustExpr () v839 
    let v841 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v842 : bool = Fable.Core.RustInterop.emitRustExpr () v841 
    let v843 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v844 : bool = Fable.Core.RustInterop.emitRustExpr () v843 
    let v845 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v846 : bool = Fable.Core.RustInterop.emitRustExpr () v845 
    let v847 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v848 : bool = Fable.Core.RustInterop.emitRustExpr () v847 
    let v849 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v850 : bool = Fable.Core.RustInterop.emitRustExpr () v849 
    let v851 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v852 : bool = Fable.Core.RustInterop.emitRustExpr () v851 
    let v853 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v854 : bool = Fable.Core.RustInterop.emitRustExpr () v853 
    let v855 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v856 : bool = Fable.Core.RustInterop.emitRustExpr () v855 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
