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
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method10(v0)
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
    let v16 : string = method11()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US5 = US5_1
    let v20 : US6 = US6_3(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US5 = US5_2
    let v24 : US6 = US6_3(v23)
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
    let v49 : (string -> US7) = method12()
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
    let v93 : (string -> US7) = method12()
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
    let v209 : US4 =
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
            let v203 : int64 = v182 |> int64 
            US4_0(v203)
    struct (v127, v209)
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
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure9()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = TraceState.trace_state.Value
    let v56 : US2 = v42.l0
    let v57 : bool = v40.l0
    let v58 : bool = v57 = false
    if v58 then
        false
    else
        let v59 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v0
        let v60 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v56
        let v61 : bool = v59 >= v60
        v61
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
    let v187 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : (int64 -> US4) = method14()
    let v191 : US4 option = v5 |> Option.map v190 
    let v211 : US4 = US4_1
    let v212 : US4 = v191 |> Option.defaultValue v211 
    let v344 : System.DateTime =
        match v212 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v327 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v328 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v328 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v329 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v329 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v331 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v327 = v331 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v334 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v334 
            #endif
#if FABLE_COMPILER_PYTHON
            let v335 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v335 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v336 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v336 
            #endif
#else
            let v337 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v337 
            #endif
            let v338 : System.DateTime = _run_target_args'_v327 
            v338
        | US4_0(v216) -> (* Some *)
            (* run_target_args'
            let v223 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v224 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v224 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v225 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v225 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v227 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v223 = v227 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v230 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v230 
            #endif
#if FABLE_COMPILER_PYTHON
            let v231 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v231 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v232 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v232 
            #endif
#else
            let v233 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v233 
            #endif
            let v234 : System.DateTime = _run_target_args'_v223 
            (* run_target_args'
            let v245 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v234
            let _run_target_args'_v245 = v247 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v248 : (System.DateTime -> int64) = _.Ticks
            let v249 : int64 = v248 v234
            let _run_target_args'_v245 = v249 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v251 : int64 = null |> unbox<int64>
            let _run_target_args'_v245 = v251 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v254 : (System.DateTime -> int64) = _.Ticks
            let v255 : int64 = v254 v234
            let _run_target_args'_v245 = v255 
            #endif
#if FABLE_COMPILER_PYTHON
            let v256 : (System.DateTime -> int64) = _.Ticks
            let v257 : int64 = v256 v234
            let _run_target_args'_v245 = v257 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v258 : (System.DateTime -> int64) = _.Ticks
            let v259 : int64 = v258 v234
            let _run_target_args'_v245 = v259 
            #endif
#else
            let v260 : (System.DateTime -> int64) = _.Ticks
            let v261 : int64 = v260 v234
            let _run_target_args'_v245 = v261 
            #endif
            let v262 : int64 = _run_target_args'_v245 
            let v283 : int64 = v262 |> int64 
            let v286 : int64 = v283 - v216
            let v292 : System.TimeSpan = v286 |> System.TimeSpan 
            let v298 : (System.TimeSpan -> int32) = _.Hours
            let v299 : int32 = v298 v292
            let v303 : (System.TimeSpan -> int32) = _.Minutes
            let v304 : int32 = v303 v292
            let v308 : (System.TimeSpan -> int32) = _.Seconds
            let v309 : int32 = v308 v292
            let v313 : (System.TimeSpan -> int32) = _.Milliseconds
            let v314 : int32 = v313 v292
            let v318 : System.DateTime = System.DateTime (1, 1, 1, v299, v304, v309, v314)
            v318
    let v346 : string = method15()
    let v350 : bool = v346 = ""
    let v352 : string =
        if v350 then
            let v351 : string = "M-d-y hh:mm:ss tt"
            v351
        else
            v346
    let v353 : (string -> string) = v344.ToString
    let v354 : string = v353 v352
    let _run_target_args'_v187 = v354 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v371 : (int64 -> US4) = method14()
    let v372 : US4 option = v5 |> Option.map v371 
    let v392 : US4 = US4_1
    let v393 : US4 = v372 |> Option.defaultValue v392 
    let v525 : System.DateTime =
        match v393 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v508 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v509 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v509 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v510 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v510 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v512 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v508 = v512 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v515 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v515 
            #endif
#if FABLE_COMPILER_PYTHON
            let v516 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v516 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v517 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v517 
            #endif
#else
            let v518 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v518 
            #endif
            let v519 : System.DateTime = _run_target_args'_v508 
            v519
        | US4_0(v397) -> (* Some *)
            (* run_target_args'
            let v404 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v406 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v406 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v408 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v404 = v408 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v411 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v411 
            #endif
#if FABLE_COMPILER_PYTHON
            let v412 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v412 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v413 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v413 
            #endif
#else
            let v414 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v414 
            #endif
            let v415 : System.DateTime = _run_target_args'_v404 
            (* run_target_args'
            let v426 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v427 : (System.DateTime -> int64) = _.Ticks
            let v428 : int64 = v427 v415
            let _run_target_args'_v426 = v428 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v429 : (System.DateTime -> int64) = _.Ticks
            let v430 : int64 = v429 v415
            let _run_target_args'_v426 = v430 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v432 : int64 = null |> unbox<int64>
            let _run_target_args'_v426 = v432 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v435 : (System.DateTime -> int64) = _.Ticks
            let v436 : int64 = v435 v415
            let _run_target_args'_v426 = v436 
            #endif
#if FABLE_COMPILER_PYTHON
            let v437 : (System.DateTime -> int64) = _.Ticks
            let v438 : int64 = v437 v415
            let _run_target_args'_v426 = v438 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v439 : (System.DateTime -> int64) = _.Ticks
            let v440 : int64 = v439 v415
            let _run_target_args'_v426 = v440 
            #endif
#else
            let v441 : (System.DateTime -> int64) = _.Ticks
            let v442 : int64 = v441 v415
            let _run_target_args'_v426 = v442 
            #endif
            let v443 : int64 = _run_target_args'_v426 
            let v464 : int64 = v443 |> int64 
            let v467 : int64 = v464 - v397
            let v473 : System.TimeSpan = v467 |> System.TimeSpan 
            let v479 : (System.TimeSpan -> int32) = _.Hours
            let v480 : int32 = v479 v473
            let v484 : (System.TimeSpan -> int32) = _.Minutes
            let v485 : int32 = v484 v473
            let v489 : (System.TimeSpan -> int32) = _.Seconds
            let v490 : int32 = v489 v473
            let v494 : (System.TimeSpan -> int32) = _.Milliseconds
            let v495 : int32 = v494 v473
            let v499 : System.DateTime = System.DateTime (1, 1, 1, v480, v485, v490, v495)
            v499
    let v527 : string = method15()
    let v531 : bool = v527 = ""
    let v533 : string =
        if v531 then
            let v532 : string = "M-d-y hh:mm:ss tt"
            v532
        else
            v527
    let v534 : (string -> string) = v525.ToString
    let v535 : string = v534 v533
    let _run_target_args'_v187 = v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v550 : string = $"near_sdk::env::block_timestamp()"
    let v551 : uint64 = Fable.Core.RustInterop.emitRustExpr () v550 
    let v554 : (int64 -> US4) = method14()
    let v555 : US4 option = v5 |> Option.map v554 
    let v575 : US4 = US4_1
    let v576 : US4 = v555 |> Option.defaultValue v575 
    let v588 : uint64 =
        match v576 with
        | US4_1 -> (* None *)
            v551
        | US4_0(v580) -> (* Some *)
            let v582 : (int64 -> uint64) = uint64
            let v583 : uint64 = v582 v580
            let v586 : uint64 = v551 - v583
            v586
    let v589 : uint64 = v588 / 1000000000UL
    let v590 : uint64 = v589 % 60UL
    let v591 : uint64 = v589 / 60UL
    let v592 : uint64 = v591 % 60UL
    let v593 : uint64 = v589 / 3600UL
    let v594 : uint64 = v593 % 24UL
    let v595 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v596 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v594, v592, v590) v595 
    let v597 : string = "fable_library_rust::String_::fromString($0)"
    let v598 : string = Fable.Core.RustInterop.emitRustExpr v596 v597 
    let _run_target_args'_v187 = v598 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v601 : (int64 -> US4) = method14()
    let v602 : US4 option = v5 |> Option.map v601 
    let v622 : US4 = US4_1
    let v623 : US4 = v602 |> Option.defaultValue v622 
    let v755 : System.DateTime =
        match v623 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v738 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v739 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v740 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v738 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v745 
            #endif
#if FABLE_COMPILER_PYTHON
            let v746 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v746 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v747 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v747 
            #endif
#else
            let v748 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v748 
            #endif
            let v749 : System.DateTime = _run_target_args'_v738 
            v749
        | US4_0(v627) -> (* Some *)
            (* run_target_args'
            let v634 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v635 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v635 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v636 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v638 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v634 = v638 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v641 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v641 
            #endif
#if FABLE_COMPILER_PYTHON
            let v642 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v642 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v643 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v643 
            #endif
#else
            let v644 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v644 
            #endif
            let v645 : System.DateTime = _run_target_args'_v634 
            (* run_target_args'
            let v656 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v657 : (System.DateTime -> int64) = _.Ticks
            let v658 : int64 = v657 v645
            let _run_target_args'_v656 = v658 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v659 : (System.DateTime -> int64) = _.Ticks
            let v660 : int64 = v659 v645
            let _run_target_args'_v656 = v660 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v662 : int64 = null |> unbox<int64>
            let _run_target_args'_v656 = v662 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v665 : (System.DateTime -> int64) = _.Ticks
            let v666 : int64 = v665 v645
            let _run_target_args'_v656 = v666 
            #endif
#if FABLE_COMPILER_PYTHON
            let v667 : (System.DateTime -> int64) = _.Ticks
            let v668 : int64 = v667 v645
            let _run_target_args'_v656 = v668 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v669 : (System.DateTime -> int64) = _.Ticks
            let v670 : int64 = v669 v645
            let _run_target_args'_v656 = v670 
            #endif
#else
            let v671 : (System.DateTime -> int64) = _.Ticks
            let v672 : int64 = v671 v645
            let _run_target_args'_v656 = v672 
            #endif
            let v673 : int64 = _run_target_args'_v656 
            let v694 : int64 = v673 |> int64 
            let v697 : int64 = v694 - v627
            let v703 : System.TimeSpan = v697 |> System.TimeSpan 
            let v709 : (System.TimeSpan -> int32) = _.Hours
            let v710 : int32 = v709 v703
            let v714 : (System.TimeSpan -> int32) = _.Minutes
            let v715 : int32 = v714 v703
            let v719 : (System.TimeSpan -> int32) = _.Seconds
            let v720 : int32 = v719 v703
            let v724 : (System.TimeSpan -> int32) = _.Milliseconds
            let v725 : int32 = v724 v703
            let v729 : System.DateTime = System.DateTime (1, 1, 1, v710, v715, v720, v725)
            v729
    let v757 : string = method16()
    let v761 : bool = v757 = ""
    let v763 : string =
        if v761 then
            let v762 : string = "M-d-y hh:mm:ss tt"
            v762
        else
            v757
    let v764 : (string -> string) = v755.ToString
    let v765 : string = v764 v763
    let _run_target_args'_v187 = v765 
    #endif
#if FABLE_COMPILER_PYTHON
    let v782 : (int64 -> US4) = method14()
    let v783 : US4 option = v5 |> Option.map v782 
    let v803 : US4 = US4_1
    let v804 : US4 = v783 |> Option.defaultValue v803 
    let v936 : System.DateTime =
        match v804 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v919 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v920 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v920 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v921 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v921 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v923 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v919 = v923 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v926 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v926 
            #endif
#if FABLE_COMPILER_PYTHON
            let v927 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v927 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v928 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v928 
            #endif
#else
            let v929 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v929 
            #endif
            let v930 : System.DateTime = _run_target_args'_v919 
            v930
        | US4_0(v808) -> (* Some *)
            (* run_target_args'
            let v815 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v816 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v816 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v817 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v817 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v819 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v815 = v819 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v822 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v822 
            #endif
#if FABLE_COMPILER_PYTHON
            let v823 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v823 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v824 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v824 
            #endif
#else
            let v825 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v825 
            #endif
            let v826 : System.DateTime = _run_target_args'_v815 
            (* run_target_args'
            let v837 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v838 : (System.DateTime -> int64) = _.Ticks
            let v839 : int64 = v838 v826
            let _run_target_args'_v837 = v839 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v840 : (System.DateTime -> int64) = _.Ticks
            let v841 : int64 = v840 v826
            let _run_target_args'_v837 = v841 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v843 : int64 = null |> unbox<int64>
            let _run_target_args'_v837 = v843 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v846 : (System.DateTime -> int64) = _.Ticks
            let v847 : int64 = v846 v826
            let _run_target_args'_v837 = v847 
            #endif
#if FABLE_COMPILER_PYTHON
            let v848 : (System.DateTime -> int64) = _.Ticks
            let v849 : int64 = v848 v826
            let _run_target_args'_v837 = v849 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v850 : (System.DateTime -> int64) = _.Ticks
            let v851 : int64 = v850 v826
            let _run_target_args'_v837 = v851 
            #endif
#else
            let v852 : (System.DateTime -> int64) = _.Ticks
            let v853 : int64 = v852 v826
            let _run_target_args'_v837 = v853 
            #endif
            let v854 : int64 = _run_target_args'_v837 
            let v875 : int64 = v854 |> int64 
            let v878 : int64 = v875 - v808
            let v884 : System.TimeSpan = v878 |> System.TimeSpan 
            let v890 : (System.TimeSpan -> int32) = _.Hours
            let v891 : int32 = v890 v884
            let v895 : (System.TimeSpan -> int32) = _.Minutes
            let v896 : int32 = v895 v884
            let v900 : (System.TimeSpan -> int32) = _.Seconds
            let v901 : int32 = v900 v884
            let v905 : (System.TimeSpan -> int32) = _.Milliseconds
            let v906 : int32 = v905 v884
            let v910 : System.DateTime = System.DateTime (1, 1, 1, v891, v896, v901, v906)
            v910
    let v938 : string = method16()
    let v942 : bool = v938 = ""
    let v944 : string =
        if v942 then
            let v943 : string = "M-d-y hh:mm:ss tt"
            v943
        else
            v938
    let v945 : (string -> string) = v936.ToString
    let v946 : string = v945 v944
    let _run_target_args'_v187 = v946 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v963 : (int64 -> US4) = method14()
    let v964 : US4 option = v5 |> Option.map v963 
    let v984 : US4 = US4_1
    let v985 : US4 = v964 |> Option.defaultValue v984 
    let v1117 : System.DateTime =
        match v985 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1100 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1101 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1102 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1104 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1100 = v1104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1107 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1108 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1109 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1109 
            #endif
#else
            let v1110 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1110 
            #endif
            let v1111 : System.DateTime = _run_target_args'_v1100 
            v1111
        | US4_0(v989) -> (* Some *)
            (* run_target_args'
            let v996 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v997 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v997 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v998 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v998 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1000 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v996 = v1000 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1003 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1003 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1004 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1004 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1005 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1005 
            #endif
#else
            let v1006 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1006 
            #endif
            let v1007 : System.DateTime = _run_target_args'_v996 
            (* run_target_args'
            let v1018 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1019 : (System.DateTime -> int64) = _.Ticks
            let v1020 : int64 = v1019 v1007
            let _run_target_args'_v1018 = v1020 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1021 : (System.DateTime -> int64) = _.Ticks
            let v1022 : int64 = v1021 v1007
            let _run_target_args'_v1018 = v1022 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1024 : int64 = null |> unbox<int64>
            let _run_target_args'_v1018 = v1024 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1027 : (System.DateTime -> int64) = _.Ticks
            let v1028 : int64 = v1027 v1007
            let _run_target_args'_v1018 = v1028 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1029 : (System.DateTime -> int64) = _.Ticks
            let v1030 : int64 = v1029 v1007
            let _run_target_args'_v1018 = v1030 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1031 : (System.DateTime -> int64) = _.Ticks
            let v1032 : int64 = v1031 v1007
            let _run_target_args'_v1018 = v1032 
            #endif
#else
            let v1033 : (System.DateTime -> int64) = _.Ticks
            let v1034 : int64 = v1033 v1007
            let _run_target_args'_v1018 = v1034 
            #endif
            let v1035 : int64 = _run_target_args'_v1018 
            let v1056 : int64 = v1035 |> int64 
            let v1059 : int64 = v1056 - v989
            let v1065 : System.TimeSpan = v1059 |> System.TimeSpan 
            let v1071 : (System.TimeSpan -> int32) = _.Hours
            let v1072 : int32 = v1071 v1065
            let v1076 : (System.TimeSpan -> int32) = _.Minutes
            let v1077 : int32 = v1076 v1065
            let v1081 : (System.TimeSpan -> int32) = _.Seconds
            let v1082 : int32 = v1081 v1065
            let v1086 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1087 : int32 = v1086 v1065
            let v1091 : System.DateTime = System.DateTime (1, 1, 1, v1072, v1077, v1082, v1087)
            v1091
    let v1119 : string = method16()
    let v1123 : bool = v1119 = ""
    let v1125 : string =
        if v1123 then
            let v1124 : string = "M-d-y hh:mm:ss tt"
            v1124
        else
            v1119
    let v1126 : (string -> string) = v1117.ToString
    let v1127 : string = v1126 v1125
    let _run_target_args'_v187 = v1127 
    #endif
#else
    let v1144 : (int64 -> US4) = method14()
    let v1145 : US4 option = v5 |> Option.map v1144 
    let v1165 : US4 = US4_1
    let v1166 : US4 = v1145 |> Option.defaultValue v1165 
    let v1298 : System.DateTime =
        match v1166 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v1281 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1282 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1283 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1283 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1285 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1281 = v1285 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1288 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1288 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1289 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1289 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1290 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1290 
            #endif
#else
            let v1291 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1291 
            #endif
            let v1292 : System.DateTime = _run_target_args'_v1281 
            v1292
        | US4_0(v1170) -> (* Some *)
            (* run_target_args'
            let v1177 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1178 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1178 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1179 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1179 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1181 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1177 = v1181 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1184 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1185 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1185 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1186 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1186 
            #endif
#else
            let v1187 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1187 
            #endif
            let v1188 : System.DateTime = _run_target_args'_v1177 
            (* run_target_args'
            let v1199 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1200 : (System.DateTime -> int64) = _.Ticks
            let v1201 : int64 = v1200 v1188
            let _run_target_args'_v1199 = v1201 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1202 : (System.DateTime -> int64) = _.Ticks
            let v1203 : int64 = v1202 v1188
            let _run_target_args'_v1199 = v1203 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1205 : int64 = null |> unbox<int64>
            let _run_target_args'_v1199 = v1205 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1208 : (System.DateTime -> int64) = _.Ticks
            let v1209 : int64 = v1208 v1188
            let _run_target_args'_v1199 = v1209 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1210 : (System.DateTime -> int64) = _.Ticks
            let v1211 : int64 = v1210 v1188
            let _run_target_args'_v1199 = v1211 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1212 : (System.DateTime -> int64) = _.Ticks
            let v1213 : int64 = v1212 v1188
            let _run_target_args'_v1199 = v1213 
            #endif
#else
            let v1214 : (System.DateTime -> int64) = _.Ticks
            let v1215 : int64 = v1214 v1188
            let _run_target_args'_v1199 = v1215 
            #endif
            let v1216 : int64 = _run_target_args'_v1199 
            let v1237 : int64 = v1216 |> int64 
            let v1240 : int64 = v1237 - v1170
            let v1246 : System.TimeSpan = v1240 |> System.TimeSpan 
            let v1252 : (System.TimeSpan -> int32) = _.Hours
            let v1253 : int32 = v1252 v1246
            let v1257 : (System.TimeSpan -> int32) = _.Minutes
            let v1258 : int32 = v1257 v1246
            let v1262 : (System.TimeSpan -> int32) = _.Seconds
            let v1263 : int32 = v1262 v1246
            let v1267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1268 : int32 = v1267 v1246
            let v1272 : System.DateTime = System.DateTime (1, 1, 1, v1253, v1258, v1263, v1268)
            v1272
    let v1300 : string = method16()
    let v1304 : bool = v1300 = ""
    let v1306 : string =
        if v1304 then
            let v1305 : string = "M-d-y hh:mm:ss tt"
            v1305
        else
            v1300
    let v1307 : (string -> string) = v1298.ToString
    let v1308 : string = v1307 v1306
    let _run_target_args'_v187 = v1308 
    #endif
    let v1323 : string = _run_target_args'_v187 
    v1323
and method18 () : string =
    let v0 : string = ""
    v0
and closure13 (v0 : Mut5, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method19 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method17 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method18()
    let v9 : Mut5 = {l0 = v8} : Mut5
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_bright_blue"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_bright_blue"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_bright_blue"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[94m"
    let v176 : string = method19()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[94m"
    let v192 : string = method19()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[94m"
    let v208 : string = method19()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[94m"
    let v224 : string = method19()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
and method21 (v0 : string) : string =
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
and method20 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method18()
    let v13 : Mut5 = {l0 = v12} : Mut5
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure13(v13, v17)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v35 : string = "current_index"
    let v36 : string = $"{v35}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v13, v36)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v54 : string = " = "
    let v55 : string = $"{v54}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure13(v13, v55)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v75 : string = $"{v8}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure13(v13, v75)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v93 : string = "; "
    let v94 : string = $"{v93}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v13, v94)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v112 : string = "acc"
    let v113 : string = $"{v112}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure13(v13, v113)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v130 : string = $"{v54}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure13(v13, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v150 : string = $"{v9}"
    let v158 : unit = ()
    let v159 : (unit -> unit) = closure13(v13, v150)
    let v160 : unit = (fun () -> v159 (); v158) ()
    let v167 : string = $"{v93}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure13(v13, v167)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v185 : string = "len"
    let v186 : string = $"{v185}"
    let v194 : unit = ()
    let v195 : (unit -> unit) = closure13(v13, v186)
    let v196 : unit = (fun () -> v195 (); v194) ()
    let v203 : string = $"{v54}"
    let v211 : unit = ()
    let v212 : (unit -> unit) = closure13(v13, v203)
    let v213 : unit = (fun () -> v212 (); v211) ()
    let v223 : string = $"{v10}"
    let v231 : unit = ()
    let v232 : (unit -> unit) = closure13(v13, v223)
    let v233 : unit = (fun () -> v232 (); v231) ()
    let v240 : string = $"{v93}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v13, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v258 : string = "last_item"
    let v259 : string = $"{v258}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure13(v13, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v54}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure13(v13, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v293 : string = $"{v11}"
    let v301 : unit = ()
    let v302 : (unit -> unit) = closure13(v13, v293)
    let v303 : unit = (fun () -> v302 (); v301) ()
    let v311 : string = " }"
    let v312 : string = $"{v311}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure13(v13, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v328 : string = v13.l0
    let v329 : int64 = v0.l0
    let v332 : string = " "
    let v333 : string = v6 + v332 
    let v337 : string = v333 + v7 
    let v342 : string = " #"
    let v343 : string = v337 + v342 
    let v347 : (int64 -> string) = _.ToString()
    let v348 : string = v347 v329
    let v352 : string = v343 + v348 
    let v356 : string = v352 + v332 
    let v361 : string = "dice.create_sequential_roller / roll"
    let v362 : string = v356 + v361 
    let v367 : string = " / "
    let v368 : string = v362 + v367 
    let v372 : string = v368 + v328 
    method21(v372)
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
and method22 (v0 : string) : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure9()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = TraceState.trace_state.Value
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure14(v38)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v63 : (string -> unit) = closure15()
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = v41.l0
    let v68 : bool = v67 = ""
    let v83 : string =
        if v68 then
            v0
        else
            let v69 : bool = v0 = ""
            if v69 then
                let v70 : string = v41.l0
                v70
            else
                let v71 : string = v41.l0
                let v74 : string = "\n"
                let v75 : string = v71 + v74 
                let v79 : string = v75 + v0 
                v79
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "&*$0"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "&*$0"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "&*$0"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : Ref<Str> = _run_target_args'_v88 
    let v117 : string = $"$0.chars()"
    let v118 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v117 
    let v119 : string = "$0"
    let v120 : _ = Fable.Core.RustInterop.emitRustExpr v118 v119 
    let v121 : string = "$0.collect::<Vec<_>>()"
    let v122 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let v123 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v124 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let v125 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr v124 v125 
    let v127 : string = "x"
    let v128 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "String::from_iter($0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let v131 : string = "true; $0 }).collect::<Vec<_>>()"
    let v132 : bool = Fable.Core.RustInterop.emitRustExpr v130 v131 
    let v133 : string = "_vec_map"
    let v134 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v133 
    let v135 : string = "$0.len()"
    let v136 : unativeint = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let v142 : int32 = v136 |> int32 
    let v152 : string = ""
    let v153 : bool = v0 <> v152 
    let v157 : bool =
        if v153 then
            let v156 : bool = v142 <= 1
            v156
        else
            false
    if v157 then
        v41.l0 <- v83
        ()
    else
        v41.l0 <- v152
        let v158 : string = "true; $0.into_iter().for_each(|x| { //"
        let v159 : bool = Fable.Core.RustInterop.emitRustExpr v134 v158 
        let v160 : string = "x"
        let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v160 
        let v162 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v163 : bool = Fable.Core.RustInterop.emitRustExpr v161 v162 
        let v164 : string = $"true"
        let v165 : bool = Fable.Core.RustInterop.emitRustExpr () v164 
        let v166 : string = "true; }); //"
        let v167 : bool = Fable.Core.RustInterop.emitRustExpr () v166 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v63 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v63 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v63 v0
    #endif
#else
    v63 v0
    #endif
    // run_target_args' is_unit
    let v168 : (string -> unit) = v39.l0
    v168 v0
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US2 = US2_1
    let v5 : bool = method6(v4)
    if v5 then
        let v20 : unit = ()
        let v21 : (unit -> unit) = closure9()
        let v22 : unit = (fun () -> v21 (); v20) ()
        let struct (v43 : Mut1, v44 : Mut3, v45 : Mut4, v46 : Mut5, v47 : Mut6, v48 : int64 option) = TraceState.trace_state.Value
        let v61 : string = method13(v43, v44, v45, v46, v47, v48)
        let v62 : string = method17()
        let v64 : string = $"%A{v3}"
        let v67 : string = method20(v43, v44, v45, v46, v47, v48, v61, v62, v0, v1, v2, v64)
        method22(v67)
and method23 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method23(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method24 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method18()
    let v9 : Mut5 = {l0 = v8} : Mut5
    let v10 : string = v9.l0
    let v11 : int64 = v0.l0
    let v14 : string = " "
    let v15 : string = v6 + v14 
    let v19 : string = v15 + v7 
    let v24 : string = " #"
    let v25 : string = v19 + v24 
    let v29 : (int64 -> string) = _.ToString()
    let v30 : string = v29 v11
    let v34 : string = v25 + v30 
    let v38 : string = v34 + v14 
    let v43 : string = "dice.create_sequential_roller / roll / None"
    let v44 : string = v38 + v43 
    let v49 : string = " / "
    let v50 : string = v44 + v49 
    let v54 : string = v50 + v10 
    method21(v54)
and closure17 () () : unit =
    let v0 : US2 = US2_1
    let v1 : bool = method6(v0)
    if v1 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure9()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
        let v57 : string = method13(v39, v40, v41, v42, v43, v44)
        let v58 : string = method17()
        let v59 : string = method24(v39, v40, v41, v42, v43, v44, v57, v58)
        method22(v59)
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
    let v84 : unit = ()
    let v85 : (unit -> unit) = closure8(v5, v6, v7, v19)
    let v86 : unit = (fun () -> v85 (); v84) ()
    let v151 : UH0 = v0 ()
    let v152 : int64 = v1.l0
    let v153 : US1 = method23(v152, v151)
    match v153 with
    | US1_1 -> (* None *)
        let v218 : unit = ()
        let v219 : (unit -> unit) = closure17()
        let v220 : unit = (fun () -> v219 (); v218) ()
        let v281 : int64 = v3.l0
        let v282 : bool = v281 = -1L
        if v282 then
            let v283 : int64 = v1.l0
            v3.l0 <- v283
            ()
        let v284 : int64 = v2.l0
        let v285 : int64 = v3.l0
        let v286 : bool = v284 >= v285
        let v289 : int64 =
            if v286 then
                1L
            else
                let v287 : int64 = v2.l0
                let v288 : int64 = v287 + 1L
                v288
        v2.l0 <- v289
        let v290 : int64 = v2.l0
        let v291 : int64 = v290 - 1L
        v1.l0 <- v291
        let v292 : US1 = US1_1
        v4.l0 <- v292
        method5(v0, v1, v2, v3, v4)
    | US1_0(v154) -> (* Some *)
        let v155 : int64 = v1.l0
        let v156 : int64 = v155 + 1L
        v1.l0 <- v156
        let v157 : US1 = US1_0(v154)
        v4.l0 <- v157
        v154
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
and method26 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "max"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "p"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "n"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v10}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = " }"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure13(v12, v241)
    let v251 : unit = (fun () -> v250 (); v249) ()
    let v257 : string = v12.l0
    let v258 : int64 = v0.l0
    let v261 : string = " "
    let v262 : string = v6 + v261 
    let v266 : string = v262 + v7 
    let v271 : string = " #"
    let v272 : string = v266 + v271 
    let v276 : (int64 -> string) = _.ToString()
    let v277 : string = v276 v258
    let v281 : string = v272 + v277 
    let v285 : string = v281 + v261 
    let v290 : string = "dice.calculate_dice_count"
    let v291 : string = v285 + v290 
    let v296 : string = " / "
    let v297 : string = v291 + v296 
    let v301 : string = v297 + v257 
    method21(v301)
and closure21 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method26(v42, v43, v44, v45, v46, v47, v60, v61, v0, v2, v1)
        method22(v62)
and method25 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method25(v0, v6, v4)
        else
            let v68 : unit = ()
            let v69 : (unit -> unit) = closure21(v0, v1, v2)
            let v70 : unit = (fun () -> v69 (); v68) ()
            v1
    else
        let v192 : unit = ()
        let v193 : (unit -> unit) = closure21(v0, v1, v2)
        let v194 : unit = (fun () -> v193 (); v192) ()
        v1
and method29 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "result"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v10}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = " }"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure13(v12, v241)
    let v251 : unit = (fun () -> v250 (); v249) ()
    let v257 : string = v12.l0
    let v258 : int64 = v0.l0
    let v261 : string = " "
    let v262 : string = v6 + v261 
    let v266 : string = v262 + v7 
    let v271 : string = " #"
    let v272 : string = v266 + v271 
    let v276 : (int64 -> string) = _.ToString()
    let v277 : string = v276 v258
    let v281 : string = v272 + v277 
    let v285 : string = v281 + v261 
    let v290 : string = "dice.accumulate_dice_rolls"
    let v291 : string = v285 + v290 
    let v296 : string = " / "
    let v297 : string = v291 + v296 
    let v301 : string = v297 + v257 
    method21(v301)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method29(v42, v43, v44, v45, v46, v47, v60, v61, v1, v0, v2)
        method22(v62)
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
and method30 (v0 : int8, v1 : UH2) : US9 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US9_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method30(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US9_1
and method31 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method18()
    let v13 : Mut5 = {l0 = v12} : Mut5
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure13(v13, v17)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v35 : string = "power"
    let v36 : string = $"{v35}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v13, v36)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v54 : string = " = "
    let v55 : string = $"{v54}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure13(v13, v55)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v75 : string = $"{v8}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure13(v13, v75)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v93 : string = "; "
    let v94 : string = $"{v93}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v13, v94)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v112 : string = "acc"
    let v113 : string = $"{v112}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure13(v13, v113)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v130 : string = $"{v54}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure13(v13, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v150 : string = $"{v9}"
    let v158 : unit = ()
    let v159 : (unit -> unit) = closure13(v13, v150)
    let v160 : unit = (fun () -> v159 (); v158) ()
    let v167 : string = $"{v93}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure13(v13, v167)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v185 : string = "roll"
    let v186 : string = $"{v185}"
    let v194 : unit = ()
    let v195 : (unit -> unit) = closure13(v13, v186)
    let v196 : unit = (fun () -> v195 (); v194) ()
    let v203 : string = $"{v54}"
    let v211 : unit = ()
    let v212 : (unit -> unit) = closure13(v13, v203)
    let v213 : unit = (fun () -> v212 (); v211) ()
    let v223 : string = $"{v10}"
    let v231 : unit = ()
    let v232 : (unit -> unit) = closure13(v13, v223)
    let v233 : unit = (fun () -> v232 (); v231) ()
    let v240 : string = $"{v93}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v13, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v258 : string = "value"
    let v259 : string = $"{v258}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure13(v13, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v54}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure13(v13, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v296 : string = $"{v11}"
    let v304 : unit = ()
    let v305 : (unit -> unit) = closure13(v13, v296)
    let v306 : unit = (fun () -> v305 (); v304) ()
    let v314 : string = " }"
    let v315 : string = $"{v314}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure13(v13, v315)
    let v325 : unit = (fun () -> v324 (); v323) ()
    let v331 : string = v13.l0
    let v332 : int64 = v0.l0
    let v335 : string = " "
    let v336 : string = v6 + v335 
    let v340 : string = v336 + v7 
    let v345 : string = " #"
    let v346 : string = v340 + v345 
    let v350 : (int64 -> string) = _.ToString()
    let v351 : string = v350 v332
    let v355 : string = v346 + v351 
    let v359 : string = v355 + v335 
    let v364 : string = "dice.accumulate_dice_rolls"
    let v365 : string = v359 + v364 
    let v370 : string = " / "
    let v371 : string = v365 + v370 
    let v375 : string = v371 + v331 
    method21(v375)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US2 = US2_1
    let v5 : bool = method6(v4)
    if v5 then
        let v20 : unit = ()
        let v21 : (unit -> unit) = closure9()
        let v22 : unit = (fun () -> v21 (); v20) ()
        let struct (v43 : Mut1, v44 : Mut3, v45 : Mut4, v46 : Mut5, v47 : Mut6, v48 : int64 option) = TraceState.trace_state.Value
        let v61 : string = method13(v43, v44, v45, v46, v47, v48)
        let v62 : string = method17()
        let v63 : string = method31(v43, v44, v45, v46, v47, v48, v61, v62, v1, v0, v2, v3)
        method22(v63)
and method32 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v10}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = " }"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure13(v12, v241)
    let v251 : unit = (fun () -> v250 (); v249) ()
    let v257 : string = v12.l0
    let v258 : int64 = v0.l0
    let v261 : string = " "
    let v262 : string = v6 + v261 
    let v266 : string = v262 + v7 
    let v271 : string = " #"
    let v272 : string = v266 + v271 
    let v276 : (int64 -> string) = _.ToString()
    let v277 : string = v276 v258
    let v281 : string = v272 + v277 
    let v285 : string = v281 + v261 
    let v290 : string = "dice.accumulate_dice_rolls"
    let v291 : string = v285 + v290 
    let v296 : string = " / "
    let v297 : string = v291 + v296 
    let v301 : string = v297 + v257 
    method21(v301)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method32(v42, v43, v44, v45, v46, v47, v60, v61, v1, v0, v2)
        method22(v62)
and method28 (v0 : int8, v1 : UH1, v2 : uint64) : US8 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure22(v2, v0, v4)
        let v67 : unit = (fun () -> v66 (); v65) ()
        US8_0(v4, v1)
    else
        match v1 with
        | UH1_1(v130, v131) -> (* Cons *)
            let v132 : bool = v130 > 1uy
            if v132 then
                let v133 : uint64 = 1UL
                let v134 : (unit -> UH2) = closure23()
                let v135 : UH2 = UH2_0(v133, v134)
                let v136 : US9 = method30(v0, v135)
                let v140 : uint64 =
                    match v136 with
                    | US9_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US9_0(v137) -> (* Some *)
                        v137
                let v141 : uint8 = v130 - 1uy
                let v142 : uint64 = uint64 v141
                let v143 : uint64 = v142 * v140
                let v204 : unit = ()
                let v205 : (unit -> unit) = closure87(v2, v0, v130, v143)
                let v206 : unit = (fun () -> v205 (); v204) ()
                let v267 : uint64 = v2 + v143
                let v268 : int8 = v0 - 1y
                method28(v268, v131, v267)
            else
                let v330 : unit = ()
                let v331 : (unit -> unit) = closure88(v2, v0, v130)
                let v332 : unit = (fun () -> v331 (); v330) ()
                let v393 : int8 = v0 - 1y
                method28(v393, v131, v2)
        | UH1_0 -> (* Nil *)
            US8_1
and method33 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method33(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method34 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method27(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US8 = method28(v3, v4, v10)
        match v11 with
        | US8_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method33(v3, v0, v15)
                    method34(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method27(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method33(v3, v0, v23)
                method34(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method27(v0, v1, v2, v3, v27, v5)
and method27 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method27(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US8 = method28(v3, v4, v12)
        match v13 with
        | US8_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method33(v3, v0, v17)
                    method34(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method27(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method33(v3, v0, v26)
                method34(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method27(v0, v1, v2, v3, v30, v31)
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
    method27(v0, v1, v2, v8, v9, v10)
and closure19 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure20(v0, v1)
and closure18 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure19(v0)
and method35 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method35(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure90 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method35(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US8 = method28(v4, v1, v5)
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
and method36 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method18()
    let v9 : Mut5 = {l0 = v8} : Mut5
    let v12 : string = "{ "
    let v13 : string = $"{v12}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure13(v9, v13)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v31 : string = "max"
    let v32 : string = $"{v31}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure13(v9, v32)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v50 : string = " = "
    let v51 : string = $"{v50}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure13(v9, v51)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v71 : string = $"{9223372036854775807L}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure13(v9, v71)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v89 : string = "; "
    let v90 : string = $"{v89}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure13(v9, v90)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v108 : string = "p"
    let v109 : string = $"{v108}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure13(v9, v109)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v126 : string = $"{v50}"
    let v134 : unit = ()
    let v135 : (unit -> unit) = closure13(v9, v126)
    let v136 : unit = (fun () -> v135 (); v134) ()
    let v146 : string = $"{4738381338321616896L}"
    let v154 : unit = ()
    let v155 : (unit -> unit) = closure13(v9, v146)
    let v156 : unit = (fun () -> v155 (); v154) ()
    let v163 : string = $"{v89}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure13(v9, v163)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v181 : string = "n"
    let v182 : string = $"{v181}"
    let v190 : unit = ()
    let v191 : (unit -> unit) = closure13(v9, v182)
    let v192 : unit = (fun () -> v191 (); v190) ()
    let v199 : string = $"{v50}"
    let v207 : unit = ()
    let v208 : (unit -> unit) = closure13(v9, v199)
    let v209 : unit = (fun () -> v208 (); v207) ()
    let v219 : string = $"{24y}"
    let v227 : unit = ()
    let v228 : (unit -> unit) = closure13(v9, v219)
    let v229 : unit = (fun () -> v228 (); v227) ()
    let v237 : string = " }"
    let v238 : string = $"{v237}"
    let v246 : unit = ()
    let v247 : (unit -> unit) = closure13(v9, v238)
    let v248 : unit = (fun () -> v247 (); v246) ()
    let v254 : string = v9.l0
    let v255 : int64 = v0.l0
    let v258 : string = " "
    let v259 : string = v6 + v258 
    let v263 : string = v259 + v7 
    let v268 : string = " #"
    let v269 : string = v263 + v268 
    let v273 : (int64 -> string) = _.ToString()
    let v274 : string = v273 v255
    let v278 : string = v269 + v274 
    let v282 : string = v278 + v258 
    let v287 : string = "dice.calculate_dice_count"
    let v288 : string = v282 + v287 
    let v293 : string = " / "
    let v294 : string = v288 + v293 
    let v298 : string = v294 + v254 
    method21(v298)
and closure92 () () : unit =
    let v0 : US2 = US2_1
    let v1 : bool = method6(v0)
    if v1 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure9()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
        let v57 : string = method13(v39, v40, v41, v42, v43, v44)
        let v58 : string = method17()
        let v59 : string = method36(v39, v40, v41, v42, v43, v44, v57, v58)
        method22(v59)
and method38 () : uint8 =
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
and method40 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{23y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure93 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method40(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method42 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{22y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure94 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method42(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method44 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{21y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure95 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method44(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method46 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{20y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure96 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method46(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method48 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{19y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure97 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method48(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method50 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{18y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure98 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method50(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method52 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{17y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure99 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method52(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method54 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{16y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure100 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method54(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method56 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{15y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure101 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method56(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method58 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{14y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure102 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method58(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method60 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{13y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method60(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method62 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{12y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method62(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method64 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{11y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method64(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method66 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{10y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method66(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method68 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{9y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method68(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method70 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{8y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method70(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method72 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{7y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method72(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method74 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{6y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method74(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method76 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{5y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method76(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method78 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{4y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method78(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method80 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{3y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method80(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method82 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{2y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method82(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method84 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{1y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method84(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method86 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : string = method18()
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure13(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure13(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{0y}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure13(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure13(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure13(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v8}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure13(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure13(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure13(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure13(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v9}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure13(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v92}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure13(v12, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v257 : string = "value"
    let v258 : string = $"{v257}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure13(v12, v258)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v275 : string = $"{v53}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure13(v12, v275)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v295 : string = $"{v10}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure13(v12, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v313 : string = " }"
    let v314 : string = $"{v313}"
    let v322 : unit = ()
    let v323 : (unit -> unit) = closure13(v12, v314)
    let v324 : unit = (fun () -> v323 (); v322) ()
    let v330 : string = v12.l0
    let v331 : int64 = v0.l0
    let v334 : string = " "
    let v335 : string = v6 + v334 
    let v339 : string = v335 + v7 
    let v344 : string = " #"
    let v345 : string = v339 + v344 
    let v349 : (int64 -> string) = _.ToString()
    let v350 : string = v349 v331
    let v354 : string = v345 + v350 
    let v358 : string = v354 + v334 
    let v363 : string = "dice.accumulate_dice_rolls"
    let v364 : string = v358 + v363 
    let v369 : string = " / "
    let v370 : string = v364 + v369 
    let v374 : string = v370 + v330 
    method21(v374)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure9()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut5, v46 : Mut6, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method13(v42, v43, v44, v45, v46, v47)
        let v61 : string = method17()
        let v62 : string = method86(v42, v43, v44, v45, v46, v47, v60, v61, v0, v1, v2)
        method22(v62)
and method88 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{-1y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "result"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure117 (v0 : int64, v1 : int64) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method88(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method87 (v0 : UH1, v1 : int64) : US10 =
    let v2 : int64 = v1 + 1L
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure117(v1, v2)
    let v65 : unit = (fun () -> v64 (); v63) ()
    US10_0(v2, v0)
and method89 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{0y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure118 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method89(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method85 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v68 : unit = ()
            let v69 : (unit -> unit) = closure116(v1, v3, v7)
            let v70 : unit = (fun () -> v69 (); v68) ()
            let v131 : int64 = v1 + v7
            method87(v4, v131)
        else
            let v193 : unit = ()
            let v194 : (unit -> unit) = closure118(v1, v3)
            let v195 : unit = (fun () -> v194 (); v193) ()
            method87(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method90 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{1y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure119 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method90(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method83 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure115(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method85(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure119(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method85(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method91 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{2y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure120 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method91(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method81 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure114(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method83(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure120(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method83(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method92 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{3y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure121 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method92(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method79 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure113(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method81(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure121(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method81(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method93 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{4y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure122 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method93(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method77 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure112(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method79(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure122(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method79(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method94 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{5y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure123 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method94(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method75 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure111(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method77(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure123(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method77(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method95 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{6y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure124 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method95(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method73 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure110(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method75(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure124(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method75(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method96 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{7y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure125 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method96(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method71 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure109(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method73(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure125(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method73(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method97 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{8y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure126 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method97(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method69 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure108(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method71(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure126(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method71(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method98 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{9y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure127 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method98(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method67 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure107(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method69(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure127(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method69(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method99 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{10y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method99(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method65 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure106(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method67(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure128(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method67(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method100 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{11y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method100(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method63 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure105(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method65(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure129(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method65(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{12y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method101(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method61 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure104(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method63(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure130(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method63(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{13y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method102(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method59 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure103(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method61(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure131(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method61(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{14y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method103(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method57 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure102(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method59(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure132(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method59(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{15y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method104(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method55 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure101(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method57(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure133(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method57(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{16y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method105(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method53 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure100(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method55(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure134(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method55(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{17y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method106(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method51 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure99(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method53(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure135(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method53(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{18y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method107(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method49 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure98(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method51(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure136(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method51(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{19y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method108(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method47 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure97(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method49(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure137(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method49(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{20y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method109(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method45 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure96(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method47(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure138(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method47(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{21y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method110(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method43 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure95(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method45(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure139(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method45(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{22y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method111(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method41 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure94(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method43(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure140(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method43(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : string = method18()
    let v11 : Mut5 = {l0 = v10} : Mut5
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure13(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "power"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{23y}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure13(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure13(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "acc"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure13(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v148 : string = $"{v8}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure13(v11, v148)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v165 : string = $"{v91}"
    let v173 : unit = ()
    let v174 : (unit -> unit) = closure13(v11, v165)
    let v175 : unit = (fun () -> v174 (); v173) ()
    let v183 : string = "roll"
    let v184 : string = $"{v183}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure13(v11, v184)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v201 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure13(v11, v201)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : string = $"{v9}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure13(v11, v221)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v239 : string = " }"
    let v240 : string = $"{v239}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure13(v11, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v256 : string = v11.l0
    let v257 : int64 = v0.l0
    let v260 : string = " "
    let v261 : string = v6 + v260 
    let v265 : string = v261 + v7 
    let v270 : string = " #"
    let v271 : string = v265 + v270 
    let v275 : (int64 -> string) = _.ToString()
    let v276 : string = v275 v257
    let v280 : string = v271 + v276 
    let v284 : string = v280 + v260 
    let v289 : string = "dice.accumulate_dice_rolls"
    let v290 : string = v284 + v289 
    let v295 : string = " / "
    let v296 : string = v290 + v295 
    let v300 : string = v296 + v256 
    method21(v300)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure9()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method13(v41, v42, v43, v44, v45, v46)
        let v60 : string = method17()
        let v61 : string = method112(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method22(v61)
and method39 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v69 : unit = ()
            let v70 : (unit -> unit) = closure93(v1, v3, v8)
            let v71 : unit = (fun () -> v70 (); v69) ()
            let v132 : int64 = v1 + v8
            method41(v4, v132)
        else
            let v194 : unit = ()
            let v195 : (unit -> unit) = closure141(v1, v3)
            let v196 : unit = (fun () -> v195 (); v194) ()
            method41(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method37 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method38()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method37(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US10 = method39(v0, v7)
        match v8 with
        | US10_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method38()
                let v13 : uint8 = method38()
                let v14 : uint8 = method38()
                let v15 : uint8 = method38()
                let v16 : uint8 = method38()
                let v17 : uint8 = method38()
                let v18 : uint8 = method38()
                let v19 : uint8 = method38()
                let v20 : uint8 = method38()
                let v21 : uint8 = method38()
                let v22 : uint8 = method38()
                let v23 : uint8 = method38()
                let v24 : uint8 = method38()
                let v25 : uint8 = method38()
                let v26 : uint8 = method38()
                let v27 : uint8 = method38()
                let v28 : uint8 = method38()
                let v29 : uint8 = method38()
                let v30 : uint8 = method38()
                let v31 : uint8 = method38()
                let v32 : uint8 = method38()
                let v33 : uint8 = method38()
                let v34 : uint8 = method38()
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
                method37(v58, v59)
        | _ ->
            let v62 : uint8 = method38()
            let v63 : uint8 = method38()
            let v64 : uint8 = method38()
            let v65 : uint8 = method38()
            let v66 : uint8 = method38()
            let v67 : uint8 = method38()
            let v68 : uint8 = method38()
            let v69 : uint8 = method38()
            let v70 : uint8 = method38()
            let v71 : uint8 = method38()
            let v72 : uint8 = method38()
            let v73 : uint8 = method38()
            let v74 : uint8 = method38()
            let v75 : uint8 = method38()
            let v76 : uint8 = method38()
            let v77 : uint8 = method38()
            let v78 : uint8 = method38()
            let v79 : uint8 = method38()
            let v80 : uint8 = method38()
            let v81 : uint8 = method38()
            let v82 : uint8 = method38()
            let v83 : uint8 = method38()
            let v84 : uint8 = method38()
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
            method37(v108, v109)
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : string = method18()
    let v10 : Mut5 = {l0 = v9} : Mut5
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure13(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "result"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure13(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure13(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v72 : string = $"{v8}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure13(v10, v72)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v90 : string = " }"
    let v91 : string = $"{v90}"
    let v99 : unit = ()
    let v100 : (unit -> unit) = closure13(v10, v91)
    let v101 : unit = (fun () -> v100 (); v99) ()
    let v107 : string = v10.l0
    let v108 : int64 = v0.l0
    let v111 : string = " "
    let v112 : string = v6 + v111 
    let v116 : string = v112 + v7 
    let v121 : string = " #"
    let v122 : string = v116 + v121 
    let v126 : (int64 -> string) = _.ToString()
    let v127 : string = v126 v108
    let v131 : string = v122 + v127 
    let v135 : string = v131 + v111 
    let v140 : string = "dice.main"
    let v141 : string = v135 + v140 
    let v146 : string = " / "
    let v147 : string = v141 + v146 
    let v151 : string = v147 + v107 
    method21(v151)
and closure142 (v0 : int64) () : unit =
    let v1 : US2 = US2_1
    let v2 : bool = method6(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure9()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut1, v41 : Mut3, v42 : Mut4, v43 : Mut5, v44 : Mut6, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method13(v40, v41, v42, v43, v44, v45)
        let v59 : string = method17()
        let v60 : string = method113(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method22(v60)
and closure91 () (v0 : (string [])) : int32 =
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure92()
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v124 : UH1 = UH1_0
    let v125 : int8 = 0y
    let v126 : int64 = method37(v124, v125)
    let v187 : unit = ()
    let v188 : (unit -> unit) = closure142(v126)
    let v189 : unit = (fun () -> v188 (); v187) ()
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
