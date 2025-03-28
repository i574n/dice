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
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
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
    let v16 : string = method5()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US3 = US3_1
    let v20 : US4 = US4_3(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US3 = US3_2
    let v24 : US4 = US4_3(v23)
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
    let v49 : (string -> US5) = method6()
    let v50 : US5 option = v44 |> Option.map v49 
    let v70 : US5 = US5_1
    let v71 : US5 = v50 |> Option.defaultValue v70 
    let v78 : string =
        match v71 with
        | US5_1 -> (* None *)
            let v76 : string = ""
            v76
        | US5_0(v75) -> (* Some *)
            v75
    let _run_target_args'_v2 = v78 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : US3 = US3_1
    let v80 : US4 = US4_1(v79)
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
    let v93 : (string -> US5) = method6()
    let v94 : US5 option = v88 |> Option.map v93 
    let v114 : US5 = US5_1
    let v115 : US5 = v94 |> Option.defaultValue v114 
    let v122 : string =
        match v115 with
        | US5_1 -> (* None *)
            let v120 : string = ""
            v120
        | US5_0(v119) -> (* Some *)
            v119
    let _run_target_args'_v2 = v122 
    #endif
    let v123 : string = _run_target_args'_v2 
    v123
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    
    
    
    
    
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
    let v41 : US1 =
        if v37 then
            let v38 : US0 = US0_0
            US1_0(v38)
        else
            US1_1
    let v127 : US1 =
        match v41 with
        | US1_1 -> (* None *)
            let v44 : bool = "Debug" = v1
            let v48 : US1 =
                if v44 then
                    let v45 : US0 = US0_1
                    US1_0(v45)
                else
                    US1_1
            match v48 with
            | US1_1 -> (* None *)
                let v51 : bool = "Info" = v1
                let v55 : US1 =
                    if v51 then
                        let v52 : US0 = US0_2
                        US1_0(v52)
                    else
                        US1_1
                match v55 with
                | US1_1 -> (* None *)
                    let v58 : bool = "Warning" = v1
                    let v62 : US1 =
                        if v58 then
                            let v59 : US0 = US0_3
                            US1_0(v59)
                        else
                            US1_1
                    match v62 with
                    | US1_1 -> (* None *)
                        let v65 : bool = "Critical" = v1
                        let v69 : US1 =
                            if v65 then
                                let v66 : US0 = US0_4
                                US1_0(v66)
                            else
                                US1_1
                        match v69 with
                        | US1_1 -> (* None *)
                            let v72 : bool = v34 = v1
                            let v76 : US1 =
                                if v72 then
                                    let v73 : US0 = US0_0
                                    US1_0(v73)
                                else
                                    US1_1
                            match v76 with
                            | US1_1 -> (* None *)
                                let v79 : bool = v27 = v1
                                let v83 : US1 =
                                    if v79 then
                                        let v80 : US0 = US0_1
                                        US1_0(v80)
                                    else
                                        US1_1
                                match v83 with
                                | US1_1 -> (* None *)
                                    let v86 : bool = v20 = v1
                                    let v90 : US1 =
                                        if v86 then
                                            let v87 : US0 = US0_2
                                            US1_0(v87)
                                        else
                                            US1_1
                                    match v90 with
                                    | US1_1 -> (* None *)
                                        let v93 : bool = v13 = v1
                                        let v97 : US1 =
                                            if v93 then
                                                let v94 : US0 = US0_3
                                                US1_0(v94)
                                            else
                                                US1_1
                                        match v97 with
                                        | US1_1 -> (* None *)
                                            let v100 : bool = v6 = v1
                                            let v104 : US1 =
                                                if v100 then
                                                    let v101 : US0 = US0_4
                                                    US1_0(v101)
                                                else
                                                    US1_1
                                            match v104 with
                                            | US1_1 -> (* None *)
                                                US1_1
                                            | US1_0(v105) -> (* Some *)
                                                US1_0(v105)
                                        | US1_0(v98) -> (* Some *)
                                            US1_0(v98)
                                    | US1_0(v91) -> (* Some *)
                                        US1_0(v91)
                                | US1_0(v84) -> (* Some *)
                                    US1_0(v84)
                            | US1_0(v77) -> (* Some *)
                                US1_0(v77)
                        | US1_0(v70) -> (* Some *)
                            US1_0(v70)
                    | US1_0(v63) -> (* Some *)
                        US1_0(v63)
                | US1_0(v56) -> (* Some *)
                    US1_0(v56)
            | US1_0(v49) -> (* Some *)
                US1_0(v49)
        | US1_0(v42) -> (* Some *)
            US1_0(v42)
    let v128 : string = "AUTOMATION"
    let v129 : string = method3(v128)
    let v132 : string = "True"
    let v133 : bool = v129 <> v132 
    let v209 : US2 =
        if v133 then
            US2_1
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
            US2_0(v203)
    struct (v127, v209)
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
    let v198 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v194 : int64 option = None
            v194
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v198)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method0 (v0 : US0) : bool =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure2()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
    let v56 : US0 = v42.l0
    let v57 : bool = v40.l0
    let v58 : bool = v57 = false
    if v58 then
        false
    else
        let v59 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v60 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v56
        let v61 : bool = v59 >= v60
        v61
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
    let v187 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : (int64 -> US2) = method8()
    let v191 : US2 option = v5 |> Option.map v190 
    let v211 : US2 = US2_1
    let v212 : US2 = v191 |> Option.defaultValue v211 
    let v344 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
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
        | US2_0(v216) -> (* Some *)
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
    let v346 : string = method9()
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
    let v371 : (int64 -> US2) = method8()
    let v372 : US2 option = v5 |> Option.map v371 
    let v392 : US2 = US2_1
    let v393 : US2 = v372 |> Option.defaultValue v392 
    let v525 : System.DateTime =
        match v393 with
        | US2_1 -> (* None *)
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
        | US2_0(v397) -> (* Some *)
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
    let v527 : string = method9()
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
    let v554 : (int64 -> US2) = method8()
    let v555 : US2 option = v5 |> Option.map v554 
    let v575 : US2 = US2_1
    let v576 : US2 = v555 |> Option.defaultValue v575 
    let v588 : uint64 =
        match v576 with
        | US2_1 -> (* None *)
            v551
        | US2_0(v580) -> (* Some *)
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
    let v601 : (int64 -> US2) = method8()
    let v602 : US2 option = v5 |> Option.map v601 
    let v622 : US2 = US2_1
    let v623 : US2 = v602 |> Option.defaultValue v622 
    let v755 : System.DateTime =
        match v623 with
        | US2_1 -> (* None *)
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
        | US2_0(v627) -> (* Some *)
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
    let v757 : string = method10()
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
    let v782 : (int64 -> US2) = method8()
    let v783 : US2 option = v5 |> Option.map v782 
    let v803 : US2 = US2_1
    let v804 : US2 = v783 |> Option.defaultValue v803 
    let v936 : System.DateTime =
        match v804 with
        | US2_1 -> (* None *)
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
        | US2_0(v808) -> (* Some *)
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
    let v938 : string = method10()
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
    let v963 : (int64 -> US2) = method8()
    let v964 : US2 option = v5 |> Option.map v963 
    let v984 : US2 = US2_1
    let v985 : US2 = v964 |> Option.defaultValue v984 
    let v1117 : System.DateTime =
        match v985 with
        | US2_1 -> (* None *)
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
        | US2_0(v989) -> (* Some *)
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
    let v1119 : string = method10()
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
    let v1144 : (int64 -> US2) = method8()
    let v1145 : US2 option = v5 |> Option.map v1144 
    let v1165 : US2 = US2_1
    let v1166 : US2 = v1145 |> Option.defaultValue v1165 
    let v1298 : System.DateTime =
        match v1166 with
        | US2_1 -> (* None *)
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
        | US2_0(v1170) -> (* Some *)
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
    let v1300 : string = method10()
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
and method12 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method12()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure6(v9, v14)
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
    let v176 : string = method13()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[94m"
    let v192 : string = method13()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[94m"
    let v208 : string = method13()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[94m"
    let v224 : string = method13()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
and method15 (v0 : string) : string =
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
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method12()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure6(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "seed_excess_len"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure6(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v73 : string = $"{v8}"
    let v81 : unit = ()
    let v82 : (unit -> unit) = closure6(v11, v73)
    let v83 : unit = (fun () -> v82 (); v81) ()
    let v91 : string = "; "
    let v92 : string = $"{v91}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure6(v11, v92)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v110 : string = "seed_excess"
    let v111 : string = $"{v110}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure6(v11, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v128 : string = $"{v52}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure6(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v145 : string = $"{v9}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure6(v11, v145)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v163 : string = " }"
    let v164 : string = $"{v163}"
    let v172 : unit = ()
    let v173 : (unit -> unit) = closure6(v11, v164)
    let v174 : unit = (fun () -> v173 (); v172) ()
    let v180 : string = v11.l0
    let v181 : int64 = v0.l0
    let v184 : string = " "
    let v185 : string = v6 + v184 
    let v189 : string = v185 + v7 
    let v194 : string = " #"
    let v195 : string = v189 + v194 
    let v199 : (int64 -> string) = _.ToString()
    let v200 : string = v199 v181
    let v204 : string = v195 + v200 
    let v208 : string = v204 + v184 
    let v213 : string = "dice_contract.contribute_seed"
    let v214 : string = v208 + v213 
    let v219 : string = " / "
    let v220 : string = v214 + v219 
    let v224 : string = v220 + v180 
    method15(v224)
and closure7 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure9 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure8 () (v0 : string) : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9(v0)
    let v4 : unit = (fun () -> v3 (); v2) ()
    ()
and method16 (v0 : string) : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure2()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure7(v38)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v63 : (string -> unit) = closure8()
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
and closure1 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure2()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method7(v41, v42, v43, v44, v45, v46)
        let v60 : string = method11()
        let v62 : string = $"%A{v1}"
        let v65 : string = method14(v41, v42, v43, v44, v45, v46, v59, v60, v0, v62)
        method16(v65)
and closure10 () () : unit =
    ()
and method17 () : (unit -> unit) =
    closure10()
and method18 () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure2()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v37 : Mut0, v38 : Mut1, v39 : Mut2, v40 : Mut3, v41 : Mut4, v42 : int64 option) = TraceState.trace_state.Value
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure7(v37)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v62 : string = ""
    let v63 : (string -> unit) = closure8()
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v62 v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v62 v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = v40.l0
    let v68 : bool = v67 = ""
    let v83 : string =
        if v68 then
            v62
        else
            let v69 : bool = v62 = ""
            if v69 then
                let v70 : string = v40.l0
                v70
            else
                let v71 : string = v40.l0
                let v74 : string = "\n"
                let v75 : string = v71 + v74 
                let v79 : string = v75 + v62 
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
    let v151 : bool = v62 <> v62 
    let v155 : bool =
        if v151 then
            let v154 : bool = v142 <= 1
            v154
        else
            false
    if v155 then
        v40.l0 <- v83
        ()
    else
        v40.l0 <- v62
        let v156 : string = "true; $0.into_iter().for_each(|x| { //"
        let v157 : bool = Fable.Core.RustInterop.emitRustExpr v134 v156 
        let v158 : string = "x"
        let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v158 
        let v160 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v161 : bool = Fable.Core.RustInterop.emitRustExpr v159 v160 
        let v162 : string = $"true"
        let v163 : bool = Fable.Core.RustInterop.emitRustExpr () v162 
        let v164 : string = "true; }); //"
        let v165 : bool = Fable.Core.RustInterop.emitRustExpr () v164 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v63 v62
    #endif
#if FABLE_COMPILER_PYTHON
    v63 v62
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v63 v62
    #endif
#else
    v63 v62
    #endif
    // run_target_args' is_unit
    let v166 : (string -> unit) = v38.l0
    v166 v62
and closure11 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure2()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        method18()
and closure13 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure12 () (v0 : uint8) : (UH0 -> UH0) =
    closure13(v0)
and method19 () : (uint8 -> (UH0 -> UH0)) =
    closure12()
and closure14 (v0 : UH1) () : UH1 =
    v0
and method20 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method20(v3, v1)
        let v5 : (unit -> UH1) = closure14(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure15 (v0 : UH1) () : UH1 =
    v0
and method21 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method21(v4, v1)
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
and method22 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method22(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method23 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method23(v3, v1)
        let v6 : uint8 list = v2 :: v4 
        v6
    | UH0_0 -> (* Nil *)
        v1
and method24 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method12()
    let v24 : Mut3 = {l0 = v23} : Mut3
    let v27 : string = "{ "
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v24, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = "max"
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure6(v24, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v65 : string = " = "
    let v66 : string = $"{v65}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure6(v24, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v86 : string = $"{v8}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v24, v86)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v104 : string = "; "
    let v105 : string = $"{v104}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure6(v24, v105)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v123 : string = "key"
    let v124 : string = $"{v123}"
    let v132 : unit = ()
    let v133 : (unit -> unit) = closure6(v24, v124)
    let v134 : unit = (fun () -> v133 (); v132) ()
    let v141 : string = $"{v65}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure6(v24, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    (* run_target_args'
    let v161 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v162 : string = "format!(\"{:#?}\", $0)"
    let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v162 
    let v164 : string = "fable_library_rust::String_::fromString($0)"
    let v165 : string = Fable.Core.RustInterop.emitRustExpr v163 v164 
    let _run_target_args'_v161 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "format!(\"{:#?}\", $0)"
    let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v166 
    let v168 : string = "fable_library_rust::String_::fromString($0)"
    let v169 : string = Fable.Core.RustInterop.emitRustExpr v167 v168 
    let _run_target_args'_v161 = v169 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v170 : string = "format!(\"{:#?}\", $0)"
    let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v170 
    let v172 : string = "fable_library_rust::String_::fromString($0)"
    let v173 : string = Fable.Core.RustInterop.emitRustExpr v171 v172 
    let _run_target_args'_v161 = v173 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v175 : string = $"%A{v9}"
    let _run_target_args'_v161 = v175 
    #endif
#if FABLE_COMPILER_PYTHON
    let v179 : string = $"%A{v9}"
    let _run_target_args'_v161 = v179 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v183 : string = $"%A{v9}"
    let _run_target_args'_v161 = v183 
    #endif
#else
    let v187 : string = $"%A{v9}"
    let _run_target_args'_v161 = v187 
    #endif
    let v190 : string = _run_target_args'_v161 
    let v197 : string = $"{v190}"
    let v205 : unit = ()
    let v206 : (unit -> unit) = closure6(v24, v197)
    let v207 : unit = (fun () -> v206 (); v205) ()
    let v214 : string = $"{v104}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure6(v24, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = "proof"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure6(v24, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v250 : string = $"{v65}"
    let v258 : unit = ()
    let v259 : (unit -> unit) = closure6(v24, v250)
    let v260 : unit = (fun () -> v259 (); v258) ()
    (* run_target_args'
    let v270 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : string = "format!(\"{:#?}\", $0)"
    let v272 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v271 
    let v273 : string = "fable_library_rust::String_::fromString($0)"
    let v274 : string = Fable.Core.RustInterop.emitRustExpr v272 v273 
    let _run_target_args'_v270 = v274 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v275 : string = "format!(\"{:#?}\", $0)"
    let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v275 
    let v277 : string = "fable_library_rust::String_::fromString($0)"
    let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
    let _run_target_args'_v270 = v278 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v279 : string = "format!(\"{:#?}\", $0)"
    let v280 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v279 
    let v281 : string = "fable_library_rust::String_::fromString($0)"
    let v282 : string = Fable.Core.RustInterop.emitRustExpr v280 v281 
    let _run_target_args'_v270 = v282 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v284 : string = $"%A{v10}"
    let _run_target_args'_v270 = v284 
    #endif
#if FABLE_COMPILER_PYTHON
    let v288 : string = $"%A{v10}"
    let _run_target_args'_v270 = v288 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v292 : string = $"%A{v10}"
    let _run_target_args'_v270 = v292 
    #endif
#else
    let v296 : string = $"%A{v10}"
    let _run_target_args'_v270 = v296 
    #endif
    let v299 : string = _run_target_args'_v270 
    let v306 : string = $"{v299}"
    let v314 : unit = ()
    let v315 : (unit -> unit) = closure6(v24, v306)
    let v316 : unit = (fun () -> v315 (); v314) ()
    let v323 : string = $"{v104}"
    let v331 : unit = ()
    let v332 : (unit -> unit) = closure6(v24, v323)
    let v333 : unit = (fun () -> v332 (); v331) ()
    let v341 : string = "block_timestamp"
    let v342 : string = $"{v341}"
    let v350 : unit = ()
    let v351 : (unit -> unit) = closure6(v24, v342)
    let v352 : unit = (fun () -> v351 (); v350) ()
    let v359 : string = $"{v65}"
    let v367 : unit = ()
    let v368 : (unit -> unit) = closure6(v24, v359)
    let v369 : unit = (fun () -> v368 (); v367) ()
    let v379 : string = $"{v11}"
    let v387 : unit = ()
    let v388 : (unit -> unit) = closure6(v24, v379)
    let v389 : unit = (fun () -> v388 (); v387) ()
    let v396 : string = $"{v104}"
    let v404 : unit = ()
    let v405 : (unit -> unit) = closure6(v24, v396)
    let v406 : unit = (fun () -> v405 (); v404) ()
    let v414 : string = "block_height"
    let v415 : string = $"{v414}"
    let v423 : unit = ()
    let v424 : (unit -> unit) = closure6(v24, v415)
    let v425 : unit = (fun () -> v424 (); v423) ()
    let v432 : string = $"{v65}"
    let v440 : unit = ()
    let v441 : (unit -> unit) = closure6(v24, v432)
    let v442 : unit = (fun () -> v441 (); v440) ()
    let v452 : string = $"{v12}"
    let v460 : unit = ()
    let v461 : (unit -> unit) = closure6(v24, v452)
    let v462 : unit = (fun () -> v461 (); v460) ()
    let v469 : string = $"{v104}"
    let v477 : unit = ()
    let v478 : (unit -> unit) = closure6(v24, v469)
    let v479 : unit = (fun () -> v478 (); v477) ()
    let v487 : string = "epoch_height"
    let v488 : string = $"{v487}"
    let v496 : unit = ()
    let v497 : (unit -> unit) = closure6(v24, v488)
    let v498 : unit = (fun () -> v497 (); v496) ()
    let v505 : string = $"{v65}"
    let v513 : unit = ()
    let v514 : (unit -> unit) = closure6(v24, v505)
    let v515 : unit = (fun () -> v514 (); v513) ()
    let v525 : string = $"{v13}"
    let v533 : unit = ()
    let v534 : (unit -> unit) = closure6(v24, v525)
    let v535 : unit = (fun () -> v534 (); v533) ()
    let v542 : string = $"{v104}"
    let v550 : unit = ()
    let v551 : (unit -> unit) = closure6(v24, v542)
    let v552 : unit = (fun () -> v551 (); v550) ()
    let v560 : string = "account_balance"
    let v561 : string = $"{v560}"
    let v569 : unit = ()
    let v570 : (unit -> unit) = closure6(v24, v561)
    let v571 : unit = (fun () -> v570 (); v569) ()
    let v578 : string = $"{v65}"
    let v586 : unit = ()
    let v587 : (unit -> unit) = closure6(v24, v578)
    let v588 : unit = (fun () -> v587 (); v586) ()
    let v595 : string = $"{v14}"
    let v603 : unit = ()
    let v604 : (unit -> unit) = closure6(v24, v595)
    let v605 : unit = (fun () -> v604 (); v603) ()
    let v612 : string = $"{v104}"
    let v620 : unit = ()
    let v621 : (unit -> unit) = closure6(v24, v612)
    let v622 : unit = (fun () -> v621 (); v620) ()
    let v630 : string = "signer_account_id"
    let v631 : string = $"{v630}"
    let v639 : unit = ()
    let v640 : (unit -> unit) = closure6(v24, v631)
    let v641 : unit = (fun () -> v640 (); v639) ()
    let v648 : string = $"{v65}"
    let v656 : unit = ()
    let v657 : (unit -> unit) = closure6(v24, v648)
    let v658 : unit = (fun () -> v657 (); v656) ()
    (* run_target_args'
    let v668 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v669 : string = "format!(\"{:#?}\", $0)"
    let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v669 
    let v671 : string = "fable_library_rust::String_::fromString($0)"
    let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
    let _run_target_args'_v668 = v672 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v673 : string = "format!(\"{:#?}\", $0)"
    let v674 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v673 
    let v675 : string = "fable_library_rust::String_::fromString($0)"
    let v676 : string = Fable.Core.RustInterop.emitRustExpr v674 v675 
    let _run_target_args'_v668 = v676 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v677 : string = "format!(\"{:#?}\", $0)"
    let v678 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v677 
    let v679 : string = "fable_library_rust::String_::fromString($0)"
    let v680 : string = Fable.Core.RustInterop.emitRustExpr v678 v679 
    let _run_target_args'_v668 = v680 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v682 : string = $"%A{v15}"
    let _run_target_args'_v668 = v682 
    #endif
#if FABLE_COMPILER_PYTHON
    let v686 : string = $"%A{v15}"
    let _run_target_args'_v668 = v686 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v690 : string = $"%A{v15}"
    let _run_target_args'_v668 = v690 
    #endif
#else
    let v694 : string = $"%A{v15}"
    let _run_target_args'_v668 = v694 
    #endif
    let v697 : string = _run_target_args'_v668 
    let v704 : string = $"{v697}"
    let v712 : unit = ()
    let v713 : (unit -> unit) = closure6(v24, v704)
    let v714 : unit = (fun () -> v713 (); v712) ()
    let v721 : string = $"{v104}"
    let v729 : unit = ()
    let v730 : (unit -> unit) = closure6(v24, v721)
    let v731 : unit = (fun () -> v730 (); v729) ()
    let v739 : string = "predecessor_account_id"
    let v740 : string = $"{v739}"
    let v748 : unit = ()
    let v749 : (unit -> unit) = closure6(v24, v740)
    let v750 : unit = (fun () -> v749 (); v748) ()
    let v757 : string = $"{v65}"
    let v765 : unit = ()
    let v766 : (unit -> unit) = closure6(v24, v757)
    let v767 : unit = (fun () -> v766 (); v765) ()
    (* run_target_args'
    let v777 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v778 : string = "format!(\"{:#?}\", $0)"
    let v779 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v778 
    let v780 : string = "fable_library_rust::String_::fromString($0)"
    let v781 : string = Fable.Core.RustInterop.emitRustExpr v779 v780 
    let _run_target_args'_v777 = v781 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v782 : string = "format!(\"{:#?}\", $0)"
    let v783 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v782 
    let v784 : string = "fable_library_rust::String_::fromString($0)"
    let v785 : string = Fable.Core.RustInterop.emitRustExpr v783 v784 
    let _run_target_args'_v777 = v785 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v786 : string = "format!(\"{:#?}\", $0)"
    let v787 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v786 
    let v788 : string = "fable_library_rust::String_::fromString($0)"
    let v789 : string = Fable.Core.RustInterop.emitRustExpr v787 v788 
    let _run_target_args'_v777 = v789 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v791 : string = $"%A{v16}"
    let _run_target_args'_v777 = v791 
    #endif
#if FABLE_COMPILER_PYTHON
    let v795 : string = $"%A{v16}"
    let _run_target_args'_v777 = v795 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v799 : string = $"%A{v16}"
    let _run_target_args'_v777 = v799 
    #endif
#else
    let v803 : string = $"%A{v16}"
    let _run_target_args'_v777 = v803 
    #endif
    let v806 : string = _run_target_args'_v777 
    let v813 : string = $"{v806}"
    let v821 : unit = ()
    let v822 : (unit -> unit) = closure6(v24, v813)
    let v823 : unit = (fun () -> v822 (); v821) ()
    let v830 : string = $"{v104}"
    let v838 : unit = ()
    let v839 : (unit -> unit) = closure6(v24, v830)
    let v840 : unit = (fun () -> v839 (); v838) ()
    let v848 : string = "seed"
    let v849 : string = $"{v848}"
    let v857 : unit = ()
    let v858 : (unit -> unit) = closure6(v24, v849)
    let v859 : unit = (fun () -> v858 (); v857) ()
    let v866 : string = $"{v65}"
    let v874 : unit = ()
    let v875 : (unit -> unit) = closure6(v24, v866)
    let v876 : unit = (fun () -> v875 (); v874) ()
    let v883 : string = $"{v17}"
    let v891 : unit = ()
    let v892 : (unit -> unit) = closure6(v24, v883)
    let v893 : unit = (fun () -> v892 (); v891) ()
    let v900 : string = $"{v104}"
    let v908 : unit = ()
    let v909 : (unit -> unit) = closure6(v24, v900)
    let v910 : unit = (fun () -> v909 (); v908) ()
    let v918 : string = "seeds"
    let v919 : string = $"{v918}"
    let v927 : unit = ()
    let v928 : (unit -> unit) = closure6(v24, v919)
    let v929 : unit = (fun () -> v928 (); v927) ()
    let v936 : string = $"{v65}"
    let v944 : unit = ()
    let v945 : (unit -> unit) = closure6(v24, v936)
    let v946 : unit = (fun () -> v945 (); v944) ()
    let v953 : string = $"{v18}"
    let v961 : unit = ()
    let v962 : (unit -> unit) = closure6(v24, v953)
    let v963 : unit = (fun () -> v962 (); v961) ()
    let v970 : string = $"{v104}"
    let v978 : unit = ()
    let v979 : (unit -> unit) = closure6(v24, v970)
    let v980 : unit = (fun () -> v979 (); v978) ()
    let v988 : string = "entropy_len"
    let v989 : string = $"{v988}"
    let v997 : unit = ()
    let v998 : (unit -> unit) = closure6(v24, v989)
    let v999 : unit = (fun () -> v998 (); v997) ()
    let v1006 : string = $"{v65}"
    let v1014 : unit = ()
    let v1015 : (unit -> unit) = closure6(v24, v1006)
    let v1016 : unit = (fun () -> v1015 (); v1014) ()
    (* run_target_args'
    let v1026 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1027 : string = "format!(\"{:#?}\", $0)"
    let v1028 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v1027 
    let v1029 : string = "fable_library_rust::String_::fromString($0)"
    let v1030 : string = Fable.Core.RustInterop.emitRustExpr v1028 v1029 
    let _run_target_args'_v1026 = v1030 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1031 : string = "format!(\"{:#?}\", $0)"
    let v1032 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v1031 
    let v1033 : string = "fable_library_rust::String_::fromString($0)"
    let v1034 : string = Fable.Core.RustInterop.emitRustExpr v1032 v1033 
    let _run_target_args'_v1026 = v1034 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1035 : string = "format!(\"{:#?}\", $0)"
    let v1036 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v1035 
    let v1037 : string = "fable_library_rust::String_::fromString($0)"
    let v1038 : string = Fable.Core.RustInterop.emitRustExpr v1036 v1037 
    let _run_target_args'_v1026 = v1038 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1040 : string = $"%A{v19}"
    let _run_target_args'_v1026 = v1040 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1044 : string = $"%A{v19}"
    let _run_target_args'_v1026 = v1044 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1048 : string = $"%A{v19}"
    let _run_target_args'_v1026 = v1048 
    #endif
#else
    let v1052 : string = $"%A{v19}"
    let _run_target_args'_v1026 = v1052 
    #endif
    let v1055 : string = _run_target_args'_v1026 
    let v1062 : string = $"{v1055}"
    let v1070 : unit = ()
    let v1071 : (unit -> unit) = closure6(v24, v1062)
    let v1072 : unit = (fun () -> v1071 (); v1070) ()
    let v1079 : string = $"{v104}"
    let v1087 : unit = ()
    let v1088 : (unit -> unit) = closure6(v24, v1079)
    let v1089 : unit = (fun () -> v1088 (); v1087) ()
    let v1097 : string = "entropy"
    let v1098 : string = $"{v1097}"
    let v1106 : unit = ()
    let v1107 : (unit -> unit) = closure6(v24, v1098)
    let v1108 : unit = (fun () -> v1107 (); v1106) ()
    let v1115 : string = $"{v65}"
    let v1123 : unit = ()
    let v1124 : (unit -> unit) = closure6(v24, v1115)
    let v1125 : unit = (fun () -> v1124 (); v1123) ()
    let v1132 : string = $"{v20}"
    let v1140 : unit = ()
    let v1141 : (unit -> unit) = closure6(v24, v1132)
    let v1142 : unit = (fun () -> v1141 (); v1140) ()
    let v1149 : string = $"{v104}"
    let v1157 : unit = ()
    let v1158 : (unit -> unit) = closure6(v24, v1149)
    let v1159 : unit = (fun () -> v1158 (); v1157) ()
    let v1167 : string = "hash_u8"
    let v1168 : string = $"{v1167}"
    let v1176 : unit = ()
    let v1177 : (unit -> unit) = closure6(v24, v1168)
    let v1178 : unit = (fun () -> v1177 (); v1176) ()
    let v1185 : string = $"{v65}"
    let v1193 : unit = ()
    let v1194 : (unit -> unit) = closure6(v24, v1185)
    let v1195 : unit = (fun () -> v1194 (); v1193) ()
    let v1202 : string = $"{v21}"
    let v1210 : unit = ()
    let v1211 : (unit -> unit) = closure6(v24, v1202)
    let v1212 : unit = (fun () -> v1211 (); v1210) ()
    let v1219 : string = $"{v104}"
    let v1227 : unit = ()
    let v1228 : (unit -> unit) = closure6(v24, v1219)
    let v1229 : unit = (fun () -> v1228 (); v1227) ()
    let v1237 : string = "rolls"
    let v1238 : string = $"{v1237}"
    let v1246 : unit = ()
    let v1247 : (unit -> unit) = closure6(v24, v1238)
    let v1248 : unit = (fun () -> v1247 (); v1246) ()
    let v1255 : string = $"{v65}"
    let v1263 : unit = ()
    let v1264 : (unit -> unit) = closure6(v24, v1255)
    let v1265 : unit = (fun () -> v1264 (); v1263) ()
    let v1272 : string = $"{v22}"
    let v1280 : unit = ()
    let v1281 : (unit -> unit) = closure6(v24, v1272)
    let v1282 : unit = (fun () -> v1281 (); v1280) ()
    let v1290 : string = " }"
    let v1291 : string = $"{v1290}"
    let v1299 : unit = ()
    let v1300 : (unit -> unit) = closure6(v24, v1291)
    let v1301 : unit = (fun () -> v1300 (); v1299) ()
    let v1307 : string = v24.l0
    let v1308 : int64 = v0.l0
    let v1311 : string = " "
    let v1312 : string = v6 + v1311 
    let v1316 : string = v1312 + v7 
    let v1321 : string = " #"
    let v1322 : string = v1316 + v1321 
    let v1326 : (int64 -> string) = _.ToString()
    let v1327 : string = v1326 v1308
    let v1331 : string = v1322 + v1327 
    let v1335 : string = v1331 + v1311 
    let v1340 : string = "dice_contract.generate_random_number"
    let v1341 : string = v1335 + v1340 
    let v1346 : string = " / "
    let v1347 : string = v1341 + v1346 
    let v1351 : string = v1347 + v1307 
    method15(v1351)
and closure16 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v14 : US0 = US0_1
    let v15 : bool = method0(v14)
    if v15 then
        let v30 : unit = ()
        let v31 : (unit -> unit) = closure2()
        let v32 : unit = (fun () -> v31 (); v30) ()
        let struct (v53 : Mut0, v54 : Mut1, v55 : Mut2, v56 : Mut3, v57 : Mut4, v58 : int64 option) = TraceState.trace_state.Value
        let v71 : string = method7(v53, v54, v55, v56, v57, v58)
        let v72 : string = method11()
        let v74 : string = $"%A{v8}"
        let v77 : string = $"v9.to_string()"
        let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v77 
        let v79 : string = $"v10.to_string()"
        let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v79 
        let v82 : string = $"%A{v4}"
        let v86 : string = $"%A{v0}"
        let v89 : string = "$0.len()"
        let v90 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v89 
        let v92 : string = $"%A{v11}"
        let v96 : string = $"%A{v12}"
        let v99 : uint8 list = []
        let v100 : uint8 list = method23(v13, v99)
        let v102 : (uint8 list -> (uint8 [])) = List.toArray
        let v103 : (uint8 []) = v102 v100
        let v106 : string = "$0.to_vec()"
        let v107 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v103 v106 
        let v109 : string = $"%A{v107}"
        let v112 : string = method24(v53, v54, v55, v56, v57, v58, v71, v72, v3, v1, v2, v7, v6, v5, v74, v78, v80, v82, v86, v90, v92, v96, v109)
        method16(v112)
and method25 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method25(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method26 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method26(v3, v1)
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
                let v9 : (unit -> UH1) = method27(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US6 = US6_1(v12)
        v1.l0 <- v13
        v12
and method27 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US6 = US6_0(v1)
    let v3 : Mut5 = {l0 = v2} : Mut5
    closure18(v0, v3)
and method29 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method12()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure6(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "max"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure6(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure6(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "p"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure6(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure6(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure6(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "n"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure6(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure6(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v10}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure6(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = " }"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure6(v12, v241)
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
    method15(v301)
and closure19 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure2()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method7(v42, v43, v44, v45, v46, v47)
        let v61 : string = method11()
        let v62 : string = method29(v42, v43, v44, v45, v46, v47, v60, v61, v0, v2, v1)
        method16(v62)
and method28 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method28(v0, v6, v4)
        else
            let v68 : unit = ()
            let v69 : (unit -> unit) = closure19(v0, v1, v2)
            let v70 : unit = (fun () -> v69 (); v68) ()
            v1
    else
        let v192 : unit = ()
        let v193 : (unit -> unit) = closure19(v0, v1, v2)
        let v194 : unit = (fun () -> v193 (); v192) ()
        v1
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method12()
    let v13 : Mut3 = {l0 = v12} : Mut3
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure6(v13, v17)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v35 : string = "current_index"
    let v36 : string = $"{v35}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v13, v36)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v54 : string = " = "
    let v55 : string = $"{v54}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure6(v13, v55)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v75 : string = $"{v8}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure6(v13, v75)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v93 : string = "; "
    let v94 : string = $"{v93}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v13, v94)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v112 : string = "acc"
    let v113 : string = $"{v112}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure6(v13, v113)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v130 : string = $"{v54}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure6(v13, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v150 : string = $"{v9}"
    let v158 : unit = ()
    let v159 : (unit -> unit) = closure6(v13, v150)
    let v160 : unit = (fun () -> v159 (); v158) ()
    let v167 : string = $"{v93}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure6(v13, v167)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v185 : string = "len"
    let v186 : string = $"{v185}"
    let v194 : unit = ()
    let v195 : (unit -> unit) = closure6(v13, v186)
    let v196 : unit = (fun () -> v195 (); v194) ()
    let v203 : string = $"{v54}"
    let v211 : unit = ()
    let v212 : (unit -> unit) = closure6(v13, v203)
    let v213 : unit = (fun () -> v212 (); v211) ()
    let v223 : string = $"{v10}"
    let v231 : unit = ()
    let v232 : (unit -> unit) = closure6(v13, v223)
    let v233 : unit = (fun () -> v232 (); v231) ()
    let v240 : string = $"{v93}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure6(v13, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v258 : string = "last_item"
    let v259 : string = $"{v258}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure6(v13, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v54}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure6(v13, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v293 : string = $"{v11}"
    let v301 : unit = ()
    let v302 : (unit -> unit) = closure6(v13, v293)
    let v303 : unit = (fun () -> v302 (); v301) ()
    let v311 : string = " }"
    let v312 : string = $"{v311}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure6(v13, v312)
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
    method15(v372)
and closure20 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v20 : unit = ()
        let v21 : (unit -> unit) = closure2()
        let v22 : unit = (fun () -> v21 (); v20) ()
        let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
        let v61 : string = method7(v43, v44, v45, v46, v47, v48)
        let v62 : string = method11()
        let v64 : string = $"%A{v3}"
        let v67 : string = method32(v43, v44, v45, v46, v47, v48, v61, v62, v0, v1, v2, v64)
        method16(v67)
and method33 (v0 : int64, v1 : UH1) : US7 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US7_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method33(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US7_1
and method34 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method12()
    let v9 : Mut3 = {l0 = v8} : Mut3
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
    method15(v54)
and closure21 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure2()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = TraceState.trace_state.Value
        let v57 : string = method7(v39, v40, v41, v42, v43, v44)
        let v58 : string = method11()
        let v59 : string = method34(v39, v40, v41, v42, v43, v44, v57, v58)
        method16(v59)
and method31 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US7 = v4.l0
    let v19 : uint8 option =
        match v8 with
        | US7_1 -> (* None *)
            let v15 : uint8 option = None
            v15
        | US7_0(v9) -> (* Some *)
            let v11 : uint8 option = Some v9 
            v11
    let v84 : unit = ()
    let v85 : (unit -> unit) = closure20(v5, v6, v7, v19)
    let v86 : unit = (fun () -> v85 (); v84) ()
    let v151 : UH1 = v0 ()
    let v152 : int64 = v1.l0
    let v153 : US7 = method33(v152, v151)
    match v153 with
    | US7_1 -> (* None *)
        let v218 : unit = ()
        let v219 : (unit -> unit) = closure21()
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
        let v292 : US7 = US7_1
        v4.l0 <- v292
        method31(v0, v1, v2, v3, v4)
    | US7_0(v154) -> (* Some *)
        let v155 : int64 = v1.l0
        let v156 : int64 = v155 + 1L
        v1.l0 <- v156
        let v157 : US7 = US7_0(v154)
        v4.l0 <- v157
        v154
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method12()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure6(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure6(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure6(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure6(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure6(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure6(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "result"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure6(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure6(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v10}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure6(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = " }"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure6(v12, v241)
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
    method15(v301)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure2()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method7(v42, v43, v44, v45, v46, v47)
        let v61 : string = method11()
        let v62 : string = method36(v42, v43, v44, v45, v46, v47, v60, v61, v1, v0, v2)
        method16(v62)
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
and method37 (v0 : int8, v1 : UH2) : US9 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US9_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method37(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US9_1
and method38 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method12()
    let v13 : Mut3 = {l0 = v12} : Mut3
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure6(v13, v17)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v35 : string = "power"
    let v36 : string = $"{v35}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v13, v36)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v54 : string = " = "
    let v55 : string = $"{v54}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure6(v13, v55)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v75 : string = $"{v8}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure6(v13, v75)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v93 : string = "; "
    let v94 : string = $"{v93}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v13, v94)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v112 : string = "acc"
    let v113 : string = $"{v112}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure6(v13, v113)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v130 : string = $"{v54}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure6(v13, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v150 : string = $"{v9}"
    let v158 : unit = ()
    let v159 : (unit -> unit) = closure6(v13, v150)
    let v160 : unit = (fun () -> v159 (); v158) ()
    let v167 : string = $"{v93}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure6(v13, v167)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v185 : string = "roll"
    let v186 : string = $"{v185}"
    let v194 : unit = ()
    let v195 : (unit -> unit) = closure6(v13, v186)
    let v196 : unit = (fun () -> v195 (); v194) ()
    let v203 : string = $"{v54}"
    let v211 : unit = ()
    let v212 : (unit -> unit) = closure6(v13, v203)
    let v213 : unit = (fun () -> v212 (); v211) ()
    let v223 : string = $"{v10}"
    let v231 : unit = ()
    let v232 : (unit -> unit) = closure6(v13, v223)
    let v233 : unit = (fun () -> v232 (); v231) ()
    let v240 : string = $"{v93}"
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure6(v13, v240)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v258 : string = "value"
    let v259 : string = $"{v258}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure6(v13, v259)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v276 : string = $"{v54}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure6(v13, v276)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v296 : string = $"{v11}"
    let v304 : unit = ()
    let v305 : (unit -> unit) = closure6(v13, v296)
    let v306 : unit = (fun () -> v305 (); v304) ()
    let v314 : string = " }"
    let v315 : string = $"{v314}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure6(v13, v315)
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
    method15(v375)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v20 : unit = ()
        let v21 : (unit -> unit) = closure2()
        let v22 : unit = (fun () -> v21 (); v20) ()
        let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
        let v61 : string = method7(v43, v44, v45, v46, v47, v48)
        let v62 : string = method11()
        let v63 : string = method38(v43, v44, v45, v46, v47, v48, v61, v62, v1, v0, v2, v3)
        method16(v63)
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method12()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure6(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "power"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure6(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure6(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "acc"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure6(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v149 : string = $"{v9}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure6(v12, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v92}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure6(v12, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v184 : string = "roll"
    let v185 : string = $"{v184}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure6(v12, v185)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v202 : string = $"{v53}"
    let v210 : unit = ()
    let v211 : (unit -> unit) = closure6(v12, v202)
    let v212 : unit = (fun () -> v211 (); v210) ()
    let v222 : string = $"{v10}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure6(v12, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v240 : string = " }"
    let v241 : string = $"{v240}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure6(v12, v241)
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
    method15(v301)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure2()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method7(v42, v43, v44, v45, v46, v47)
        let v61 : string = method11()
        let v62 : string = method39(v42, v43, v44, v45, v46, v47, v60, v61, v1, v0, v2)
        method16(v62)
and method35 (v0 : int8, v1 : UH0, v2 : uint64) : US8 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure22(v2, v0, v4)
        let v67 : unit = (fun () -> v66 (); v65) ()
        US8_0(v4, v1)
    else
        match v1 with
        | UH0_1(v130, v131) -> (* Cons *)
            let v132 : bool = v130 > 1uy
            if v132 then
                let v133 : uint64 = 1UL
                let v134 : (unit -> UH2) = closure23()
                let v135 : UH2 = UH2_0(v133, v134)
                let v136 : US9 = method37(v0, v135)
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
                method35(v268, v131, v267)
            else
                let v330 : unit = ()
                let v331 : (unit -> unit) = closure88(v2, v0, v130)
                let v332 : unit = (fun () -> v331 (); v330) ()
                let v393 : int8 = v0 - 1y
                method35(v393, v131, v2)
        | UH0_0 -> (* Nil *)
            US8_1
and method40 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut6, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method31(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method40(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method41 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method31(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method30(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US8 = method35(v6, v7, v13)
        match v14 with
        | US8_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method40(v6, v0, v1, v2, v3, v4, v18)
                method41(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method40(v6, v0, v1, v2, v3, v4, v22)
            method41(v0, v1, v2, v3, v4, v5, v6, v23)
and method30 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method31(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method30(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US8 = method35(v6, v7, v15)
        match v16 with
        | US8_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method40(v6, v0, v1, v2, v3, v4, v20)
                method41(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method40(v6, v0, v1, v2, v3, v4, v24)
            method41(v0, v1, v2, v3, v4, v5, v6, v25)
and method42 () : (unit -> unit) =
    closure10()
and closure89 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure2()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        method18()
and method43 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method43(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method44 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method12()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v15 : string = "{ "
    let v16 : string = $"{v15}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure6(v12, v16)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v34 : string = "max"
    let v35 : string = $"{v34}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v12, v35)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v53 : string = " = "
    let v54 : string = $"{v53}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v12, v54)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v74 : string = $"{v8}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure6(v12, v74)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v92 : string = "; "
    let v93 : string = $"{v92}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure6(v12, v93)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v111 : string = "rolls"
    let v112 : string = $"{v111}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v12, v112)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v129 : string = $"{v53}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure6(v12, v129)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v146 : string = $"{v9}"
    let v154 : unit = ()
    let v155 : (unit -> unit) = closure6(v12, v146)
    let v156 : unit = (fun () -> v155 (); v154) ()
    let v163 : string = $"{v92}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure6(v12, v163)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v181 : string = "result"
    let v182 : string = $"{v181}"
    let v190 : unit = ()
    let v191 : (unit -> unit) = closure6(v12, v182)
    let v192 : unit = (fun () -> v191 (); v190) ()
    let v199 : string = $"{v53}"
    let v207 : unit = ()
    let v208 : (unit -> unit) = closure6(v12, v199)
    let v209 : unit = (fun () -> v208 (); v207) ()
    let v216 : string = $"{v10}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure6(v12, v216)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v234 : string = " }"
    let v235 : string = $"{v234}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure6(v12, v235)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v251 : string = v12.l0
    let v252 : int64 = v0.l0
    let v255 : string = " "
    let v256 : string = v6 + v255 
    let v260 : string = v256 + v7 
    let v265 : string = " #"
    let v266 : string = v260 + v265 
    let v270 : (int64 -> string) = _.ToString()
    let v271 : string = v270 v252
    let v275 : string = v266 + v271 
    let v279 : string = v275 + v255 
    let v284 : string = "dice_contract.roll_within_bounds"
    let v285 : string = v279 + v284 
    let v290 : string = " / "
    let v291 : string = v285 + v290 
    let v295 : string = v291 + v251 
    method15(v295)
and closure90 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v19 : unit = ()
        let v20 : (unit -> unit) = closure2()
        let v21 : unit = (fun () -> v20 (); v19) ()
        let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
        let v60 : string = method7(v42, v43, v44, v45, v46, v47)
        let v61 : string = method11()
        let v63 : string = $"%A{v1}"
        let v67 : string = $"%A{v2}"
        let v70 : string = method44(v42, v43, v44, v45, v46, v47, v60, v61, v0, v63, v67)
        method16(v70)
and method45 () : (unit -> unit) =
    closure10()
and closure91 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure2()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        method18()
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
        let v161 : unit = ()
        let v162 : (unit -> unit) = closure1(v93, v96)
        let v163 : unit = (fun () -> v162 (); v161) ()
        ()
    let v228 : (unit -> unit) = method17()
    let v288 : unit = ()
    let v289 : (unit -> unit) = closure11(v228)
    let v290 : unit = (fun () -> v289 (); v288) ()
    let v350 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v350 
    let v351 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v351 
    let v352 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v352 
    let v353 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v353 
    let v354 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v355 : bool = Fable.Core.RustInterop.emitRustExpr () v354 
    let v356 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v357 : bool = Fable.Core.RustInterop.emitRustExpr () v356 
    let v358 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v358 
    let v359 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v359 
    let v360 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v360 
    let v361 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v361 
    let v362 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v362 
    let v363 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v363 
    let v364 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v365 : bool = Fable.Core.RustInterop.emitRustExpr () v364 
    let v366 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v367 : bool = Fable.Core.RustInterop.emitRustExpr () v366 
    let v368 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v368 
    let v369 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v369 
    let v370 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v370 
    let v371 : string = $"key"
    let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v371 
    let v373 : string = $"proof"
    let v374 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v373 
    let v375 : string = $"max"
    let v376 : uint64 = Fable.Core.RustInterop.emitRustExpr () v375 
    let v377 : string = $"&mut self.0.1"
    let v378 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v377 
    let v379 : string = $"near_sdk::env::random_seed()"
    let v380 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v379 
    let v381 : string = $"near_sdk::env::epoch_height()"
    let v382 : uint64 = Fable.Core.RustInterop.emitRustExpr () v381 
    let v383 : string = $"near_sdk::env::block_height()"
    let v384 : uint64 = Fable.Core.RustInterop.emitRustExpr () v383 
    let v385 : string = $"near_sdk::env::block_timestamp()"
    let v386 : uint64 = Fable.Core.RustInterop.emitRustExpr () v385 
    let v387 : string = $"near_sdk::env::account_balance()"
    let v388 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v387 
    let v389 : string = $"near_sdk::env::signer_account_id()"
    let v390 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v389 
    let v391 : string = $"near_sdk::env::predecessor_account_id()"
    let v392 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v391 
    let v393 : string = $"&*v378"
    let v394 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v393 
    let v395 : string = $"v394.iter().map(|x| *x).collect::<Vec<_>>()"
    let v396 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v395 
    let v397 : string = $"v382.to_le_bytes()"
    let v398 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v397 
    let v399 : string = $"v398.to_vec()"
    let v400 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v399 
    let v401 : string = $"v384.to_le_bytes()"
    let v402 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v401 
    let v403 : string = $"v402.to_vec()"
    let v404 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v403 
    let v405 : string = $"v386.to_le_bytes()"
    let v406 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v405 
    let v407 : string = $"v406.to_vec()"
    let v408 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v407 
    let v409 : string = "$0.as_yoctonear()"
    let v410 : u128 = Fable.Core.RustInterop.emitRustExpr v388 v409 
    let v411 : string = $"v410.to_le_bytes()"
    let v412 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v411 
    let v413 : string = $"v412.to_vec()"
    let v414 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v413 
    let v415 : string = $"v390.as_bytes()"
    let v416 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v415 
    let v417 : string = $"v416.to_vec()"
    let v418 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v417 
    let v419 : string = $"v392.as_bytes()"
    let v420 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v419 
    let v421 : string = $"v420.to_vec()"
    let v422 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v421 
    let v423 : string = $"$0.into_bytes()"
    let v424 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v374 v423 
    let v425 : string = $"$0.into_bytes()"
    let v426 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v372 v425 
    let v427 : (Vec<uint8> []) = [|v380; v396; v400; v404; v408; v414; v418; v422; v424; v426|]
    let v428 : string = "$0.to_vec()"
    let v429 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v427 v428 
    let v430 : string = $"v429.concat()"
    let v431 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v430 
    let v432 : string = $"near_sdk::env::keccak512(&$0)"
    let v433 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v431 v432 
    let v434 : string = "true; v378.extend($0); //"
    let v435 : bool = Fable.Core.RustInterop.emitRustExpr v433 v434 
    let v436 : string = $"v378.len()"
    let v437 : uint32 = Fable.Core.RustInterop.emitRustExpr () v436 
    let v443 : int32 = v437 |> int32 
    let v452 : unativeint = 100 |> unativeint 
    let v460 : int32 = v452 |> int32 
    let v468 : int32 = v443 - v460
    let v469 : bool = v468 > 0
    if v469 then
        let v470 : string = "v378.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v471 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v468 v470 
        let v536 : unit = ()
        let v537 : (unit -> unit) = closure1(v468, v471)
        let v538 : unit = (fun () -> v537 (); v536) ()
        ()
    let v603 : (unit -> unit) = method17()
    let v663 : unit = ()
    let v664 : (unit -> unit) = closure11(v603)
    let v665 : unit = (fun () -> v664 (); v663) ()
    let v725 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v726 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v433 v725 
    let v728 : uint8 list = v726 |> Array.toList
    let v736 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v737 : (uint8 -> (UH0 -> UH0)) = method19()
    let v738 : (uint8 list -> (UH0 -> UH0)) = v736 v737
    let v739 : (UH0 -> UH0) = v738 v728
    let v740 : UH0 = UH0_0
    let v741 : UH0 = v739 v740
    let v770 : UH1 = UH1_1
    let v771 : UH1 = method20(v741, v770)
    let v772 : UH1 = UH1_1
    let v773 : UH1 = method21(v771, v772)
    let v774 : UH0 = UH0_0
    let v775 : UH0 = method22(v773, v774)
    let v875 : unit = ()
    let v876 : (unit -> unit) = closure16(v378, v372, v374, v376, v380, v382, v384, v386, v388, v390, v392, v431, v433, v775)
    let v877 : unit = (fun () -> v876 (); v875) ()
    let v977 : UH0 = UH0_0
    let v978 : UH0 = method25(v775, v977)
    let v979 : UH0 = method26(v775, v978)
    let v980 : UH1 = UH1_1
    let v981 : UH1 = method20(v979, v980)
    let v982 : (unit -> UH1) = closure17(v981)
    let v983 : (unit -> UH1) = method27(v981, v982)
    let v984 : Mut0 = {l0 = 0L} : Mut0
    let v985 : Mut0 = {l0 = 1L} : Mut0
    let v986 : Mut0 = {l0 = -1L} : Mut0
    let v987 : US7 = US7_1
    let v988 : Mut6 = {l0 = v987} : Mut6
    let v989 : bool = v376 = 1UL
    let v993 : int8 =
        if v989 then
            1y
        else
            let v990 : int8 = 0y
            let v991 : uint64 = 1UL
            method28(v376, v990, v991)
    let v994 : int8 = v993 - 1y
    let v995 : UH0 = UH0_0
    let v996 : int8 = 0y
    let v997 : uint64 = method30(v983, v984, v985, v986, v988, v376, v994, v995, v996)
    let v998 : (unit -> unit) = method42()
    let v1058 : unit = ()
    let v1059 : (unit -> unit) = closure89(v998)
    let v1060 : unit = (fun () -> v1059 (); v1058) ()
    let v1120 : string = "v997 //"
    Fable.Core.RustInterop.emitRustExpr () v1120 
    let v1121 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1121 
    let v1122 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1122 
    let v1123 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1123 
    let v1124 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1124 
    let v1125 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v1126 : bool = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v1128 : bool = Fable.Core.RustInterop.emitRustExpr () v1127 
    let v1129 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1129 
    let v1130 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1130 
    let v1131 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v1131 
    let v1132 : string = $"max"
    let v1133 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1132 
    let v1134 : string = $"rolls"
    let v1135 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1134 
    let v1136 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v1137 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v1135 v1136 
    let v1139 : uint8 list = v1137 |> Array.toList
    let v1147 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v1148 : (uint8 -> (UH0 -> UH0)) = method19()
    let v1149 : (uint8 list -> (UH0 -> UH0)) = v1147 v1148
    let v1150 : (UH0 -> UH0) = v1149 v1139
    let v1151 : UH0 = UH0_0
    let v1152 : UH0 = v1150 v1151
    let v1181 : int8 = 0y
    let v1182 : int8 = method43(v1152, v1181)
    let v1183 : int8 = v1182 - 1y
    let v1184 : uint64 = 0UL
    let v1185 : US8 = method35(v1183, v1152, v1184)
    let v1195 : US9 =
        match v1185 with
        | US8_0(v1186, v1187) -> (* Some *)
            let v1188 : bool = v1186 >= 1UL
            let v1190 : bool =
                if v1188 then
                    let v1189 : bool = v1186 <= v1133
                    v1189
                else
                    false
            if v1190 then
                US9_0(v1186)
            else
                US9_1
        | _ ->
            US9_1
    let v1206 : uint64 option =
        match v1195 with
        | US9_1 -> (* None *)
            let v1202 : uint64 option = None
            v1202
        | US9_0(v1196) -> (* Some *)
            let v1198 : uint64 option = Some v1196 
            v1198
    let v1275 : unit = ()
    let v1276 : (unit -> unit) = closure90(v1133, v1135, v1206)
    let v1277 : unit = (fun () -> v1276 (); v1275) ()
    let v1346 : (unit -> unit) = method45()
    let v1406 : unit = ()
    let v1407 : (unit -> unit) = closure91(v1346)
    let v1408 : unit = (fun () -> v1407 (); v1406) ()
    let v1468 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v1206 v1468 
    let v1469 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1469 
    let v1470 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1470 
    let v1471 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1471 
    let v1472 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v1473 : bool = Fable.Core.RustInterop.emitRustExpr () v1472 
    let v1474 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v1475 : bool = Fable.Core.RustInterop.emitRustExpr () v1474 
    let v1476 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1476 
    let v1477 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1477 
    let v1478 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v1478 
    let v1479 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v1479 
    let v1480 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1480 
    let v1481 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v1481 
    let v1482 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v1482 
    let v1483 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v1483 
    let v1484 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v1484 
    let v1485 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1485 
    let v1486 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1486 
    let v1487 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v1488 : bool = Fable.Core.RustInterop.emitRustExpr () v1487 
    let v1489 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v1490 : bool = Fable.Core.RustInterop.emitRustExpr () v1489 
    let v1491 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v1491 
    let v1492 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v1492 
    let v1493 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v1494 : bool = Fable.Core.RustInterop.emitRustExpr () v1493 
    let v1495 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v1496 : bool = Fable.Core.RustInterop.emitRustExpr () v1495 
    let v1497 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v1498 : bool = Fable.Core.RustInterop.emitRustExpr () v1497 
    let v1499 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v1500 : bool = Fable.Core.RustInterop.emitRustExpr () v1499 
    let v1501 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v1502 : bool = Fable.Core.RustInterop.emitRustExpr () v1501 
    let v1503 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v1504 : bool = Fable.Core.RustInterop.emitRustExpr () v1503 
    let v1505 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v1506 : bool = Fable.Core.RustInterop.emitRustExpr () v1505 
    let v1507 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v1508 : bool = Fable.Core.RustInterop.emitRustExpr () v1507 
    let v1509 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v1510 : bool = Fable.Core.RustInterop.emitRustExpr () v1509 
    let v1511 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v1512 : bool = Fable.Core.RustInterop.emitRustExpr () v1511 
    let v1513 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v1514 : bool = Fable.Core.RustInterop.emitRustExpr () v1513 
    let v1515 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v1516 : bool = Fable.Core.RustInterop.emitRustExpr () v1515 
    let v1517 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v1518 : bool = Fable.Core.RustInterop.emitRustExpr () v1517 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
