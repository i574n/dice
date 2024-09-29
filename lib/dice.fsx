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
and [<Struct>] US4 =
    | US4_0 of f0_0 : (unit -> UH0)
    | US4_1 of f1_0 : UH0
and Mut5 = {mutable l0 : US4}
and [<Struct>] US5 =
    | US5_0 of f0_0 : uint8
    | US5_1
and Mut6 = {mutable l0 : US5}
and [<Struct>] US6 =
    | US6_0 of f0_0 : uint64 * f0_1 : UH1
    | US6_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : uint64
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : int64 * f0_1 : UH1
    | US8_1
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
and method2 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure6 () (v0 : string) : US1 =
    US1_0(v0)
and method5 () : (string -> US1) =
    closure6()
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
and closure7 () (v0 : string) : unit =
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
    let v417 : (string -> unit) = closure7()
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
and closure5 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure8 () (v0 : int64) : US3 =
    US3_0(v0)
and method8 () : (int64 -> US3) =
    closure8()
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
and method12 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
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
    let v108 : string = method12()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[94m"
    let v112 : string = method12()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[94m"
    let v116 : string = method12()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
and method14 () : string =
    let v0 : string = ""
    v0
and method13 () : string =
    let v0 : string = method14()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method15 (v0 : string, v1 : string, v2 : string, v3 : int64, v4 : string) : string =
    let v5 : string = $"{v0} {v1} #{v3} %s{v2} / {v4}"
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
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method16 (v0 : string, v1 : Mut0, v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure9(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure10()
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
and closure4 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure5()
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
        let v73 : string = method7(v55, v56, v57, v58, v59, v60)
        let v74 : string = method11()
        let v75 : string = $"dice.create_sequential_roller ()"
        let v76 : bool = v75 = ""
        let v81 : string =
            if v76 then
                let v77 : string = ""
                v77
            else
                let v78 : int64 = v55.l0
                let v79 : string = method13()
                method15(v73, v74, v75, v78, v79)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v1 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method16(v81, v97, v98, v99, v100, v101, v102)
and method17 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_1(v2, v1)
        method17(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and method18 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method18(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure12 (v0 : UH0) () : UH0 =
    v0
and method19 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method19(v3, v1)
        let v5 : (unit -> UH0) = closure12(v4)
        UH0_0(v2, v5)
    | UH1_0 -> (* Nil *)
        v1
and closure13 (v0 : UH0) () : UH0 =
    v0
and closure14 (v0 : UH0, v1 : Mut5) () : UH0 =
    let v2 : US4 = v1.l0
    match v2 with
    | US4_1(v3) -> (* Computed *)
        v3
    | US4_0(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method20(v0, v8)
                UH0_0(v7, v9)
            | UH0_1 -> (* StreamNil *)
                UH0_1
        let v13 : US4 = US4_1(v12)
        v1.l0 <- v13
        v12
and method20 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US4 = US4_0(v1)
    let v3 : Mut5 = {l0 = v2} : Mut5
    closure14(v0, v3)
and closure17 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method22 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure17(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "current_index"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure17(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure17(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure17(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure17(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure17(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure17(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure17(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure17(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "len"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure17(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure17(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure17(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "last_item"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure17(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure17(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v134 : string = "format!(\"{:#?}\", $0)"
    let v135 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v134 
    let v136 : string = "fable_library_rust::String_::fromString($0)"
    let v137 : string = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let _v133 = v137 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v138 : string = "format!(\"{:#?}\", $0)"
    let v139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v138 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v139 v140 
    let _v133 = v141 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v142 : string = "format!(\"{:#?}\", $0)"
    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v142 
    let v144 : string = "fable_library_rust::String_::fromString($0)"
    let v145 : string = Fable.Core.RustInterop.emitRustExpr v143 v144 
    let _v133 = v145 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v146 : string = $"%A{v3}"
    let _v133 = v146 
    #endif
#if FABLE_COMPILER_PYTHON
    let v149 : string = $"%A{v3}"
    let _v133 = v149 
    #endif
#else
    let v152 : string = $"%A{v3}"
    let _v133 = v152 
    #endif
    let v155 : string = _v133 
    let v160 : string = $"{v155}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure17(v5, v160)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v168 : string = " }"
    let v169 : string = $"{v168}"
    let v172 : unit = ()
    let v173 : (unit -> unit) = closure17(v5, v169)
    let v174 : unit = (fun () -> v173 (); v172) ()
    let v177 : string = v5.l0
    v177
and closure16 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure5()
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
        let v77 : string = method7(v59, v60, v61, v62, v63, v64)
        let v78 : string = method11()
        let v79 : string = $"dice.create_sequential_roller / roll"
        let v80 : bool = v79 = ""
        let v85 : string =
            if v80 then
                let v81 : string = ""
                v81
            else
                let v82 : int64 = v59.l0
                let v83 : string = method22(v0, v1, v2, v3)
                method15(v77, v78, v79, v82, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v5 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and method23 (v0 : int64, v1 : UH0) : US5 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US5_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method23(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US5_1
and closure18 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure5()
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
        let v73 : string = method7(v55, v56, v57, v58, v59, v60)
        let v74 : string = method11()
        let v75 : string = $"dice.create_sequential_roller / roll / None"
        let v76 : bool = v75 = ""
        let v81 : string =
            if v76 then
                let v77 : string = ""
                v77
            else
                let v78 : int64 = v55.l0
                let v79 : string = method13()
                method15(v73, v74, v75, v78, v79)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v1 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method16(v81, v97, v98, v99, v100, v101, v102)
and method21 (v0 : (unit -> UH0), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) : uint8 =
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
    let v17 : (unit -> unit) = closure16(v5, v6, v7, v15)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v134 : UH0 = v0 ()
    let v135 : int64 = v1.l0
    let v136 : US5 = method23(v135, v134)
    match v136 with
    | US5_1 -> (* None *)
        let v141 : unit = ()
        let v142 : (unit -> unit) = closure18()
        let v143 : unit = (fun () -> v142 (); v141) ()
        let v259 : int64 = v3.l0
        let v260 : bool = v259 = -1L
        if v260 then
            let v261 : int64 = v1.l0
            v3.l0 <- v261
            ()
        let v262 : int64 = v2.l0
        let v263 : int64 = v3.l0
        let v264 : bool = v262 >= v263
        let v267 : int64 =
            if v264 then
                1L
            else
                let v265 : int64 = v2.l0
                let v266 : int64 = v265 + 1L
                v266
        v2.l0 <- v267
        let v268 : int64 = v2.l0
        let v269 : int64 = v268 - 1L
        v1.l0 <- v269
        let v270 : US5 = US5_1
        v4.l0 <- v270
        method21(v0, v1, v2, v3, v4)
    | US5_0(v137) -> (* Some *)
        let v138 : int64 = v1.l0
        let v139 : int64 = v138 + 1L
        v1.l0 <- v139
        let v140 : US5 = US5_0(v137)
        v4.l0 <- v140
        v137
and closure15 (v0 : (unit -> UH0), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut6) () : uint8 =
    method21(v0, v1, v2, v3, v4)
and closure3 () (v0 : UH1) : (unit -> uint8) =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure4()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v119 : UH1 = UH1_0
    let v120 : UH1 = method17(v0, v119)
    let v121 : UH1 = method18(v0, v120)
    let v122 : UH0 = UH0_1
    let v123 : UH0 = method19(v121, v122)
    let v124 : (unit -> UH0) = closure13(v123)
    let v125 : (unit -> UH0) = method20(v123, v124)
    let v126 : Mut0 = {l0 = 0L} : Mut0
    let v127 : Mut0 = {l0 = 1L} : Mut0
    let v128 : Mut0 = {l0 = -1L} : Mut0
    let v129 : US5 = US5_1
    let v130 : Mut6 = {l0 = v129} : Mut6
    closure15(v125, v126, v127, v128, v130)
and method25 (v0 : uint64, v1 : int8, v2 : uint64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure17(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure17(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure17(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure17(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure17(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "n"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure17(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure17(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure17(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure17(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "p"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure17(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure17(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure17(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure22 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.calculate_dice_count"
        let v79 : bool = v78 = ""
        let v84 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = method25(v0, v1, v2)
                method15(v76, v77, v78, v81, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v4 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method24 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method24(v0, v6, v4)
        else
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure22(v0, v1, v2)
            let v10 : unit = (fun () -> v9 (); v8) ()
            v1
    else
        let v127 : unit = ()
        let v128 : (unit -> unit) = closure22(v0, v1, v2)
        let v129 : unit = (fun () -> v128 (); v127) ()
        v1
and method28 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure17(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure17(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure17(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure17(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure17(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure17(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure17(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure17(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure17(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure17(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure17(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure17(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure23 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v84 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = method28(v1, v0, v2)
                method15(v76, v77, v78, v81, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v4 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and closure87 () () : UH2 =
    UH2_1
and closure86 () () : UH2 =
    let v0 : (unit -> UH2) = closure87()
    UH2_0(9223372036854775808UL, v0)
and closure85 () () : UH2 =
    let v0 : (unit -> UH2) = closure86()
    UH2_0(4611686018427387904UL, v0)
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(6917529027641081856UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(1152921504606846976UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(15564440312192434176UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(11817445422220181504UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(5044031582654955520UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(6989586621679009792UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(16537217831704461312UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(11979575008805519360UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(14294425217273954304UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(2382404202878992384UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(6545982058383015936UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(10314369046585278464UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(4793518853382471680UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(3873377154515337216UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(645562859085889536UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(107593809847648256UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(3092389647259533312UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(9738770311398031360UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(16995415113324298240UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(8981483876790566912UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(13794743361938128896UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(2299123893656354816UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(3457644661227651072UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(576274110204608512UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(6244960376270618624UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(13338656111851470848UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(14520938734448279552UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(14717985838214414336UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(5527454985320660992UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(16293529225644736512UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(11938960241128898560UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(8138741398091333632UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(7505371590918406144UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(16623181993244360704UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(8919445023443910656UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(4561031516192243712UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(9983543956220149760UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(4738381338321616896UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(789730223053602816UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(131621703842267136UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(21936950640377856UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(3656158440062976UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(609359740010496UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(101559956668416UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(16926659444736UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(2821109907456UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(470184984576UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(78364164096UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(13060694016UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(2176782336UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(362797056UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(60466176UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(10077696UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(1679616UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(279936UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(46656UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(7776UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(1296UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(216UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(36UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(6UL, v0)
and method29 (v0 : int8, v1 : UH2) : US7 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US7_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method29(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US7_1
and method30 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure17(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "power"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure17(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure17(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure17(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure17(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure17(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure17(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure17(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure17(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "roll"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure17(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure17(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure17(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "value"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure17(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure17(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure17(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure17(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and closure88 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure5()
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
        let v77 : string = method7(v59, v60, v61, v62, v63, v64)
        let v78 : string = method11()
        let v79 : string = $"dice.accumulate_dice_rolls"
        let v80 : bool = v79 = ""
        let v85 : string =
            if v80 then
                let v81 : string = ""
                v81
            else
                let v82 : int64 = v59.l0
                let v83 : string = method30(v1, v0, v2, v3)
                method15(v77, v78, v79, v82, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v5 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and method31 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure17(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure17(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure17(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure17(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure17(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure17(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure17(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure17(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure17(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "roll"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure17(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure17(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure17(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure89 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v84 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = method31(v1, v0, v2)
                method15(v76, v77, v78, v81, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v4 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method27 (v0 : int8, v1 : UH1, v2 : uint64) : US6 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure23(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US6_0(v4, v1)
    else
        match v1 with
        | UH1_1(v125, v126) -> (* Cons *)
            let v127 : bool = v125 > 1uy
            if v127 then
                let v128 : uint64 = 1UL
                let v129 : (unit -> UH2) = closure24()
                let v130 : UH2 = UH2_0(v128, v129)
                let v131 : US7 = method29(v0, v130)
                let v135 : uint64 =
                    match v131 with
                    | US7_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US7_0(v132) -> (* Some *)
                        v132
                let v136 : uint8 = v125 - 1uy
                let v137 : uint64 = uint64 v136
                let v138 : uint64 = v137 * v135
                let v139 : unit = ()
                let v140 : (unit -> unit) = closure88(v2, v0, v125, v138)
                let v141 : unit = (fun () -> v140 (); v139) ()
                let v257 : uint64 = v2 + v138
                let v258 : int8 = v0 - 1y
                method27(v258, v126, v257)
            else
                let v260 : unit = ()
                let v261 : (unit -> unit) = closure89(v2, v0, v125)
                let v262 : unit = (fun () -> v261 (); v260) ()
                let v378 : int8 = v0 - 1y
                method27(v378, v126, v2)
        | UH1_0 -> (* Nil *)
            US6_1
and method32 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method32(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method33 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method26(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US6 = method27(v3, v4, v10)
        match v11 with
        | US6_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method32(v3, v0, v15)
                    method33(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method26(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method32(v3, v0, v23)
                method33(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method26(v0, v1, v2, v3, v27, v5)
and method26 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method26(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US6 = method27(v3, v4, v12)
        match v13 with
        | US6_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method32(v3, v0, v17)
                    method33(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method26(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method32(v3, v0, v26)
                method33(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method26(v0, v1, v2, v3, v30, v31)
and closure21 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method24(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method26(v0, v1, v2, v8, v9, v10)
and closure20 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure21(v0, v1)
and closure19 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure20(v0)
and method34 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method34(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure91 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method34(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US6 = method27(v4, v1, v5)
    let v16 : US7 =
        match v6 with
        | US6_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US7_0(v7)
            else
                US7_1
        | _ ->
            US7_1
    match v16 with
    | US7_1 -> (* None *)
        let v21 : uint64 option = None
        v21
    | US7_0(v17) -> (* Some *)
        let v18 : uint64 option = Some v17 
        v18
and closure90 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure91(v0)
and method35 (v0 : int64, v1 : int8, v2 : int64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure17(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "max"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure17(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure17(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure17(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure17(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "n"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure17(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure17(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure17(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure17(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "p"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure17(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure17(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure17(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure93 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure5()
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
        let v73 : string = method7(v55, v56, v57, v58, v59, v60)
        let v74 : string = method11()
        let v75 : string = $"dice.calculate_dice_count"
        let v76 : bool = v75 = ""
        let v84 : string =
            if v76 then
                let v77 : string = ""
                v77
            else
                let v78 : int64 = v55.l0
                let v79 : int64 = 9223372036854775807L
                let v80 : int8 = 24y
                let v81 : int64 = 4738381338321616896L
                let v82 : string = method35(v79, v80, v81)
                method15(v73, v74, v75, v78, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v1 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method37 () : uint8 =
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
    let v8 : (uint8 -> int32) = int32
    let v9 : int32 = v8 1uy
    let v10 : (uint8 -> int32) = int32
    let v11 : int32 = v10 7uy
    let v12 : int32 = v7.Next (v9, v11)
    let v13 : uint8 = v12 |> uint8 
    let _v0 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : (unit -> System.Random) = System.Random 
    let v17 : System.Random = v16 ()
    let v18 : (uint8 -> int32) = int32
    let v19 : int32 = v18 1uy
    let v20 : (uint8 -> int32) = int32
    let v21 : int32 = v20 7uy
    let v22 : int32 = v17.Next (v19, v21)
    let v23 : uint8 = v22 |> uint8 
    let _v0 = v23 
    #endif
#else
    let v26 : (unit -> System.Random) = System.Random 
    let v27 : System.Random = v26 ()
    let v28 : (uint8 -> int32) = int32
    let v29 : int32 = v28 1uy
    let v30 : (uint8 -> int32) = int32
    let v31 : int32 = v30 7uy
    let v32 : int32 = v27.Next (v29, v31)
    let v33 : uint8 = v32 |> uint8 
    let _v0 = v33 
    #endif
    let v36 : uint8 = _v0 
    v36
and method39 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure17(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "power"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure17(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure17(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure17(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure17(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "acc"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure17(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure17(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure17(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure17(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "roll"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure17(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure17(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure17(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "value"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure17(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure17(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure17(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure17(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and closure94 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 23y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure95 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 22y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure96 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 21y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure97 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 20y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure98 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 19y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure99 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 18y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure100 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 17y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure101 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 16y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure102 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 15y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 14y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 13y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 12y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 11y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 10y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 9y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 8y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 7y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 6y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 5y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 4y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 3y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 2y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 1y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and closure117 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure5()
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
        let v76 : string = method7(v58, v59, v60, v61, v62, v63)
        let v77 : string = method11()
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v85 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : int8 = 0y
                let v83 : string = method39(v82, v0, v1, v2)
                method15(v76, v77, v78, v81, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v4 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method16(v85, v101, v102, v103, v104, v105, v106)
and method64 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure17(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure17(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure17(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure17(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure17(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure17(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure17(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure17(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure17(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure17(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure17(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure17(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure118 (v0 : int64, v1 : int64) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = -1y
                let v82 : string = method64(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method63 (v0 : UH1, v1 : int64) : US8 =
    let v2 : int64 = v1 + 1L
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure118(v1, v2)
    let v5 : unit = (fun () -> v4 (); v3) ()
    US8_0(v2, v0)
and method65 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure17(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "power"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure17(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure17(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure17(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure17(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "acc"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure17(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure17(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure17(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure17(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "roll"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure17(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure17(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure17(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure17(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and closure119 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 0y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method62 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure117(v1, v3, v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            let v127 : int64 = v1 + v7
            method63(v4, v127)
        else
            let v129 : unit = ()
            let v130 : (unit -> unit) = closure119(v1, v3)
            let v131 : unit = (fun () -> v130 (); v129) ()
            method63(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure120 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 1y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method61 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure116(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method62(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure120(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method62(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure121 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 2y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method60 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure115(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method61(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure121(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method61(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure122 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 3y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method59 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure114(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method60(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure122(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method60(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure123 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 4y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method58 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure113(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method59(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure123(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method59(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure124 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 5y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method57 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure112(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method58(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure124(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method58(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure125 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 6y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method56 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure111(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method57(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure125(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method57(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure126 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 7y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method55 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure110(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method56(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure126(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method56(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure127 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 8y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method54 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure109(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method55(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure127(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method55(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 9y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method53 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure108(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method54(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure128(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method54(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 10y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method52 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure107(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method53(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure129(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method53(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 11y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method51 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure106(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method52(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure130(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method52(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 12y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method50 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure105(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method51(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure131(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method51(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 13y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method49 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure104(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method50(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure132(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method50(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 14y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method48 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure103(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method49(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure133(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method49(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 15y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method47 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure102(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method48(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure134(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method48(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 16y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method46 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure101(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method47(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure135(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method47(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 17y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method45 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure100(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method46(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure136(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method46(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 18y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method44 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure99(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method45(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure137(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method45(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 19y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method43 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure98(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method44(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure138(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method44(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 20y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method42 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure97(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method43(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure139(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method43(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 21y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method41 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure96(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method42(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure140(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method42(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 22y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method40 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure95(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method41(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure141(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method41(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and closure142 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure5()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method7(v57, v58, v59, v60, v61, v62)
        let v76 : string = method11()
        let v77 : string = $"dice.accumulate_dice_rolls"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int8 = 23y
                let v82 : string = method65(v81, v0, v1)
                method15(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method16(v84, v100, v101, v102, v103, v104, v105)
and method38 (v0 : UH1, v1 : int64) : US8 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : unit = ()
            let v10 : (unit -> unit) = closure94(v1, v3, v8)
            let v11 : unit = (fun () -> v10 (); v9) ()
            let v128 : int64 = v1 + v8
            method40(v4, v128)
        else
            let v130 : unit = ()
            let v131 : (unit -> unit) = closure142(v1, v3)
            let v132 : unit = (fun () -> v131 (); v130) ()
            method40(v4, v1)
    | UH1_0 -> (* Nil *)
        US8_1
and method36 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method37()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method36(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US8 = method38(v0, v7)
        match v8 with
        | US8_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method37()
                let v13 : uint8 = method37()
                let v14 : uint8 = method37()
                let v15 : uint8 = method37()
                let v16 : uint8 = method37()
                let v17 : uint8 = method37()
                let v18 : uint8 = method37()
                let v19 : uint8 = method37()
                let v20 : uint8 = method37()
                let v21 : uint8 = method37()
                let v22 : uint8 = method37()
                let v23 : uint8 = method37()
                let v24 : uint8 = method37()
                let v25 : uint8 = method37()
                let v26 : uint8 = method37()
                let v27 : uint8 = method37()
                let v28 : uint8 = method37()
                let v29 : uint8 = method37()
                let v30 : uint8 = method37()
                let v31 : uint8 = method37()
                let v32 : uint8 = method37()
                let v33 : uint8 = method37()
                let v34 : uint8 = method37()
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
                method36(v58, v59)
        | _ ->
            let v62 : uint8 = method37()
            let v63 : uint8 = method37()
            let v64 : uint8 = method37()
            let v65 : uint8 = method37()
            let v66 : uint8 = method37()
            let v67 : uint8 = method37()
            let v68 : uint8 = method37()
            let v69 : uint8 = method37()
            let v70 : uint8 = method37()
            let v71 : uint8 = method37()
            let v72 : uint8 = method37()
            let v73 : uint8 = method37()
            let v74 : uint8 = method37()
            let v75 : uint8 = method37()
            let v76 : uint8 = method37()
            let v77 : uint8 = method37()
            let v78 : uint8 = method37()
            let v79 : uint8 = method37()
            let v80 : uint8 = method37()
            let v81 : uint8 = method37()
            let v82 : uint8 = method37()
            let v83 : uint8 = method37()
            let v84 : uint8 = method37()
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
            method36(v108, v109)
and method66 (v0 : int64) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure17(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "result"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure17(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure17(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure17(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure17(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and closure143 (v0 : int64) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure5()
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
        let v74 : string = method7(v56, v57, v58, v59, v60, v61)
        let v75 : string = method11()
        let v76 : string = $"dice.main"
        let v77 : bool = v76 = ""
        let v82 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = method66(v0)
                method15(v74, v75, v76, v79, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v2 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method16(v82, v98, v99, v100, v101, v102, v103)
and closure92 () (v0 : (string [])) : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure93()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v122 : UH1 = UH1_0
    let v123 : int8 = 0y
    let v124 : int64 = method36(v122, v123)
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure143(v124)
    let v127 : unit = (fun () -> v126 (); v125) ()
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure19()
let roll_progressively x = v2 x
let v3 : (uint64 -> (UH1 -> uint64 option)) = closure90()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure92()
let main args = v4 args
()
