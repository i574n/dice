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
let rec method2 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US1 =
    US1_0(v0)
and method5 () : (string -> US1) =
    closure3()
and method3 (v0 : string) : string =
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
    let v14 : string = method4()
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
    let v29 : string = method4()
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
    let v44 : string = method4()
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
    let v64 : (string -> US1) = method5()
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
    let v92 : (string -> US1) = method5()
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
and method6 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure4 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method2()
    let v3 : string = method3(v2)
    
    
    
    
    
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
    let v50 : string = method6()
    let v51 : string = method3(v50)
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
    let v168 : string = method2()
    let v169 : string = method3(v168)
    
    
    
    
    
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
    let v216 : string = method6()
    let v217 : string = method3(v216)
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
    let v229 : string = method2()
    let v230 : string = method3(v229)
    
    
    
    
    
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
    let v277 : string = method6()
    let v278 : string = method3(v277)
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
    let v290 : string = method2()
    let v291 : string = method3(v290)
    
    
    
    
    
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
    let v338 : string = method6()
    let v339 : string = method3(v338)
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
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method0 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
and closure5 () (v0 : int64) : US3 =
    US3_0(v0)
and method8 () : (int64 -> US3) =
    closure5()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method8()
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
    let v61 : string = method9()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method8()
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
    let v122 : string = method9()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method8()
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
    let v164 : (int64 -> US3) = method8()
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
    let v218 : string = method10()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method8()
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
    let v279 : string = method10()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method8()
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
    let v340 : string = method10()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method13 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure6(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_bright_blue"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_bright_blue"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[94m"
    let v96 : string = method14()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[94m"
    let v100 : string = method14()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[94m"
    let v104 : string = method14()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method16 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "seed_excess_len"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "seed_excess"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method17 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v24 : char list = []
    let v25 : char list = '/' :: v24 
    let v28 : char list = ' ' :: v25 
    let v31 : (char list -> (char [])) = List.toArray
    let v32 : (char []) = v31 v28
    let v35 : string = v6.TrimEnd v32 
    v35
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method16(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "dice_contract.contribute_seed"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
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
and method18 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure7(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure8()
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
#else
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
    let v70 : Ref<Str> = _v54 
    let v75 : string = $"$0.chars()"
    let v76 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v70 v75 
    let v77 : string = "$0"
    let v78 : _ = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "$0.collect::<Vec<_>>()"
    let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v82 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "x"
    let v86 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v85 
    let v87 : string = "String::from_iter($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : string = "true; $0 }).collect::<Vec<_>>()"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "_vec_map"
    let v92 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "$0.len()"
    let v94 : unativeint = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : (unativeint -> int32) = int32
    let v96 : int32 = v95 v94
    let v97 : string = ""
    let v98 : bool = v0 <> v97 
    let v102 : bool =
        if v98 then
            let v101 : bool = v96 <= 1
            v101
        else
            false
    if v102 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v97
        let v103 : string = "true; $0.into_iter().for_each(|x| { //"
        let v104 : bool = Fable.Core.RustInterop.emitRustExpr v92 v103 
        let v105 : string = "x"
        let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v105 
        let v107 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
        let v109 : string = $"true"
        let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
        let v111 : string = "true; }); //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
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
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v113 : (string -> unit) = v18.l0
    v113 v0
and closure1 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure2()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = $"%A{v1}"
        let v43 : string = method15(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method18(v43)
and closure10 () () : unit =
    ()
and method19 () : (unit -> unit) =
    closure10()
and method20 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure2()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure7(v16)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = ""
    let v40 : (string -> unit) = closure8()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v42 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v43 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v19.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v39
        else
            let v46 : bool = v39 = ""
            if v46 then
                let v47 : string = v19.l0
                v47
            else
                let v48 : string = v19.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v39 
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
#else
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
    let v70 : Ref<Str> = _v54 
    let v75 : string = $"$0.chars()"
    let v76 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v70 v75 
    let v77 : string = "$0"
    let v78 : _ = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "$0.collect::<Vec<_>>()"
    let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v82 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "x"
    let v86 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v85 
    let v87 : string = "String::from_iter($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : string = "true; $0 }).collect::<Vec<_>>()"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "_vec_map"
    let v92 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "$0.len()"
    let v94 : unativeint = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : (unativeint -> int32) = int32
    let v96 : int32 = v95 v94
    let v97 : bool = v39 <> v39 
    let v101 : bool =
        if v97 then
            let v100 : bool = v96 <= 1
            v100
        else
            false
    if v101 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v39
        let v102 : string = "true; $0.into_iter().for_each(|x| { //"
        let v103 : bool = Fable.Core.RustInterop.emitRustExpr v92 v102 
        let v104 : string = "x"
        let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v104 
        let v106 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v107 : bool = Fable.Core.RustInterop.emitRustExpr v105 v106 
        let v108 : string = $"true"
        let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108 
        let v110 : string = "true; }); //"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr () v110 
        ()
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v39
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v39
    let _v41 = () 
    #endif
#else
    v40 v39
    let _v41 = () 
    #endif
    _v41 
    let v112 : (string -> unit) = v17.l0
    v112 v39
and closure11 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method20()
and closure13 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure12 () (v0 : uint8) : (UH0 -> UH0) =
    closure13(v0)
and method21 () : (uint8 -> (UH0 -> UH0)) =
    closure12()
and closure14 (v0 : UH1) () : UH1 =
    v0
and method22 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method22(v3, v1)
        let v5 : (unit -> UH1) = closure14(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure15 (v0 : UH1) () : UH1 =
    v0
and method23 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method23(v4, v1)
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
and method24 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method24(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method25 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method25(v3, v1)
        let v5 : uint8 list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and method27 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : std_string_String, v9 : string, v10 : string, v11 : unativeint, v12 : string, v13 : string, v14 : string) : string =
    let v15 : string = method13()
    let v16 : Mut3 = {l0 = v15} : Mut3
    let v17 : string = "{ "
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure6(v16, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v26 : string = "max"
    let v27 : string = $"{v26}"
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure6(v16, v27)
    let v32 : unit = (fun () -> v31 (); v30) ()
    let v35 : string = " = "
    let v36 : string = $"{v35}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure6(v16, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v44 : string = $"{v0}"
    let v47 : unit = ()
    let v48 : (unit -> unit) = closure6(v16, v44)
    let v49 : unit = (fun () -> v48 (); v47) ()
    let v52 : string = "; "
    let v53 : string = $"{v52}"
    let v56 : unit = ()
    let v57 : (unit -> unit) = closure6(v16, v53)
    let v58 : unit = (fun () -> v57 (); v56) ()
    let v61 : string = "key"
    let v62 : string = $"{v61}"
    let v65 : unit = ()
    let v66 : (unit -> unit) = closure6(v16, v62)
    let v67 : unit = (fun () -> v66 (); v65) ()
    let v70 : string = $"{v35}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure6(v16, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v78 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v79 : string = "format!(\"{:#?}\", $0)"
    let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v79 
    let v81 : string = "fable_library_rust::String_::fromString($0)"
    let v82 : string = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let _v78 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "format!(\"{:#?}\", $0)"
    let v84 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v83 
    let v85 : string = "fable_library_rust::String_::fromString($0)"
    let v86 : string = Fable.Core.RustInterop.emitRustExpr v84 v85 
    let _v78 = v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : string = "format!(\"{:#?}\", $0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v87 
    let v89 : string = "fable_library_rust::String_::fromString($0)"
    let v90 : string = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let _v78 = v90 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v91 : string = $"%A{v1}"
    let _v78 = v91 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v1}"
    let _v78 = v94 
    #endif
#else
    let v97 : string = $"%A{v1}"
    let _v78 = v97 
    #endif
    let v100 : string = _v78 
    let v105 : string = $"{v100}"
    let v108 : unit = ()
    let v109 : (unit -> unit) = closure6(v16, v105)
    let v110 : unit = (fun () -> v109 (); v108) ()
    let v113 : string = $"{v52}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure6(v16, v113)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v121 : string = "proof"
    let v122 : string = $"{v121}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure6(v16, v122)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v130 : string = $"{v35}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure6(v16, v130)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v138 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v139 : string = "format!(\"{:#?}\", $0)"
    let v140 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v139 
    let v141 : string = "fable_library_rust::String_::fromString($0)"
    let v142 : string = Fable.Core.RustInterop.emitRustExpr v140 v141 
    let _v138 = v142 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v143 : string = "format!(\"{:#?}\", $0)"
    let v144 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v143 
    let v145 : string = "fable_library_rust::String_::fromString($0)"
    let v146 : string = Fable.Core.RustInterop.emitRustExpr v144 v145 
    let _v138 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "format!(\"{:#?}\", $0)"
    let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v147 
    let v149 : string = "fable_library_rust::String_::fromString($0)"
    let v150 : string = Fable.Core.RustInterop.emitRustExpr v148 v149 
    let _v138 = v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : string = $"%A{v2}"
    let _v138 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : string = $"%A{v2}"
    let _v138 = v154 
    #endif
#else
    let v157 : string = $"%A{v2}"
    let _v138 = v157 
    #endif
    let v160 : string = _v138 
    let v165 : string = $"{v160}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure6(v16, v165)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v173 : string = $"{v52}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure6(v16, v173)
    let v178 : unit = (fun () -> v177 (); v176) ()
    let v181 : string = "block_timestamp"
    let v182 : string = $"{v181}"
    let v185 : unit = ()
    let v186 : (unit -> unit) = closure6(v16, v182)
    let v187 : unit = (fun () -> v186 (); v185) ()
    let v190 : string = $"{v35}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure6(v16, v190)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v198 : string = $"{v3}"
    let v201 : unit = ()
    let v202 : (unit -> unit) = closure6(v16, v198)
    let v203 : unit = (fun () -> v202 (); v201) ()
    let v206 : string = $"{v52}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure6(v16, v206)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v214 : string = "block_height"
    let v215 : string = $"{v214}"
    let v218 : unit = ()
    let v219 : (unit -> unit) = closure6(v16, v215)
    let v220 : unit = (fun () -> v219 (); v218) ()
    let v223 : string = $"{v35}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure6(v16, v223)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v231 : string = $"{v4}"
    let v234 : unit = ()
    let v235 : (unit -> unit) = closure6(v16, v231)
    let v236 : unit = (fun () -> v235 (); v234) ()
    let v239 : string = $"{v52}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure6(v16, v239)
    let v244 : unit = (fun () -> v243 (); v242) ()
    let v247 : string = "epoch_height"
    let v248 : string = $"{v247}"
    let v251 : unit = ()
    let v252 : (unit -> unit) = closure6(v16, v248)
    let v253 : unit = (fun () -> v252 (); v251) ()
    let v256 : string = $"{v35}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure6(v16, v256)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v264 : string = $"{v5}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure6(v16, v264)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v272 : string = $"{v52}"
    let v275 : unit = ()
    let v276 : (unit -> unit) = closure6(v16, v272)
    let v277 : unit = (fun () -> v276 (); v275) ()
    let v280 : string = "account_balance"
    let v281 : string = $"{v280}"
    let v284 : unit = ()
    let v285 : (unit -> unit) = closure6(v16, v281)
    let v286 : unit = (fun () -> v285 (); v284) ()
    let v289 : string = $"{v35}"
    let v292 : unit = ()
    let v293 : (unit -> unit) = closure6(v16, v289)
    let v294 : unit = (fun () -> v293 (); v292) ()
    let v297 : string = $"{v6}"
    let v300 : unit = ()
    let v301 : (unit -> unit) = closure6(v16, v297)
    let v302 : unit = (fun () -> v301 (); v300) ()
    let v305 : string = $"{v52}"
    let v308 : unit = ()
    let v309 : (unit -> unit) = closure6(v16, v305)
    let v310 : unit = (fun () -> v309 (); v308) ()
    let v313 : string = "signer_account_id"
    let v314 : string = $"{v313}"
    let v317 : unit = ()
    let v318 : (unit -> unit) = closure6(v16, v314)
    let v319 : unit = (fun () -> v318 (); v317) ()
    let v322 : string = $"{v35}"
    let v325 : unit = ()
    let v326 : (unit -> unit) = closure6(v16, v322)
    let v327 : unit = (fun () -> v326 (); v325) ()
    let v330 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v331 : string = "format!(\"{:#?}\", $0)"
    let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v331 
    let v333 : string = "fable_library_rust::String_::fromString($0)"
    let v334 : string = Fable.Core.RustInterop.emitRustExpr v332 v333 
    let _v330 = v334 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v335 : string = "format!(\"{:#?}\", $0)"
    let v336 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v335 
    let v337 : string = "fable_library_rust::String_::fromString($0)"
    let v338 : string = Fable.Core.RustInterop.emitRustExpr v336 v337 
    let _v330 = v338 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v339 : string = "format!(\"{:#?}\", $0)"
    let v340 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v339 
    let v341 : string = "fable_library_rust::String_::fromString($0)"
    let v342 : string = Fable.Core.RustInterop.emitRustExpr v340 v341 
    let _v330 = v342 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v343 : string = $"%A{v7}"
    let _v330 = v343 
    #endif
#if FABLE_COMPILER_PYTHON
    let v346 : string = $"%A{v7}"
    let _v330 = v346 
    #endif
#else
    let v349 : string = $"%A{v7}"
    let _v330 = v349 
    #endif
    let v352 : string = _v330 
    let v357 : string = $"{v352}"
    let v360 : unit = ()
    let v361 : (unit -> unit) = closure6(v16, v357)
    let v362 : unit = (fun () -> v361 (); v360) ()
    let v365 : string = $"{v52}"
    let v368 : unit = ()
    let v369 : (unit -> unit) = closure6(v16, v365)
    let v370 : unit = (fun () -> v369 (); v368) ()
    let v373 : string = "predecessor_account_id"
    let v374 : string = $"{v373}"
    let v377 : unit = ()
    let v378 : (unit -> unit) = closure6(v16, v374)
    let v379 : unit = (fun () -> v378 (); v377) ()
    let v382 : string = $"{v35}"
    let v385 : unit = ()
    let v386 : (unit -> unit) = closure6(v16, v382)
    let v387 : unit = (fun () -> v386 (); v385) ()
    let v390 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v391 : string = "format!(\"{:#?}\", $0)"
    let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v391 
    let v393 : string = "fable_library_rust::String_::fromString($0)"
    let v394 : string = Fable.Core.RustInterop.emitRustExpr v392 v393 
    let _v390 = v394 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v395 : string = "format!(\"{:#?}\", $0)"
    let v396 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v395 
    let v397 : string = "fable_library_rust::String_::fromString($0)"
    let v398 : string = Fable.Core.RustInterop.emitRustExpr v396 v397 
    let _v390 = v398 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v399 : string = "format!(\"{:#?}\", $0)"
    let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v399 
    let v401 : string = "fable_library_rust::String_::fromString($0)"
    let v402 : string = Fable.Core.RustInterop.emitRustExpr v400 v401 
    let _v390 = v402 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v403 : string = $"%A{v8}"
    let _v390 = v403 
    #endif
#if FABLE_COMPILER_PYTHON
    let v406 : string = $"%A{v8}"
    let _v390 = v406 
    #endif
#else
    let v409 : string = $"%A{v8}"
    let _v390 = v409 
    #endif
    let v412 : string = _v390 
    let v417 : string = $"{v412}"
    let v420 : unit = ()
    let v421 : (unit -> unit) = closure6(v16, v417)
    let v422 : unit = (fun () -> v421 (); v420) ()
    let v425 : string = $"{v52}"
    let v428 : unit = ()
    let v429 : (unit -> unit) = closure6(v16, v425)
    let v430 : unit = (fun () -> v429 (); v428) ()
    let v433 : string = "seed"
    let v434 : string = $"{v433}"
    let v437 : unit = ()
    let v438 : (unit -> unit) = closure6(v16, v434)
    let v439 : unit = (fun () -> v438 (); v437) ()
    let v442 : string = $"{v35}"
    let v445 : unit = ()
    let v446 : (unit -> unit) = closure6(v16, v442)
    let v447 : unit = (fun () -> v446 (); v445) ()
    let v450 : string = $"{v9}"
    let v453 : unit = ()
    let v454 : (unit -> unit) = closure6(v16, v450)
    let v455 : unit = (fun () -> v454 (); v453) ()
    let v458 : string = $"{v52}"
    let v461 : unit = ()
    let v462 : (unit -> unit) = closure6(v16, v458)
    let v463 : unit = (fun () -> v462 (); v461) ()
    let v466 : string = "seeds"
    let v467 : string = $"{v466}"
    let v470 : unit = ()
    let v471 : (unit -> unit) = closure6(v16, v467)
    let v472 : unit = (fun () -> v471 (); v470) ()
    let v475 : string = $"{v35}"
    let v478 : unit = ()
    let v479 : (unit -> unit) = closure6(v16, v475)
    let v480 : unit = (fun () -> v479 (); v478) ()
    let v483 : string = $"{v10}"
    let v486 : unit = ()
    let v487 : (unit -> unit) = closure6(v16, v483)
    let v488 : unit = (fun () -> v487 (); v486) ()
    let v491 : string = $"{v52}"
    let v494 : unit = ()
    let v495 : (unit -> unit) = closure6(v16, v491)
    let v496 : unit = (fun () -> v495 (); v494) ()
    let v499 : string = "entropy_len"
    let v500 : string = $"{v499}"
    let v503 : unit = ()
    let v504 : (unit -> unit) = closure6(v16, v500)
    let v505 : unit = (fun () -> v504 (); v503) ()
    let v508 : string = $"{v35}"
    let v511 : unit = ()
    let v512 : (unit -> unit) = closure6(v16, v508)
    let v513 : unit = (fun () -> v512 (); v511) ()
    let v516 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v517 : string = "format!(\"{:#?}\", $0)"
    let v518 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v517 
    let v519 : string = "fable_library_rust::String_::fromString($0)"
    let v520 : string = Fable.Core.RustInterop.emitRustExpr v518 v519 
    let _v516 = v520 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v521 : string = "format!(\"{:#?}\", $0)"
    let v522 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v521 
    let v523 : string = "fable_library_rust::String_::fromString($0)"
    let v524 : string = Fable.Core.RustInterop.emitRustExpr v522 v523 
    let _v516 = v524 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v525 : string = "format!(\"{:#?}\", $0)"
    let v526 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v525 
    let v527 : string = "fable_library_rust::String_::fromString($0)"
    let v528 : string = Fable.Core.RustInterop.emitRustExpr v526 v527 
    let _v516 = v528 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v529 : string = $"%A{v11}"
    let _v516 = v529 
    #endif
#if FABLE_COMPILER_PYTHON
    let v532 : string = $"%A{v11}"
    let _v516 = v532 
    #endif
#else
    let v535 : string = $"%A{v11}"
    let _v516 = v535 
    #endif
    let v538 : string = _v516 
    let v543 : string = $"{v538}"
    let v546 : unit = ()
    let v547 : (unit -> unit) = closure6(v16, v543)
    let v548 : unit = (fun () -> v547 (); v546) ()
    let v551 : string = $"{v52}"
    let v554 : unit = ()
    let v555 : (unit -> unit) = closure6(v16, v551)
    let v556 : unit = (fun () -> v555 (); v554) ()
    let v559 : string = "entropy"
    let v560 : string = $"{v559}"
    let v563 : unit = ()
    let v564 : (unit -> unit) = closure6(v16, v560)
    let v565 : unit = (fun () -> v564 (); v563) ()
    let v568 : string = $"{v35}"
    let v571 : unit = ()
    let v572 : (unit -> unit) = closure6(v16, v568)
    let v573 : unit = (fun () -> v572 (); v571) ()
    let v576 : string = $"{v12}"
    let v579 : unit = ()
    let v580 : (unit -> unit) = closure6(v16, v576)
    let v581 : unit = (fun () -> v580 (); v579) ()
    let v584 : string = $"{v52}"
    let v587 : unit = ()
    let v588 : (unit -> unit) = closure6(v16, v584)
    let v589 : unit = (fun () -> v588 (); v587) ()
    let v592 : string = "hash_u8"
    let v593 : string = $"{v592}"
    let v596 : unit = ()
    let v597 : (unit -> unit) = closure6(v16, v593)
    let v598 : unit = (fun () -> v597 (); v596) ()
    let v601 : string = $"{v35}"
    let v604 : unit = ()
    let v605 : (unit -> unit) = closure6(v16, v601)
    let v606 : unit = (fun () -> v605 (); v604) ()
    let v609 : string = $"{v13}"
    let v612 : unit = ()
    let v613 : (unit -> unit) = closure6(v16, v609)
    let v614 : unit = (fun () -> v613 (); v612) ()
    let v617 : string = $"{v52}"
    let v620 : unit = ()
    let v621 : (unit -> unit) = closure6(v16, v617)
    let v622 : unit = (fun () -> v621 (); v620) ()
    let v625 : string = "rolls"
    let v626 : string = $"{v625}"
    let v629 : unit = ()
    let v630 : (unit -> unit) = closure6(v16, v626)
    let v631 : unit = (fun () -> v630 (); v629) ()
    let v634 : string = $"{v35}"
    let v637 : unit = ()
    let v638 : (unit -> unit) = closure6(v16, v634)
    let v639 : unit = (fun () -> v638 (); v637) ()
    let v642 : string = $"{v14}"
    let v645 : unit = ()
    let v646 : (unit -> unit) = closure6(v16, v642)
    let v647 : unit = (fun () -> v646 (); v645) ()
    let v650 : string = " }"
    let v651 : string = $"{v650}"
    let v654 : unit = ()
    let v655 : (unit -> unit) = closure6(v16, v651)
    let v656 : unit = (fun () -> v655 (); v654) ()
    let v659 : string = v16.l0
    v659
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method27(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v24 : int64 = v0.l0
    let v25 : string = "dice_contract.generate_random_number"
    let v26 : string = $"{v6} {v7} #{v24} %s{v25} / {v23}"
    method17(v26)
and closure16 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v14 : US0 = US0_1
    let v15 : bool = method0(v14)
    if v15 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure2()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v32 : Mut0, v33 : Mut1, v34 : Mut2, v35 : Mut3, v36 : Mut4, v37 : int64 option) = TraceState.trace_state.Value
        let v50 : string = method7(v32, v33, v34, v35, v36, v37)
        let v51 : string = method11()
        let v52 : string = $"%A{v8}"
        let v55 : string = $"v9.to_string()"
        let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v55 
        let v57 : string = $"v10.to_string()"
        let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v57 
        let v59 : string = $"%A{v4}"
        let v62 : string = $"%A{v0}"
        let v65 : string = "$0.len()"
        let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v65 
        let v67 : string = $"%A{v11}"
        let v70 : string = $"%A{v12}"
        let v73 : uint8 list = []
        let v74 : uint8 list = method25(v13, v73)
        let v75 : (uint8 list -> (uint8 [])) = List.toArray
        let v76 : (uint8 []) = v75 v74
        let v79 : string = "$0.to_vec()"
        let v80 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v76 v79 
        let v81 : string = $"%A{v80}"
        let v84 : string = method26(v32, v33, v34, v35, v36, v37, v50, v51, v3, v1, v2, v7, v6, v5, v52, v56, v58, v59, v62, v66, v67, v70, v81)
        method18(v84)
and method28 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method28(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method29 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method29(v3, v1)
        UH0_1(v2, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure17 (v0 : UH1) () : UH1 =
    v0
and closure18 (v0 : UH1, v1 : Mut5) () : UH1 =
    let v2 : US4 = v1.l0
    match v2 with
    | US4_1(v3) -> (* Computed *)
        v3
    | US4_0(v4) -> (* NotComputed *)
        let v5 : UH1 = v4 ()
        let v12 : UH1 =
            match v5 with
            | UH1_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH1) = method30(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US4 = US4_1(v12)
        v1.l0 <- v13
        v12
and method30 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US4 = US4_0(v1)
    let v3 : Mut5 = {l0 = v2} : Mut5
    closure18(v0, v3)
and method33 (v0 : uint64, v1 : uint64, v2 : int8) : string =
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
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method33(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.calculate_dice_count"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure19 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = method32(v21, v22, v23, v24, v25, v26, v39, v40, v0, v2, v1)
        method18(v41)
and method31 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method31(v0, v6, v4)
        else
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure19(v0, v1, v2)
            let v10 : unit = (fun () -> v9 (); v8) ()
            v1
    else
        let v51 : unit = ()
        let v52 : (unit -> unit) = closure19(v0, v1, v2)
        let v53 : unit = (fun () -> v52 (); v51) ()
        v1
and method37 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
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
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method37(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.create_sequential_roller / roll"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure20 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure2()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = $"%A{v3}"
        let v45 : string = method36(v22, v23, v24, v25, v26, v27, v40, v41, v0, v1, v2, v42)
        method18(v45)
and method38 (v0 : int64, v1 : UH1) : US5 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US5_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method38(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US5_1
and method40 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method40()
    let v9 : int64 = v0.l0
    let v10 : string = "dice.create_sequential_roller / roll / None"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
and closure21 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure2()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method39(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and method35 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
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
    let v17 : (unit -> unit) = closure20(v5, v6, v7, v15)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v61 : UH1 = v0 ()
    let v62 : int64 = v1.l0
    let v63 : US5 = method38(v62, v61)
    match v63 with
    | US5_1 -> (* None *)
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure21()
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
        let v121 : US5 = US5_1
        v4.l0 <- v121
        method35(v0, v1, v2, v3, v4)
    | US5_0(v64) -> (* Some *)
        let v65 : int64 = v1.l0
        let v66 : int64 = v65 + 1L
        v1.l0 <- v66
        let v67 : US5 = US5_0(v64)
        v4.l0 <- v67
        v64
and method43 (v0 : int8, v1 : uint64, v2 : uint64) : string =
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
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method43(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = method42(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method18(v41)
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
and method44 (v0 : int8, v1 : UH2) : US7 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US7_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method44(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US7_1
and method46 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
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
and method45 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method46(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "dice.accumulate_dice_rolls"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure87 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure2()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = method45(v22, v23, v24, v25, v26, v27, v40, v41, v1, v0, v2, v3)
        method18(v42)
and method48 (v0 : int8, v1 : uint64, v2 : uint8) : string =
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
and method47 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method48(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice.accumulate_dice_rolls"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure88 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = method47(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method18(v41)
and method41 (v0 : int8, v1 : UH0, v2 : uint64) : US6 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure22(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US6_0(v4, v1)
    else
        match v1 with
        | UH0_1(v49, v50) -> (* Cons *)
            let v51 : bool = v49 > 1uy
            if v51 then
                let v52 : uint64 = 1UL
                let v53 : (unit -> UH2) = closure23()
                let v54 : UH2 = UH2_0(v52, v53)
                let v55 : US7 = method44(v0, v54)
                let v59 : uint64 =
                    match v55 with
                    | US7_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US7_0(v56) -> (* Some *)
                        v56
                let v60 : uint8 = v49 - 1uy
                let v61 : uint64 = uint64 v60
                let v62 : uint64 = v61 * v59
                let v63 : unit = ()
                let v64 : (unit -> unit) = closure87(v2, v0, v49, v62)
                let v65 : unit = (fun () -> v64 (); v63) ()
                let v105 : uint64 = v2 + v62
                let v106 : int8 = v0 - 1y
                method41(v106, v50, v105)
            else
                let v108 : unit = ()
                let v109 : (unit -> unit) = closure88(v2, v0, v49)
                let v110 : unit = (fun () -> v109 (); v108) ()
                let v150 : int8 = v0 - 1y
                method41(v150, v50, v2)
        | UH0_0 -> (* Nil *)
            US6_1
and method49 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut6, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method35(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method49(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method50 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method35(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method34(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US6 = method41(v6, v7, v13)
        match v14 with
        | US6_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method49(v6, v0, v1, v2, v3, v4, v18)
                method50(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method49(v6, v0, v1, v2, v3, v4, v22)
            method50(v0, v1, v2, v3, v4, v5, v6, v23)
and method34 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method35(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method34(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US6 = method41(v6, v7, v15)
        match v16 with
        | US6_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method49(v6, v0, v1, v2, v3, v4, v20)
                method50(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method49(v6, v0, v1, v2, v3, v4, v24)
            method50(v0, v1, v2, v3, v4, v5, v6, v25)
and method51 () : (unit -> unit) =
    closure10()
and closure89 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method20()
and method52 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method52(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method54 (v0 : uint64, v1 : string, v2 : string) : string =
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
and method53 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method54(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "dice_contract.roll_within_bounds"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure90 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method0(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure2()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : string = $"%A{v1}"
        let v44 : string = $"%A{v2}"
        let v47 : string = method53(v21, v22, v23, v24, v25, v26, v39, v40, v0, v41, v44)
        method18(v47)
and method55 () : (unit -> unit) =
    closure10()
and closure91 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure2()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method20()
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
        let v73 : (unit -> unit) = closure1(v68, v71)
        let v74 : unit = (fun () -> v73 (); v72) ()
        ()
    let v117 : (unit -> unit) = method19()
    let v118 : unit = ()
    let v119 : (unit -> unit) = closure11(v117)
    let v120 : unit = (fun () -> v119 (); v118) ()
    let v159 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v159 
    let v160 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v160 
    let v161 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
    let v165 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v167 
    let v168 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v168 
    let v169 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v171 
    let v172 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v172 
    let v173 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v174 : bool = Fable.Core.RustInterop.emitRustExpr () v173 
    let v175 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr () v175 
    let v177 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v177 
    let v178 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = $"key"
    let v181 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v180 
    let v182 : string = $"proof"
    let v183 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : string = $"max"
    let v185 : uint64 = Fable.Core.RustInterop.emitRustExpr () v184 
    let v186 : string = $"&mut self.0.1"
    let v187 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v186 
    let v188 : string = $"near_sdk::env::random_seed()"
    let v189 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : string = $"near_sdk::env::epoch_height()"
    let v191 : uint64 = Fable.Core.RustInterop.emitRustExpr () v190 
    let v192 : string = $"near_sdk::env::block_height()"
    let v193 : uint64 = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = $"near_sdk::env::block_timestamp()"
    let v195 : uint64 = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = $"near_sdk::env::account_balance()"
    let v197 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : string = $"near_sdk::env::signer_account_id()"
    let v199 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v198 
    let v200 : string = $"near_sdk::env::predecessor_account_id()"
    let v201 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v200 
    let v202 : string = $"&*v187"
    let v203 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v202 
    let v204 : string = $"v203.iter().map(|x| *x).collect::<Vec<_>>()"
    let v205 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = $"v191.to_le_bytes()"
    let v207 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v206 
    let v208 : string = $"v207.to_vec()"
    let v209 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v208 
    let v210 : string = $"v193.to_le_bytes()"
    let v211 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v210 
    let v212 : string = $"v211.to_vec()"
    let v213 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v212 
    let v214 : string = $"v195.to_le_bytes()"
    let v215 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v214 
    let v216 : string = $"v215.to_vec()"
    let v217 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v216 
    let v218 : string = "$0.as_yoctonear()"
    let v219 : u128 = Fable.Core.RustInterop.emitRustExpr v197 v218 
    let v220 : string = $"v219.to_le_bytes()"
    let v221 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v220 
    let v222 : string = $"v221.to_vec()"
    let v223 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v222 
    let v224 : string = $"v199.as_bytes()"
    let v225 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v224 
    let v226 : string = $"v225.to_vec()"
    let v227 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v226 
    let v228 : string = $"v201.as_bytes()"
    let v229 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = $"v229.to_vec()"
    let v231 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = $"$0.into_bytes()"
    let v233 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v183 v232 
    let v234 : string = $"$0.into_bytes()"
    let v235 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v181 v234 
    let v236 : (Vec<uint8> []) = [|v189; v205; v209; v213; v217; v223; v227; v231; v233; v235|]
    let v237 : string = "$0.to_vec()"
    let v238 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v236 v237 
    let v239 : string = $"v238.concat()"
    let v240 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v239 
    let v241 : string = $"near_sdk::env::keccak512(&$0)"
    let v242 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v240 v241 
    let v243 : string = "true; v187.extend($0); //"
    let v244 : bool = Fable.Core.RustInterop.emitRustExpr v242 v243 
    let v245 : string = $"v187.len()"
    let v246 : uint32 = Fable.Core.RustInterop.emitRustExpr () v245 
    let v247 : (uint32 -> int32) = int32
    let v248 : int32 = v247 v246
    let v249 : unativeint = 100 |> unativeint 
    let v252 : (unativeint -> int32) = int32
    let v253 : int32 = v252 v249
    let v254 : int32 = v248 - v253
    let v255 : bool = v254 > 0
    if v255 then
        let v256 : string = "v187.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v257 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v254 v256 
        let v258 : unit = ()
        let v259 : (unit -> unit) = closure1(v254, v257)
        let v260 : unit = (fun () -> v259 (); v258) ()
        ()
    let v303 : (unit -> unit) = method19()
    let v304 : unit = ()
    let v305 : (unit -> unit) = closure11(v303)
    let v306 : unit = (fun () -> v305 (); v304) ()
    let v345 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v346 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v242 v345 
    let v347 : uint8 list = v346 |> Array.toList
    let v348 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v349 : (uint8 -> (UH0 -> UH0)) = method21()
    let v350 : (uint8 list -> (UH0 -> UH0)) = v348 v349
    let v351 : (UH0 -> UH0) = v350 v347
    let v352 : UH0 = UH0_0
    let v353 : UH0 = v351 v352
    let v358 : UH1 = UH1_1
    let v359 : UH1 = method22(v353, v358)
    let v360 : UH1 = UH1_1
    let v361 : UH1 = method23(v359, v360)
    let v362 : UH0 = UH0_0
    let v363 : UH0 = method24(v361, v362)
    let v364 : unit = ()
    let v365 : (unit -> unit) = closure16(v187, v181, v183, v185, v189, v191, v193, v195, v197, v199, v201, v240, v242, v363)
    let v366 : unit = (fun () -> v365 (); v364) ()
    let v438 : UH0 = UH0_0
    let v439 : UH0 = method28(v363, v438)
    let v440 : UH0 = method29(v363, v439)
    let v441 : UH1 = UH1_1
    let v442 : UH1 = method22(v440, v441)
    let v443 : (unit -> UH1) = closure17(v442)
    let v444 : (unit -> UH1) = method30(v442, v443)
    let v445 : Mut0 = {l0 = 0L} : Mut0
    let v446 : Mut0 = {l0 = 1L} : Mut0
    let v447 : Mut0 = {l0 = -1L} : Mut0
    let v448 : US5 = US5_1
    let v449 : Mut6 = {l0 = v448} : Mut6
    let v450 : bool = v185 = 1UL
    let v454 : int8 =
        if v450 then
            1y
        else
            let v451 : int8 = 0y
            let v452 : uint64 = 1UL
            method31(v185, v451, v452)
    let v455 : int8 = v454 - 1y
    let v456 : UH0 = UH0_0
    let v457 : int8 = 0y
    let v458 : uint64 = method34(v444, v445, v446, v447, v449, v185, v455, v456, v457)
    let v459 : (unit -> unit) = method51()
    let v460 : unit = ()
    let v461 : (unit -> unit) = closure89(v459)
    let v462 : unit = (fun () -> v461 (); v460) ()
    let v501 : string = "v458 //"
    Fable.Core.RustInterop.emitRustExpr () v501 
    let v502 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v502 
    let v503 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v503 
    let v504 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v504 
    let v505 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v505 
    let v506 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v507 : bool = Fable.Core.RustInterop.emitRustExpr () v506 
    let v508 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v509 : bool = Fable.Core.RustInterop.emitRustExpr () v508 
    let v510 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v510 
    let v511 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v511 
    let v512 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v512 
    let v513 : string = $"max"
    let v514 : uint64 = Fable.Core.RustInterop.emitRustExpr () v513 
    let v515 : string = $"rolls"
    let v516 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v515 
    let v517 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v518 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v516 v517 
    let v519 : uint8 list = v518 |> Array.toList
    let v520 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v521 : (uint8 -> (UH0 -> UH0)) = method21()
    let v522 : (uint8 list -> (UH0 -> UH0)) = v520 v521
    let v523 : (UH0 -> UH0) = v522 v519
    let v524 : UH0 = UH0_0
    let v525 : UH0 = v523 v524
    let v530 : int8 = 0y
    let v531 : int8 = method52(v525, v530)
    let v532 : int8 = v531 - 1y
    let v533 : uint64 = 0UL
    let v534 : US6 = method41(v532, v525, v533)
    let v544 : US7 =
        match v534 with
        | US6_0(v535, v536) -> (* Some *)
            let v537 : bool = v535 >= 1UL
            let v539 : bool =
                if v537 then
                    let v538 : bool = v535 <= v514
                    v538
                else
                    false
            if v539 then
                US7_0(v535)
            else
                US7_1
        | _ ->
            US7_1
    let v551 : uint64 option =
        match v544 with
        | US7_1 -> (* None *)
            let v549 : uint64 option = None
            v549
        | US7_0(v545) -> (* Some *)
            let v546 : uint64 option = Some v545 
            v546
    let v552 : unit = ()
    let v553 : (unit -> unit) = closure90(v514, v516, v551)
    let v554 : unit = (fun () -> v553 (); v552) ()
    let v600 : (unit -> unit) = method55()
    let v601 : unit = ()
    let v602 : (unit -> unit) = closure91(v600)
    let v603 : unit = (fun () -> v602 (); v601) ()
    let v642 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v551 v642 
    let v643 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v643 
    let v644 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v644 
    let v645 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v645 
    let v646 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v647 : bool = Fable.Core.RustInterop.emitRustExpr () v646 
    let v648 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v649 : bool = Fable.Core.RustInterop.emitRustExpr () v648 
    let v650 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v650 
    let v651 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v651 
    let v652 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v652 
    let v653 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v653 
    let v654 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v654 
    let v655 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v655 
    let v656 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v656 
    let v657 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v657 
    let v658 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v658 
    let v659 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v659 
    let v660 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v660 
    let v661 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v662 : bool = Fable.Core.RustInterop.emitRustExpr () v661 
    let v663 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v664 : bool = Fable.Core.RustInterop.emitRustExpr () v663 
    let v665 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v665 
    let v666 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v666 
    let v667 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v668 : bool = Fable.Core.RustInterop.emitRustExpr () v667 
    let v669 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v670 : bool = Fable.Core.RustInterop.emitRustExpr () v669 
    let v671 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v672 : bool = Fable.Core.RustInterop.emitRustExpr () v671 
    let v673 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v674 : bool = Fable.Core.RustInterop.emitRustExpr () v673 
    let v675 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v676 : bool = Fable.Core.RustInterop.emitRustExpr () v675 
    let v677 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v678 : bool = Fable.Core.RustInterop.emitRustExpr () v677 
    let v679 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v680 : bool = Fable.Core.RustInterop.emitRustExpr () v679 
    let v681 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v682 : bool = Fable.Core.RustInterop.emitRustExpr () v681 
    let v683 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v684 : bool = Fable.Core.RustInterop.emitRustExpr () v683 
    let v685 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v686 : bool = Fable.Core.RustInterop.emitRustExpr () v685 
    let v687 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v688 : bool = Fable.Core.RustInterop.emitRustExpr () v687 
    let v689 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v690 : bool = Fable.Core.RustInterop.emitRustExpr () v689 
    let v691 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v692 : bool = Fable.Core.RustInterop.emitRustExpr () v691 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
