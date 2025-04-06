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

type IOsEnviron = abstract environ: x: unit -> obj
module TraceState = let mutable trace_state = None
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
    | US4_6 of f6_0 : US3
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
    let v20 : US4 = US4_4(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US3 = US3_2
    let v24 : US4 = US4_4(v23)
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
    let v210 : US2 =
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
            let v204 : int64 = v182 |> int64 
            US2_0(v204)
    struct (v127, v210)
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
    let v174 : US2 =
        if v162 then
            US2_1
        else
            let v166 : string = $"near_sdk::env::block_timestamp()"
            let v167 : uint64 = Fable.Core.RustInterop.emitRustExpr () v166 
            let v169 : (uint64 -> int64) = int64
            let v170 : int64 = v169 v167
            US2_0(v170)
    let v175 : US1 = US1_1
    let _run_target_args'_v3 = struct (v175, v174) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v176 : US1, v177 : US2) = method2()
    let _run_target_args'_v3 = struct (v176, v177) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v178 : US1, v179 : US2) = method2()
    let _run_target_args'_v3 = struct (v178, v179) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v180 : US1, v181 : US2) = method2()
    let _run_target_args'_v3 = struct (v180, v181) 
    #endif
#else
    let struct (v182 : US1, v183 : US2) = method2()
    let _run_target_args'_v3 = struct (v182, v183) 
    #endif
    let struct (v184 : US1, v185 : US2) = _run_target_args'_v3 
    let v190 : Mut0 = {l0 = 1L} : Mut0
    let v191 : (string -> unit) = closure4()
    let v192 : Mut1 = {l0 = v191} : Mut1
    let v193 : Mut2 = {l0 = true} : Mut2
    let v194 : string = ""
    let v195 : Mut3 = {l0 = v194} : Mut3
    let v198 : US0 =
        match v184 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v196) -> (* Some *)
            v196
    let v199 : Mut4 = {l0 = v198} : Mut4
    let v210 : int64 option =
        match v185 with
        | US2_1 -> (* None *)
            let v206 : int64 option = None
            v206
        | US2_0(v200) -> (* Some *)
            let v202 : int64 option = Some v200 
            v202
    struct (v190, v192, v193, v195, v199, v210)
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
    let v195 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : (int64 -> US2) = method8()
    let v199 : US2 option = v5 |> Option.map v198 
    let v219 : US2 = US2_1
    let v220 : US2 = v199 |> Option.defaultValue v219 
    let v360 : System.DateTime =
        match v220 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v343 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v344 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v344 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v345 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v347 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v343 = v347 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v350 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v351 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v352 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v352 
            #endif
#else
            let v353 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v353 
            #endif
            let v354 : System.DateTime = _run_target_args'_v343 
            v354
        | US2_0(v224) -> (* Some *)
            (* run_target_args'
            let v231 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v232 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v232 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v233 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v233 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v235 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v231 = v235 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v239 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v240 
            #endif
#else
            let v241 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v241 
            #endif
            let v242 : System.DateTime = _run_target_args'_v231 
            (* run_target_args'
            let v253 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v254 : (System.DateTime -> int64) = _.Ticks
            let v255 : int64 = v254 v242
            let _run_target_args'_v253 = v255 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v256 : (System.DateTime -> int64) = _.Ticks
            let v257 : int64 = v256 v242
            let _run_target_args'_v253 = v257 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v259 : int64 = null |> unbox<int64>
            let _run_target_args'_v253 = v259 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v262 : (System.DateTime -> int64) = _.Ticks
            let v263 : int64 = v262 v242
            let _run_target_args'_v253 = v263 
            #endif
#if FABLE_COMPILER_PYTHON
            let v264 : (System.DateTime -> int64) = _.Ticks
            let v265 : int64 = v264 v242
            let _run_target_args'_v253 = v265 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v266 : (System.DateTime -> int64) = _.Ticks
            let v267 : int64 = v266 v242
            let _run_target_args'_v253 = v267 
            #endif
#else
            let v268 : (System.DateTime -> int64) = _.Ticks
            let v269 : int64 = v268 v242
            let _run_target_args'_v253 = v269 
            #endif
            let v270 : int64 = _run_target_args'_v253 
            let v292 : int64 = v270 |> int64 
            let v297 : int64 = v292 - v224
            let v303 : System.TimeSpan = v297 |> System.TimeSpan 
            let v309 : (System.TimeSpan -> int32) = _.Hours
            let v310 : int32 = v309 v303
            let v314 : (System.TimeSpan -> int32) = _.Minutes
            let v315 : int32 = v314 v303
            let v319 : (System.TimeSpan -> int32) = _.Seconds
            let v320 : int32 = v319 v303
            let v324 : (System.TimeSpan -> int32) = _.Milliseconds
            let v325 : int32 = v324 v303
            let v334 : System.DateTime = System.DateTime (1, 1, 1, v310, v315, v320, v325)
            v334
    let v361 : string = method9()
    let v363 : bool = v361 = ""
    let v365 : string =
        if v363 then
            let v364 : string = "M-d-y hh:mm:ss tt"
            v364
        else
            v361
    let v366 : (string -> string) = v360.ToString
    let v367 : string = v366 v365
    let _run_target_args'_v195 = v367 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v384 : (int64 -> US2) = method8()
    let v385 : US2 option = v5 |> Option.map v384 
    let v405 : US2 = US2_1
    let v406 : US2 = v385 |> Option.defaultValue v405 
    let v546 : System.DateTime =
        match v406 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v529 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v530 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v530 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v531 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v531 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v529 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v538 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v538 
            #endif
#else
            let v539 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v539 
            #endif
            let v540 : System.DateTime = _run_target_args'_v529 
            v540
        | US2_0(v410) -> (* Some *)
            (* run_target_args'
            let v417 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v418 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v418 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v419 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v419 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v417 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v424 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v424 
            #endif
#if FABLE_COMPILER_PYTHON
            let v425 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v425 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v426 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v426 
            #endif
#else
            let v427 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v427 
            #endif
            let v428 : System.DateTime = _run_target_args'_v417 
            (* run_target_args'
            let v439 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v428
            let _run_target_args'_v439 = v441 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v442 : (System.DateTime -> int64) = _.Ticks
            let v443 : int64 = v442 v428
            let _run_target_args'_v439 = v443 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v445 : int64 = null |> unbox<int64>
            let _run_target_args'_v439 = v445 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v448 : (System.DateTime -> int64) = _.Ticks
            let v449 : int64 = v448 v428
            let _run_target_args'_v439 = v449 
            #endif
#if FABLE_COMPILER_PYTHON
            let v450 : (System.DateTime -> int64) = _.Ticks
            let v451 : int64 = v450 v428
            let _run_target_args'_v439 = v451 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v452 : (System.DateTime -> int64) = _.Ticks
            let v453 : int64 = v452 v428
            let _run_target_args'_v439 = v453 
            #endif
#else
            let v454 : (System.DateTime -> int64) = _.Ticks
            let v455 : int64 = v454 v428
            let _run_target_args'_v439 = v455 
            #endif
            let v456 : int64 = _run_target_args'_v439 
            let v478 : int64 = v456 |> int64 
            let v483 : int64 = v478 - v410
            let v489 : System.TimeSpan = v483 |> System.TimeSpan 
            let v495 : (System.TimeSpan -> int32) = _.Hours
            let v496 : int32 = v495 v489
            let v500 : (System.TimeSpan -> int32) = _.Minutes
            let v501 : int32 = v500 v489
            let v505 : (System.TimeSpan -> int32) = _.Seconds
            let v506 : int32 = v505 v489
            let v510 : (System.TimeSpan -> int32) = _.Milliseconds
            let v511 : int32 = v510 v489
            let v520 : System.DateTime = System.DateTime (1, 1, 1, v496, v501, v506, v511)
            v520
    let v547 : string = method9()
    let v549 : bool = v547 = ""
    let v551 : string =
        if v549 then
            let v550 : string = "M-d-y hh:mm:ss tt"
            v550
        else
            v547
    let v552 : (string -> string) = v546.ToString
    let v553 : string = v552 v551
    let _run_target_args'_v195 = v553 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v568 : string = $"near_sdk::env::block_timestamp()"
    let v569 : uint64 = Fable.Core.RustInterop.emitRustExpr () v568 
    let v572 : (int64 -> US2) = method8()
    let v573 : US2 option = v5 |> Option.map v572 
    let v593 : US2 = US2_1
    let v594 : US2 = v573 |> Option.defaultValue v593 
    let v606 : uint64 =
        match v594 with
        | US2_1 -> (* None *)
            v569
        | US2_0(v598) -> (* Some *)
            let v600 : (int64 -> uint64) = uint64
            let v601 : uint64 = v600 v598
            let v604 : uint64 = v569 - v601
            v604
    let v607 : uint64 = v606 / 1000000000UL
    let v608 : uint64 = v607 % 60UL
    let v609 : uint64 = v607 / 60UL
    let v610 : uint64 = v609 % 60UL
    let v611 : uint64 = v607 / 3600UL
    let v612 : uint64 = v611 % 24UL
    let v613 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v612, v610, v608) v613 
    let v615 : string = "fable_library_rust::String_::fromString($0)"
    let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
    let _run_target_args'_v195 = v616 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : (int64 -> US2) = method8()
    let v620 : US2 option = v5 |> Option.map v619 
    let v640 : US2 = US2_1
    let v641 : US2 = v620 |> Option.defaultValue v640 
    let v781 : System.DateTime =
        match v641 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v764 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v765 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v765 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v766 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v766 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v768 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v764 = v768 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v771 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v771 
            #endif
#if FABLE_COMPILER_PYTHON
            let v772 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v772 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v773 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v773 
            #endif
#else
            let v774 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v774 
            #endif
            let v775 : System.DateTime = _run_target_args'_v764 
            v775
        | US2_0(v645) -> (* Some *)
            (* run_target_args'
            let v652 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v653 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v654 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v654 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v656 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v652 = v656 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v659 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v659 
            #endif
#if FABLE_COMPILER_PYTHON
            let v660 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v660 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v661 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v661 
            #endif
#else
            let v662 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v662 
            #endif
            let v663 : System.DateTime = _run_target_args'_v652 
            (* run_target_args'
            let v674 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v675 : (System.DateTime -> int64) = _.Ticks
            let v676 : int64 = v675 v663
            let _run_target_args'_v674 = v676 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v677 : (System.DateTime -> int64) = _.Ticks
            let v678 : int64 = v677 v663
            let _run_target_args'_v674 = v678 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v680 : int64 = null |> unbox<int64>
            let _run_target_args'_v674 = v680 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v683 : (System.DateTime -> int64) = _.Ticks
            let v684 : int64 = v683 v663
            let _run_target_args'_v674 = v684 
            #endif
#if FABLE_COMPILER_PYTHON
            let v685 : (System.DateTime -> int64) = _.Ticks
            let v686 : int64 = v685 v663
            let _run_target_args'_v674 = v686 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v687 : (System.DateTime -> int64) = _.Ticks
            let v688 : int64 = v687 v663
            let _run_target_args'_v674 = v688 
            #endif
#else
            let v689 : (System.DateTime -> int64) = _.Ticks
            let v690 : int64 = v689 v663
            let _run_target_args'_v674 = v690 
            #endif
            let v691 : int64 = _run_target_args'_v674 
            let v713 : int64 = v691 |> int64 
            let v718 : int64 = v713 - v645
            let v724 : System.TimeSpan = v718 |> System.TimeSpan 
            let v730 : (System.TimeSpan -> int32) = _.Hours
            let v731 : int32 = v730 v724
            let v735 : (System.TimeSpan -> int32) = _.Minutes
            let v736 : int32 = v735 v724
            let v740 : (System.TimeSpan -> int32) = _.Seconds
            let v741 : int32 = v740 v724
            let v745 : (System.TimeSpan -> int32) = _.Milliseconds
            let v746 : int32 = v745 v724
            let v755 : System.DateTime = System.DateTime (1, 1, 1, v731, v736, v741, v746)
            v755
    let v782 : string = method10()
    let v784 : bool = v782 = ""
    let v786 : string =
        if v784 then
            let v785 : string = "M-d-y hh:mm:ss tt"
            v785
        else
            v782
    let v787 : (string -> string) = v781.ToString
    let v788 : string = v787 v786
    let _run_target_args'_v195 = v788 
    #endif
#if FABLE_COMPILER_PYTHON
    let v805 : (int64 -> US2) = method8()
    let v806 : US2 option = v5 |> Option.map v805 
    let v826 : US2 = US2_1
    let v827 : US2 = v806 |> Option.defaultValue v826 
    let v967 : System.DateTime =
        match v827 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v950 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v951 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v951 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v952 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v952 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v954 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v950 = v954 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v957 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v957 
            #endif
#if FABLE_COMPILER_PYTHON
            let v958 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v958 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v959 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v959 
            #endif
#else
            let v960 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v960 
            #endif
            let v961 : System.DateTime = _run_target_args'_v950 
            v961
        | US2_0(v831) -> (* Some *)
            (* run_target_args'
            let v838 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v839 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v839 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v840 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v840 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v842 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v838 = v842 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v845 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v845 
            #endif
#if FABLE_COMPILER_PYTHON
            let v846 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v846 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v847 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v847 
            #endif
#else
            let v848 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v848 
            #endif
            let v849 : System.DateTime = _run_target_args'_v838 
            (* run_target_args'
            let v860 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v861 : (System.DateTime -> int64) = _.Ticks
            let v862 : int64 = v861 v849
            let _run_target_args'_v860 = v862 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v863 : (System.DateTime -> int64) = _.Ticks
            let v864 : int64 = v863 v849
            let _run_target_args'_v860 = v864 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v866 : int64 = null |> unbox<int64>
            let _run_target_args'_v860 = v866 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v869 : (System.DateTime -> int64) = _.Ticks
            let v870 : int64 = v869 v849
            let _run_target_args'_v860 = v870 
            #endif
#if FABLE_COMPILER_PYTHON
            let v871 : (System.DateTime -> int64) = _.Ticks
            let v872 : int64 = v871 v849
            let _run_target_args'_v860 = v872 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v873 : (System.DateTime -> int64) = _.Ticks
            let v874 : int64 = v873 v849
            let _run_target_args'_v860 = v874 
            #endif
#else
            let v875 : (System.DateTime -> int64) = _.Ticks
            let v876 : int64 = v875 v849
            let _run_target_args'_v860 = v876 
            #endif
            let v877 : int64 = _run_target_args'_v860 
            let v899 : int64 = v877 |> int64 
            let v904 : int64 = v899 - v831
            let v910 : System.TimeSpan = v904 |> System.TimeSpan 
            let v916 : (System.TimeSpan -> int32) = _.Hours
            let v917 : int32 = v916 v910
            let v921 : (System.TimeSpan -> int32) = _.Minutes
            let v922 : int32 = v921 v910
            let v926 : (System.TimeSpan -> int32) = _.Seconds
            let v927 : int32 = v926 v910
            let v931 : (System.TimeSpan -> int32) = _.Milliseconds
            let v932 : int32 = v931 v910
            let v941 : System.DateTime = System.DateTime (1, 1, 1, v917, v922, v927, v932)
            v941
    let v968 : string = method10()
    let v970 : bool = v968 = ""
    let v972 : string =
        if v970 then
            let v971 : string = "M-d-y hh:mm:ss tt"
            v971
        else
            v968
    let v973 : (string -> string) = v967.ToString
    let v974 : string = v973 v972
    let _run_target_args'_v195 = v974 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v991 : (int64 -> US2) = method8()
    let v992 : US2 option = v5 |> Option.map v991 
    let v1012 : US2 = US2_1
    let v1013 : US2 = v992 |> Option.defaultValue v1012 
    let v1153 : System.DateTime =
        match v1013 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1136 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1137 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1137 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1138 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1138 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1140 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1136 = v1140 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1143 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1144 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1145 
            #endif
#else
            let v1146 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1146 
            #endif
            let v1147 : System.DateTime = _run_target_args'_v1136 
            v1147
        | US2_0(v1017) -> (* Some *)
            (* run_target_args'
            let v1024 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1025 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1025 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1026 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1028 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1024 = v1028 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1031 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1031 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1032 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1032 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1033 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1033 
            #endif
#else
            let v1034 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1034 
            #endif
            let v1035 : System.DateTime = _run_target_args'_v1024 
            (* run_target_args'
            let v1046 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1047 : (System.DateTime -> int64) = _.Ticks
            let v1048 : int64 = v1047 v1035
            let _run_target_args'_v1046 = v1048 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1049 : (System.DateTime -> int64) = _.Ticks
            let v1050 : int64 = v1049 v1035
            let _run_target_args'_v1046 = v1050 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1052 : int64 = null |> unbox<int64>
            let _run_target_args'_v1046 = v1052 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1055 : (System.DateTime -> int64) = _.Ticks
            let v1056 : int64 = v1055 v1035
            let _run_target_args'_v1046 = v1056 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1057 : (System.DateTime -> int64) = _.Ticks
            let v1058 : int64 = v1057 v1035
            let _run_target_args'_v1046 = v1058 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1059 : (System.DateTime -> int64) = _.Ticks
            let v1060 : int64 = v1059 v1035
            let _run_target_args'_v1046 = v1060 
            #endif
#else
            let v1061 : (System.DateTime -> int64) = _.Ticks
            let v1062 : int64 = v1061 v1035
            let _run_target_args'_v1046 = v1062 
            #endif
            let v1063 : int64 = _run_target_args'_v1046 
            let v1085 : int64 = v1063 |> int64 
            let v1090 : int64 = v1085 - v1017
            let v1096 : System.TimeSpan = v1090 |> System.TimeSpan 
            let v1102 : (System.TimeSpan -> int32) = _.Hours
            let v1103 : int32 = v1102 v1096
            let v1107 : (System.TimeSpan -> int32) = _.Minutes
            let v1108 : int32 = v1107 v1096
            let v1112 : (System.TimeSpan -> int32) = _.Seconds
            let v1113 : int32 = v1112 v1096
            let v1117 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1118 : int32 = v1117 v1096
            let v1127 : System.DateTime = System.DateTime (1, 1, 1, v1103, v1108, v1113, v1118)
            v1127
    let v1154 : string = method10()
    let v1156 : bool = v1154 = ""
    let v1158 : string =
        if v1156 then
            let v1157 : string = "M-d-y hh:mm:ss tt"
            v1157
        else
            v1154
    let v1159 : (string -> string) = v1153.ToString
    let v1160 : string = v1159 v1158
    let _run_target_args'_v195 = v1160 
    #endif
#else
    let v1177 : (int64 -> US2) = method8()
    let v1178 : US2 option = v5 |> Option.map v1177 
    let v1198 : US2 = US2_1
    let v1199 : US2 = v1178 |> Option.defaultValue v1198 
    let v1339 : System.DateTime =
        match v1199 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1322 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1323 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1323 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1324 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1324 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1326 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1322 = v1326 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1329 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1329 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1330 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1330 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1331 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1331 
            #endif
#else
            let v1332 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1332 
            #endif
            let v1333 : System.DateTime = _run_target_args'_v1322 
            v1333
        | US2_0(v1203) -> (* Some *)
            (* run_target_args'
            let v1210 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1211 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1211 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1212 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1212 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1214 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1210 = v1214 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1217 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1217 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1218 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1218 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1219 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1219 
            #endif
#else
            let v1220 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1220 
            #endif
            let v1221 : System.DateTime = _run_target_args'_v1210 
            (* run_target_args'
            let v1232 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1233 : (System.DateTime -> int64) = _.Ticks
            let v1234 : int64 = v1233 v1221
            let _run_target_args'_v1232 = v1234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1235 : (System.DateTime -> int64) = _.Ticks
            let v1236 : int64 = v1235 v1221
            let _run_target_args'_v1232 = v1236 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1238 : int64 = null |> unbox<int64>
            let _run_target_args'_v1232 = v1238 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1241 : (System.DateTime -> int64) = _.Ticks
            let v1242 : int64 = v1241 v1221
            let _run_target_args'_v1232 = v1242 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1243 : (System.DateTime -> int64) = _.Ticks
            let v1244 : int64 = v1243 v1221
            let _run_target_args'_v1232 = v1244 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1245 : (System.DateTime -> int64) = _.Ticks
            let v1246 : int64 = v1245 v1221
            let _run_target_args'_v1232 = v1246 
            #endif
#else
            let v1247 : (System.DateTime -> int64) = _.Ticks
            let v1248 : int64 = v1247 v1221
            let _run_target_args'_v1232 = v1248 
            #endif
            let v1249 : int64 = _run_target_args'_v1232 
            let v1271 : int64 = v1249 |> int64 
            let v1276 : int64 = v1271 - v1203
            let v1282 : System.TimeSpan = v1276 |> System.TimeSpan 
            let v1288 : (System.TimeSpan -> int32) = _.Hours
            let v1289 : int32 = v1288 v1282
            let v1293 : (System.TimeSpan -> int32) = _.Minutes
            let v1294 : int32 = v1293 v1282
            let v1298 : (System.TimeSpan -> int32) = _.Seconds
            let v1299 : int32 = v1298 v1282
            let v1303 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1304 : int32 = v1303 v1282
            let v1313 : System.DateTime = System.DateTime (1, 1, 1, v1289, v1294, v1299, v1304)
            v1313
    let v1340 : string = method10()
    let v1342 : bool = v1340 = ""
    let v1344 : string =
        if v1342 then
            let v1343 : string = "M-d-y hh:mm:ss tt"
            v1343
        else
            v1340
    let v1345 : (string -> string) = v1339.ToString
    let v1346 : string = v1345 v1344
    let _run_target_args'_v195 = v1346 
    #endif
    let v1361 : string = _run_target_args'_v195 
    v1361
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
    let v86 : string = "inline_colorization::color_reset"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86 
    let v88 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v87) v88 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let _run_target_args'_v47 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "inline_colorization::color_bright_blue"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    (* run_target_args'
    let v98 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "&*$0"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v99 
    let _run_target_args'_v98 = v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : string = "&*$0"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v101 
    let _run_target_args'_v98 = v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v103 
    let _run_target_args'_v98 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v110 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v110 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v114 
    #endif
#else
    let v118 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v98 = v118 
    #endif
    let v121 : Ref<Str> = _run_target_args'_v98 
    let v130 : string = "inline_colorization::color_reset"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v93, v121, v131) v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v47 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : string = "inline_colorization::color_bright_blue"
    let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136 
    (* run_target_args'
    let v142 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "&*$0"
    let v144 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v143 
    let _run_target_args'_v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let _run_target_args'_v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "&*$0"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v147 
    let _run_target_args'_v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v158 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v158 
    #endif
#else
    let v162 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v142 = v162 
    #endif
    let v165 : Ref<Str> = _run_target_args'_v142 
    let v174 : string = "inline_colorization::color_reset"
    let v175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v137, v165, v175) v176 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178 
    let _run_target_args'_v47 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : string = "\u001b[94m"
    let v185 : string = method13()
    let v189 : string = v181 + v30 
    let v193 : string = v189 + v185 
    let _run_target_args'_v47 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = "\u001b[94m"
    let v201 : string = method13()
    let v205 : string = v197 + v30 
    let v209 : string = v205 + v201 
    let _run_target_args'_v47 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : string = "\u001b[94m"
    let v217 : string = method13()
    let v221 : string = v213 + v30 
    let v225 : string = v221 + v217 
    let _run_target_args'_v47 = v225 
    #endif
#else
    let v229 : string = "\u001b[94m"
    let v233 : string = method13()
    let v237 : string = v229 + v30 
    let v241 : string = v237 + v233 
    let _run_target_args'_v47 = v241 
    #endif
    let v244 : string = _run_target_args'_v47 
    v244
and method15 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v42 : char list = []
    let v44 : char list = '/' :: v42 
    let v48 : char list = ' ' :: v44 
    let v53 : (char list -> (char [])) = List.toArray
    let v54 : (char []) = v53 v48
    let v57 : string = v8.TrimEnd v54 
    v57
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
    let v120 : string = $"$0.chars()"
    let v121 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v120 
    let v122 : string = "$0"
    let v123 : _ = Fable.Core.RustInterop.emitRustExpr v121 v122 
    let v124 : string = "$0.collect::<Vec<_>>()"
    let v125 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v123 v124 
    let v126 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v127 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v125 v126 
    let v128 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v129 : bool = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let v130 : string = "x"
    let v131 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = "String::from_iter($0)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = "true; $0 }).collect::<Vec<_>>()"
    let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "_vec_map"
    let v137 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v136 
    let v138 : string = "$0.len()"
    let v139 : unativeint = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let v145 : int32 = v139 |> int32 
    let v155 : string = ""
    let v156 : bool = v0 <> v155 
    let v160 : bool =
        if v156 then
            let v159 : bool = v145 <= 1
            v159
        else
            false
    if v160 then
        v41.l0 <- v83
        ()
    else
        v41.l0 <- v155
        let v161 : string = "true; $0.into_iter().for_each(|x| { //"
        let v162 : bool = Fable.Core.RustInterop.emitRustExpr v137 v161 
        let v163 : string = "x"
        let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v166 : bool = Fable.Core.RustInterop.emitRustExpr v164 v165 
        let v167 : string = $"true"
        let v168 : bool = Fable.Core.RustInterop.emitRustExpr () v167 
        let v169 : string = "true; }); //"
        let v170 : bool = Fable.Core.RustInterop.emitRustExpr () v169 
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
    let v171 : (string -> unit) = v39.l0
    v171 v0
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
    let v120 : string = $"$0.chars()"
    let v121 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v120 
    let v122 : string = "$0"
    let v123 : _ = Fable.Core.RustInterop.emitRustExpr v121 v122 
    let v124 : string = "$0.collect::<Vec<_>>()"
    let v125 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v123 v124 
    let v126 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v127 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v125 v126 
    let v128 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v129 : bool = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let v130 : string = "x"
    let v131 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = "String::from_iter($0)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = "true; $0 }).collect::<Vec<_>>()"
    let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "_vec_map"
    let v137 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v136 
    let v138 : string = "$0.len()"
    let v139 : unativeint = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let v145 : int32 = v139 |> int32 
    let v154 : bool = v62 <> v62 
    let v158 : bool =
        if v154 then
            let v157 : bool = v145 <= 1
            v157
        else
            false
    if v158 then
        v40.l0 <- v83
        ()
    else
        v40.l0 <- v62
        let v159 : string = "true; $0.into_iter().for_each(|x| { //"
        let v160 : bool = Fable.Core.RustInterop.emitRustExpr v137 v159 
        let v161 : string = "x"
        let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v161 
        let v163 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v164 : bool = Fable.Core.RustInterop.emitRustExpr v162 v163 
        let v165 : string = $"true"
        let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
        let v167 : string = "true; }); //"
        let v168 : bool = Fable.Core.RustInterop.emitRustExpr () v167 
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
    let v169 : (string -> unit) = v38.l0
    v169 v62
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
    let v200 : string = $"{v190}"
    let v208 : unit = ()
    let v209 : (unit -> unit) = closure6(v24, v200)
    let v210 : unit = (fun () -> v209 (); v208) ()
    let v217 : string = $"{v104}"
    let v225 : unit = ()
    let v226 : (unit -> unit) = closure6(v24, v217)
    let v227 : unit = (fun () -> v226 (); v225) ()
    let v235 : string = "proof"
    let v236 : string = $"{v235}"
    let v244 : unit = ()
    let v245 : (unit -> unit) = closure6(v24, v236)
    let v246 : unit = (fun () -> v245 (); v244) ()
    let v253 : string = $"{v65}"
    let v261 : unit = ()
    let v262 : (unit -> unit) = closure6(v24, v253)
    let v263 : unit = (fun () -> v262 (); v261) ()
    (* run_target_args'
    let v273 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v274 : string = "format!(\"{:#?}\", $0)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _run_target_args'_v273 = v277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v278 : string = "format!(\"{:#?}\", $0)"
    let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v278 
    let v280 : string = "fable_library_rust::String_::fromString($0)"
    let v281 : string = Fable.Core.RustInterop.emitRustExpr v279 v280 
    let _run_target_args'_v273 = v281 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v282 : string = "format!(\"{:#?}\", $0)"
    let v283 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v282 
    let v284 : string = "fable_library_rust::String_::fromString($0)"
    let v285 : string = Fable.Core.RustInterop.emitRustExpr v283 v284 
    let _run_target_args'_v273 = v285 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v287 : string = $"%A{v10}"
    let _run_target_args'_v273 = v287 
    #endif
#if FABLE_COMPILER_PYTHON
    let v291 : string = $"%A{v10}"
    let _run_target_args'_v273 = v291 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v295 : string = $"%A{v10}"
    let _run_target_args'_v273 = v295 
    #endif
#else
    let v299 : string = $"%A{v10}"
    let _run_target_args'_v273 = v299 
    #endif
    let v302 : string = _run_target_args'_v273 
    let v312 : string = $"{v302}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure6(v24, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v329 : string = $"{v104}"
    let v337 : unit = ()
    let v338 : (unit -> unit) = closure6(v24, v329)
    let v339 : unit = (fun () -> v338 (); v337) ()
    let v347 : string = "block_timestamp"
    let v348 : string = $"{v347}"
    let v356 : unit = ()
    let v357 : (unit -> unit) = closure6(v24, v348)
    let v358 : unit = (fun () -> v357 (); v356) ()
    let v365 : string = $"{v65}"
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure6(v24, v365)
    let v375 : unit = (fun () -> v374 (); v373) ()
    let v385 : string = $"{v11}"
    let v393 : unit = ()
    let v394 : (unit -> unit) = closure6(v24, v385)
    let v395 : unit = (fun () -> v394 (); v393) ()
    let v402 : string = $"{v104}"
    let v410 : unit = ()
    let v411 : (unit -> unit) = closure6(v24, v402)
    let v412 : unit = (fun () -> v411 (); v410) ()
    let v420 : string = "block_height"
    let v421 : string = $"{v420}"
    let v429 : unit = ()
    let v430 : (unit -> unit) = closure6(v24, v421)
    let v431 : unit = (fun () -> v430 (); v429) ()
    let v438 : string = $"{v65}"
    let v446 : unit = ()
    let v447 : (unit -> unit) = closure6(v24, v438)
    let v448 : unit = (fun () -> v447 (); v446) ()
    let v458 : string = $"{v12}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure6(v24, v458)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v475 : string = $"{v104}"
    let v483 : unit = ()
    let v484 : (unit -> unit) = closure6(v24, v475)
    let v485 : unit = (fun () -> v484 (); v483) ()
    let v493 : string = "epoch_height"
    let v494 : string = $"{v493}"
    let v502 : unit = ()
    let v503 : (unit -> unit) = closure6(v24, v494)
    let v504 : unit = (fun () -> v503 (); v502) ()
    let v511 : string = $"{v65}"
    let v519 : unit = ()
    let v520 : (unit -> unit) = closure6(v24, v511)
    let v521 : unit = (fun () -> v520 (); v519) ()
    let v531 : string = $"{v13}"
    let v539 : unit = ()
    let v540 : (unit -> unit) = closure6(v24, v531)
    let v541 : unit = (fun () -> v540 (); v539) ()
    let v548 : string = $"{v104}"
    let v556 : unit = ()
    let v557 : (unit -> unit) = closure6(v24, v548)
    let v558 : unit = (fun () -> v557 (); v556) ()
    let v566 : string = "account_balance"
    let v567 : string = $"{v566}"
    let v575 : unit = ()
    let v576 : (unit -> unit) = closure6(v24, v567)
    let v577 : unit = (fun () -> v576 (); v575) ()
    let v584 : string = $"{v65}"
    let v592 : unit = ()
    let v593 : (unit -> unit) = closure6(v24, v584)
    let v594 : unit = (fun () -> v593 (); v592) ()
    let v601 : string = $"{v14}"
    let v609 : unit = ()
    let v610 : (unit -> unit) = closure6(v24, v601)
    let v611 : unit = (fun () -> v610 (); v609) ()
    let v618 : string = $"{v104}"
    let v626 : unit = ()
    let v627 : (unit -> unit) = closure6(v24, v618)
    let v628 : unit = (fun () -> v627 (); v626) ()
    let v636 : string = "signer_account_id"
    let v637 : string = $"{v636}"
    let v645 : unit = ()
    let v646 : (unit -> unit) = closure6(v24, v637)
    let v647 : unit = (fun () -> v646 (); v645) ()
    let v654 : string = $"{v65}"
    let v662 : unit = ()
    let v663 : (unit -> unit) = closure6(v24, v654)
    let v664 : unit = (fun () -> v663 (); v662) ()
    (* run_target_args'
    let v674 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v675 : string = "format!(\"{:#?}\", $0)"
    let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v675 
    let v677 : string = "fable_library_rust::String_::fromString($0)"
    let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
    let _run_target_args'_v674 = v678 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v679 : string = "format!(\"{:#?}\", $0)"
    let v680 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v679 
    let v681 : string = "fable_library_rust::String_::fromString($0)"
    let v682 : string = Fable.Core.RustInterop.emitRustExpr v680 v681 
    let _run_target_args'_v674 = v682 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v683 : string = "format!(\"{:#?}\", $0)"
    let v684 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v683 
    let v685 : string = "fable_library_rust::String_::fromString($0)"
    let v686 : string = Fable.Core.RustInterop.emitRustExpr v684 v685 
    let _run_target_args'_v674 = v686 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v688 : string = $"%A{v15}"
    let _run_target_args'_v674 = v688 
    #endif
#if FABLE_COMPILER_PYTHON
    let v692 : string = $"%A{v15}"
    let _run_target_args'_v674 = v692 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v696 : string = $"%A{v15}"
    let _run_target_args'_v674 = v696 
    #endif
#else
    let v700 : string = $"%A{v15}"
    let _run_target_args'_v674 = v700 
    #endif
    let v703 : string = _run_target_args'_v674 
    let v713 : string = $"{v703}"
    let v721 : unit = ()
    let v722 : (unit -> unit) = closure6(v24, v713)
    let v723 : unit = (fun () -> v722 (); v721) ()
    let v730 : string = $"{v104}"
    let v738 : unit = ()
    let v739 : (unit -> unit) = closure6(v24, v730)
    let v740 : unit = (fun () -> v739 (); v738) ()
    let v748 : string = "predecessor_account_id"
    let v749 : string = $"{v748}"
    let v757 : unit = ()
    let v758 : (unit -> unit) = closure6(v24, v749)
    let v759 : unit = (fun () -> v758 (); v757) ()
    let v766 : string = $"{v65}"
    let v774 : unit = ()
    let v775 : (unit -> unit) = closure6(v24, v766)
    let v776 : unit = (fun () -> v775 (); v774) ()
    (* run_target_args'
    let v786 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v787 : string = "format!(\"{:#?}\", $0)"
    let v788 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v787 
    let v789 : string = "fable_library_rust::String_::fromString($0)"
    let v790 : string = Fable.Core.RustInterop.emitRustExpr v788 v789 
    let _run_target_args'_v786 = v790 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v791 : string = "format!(\"{:#?}\", $0)"
    let v792 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v791 
    let v793 : string = "fable_library_rust::String_::fromString($0)"
    let v794 : string = Fable.Core.RustInterop.emitRustExpr v792 v793 
    let _run_target_args'_v786 = v794 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v795 : string = "format!(\"{:#?}\", $0)"
    let v796 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v795 
    let v797 : string = "fable_library_rust::String_::fromString($0)"
    let v798 : string = Fable.Core.RustInterop.emitRustExpr v796 v797 
    let _run_target_args'_v786 = v798 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v800 : string = $"%A{v16}"
    let _run_target_args'_v786 = v800 
    #endif
#if FABLE_COMPILER_PYTHON
    let v804 : string = $"%A{v16}"
    let _run_target_args'_v786 = v804 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v808 : string = $"%A{v16}"
    let _run_target_args'_v786 = v808 
    #endif
#else
    let v812 : string = $"%A{v16}"
    let _run_target_args'_v786 = v812 
    #endif
    let v815 : string = _run_target_args'_v786 
    let v825 : string = $"{v815}"
    let v833 : unit = ()
    let v834 : (unit -> unit) = closure6(v24, v825)
    let v835 : unit = (fun () -> v834 (); v833) ()
    let v842 : string = $"{v104}"
    let v850 : unit = ()
    let v851 : (unit -> unit) = closure6(v24, v842)
    let v852 : unit = (fun () -> v851 (); v850) ()
    let v860 : string = "seed"
    let v861 : string = $"{v860}"
    let v869 : unit = ()
    let v870 : (unit -> unit) = closure6(v24, v861)
    let v871 : unit = (fun () -> v870 (); v869) ()
    let v878 : string = $"{v65}"
    let v886 : unit = ()
    let v887 : (unit -> unit) = closure6(v24, v878)
    let v888 : unit = (fun () -> v887 (); v886) ()
    let v895 : string = $"{v17}"
    let v903 : unit = ()
    let v904 : (unit -> unit) = closure6(v24, v895)
    let v905 : unit = (fun () -> v904 (); v903) ()
    let v912 : string = $"{v104}"
    let v920 : unit = ()
    let v921 : (unit -> unit) = closure6(v24, v912)
    let v922 : unit = (fun () -> v921 (); v920) ()
    let v930 : string = "seeds"
    let v931 : string = $"{v930}"
    let v939 : unit = ()
    let v940 : (unit -> unit) = closure6(v24, v931)
    let v941 : unit = (fun () -> v940 (); v939) ()
    let v948 : string = $"{v65}"
    let v956 : unit = ()
    let v957 : (unit -> unit) = closure6(v24, v948)
    let v958 : unit = (fun () -> v957 (); v956) ()
    let v965 : string = $"{v18}"
    let v973 : unit = ()
    let v974 : (unit -> unit) = closure6(v24, v965)
    let v975 : unit = (fun () -> v974 (); v973) ()
    let v982 : string = $"{v104}"
    let v990 : unit = ()
    let v991 : (unit -> unit) = closure6(v24, v982)
    let v992 : unit = (fun () -> v991 (); v990) ()
    let v1000 : string = "entropy_len"
    let v1001 : string = $"{v1000}"
    let v1009 : unit = ()
    let v1010 : (unit -> unit) = closure6(v24, v1001)
    let v1011 : unit = (fun () -> v1010 (); v1009) ()
    let v1018 : string = $"{v65}"
    let v1026 : unit = ()
    let v1027 : (unit -> unit) = closure6(v24, v1018)
    let v1028 : unit = (fun () -> v1027 (); v1026) ()
    (* run_target_args'
    let v1038 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1039 : string = "format!(\"{:#?}\", $0)"
    let v1040 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v1039 
    let v1041 : string = "fable_library_rust::String_::fromString($0)"
    let v1042 : string = Fable.Core.RustInterop.emitRustExpr v1040 v1041 
    let _run_target_args'_v1038 = v1042 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1043 : string = "format!(\"{:#?}\", $0)"
    let v1044 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v1043 
    let v1045 : string = "fable_library_rust::String_::fromString($0)"
    let v1046 : string = Fable.Core.RustInterop.emitRustExpr v1044 v1045 
    let _run_target_args'_v1038 = v1046 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1047 : string = "format!(\"{:#?}\", $0)"
    let v1048 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v1047 
    let v1049 : string = "fable_library_rust::String_::fromString($0)"
    let v1050 : string = Fable.Core.RustInterop.emitRustExpr v1048 v1049 
    let _run_target_args'_v1038 = v1050 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1052 : string = $"%A{v19}"
    let _run_target_args'_v1038 = v1052 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1056 : string = $"%A{v19}"
    let _run_target_args'_v1038 = v1056 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1060 : string = $"%A{v19}"
    let _run_target_args'_v1038 = v1060 
    #endif
#else
    let v1064 : string = $"%A{v19}"
    let _run_target_args'_v1038 = v1064 
    #endif
    let v1067 : string = _run_target_args'_v1038 
    let v1077 : string = $"{v1067}"
    let v1085 : unit = ()
    let v1086 : (unit -> unit) = closure6(v24, v1077)
    let v1087 : unit = (fun () -> v1086 (); v1085) ()
    let v1094 : string = $"{v104}"
    let v1102 : unit = ()
    let v1103 : (unit -> unit) = closure6(v24, v1094)
    let v1104 : unit = (fun () -> v1103 (); v1102) ()
    let v1112 : string = "entropy"
    let v1113 : string = $"{v1112}"
    let v1121 : unit = ()
    let v1122 : (unit -> unit) = closure6(v24, v1113)
    let v1123 : unit = (fun () -> v1122 (); v1121) ()
    let v1130 : string = $"{v65}"
    let v1138 : unit = ()
    let v1139 : (unit -> unit) = closure6(v24, v1130)
    let v1140 : unit = (fun () -> v1139 (); v1138) ()
    let v1147 : string = $"{v20}"
    let v1155 : unit = ()
    let v1156 : (unit -> unit) = closure6(v24, v1147)
    let v1157 : unit = (fun () -> v1156 (); v1155) ()
    let v1164 : string = $"{v104}"
    let v1172 : unit = ()
    let v1173 : (unit -> unit) = closure6(v24, v1164)
    let v1174 : unit = (fun () -> v1173 (); v1172) ()
    let v1182 : string = "hash_u8"
    let v1183 : string = $"{v1182}"
    let v1191 : unit = ()
    let v1192 : (unit -> unit) = closure6(v24, v1183)
    let v1193 : unit = (fun () -> v1192 (); v1191) ()
    let v1200 : string = $"{v65}"
    let v1208 : unit = ()
    let v1209 : (unit -> unit) = closure6(v24, v1200)
    let v1210 : unit = (fun () -> v1209 (); v1208) ()
    let v1217 : string = $"{v21}"
    let v1225 : unit = ()
    let v1226 : (unit -> unit) = closure6(v24, v1217)
    let v1227 : unit = (fun () -> v1226 (); v1225) ()
    let v1234 : string = $"{v104}"
    let v1242 : unit = ()
    let v1243 : (unit -> unit) = closure6(v24, v1234)
    let v1244 : unit = (fun () -> v1243 (); v1242) ()
    let v1252 : string = "rolls"
    let v1253 : string = $"{v1252}"
    let v1261 : unit = ()
    let v1262 : (unit -> unit) = closure6(v24, v1253)
    let v1263 : unit = (fun () -> v1262 (); v1261) ()
    let v1270 : string = $"{v65}"
    let v1278 : unit = ()
    let v1279 : (unit -> unit) = closure6(v24, v1270)
    let v1280 : unit = (fun () -> v1279 (); v1278) ()
    let v1287 : string = $"{v22}"
    let v1295 : unit = ()
    let v1296 : (unit -> unit) = closure6(v24, v1287)
    let v1297 : unit = (fun () -> v1296 (); v1295) ()
    let v1305 : string = " }"
    let v1306 : string = $"{v1305}"
    let v1314 : unit = ()
    let v1315 : (unit -> unit) = closure6(v24, v1306)
    let v1316 : unit = (fun () -> v1315 (); v1314) ()
    let v1322 : string = v24.l0
    let v1323 : int64 = v0.l0
    let v1326 : string = " "
    let v1327 : string = v6 + v1326 
    let v1331 : string = v1327 + v7 
    let v1336 : string = " #"
    let v1337 : string = v1331 + v1336 
    let v1341 : (int64 -> string) = _.ToString()
    let v1342 : string = v1341 v1323
    let v1346 : string = v1337 + v1342 
    let v1350 : string = v1346 + v1326 
    let v1355 : string = "dice_contract.generate_random_number"
    let v1356 : string = v1350 + v1355 
    let v1361 : string = " / "
    let v1362 : string = v1356 + v1361 
    let v1366 : string = v1362 + v1322 
    method15(v1366)
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
