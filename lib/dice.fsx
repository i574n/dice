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
    let v52 : (string -> US7) = method12()
    let v53 : US7 option = v47 |> Option.map v52 
    let v73 : US7 = US7_1
    let v74 : US7 = v53 |> Option.defaultValue v73 
    let v81 : string =
        match v74 with
        | US7_1 -> (* None *)
            let v79 : string = ""
            v79
        | US7_0(v78) -> (* Some *)
            v78
    let _run_target_args'_v5 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v82 : US5 = US5_1
    let v83 : US6 = US6_1(v82)
    let v84 : string = $"env.get_environment_variable / target: {v83} / var: {v0}"
    let v85 : string = failwith<string> v84
    let _run_target_args'_v5 = v85 
    #endif
#else
    let v86 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v87 : string = v86 v0
    let mutable _v87 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v87
    v90 
    #else
    Some v87 
    #endif
    |> fun x -> _v87 <- Some x
    let v91 : string option = match _v87 with Some x -> x | None -> failwith "optionm'.of_obj / _v87=None"
    let v96 : (string -> US7) = method12()
    let v97 : US7 option = v91 |> Option.map v96 
    let v117 : US7 = US7_1
    let v118 : US7 = v97 |> Option.defaultValue v117 
    let v125 : string =
        match v118 with
        | US7_1 -> (* None *)
            let v123 : string = ""
            v123
        | US7_0(v122) -> (* Some *)
            v122
    let _run_target_args'_v5 = v125 
    #endif
    let v126 : string = _run_target_args'_v5 
    v126
and method8 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method9(v0)
    
    
    
    
    
    
    
    
    
    
    let v4 : string = "Critical"
    let v5 : (unit -> string) = v4.ToLower
    let v6 : string = v5 ()
    let v11 : string = "Warning"
    let v12 : (unit -> string) = v11.ToLower
    let v13 : string = v12 ()
    let v18 : string = "Info"
    let v19 : (unit -> string) = v18.ToLower
    let v20 : string = v19 ()
    let v25 : string = "Debug"
    let v26 : (unit -> string) = v25.ToLower
    let v27 : string = v26 ()
    let v32 : string = "Verbose"
    let v33 : (unit -> string) = v32.ToLower
    let v34 : string = v33 ()
    let v37 : bool = "Verbose" = v1
    let v41 : US3 =
        if v37 then
            let v38 : US2 = US2_0
            US3_0(v38)
        else
            US3_1
    let v127 : US3 =
        match v41 with
        | US3_1 -> (* None *)
            let v44 : bool = "Debug" = v1
            let v48 : US3 =
                if v44 then
                    let v45 : US2 = US2_1
                    US3_0(v45)
                else
                    US3_1
            match v48 with
            | US3_1 -> (* None *)
                let v51 : bool = "Info" = v1
                let v55 : US3 =
                    if v51 then
                        let v52 : US2 = US2_2
                        US3_0(v52)
                    else
                        US3_1
                match v55 with
                | US3_1 -> (* None *)
                    let v58 : bool = "Warning" = v1
                    let v62 : US3 =
                        if v58 then
                            let v59 : US2 = US2_3
                            US3_0(v59)
                        else
                            US3_1
                    match v62 with
                    | US3_1 -> (* None *)
                        let v65 : bool = "Critical" = v1
                        let v69 : US3 =
                            if v65 then
                                let v66 : US2 = US2_4
                                US3_0(v66)
                            else
                                US3_1
                        match v69 with
                        | US3_1 -> (* None *)
                            let v72 : bool = v34 = v1
                            let v76 : US3 =
                                if v72 then
                                    let v73 : US2 = US2_0
                                    US3_0(v73)
                                else
                                    US3_1
                            match v76 with
                            | US3_1 -> (* None *)
                                let v79 : bool = v27 = v1
                                let v83 : US3 =
                                    if v79 then
                                        let v80 : US2 = US2_1
                                        US3_0(v80)
                                    else
                                        US3_1
                                match v83 with
                                | US3_1 -> (* None *)
                                    let v86 : bool = v20 = v1
                                    let v90 : US3 =
                                        if v86 then
                                            let v87 : US2 = US2_2
                                            US3_0(v87)
                                        else
                                            US3_1
                                    match v90 with
                                    | US3_1 -> (* None *)
                                        let v93 : bool = v13 = v1
                                        let v97 : US3 =
                                            if v93 then
                                                let v94 : US2 = US2_3
                                                US3_0(v94)
                                            else
                                                US3_1
                                        match v97 with
                                        | US3_1 -> (* None *)
                                            let v100 : bool = v6 = v1
                                            let v104 : US3 =
                                                if v100 then
                                                    let v101 : US2 = US2_4
                                                    US3_0(v101)
                                                else
                                                    US3_1
                                            match v104 with
                                            | US3_1 -> (* None *)
                                                US3_1
                                            | US3_0(v105) -> (* Some *)
                                                US3_0(v105)
                                        | US3_0(v98) -> (* Some *)
                                            US3_0(v98)
                                    | US3_0(v91) -> (* Some *)
                                        US3_0(v91)
                                | US3_0(v84) -> (* Some *)
                                    US3_0(v84)
                            | US3_0(v77) -> (* Some *)
                                US3_0(v77)
                        | US3_0(v70) -> (* Some *)
                            US3_0(v70)
                    | US3_0(v63) -> (* Some *)
                        US3_0(v63)
                | US3_0(v56) -> (* Some *)
                    US3_0(v56)
            | US3_0(v49) -> (* Some *)
                US3_0(v49)
        | US3_0(v42) -> (* Some *)
            US3_0(v42)
    let v128 : string = "AUTOMATION"
    let v129 : string = method9(v128)
    let v132 : string = "True"
    let v133 : bool = v129 <> v132 
    let v200 : US4 =
        if v133 then
            US4_1
        else
            (* run_target_args'
            let v139 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v140 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v141 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v143 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v139 = v143 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v146 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v146 
            #endif
#if FABLE_COMPILER_PYTHON
            let v147 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v147 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v148 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v148 
            #endif
#else
            let v149 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v149 
            #endif
            let v150 : System.DateTime = _run_target_args'_v139 
            (* run_target_args'
            let v158 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v159 : (System.DateTime -> int64) = _.Ticks
            let v160 : int64 = v159 v150
            let _run_target_args'_v158 = v160 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v161 : (System.DateTime -> int64) = _.Ticks
            let v162 : int64 = v161 v150
            let _run_target_args'_v158 = v162 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : int64 = null |> unbox<int64>
            let _run_target_args'_v158 = v164 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v167 : (System.DateTime -> int64) = _.Ticks
            let v168 : int64 = v167 v150
            let _run_target_args'_v158 = v168 
            #endif
#if FABLE_COMPILER_PYTHON
            let v169 : (System.DateTime -> int64) = _.Ticks
            let v170 : int64 = v169 v150
            let _run_target_args'_v158 = v170 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v171 : (System.DateTime -> int64) = _.Ticks
            let v172 : int64 = v171 v150
            let _run_target_args'_v158 = v172 
            #endif
#else
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v150
            let _run_target_args'_v158 = v174 
            #endif
            let v175 : int64 = _run_target_args'_v158 
            let v196 : int64 = v175 |> int64 
            US4_0(v196)
    struct (v127, v200)
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
    let v198 : int64 option =
        match v173 with
        | US4_1 -> (* None *)
            let v194 : int64 option = None
            v194
        | US4_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v198)
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
    let v173 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v176 : (int64 -> US4) = method14()
    let v177 : US4 option = v5 |> Option.map v176 
    let v197 : US4 = US4_1
    let v198 : US4 = v177 |> Option.defaultValue v197 
    let v316 : System.DateTime =
        match v198 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v299 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v300 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v300 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v301 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v301 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v303 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v299 = v303 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v306 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v306 
            #endif
#if FABLE_COMPILER_PYTHON
            let v307 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v307 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v308 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v308 
            #endif
#else
            let v309 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v299 = v309 
            #endif
            let v310 : System.DateTime = _run_target_args'_v299 
            v310
        | US4_0(v202) -> (* Some *)
            (* run_target_args'
            let v205 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v206 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v206 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v207 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v207 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v209 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v205 = v209 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v212 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v212 
            #endif
#if FABLE_COMPILER_PYTHON
            let v213 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v213 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v214 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v214 
            #endif
#else
            let v215 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v205 = v215 
            #endif
            let v216 : System.DateTime = _run_target_args'_v205 
            (* run_target_args'
            let v224 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v225 : (System.DateTime -> int64) = _.Ticks
            let v226 : int64 = v225 v216
            let _run_target_args'_v224 = v226 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v227 : (System.DateTime -> int64) = _.Ticks
            let v228 : int64 = v227 v216
            let _run_target_args'_v224 = v228 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v230 : int64 = null |> unbox<int64>
            let _run_target_args'_v224 = v230 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v233 : (System.DateTime -> int64) = _.Ticks
            let v234 : int64 = v233 v216
            let _run_target_args'_v224 = v234 
            #endif
#if FABLE_COMPILER_PYTHON
            let v235 : (System.DateTime -> int64) = _.Ticks
            let v236 : int64 = v235 v216
            let _run_target_args'_v224 = v236 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v237 : (System.DateTime -> int64) = _.Ticks
            let v238 : int64 = v237 v216
            let _run_target_args'_v224 = v238 
            #endif
#else
            let v239 : (System.DateTime -> int64) = _.Ticks
            let v240 : int64 = v239 v216
            let _run_target_args'_v224 = v240 
            #endif
            let v241 : int64 = _run_target_args'_v224 
            let v262 : int64 = v241 |> int64 
            let v265 : int64 = v262 - v202
            let v268 : System.TimeSpan = v265 |> System.TimeSpan 
            let v274 : (System.TimeSpan -> int32) = _.Hours
            let v275 : int32 = v274 v268
            let v279 : (System.TimeSpan -> int32) = _.Minutes
            let v280 : int32 = v279 v268
            let v284 : (System.TimeSpan -> int32) = _.Seconds
            let v285 : int32 = v284 v268
            let v289 : (System.TimeSpan -> int32) = _.Milliseconds
            let v290 : int32 = v289 v268
            let v294 : System.DateTime = System.DateTime (1, 1, 1, v275, v280, v285, v290)
            v294
    let v318 : string = method15()
    let v322 : bool = v318 = ""
    let v324 : string =
        if v322 then
            let v323 : string = "M-d-y hh:mm:ss tt"
            v323
        else
            v318
    let v325 : (string -> string) = v316.ToString
    let v326 : string = v325 v324
    let _run_target_args'_v173 = v326 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v343 : (int64 -> US4) = method14()
    let v344 : US4 option = v5 |> Option.map v343 
    let v364 : US4 = US4_1
    let v365 : US4 = v344 |> Option.defaultValue v364 
    let v483 : System.DateTime =
        match v365 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v466 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v467 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v467 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v468 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v468 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v470 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v466 = v470 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v473 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v473 
            #endif
#if FABLE_COMPILER_PYTHON
            let v474 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v474 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v475 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v475 
            #endif
#else
            let v476 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v466 = v476 
            #endif
            let v477 : System.DateTime = _run_target_args'_v466 
            v477
        | US4_0(v369) -> (* Some *)
            (* run_target_args'
            let v372 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v373 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v373 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v374 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v374 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v376 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v372 = v376 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v379 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v379 
            #endif
#if FABLE_COMPILER_PYTHON
            let v380 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v380 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v381 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v381 
            #endif
#else
            let v382 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v372 = v382 
            #endif
            let v383 : System.DateTime = _run_target_args'_v372 
            (* run_target_args'
            let v391 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v392 : (System.DateTime -> int64) = _.Ticks
            let v393 : int64 = v392 v383
            let _run_target_args'_v391 = v393 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v394 : (System.DateTime -> int64) = _.Ticks
            let v395 : int64 = v394 v383
            let _run_target_args'_v391 = v395 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v397 : int64 = null |> unbox<int64>
            let _run_target_args'_v391 = v397 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v400 : (System.DateTime -> int64) = _.Ticks
            let v401 : int64 = v400 v383
            let _run_target_args'_v391 = v401 
            #endif
#if FABLE_COMPILER_PYTHON
            let v402 : (System.DateTime -> int64) = _.Ticks
            let v403 : int64 = v402 v383
            let _run_target_args'_v391 = v403 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v404 : (System.DateTime -> int64) = _.Ticks
            let v405 : int64 = v404 v383
            let _run_target_args'_v391 = v405 
            #endif
#else
            let v406 : (System.DateTime -> int64) = _.Ticks
            let v407 : int64 = v406 v383
            let _run_target_args'_v391 = v407 
            #endif
            let v408 : int64 = _run_target_args'_v391 
            let v429 : int64 = v408 |> int64 
            let v432 : int64 = v429 - v369
            let v435 : System.TimeSpan = v432 |> System.TimeSpan 
            let v441 : (System.TimeSpan -> int32) = _.Hours
            let v442 : int32 = v441 v435
            let v446 : (System.TimeSpan -> int32) = _.Minutes
            let v447 : int32 = v446 v435
            let v451 : (System.TimeSpan -> int32) = _.Seconds
            let v452 : int32 = v451 v435
            let v456 : (System.TimeSpan -> int32) = _.Milliseconds
            let v457 : int32 = v456 v435
            let v461 : System.DateTime = System.DateTime (1, 1, 1, v442, v447, v452, v457)
            v461
    let v485 : string = method15()
    let v489 : bool = v485 = ""
    let v491 : string =
        if v489 then
            let v490 : string = "M-d-y hh:mm:ss tt"
            v490
        else
            v485
    let v492 : (string -> string) = v483.ToString
    let v493 : string = v492 v491
    let _run_target_args'_v173 = v493 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v508 : string = $"near_sdk::env::block_timestamp()"
    let v509 : uint64 = Fable.Core.RustInterop.emitRustExpr () v508 
    let v512 : (int64 -> US4) = method14()
    let v513 : US4 option = v5 |> Option.map v512 
    let v533 : US4 = US4_1
    let v534 : US4 = v513 |> Option.defaultValue v533 
    let v546 : uint64 =
        match v534 with
        | US4_1 -> (* None *)
            v509
        | US4_0(v538) -> (* Some *)
            let v540 : (int64 -> uint64) = uint64
            let v541 : uint64 = v540 v538
            let v544 : uint64 = v509 - v541
            v544
    let v547 : uint64 = v546 / 1000000000UL
    let v548 : uint64 = v547 % 60UL
    let v549 : uint64 = v547 / 60UL
    let v550 : uint64 = v549 % 60UL
    let v551 : uint64 = v547 / 3600UL
    let v552 : uint64 = v551 % 24UL
    let v553 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v554 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v552, v550, v548) v553 
    let v555 : string = "fable_library_rust::String_::fromString($0)"
    let v556 : string = Fable.Core.RustInterop.emitRustExpr v554 v555 
    let _run_target_args'_v173 = v556 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v559 : (int64 -> US4) = method14()
    let v560 : US4 option = v5 |> Option.map v559 
    let v580 : US4 = US4_1
    let v581 : US4 = v560 |> Option.defaultValue v580 
    let v699 : System.DateTime =
        match v581 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v682 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v683 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v683 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v684 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v684 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v686 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v682 = v686 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v689 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v689 
            #endif
#if FABLE_COMPILER_PYTHON
            let v690 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v690 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v691 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v691 
            #endif
#else
            let v692 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v682 = v692 
            #endif
            let v693 : System.DateTime = _run_target_args'_v682 
            v693
        | US4_0(v585) -> (* Some *)
            (* run_target_args'
            let v588 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v589 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v589 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v590 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v590 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v592 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v588 = v592 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v595 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v595 
            #endif
#if FABLE_COMPILER_PYTHON
            let v596 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v596 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v597 
            #endif
#else
            let v598 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v588 = v598 
            #endif
            let v599 : System.DateTime = _run_target_args'_v588 
            (* run_target_args'
            let v607 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v599
            let _run_target_args'_v607 = v609 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v610 : (System.DateTime -> int64) = _.Ticks
            let v611 : int64 = v610 v599
            let _run_target_args'_v607 = v611 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v613 : int64 = null |> unbox<int64>
            let _run_target_args'_v607 = v613 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v616 : (System.DateTime -> int64) = _.Ticks
            let v617 : int64 = v616 v599
            let _run_target_args'_v607 = v617 
            #endif
#if FABLE_COMPILER_PYTHON
            let v618 : (System.DateTime -> int64) = _.Ticks
            let v619 : int64 = v618 v599
            let _run_target_args'_v607 = v619 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v620 : (System.DateTime -> int64) = _.Ticks
            let v621 : int64 = v620 v599
            let _run_target_args'_v607 = v621 
            #endif
#else
            let v622 : (System.DateTime -> int64) = _.Ticks
            let v623 : int64 = v622 v599
            let _run_target_args'_v607 = v623 
            #endif
            let v624 : int64 = _run_target_args'_v607 
            let v645 : int64 = v624 |> int64 
            let v648 : int64 = v645 - v585
            let v651 : System.TimeSpan = v648 |> System.TimeSpan 
            let v657 : (System.TimeSpan -> int32) = _.Hours
            let v658 : int32 = v657 v651
            let v662 : (System.TimeSpan -> int32) = _.Minutes
            let v663 : int32 = v662 v651
            let v667 : (System.TimeSpan -> int32) = _.Seconds
            let v668 : int32 = v667 v651
            let v672 : (System.TimeSpan -> int32) = _.Milliseconds
            let v673 : int32 = v672 v651
            let v677 : System.DateTime = System.DateTime (1, 1, 1, v658, v663, v668, v673)
            v677
    let v701 : string = method16()
    let v705 : bool = v701 = ""
    let v707 : string =
        if v705 then
            let v706 : string = "M-d-y hh:mm:ss tt"
            v706
        else
            v701
    let v708 : (string -> string) = v699.ToString
    let v709 : string = v708 v707
    let _run_target_args'_v173 = v709 
    #endif
#if FABLE_COMPILER_PYTHON
    let v726 : (int64 -> US4) = method14()
    let v727 : US4 option = v5 |> Option.map v726 
    let v747 : US4 = US4_1
    let v748 : US4 = v727 |> Option.defaultValue v747 
    let v866 : System.DateTime =
        match v748 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v849 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v850 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v850 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v851 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v851 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v853 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v849 = v853 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v856 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v856 
            #endif
#if FABLE_COMPILER_PYTHON
            let v857 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v857 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v858 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v858 
            #endif
#else
            let v859 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v849 = v859 
            #endif
            let v860 : System.DateTime = _run_target_args'_v849 
            v860
        | US4_0(v752) -> (* Some *)
            (* run_target_args'
            let v755 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v756 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v756 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v757 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v757 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v759 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v755 = v759 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v762 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v762 
            #endif
#if FABLE_COMPILER_PYTHON
            let v763 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v763 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v764 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v764 
            #endif
#else
            let v765 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v755 = v765 
            #endif
            let v766 : System.DateTime = _run_target_args'_v755 
            (* run_target_args'
            let v774 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v775 : (System.DateTime -> int64) = _.Ticks
            let v776 : int64 = v775 v766
            let _run_target_args'_v774 = v776 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v777 : (System.DateTime -> int64) = _.Ticks
            let v778 : int64 = v777 v766
            let _run_target_args'_v774 = v778 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v780 : int64 = null |> unbox<int64>
            let _run_target_args'_v774 = v780 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v783 : (System.DateTime -> int64) = _.Ticks
            let v784 : int64 = v783 v766
            let _run_target_args'_v774 = v784 
            #endif
#if FABLE_COMPILER_PYTHON
            let v785 : (System.DateTime -> int64) = _.Ticks
            let v786 : int64 = v785 v766
            let _run_target_args'_v774 = v786 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v787 : (System.DateTime -> int64) = _.Ticks
            let v788 : int64 = v787 v766
            let _run_target_args'_v774 = v788 
            #endif
#else
            let v789 : (System.DateTime -> int64) = _.Ticks
            let v790 : int64 = v789 v766
            let _run_target_args'_v774 = v790 
            #endif
            let v791 : int64 = _run_target_args'_v774 
            let v812 : int64 = v791 |> int64 
            let v815 : int64 = v812 - v752
            let v818 : System.TimeSpan = v815 |> System.TimeSpan 
            let v824 : (System.TimeSpan -> int32) = _.Hours
            let v825 : int32 = v824 v818
            let v829 : (System.TimeSpan -> int32) = _.Minutes
            let v830 : int32 = v829 v818
            let v834 : (System.TimeSpan -> int32) = _.Seconds
            let v835 : int32 = v834 v818
            let v839 : (System.TimeSpan -> int32) = _.Milliseconds
            let v840 : int32 = v839 v818
            let v844 : System.DateTime = System.DateTime (1, 1, 1, v825, v830, v835, v840)
            v844
    let v868 : string = method16()
    let v872 : bool = v868 = ""
    let v874 : string =
        if v872 then
            let v873 : string = "M-d-y hh:mm:ss tt"
            v873
        else
            v868
    let v875 : (string -> string) = v866.ToString
    let v876 : string = v875 v874
    let _run_target_args'_v173 = v876 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v893 : (int64 -> US4) = method14()
    let v894 : US4 option = v5 |> Option.map v893 
    let v914 : US4 = US4_1
    let v915 : US4 = v894 |> Option.defaultValue v914 
    let v1033 : System.DateTime =
        match v915 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1016 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1017 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1017 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1018 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1018 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1020 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1016 = v1020 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1023 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1023 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1024 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1024 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1025 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1025 
            #endif
#else
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1016 = v1026 
            #endif
            let v1027 : System.DateTime = _run_target_args'_v1016 
            v1027
        | US4_0(v919) -> (* Some *)
            (* run_target_args'
            let v922 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v923 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v923 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v924 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v924 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v926 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v922 = v926 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v929 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v929 
            #endif
#if FABLE_COMPILER_PYTHON
            let v930 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v930 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v931 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v931 
            #endif
#else
            let v932 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v922 = v932 
            #endif
            let v933 : System.DateTime = _run_target_args'_v922 
            (* run_target_args'
            let v941 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v942 : (System.DateTime -> int64) = _.Ticks
            let v943 : int64 = v942 v933
            let _run_target_args'_v941 = v943 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v944 : (System.DateTime -> int64) = _.Ticks
            let v945 : int64 = v944 v933
            let _run_target_args'_v941 = v945 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v947 : int64 = null |> unbox<int64>
            let _run_target_args'_v941 = v947 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v950 : (System.DateTime -> int64) = _.Ticks
            let v951 : int64 = v950 v933
            let _run_target_args'_v941 = v951 
            #endif
#if FABLE_COMPILER_PYTHON
            let v952 : (System.DateTime -> int64) = _.Ticks
            let v953 : int64 = v952 v933
            let _run_target_args'_v941 = v953 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v954 : (System.DateTime -> int64) = _.Ticks
            let v955 : int64 = v954 v933
            let _run_target_args'_v941 = v955 
            #endif
#else
            let v956 : (System.DateTime -> int64) = _.Ticks
            let v957 : int64 = v956 v933
            let _run_target_args'_v941 = v957 
            #endif
            let v958 : int64 = _run_target_args'_v941 
            let v979 : int64 = v958 |> int64 
            let v982 : int64 = v979 - v919
            let v985 : System.TimeSpan = v982 |> System.TimeSpan 
            let v991 : (System.TimeSpan -> int32) = _.Hours
            let v992 : int32 = v991 v985
            let v996 : (System.TimeSpan -> int32) = _.Minutes
            let v997 : int32 = v996 v985
            let v1001 : (System.TimeSpan -> int32) = _.Seconds
            let v1002 : int32 = v1001 v985
            let v1006 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1007 : int32 = v1006 v985
            let v1011 : System.DateTime = System.DateTime (1, 1, 1, v992, v997, v1002, v1007)
            v1011
    let v1035 : string = method16()
    let v1039 : bool = v1035 = ""
    let v1041 : string =
        if v1039 then
            let v1040 : string = "M-d-y hh:mm:ss tt"
            v1040
        else
            v1035
    let v1042 : (string -> string) = v1033.ToString
    let v1043 : string = v1042 v1041
    let _run_target_args'_v173 = v1043 
    #endif
#else
    let v1060 : (int64 -> US4) = method14()
    let v1061 : US4 option = v5 |> Option.map v1060 
    let v1081 : US4 = US4_1
    let v1082 : US4 = v1061 |> Option.defaultValue v1081 
    let v1200 : System.DateTime =
        match v1082 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1183 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1184 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1185 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1185 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1187 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1183 = v1187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1190 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1190 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1191 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1191 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1192 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1192 
            #endif
#else
            let v1193 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1183 = v1193 
            #endif
            let v1194 : System.DateTime = _run_target_args'_v1183 
            v1194
        | US4_0(v1086) -> (* Some *)
            (* run_target_args'
            let v1089 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1090 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1090 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1091 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1091 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1093 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1089 = v1093 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1096 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1096 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1097 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1097 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1098 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1098 
            #endif
#else
            let v1099 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1089 = v1099 
            #endif
            let v1100 : System.DateTime = _run_target_args'_v1089 
            (* run_target_args'
            let v1108 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1109 : (System.DateTime -> int64) = _.Ticks
            let v1110 : int64 = v1109 v1100
            let _run_target_args'_v1108 = v1110 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1111 : (System.DateTime -> int64) = _.Ticks
            let v1112 : int64 = v1111 v1100
            let _run_target_args'_v1108 = v1112 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1114 : int64 = null |> unbox<int64>
            let _run_target_args'_v1108 = v1114 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1117 : (System.DateTime -> int64) = _.Ticks
            let v1118 : int64 = v1117 v1100
            let _run_target_args'_v1108 = v1118 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1119 : (System.DateTime -> int64) = _.Ticks
            let v1120 : int64 = v1119 v1100
            let _run_target_args'_v1108 = v1120 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1121 : (System.DateTime -> int64) = _.Ticks
            let v1122 : int64 = v1121 v1100
            let _run_target_args'_v1108 = v1122 
            #endif
#else
            let v1123 : (System.DateTime -> int64) = _.Ticks
            let v1124 : int64 = v1123 v1100
            let _run_target_args'_v1108 = v1124 
            #endif
            let v1125 : int64 = _run_target_args'_v1108 
            let v1146 : int64 = v1125 |> int64 
            let v1149 : int64 = v1146 - v1086
            let v1152 : System.TimeSpan = v1149 |> System.TimeSpan 
            let v1158 : (System.TimeSpan -> int32) = _.Hours
            let v1159 : int32 = v1158 v1152
            let v1163 : (System.TimeSpan -> int32) = _.Minutes
            let v1164 : int32 = v1163 v1152
            let v1168 : (System.TimeSpan -> int32) = _.Seconds
            let v1169 : int32 = v1168 v1152
            let v1173 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1174 : int32 = v1173 v1152
            let v1178 : System.DateTime = System.DateTime (1, 1, 1, v1159, v1164, v1169, v1174)
            v1178
    let v1202 : string = method16()
    let v1206 : bool = v1202 = ""
    let v1208 : string =
        if v1206 then
            let v1207 : string = "M-d-y hh:mm:ss tt"
            v1207
        else
            v1202
    let v1209 : (string -> string) = v1200.ToString
    let v1210 : string = v1209 v1208
    let _run_target_args'_v173 = v1210 
    #endif
    let v1225 : string = _run_target_args'_v173 
    v1225
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
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method18(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_bright_blue"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_bright_blue"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_bright_blue"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[94m"
    let v138 : string = method20()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[94m"
    let v142 : string = method20()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[94m"
    let v146 : string = method20()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[94m"
    let v150 : string = method20()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method22 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method19()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure13(v5, v9)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v19 : string = "current_index"
    let v20 : string = $"{v19}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v5, v20)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v30 : string = " = "
    let v31 : string = $"{v30}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure13(v5, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v40 : string = $"{v0}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v5, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v50 : string = "; "
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v61 : string = "acc"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure13(v5, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v30}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v5, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure13(v5, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v50}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure13(v5, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v99 : string = "len"
    let v100 : string = $"{v99}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure13(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v109 : string = $"{v30}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v5, v109)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v118 : string = $"{v2}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure13(v5, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v127 : string = $"{v50}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure13(v5, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v137 : string = "last_item"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure13(v5, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v30}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure13(v5, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v3}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure13(v5, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v170 : unit = ()
    let v171 : (unit -> unit) = closure13(v5, v167)
    let v172 : unit = (fun () -> v171 (); v170) ()
    let v175 : string = v5.l0
    v175
and method23 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v40 : char list = []
    let v42 : char list = '/' :: v40 
    let v46 : char list = ' ' :: v42 
    let v51 : (char list -> (char [])) = List.toArray
    let v52 : (char []) = v51 v46
    let v55 : string = v8.TrimEnd v52 
    v55
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
    let v19 : uint8 option =
        match v8 with
        | US1_1 -> (* None *)
            let v15 : uint8 option = None
            v15
        | US1_0(v9) -> (* Some *)
            let v11 : uint8 option = Some v9 
            v11
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v5, v6, v7, v19)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v73 : UH0 = v0 ()
    let v74 : int64 = v1.l0
    let v75 : US1 = method25(v74, v73)
    match v75 with
    | US1_1 -> (* None *)
        let v80 : unit = ()
        let v81 : (unit -> unit) = closure17()
        let v82 : unit = (fun () -> v81 (); v80) ()
        let v129 : int64 = v3.l0
        let v130 : bool = v129 = -1L
        if v130 then
            let v131 : int64 = v1.l0
            v3.l0 <- v131
            ()
        let v132 : int64 = v2.l0
        let v133 : int64 = v3.l0
        let v134 : bool = v132 >= v133
        let v137 : int64 =
            if v134 then
                1L
            else
                let v135 : int64 = v2.l0
                let v136 : int64 = v135 + 1L
                v136
        v2.l0 <- v137
        let v138 : int64 = v2.l0
        let v139 : int64 = v138 - 1L
        v1.l0 <- v139
        let v140 : US1 = US1_1
        v4.l0 <- v140
        method5(v0, v1, v2, v3, v4)
    | US1_0(v76) -> (* Some *)
        let v77 : int64 = v1.l0
        let v78 : int64 = v77 + 1L
        v1.l0 <- v78
        let v79 : US1 = US1_0(v76)
        v4.l0 <- v79
        v76
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
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "max"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "p"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure13(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure13(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "n"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure13(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
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
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "power"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "acc"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure13(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure13(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "result"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure13(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
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
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure13(v5, v9)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v19 : string = "power"
    let v20 : string = $"{v19}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v5, v20)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v30 : string = " = "
    let v31 : string = $"{v30}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure13(v5, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v40 : string = $"{v0}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v5, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v50 : string = "; "
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v61 : string = "acc"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure13(v5, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v30}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v5, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure13(v5, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v50}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure13(v5, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v99 : string = "roll"
    let v100 : string = $"{v99}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure13(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v109 : string = $"{v30}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v5, v109)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v118 : string = $"{v2}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure13(v5, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v127 : string = $"{v50}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure13(v5, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v137 : string = "value"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure13(v5, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v30}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure13(v5, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v3}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure13(v5, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v170 : unit = ()
    let v171 : (unit -> unit) = closure13(v5, v167)
    let v172 : unit = (fun () -> v171 (); v170) ()
    let v175 : string = v5.l0
    v175
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
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "power"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "acc"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure13(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure13(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "roll"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure13(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
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
        let v23 : uint64 option = None
        v23
    | US9_0(v17) -> (* Some *)
        let v19 : uint64 option = Some v17 
        v19
and closure89 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure90(v0)
and method44 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method19()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "max"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "p"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure13(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure13(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "n"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure13(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
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
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure13(v5, v9)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v19 : string = "power"
    let v20 : string = $"{v19}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v5, v20)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v30 : string = " = "
    let v31 : string = $"{v30}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure13(v5, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v40 : string = $"{v0}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v5, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v50 : string = "; "
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v61 : string = "acc"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure13(v5, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v71 : string = $"{v30}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v5, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v80 : string = $"{v1}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure13(v5, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v89 : string = $"{v50}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure13(v5, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v99 : string = "roll"
    let v100 : string = $"{v99}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure13(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v109 : string = $"{v30}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v5, v109)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v118 : string = $"{v2}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure13(v5, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v127 : string = $"{v50}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure13(v5, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v137 : string = "value"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure13(v5, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v147 : string = $"{v30}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure13(v5, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v156 : string = $"{v3}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure13(v5, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v170 : unit = ()
    let v171 : (unit -> unit) = closure13(v5, v167)
    let v172 : unit = (fun () -> v171 (); v170) ()
    let v175 : string = v5.l0
    v175
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
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "power"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "acc"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure13(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure13(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "result"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure13(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
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
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure13(v4, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v18 : string = "power"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v4, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v4, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v39 : string = $"{v0}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v4, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v49 : string = "; "
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v60 : string = "acc"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure13(v4, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v70 : string = $"{v29}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure13(v4, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v79 : string = $"{v1}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v4, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v88 : string = $"{v49}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v4, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "roll"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v29}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v117 : string = $"{v2}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v4, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure13(v4, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v4.l0
    v136
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
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "result"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure13(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure13(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure13(v2, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v47 : string = " }"
    let v48 : string = $"{v47}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure13(v2, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v56 : string = v2.l0
    v56
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
