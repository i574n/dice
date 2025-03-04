#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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

type UH0 =
    | UH0_0 of uint8 * (unit -> UH0)
    | UH0_1
and UH1 =
    | UH1_0
    | UH1_1 of uint8 * UH1
and [<Struct>] US0 =
    | US0_0 of f0_0 : (unit -> UH0)
    | US0_1 of f1_0 : UH0
and Mut0 = {mutable l0 : US0}
and Mut1 = {mutable l0 : int64}
and [<Struct>] US1 =
    | US1_0 of f0_0 : uint8
    | US1_1
and Mut2 = {mutable l0 : US1}
and [<Struct>] US2 =
    | US2_0
    | US2_1
    | US2_2
    | US2_3
    | US2_4
and Mut3 = {mutable l0 : (string -> unit)}
and Mut4 = {mutable l0 : bool}
and Mut5 = {mutable l0 : string}
and Mut6 = {mutable l0 : US2}
and [<Struct>] US3 =
    | US3_0 of f0_0 : US2
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : int64
    | US4_1
and [<Struct>] US5 =
    | US5_0
    | US5_1
    | US5_2
and [<Struct>] US6 =
    | US6_0 of f0_0 : US5
    | US6_1 of f1_0 : US5
    | US6_2 of f2_0 : US5
    | US6_3 of f3_0 : US5
    | US6_4 of f4_0 : US5
    | US6_5 of f5_0 : US5
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint64 * f0_1 : UH1
    | US8_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : uint64
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : int64 * f0_1 : UH1
    | US10_1
let rec closure2 (v0 : UH0) () : UH0 =
    v0
and method0 (v0 : int64, v1 : UH0, v2 : UH0) : UH0 =
    match v1 with
    | UH0_0(v3, v4) -> (* StreamCons *)
        let v5 : UH0 = v4 ()
        let v6 : UH0 = method0(v0, v5, v2)
        let v7 : int64 = int64 v3
        let v8 : int64 = v7 - 1L
        let v9 : int64 = v8 + v0
        let v10 : int64 = v9 % v0
        let v11 : int64 = v10 + 1L
        let v12 : uint8 = uint8 v11
        let v13 : (unit -> UH0) = closure2(v6)
        UH0_0(v12, v13)
    | UH0_1 -> (* StreamNil *)
        v2
and closure1 (v0 : int64) (v1 : UH0) : UH0 =
    let v2 : UH0 = UH0_1
    method0(v0, v1, v2)
and closure0 () (v0 : int64) : (UH0 -> UH0) =
    closure1(v0)
and method1 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_1(v2, v1)
        method1(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and method2 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method2(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure4 (v0 : UH0) () : UH0 =
    v0
and method3 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method3(v3, v1)
        let v5 : (unit -> UH0) = closure4(v4)
        UH0_0(v2, v5)
    | UH1_0 -> (* Nil *)
        v1
and closure5 (v0 : UH0) () : UH0 =
    v0
and closure6 (v0 : UH0, v1 : Mut0) () : UH0 =
    let v2 : US0 = v1.l0
    match v2 with
    | US0_1(v3) -> (* Computed *)
        v3
    | US0_0(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method4(v0, v8)
                UH0_0(v7, v9)
            | UH0_1 -> (* StreamNil *)
                UH0_1
        let v13 : US0 = US0_1(v12)
        v1.l0 <- v13
        v12
and method4 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US0 = US0_0(v1)
    let v3 : Mut0 = {l0 = v2} : Mut0
    closure6(v0, v3)
and method10 (v0 : string) : string =
    v0
and method11 () : string =
    let v0 : string = ""
    v0
and closure10 () (v0 : string) : US7 =
    US7_0(v0)
and method12 () : (string -> US7) =
    closure10()
and method9 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method10(v0)
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
    let v19 : string = method11()
    let v20 : string = "$0.unwrap_or($1)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v20 
    let _run_target_args'_v5 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US5 = US5_1
    let v23 : US6 = US6_3(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v5 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : US5 = US5_2
    let v27 : US6 = US6_3(v26)
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
    let v51 : (string -> US7) = method12()
    let v52 : US7 option = v47 |> Option.map v51 
    let v65 : US7 = US7_1
    let v66 : US7 = v52 |> Option.defaultValue v65 
    let v73 : string =
        match v66 with
        | US7_1 -> (* None *)
            let v71 : string = ""
            v71
        | US7_0(v70) -> (* Some *)
            v70
    let _run_target_args'_v5 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v74 : US5 = US5_1
    let v75 : US6 = US6_1(v74)
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
    let v87 : (string -> US7) = method12()
    let v88 : US7 option = v83 |> Option.map v87 
    let v101 : US7 = US7_1
    let v102 : US7 = v88 |> Option.defaultValue v101 
    let v109 : string =
        match v102 with
        | US7_1 -> (* None *)
            let v107 : string = ""
            v107
        | US7_0(v106) -> (* Some *)
            v106
    let _run_target_args'_v5 = v109 
    #endif
    let v110 : string = _run_target_args'_v5 
    v110
and method8 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method9(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US3 =
        if v2 then
            let v3 : US2 = US2_0
            US3_0(v3)
        else
            US3_1
    let v47 : US3 =
        match v6 with
        | US3_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US3 =
                if v9 then
                    let v10 : US2 = US2_1
                    US3_0(v10)
                else
                    US3_1
            match v13 with
            | US3_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US3 =
                    if v16 then
                        let v17 : US2 = US2_2
                        US3_0(v17)
                    else
                        US3_1
                match v20 with
                | US3_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US3 =
                        if v23 then
                            let v24 : US2 = US2_3
                            US3_0(v24)
                        else
                            US3_1
                    match v27 with
                    | US3_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US3 =
                            if v30 then
                                let v31 : US2 = US2_4
                                US3_0(v31)
                            else
                                US3_1
                        match v34 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v35) -> (* Some *)
                            US3_0(v35)
                    | US3_0(v28) -> (* Some *)
                        US3_0(v28)
                | US3_0(v21) -> (* Some *)
                    US3_0(v21)
            | US3_0(v14) -> (* Some *)
                US3_0(v14)
        | US3_0(v7) -> (* Some *)
            US3_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method9(v48)
    let v52 : string = "True"
    let v53 : bool = v49 <> v52 
    let v120 : US4 =
        if v53 then
            US4_1
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
            US4_0(v116)
    struct (v47, v120)
and closure11 () (v0 : string) : unit =
    ()
and method7 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US3, v5 : US4) = method8()
    let _run_target_args'_v3 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : US3 = US3_1
    let v7 : US4 = US4_1
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
    let v162 : US4 =
        if v150 then
            US4_1
        else
            let v154 : string = $"near_sdk::env::block_timestamp()"
            let v155 : uint64 = Fable.Core.RustInterop.emitRustExpr () v154 
            let v157 : (uint64 -> int64) = int64
            let v158 : int64 = v157 v155
            US4_0(v158)
    let v163 : US3 = US3_1
    let _run_target_args'_v3 = struct (v163, v162) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v164 : US3, v165 : US4) = method8()
    let _run_target_args'_v3 = struct (v164, v165) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v166 : US3, v167 : US4) = method8()
    let _run_target_args'_v3 = struct (v166, v167) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v168 : US3, v169 : US4) = method8()
    let _run_target_args'_v3 = struct (v168, v169) 
    #endif
#else
    let struct (v170 : US3, v171 : US4) = method8()
    let _run_target_args'_v3 = struct (v170, v171) 
    #endif
    let struct (v172 : US3, v173 : US4) = _run_target_args'_v3 
    let v178 : Mut1 = {l0 = 1L} : Mut1
    let v179 : (string -> unit) = closure11()
    let v180 : Mut3 = {l0 = v179} : Mut3
    let v181 : Mut4 = {l0 = true} : Mut4
    let v182 : string = ""
    let v183 : Mut5 = {l0 = v182} : Mut5
    let v186 : US2 =
        match v172 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v184) -> (* Some *)
            v184
    let v187 : Mut6 = {l0 = v186} : Mut6
    let v195 : int64 option =
        match v173 with
        | US4_1 -> (* None *)
            let v193 : int64 option = None
            v193
        | US4_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v195)
and closure9 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US2 = US2_0
        let struct (v2 : Mut1, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : Mut6, v7 : int64 option) = method7(v1)
        let v9 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method6 (v0 : US2) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut1, v25 : Mut3, v26 : Mut4, v27 : Mut5, v28 : Mut6, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : US2 = v28.l0
    let v43 : bool = v26.l0
    let v44 : bool = v43 = false
    if v44 then
        false
    else
        let v45 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v0
        let v46 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v42
        let v47 : bool = v45 >= v46
        v47
and closure12 () (v0 : int64) : US4 =
    US4_0(v0)
and method14 () : (int64 -> US4) =
    closure12()
and method15 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method16 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method13 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    (* run_target_args'
    let v165 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : (int64 -> US4) = method14()
    let v168 : US4 option = v5 |> Option.map v167 
    let v181 : US4 = US4_1
    let v182 : US4 = v168 |> Option.defaultValue v181 
    let v300 : System.DateTime =
        match v182 with
        | US4_1 -> (* None *)
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
        | US4_0(v186) -> (* Some *)
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
    let v302 : string = method15()
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
    let v326 : (int64 -> US4) = method14()
    let v327 : US4 option = v5 |> Option.map v326 
    let v340 : US4 = US4_1
    let v341 : US4 = v327 |> Option.defaultValue v340 
    let v459 : System.DateTime =
        match v341 with
        | US4_1 -> (* None *)
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
        | US4_0(v345) -> (* Some *)
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
    let v461 : string = method15()
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
    let v487 : (int64 -> US4) = method14()
    let v488 : US4 option = v5 |> Option.map v487 
    let v501 : US4 = US4_1
    let v502 : US4 = v488 |> Option.defaultValue v501 
    let v514 : uint64 =
        match v502 with
        | US4_1 -> (* None *)
            v485
        | US4_0(v506) -> (* Some *)
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
    let v526 : (int64 -> US4) = method14()
    let v527 : US4 option = v5 |> Option.map v526 
    let v540 : US4 = US4_1
    let v541 : US4 = v527 |> Option.defaultValue v540 
    let v659 : System.DateTime =
        match v541 with
        | US4_1 -> (* None *)
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
        | US4_0(v545) -> (* Some *)
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
    let v661 : string = method16()
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
    let v685 : (int64 -> US4) = method14()
    let v686 : US4 option = v5 |> Option.map v685 
    let v699 : US4 = US4_1
    let v700 : US4 = v686 |> Option.defaultValue v699 
    let v818 : System.DateTime =
        match v700 with
        | US4_1 -> (* None *)
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
        | US4_0(v704) -> (* Some *)
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
    let v820 : string = method16()
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
    let v844 : (int64 -> US4) = method14()
    let v845 : US4 option = v5 |> Option.map v844 
    let v858 : US4 = US4_1
    let v859 : US4 = v845 |> Option.defaultValue v858 
    let v977 : System.DateTime =
        match v859 with
        | US4_1 -> (* None *)
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
        | US4_0(v863) -> (* Some *)
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
    let v979 : string = method16()
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
    let v1003 : (int64 -> US4) = method14()
    let v1004 : US4 option = v5 |> Option.map v1003 
    let v1017 : US4 = US4_1
    let v1018 : US4 = v1004 |> Option.defaultValue v1017 
    let v1136 : System.DateTime =
        match v1018 with
        | US4_1 -> (* None *)
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
        | US4_0(v1022) -> (* Some *)
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
    let v1138 : string = method16()
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
and method19 () : string =
    let v0 : string = ""
    v0
and closure13 (v0 : Mut5, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method18 (v0 : char) : string =
    let v1 : string = method19()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure13(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method20 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method17 () : string =
    
    
    
    
    
    let v1 : string = "Debug"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v6 : char = v3.[int 0]
    let v7 : string = method18(v6)
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
    let v137 : string = method20()
    let v138 : string = v136 + v7 
    let v139 : string = v138 + v137 
    let _run_target_args'_v12 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : string = "\u001b[94m"
    let v141 : string = method20()
    let v142 : string = v140 + v7 
    let v143 : string = v142 + v141 
    let _run_target_args'_v12 = v143 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v144 : string = "\u001b[94m"
    let v145 : string = method20()
    let v146 : string = v144 + v7 
    let v147 : string = v146 + v145 
    let _run_target_args'_v12 = v147 
    #endif
#else
    let v148 : string = "\u001b[94m"
    let v149 : string = method20()
    let v150 : string = v148 + v7 
    let v151 : string = v150 + v149 
    let _run_target_args'_v12 = v151 
    #endif
    let v152 : string = _run_target_args'_v12 
    v152
and method22 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method19()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "current_index"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure13(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure13(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure13(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure13(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "acc"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure13(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure13(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure13(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "len"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure13(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure13(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure13(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "last_item"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure13(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure13(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure13(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure13(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method23 (v0 : string) : string =
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
and method21 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method22(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.create_sequential_roller / roll"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure14 (v0 : Mut1) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure16 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure15 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure16(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method24 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut1, v25 : Mut3, v26 : Mut4, v27 : Mut5, v28 : Mut6, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure14(v24)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : (string -> unit) = closure15()
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
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US2 = US2_1
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure9()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut1, v30 : Mut3, v31 : Mut4, v32 : Mut5, v33 : Mut6, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method13(v29, v30, v31, v32, v33, v34)
        let v48 : string = method17()
        let v50 : string = $"%A{v3}"
        let v53 : string = method21(v29, v30, v31, v32, v33, v34, v47, v48, v0, v1, v2, v50)
        method24(v53)
and method25 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method25(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method27 () : string =
    let v0 : string = method19()
    let v1 : Mut5 = {l0 = v0} : Mut5
    let v2 : string = v1.l0
    v2
and method26 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method27()
    let v9 : int64 = v0.l0
    let v11 : string = "dice.create_sequential_roller / roll / None"
    let v12 : string = $"{v6} {v7} #{v9} %s{v11} / {v8}"
    method23(v12)
and closure17 () () : unit =
    let v0 : US2 = US2_1
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure9()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
        let v43 : string = method13(v25, v26, v27, v28, v29, v30)
        let v44 : string = method17()
        let v45 : string = method26(v25, v26, v27, v28, v29, v30, v43, v44)
        method24(v45)
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US1 = v4.l0
    let v16 : uint8 option =
        match v8 with
        | US1_1 -> (* None *)
            let v14 : uint8 option = None
            v14
        | US1_0(v9) -> (* Some *)
            let v11 : uint8 option = Some v9 
            v11
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v5, v6, v7, v16)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v70 : UH0 = v0 ()
    let v71 : int64 = v1.l0
    let v72 : US1 = method25(v71, v70)
    match v72 with
    | US1_1 -> (* None *)
        let v77 : unit = ()
        let v78 : (unit -> unit) = closure17()
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
        let v137 : US1 = US1_1
        v4.l0 <- v137
        method5(v0, v1, v2, v3, v4)
    | US1_0(v73) -> (* Some *)
        let v74 : int64 = v1.l0
        let v75 : int64 = v74 + 1L
        v1.l0 <- v75
        let v76 : US1 = US1_0(v73)
        v4.l0 <- v76
        v73
and closure7 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) () : uint8 =
    method5(v0, v1, v2, v3, v4)
and closure3 () (v0 : UH1) : (unit -> uint8) =
    let v1 : UH1 = UH1_0
    let v2 : UH1 = method1(v0, v1)
    let v3 : UH1 = method2(v0, v2)
    let v4 : UH0 = UH0_1
    let v5 : UH0 = method3(v3, v4)
    let v6 : (unit -> UH0) = closure5(v5)
    let v7 : (unit -> UH0) = method4(v5, v6)
    let v8 : Mut1 = {l0 = 0L} : Mut1
    let v9 : Mut1 = {l0 = 1L} : Mut1
    let v10 : Mut1 = {l0 = -1L} : Mut1
    let v11 : US1 = US1_1
    let v12 : Mut2 = {l0 = v11} : Mut2
    closure7(v7, v8, v9, v10, v12)
and method30 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "max"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure13(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure13(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure13(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "p"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure13(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "n"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure13(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure13(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure13(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method29 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method30(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.calculate_dice_count"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure21 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method29(v28, v29, v30, v31, v32, v33, v46, v47, v0, v2, v1)
        method24(v48)
and method28 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method28(v0, v6, v4)
        else
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure21(v0, v1, v2)
            let v10 : unit = (fun () -> v9 (); v8) ()
            v1
    else
        let v58 : unit = ()
        let v59 : (unit -> unit) = closure21(v0, v1, v2)
        let v60 : unit = (fun () -> v59 (); v58) ()
        v1
and method34 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "power"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure13(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure13(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure13(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "acc"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure13(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure13(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure13(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure13(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method33 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method34(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method33(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method24(v48)
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
and method35 (v0 : int8, v1 : UH2) : US9 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US9_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method35(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US9_1
and method37 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method19()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "power"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure13(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure13(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure13(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure13(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "acc"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure13(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure13(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure13(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "roll"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure13(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure13(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure13(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "value"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure13(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure13(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure13(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure13(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method36 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method37(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US2 = US2_1
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure9()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut1, v30 : Mut3, v31 : Mut4, v32 : Mut5, v33 : Mut6, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method13(v29, v30, v31, v32, v33, v34)
        let v48 : string = method17()
        let v49 : string = method36(v29, v30, v31, v32, v33, v34, v47, v48, v1, v0, v2, v3)
        method24(v49)
and method39 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "power"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure13(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure13(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure13(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "acc"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure13(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "roll"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure13(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure13(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure13(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method38 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method39(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method38(v28, v29, v30, v31, v32, v33, v46, v47, v1, v0, v2)
        method24(v48)
and method32 (v0 : int8, v1 : UH1, v2 : uint64) : US8 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure22(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US8_0(v4, v1)
    else
        match v1 with
        | UH1_1(v56, v57) -> (* Cons *)
            let v58 : bool = v56 > 1uy
            if v58 then
                let v59 : uint64 = 1UL
                let v60 : (unit -> UH2) = closure23()
                let v61 : UH2 = UH2_0(v59, v60)
                let v62 : US9 = method35(v0, v61)
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
                method32(v120, v57, v119)
            else
                let v122 : unit = ()
                let v123 : (unit -> unit) = closure88(v2, v0, v56)
                let v124 : unit = (fun () -> v123 (); v122) ()
                let v171 : int8 = v0 - 1y
                method32(v171, v57, v2)
        | UH1_0 -> (* Nil *)
            US8_1
and method40 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method40(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method41 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method31(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US8 = method32(v3, v4, v10)
        match v11 with
        | US8_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method40(v3, v0, v15)
                    method41(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method31(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method40(v3, v0, v23)
                method41(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method31(v0, v1, v2, v3, v27, v5)
and method31 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method31(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US8 = method32(v3, v4, v12)
        match v13 with
        | US8_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method40(v3, v0, v17)
                    method41(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method31(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method40(v3, v0, v26)
                method41(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method31(v0, v1, v2, v3, v30, v31)
and closure20 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method28(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method31(v0, v1, v2, v8, v9, v10)
and closure19 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure20(v0, v1)
and closure18 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure19(v0)
and method42 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method42(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure90 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method42(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US8 = method32(v4, v1, v5)
    let v16 : US9 =
        match v6 with
        | US8_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US9_0(v7)
            else
                US9_1
        | _ ->
            US9_1
    match v16 with
    | US9_1 -> (* None *)
        let v22 : uint64 option = None
        v22
    | US9_0(v17) -> (* Some *)
        let v19 : uint64 option = Some v17 
        v19
and closure89 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure90(v0)
and method44 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "max"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure13(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure13(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure13(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "p"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure13(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "n"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure13(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure13(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure13(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method43 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = 9223372036854775807L
    let v9 : int64 = 4738381338321616896L
    let v10 : int8 = 24y
    let v11 : string = method44(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.calculate_dice_count"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure92 () () : unit =
    let v0 : US2 = US2_1
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure9()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
        let v43 : string = method13(v25, v26, v27, v28, v29, v30)
        let v44 : string = method17()
        let v45 : string = method43(v25, v26, v27, v28, v29, v30, v43, v44)
        method24(v45)
and method46 () : uint8 =
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v35 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v34 
    let _run_target_args'_v33 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v37 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v36 
    let _run_target_args'_v33 = v37 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : uint8 = failwith<uint8> "common.random' / target=Rust(Contract)"
    let _run_target_args'_v33 = v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : (unit -> System.Random) = System.Random 
    let v40 : System.Random = v39 ()
    let v46 : int32 = 1uy |> int32 
    let v59 : int32 = 7uy |> int32 
    let v67 : int32 = v40.Next (v46, v59)
    let v69 : uint8 = v67 |> uint8 
    let _run_target_args'_v33 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : (unit -> System.Random) = System.Random 
    let v73 : System.Random = v72 ()
    let v79 : int32 = 1uy |> int32 
    let v92 : int32 = 7uy |> int32 
    let v100 : int32 = v73.Next (v79, v92)
    let v102 : uint8 = v100 |> uint8 
    let _run_target_args'_v33 = v102 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v105 : (unit -> System.Random) = System.Random 
    let v106 : System.Random = v105 ()
    let v112 : int32 = 1uy |> int32 
    let v125 : int32 = 7uy |> int32 
    let v133 : int32 = v106.Next (v112, v125)
    let v135 : uint8 = v133 |> uint8 
    let _run_target_args'_v33 = v135 
    #endif
#else
    let v138 : (unit -> System.Random) = System.Random 
    let v139 : System.Random = v138 ()
    let v145 : int32 = 1uy |> int32 
    let v158 : int32 = 7uy |> int32 
    let v166 : int32 = v139.Next (v145, v158)
    let v168 : uint8 = v166 |> uint8 
    let _run_target_args'_v33 = v168 
    #endif
    let v171 : uint8 = _run_target_args'_v33 
    v171
and method49 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method19()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v5, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v17 : string = "power"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure13(v5, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure13(v5, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure13(v5, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure13(v5, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v56 : string = "acc"
    let v57 : string = $"{v56}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure13(v5, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v66 : string = $"{v27}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v5, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v75 : string = $"{v1}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure13(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v84 : string = $"{v46}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure13(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v93 : string = "roll"
    let v94 : string = $"{v93}"
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure13(v5, v94)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let v103 : string = $"{v27}"
    let v106 : unit = ()
    let v107 : (unit -> unit) = closure13(v5, v103)
    let v108 : unit = (fun () -> v107 (); v106) ()
    let v112 : string = $"{v2}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure13(v5, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v121 : string = $"{v46}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v5, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v130 : string = "value"
    let v131 : string = $"{v130}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure13(v5, v131)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v140 : string = $"{v27}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure13(v5, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v149 : string = $"{v3}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure13(v5, v149)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v158 : string = " }"
    let v159 : string = $"{v158}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure13(v5, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = v5.l0
    v167
and method48 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 23y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure93 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method48(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method51 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 22y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure94 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method51(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method53 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 21y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure95 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method53(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method55 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 20y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure96 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method55(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method57 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 19y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure97 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method57(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method59 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 18y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure98 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method59(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method61 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 17y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure99 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method61(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method63 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 16y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure100 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method63(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method65 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 15y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure101 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method65(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method67 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 14y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure102 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method67(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method69 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 13y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method69(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method71 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 12y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method71(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method73 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 11y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method73(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method75 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 10y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method75(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method77 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 9y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method77(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method79 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 8y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method79(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method81 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 7y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method81(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method83 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 6y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method83(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method85 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 5y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method85(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method87 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 4y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method87(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method89 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 3y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method89(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method91 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 2y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method91(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method93 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 1y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method93(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method95 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 0y
    let v12 : string = method49(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v15 : string = "dice.accumulate_dice_rolls"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method23(v16)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v28 : Mut1, v29 : Mut3, v30 : Mut4, v31 : Mut5, v32 : Mut6, v33 : int64 option) = TraceState.trace_state.Value
        let v46 : string = method13(v28, v29, v30, v31, v32, v33)
        let v47 : string = method17()
        let v48 : string = method95(v28, v29, v30, v31, v32, v33, v46, v47, v0, v1, v2)
        method24(v48)
and method98 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "power"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure13(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure13(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure13(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "acc"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure13(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "result"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure13(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure13(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure13(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method97 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int8 = -1y
    let v11 : string = method98(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure117 (v0 : int64, v1 : int64) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method97(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method96 (v0 : UH1, v1 : int64) : US10 =
    let v2 : int64 = v1 + 1L
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure117(v1, v2)
    let v5 : unit = (fun () -> v4 (); v3) ()
    US10_0(v2, v0)
and method100 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v4, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v16 : string = "power"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v4, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v26 : string = " = "
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure13(v4, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v36 : string = $"{v0}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure13(v4, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure13(v4, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v55 : string = "acc"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v4, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v65 : string = $"{v26}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure13(v4, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v83 : string = $"{v45}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v92 : string = "roll"
    let v93 : string = $"{v92}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure13(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v102 : string = $"{v26}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure13(v4, v102)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v111 : string = $"{v2}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure13(v4, v111)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v120 : string = " }"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure13(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = v4.l0
    v129
and method99 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 0y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure118 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method99(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method94 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure116(v1, v3, v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            let v57 : int64 = v1 + v7
            method96(v4, v57)
        else
            let v59 : unit = ()
            let v60 : (unit -> unit) = closure118(v1, v3)
            let v61 : unit = (fun () -> v60 (); v59) ()
            method96(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 1y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure119 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method101(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method92 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure115(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method94(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure119(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method94(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 2y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure120 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method102(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method90 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure114(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method92(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure120(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method92(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 3y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure121 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method103(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method88 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure113(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method90(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure121(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method90(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 4y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure122 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method104(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method86 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure112(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method88(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure122(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method88(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 5y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure123 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method105(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method84 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure111(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method86(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure123(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method86(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 6y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure124 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method106(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method82 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure110(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method84(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure124(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method84(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 7y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure125 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method107(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method80 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure109(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method82(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure125(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method82(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 8y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure126 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method108(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method78 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure108(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method80(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure126(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method80(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 9y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure127 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method109(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method76 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure107(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method78(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure127(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method78(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 10y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method110(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method74 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure106(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method76(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure128(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method76(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 11y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method111(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method72 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure105(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method74(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure129(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method74(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 12y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method112(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method70 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure104(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method72(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure130(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method72(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 13y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method113(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method68 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure103(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method70(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure131(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method70(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method114 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 14y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method114(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method66 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure102(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method68(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure132(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method68(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method115 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 15y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method115(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method64 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure101(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method66(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure133(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method66(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method116 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 16y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method116(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method62 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure100(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method64(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure134(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method64(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method117 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 17y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method117(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method60 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure99(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method62(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure135(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method62(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method118 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 18y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method118(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method58 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure98(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method60(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure136(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method60(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method119 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 19y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method119(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method56 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure97(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method58(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure137(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method58(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method120 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 20y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method120(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method54 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure96(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method56(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure138(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method56(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method121 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 21y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method121(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method52 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure95(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method54(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure139(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method54(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method122 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 22y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method122(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method50 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure94(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method52(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure140(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method52(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method123 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 23y
    let v11 : string = method100(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v12} %s{v14} / {v11}"
    method23(v15)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method13(v27, v28, v29, v30, v31, v32)
        let v46 : string = method17()
        let v47 : string = method123(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method24(v47)
and method47 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure93(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v58 : int64 = v1 + v8
            method50(v4, v58)
        else
            let v60 : unit = ()
            let v61 : (unit -> unit) = closure141(v1, v3)
            let v62 : unit = (fun () -> v61 (); v60) ()
            method50(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method45 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method46()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method45(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US10 = method47(v0, v7)
        match v8 with
        | US10_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method46()
                let v13 : uint8 = method46()
                let v14 : uint8 = method46()
                let v15 : uint8 = method46()
                let v16 : uint8 = method46()
                let v17 : uint8 = method46()
                let v18 : uint8 = method46()
                let v19 : uint8 = method46()
                let v20 : uint8 = method46()
                let v21 : uint8 = method46()
                let v22 : uint8 = method46()
                let v23 : uint8 = method46()
                let v24 : uint8 = method46()
                let v25 : uint8 = method46()
                let v26 : uint8 = method46()
                let v27 : uint8 = method46()
                let v28 : uint8 = method46()
                let v29 : uint8 = method46()
                let v30 : uint8 = method46()
                let v31 : uint8 = method46()
                let v32 : uint8 = method46()
                let v33 : uint8 = method46()
                let v34 : uint8 = method46()
                let v35 : UH1 = UH1_0
                let v36 : UH1 = UH1_1(v34, v35)
                let v37 : UH1 = UH1_1(v33, v36)
                let v38 : UH1 = UH1_1(v32, v37)
                let v39 : UH1 = UH1_1(v31, v38)
                let v40 : UH1 = UH1_1(v30, v39)
                let v41 : UH1 = UH1_1(v29, v40)
                let v42 : UH1 = UH1_1(v28, v41)
                let v43 : UH1 = UH1_1(v27, v42)
                let v44 : UH1 = UH1_1(v26, v43)
                let v45 : UH1 = UH1_1(v25, v44)
                let v46 : UH1 = UH1_1(v24, v45)
                let v47 : UH1 = UH1_1(v23, v46)
                let v48 : UH1 = UH1_1(v22, v47)
                let v49 : UH1 = UH1_1(v21, v48)
                let v50 : UH1 = UH1_1(v20, v49)
                let v51 : UH1 = UH1_1(v19, v50)
                let v52 : UH1 = UH1_1(v18, v51)
                let v53 : UH1 = UH1_1(v17, v52)
                let v54 : UH1 = UH1_1(v16, v53)
                let v55 : UH1 = UH1_1(v15, v54)
                let v56 : UH1 = UH1_1(v14, v55)
                let v57 : UH1 = UH1_1(v13, v56)
                let v58 : UH1 = UH1_1(v12, v57)
                let v59 : int8 = 23y
                method45(v58, v59)
        | _ ->
            let v62 : uint8 = method46()
            let v63 : uint8 = method46()
            let v64 : uint8 = method46()
            let v65 : uint8 = method46()
            let v66 : uint8 = method46()
            let v67 : uint8 = method46()
            let v68 : uint8 = method46()
            let v69 : uint8 = method46()
            let v70 : uint8 = method46()
            let v71 : uint8 = method46()
            let v72 : uint8 = method46()
            let v73 : uint8 = method46()
            let v74 : uint8 = method46()
            let v75 : uint8 = method46()
            let v76 : uint8 = method46()
            let v77 : uint8 = method46()
            let v78 : uint8 = method46()
            let v79 : uint8 = method46()
            let v80 : uint8 = method46()
            let v81 : uint8 = method46()
            let v82 : uint8 = method46()
            let v83 : uint8 = method46()
            let v84 : uint8 = method46()
            let v85 : UH1 = UH1_0
            let v86 : UH1 = UH1_1(v84, v85)
            let v87 : UH1 = UH1_1(v83, v86)
            let v88 : UH1 = UH1_1(v82, v87)
            let v89 : UH1 = UH1_1(v81, v88)
            let v90 : UH1 = UH1_1(v80, v89)
            let v91 : UH1 = UH1_1(v79, v90)
            let v92 : UH1 = UH1_1(v78, v91)
            let v93 : UH1 = UH1_1(v77, v92)
            let v94 : UH1 = UH1_1(v76, v93)
            let v95 : UH1 = UH1_1(v75, v94)
            let v96 : UH1 = UH1_1(v74, v95)
            let v97 : UH1 = UH1_1(v73, v96)
            let v98 : UH1 = UH1_1(v72, v97)
            let v99 : UH1 = UH1_1(v71, v98)
            let v100 : UH1 = UH1_1(v70, v99)
            let v101 : UH1 = UH1_1(v69, v100)
            let v102 : UH1 = UH1_1(v68, v101)
            let v103 : UH1 = UH1_1(v67, v102)
            let v104 : UH1 = UH1_1(v66, v103)
            let v105 : UH1 = UH1_1(v65, v104)
            let v106 : UH1 = UH1_1(v64, v105)
            let v107 : UH1 = UH1_1(v63, v106)
            let v108 : UH1 = UH1_1(v62, v107)
            let v109 : int8 = 23y
            method45(v108, v109)
and method125 (v0 : int64) : string =
    let v1 : string = method19()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure13(v2, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v14 : string = "result"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v2, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure13(v2, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v34 : string = $"{v0}"
    let v37 : unit = ()
    let v38 : (unit -> unit) = closure13(v2, v34)
    let v39 : unit = (fun () -> v38 (); v37) ()
    let v43 : string = " }"
    let v44 : string = $"{v43}"
    let v47 : unit = ()
    let v48 : (unit -> unit) = closure13(v2, v44)
    let v49 : unit = (fun () -> v48 (); v47) ()
    let v52 : string = v2.l0
    v52
and method124 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : string = method125(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "dice.main"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method23(v13)
and closure142 (v0 : int64) () : unit =
    let v1 : US2 = US2_1
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure9()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method13(v26, v27, v28, v29, v30, v31)
        let v45 : string = method17()
        let v46 : string = method124(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method24(v46)
and closure91 () (v0 : (string [])) : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure92()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v50 : UH1 = UH1_0
    let v51 : int8 = 0y
    let v52 : int64 = method45(v50, v51)
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure142(v52)
    let v55 : unit = (fun () -> v54 (); v53) ()
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure18()
let roll_progressively x = v2 x
let v3 : (uint64 -> (UH1 -> uint64 option)) = closure89()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure91()
let main args = v4 args
()
