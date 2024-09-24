#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
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
#endif
type std_string_String = class end
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
#endif
type Str = class end
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
and [<Struct>] US4 =
    | US4_0 of f0_0 : uint64 * f0_1 : UH0
    | US4_1
and UH1 =
    | UH1_0 of uint64 * (unit -> UH1)
    | UH1_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : uint64
    | US5_1
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
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let v71 : string = "fable_library_rust::String_::fromString($0)"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = "env!(\"" + v65 + "\")"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : string = "String::from($0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let _v66 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "env!(\"" + v65 + "\")"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79 
    let v81 : string = "String::from($0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _v66 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = null |> unbox<string>
    let _v66 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : string = null |> unbox<string>
    let _v66 = v88 
    #endif
#else
    let v91 : string = null |> unbox<string>
    let _v66 = v91 
    #endif
    let v94 : string = _v66 
    let v99 : string = "True"
    let v100 : bool = v94 <> v99 
    let v109 : US3 =
        if v100 then
            US3_1
        else
            let v104 : string = $"near_sdk::env::block_timestamp()"
            let v105 : uint64 = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : (uint64 -> int64) = int64
            let v107 : int64 = v106 v105
            US3_0(v107)
    let v110 : US2 = US2_1
    let _v1 = struct (v110, v109) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : string = method1()
    let v112 : string = method2(v111)
    
    
    
    
    
    let v113 : bool = "Verbose" = v112
    let v117 : US2 =
        if v113 then
            let v114 : US0 = US0_0
            US2_0(v114)
        else
            US2_1
    let v158 : US2 =
        match v117 with
        | US2_1 -> (* None *)
            let v120 : bool = "Debug" = v112
            let v124 : US2 =
                if v120 then
                    let v121 : US0 = US0_1
                    US2_0(v121)
                else
                    US2_1
            match v124 with
            | US2_1 -> (* None *)
                let v127 : bool = "Info" = v112
                let v131 : US2 =
                    if v127 then
                        let v128 : US0 = US0_2
                        US2_0(v128)
                    else
                        US2_1
                match v131 with
                | US2_1 -> (* None *)
                    let v134 : bool = "Warning" = v112
                    let v138 : US2 =
                        if v134 then
                            let v135 : US0 = US0_3
                            US2_0(v135)
                        else
                            US2_1
                    match v138 with
                    | US2_1 -> (* None *)
                        let v141 : bool = "Critical" = v112
                        let v145 : US2 =
                            if v141 then
                                let v142 : US0 = US0_4
                                US2_0(v142)
                            else
                                US2_1
                        match v145 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v146) -> (* Some *)
                            US2_0(v146)
                    | US2_0(v139) -> (* Some *)
                        US2_0(v139)
                | US2_0(v132) -> (* Some *)
                    US2_0(v132)
            | US2_0(v125) -> (* Some *)
                US2_0(v125)
        | US2_0(v118) -> (* Some *)
            US2_0(v118)
    let v159 : string = method5()
    let v160 : string = method2(v159)
    let v161 : bool = v160 = "True"
    let v171 : US3 =
        if v161 then
            let v162 : System.DateTime = System.DateTime.Now
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v162
            US3_0(v166)
        else
            US3_1
    let _v1 = struct (v158, v171) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : string = method1()
    let v173 : string = method2(v172)
    
    
    
    
    
    let v174 : bool = "Verbose" = v173
    let v178 : US2 =
        if v174 then
            let v175 : US0 = US0_0
            US2_0(v175)
        else
            US2_1
    let v219 : US2 =
        match v178 with
        | US2_1 -> (* None *)
            let v181 : bool = "Debug" = v173
            let v185 : US2 =
                if v181 then
                    let v182 : US0 = US0_1
                    US2_0(v182)
                else
                    US2_1
            match v185 with
            | US2_1 -> (* None *)
                let v188 : bool = "Info" = v173
                let v192 : US2 =
                    if v188 then
                        let v189 : US0 = US0_2
                        US2_0(v189)
                    else
                        US2_1
                match v192 with
                | US2_1 -> (* None *)
                    let v195 : bool = "Warning" = v173
                    let v199 : US2 =
                        if v195 then
                            let v196 : US0 = US0_3
                            US2_0(v196)
                        else
                            US2_1
                    match v199 with
                    | US2_1 -> (* None *)
                        let v202 : bool = "Critical" = v173
                        let v206 : US2 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US2_0(v203)
                            else
                                US2_1
                        match v206 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v207) -> (* Some *)
                            US2_0(v207)
                    | US2_0(v200) -> (* Some *)
                        US2_0(v200)
                | US2_0(v193) -> (* Some *)
                    US2_0(v193)
            | US2_0(v186) -> (* Some *)
                US2_0(v186)
        | US2_0(v179) -> (* Some *)
            US2_0(v179)
    let v220 : string = method5()
    let v221 : string = method2(v220)
    let v222 : bool = v221 = "True"
    let v232 : US3 =
        if v222 then
            let v223 : System.DateTime = System.DateTime.Now
            let v226 : (System.DateTime -> int64) = _.Ticks
            let v227 : int64 = v226 v223
            US3_0(v227)
        else
            US3_1
    let _v1 = struct (v219, v232) 
    #endif
#else
    let v233 : string = method1()
    let v234 : string = method2(v233)
    
    
    
    
    
    let v235 : bool = "Verbose" = v234
    let v239 : US2 =
        if v235 then
            let v236 : US0 = US0_0
            US2_0(v236)
        else
            US2_1
    let v280 : US2 =
        match v239 with
        | US2_1 -> (* None *)
            let v242 : bool = "Debug" = v234
            let v246 : US2 =
                if v242 then
                    let v243 : US0 = US0_1
                    US2_0(v243)
                else
                    US2_1
            match v246 with
            | US2_1 -> (* None *)
                let v249 : bool = "Info" = v234
                let v253 : US2 =
                    if v249 then
                        let v250 : US0 = US0_2
                        US2_0(v250)
                    else
                        US2_1
                match v253 with
                | US2_1 -> (* None *)
                    let v256 : bool = "Warning" = v234
                    let v260 : US2 =
                        if v256 then
                            let v257 : US0 = US0_3
                            US2_0(v257)
                        else
                            US2_1
                    match v260 with
                    | US2_1 -> (* None *)
                        let v263 : bool = "Critical" = v234
                        let v267 : US2 =
                            if v263 then
                                let v264 : US0 = US0_4
                                US2_0(v264)
                            else
                                US2_1
                        match v267 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v268) -> (* Some *)
                            US2_0(v268)
                    | US2_0(v261) -> (* Some *)
                        US2_0(v261)
                | US2_0(v254) -> (* Some *)
                    US2_0(v254)
            | US2_0(v247) -> (* Some *)
                US2_0(v247)
        | US2_0(v240) -> (* Some *)
            US2_0(v240)
    let v281 : string = method5()
    let v282 : string = method2(v281)
    let v283 : bool = v282 = "True"
    let v293 : US3 =
        if v283 then
            let v284 : System.DateTime = System.DateTime.Now
            let v287 : (System.DateTime -> int64) = _.Ticks
            let v288 : int64 = v287 v284
            US3_0(v288)
        else
            US3_1
    let _v1 = struct (v280, v293) 
    #endif
    let struct (v294 : US2, v295 : US3) = _v1 
    let v359 : Mut0 = {l0 = 1L} : Mut0
    let v360 : (string -> unit) = closure4()
    let v361 : Mut1 = {l0 = v360} : Mut1
    let v362 : Mut2 = {l0 = true} : Mut2
    let v363 : string = ""
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v367 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v365) -> (* Some *)
            v365
    let v368 : Mut4 = {l0 = v367} : Mut4
    let v375 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v373 : int64 option = None
            v373
        | US3_0(v369) -> (* Some *)
            let v370 : int64 option = Some v369 
            v370
    struct (v359, v361, v362, v364, v368, v375)
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
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_blue"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[94m"
    let v51 : string = method11()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[94m"
    let v55 : string = method11()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[94m"
    let v59 : string = method11()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
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
and method14 (v0 : string, v1 : string, v2 : string, v3 : int64, v4 : string) : string =
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
    let v26 : string = "&*$0"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = $"$0.chars()"
    let v29 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0"
    let v31 : _ = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "$0.collect::<Vec<_>>()"
    let v33 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v35 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "String::from_iter($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 }).collect::<Vec<_>>()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_vec_map"
    let v45 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "$0.len()"
    let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : (unativeint -> int32) = int32
    let v49 : int32 = v48 v47
    let v50 : string = ""
    let v51 : bool = v0 <> v50 
    let v55 : bool =
        if v51 then
            let v54 : bool = v49 <= 1
            v54
        else
            false
    if v55 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v50
        let v56 : string = "true; $0.into_iter().for_each(|x| { //"
        let v57 : bool = Fable.Core.RustInterop.emitRustExpr v45 v56 
        let v58 : string = "x"
        let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v61 : bool = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v62 : string = $"true"
        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
        let v64 : string = "true; }); //"
        let v65 : bool = Fable.Core.RustInterop.emitRustExpr () v64 
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
    let v66 : (string -> unit) = v2.l0
    v66 v0
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
        let v76 : string = $"dice_contract.contribute_seed"
        let v77 : bool = v76 = ""
        let v85 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = $"%A{v0}"
                let v83 : string = method12(v80)
                method14(v74, v75, v76, v79, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v2 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method15(v85, v101, v102, v103, v104, v105, v106)
and method16 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : string, v9 : string, v10 : unativeint, v11 : string, v12 : string, v13 : string) : string =
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
    let v564 : string = "rolls_list_log"
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
and closure10 (v0 : Vec<uint8>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : Vec<uint8>, v11 : unativeint, v12 : Vec<uint8>, v13 : Vec<uint8>) () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure2()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v30 : Mut0, v31 : Mut1, v32 : Mut2, v33 : Mut3, v34 : Mut4, v35 : int64 option) = TraceState.trace_state.Value
    let v48 : US0 = v34.l0
    let v49 : bool = v32.l0
    let v50 : bool = v49 = false
    let v53 : bool =
        if v50 then
            false
        else
            let v51 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v48
            let v52 : bool = 1 >= v51
            v52
    if v53 then
        let v54 : unit = ()
        let v55 : unit = (fun () -> v15 (); v54) ()
        let struct (v69 : Mut0, v70 : Mut1, v71 : Mut2, v72 : Mut3, v73 : Mut4, v74 : int64 option) = TraceState.trace_state.Value
        let v87 : string = method6(v69, v70, v71, v72, v73, v74)
        let v88 : string = method10()
        let v89 : string = $"dice_contract.generate_random_number"
        let v90 : bool = v89 = ""
        let v115 : string =
            if v90 then
                let v91 : string = ""
                v91
            else
                let v92 : int64 = v69.l0
                let v93 : string = $"%A{v8}"
                let v96 : string = $"v9.to_string()"
                let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v96 
                let v98 : string = $"%A{v4}"
                let v101 : string = $"%A{v0}"
                let v104 : string = $"%A{v10}"
                let v107 : string = $"%A{v12}"
                let v110 : string = $"%A{v13}"
                let v113 : string = method16(v3, v1, v2, v5, v6, v7, v93, v97, v98, v101, v11, v104, v107, v110)
                method14(v87, v88, v89, v92, v113)
        let v116 : unit = ()
        let v117 : unit = (fun () -> v15 (); v116) ()
        let struct (v131 : Mut0, v132 : Mut1, v133 : Mut2, v134 : Mut3, v135 : Mut4, v136 : int64 option) = TraceState.trace_state.Value
        method15(v115, v131, v132, v133, v134, v135, v136)
and closure11 () () : unit =
    ()
and method17 () : (unit -> unit) =
    closure11()
and method18 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : unit =
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
    let v26 : string = "&*$0"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = $"$0.chars()"
    let v29 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0"
    let v31 : _ = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "$0.collect::<Vec<_>>()"
    let v33 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v35 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "String::from_iter($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 }).collect::<Vec<_>>()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_vec_map"
    let v45 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "$0.len()"
    let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : (unativeint -> int32) = int32
    let v49 : int32 = v48 v47
    let v50 : bool = v11 <> v11 
    let v54 : bool =
        if v50 then
            let v53 : bool = v49 <= 1
            v53
        else
            false
    if v54 then
        v3.l0 <- v25
        ()
    else
        v3.l0 <- v11
        let v55 : string = "true; $0.into_iter().for_each(|x| { //"
        let v56 : bool = Fable.Core.RustInterop.emitRustExpr v45 v55 
        let v57 : string = "x"
        let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v57 
        let v59 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v60 : bool = Fable.Core.RustInterop.emitRustExpr v58 v59 
        let v61 : string = $"true"
        let v62 : bool = Fable.Core.RustInterop.emitRustExpr () v61 
        let v63 : string = "true; }); //"
        let v64 : bool = Fable.Core.RustInterop.emitRustExpr () v63 
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
    let v65 : (string -> unit) = v1.l0
    v65 v11
and closure12 (v0 : (unit -> unit)) () : unit =
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
        method18(v91, v92, v93, v94, v95, v96)
and closure14 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure13 () (v0 : uint8) : (UH0 -> UH0) =
    closure14(v0)
and method19 () : (uint8 -> (UH0 -> UH0)) =
    closure13()
and method20 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method20(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method22 (v0 : int8, v1 : uint64, v2 : uint64) : string =
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
and closure15 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
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
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v84 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = method22(v1, v0, v2)
                method14(v76, v77, v78, v81, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v4 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method15(v84, v100, v101, v102, v103, v104, v105)
and closure79 () () : UH1 =
    UH1_1
and closure78 () () : UH1 =
    let v0 : (unit -> UH1) = closure79()
    UH1_0(9223372036854775808UL, v0)
and closure77 () () : UH1 =
    let v0 : (unit -> UH1) = closure78()
    UH1_0(4611686018427387904UL, v0)
and closure76 () () : UH1 =
    let v0 : (unit -> UH1) = closure77()
    UH1_0(6917529027641081856UL, v0)
and closure75 () () : UH1 =
    let v0 : (unit -> UH1) = closure76()
    UH1_0(1152921504606846976UL, v0)
and closure74 () () : UH1 =
    let v0 : (unit -> UH1) = closure75()
    UH1_0(15564440312192434176UL, v0)
and closure73 () () : UH1 =
    let v0 : (unit -> UH1) = closure74()
    UH1_0(11817445422220181504UL, v0)
and closure72 () () : UH1 =
    let v0 : (unit -> UH1) = closure73()
    UH1_0(5044031582654955520UL, v0)
and closure71 () () : UH1 =
    let v0 : (unit -> UH1) = closure72()
    UH1_0(6989586621679009792UL, v0)
and closure70 () () : UH1 =
    let v0 : (unit -> UH1) = closure71()
    UH1_0(16537217831704461312UL, v0)
and closure69 () () : UH1 =
    let v0 : (unit -> UH1) = closure70()
    UH1_0(11979575008805519360UL, v0)
and closure68 () () : UH1 =
    let v0 : (unit -> UH1) = closure69()
    UH1_0(14294425217273954304UL, v0)
and closure67 () () : UH1 =
    let v0 : (unit -> UH1) = closure68()
    UH1_0(2382404202878992384UL, v0)
and closure66 () () : UH1 =
    let v0 : (unit -> UH1) = closure67()
    UH1_0(6545982058383015936UL, v0)
and closure65 () () : UH1 =
    let v0 : (unit -> UH1) = closure66()
    UH1_0(10314369046585278464UL, v0)
and closure64 () () : UH1 =
    let v0 : (unit -> UH1) = closure65()
    UH1_0(4793518853382471680UL, v0)
and closure63 () () : UH1 =
    let v0 : (unit -> UH1) = closure64()
    UH1_0(3873377154515337216UL, v0)
and closure62 () () : UH1 =
    let v0 : (unit -> UH1) = closure63()
    UH1_0(645562859085889536UL, v0)
and closure61 () () : UH1 =
    let v0 : (unit -> UH1) = closure62()
    UH1_0(107593809847648256UL, v0)
and closure60 () () : UH1 =
    let v0 : (unit -> UH1) = closure61()
    UH1_0(3092389647259533312UL, v0)
and closure59 () () : UH1 =
    let v0 : (unit -> UH1) = closure60()
    UH1_0(9738770311398031360UL, v0)
and closure58 () () : UH1 =
    let v0 : (unit -> UH1) = closure59()
    UH1_0(16995415113324298240UL, v0)
and closure57 () () : UH1 =
    let v0 : (unit -> UH1) = closure58()
    UH1_0(8981483876790566912UL, v0)
and closure56 () () : UH1 =
    let v0 : (unit -> UH1) = closure57()
    UH1_0(13794743361938128896UL, v0)
and closure55 () () : UH1 =
    let v0 : (unit -> UH1) = closure56()
    UH1_0(2299123893656354816UL, v0)
and closure54 () () : UH1 =
    let v0 : (unit -> UH1) = closure55()
    UH1_0(3457644661227651072UL, v0)
and closure53 () () : UH1 =
    let v0 : (unit -> UH1) = closure54()
    UH1_0(576274110204608512UL, v0)
and closure52 () () : UH1 =
    let v0 : (unit -> UH1) = closure53()
    UH1_0(6244960376270618624UL, v0)
and closure51 () () : UH1 =
    let v0 : (unit -> UH1) = closure52()
    UH1_0(13338656111851470848UL, v0)
and closure50 () () : UH1 =
    let v0 : (unit -> UH1) = closure51()
    UH1_0(14520938734448279552UL, v0)
and closure49 () () : UH1 =
    let v0 : (unit -> UH1) = closure50()
    UH1_0(14717985838214414336UL, v0)
and closure48 () () : UH1 =
    let v0 : (unit -> UH1) = closure49()
    UH1_0(5527454985320660992UL, v0)
and closure47 () () : UH1 =
    let v0 : (unit -> UH1) = closure48()
    UH1_0(16293529225644736512UL, v0)
and closure46 () () : UH1 =
    let v0 : (unit -> UH1) = closure47()
    UH1_0(11938960241128898560UL, v0)
and closure45 () () : UH1 =
    let v0 : (unit -> UH1) = closure46()
    UH1_0(8138741398091333632UL, v0)
and closure44 () () : UH1 =
    let v0 : (unit -> UH1) = closure45()
    UH1_0(7505371590918406144UL, v0)
and closure43 () () : UH1 =
    let v0 : (unit -> UH1) = closure44()
    UH1_0(16623181993244360704UL, v0)
and closure42 () () : UH1 =
    let v0 : (unit -> UH1) = closure43()
    UH1_0(8919445023443910656UL, v0)
and closure41 () () : UH1 =
    let v0 : (unit -> UH1) = closure42()
    UH1_0(4561031516192243712UL, v0)
and closure40 () () : UH1 =
    let v0 : (unit -> UH1) = closure41()
    UH1_0(9983543956220149760UL, v0)
and closure39 () () : UH1 =
    let v0 : (unit -> UH1) = closure40()
    UH1_0(4738381338321616896UL, v0)
and closure38 () () : UH1 =
    let v0 : (unit -> UH1) = closure39()
    UH1_0(789730223053602816UL, v0)
and closure37 () () : UH1 =
    let v0 : (unit -> UH1) = closure38()
    UH1_0(131621703842267136UL, v0)
and closure36 () () : UH1 =
    let v0 : (unit -> UH1) = closure37()
    UH1_0(21936950640377856UL, v0)
and closure35 () () : UH1 =
    let v0 : (unit -> UH1) = closure36()
    UH1_0(3656158440062976UL, v0)
and closure34 () () : UH1 =
    let v0 : (unit -> UH1) = closure35()
    UH1_0(609359740010496UL, v0)
and closure33 () () : UH1 =
    let v0 : (unit -> UH1) = closure34()
    UH1_0(101559956668416UL, v0)
and closure32 () () : UH1 =
    let v0 : (unit -> UH1) = closure33()
    UH1_0(16926659444736UL, v0)
and closure31 () () : UH1 =
    let v0 : (unit -> UH1) = closure32()
    UH1_0(2821109907456UL, v0)
and closure30 () () : UH1 =
    let v0 : (unit -> UH1) = closure31()
    UH1_0(470184984576UL, v0)
and closure29 () () : UH1 =
    let v0 : (unit -> UH1) = closure30()
    UH1_0(78364164096UL, v0)
and closure28 () () : UH1 =
    let v0 : (unit -> UH1) = closure29()
    UH1_0(13060694016UL, v0)
and closure27 () () : UH1 =
    let v0 : (unit -> UH1) = closure28()
    UH1_0(2176782336UL, v0)
and closure26 () () : UH1 =
    let v0 : (unit -> UH1) = closure27()
    UH1_0(362797056UL, v0)
and closure25 () () : UH1 =
    let v0 : (unit -> UH1) = closure26()
    UH1_0(60466176UL, v0)
and closure24 () () : UH1 =
    let v0 : (unit -> UH1) = closure25()
    UH1_0(10077696UL, v0)
and closure23 () () : UH1 =
    let v0 : (unit -> UH1) = closure24()
    UH1_0(1679616UL, v0)
and closure22 () () : UH1 =
    let v0 : (unit -> UH1) = closure23()
    UH1_0(279936UL, v0)
and closure21 () () : UH1 =
    let v0 : (unit -> UH1) = closure22()
    UH1_0(46656UL, v0)
and closure20 () () : UH1 =
    let v0 : (unit -> UH1) = closure21()
    UH1_0(7776UL, v0)
and closure19 () () : UH1 =
    let v0 : (unit -> UH1) = closure20()
    UH1_0(1296UL, v0)
and closure18 () () : UH1 =
    let v0 : (unit -> UH1) = closure19()
    UH1_0(216UL, v0)
and closure17 () () : UH1 =
    let v0 : (unit -> UH1) = closure18()
    UH1_0(36UL, v0)
and closure16 () () : UH1 =
    let v0 : (unit -> UH1) = closure17()
    UH1_0(6UL, v0)
and method23 (v0 : int8, v1 : UH1) : US5 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US5_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH1 = v3 ()
            method23(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US5_1
and method24 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
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
and closure80 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
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
        let v79 : string = $"dice.accumulate_dice_rolls"
        let v80 : bool = v79 = ""
        let v85 : string =
            if v80 then
                let v81 : string = ""
                v81
            else
                let v82 : int64 = v59.l0
                let v83 : string = method24(v1, v0, v2, v3)
                method14(v77, v78, v79, v82, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v5 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method15(v85, v101, v102, v103, v104, v105, v106)
and method25 (v0 : int8, v1 : uint64, v2 : uint8) : string =
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
and closure81 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
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
        let v78 : string = $"dice.accumulate_dice_rolls"
        let v79 : bool = v78 = ""
        let v84 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = method25(v1, v0, v2)
                method14(v76, v77, v78, v81, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v4 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method15(v84, v100, v101, v102, v103, v104, v105)
and method21 (v0 : int8, v1 : UH0, v2 : uint64) : US4 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure15(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US4_0(v4, v1)
    else
        match v1 with
        | UH0_1(v125, v126) -> (* Cons *)
            let v127 : bool = v125 > 1uy
            if v127 then
                let v128 : uint64 = 1UL
                let v129 : (unit -> UH1) = closure16()
                let v130 : UH1 = UH1_0(v128, v129)
                let v131 : US5 = method23(v0, v130)
                let v135 : uint64 =
                    match v131 with
                    | US5_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US5_0(v132) -> (* Some *)
                        v132
                let v136 : uint8 = v125 - 1uy
                let v137 : uint64 = uint64 v136
                let v138 : uint64 = v137 * v135
                let v139 : unit = ()
                let v140 : (unit -> unit) = closure80(v2, v0, v125, v138)
                let v141 : unit = (fun () -> v140 (); v139) ()
                let v257 : uint64 = v2 + v138
                let v258 : int8 = v0 - 1y
                method21(v258, v126, v257)
            else
                let v260 : unit = ()
                let v261 : (unit -> unit) = closure81(v2, v0, v125)
                let v262 : unit = (fun () -> v261 (); v260) ()
                let v378 : int8 = v0 - 1y
                method21(v378, v126, v2)
        | UH0_0 -> (* Nil *)
            US4_1
and method26 (v0 : uint64, v1 : string, v2 : uint64 option) : string =
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
    let v99 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v99 = v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{:#?}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v108 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let _v99 = v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : string = $"%A{v2}"
    let _v99 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : string = $"%A{v2}"
    let _v99 = v115 
    #endif
#else
    let v118 : string = $"%A{v2}"
    let _v99 = v118 
    #endif
    let v121 : string = _v99 
    let v126 : string = $"{v121}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure6(v4, v126)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v134 : string = " }"
    let v135 : string = $"{v134}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure6(v4, v135)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v143 : string = v4.l0
    v143
and method27 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
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
and closure82 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
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
        let v82 : string = method26(v0, v79, v2)
        let v83 : string = method27(v76, v77, v78, v82)
        let v84 : unit = ()
        let v85 : unit = (fun () -> v4 (); v84) ()
        let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : Mut4, v104 : int64 option) = TraceState.trace_state.Value
        method15(v83, v99, v100, v101, v102, v103, v104)
and method28 () : (unit -> unit) =
    closure11()
and closure83 (v0 : (unit -> unit)) () : unit =
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
        method18(v91, v92, v93, v94, v95, v96)
and closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "pub struct Util {} //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "impl Util { //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "    fn stream_u8_to_list( //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "        s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH0>, //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = "    ) -> dice_contract_lib::Dice::UH1 { //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = "        match s.as_ref() { //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "            dice_contract_lib::Dice::UH0::UH0_0(n, f) => { //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "                dice_contract_lib::Dice::UH1::UH1_1( //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "                    *n, //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "                    Self::stream_u8_to_list(f()).into() //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "                ) //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "            dice_contract_lib::Dice::UH0::UH0_1 => dice_contract_lib::Dice::UH1::UH1_0, //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "    fn list_u8_to_vec( //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "        s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH1>, //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "    ) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "        match s.as_ref() { //"
    Fable.Core.RustInterop.emitRustExpr () v19 
    let v20 : string = "            dice_contract_lib::Dice::UH1::UH1_1(n, f) => { //"
    Fable.Core.RustInterop.emitRustExpr () v20 
    let v21 : string = "                let mut v = Self::list_u8_to_vec(f.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "                v.insert(0, *n); //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "                v //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "            dice_contract_lib::Dice::UH1::UH1_0 => vec![], //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "    fn vec_u8_to_list(v: Vec<u8>) -> dice_contract_lib::Dice::UH1 { //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "        v.iter() //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "            .rev() //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "            .fold(dice_contract_lib::Dice::UH1::UH1_0, |acc, x| { //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "                dice_contract_lib::Dice::UH1::UH1_1(*x, acc.into()) //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "            }) //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "    fn vec_u8_to_stream(v: Vec<u8>) -> dice_contract_lib::Dice::UH0 { //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "        v.iter() //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "            .rev() //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "            .fold(dice_contract_lib::Dice::UH0::UH0_1, |acc, x| { //"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "                dice_contract_lib::Dice::UH0::UH0_0( //"
    Fable.Core.RustInterop.emitRustExpr () v39 
    let v40 : string = "                    *x, //"
    Fable.Core.RustInterop.emitRustExpr () v40 
    let v41 : string = "                    fable_library_rust::Native_::Func0::new(move || acc.clone().into()), //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "                ) //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "            }) //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v48 
    let v49 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v49 
    let v50 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "pub struct OldState { //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "    version: u32, //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "    seeds: near_sdk::store::vec::Vector<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v54 
    let v55 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v55 
    let v56 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v56 
    let v57 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v57 
    let v58 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v58 
    let v59 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v59 
    let v60 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v60 
    let v61 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v61 
    let v62 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v62 
    let v63 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v66 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v66 
    let v67 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v68 
    let v69 : string = "        Self((old_state.version + 1, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v69 
    let v70 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v70 
    let v71 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v71 
    let v72 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v73 
    let v74 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v74 
    let v75 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v75 
    let v76 : string = "true; /*"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v81 : string = "true; */"
    let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
    let v83 : string = "seeds"
    let v84 : string = "b\"" + v83 + "\""
    let v85 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v84 
    let v86 : string = "near_sdk::store::vec::Vector::new(v85)"
    let v87 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr () v86 
    let _result = struct (2u, v87) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v88 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v88 
    let v89 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v89 
    let v90 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v90 
    let v91 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v95 
    let v96 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v96 
    let v97 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = $"&mut self.0.1"
    let v99 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"seed"
    let v101 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v100 
    let v102 : string = "v99.extend(v101); //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : unativeint = 100 |> unativeint 
    let v106 : string = "(v99.len() as i32) - v103 as i32"
    let v107 : int32 = Fable.Core.RustInterop.emitRustExpr () v106 
    let v108 : bool = v107 > 0
    if v108 then
        let v109 : string = "v99.drain(0..$0 as u32).collect()"
        let v110 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v107 v109 
        let v111 : unit = ()
        let v112 : (unit -> unit) = closure1(v110)
        let v113 : unit = (fun () -> v112 (); v111) ()
        ()
    let v232 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v232 
    let v233 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v233 
    let v234 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v234 
    let v235 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v235 
    let v236 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v237 : bool = Fable.Core.RustInterop.emitRustExpr () v236 
    let v238 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238 
    let v240 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v240 
    let v241 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v241 
    let v242 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v242 
    let v243 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v243 
    let v244 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v244 
    let v245 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v245 
    let v246 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v247 : bool = Fable.Core.RustInterop.emitRustExpr () v246 
    let v248 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v249 : bool = Fable.Core.RustInterop.emitRustExpr () v248 
    let v250 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v250 
    let v251 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v251 
    let v252 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v252 
    let v253 : string = $"key"
    let v254 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v253 
    let v255 : string = $"proof"
    let v256 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v255 
    let v257 : string = $"max"
    let v258 : uint64 = Fable.Core.RustInterop.emitRustExpr () v257 
    let v259 : string = $"&self.0.1"
    let v260 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v259 
    let v261 : string = $"v260.iter().map(|x| *x).collect::<Vec<u8>>()"
    let v262 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = $"near_sdk::env::random_seed()"
    let v264 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : string = $"near_sdk::env::block_timestamp()"
    let v266 : uint64 = Fable.Core.RustInterop.emitRustExpr () v265 
    let v267 : string = $"near_sdk::env::block_height()"
    let v268 : uint64 = Fable.Core.RustInterop.emitRustExpr () v267 
    let v269 : string = $"near_sdk::env::epoch_height()"
    let v270 : uint64 = Fable.Core.RustInterop.emitRustExpr () v269 
    let v271 : string = $"near_sdk::env::account_balance()"
    let v272 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : string = $"near_sdk::env::signer_account_id()"
    let v274 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v273 
    let v275 : string = $"v270.to_le_bytes()"
    let v276 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v275 
    let v277 : string = $"v276.to_vec()"
    let v278 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v277 
    let v279 : string = $"v268.to_le_bytes()"
    let v280 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v279 
    let v281 : string = $"v280.to_vec()"
    let v282 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v281 
    let v283 : string = $"v266.to_le_bytes()"
    let v284 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v283 
    let v285 : string = $"v284.to_vec()"
    let v286 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v285 
    let v287 : string = "$0.as_yoctonear()"
    let v288 : u128 = Fable.Core.RustInterop.emitRustExpr v272 v287 
    let v289 : string = $"v288.to_le_bytes()"
    let v290 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v289 
    let v291 : string = $"v290.to_vec()"
    let v292 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v291 
    let v293 : string = $"v274.as_bytes()"
    let v294 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v293 
    let v295 : string = $"v294.to_vec()"
    let v296 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v295 
    let v297 : string = $"$0.into_bytes()"
    let v298 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v256 v297 
    let v299 : string = $"$0.into_bytes()"
    let v300 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v254 v299 
    let v301 : (Vec<uint8> []) = [|v264; v262; v278; v282; v286; v292; v296; v298; v300|]
    let v302 : string = "$0.to_vec()"
    let v303 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v301 v302 
    let v304 : string = $"v303.concat()"
    let v305 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v304 
    let v306 : string = "$0.len()"
    let v307 : unativeint = Fable.Core.RustInterop.emitRustExpr v305 v306 
    let v308 : string = $"near_sdk::env::keccak512(&v305)"
    let v309 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v308 
    let v310 : string = "self.contribute_seed(v309.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v310 
    let v311 : string = "let hash_stream = Util::vec_u8_to_stream(v309.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v311 
    let v312 : string = "let rolls_list = Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)( //"
    Fable.Core.RustInterop.emitRustExpr () v312 
    let v313 : string = "    hash_stream.into(), //"
    Fable.Core.RustInterop.emitRustExpr () v313 
    let v314 : string = ")); //"
    Fable.Core.RustInterop.emitRustExpr () v314 
    let v315 : string = "Util::list_u8_to_vec(rolls_list.clone().into())"
    let v316 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v315 
    let v317 : unit = ()
    let v318 : (unit -> unit) = closure10(v262, v254, v256, v258, v264, v266, v268, v270, v272, v274, v305, v307, v309, v316)
    let v319 : unit = (fun () -> v318 (); v317) ()
    let v455 : string = "let sequential_roll = //"
    Fable.Core.RustInterop.emitRustExpr () v455 
    let v456 : string = "    dice_contract_lib::Dice::create_sequential_roller(rolls_list.into()); //"
    Fable.Core.RustInterop.emitRustExpr () v456 
    let v457 : string = "let result = dice_contract_lib::Dice::roll_progressively //"
    Fable.Core.RustInterop.emitRustExpr () v457 
    let v458 : string = "    (sequential_roll)(true)(max); //"
    Fable.Core.RustInterop.emitRustExpr () v458 
    let v459 : (unit -> unit) = method17()
    let v460 : unit = ()
    let v461 : (unit -> unit) = closure12(v459)
    let v462 : unit = (fun () -> v461 (); v460) ()
    let v571 : string = "result as u64"
    let v572 : uint64 = Fable.Core.RustInterop.emitRustExpr () v571 
    let v573 : string = "v572 //"
    Fable.Core.RustInterop.emitRustExpr () v573 
    let v574 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v574 
    let v575 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v575 
    let v576 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v576 
    let v577 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v577 
    let v578 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v578 
    let v579 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 4uy"
    let v580 : bool = Fable.Core.RustInterop.emitRustExpr () v579 
    let v581 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 4uy"
    let v582 : bool = Fable.Core.RustInterop.emitRustExpr () v581 
    let v583 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v583 
    let v584 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v584 
    let v585 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v585 
    let v586 : string = $"max"
    let v587 : uint64 = Fable.Core.RustInterop.emitRustExpr () v586 
    let v588 : string = $"rolls"
    let v589 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v588 
    let v590 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v591 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v589 v590 
    let v592 : uint8 list = v591 |> Array.toList
    let v593 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v594 : (uint8 -> (UH0 -> UH0)) = method19()
    let v595 : (uint8 list -> (UH0 -> UH0)) = v593 v594
    let v596 : (UH0 -> UH0) = v595 v592
    let v597 : UH0 = UH0_0
    let v598 : UH0 = v596 v597
    let v603 : int8 = 0y
    let v604 : int8 = method20(v598, v603)
    let v605 : int8 = v604 - 1y
    let v606 : uint64 = 0UL
    let v607 : US4 = method21(v605, v598, v606)
    let v617 : US5 =
        match v607 with
        | US4_0(v608, v609) -> (* Some *)
            let v610 : bool = v608 >= 1UL
            let v612 : bool =
                if v610 then
                    let v611 : bool = v608 <= v587
                    v611
                else
                    false
            if v612 then
                US5_0(v608)
            else
                US5_1
        | _ ->
            US5_1
    let v624 : uint64 option =
        match v617 with
        | US5_1 -> (* None *)
            let v622 : uint64 option = None
            v622
        | US5_0(v618) -> (* Some *)
            let v619 : uint64 option = Some v618 
            v619
    let v625 : unit = ()
    let v626 : (unit -> unit) = closure82(v587, v589, v624)
    let v627 : unit = (fun () -> v626 (); v625) ()
    let v742 : (unit -> unit) = method28()
    let v743 : unit = ()
    let v744 : (unit -> unit) = closure83(v742)
    let v745 : unit = (fun () -> v744 (); v743) ()
    let v854 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v624 v854 
    let v855 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v855 
    let v856 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v856 
    let v857 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v857 
    let v858 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 10uy / n: 2uy"
    let v859 : bool = Fable.Core.RustInterop.emitRustExpr () v858 
    let v860 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 10uy / n: 2uy"
    let v861 : bool = Fable.Core.RustInterop.emitRustExpr () v860 
    let v862 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v862 
    let v863 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v863 
    let v864 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v864 
    let v865 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v865 
    let v866 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v866 
    let v867 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v867 
    let v868 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v868 
    let v869 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v869 
    let v870 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v870 
    let v871 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v871 
    let v872 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v872 
    let v873 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 12uy / n: 1uy"
    let v874 : bool = Fable.Core.RustInterop.emitRustExpr () v873 
    let v875 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 12uy / n: 1uy"
    let v876 : bool = Fable.Core.RustInterop.emitRustExpr () v875 
    let v877 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v877 
    let v878 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v878 
    let v879 : string = "true; { (); // ?? / i': 1uy / n: 13uy"
    let v880 : bool = Fable.Core.RustInterop.emitRustExpr () v879 
    let v881 : string = "true; { (); // ?? / i': 2uy / n: 13uy"
    let v882 : bool = Fable.Core.RustInterop.emitRustExpr () v881 
    let v883 : string = "true; { (); // ?? / i': 3uy / n: 13uy"
    let v884 : bool = Fable.Core.RustInterop.emitRustExpr () v883 
    let v885 : string = "true; { (); // ?? / i': 4uy / n: 13uy"
    let v886 : bool = Fable.Core.RustInterop.emitRustExpr () v885 
    let v887 : string = "true; { (); // ?? / i': 5uy / n: 13uy"
    let v888 : bool = Fable.Core.RustInterop.emitRustExpr () v887 
    let v889 : string = "true; { (); // ?? / i': 6uy / n: 13uy"
    let v890 : bool = Fable.Core.RustInterop.emitRustExpr () v889 
    let v891 : string = "true; { (); // ?? / i': 7uy / n: 13uy"
    let v892 : bool = Fable.Core.RustInterop.emitRustExpr () v891 
    let v893 : string = "true; { (); // ?? / i': 8uy / n: 13uy"
    let v894 : bool = Fable.Core.RustInterop.emitRustExpr () v893 
    let v895 : string = "true; { (); // ?? / i': 9uy / n: 13uy"
    let v896 : bool = Fable.Core.RustInterop.emitRustExpr () v895 
    let v897 : string = "true; { (); // ?? / i': 10uy / n: 13uy"
    let v898 : bool = Fable.Core.RustInterop.emitRustExpr () v897 
    let v899 : string = "true; { (); // ?? / i': 11uy / n: 13uy"
    let v900 : bool = Fable.Core.RustInterop.emitRustExpr () v899 
    let v901 : string = "true; { (); // ?? / i': 12uy / n: 13uy"
    let v902 : bool = Fable.Core.RustInterop.emitRustExpr () v901 
    let v903 : string = "true; { (); // ?? / i': 13uy / n: 13uy"
    let v904 : bool = Fable.Core.RustInterop.emitRustExpr () v903 
    let v905 : string = "true; { { (); // ? / i': 14uy / n: 13uy"
    let v906 : bool = Fable.Core.RustInterop.emitRustExpr () v905 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
