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
    let v195 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : (int64 -> US2) = method7()
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
    let v361 : string = method8()
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
    let v384 : (int64 -> US2) = method7()
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
    let v547 : string = method8()
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
    let v572 : (int64 -> US2) = method7()
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
    let v619 : (int64 -> US2) = method7()
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
    let v782 : string = method9()
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
    let v805 : (int64 -> US2) = method7()
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
    let v968 : string = method9()
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
    let v991 : (int64 -> US2) = method7()
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
    let v1154 : string = method9()
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
    let v1177 : (int64 -> US2) = method7()
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
    let v1340 : string = method9()
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
and method11 (v0 : char) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v7 : string = $"{v0}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure6(v2, v7)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v23 : string = v2.l0
    v23
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method11(v7)
    (* run_target_args'
    let v25 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v26 : string = "inline_colorization::color_bright_blue"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26 
    (* run_target_args'
    let v32 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = "&*$0"
    let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v33 
    let _run_target_args'_v32 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "&*$0"
    let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v35 
    let _run_target_args'_v32 = v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = "&*$0"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v37 
    let _run_target_args'_v32 = v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v48 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v48 
    #endif
#else
    let v52 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v52 
    #endif
    let v55 : Ref<Str> = _run_target_args'_v32 
    let v64 : string = "inline_colorization::color_reset"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v27, v55, v65) v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _run_target_args'_v25 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "inline_colorization::color_bright_blue"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v70 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : Ref<Str> = _run_target_args'_v76 
    let v108 : string = "inline_colorization::color_reset"
    let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108 
    let v110 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v111 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v71, v99, v109) v110 
    let v112 : string = "fable_library_rust::String_::fromString($0)"
    let v113 : string = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let _run_target_args'_v25 = v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v114 : string = "inline_colorization::color_bright_blue"
    let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114 
    (* run_target_args'
    let v120 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v121 
    let _run_target_args'_v120 = v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v123 
    let _run_target_args'_v120 = v124 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v125 : string = "&*$0"
    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v125 
    let _run_target_args'_v120 = v126 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v136 
    #endif
#else
    let v140 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v140 
    #endif
    let v143 : Ref<Str> = _run_target_args'_v120 
    let v152 : string = "inline_colorization::color_reset"
    let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v152 
    let v154 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v115, v143, v153) v154 
    let v156 : string = "fable_library_rust::String_::fromString($0)"
    let v157 : string = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let _run_target_args'_v25 = v157 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v159 : string = "\u001b[94m"
    let v163 : string = method13()
    let v167 : string = v159 + v8 
    let v171 : string = v167 + v163 
    let _run_target_args'_v25 = v171 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : string = "\u001b[94m"
    let v179 : string = method13()
    let v183 : string = v175 + v8 
    let v187 : string = v183 + v179 
    let _run_target_args'_v25 = v187 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v191 : string = "\u001b[94m"
    let v195 : string = method13()
    let v199 : string = v191 + v8 
    let v203 : string = v199 + v195 
    let _run_target_args'_v25 = v203 
    #endif
#else
    let v207 : string = "\u001b[94m"
    let v211 : string = method13()
    let v215 : string = v207 + v8 
    let v219 : string = v215 + v211 
    let _run_target_args'_v25 = v219 
    #endif
    let v222 : string = _run_target_args'_v25 
    v222
and method15 (v0 : int32, v1 : string) : string =
    let v2 : string = method12()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure6(v3, v7)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v25 : string = "seed_excess_len"
    let v26 : string = $"{v25}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v26)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v44 : string = " = "
    let v45 : string = $"{v44}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v3, v45)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v65 : string = $"{v0}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure6(v3, v65)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v83 : string = "; "
    let v84 : string = $"{v83}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure6(v3, v84)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v102 : string = "seed_excess"
    let v103 : string = $"{v102}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v3, v103)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v120 : string = $"{v44}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v3, v120)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v137 : string = $"{v1}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure6(v3, v137)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v155 : string = " }"
    let v156 : string = $"{v155}"
    let v164 : unit = ()
    let v165 : (unit -> unit) = closure6(v3, v156)
    let v166 : unit = (fun () -> v165 (); v164) ()
    let v172 : string = v3.l0
    v172
and method16 (v0 : string) : string =
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
    let v10 : string = method15(v8, v9)
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
    let v43 : string = "dice_contract.contribute_seed"
    let v44 : string = v38 + v43 
    let v49 : string = " / "
    let v50 : string = v44 + v49 
    let v54 : string = v50 + v10 
    method16(v54)
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
    let v303 : US6 =
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
            let v189 : (unit -> unit) = closure7(v168)
            let v190 : unit = (fun () -> v189 (); v188) ()
            let v193 : (string -> unit) = closure8()
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
            let v275 : int32 = v269 |> int32 
            let v285 : string = ""
            let v286 : bool = v129 <> v285 
            let v290 : bool =
                if v286 then
                    let v289 : bool = v275 <= 1
                    v289
                else
                    false
            if v290 then
                v171.l0 <- v213
                ()
            else
                v171.l0 <- v285
                let v291 : string = "true; $0.into_iter().for_each(|x| { //"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v267 v291 
                let v293 : string = "x"
                let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr v294 v295 
                let v297 : string = $"true"
                let v298 : bool = Fable.Core.RustInterop.emitRustExpr () v297 
                let v299 : string = "true; }); //"
                let v300 : bool = Fable.Core.RustInterop.emitRustExpr () v299 
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
            let v301 : (string -> unit) = v169.l0
            v301 v129
            US6_0(v168, v169, v170, v171, v172, v173)
    
    ()
and closure10 () () : unit =
    ()
and method17 () : (unit -> unit) =
    closure10()
and closure11 (v0 : (unit -> unit)) () : unit =
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
    let v296 : US6 =
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
            let v183 : (unit -> unit) = closure7(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure8()
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
            let v270 : int32 = v264 |> int32 
            let v279 : bool = v187 <> v187 
            let v283 : bool =
                if v279 then
                    let v282 : bool = v270 <= 1
                    v282
                else
                    false
            if v283 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v284 : string = "true; $0.into_iter().for_each(|x| { //"
                let v285 : bool = Fable.Core.RustInterop.emitRustExpr v262 v284 
                let v286 : string = "x"
                let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v286 
                let v288 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v287 v288 
                let v290 : string = $"true"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = "true; }); //"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
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
            let v294 : (string -> unit) = v163.l0
            v294 v187
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
and closure13 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure12 () (v0 : uint8) : (UH0 -> UH0) =
    closure13(v0)
and method18 () : (uint8 -> (UH0 -> UH0)) =
    closure12()
and closure14 (v0 : UH1) () : UH1 =
    v0
and method19 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method19(v3, v1)
        let v5 : (unit -> UH1) = closure14(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure15 (v0 : UH1) () : UH1 =
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
        let v12 : (unit -> UH1) = closure15(v5)
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
    let v16 : Mut3 = {l0 = v15} : Mut3
    let v19 : string = "{ "
    let v20 : string = $"{v19}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure6(v16, v20)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v38 : string = "max"
    let v39 : string = $"{v38}"
    let v47 : unit = ()
    let v48 : (unit -> unit) = closure6(v16, v39)
    let v49 : unit = (fun () -> v48 (); v47) ()
    let v57 : string = " = "
    let v58 : string = $"{v57}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure6(v16, v58)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v78 : string = $"{v0}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v16, v78)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v96 : string = "; "
    let v97 : string = $"{v96}"
    let v105 : unit = ()
    let v106 : (unit -> unit) = closure6(v16, v97)
    let v107 : unit = (fun () -> v106 (); v105) ()
    let v115 : string = "key"
    let v116 : string = $"{v115}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v16, v116)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v133 : string = $"{v57}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure6(v16, v133)
    let v143 : unit = (fun () -> v142 (); v141) ()
    (* run_target_args'
    let v153 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v154 : string = "format!(\"{:#?}\", $0)"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v154 
    let v156 : string = "fable_library_rust::String_::fromString($0)"
    let v157 : string = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let _run_target_args'_v153 = v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : string = "format!(\"{:#?}\", $0)"
    let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v158 
    let v160 : string = "fable_library_rust::String_::fromString($0)"
    let v161 : string = Fable.Core.RustInterop.emitRustExpr v159 v160 
    let _run_target_args'_v153 = v161 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v162 : string = "format!(\"{:#?}\", $0)"
    let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v162 
    let v164 : string = "fable_library_rust::String_::fromString($0)"
    let v165 : string = Fable.Core.RustInterop.emitRustExpr v163 v164 
    let _run_target_args'_v153 = v165 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v167 : string = $"%A{v1}"
    let _run_target_args'_v153 = v167 
    #endif
#if FABLE_COMPILER_PYTHON
    let v171 : string = $"%A{v1}"
    let _run_target_args'_v153 = v171 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v175 : string = $"%A{v1}"
    let _run_target_args'_v153 = v175 
    #endif
#else
    let v179 : string = $"%A{v1}"
    let _run_target_args'_v153 = v179 
    #endif
    let v182 : string = _run_target_args'_v153 
    let v192 : string = $"{v182}"
    let v200 : unit = ()
    let v201 : (unit -> unit) = closure6(v16, v192)
    let v202 : unit = (fun () -> v201 (); v200) ()
    let v209 : string = $"{v96}"
    let v217 : unit = ()
    let v218 : (unit -> unit) = closure6(v16, v209)
    let v219 : unit = (fun () -> v218 (); v217) ()
    let v227 : string = "proof"
    let v228 : string = $"{v227}"
    let v236 : unit = ()
    let v237 : (unit -> unit) = closure6(v16, v228)
    let v238 : unit = (fun () -> v237 (); v236) ()
    let v245 : string = $"{v57}"
    let v253 : unit = ()
    let v254 : (unit -> unit) = closure6(v16, v245)
    let v255 : unit = (fun () -> v254 (); v253) ()
    (* run_target_args'
    let v265 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v266 : string = "format!(\"{:#?}\", $0)"
    let v267 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v266 
    let v268 : string = "fable_library_rust::String_::fromString($0)"
    let v269 : string = Fable.Core.RustInterop.emitRustExpr v267 v268 
    let _run_target_args'_v265 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "format!(\"{:#?}\", $0)"
    let v271 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v270 
    let v272 : string = "fable_library_rust::String_::fromString($0)"
    let v273 : string = Fable.Core.RustInterop.emitRustExpr v271 v272 
    let _run_target_args'_v265 = v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = "format!(\"{:#?}\", $0)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _run_target_args'_v265 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v279 : string = $"%A{v2}"
    let _run_target_args'_v265 = v279 
    #endif
#if FABLE_COMPILER_PYTHON
    let v283 : string = $"%A{v2}"
    let _run_target_args'_v265 = v283 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v287 : string = $"%A{v2}"
    let _run_target_args'_v265 = v287 
    #endif
#else
    let v291 : string = $"%A{v2}"
    let _run_target_args'_v265 = v291 
    #endif
    let v294 : string = _run_target_args'_v265 
    let v304 : string = $"{v294}"
    let v312 : unit = ()
    let v313 : (unit -> unit) = closure6(v16, v304)
    let v314 : unit = (fun () -> v313 (); v312) ()
    let v321 : string = $"{v96}"
    let v329 : unit = ()
    let v330 : (unit -> unit) = closure6(v16, v321)
    let v331 : unit = (fun () -> v330 (); v329) ()
    let v339 : string = "block_timestamp"
    let v340 : string = $"{v339}"
    let v348 : unit = ()
    let v349 : (unit -> unit) = closure6(v16, v340)
    let v350 : unit = (fun () -> v349 (); v348) ()
    let v357 : string = $"{v57}"
    let v365 : unit = ()
    let v366 : (unit -> unit) = closure6(v16, v357)
    let v367 : unit = (fun () -> v366 (); v365) ()
    let v377 : string = $"{v3}"
    let v385 : unit = ()
    let v386 : (unit -> unit) = closure6(v16, v377)
    let v387 : unit = (fun () -> v386 (); v385) ()
    let v394 : string = $"{v96}"
    let v402 : unit = ()
    let v403 : (unit -> unit) = closure6(v16, v394)
    let v404 : unit = (fun () -> v403 (); v402) ()
    let v412 : string = "block_height"
    let v413 : string = $"{v412}"
    let v421 : unit = ()
    let v422 : (unit -> unit) = closure6(v16, v413)
    let v423 : unit = (fun () -> v422 (); v421) ()
    let v430 : string = $"{v57}"
    let v438 : unit = ()
    let v439 : (unit -> unit) = closure6(v16, v430)
    let v440 : unit = (fun () -> v439 (); v438) ()
    let v450 : string = $"{v4}"
    let v458 : unit = ()
    let v459 : (unit -> unit) = closure6(v16, v450)
    let v460 : unit = (fun () -> v459 (); v458) ()
    let v467 : string = $"{v96}"
    let v475 : unit = ()
    let v476 : (unit -> unit) = closure6(v16, v467)
    let v477 : unit = (fun () -> v476 (); v475) ()
    let v485 : string = "epoch_height"
    let v486 : string = $"{v485}"
    let v494 : unit = ()
    let v495 : (unit -> unit) = closure6(v16, v486)
    let v496 : unit = (fun () -> v495 (); v494) ()
    let v503 : string = $"{v57}"
    let v511 : unit = ()
    let v512 : (unit -> unit) = closure6(v16, v503)
    let v513 : unit = (fun () -> v512 (); v511) ()
    let v523 : string = $"{v5}"
    let v531 : unit = ()
    let v532 : (unit -> unit) = closure6(v16, v523)
    let v533 : unit = (fun () -> v532 (); v531) ()
    let v540 : string = $"{v96}"
    let v548 : unit = ()
    let v549 : (unit -> unit) = closure6(v16, v540)
    let v550 : unit = (fun () -> v549 (); v548) ()
    let v558 : string = "account_balance"
    let v559 : string = $"{v558}"
    let v567 : unit = ()
    let v568 : (unit -> unit) = closure6(v16, v559)
    let v569 : unit = (fun () -> v568 (); v567) ()
    let v576 : string = $"{v57}"
    let v584 : unit = ()
    let v585 : (unit -> unit) = closure6(v16, v576)
    let v586 : unit = (fun () -> v585 (); v584) ()
    let v593 : string = $"{v6}"
    let v601 : unit = ()
    let v602 : (unit -> unit) = closure6(v16, v593)
    let v603 : unit = (fun () -> v602 (); v601) ()
    let v610 : string = $"{v96}"
    let v618 : unit = ()
    let v619 : (unit -> unit) = closure6(v16, v610)
    let v620 : unit = (fun () -> v619 (); v618) ()
    let v628 : string = "signer_account_id"
    let v629 : string = $"{v628}"
    let v637 : unit = ()
    let v638 : (unit -> unit) = closure6(v16, v629)
    let v639 : unit = (fun () -> v638 (); v637) ()
    let v646 : string = $"{v57}"
    let v654 : unit = ()
    let v655 : (unit -> unit) = closure6(v16, v646)
    let v656 : unit = (fun () -> v655 (); v654) ()
    (* run_target_args'
    let v666 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v667 : string = "format!(\"{:#?}\", $0)"
    let v668 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v667 
    let v669 : string = "fable_library_rust::String_::fromString($0)"
    let v670 : string = Fable.Core.RustInterop.emitRustExpr v668 v669 
    let _run_target_args'_v666 = v670 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v671 : string = "format!(\"{:#?}\", $0)"
    let v672 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v671 
    let v673 : string = "fable_library_rust::String_::fromString($0)"
    let v674 : string = Fable.Core.RustInterop.emitRustExpr v672 v673 
    let _run_target_args'_v666 = v674 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v675 : string = "format!(\"{:#?}\", $0)"
    let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v675 
    let v677 : string = "fable_library_rust::String_::fromString($0)"
    let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
    let _run_target_args'_v666 = v678 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v680 : string = $"%A{v7}"
    let _run_target_args'_v666 = v680 
    #endif
#if FABLE_COMPILER_PYTHON
    let v684 : string = $"%A{v7}"
    let _run_target_args'_v666 = v684 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v688 : string = $"%A{v7}"
    let _run_target_args'_v666 = v688 
    #endif
#else
    let v692 : string = $"%A{v7}"
    let _run_target_args'_v666 = v692 
    #endif
    let v695 : string = _run_target_args'_v666 
    let v705 : string = $"{v695}"
    let v713 : unit = ()
    let v714 : (unit -> unit) = closure6(v16, v705)
    let v715 : unit = (fun () -> v714 (); v713) ()
    let v722 : string = $"{v96}"
    let v730 : unit = ()
    let v731 : (unit -> unit) = closure6(v16, v722)
    let v732 : unit = (fun () -> v731 (); v730) ()
    let v740 : string = "predecessor_account_id"
    let v741 : string = $"{v740}"
    let v749 : unit = ()
    let v750 : (unit -> unit) = closure6(v16, v741)
    let v751 : unit = (fun () -> v750 (); v749) ()
    let v758 : string = $"{v57}"
    let v766 : unit = ()
    let v767 : (unit -> unit) = closure6(v16, v758)
    let v768 : unit = (fun () -> v767 (); v766) ()
    (* run_target_args'
    let v778 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v779 : string = "format!(\"{:#?}\", $0)"
    let v780 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v779 
    let v781 : string = "fable_library_rust::String_::fromString($0)"
    let v782 : string = Fable.Core.RustInterop.emitRustExpr v780 v781 
    let _run_target_args'_v778 = v782 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v783 : string = "format!(\"{:#?}\", $0)"
    let v784 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v783 
    let v785 : string = "fable_library_rust::String_::fromString($0)"
    let v786 : string = Fable.Core.RustInterop.emitRustExpr v784 v785 
    let _run_target_args'_v778 = v786 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v787 : string = "format!(\"{:#?}\", $0)"
    let v788 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v787 
    let v789 : string = "fable_library_rust::String_::fromString($0)"
    let v790 : string = Fable.Core.RustInterop.emitRustExpr v788 v789 
    let _run_target_args'_v778 = v790 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v792 : string = $"%A{v8}"
    let _run_target_args'_v778 = v792 
    #endif
#if FABLE_COMPILER_PYTHON
    let v796 : string = $"%A{v8}"
    let _run_target_args'_v778 = v796 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v800 : string = $"%A{v8}"
    let _run_target_args'_v778 = v800 
    #endif
#else
    let v804 : string = $"%A{v8}"
    let _run_target_args'_v778 = v804 
    #endif
    let v807 : string = _run_target_args'_v778 
    let v817 : string = $"{v807}"
    let v825 : unit = ()
    let v826 : (unit -> unit) = closure6(v16, v817)
    let v827 : unit = (fun () -> v826 (); v825) ()
    let v834 : string = $"{v96}"
    let v842 : unit = ()
    let v843 : (unit -> unit) = closure6(v16, v834)
    let v844 : unit = (fun () -> v843 (); v842) ()
    let v852 : string = "seed"
    let v853 : string = $"{v852}"
    let v861 : unit = ()
    let v862 : (unit -> unit) = closure6(v16, v853)
    let v863 : unit = (fun () -> v862 (); v861) ()
    let v870 : string = $"{v57}"
    let v878 : unit = ()
    let v879 : (unit -> unit) = closure6(v16, v870)
    let v880 : unit = (fun () -> v879 (); v878) ()
    let v887 : string = $"{v9}"
    let v895 : unit = ()
    let v896 : (unit -> unit) = closure6(v16, v887)
    let v897 : unit = (fun () -> v896 (); v895) ()
    let v904 : string = $"{v96}"
    let v912 : unit = ()
    let v913 : (unit -> unit) = closure6(v16, v904)
    let v914 : unit = (fun () -> v913 (); v912) ()
    let v922 : string = "seeds"
    let v923 : string = $"{v922}"
    let v931 : unit = ()
    let v932 : (unit -> unit) = closure6(v16, v923)
    let v933 : unit = (fun () -> v932 (); v931) ()
    let v940 : string = $"{v57}"
    let v948 : unit = ()
    let v949 : (unit -> unit) = closure6(v16, v940)
    let v950 : unit = (fun () -> v949 (); v948) ()
    let v957 : string = $"{v10}"
    let v965 : unit = ()
    let v966 : (unit -> unit) = closure6(v16, v957)
    let v967 : unit = (fun () -> v966 (); v965) ()
    let v974 : string = $"{v96}"
    let v982 : unit = ()
    let v983 : (unit -> unit) = closure6(v16, v974)
    let v984 : unit = (fun () -> v983 (); v982) ()
    let v992 : string = "entropy_len"
    let v993 : string = $"{v992}"
    let v1001 : unit = ()
    let v1002 : (unit -> unit) = closure6(v16, v993)
    let v1003 : unit = (fun () -> v1002 (); v1001) ()
    let v1010 : string = $"{v57}"
    let v1018 : unit = ()
    let v1019 : (unit -> unit) = closure6(v16, v1010)
    let v1020 : unit = (fun () -> v1019 (); v1018) ()
    (* run_target_args'
    let v1030 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1031 : string = "format!(\"{:#?}\", $0)"
    let v1032 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v1031 
    let v1033 : string = "fable_library_rust::String_::fromString($0)"
    let v1034 : string = Fable.Core.RustInterop.emitRustExpr v1032 v1033 
    let _run_target_args'_v1030 = v1034 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1035 : string = "format!(\"{:#?}\", $0)"
    let v1036 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v1035 
    let v1037 : string = "fable_library_rust::String_::fromString($0)"
    let v1038 : string = Fable.Core.RustInterop.emitRustExpr v1036 v1037 
    let _run_target_args'_v1030 = v1038 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1039 : string = "format!(\"{:#?}\", $0)"
    let v1040 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v1039 
    let v1041 : string = "fable_library_rust::String_::fromString($0)"
    let v1042 : string = Fable.Core.RustInterop.emitRustExpr v1040 v1041 
    let _run_target_args'_v1030 = v1042 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1044 : string = $"%A{v11}"
    let _run_target_args'_v1030 = v1044 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1048 : string = $"%A{v11}"
    let _run_target_args'_v1030 = v1048 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1052 : string = $"%A{v11}"
    let _run_target_args'_v1030 = v1052 
    #endif
#else
    let v1056 : string = $"%A{v11}"
    let _run_target_args'_v1030 = v1056 
    #endif
    let v1059 : string = _run_target_args'_v1030 
    let v1069 : string = $"{v1059}"
    let v1077 : unit = ()
    let v1078 : (unit -> unit) = closure6(v16, v1069)
    let v1079 : unit = (fun () -> v1078 (); v1077) ()
    let v1086 : string = $"{v96}"
    let v1094 : unit = ()
    let v1095 : (unit -> unit) = closure6(v16, v1086)
    let v1096 : unit = (fun () -> v1095 (); v1094) ()
    let v1104 : string = "entropy"
    let v1105 : string = $"{v1104}"
    let v1113 : unit = ()
    let v1114 : (unit -> unit) = closure6(v16, v1105)
    let v1115 : unit = (fun () -> v1114 (); v1113) ()
    let v1122 : string = $"{v57}"
    let v1130 : unit = ()
    let v1131 : (unit -> unit) = closure6(v16, v1122)
    let v1132 : unit = (fun () -> v1131 (); v1130) ()
    let v1139 : string = $"{v12}"
    let v1147 : unit = ()
    let v1148 : (unit -> unit) = closure6(v16, v1139)
    let v1149 : unit = (fun () -> v1148 (); v1147) ()
    let v1156 : string = $"{v96}"
    let v1164 : unit = ()
    let v1165 : (unit -> unit) = closure6(v16, v1156)
    let v1166 : unit = (fun () -> v1165 (); v1164) ()
    let v1174 : string = "hash_u8"
    let v1175 : string = $"{v1174}"
    let v1183 : unit = ()
    let v1184 : (unit -> unit) = closure6(v16, v1175)
    let v1185 : unit = (fun () -> v1184 (); v1183) ()
    let v1192 : string = $"{v57}"
    let v1200 : unit = ()
    let v1201 : (unit -> unit) = closure6(v16, v1192)
    let v1202 : unit = (fun () -> v1201 (); v1200) ()
    let v1209 : string = $"{v13}"
    let v1217 : unit = ()
    let v1218 : (unit -> unit) = closure6(v16, v1209)
    let v1219 : unit = (fun () -> v1218 (); v1217) ()
    let v1226 : string = $"{v96}"
    let v1234 : unit = ()
    let v1235 : (unit -> unit) = closure6(v16, v1226)
    let v1236 : unit = (fun () -> v1235 (); v1234) ()
    let v1244 : string = "rolls"
    let v1245 : string = $"{v1244}"
    let v1253 : unit = ()
    let v1254 : (unit -> unit) = closure6(v16, v1245)
    let v1255 : unit = (fun () -> v1254 (); v1253) ()
    let v1262 : string = $"{v57}"
    let v1270 : unit = ()
    let v1271 : (unit -> unit) = closure6(v16, v1262)
    let v1272 : unit = (fun () -> v1271 (); v1270) ()
    let v1279 : string = $"{v14}"
    let v1287 : unit = ()
    let v1288 : (unit -> unit) = closure6(v16, v1279)
    let v1289 : unit = (fun () -> v1288 (); v1287) ()
    let v1297 : string = " }"
    let v1298 : string = $"{v1297}"
    let v1306 : unit = ()
    let v1307 : (unit -> unit) = closure6(v16, v1298)
    let v1308 : unit = (fun () -> v1307 (); v1306) ()
    let v1314 : string = v16.l0
    v1314
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method24(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v24 : int64 = v0.l0
    let v27 : string = " "
    let v28 : string = v6 + v27 
    let v32 : string = v28 + v7 
    let v37 : string = " #"
    let v38 : string = v32 + v37 
    let v42 : (int64 -> string) = _.ToString()
    let v43 : string = v42 v24
    let v47 : string = v38 + v43 
    let v51 : string = v47 + v27 
    let v56 : string = "dice_contract.generate_random_number"
    let v57 : string = v51 + v56 
    let v62 : string = " / "
    let v63 : string = v57 + v62 
    let v67 : string = v63 + v23 
    method16(v67)
and closure16 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
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
    let v350 : US6 =
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
            let v166 : (uint8 list -> (uint8 [])) = List.toArray
            let v167 : (uint8 []) = v166 v164
            let v170 : string = "$0.to_vec()"
            let v171 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v167 v170 
            let v173 : string = $"%A{v171}"
            let v176 : string = method23(v117, v118, v119, v120, v121, v122, v135, v136, v3, v1, v2, v7, v6, v5, v138, v142, v144, v146, v150, v154, v156, v160, v173)
            let v191 : unit = ()
            let v192 : unit = (fun () -> v29 (); v191) ()
            let struct (v215 : Mut0, v216 : Mut1, v217 : Mut2, v218 : Mut3, v219 : Mut4, v220 : int64 option) = TraceState.trace_state.Value
            let v235 : unit = ()
            let v236 : (unit -> unit) = closure7(v215)
            let v237 : unit = (fun () -> v236 (); v235) ()
            let v240 : (string -> unit) = closure8()
            (* run_target_args'
            let v241 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v242 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v176 v242 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v243 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v176 v243 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v244 : string = v218.l0
            let v245 : bool = v244 = ""
            let v260 : string =
                if v245 then
                    v176
                else
                    let v246 : bool = v176 = ""
                    if v246 then
                        let v247 : string = v218.l0
                        v247
                    else
                        let v248 : string = v218.l0
                        let v251 : string = "\n"
                        let v252 : string = v248 + v251 
                        let v256 : string = v252 + v176 
                        v256
            (* run_target_args'
            let v265 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v266 : string = "&*$0"
            let v267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v266 
            let _run_target_args'_v265 = v267 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v268 : string = "&*$0"
            let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v268 
            let _run_target_args'_v265 = v269 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v270 : string = "&*$0"
            let v271 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v260 v270 
            let _run_target_args'_v265 = v271 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v273 : Ref<Str> = v260 |> unbox<Ref<Str>>
            let _run_target_args'_v265 = v273 
            #endif
#if FABLE_COMPILER_PYTHON
            let v277 : Ref<Str> = v260 |> unbox<Ref<Str>>
            let _run_target_args'_v265 = v277 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v281 : Ref<Str> = v260 |> unbox<Ref<Str>>
            let _run_target_args'_v265 = v281 
            #endif
#else
            let v285 : Ref<Str> = v260 |> unbox<Ref<Str>>
            let _run_target_args'_v265 = v285 
            #endif
            let v288 : Ref<Str> = _run_target_args'_v265 
            let v297 : string = $"$0.chars()"
            let v298 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v288 v297 
            let v299 : string = "$0"
            let v300 : _ = Fable.Core.RustInterop.emitRustExpr v298 v299 
            let v301 : string = "$0.collect::<Vec<_>>()"
            let v302 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v300 v301 
            let v303 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v304 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v302 v303 
            let v305 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v306 : bool = Fable.Core.RustInterop.emitRustExpr v304 v305 
            let v307 : string = "x"
            let v308 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v307 
            let v309 : string = "String::from_iter($0)"
            let v310 : std_string_String = Fable.Core.RustInterop.emitRustExpr v308 v309 
            let v311 : string = "true; $0 }).collect::<Vec<_>>()"
            let v312 : bool = Fable.Core.RustInterop.emitRustExpr v310 v311 
            let v313 : string = "_vec_map"
            let v314 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v313 
            let v315 : string = "$0.len()"
            let v316 : unativeint = Fable.Core.RustInterop.emitRustExpr v314 v315 
            let v322 : int32 = v316 |> int32 
            let v332 : string = ""
            let v333 : bool = v176 <> v332 
            let v337 : bool =
                if v333 then
                    let v336 : bool = v322 <= 1
                    v336
                else
                    false
            if v337 then
                v218.l0 <- v260
                ()
            else
                v218.l0 <- v332
                let v338 : string = "true; $0.into_iter().for_each(|x| { //"
                let v339 : bool = Fable.Core.RustInterop.emitRustExpr v314 v338 
                let v340 : string = "x"
                let v341 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v340 
                let v342 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v343 : bool = Fable.Core.RustInterop.emitRustExpr v341 v342 
                let v344 : string = $"true"
                let v345 : bool = Fable.Core.RustInterop.emitRustExpr () v344 
                let v346 : string = "true; }); //"
                let v347 : bool = Fable.Core.RustInterop.emitRustExpr () v346 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v240 v176
            #endif
#if FABLE_COMPILER_PYTHON
            v240 v176
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v240 v176
            #endif
#else
            v240 v176
            #endif
            // run_target_args' is_unit
            let v348 : (string -> unit) = v216.l0
            v348 v176
            US6_0(v215, v216, v217, v218, v219, v220)
    
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
and closure17 (v0 : UH1) () : UH1 =
    v0
and closure18 (v0 : UH1, v1 : Mut5) () : UH1 =
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
    closure18(v0, v3)
and method30 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method12()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "max"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure6(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure6(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "p"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure6(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure6(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure6(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure6(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "n"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure6(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure6(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure6(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure6(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method29 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method30(v8, v9, v10)
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
    method16(v55)
and closure19 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
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
    let v300 : US6 =
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
            let v186 : (unit -> unit) = closure7(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure8()
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
            let v319 : unit = ()
            let v320 : (unit -> unit) = closure19(v0, v1, v2)
            let v321 : unit = (fun () -> v320 (); v319) ()
            v1
    else
        let v948 : unit = ()
        let v949 : (unit -> unit) = closure19(v0, v1, v2)
        let v950 : unit = (fun () -> v949 (); v948) ()
        v1
and method34 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method12()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v5, v9)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v27 : string = "current_index"
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v5, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = " = "
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure6(v5, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v67 : string = $"{v0}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure6(v5, v67)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v85 : string = "; "
    let v86 : string = $"{v85}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v5, v86)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v104 : string = "acc"
    let v105 : string = $"{v104}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure6(v5, v105)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v122 : string = $"{v46}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure6(v5, v122)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v142 : string = $"{v1}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure6(v5, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v159 : string = $"{v85}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure6(v5, v159)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v177 : string = "len"
    let v178 : string = $"{v177}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure6(v5, v178)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v195 : string = $"{v46}"
    let v203 : unit = ()
    let v204 : (unit -> unit) = closure6(v5, v195)
    let v205 : unit = (fun () -> v204 (); v203) ()
    let v215 : string = $"{v2}"
    let v223 : unit = ()
    let v224 : (unit -> unit) = closure6(v5, v215)
    let v225 : unit = (fun () -> v224 (); v223) ()
    let v232 : string = $"{v85}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure6(v5, v232)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v250 : string = "last_item"
    let v251 : string = $"{v250}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure6(v5, v251)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v268 : string = $"{v46}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure6(v5, v268)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v285 : string = $"{v3}"
    let v293 : unit = ()
    let v294 : (unit -> unit) = closure6(v5, v285)
    let v295 : unit = (fun () -> v294 (); v293) ()
    let v303 : string = " }"
    let v304 : string = $"{v303}"
    let v312 : unit = ()
    let v313 : (unit -> unit) = closure6(v5, v304)
    let v314 : unit = (fun () -> v313 (); v312) ()
    let v320 : string = v5.l0
    v320
and method33 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
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
    let v45 : string = "dice.create_sequential_roller / roll"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method16(v56)
and closure20 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
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
    let v305 : US6 =
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
            let v191 : (unit -> unit) = closure7(v170)
            let v192 : unit = (fun () -> v191 (); v190) ()
            let v195 : (string -> unit) = closure8()
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
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method37()
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
    method16(v52)
and closure21 () () : unit =
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
    let v297 : US6 =
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
            let v183 : (unit -> unit) = closure7(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : (string -> unit) = closure8()
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
    let v335 : unit = ()
    let v336 : (unit -> unit) = closure20(v5, v6, v7, v19)
    let v337 : unit = (fun () -> v336 (); v335) ()
    let v656 : UH1 = v0 ()
    let v657 : int64 = v1.l0
    let v658 : US8 = method35(v657, v656)
    match v658 with
    | US8_1 -> (* None *)
        let v974 : unit = ()
        let v975 : (unit -> unit) = closure21()
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
        let v1302 : US8 = US8_1
        v4.l0 <- v1302
        method32(v0, v1, v2, v3, v4)
    | US8_0(v659) -> (* Some *)
        let v660 : int64 = v1.l0
        let v661 : int64 = v660 + 1L
        v1.l0 <- v661
        let v662 : US8 = US8_0(v659)
        v4.l0 <- v662
        v659
and method40 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method12()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "power"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure6(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure6(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "acc"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure6(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure6(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure6(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure6(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "result"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure6(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure6(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure6(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure6(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method40(v8, v9, v10)
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
    method16(v55)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
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
    let v300 : US6 =
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
            let v186 : (unit -> unit) = closure7(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure8()
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
            US6_0(v165, v166, v167, v168, v169, v170)
    
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
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v5, v9)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v27 : string = "power"
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v5, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = " = "
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure6(v5, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v67 : string = $"{v0}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure6(v5, v67)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v85 : string = "; "
    let v86 : string = $"{v85}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v5, v86)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v104 : string = "acc"
    let v105 : string = $"{v104}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure6(v5, v105)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v122 : string = $"{v46}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure6(v5, v122)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v142 : string = $"{v1}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure6(v5, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v159 : string = $"{v85}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure6(v5, v159)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v177 : string = "roll"
    let v178 : string = $"{v177}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure6(v5, v178)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v195 : string = $"{v46}"
    let v203 : unit = ()
    let v204 : (unit -> unit) = closure6(v5, v195)
    let v205 : unit = (fun () -> v204 (); v203) ()
    let v215 : string = $"{v2}"
    let v223 : unit = ()
    let v224 : (unit -> unit) = closure6(v5, v215)
    let v225 : unit = (fun () -> v224 (); v223) ()
    let v232 : string = $"{v85}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure6(v5, v232)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v250 : string = "value"
    let v251 : string = $"{v250}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure6(v5, v251)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v268 : string = $"{v46}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure6(v5, v268)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v288 : string = $"{v3}"
    let v296 : unit = ()
    let v297 : (unit -> unit) = closure6(v5, v288)
    let v298 : unit = (fun () -> v297 (); v296) ()
    let v306 : string = " }"
    let v307 : string = $"{v306}"
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure6(v5, v307)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v323 : string = v5.l0
    v323
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method43(v8, v9, v10, v11)
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
    method16(v56)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
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
    let v301 : US6 =
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
            let v187 : (unit -> unit) = closure7(v166)
            let v188 : unit = (fun () -> v187 (); v186) ()
            let v191 : (string -> unit) = closure8()
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
            US6_0(v166, v167, v168, v169, v170, v171)
    
    ()
and method45 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method12()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "power"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure6(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure6(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "acc"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure6(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure6(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v141 : string = $"{v1}"
    let v149 : unit = ()
    let v150 : (unit -> unit) = closure6(v4, v141)
    let v151 : unit = (fun () -> v150 (); v149) ()
    let v158 : string = $"{v84}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure6(v4, v158)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v176 : string = "roll"
    let v177 : string = $"{v176}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure6(v4, v177)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v194 : string = $"{v45}"
    let v202 : unit = ()
    let v203 : (unit -> unit) = closure6(v4, v194)
    let v204 : unit = (fun () -> v203 (); v202) ()
    let v214 : string = $"{v2}"
    let v222 : unit = ()
    let v223 : (unit -> unit) = closure6(v4, v214)
    let v224 : unit = (fun () -> v223 (); v222) ()
    let v232 : string = " }"
    let v233 : string = $"{v232}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure6(v4, v233)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v249 : string = v4.l0
    v249
and method44 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method45(v8, v9, v10)
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
    method16(v55)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
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
    let v300 : US6 =
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
            let v186 : (unit -> unit) = closure7(v165)
            let v187 : unit = (fun () -> v186 (); v185) ()
            let v190 : (string -> unit) = closure8()
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
            US6_0(v165, v166, v167, v168, v169, v170)
    
    ()
and method38 (v0 : int8, v1 : UH0, v2 : uint64) : US9 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v316 : unit = ()
        let v317 : (unit -> unit) = closure22(v2, v0, v4)
        let v318 : unit = (fun () -> v317 (); v316) ()
        US9_0(v4, v1)
    else
        match v1 with
        | UH0_1(v635, v636) -> (* Cons *)
            let v637 : bool = v635 > 1uy
            if v637 then
                let v638 : uint64 = 1UL
                let v639 : (unit -> UH2) = closure23()
                let v640 : UH2 = UH2_0(v638, v639)
                let v641 : US10 = method41(v0, v640)
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
                method38(v1278, v636, v1277)
            else
                let v1591 : unit = ()
                let v1592 : (unit -> unit) = closure88(v2, v0, v635)
                let v1593 : unit = (fun () -> v1592 (); v1591) ()
                let v1908 : int8 = v0 - 1y
                method38(v1908, v636, v2)
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
    closure10()
and closure89 (v0 : (unit -> unit)) () : unit =
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
    let v296 : US6 =
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
            let v183 : (unit -> unit) = closure7(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure8()
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
            let v270 : int32 = v264 |> int32 
            let v279 : bool = v187 <> v187 
            let v283 : bool =
                if v279 then
                    let v282 : bool = v270 <= 1
                    v282
                else
                    false
            if v283 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v284 : string = "true; $0.into_iter().for_each(|x| { //"
                let v285 : bool = Fable.Core.RustInterop.emitRustExpr v262 v284 
                let v286 : string = "x"
                let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v286 
                let v288 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v287 v288 
                let v290 : string = $"true"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = "true; }); //"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
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
            let v294 : (string -> unit) = v163.l0
            v294 v187
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
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v4, v8)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v26 : string = "max"
    let v27 : string = $"{v26}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v27)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v45 : string = " = "
    let v46 : string = $"{v45}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v4, v46)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v66 : string = $"{v0}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure6(v4, v66)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v84 : string = "; "
    let v85 : string = $"{v84}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure6(v4, v85)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v103 : string = "rolls"
    let v104 : string = $"{v103}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure6(v4, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v121 : string = $"{v45}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure6(v4, v121)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v138 : string = $"{v1}"
    let v146 : unit = ()
    let v147 : (unit -> unit) = closure6(v4, v138)
    let v148 : unit = (fun () -> v147 (); v146) ()
    let v155 : string = $"{v84}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure6(v4, v155)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v173 : string = "result"
    let v174 : string = $"{v173}"
    let v182 : unit = ()
    let v183 : (unit -> unit) = closure6(v4, v174)
    let v184 : unit = (fun () -> v183 (); v182) ()
    let v191 : string = $"{v45}"
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure6(v4, v191)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v208 : string = $"{v2}"
    let v216 : unit = ()
    let v217 : (unit -> unit) = closure6(v4, v208)
    let v218 : unit = (fun () -> v217 (); v216) ()
    let v226 : string = " }"
    let v227 : string = $"{v226}"
    let v235 : unit = ()
    let v236 : (unit -> unit) = closure6(v4, v227)
    let v237 : unit = (fun () -> v236 (); v235) ()
    let v243 : string = v4.l0
    v243
and method50 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method51(v8, v9, v10)
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
    let v44 : string = "dice_contract.roll_within_bounds"
    let v45 : string = v39 + v44 
    let v50 : string = " / "
    let v51 : string = v45 + v50 
    let v55 : string = v51 + v11 
    method16(v55)
and closure90 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
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
    let v308 : US6 =
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
            let v194 : (unit -> unit) = closure7(v173)
            let v195 : unit = (fun () -> v194 (); v193) ()
            let v198 : (string -> unit) = closure8()
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
            let v280 : int32 = v274 |> int32 
            let v290 : string = ""
            let v291 : bool = v134 <> v290 
            let v295 : bool =
                if v291 then
                    let v294 : bool = v280 <= 1
                    v294
                else
                    false
            if v295 then
                v176.l0 <- v218
                ()
            else
                v176.l0 <- v290
                let v296 : string = "true; $0.into_iter().for_each(|x| { //"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr v272 v296 
                let v298 : string = "x"
                let v299 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v298 
                let v300 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v301 : bool = Fable.Core.RustInterop.emitRustExpr v299 v300 
                let v302 : string = $"true"
                let v303 : bool = Fable.Core.RustInterop.emitRustExpr () v302 
                let v304 : string = "true; }); //"
                let v305 : bool = Fable.Core.RustInterop.emitRustExpr () v304 
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
            let v306 : (string -> unit) = v174.l0
            v306 v134
            US6_0(v173, v174, v175, v176, v177, v178)
    
    ()
and method52 () : (unit -> unit) =
    closure10()
and closure91 (v0 : (unit -> unit)) () : unit =
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
    let v296 : US6 =
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
            let v183 : (unit -> unit) = closure7(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure8()
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
            let v270 : int32 = v264 |> int32 
            let v279 : bool = v187 <> v187 
            let v283 : bool =
                if v279 then
                    let v282 : bool = v270 <= 1
                    v282
                else
                    false
            if v283 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v284 : string = "true; $0.into_iter().for_each(|x| { //"
                let v285 : bool = Fable.Core.RustInterop.emitRustExpr v262 v284 
                let v286 : string = "x"
                let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v286 
                let v288 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v287 v288 
                let v290 : string = $"true"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = "true; }); //"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
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
            let v294 : (string -> unit) = v163.l0
            v294 v187
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
    let v68 : int32 = v62 |> int32 
    let v77 : unativeint = 100 |> unativeint 
    let v85 : int32 = v77 |> int32 
    let v93 : int32 = v68 - v85
    let v94 : bool = v93 > 0
    if v94 then
        let v95 : string = "v56.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v96 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v93 v95 
        let v412 : unit = ()
        let v413 : (unit -> unit) = closure1(v93, v96)
        let v414 : unit = (fun () -> v413 (); v412) ()
        ()
    let v733 : (unit -> unit) = method17()
    let v1043 : unit = ()
    let v1044 : (unit -> unit) = closure11(v733)
    let v1045 : unit = (fun () -> v1044 (); v1043) ()
    let v1358 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1358 
    let v1359 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1359 
    let v1360 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1360 
    let v1361 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1361 
    let v1362 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v1363 : bool = Fable.Core.RustInterop.emitRustExpr () v1362 
    let v1364 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v1365 : bool = Fable.Core.RustInterop.emitRustExpr () v1364 
    let v1366 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1366 
    let v1367 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1367 
    let v1368 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v1368 
    let v1369 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v1369 
    let v1370 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1370 
    let v1371 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1371 
    let v1372 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v1373 : bool = Fable.Core.RustInterop.emitRustExpr () v1372 
    let v1374 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v1375 : bool = Fable.Core.RustInterop.emitRustExpr () v1374 
    let v1376 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1376 
    let v1377 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1377 
    let v1378 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v1378 
    let v1379 : string = $"key"
    let v1380 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1379 
    let v1381 : string = $"proof"
    let v1382 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1381 
    let v1383 : string = $"max"
    let v1384 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1383 
    let v1385 : string = $"&mut self.0.1"
    let v1386 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v1385 
    let v1387 : string = $"near_sdk::env::random_seed()"
    let v1388 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1387 
    let v1389 : string = $"near_sdk::env::epoch_height()"
    let v1390 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1389 
    let v1391 : string = $"near_sdk::env::block_height()"
    let v1392 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1391 
    let v1393 : string = $"near_sdk::env::block_timestamp()"
    let v1394 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1393 
    let v1395 : string = $"near_sdk::env::account_balance()"
    let v1396 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v1395 
    let v1397 : string = $"near_sdk::env::signer_account_id()"
    let v1398 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v1397 
    let v1399 : string = $"near_sdk::env::predecessor_account_id()"
    let v1400 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v1399 
    let v1401 : string = $"&*v1386"
    let v1402 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1401 
    let v1403 : string = $"v1402.iter().map(|x| *x).collect::<Vec<_>>()"
    let v1404 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1403 
    let v1405 : string = $"v1390.to_le_bytes()"
    let v1406 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1405 
    let v1407 : string = $"v1406.to_vec()"
    let v1408 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1407 
    let v1409 : string = $"v1392.to_le_bytes()"
    let v1410 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1409 
    let v1411 : string = $"v1410.to_vec()"
    let v1412 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1411 
    let v1413 : string = $"v1394.to_le_bytes()"
    let v1414 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1413 
    let v1415 : string = $"v1414.to_vec()"
    let v1416 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1415 
    let v1417 : string = "$0.as_yoctonear()"
    let v1418 : u128 = Fable.Core.RustInterop.emitRustExpr v1396 v1417 
    let v1419 : string = $"v1418.to_le_bytes()"
    let v1420 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v1419 
    let v1421 : string = $"v1420.to_vec()"
    let v1422 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1421 
    let v1423 : string = $"v1398.as_bytes()"
    let v1424 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1423 
    let v1425 : string = $"v1424.to_vec()"
    let v1426 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1425 
    let v1427 : string = $"v1400.as_bytes()"
    let v1428 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v1427 
    let v1429 : string = $"v1428.to_vec()"
    let v1430 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1429 
    let v1431 : string = $"$0.into_bytes()"
    let v1432 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1382 v1431 
    let v1433 : string = $"$0.into_bytes()"
    let v1434 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1380 v1433 
    let v1435 : (Vec<uint8> []) = [|v1388; v1404; v1408; v1412; v1416; v1422; v1426; v1430; v1432; v1434|]
    let v1436 : string = "$0.to_vec()"
    let v1437 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v1435 v1436 
    let v1438 : string = $"v1437.concat()"
    let v1439 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v1438 
    let v1440 : string = $"near_sdk::env::keccak512(&$0)"
    let v1441 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1439 v1440 
    let v1442 : string = "true; v1386.extend($0); //"
    let v1443 : bool = Fable.Core.RustInterop.emitRustExpr v1441 v1442 
    let v1444 : string = $"v1386.len()"
    let v1445 : uint32 = Fable.Core.RustInterop.emitRustExpr () v1444 
    let v1451 : int32 = v1445 |> int32 
    let v1460 : unativeint = 100 |> unativeint 
    let v1468 : int32 = v1460 |> int32 
    let v1476 : int32 = v1451 - v1468
    let v1477 : bool = v1476 > 0
    if v1477 then
        let v1478 : string = "v1386.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v1479 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1476 v1478 
        let v1795 : unit = ()
        let v1796 : (unit -> unit) = closure1(v1476, v1479)
        let v1797 : unit = (fun () -> v1796 (); v1795) ()
        ()
    let v2116 : (unit -> unit) = method17()
    let v2426 : unit = ()
    let v2427 : (unit -> unit) = closure11(v2116)
    let v2428 : unit = (fun () -> v2427 (); v2426) ()
    let v2741 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v2742 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v1441 v2741 
    let v2744 : uint8 list = v2742 |> Array.toList
    let v2752 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v2753 : (uint8 -> (UH0 -> UH0)) = method18()
    let v2754 : (uint8 list -> (UH0 -> UH0)) = v2752 v2753
    let v2755 : (UH0 -> UH0) = v2754 v2744
    let v2756 : UH0 = UH0_0
    let v2757 : UH0 = v2755 v2756
    let v2786 : UH1 = UH1_1
    let v2787 : UH1 = method19(v2757, v2786)
    let v2788 : UH1 = UH1_1
    let v2789 : UH1 = method20(v2787, v2788)
    let v2790 : UH0 = UH0_0
    let v2791 : UH0 = method21(v2789, v2790)
    let v3142 : unit = ()
    let v3143 : (unit -> unit) = closure16(v1386, v1380, v1382, v1384, v1388, v1390, v1392, v1394, v1396, v1398, v1400, v1439, v1441, v2791)
    let v3144 : unit = (fun () -> v3143 (); v3142) ()
    let v3498 : UH0 = UH0_0
    let v3499 : UH0 = method25(v2791, v3498)
    let v3500 : UH0 = method26(v2791, v3499)
    let v3501 : UH1 = UH1_1
    let v3502 : UH1 = method19(v3500, v3501)
    let v3503 : (unit -> UH1) = closure17(v3502)
    let v3504 : (unit -> UH1) = method27(v3502, v3503)
    let v3505 : Mut0 = {l0 = 0L} : Mut0
    let v3506 : Mut0 = {l0 = 1L} : Mut0
    let v3507 : Mut0 = {l0 = -1L} : Mut0
    let v3508 : US8 = US8_1
    let v3509 : Mut6 = {l0 = v3508} : Mut6
    let v3510 : bool = v1384 = 1UL
    let v3514 : int8 =
        if v3510 then
            1y
        else
            let v3511 : int8 = 0y
            let v3512 : uint64 = 1UL
            method28(v1384, v3511, v3512)
    let v3515 : int8 = v3514 - 1y
    let v3516 : UH0 = UH0_0
    let v3517 : int8 = 0y
    let v3518 : uint64 = method31(v3504, v3505, v3506, v3507, v3509, v1384, v3515, v3516, v3517)
    let v3519 : (unit -> unit) = method48()
    let v3829 : unit = ()
    let v3830 : (unit -> unit) = closure89(v3519)
    let v3831 : unit = (fun () -> v3830 (); v3829) ()
    let v4144 : string = "v3518 //"
    Fable.Core.RustInterop.emitRustExpr () v4144 
    let v4145 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4145 
    let v4146 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4146 
    let v4147 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4147 
    let v4148 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4148 
    let v4149 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v4150 : bool = Fable.Core.RustInterop.emitRustExpr () v4149 
    let v4151 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v4152 : bool = Fable.Core.RustInterop.emitRustExpr () v4151 
    let v4153 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v4153 
    let v4154 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v4154 
    let v4155 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v4155 
    let v4156 : string = $"max"
    let v4157 : uint64 = Fable.Core.RustInterop.emitRustExpr () v4156 
    let v4158 : string = $"rolls"
    let v4159 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v4158 
    let v4160 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v4161 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v4159 v4160 
    let v4163 : uint8 list = v4161 |> Array.toList
    let v4171 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v4172 : (uint8 -> (UH0 -> UH0)) = method18()
    let v4173 : (uint8 list -> (UH0 -> UH0)) = v4171 v4172
    let v4174 : (UH0 -> UH0) = v4173 v4163
    let v4175 : UH0 = UH0_0
    let v4176 : UH0 = v4174 v4175
    let v4205 : int8 = 0y
    let v4206 : int8 = method49(v4176, v4205)
    let v4207 : int8 = v4206 - 1y
    let v4208 : uint64 = 0UL
    let v4209 : US9 = method38(v4207, v4176, v4208)
    let v4219 : US10 =
        match v4209 with
        | US9_0(v4210, v4211) -> (* Some *)
            let v4212 : bool = v4210 >= 1UL
            let v4214 : bool =
                if v4212 then
                    let v4213 : bool = v4210 <= v4157
                    v4213
                else
                    false
            if v4214 then
                US10_0(v4210)
            else
                US10_1
        | _ ->
            US10_1
    let v4230 : uint64 option =
        match v4219 with
        | US10_1 -> (* None *)
            let v4226 : uint64 option = None
            v4226
        | US10_0(v4220) -> (* Some *)
            let v4222 : uint64 option = Some v4220 
            v4222
    let v4550 : unit = ()
    let v4551 : (unit -> unit) = closure90(v4157, v4159, v4230)
    let v4552 : unit = (fun () -> v4551 (); v4550) ()
    let v4875 : (unit -> unit) = method52()
    let v5185 : unit = ()
    let v5186 : (unit -> unit) = closure91(v4875)
    let v5187 : unit = (fun () -> v5186 (); v5185) ()
    let v5500 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v4230 v5500 
    let v5501 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5501 
    let v5502 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5502 
    let v5503 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v5503 
    let v5504 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v5505 : bool = Fable.Core.RustInterop.emitRustExpr () v5504 
    let v5506 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v5507 : bool = Fable.Core.RustInterop.emitRustExpr () v5506 
    let v5508 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v5508 
    let v5509 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v5509 
    let v5510 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v5510 
    let v5511 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v5511 
    let v5512 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v5512 
    let v5513 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v5513 
    let v5514 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v5514 
    let v5515 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v5515 
    let v5516 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v5516 
    let v5517 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5517 
    let v5518 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v5518 
    let v5519 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v5520 : bool = Fable.Core.RustInterop.emitRustExpr () v5519 
    let v5521 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v5522 : bool = Fable.Core.RustInterop.emitRustExpr () v5521 
    let v5523 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v5523 
    let v5524 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v5524 
    let v5525 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v5526 : bool = Fable.Core.RustInterop.emitRustExpr () v5525 
    let v5527 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v5528 : bool = Fable.Core.RustInterop.emitRustExpr () v5527 
    let v5529 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v5530 : bool = Fable.Core.RustInterop.emitRustExpr () v5529 
    let v5531 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v5532 : bool = Fable.Core.RustInterop.emitRustExpr () v5531 
    let v5533 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v5534 : bool = Fable.Core.RustInterop.emitRustExpr () v5533 
    let v5535 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v5536 : bool = Fable.Core.RustInterop.emitRustExpr () v5535 
    let v5537 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v5538 : bool = Fable.Core.RustInterop.emitRustExpr () v5537 
    let v5539 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v5540 : bool = Fable.Core.RustInterop.emitRustExpr () v5539 
    let v5541 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v5542 : bool = Fable.Core.RustInterop.emitRustExpr () v5541 
    let v5543 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v5544 : bool = Fable.Core.RustInterop.emitRustExpr () v5543 
    let v5545 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v5546 : bool = Fable.Core.RustInterop.emitRustExpr () v5545 
    let v5547 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v5548 : bool = Fable.Core.RustInterop.emitRustExpr () v5547 
    let v5549 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v5550 : bool = Fable.Core.RustInterop.emitRustExpr () v5549 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
