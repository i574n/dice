#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
    | US6_6 of f6_0 : US5
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut5 * f0_4 : Mut6 * f0_5 : int64 option
    | US8_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : uint64 * f0_1 : UH1
    | US9_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : uint64
    | US10_1
and [<Struct>] US11 =
    | US11_0 of f0_0 : int64 * f0_1 : UH1
    | US11_1
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
and method9 (v0 : string) : string =
    v0
and method10 () : string =
    let v0 : string = ""
    v0
and closure10 () (v0 : string) : US7 =
    US7_0(v0)
and method11 () : (string -> US7) =
    closure10()
and method8 (v0 : string) : string =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method9(v0)
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result_map_"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method10()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US5 = US5_1
    let v20 : US6 = US6_4(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US5 = US5_2
    let v24 : US6 = US6_4(v23)
    let v25 : string = $"env.get_environment_variable / target: {v24} / var: {v0}"
    let v26 : string = failwith<string> v25
    let _run_target_args'_v2 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "process.env[$0] ?? \"\""
    let v28 : string = Fable.Core.JsInterop.emitJsExpr v0 v27 
    let _run_target_args'_v2 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : string = "os"
    let v31 : IOsEnviron = Fable.Core.PyInterop.importAll v30 
    let v32 : string = "v31.environ"
    let v33 : obj = Fable.Core.PyInterop.emitPyExpr () v32 
    let v37 : string = "v33.get($0)"
    let v38 : string = Fable.Core.PyInterop.emitPyExpr v0 v37 
    let mutable _v38 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v42 : (string -> string option) = Option.ofObj
    let v43 : string option = v42 v38
    v43 
    #else
    Some v38 
    #endif
    |> fun x -> _v38 <- Some x
    let v44 : string option = match _v38 with Some x -> x | None -> failwith "optionm'.of_obj / _v38=None"
    let v49 : (string -> US7) = method11()
    let v50 : US7 option = v44 |> Option.map v49 
    let v70 : US7 = US7_1
    let v71 : US7 = v50 |> Option.defaultValue v70 
    let v78 : string =
        match v71 with
        | US7_1 -> (* None *)
            let v76 : string = ""
            v76
        | US7_0(v75) -> (* Some *)
            v75
    let _run_target_args'_v2 = v78 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : US5 = US5_1
    let v80 : US6 = US6_1(v79)
    let v81 : string = $"env.get_environment_variable / target: {v80} / var: {v0}"
    let v82 : string = failwith<string> v81
    let _run_target_args'_v2 = v82 
    #endif
#else
    let v83 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v84 : string = v83 v0
    let mutable _v84 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v86 : (string -> string option) = Option.ofObj
    let v87 : string option = v86 v84
    v87 
    #else
    Some v84 
    #endif
    |> fun x -> _v84 <- Some x
    let v88 : string option = match _v84 with Some x -> x | None -> failwith "optionm'.of_obj / _v84=None"
    let v93 : (string -> US7) = method11()
    let v94 : US7 option = v88 |> Option.map v93 
    let v114 : US7 = US7_1
    let v115 : US7 = v94 |> Option.defaultValue v114 
    let v122 : string =
        match v115 with
        | US7_1 -> (* None *)
            let v120 : string = ""
            v120
        | US7_0(v119) -> (* Some *)
            v119
    let _run_target_args'_v2 = v122 
    #endif
    let v123 : string = _run_target_args'_v2 
    v123
and method7 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method8(v0)
    
    
    
    
    
    
    
    
    
    
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
    let v129 : string = method8(v128)
    let v132 : string = "True"
    let v133 : bool = v129 <> v132 
    let v210 : US4 =
        if v133 then
            US4_1
        else
            (* run_target_args'
            let v143 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v144 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v145 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v147 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v143 = v147 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v150 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v150 
            #endif
#if FABLE_COMPILER_PYTHON
            let v151 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v151 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v152 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v152 
            #endif
#else
            let v153 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v153 
            #endif
            let v154 : System.DateTime = _run_target_args'_v143 
            (* run_target_args'
            let v165 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v166 : (System.DateTime -> int64) = _.Ticks
            let v167 : int64 = v166 v154
            let _run_target_args'_v165 = v167 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v168 : (System.DateTime -> int64) = _.Ticks
            let v169 : int64 = v168 v154
            let _run_target_args'_v165 = v169 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : int64 = null |> unbox<int64>
            let _run_target_args'_v165 = v171 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v174 : (System.DateTime -> int64) = _.Ticks
            let v175 : int64 = v174 v154
            let _run_target_args'_v165 = v175 
            #endif
#if FABLE_COMPILER_PYTHON
            let v176 : (System.DateTime -> int64) = _.Ticks
            let v177 : int64 = v176 v154
            let _run_target_args'_v165 = v177 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v178 : (System.DateTime -> int64) = _.Ticks
            let v179 : int64 = v178 v154
            let _run_target_args'_v165 = v179 
            #endif
#else
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v154
            let _run_target_args'_v165 = v181 
            #endif
            let v182 : int64 = _run_target_args'_v165 
            let v204 : int64 = v182 |> int64 
            US4_0(v204)
    struct (v127, v210)
and closure11 () (v0 : string) : unit =
    ()
and method6 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US3, v5 : US4) = method7()
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
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v43 v52 
    let _run_target_args'_v13 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "String::from($0)"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "String::from($0)"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "String::from($0)"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : std_string_String = _run_target_args'_v60 
    let v92 : string = "fable_library_rust::String_::fromString($0)"
    let v93 : string = Fable.Core.RustInterop.emitRustExpr v83 v92 
    let _run_target_args'_v13 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v94 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94 
    (* run_target_args'
    let v100 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : string = "String::from($0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v101 
    let _run_target_args'_v100 = v102 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v103 
    let _run_target_args'_v100 = v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : string = "String::from($0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v105 
    let _run_target_args'_v100 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v112 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v112 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v116 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v116 
    #endif
#else
    let v120 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v120 
    #endif
    let v123 : std_string_String = _run_target_args'_v100 
    let v132 : string = "fable_library_rust::String_::fromString($0)"
    let v133 : string = Fable.Core.RustInterop.emitRustExpr v123 v132 
    let _run_target_args'_v13 = v133 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : string = null |> unbox<string>
    let _run_target_args'_v13 = v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : string = null |> unbox<string>
    let _run_target_args'_v13 = v139 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v143 : string = null |> unbox<string>
    let _run_target_args'_v13 = v143 
    #endif
#else
    let v147 : string = null |> unbox<string>
    let _run_target_args'_v13 = v147 
    #endif
    let v150 : string = _run_target_args'_v13 
    let v161 : string = "True"
    let v162 : bool = v150 <> v161 
    let v174 : US4 =
        if v162 then
            US4_1
        else
            let v166 : string = $"near_sdk::env::block_timestamp()"
            let v167 : uint64 = Fable.Core.RustInterop.emitRustExpr () v166 
            let v169 : (uint64 -> int64) = int64
            let v170 : int64 = v169 v167
            US4_0(v170)
    let v175 : US3 = US3_1
    let _run_target_args'_v3 = struct (v175, v174) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v176 : US3, v177 : US4) = method7()
    let _run_target_args'_v3 = struct (v176, v177) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v178 : US3, v179 : US4) = method7()
    let _run_target_args'_v3 = struct (v178, v179) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v180 : US3, v181 : US4) = method7()
    let _run_target_args'_v3 = struct (v180, v181) 
    #endif
#else
    let struct (v182 : US3, v183 : US4) = method7()
    let _run_target_args'_v3 = struct (v182, v183) 
    #endif
    let struct (v184 : US3, v185 : US4) = _run_target_args'_v3 
    let v190 : Mut1 = {l0 = 1L} : Mut1
    let v191 : (string -> unit) = closure11()
    let v192 : Mut3 = {l0 = v191} : Mut3
    let v193 : Mut4 = {l0 = true} : Mut4
    let v194 : string = ""
    let v195 : Mut5 = {l0 = v194} : Mut5
    let v198 : US2 =
        match v184 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v196) -> (* Some *)
            v196
    let v199 : Mut6 = {l0 = v198} : Mut6
    let v210 : int64 option =
        match v185 with
        | US4_1 -> (* None *)
            let v206 : int64 option = None
            v206
        | US4_0(v200) -> (* Some *)
            let v202 : int64 option = Some v200 
            v202
    struct (v190, v192, v193, v195, v199, v210)
and closure9 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US2 = US2_0
        let struct (v2 : Mut1, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : Mut6, v7 : int64 option) = method6(v1)
        let v9 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and closure12 () (v0 : int64) : US4 =
    US4_0(v0)
and method13 () : (int64 -> US4) =
    closure12()
and method14 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method15 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method12 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    (* run_target_args'
    let v216 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : (int64 -> US4) = method13()
    let v220 : US4 option = v5 |> Option.map v219 
    let v240 : US4 = US4_1
    let v241 : US4 = v220 |> Option.defaultValue v240 
    let v395 : System.DateTime =
        match v241 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v378 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v379 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v378 = v379 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v380 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v378 = v380 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v382 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v378 = v382 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v385 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v378 = v385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v378 = v386 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v387 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v378 = v387 
            #endif
#else
            let v388 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v378 = v388 
            #endif
            let v389 : System.DateTime = _run_target_args'_v378 
            v389
        | US4_0(v245) -> (* Some *)
            (* run_target_args'
            let v252 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v253 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v252 = v253 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v252 = v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v256 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v252 = v256 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v259 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v252 = v259 
            #endif
#if FABLE_COMPILER_PYTHON
            let v260 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v252 = v260 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v261 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v252 = v261 
            #endif
#else
            let v262 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v252 = v262 
            #endif
            let v263 : System.DateTime = _run_target_args'_v252 
            (* run_target_args'
            let v274 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v275 : (System.DateTime -> int64) = _.Ticks
            let v276 : int64 = v275 v263
            let _run_target_args'_v274 = v276 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v277 : (System.DateTime -> int64) = _.Ticks
            let v278 : int64 = v277 v263
            let _run_target_args'_v274 = v278 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v280 : int64 = null |> unbox<int64>
            let _run_target_args'_v274 = v280 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v283 : (System.DateTime -> int64) = _.Ticks
            let v284 : int64 = v283 v263
            let _run_target_args'_v274 = v284 
            #endif
#if FABLE_COMPILER_PYTHON
            let v285 : (System.DateTime -> int64) = _.Ticks
            let v286 : int64 = v285 v263
            let _run_target_args'_v274 = v286 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v287 : (System.DateTime -> int64) = _.Ticks
            let v288 : int64 = v287 v263
            let _run_target_args'_v274 = v288 
            #endif
#else
            let v289 : (System.DateTime -> int64) = _.Ticks
            let v290 : int64 = v289 v263
            let _run_target_args'_v274 = v290 
            #endif
            let v291 : int64 = _run_target_args'_v274 
            let v313 : int64 = v291 |> int64 
            let v318 : int64 = v313 - v245
            let v324 : System.TimeSpan = v318 |> System.TimeSpan 
            let v330 : (System.TimeSpan -> int32) = _.Hours
            let v331 : int32 = v330 v324
            let v335 : (System.TimeSpan -> int32) = _.Minutes
            let v336 : int32 = v335 v324
            let v340 : (System.TimeSpan -> int32) = _.Seconds
            let v341 : int32 = v340 v324
            let v345 : (System.TimeSpan -> int32) = _.Milliseconds
            let v346 : int32 = v345 v324
            let v369 : System.DateTime = System.DateTime (1, 1, 1, v331, v336, v341, v346)
            v369
    let v396 : string = method14()
    let v408 : bool = v396 = ""
    let v410 : string =
        if v408 then
            let v409 : string = "M-d-y hh:mm:ss tt"
            v409
        else
            v396
    let v411 : (string -> string) = v395.ToString
    let v412 : string = v411 v410
    let _run_target_args'_v216 = v412 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v429 : (int64 -> US4) = method13()
    let v430 : US4 option = v5 |> Option.map v429 
    let v450 : US4 = US4_1
    let v451 : US4 = v430 |> Option.defaultValue v450 
    let v605 : System.DateTime =
        match v451 with
        | US4_1 -> (* None *)
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
            v599
        | US4_0(v455) -> (* Some *)
            (* run_target_args'
            let v462 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v463 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v462 = v463 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v464 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v462 = v464 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v466 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v462 = v466 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v469 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v462 = v469 
            #endif
#if FABLE_COMPILER_PYTHON
            let v470 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v462 = v470 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v471 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v462 = v471 
            #endif
#else
            let v472 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v462 = v472 
            #endif
            let v473 : System.DateTime = _run_target_args'_v462 
            (* run_target_args'
            let v484 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v485 : (System.DateTime -> int64) = _.Ticks
            let v486 : int64 = v485 v473
            let _run_target_args'_v484 = v486 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v487 : (System.DateTime -> int64) = _.Ticks
            let v488 : int64 = v487 v473
            let _run_target_args'_v484 = v488 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v490 : int64 = null |> unbox<int64>
            let _run_target_args'_v484 = v490 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v493 : (System.DateTime -> int64) = _.Ticks
            let v494 : int64 = v493 v473
            let _run_target_args'_v484 = v494 
            #endif
#if FABLE_COMPILER_PYTHON
            let v495 : (System.DateTime -> int64) = _.Ticks
            let v496 : int64 = v495 v473
            let _run_target_args'_v484 = v496 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v497 : (System.DateTime -> int64) = _.Ticks
            let v498 : int64 = v497 v473
            let _run_target_args'_v484 = v498 
            #endif
#else
            let v499 : (System.DateTime -> int64) = _.Ticks
            let v500 : int64 = v499 v473
            let _run_target_args'_v484 = v500 
            #endif
            let v501 : int64 = _run_target_args'_v484 
            let v523 : int64 = v501 |> int64 
            let v528 : int64 = v523 - v455
            let v534 : System.TimeSpan = v528 |> System.TimeSpan 
            let v540 : (System.TimeSpan -> int32) = _.Hours
            let v541 : int32 = v540 v534
            let v545 : (System.TimeSpan -> int32) = _.Minutes
            let v546 : int32 = v545 v534
            let v550 : (System.TimeSpan -> int32) = _.Seconds
            let v551 : int32 = v550 v534
            let v555 : (System.TimeSpan -> int32) = _.Milliseconds
            let v556 : int32 = v555 v534
            let v579 : System.DateTime = System.DateTime (1, 1, 1, v541, v546, v551, v556)
            v579
    let v606 : string = method14()
    let v618 : bool = v606 = ""
    let v620 : string =
        if v618 then
            let v619 : string = "M-d-y hh:mm:ss tt"
            v619
        else
            v606
    let v621 : (string -> string) = v605.ToString
    let v622 : string = v621 v620
    let _run_target_args'_v216 = v622 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v637 : string = $"near_sdk::env::block_timestamp()"
    let v638 : uint64 = Fable.Core.RustInterop.emitRustExpr () v637 
    let v641 : (int64 -> US4) = method13()
    let v642 : US4 option = v5 |> Option.map v641 
    let v662 : US4 = US4_1
    let v663 : US4 = v642 |> Option.defaultValue v662 
    let v675 : uint64 =
        match v663 with
        | US4_1 -> (* None *)
            v638
        | US4_0(v667) -> (* Some *)
            let v669 : (int64 -> uint64) = uint64
            let v670 : uint64 = v669 v667
            let v673 : uint64 = v638 - v670
            v673
    let v676 : uint64 = v675 / 1000000000UL
    let v677 : uint64 = v676 % 60UL
    let v678 : uint64 = v676 / 60UL
    let v679 : uint64 = v678 % 60UL
    let v680 : uint64 = v676 / 3600UL
    let v681 : uint64 = v680 % 24UL
    let v682 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v683 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v681, v679, v677) v682 
    let v684 : string = "fable_library_rust::String_::fromString($0)"
    let v685 : string = Fable.Core.RustInterop.emitRustExpr v683 v684 
    let _run_target_args'_v216 = v685 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v688 : (int64 -> US4) = method13()
    let v689 : US4 option = v5 |> Option.map v688 
    let v709 : US4 = US4_1
    let v710 : US4 = v689 |> Option.defaultValue v709 
    let v864 : System.DateTime =
        match v710 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v847 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v848 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v847 = v848 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v849 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v847 = v849 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v851 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v847 = v851 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v854 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v847 = v854 
            #endif
#if FABLE_COMPILER_PYTHON
            let v855 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v847 = v855 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v856 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v847 = v856 
            #endif
#else
            let v857 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v847 = v857 
            #endif
            let v858 : System.DateTime = _run_target_args'_v847 
            v858
        | US4_0(v714) -> (* Some *)
            (* run_target_args'
            let v721 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v722 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v721 = v722 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v723 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v721 = v723 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v721 = v725 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v721 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v729 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v721 = v729 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v730 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v721 = v730 
            #endif
#else
            let v731 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v721 = v731 
            #endif
            let v732 : System.DateTime = _run_target_args'_v721 
            (* run_target_args'
            let v743 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v744 : (System.DateTime -> int64) = _.Ticks
            let v745 : int64 = v744 v732
            let _run_target_args'_v743 = v745 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v746 : (System.DateTime -> int64) = _.Ticks
            let v747 : int64 = v746 v732
            let _run_target_args'_v743 = v747 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v749 : int64 = null |> unbox<int64>
            let _run_target_args'_v743 = v749 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v752 : (System.DateTime -> int64) = _.Ticks
            let v753 : int64 = v752 v732
            let _run_target_args'_v743 = v753 
            #endif
#if FABLE_COMPILER_PYTHON
            let v754 : (System.DateTime -> int64) = _.Ticks
            let v755 : int64 = v754 v732
            let _run_target_args'_v743 = v755 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v756 : (System.DateTime -> int64) = _.Ticks
            let v757 : int64 = v756 v732
            let _run_target_args'_v743 = v757 
            #endif
#else
            let v758 : (System.DateTime -> int64) = _.Ticks
            let v759 : int64 = v758 v732
            let _run_target_args'_v743 = v759 
            #endif
            let v760 : int64 = _run_target_args'_v743 
            let v782 : int64 = v760 |> int64 
            let v787 : int64 = v782 - v714
            let v793 : System.TimeSpan = v787 |> System.TimeSpan 
            let v799 : (System.TimeSpan -> int32) = _.Hours
            let v800 : int32 = v799 v793
            let v804 : (System.TimeSpan -> int32) = _.Minutes
            let v805 : int32 = v804 v793
            let v809 : (System.TimeSpan -> int32) = _.Seconds
            let v810 : int32 = v809 v793
            let v814 : (System.TimeSpan -> int32) = _.Milliseconds
            let v815 : int32 = v814 v793
            let v838 : System.DateTime = System.DateTime (1, 1, 1, v800, v805, v810, v815)
            v838
    let v865 : string = method15()
    let v877 : bool = v865 = ""
    let v879 : string =
        if v877 then
            let v878 : string = "M-d-y hh:mm:ss tt"
            v878
        else
            v865
    let v880 : (string -> string) = v864.ToString
    let v881 : string = v880 v879
    let _run_target_args'_v216 = v881 
    #endif
#if FABLE_COMPILER_PYTHON
    let v898 : (int64 -> US4) = method13()
    let v899 : US4 option = v5 |> Option.map v898 
    let v919 : US4 = US4_1
    let v920 : US4 = v899 |> Option.defaultValue v919 
    let v1074 : System.DateTime =
        match v920 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1057 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1058 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1057 = v1058 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1059 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1057 = v1059 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1061 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1057 = v1061 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1064 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1057 = v1064 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1065 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1057 = v1065 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1066 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1057 = v1066 
            #endif
#else
            let v1067 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1057 = v1067 
            #endif
            let v1068 : System.DateTime = _run_target_args'_v1057 
            v1068
        | US4_0(v924) -> (* Some *)
            (* run_target_args'
            let v931 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v932 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v931 = v932 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v933 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v931 = v933 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v935 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v931 = v935 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v938 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v931 = v938 
            #endif
#if FABLE_COMPILER_PYTHON
            let v939 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v931 = v939 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v940 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v931 = v940 
            #endif
#else
            let v941 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v931 = v941 
            #endif
            let v942 : System.DateTime = _run_target_args'_v931 
            (* run_target_args'
            let v953 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v954 : (System.DateTime -> int64) = _.Ticks
            let v955 : int64 = v954 v942
            let _run_target_args'_v953 = v955 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v956 : (System.DateTime -> int64) = _.Ticks
            let v957 : int64 = v956 v942
            let _run_target_args'_v953 = v957 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v959 : int64 = null |> unbox<int64>
            let _run_target_args'_v953 = v959 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v962 : (System.DateTime -> int64) = _.Ticks
            let v963 : int64 = v962 v942
            let _run_target_args'_v953 = v963 
            #endif
#if FABLE_COMPILER_PYTHON
            let v964 : (System.DateTime -> int64) = _.Ticks
            let v965 : int64 = v964 v942
            let _run_target_args'_v953 = v965 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v966 : (System.DateTime -> int64) = _.Ticks
            let v967 : int64 = v966 v942
            let _run_target_args'_v953 = v967 
            #endif
#else
            let v968 : (System.DateTime -> int64) = _.Ticks
            let v969 : int64 = v968 v942
            let _run_target_args'_v953 = v969 
            #endif
            let v970 : int64 = _run_target_args'_v953 
            let v992 : int64 = v970 |> int64 
            let v997 : int64 = v992 - v924
            let v1003 : System.TimeSpan = v997 |> System.TimeSpan 
            let v1009 : (System.TimeSpan -> int32) = _.Hours
            let v1010 : int32 = v1009 v1003
            let v1014 : (System.TimeSpan -> int32) = _.Minutes
            let v1015 : int32 = v1014 v1003
            let v1019 : (System.TimeSpan -> int32) = _.Seconds
            let v1020 : int32 = v1019 v1003
            let v1024 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1025 : int32 = v1024 v1003
            let v1048 : System.DateTime = System.DateTime (1, 1, 1, v1010, v1015, v1020, v1025)
            v1048
    let v1075 : string = method15()
    let v1087 : bool = v1075 = ""
    let v1089 : string =
        if v1087 then
            let v1088 : string = "M-d-y hh:mm:ss tt"
            v1088
        else
            v1075
    let v1090 : (string -> string) = v1074.ToString
    let v1091 : string = v1090 v1089
    let _run_target_args'_v216 = v1091 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1108 : (int64 -> US4) = method13()
    let v1109 : US4 option = v5 |> Option.map v1108 
    let v1129 : US4 = US4_1
    let v1130 : US4 = v1109 |> Option.defaultValue v1129 
    let v1284 : System.DateTime =
        match v1130 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1267 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1268 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1267 = v1268 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1269 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1267 = v1269 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1271 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1267 = v1271 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1274 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1267 = v1274 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1275 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1267 = v1275 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1276 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1267 = v1276 
            #endif
#else
            let v1277 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1267 = v1277 
            #endif
            let v1278 : System.DateTime = _run_target_args'_v1267 
            v1278
        | US4_0(v1134) -> (* Some *)
            (* run_target_args'
            let v1141 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1142 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1141 = v1142 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1141 = v1143 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1145 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1141 = v1145 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1148 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1141 = v1148 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1149 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1141 = v1149 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1150 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1141 = v1150 
            #endif
#else
            let v1151 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1141 = v1151 
            #endif
            let v1152 : System.DateTime = _run_target_args'_v1141 
            (* run_target_args'
            let v1163 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1164 : (System.DateTime -> int64) = _.Ticks
            let v1165 : int64 = v1164 v1152
            let _run_target_args'_v1163 = v1165 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1166 : (System.DateTime -> int64) = _.Ticks
            let v1167 : int64 = v1166 v1152
            let _run_target_args'_v1163 = v1167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1169 : int64 = null |> unbox<int64>
            let _run_target_args'_v1163 = v1169 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1172 : (System.DateTime -> int64) = _.Ticks
            let v1173 : int64 = v1172 v1152
            let _run_target_args'_v1163 = v1173 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1174 : (System.DateTime -> int64) = _.Ticks
            let v1175 : int64 = v1174 v1152
            let _run_target_args'_v1163 = v1175 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1176 : (System.DateTime -> int64) = _.Ticks
            let v1177 : int64 = v1176 v1152
            let _run_target_args'_v1163 = v1177 
            #endif
#else
            let v1178 : (System.DateTime -> int64) = _.Ticks
            let v1179 : int64 = v1178 v1152
            let _run_target_args'_v1163 = v1179 
            #endif
            let v1180 : int64 = _run_target_args'_v1163 
            let v1202 : int64 = v1180 |> int64 
            let v1207 : int64 = v1202 - v1134
            let v1213 : System.TimeSpan = v1207 |> System.TimeSpan 
            let v1219 : (System.TimeSpan -> int32) = _.Hours
            let v1220 : int32 = v1219 v1213
            let v1224 : (System.TimeSpan -> int32) = _.Minutes
            let v1225 : int32 = v1224 v1213
            let v1229 : (System.TimeSpan -> int32) = _.Seconds
            let v1230 : int32 = v1229 v1213
            let v1234 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1235 : int32 = v1234 v1213
            let v1258 : System.DateTime = System.DateTime (1, 1, 1, v1220, v1225, v1230, v1235)
            v1258
    let v1285 : string = method15()
    let v1297 : bool = v1285 = ""
    let v1299 : string =
        if v1297 then
            let v1298 : string = "M-d-y hh:mm:ss tt"
            v1298
        else
            v1285
    let v1300 : (string -> string) = v1284.ToString
    let v1301 : string = v1300 v1299
    let _run_target_args'_v216 = v1301 
    #endif
#else
    let v1318 : (int64 -> US4) = method13()
    let v1319 : US4 option = v5 |> Option.map v1318 
    let v1339 : US4 = US4_1
    let v1340 : US4 = v1319 |> Option.defaultValue v1339 
    let v1494 : System.DateTime =
        match v1340 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1477 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1478 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1477 = v1478 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1479 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1477 = v1479 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1481 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1477 = v1481 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1484 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1477 = v1484 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1485 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1477 = v1485 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1486 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1477 = v1486 
            #endif
#else
            let v1487 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1477 = v1487 
            #endif
            let v1488 : System.DateTime = _run_target_args'_v1477 
            v1488
        | US4_0(v1344) -> (* Some *)
            (* run_target_args'
            let v1351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1352 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1351 = v1352 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1353 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1351 = v1353 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1355 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1351 = v1355 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1358 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1351 = v1358 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1359 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1351 = v1359 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1360 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1351 = v1360 
            #endif
#else
            let v1361 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1351 = v1361 
            #endif
            let v1362 : System.DateTime = _run_target_args'_v1351 
            (* run_target_args'
            let v1373 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1374 : (System.DateTime -> int64) = _.Ticks
            let v1375 : int64 = v1374 v1362
            let _run_target_args'_v1373 = v1375 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1376 : (System.DateTime -> int64) = _.Ticks
            let v1377 : int64 = v1376 v1362
            let _run_target_args'_v1373 = v1377 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1379 : int64 = null |> unbox<int64>
            let _run_target_args'_v1373 = v1379 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1382 : (System.DateTime -> int64) = _.Ticks
            let v1383 : int64 = v1382 v1362
            let _run_target_args'_v1373 = v1383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1384 : (System.DateTime -> int64) = _.Ticks
            let v1385 : int64 = v1384 v1362
            let _run_target_args'_v1373 = v1385 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1386 : (System.DateTime -> int64) = _.Ticks
            let v1387 : int64 = v1386 v1362
            let _run_target_args'_v1373 = v1387 
            #endif
#else
            let v1388 : (System.DateTime -> int64) = _.Ticks
            let v1389 : int64 = v1388 v1362
            let _run_target_args'_v1373 = v1389 
            #endif
            let v1390 : int64 = _run_target_args'_v1373 
            let v1412 : int64 = v1390 |> int64 
            let v1417 : int64 = v1412 - v1344
            let v1423 : System.TimeSpan = v1417 |> System.TimeSpan 
            let v1429 : (System.TimeSpan -> int32) = _.Hours
            let v1430 : int32 = v1429 v1423
            let v1434 : (System.TimeSpan -> int32) = _.Minutes
            let v1435 : int32 = v1434 v1423
            let v1439 : (System.TimeSpan -> int32) = _.Seconds
            let v1440 : int32 = v1439 v1423
            let v1444 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1445 : int32 = v1444 v1423
            let v1468 : System.DateTime = System.DateTime (1, 1, 1, v1430, v1435, v1440, v1445)
            v1468
    let v1495 : string = method15()
    let v1507 : bool = v1495 = ""
    let v1509 : string =
        if v1507 then
            let v1508 : string = "M-d-y hh:mm:ss tt"
            v1508
        else
            v1495
    let v1510 : (string -> string) = v1494.ToString
    let v1511 : string = v1510 v1509
    let _run_target_args'_v216 = v1511 
    #endif
    let v1526 : string = _run_target_args'_v216 
    v1526
and method18 () : string =
    let v0 : string = ""
    v0
and closure13 (v0 : Mut5, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method17 (v0 : char) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v7 : string = $"{v0}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure13(v2, v7)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v23 : string = v2.l0
    v23
and method16 () : string =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "inline_colorization::color_bright_blue"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2 
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v8 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v8 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v8 = v24 
    #endif
#else
    let v28 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v8 = v28 
    #endif
    let v31 : std_string_String = _run_target_args'_v8 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v31 v40 
    let _run_target_args'_v1 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "inline_colorization::color_bright_blue"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v42 
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v43 v49 
    let _run_target_args'_v48 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v43 v51 
    let _run_target_args'_v48 = v52 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v53 : string = "String::from($0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v43 v53 
    let _run_target_args'_v48 = v54 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v56 : std_string_String = v43 |> unbox<std_string_String>
    let _run_target_args'_v48 = v56 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_string_String = v43 |> unbox<std_string_String>
    let _run_target_args'_v48 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : std_string_String = v43 |> unbox<std_string_String>
    let _run_target_args'_v48 = v64 
    #endif
#else
    let v68 : std_string_String = v43 |> unbox<std_string_String>
    let _run_target_args'_v48 = v68 
    #endif
    let v71 : std_string_String = _run_target_args'_v48 
    let v80 : string = "fable_library_rust::String_::fromString($0)"
    let v81 : string = Fable.Core.RustInterop.emitRustExpr v71 v80 
    let _run_target_args'_v1 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = "inline_colorization::color_bright_blue"
    let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82 
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v83 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v83 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "String::from($0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v83 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : std_string_String = v83 |> unbox<std_string_String>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : std_string_String = v83 |> unbox<std_string_String>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v83 |> unbox<std_string_String>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : std_string_String = v83 |> unbox<std_string_String>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : std_string_String = _run_target_args'_v88 
    let v120 : string = "fable_library_rust::String_::fromString($0)"
    let v121 : string = Fable.Core.RustInterop.emitRustExpr v111 v120 
    let _run_target_args'_v1 = v121 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v122 : string = "\u001b[94m"
    let _run_target_args'_v1 = v122 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : string = "\u001b[94m"
    let _run_target_args'_v1 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v124 : string = "\u001b[94m"
    let _run_target_args'_v1 = v124 
    #endif
#else
    let v125 : string = "\u001b[94m"
    let _run_target_args'_v1 = v125 
    #endif
    let v126 : string = _run_target_args'_v1 
    
    
    
    
    
    let v131 : string = "Debug"
    let v132 : (unit -> string) = v131.ToLower
    let v133 : string = v132 ()
    let v136 : char = v133.[int 0]
    let v137 : string = method17(v136)
    let v139 : string = v126 + v137 
    (* run_target_args'
    let v143 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : string = "inline_colorization::color_reset"
    let v145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v144 
    (* run_target_args'
    let v150 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v151 : string = "String::from($0)"
    let v152 : std_string_String = Fable.Core.RustInterop.emitRustExpr v145 v151 
    let _run_target_args'_v150 = v152 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v153 : string = "String::from($0)"
    let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v145 v153 
    let _run_target_args'_v150 = v154 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v155 : string = "String::from($0)"
    let v156 : std_string_String = Fable.Core.RustInterop.emitRustExpr v145 v155 
    let _run_target_args'_v150 = v156 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v158 : std_string_String = v145 |> unbox<std_string_String>
    let _run_target_args'_v150 = v158 
    #endif
#if FABLE_COMPILER_PYTHON
    let v162 : std_string_String = v145 |> unbox<std_string_String>
    let _run_target_args'_v150 = v162 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v166 : std_string_String = v145 |> unbox<std_string_String>
    let _run_target_args'_v150 = v166 
    #endif
#else
    let v170 : std_string_String = v145 |> unbox<std_string_String>
    let _run_target_args'_v150 = v170 
    #endif
    let v173 : std_string_String = _run_target_args'_v150 
    let v182 : string = "fable_library_rust::String_::fromString($0)"
    let v183 : string = Fable.Core.RustInterop.emitRustExpr v173 v182 
    let _run_target_args'_v143 = v183 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v184 : string = "inline_colorization::color_reset"
    let v185 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v184 
    (* run_target_args'
    let v190 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v191 : string = "String::from($0)"
    let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v191 
    let _run_target_args'_v190 = v192 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v193 : string = "String::from($0)"
    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v193 
    let _run_target_args'_v190 = v194 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v195 : string = "String::from($0)"
    let v196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v195 
    let _run_target_args'_v190 = v196 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v198 : std_string_String = v185 |> unbox<std_string_String>
    let _run_target_args'_v190 = v198 
    #endif
#if FABLE_COMPILER_PYTHON
    let v202 : std_string_String = v185 |> unbox<std_string_String>
    let _run_target_args'_v190 = v202 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v206 : std_string_String = v185 |> unbox<std_string_String>
    let _run_target_args'_v190 = v206 
    #endif
#else
    let v210 : std_string_String = v185 |> unbox<std_string_String>
    let _run_target_args'_v190 = v210 
    #endif
    let v213 : std_string_String = _run_target_args'_v190 
    let v222 : string = "fable_library_rust::String_::fromString($0)"
    let v223 : string = Fable.Core.RustInterop.emitRustExpr v213 v222 
    let _run_target_args'_v143 = v223 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v224 : string = "inline_colorization::color_reset"
    let v225 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v224 
    (* run_target_args'
    let v230 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v231 : string = "String::from($0)"
    let v232 : std_string_String = Fable.Core.RustInterop.emitRustExpr v225 v231 
    let _run_target_args'_v230 = v232 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v233 : string = "String::from($0)"
    let v234 : std_string_String = Fable.Core.RustInterop.emitRustExpr v225 v233 
    let _run_target_args'_v230 = v234 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v235 : string = "String::from($0)"
    let v236 : std_string_String = Fable.Core.RustInterop.emitRustExpr v225 v235 
    let _run_target_args'_v230 = v236 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v238 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v230 = v238 
    #endif
#if FABLE_COMPILER_PYTHON
    let v242 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v230 = v242 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v246 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v230 = v246 
    #endif
#else
    let v250 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v230 = v250 
    #endif
    let v253 : std_string_String = _run_target_args'_v230 
    let v262 : string = "fable_library_rust::String_::fromString($0)"
    let v263 : string = Fable.Core.RustInterop.emitRustExpr v253 v262 
    let _run_target_args'_v143 = v263 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v264 : string = "\u001b[0m"
    let _run_target_args'_v143 = v264 
    #endif
#if FABLE_COMPILER_PYTHON
    let v265 : string = "\u001b[0m"
    let _run_target_args'_v143 = v265 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v266 : string = "\u001b[0m"
    let _run_target_args'_v143 = v266 
    #endif
#else
    let v267 : string = "\u001b[0m"
    let _run_target_args'_v143 = v267 
    #endif
    let v268 : string = _run_target_args'_v143 
    let v272 : string = v139 + v268 
    v272
and method20 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure13(v5, v9)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v27 : string = "current_index"
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure13(v5, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = " = "
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure13(v5, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v67 : string = $"{v0}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure13(v5, v67)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v85 : string = "; "
    let v86 : string = $"{v85}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v5, v86)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v104 : string = "acc"
    let v105 : string = $"{v104}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure13(v5, v105)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v122 : string = $"{v46}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure13(v5, v122)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v142 : string = $"{v1}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure13(v5, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v159 : string = $"{v85}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure13(v5, v159)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v177 : string = "len"
    let v178 : string = $"{v177}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure13(v5, v178)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v195 : string = $"{v46}"
    let v203 : unit = ()
    let v204 : (unit -> unit) = closure13(v5, v195)
    let v205 : unit = (fun () -> v204 (); v203) ()
    let v215 : string = $"{v2}"
    let v223 : unit = ()
    let v224 : (unit -> unit) = closure13(v5, v215)
    let v225 : unit = (fun () -> v224 (); v223) ()
    let v232 : string = $"{v85}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure13(v5, v232)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v250 : string = "last_item"
    let v251 : string = $"{v250}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure13(v5, v251)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v268 : string = $"{v46}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure13(v5, v268)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v285 : string = $"{v3}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure13(v5, v285)
    let v295 : unit = (fun () -> v294 (); v293) ()
    let v303 : string = " }"
    let v304 : string = $"{v303}"
    let v312 : unit = ()
    let v313 : (unit -> unit) = closure13(v5, v304)
    let v314 : unit = (fun () -> v313 (); v312) ()
    let v320 : string = v5.l0
    v320
and method21 (v0 : string) : string =
    let v1 : char list = []
    let v8 : (char list -> (char [])) = List.toArray
    let v9 : (char []) = v8 v1
    let v12 : string = v0.TrimStart v9 
    let v46 : char list = []
    let v48 : char list = '/' :: v46 
    let v52 : char list = ' ' :: v48 
    let v61 : (char list -> (char [])) = List.toArray
    let v62 : (char []) = v61 v52
    let v65 : string = v12.TrimEnd v62 
    v65
and method19 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method20(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.create_sequential_roller / roll"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure14 (v0 : Mut1) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure16 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure15 () (v0 : string) : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure16(v0)
    let v4 : unit = (fun () -> v3 (); v2) ()
    ()
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure9()
    let v20 : unit = (fun () -> v19 (); v18) ()
    let struct (v43 : Mut1, v44 : Mut3, v45 : Mut4, v46 : Mut5, v47 : Mut6, v48 : int64 option) = TraceState.trace_state.Value
    let v61 : US2 = v47.l0
    let v62 : bool = v45.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    let v67 : bool = v66 = false
    let v305 : US8 =
        if v67 then
            US8_1
        else
            let v83 : unit = ()
            let v84 : unit = (fun () -> v19 (); v83) ()
            let struct (v107 : Mut1, v108 : Mut3, v109 : Mut4, v110 : Mut5, v111 : Mut6, v112 : int64 option) = TraceState.trace_state.Value
            let v125 : string = method12(v107, v108, v109, v110, v111, v112)
            let v126 : string = method16()
            let v128 : string = $"%A{v3}"
            let v131 : string = method19(v107, v108, v109, v110, v111, v112, v125, v126, v0, v1, v2, v128)
            let v146 : unit = ()
            let v147 : unit = (fun () -> v19 (); v146) ()
            let struct (v170 : Mut1, v171 : Mut3, v172 : Mut4, v173 : Mut5, v174 : Mut6, v175 : int64 option) = TraceState.trace_state.Value
            let v190 : unit = ()
            let v191 : (unit -> unit) = closure14(v170)
            let v192 : unit = (fun () -> v191 (); v190) ()
            let v195 : (string -> unit) = closure15()
            (* run_target_args'
            let v196 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v197 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v131 v197 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v198 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v131 v198 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v199 : string = v173.l0
            let v200 : bool = v199 = ""
            let v215 : string =
                if v200 then
                    v131
                else
                    let v201 : bool = v131 = ""
                    if v201 then
                        let v202 : string = v173.l0
                        v202
                    else
                        let v203 : string = v173.l0
                        let v206 : string = "\n"
                        let v207 : string = v203 + v206 
                        let v211 : string = v207 + v131 
                        v211
            (* run_target_args'
            let v220 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v221 : string = "&*$0"
            let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v221 
            let _run_target_args'_v220 = v222 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v223 : string = "&*$0"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v223 
            let _run_target_args'_v220 = v224 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v225 : string = "&*$0"
            let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v225 
            let _run_target_args'_v220 = v226 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v228 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v228 
            #endif
#if FABLE_COMPILER_PYTHON
            let v232 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v232 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v236 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v236 
            #endif
#else
            let v240 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v240 
            #endif
            let v243 : Ref<Str> = _run_target_args'_v220 
            let v252 : string = $"$0.chars()"
            let v253 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v243 v252 
            let v254 : string = "$0"
            let v255 : _ = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "$0.collect::<Vec<_>>()"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v259 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "x"
            let v263 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "String::from_iter($0)"
            let v265 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v266 : string = "true; $0 }).collect::<Vec<_>>()"
            let v267 : bool = Fable.Core.RustInterop.emitRustExpr v265 v266 
            let v268 : string = "_vec_map"
            let v269 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v268 
            let v270 : string = "$0.len()"
            let v271 : unativeint = Fable.Core.RustInterop.emitRustExpr v269 v270 
            let v277 : int32 = v271 |> int32 
            let v287 : string = ""
            let v288 : bool = v131 <> v287 
            let v292 : bool =
                if v288 then
                    let v291 : bool = v277 <= 1
                    v291
                else
                    false
            if v292 then
                v173.l0 <- v215
                ()
            else
                v173.l0 <- v287
                let v293 : string = "true; $0.into_iter().for_each(|x| { //"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr v269 v293 
                let v295 : string = "x"
                let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v295 
                let v297 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v298 : bool = Fable.Core.RustInterop.emitRustExpr v296 v297 
                let v299 : string = $"true"
                let v300 : bool = Fable.Core.RustInterop.emitRustExpr () v299 
                let v301 : string = "true; }); //"
                let v302 : bool = Fable.Core.RustInterop.emitRustExpr () v301 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v195 v131
            #endif
#if FABLE_COMPILER_PYTHON
            v195 v131
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v195 v131
            #endif
#else
            v195 v131
            #endif
            // run_target_args' is_unit
            let v303 : (string -> unit) = v171.l0
            v303 v131
            US8_0(v170, v171, v172, v173, v174, v175)
    
    ()
and method22 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method22(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method24 () : string =
    let v0 : string = method18()
    let v1 : Mut5 = {l0 = v0} : Mut5
    let v2 : string = v1.l0
    v2
and method23 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method24()
    let v9 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v17 : string = v13 + v7 
    let v22 : string = " #"
    let v23 : string = v17 + v22 
    let v27 : (int64 -> string) = _.ToString()
    let v28 : string = v27 v9
    let v32 : string = v23 + v28 
    let v36 : string = v32 + v12 
    let v41 : string = "dice.create_sequential_roller / roll / None"
    let v42 : string = v36 + v41 
    let v47 : string = " / "
    let v48 : string = v42 + v47 
    let v52 : string = v48 + v8 
    method21(v52)
and closure17 () () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure9()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
    let v57 : US2 = v43.l0
    let v58 : bool = v41.l0
    let v59 : bool = v58 = false
    let v62 : bool =
        if v59 then
            false
        else
            let v60 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v57
            let v61 : bool = 1 >= v60
            v61
    let v63 : bool = v62 = false
    let v297 : US8 =
        if v63 then
            US8_1
        else
            let v79 : unit = ()
            let v80 : unit = (fun () -> v15 (); v79) ()
            let struct (v103 : Mut1, v104 : Mut3, v105 : Mut4, v106 : Mut5, v107 : Mut6, v108 : int64 option) = TraceState.trace_state.Value
            let v121 : string = method12(v103, v104, v105, v106, v107, v108)
            let v122 : string = method16()
            let v123 : string = method23(v103, v104, v105, v106, v107, v108, v121, v122)
            let v138 : unit = ()
            let v139 : unit = (fun () -> v15 (); v138) ()
            let struct (v162 : Mut1, v163 : Mut3, v164 : Mut4, v165 : Mut5, v166 : Mut6, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure14(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : (string -> unit) = closure15()
            (* run_target_args'
            let v188 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v189 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v123 v189 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v123 v190 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v191 : string = v165.l0
            let v192 : bool = v191 = ""
            let v207 : string =
                if v192 then
                    v123
                else
                    let v193 : bool = v123 = ""
                    if v193 then
                        let v194 : string = v165.l0
                        v194
                    else
                        let v195 : string = v165.l0
                        let v198 : string = "\n"
                        let v199 : string = v195 + v198 
                        let v203 : string = v199 + v123 
                        v203
            (* run_target_args'
            let v212 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v213 : string = "&*$0"
            let v214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v213 
            let _run_target_args'_v212 = v214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v215 
            let _run_target_args'_v212 = v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v217 
            let _run_target_args'_v212 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v220 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v220 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v228 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v228 
            #endif
#else
            let v232 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v232 
            #endif
            let v235 : Ref<Str> = _run_target_args'_v212 
            let v244 : string = $"$0.chars()"
            let v245 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v235 v244 
            let v246 : string = "$0"
            let v247 : _ = Fable.Core.RustInterop.emitRustExpr v245 v246 
            let v248 : string = "$0.collect::<Vec<_>>()"
            let v249 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v251 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v253 : bool = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "x"
            let v255 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v254 
            let v256 : string = "String::from_iter($0)"
            let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "true; $0 }).collect::<Vec<_>>()"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "_vec_map"
            let v261 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "$0.len()"
            let v263 : unativeint = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v269 : int32 = v263 |> int32 
            let v279 : string = ""
            let v280 : bool = v123 <> v279 
            let v284 : bool =
                if v280 then
                    let v283 : bool = v269 <= 1
                    v283
                else
                    false
            if v284 then
                v165.l0 <- v207
                ()
            else
                v165.l0 <- v279
                let v285 : string = "true; $0.into_iter().for_each(|x| { //"
                let v286 : bool = Fable.Core.RustInterop.emitRustExpr v261 v285 
                let v287 : string = "x"
                let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v287 
                let v289 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v290 : bool = Fable.Core.RustInterop.emitRustExpr v288 v289 
                let v291 : string = $"true"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr () v291 
                let v293 : string = "true; }); //"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v187 v123
            #endif
#if FABLE_COMPILER_PYTHON
            v187 v123
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v187 v123
            #endif
#else
            v187 v123
            #endif
            // run_target_args' is_unit
            let v295 : (string -> unit) = v163.l0
            v295 v123
            US8_0(v162, v163, v164, v165, v166, v167)
    
    ()
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
    let v335 : unit = ()
    let v336 : (unit -> unit) = closure8(v5, v6, v7, v19)
    let v337 : unit = (fun () -> v336 (); v335) ()
    let v656 : UH0 = v0 ()
    let v657 : int64 = v1.l0
    let v658 : US1 = method22(v657, v656)
    match v658 with
    | US1_1 -> (* None *)
        let v974 : unit = ()
        let v975 : (unit -> unit) = closure17()
        let v976 : unit = (fun () -> v975 (); v974) ()
        let v1291 : int64 = v3.l0
        let v1292 : bool = v1291 = -1L
        if v1292 then
            let v1293 : int64 = v1.l0
            v3.l0 <- v1293
            ()
        let v1294 : int64 = v2.l0
        let v1295 : int64 = v3.l0
        let v1296 : bool = v1294 >= v1295
        let v1299 : int64 =
            if v1296 then
                1L
            else
                let v1297 : int64 = v2.l0
                let v1298 : int64 = v1297 + 1L
                v1298
        v2.l0 <- v1299
        let v1300 : int64 = v2.l0
        let v1301 : int64 = v1300 - 1L
        v1.l0 <- v1301
        let v1302 : US1 = US1_1
        v4.l0 <- v1302
        method5(v0, v1, v2, v3, v4)
    | US1_0(v659) -> (* Some *)
        let v660 : int64 = v1.l0
        let v661 : int64 = v660 + 1L
        v1.l0 <- v661
        let v662 : US1 = US1_0(v659)
        v4.l0 <- v662
        v659
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
and method27 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "max"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure13(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "p"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure13(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure13(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure13(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "n"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure13(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure13(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure13(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure13(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method26 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method27(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.calculate_dice_count"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure21 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method26(v106, v107, v108, v109, v110, v111, v124, v125, v0, v2, v1)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method25 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method25(v0, v6, v4)
        else
            let v319 : unit = ()
            let v320 : (unit -> unit) = closure21(v0, v1, v2)
            let v321 : unit = (fun () -> v320 (); v319) ()
            v1
    else
        let v948 : unit = ()
        let v949 : (unit -> unit) = closure21(v0, v1, v2)
        let v950 : unit = (fun () -> v949 (); v948) ()
        v1
and method31 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "power"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure13(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "acc"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure13(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure13(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure13(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "result"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure13(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure13(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure13(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure13(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method30 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method31(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method30(v106, v107, v108, v109, v110, v111, v124, v125, v1, v0, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
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
and method32 (v0 : int8, v1 : UH2) : US10 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US10_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method32(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US10_1
and method34 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure13(v5, v9)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v27 : string = "power"
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure13(v5, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = " = "
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure13(v5, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v67 : string = $"{v0}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure13(v5, v67)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v85 : string = "; "
    let v86 : string = $"{v85}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v5, v86)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v104 : string = "acc"
    let v105 : string = $"{v104}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure13(v5, v105)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v122 : string = $"{v46}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure13(v5, v122)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v142 : string = $"{v1}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure13(v5, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v159 : string = $"{v85}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure13(v5, v159)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v177 : string = "roll"
    let v178 : string = $"{v177}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure13(v5, v178)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v195 : string = $"{v46}"
    let v203 : unit = ()
    let v204 : (unit -> unit) = closure13(v5, v195)
    let v205 : unit = (fun () -> v204 (); v203) ()
    let v215 : string = $"{v2}"
    let v223 : unit = ()
    let v224 : (unit -> unit) = closure13(v5, v215)
    let v225 : unit = (fun () -> v224 (); v223) ()
    let v232 : string = $"{v85}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure13(v5, v232)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v250 : string = "value"
    let v251 : string = $"{v250}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure13(v5, v251)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v268 : string = $"{v46}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure13(v5, v268)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v288 : string = $"{v3}"
    let v296 : unit = ()
    let v297 : (unit -> unit) = closure13(v5, v288)
    let v298 : unit = (fun () -> v297 (); v296) ()
    let v306 : string = " }"
    let v307 : string = $"{v306}"
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure13(v5, v307)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v323 : string = v5.l0
    v323
and method33 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method34(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure9()
    let v20 : unit = (fun () -> v19 (); v18) ()
    let struct (v43 : Mut1, v44 : Mut3, v45 : Mut4, v46 : Mut5, v47 : Mut6, v48 : int64 option) = TraceState.trace_state.Value
    let v61 : US2 = v47.l0
    let v62 : bool = v45.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    let v67 : bool = v66 = false
    let v301 : US8 =
        if v67 then
            US8_1
        else
            let v83 : unit = ()
            let v84 : unit = (fun () -> v19 (); v83) ()
            let struct (v107 : Mut1, v108 : Mut3, v109 : Mut4, v110 : Mut5, v111 : Mut6, v112 : int64 option) = TraceState.trace_state.Value
            let v125 : string = method12(v107, v108, v109, v110, v111, v112)
            let v126 : string = method16()
            let v127 : string = method33(v107, v108, v109, v110, v111, v112, v125, v126, v1, v0, v2, v3)
            let v142 : unit = ()
            let v143 : unit = (fun () -> v19 (); v142) ()
            let struct (v166 : Mut1, v167 : Mut3, v168 : Mut4, v169 : Mut5, v170 : Mut6, v171 : int64 option) = TraceState.trace_state.Value
            let v186 : unit = ()
            let v187 : (unit -> unit) = closure14(v166)
            let v188 : unit = (fun () -> v187 (); v186) ()
            let v191 : (string -> unit) = closure15()
            (* run_target_args'
            let v192 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v127 v193 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v194 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v127 v194 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v195 : string = v169.l0
            let v196 : bool = v195 = ""
            let v211 : string =
                if v196 then
                    v127
                else
                    let v197 : bool = v127 = ""
                    if v197 then
                        let v198 : string = v169.l0
                        v198
                    else
                        let v199 : string = v169.l0
                        let v202 : string = "\n"
                        let v203 : string = v199 + v202 
                        let v207 : string = v203 + v127 
                        v207
            (* run_target_args'
            let v216 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v211 v217 
            let _run_target_args'_v216 = v218 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v211 v219 
            let _run_target_args'_v216 = v220 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v221 : string = "&*$0"
            let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v211 v221 
            let _run_target_args'_v216 = v222 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v224 : Ref<Str> = v211 |> unbox<Ref<Str>>
            let _run_target_args'_v216 = v224 
            #endif
#if FABLE_COMPILER_PYTHON
            let v228 : Ref<Str> = v211 |> unbox<Ref<Str>>
            let _run_target_args'_v216 = v228 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v232 : Ref<Str> = v211 |> unbox<Ref<Str>>
            let _run_target_args'_v216 = v232 
            #endif
#else
            let v236 : Ref<Str> = v211 |> unbox<Ref<Str>>
            let _run_target_args'_v216 = v236 
            #endif
            let v239 : Ref<Str> = _run_target_args'_v216 
            let v248 : string = $"$0.chars()"
            let v249 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v239 v248 
            let v250 : string = "$0"
            let v251 : _ = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.collect::<Vec<_>>()"
            let v253 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v255 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v257 : bool = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "x"
            let v259 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v258 
            let v260 : string = "String::from_iter($0)"
            let v261 : std_string_String = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "true; $0 }).collect::<Vec<_>>()"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v264 : string = "_vec_map"
            let v265 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "$0.len()"
            let v267 : unativeint = Fable.Core.RustInterop.emitRustExpr v265 v266 
            let v273 : int32 = v267 |> int32 
            let v283 : string = ""
            let v284 : bool = v127 <> v283 
            let v288 : bool =
                if v284 then
                    let v287 : bool = v273 <= 1
                    v287
                else
                    false
            if v288 then
                v169.l0 <- v211
                ()
            else
                v169.l0 <- v283
                let v289 : string = "true; $0.into_iter().for_each(|x| { //"
                let v290 : bool = Fable.Core.RustInterop.emitRustExpr v265 v289 
                let v291 : string = "x"
                let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v291 
                let v293 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr v292 v293 
                let v295 : string = $"true"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                let v297 : string = "true; }); //"
                let v298 : bool = Fable.Core.RustInterop.emitRustExpr () v297 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v191 v127
            #endif
#if FABLE_COMPILER_PYTHON
            v191 v127
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v191 v127
            #endif
#else
            v191 v127
            #endif
            // run_target_args' is_unit
            let v299 : (string -> unit) = v167.l0
            v299 v127
            US8_0(v166, v167, v168, v169, v170, v171)
    
    ()
and method36 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "power"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure13(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "acc"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure13(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure13(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure13(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "roll"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure13(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure13(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure13(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure13(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method35 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method36(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method35(v106, v107, v108, v109, v110, v111, v124, v125, v1, v0, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method29 (v0 : int8, v1 : UH1, v2 : uint64) : US9 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v316 : unit = ()
        let v317 : (unit -> unit) = closure22(v2, v0, v4)
        let v318 : unit = (fun () -> v317 (); v316) ()
        US9_0(v4, v1)
    else
        match v1 with
        | UH1_1(v635, v636) -> (* Cons *)
            let v637 : bool = v635 > 1uy
            if v637 then
                let v638 : uint64 = 1UL
                let v639 : (unit -> UH2) = closure23()
                let v640 : UH2 = UH2_0(v638, v639)
                let v641 : US10 = method32(v0, v640)
                let v645 : uint64 =
                    match v641 with
                    | US10_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US10_0(v642) -> (* Some *)
                        v642
                let v646 : uint8 = v635 - 1uy
                let v647 : uint64 = uint64 v646
                let v648 : uint64 = v647 * v645
                let v960 : unit = ()
                let v961 : (unit -> unit) = closure87(v2, v0, v635, v648)
                let v962 : unit = (fun () -> v961 (); v960) ()
                let v1277 : uint64 = v2 + v648
                let v1278 : int8 = v0 - 1y
                method29(v1278, v636, v1277)
            else
                let v1591 : unit = ()
                let v1592 : (unit -> unit) = closure88(v2, v0, v635)
                let v1593 : unit = (fun () -> v1592 (); v1591) ()
                let v1908 : int8 = v0 - 1y
                method29(v1908, v636, v2)
        | UH1_0 -> (* Nil *)
            US9_1
and method37 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method37(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method38 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method28(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US9 = method29(v3, v4, v10)
        match v11 with
        | US9_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method37(v3, v0, v15)
                    method38(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method28(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method37(v3, v0, v23)
                method38(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method28(v0, v1, v2, v3, v27, v5)
and method28 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method28(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US9 = method29(v3, v4, v12)
        match v13 with
        | US9_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method37(v3, v0, v17)
                    method38(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method28(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method37(v3, v0, v26)
                method38(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method28(v0, v1, v2, v3, v30, v31)
and closure20 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method25(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method28(v0, v1, v2, v8, v9, v10)
and closure19 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure20(v0, v1)
and closure18 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure19(v0)
and method39 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method39(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure90 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method39(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US9 = method29(v4, v1, v5)
    let v16 : US10 =
        match v6 with
        | US9_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US10_0(v7)
            else
                US10_1
        | _ ->
            US10_1
    match v16 with
    | US10_1 -> (* None *)
        let v23 : uint64 option = None
        v23
    | US10_0(v17) -> (* Some *)
        let v19 : uint64 option = Some v17 
        v19
and closure89 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure90(v0)
and method41 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "max"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure13(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "p"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure13(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure13(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure13(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "n"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure13(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure13(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure13(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure13(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method40 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = 9223372036854775807L
    let v9 : int64 = 4738381338321616896L
    let v10 : int8 = 24y
    let v11 : string = method41(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.calculate_dice_count"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure92 () () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure9()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
    let v57 : US2 = v43.l0
    let v58 : bool = v41.l0
    let v59 : bool = v58 = false
    let v62 : bool =
        if v59 then
            false
        else
            let v60 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v57
            let v61 : bool = 1 >= v60
            v61
    let v63 : bool = v62 = false
    let v297 : US8 =
        if v63 then
            US8_1
        else
            let v79 : unit = ()
            let v80 : unit = (fun () -> v15 (); v79) ()
            let struct (v103 : Mut1, v104 : Mut3, v105 : Mut4, v106 : Mut5, v107 : Mut6, v108 : int64 option) = TraceState.trace_state.Value
            let v121 : string = method12(v103, v104, v105, v106, v107, v108)
            let v122 : string = method16()
            let v123 : string = method40(v103, v104, v105, v106, v107, v108, v121, v122)
            let v138 : unit = ()
            let v139 : unit = (fun () -> v15 (); v138) ()
            let struct (v162 : Mut1, v163 : Mut3, v164 : Mut4, v165 : Mut5, v166 : Mut6, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure14(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : (string -> unit) = closure15()
            (* run_target_args'
            let v188 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v189 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v123 v189 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v123 v190 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v191 : string = v165.l0
            let v192 : bool = v191 = ""
            let v207 : string =
                if v192 then
                    v123
                else
                    let v193 : bool = v123 = ""
                    if v193 then
                        let v194 : string = v165.l0
                        v194
                    else
                        let v195 : string = v165.l0
                        let v198 : string = "\n"
                        let v199 : string = v195 + v198 
                        let v203 : string = v199 + v123 
                        v203
            (* run_target_args'
            let v212 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v213 : string = "&*$0"
            let v214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v213 
            let _run_target_args'_v212 = v214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v215 
            let _run_target_args'_v212 = v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v217 
            let _run_target_args'_v212 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v220 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v220 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v228 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v228 
            #endif
#else
            let v232 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v232 
            #endif
            let v235 : Ref<Str> = _run_target_args'_v212 
            let v244 : string = $"$0.chars()"
            let v245 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v235 v244 
            let v246 : string = "$0"
            let v247 : _ = Fable.Core.RustInterop.emitRustExpr v245 v246 
            let v248 : string = "$0.collect::<Vec<_>>()"
            let v249 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v251 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v253 : bool = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "x"
            let v255 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v254 
            let v256 : string = "String::from_iter($0)"
            let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "true; $0 }).collect::<Vec<_>>()"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "_vec_map"
            let v261 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "$0.len()"
            let v263 : unativeint = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v269 : int32 = v263 |> int32 
            let v279 : string = ""
            let v280 : bool = v123 <> v279 
            let v284 : bool =
                if v280 then
                    let v283 : bool = v269 <= 1
                    v283
                else
                    false
            if v284 then
                v165.l0 <- v207
                ()
            else
                v165.l0 <- v279
                let v285 : string = "true; $0.into_iter().for_each(|x| { //"
                let v286 : bool = Fable.Core.RustInterop.emitRustExpr v261 v285 
                let v287 : string = "x"
                let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v287 
                let v289 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v290 : bool = Fable.Core.RustInterop.emitRustExpr v288 v289 
                let v291 : string = $"true"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr () v291 
                let v293 : string = "true; }); //"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v187 v123
            #endif
#if FABLE_COMPILER_PYTHON
            v187 v123
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v187 v123
            #endif
#else
            v187 v123
            #endif
            // run_target_args' is_unit
            let v295 : (string -> unit) = v163.l0
            v295 v123
            US8_0(v162, v163, v164, v165, v166, v167)
    
    ()
and method43 () : uint8 =
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
and method46 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure13(v5, v9)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v27 : string = "power"
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure13(v5, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = " = "
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure13(v5, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v67 : string = $"{v0}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure13(v5, v67)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v85 : string = "; "
    let v86 : string = $"{v85}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v5, v86)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v104 : string = "acc"
    let v105 : string = $"{v104}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure13(v5, v105)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v122 : string = $"{v46}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure13(v5, v122)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v142 : string = $"{v1}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure13(v5, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v159 : string = $"{v85}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure13(v5, v159)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v177 : string = "roll"
    let v178 : string = $"{v177}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure13(v5, v178)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v195 : string = $"{v46}"
    let v203 : unit = ()
    let v204 : (unit -> unit) = closure13(v5, v195)
    let v205 : unit = (fun () -> v204 (); v203) ()
    let v215 : string = $"{v2}"
    let v223 : unit = ()
    let v224 : (unit -> unit) = closure13(v5, v215)
    let v225 : unit = (fun () -> v224 (); v223) ()
    let v232 : string = $"{v85}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure13(v5, v232)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v250 : string = "value"
    let v251 : string = $"{v250}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure13(v5, v251)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v268 : string = $"{v46}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure13(v5, v268)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v288 : string = $"{v3}"
    let v296 : unit = ()
    let v297 : (unit -> unit) = closure13(v5, v288)
    let v298 : unit = (fun () -> v297 (); v296) ()
    let v306 : string = " }"
    let v307 : string = $"{v306}"
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure13(v5, v307)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v323 : string = v5.l0
    v323
and method45 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 23y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure93 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method45(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method48 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 22y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure94 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method48(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method50 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 21y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure95 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method50(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method52 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 20y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure96 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method52(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method54 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 19y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure97 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method54(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method56 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 18y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure98 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method56(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method58 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 17y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure99 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method58(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method60 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 16y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure100 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method60(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method62 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 15y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure101 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method62(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method64 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 14y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure102 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method64(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method66 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 13y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method66(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method68 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 12y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method68(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method70 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 11y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method70(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method72 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 10y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method72(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method74 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 9y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method74(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method76 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 8y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method76(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method78 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 7y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method78(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method80 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 6y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method80(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method82 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 5y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method82(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method84 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 4y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method84(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method86 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 3y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method86(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method88 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 2y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method88(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method90 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 1y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method90(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method92 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 0y
    let v12 : string = method46(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "dice.accumulate_dice_rolls"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method21(v56)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure9()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US2 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v300 : US8 =
        if v66 then
            US8_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method12(v106, v107, v108, v109, v110, v111)
            let v125 : string = method16()
            let v126 : string = method92(v106, v107, v108, v109, v110, v111, v124, v125, v0, v1, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure14(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure15()
            (* run_target_args'
            let v191 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v192 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v126 v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v194 : string = v168.l0
            let v195 : bool = v194 = ""
            let v210 : string =
                if v195 then
                    v126
                else
                    let v196 : bool = v126 = ""
                    if v196 then
                        let v197 : string = v168.l0
                        v197
                    else
                        let v198 : string = v168.l0
                        let v201 : string = "\n"
                        let v202 : string = v198 + v201 
                        let v206 : string = v202 + v126 
                        v206
            (* run_target_args'
            let v215 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v216 
            let _run_target_args'_v215 = v217 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v218 
            let _run_target_args'_v215 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v220 
            let _run_target_args'_v215 = v221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v231 
            #endif
#else
            let v235 : Ref<Str> = v210 |> unbox<Ref<Str>>
            let _run_target_args'_v215 = v235 
            #endif
            let v238 : Ref<Str> = _run_target_args'_v215 
            let v247 : string = $"$0.chars()"
            let v248 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v238 v247 
            let v249 : string = "$0"
            let v250 : _ = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.collect::<Vec<_>>()"
            let v252 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v254 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "String::from_iter($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "true; $0 }).collect::<Vec<_>>()"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "_vec_map"
            let v264 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "$0.len()"
            let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v272 : int32 = v266 |> int32 
            let v282 : string = ""
            let v283 : bool = v126 <> v282 
            let v287 : bool =
                if v283 then
                    let v286 : bool = v272 <= 1
                    v286
                else
                    false
            if v287 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v282
                let v288 : string = "true; $0.into_iter().for_each(|x| { //"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v264 v288 
                let v290 : string = "x"
                let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr v291 v292 
                let v294 : string = $"true"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                let v296 : string = "true; }); //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v190 v126
            #endif
#if FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v190 v126
            #endif
#else
            v190 v126
            #endif
            // run_target_args' is_unit
            let v298 : (string -> unit) = v166.l0
            v298 v126
            US8_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method95 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "power"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure13(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "acc"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure13(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure13(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure13(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "result"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure13(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure13(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure13(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure13(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method94 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int8 = -1y
    let v11 : string = method95(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure117 (v0 : int64, v1 : int64) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method94(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method93 (v0 : UH1, v1 : int64) : US11 =
    let v2 : int64 = v1 + 1L
    let v314 : unit = ()
    let v315 : (unit -> unit) = closure117(v1, v2)
    let v316 : unit = (fun () -> v315 (); v314) ()
    US11_0(v2, v0)
and method97 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "power"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure13(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure13(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "acc"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure13(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure13(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure13(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure13(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "roll"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure13(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure13(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure13(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure13(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method96 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 0y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure118 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method96(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method91 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v319 : unit = ()
            let v320 : (unit -> unit) = closure116(v1, v3, v7)
            let v321 : unit = (fun () -> v320 (); v319) ()
            let v636 : int64 = v1 + v7
            method93(v4, v636)
        else
            let v949 : unit = ()
            let v950 : (unit -> unit) = closure118(v1, v3)
            let v951 : unit = (fun () -> v950 (); v949) ()
            method93(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method98 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 1y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure119 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method98(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method89 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure115(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method91(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure119(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method91(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method99 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 2y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure120 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method99(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method87 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure114(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method89(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure120(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method89(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method100 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 3y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure121 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method100(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method85 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure113(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method87(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure121(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method87(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 4y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure122 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method101(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method83 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure112(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method85(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure122(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method85(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 5y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure123 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method102(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method81 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure111(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method83(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure123(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method83(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 6y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure124 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method103(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method79 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure110(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method81(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure124(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method81(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 7y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure125 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method104(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method77 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure109(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method79(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure125(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method79(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 8y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure126 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method105(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method75 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure108(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method77(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure126(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method77(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 9y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure127 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method106(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method73 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure107(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method75(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure127(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method75(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 10y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method107(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method71 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure106(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method73(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure128(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method73(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 11y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method108(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method69 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure105(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method71(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure129(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method71(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 12y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method109(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method67 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure104(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method69(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure130(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method69(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 13y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method110(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method65 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure103(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method67(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure131(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method67(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 14y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method111(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method63 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure102(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method65(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure132(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method65(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 15y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method112(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method61 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure101(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method63(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure133(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method63(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 16y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method113(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method59 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure100(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method61(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure134(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method61(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method114 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 17y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method114(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method57 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure99(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method59(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure135(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method59(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method115 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 18y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method115(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method55 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure98(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method57(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure136(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method57(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method116 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 19y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method116(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method53 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure97(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method55(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure137(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method55(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method117 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 20y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method117(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method51 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure96(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method53(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure138(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method53(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method118 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 21y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method118(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method49 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure95(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method51(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure139(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method51(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method119 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 22y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method119(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method47 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure94(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method49(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure140(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method49(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method120 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 23y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v12
    let v35 : string = v26 + v31 
    let v39 : string = v35 + v15 
    let v44 : string = "dice.accumulate_dice_rolls"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method21(v55)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure9()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US2 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US8 =
        if v65 then
            US8_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method12(v105, v106, v107, v108, v109, v110)
            let v124 : string = method16()
            let v125 : string = method120(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut1, v165 : Mut3, v166 : Mut4, v167 : Mut5, v168 : Mut6, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure14(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure15()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US8_0(v164, v165, v166, v167, v168, v169)
    
    ()
and method44 (v0 : UH1, v1 : int64) : US11 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure93(v1, v3, v8)
            let v322 : unit = (fun () -> v321 (); v320) ()
            let v637 : int64 = v1 + v8
            method47(v4, v637)
        else
            let v950 : unit = ()
            let v951 : (unit -> unit) = closure141(v1, v3)
            let v952 : unit = (fun () -> v951 (); v950) ()
            method47(v4, v1)
    | UH1_0 -> (* Nil *)
        US11_1
and method42 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method43()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method42(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US11 = method44(v0, v7)
        match v8 with
        | US11_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method43()
                let v13 : uint8 = method43()
                let v14 : uint8 = method43()
                let v15 : uint8 = method43()
                let v16 : uint8 = method43()
                let v17 : uint8 = method43()
                let v18 : uint8 = method43()
                let v19 : uint8 = method43()
                let v20 : uint8 = method43()
                let v21 : uint8 = method43()
                let v22 : uint8 = method43()
                let v23 : uint8 = method43()
                let v24 : uint8 = method43()
                let v25 : uint8 = method43()
                let v26 : uint8 = method43()
                let v27 : uint8 = method43()
                let v28 : uint8 = method43()
                let v29 : uint8 = method43()
                let v30 : uint8 = method43()
                let v31 : uint8 = method43()
                let v32 : uint8 = method43()
                let v33 : uint8 = method43()
                let v34 : uint8 = method43()
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
                method42(v58, v59)
        | _ ->
            let v62 : uint8 = method43()
            let v63 : uint8 = method43()
            let v64 : uint8 = method43()
            let v65 : uint8 = method43()
            let v66 : uint8 = method43()
            let v67 : uint8 = method43()
            let v68 : uint8 = method43()
            let v69 : uint8 = method43()
            let v70 : uint8 = method43()
            let v71 : uint8 = method43()
            let v72 : uint8 = method43()
            let v73 : uint8 = method43()
            let v74 : uint8 = method43()
            let v75 : uint8 = method43()
            let v76 : uint8 = method43()
            let v77 : uint8 = method43()
            let v78 : uint8 = method43()
            let v79 : uint8 = method43()
            let v80 : uint8 = method43()
            let v81 : uint8 = method43()
            let v82 : uint8 = method43()
            let v83 : uint8 = method43()
            let v84 : uint8 = method43()
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
            method42(v108, v109)
and method122 (v0 : int64) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure13(v2, v6)
    let v16 : unit = (fun () -> v15 (); v14) ()
    let v24 : string = "result"
    let v25 : string = $"{v24}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v2, v25)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v43 : string = " = "
    let v44 : string = $"{v43}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure13(v2, v44)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v64 : string = $"{v0}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure13(v2, v64)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v82 : string = " }"
    let v83 : string = $"{v82}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure13(v2, v83)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v99 : string = v2.l0
    v99
and method121 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : string = method122(v8)
    let v10 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v18 : string = v14 + v7 
    let v23 : string = " #"
    let v24 : string = v18 + v23 
    let v28 : (int64 -> string) = _.ToString()
    let v29 : string = v28 v10
    let v33 : string = v24 + v29 
    let v37 : string = v33 + v13 
    let v42 : string = "dice.main"
    let v43 : string = v37 + v42 
    let v48 : string = " / "
    let v49 : string = v43 + v48 
    let v53 : string = v49 + v9 
    method21(v53)
and closure142 (v0 : int64) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure9()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut1, v41 : Mut3, v42 : Mut4, v43 : Mut5, v44 : Mut6, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US2 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v298 : US8 =
        if v64 then
            US8_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut1, v105 : Mut3, v106 : Mut4, v107 : Mut5, v108 : Mut6, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method12(v104, v105, v106, v107, v108, v109)
            let v123 : string = method16()
            let v124 : string = method121(v104, v105, v106, v107, v108, v109, v122, v123, v0)
            let v139 : unit = ()
            let v140 : unit = (fun () -> v16 (); v139) ()
            let struct (v163 : Mut1, v164 : Mut3, v165 : Mut4, v166 : Mut5, v167 : Mut6, v168 : int64 option) = TraceState.trace_state.Value
            let v183 : unit = ()
            let v184 : (unit -> unit) = closure14(v163)
            let v185 : unit = (fun () -> v184 (); v183) ()
            let v188 : (string -> unit) = closure15()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v124 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v124 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v166.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v124
                else
                    let v194 : bool = v124 = ""
                    if v194 then
                        let v195 : string = v166.l0
                        v195
                    else
                        let v196 : string = v166.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v124 
                        v204
            (* run_target_args'
            let v213 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v214 : string = "&*$0"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v214 
            let _run_target_args'_v213 = v215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v216 
            let _run_target_args'_v213 = v217 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v218 
            let _run_target_args'_v213 = v219 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v221 
            #endif
#if FABLE_COMPILER_PYTHON
            let v225 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v225 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v229 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v229 
            #endif
#else
            let v233 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v233 
            #endif
            let v236 : Ref<Str> = _run_target_args'_v213 
            let v245 : string = $"$0.chars()"
            let v246 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v236 v245 
            let v247 : string = "$0"
            let v248 : _ = Fable.Core.RustInterop.emitRustExpr v246 v247 
            let v249 : string = "$0.collect::<Vec<_>>()"
            let v250 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v252 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v254 : bool = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "x"
            let v256 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v255 
            let v257 : string = "String::from_iter($0)"
            let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "true; $0 }).collect::<Vec<_>>()"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "_vec_map"
            let v262 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "$0.len()"
            let v264 : unativeint = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v270 : int32 = v264 |> int32 
            let v280 : string = ""
            let v281 : bool = v124 <> v280 
            let v285 : bool =
                if v281 then
                    let v284 : bool = v270 <= 1
                    v284
                else
                    false
            if v285 then
                v166.l0 <- v208
                ()
            else
                v166.l0 <- v280
                let v286 : string = "true; $0.into_iter().for_each(|x| { //"
                let v287 : bool = Fable.Core.RustInterop.emitRustExpr v262 v286 
                let v288 : string = "x"
                let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v288 
                let v290 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr v289 v290 
                let v292 : string = $"true"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
                let v294 : string = "true; }); //"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v124
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v124
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v124
            #endif
#else
            v188 v124
            #endif
            // run_target_args' is_unit
            let v296 : (string -> unit) = v164.l0
            v296 v124
            US8_0(v163, v164, v165, v166, v167, v168)
    
    ()
and closure91 () (v0 : (string [])) : int32 =
    let v312 : unit = ()
    let v313 : (unit -> unit) = closure92()
    let v314 : unit = (fun () -> v313 (); v312) ()
    let v629 : UH1 = UH1_0
    let v630 : int8 = 0y
    let v631 : int64 = method42(v629, v630)
    let v943 : unit = ()
    let v944 : (unit -> unit) = closure142(v631)
    let v945 : unit = (fun () -> v944 (); v943) ()
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
