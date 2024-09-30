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
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and UH0 =
    | UH0_0
    | UH0_1 of uint8 * UH0
and UH1 =
    | UH1_0 of uint8 * (unit -> UH1)
    | UH1_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : (unit -> UH1)
    | US4_1 of f1_0 : UH1
and Mut5 = {mutable l0 : US4}
and [<Struct>] US5 =
    | US5_0 of f0_0 : uint8
    | US5_1
and Mut6 = {mutable l0 : US5}
and [<Struct>] US6 =
    | US6_0 of f0_0 : uint64 * f0_1 : UH0
    | US6_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : uint64
    | US7_1
let rec method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US1 =
    US1_0(v0)
and method4 () : (string -> US1) =
    closure3()
and method2 (v0 : string) : string =
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
    let v14 : string = method3()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result_map_"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method3()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result_map_"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method3()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    let _v1 = v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0] ?? \"\""
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    let _v1 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v55 : string = "v52.get($0)"
    let v56 : string = Fable.Core.PyInterop.emitPyExpr v0 v55 
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v59 : (string -> string option) = Option.ofObj
    let v60 : string option = v59 v56
    v60 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v61 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v64 : (string -> US1) = method4()
    let v65 : US1 option = v61 |> Option.map v64 
    let v76 : US1 = US1_1
    let v77 : US1 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US1_1 -> (* None *)
            let v82 : string = ""
            v82
        | US1_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#else
    let v85 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v86 : string = v85 v0
    let mutable _v86 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v87 : (string -> string option) = Option.ofObj
    let v88 : string option = v87 v86
    v88 
    #else
    Some v86 
    #endif
    |> fun x -> _v86 <- Some x
    let v89 : string option = match _v86 with Some x -> x | None -> failwith "optionm'.of_obj / _v86=None"
    let v92 : (string -> US1) = method4()
    let v93 : US1 option = v89 |> Option.map v92 
    let v104 : US1 = US1_1
    let v105 : US1 = v93 |> Option.defaultValue v104 
    let v112 : string =
        match v105 with
        | US1_1 -> (* None *)
            let v110 : string = ""
            v110
        | US1_0(v109) -> (* Some *)
            v109
    let _v1 = v112 
    #endif
    let v113 : string = _v1 
    v113
and method5 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure4 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method1()
    let v3 : string = method2(v2)
    
    
    
    
    
    let v4 : bool = "Verbose" = v3
    let v8 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            US2_1
    let v49 : US2 =
        match v8 with
        | US2_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US2 =
                if v11 then
                    let v12 : US0 = US0_1
                    US2_0(v12)
                else
                    US2_1
            match v15 with
            | US2_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US2 =
                    if v18 then
                        let v19 : US0 = US0_2
                        US2_0(v19)
                    else
                        US2_1
                match v22 with
                | US2_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US2 =
                        if v25 then
                            let v26 : US0 = US0_3
                            US2_0(v26)
                        else
                            US2_1
                    match v29 with
                    | US2_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US2 =
                            if v32 then
                                let v33 : US0 = US0_4
                                US2_0(v33)
                            else
                                US2_1
                        match v36 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v37) -> (* Some *)
                            US2_0(v37)
                    | US2_0(v30) -> (* Some *)
                        US2_0(v30)
                | US2_0(v23) -> (* Some *)
                    US2_0(v23)
            | US2_0(v16) -> (* Some *)
                US2_0(v16)
        | US2_0(v9) -> (* Some *)
            US2_0(v9)
    let v50 : string = method5()
    let v51 : string = method2(v50)
    let v52 : bool = v51 = "True"
    let v62 : US3 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US3_0(v57)
        else
            US3_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US2 = US2_1
    let v64 : US3 = US3_1
    let _v1 = struct (v63, v64) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "AUTOMATION"
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "env!(\"" + v65 + "\")"
    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v70 : string = "String::from($0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v70 
    let _v69 = v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "String::from($0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v72 
    let _v69 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "String::from($0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v74 
    let _v69 = v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v79 
    #endif
#else
    let v82 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v82 
    #endif
    let v85 : std_string_String = _v69 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v66 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "env!(\"" + v65 + "\")"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v95 
    let _v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v97 
    let _v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v99 
    let _v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v104 
    #endif
#else
    let v107 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v107 
    #endif
    let v110 : std_string_String = _v94 
    let v115 : string = "fable_library_rust::String_::fromString($0)"
    let v116 : string = Fable.Core.RustInterop.emitRustExpr v110 v115 
    let _v66 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : string = "env!(\"" + v65 + "\")"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117 
    let v119 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : string = "String::from($0)"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v120 
    let _v119 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : string = "String::from($0)"
    let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v122 
    let _v119 = v123 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v124 
    let _v119 = v125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v129 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v129 
    #endif
#else
    let v132 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v132 
    #endif
    let v135 : std_string_String = _v119 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v135 v140 
    let _v66 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : string = null |> unbox<string>
    let _v66 = v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v145 : string = null |> unbox<string>
    let _v66 = v145 
    #endif
#else
    let v148 : string = null |> unbox<string>
    let _v66 = v148 
    #endif
    let v151 : string = _v66 
    let v156 : string = "True"
    let v157 : bool = v151 <> v156 
    let v166 : US3 =
        if v157 then
            US3_1
        else
            let v161 : string = $"near_sdk::env::block_timestamp()"
            let v162 : uint64 = Fable.Core.RustInterop.emitRustExpr () v161 
            let v163 : (uint64 -> int64) = int64
            let v164 : int64 = v163 v162
            US3_0(v164)
    let v167 : US2 = US2_1
    let _v1 = struct (v167, v166) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : string = method1()
    let v169 : string = method2(v168)
    
    
    
    
    
    let v170 : bool = "Verbose" = v169
    let v174 : US2 =
        if v170 then
            let v171 : US0 = US0_0
            US2_0(v171)
        else
            US2_1
    let v215 : US2 =
        match v174 with
        | US2_1 -> (* None *)
            let v177 : bool = "Debug" = v169
            let v181 : US2 =
                if v177 then
                    let v178 : US0 = US0_1
                    US2_0(v178)
                else
                    US2_1
            match v181 with
            | US2_1 -> (* None *)
                let v184 : bool = "Info" = v169
                let v188 : US2 =
                    if v184 then
                        let v185 : US0 = US0_2
                        US2_0(v185)
                    else
                        US2_1
                match v188 with
                | US2_1 -> (* None *)
                    let v191 : bool = "Warning" = v169
                    let v195 : US2 =
                        if v191 then
                            let v192 : US0 = US0_3
                            US2_0(v192)
                        else
                            US2_1
                    match v195 with
                    | US2_1 -> (* None *)
                        let v198 : bool = "Critical" = v169
                        let v202 : US2 =
                            if v198 then
                                let v199 : US0 = US0_4
                                US2_0(v199)
                            else
                                US2_1
                        match v202 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v203) -> (* Some *)
                            US2_0(v203)
                    | US2_0(v196) -> (* Some *)
                        US2_0(v196)
                | US2_0(v189) -> (* Some *)
                    US2_0(v189)
            | US2_0(v182) -> (* Some *)
                US2_0(v182)
        | US2_0(v175) -> (* Some *)
            US2_0(v175)
    let v216 : string = method5()
    let v217 : string = method2(v216)
    let v218 : bool = v217 = "True"
    let v228 : US3 =
        if v218 then
            let v219 : System.DateTime = System.DateTime.Now
            let v222 : (System.DateTime -> int64) = _.Ticks
            let v223 : int64 = v222 v219
            US3_0(v223)
        else
            US3_1
    let _v1 = struct (v215, v228) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v229 : string = method1()
    let v230 : string = method2(v229)
    
    
    
    
    
    let v231 : bool = "Verbose" = v230
    let v235 : US2 =
        if v231 then
            let v232 : US0 = US0_0
            US2_0(v232)
        else
            US2_1
    let v276 : US2 =
        match v235 with
        | US2_1 -> (* None *)
            let v238 : bool = "Debug" = v230
            let v242 : US2 =
                if v238 then
                    let v239 : US0 = US0_1
                    US2_0(v239)
                else
                    US2_1
            match v242 with
            | US2_1 -> (* None *)
                let v245 : bool = "Info" = v230
                let v249 : US2 =
                    if v245 then
                        let v246 : US0 = US0_2
                        US2_0(v246)
                    else
                        US2_1
                match v249 with
                | US2_1 -> (* None *)
                    let v252 : bool = "Warning" = v230
                    let v256 : US2 =
                        if v252 then
                            let v253 : US0 = US0_3
                            US2_0(v253)
                        else
                            US2_1
                    match v256 with
                    | US2_1 -> (* None *)
                        let v259 : bool = "Critical" = v230
                        let v263 : US2 =
                            if v259 then
                                let v260 : US0 = US0_4
                                US2_0(v260)
                            else
                                US2_1
                        match v263 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v264) -> (* Some *)
                            US2_0(v264)
                    | US2_0(v257) -> (* Some *)
                        US2_0(v257)
                | US2_0(v250) -> (* Some *)
                    US2_0(v250)
            | US2_0(v243) -> (* Some *)
                US2_0(v243)
        | US2_0(v236) -> (* Some *)
            US2_0(v236)
    let v277 : string = method5()
    let v278 : string = method2(v277)
    let v279 : bool = v278 = "True"
    let v289 : US3 =
        if v279 then
            let v280 : System.DateTime = System.DateTime.Now
            let v283 : (System.DateTime -> int64) = _.Ticks
            let v284 : int64 = v283 v280
            US3_0(v284)
        else
            US3_1
    let _v1 = struct (v276, v289) 
    #endif
#else
    let v290 : string = method1()
    let v291 : string = method2(v290)
    
    
    
    
    
    let v292 : bool = "Verbose" = v291
    let v296 : US2 =
        if v292 then
            let v293 : US0 = US0_0
            US2_0(v293)
        else
            US2_1
    let v337 : US2 =
        match v296 with
        | US2_1 -> (* None *)
            let v299 : bool = "Debug" = v291
            let v303 : US2 =
                if v299 then
                    let v300 : US0 = US0_1
                    US2_0(v300)
                else
                    US2_1
            match v303 with
            | US2_1 -> (* None *)
                let v306 : bool = "Info" = v291
                let v310 : US2 =
                    if v306 then
                        let v307 : US0 = US0_2
                        US2_0(v307)
                    else
                        US2_1
                match v310 with
                | US2_1 -> (* None *)
                    let v313 : bool = "Warning" = v291
                    let v317 : US2 =
                        if v313 then
                            let v314 : US0 = US0_3
                            US2_0(v314)
                        else
                            US2_1
                    match v317 with
                    | US2_1 -> (* None *)
                        let v320 : bool = "Critical" = v291
                        let v324 : US2 =
                            if v320 then
                                let v321 : US0 = US0_4
                                US2_0(v321)
                            else
                                US2_1
                        match v324 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v325) -> (* Some *)
                            US2_0(v325)
                    | US2_0(v318) -> (* Some *)
                        US2_0(v318)
                | US2_0(v311) -> (* Some *)
                    US2_0(v311)
            | US2_0(v304) -> (* Some *)
                US2_0(v304)
        | US2_0(v297) -> (* Some *)
            US2_0(v297)
    let v338 : string = method5()
    let v339 : string = method2(v338)
    let v340 : bool = v339 = "True"
    let v350 : US3 =
        if v340 then
            let v341 : System.DateTime = System.DateTime.Now
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v341
            US3_0(v345)
        else
            US3_1
    let _v1 = struct (v337, v350) 
    #endif
    let struct (v351 : US2, v352 : US3) = _v1 
    let v416 : Mut0 = {l0 = 1L} : Mut0
    let v417 : (string -> unit) = closure4()
    let v418 : Mut1 = {l0 = v417} : Mut1
    let v419 : Mut2 = {l0 = true} : Mut2
    let v420 : string = ""
    let v421 : Mut3 = {l0 = v420} : Mut3
    let v424 : US0 =
        match v351 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v422) -> (* Some *)
            v422
    let v425 : Mut4 = {l0 = v424} : Mut4
    let v432 : int64 option =
        match v352 with
        | US3_1 -> (* None *)
            let v430 : int64 option = None
            v430
        | US3_0(v426) -> (* Some *)
            let v427 : int64 option = Some v426 
            v427
    struct (v416, v418, v419, v421, v425, v432)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure5 () (v0 : int64) : US3 =
    US3_0(v0)
and method7 () : (int64 -> US3) =
    closure5()
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method7()
    let v8 : US3 option = v5 |> Option.map v7 
    let v19 : US3 = US3_1
    let v20 : US3 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US3_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US3_0(v24) -> (* Some *)
            let v25 : System.DateTime = System.DateTime.Now
            let v28 : (System.DateTime -> int64) = _.Ticks
            let v29 : int64 = v28 v25
            let v32 : int64 = v29 - v24
            let v33 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v34 : System.TimeSpan = v33 v32
            let v37 : (System.TimeSpan -> int32) = _.Hours
            let v38 : int32 = v37 v34
            let v41 : (System.TimeSpan -> int32) = _.Minutes
            let v42 : int32 = v41 v34
            let v45 : (System.TimeSpan -> int32) = _.Seconds
            let v46 : int32 = v45 v34
            let v49 : (System.TimeSpan -> int32) = _.Milliseconds
            let v50 : int32 = v49 v34
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v38, v42, v46, v50)
            v53
    let v61 : string = method8()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method7()
    let v69 : US3 option = v5 |> Option.map v68 
    let v80 : US3 = US3_1
    let v81 : US3 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US3_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US3_0(v85) -> (* Some *)
            let v86 : System.DateTime = System.DateTime.Now
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v86
            let v93 : int64 = v90 - v85
            let v94 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v95 : System.TimeSpan = v94 v93
            let v98 : (System.TimeSpan -> int32) = _.Hours
            let v99 : int32 = v98 v95
            let v102 : (System.TimeSpan -> int32) = _.Minutes
            let v103 : int32 = v102 v95
            let v106 : (System.TimeSpan -> int32) = _.Seconds
            let v107 : int32 = v106 v95
            let v110 : (System.TimeSpan -> int32) = _.Milliseconds
            let v111 : int32 = v110 v95
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v99, v103, v107, v111)
            v114
    let v122 : string = method8()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method7()
    let v132 : US3 option = v5 |> Option.map v131 
    let v143 : US3 = US3_1
    let v144 : US3 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US3_1 -> (* None *)
            v130
        | US3_0(v148) -> (* Some *)
            let v149 : (int64 -> uint64) = uint64
            let v150 : uint64 = v149 v148
            let v151 : uint64 = v130 - v150
            v151
    let v154 : uint64 = v153 / 1000000000UL
    let v155 : uint64 = v154 % 60UL
    let v156 : uint64 = v154 / 60UL
    let v157 : uint64 = v156 % 60UL
    let v158 : uint64 = v154 / 3600UL
    let v159 : uint64 = v158 % 24UL
    let v160 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v159, v157, v155) v160 
    let v162 : string = "fable_library_rust::String_::fromString($0)"
    let v163 : string = Fable.Core.RustInterop.emitRustExpr v161 v162 
    let _v6 = v163 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : (int64 -> US3) = method7()
    let v165 : US3 option = v5 |> Option.map v164 
    let v176 : US3 = US3_1
    let v177 : US3 = v165 |> Option.defaultValue v176 
    let v217 : System.DateTime =
        match v177 with
        | US3_1 -> (* None *)
            let v213 : System.DateTime = System.DateTime.Now
            v213
        | US3_0(v181) -> (* Some *)
            let v182 : System.DateTime = System.DateTime.Now
            let v185 : (System.DateTime -> int64) = _.Ticks
            let v186 : int64 = v185 v182
            let v189 : int64 = v186 - v181
            let v190 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v191 : System.TimeSpan = v190 v189
            let v194 : (System.TimeSpan -> int32) = _.Hours
            let v195 : int32 = v194 v191
            let v198 : (System.TimeSpan -> int32) = _.Minutes
            let v199 : int32 = v198 v191
            let v202 : (System.TimeSpan -> int32) = _.Seconds
            let v203 : int32 = v202 v191
            let v206 : (System.TimeSpan -> int32) = _.Milliseconds
            let v207 : int32 = v206 v191
            let v210 : System.DateTime = System.DateTime (1, 1, 1, v195, v199, v203, v207)
            v210
    let v218 : string = method9()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method7()
    let v226 : US3 option = v5 |> Option.map v225 
    let v237 : US3 = US3_1
    let v238 : US3 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US3_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US3_0(v242) -> (* Some *)
            let v243 : System.DateTime = System.DateTime.Now
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v243
            let v250 : int64 = v247 - v242
            let v251 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v252 : System.TimeSpan = v251 v250
            let v255 : (System.TimeSpan -> int32) = _.Hours
            let v256 : int32 = v255 v252
            let v259 : (System.TimeSpan -> int32) = _.Minutes
            let v260 : int32 = v259 v252
            let v263 : (System.TimeSpan -> int32) = _.Seconds
            let v264 : int32 = v263 v252
            let v267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v268 : int32 = v267 v252
            let v271 : System.DateTime = System.DateTime (1, 1, 1, v256, v260, v264, v268)
            v271
    let v279 : string = method9()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method7()
    let v287 : US3 option = v5 |> Option.map v286 
    let v298 : US3 = US3_1
    let v299 : US3 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US3_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US3_0(v303) -> (* Some *)
            let v304 : System.DateTime = System.DateTime.Now
            let v307 : (System.DateTime -> int64) = _.Ticks
            let v308 : int64 = v307 v304
            let v311 : int64 = v308 - v303
            let v312 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v313 : System.TimeSpan = v312 v311
            let v316 : (System.TimeSpan -> int32) = _.Hours
            let v317 : int32 = v316 v313
            let v320 : (System.TimeSpan -> int32) = _.Minutes
            let v321 : int32 = v320 v313
            let v324 : (System.TimeSpan -> int32) = _.Seconds
            let v325 : int32 = v324 v313
            let v328 : (System.TimeSpan -> int32) = _.Milliseconds
            let v329 : int32 = v328 v313
            let v332 : System.DateTime = System.DateTime (1, 1, 1, v317, v321, v325, v329)
            v332
    let v340 : string = method9()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method11 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_blue"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_blue"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_blue"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[94m"
    let v108 : string = method11()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[94m"
    let v112 : string = method11()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[94m"
    let v116 : string = method11()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
and method13 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure6(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "seed_excess"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure6(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure6(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure6(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method14 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice_contract.contribute_seed"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
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
and method15 (v0 : string, v1 : Mut0, v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure8()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v4.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v0
        else
            let v18 : bool = v0 = ""
            if v18 then
                let v19 : string = v4.l0
                v19
            else
                let v20 : string = v4.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v0 
                v23
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "&*$0"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "&*$0"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v36 
    #endif
#else
    let v39 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v39 
    #endif
    let v42 : Ref<Str> = _v26 
    let v47 : string = $"$0.chars()"
    let v48 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v42 v47 
    let v49 : string = "$0"
    let v50 : _ = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "$0.collect::<Vec<_>>()"
    let v52 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v54 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "x"
    let v58 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "String::from_iter($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "true; $0 }).collect::<Vec<_>>()"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr v60 v61 
    let v63 : string = "_vec_map"
    let v64 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "$0.len()"
    let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : (unativeint -> int32) = int32
    let v68 : int32 = v67 v66
    let v69 : string = ""
    let v70 : bool = v0 <> v69 
    let v74 : bool =
        if v70 then
            let v73 : bool = v68 <= 1
            v73
        else
            false
    if v74 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v69
        let v75 : string = "true; $0.into_iter().for_each(|x| { //"
        let v76 : bool = Fable.Core.RustInterop.emitRustExpr v64 v75 
        let v77 : string = "x"
        let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v77 
        let v79 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
        let v81 : string = $"true"
        let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
        let v83 : string = "true; }); //"
        let v84 : bool = Fable.Core.RustInterop.emitRustExpr () v83 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v0
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v0
    let _v13 = () 
    #endif
#else
    v12 v0
    let _v13 = () 
    #endif
    _v13 
    let v85 : (string -> unit) = v2.l0
    v85 v0
and closure1 (v0 : Vec<uint8>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : int64 = v56.l0
        let v77 : string = $"%A{v0}"
        let v80 : string = method12(v77)
        let v81 : string = method14(v74, v75, v76, v80)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v2 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method15(v81, v97, v98, v99, v100, v101, v102)
and closure11 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure10 () (v0 : uint8) : (UH0 -> UH0) =
    closure11(v0)
and method16 () : (uint8 -> (UH0 -> UH0)) =
    closure10()
and closure12 (v0 : UH1) () : UH1 =
    v0
and method17 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method17(v3, v1)
        let v5 : (unit -> UH1) = closure12(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure13 (v0 : UH1) () : UH1 =
    v0
and method18 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method18(v4, v1)
        let v6 : int64 = int64 v2
        let v7 : int64 = v6 - 1L
        let v8 : int64 = v7 + 6L
        let v9 : int64 = v8 % 6L
        let v10 : int64 = v9 + 1L
        let v11 : uint8 = uint8 v10
        let v12 : (unit -> UH1) = closure13(v5)
        UH1_0(v11, v12)
    | UH1_1 -> (* StreamNil *)
        v1
and method19 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method19(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method20 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method20(v3, v1)
        let v5 : uint8 list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and method21 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : string, v9 : string, v10 : unativeint, v11 : string, v12 : string, v13 : string) : string =
    let v14 : string = method13()
    let v15 : Mut3 = {l0 = v14} : Mut3
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure6(v15, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v25 : string = "max"
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure6(v15, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v34 : string = " = "
    let v35 : string = $"{v34}"
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure6(v15, v35)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v43 : string = $"{v0}"
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure6(v15, v43)
    let v48 : unit = (fun () -> v47 (); v46) ()
    let v51 : string = "; "
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure6(v15, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v60 : string = "key"
    let v61 : string = $"{v60}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure6(v15, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v69 : string = $"{v34}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure6(v15, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v78 : string = "format!(\"{:#?}\", $0)"
    let v79 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v78 
    let v80 : string = "fable_library_rust::String_::fromString($0)"
    let v81 : string = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let _v77 = v81 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v82 : string = "format!(\"{:#?}\", $0)"
    let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v82 
    let v84 : string = "fable_library_rust::String_::fromString($0)"
    let v85 : string = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let _v77 = v85 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v86 : string = "format!(\"{:#?}\", $0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v86 
    let v88 : string = "fable_library_rust::String_::fromString($0)"
    let v89 : string = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let _v77 = v89 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : string = $"%A{v1}"
    let _v77 = v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : string = $"%A{v1}"
    let _v77 = v93 
    #endif
#else
    let v96 : string = $"%A{v1}"
    let _v77 = v96 
    #endif
    let v99 : string = _v77 
    let v104 : string = $"{v99}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure6(v15, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = $"{v51}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure6(v15, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v120 : string = "proof"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure6(v15, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = $"{v34}"
    let v132 : unit = ()
    let v133 : (unit -> unit) = closure6(v15, v129)
    let v134 : unit = (fun () -> v133 (); v132) ()
    let v137 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v138 : string = "format!(\"{:#?}\", $0)"
    let v139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v138 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v139 v140 
    let _v137 = v141 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v142 : string = "format!(\"{:#?}\", $0)"
    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v142 
    let v144 : string = "fable_library_rust::String_::fromString($0)"
    let v145 : string = Fable.Core.RustInterop.emitRustExpr v143 v144 
    let _v137 = v145 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v146 : string = "format!(\"{:#?}\", $0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v146 
    let v148 : string = "fable_library_rust::String_::fromString($0)"
    let v149 : string = Fable.Core.RustInterop.emitRustExpr v147 v148 
    let _v137 = v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : string = $"%A{v2}"
    let _v137 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v153 : string = $"%A{v2}"
    let _v137 = v153 
    #endif
#else
    let v156 : string = $"%A{v2}"
    let _v137 = v156 
    #endif
    let v159 : string = _v137 
    let v164 : string = $"{v159}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure6(v15, v164)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v172 : string = $"{v51}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure6(v15, v172)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v180 : string = "block_timestamp"
    let v181 : string = $"{v180}"
    let v184 : unit = ()
    let v185 : (unit -> unit) = closure6(v15, v181)
    let v186 : unit = (fun () -> v185 (); v184) ()
    let v189 : string = $"{v34}"
    let v192 : unit = ()
    let v193 : (unit -> unit) = closure6(v15, v189)
    let v194 : unit = (fun () -> v193 (); v192) ()
    let v197 : string = $"{v3}"
    let v200 : unit = ()
    let v201 : (unit -> unit) = closure6(v15, v197)
    let v202 : unit = (fun () -> v201 (); v200) ()
    let v205 : string = $"{v51}"
    let v208 : unit = ()
    let v209 : (unit -> unit) = closure6(v15, v205)
    let v210 : unit = (fun () -> v209 (); v208) ()
    let v213 : string = "block_height"
    let v214 : string = $"{v213}"
    let v217 : unit = ()
    let v218 : (unit -> unit) = closure6(v15, v214)
    let v219 : unit = (fun () -> v218 (); v217) ()
    let v222 : string = $"{v34}"
    let v225 : unit = ()
    let v226 : (unit -> unit) = closure6(v15, v222)
    let v227 : unit = (fun () -> v226 (); v225) ()
    let v230 : string = $"{v4}"
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure6(v15, v230)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v238 : string = $"{v51}"
    let v241 : unit = ()
    let v242 : (unit -> unit) = closure6(v15, v238)
    let v243 : unit = (fun () -> v242 (); v241) ()
    let v246 : string = "epoch_height"
    let v247 : string = $"{v246}"
    let v250 : unit = ()
    let v251 : (unit -> unit) = closure6(v15, v247)
    let v252 : unit = (fun () -> v251 (); v250) ()
    let v255 : string = $"{v34}"
    let v258 : unit = ()
    let v259 : (unit -> unit) = closure6(v15, v255)
    let v260 : unit = (fun () -> v259 (); v258) ()
    let v263 : string = $"{v5}"
    let v266 : unit = ()
    let v267 : (unit -> unit) = closure6(v15, v263)
    let v268 : unit = (fun () -> v267 (); v266) ()
    let v271 : string = $"{v51}"
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure6(v15, v271)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v279 : string = "account_balance"
    let v280 : string = $"{v279}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure6(v15, v280)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v288 : string = $"{v34}"
    let v291 : unit = ()
    let v292 : (unit -> unit) = closure6(v15, v288)
    let v293 : unit = (fun () -> v292 (); v291) ()
    let v296 : string = $"{v6}"
    let v299 : unit = ()
    let v300 : (unit -> unit) = closure6(v15, v296)
    let v301 : unit = (fun () -> v300 (); v299) ()
    let v304 : string = $"{v51}"
    let v307 : unit = ()
    let v308 : (unit -> unit) = closure6(v15, v304)
    let v309 : unit = (fun () -> v308 (); v307) ()
    let v312 : string = "signer_account_id"
    let v313 : string = $"{v312}"
    let v316 : unit = ()
    let v317 : (unit -> unit) = closure6(v15, v313)
    let v318 : unit = (fun () -> v317 (); v316) ()
    let v321 : string = $"{v34}"
    let v324 : unit = ()
    let v325 : (unit -> unit) = closure6(v15, v321)
    let v326 : unit = (fun () -> v325 (); v324) ()
    let v329 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v330 : string = "format!(\"{:#?}\", $0)"
    let v331 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v330 
    let v332 : string = "fable_library_rust::String_::fromString($0)"
    let v333 : string = Fable.Core.RustInterop.emitRustExpr v331 v332 
    let _v329 = v333 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v334 : string = "format!(\"{:#?}\", $0)"
    let v335 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v334 
    let v336 : string = "fable_library_rust::String_::fromString($0)"
    let v337 : string = Fable.Core.RustInterop.emitRustExpr v335 v336 
    let _v329 = v337 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v338 : string = "format!(\"{:#?}\", $0)"
    let v339 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v338 
    let v340 : string = "fable_library_rust::String_::fromString($0)"
    let v341 : string = Fable.Core.RustInterop.emitRustExpr v339 v340 
    let _v329 = v341 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v342 : string = $"%A{v7}"
    let _v329 = v342 
    #endif
#if FABLE_COMPILER_PYTHON
    let v345 : string = $"%A{v7}"
    let _v329 = v345 
    #endif
#else
    let v348 : string = $"%A{v7}"
    let _v329 = v348 
    #endif
    let v351 : string = _v329 
    let v356 : string = $"{v351}"
    let v359 : unit = ()
    let v360 : (unit -> unit) = closure6(v15, v356)
    let v361 : unit = (fun () -> v360 (); v359) ()
    let v364 : string = $"{v51}"
    let v367 : unit = ()
    let v368 : (unit -> unit) = closure6(v15, v364)
    let v369 : unit = (fun () -> v368 (); v367) ()
    let v372 : string = "seed"
    let v373 : string = $"{v372}"
    let v376 : unit = ()
    let v377 : (unit -> unit) = closure6(v15, v373)
    let v378 : unit = (fun () -> v377 (); v376) ()
    let v381 : string = $"{v34}"
    let v384 : unit = ()
    let v385 : (unit -> unit) = closure6(v15, v381)
    let v386 : unit = (fun () -> v385 (); v384) ()
    let v389 : string = $"{v8}"
    let v392 : unit = ()
    let v393 : (unit -> unit) = closure6(v15, v389)
    let v394 : unit = (fun () -> v393 (); v392) ()
    let v397 : string = $"{v51}"
    let v400 : unit = ()
    let v401 : (unit -> unit) = closure6(v15, v397)
    let v402 : unit = (fun () -> v401 (); v400) ()
    let v405 : string = "seeds"
    let v406 : string = $"{v405}"
    let v409 : unit = ()
    let v410 : (unit -> unit) = closure6(v15, v406)
    let v411 : unit = (fun () -> v410 (); v409) ()
    let v414 : string = $"{v34}"
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure6(v15, v414)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v422 : string = $"{v9}"
    let v425 : unit = ()
    let v426 : (unit -> unit) = closure6(v15, v422)
    let v427 : unit = (fun () -> v426 (); v425) ()
    let v430 : string = $"{v51}"
    let v433 : unit = ()
    let v434 : (unit -> unit) = closure6(v15, v430)
    let v435 : unit = (fun () -> v434 (); v433) ()
    let v438 : string = "entropy_len"
    let v439 : string = $"{v438}"
    let v442 : unit = ()
    let v443 : (unit -> unit) = closure6(v15, v439)
    let v444 : unit = (fun () -> v443 (); v442) ()
    let v447 : string = $"{v34}"
    let v450 : unit = ()
    let v451 : (unit -> unit) = closure6(v15, v447)
    let v452 : unit = (fun () -> v451 (); v450) ()
    let v455 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v456 : string = "format!(\"{:#?}\", $0)"
    let v457 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v456 
    let v458 : string = "fable_library_rust::String_::fromString($0)"
    let v459 : string = Fable.Core.RustInterop.emitRustExpr v457 v458 
    let _v455 = v459 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v460 : string = "format!(\"{:#?}\", $0)"
    let v461 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v460 
    let v462 : string = "fable_library_rust::String_::fromString($0)"
    let v463 : string = Fable.Core.RustInterop.emitRustExpr v461 v462 
    let _v455 = v463 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v464 : string = "format!(\"{:#?}\", $0)"
    let v465 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v464 
    let v466 : string = "fable_library_rust::String_::fromString($0)"
    let v467 : string = Fable.Core.RustInterop.emitRustExpr v465 v466 
    let _v455 = v467 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v468 : string = $"%A{v10}"
    let _v455 = v468 
    #endif
#if FABLE_COMPILER_PYTHON
    let v471 : string = $"%A{v10}"
    let _v455 = v471 
    #endif
#else
    let v474 : string = $"%A{v10}"
    let _v455 = v474 
    #endif
    let v477 : string = _v455 
    let v482 : string = $"{v477}"
    let v485 : unit = ()
    let v486 : (unit -> unit) = closure6(v15, v482)
    let v487 : unit = (fun () -> v486 (); v485) ()
    let v490 : string = $"{v51}"
    let v493 : unit = ()
    let v494 : (unit -> unit) = closure6(v15, v490)
    let v495 : unit = (fun () -> v494 (); v493) ()
    let v498 : string = "entropy"
    let v499 : string = $"{v498}"
    let v502 : unit = ()
    let v503 : (unit -> unit) = closure6(v15, v499)
    let v504 : unit = (fun () -> v503 (); v502) ()
    let v507 : string = $"{v34}"
    let v510 : unit = ()
    let v511 : (unit -> unit) = closure6(v15, v507)
    let v512 : unit = (fun () -> v511 (); v510) ()
    let v515 : string = $"{v11}"
    let v518 : unit = ()
    let v519 : (unit -> unit) = closure6(v15, v515)
    let v520 : unit = (fun () -> v519 (); v518) ()
    let v523 : string = $"{v51}"
    let v526 : unit = ()
    let v527 : (unit -> unit) = closure6(v15, v523)
    let v528 : unit = (fun () -> v527 (); v526) ()
    let v531 : string = "hash_u8"
    let v532 : string = $"{v531}"
    let v535 : unit = ()
    let v536 : (unit -> unit) = closure6(v15, v532)
    let v537 : unit = (fun () -> v536 (); v535) ()
    let v540 : string = $"{v34}"
    let v543 : unit = ()
    let v544 : (unit -> unit) = closure6(v15, v540)
    let v545 : unit = (fun () -> v544 (); v543) ()
    let v548 : string = $"{v12}"
    let v551 : unit = ()
    let v552 : (unit -> unit) = closure6(v15, v548)
    let v553 : unit = (fun () -> v552 (); v551) ()
    let v556 : string = $"{v51}"
    let v559 : unit = ()
    let v560 : (unit -> unit) = closure6(v15, v556)
    let v561 : unit = (fun () -> v560 (); v559) ()
    let v564 : string = "rolls"
    let v565 : string = $"{v564}"
    let v568 : unit = ()
    let v569 : (unit -> unit) = closure6(v15, v565)
    let v570 : unit = (fun () -> v569 (); v568) ()
    let v573 : string = $"{v34}"
    let v576 : unit = ()
    let v577 : (unit -> unit) = closure6(v15, v573)
    let v578 : unit = (fun () -> v577 (); v576) ()
    let v581 : string = $"{v13}"
    let v584 : unit = ()
    let v585 : (unit -> unit) = closure6(v15, v581)
    let v586 : unit = (fun () -> v585 (); v584) ()
    let v589 : string = " }"
    let v590 : string = $"{v589}"
    let v593 : unit = ()
    let v594 : (unit -> unit) = closure6(v15, v590)
    let v595 : unit = (fun () -> v594 (); v593) ()
    let v598 : string = v15.l0
    v598
and method22 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice_contract.generate_random_number"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure14 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : Vec<uint8>, v11 : Vec<uint8>, v12 : UH0) () : unit =
    let v13 : unit = ()
    let v14 : (unit -> unit) = closure2()
    let v15 : unit = (fun () -> v14 (); v13) ()
    let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
    let v47 : US0 = v33.l0
    let v48 : bool = v31.l0
    let v49 : bool = v48 = false
    let v52 : bool =
        if v49 then
            false
        else
            let v50 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v47
            let v51 : bool = 1 >= v50
            v51
    if v52 then
        let v53 : unit = ()
        let v54 : unit = (fun () -> v14 (); v53) ()
        let struct (v68 : Mut0, v69 : Mut1, v70 : Mut2, v71 : Mut3, v72 : Mut4, v73 : int64 option) = TraceState.trace_state.Value
        let v86 : string = method6(v68, v69, v70, v71, v72, v73)
        let v87 : string = method10()
        let v88 : int64 = v68.l0
        let v89 : string = $"%A{v8}"
        let v92 : string = $"v9.to_string()"
        let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v92 
        let v94 : string = $"%A{v4}"
        let v97 : string = $"%A{v0}"
        let v100 : string = "$0.len()"
        let v101 : unativeint = Fable.Core.RustInterop.emitRustExpr v10 v100 
        let v102 : string = $"%A{v10}"
        let v105 : string = $"%A{v11}"
        let v108 : uint8 list = []
        let v109 : uint8 list = method20(v12, v108)
        let v110 : (uint8 list -> (uint8 [])) = List.toArray
        let v111 : (uint8 []) = v110 v109
        let v114 : string = "$0.to_vec()"
        let v115 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v111 v114 
        let v116 : string = $"%A{v115}"
        let v119 : string = method21(v3, v1, v2, v7, v6, v5, v89, v93, v94, v97, v101, v102, v105, v116)
        let v120 : string = method22(v86, v87, v88, v119)
        let v121 : unit = ()
        let v122 : unit = (fun () -> v14 (); v121) ()
        let struct (v136 : Mut0, v137 : Mut1, v138 : Mut2, v139 : Mut3, v140 : Mut4, v141 : int64 option) = TraceState.trace_state.Value
        method15(v120, v136, v137, v138, v139, v140, v141)
and method23 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method23(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method24 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method24(v3, v1)
        UH0_1(v2, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure15 (v0 : UH1) () : UH1 =
    v0
and closure16 (v0 : UH1, v1 : Mut5) () : UH1 =
    let v2 : US4 = v1.l0
    match v2 with
    | US4_1(v3) -> (* Computed *)
        v3
    | US4_0(v4) -> (* NotComputed *)
        let v5 : UH1 = v4 ()
        let v12 : UH1 =
            match v5 with
            | UH1_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH1) = method25(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US4 = US4_1(v12)
        v1.l0 <- v13
        v12
and method25 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US4 = US4_0(v1)
    let v3 : Mut5 = {l0 = v2} : Mut5
    closure16(v0, v3)
and method27 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "p"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "n"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method28 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice.calculate_dice_count"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure17 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method6(v58, v59, v60, v61, v62, v63)
        let v77 : string = method10()
        let v78 : int64 = v58.l0
        let v79 : string = method27(v0, v2, v1)
        let v80 : string = method28(v76, v77, v78, v79)
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        method15(v80, v96, v97, v98, v99, v100, v101)
and method26 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method26(v0, v6, v4)
        else
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure17(v0, v1, v2)
            let v10 : unit = (fun () -> v9 (); v8) ()
            v1
    else
        let v123 : unit = ()
        let v124 : (unit -> unit) = closure17(v0, v1, v2)
        let v125 : unit = (fun () -> v124 (); v123) ()
        v1
and method31 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "current_index"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure6(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure6(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure6(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure6(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure6(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "len"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure6(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure6(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure6(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "last_item"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure6(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure6(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method32 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice.create_sequential_roller / roll"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure18 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure2()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
    let v38 : US0 = v24.l0
    let v39 : bool = v22.l0
    let v40 : bool = v39 = false
    let v43 : bool =
        if v40 then
            false
        else
            let v41 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v38
            let v42 : bool = 1 >= v41
            v42
    if v43 then
        let v44 : unit = ()
        let v45 : unit = (fun () -> v5 (); v44) ()
        let struct (v59 : Mut0, v60 : Mut1, v61 : Mut2, v62 : Mut3, v63 : Mut4, v64 : int64 option) = TraceState.trace_state.Value
        let v77 : string = method6(v59, v60, v61, v62, v63, v64)
        let v78 : string = method10()
        let v79 : int64 = v59.l0
        let v80 : string = $"%A{v3}"
        let v83 : string = method31(v0, v1, v2, v80)
        let v84 : string = method32(v77, v78, v79, v83)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v5 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method15(v84, v100, v101, v102, v103, v104, v105)
and method33 (v0 : int64, v1 : UH1) : US5 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US5_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method33(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US5_1
and method34 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method35 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice.create_sequential_roller / roll / None"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure19 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure2()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 1 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method6(v55, v56, v57, v58, v59, v60)
        let v74 : string = method10()
        let v75 : int64 = v55.l0
        let v76 : string = method34()
        let v77 : string = method35(v73, v74, v75, v76)
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        method15(v77, v93, v94, v95, v96, v97, v98)
and method30 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US5 = v4.l0
    let v15 : uint8 option =
        match v8 with
        | US5_1 -> (* None *)
            let v13 : uint8 option = None
            v13
        | US5_0(v9) -> (* Some *)
            let v10 : uint8 option = Some v9 
            v10
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure18(v5, v6, v7, v15)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v133 : UH1 = v0 ()
    let v134 : int64 = v1.l0
    let v135 : US5 = method33(v134, v133)
    match v135 with
    | US5_1 -> (* None *)
        let v140 : unit = ()
        let v141 : (unit -> unit) = closure19()
        let v142 : unit = (fun () -> v141 (); v140) ()
        let v254 : int64 = v3.l0
        let v255 : bool = v254 = -1L
        if v255 then
            let v256 : int64 = v1.l0
            v3.l0 <- v256
            ()
        let v257 : int64 = v2.l0
        let v258 : int64 = v3.l0
        let v259 : bool = v257 >= v258
        let v262 : int64 =
            if v259 then
                1L
            else
                let v260 : int64 = v2.l0
                let v261 : int64 = v260 + 1L
                v261
        v2.l0 <- v262
        let v263 : int64 = v2.l0
        let v264 : int64 = v263 - 1L
        v1.l0 <- v264
        let v265 : US5 = US5_1
        v4.l0 <- v265
        method30(v0, v1, v2, v3, v4)
    | US5_0(v136) -> (* Some *)
        let v137 : int64 = v1.l0
        let v138 : int64 = v137 + 1L
        v1.l0 <- v138
        let v139 : US5 = US5_0(v136)
        v4.l0 <- v139
        v136
and method37 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method38 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice.accumulate_dice_rolls"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure20 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method6(v58, v59, v60, v61, v62, v63)
        let v77 : string = method10()
        let v78 : int64 = v58.l0
        let v79 : string = method37(v1, v0, v2)
        let v80 : string = method38(v76, v77, v78, v79)
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        method15(v80, v96, v97, v98, v99, v100, v101)
and closure84 () () : UH2 =
    UH2_1
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(9223372036854775808UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(4611686018427387904UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(6917529027641081856UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(1152921504606846976UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(15564440312192434176UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(11817445422220181504UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(5044031582654955520UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(6989586621679009792UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(16537217831704461312UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(11979575008805519360UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(14294425217273954304UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(2382404202878992384UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(6545982058383015936UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(10314369046585278464UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(4793518853382471680UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(3873377154515337216UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(645562859085889536UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(107593809847648256UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(3092389647259533312UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(9738770311398031360UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(16995415113324298240UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(8981483876790566912UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(13794743361938128896UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(2299123893656354816UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(3457644661227651072UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(576274110204608512UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(6244960376270618624UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(13338656111851470848UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(14520938734448279552UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(14717985838214414336UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(5527454985320660992UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(16293529225644736512UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(11938960241128898560UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(8138741398091333632UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(7505371590918406144UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(16623181993244360704UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(8919445023443910656UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(4561031516192243712UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(9983543956220149760UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(4738381338321616896UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(789730223053602816UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(131621703842267136UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(21936950640377856UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(3656158440062976UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(609359740010496UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(101559956668416UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(16926659444736UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(2821109907456UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(470184984576UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(78364164096UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(13060694016UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(2176782336UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(362797056UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(60466176UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(10077696UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(1679616UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(279936UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(46656UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(7776UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(1296UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(216UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_0(36UL, v0)
and closure21 () () : UH2 =
    let v0 : (unit -> UH2) = closure22()
    UH2_0(6UL, v0)
and method39 (v0 : int8, v1 : UH2) : US7 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US7_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method39(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US7_1
and method40 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure6(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "power"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure6(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure6(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure6(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure6(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure6(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure6(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure6(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "roll"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure6(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure6(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure6(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "value"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure6(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure6(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure6(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure6(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and closure85 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure2()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
    let v38 : US0 = v24.l0
    let v39 : bool = v22.l0
    let v40 : bool = v39 = false
    let v43 : bool =
        if v40 then
            false
        else
            let v41 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v38
            let v42 : bool = 1 >= v41
            v42
    if v43 then
        let v44 : unit = ()
        let v45 : unit = (fun () -> v5 (); v44) ()
        let struct (v59 : Mut0, v60 : Mut1, v61 : Mut2, v62 : Mut3, v63 : Mut4, v64 : int64 option) = TraceState.trace_state.Value
        let v77 : string = method6(v59, v60, v61, v62, v63, v64)
        let v78 : string = method10()
        let v79 : int64 = v59.l0
        let v80 : string = method40(v1, v0, v2, v3)
        let v81 : string = method38(v77, v78, v79, v80)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v5 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method15(v81, v97, v98, v99, v100, v101, v102)
and method41 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "roll"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure86 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method6(v58, v59, v60, v61, v62, v63)
        let v77 : string = method10()
        let v78 : int64 = v58.l0
        let v79 : string = method41(v1, v0, v2)
        let v80 : string = method38(v76, v77, v78, v79)
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        method15(v80, v96, v97, v98, v99, v100, v101)
and method36 (v0 : int8, v1 : UH0, v2 : uint64) : US6 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure20(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US6_0(v4, v1)
    else
        match v1 with
        | UH0_1(v121, v122) -> (* Cons *)
            let v123 : bool = v121 > 1uy
            if v123 then
                let v124 : uint64 = 1UL
                let v125 : (unit -> UH2) = closure21()
                let v126 : UH2 = UH2_0(v124, v125)
                let v127 : US7 = method39(v0, v126)
                let v131 : uint64 =
                    match v127 with
                    | US7_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US7_0(v128) -> (* Some *)
                        v128
                let v132 : uint8 = v121 - 1uy
                let v133 : uint64 = uint64 v132
                let v134 : uint64 = v133 * v131
                let v135 : unit = ()
                let v136 : (unit -> unit) = closure85(v2, v0, v121, v134)
                let v137 : unit = (fun () -> v136 (); v135) ()
                let v249 : uint64 = v2 + v134
                let v250 : int8 = v0 - 1y
                method36(v250, v122, v249)
            else
                let v252 : unit = ()
                let v253 : (unit -> unit) = closure86(v2, v0, v121)
                let v254 : unit = (fun () -> v253 (); v252) ()
                let v366 : int8 = v0 - 1y
                method36(v366, v122, v2)
        | UH0_0 -> (* Nil *)
            US6_1
and method42 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut6, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method30(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method42(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method43 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method30(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method29(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US6 = method36(v6, v7, v13)
        match v14 with
        | US6_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method42(v6, v0, v1, v2, v3, v4, v18)
                method43(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method42(v6, v0, v1, v2, v3, v4, v22)
            method43(v0, v1, v2, v3, v4, v5, v6, v23)
and method29 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method30(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method29(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US6 = method36(v6, v7, v15)
        match v16 with
        | US6_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method42(v6, v0, v1, v2, v3, v4, v20)
                method43(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method42(v6, v0, v1, v2, v3, v4, v24)
            method43(v0, v1, v2, v3, v4, v5, v6, v25)
and closure87 () () : unit =
    ()
and method44 () : (unit -> unit) =
    closure87()
and method45 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : unit =
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure7(v0)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = ""
    let v12 : (string -> unit) = closure8()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v11 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v11 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v3.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v11
        else
            let v18 : bool = v11 = ""
            if v18 then
                let v19 : string = v3.l0
                v19
            else
                let v20 : string = v3.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v11 
                v23
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "&*$0"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "&*$0"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v36 
    #endif
#else
    let v39 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v39 
    #endif
    let v42 : Ref<Str> = _v26 
    let v47 : string = $"$0.chars()"
    let v48 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v42 v47 
    let v49 : string = "$0"
    let v50 : _ = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "$0.collect::<Vec<_>>()"
    let v52 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v54 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "x"
    let v58 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "String::from_iter($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "true; $0 }).collect::<Vec<_>>()"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr v60 v61 
    let v63 : string = "_vec_map"
    let v64 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "$0.len()"
    let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : (unativeint -> int32) = int32
    let v68 : int32 = v67 v66
    let v69 : bool = v11 <> v11 
    let v73 : bool =
        if v69 then
            let v72 : bool = v68 <= 1
            v72
        else
            false
    if v73 then
        v3.l0 <- v25
        ()
    else
        v3.l0 <- v11
        let v74 : string = "true; $0.into_iter().for_each(|x| { //"
        let v75 : bool = Fable.Core.RustInterop.emitRustExpr v64 v74 
        let v76 : string = "x"
        let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v76 
        let v78 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
        let v80 : string = $"true"
        let v81 : bool = Fable.Core.RustInterop.emitRustExpr () v80 
        let v82 : string = "true; }); //"
        let v83 : bool = Fable.Core.RustInterop.emitRustExpr () v82 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v11
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v11
    let _v13 = () 
    #endif
#else
    v12 v11
    let _v13 = () 
    #endif
    _v13 
    let v84 : (string -> unit) = v1.l0
    v84 v11
and closure88 (v0 : (unit -> unit)) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : unit = ()
        let v77 : unit = (fun () -> v2 (); v76) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
        method45(v91, v92, v93, v94, v95, v96)
and method46 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method46(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method47 (v0 : uint64, v1 : string, v2 : string) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "rolls"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method48 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "dice_contract.roll_within_bounds"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure89 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method6(v58, v59, v60, v61, v62, v63)
        let v77 : string = method10()
        let v78 : int64 = v58.l0
        let v79 : string = $"%A{v1}"
        let v82 : string = $"%A{v2}"
        let v85 : string = method47(v0, v79, v82)
        let v86 : string = method48(v76, v77, v78, v85)
        let v87 : unit = ()
        let v88 : unit = (fun () -> v4 (); v87) ()
        let struct (v102 : Mut0, v103 : Mut1, v104 : Mut2, v105 : Mut3, v106 : Mut4, v107 : int64 option) = TraceState.trace_state.Value
        method15(v86, v102, v103, v104, v105, v106, v107)
and method49 () : (unit -> unit) =
    closure87()
and closure90 (v0 : (unit -> unit)) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : unit = ()
        let v77 : unit = (fun () -> v2 (); v76) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
        method45(v91, v92, v93, v94, v95, v96)
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
    let v18 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v21 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "        Self((old_state.version + 1, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "true; /*"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v36 : string = "true; */"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "seeds"
    let v39 : string = "b\"" + v38 + "\""
    let v40 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : string = "near_sdk::store::vec::Vector::new($0)"
    let v42 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _result = struct (2u, v42) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v43 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v47 : bool = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = $"&mut self.0.1"
    let v54 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : string = $"seed"
    let v56 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = "true; v54.extend($0); //"
    let v58 : bool = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let v59 : string = $"v54.len()"
    let v60 : uint32 = Fable.Core.RustInterop.emitRustExpr () v59 
    let v61 : (uint32 -> int32) = int32
    let v62 : int32 = v61 v60
    let v63 : unativeint = 100 |> unativeint 
    let v66 : (unativeint -> int32) = int32
    let v67 : int32 = v66 v63
    let v68 : int32 = v62 - v67
    let v69 : bool = v68 > 0
    if v69 then
        let v70 : string = "v54.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v71 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v68 v70 
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure1(v71)
        let v74 : unit = (fun () -> v73 (); v72) ()
        ()
    let v189 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v189 
    let v190 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v190 
    let v191 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v191 
    let v192 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 2uy"
    let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 2uy"
    let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v196 
    let v197 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v197 
    let v198 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v198 
    let v199 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v199 
    let v200 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v200 
    let v201 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v201 
    let v202 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 4uy / n: 1uy"
    let v203 : bool = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 4uy / n: 1uy"
    let v205 : bool = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v206 
    let v207 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v207 
    let v208 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v208 
    let v209 : string = $"key"
    let v210 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v209 
    let v211 : string = $"proof"
    let v212 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v211 
    let v213 : string = $"max"
    let v214 : uint64 = Fable.Core.RustInterop.emitRustExpr () v213 
    let v215 : string = $"&mut self.0.1"
    let v216 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v215 
    let v217 : string = $"near_sdk::env::random_seed()"
    let v218 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v217 
    let v219 : string = $"near_sdk::env::epoch_height()"
    let v220 : uint64 = Fable.Core.RustInterop.emitRustExpr () v219 
    let v221 : string = $"near_sdk::env::block_height()"
    let v222 : uint64 = Fable.Core.RustInterop.emitRustExpr () v221 
    let v223 : string = $"near_sdk::env::block_timestamp()"
    let v224 : uint64 = Fable.Core.RustInterop.emitRustExpr () v223 
    let v225 : string = $"near_sdk::env::account_balance()"
    let v226 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v225 
    let v227 : string = $"near_sdk::env::signer_account_id()"
    let v228 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v227 
    let v229 : string = $"&*v216"
    let v230 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v229 
    let v231 : string = $"v230.iter().map(|x| *x).collect::<Vec<_>>()"
    let v232 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v231 
    let v233 : string = $"v220.to_le_bytes()"
    let v234 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v233 
    let v235 : string = $"v234.to_vec()"
    let v236 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v235 
    let v237 : string = $"v222.to_le_bytes()"
    let v238 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v237 
    let v239 : string = $"v238.to_vec()"
    let v240 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v239 
    let v241 : string = $"v224.to_le_bytes()"
    let v242 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : string = $"v242.to_vec()"
    let v244 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v243 
    let v245 : string = "$0.as_yoctonear()"
    let v246 : u128 = Fable.Core.RustInterop.emitRustExpr v226 v245 
    let v247 : string = $"v246.to_le_bytes()"
    let v248 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v247 
    let v249 : string = $"v248.to_vec()"
    let v250 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v249 
    let v251 : string = $"v228.as_bytes()"
    let v252 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v251 
    let v253 : string = $"v252.to_vec()"
    let v254 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v253 
    let v255 : string = $"$0.into_bytes()"
    let v256 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v212 v255 
    let v257 : string = $"$0.into_bytes()"
    let v258 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v210 v257 
    let v259 : (Vec<uint8> []) = [|v218; v232; v236; v240; v244; v250; v254; v256; v258|]
    let v260 : string = "$0.to_vec()"
    let v261 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v259 v260 
    let v262 : string = $"v261.concat()"
    let v263 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v262 
    let v264 : string = $"near_sdk::env::keccak512(&$0)"
    let v265 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v263 v264 
    let v266 : string = "true; v216.extend($0); //"
    let v267 : bool = Fable.Core.RustInterop.emitRustExpr v265 v266 
    let v268 : string = $"v216.len()"
    let v269 : uint32 = Fable.Core.RustInterop.emitRustExpr () v268 
    let v270 : (uint32 -> int32) = int32
    let v271 : int32 = v270 v269
    let v272 : unativeint = 100 |> unativeint 
    let v275 : (unativeint -> int32) = int32
    let v276 : int32 = v275 v272
    let v277 : int32 = v271 - v276
    let v278 : bool = v277 > 0
    if v278 then
        let v279 : string = "v216.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v280 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v277 v279 
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure1(v280)
        let v283 : unit = (fun () -> v282 (); v281) ()
        ()
    let v398 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v399 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v265 v398 
    let v400 : uint8 list = v399 |> Array.toList
    let v401 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v402 : (uint8 -> (UH0 -> UH0)) = method16()
    let v403 : (uint8 list -> (UH0 -> UH0)) = v401 v402
    let v404 : (UH0 -> UH0) = v403 v400
    let v405 : UH0 = UH0_0
    let v406 : UH0 = v404 v405
    let v411 : UH1 = UH1_1
    let v412 : UH1 = method17(v406, v411)
    let v413 : UH1 = UH1_1
    let v414 : UH1 = method18(v412, v413)
    let v415 : UH0 = UH0_0
    let v416 : UH0 = method19(v414, v415)
    let v417 : unit = ()
    let v418 : (unit -> unit) = closure14(v216, v210, v212, v214, v218, v220, v222, v224, v226, v228, v263, v265, v416)
    let v419 : unit = (fun () -> v418 (); v417) ()
    let v561 : UH0 = UH0_0
    let v562 : UH0 = method23(v416, v561)
    let v563 : UH0 = method24(v416, v562)
    let v564 : UH1 = UH1_1
    let v565 : UH1 = method17(v563, v564)
    let v566 : (unit -> UH1) = closure15(v565)
    let v567 : (unit -> UH1) = method25(v565, v566)
    let v568 : Mut0 = {l0 = 0L} : Mut0
    let v569 : Mut0 = {l0 = 1L} : Mut0
    let v570 : Mut0 = {l0 = -1L} : Mut0
    let v571 : US5 = US5_1
    let v572 : Mut6 = {l0 = v571} : Mut6
    let v573 : bool = v214 = 1UL
    let v577 : int8 =
        if v573 then
            1y
        else
            let v574 : int8 = 0y
            let v575 : uint64 = 1UL
            method26(v214, v574, v575)
    let v578 : int8 = v577 - 1y
    let v579 : UH0 = UH0_0
    let v580 : int8 = 0y
    let v581 : uint64 = method29(v567, v568, v569, v570, v572, v214, v578, v579, v580)
    let v582 : (unit -> unit) = method44()
    let v583 : unit = ()
    let v584 : (unit -> unit) = closure88(v582)
    let v585 : unit = (fun () -> v584 (); v583) ()
    let v694 : string = "v581 //"
    Fable.Core.RustInterop.emitRustExpr () v694 
    let v695 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v695 
    let v696 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v696 
    let v697 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v697 
    let v698 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v698 
    let v699 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 3uy"
    let v700 : bool = Fable.Core.RustInterop.emitRustExpr () v699 
    let v701 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 3uy"
    let v702 : bool = Fable.Core.RustInterop.emitRustExpr () v701 
    let v703 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v703 
    let v704 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v704 
    let v705 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v705 
    let v706 : string = $"max"
    let v707 : uint64 = Fable.Core.RustInterop.emitRustExpr () v706 
    let v708 : string = $"rolls"
    let v709 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v708 
    let v710 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v711 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v709 v710 
    let v712 : uint8 list = v711 |> Array.toList
    let v713 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v714 : (uint8 -> (UH0 -> UH0)) = method16()
    let v715 : (uint8 list -> (UH0 -> UH0)) = v713 v714
    let v716 : (UH0 -> UH0) = v715 v712
    let v717 : UH0 = UH0_0
    let v718 : UH0 = v716 v717
    let v723 : int8 = 0y
    let v724 : int8 = method46(v718, v723)
    let v725 : int8 = v724 - 1y
    let v726 : uint64 = 0UL
    let v727 : US6 = method36(v725, v718, v726)
    let v737 : US7 =
        match v727 with
        | US6_0(v728, v729) -> (* Some *)
            let v730 : bool = v728 >= 1UL
            let v732 : bool =
                if v730 then
                    let v731 : bool = v728 <= v707
                    v731
                else
                    false
            if v732 then
                US7_0(v728)
            else
                US7_1
        | _ ->
            US7_1
    let v744 : uint64 option =
        match v737 with
        | US7_1 -> (* None *)
            let v742 : uint64 option = None
            v742
        | US7_0(v738) -> (* Some *)
            let v739 : uint64 option = Some v738 
            v739
    let v745 : unit = ()
    let v746 : (unit -> unit) = closure89(v707, v709, v744)
    let v747 : unit = (fun () -> v746 (); v745) ()
    let v865 : (unit -> unit) = method49()
    let v866 : unit = ()
    let v867 : (unit -> unit) = closure90(v865)
    let v868 : unit = (fun () -> v867 (); v866) ()
    let v977 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v744 v977 
    let v978 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v978 
    let v979 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v979 
    let v980 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v980 
    let v981 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 8uy / n: 2uy"
    let v982 : bool = Fable.Core.RustInterop.emitRustExpr () v981 
    let v983 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 8uy / n: 2uy"
    let v984 : bool = Fable.Core.RustInterop.emitRustExpr () v983 
    let v985 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v985 
    let v986 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v986 
    let v987 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v987 
    let v988 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v988 
    let v989 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v989 
    let v990 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v990 
    let v991 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v991 
    let v992 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v992 
    let v993 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v993 
    let v994 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v994 
    let v995 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v995 
    let v996 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 10uy / n: 1uy"
    let v997 : bool = Fable.Core.RustInterop.emitRustExpr () v996 
    let v998 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 10uy / n: 1uy"
    let v999 : bool = Fable.Core.RustInterop.emitRustExpr () v998 
    let v1000 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v1000 
    let v1001 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v1001 
    let v1002 : string = "true; { (); // ?? / i': 1uy / n: 11uy"
    let v1003 : bool = Fable.Core.RustInterop.emitRustExpr () v1002 
    let v1004 : string = "true; { (); // ?? / i': 2uy / n: 11uy"
    let v1005 : bool = Fable.Core.RustInterop.emitRustExpr () v1004 
    let v1006 : string = "true; { (); // ?? / i': 3uy / n: 11uy"
    let v1007 : bool = Fable.Core.RustInterop.emitRustExpr () v1006 
    let v1008 : string = "true; { (); // ?? / i': 4uy / n: 11uy"
    let v1009 : bool = Fable.Core.RustInterop.emitRustExpr () v1008 
    let v1010 : string = "true; { (); // ?? / i': 5uy / n: 11uy"
    let v1011 : bool = Fable.Core.RustInterop.emitRustExpr () v1010 
    let v1012 : string = "true; { (); // ?? / i': 6uy / n: 11uy"
    let v1013 : bool = Fable.Core.RustInterop.emitRustExpr () v1012 
    let v1014 : string = "true; { (); // ?? / i': 7uy / n: 11uy"
    let v1015 : bool = Fable.Core.RustInterop.emitRustExpr () v1014 
    let v1016 : string = "true; { (); // ?? / i': 8uy / n: 11uy"
    let v1017 : bool = Fable.Core.RustInterop.emitRustExpr () v1016 
    let v1018 : string = "true; { (); // ?? / i': 9uy / n: 11uy"
    let v1019 : bool = Fable.Core.RustInterop.emitRustExpr () v1018 
    let v1020 : string = "true; { (); // ?? / i': 10uy / n: 11uy"
    let v1021 : bool = Fable.Core.RustInterop.emitRustExpr () v1020 
    let v1022 : string = "true; { (); // ?? / i': 11uy / n: 11uy"
    let v1023 : bool = Fable.Core.RustInterop.emitRustExpr () v1022 
    let v1024 : string = "true; { { (); // ? / i': 12uy / n: 11uy"
    let v1025 : bool = Fable.Core.RustInterop.emitRustExpr () v1024 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
