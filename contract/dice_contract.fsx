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
and [<Struct>] US6 =
    | US6_0 of f0_0 : Mut0 * f0_1 : Mut1 * f0_2 : Mut2 * f0_3 : Mut3 * f0_4 : Mut4 * f0_5 : int64 option
    | US6_1
and UH0 =
    | UH0_0
    | UH0_1 of uint8 * UH0
and UH1 =
    | UH1_0 of uint8 * (unit -> UH1)
    | UH1_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : (unit -> UH1)
    | US7_1 of f1_0 : UH1
and Mut5 = {mutable l0 : US7}
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint8
    | US8_1
and Mut6 = {mutable l0 : US8}
and [<Struct>] US9 =
    | US9_0 of f0_0 : uint64 * f0_1 : UH0
    | US9_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : uint64
    | US10_1
let rec method3 (v0 : string) : string =
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US5 =
    US5_0(v0)
and method5 () : (string -> US5) =
    closure3()
and method2 (v0 : string) : string =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method3(v0)
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
    let v16 : string = method4()
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
    let v49 : (string -> US5) = method5()
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
    let v93 : (string -> US5) = method5()
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
and method1 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method2(v0)
    
    
    
    
    
    
    
    
    
    
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
    let v129 : string = method2(v128)
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
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US1, v5 : US2) = method1()
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
    let struct (v176 : US1, v177 : US2) = method1()
    let _run_target_args'_v3 = struct (v176, v177) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v178 : US1, v179 : US2) = method1()
    let _run_target_args'_v3 = struct (v178, v179) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v180 : US1, v181 : US2) = method1()
    let _run_target_args'_v3 = struct (v180, v181) 
    #endif
#else
    let struct (v182 : US1, v183 : US2) = method1()
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
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and closure5 () (v0 : int64) : US2 =
    US2_0(v0)
and method7 () : (int64 -> US2) =
    closure5()
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v216 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : (int64 -> US2) = method7()
    let v220 : US2 option = v5 |> Option.map v219 
    let v240 : US2 = US2_1
    let v241 : US2 = v220 |> Option.defaultValue v240 
    let v395 : System.DateTime =
        match v241 with
        | US2_1 -> (* None *)
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
        | US2_0(v245) -> (* Some *)
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
    let v396 : string = method8()
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
    let v429 : (int64 -> US2) = method7()
    let v430 : US2 option = v5 |> Option.map v429 
    let v450 : US2 = US2_1
    let v451 : US2 = v430 |> Option.defaultValue v450 
    let v605 : System.DateTime =
        match v451 with
        | US2_1 -> (* None *)
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
        | US2_0(v455) -> (* Some *)
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
    let v606 : string = method8()
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
    let v641 : (int64 -> US2) = method7()
    let v642 : US2 option = v5 |> Option.map v641 
    let v662 : US2 = US2_1
    let v663 : US2 = v642 |> Option.defaultValue v662 
    let v675 : uint64 =
        match v663 with
        | US2_1 -> (* None *)
            v638
        | US2_0(v667) -> (* Some *)
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
    let v688 : (int64 -> US2) = method7()
    let v689 : US2 option = v5 |> Option.map v688 
    let v709 : US2 = US2_1
    let v710 : US2 = v689 |> Option.defaultValue v709 
    let v864 : System.DateTime =
        match v710 with
        | US2_1 -> (* None *)
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
        | US2_0(v714) -> (* Some *)
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
    let v865 : string = method9()
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
    let v898 : (int64 -> US2) = method7()
    let v899 : US2 option = v5 |> Option.map v898 
    let v919 : US2 = US2_1
    let v920 : US2 = v899 |> Option.defaultValue v919 
    let v1074 : System.DateTime =
        match v920 with
        | US2_1 -> (* None *)
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
        | US2_0(v924) -> (* Some *)
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
    let v1075 : string = method9()
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
    let v1108 : (int64 -> US2) = method7()
    let v1109 : US2 option = v5 |> Option.map v1108 
    let v1129 : US2 = US2_1
    let v1130 : US2 = v1109 |> Option.defaultValue v1129 
    let v1284 : System.DateTime =
        match v1130 with
        | US2_1 -> (* None *)
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
        | US2_0(v1134) -> (* Some *)
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
    let v1285 : string = method9()
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
    let v1318 : (int64 -> US2) = method7()
    let v1319 : US2 option = v5 |> Option.map v1318 
    let v1339 : US2 = US2_1
    let v1340 : US2 = v1319 |> Option.defaultValue v1339 
    let v1494 : System.DateTime =
        match v1340 with
        | US2_1 -> (* None *)
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
        | US2_0(v1344) -> (* Some *)
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
    let v1495 : string = method9()
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
and method12 () : string =
    let v0 : string = ""
    v0
and method13 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method11 (v0 : char) : string =
    let v1 : string = method12()
    let v3 : Mut3 = {l0 = v1} : Mut3
    let v8 : string = $"{v0}"
    method13(v3, v8)
    let v24 : string = v3.l0
    v24
and method10 () : string =
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
    let v137 : string = method11(v136)
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
and method15 (v0 : int32, v1 : string) : string =
    let v2 : string = method12()
    let v4 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    method13(v4, v6)
    let v21 : string = "seed_excess_len"
    method13(v4, v21)
    let v36 : string = " = "
    method13(v4, v36)
    let v54 : string = $"{v0}"
    method13(v4, v54)
    let v71 : string = "; "
    method13(v4, v71)
    let v86 : string = "seed_excess"
    method13(v4, v86)
    method13(v4, v36)
    method13(v4, v1)
    let v129 : string = " }"
    method13(v4, v129)
    let v143 : string = v4.l0
    v143
and method16 (v0 : string) : string =
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
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method15(v8, v9)
    let v11 : int64 = v0.l0
    let v14 : string = " "
    let v15 : string = v6 + v14 
    let v19 : string = v15 + v7 
    let v24 : string = " #"
    let v25 : string = v19 + v24 
    let v32 : (int64 -> string) = _.ToString()
    let v33 : string = v32 v11
    let v37 : string = v25 + v33 
    let v41 : string = v37 + v14 
    let v46 : string = "dice_contract.contribute_seed"
    let v47 : string = v41 + v46 
    let v52 : string = " / "
    let v53 : string = v47 + v52 
    let v57 : string = v53 + v10 
    method16(v57)
and closure6 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure8 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure7 () (v0 : string) : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure8(v0)
    let v4 : unit = (fun () -> v3 (); v2) ()
    ()
and closure1 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure2()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US0 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v341 : US6 =
        if v65 then
            US6_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut0, v106 : Mut1, v107 : Mut2, v108 : Mut3, v109 : Mut4, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method6(v105, v106, v107, v108, v109, v110)
            let v124 : string = method10()
            let v126 : string = $"%A{v1}"
            let v129 : string = method14(v105, v106, v107, v108, v109, v110, v123, v124, v0, v126)
            let v144 : unit = ()
            let v145 : unit = (fun () -> v17 (); v144) ()
            let struct (v168 : Mut0, v169 : Mut1, v170 : Mut2, v171 : Mut3, v172 : Mut4, v173 : int64 option) = TraceState.trace_state.Value
            let v188 : unit = ()
            let v189 : (unit -> unit) = closure6(v168)
            let v190 : unit = (fun () -> v189 (); v188) ()
            let v193 : (string -> unit) = closure7()
            (* run_target_args'
            let v194 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v195 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v129 v195 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v196 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v129 v196 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v197 : string = v171.l0
            let v198 : bool = v197 = ""
            let v213 : string =
                if v198 then
                    v129
                else
                    let v199 : bool = v129 = ""
                    if v199 then
                        let v200 : string = v171.l0
                        v200
                    else
                        let v201 : string = v171.l0
                        let v204 : string = "\n"
                        let v205 : string = v201 + v204 
                        let v209 : string = v205 + v129 
                        v209
            (* run_target_args'
            let v218 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v213 v219 
            let _run_target_args'_v218 = v220 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v221 : string = "&*$0"
            let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v213 v221 
            let _run_target_args'_v218 = v222 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v223 : string = "&*$0"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v213 v223 
            let _run_target_args'_v218 = v224 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v226 : Ref<Str> = v213 |> unbox<Ref<Str>>
            let _run_target_args'_v218 = v226 
            #endif
#if FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v213 |> unbox<Ref<Str>>
            let _run_target_args'_v218 = v230 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v234 : Ref<Str> = v213 |> unbox<Ref<Str>>
            let _run_target_args'_v218 = v234 
            #endif
#else
            let v238 : Ref<Str> = v213 |> unbox<Ref<Str>>
            let _run_target_args'_v218 = v238 
            #endif
            let v241 : Ref<Str> = _run_target_args'_v218 
            let v250 : string = $"$0.chars()"
            let v251 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v241 v250 
            let v252 : string = "$0"
            let v253 : _ = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "$0.collect::<Vec<_>>()"
            let v255 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v257 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "x"
            let v261 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "String::from_iter($0)"
            let v263 : std_string_String = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v264 : string = "true; $0 }).collect::<Vec<_>>()"
            let v265 : bool = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v266 : string = "_vec_map"
            let v267 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v266 
            let v268 : string = "$0.len()"
            let v269 : unativeint = Fable.Core.RustInterop.emitRustExpr v267 v268 
            let v313 : int32 = v269 |> int32 
            let v323 : string = ""
            let v324 : bool = v129 <> v323 
            let v328 : bool =
                if v324 then
                    let v327 : bool = v313 <= 1
                    v327
                else
                    false
            if v328 then
                v171.l0 <- v213
                ()
            else
                v171.l0 <- v323
                let v329 : string = "true; $0.into_iter().for_each(|x| { //"
                let v330 : bool = Fable.Core.RustInterop.emitRustExpr v267 v329 
                let v331 : string = "x"
                let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v331 
                let v333 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v334 : bool = Fable.Core.RustInterop.emitRustExpr v332 v333 
                let v335 : string = $"true"
                let v336 : bool = Fable.Core.RustInterop.emitRustExpr () v335 
                let v337 : string = "true; }); //"
                let v338 : bool = Fable.Core.RustInterop.emitRustExpr () v337 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v193 v129
            #endif
#if FABLE_COMPILER_PYTHON
            v193 v129
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v193 v129
            #endif
#else
            v193 v129
            #endif
            // run_target_args' is_unit
            let v339 : (string -> unit) = v169.l0
            v339 v129
            US6_0(v168, v169, v170, v171, v172, v173)
    
    ()
and closure9 () () : unit =
    ()
and method17 () : (unit -> unit) =
    closure9()
and closure10 (v0 : (unit -> unit)) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure2()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v334 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v138 : unit = ()
            let v139 : unit = (fun () -> v16 (); v138) ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : Mut4, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure6(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure7()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v165.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v187
                else
                    let v194 : bool = v187 = ""
                    if v194 then
                        let v195 : string = v165.l0
                        v195
                    else
                        let v196 : string = v165.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v187 
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
            let v308 : int32 = v264 |> int32 
            let v317 : bool = v187 <> v187 
            let v321 : bool =
                if v317 then
                    let v320 : bool = v308 <= 1
                    v320
                else
                    false
            if v321 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v322 : string = "true; $0.into_iter().for_each(|x| { //"
                let v323 : bool = Fable.Core.RustInterop.emitRustExpr v262 v322 
                let v324 : string = "x"
                let v325 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v324 
                let v326 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr v325 v326 
                let v328 : string = $"true"
                let v329 : bool = Fable.Core.RustInterop.emitRustExpr () v328 
                let v330 : string = "true; }); //"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr () v330 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v187
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#else
            v188 v187
            #endif
            // run_target_args' is_unit
            let v332 : (string -> unit) = v163.l0
            v332 v187
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
and closure12 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure11 () (v0 : uint8) : (UH0 -> UH0) =
    closure12(v0)
and method18 () : (uint8 -> (UH0 -> UH0)) =
    closure11()
and closure13 (v0 : UH1) () : UH1 =
    v0
and method19 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method19(v3, v1)
        let v5 : (unit -> UH1) = closure13(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure14 (v0 : UH1) () : UH1 =
    v0
and method20 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method20(v4, v1)
        let v6 : int64 = int64 v2
        let v7 : int64 = v6 - 1L
        let v8 : int64 = v7 + 6L
        let v9 : int64 = v8 % 6L
        let v10 : int64 = v9 + 1L
        let v11 : uint8 = uint8 v10
        let v12 : (unit -> UH1) = closure14(v5)
        UH1_0(v11, v12)
    | UH1_1 -> (* StreamNil *)
        v1
and method21 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method21(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method22 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method22(v3, v1)
        let v6 : uint8 list = v2 :: v4 
        v6
    | UH0_0 -> (* Nil *)
        v1
and method24 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : std_string_String, v9 : string, v10 : string, v11 : unativeint, v12 : string, v13 : string, v14 : string) : string =
    let v15 : string = method12()
    let v17 : Mut3 = {l0 = v15} : Mut3
    let v19 : string = "{ "
    method13(v17, v19)
    let v34 : string = "max"
    method13(v17, v34)
    let v49 : string = " = "
    method13(v17, v49)
    let v67 : string = $"{v0}"
    method13(v17, v67)
    let v84 : string = "; "
    method13(v17, v84)
    let v99 : string = "key"
    method13(v17, v99)
    method13(v17, v49)
    (* run_target_args'
    let v131 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v132 : string = "format!(\"{:#?}\", $0)"
    let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v132 
    let v134 : string = "fable_library_rust::String_::fromString($0)"
    let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let _run_target_args'_v131 = v135 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v136 : string = "format!(\"{:#?}\", $0)"
    let v137 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v136 
    let v138 : string = "fable_library_rust::String_::fromString($0)"
    let v139 : string = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let _run_target_args'_v131 = v139 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v140 : string = "format!(\"{:#?}\", $0)"
    let v141 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v140 
    let v142 : string = "fable_library_rust::String_::fromString($0)"
    let v143 : string = Fable.Core.RustInterop.emitRustExpr v141 v142 
    let _run_target_args'_v131 = v143 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : string = $"%A{v1}"
    let _run_target_args'_v131 = v145 
    #endif
#if FABLE_COMPILER_PYTHON
    let v149 : string = $"%A{v1}"
    let _run_target_args'_v131 = v149 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v153 : string = $"%A{v1}"
    let _run_target_args'_v131 = v153 
    #endif
#else
    let v157 : string = $"%A{v1}"
    let _run_target_args'_v131 = v157 
    #endif
    let v160 : string = _run_target_args'_v131 
    method13(v17, v160)
    method13(v17, v84)
    let v198 : string = "proof"
    method13(v17, v198)
    method13(v17, v49)
    (* run_target_args'
    let v230 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v231 : string = "format!(\"{:#?}\", $0)"
    let v232 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v231 
    let v233 : string = "fable_library_rust::String_::fromString($0)"
    let v234 : string = Fable.Core.RustInterop.emitRustExpr v232 v233 
    let _run_target_args'_v230 = v234 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v235 : string = "format!(\"{:#?}\", $0)"
    let v236 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v235 
    let v237 : string = "fable_library_rust::String_::fromString($0)"
    let v238 : string = Fable.Core.RustInterop.emitRustExpr v236 v237 
    let _run_target_args'_v230 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v239 : string = "format!(\"{:#?}\", $0)"
    let v240 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v239 
    let v241 : string = "fable_library_rust::String_::fromString($0)"
    let v242 : string = Fable.Core.RustInterop.emitRustExpr v240 v241 
    let _run_target_args'_v230 = v242 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v244 : string = $"%A{v2}"
    let _run_target_args'_v230 = v244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v248 : string = $"%A{v2}"
    let _run_target_args'_v230 = v248 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v252 : string = $"%A{v2}"
    let _run_target_args'_v230 = v252 
    #endif
#else
    let v256 : string = $"%A{v2}"
    let _run_target_args'_v230 = v256 
    #endif
    let v259 : string = _run_target_args'_v230 
    method13(v17, v259)
    method13(v17, v84)
    let v297 : string = "block_timestamp"
    method13(v17, v297)
    method13(v17, v49)
    let v329 : string = $"{v3}"
    method13(v17, v329)
    method13(v17, v84)
    let v360 : string = "block_height"
    method13(v17, v360)
    method13(v17, v49)
    let v392 : string = $"{v4}"
    method13(v17, v392)
    method13(v17, v84)
    let v423 : string = "epoch_height"
    method13(v17, v423)
    method13(v17, v49)
    let v455 : string = $"{v5}"
    method13(v17, v455)
    method13(v17, v84)
    let v486 : string = "account_balance"
    method13(v17, v486)
    method13(v17, v49)
    method13(v17, v6)
    method13(v17, v84)
    let v543 : string = "signer_account_id"
    method13(v17, v543)
    method13(v17, v49)
    (* run_target_args'
    let v575 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v576 : string = "format!(\"{:#?}\", $0)"
    let v577 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v576 
    let v578 : string = "fable_library_rust::String_::fromString($0)"
    let v579 : string = Fable.Core.RustInterop.emitRustExpr v577 v578 
    let _run_target_args'_v575 = v579 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v580 : string = "format!(\"{:#?}\", $0)"
    let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v580 
    let v582 : string = "fable_library_rust::String_::fromString($0)"
    let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
    let _run_target_args'_v575 = v583 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v584 : string = "format!(\"{:#?}\", $0)"
    let v585 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v584 
    let v586 : string = "fable_library_rust::String_::fromString($0)"
    let v587 : string = Fable.Core.RustInterop.emitRustExpr v585 v586 
    let _run_target_args'_v575 = v587 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v589 : string = $"%A{v7}"
    let _run_target_args'_v575 = v589 
    #endif
#if FABLE_COMPILER_PYTHON
    let v593 : string = $"%A{v7}"
    let _run_target_args'_v575 = v593 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v597 : string = $"%A{v7}"
    let _run_target_args'_v575 = v597 
    #endif
#else
    let v601 : string = $"%A{v7}"
    let _run_target_args'_v575 = v601 
    #endif
    let v604 : string = _run_target_args'_v575 
    method13(v17, v604)
    method13(v17, v84)
    let v642 : string = "predecessor_account_id"
    method13(v17, v642)
    method13(v17, v49)
    (* run_target_args'
    let v674 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v675 : string = "format!(\"{:#?}\", $0)"
    let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v675 
    let v677 : string = "fable_library_rust::String_::fromString($0)"
    let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
    let _run_target_args'_v674 = v678 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v679 : string = "format!(\"{:#?}\", $0)"
    let v680 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v679 
    let v681 : string = "fable_library_rust::String_::fromString($0)"
    let v682 : string = Fable.Core.RustInterop.emitRustExpr v680 v681 
    let _run_target_args'_v674 = v682 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v683 : string = "format!(\"{:#?}\", $0)"
    let v684 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v683 
    let v685 : string = "fable_library_rust::String_::fromString($0)"
    let v686 : string = Fable.Core.RustInterop.emitRustExpr v684 v685 
    let _run_target_args'_v674 = v686 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v688 : string = $"%A{v8}"
    let _run_target_args'_v674 = v688 
    #endif
#if FABLE_COMPILER_PYTHON
    let v692 : string = $"%A{v8}"
    let _run_target_args'_v674 = v692 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v696 : string = $"%A{v8}"
    let _run_target_args'_v674 = v696 
    #endif
#else
    let v700 : string = $"%A{v8}"
    let _run_target_args'_v674 = v700 
    #endif
    let v703 : string = _run_target_args'_v674 
    method13(v17, v703)
    method13(v17, v84)
    let v741 : string = "seed"
    method13(v17, v741)
    method13(v17, v49)
    method13(v17, v9)
    method13(v17, v84)
    let v798 : string = "seeds"
    method13(v17, v798)
    method13(v17, v49)
    method13(v17, v10)
    method13(v17, v84)
    let v855 : string = "entropy_len"
    method13(v17, v855)
    method13(v17, v49)
    (* run_target_args'
    let v887 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v888 : string = "format!(\"{:#?}\", $0)"
    let v889 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v888 
    let v890 : string = "fable_library_rust::String_::fromString($0)"
    let v891 : string = Fable.Core.RustInterop.emitRustExpr v889 v890 
    let _run_target_args'_v887 = v891 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v892 : string = "format!(\"{:#?}\", $0)"
    let v893 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v892 
    let v894 : string = "fable_library_rust::String_::fromString($0)"
    let v895 : string = Fable.Core.RustInterop.emitRustExpr v893 v894 
    let _run_target_args'_v887 = v895 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v896 : string = "format!(\"{:#?}\", $0)"
    let v897 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v896 
    let v898 : string = "fable_library_rust::String_::fromString($0)"
    let v899 : string = Fable.Core.RustInterop.emitRustExpr v897 v898 
    let _run_target_args'_v887 = v899 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v901 : string = $"%A{v11}"
    let _run_target_args'_v887 = v901 
    #endif
#if FABLE_COMPILER_PYTHON
    let v905 : string = $"%A{v11}"
    let _run_target_args'_v887 = v905 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v909 : string = $"%A{v11}"
    let _run_target_args'_v887 = v909 
    #endif
#else
    let v913 : string = $"%A{v11}"
    let _run_target_args'_v887 = v913 
    #endif
    let v916 : string = _run_target_args'_v887 
    method13(v17, v916)
    method13(v17, v84)
    let v954 : string = "entropy"
    method13(v17, v954)
    method13(v17, v49)
    method13(v17, v12)
    method13(v17, v84)
    let v1011 : string = "hash_u8"
    method13(v17, v1011)
    method13(v17, v49)
    method13(v17, v13)
    method13(v17, v84)
    let v1068 : string = "rolls"
    method13(v17, v1068)
    method13(v17, v49)
    method13(v17, v14)
    let v1111 : string = " }"
    method13(v17, v1111)
    let v1125 : string = v17.l0
    v1125
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method24(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v24 : int64 = v0.l0
    let v27 : string = " "
    let v28 : string = v6 + v27 
    let v32 : string = v28 + v7 
    let v37 : string = " #"
    let v38 : string = v32 + v37 
    let v45 : (int64 -> string) = _.ToString()
    let v46 : string = v45 v24
    let v50 : string = v38 + v46 
    let v54 : string = v50 + v27 
    let v59 : string = "dice_contract.generate_random_number"
    let v60 : string = v54 + v59 
    let v65 : string = " / "
    let v66 : string = v60 + v65 
    let v70 : string = v66 + v23 
    method16(v70)
and closure15 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure2()
    let v30 : unit = (fun () -> v29 (); v28) ()
    let struct (v53 : Mut0, v54 : Mut1, v55 : Mut2, v56 : Mut3, v57 : Mut4, v58 : int64 option) = TraceState.trace_state.Value
    let v71 : US0 = v57.l0
    let v72 : bool = v55.l0
    let v73 : bool = v72 = false
    let v76 : bool =
        if v73 then
            false
        else
            let v74 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v71
            let v75 : bool = 1 >= v74
            v75
    let v77 : bool = v76 = false
    let v392 : US6 =
        if v77 then
            US6_1
        else
            let v93 : unit = ()
            let v94 : unit = (fun () -> v29 (); v93) ()
            let struct (v117 : Mut0, v118 : Mut1, v119 : Mut2, v120 : Mut3, v121 : Mut4, v122 : int64 option) = TraceState.trace_state.Value
            let v135 : string = method6(v117, v118, v119, v120, v121, v122)
            let v136 : string = method10()
            let v138 : string = $"%A{v8}"
            let v141 : string = $"v9.to_string()"
            let v142 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v141 
            let v143 : string = $"v10.to_string()"
            let v144 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v143 
            let v146 : string = $"%A{v4}"
            let v150 : string = $"%A{v0}"
            let v153 : string = "$0.len()"
            let v154 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v153 
            let v156 : string = $"%A{v11}"
            let v160 : string = $"%A{v12}"
            let v163 : uint8 list = []
            let v164 : uint8 list = method22(v13, v163)
            let v170 : (uint8 list -> (uint8 [])) = List.toArray
            let v171 : (uint8 []) = v170 v164
            let v174 : string = "$0.to_vec()"
            let v175 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v171 v174 
            let v177 : string = $"%A{v175}"
            let v180 : string = method23(v117, v118, v119, v120, v121, v122, v135, v136, v3, v1, v2, v7, v6, v5, v138, v142, v144, v146, v150, v154, v156, v160, v177)
            let v195 : unit = ()
            let v196 : unit = (fun () -> v29 (); v195) ()
            let struct (v219 : Mut0, v220 : Mut1, v221 : Mut2, v222 : Mut3, v223 : Mut4, v224 : int64 option) = TraceState.trace_state.Value
            let v239 : unit = ()
            let v240 : (unit -> unit) = closure6(v219)
            let v241 : unit = (fun () -> v240 (); v239) ()
            let v244 : (string -> unit) = closure7()
            (* run_target_args'
            let v245 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v246 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v180 v246 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v247 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v180 v247 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v248 : string = v222.l0
            let v249 : bool = v248 = ""
            let v264 : string =
                if v249 then
                    v180
                else
                    let v250 : bool = v180 = ""
                    if v250 then
                        let v251 : string = v222.l0
                        v251
                    else
                        let v252 : string = v222.l0
                        let v255 : string = "\n"
                        let v256 : string = v252 + v255 
                        let v260 : string = v256 + v180 
                        v260
            (* run_target_args'
            let v269 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v270 : string = "&*$0"
            let v271 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v264 v270 
            let _run_target_args'_v269 = v271 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v272 : string = "&*$0"
            let v273 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v264 v272 
            let _run_target_args'_v269 = v273 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v274 : string = "&*$0"
            let v275 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v264 v274 
            let _run_target_args'_v269 = v275 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v277 : Ref<Str> = v264 |> unbox<Ref<Str>>
            let _run_target_args'_v269 = v277 
            #endif
#if FABLE_COMPILER_PYTHON
            let v281 : Ref<Str> = v264 |> unbox<Ref<Str>>
            let _run_target_args'_v269 = v281 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v285 : Ref<Str> = v264 |> unbox<Ref<Str>>
            let _run_target_args'_v269 = v285 
            #endif
#else
            let v289 : Ref<Str> = v264 |> unbox<Ref<Str>>
            let _run_target_args'_v269 = v289 
            #endif
            let v292 : Ref<Str> = _run_target_args'_v269 
            let v301 : string = $"$0.chars()"
            let v302 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v292 v301 
            let v303 : string = "$0"
            let v304 : _ = Fable.Core.RustInterop.emitRustExpr v302 v303 
            let v305 : string = "$0.collect::<Vec<_>>()"
            let v306 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v304 v305 
            let v307 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v308 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v306 v307 
            let v309 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v310 : bool = Fable.Core.RustInterop.emitRustExpr v308 v309 
            let v311 : string = "x"
            let v312 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v311 
            let v313 : string = "String::from_iter($0)"
            let v314 : std_string_String = Fable.Core.RustInterop.emitRustExpr v312 v313 
            let v315 : string = "true; $0 }).collect::<Vec<_>>()"
            let v316 : bool = Fable.Core.RustInterop.emitRustExpr v314 v315 
            let v317 : string = "_vec_map"
            let v318 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v317 
            let v319 : string = "$0.len()"
            let v320 : unativeint = Fable.Core.RustInterop.emitRustExpr v318 v319 
            let v364 : int32 = v320 |> int32 
            let v374 : string = ""
            let v375 : bool = v180 <> v374 
            let v379 : bool =
                if v375 then
                    let v378 : bool = v364 <= 1
                    v378
                else
                    false
            if v379 then
                v222.l0 <- v264
                ()
            else
                v222.l0 <- v374
                let v380 : string = "true; $0.into_iter().for_each(|x| { //"
                let v381 : bool = Fable.Core.RustInterop.emitRustExpr v318 v380 
                let v382 : string = "x"
                let v383 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v382 
                let v384 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v385 : bool = Fable.Core.RustInterop.emitRustExpr v383 v384 
                let v386 : string = $"true"
                let v387 : bool = Fable.Core.RustInterop.emitRustExpr () v386 
                let v388 : string = "true; }); //"
                let v389 : bool = Fable.Core.RustInterop.emitRustExpr () v388 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v244 v180
            #endif
#if FABLE_COMPILER_PYTHON
            v244 v180
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v244 v180
            #endif
#else
            v244 v180
            #endif
            // run_target_args' is_unit
            let v390 : (string -> unit) = v220.l0
            v390 v180
            US6_0(v219, v220, v221, v222, v223, v224)
    
    ()
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
and closure16 (v0 : UH1) () : UH1 =
    v0
and closure17 (v0 : UH1, v1 : Mut5) () : UH1 =
    let v2 : US7 = v1.l0
    match v2 with
    | US7_1(v3) -> (* Computed *)
        v3
    | US7_0(v4) -> (* NotComputed *)
        let v5 : UH1 = v4 ()
        let v12 : UH1 =
            match v5 with
            | UH1_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH1) = method27(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US7 = US7_1(v12)
        v1.l0 <- v13
        v12
and method27 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US7 = US7_0(v1)
    let v3 : Mut5 = {l0 = v2} : Mut5
    closure17(v0, v3)
and method30 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method12()
    let v5 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    method13(v5, v7)
    let v22 : string = "max"
    method13(v5, v22)
    let v37 : string = " = "
    method13(v5, v37)
    let v55 : string = $"{v0}"
    method13(v5, v55)
    let v72 : string = "; "
    method13(v5, v72)
    let v87 : string = "p"
    method13(v5, v87)
    method13(v5, v37)
    let v119 : string = $"{v1}"
    method13(v5, v119)
    method13(v5, v72)
    let v150 : string = "n"
    method13(v5, v150)
    method13(v5, v37)
    let v182 : string = $"{v2}"
    method13(v5, v182)
    let v199 : string = " }"
    method13(v5, v199)
    let v213 : string = v5.l0
    v213
and method29 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method30(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v33 : (int64 -> string) = _.ToString()
    let v34 : string = v33 v12
    let v38 : string = v26 + v34 
    let v42 : string = v38 + v15 
    let v47 : string = "dice.calculate_dice_count"
    let v48 : string = v42 + v47 
    let v53 : string = " / "
    let v54 : string = v48 + v53 
    let v58 : string = v54 + v11 
    method16(v58)
and closure18 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure2()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US0 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v338 : US6 =
        if v66 then
            US6_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut0, v107 : Mut1, v108 : Mut2, v109 : Mut3, v110 : Mut4, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method6(v106, v107, v108, v109, v110, v111)
            let v125 : string = method10()
            let v126 : string = method29(v106, v107, v108, v109, v110, v111, v124, v125, v0, v2, v1)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut0, v166 : Mut1, v167 : Mut2, v168 : Mut3, v169 : Mut4, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure6(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure7()
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
            let v310 : int32 = v266 |> int32 
            let v320 : string = ""
            let v321 : bool = v126 <> v320 
            let v325 : bool =
                if v321 then
                    let v324 : bool = v310 <= 1
                    v324
                else
                    false
            if v325 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v320
                let v326 : string = "true; $0.into_iter().for_each(|x| { //"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr v264 v326 
                let v328 : string = "x"
                let v329 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v328 
                let v330 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr v329 v330 
                let v332 : string = $"true"
                let v333 : bool = Fable.Core.RustInterop.emitRustExpr () v332 
                let v334 : string = "true; }); //"
                let v335 : bool = Fable.Core.RustInterop.emitRustExpr () v334 
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
            let v336 : (string -> unit) = v166.l0
            v336 v126
            US6_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method28 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method28(v0, v6, v4)
        else
            let v357 : unit = ()
            let v358 : (unit -> unit) = closure18(v0, v1, v2)
            let v359 : unit = (fun () -> v358 (); v357) ()
            v1
    else
        let v1062 : unit = ()
        let v1063 : (unit -> unit) = closure18(v0, v1, v2)
        let v1064 : unit = (fun () -> v1063 (); v1062) ()
        v1
and method34 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method12()
    let v6 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    method13(v6, v8)
    let v23 : string = "current_index"
    method13(v6, v23)
    let v38 : string = " = "
    method13(v6, v38)
    let v56 : string = $"{v0}"
    method13(v6, v56)
    let v73 : string = "; "
    method13(v6, v73)
    let v88 : string = "acc"
    method13(v6, v88)
    method13(v6, v38)
    let v120 : string = $"{v1}"
    method13(v6, v120)
    method13(v6, v73)
    let v151 : string = "len"
    method13(v6, v151)
    method13(v6, v38)
    let v183 : string = $"{v2}"
    method13(v6, v183)
    method13(v6, v73)
    let v214 : string = "last_item"
    method13(v6, v214)
    method13(v6, v38)
    method13(v6, v3)
    let v257 : string = " }"
    method13(v6, v257)
    let v271 : string = v6.l0
    v271
and method33 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method34(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v34 : (int64 -> string) = _.ToString()
    let v35 : string = v34 v13
    let v39 : string = v27 + v35 
    let v43 : string = v39 + v16 
    let v48 : string = "dice.create_sequential_roller / roll"
    let v49 : string = v43 + v48 
    let v54 : string = " / "
    let v55 : string = v49 + v54 
    let v59 : string = v55 + v12 
    method16(v59)
and closure19 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure2()
    let v20 : unit = (fun () -> v19 (); v18) ()
    let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
    let v61 : US0 = v47.l0
    let v62 : bool = v45.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    let v67 : bool = v66 = false
    let v343 : US6 =
        if v67 then
            US6_1
        else
            let v83 : unit = ()
            let v84 : unit = (fun () -> v19 (); v83) ()
            let struct (v107 : Mut0, v108 : Mut1, v109 : Mut2, v110 : Mut3, v111 : Mut4, v112 : int64 option) = TraceState.trace_state.Value
            let v125 : string = method6(v107, v108, v109, v110, v111, v112)
            let v126 : string = method10()
            let v128 : string = $"%A{v3}"
            let v131 : string = method33(v107, v108, v109, v110, v111, v112, v125, v126, v0, v1, v2, v128)
            let v146 : unit = ()
            let v147 : unit = (fun () -> v19 (); v146) ()
            let struct (v170 : Mut0, v171 : Mut1, v172 : Mut2, v173 : Mut3, v174 : Mut4, v175 : int64 option) = TraceState.trace_state.Value
            let v190 : unit = ()
            let v191 : (unit -> unit) = closure6(v170)
            let v192 : unit = (fun () -> v191 (); v190) ()
            let v195 : (string -> unit) = closure7()
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
            let v315 : int32 = v271 |> int32 
            let v325 : string = ""
            let v326 : bool = v131 <> v325 
            let v330 : bool =
                if v326 then
                    let v329 : bool = v315 <= 1
                    v329
                else
                    false
            if v330 then
                v173.l0 <- v215
                ()
            else
                v173.l0 <- v325
                let v331 : string = "true; $0.into_iter().for_each(|x| { //"
                let v332 : bool = Fable.Core.RustInterop.emitRustExpr v269 v331 
                let v333 : string = "x"
                let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v333 
                let v335 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v336 : bool = Fable.Core.RustInterop.emitRustExpr v334 v335 
                let v337 : string = $"true"
                let v338 : bool = Fable.Core.RustInterop.emitRustExpr () v337 
                let v339 : string = "true; }); //"
                let v340 : bool = Fable.Core.RustInterop.emitRustExpr () v339 
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
            let v341 : (string -> unit) = v171.l0
            v341 v131
            US6_0(v170, v171, v172, v173, v174, v175)
    
    ()
and method35 (v0 : int64, v1 : UH1) : US8 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US8_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method35(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US8_1
and method37 () : string =
    let v0 : string = method12()
    let v2 : Mut3 = {l0 = v0} : Mut3
    let v3 : string = v2.l0
    v3
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method37()
    let v9 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v17 : string = v13 + v7 
    let v22 : string = " #"
    let v23 : string = v17 + v22 
    let v30 : (int64 -> string) = _.ToString()
    let v31 : string = v30 v9
    let v35 : string = v23 + v31 
    let v39 : string = v35 + v12 
    let v44 : string = "dice.create_sequential_roller / roll / None"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v8 
    method16(v55)
and closure20 () () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure2()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = TraceState.trace_state.Value
    let v57 : US0 = v43.l0
    let v58 : bool = v41.l0
    let v59 : bool = v58 = false
    let v62 : bool =
        if v59 then
            false
        else
            let v60 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v57
            let v61 : bool = 1 >= v60
            v61
    let v63 : bool = v62 = false
    let v335 : US6 =
        if v63 then
            US6_1
        else
            let v79 : unit = ()
            let v80 : unit = (fun () -> v15 (); v79) ()
            let struct (v103 : Mut0, v104 : Mut1, v105 : Mut2, v106 : Mut3, v107 : Mut4, v108 : int64 option) = TraceState.trace_state.Value
            let v121 : string = method6(v103, v104, v105, v106, v107, v108)
            let v122 : string = method10()
            let v123 : string = method36(v103, v104, v105, v106, v107, v108, v121, v122)
            let v138 : unit = ()
            let v139 : unit = (fun () -> v15 (); v138) ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : Mut4, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure6(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : (string -> unit) = closure7()
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
            let v307 : int32 = v263 |> int32 
            let v317 : string = ""
            let v318 : bool = v123 <> v317 
            let v322 : bool =
                if v318 then
                    let v321 : bool = v307 <= 1
                    v321
                else
                    false
            if v322 then
                v165.l0 <- v207
                ()
            else
                v165.l0 <- v317
                let v323 : string = "true; $0.into_iter().for_each(|x| { //"
                let v324 : bool = Fable.Core.RustInterop.emitRustExpr v261 v323 
                let v325 : string = "x"
                let v326 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v325 
                let v327 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v328 : bool = Fable.Core.RustInterop.emitRustExpr v326 v327 
                let v329 : string = $"true"
                let v330 : bool = Fable.Core.RustInterop.emitRustExpr () v329 
                let v331 : string = "true; }); //"
                let v332 : bool = Fable.Core.RustInterop.emitRustExpr () v331 
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
            let v333 : (string -> unit) = v163.l0
            v333 v123
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
and method32 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US8 = v4.l0
    let v19 : uint8 option =
        match v8 with
        | US8_1 -> (* None *)
            let v15 : uint8 option = None
            v15
        | US8_0(v9) -> (* Some *)
            let v11 : uint8 option = Some v9 
            v11
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure19(v5, v6, v7, v19)
    let v375 : unit = (fun () -> v374 (); v373) ()
    let v732 : UH1 = v0 ()
    let v733 : int64 = v1.l0
    let v734 : US8 = method35(v733, v732)
    match v734 with
    | US8_1 -> (* None *)
        let v1088 : unit = ()
        let v1089 : (unit -> unit) = closure20()
        let v1090 : unit = (fun () -> v1089 (); v1088) ()
        let v1443 : int64 = v3.l0
        let v1444 : bool = v1443 = -1L
        if v1444 then
            let v1445 : int64 = v1.l0
            v3.l0 <- v1445
            ()
        let v1446 : int64 = v2.l0
        let v1447 : int64 = v3.l0
        let v1448 : bool = v1446 >= v1447
        let v1451 : int64 =
            if v1448 then
                1L
            else
                let v1449 : int64 = v2.l0
                let v1450 : int64 = v1449 + 1L
                v1450
        v2.l0 <- v1451
        let v1452 : int64 = v2.l0
        let v1453 : int64 = v1452 - 1L
        v1.l0 <- v1453
        let v1454 : US8 = US8_1
        v4.l0 <- v1454
        method32(v0, v1, v2, v3, v4)
    | US8_0(v735) -> (* Some *)
        let v736 : int64 = v1.l0
        let v737 : int64 = v736 + 1L
        v1.l0 <- v737
        let v738 : US8 = US8_0(v735)
        v4.l0 <- v738
        v735
and method40 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method12()
    let v5 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    method13(v5, v7)
    let v22 : string = "power"
    method13(v5, v22)
    let v37 : string = " = "
    method13(v5, v37)
    let v55 : string = $"{v0}"
    method13(v5, v55)
    let v72 : string = "; "
    method13(v5, v72)
    let v87 : string = "acc"
    method13(v5, v87)
    method13(v5, v37)
    let v119 : string = $"{v1}"
    method13(v5, v119)
    method13(v5, v72)
    let v150 : string = "result"
    method13(v5, v150)
    method13(v5, v37)
    let v182 : string = $"{v2}"
    method13(v5, v182)
    let v199 : string = " }"
    method13(v5, v199)
    let v213 : string = v5.l0
    v213
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method40(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v33 : (int64 -> string) = _.ToString()
    let v34 : string = v33 v12
    let v38 : string = v26 + v34 
    let v42 : string = v38 + v15 
    let v47 : string = "dice.accumulate_dice_rolls"
    let v48 : string = v42 + v47 
    let v53 : string = " / "
    let v54 : string = v48 + v53 
    let v58 : string = v54 + v11 
    method16(v58)
and closure21 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure2()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US0 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v338 : US6 =
        if v66 then
            US6_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut0, v107 : Mut1, v108 : Mut2, v109 : Mut3, v110 : Mut4, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method6(v106, v107, v108, v109, v110, v111)
            let v125 : string = method10()
            let v126 : string = method39(v106, v107, v108, v109, v110, v111, v124, v125, v1, v0, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut0, v166 : Mut1, v167 : Mut2, v168 : Mut3, v169 : Mut4, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure6(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure7()
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
            let v310 : int32 = v266 |> int32 
            let v320 : string = ""
            let v321 : bool = v126 <> v320 
            let v325 : bool =
                if v321 then
                    let v324 : bool = v310 <= 1
                    v324
                else
                    false
            if v325 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v320
                let v326 : string = "true; $0.into_iter().for_each(|x| { //"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr v264 v326 
                let v328 : string = "x"
                let v329 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v328 
                let v330 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr v329 v330 
                let v332 : string = $"true"
                let v333 : bool = Fable.Core.RustInterop.emitRustExpr () v332 
                let v334 : string = "true; }); //"
                let v335 : bool = Fable.Core.RustInterop.emitRustExpr () v334 
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
            let v336 : (string -> unit) = v166.l0
            v336 v126
            US6_0(v165, v166, v167, v168, v169, v170)
    
    ()
and closure85 () () : UH2 =
    UH2_1
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(9223372036854775808UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(4611686018427387904UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(6917529027641081856UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(1152921504606846976UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(15564440312192434176UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(11817445422220181504UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(5044031582654955520UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(6989586621679009792UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(16537217831704461312UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(11979575008805519360UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(14294425217273954304UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(2382404202878992384UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(6545982058383015936UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(10314369046585278464UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(4793518853382471680UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(3873377154515337216UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(645562859085889536UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(107593809847648256UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(3092389647259533312UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(9738770311398031360UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(16995415113324298240UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(8981483876790566912UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(13794743361938128896UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(2299123893656354816UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(3457644661227651072UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(576274110204608512UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(6244960376270618624UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(13338656111851470848UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(14520938734448279552UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(14717985838214414336UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(5527454985320660992UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(16293529225644736512UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(11938960241128898560UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(8138741398091333632UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(7505371590918406144UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(16623181993244360704UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(8919445023443910656UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(4561031516192243712UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(9983543956220149760UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(4738381338321616896UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(789730223053602816UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(131621703842267136UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(21936950640377856UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(3656158440062976UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(609359740010496UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(101559956668416UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(16926659444736UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(2821109907456UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(470184984576UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(78364164096UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(13060694016UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(2176782336UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(362797056UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(60466176UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(10077696UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(1679616UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(279936UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(46656UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(7776UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(1296UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(216UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(36UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_0(6UL, v0)
and method41 (v0 : int8, v1 : UH2) : US10 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US10_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method41(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US10_1
and method43 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method12()
    let v6 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    method13(v6, v8)
    let v23 : string = "power"
    method13(v6, v23)
    let v38 : string = " = "
    method13(v6, v38)
    let v56 : string = $"{v0}"
    method13(v6, v56)
    let v73 : string = "; "
    method13(v6, v73)
    let v88 : string = "acc"
    method13(v6, v88)
    method13(v6, v38)
    let v120 : string = $"{v1}"
    method13(v6, v120)
    method13(v6, v73)
    let v151 : string = "roll"
    method13(v6, v151)
    method13(v6, v38)
    let v183 : string = $"{v2}"
    method13(v6, v183)
    method13(v6, v73)
    let v214 : string = "value"
    method13(v6, v214)
    method13(v6, v38)
    let v246 : string = $"{v3}"
    method13(v6, v246)
    let v263 : string = " }"
    method13(v6, v263)
    let v277 : string = v6.l0
    v277
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method43(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v34 : (int64 -> string) = _.ToString()
    let v35 : string = v34 v13
    let v39 : string = v27 + v35 
    let v43 : string = v39 + v16 
    let v48 : string = "dice.accumulate_dice_rolls"
    let v49 : string = v43 + v48 
    let v54 : string = " / "
    let v55 : string = v49 + v54 
    let v59 : string = v55 + v12 
    method16(v59)
and closure86 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure2()
    let v20 : unit = (fun () -> v19 (); v18) ()
    let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
    let v61 : US0 = v47.l0
    let v62 : bool = v45.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    let v67 : bool = v66 = false
    let v339 : US6 =
        if v67 then
            US6_1
        else
            let v83 : unit = ()
            let v84 : unit = (fun () -> v19 (); v83) ()
            let struct (v107 : Mut0, v108 : Mut1, v109 : Mut2, v110 : Mut3, v111 : Mut4, v112 : int64 option) = TraceState.trace_state.Value
            let v125 : string = method6(v107, v108, v109, v110, v111, v112)
            let v126 : string = method10()
            let v127 : string = method42(v107, v108, v109, v110, v111, v112, v125, v126, v1, v0, v2, v3)
            let v142 : unit = ()
            let v143 : unit = (fun () -> v19 (); v142) ()
            let struct (v166 : Mut0, v167 : Mut1, v168 : Mut2, v169 : Mut3, v170 : Mut4, v171 : int64 option) = TraceState.trace_state.Value
            let v186 : unit = ()
            let v187 : (unit -> unit) = closure6(v166)
            let v188 : unit = (fun () -> v187 (); v186) ()
            let v191 : (string -> unit) = closure7()
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
            let v311 : int32 = v267 |> int32 
            let v321 : string = ""
            let v322 : bool = v127 <> v321 
            let v326 : bool =
                if v322 then
                    let v325 : bool = v311 <= 1
                    v325
                else
                    false
            if v326 then
                v169.l0 <- v211
                ()
            else
                v169.l0 <- v321
                let v327 : string = "true; $0.into_iter().for_each(|x| { //"
                let v328 : bool = Fable.Core.RustInterop.emitRustExpr v265 v327 
                let v329 : string = "x"
                let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v329 
                let v331 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v332 : bool = Fable.Core.RustInterop.emitRustExpr v330 v331 
                let v333 : string = $"true"
                let v334 : bool = Fable.Core.RustInterop.emitRustExpr () v333 
                let v335 : string = "true; }); //"
                let v336 : bool = Fable.Core.RustInterop.emitRustExpr () v335 
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
            let v337 : (string -> unit) = v167.l0
            v337 v127
            US6_0(v166, v167, v168, v169, v170, v171)
    
    ()
and method45 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method12()
    let v5 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    method13(v5, v7)
    let v22 : string = "power"
    method13(v5, v22)
    let v37 : string = " = "
    method13(v5, v37)
    let v55 : string = $"{v0}"
    method13(v5, v55)
    let v72 : string = "; "
    method13(v5, v72)
    let v87 : string = "acc"
    method13(v5, v87)
    method13(v5, v37)
    let v119 : string = $"{v1}"
    method13(v5, v119)
    method13(v5, v72)
    let v150 : string = "roll"
    method13(v5, v150)
    method13(v5, v37)
    let v182 : string = $"{v2}"
    method13(v5, v182)
    let v199 : string = " }"
    method13(v5, v199)
    let v213 : string = v5.l0
    v213
and method44 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method45(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v33 : (int64 -> string) = _.ToString()
    let v34 : string = v33 v12
    let v38 : string = v26 + v34 
    let v42 : string = v38 + v15 
    let v47 : string = "dice.accumulate_dice_rolls"
    let v48 : string = v42 + v47 
    let v53 : string = " / "
    let v54 : string = v48 + v53 
    let v58 : string = v54 + v11 
    method16(v58)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure2()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US0 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v338 : US6 =
        if v66 then
            US6_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut0, v107 : Mut1, v108 : Mut2, v109 : Mut3, v110 : Mut4, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method6(v106, v107, v108, v109, v110, v111)
            let v125 : string = method10()
            let v126 : string = method44(v106, v107, v108, v109, v110, v111, v124, v125, v1, v0, v2)
            let v141 : unit = ()
            let v142 : unit = (fun () -> v18 (); v141) ()
            let struct (v165 : Mut0, v166 : Mut1, v167 : Mut2, v168 : Mut3, v169 : Mut4, v170 : int64 option) = TraceState.trace_state.Value
            let v185 : unit = ()
            let v186 : (unit -> unit) = closure6(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure7()
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
            let v310 : int32 = v266 |> int32 
            let v320 : string = ""
            let v321 : bool = v126 <> v320 
            let v325 : bool =
                if v321 then
                    let v324 : bool = v310 <= 1
                    v324
                else
                    false
            if v325 then
                v168.l0 <- v210
                ()
            else
                v168.l0 <- v320
                let v326 : string = "true; $0.into_iter().for_each(|x| { //"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr v264 v326 
                let v328 : string = "x"
                let v329 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v328 
                let v330 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr v329 v330 
                let v332 : string = $"true"
                let v333 : bool = Fable.Core.RustInterop.emitRustExpr () v332 
                let v334 : string = "true; }); //"
                let v335 : bool = Fable.Core.RustInterop.emitRustExpr () v334 
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
            let v336 : (string -> unit) = v166.l0
            v336 v126
            US6_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method38 (v0 : int8, v1 : UH0, v2 : uint64) : US9 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v354 : unit = ()
        let v355 : (unit -> unit) = closure21(v2, v0, v4)
        let v356 : unit = (fun () -> v355 (); v354) ()
        US9_0(v4, v1)
    else
        match v1 with
        | UH0_1(v711, v712) -> (* Cons *)
            let v713 : bool = v711 > 1uy
            if v713 then
                let v714 : uint64 = 1UL
                let v715 : (unit -> UH2) = closure22()
                let v716 : UH2 = UH2_0(v714, v715)
                let v717 : US10 = method41(v0, v716)
                let v721 : uint64 =
                    match v717 with
                    | US10_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US10_0(v718) -> (* Some *)
                        v718
                let v722 : uint8 = v711 - 1uy
                let v723 : uint64 = uint64 v722
                let v724 : uint64 = v723 * v721
                let v1074 : unit = ()
                let v1075 : (unit -> unit) = closure86(v2, v0, v711, v724)
                let v1076 : unit = (fun () -> v1075 (); v1074) ()
                let v1429 : uint64 = v2 + v724
                let v1430 : int8 = v0 - 1y
                method38(v1430, v712, v1429)
            else
                let v1781 : unit = ()
                let v1782 : (unit -> unit) = closure87(v2, v0, v711)
                let v1783 : unit = (fun () -> v1782 (); v1781) ()
                let v2136 : int8 = v0 - 1y
                method38(v2136, v712, v2)
        | UH0_0 -> (* Nil *)
            US9_1
and method46 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut6, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method32(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method46(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method47 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method32(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method31(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US9 = method38(v6, v7, v13)
        match v14 with
        | US9_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method46(v6, v0, v1, v2, v3, v4, v18)
                method47(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method46(v6, v0, v1, v2, v3, v4, v22)
            method47(v0, v1, v2, v3, v4, v5, v6, v23)
and method31 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method32(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method31(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US9 = method38(v6, v7, v15)
        match v16 with
        | US9_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method46(v6, v0, v1, v2, v3, v4, v20)
                method47(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method46(v6, v0, v1, v2, v3, v4, v24)
            method47(v0, v1, v2, v3, v4, v5, v6, v25)
and method48 () : (unit -> unit) =
    closure9()
and closure88 (v0 : (unit -> unit)) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure2()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v334 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v138 : unit = ()
            let v139 : unit = (fun () -> v16 (); v138) ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : Mut4, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure6(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure7()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v165.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v187
                else
                    let v194 : bool = v187 = ""
                    if v194 then
                        let v195 : string = v165.l0
                        v195
                    else
                        let v196 : string = v165.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v187 
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
            let v308 : int32 = v264 |> int32 
            let v317 : bool = v187 <> v187 
            let v321 : bool =
                if v317 then
                    let v320 : bool = v308 <= 1
                    v320
                else
                    false
            if v321 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v322 : string = "true; $0.into_iter().for_each(|x| { //"
                let v323 : bool = Fable.Core.RustInterop.emitRustExpr v262 v322 
                let v324 : string = "x"
                let v325 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v324 
                let v326 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr v325 v326 
                let v328 : string = $"true"
                let v329 : bool = Fable.Core.RustInterop.emitRustExpr () v328 
                let v330 : string = "true; }); //"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr () v330 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v187
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#else
            v188 v187
            #endif
            // run_target_args' is_unit
            let v332 : (string -> unit) = v163.l0
            v332 v187
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
and method49 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method49(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method51 (v0 : uint64, v1 : string, v2 : string) : string =
    let v3 : string = method12()
    let v5 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    method13(v5, v7)
    let v22 : string = "max"
    method13(v5, v22)
    let v37 : string = " = "
    method13(v5, v37)
    let v55 : string = $"{v0}"
    method13(v5, v55)
    let v72 : string = "; "
    method13(v5, v72)
    let v87 : string = "rolls"
    method13(v5, v87)
    method13(v5, v37)
    method13(v5, v1)
    method13(v5, v72)
    let v144 : string = "result"
    method13(v5, v144)
    method13(v5, v37)
    method13(v5, v2)
    let v187 : string = " }"
    method13(v5, v187)
    let v201 : string = v5.l0
    v201
and method50 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method51(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v20 : string = v16 + v7 
    let v25 : string = " #"
    let v26 : string = v20 + v25 
    let v33 : (int64 -> string) = _.ToString()
    let v34 : string = v33 v12
    let v38 : string = v26 + v34 
    let v42 : string = v38 + v15 
    let v47 : string = "dice_contract.roll_within_bounds"
    let v48 : string = v42 + v47 
    let v53 : string = " / "
    let v54 : string = v48 + v53 
    let v58 : string = v54 + v11 
    method16(v58)
and closure89 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure2()
    let v19 : unit = (fun () -> v18 (); v17) ()
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : Mut4, v47 : int64 option) = TraceState.trace_state.Value
    let v60 : US0 = v46.l0
    let v61 : bool = v44.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 1 >= v63
            v64
    let v66 : bool = v65 = false
    let v346 : US6 =
        if v66 then
            US6_1
        else
            let v82 : unit = ()
            let v83 : unit = (fun () -> v18 (); v82) ()
            let struct (v106 : Mut0, v107 : Mut1, v108 : Mut2, v109 : Mut3, v110 : Mut4, v111 : int64 option) = TraceState.trace_state.Value
            let v124 : string = method6(v106, v107, v108, v109, v110, v111)
            let v125 : string = method10()
            let v127 : string = $"%A{v1}"
            let v131 : string = $"%A{v2}"
            let v134 : string = method50(v106, v107, v108, v109, v110, v111, v124, v125, v0, v127, v131)
            let v149 : unit = ()
            let v150 : unit = (fun () -> v18 (); v149) ()
            let struct (v173 : Mut0, v174 : Mut1, v175 : Mut2, v176 : Mut3, v177 : Mut4, v178 : int64 option) = TraceState.trace_state.Value
            let v193 : unit = ()
            let v194 : (unit -> unit) = closure6(v173)
            let v195 : unit = (fun () -> v194 (); v193) ()
            let v198 : (string -> unit) = closure7()
            (* run_target_args'
            let v199 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v200 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v134 v200 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v201 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v134 v201 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v202 : string = v176.l0
            let v203 : bool = v202 = ""
            let v218 : string =
                if v203 then
                    v134
                else
                    let v204 : bool = v134 = ""
                    if v204 then
                        let v205 : string = v176.l0
                        v205
                    else
                        let v206 : string = v176.l0
                        let v209 : string = "\n"
                        let v210 : string = v206 + v209 
                        let v214 : string = v210 + v134 
                        v214
            (* run_target_args'
            let v223 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v224 : string = "&*$0"
            let v225 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v218 v224 
            let _run_target_args'_v223 = v225 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v226 : string = "&*$0"
            let v227 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v218 v226 
            let _run_target_args'_v223 = v227 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v228 : string = "&*$0"
            let v229 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v218 v228 
            let _run_target_args'_v223 = v229 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v231 : Ref<Str> = v218 |> unbox<Ref<Str>>
            let _run_target_args'_v223 = v231 
            #endif
#if FABLE_COMPILER_PYTHON
            let v235 : Ref<Str> = v218 |> unbox<Ref<Str>>
            let _run_target_args'_v223 = v235 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v239 : Ref<Str> = v218 |> unbox<Ref<Str>>
            let _run_target_args'_v223 = v239 
            #endif
#else
            let v243 : Ref<Str> = v218 |> unbox<Ref<Str>>
            let _run_target_args'_v223 = v243 
            #endif
            let v246 : Ref<Str> = _run_target_args'_v223 
            let v255 : string = $"$0.chars()"
            let v256 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v246 v255 
            let v257 : string = "$0"
            let v258 : _ = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "$0.collect::<Vec<_>>()"
            let v260 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v262 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v265 : string = "x"
            let v266 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "String::from_iter($0)"
            let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : string = "true; $0 }).collect::<Vec<_>>()"
            let v270 : bool = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "_vec_map"
            let v272 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v271 
            let v273 : string = "$0.len()"
            let v274 : unativeint = Fable.Core.RustInterop.emitRustExpr v272 v273 
            let v318 : int32 = v274 |> int32 
            let v328 : string = ""
            let v329 : bool = v134 <> v328 
            let v333 : bool =
                if v329 then
                    let v332 : bool = v318 <= 1
                    v332
                else
                    false
            if v333 then
                v176.l0 <- v218
                ()
            else
                v176.l0 <- v328
                let v334 : string = "true; $0.into_iter().for_each(|x| { //"
                let v335 : bool = Fable.Core.RustInterop.emitRustExpr v272 v334 
                let v336 : string = "x"
                let v337 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v336 
                let v338 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v339 : bool = Fable.Core.RustInterop.emitRustExpr v337 v338 
                let v340 : string = $"true"
                let v341 : bool = Fable.Core.RustInterop.emitRustExpr () v340 
                let v342 : string = "true; }); //"
                let v343 : bool = Fable.Core.RustInterop.emitRustExpr () v342 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v198 v134
            #endif
#if FABLE_COMPILER_PYTHON
            v198 v134
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v198 v134
            #endif
#else
            v198 v134
            #endif
            // run_target_args' is_unit
            let v344 : (string -> unit) = v174.l0
            v344 v134
            US6_0(v173, v174, v175, v176, v177, v178)
    
    ()
and method52 () : (unit -> unit) =
    closure9()
and closure90 (v0 : (unit -> unit)) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure2()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v334 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v138 : unit = ()
            let v139 : unit = (fun () -> v16 (); v138) ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : Mut4, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure6(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure7()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v165.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v187
                else
                    let v194 : bool = v187 = ""
                    if v194 then
                        let v195 : string = v165.l0
                        v195
                    else
                        let v196 : string = v165.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v187 
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
            let v308 : int32 = v264 |> int32 
            let v317 : bool = v187 <> v187 
            let v321 : bool =
                if v317 then
                    let v320 : bool = v308 <= 1
                    v320
                else
                    false
            if v321 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v322 : string = "true; $0.into_iter().for_each(|x| { //"
                let v323 : bool = Fable.Core.RustInterop.emitRustExpr v262 v322 
                let v324 : string = "x"
                let v325 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v324 
                let v326 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v327 : bool = Fable.Core.RustInterop.emitRustExpr v325 v326 
                let v328 : string = $"true"
                let v329 : bool = Fable.Core.RustInterop.emitRustExpr () v328 
                let v330 : string = "true; }); //"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr () v330 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v187
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#else
            v188 v187
            #endif
            // run_target_args' is_unit
            let v332 : (string -> unit) = v163.l0
            v332 v187
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
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
    let v106 : int32 = v62 |> int32 
    let v115 : unativeint = 100 |> unativeint 
    let v161 : int32 = v115 |> int32 
    let v169 : int32 = v106 - v161
    let v170 : bool = v169 > 0
    if v170 then
        let v171 : string = "v56.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v172 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v169 v171 
        let v526 : unit = ()
        let v527 : (unit -> unit) = closure1(v169, v172)
        let v528 : unit = (fun () -> v527 (); v526) ()
        ()
    let v885 : (unit -> unit) = method17()
    let v1233 : unit = ()
    let v1234 : (unit -> unit) = closure10(v885)
    let v1235 : unit = (fun () -> v1234 (); v1233) ()
    let v1586 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1586 
    let v1587 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1587 
    let v1588 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1588 
    let v1589 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1589 
    let v1590 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v1591 : bool = Fable.Core.RustInterop.emitRustExpr () v1590 
    let v1592 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v1593 : bool = Fable.Core.RustInterop.emitRustExpr () v1592 
    let v1594 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1594 
    let v1595 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1595 
    let v1596 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v1596 
    let v1597 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v1597 
    let v1598 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1598 
    let v1599 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1599 
    let v1600 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v1601 : bool = Fable.Core.RustInterop.emitRustExpr () v1600 
    let v1602 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v1603 : bool = Fable.Core.RustInterop.emitRustExpr () v1602 
    let v1604 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1604 
    let v1605 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1605 
    let v1606 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v1606 
    let v1607 : string = $"key"
    let v1608 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1607 
    let v1609 : string = $"proof"
    let v1610 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1609 
    let v1611 : string = $"max"
    let v1612 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1611 
    let v1613 : string = $"&mut self.0.1"
    let v1614 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v1613 
    let v1615 : string = $"near_sdk::env::random_seed()"
    let v1616 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1615 
    let v1617 : string = $"near_sdk::env::epoch_height()"
    let v1618 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1617 
    let v1619 : string = $"near_sdk::env::block_height()"
    let v1620 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1619 
    let v1621 : string = $"near_sdk::env::block_timestamp()"
    let v1622 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1621 
    let v1623 : string = $"near_sdk::env::account_balance()"
    let v1624 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v1623 
    let v1625 : string = $"near_sdk::env::signer_account_id()"
    let v1626 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v1625 
    let v1627 : string = $"near_sdk::env::predecessor_account_id()"
    let v1628 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v1627 
    let v1629 : string = $"&*v1614"
    let v1630 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1629 
    let v1631 : string = $"v1630.iter().map(|x| *x).collect::<Vec<_>>()"
    let v1632 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1631 
    let v1633 : string = $"v1618.to_le_bytes()"
    let v1634 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1633 
    let v1635 : string = $"v1634.to_vec()"
    let v1636 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1635 
    let v1637 : string = $"v1620.to_le_bytes()"
    let v1638 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1637 
    let v1639 : string = $"v1638.to_vec()"
    let v1640 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1639 
    let v1641 : string = $"v1622.to_le_bytes()"
    let v1642 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1641 
    let v1643 : string = $"v1642.to_vec()"
    let v1644 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1643 
    let v1645 : string = "$0.as_yoctonear()"
    let v1646 : u128 = Fable.Core.RustInterop.emitRustExpr v1624 v1645 
    let v1647 : string = $"v1646.to_le_bytes()"
    let v1648 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1647 
    let v1649 : string = $"v1648.to_vec()"
    let v1650 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1649 
    let v1651 : string = $"v1626.as_bytes()"
    let v1652 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1651 
    let v1653 : string = $"v1652.to_vec()"
    let v1654 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1653 
    let v1655 : string = $"v1628.as_bytes()"
    let v1656 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1655 
    let v1657 : string = $"v1656.to_vec()"
    let v1658 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1657 
    let v1659 : string = $"$0.into_bytes()"
    let v1660 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1610 v1659 
    let v1661 : string = $"$0.into_bytes()"
    let v1662 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1608 v1661 
    let v1663 : (Vec<uint8> []) = [|v1616; v1632; v1636; v1640; v1644; v1650; v1654; v1658; v1660; v1662|]
    let v1664 : string = "$0.to_vec()"
    let v1665 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v1663 v1664 
    let v1666 : string = $"v1665.concat()"
    let v1667 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1666 
    let v1668 : string = $"near_sdk::env::keccak512(&$0)"
    let v1669 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1667 v1668 
    let v1670 : string = "true; v1614.extend($0); //"
    let v1671 : bool = Fable.Core.RustInterop.emitRustExpr v1669 v1670 
    let v1672 : string = $"v1614.len()"
    let v1673 : uint32 = Fable.Core.RustInterop.emitRustExpr () v1672 
    let v1717 : int32 = v1673 |> int32 
    let v1726 : unativeint = 100 |> unativeint 
    let v1772 : int32 = v1726 |> int32 
    let v1780 : int32 = v1717 - v1772
    let v1781 : bool = v1780 > 0
    if v1781 then
        let v1782 : string = "v1614.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v1783 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1780 v1782 
        let v2137 : unit = ()
        let v2138 : (unit -> unit) = closure1(v1780, v1783)
        let v2139 : unit = (fun () -> v2138 (); v2137) ()
        ()
    let v2496 : (unit -> unit) = method17()
    let v2844 : unit = ()
    let v2845 : (unit -> unit) = closure10(v2496)
    let v2846 : unit = (fun () -> v2845 (); v2844) ()
    let v3197 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v3198 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v1669 v3197 
    let v3200 : uint8 list = v3198 |> Array.toList
    let v3208 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v3209 : (uint8 -> (UH0 -> UH0)) = method18()
    let v3210 : (uint8 list -> (UH0 -> UH0)) = v3208 v3209
    let v3211 : (UH0 -> UH0) = v3210 v3200
    let v3212 : UH0 = UH0_0
    let v3213 : UH0 = v3211 v3212
    let v3242 : UH1 = UH1_1
    let v3243 : UH1 = method19(v3213, v3242)
    let v3244 : UH1 = UH1_1
    let v3245 : UH1 = method20(v3243, v3244)
    let v3246 : UH0 = UH0_0
    let v3247 : UH0 = method21(v3245, v3246)
    let v3640 : unit = ()
    let v3641 : (unit -> unit) = closure15(v1614, v1608, v1610, v1612, v1616, v1618, v1620, v1622, v1624, v1626, v1628, v1667, v1669, v3247)
    let v3642 : unit = (fun () -> v3641 (); v3640) ()
    let v4038 : UH0 = UH0_0
    let v4039 : UH0 = method25(v3247, v4038)
    let v4040 : UH0 = method26(v3247, v4039)
    let v4041 : UH1 = UH1_1
    let v4042 : UH1 = method19(v4040, v4041)
    let v4043 : (unit -> UH1) = closure16(v4042)
    let v4044 : (unit -> UH1) = method27(v4042, v4043)
    let v4045 : Mut0 = {l0 = 0L} : Mut0
    let v4046 : Mut0 = {l0 = 1L} : Mut0
    let v4047 : Mut0 = {l0 = -1L} : Mut0
    let v4048 : US8 = US8_1
    let v4049 : Mut6 = {l0 = v4048} : Mut6
    let v4050 : bool = v1612 = 1UL
    let v4054 : int8 =
        if v4050 then
            1y
        else
            let v4051 : int8 = 0y
            let v4052 : uint64 = 1UL
            method28(v1612, v4051, v4052)
    let v4055 : int8 = v4054 - 1y
    let v4056 : UH0 = UH0_0
    let v4057 : int8 = 0y
    let v4058 : uint64 = method31(v4044, v4045, v4046, v4047, v4049, v1612, v4055, v4056, v4057)
    let v4059 : (unit -> unit) = method48()
    let v4407 : unit = ()
    let v4408 : (unit -> unit) = closure88(v4059)
    let v4409 : unit = (fun () -> v4408 (); v4407) ()
    let v4760 : string = "v4058 //"
    Fable.Core.RustInterop.emitRustExpr () v4760 
    let v4761 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4761 
    let v4762 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4762 
    let v4763 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4763 
    let v4764 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4764 
    let v4765 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v4766 : bool = Fable.Core.RustInterop.emitRustExpr () v4765 
    let v4767 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v4768 : bool = Fable.Core.RustInterop.emitRustExpr () v4767 
    let v4769 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v4769 
    let v4770 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v4770 
    let v4771 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v4771 
    let v4772 : string = $"max"
    let v4773 : uint64 = Fable.Core.RustInterop.emitRustExpr () v4772 
    let v4774 : string = $"rolls"
    let v4775 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v4774 
    let v4776 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v4777 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v4775 v4776 
    let v4779 : uint8 list = v4777 |> Array.toList
    let v4787 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v4788 : (uint8 -> (UH0 -> UH0)) = method18()
    let v4789 : (uint8 list -> (UH0 -> UH0)) = v4787 v4788
    let v4790 : (UH0 -> UH0) = v4789 v4779
    let v4791 : UH0 = UH0_0
    let v4792 : UH0 = v4790 v4791
    let v4821 : int8 = 0y
    let v4822 : int8 = method49(v4792, v4821)
    let v4823 : int8 = v4822 - 1y
    let v4824 : uint64 = 0UL
    let v4825 : US9 = method38(v4823, v4792, v4824)
    let v4835 : US10 =
        match v4825 with
        | US9_0(v4826, v4827) -> (* Some *)
            let v4828 : bool = v4826 >= 1UL
            let v4830 : bool =
                if v4828 then
                    let v4829 : bool = v4826 <= v4773
                    v4829
                else
                    false
            if v4830 then
                US10_0(v4826)
            else
                US10_1
        | _ ->
            US10_1
    let v4846 : uint64 option =
        match v4835 with
        | US10_1 -> (* None *)
            let v4842 : uint64 option = None
            v4842
        | US10_0(v4836) -> (* Some *)
            let v4838 : uint64 option = Some v4836 
            v4838
    let v5204 : unit = ()
    let v5205 : (unit -> unit) = closure89(v4773, v4775, v4846)
    let v5206 : unit = (fun () -> v5205 (); v5204) ()
    let v5567 : (unit -> unit) = method52()
    let v5915 : unit = ()
    let v5916 : (unit -> unit) = closure90(v5567)
    let v5917 : unit = (fun () -> v5916 (); v5915) ()
    let v6268 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v4846 v6268 
    let v6269 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v6269 
    let v6270 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v6270 
    let v6271 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v6271 
    let v6272 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v6273 : bool = Fable.Core.RustInterop.emitRustExpr () v6272 
    let v6274 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v6275 : bool = Fable.Core.RustInterop.emitRustExpr () v6274 
    let v6276 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v6276 
    let v6277 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v6277 
    let v6278 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v6278 
    let v6279 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v6279 
    let v6280 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v6280 
    let v6281 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v6281 
    let v6282 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v6282 
    let v6283 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v6283 
    let v6284 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v6284 
    let v6285 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v6285 
    let v6286 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v6286 
    let v6287 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v6288 : bool = Fable.Core.RustInterop.emitRustExpr () v6287 
    let v6289 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v6290 : bool = Fable.Core.RustInterop.emitRustExpr () v6289 
    let v6291 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v6291 
    let v6292 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v6292 
    let v6293 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v6294 : bool = Fable.Core.RustInterop.emitRustExpr () v6293 
    let v6295 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v6296 : bool = Fable.Core.RustInterop.emitRustExpr () v6295 
    let v6297 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v6298 : bool = Fable.Core.RustInterop.emitRustExpr () v6297 
    let v6299 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v6300 : bool = Fable.Core.RustInterop.emitRustExpr () v6299 
    let v6301 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v6302 : bool = Fable.Core.RustInterop.emitRustExpr () v6301 
    let v6303 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v6304 : bool = Fable.Core.RustInterop.emitRustExpr () v6303 
    let v6305 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v6306 : bool = Fable.Core.RustInterop.emitRustExpr () v6305 
    let v6307 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v6308 : bool = Fable.Core.RustInterop.emitRustExpr () v6307 
    let v6309 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v6310 : bool = Fable.Core.RustInterop.emitRustExpr () v6309 
    let v6311 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v6312 : bool = Fable.Core.RustInterop.emitRustExpr () v6311 
    let v6313 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v6314 : bool = Fable.Core.RustInterop.emitRustExpr () v6313 
    let v6315 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v6316 : bool = Fable.Core.RustInterop.emitRustExpr () v6315 
    let v6317 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v6318 : bool = Fable.Core.RustInterop.emitRustExpr () v6317 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
