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
and method10 () : string =
    let v0 : string = ""
    v0
and closure10 () (v0 : string) : US7 =
    US7_0(v0)
and method11 () : (string -> US7) =
    closure10()
and method9 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result_map_"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method10()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : US5 = US5_1
    let v18 : US6 = US6_2(v17)
    let v19 : string = $"env.get_environment_variable / target: {v18} / var: {v0}"
    let v20 : string = failwith<string> v19
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : US5 = US5_2
    let v22 : US6 = US6_2(v21)
    let v23 : string = $"env.get_environment_variable / target: {v22} / var: {v0}"
    let v24 : string = failwith<string> v23
    let _v1 = v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "process.env[$0] ?? \"\""
    let v26 : string = Fable.Core.JsInterop.emitJsExpr v0 v25 
    let _v1 = v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = "os"
    let v28 : IOsEnviron = Fable.Core.PyInterop.importAll v27 
    let v29 : string = "v28.environ"
    let v30 : obj = Fable.Core.PyInterop.emitPyExpr () v29 
    let v33 : string = "v30.get($0)"
    let v34 : string = Fable.Core.PyInterop.emitPyExpr v0 v33 
    let mutable _v34 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : (string -> string option) = Option.ofObj
    let v38 : string option = v37 v34
    v38 
    #else
    Some v34 
    #endif
    |> fun x -> _v34 <- Some x
    let v39 : string option = match _v34 with Some x -> x | None -> failwith "optionm'.of_obj / _v34=None"
    let v42 : (string -> US7) = method11()
    let v43 : US7 option = v39 |> Option.map v42 
    let v54 : US7 = US7_1
    let v55 : US7 = v43 |> Option.defaultValue v54 
    let v62 : string =
        match v55 with
        | US7_1 -> (* None *)
            let v60 : string = ""
            v60
        | US7_0(v59) -> (* Some *)
            v59
    let _v1 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : US5 = US5_1
    let v64 : US6 = US6_0(v63)
    let v65 : string = $"env.get_environment_variable / target: {v64} / var: {v0}"
    let v66 : string = failwith<string> v65
    let _v1 = v66 
    #endif
#else
    let v67 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v68 : string = v67 v0
    let mutable _v68 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v69 : (string -> string option) = Option.ofObj
    let v70 : string option = v69 v68
    v70 
    #else
    Some v68 
    #endif
    |> fun x -> _v68 <- Some x
    let v71 : string option = match _v68 with Some x -> x | None -> failwith "optionm'.of_obj / _v68=None"
    let v74 : (string -> US7) = method11()
    let v75 : US7 option = v71 |> Option.map v74 
    let v86 : US7 = US7_1
    let v87 : US7 = v75 |> Option.defaultValue v86 
    let v94 : string =
        match v87 with
        | US7_1 -> (* None *)
            let v92 : string = ""
            v92
        | US7_0(v91) -> (* Some *)
            v91
    let _v1 = v94 
    #endif
    let v95 : string = _v1 
    v95
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
    let v50 : string = "True"
    let v51 : bool = v49 <> v50 
    let v107 : US4 =
        if v51 then
            US4_1
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
            US4_0(v103)
    struct (v47, v107)
and closure11 () (v0 : string) : unit =
    ()
and method7 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US3, v3 : US4) = method8()
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US3 = US3_1
    let v5 : US4 = US4_1
    let _v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "env!(\"" + v6 + "\")"
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
    let v36 : string = "env!(\"" + v6 + "\")"
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
    let v64 : string = "env!(\"" + v6 + "\")"
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
    let v121 : US4 =
        if v110 then
            US4_1
        else
            let v114 : string = $"near_sdk::env::block_timestamp()"
            let v115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : (uint64 -> int64) = int64
            let v117 : int64 = v116 v115
            US4_0(v117)
    let v122 : US3 = US3_1
    let _v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US3, v124 : US4) = method8()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US3, v126 : US4) = method8()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US3, v128 : US4) = method8()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US3, v130 : US4) = method8()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US3, v132 : US4) = _v1 
    let v137 : Mut1 = {l0 = 1L} : Mut1
    let v138 : (string -> unit) = closure11()
    let v139 : Mut3 = {l0 = v138} : Mut3
    let v140 : Mut4 = {l0 = true} : Mut4
    let v141 : string = ""
    let v142 : Mut5 = {l0 = v141} : Mut5
    let v145 : US2 =
        match v131 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v143) -> (* Some *)
            v143
    let v146 : Mut6 = {l0 = v145} : Mut6
    let v153 : int64 option =
        match v132 with
        | US4_1 -> (* None *)
            let v151 : int64 option = None
            v151
        | US4_0(v147) -> (* Some *)
            let v148 : int64 option = Some v147 
            v148
    struct (v137, v139, v140, v142, v146, v153)
and closure9 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US2 = US2_0
        let struct (v2 : Mut1, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : Mut6, v7 : int64 option) = method7(v1)
        let v8 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method6 (v0 : US2) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut1, v18 : Mut3, v19 : Mut4, v20 : Mut5, v21 : Mut6, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US2 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
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
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US4) = method13()
    let v8 : US4 option = v5 |> Option.map v7 
    let v19 : US4 = US4_1
    let v20 : US4 = v8 |> Option.defaultValue v19 
    let v116 : System.DateTime =
        match v20 with
        | US4_1 -> (* None *)
            let v100 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v101 : System.DateTime = System.DateTime.Now
            let _v100 = v101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v102 : System.DateTime = System.DateTime.Now
            let _v100 = v102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v103 : System.DateTime = null |> unbox<System.DateTime>
            let _v100 = v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v106 : System.DateTime = System.DateTime.Now
            let _v100 = v106 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107 : System.DateTime = System.DateTime.Now
            let _v100 = v107 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v100 = v108 
            #endif
#else
            let v109 : System.DateTime = System.DateTime.Now
            let _v100 = v109 
            #endif
            let v110 : System.DateTime = _v100 
            v110
        | US4_0(v24) -> (* Some *)
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
            let v77 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v78 : System.TimeSpan = v77 v76
            let v81 : (System.TimeSpan -> int32) = _.Hours
            let v82 : int32 = v81 v78
            let v85 : (System.TimeSpan -> int32) = _.Minutes
            let v86 : int32 = v85 v78
            let v89 : (System.TimeSpan -> int32) = _.Seconds
            let v90 : int32 = v89 v78
            let v93 : (System.TimeSpan -> int32) = _.Milliseconds
            let v94 : int32 = v93 v78
            let v97 : System.DateTime = System.DateTime (1, 1, 1, v82, v86, v90, v94)
            v97
    let v117 : string = method14()
    let v120 : (string -> string) = v116.ToString
    let v121 : string = v120 v117
    let _v6 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v124 : (int64 -> US4) = method13()
    let v125 : US4 option = v5 |> Option.map v124 
    let v136 : US4 = US4_1
    let v137 : US4 = v125 |> Option.defaultValue v136 
    let v233 : System.DateTime =
        match v137 with
        | US4_1 -> (* None *)
            let v217 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : System.DateTime = System.DateTime.Now
            let _v217 = v218 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v219 : System.DateTime = System.DateTime.Now
            let _v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : System.DateTime = null |> unbox<System.DateTime>
            let _v217 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : System.DateTime = System.DateTime.Now
            let _v217 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : System.DateTime = System.DateTime.Now
            let _v217 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : System.DateTime = System.DateTime.Now
            let _v217 = v225 
            #endif
#else
            let v226 : System.DateTime = System.DateTime.Now
            let _v217 = v226 
            #endif
            let v227 : System.DateTime = _v217 
            v227
        | US4_0(v141) -> (* Some *)
            let v142 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v143 : System.DateTime = System.DateTime.Now
            let _v142 = v143 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v144 : System.DateTime = System.DateTime.Now
            let _v142 = v144 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v145 : System.DateTime = null |> unbox<System.DateTime>
            let _v142 = v145 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v148 : System.DateTime = System.DateTime.Now
            let _v142 = v148 
            #endif
#if FABLE_COMPILER_PYTHON
            let v149 : System.DateTime = System.DateTime.Now
            let _v142 = v149 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v150 : System.DateTime = System.DateTime.Now
            let _v142 = v150 
            #endif
#else
            let v151 : System.DateTime = System.DateTime.Now
            let _v142 = v151 
            #endif
            let v152 : System.DateTime = _v142 
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : (System.DateTime -> int64) = _.Ticks
            let v159 : int64 = v158 v152
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v160 : (System.DateTime -> int64) = _.Ticks
            let v161 : int64 = v160 v152
            let _v157 = v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v162 : int64 = null |> unbox<int64>
            let _v157 = v162 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v152
            let _v157 = v166 
            #endif
#if FABLE_COMPILER_PYTHON
            let v167 : (System.DateTime -> int64) = _.Ticks
            let v168 : int64 = v167 v152
            let _v157 = v168 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v169 : (System.DateTime -> int64) = _.Ticks
            let v170 : int64 = v169 v152
            let _v157 = v170 
            #endif
#else
            let v171 : (System.DateTime -> int64) = _.Ticks
            let v172 : int64 = v171 v152
            let _v157 = v172 
            #endif
            let v173 : int64 = _v157 
            let v190 : int64 = v173 |> int64 
            let v193 : int64 = v190 - v141
            let v194 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v195 : System.TimeSpan = v194 v193
            let v198 : (System.TimeSpan -> int32) = _.Hours
            let v199 : int32 = v198 v195
            let v202 : (System.TimeSpan -> int32) = _.Minutes
            let v203 : int32 = v202 v195
            let v206 : (System.TimeSpan -> int32) = _.Seconds
            let v207 : int32 = v206 v195
            let v210 : (System.TimeSpan -> int32) = _.Milliseconds
            let v211 : int32 = v210 v195
            let v214 : System.DateTime = System.DateTime (1, 1, 1, v199, v203, v207, v211)
            v214
    let v234 : string = method14()
    let v237 : (string -> string) = v233.ToString
    let v238 : string = v237 v234
    let _v6 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v241 : string = $"near_sdk::env::block_timestamp()"
    let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : (int64 -> US4) = method13()
    let v244 : US4 option = v5 |> Option.map v243 
    let v255 : US4 = US4_1
    let v256 : US4 = v244 |> Option.defaultValue v255 
    let v267 : uint64 =
        match v256 with
        | US4_1 -> (* None *)
            v242
        | US4_0(v260) -> (* Some *)
            let v261 : (int64 -> uint64) = uint64
            let v262 : uint64 = v261 v260
            let v265 : uint64 = v242 - v262
            v265
    let v268 : uint64 = v267 / 1000000000UL
    let v269 : uint64 = v268 % 60UL
    let v270 : uint64 = v268 / 60UL
    let v271 : uint64 = v270 % 60UL
    let v272 : uint64 = v268 / 3600UL
    let v273 : uint64 = v272 % 24UL
    let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _v6 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v278 : (int64 -> US4) = method13()
    let v279 : US4 option = v5 |> Option.map v278 
    let v290 : US4 = US4_1
    let v291 : US4 = v279 |> Option.defaultValue v290 
    let v387 : System.DateTime =
        match v291 with
        | US4_1 -> (* None *)
            let v371 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v372 : System.DateTime = System.DateTime.Now
            let _v371 = v372 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v373 : System.DateTime = System.DateTime.Now
            let _v371 = v373 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v374 : System.DateTime = null |> unbox<System.DateTime>
            let _v371 = v374 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v377 : System.DateTime = System.DateTime.Now
            let _v371 = v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v378 : System.DateTime = System.DateTime.Now
            let _v371 = v378 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v379 : System.DateTime = System.DateTime.Now
            let _v371 = v379 
            #endif
#else
            let v380 : System.DateTime = System.DateTime.Now
            let _v371 = v380 
            #endif
            let v381 : System.DateTime = _v371 
            v381
        | US4_0(v295) -> (* Some *)
            let v296 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v297 : System.DateTime = System.DateTime.Now
            let _v296 = v297 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v298 : System.DateTime = System.DateTime.Now
            let _v296 = v298 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v299 : System.DateTime = null |> unbox<System.DateTime>
            let _v296 = v299 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v302 : System.DateTime = System.DateTime.Now
            let _v296 = v302 
            #endif
#if FABLE_COMPILER_PYTHON
            let v303 : System.DateTime = System.DateTime.Now
            let _v296 = v303 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v304 : System.DateTime = System.DateTime.Now
            let _v296 = v304 
            #endif
#else
            let v305 : System.DateTime = System.DateTime.Now
            let _v296 = v305 
            #endif
            let v306 : System.DateTime = _v296 
            let v311 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v306
            let _v311 = v313 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v314 : (System.DateTime -> int64) = _.Ticks
            let v315 : int64 = v314 v306
            let _v311 = v315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v316 : int64 = null |> unbox<int64>
            let _v311 = v316 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : (System.DateTime -> int64) = _.Ticks
            let v320 : int64 = v319 v306
            let _v311 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : (System.DateTime -> int64) = _.Ticks
            let v322 : int64 = v321 v306
            let _v311 = v322 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v323 : (System.DateTime -> int64) = _.Ticks
            let v324 : int64 = v323 v306
            let _v311 = v324 
            #endif
#else
            let v325 : (System.DateTime -> int64) = _.Ticks
            let v326 : int64 = v325 v306
            let _v311 = v326 
            #endif
            let v327 : int64 = _v311 
            let v344 : int64 = v327 |> int64 
            let v347 : int64 = v344 - v295
            let v348 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v349 : System.TimeSpan = v348 v347
            let v352 : (System.TimeSpan -> int32) = _.Hours
            let v353 : int32 = v352 v349
            let v356 : (System.TimeSpan -> int32) = _.Minutes
            let v357 : int32 = v356 v349
            let v360 : (System.TimeSpan -> int32) = _.Seconds
            let v361 : int32 = v360 v349
            let v364 : (System.TimeSpan -> int32) = _.Milliseconds
            let v365 : int32 = v364 v349
            let v368 : System.DateTime = System.DateTime (1, 1, 1, v353, v357, v361, v365)
            v368
    let v388 : string = method15()
    let v391 : (string -> string) = v387.ToString
    let v392 : string = v391 v388
    let _v6 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v395 : (int64 -> US4) = method13()
    let v396 : US4 option = v5 |> Option.map v395 
    let v407 : US4 = US4_1
    let v408 : US4 = v396 |> Option.defaultValue v407 
    let v504 : System.DateTime =
        match v408 with
        | US4_1 -> (* None *)
            let v488 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v489 : System.DateTime = System.DateTime.Now
            let _v488 = v489 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v490 : System.DateTime = System.DateTime.Now
            let _v488 = v490 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v491 : System.DateTime = null |> unbox<System.DateTime>
            let _v488 = v491 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v494 : System.DateTime = System.DateTime.Now
            let _v488 = v494 
            #endif
#if FABLE_COMPILER_PYTHON
            let v495 : System.DateTime = System.DateTime.Now
            let _v488 = v495 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v496 : System.DateTime = System.DateTime.Now
            let _v488 = v496 
            #endif
#else
            let v497 : System.DateTime = System.DateTime.Now
            let _v488 = v497 
            #endif
            let v498 : System.DateTime = _v488 
            v498
        | US4_0(v412) -> (* Some *)
            let v413 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v414 : System.DateTime = System.DateTime.Now
            let _v413 = v414 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : System.DateTime = System.DateTime.Now
            let _v413 = v415 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v416 : System.DateTime = null |> unbox<System.DateTime>
            let _v413 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v419 : System.DateTime = System.DateTime.Now
            let _v413 = v419 
            #endif
#if FABLE_COMPILER_PYTHON
            let v420 : System.DateTime = System.DateTime.Now
            let _v413 = v420 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v421 : System.DateTime = System.DateTime.Now
            let _v413 = v421 
            #endif
#else
            let v422 : System.DateTime = System.DateTime.Now
            let _v413 = v422 
            #endif
            let v423 : System.DateTime = _v413 
            let v428 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v429 : (System.DateTime -> int64) = _.Ticks
            let v430 : int64 = v429 v423
            let _v428 = v430 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v431 : (System.DateTime -> int64) = _.Ticks
            let v432 : int64 = v431 v423
            let _v428 = v432 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v433 : int64 = null |> unbox<int64>
            let _v428 = v433 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v436 : (System.DateTime -> int64) = _.Ticks
            let v437 : int64 = v436 v423
            let _v428 = v437 
            #endif
#if FABLE_COMPILER_PYTHON
            let v438 : (System.DateTime -> int64) = _.Ticks
            let v439 : int64 = v438 v423
            let _v428 = v439 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v423
            let _v428 = v441 
            #endif
#else
            let v442 : (System.DateTime -> int64) = _.Ticks
            let v443 : int64 = v442 v423
            let _v428 = v443 
            #endif
            let v444 : int64 = _v428 
            let v461 : int64 = v444 |> int64 
            let v464 : int64 = v461 - v412
            let v465 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v466 : System.TimeSpan = v465 v464
            let v469 : (System.TimeSpan -> int32) = _.Hours
            let v470 : int32 = v469 v466
            let v473 : (System.TimeSpan -> int32) = _.Minutes
            let v474 : int32 = v473 v466
            let v477 : (System.TimeSpan -> int32) = _.Seconds
            let v478 : int32 = v477 v466
            let v481 : (System.TimeSpan -> int32) = _.Milliseconds
            let v482 : int32 = v481 v466
            let v485 : System.DateTime = System.DateTime (1, 1, 1, v470, v474, v478, v482)
            v485
    let v505 : string = method15()
    let v508 : (string -> string) = v504.ToString
    let v509 : string = v508 v505
    let _v6 = v509 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v512 : (int64 -> US4) = method13()
    let v513 : US4 option = v5 |> Option.map v512 
    let v524 : US4 = US4_1
    let v525 : US4 = v513 |> Option.defaultValue v524 
    let v621 : System.DateTime =
        match v525 with
        | US4_1 -> (* None *)
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : System.DateTime = System.DateTime.Now
            let _v605 = v606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v607 : System.DateTime = System.DateTime.Now
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v608 : System.DateTime = null |> unbox<System.DateTime>
            let _v605 = v608 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v611 : System.DateTime = System.DateTime.Now
            let _v605 = v611 
            #endif
#if FABLE_COMPILER_PYTHON
            let v612 : System.DateTime = System.DateTime.Now
            let _v605 = v612 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v613 : System.DateTime = System.DateTime.Now
            let _v605 = v613 
            #endif
#else
            let v614 : System.DateTime = System.DateTime.Now
            let _v605 = v614 
            #endif
            let v615 : System.DateTime = _v605 
            v615
        | US4_0(v529) -> (* Some *)
            let v530 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v531 : System.DateTime = System.DateTime.Now
            let _v530 = v531 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v532 : System.DateTime = System.DateTime.Now
            let _v530 = v532 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : System.DateTime = null |> unbox<System.DateTime>
            let _v530 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : System.DateTime = System.DateTime.Now
            let _v530 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : System.DateTime = System.DateTime.Now
            let _v530 = v537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v538 : System.DateTime = System.DateTime.Now
            let _v530 = v538 
            #endif
#else
            let v539 : System.DateTime = System.DateTime.Now
            let _v530 = v539 
            #endif
            let v540 : System.DateTime = _v530 
            let v545 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v546 : (System.DateTime -> int64) = _.Ticks
            let v547 : int64 = v546 v540
            let _v545 = v547 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v548 : (System.DateTime -> int64) = _.Ticks
            let v549 : int64 = v548 v540
            let _v545 = v549 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v550 : int64 = null |> unbox<int64>
            let _v545 = v550 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v553 : (System.DateTime -> int64) = _.Ticks
            let v554 : int64 = v553 v540
            let _v545 = v554 
            #endif
#if FABLE_COMPILER_PYTHON
            let v555 : (System.DateTime -> int64) = _.Ticks
            let v556 : int64 = v555 v540
            let _v545 = v556 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v557 : (System.DateTime -> int64) = _.Ticks
            let v558 : int64 = v557 v540
            let _v545 = v558 
            #endif
#else
            let v559 : (System.DateTime -> int64) = _.Ticks
            let v560 : int64 = v559 v540
            let _v545 = v560 
            #endif
            let v561 : int64 = _v545 
            let v578 : int64 = v561 |> int64 
            let v581 : int64 = v578 - v529
            let v582 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v583 : System.TimeSpan = v582 v581
            let v586 : (System.TimeSpan -> int32) = _.Hours
            let v587 : int32 = v586 v583
            let v590 : (System.TimeSpan -> int32) = _.Minutes
            let v591 : int32 = v590 v583
            let v594 : (System.TimeSpan -> int32) = _.Seconds
            let v595 : int32 = v594 v583
            let v598 : (System.TimeSpan -> int32) = _.Milliseconds
            let v599 : int32 = v598 v583
            let v602 : System.DateTime = System.DateTime (1, 1, 1, v587, v591, v595, v599)
            v602
    let v622 : string = method15()
    let v625 : (string -> string) = v621.ToString
    let v626 : string = v625 v622
    let _v6 = v626 
    #endif
#else
    let v629 : (int64 -> US4) = method13()
    let v630 : US4 option = v5 |> Option.map v629 
    let v641 : US4 = US4_1
    let v642 : US4 = v630 |> Option.defaultValue v641 
    let v738 : System.DateTime =
        match v642 with
        | US4_1 -> (* None *)
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
            v732
        | US4_0(v646) -> (* Some *)
            let v647 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v648 : System.DateTime = System.DateTime.Now
            let _v647 = v648 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v649 : System.DateTime = System.DateTime.Now
            let _v647 = v649 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v650 : System.DateTime = null |> unbox<System.DateTime>
            let _v647 = v650 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v653 : System.DateTime = System.DateTime.Now
            let _v647 = v653 
            #endif
#if FABLE_COMPILER_PYTHON
            let v654 : System.DateTime = System.DateTime.Now
            let _v647 = v654 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v655 : System.DateTime = System.DateTime.Now
            let _v647 = v655 
            #endif
#else
            let v656 : System.DateTime = System.DateTime.Now
            let _v647 = v656 
            #endif
            let v657 : System.DateTime = _v647 
            let v662 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v663 : (System.DateTime -> int64) = _.Ticks
            let v664 : int64 = v663 v657
            let _v662 = v664 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v665 : (System.DateTime -> int64) = _.Ticks
            let v666 : int64 = v665 v657
            let _v662 = v666 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v667 : int64 = null |> unbox<int64>
            let _v662 = v667 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v670 : (System.DateTime -> int64) = _.Ticks
            let v671 : int64 = v670 v657
            let _v662 = v671 
            #endif
#if FABLE_COMPILER_PYTHON
            let v672 : (System.DateTime -> int64) = _.Ticks
            let v673 : int64 = v672 v657
            let _v662 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : (System.DateTime -> int64) = _.Ticks
            let v675 : int64 = v674 v657
            let _v662 = v675 
            #endif
#else
            let v676 : (System.DateTime -> int64) = _.Ticks
            let v677 : int64 = v676 v657
            let _v662 = v677 
            #endif
            let v678 : int64 = _v662 
            let v695 : int64 = v678 |> int64 
            let v698 : int64 = v695 - v646
            let v699 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v700 : System.TimeSpan = v699 v698
            let v703 : (System.TimeSpan -> int32) = _.Hours
            let v704 : int32 = v703 v700
            let v707 : (System.TimeSpan -> int32) = _.Minutes
            let v708 : int32 = v707 v700
            let v711 : (System.TimeSpan -> int32) = _.Seconds
            let v712 : int32 = v711 v700
            let v715 : (System.TimeSpan -> int32) = _.Milliseconds
            let v716 : int32 = v715 v700
            let v719 : System.DateTime = System.DateTime (1, 1, 1, v704, v708, v712, v716)
            v719
    let v739 : string = method15()
    let v742 : (string -> string) = v738.ToString
    let v743 : string = v742 v739
    let _v6 = v743 
    #endif
    let v746 : string = _v6 
    v746
and method18 () : string =
    let v0 : string = ""
    v0
and closure13 (v0 : Mut5, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method17 (v0 : char) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure13(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method19 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method16 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method17(v5)
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
    let v105 : string = method19()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method19()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method19()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method19()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method21 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "current_index"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure13(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure13(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure13(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure13(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure13(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure13(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "len"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure13(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure13(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure13(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "last_item"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure13(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure13(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method22 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v28 : char list = []
    let v29 : char list = '/' :: v28 
    let v32 : char list = ' ' :: v29 
    let v35 : (char list -> (char [])) = List.toArray
    let v36 : (char []) = v35 v32
    let v39 : string = v6.TrimEnd v36 
    v39
and method20 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method21(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.create_sequential_roller / roll"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
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
and method23 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut1, v18 : Mut3, v19 : Mut4, v20 : Mut5, v21 : Mut6, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure14(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure15()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v42 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
    let _v41 = () 
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
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US2 = US2_1
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure9()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut1, v23 : Mut3, v24 : Mut4, v25 : Mut5, v26 : Mut6, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method12(v22, v23, v24, v25, v26, v27)
        let v41 : string = method16()
        let v42 : string = $"%A{v3}"
        let v45 : string = method20(v22, v23, v24, v25, v26, v27, v40, v41, v0, v1, v2, v42)
        method23(v45)
and method24 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method24(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method26 () : string =
    let v0 : string = method18()
    let v1 : Mut5 = {l0 = v0} : Mut5
    let v2 : string = v1.l0
    v2
and method25 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method26()
    let v9 : int64 = v0.l0
    let v10 : string = "dice.create_sequential_roller / roll / None"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method22(v11)
and closure17 () () : unit =
    let v0 : US2 = US2_1
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure9()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method12(v18, v19, v20, v21, v22, v23)
        let v37 : string = method16()
        let v38 : string = method25(v18, v19, v20, v21, v22, v23, v36, v37)
        method23(v38)
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US1 = v4.l0
    let v15 : uint8 option =
        match v8 with
        | US1_1 -> (* None *)
            let v13 : uint8 option = None
            v13
        | US1_0(v9) -> (* Some *)
            let v10 : uint8 option = Some v9 
            v10
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v5, v6, v7, v15)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v61 : UH0 = v0 ()
    let v62 : int64 = v1.l0
    let v63 : US1 = method24(v62, v61)
    match v63 with
    | US1_1 -> (* None *)
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure17()
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
        let v121 : US1 = US1_1
        v4.l0 <- v121
        method5(v0, v1, v2, v3, v4)
    | US1_0(v64) -> (* Some *)
        let v65 : int64 = v1.l0
        let v66 : int64 = v65 + 1L
        v1.l0 <- v66
        let v67 : US1 = US1_0(v64)
        v4.l0 <- v67
        v64
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
and method29 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure13(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "p"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "n"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method28 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method29(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.calculate_dice_count"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure21 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method28(v21, v22, v23, v24, v25, v26, v39, v40, v0, v2, v1)
        method23(v41)
and method27 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method27(v0, v6, v4)
        else
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure21(v0, v1, v2)
            let v10 : unit = (fun () -> v9 (); v8) ()
            v1
    else
        let v51 : unit = ()
        let v52 : (unit -> unit) = closure21(v0, v1, v2)
        let v53 : unit = (fun () -> v52 (); v51) ()
        v1
and method33 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure13(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method32 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method33(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method32(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method23(v41)
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
and method34 (v0 : int8, v1 : UH2) : US9 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US9_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method34(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US9_1
and method36 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "power"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure13(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure13(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure13(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure13(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure13(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure13(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "roll"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure13(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure13(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure13(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "value"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure13(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure13(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method35 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method36(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US2 = US2_1
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure9()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut1, v23 : Mut3, v24 : Mut4, v25 : Mut5, v26 : Mut6, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method12(v22, v23, v24, v25, v26, v27)
        let v41 : string = method16()
        let v42 : string = method35(v22, v23, v24, v25, v26, v27, v40, v41, v1, v0, v2, v3)
        method23(v42)
and method38 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure13(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "roll"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method37 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method38(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method37(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method23(v41)
and method31 (v0 : int8, v1 : UH1, v2 : uint64) : US8 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure22(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US8_0(v4, v1)
    else
        match v1 with
        | UH1_1(v49, v50) -> (* Cons *)
            let v51 : bool = v49 > 1uy
            if v51 then
                let v52 : uint64 = 1UL
                let v53 : (unit -> UH2) = closure23()
                let v54 : UH2 = UH2_0(v52, v53)
                let v55 : US9 = method34(v0, v54)
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
                method31(v106, v50, v105)
            else
                let v108 : unit = ()
                let v109 : (unit -> unit) = closure88(v2, v0, v49)
                let v110 : unit = (fun () -> v109 (); v108) ()
                let v150 : int8 = v0 - 1y
                method31(v150, v50, v2)
        | UH1_0 -> (* Nil *)
            US8_1
and method39 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method39(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method40 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method30(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US8 = method31(v3, v4, v10)
        match v11 with
        | US8_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method39(v3, v0, v15)
                    method40(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method30(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method39(v3, v0, v23)
                method40(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method30(v0, v1, v2, v3, v27, v5)
and method30 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method30(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US8 = method31(v3, v4, v12)
        match v13 with
        | US8_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method39(v3, v0, v17)
                    method40(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method30(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method39(v3, v0, v26)
                method40(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method30(v0, v1, v2, v3, v30, v31)
and closure20 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method27(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method30(v0, v1, v2, v8, v9, v10)
and closure19 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure20(v0, v1)
and closure18 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure19(v0)
and method41 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method41(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure90 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method41(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US8 = method31(v4, v1, v5)
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
        let v21 : uint64 option = None
        v21
    | US9_0(v17) -> (* Some *)
        let v18 : uint64 option = Some v17 
        v18
and closure89 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure90(v0)
and method43 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure13(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "p"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "n"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method42 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = 9223372036854775807L
    let v9 : int64 = 4738381338321616896L
    let v10 : int8 = 24y
    let v11 : string = method43(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.calculate_dice_count"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure92 () () : unit =
    let v0 : US2 = US2_1
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure9()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method12(v18, v19, v20, v21, v22, v23)
        let v37 : string = method16()
        let v38 : string = method42(v18, v19, v20, v21, v22, v23, v36, v37)
        method23(v38)
and method45 () : uint8 =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v2 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v1 
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v4 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v3 
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : uint8 = failwith<uint8> "common.random' / target=Rust(Contract)"
    let _v0 = v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : (unit -> System.Random) = System.Random 
    let v7 : System.Random = v6 ()
    let v8 : int32 = 1uy |> int32 
    let v15 : int32 = 7uy |> int32 
    let v22 : int32 = v7.Next (v8, v15)
    let v23 : uint8 = v22 |> uint8 
    let _v0 = v23 
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : (unit -> System.Random) = System.Random 
    let v27 : System.Random = v26 ()
    let v28 : int32 = 1uy |> int32 
    let v35 : int32 = 7uy |> int32 
    let v42 : int32 = v27.Next (v28, v35)
    let v43 : uint8 = v42 |> uint8 
    let _v0 = v43 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v46 : (unit -> System.Random) = System.Random 
    let v47 : System.Random = v46 ()
    let v48 : int32 = 1uy |> int32 
    let v55 : int32 = 7uy |> int32 
    let v62 : int32 = v47.Next (v48, v55)
    let v63 : uint8 = v62 |> uint8 
    let _v0 = v63 
    #endif
#else
    let v66 : (unit -> System.Random) = System.Random 
    let v67 : System.Random = v66 ()
    let v68 : int32 = 1uy |> int32 
    let v75 : int32 = 7uy |> int32 
    let v82 : int32 = v67.Next (v68, v75)
    let v83 : uint8 = v82 |> uint8 
    let _v0 = v83 
    #endif
    let v86 : uint8 = _v0 
    v86
and method48 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure13(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "power"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure13(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure13(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure13(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure13(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure13(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure13(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure13(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure13(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "roll"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure13(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure13(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure13(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "value"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure13(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure13(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure13(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure13(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method47 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 23y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure93 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method47(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method50 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 22y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure94 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method50(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method52 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 21y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure95 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method52(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method54 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 20y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure96 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method54(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method56 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 19y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure97 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method56(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method58 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 18y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure98 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method58(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method60 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 17y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure99 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method60(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method62 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 16y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure100 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method62(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method64 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 15y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure101 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method64(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method66 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 14y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure102 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method66(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method68 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 13y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method68(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method70 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 12y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method70(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method72 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 11y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method72(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method74 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 10y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method74(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method76 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 9y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method76(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method78 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 8y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method78(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method80 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 7y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method80(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method82 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 6y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method82(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method84 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 5y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method84(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method86 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 4y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method86(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method88 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 3y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method88(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method90 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 2y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method90(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method92 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 1y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method92(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method94 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int8 = 0y
    let v12 : string = method48(v11, v8, v9, v10)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method22(v15)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : US2 = US2_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure9()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut1, v22 : Mut3, v23 : Mut4, v24 : Mut5, v25 : Mut6, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method94(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method23(v41)
and method97 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure13(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method96 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int8 = -1y
    let v11 : string = method97(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure117 (v0 : int64, v1 : int64) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method96(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method95 (v0 : UH1, v1 : int64) : US10 =
    let v2 : int64 = v1 + 1L
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure117(v1, v2)
    let v5 : unit = (fun () -> v4 (); v3) ()
    US10_0(v2, v0)
and method99 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure13(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure13(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure13(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure13(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure13(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure13(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure13(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure13(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "roll"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure13(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure13(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure13(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure13(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method98 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 0y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure118 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method98(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method93 (v0 : UH1, v1 : int64) : US10 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure116(v1, v3, v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            let v50 : int64 = v1 + v7
            method95(v4, v50)
        else
            let v52 : unit = ()
            let v53 : (unit -> unit) = closure118(v1, v3)
            let v54 : unit = (fun () -> v53 (); v52) ()
            method95(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method100 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 1y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure119 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method100(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method91 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method93(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure119(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method93(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 2y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure120 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method101(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method89 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method91(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure120(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method91(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 3y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure121 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method102(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method87 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method89(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure121(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method89(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 4y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure122 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method103(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method85 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method87(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure122(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method87(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 5y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure123 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method104(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method83 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method85(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure123(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method85(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 6y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure124 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method105(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method81 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method83(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure124(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method83(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 7y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure125 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method106(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method79 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method81(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure125(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method81(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 8y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure126 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method107(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method77 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method79(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure126(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method79(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 9y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure127 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method108(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method75 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method77(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure127(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method77(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 10y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method109(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method73 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method75(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure128(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method75(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 11y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method110(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method71 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method73(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure129(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method73(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 12y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method111(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method69 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method71(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure130(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method71(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 13y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method112(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method67 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method69(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure131(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method69(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 14y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method113(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method65 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method67(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure132(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method67(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method114 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 15y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method114(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method63 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method65(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure133(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method65(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method115 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 16y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method115(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method61 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method63(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure134(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method63(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method116 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 17y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method116(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method59 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method61(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure135(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method61(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method117 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 18y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method117(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method57 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method59(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure136(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method59(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method118 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 19y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method118(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method55 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method57(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure137(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method57(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method119 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 20y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method119(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method53 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method55(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure138(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method55(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method120 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 21y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method120(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method51 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method53(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure139(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method53(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method121 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 22y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method121(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method49 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method51(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure140(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method51(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method122 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int8 = 23y
    let v11 : string = method99(v10, v8, v9)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v2 : US2 = US2_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure9()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut1, v21 : Mut3, v22 : Mut4, v23 : Mut5, v24 : Mut6, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method122(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method46 (v0 : UH1, v1 : int64) : US10 =
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
            let v51 : int64 = v1 + v8
            method49(v4, v51)
        else
            let v53 : unit = ()
            let v54 : (unit -> unit) = closure141(v1, v3)
            let v55 : unit = (fun () -> v54 (); v53) ()
            method49(v4, v1)
    | UH1_0 -> (* Nil *)
        US10_1
and method44 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method45()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method44(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US10 = method46(v0, v7)
        match v8 with
        | US10_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method45()
                let v13 : uint8 = method45()
                let v14 : uint8 = method45()
                let v15 : uint8 = method45()
                let v16 : uint8 = method45()
                let v17 : uint8 = method45()
                let v18 : uint8 = method45()
                let v19 : uint8 = method45()
                let v20 : uint8 = method45()
                let v21 : uint8 = method45()
                let v22 : uint8 = method45()
                let v23 : uint8 = method45()
                let v24 : uint8 = method45()
                let v25 : uint8 = method45()
                let v26 : uint8 = method45()
                let v27 : uint8 = method45()
                let v28 : uint8 = method45()
                let v29 : uint8 = method45()
                let v30 : uint8 = method45()
                let v31 : uint8 = method45()
                let v32 : uint8 = method45()
                let v33 : uint8 = method45()
                let v34 : uint8 = method45()
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
                method44(v58, v59)
        | _ ->
            let v62 : uint8 = method45()
            let v63 : uint8 = method45()
            let v64 : uint8 = method45()
            let v65 : uint8 = method45()
            let v66 : uint8 = method45()
            let v67 : uint8 = method45()
            let v68 : uint8 = method45()
            let v69 : uint8 = method45()
            let v70 : uint8 = method45()
            let v71 : uint8 = method45()
            let v72 : uint8 = method45()
            let v73 : uint8 = method45()
            let v74 : uint8 = method45()
            let v75 : uint8 = method45()
            let v76 : uint8 = method45()
            let v77 : uint8 = method45()
            let v78 : uint8 = method45()
            let v79 : uint8 = method45()
            let v80 : uint8 = method45()
            let v81 : uint8 = method45()
            let v82 : uint8 = method45()
            let v83 : uint8 = method45()
            let v84 : uint8 = method45()
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
            method44(v108, v109)
and method124 (v0 : int64) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure13(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "result"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure13(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure13(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure13(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure13(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method123 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : string = method124(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "dice.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method22(v12)
and closure142 (v0 : int64) () : unit =
    let v1 : US2 = US2_1
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure9()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut1, v20 : Mut3, v21 : Mut4, v22 : Mut5, v23 : Mut6, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method12(v19, v20, v21, v22, v23, v24)
        let v38 : string = method16()
        let v39 : string = method123(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method23(v39)
and closure91 () (v0 : (string [])) : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure92()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v43 : UH1 = UH1_0
    let v44 : int8 = 0y
    let v45 : int64 = method44(v43, v44)
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure142(v45)
    let v48 : unit = (fun () -> v47 (); v46) ()
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
