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
and closure3 (v0 : US1 option ref) (v1 : US1 option) : US1 option ref =
    v0.Value <- v1 
    v0
and closure4 (v0 : string option, v1 : (US1 option -> US1 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : string = x
    let v3 : US1 = US1_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
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
    let v64 : US1 option = None
    let _v64 = ref v64 
    let v65 : US1 option ref = _v64 
    let v66 : (US1 option -> US1 option ref) = closure3(v65)
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure4(v61, v66)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : US1 option = _v64.Value 
    let v83 : US1 = US1_1
    let v84 : US1 = v72 |> Option.defaultValue v83 
    let v91 : string =
        match v84 with
        | US1_1 -> (* None *)
            let v89 : string = ""
            v89
        | US1_0(v88) -> (* Some *)
            v88
    let _v1 = v91 
    #endif
#else
    let v92 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v93 : string = v92 v0
    let mutable _v93 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v94 : (string -> string option) = Option.ofObj
    let v95 : string option = v94 v93
    v95 
    #else
    Some v93 
    #endif
    |> fun x -> _v93 <- Some x
    let v96 : string option = match _v93 with Some x -> x | None -> failwith "optionm'.of_obj / _v93=None"
    let v99 : US1 option = None
    let _v99 = ref v99 
    let v100 : US1 option ref = _v99 
    let v101 : (US1 option -> US1 option ref) = closure3(v100)
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure4(v96, v101)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : US1 option = _v99.Value 
    let v118 : US1 = US1_1
    let v119 : US1 = v107 |> Option.defaultValue v118 
    let v126 : string =
        match v119 with
        | US1_1 -> (* None *)
            let v124 : string = ""
            v124
        | US1_0(v123) -> (* Some *)
            v123
    let _v1 = v126 
    #endif
    let v127 : string = _v1 
    v127
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure5 () (v0 : string) : unit =
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
    let v50 : string = method4()
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
    let v159 : string = method4()
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
    let v220 : string = method4()
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
    let v281 : string = method4()
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
    let v359 : Mut0 = {l0 = 0L} : Mut0
    let v360 : (string -> unit) = closure5()
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
and closure6 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure7 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure8 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : int64 = x
    let v3 : US3 = US3_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method8 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure1 (v0 : Vec<uint8>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v2 (); v35) ()
    let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
    let v68 : US0 = v54.l0
    let v69 : bool = v52.l0
    let v70 : bool = v69 = false
    let v73 : bool =
        if v70 then
            false
        else
            let v71 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v68
            let v72 : bool = 1 >= v71
            v72
    if v73 then
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure6(v17)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        let v112 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : US3 option = None
        let _v113 = ref v113 
        let v114 : US3 option ref = _v113 
        let v115 : (US3 option -> US3 option ref) = closure7(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure8(v99, v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v121 : US3 option = _v113.Value 
        let v132 : US3 = US3_1
        let v133 : US3 = v121 |> Option.defaultValue v132 
        let v173 : System.DateTime =
            match v133 with
            | US3_1 -> (* None *)
                let v169 : System.DateTime = System.DateTime.Now
                v169
            | US3_0(v137) -> (* Some *)
                let v138 : System.DateTime = System.DateTime.Now
                let v141 : (System.DateTime -> int64) = _.Ticks
                let v142 : int64 = v141 v138
                let v145 : int64 = v142 - v137
                let v146 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v147 : System.TimeSpan = v146 v145
                let v150 : (System.TimeSpan -> int32) = _.Hours
                let v151 : int32 = v150 v147
                let v154 : (System.TimeSpan -> int32) = _.Minutes
                let v155 : int32 = v154 v147
                let v158 : (System.TimeSpan -> int32) = _.Seconds
                let v159 : int32 = v158 v147
                let v162 : (System.TimeSpan -> int32) = _.Milliseconds
                let v163 : int32 = v162 v147
                let v166 : System.DateTime = System.DateTime (1, 1, 1, v151, v155, v159, v163)
                v166
        let v174 : string = method5()
        let v177 : (string -> string) = v173.ToString
        let v178 : string = v177 v174
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure7(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure8(v99, v183)
        let v186 : unit = (fun () -> v185 (); v184) ()
        let v189 : US3 option = _v181.Value 
        let v200 : US3 = US3_1
        let v201 : US3 = v189 |> Option.defaultValue v200 
        let v241 : System.DateTime =
            match v201 with
            | US3_1 -> (* None *)
                let v237 : System.DateTime = System.DateTime.Now
                v237
            | US3_0(v205) -> (* Some *)
                let v206 : System.DateTime = System.DateTime.Now
                let v209 : (System.DateTime -> int64) = _.Ticks
                let v210 : int64 = v209 v206
                let v213 : int64 = v210 - v205
                let v214 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v215 : System.TimeSpan = v214 v213
                let v218 : (System.TimeSpan -> int32) = _.Hours
                let v219 : int32 = v218 v215
                let v222 : (System.TimeSpan -> int32) = _.Minutes
                let v223 : int32 = v222 v215
                let v226 : (System.TimeSpan -> int32) = _.Seconds
                let v227 : int32 = v226 v215
                let v230 : (System.TimeSpan -> int32) = _.Milliseconds
                let v231 : int32 = v230 v215
                let v234 : System.DateTime = System.DateTime (1, 1, 1, v219, v223, v227, v231)
                v234
        let v242 : string = method5()
        let v245 : (string -> string) = v241.ToString
        let v246 : string = v245 v242
        let _v112 = v246 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v249 : string = $"near_sdk::env::block_timestamp()"
        let v250 : uint64 = Fable.Core.RustInterop.emitRustExpr () v249 
        let v251 : US3 option = None
        let _v251 = ref v251 
        let v252 : US3 option ref = _v251 
        let v253 : (US3 option -> US3 option ref) = closure7(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure8(v99, v253)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v259 : US3 option = _v251.Value 
        let v270 : US3 = US3_1
        let v271 : US3 = v259 |> Option.defaultValue v270 
        let v280 : uint64 =
            match v271 with
            | US3_1 -> (* None *)
                v250
            | US3_0(v275) -> (* Some *)
                let v276 : (int64 -> uint64) = uint64
                let v277 : uint64 = v276 v275
                let v278 : uint64 = v250 - v277
                v278
        let v281 : uint64 = v280 / 1000000000UL
        let v282 : uint64 = v281 % 60UL
        let v283 : uint64 = v281 / 60UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v281 / 3600UL
        let v286 : uint64 = v285 % 24UL
        let v287 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v286, v284, v282) v287 
        let v289 : string = "fable_library_rust::String_::fromString($0)"
        let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
        let _v112 = v290 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v291 : US3 option = None
        let _v291 = ref v291 
        let v292 : US3 option ref = _v291 
        let v293 : (US3 option -> US3 option ref) = closure7(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure8(v99, v293)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v299 : US3 option = _v291.Value 
        let v310 : US3 = US3_1
        let v311 : US3 = v299 |> Option.defaultValue v310 
        let v351 : System.DateTime =
            match v311 with
            | US3_1 -> (* None *)
                let v347 : System.DateTime = System.DateTime.Now
                v347
            | US3_0(v315) -> (* Some *)
                let v316 : System.DateTime = System.DateTime.Now
                let v319 : (System.DateTime -> int64) = _.Ticks
                let v320 : int64 = v319 v316
                let v323 : int64 = v320 - v315
                let v324 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v325 : System.TimeSpan = v324 v323
                let v328 : (System.TimeSpan -> int32) = _.Hours
                let v329 : int32 = v328 v325
                let v332 : (System.TimeSpan -> int32) = _.Minutes
                let v333 : int32 = v332 v325
                let v336 : (System.TimeSpan -> int32) = _.Seconds
                let v337 : int32 = v336 v325
                let v340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v341 : int32 = v340 v325
                let v344 : System.DateTime = System.DateTime (1, 1, 1, v329, v333, v337, v341)
                v344
        let v352 : string = method6()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure7(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure8(v99, v361)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v367 : US3 option = _v359.Value 
        let v378 : US3 = US3_1
        let v379 : US3 = v367 |> Option.defaultValue v378 
        let v419 : System.DateTime =
            match v379 with
            | US3_1 -> (* None *)
                let v415 : System.DateTime = System.DateTime.Now
                v415
            | US3_0(v383) -> (* Some *)
                let v384 : System.DateTime = System.DateTime.Now
                let v387 : (System.DateTime -> int64) = _.Ticks
                let v388 : int64 = v387 v384
                let v391 : int64 = v388 - v383
                let v392 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v393 : System.TimeSpan = v392 v391
                let v396 : (System.TimeSpan -> int32) = _.Hours
                let v397 : int32 = v396 v393
                let v400 : (System.TimeSpan -> int32) = _.Minutes
                let v401 : int32 = v400 v393
                let v404 : (System.TimeSpan -> int32) = _.Seconds
                let v405 : int32 = v404 v393
                let v408 : (System.TimeSpan -> int32) = _.Milliseconds
                let v409 : int32 = v408 v393
                let v412 : System.DateTime = System.DateTime (1, 1, 1, v397, v401, v405, v409)
                v412
        let v420 : string = method6()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure7(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure8(v99, v429)
        let v432 : unit = (fun () -> v431 (); v430) ()
        let v435 : US3 option = _v427.Value 
        let v446 : US3 = US3_1
        let v447 : US3 = v435 |> Option.defaultValue v446 
        let v487 : System.DateTime =
            match v447 with
            | US3_1 -> (* None *)
                let v483 : System.DateTime = System.DateTime.Now
                v483
            | US3_0(v451) -> (* Some *)
                let v452 : System.DateTime = System.DateTime.Now
                let v455 : (System.DateTime -> int64) = _.Ticks
                let v456 : int64 = v455 v452
                let v459 : int64 = v456 - v451
                let v460 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v461 : System.TimeSpan = v460 v459
                let v464 : (System.TimeSpan -> int32) = _.Hours
                let v465 : int32 = v464 v461
                let v468 : (System.TimeSpan -> int32) = _.Minutes
                let v469 : int32 = v468 v461
                let v472 : (System.TimeSpan -> int32) = _.Seconds
                let v473 : int32 = v472 v461
                let v476 : (System.TimeSpan -> int32) = _.Milliseconds
                let v477 : int32 = v476 v461
                let v480 : System.DateTime = System.DateTime (1, 1, 1, v465, v469, v473, v477)
                v480
        let v488 : string = method6()
        let v491 : (string -> string) = v487.ToString
        let v492 : string = v491 v488
        let _v112 = v492 
        #endif
        let v495 : string = _v112 
        
        
        
        
        
        let v565 : string = "Debug"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_blue"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v584 = v595 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v596 : string = "inline_colorization::color_bright_blue"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v584 = v606 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v607 : string = "inline_colorization::color_bright_blue"
        let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v607 
        let v609 : string = "&*$0"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v609 
        let v611 : string = "inline_colorization::color_reset"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v611 
        let v613 : string = "\"{v608}{v610}{v612}\""
        let v614 : string = @$"format!(" + v613 + ")"
        let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "fable_library_rust::String_::fromString($0)"
        let v617 : string = Fable.Core.RustInterop.emitRustExpr v615 v616 
        let _v584 = v617 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v618 : string = "\u001b[94m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[94m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[94m"
        let v627 : string = method7()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = $"%A{v0}"
        let v640 : string = method8()
        let v641 : Mut3 = {l0 = v640} : Mut3
        let v642 : string = "{ "
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure9(v641, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = "seed_excess"
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure9(v641, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = " = "
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure9(v641, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = $"{v637}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure9(v641, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = " }"
        let v678 : string = $"{v677}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure9(v641, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = v641.l0
        let v687 : string = $"dice_contract.contribute_seed"
        let v688 : bool = v687 = ""
        let v745 : string =
            if v688 then
                let v689 : string = ""
                v689
            else
                let v690 : string = $"{v495} {v630} #{v636} %s{v687} / {v686}"
                let v693 : char list = []
                let v694 : (char list -> (char [])) = List.toArray
                let v695 : (char []) = v694 v693
                let v698 : string = v690.TrimStart v695 
                let v716 : char list = []
                let v717 : char list = '/' :: v716 
                let v720 : char list = ' ' :: v717 
                let v723 : (char list -> (char [])) = List.toArray
                let v724 : (char []) = v723 v720
                let v727 : string = v698.TrimEnd v724 
                v727
        let v746 : (string -> unit) = closure10()
        let v747 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v748 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v748 
        let _v747 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v749 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v749 
        let _v747 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v750 : string = v20.l0
        let v751 : bool = v750 = ""
        let v759 : string =
            if v751 then
                v745
            else
                let v752 : bool = v745 = ""
                if v752 then
                    let v753 : string = v20.l0
                    v753
                else
                    let v754 : string = v20.l0
                    let v755 : string = "\n"
                    let v756 : string = v754 + v755 
                    let v757 : string = v756 + v745 
                    v757
        let v760 : string = "&*$0"
        let v761 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v759 v760 
        let v762 : string = $"$0.chars()"
        let v763 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v761 v762 
        let v764 : string = "v763"
        let v765 : _ = Fable.Core.RustInterop.emitRustExpr () v764 
        let v766 : string = "v765.collect::<Vec<_>>()"
        let v767 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v769 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v767 v768 
        let v770 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v771 : bool = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let v772 : string = "x"
        let v773 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v772 
        let v774 : string = "String::from_iter($0)"
        let v775 : std_string_String = Fable.Core.RustInterop.emitRustExpr v773 v774 
        let v776 : string = "true; $0 }).collect::<Vec<_>>()"
        let v777 : bool = Fable.Core.RustInterop.emitRustExpr v775 v776 
        let v778 : string = "_vec_map"
        let v779 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v778 
        let v780 : string = "$0.len()"
        let v781 : unativeint = Fable.Core.RustInterop.emitRustExpr v779 v780 
        let v782 : (unativeint -> int32) = int32
        let v783 : int32 = v782 v781
        let v784 : string = ""
        let v785 : bool = v745 <> v784 
        let v789 : bool =
            if v785 then
                let v788 : bool = v783 <= 1
                v788
            else
                false
        if v789 then
            v20.l0 <- v759
            ()
        else
            v20.l0 <- v784
            let v790 : string = "true; $0.into_iter().for_each(|x| { //"
            let v791 : bool = Fable.Core.RustInterop.emitRustExpr v779 v790 
            let v792 : string = "x"
            let v793 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v792 
            let v794 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v793 v794 
            let v795 : string = $"true;"
            let v796 : bool = Fable.Core.RustInterop.emitRustExpr () v795 
            let v797 : string = "true; }}); { //"
            let v798 : bool = Fable.Core.RustInterop.emitRustExpr () v797 
            ()
        let _v747 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v746 v745
        let _v747 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v746 v745
        let _v747 = () 
        #endif
#else
        v746 v745
        let _v747 = () 
        #endif
        _v747 
        let v799 : (string -> unit) = v18.l0
        v799 v745
and closure12 (v0 : Vec<uint8>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : Vec<uint8>, v11 : unativeint, v12 : Vec<uint8>, v13 : Vec<uint8>) () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure2()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v30 : Mut0, v31 : Mut1, v32 : Mut2, v33 : Mut3, v34 : Mut4, v35 : int64 option) = TraceState.trace_state.Value
    let v48 : unit = ()
    let v49 : unit = (fun () -> v15 (); v48) ()
    let struct (v63 : Mut0, v64 : Mut1, v65 : Mut2, v66 : Mut3, v67 : Mut4, v68 : int64 option) = TraceState.trace_state.Value
    let v81 : US0 = v67.l0
    let v82 : bool = v65.l0
    let v83 : bool = v82 = false
    let v86 : bool =
        if v83 then
            false
        else
            let v84 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v81
            let v85 : bool = 1 >= v84
            v85
    if v86 then
        let v87 : unit = ()
        let v88 : (unit -> unit) = closure6(v30)
        let v89 : unit = (fun () -> v88 (); v87) ()
        let v92 : unit = ()
        let v93 : unit = (fun () -> v15 (); v92) ()
        let struct (v107 : Mut0, v108 : Mut1, v109 : Mut2, v110 : Mut3, v111 : Mut4, v112 : int64 option) = TraceState.trace_state.Value
        let v125 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v126 : US3 option = None
        let _v126 = ref v126 
        let v127 : US3 option ref = _v126 
        let v128 : (US3 option -> US3 option ref) = closure7(v127)
        let v129 : unit = ()
        let v130 : (unit -> unit) = closure8(v112, v128)
        let v131 : unit = (fun () -> v130 (); v129) ()
        let v134 : US3 option = _v126.Value 
        let v145 : US3 = US3_1
        let v146 : US3 = v134 |> Option.defaultValue v145 
        let v186 : System.DateTime =
            match v146 with
            | US3_1 -> (* None *)
                let v182 : System.DateTime = System.DateTime.Now
                v182
            | US3_0(v150) -> (* Some *)
                let v151 : System.DateTime = System.DateTime.Now
                let v154 : (System.DateTime -> int64) = _.Ticks
                let v155 : int64 = v154 v151
                let v158 : int64 = v155 - v150
                let v159 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v160 : System.TimeSpan = v159 v158
                let v163 : (System.TimeSpan -> int32) = _.Hours
                let v164 : int32 = v163 v160
                let v167 : (System.TimeSpan -> int32) = _.Minutes
                let v168 : int32 = v167 v160
                let v171 : (System.TimeSpan -> int32) = _.Seconds
                let v172 : int32 = v171 v160
                let v175 : (System.TimeSpan -> int32) = _.Milliseconds
                let v176 : int32 = v175 v160
                let v179 : System.DateTime = System.DateTime (1, 1, 1, v164, v168, v172, v176)
                v179
        let v187 : string = method5()
        let v190 : (string -> string) = v186.ToString
        let v191 : string = v190 v187
        let _v125 = v191 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v194 : US3 option = None
        let _v194 = ref v194 
        let v195 : US3 option ref = _v194 
        let v196 : (US3 option -> US3 option ref) = closure7(v195)
        let v197 : unit = ()
        let v198 : (unit -> unit) = closure8(v112, v196)
        let v199 : unit = (fun () -> v198 (); v197) ()
        let v202 : US3 option = _v194.Value 
        let v213 : US3 = US3_1
        let v214 : US3 = v202 |> Option.defaultValue v213 
        let v254 : System.DateTime =
            match v214 with
            | US3_1 -> (* None *)
                let v250 : System.DateTime = System.DateTime.Now
                v250
            | US3_0(v218) -> (* Some *)
                let v219 : System.DateTime = System.DateTime.Now
                let v222 : (System.DateTime -> int64) = _.Ticks
                let v223 : int64 = v222 v219
                let v226 : int64 = v223 - v218
                let v227 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v228 : System.TimeSpan = v227 v226
                let v231 : (System.TimeSpan -> int32) = _.Hours
                let v232 : int32 = v231 v228
                let v235 : (System.TimeSpan -> int32) = _.Minutes
                let v236 : int32 = v235 v228
                let v239 : (System.TimeSpan -> int32) = _.Seconds
                let v240 : int32 = v239 v228
                let v243 : (System.TimeSpan -> int32) = _.Milliseconds
                let v244 : int32 = v243 v228
                let v247 : System.DateTime = System.DateTime (1, 1, 1, v232, v236, v240, v244)
                v247
        let v255 : string = method5()
        let v258 : (string -> string) = v254.ToString
        let v259 : string = v258 v255
        let _v125 = v259 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v262 : string = $"near_sdk::env::block_timestamp()"
        let v263 : uint64 = Fable.Core.RustInterop.emitRustExpr () v262 
        let v264 : US3 option = None
        let _v264 = ref v264 
        let v265 : US3 option ref = _v264 
        let v266 : (US3 option -> US3 option ref) = closure7(v265)
        let v267 : unit = ()
        let v268 : (unit -> unit) = closure8(v112, v266)
        let v269 : unit = (fun () -> v268 (); v267) ()
        let v272 : US3 option = _v264.Value 
        let v283 : US3 = US3_1
        let v284 : US3 = v272 |> Option.defaultValue v283 
        let v293 : uint64 =
            match v284 with
            | US3_1 -> (* None *)
                v263
            | US3_0(v288) -> (* Some *)
                let v289 : (int64 -> uint64) = uint64
                let v290 : uint64 = v289 v288
                let v291 : uint64 = v263 - v290
                v291
        let v294 : uint64 = v293 / 1000000000UL
        let v295 : uint64 = v294 % 60UL
        let v296 : uint64 = v294 / 60UL
        let v297 : uint64 = v296 % 60UL
        let v298 : uint64 = v294 / 3600UL
        let v299 : uint64 = v298 % 24UL
        let v300 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v301 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v299, v297, v295) v300 
        let v302 : string = "fable_library_rust::String_::fromString($0)"
        let v303 : string = Fable.Core.RustInterop.emitRustExpr v301 v302 
        let _v125 = v303 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v304 : US3 option = None
        let _v304 = ref v304 
        let v305 : US3 option ref = _v304 
        let v306 : (US3 option -> US3 option ref) = closure7(v305)
        let v307 : unit = ()
        let v308 : (unit -> unit) = closure8(v112, v306)
        let v309 : unit = (fun () -> v308 (); v307) ()
        let v312 : US3 option = _v304.Value 
        let v323 : US3 = US3_1
        let v324 : US3 = v312 |> Option.defaultValue v323 
        let v364 : System.DateTime =
            match v324 with
            | US3_1 -> (* None *)
                let v360 : System.DateTime = System.DateTime.Now
                v360
            | US3_0(v328) -> (* Some *)
                let v329 : System.DateTime = System.DateTime.Now
                let v332 : (System.DateTime -> int64) = _.Ticks
                let v333 : int64 = v332 v329
                let v336 : int64 = v333 - v328
                let v337 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v338 : System.TimeSpan = v337 v336
                let v341 : (System.TimeSpan -> int32) = _.Hours
                let v342 : int32 = v341 v338
                let v345 : (System.TimeSpan -> int32) = _.Minutes
                let v346 : int32 = v345 v338
                let v349 : (System.TimeSpan -> int32) = _.Seconds
                let v350 : int32 = v349 v338
                let v353 : (System.TimeSpan -> int32) = _.Milliseconds
                let v354 : int32 = v353 v338
                let v357 : System.DateTime = System.DateTime (1, 1, 1, v342, v346, v350, v354)
                v357
        let v365 : string = method6()
        let v368 : (string -> string) = v364.ToString
        let v369 : string = v368 v365
        let _v125 = v369 
        #endif
#if FABLE_COMPILER_PYTHON
        let v372 : US3 option = None
        let _v372 = ref v372 
        let v373 : US3 option ref = _v372 
        let v374 : (US3 option -> US3 option ref) = closure7(v373)
        let v375 : unit = ()
        let v376 : (unit -> unit) = closure8(v112, v374)
        let v377 : unit = (fun () -> v376 (); v375) ()
        let v380 : US3 option = _v372.Value 
        let v391 : US3 = US3_1
        let v392 : US3 = v380 |> Option.defaultValue v391 
        let v432 : System.DateTime =
            match v392 with
            | US3_1 -> (* None *)
                let v428 : System.DateTime = System.DateTime.Now
                v428
            | US3_0(v396) -> (* Some *)
                let v397 : System.DateTime = System.DateTime.Now
                let v400 : (System.DateTime -> int64) = _.Ticks
                let v401 : int64 = v400 v397
                let v404 : int64 = v401 - v396
                let v405 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v406 : System.TimeSpan = v405 v404
                let v409 : (System.TimeSpan -> int32) = _.Hours
                let v410 : int32 = v409 v406
                let v413 : (System.TimeSpan -> int32) = _.Minutes
                let v414 : int32 = v413 v406
                let v417 : (System.TimeSpan -> int32) = _.Seconds
                let v418 : int32 = v417 v406
                let v421 : (System.TimeSpan -> int32) = _.Milliseconds
                let v422 : int32 = v421 v406
                let v425 : System.DateTime = System.DateTime (1, 1, 1, v410, v414, v418, v422)
                v425
        let v433 : string = method6()
        let v436 : (string -> string) = v432.ToString
        let v437 : string = v436 v433
        let _v125 = v437 
        #endif
#else
        let v440 : US3 option = None
        let _v440 = ref v440 
        let v441 : US3 option ref = _v440 
        let v442 : (US3 option -> US3 option ref) = closure7(v441)
        let v443 : unit = ()
        let v444 : (unit -> unit) = closure8(v112, v442)
        let v445 : unit = (fun () -> v444 (); v443) ()
        let v448 : US3 option = _v440.Value 
        let v459 : US3 = US3_1
        let v460 : US3 = v448 |> Option.defaultValue v459 
        let v500 : System.DateTime =
            match v460 with
            | US3_1 -> (* None *)
                let v496 : System.DateTime = System.DateTime.Now
                v496
            | US3_0(v464) -> (* Some *)
                let v465 : System.DateTime = System.DateTime.Now
                let v468 : (System.DateTime -> int64) = _.Ticks
                let v469 : int64 = v468 v465
                let v472 : int64 = v469 - v464
                let v473 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v474 : System.TimeSpan = v473 v472
                let v477 : (System.TimeSpan -> int32) = _.Hours
                let v478 : int32 = v477 v474
                let v481 : (System.TimeSpan -> int32) = _.Minutes
                let v482 : int32 = v481 v474
                let v485 : (System.TimeSpan -> int32) = _.Seconds
                let v486 : int32 = v485 v474
                let v489 : (System.TimeSpan -> int32) = _.Milliseconds
                let v490 : int32 = v489 v474
                let v493 : System.DateTime = System.DateTime (1, 1, 1, v478, v482, v486, v490)
                v493
        let v501 : string = method6()
        let v504 : (string -> string) = v500.ToString
        let v505 : string = v504 v501
        let _v125 = v505 
        #endif
        let v508 : string = _v125 
        
        
        
        
        
        let v578 : string = "Debug"
        let v579 : (unit -> string) = v578.ToLower
        let v580 : string = v579 ()
        let v583 : string = v580.PadLeft (7, ' ')
        let v597 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v598 : string = "inline_colorization::color_bright_blue"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v583 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v597 = v608 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v609 : string = "inline_colorization::color_bright_blue"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v583 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v597 = v619 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v620 : string = "inline_colorization::color_bright_blue"
        let v621 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v620 
        let v622 : string = "&*$0"
        let v623 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v583 v622 
        let v624 : string = "inline_colorization::color_reset"
        let v625 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v624 
        let v626 : string = "\"{v621}{v623}{v625}\""
        let v627 : string = @$"format!(" + v626 + ")"
        let v628 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v627 
        let v629 : string = "fable_library_rust::String_::fromString($0)"
        let v630 : string = Fable.Core.RustInterop.emitRustExpr v628 v629 
        let _v597 = v630 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v631 : string = "\u001b[94m"
        let v632 : string = method7()
        let v633 : string = v631 + v583 
        let v634 : string = v633 + v632 
        let _v597 = v634 
        #endif
#if FABLE_COMPILER_PYTHON
        let v635 : string = "\u001b[94m"
        let v636 : string = method7()
        let v637 : string = v635 + v583 
        let v638 : string = v637 + v636 
        let _v597 = v638 
        #endif
#else
        let v639 : string = "\u001b[94m"
        let v640 : string = method7()
        let v641 : string = v639 + v583 
        let v642 : string = v641 + v640 
        let _v597 = v642 
        #endif
        let v643 : string = _v597 
        let v649 : int64 = v107.l0
        let v650 : string = $"%A{v8}"
        let v653 : string = $"v9.to_string()"
        let v654 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v653 
        let v655 : string = $"%A{v4}"
        let v658 : string = $"%A{v0}"
        let v661 : string = $"%A{v10}"
        let v664 : string = $"%A{v12}"
        let v667 : string = $"%A{v13}"
        let v670 : string = method8()
        let v671 : Mut3 = {l0 = v670} : Mut3
        let v672 : string = "{ "
        let v673 : string = $"{v672}"
        let v676 : unit = ()
        let v677 : (unit -> unit) = closure9(v671, v673)
        let v678 : unit = (fun () -> v677 (); v676) ()
        let v681 : string = "max"
        let v682 : string = $"{v681}"
        let v685 : unit = ()
        let v686 : (unit -> unit) = closure9(v671, v682)
        let v687 : unit = (fun () -> v686 (); v685) ()
        let v690 : string = " = "
        let v691 : string = $"{v690}"
        let v694 : unit = ()
        let v695 : (unit -> unit) = closure9(v671, v691)
        let v696 : unit = (fun () -> v695 (); v694) ()
        let v699 : string = $"{v3}"
        let v702 : unit = ()
        let v703 : (unit -> unit) = closure9(v671, v699)
        let v704 : unit = (fun () -> v703 (); v702) ()
        let v707 : string = "; "
        let v708 : string = $"{v707}"
        let v711 : unit = ()
        let v712 : (unit -> unit) = closure9(v671, v708)
        let v713 : unit = (fun () -> v712 (); v711) ()
        let v716 : string = "key"
        let v717 : string = $"{v716}"
        let v720 : unit = ()
        let v721 : (unit -> unit) = closure9(v671, v717)
        let v722 : unit = (fun () -> v721 (); v720) ()
        let v725 : string = $"{v690}"
        let v728 : unit = ()
        let v729 : (unit -> unit) = closure9(v671, v725)
        let v730 : unit = (fun () -> v729 (); v728) ()
        let v733 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v734 : string = "format!(\"{:#?}\", $0)"
        let v735 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v734 
        let v736 : string = "fable_library_rust::String_::fromString($0)"
        let v737 : string = Fable.Core.RustInterop.emitRustExpr v735 v736 
        let _v733 = v737 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v738 : string = "format!(\"{:#?}\", $0)"
        let v739 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v738 
        let v740 : string = "fable_library_rust::String_::fromString($0)"
        let v741 : string = Fable.Core.RustInterop.emitRustExpr v739 v740 
        let _v733 = v741 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v742 : string = "format!(\"{:#?}\", $0)"
        let v743 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v742 
        let v744 : string = "fable_library_rust::String_::fromString($0)"
        let v745 : string = Fable.Core.RustInterop.emitRustExpr v743 v744 
        let _v733 = v745 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v746 : string = $"%A{v1}"
        let _v733 = v746 
        #endif
#if FABLE_COMPILER_PYTHON
        let v749 : string = $"%A{v1}"
        let _v733 = v749 
        #endif
#else
        let v752 : string = $"%A{v1}"
        let _v733 = v752 
        #endif
        let v755 : string = _v733 
        let v760 : string = $"{v755}"
        let v763 : unit = ()
        let v764 : (unit -> unit) = closure9(v671, v760)
        let v765 : unit = (fun () -> v764 (); v763) ()
        let v768 : string = $"{v707}"
        let v771 : unit = ()
        let v772 : (unit -> unit) = closure9(v671, v768)
        let v773 : unit = (fun () -> v772 (); v771) ()
        let v776 : string = "proof"
        let v777 : string = $"{v776}"
        let v780 : unit = ()
        let v781 : (unit -> unit) = closure9(v671, v777)
        let v782 : unit = (fun () -> v781 (); v780) ()
        let v785 : string = $"{v690}"
        let v788 : unit = ()
        let v789 : (unit -> unit) = closure9(v671, v785)
        let v790 : unit = (fun () -> v789 (); v788) ()
        let v793 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v794 : string = "format!(\"{:#?}\", $0)"
        let v795 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v794 
        let v796 : string = "fable_library_rust::String_::fromString($0)"
        let v797 : string = Fable.Core.RustInterop.emitRustExpr v795 v796 
        let _v793 = v797 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v798 : string = "format!(\"{:#?}\", $0)"
        let v799 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v798 
        let v800 : string = "fable_library_rust::String_::fromString($0)"
        let v801 : string = Fable.Core.RustInterop.emitRustExpr v799 v800 
        let _v793 = v801 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v802 : string = "format!(\"{:#?}\", $0)"
        let v803 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v802 
        let v804 : string = "fable_library_rust::String_::fromString($0)"
        let v805 : string = Fable.Core.RustInterop.emitRustExpr v803 v804 
        let _v793 = v805 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v806 : string = $"%A{v2}"
        let _v793 = v806 
        #endif
#if FABLE_COMPILER_PYTHON
        let v809 : string = $"%A{v2}"
        let _v793 = v809 
        #endif
#else
        let v812 : string = $"%A{v2}"
        let _v793 = v812 
        #endif
        let v815 : string = _v793 
        let v820 : string = $"{v815}"
        let v823 : unit = ()
        let v824 : (unit -> unit) = closure9(v671, v820)
        let v825 : unit = (fun () -> v824 (); v823) ()
        let v828 : string = $"{v707}"
        let v831 : unit = ()
        let v832 : (unit -> unit) = closure9(v671, v828)
        let v833 : unit = (fun () -> v832 (); v831) ()
        let v836 : string = "block_timestamp"
        let v837 : string = $"{v836}"
        let v840 : unit = ()
        let v841 : (unit -> unit) = closure9(v671, v837)
        let v842 : unit = (fun () -> v841 (); v840) ()
        let v845 : string = $"{v690}"
        let v848 : unit = ()
        let v849 : (unit -> unit) = closure9(v671, v845)
        let v850 : unit = (fun () -> v849 (); v848) ()
        let v853 : string = $"{v5}"
        let v856 : unit = ()
        let v857 : (unit -> unit) = closure9(v671, v853)
        let v858 : unit = (fun () -> v857 (); v856) ()
        let v861 : string = $"{v707}"
        let v864 : unit = ()
        let v865 : (unit -> unit) = closure9(v671, v861)
        let v866 : unit = (fun () -> v865 (); v864) ()
        let v869 : string = "block_height"
        let v870 : string = $"{v869}"
        let v873 : unit = ()
        let v874 : (unit -> unit) = closure9(v671, v870)
        let v875 : unit = (fun () -> v874 (); v873) ()
        let v878 : string = $"{v690}"
        let v881 : unit = ()
        let v882 : (unit -> unit) = closure9(v671, v878)
        let v883 : unit = (fun () -> v882 (); v881) ()
        let v886 : string = $"{v6}"
        let v889 : unit = ()
        let v890 : (unit -> unit) = closure9(v671, v886)
        let v891 : unit = (fun () -> v890 (); v889) ()
        let v894 : string = $"{v707}"
        let v897 : unit = ()
        let v898 : (unit -> unit) = closure9(v671, v894)
        let v899 : unit = (fun () -> v898 (); v897) ()
        let v902 : string = "epoch_height"
        let v903 : string = $"{v902}"
        let v906 : unit = ()
        let v907 : (unit -> unit) = closure9(v671, v903)
        let v908 : unit = (fun () -> v907 (); v906) ()
        let v911 : string = $"{v690}"
        let v914 : unit = ()
        let v915 : (unit -> unit) = closure9(v671, v911)
        let v916 : unit = (fun () -> v915 (); v914) ()
        let v919 : string = $"{v7}"
        let v922 : unit = ()
        let v923 : (unit -> unit) = closure9(v671, v919)
        let v924 : unit = (fun () -> v923 (); v922) ()
        let v927 : string = $"{v707}"
        let v930 : unit = ()
        let v931 : (unit -> unit) = closure9(v671, v927)
        let v932 : unit = (fun () -> v931 (); v930) ()
        let v935 : string = "account_balance"
        let v936 : string = $"{v935}"
        let v939 : unit = ()
        let v940 : (unit -> unit) = closure9(v671, v936)
        let v941 : unit = (fun () -> v940 (); v939) ()
        let v944 : string = $"{v690}"
        let v947 : unit = ()
        let v948 : (unit -> unit) = closure9(v671, v944)
        let v949 : unit = (fun () -> v948 (); v947) ()
        let v952 : string = $"{v650}"
        let v955 : unit = ()
        let v956 : (unit -> unit) = closure9(v671, v952)
        let v957 : unit = (fun () -> v956 (); v955) ()
        let v960 : string = $"{v707}"
        let v963 : unit = ()
        let v964 : (unit -> unit) = closure9(v671, v960)
        let v965 : unit = (fun () -> v964 (); v963) ()
        let v968 : string = "signer_account_id"
        let v969 : string = $"{v968}"
        let v972 : unit = ()
        let v973 : (unit -> unit) = closure9(v671, v969)
        let v974 : unit = (fun () -> v973 (); v972) ()
        let v977 : string = $"{v690}"
        let v980 : unit = ()
        let v981 : (unit -> unit) = closure9(v671, v977)
        let v982 : unit = (fun () -> v981 (); v980) ()
        let v985 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v986 : string = "format!(\"{:#?}\", $0)"
        let v987 : std_string_String = Fable.Core.RustInterop.emitRustExpr v654 v986 
        let v988 : string = "fable_library_rust::String_::fromString($0)"
        let v989 : string = Fable.Core.RustInterop.emitRustExpr v987 v988 
        let _v985 = v989 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v990 : string = "format!(\"{:#?}\", $0)"
        let v991 : std_string_String = Fable.Core.RustInterop.emitRustExpr v654 v990 
        let v992 : string = "fable_library_rust::String_::fromString($0)"
        let v993 : string = Fable.Core.RustInterop.emitRustExpr v991 v992 
        let _v985 = v993 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v994 : string = "format!(\"{:#?}\", $0)"
        let v995 : std_string_String = Fable.Core.RustInterop.emitRustExpr v654 v994 
        let v996 : string = "fable_library_rust::String_::fromString($0)"
        let v997 : string = Fable.Core.RustInterop.emitRustExpr v995 v996 
        let _v985 = v997 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v998 : string = $"%A{v654}"
        let _v985 = v998 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1001 : string = $"%A{v654}"
        let _v985 = v1001 
        #endif
#else
        let v1004 : string = $"%A{v654}"
        let _v985 = v1004 
        #endif
        let v1007 : string = _v985 
        let v1012 : string = $"{v1007}"
        let v1015 : unit = ()
        let v1016 : (unit -> unit) = closure9(v671, v1012)
        let v1017 : unit = (fun () -> v1016 (); v1015) ()
        let v1020 : string = $"{v707}"
        let v1023 : unit = ()
        let v1024 : (unit -> unit) = closure9(v671, v1020)
        let v1025 : unit = (fun () -> v1024 (); v1023) ()
        let v1028 : string = "seed"
        let v1029 : string = $"{v1028}"
        let v1032 : unit = ()
        let v1033 : (unit -> unit) = closure9(v671, v1029)
        let v1034 : unit = (fun () -> v1033 (); v1032) ()
        let v1037 : string = $"{v690}"
        let v1040 : unit = ()
        let v1041 : (unit -> unit) = closure9(v671, v1037)
        let v1042 : unit = (fun () -> v1041 (); v1040) ()
        let v1045 : string = $"{v655}"
        let v1048 : unit = ()
        let v1049 : (unit -> unit) = closure9(v671, v1045)
        let v1050 : unit = (fun () -> v1049 (); v1048) ()
        let v1053 : string = $"{v707}"
        let v1056 : unit = ()
        let v1057 : (unit -> unit) = closure9(v671, v1053)
        let v1058 : unit = (fun () -> v1057 (); v1056) ()
        let v1061 : string = "seeds"
        let v1062 : string = $"{v1061}"
        let v1065 : unit = ()
        let v1066 : (unit -> unit) = closure9(v671, v1062)
        let v1067 : unit = (fun () -> v1066 (); v1065) ()
        let v1070 : string = $"{v690}"
        let v1073 : unit = ()
        let v1074 : (unit -> unit) = closure9(v671, v1070)
        let v1075 : unit = (fun () -> v1074 (); v1073) ()
        let v1078 : string = $"{v658}"
        let v1081 : unit = ()
        let v1082 : (unit -> unit) = closure9(v671, v1078)
        let v1083 : unit = (fun () -> v1082 (); v1081) ()
        let v1086 : string = $"{v707}"
        let v1089 : unit = ()
        let v1090 : (unit -> unit) = closure9(v671, v1086)
        let v1091 : unit = (fun () -> v1090 (); v1089) ()
        let v1094 : string = "entropy_len"
        let v1095 : string = $"{v1094}"
        let v1098 : unit = ()
        let v1099 : (unit -> unit) = closure9(v671, v1095)
        let v1100 : unit = (fun () -> v1099 (); v1098) ()
        let v1103 : string = $"{v690}"
        let v1106 : unit = ()
        let v1107 : (unit -> unit) = closure9(v671, v1103)
        let v1108 : unit = (fun () -> v1107 (); v1106) ()
        let v1111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1112 : string = "format!(\"{:#?}\", $0)"
        let v1113 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v1112 
        let v1114 : string = "fable_library_rust::String_::fromString($0)"
        let v1115 : string = Fable.Core.RustInterop.emitRustExpr v1113 v1114 
        let _v1111 = v1115 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1116 : string = "format!(\"{:#?}\", $0)"
        let v1117 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v1116 
        let v1118 : string = "fable_library_rust::String_::fromString($0)"
        let v1119 : string = Fable.Core.RustInterop.emitRustExpr v1117 v1118 
        let _v1111 = v1119 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1120 : string = "format!(\"{:#?}\", $0)"
        let v1121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v1120 
        let v1122 : string = "fable_library_rust::String_::fromString($0)"
        let v1123 : string = Fable.Core.RustInterop.emitRustExpr v1121 v1122 
        let _v1111 = v1123 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1124 : string = $"%A{v11}"
        let _v1111 = v1124 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1127 : string = $"%A{v11}"
        let _v1111 = v1127 
        #endif
#else
        let v1130 : string = $"%A{v11}"
        let _v1111 = v1130 
        #endif
        let v1133 : string = _v1111 
        let v1138 : string = $"{v1133}"
        let v1141 : unit = ()
        let v1142 : (unit -> unit) = closure9(v671, v1138)
        let v1143 : unit = (fun () -> v1142 (); v1141) ()
        let v1146 : string = $"{v707}"
        let v1149 : unit = ()
        let v1150 : (unit -> unit) = closure9(v671, v1146)
        let v1151 : unit = (fun () -> v1150 (); v1149) ()
        let v1154 : string = "entropy"
        let v1155 : string = $"{v1154}"
        let v1158 : unit = ()
        let v1159 : (unit -> unit) = closure9(v671, v1155)
        let v1160 : unit = (fun () -> v1159 (); v1158) ()
        let v1163 : string = $"{v690}"
        let v1166 : unit = ()
        let v1167 : (unit -> unit) = closure9(v671, v1163)
        let v1168 : unit = (fun () -> v1167 (); v1166) ()
        let v1171 : string = $"{v661}"
        let v1174 : unit = ()
        let v1175 : (unit -> unit) = closure9(v671, v1171)
        let v1176 : unit = (fun () -> v1175 (); v1174) ()
        let v1179 : string = $"{v707}"
        let v1182 : unit = ()
        let v1183 : (unit -> unit) = closure9(v671, v1179)
        let v1184 : unit = (fun () -> v1183 (); v1182) ()
        let v1187 : string = "hash_u8"
        let v1188 : string = $"{v1187}"
        let v1191 : unit = ()
        let v1192 : (unit -> unit) = closure9(v671, v1188)
        let v1193 : unit = (fun () -> v1192 (); v1191) ()
        let v1196 : string = $"{v690}"
        let v1199 : unit = ()
        let v1200 : (unit -> unit) = closure9(v671, v1196)
        let v1201 : unit = (fun () -> v1200 (); v1199) ()
        let v1204 : string = $"{v664}"
        let v1207 : unit = ()
        let v1208 : (unit -> unit) = closure9(v671, v1204)
        let v1209 : unit = (fun () -> v1208 (); v1207) ()
        let v1212 : string = $"{v707}"
        let v1215 : unit = ()
        let v1216 : (unit -> unit) = closure9(v671, v1212)
        let v1217 : unit = (fun () -> v1216 (); v1215) ()
        let v1220 : string = "rolls_list_log"
        let v1221 : string = $"{v1220}"
        let v1224 : unit = ()
        let v1225 : (unit -> unit) = closure9(v671, v1221)
        let v1226 : unit = (fun () -> v1225 (); v1224) ()
        let v1229 : string = $"{v690}"
        let v1232 : unit = ()
        let v1233 : (unit -> unit) = closure9(v671, v1229)
        let v1234 : unit = (fun () -> v1233 (); v1232) ()
        let v1237 : string = $"{v667}"
        let v1240 : unit = ()
        let v1241 : (unit -> unit) = closure9(v671, v1237)
        let v1242 : unit = (fun () -> v1241 (); v1240) ()
        let v1245 : string = " }"
        let v1246 : string = $"{v1245}"
        let v1249 : unit = ()
        let v1250 : (unit -> unit) = closure9(v671, v1246)
        let v1251 : unit = (fun () -> v1250 (); v1249) ()
        let v1254 : string = v671.l0
        let v1255 : string = $"dice_contract.generate_random_number"
        let v1256 : bool = v1255 = ""
        let v1313 : string =
            if v1256 then
                let v1257 : string = ""
                v1257
            else
                let v1258 : string = $"{v508} {v643} #{v649} %s{v1255} / {v1254}"
                let v1261 : char list = []
                let v1262 : (char list -> (char [])) = List.toArray
                let v1263 : (char []) = v1262 v1261
                let v1266 : string = v1258.TrimStart v1263 
                let v1284 : char list = []
                let v1285 : char list = '/' :: v1284 
                let v1288 : char list = ' ' :: v1285 
                let v1291 : (char list -> (char [])) = List.toArray
                let v1292 : (char []) = v1291 v1288
                let v1295 : string = v1266.TrimEnd v1292 
                v1295
        let v1314 : (string -> unit) = closure10()
        let v1315 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1316 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1313 v1316 
        let _v1315 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1317 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1313 v1317 
        let _v1315 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1318 : string = v33.l0
        let v1319 : bool = v1318 = ""
        let v1327 : string =
            if v1319 then
                v1313
            else
                let v1320 : bool = v1313 = ""
                if v1320 then
                    let v1321 : string = v33.l0
                    v1321
                else
                    let v1322 : string = v33.l0
                    let v1323 : string = "\n"
                    let v1324 : string = v1322 + v1323 
                    let v1325 : string = v1324 + v1313 
                    v1325
        let v1328 : string = "&*$0"
        let v1329 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1327 v1328 
        let v1330 : string = $"$0.chars()"
        let v1331 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v1329 v1330 
        let v1332 : string = "v1331"
        let v1333 : _ = Fable.Core.RustInterop.emitRustExpr () v1332 
        let v1334 : string = "v1333.collect::<Vec<_>>()"
        let v1335 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v1334 
        let v1336 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v1337 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v1335 v1336 
        let v1338 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v1339 : bool = Fable.Core.RustInterop.emitRustExpr v1337 v1338 
        let v1340 : string = "x"
        let v1341 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v1340 
        let v1342 : string = "String::from_iter($0)"
        let v1343 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1341 v1342 
        let v1344 : string = "true; $0 }).collect::<Vec<_>>()"
        let v1345 : bool = Fable.Core.RustInterop.emitRustExpr v1343 v1344 
        let v1346 : string = "_vec_map"
        let v1347 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1346 
        let v1348 : string = "$0.len()"
        let v1349 : unativeint = Fable.Core.RustInterop.emitRustExpr v1347 v1348 
        let v1350 : (unativeint -> int32) = int32
        let v1351 : int32 = v1350 v1349
        let v1352 : string = ""
        let v1353 : bool = v1313 <> v1352 
        let v1357 : bool =
            if v1353 then
                let v1356 : bool = v1351 <= 1
                v1356
            else
                false
        if v1357 then
            v33.l0 <- v1327
            ()
        else
            v33.l0 <- v1352
            let v1358 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1359 : bool = Fable.Core.RustInterop.emitRustExpr v1347 v1358 
            let v1360 : string = "x"
            let v1361 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1360 
            let v1362 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v1361 v1362 
            let v1363 : string = $"true;"
            let v1364 : bool = Fable.Core.RustInterop.emitRustExpr () v1363 
            let v1365 : string = "true; }}); { //"
            let v1366 : bool = Fable.Core.RustInterop.emitRustExpr () v1365 
            ()
        let _v1315 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1314 v1313
        let _v1315 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1314 v1313
        let _v1315 = () 
        #endif
#else
        v1314 v1313
        let _v1315 = () 
        #endif
        _v1315 
        let v1367 : (string -> unit) = v31.l0
        v1367 v1313
and closure13 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure2()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 1 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure6(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure7(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure8(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure7(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure8(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method5()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure7(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure8(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure7(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure8(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure7(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure8(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure7(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure8(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Debug"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_bright_blue"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_bright_blue"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_bright_blue"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[94m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[94m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[94m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = ""
        let v640 : (string -> unit) = closure10()
        let v641 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v642 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v642 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v643 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v643 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v644 : string = v19.l0
        let v645 : bool = v644 = ""
        let v653 : string =
            if v645 then
                v639
            else
                let v646 : bool = v639 = ""
                if v646 then
                    let v647 : string = v19.l0
                    v647
                else
                    let v648 : string = v19.l0
                    let v649 : string = "\n"
                    let v650 : string = v648 + v649 
                    let v651 : string = v650 + v639 
                    v651
        let v654 : string = "&*$0"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v653 v654 
        let v656 : string = $"$0.chars()"
        let v657 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v655 v656 
        let v658 : string = "v657"
        let v659 : _ = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "v659.collect::<Vec<_>>()"
        let v661 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v660 
        let v662 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v663 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v661 v662 
        let v664 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v665 : bool = Fable.Core.RustInterop.emitRustExpr v663 v664 
        let v666 : string = "x"
        let v667 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "String::from_iter($0)"
        let v669 : std_string_String = Fable.Core.RustInterop.emitRustExpr v667 v668 
        let v670 : string = "true; $0 }).collect::<Vec<_>>()"
        let v671 : bool = Fable.Core.RustInterop.emitRustExpr v669 v670 
        let v672 : string = "_vec_map"
        let v673 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v672 
        let v674 : string = "$0.len()"
        let v675 : unativeint = Fable.Core.RustInterop.emitRustExpr v673 v674 
        let v676 : (unativeint -> int32) = int32
        let v677 : int32 = v676 v675
        let v678 : bool = v639 <> v639 
        let v682 : bool =
            if v678 then
                let v681 : bool = v677 <= 1
                v681
            else
                false
        if v682 then
            v19.l0 <- v653
            ()
        else
            v19.l0 <- v639
            let v683 : string = "true; $0.into_iter().for_each(|x| { //"
            let v684 : bool = Fable.Core.RustInterop.emitRustExpr v673 v683 
            let v685 : string = "x"
            let v686 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v685 
            let v687 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v686 v687 
            let v688 : string = $"true;"
            let v689 : bool = Fable.Core.RustInterop.emitRustExpr () v688 
            let v690 : string = "true; }}); { //"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr () v690 
            ()
        let _v641 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v640 v639
        let _v641 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v640 v639
        let _v641 = () 
        #endif
#else
        v640 v639
        let _v641 = () 
        #endif
        _v641 
        let v692 : (string -> unit) = v17.l0
        v692 v639
and closure15 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure14 () (v0 : uint8) : (UH0 -> UH0) =
    closure15(v0)
and method9 () : (uint8 -> (UH0 -> UH0)) =
    closure14()
and method10 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method10(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure16 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut0, v53 : Mut1, v54 : Mut2, v55 : Mut3, v56 : Mut4, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 1 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure6(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure7(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure8(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method5()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure7(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure8(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method5()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure7(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure8(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure7(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure8(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method6()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure7(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure8(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method6()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure7(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure8(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method6()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Debug"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_bright_blue"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_bright_blue"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_bright_blue"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[94m"
        let v621 : string = method7()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[94m"
        let v625 : string = method7()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[94m"
        let v629 : string = method7()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = method8()
        let v640 : Mut3 = {l0 = v639} : Mut3
        let v641 : string = "{ "
        let v642 : string = $"{v641}"
        let v645 : unit = ()
        let v646 : (unit -> unit) = closure9(v640, v642)
        let v647 : unit = (fun () -> v646 (); v645) ()
        let v650 : string = "power"
        let v651 : string = $"{v650}"
        let v654 : unit = ()
        let v655 : (unit -> unit) = closure9(v640, v651)
        let v656 : unit = (fun () -> v655 (); v654) ()
        let v659 : string = " = "
        let v660 : string = $"{v659}"
        let v663 : unit = ()
        let v664 : (unit -> unit) = closure9(v640, v660)
        let v665 : unit = (fun () -> v664 (); v663) ()
        let v668 : string = $"{v1}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure9(v640, v668)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v676 : string = "; "
        let v677 : string = $"{v676}"
        let v680 : unit = ()
        let v681 : (unit -> unit) = closure9(v640, v677)
        let v682 : unit = (fun () -> v681 (); v680) ()
        let v685 : string = "acc"
        let v686 : string = $"{v685}"
        let v689 : unit = ()
        let v690 : (unit -> unit) = closure9(v640, v686)
        let v691 : unit = (fun () -> v690 (); v689) ()
        let v694 : string = $"{v659}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure9(v640, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = $"{v0}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure9(v640, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = $"{v676}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure9(v640, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = "result"
        let v719 : string = $"{v718}"
        let v722 : unit = ()
        let v723 : (unit -> unit) = closure9(v640, v719)
        let v724 : unit = (fun () -> v723 (); v722) ()
        let v727 : string = $"{v659}"
        let v730 : unit = ()
        let v731 : (unit -> unit) = closure9(v640, v727)
        let v732 : unit = (fun () -> v731 (); v730) ()
        let v735 : string = $"{v2}"
        let v738 : unit = ()
        let v739 : (unit -> unit) = closure9(v640, v735)
        let v740 : unit = (fun () -> v739 (); v738) ()
        let v743 : string = " }"
        let v744 : string = $"{v743}"
        let v747 : unit = ()
        let v748 : (unit -> unit) = closure9(v640, v744)
        let v749 : unit = (fun () -> v748 (); v747) ()
        let v752 : string = v640.l0
        let v753 : string = $"dice.accumulate_dice_rolls"
        let v754 : bool = v753 = ""
        let v811 : string =
            if v754 then
                let v755 : string = ""
                v755
            else
                let v756 : string = $"{v497} {v632} #{v638} %s{v753} / {v752}"
                let v759 : char list = []
                let v760 : (char list -> (char [])) = List.toArray
                let v761 : (char []) = v760 v759
                let v764 : string = v756.TrimStart v761 
                let v782 : char list = []
                let v783 : char list = '/' :: v782 
                let v786 : char list = ' ' :: v783 
                let v789 : (char list -> (char [])) = List.toArray
                let v790 : (char []) = v789 v786
                let v793 : string = v764.TrimEnd v790 
                v793
        let v812 : (string -> unit) = closure10()
        let v813 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v814 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v814 
        let _v813 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v815 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v815 
        let _v813 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v816 : string = v22.l0
        let v817 : bool = v816 = ""
        let v825 : string =
            if v817 then
                v811
            else
                let v818 : bool = v811 = ""
                if v818 then
                    let v819 : string = v22.l0
                    v819
                else
                    let v820 : string = v22.l0
                    let v821 : string = "\n"
                    let v822 : string = v820 + v821 
                    let v823 : string = v822 + v811 
                    v823
        let v826 : string = "&*$0"
        let v827 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v825 v826 
        let v828 : string = $"$0.chars()"
        let v829 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v827 v828 
        let v830 : string = "v829"
        let v831 : _ = Fable.Core.RustInterop.emitRustExpr () v830 
        let v832 : string = "v831.collect::<Vec<_>>()"
        let v833 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v832 
        let v834 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v835 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v833 v834 
        let v836 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v837 : bool = Fable.Core.RustInterop.emitRustExpr v835 v836 
        let v838 : string = "x"
        let v839 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v838 
        let v840 : string = "String::from_iter($0)"
        let v841 : std_string_String = Fable.Core.RustInterop.emitRustExpr v839 v840 
        let v842 : string = "true; $0 }).collect::<Vec<_>>()"
        let v843 : bool = Fable.Core.RustInterop.emitRustExpr v841 v842 
        let v844 : string = "_vec_map"
        let v845 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v844 
        let v846 : string = "$0.len()"
        let v847 : unativeint = Fable.Core.RustInterop.emitRustExpr v845 v846 
        let v848 : (unativeint -> int32) = int32
        let v849 : int32 = v848 v847
        let v850 : string = ""
        let v851 : bool = v811 <> v850 
        let v855 : bool =
            if v851 then
                let v854 : bool = v849 <= 1
                v854
            else
                false
        if v855 then
            v22.l0 <- v825
            ()
        else
            v22.l0 <- v850
            let v856 : string = "true; $0.into_iter().for_each(|x| { //"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v845 v856 
            let v858 : string = "x"
            let v859 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v861 : string = $"true;"
            let v862 : bool = Fable.Core.RustInterop.emitRustExpr () v861 
            let v863 : string = "true; }}); { //"
            let v864 : bool = Fable.Core.RustInterop.emitRustExpr () v863 
            ()
        let _v813 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v812 v811
        let _v813 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v812 v811
        let _v813 = () 
        #endif
#else
        v812 v811
        let _v813 = () 
        #endif
        _v813 
        let v865 : (string -> unit) = v20.l0
        v865 v811
and closure80 () () : UH1 =
    UH1_1
and closure79 () () : UH1 =
    let v0 : (unit -> UH1) = closure80()
    UH1_0(9223372036854775808UL, v0)
and closure78 () () : UH1 =
    let v0 : (unit -> UH1) = closure79()
    UH1_0(4611686018427387904UL, v0)
and closure77 () () : UH1 =
    let v0 : (unit -> UH1) = closure78()
    UH1_0(6917529027641081856UL, v0)
and closure76 () () : UH1 =
    let v0 : (unit -> UH1) = closure77()
    UH1_0(1152921504606846976UL, v0)
and closure75 () () : UH1 =
    let v0 : (unit -> UH1) = closure76()
    UH1_0(15564440312192434176UL, v0)
and closure74 () () : UH1 =
    let v0 : (unit -> UH1) = closure75()
    UH1_0(11817445422220181504UL, v0)
and closure73 () () : UH1 =
    let v0 : (unit -> UH1) = closure74()
    UH1_0(5044031582654955520UL, v0)
and closure72 () () : UH1 =
    let v0 : (unit -> UH1) = closure73()
    UH1_0(6989586621679009792UL, v0)
and closure71 () () : UH1 =
    let v0 : (unit -> UH1) = closure72()
    UH1_0(16537217831704461312UL, v0)
and closure70 () () : UH1 =
    let v0 : (unit -> UH1) = closure71()
    UH1_0(11979575008805519360UL, v0)
and closure69 () () : UH1 =
    let v0 : (unit -> UH1) = closure70()
    UH1_0(14294425217273954304UL, v0)
and closure68 () () : UH1 =
    let v0 : (unit -> UH1) = closure69()
    UH1_0(2382404202878992384UL, v0)
and closure67 () () : UH1 =
    let v0 : (unit -> UH1) = closure68()
    UH1_0(6545982058383015936UL, v0)
and closure66 () () : UH1 =
    let v0 : (unit -> UH1) = closure67()
    UH1_0(10314369046585278464UL, v0)
and closure65 () () : UH1 =
    let v0 : (unit -> UH1) = closure66()
    UH1_0(4793518853382471680UL, v0)
and closure64 () () : UH1 =
    let v0 : (unit -> UH1) = closure65()
    UH1_0(3873377154515337216UL, v0)
and closure63 () () : UH1 =
    let v0 : (unit -> UH1) = closure64()
    UH1_0(645562859085889536UL, v0)
and closure62 () () : UH1 =
    let v0 : (unit -> UH1) = closure63()
    UH1_0(107593809847648256UL, v0)
and closure61 () () : UH1 =
    let v0 : (unit -> UH1) = closure62()
    UH1_0(3092389647259533312UL, v0)
and closure60 () () : UH1 =
    let v0 : (unit -> UH1) = closure61()
    UH1_0(9738770311398031360UL, v0)
and closure59 () () : UH1 =
    let v0 : (unit -> UH1) = closure60()
    UH1_0(16995415113324298240UL, v0)
and closure58 () () : UH1 =
    let v0 : (unit -> UH1) = closure59()
    UH1_0(8981483876790566912UL, v0)
and closure57 () () : UH1 =
    let v0 : (unit -> UH1) = closure58()
    UH1_0(13794743361938128896UL, v0)
and closure56 () () : UH1 =
    let v0 : (unit -> UH1) = closure57()
    UH1_0(2299123893656354816UL, v0)
and closure55 () () : UH1 =
    let v0 : (unit -> UH1) = closure56()
    UH1_0(3457644661227651072UL, v0)
and closure54 () () : UH1 =
    let v0 : (unit -> UH1) = closure55()
    UH1_0(576274110204608512UL, v0)
and closure53 () () : UH1 =
    let v0 : (unit -> UH1) = closure54()
    UH1_0(6244960376270618624UL, v0)
and closure52 () () : UH1 =
    let v0 : (unit -> UH1) = closure53()
    UH1_0(13338656111851470848UL, v0)
and closure51 () () : UH1 =
    let v0 : (unit -> UH1) = closure52()
    UH1_0(14520938734448279552UL, v0)
and closure50 () () : UH1 =
    let v0 : (unit -> UH1) = closure51()
    UH1_0(14717985838214414336UL, v0)
and closure49 () () : UH1 =
    let v0 : (unit -> UH1) = closure50()
    UH1_0(5527454985320660992UL, v0)
and closure48 () () : UH1 =
    let v0 : (unit -> UH1) = closure49()
    UH1_0(16293529225644736512UL, v0)
and closure47 () () : UH1 =
    let v0 : (unit -> UH1) = closure48()
    UH1_0(11938960241128898560UL, v0)
and closure46 () () : UH1 =
    let v0 : (unit -> UH1) = closure47()
    UH1_0(8138741398091333632UL, v0)
and closure45 () () : UH1 =
    let v0 : (unit -> UH1) = closure46()
    UH1_0(7505371590918406144UL, v0)
and closure44 () () : UH1 =
    let v0 : (unit -> UH1) = closure45()
    UH1_0(16623181993244360704UL, v0)
and closure43 () () : UH1 =
    let v0 : (unit -> UH1) = closure44()
    UH1_0(8919445023443910656UL, v0)
and closure42 () () : UH1 =
    let v0 : (unit -> UH1) = closure43()
    UH1_0(4561031516192243712UL, v0)
and closure41 () () : UH1 =
    let v0 : (unit -> UH1) = closure42()
    UH1_0(9983543956220149760UL, v0)
and closure40 () () : UH1 =
    let v0 : (unit -> UH1) = closure41()
    UH1_0(4738381338321616896UL, v0)
and closure39 () () : UH1 =
    let v0 : (unit -> UH1) = closure40()
    UH1_0(789730223053602816UL, v0)
and closure38 () () : UH1 =
    let v0 : (unit -> UH1) = closure39()
    UH1_0(131621703842267136UL, v0)
and closure37 () () : UH1 =
    let v0 : (unit -> UH1) = closure38()
    UH1_0(21936950640377856UL, v0)
and closure36 () () : UH1 =
    let v0 : (unit -> UH1) = closure37()
    UH1_0(3656158440062976UL, v0)
and closure35 () () : UH1 =
    let v0 : (unit -> UH1) = closure36()
    UH1_0(609359740010496UL, v0)
and closure34 () () : UH1 =
    let v0 : (unit -> UH1) = closure35()
    UH1_0(101559956668416UL, v0)
and closure33 () () : UH1 =
    let v0 : (unit -> UH1) = closure34()
    UH1_0(16926659444736UL, v0)
and closure32 () () : UH1 =
    let v0 : (unit -> UH1) = closure33()
    UH1_0(2821109907456UL, v0)
and closure31 () () : UH1 =
    let v0 : (unit -> UH1) = closure32()
    UH1_0(470184984576UL, v0)
and closure30 () () : UH1 =
    let v0 : (unit -> UH1) = closure31()
    UH1_0(78364164096UL, v0)
and closure29 () () : UH1 =
    let v0 : (unit -> UH1) = closure30()
    UH1_0(13060694016UL, v0)
and closure28 () () : UH1 =
    let v0 : (unit -> UH1) = closure29()
    UH1_0(2176782336UL, v0)
and closure27 () () : UH1 =
    let v0 : (unit -> UH1) = closure28()
    UH1_0(362797056UL, v0)
and closure26 () () : UH1 =
    let v0 : (unit -> UH1) = closure27()
    UH1_0(60466176UL, v0)
and closure25 () () : UH1 =
    let v0 : (unit -> UH1) = closure26()
    UH1_0(10077696UL, v0)
and closure24 () () : UH1 =
    let v0 : (unit -> UH1) = closure25()
    UH1_0(1679616UL, v0)
and closure23 () () : UH1 =
    let v0 : (unit -> UH1) = closure24()
    UH1_0(279936UL, v0)
and closure22 () () : UH1 =
    let v0 : (unit -> UH1) = closure23()
    UH1_0(46656UL, v0)
and closure21 () () : UH1 =
    let v0 : (unit -> UH1) = closure22()
    UH1_0(7776UL, v0)
and closure20 () () : UH1 =
    let v0 : (unit -> UH1) = closure21()
    UH1_0(1296UL, v0)
and closure19 () () : UH1 =
    let v0 : (unit -> UH1) = closure20()
    UH1_0(216UL, v0)
and closure18 () () : UH1 =
    let v0 : (unit -> UH1) = closure19()
    UH1_0(36UL, v0)
and closure17 () () : UH1 =
    let v0 : (unit -> UH1) = closure18()
    UH1_0(6UL, v0)
and method12 (v0 : int8, v1 : UH1) : US5 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US5_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH1 = v3 ()
            method12(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US5_1
and closure81 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure2()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
    let v38 : unit = ()
    let v39 : unit = (fun () -> v5 (); v38) ()
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
    if v76 then
        let v77 : unit = ()
        let v78 : (unit -> unit) = closure6(v20)
        let v79 : unit = (fun () -> v78 (); v77) ()
        let v82 : unit = ()
        let v83 : unit = (fun () -> v5 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        let v115 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v116 : US3 option = None
        let _v116 = ref v116 
        let v117 : US3 option ref = _v116 
        let v118 : (US3 option -> US3 option ref) = closure7(v117)
        let v119 : unit = ()
        let v120 : (unit -> unit) = closure8(v102, v118)
        let v121 : unit = (fun () -> v120 (); v119) ()
        let v124 : US3 option = _v116.Value 
        let v135 : US3 = US3_1
        let v136 : US3 = v124 |> Option.defaultValue v135 
        let v176 : System.DateTime =
            match v136 with
            | US3_1 -> (* None *)
                let v172 : System.DateTime = System.DateTime.Now
                v172
            | US3_0(v140) -> (* Some *)
                let v141 : System.DateTime = System.DateTime.Now
                let v144 : (System.DateTime -> int64) = _.Ticks
                let v145 : int64 = v144 v141
                let v148 : int64 = v145 - v140
                let v149 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v150 : System.TimeSpan = v149 v148
                let v153 : (System.TimeSpan -> int32) = _.Hours
                let v154 : int32 = v153 v150
                let v157 : (System.TimeSpan -> int32) = _.Minutes
                let v158 : int32 = v157 v150
                let v161 : (System.TimeSpan -> int32) = _.Seconds
                let v162 : int32 = v161 v150
                let v165 : (System.TimeSpan -> int32) = _.Milliseconds
                let v166 : int32 = v165 v150
                let v169 : System.DateTime = System.DateTime (1, 1, 1, v154, v158, v162, v166)
                v169
        let v177 : string = method5()
        let v180 : (string -> string) = v176.ToString
        let v181 : string = v180 v177
        let _v115 = v181 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v184 : US3 option = None
        let _v184 = ref v184 
        let v185 : US3 option ref = _v184 
        let v186 : (US3 option -> US3 option ref) = closure7(v185)
        let v187 : unit = ()
        let v188 : (unit -> unit) = closure8(v102, v186)
        let v189 : unit = (fun () -> v188 (); v187) ()
        let v192 : US3 option = _v184.Value 
        let v203 : US3 = US3_1
        let v204 : US3 = v192 |> Option.defaultValue v203 
        let v244 : System.DateTime =
            match v204 with
            | US3_1 -> (* None *)
                let v240 : System.DateTime = System.DateTime.Now
                v240
            | US3_0(v208) -> (* Some *)
                let v209 : System.DateTime = System.DateTime.Now
                let v212 : (System.DateTime -> int64) = _.Ticks
                let v213 : int64 = v212 v209
                let v216 : int64 = v213 - v208
                let v217 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v218 : System.TimeSpan = v217 v216
                let v221 : (System.TimeSpan -> int32) = _.Hours
                let v222 : int32 = v221 v218
                let v225 : (System.TimeSpan -> int32) = _.Minutes
                let v226 : int32 = v225 v218
                let v229 : (System.TimeSpan -> int32) = _.Seconds
                let v230 : int32 = v229 v218
                let v233 : (System.TimeSpan -> int32) = _.Milliseconds
                let v234 : int32 = v233 v218
                let v237 : System.DateTime = System.DateTime (1, 1, 1, v222, v226, v230, v234)
                v237
        let v245 : string = method5()
        let v248 : (string -> string) = v244.ToString
        let v249 : string = v248 v245
        let _v115 = v249 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v252 : string = $"near_sdk::env::block_timestamp()"
        let v253 : uint64 = Fable.Core.RustInterop.emitRustExpr () v252 
        let v254 : US3 option = None
        let _v254 = ref v254 
        let v255 : US3 option ref = _v254 
        let v256 : (US3 option -> US3 option ref) = closure7(v255)
        let v257 : unit = ()
        let v258 : (unit -> unit) = closure8(v102, v256)
        let v259 : unit = (fun () -> v258 (); v257) ()
        let v262 : US3 option = _v254.Value 
        let v273 : US3 = US3_1
        let v274 : US3 = v262 |> Option.defaultValue v273 
        let v283 : uint64 =
            match v274 with
            | US3_1 -> (* None *)
                v253
            | US3_0(v278) -> (* Some *)
                let v279 : (int64 -> uint64) = uint64
                let v280 : uint64 = v279 v278
                let v281 : uint64 = v253 - v280
                v281
        let v284 : uint64 = v283 / 1000000000UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v284 / 60UL
        let v287 : uint64 = v286 % 60UL
        let v288 : uint64 = v284 / 3600UL
        let v289 : uint64 = v288 % 24UL
        let v290 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v289, v287, v285) v290 
        let v292 : string = "fable_library_rust::String_::fromString($0)"
        let v293 : string = Fable.Core.RustInterop.emitRustExpr v291 v292 
        let _v115 = v293 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v294 : US3 option = None
        let _v294 = ref v294 
        let v295 : US3 option ref = _v294 
        let v296 : (US3 option -> US3 option ref) = closure7(v295)
        let v297 : unit = ()
        let v298 : (unit -> unit) = closure8(v102, v296)
        let v299 : unit = (fun () -> v298 (); v297) ()
        let v302 : US3 option = _v294.Value 
        let v313 : US3 = US3_1
        let v314 : US3 = v302 |> Option.defaultValue v313 
        let v354 : System.DateTime =
            match v314 with
            | US3_1 -> (* None *)
                let v350 : System.DateTime = System.DateTime.Now
                v350
            | US3_0(v318) -> (* Some *)
                let v319 : System.DateTime = System.DateTime.Now
                let v322 : (System.DateTime -> int64) = _.Ticks
                let v323 : int64 = v322 v319
                let v326 : int64 = v323 - v318
                let v327 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v328 : System.TimeSpan = v327 v326
                let v331 : (System.TimeSpan -> int32) = _.Hours
                let v332 : int32 = v331 v328
                let v335 : (System.TimeSpan -> int32) = _.Minutes
                let v336 : int32 = v335 v328
                let v339 : (System.TimeSpan -> int32) = _.Seconds
                let v340 : int32 = v339 v328
                let v343 : (System.TimeSpan -> int32) = _.Milliseconds
                let v344 : int32 = v343 v328
                let v347 : System.DateTime = System.DateTime (1, 1, 1, v332, v336, v340, v344)
                v347
        let v355 : string = method6()
        let v358 : (string -> string) = v354.ToString
        let v359 : string = v358 v355
        let _v115 = v359 
        #endif
#if FABLE_COMPILER_PYTHON
        let v362 : US3 option = None
        let _v362 = ref v362 
        let v363 : US3 option ref = _v362 
        let v364 : (US3 option -> US3 option ref) = closure7(v363)
        let v365 : unit = ()
        let v366 : (unit -> unit) = closure8(v102, v364)
        let v367 : unit = (fun () -> v366 (); v365) ()
        let v370 : US3 option = _v362.Value 
        let v381 : US3 = US3_1
        let v382 : US3 = v370 |> Option.defaultValue v381 
        let v422 : System.DateTime =
            match v382 with
            | US3_1 -> (* None *)
                let v418 : System.DateTime = System.DateTime.Now
                v418
            | US3_0(v386) -> (* Some *)
                let v387 : System.DateTime = System.DateTime.Now
                let v390 : (System.DateTime -> int64) = _.Ticks
                let v391 : int64 = v390 v387
                let v394 : int64 = v391 - v386
                let v395 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v396 : System.TimeSpan = v395 v394
                let v399 : (System.TimeSpan -> int32) = _.Hours
                let v400 : int32 = v399 v396
                let v403 : (System.TimeSpan -> int32) = _.Minutes
                let v404 : int32 = v403 v396
                let v407 : (System.TimeSpan -> int32) = _.Seconds
                let v408 : int32 = v407 v396
                let v411 : (System.TimeSpan -> int32) = _.Milliseconds
                let v412 : int32 = v411 v396
                let v415 : System.DateTime = System.DateTime (1, 1, 1, v400, v404, v408, v412)
                v415
        let v423 : string = method6()
        let v426 : (string -> string) = v422.ToString
        let v427 : string = v426 v423
        let _v115 = v427 
        #endif
#else
        let v430 : US3 option = None
        let _v430 = ref v430 
        let v431 : US3 option ref = _v430 
        let v432 : (US3 option -> US3 option ref) = closure7(v431)
        let v433 : unit = ()
        let v434 : (unit -> unit) = closure8(v102, v432)
        let v435 : unit = (fun () -> v434 (); v433) ()
        let v438 : US3 option = _v430.Value 
        let v449 : US3 = US3_1
        let v450 : US3 = v438 |> Option.defaultValue v449 
        let v490 : System.DateTime =
            match v450 with
            | US3_1 -> (* None *)
                let v486 : System.DateTime = System.DateTime.Now
                v486
            | US3_0(v454) -> (* Some *)
                let v455 : System.DateTime = System.DateTime.Now
                let v458 : (System.DateTime -> int64) = _.Ticks
                let v459 : int64 = v458 v455
                let v462 : int64 = v459 - v454
                let v463 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v464 : System.TimeSpan = v463 v462
                let v467 : (System.TimeSpan -> int32) = _.Hours
                let v468 : int32 = v467 v464
                let v471 : (System.TimeSpan -> int32) = _.Minutes
                let v472 : int32 = v471 v464
                let v475 : (System.TimeSpan -> int32) = _.Seconds
                let v476 : int32 = v475 v464
                let v479 : (System.TimeSpan -> int32) = _.Milliseconds
                let v480 : int32 = v479 v464
                let v483 : System.DateTime = System.DateTime (1, 1, 1, v468, v472, v476, v480)
                v483
        let v491 : string = method6()
        let v494 : (string -> string) = v490.ToString
        let v495 : string = v494 v491
        let _v115 = v495 
        #endif
        let v498 : string = _v115 
        
        
        
        
        
        let v568 : string = "Debug"
        let v569 : (unit -> string) = v568.ToLower
        let v570 : string = v569 ()
        let v573 : string = v570.PadLeft (7, ' ')
        let v587 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v588 : string = "inline_colorization::color_bright_blue"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "&*$0"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v573 v590 
        let v592 : string = "inline_colorization::color_reset"
        let v593 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "\"{v589}{v591}{v593}\""
        let v595 : string = @$"format!(" + v594 + ")"
        let v596 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "fable_library_rust::String_::fromString($0)"
        let v598 : string = Fable.Core.RustInterop.emitRustExpr v596 v597 
        let _v587 = v598 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v599 : string = "inline_colorization::color_bright_blue"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "&*$0"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v573 v601 
        let v603 : string = "inline_colorization::color_reset"
        let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "\"{v600}{v602}{v604}\""
        let v606 : string = @$"format!(" + v605 + ")"
        let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "fable_library_rust::String_::fromString($0)"
        let v609 : string = Fable.Core.RustInterop.emitRustExpr v607 v608 
        let _v587 = v609 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v610 : string = "inline_colorization::color_bright_blue"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "&*$0"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v573 v612 
        let v614 : string = "inline_colorization::color_reset"
        let v615 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "\"{v611}{v613}{v615}\""
        let v617 : string = @$"format!(" + v616 + ")"
        let v618 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v617 
        let v619 : string = "fable_library_rust::String_::fromString($0)"
        let v620 : string = Fable.Core.RustInterop.emitRustExpr v618 v619 
        let _v587 = v620 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v621 : string = "\u001b[94m"
        let v622 : string = method7()
        let v623 : string = v621 + v573 
        let v624 : string = v623 + v622 
        let _v587 = v624 
        #endif
#if FABLE_COMPILER_PYTHON
        let v625 : string = "\u001b[94m"
        let v626 : string = method7()
        let v627 : string = v625 + v573 
        let v628 : string = v627 + v626 
        let _v587 = v628 
        #endif
#else
        let v629 : string = "\u001b[94m"
        let v630 : string = method7()
        let v631 : string = v629 + v573 
        let v632 : string = v631 + v630 
        let _v587 = v632 
        #endif
        let v633 : string = _v587 
        let v639 : int64 = v97.l0
        let v640 : string = method8()
        let v641 : Mut3 = {l0 = v640} : Mut3
        let v642 : string = "{ "
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure9(v641, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = "power"
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure9(v641, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = " = "
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure9(v641, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = $"{v1}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure9(v641, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = "; "
        let v678 : string = $"{v677}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure9(v641, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = "acc"
        let v687 : string = $"{v686}"
        let v690 : unit = ()
        let v691 : (unit -> unit) = closure9(v641, v687)
        let v692 : unit = (fun () -> v691 (); v690) ()
        let v695 : string = $"{v660}"
        let v698 : unit = ()
        let v699 : (unit -> unit) = closure9(v641, v695)
        let v700 : unit = (fun () -> v699 (); v698) ()
        let v703 : string = $"{v0}"
        let v706 : unit = ()
        let v707 : (unit -> unit) = closure9(v641, v703)
        let v708 : unit = (fun () -> v707 (); v706) ()
        let v711 : string = $"{v677}"
        let v714 : unit = ()
        let v715 : (unit -> unit) = closure9(v641, v711)
        let v716 : unit = (fun () -> v715 (); v714) ()
        let v719 : string = "roll"
        let v720 : string = $"{v719}"
        let v723 : unit = ()
        let v724 : (unit -> unit) = closure9(v641, v720)
        let v725 : unit = (fun () -> v724 (); v723) ()
        let v728 : string = $"{v660}"
        let v731 : unit = ()
        let v732 : (unit -> unit) = closure9(v641, v728)
        let v733 : unit = (fun () -> v732 (); v731) ()
        let v736 : string = $"{v2}"
        let v739 : unit = ()
        let v740 : (unit -> unit) = closure9(v641, v736)
        let v741 : unit = (fun () -> v740 (); v739) ()
        let v744 : string = $"{v677}"
        let v747 : unit = ()
        let v748 : (unit -> unit) = closure9(v641, v744)
        let v749 : unit = (fun () -> v748 (); v747) ()
        let v752 : string = "value"
        let v753 : string = $"{v752}"
        let v756 : unit = ()
        let v757 : (unit -> unit) = closure9(v641, v753)
        let v758 : unit = (fun () -> v757 (); v756) ()
        let v761 : string = $"{v660}"
        let v764 : unit = ()
        let v765 : (unit -> unit) = closure9(v641, v761)
        let v766 : unit = (fun () -> v765 (); v764) ()
        let v769 : string = $"{v3}"
        let v772 : unit = ()
        let v773 : (unit -> unit) = closure9(v641, v769)
        let v774 : unit = (fun () -> v773 (); v772) ()
        let v777 : string = " }"
        let v778 : string = $"{v777}"
        let v781 : unit = ()
        let v782 : (unit -> unit) = closure9(v641, v778)
        let v783 : unit = (fun () -> v782 (); v781) ()
        let v786 : string = v641.l0
        let v787 : string = $"dice.accumulate_dice_rolls"
        let v788 : bool = v787 = ""
        let v845 : string =
            if v788 then
                let v789 : string = ""
                v789
            else
                let v790 : string = $"{v498} {v633} #{v639} %s{v787} / {v786}"
                let v793 : char list = []
                let v794 : (char list -> (char [])) = List.toArray
                let v795 : (char []) = v794 v793
                let v798 : string = v790.TrimStart v795 
                let v816 : char list = []
                let v817 : char list = '/' :: v816 
                let v820 : char list = ' ' :: v817 
                let v823 : (char list -> (char [])) = List.toArray
                let v824 : (char []) = v823 v820
                let v827 : string = v798.TrimEnd v824 
                v827
        let v846 : (string -> unit) = closure10()
        let v847 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v848 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v845 v848 
        let _v847 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v849 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v845 v849 
        let _v847 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v850 : string = v23.l0
        let v851 : bool = v850 = ""
        let v859 : string =
            if v851 then
                v845
            else
                let v852 : bool = v845 = ""
                if v852 then
                    let v853 : string = v23.l0
                    v853
                else
                    let v854 : string = v23.l0
                    let v855 : string = "\n"
                    let v856 : string = v854 + v855 
                    let v857 : string = v856 + v845 
                    v857
        let v860 : string = "&*$0"
        let v861 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v859 v860 
        let v862 : string = $"$0.chars()"
        let v863 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v861 v862 
        let v864 : string = "v863"
        let v865 : _ = Fable.Core.RustInterop.emitRustExpr () v864 
        let v866 : string = "v865.collect::<Vec<_>>()"
        let v867 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v866 
        let v868 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v869 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v867 v868 
        let v870 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v871 : bool = Fable.Core.RustInterop.emitRustExpr v869 v870 
        let v872 : string = "x"
        let v873 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v872 
        let v874 : string = "String::from_iter($0)"
        let v875 : std_string_String = Fable.Core.RustInterop.emitRustExpr v873 v874 
        let v876 : string = "true; $0 }).collect::<Vec<_>>()"
        let v877 : bool = Fable.Core.RustInterop.emitRustExpr v875 v876 
        let v878 : string = "_vec_map"
        let v879 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v878 
        let v880 : string = "$0.len()"
        let v881 : unativeint = Fable.Core.RustInterop.emitRustExpr v879 v880 
        let v882 : (unativeint -> int32) = int32
        let v883 : int32 = v882 v881
        let v884 : string = ""
        let v885 : bool = v845 <> v884 
        let v889 : bool =
            if v885 then
                let v888 : bool = v883 <= 1
                v888
            else
                false
        if v889 then
            v23.l0 <- v859
            ()
        else
            v23.l0 <- v884
            let v890 : string = "true; $0.into_iter().for_each(|x| { //"
            let v891 : bool = Fable.Core.RustInterop.emitRustExpr v879 v890 
            let v892 : string = "x"
            let v893 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v892 
            let v894 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v893 v894 
            let v895 : string = $"true;"
            let v896 : bool = Fable.Core.RustInterop.emitRustExpr () v895 
            let v897 : string = "true; }}); { //"
            let v898 : bool = Fable.Core.RustInterop.emitRustExpr () v897 
            ()
        let _v847 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v846 v845
        let _v847 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v846 v845
        let _v847 = () 
        #endif
#else
        v846 v845
        let _v847 = () 
        #endif
        _v847 
        let v899 : (string -> unit) = v21.l0
        v899 v845
and closure82 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut0, v53 : Mut1, v54 : Mut2, v55 : Mut3, v56 : Mut4, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 1 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure6(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure7(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure8(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method5()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure7(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure8(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method5()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure7(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure8(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure7(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure8(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method6()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure7(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure8(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method6()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure7(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure8(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method6()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Debug"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_bright_blue"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_bright_blue"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_bright_blue"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[94m"
        let v621 : string = method7()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[94m"
        let v625 : string = method7()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[94m"
        let v629 : string = method7()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = method8()
        let v640 : Mut3 = {l0 = v639} : Mut3
        let v641 : string = "{ "
        let v642 : string = $"{v641}"
        let v645 : unit = ()
        let v646 : (unit -> unit) = closure9(v640, v642)
        let v647 : unit = (fun () -> v646 (); v645) ()
        let v650 : string = "power"
        let v651 : string = $"{v650}"
        let v654 : unit = ()
        let v655 : (unit -> unit) = closure9(v640, v651)
        let v656 : unit = (fun () -> v655 (); v654) ()
        let v659 : string = " = "
        let v660 : string = $"{v659}"
        let v663 : unit = ()
        let v664 : (unit -> unit) = closure9(v640, v660)
        let v665 : unit = (fun () -> v664 (); v663) ()
        let v668 : string = $"{v1}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure9(v640, v668)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v676 : string = "; "
        let v677 : string = $"{v676}"
        let v680 : unit = ()
        let v681 : (unit -> unit) = closure9(v640, v677)
        let v682 : unit = (fun () -> v681 (); v680) ()
        let v685 : string = "acc"
        let v686 : string = $"{v685}"
        let v689 : unit = ()
        let v690 : (unit -> unit) = closure9(v640, v686)
        let v691 : unit = (fun () -> v690 (); v689) ()
        let v694 : string = $"{v659}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure9(v640, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = $"{v0}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure9(v640, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = $"{v676}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure9(v640, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = "roll"
        let v719 : string = $"{v718}"
        let v722 : unit = ()
        let v723 : (unit -> unit) = closure9(v640, v719)
        let v724 : unit = (fun () -> v723 (); v722) ()
        let v727 : string = $"{v659}"
        let v730 : unit = ()
        let v731 : (unit -> unit) = closure9(v640, v727)
        let v732 : unit = (fun () -> v731 (); v730) ()
        let v735 : string = $"{v2}"
        let v738 : unit = ()
        let v739 : (unit -> unit) = closure9(v640, v735)
        let v740 : unit = (fun () -> v739 (); v738) ()
        let v743 : string = " }"
        let v744 : string = $"{v743}"
        let v747 : unit = ()
        let v748 : (unit -> unit) = closure9(v640, v744)
        let v749 : unit = (fun () -> v748 (); v747) ()
        let v752 : string = v640.l0
        let v753 : string = $"dice.accumulate_dice_rolls"
        let v754 : bool = v753 = ""
        let v811 : string =
            if v754 then
                let v755 : string = ""
                v755
            else
                let v756 : string = $"{v497} {v632} #{v638} %s{v753} / {v752}"
                let v759 : char list = []
                let v760 : (char list -> (char [])) = List.toArray
                let v761 : (char []) = v760 v759
                let v764 : string = v756.TrimStart v761 
                let v782 : char list = []
                let v783 : char list = '/' :: v782 
                let v786 : char list = ' ' :: v783 
                let v789 : (char list -> (char [])) = List.toArray
                let v790 : (char []) = v789 v786
                let v793 : string = v764.TrimEnd v790 
                v793
        let v812 : (string -> unit) = closure10()
        let v813 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v814 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v814 
        let _v813 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v815 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v815 
        let _v813 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v816 : string = v22.l0
        let v817 : bool = v816 = ""
        let v825 : string =
            if v817 then
                v811
            else
                let v818 : bool = v811 = ""
                if v818 then
                    let v819 : string = v22.l0
                    v819
                else
                    let v820 : string = v22.l0
                    let v821 : string = "\n"
                    let v822 : string = v820 + v821 
                    let v823 : string = v822 + v811 
                    v823
        let v826 : string = "&*$0"
        let v827 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v825 v826 
        let v828 : string = $"$0.chars()"
        let v829 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v827 v828 
        let v830 : string = "v829"
        let v831 : _ = Fable.Core.RustInterop.emitRustExpr () v830 
        let v832 : string = "v831.collect::<Vec<_>>()"
        let v833 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v832 
        let v834 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v835 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v833 v834 
        let v836 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v837 : bool = Fable.Core.RustInterop.emitRustExpr v835 v836 
        let v838 : string = "x"
        let v839 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v838 
        let v840 : string = "String::from_iter($0)"
        let v841 : std_string_String = Fable.Core.RustInterop.emitRustExpr v839 v840 
        let v842 : string = "true; $0 }).collect::<Vec<_>>()"
        let v843 : bool = Fable.Core.RustInterop.emitRustExpr v841 v842 
        let v844 : string = "_vec_map"
        let v845 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v844 
        let v846 : string = "$0.len()"
        let v847 : unativeint = Fable.Core.RustInterop.emitRustExpr v845 v846 
        let v848 : (unativeint -> int32) = int32
        let v849 : int32 = v848 v847
        let v850 : string = ""
        let v851 : bool = v811 <> v850 
        let v855 : bool =
            if v851 then
                let v854 : bool = v849 <= 1
                v854
            else
                false
        if v855 then
            v22.l0 <- v825
            ()
        else
            v22.l0 <- v850
            let v856 : string = "true; $0.into_iter().for_each(|x| { //"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v845 v856 
            let v858 : string = "x"
            let v859 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v861 : string = $"true;"
            let v862 : bool = Fable.Core.RustInterop.emitRustExpr () v861 
            let v863 : string = "true; }}); { //"
            let v864 : bool = Fable.Core.RustInterop.emitRustExpr () v863 
            ()
        let _v813 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v812 v811
        let _v813 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v812 v811
        let _v813 = () 
        #endif
#else
        v812 v811
        let _v813 = () 
        #endif
        _v813 
        let v865 : (string -> unit) = v20.l0
        v865 v811
and method11 (v0 : int8, v1 : UH0, v2 : uint64) : US4 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure16(v2, v0, v4)
        let v7 : unit = (fun () -> v6 (); v5) ()
        US4_0(v4, v1)
    else
        match v1 with
        | UH0_1(v873, v874) -> (* Cons *)
            let v875 : bool = v873 > 1uy
            if v875 then
                let v876 : uint64 = 1UL
                let v877 : (unit -> UH1) = closure17()
                let v878 : UH1 = UH1_0(v876, v877)
                let v879 : US5 = method12(v0, v878)
                let v883 : uint64 =
                    match v879 with
                    | US5_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US5_0(v880) -> (* Some *)
                        v880
                let v884 : uint8 = v873 - 1uy
                let v885 : uint64 = uint64 v884
                let v886 : uint64 = v885 * v883
                let v887 : unit = ()
                let v888 : (unit -> unit) = closure81(v2, v0, v873, v886)
                let v889 : unit = (fun () -> v888 (); v887) ()
                let v1786 : uint64 = v2 + v886
                let v1787 : int8 = v0 - 1y
                method11(v1787, v874, v1786)
            else
                let v1789 : unit = ()
                let v1790 : (unit -> unit) = closure82(v2, v0, v873)
                let v1791 : unit = (fun () -> v1790 (); v1789) ()
                let v2655 : int8 = v0 - 1y
                method11(v2655, v874, v2)
        | UH0_0 -> (* Nil *)
            US4_1
and closure83 (v0 : uint64, v1 : UH0, v2 : uint64 option) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure2()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut0, v53 : Mut1, v54 : Mut2, v55 : Mut3, v56 : Mut4, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 1 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure6(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure7(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure8(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method5()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure7(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure8(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method5()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure7(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure8(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure7(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure8(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method6()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure7(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure8(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method6()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure7(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure8(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method6()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Debug"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_bright_blue"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_bright_blue"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_bright_blue"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[94m"
        let v621 : string = method7()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[94m"
        let v625 : string = method7()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[94m"
        let v629 : string = method7()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = $"%A{v1}"
        let v642 : string = method8()
        let v643 : Mut3 = {l0 = v642} : Mut3
        let v644 : string = "{ "
        let v645 : string = $"{v644}"
        let v648 : unit = ()
        let v649 : (unit -> unit) = closure9(v643, v645)
        let v650 : unit = (fun () -> v649 (); v648) ()
        let v653 : string = "max"
        let v654 : string = $"{v653}"
        let v657 : unit = ()
        let v658 : (unit -> unit) = closure9(v643, v654)
        let v659 : unit = (fun () -> v658 (); v657) ()
        let v662 : string = " = "
        let v663 : string = $"{v662}"
        let v666 : unit = ()
        let v667 : (unit -> unit) = closure9(v643, v663)
        let v668 : unit = (fun () -> v667 (); v666) ()
        let v671 : string = $"{v0}"
        let v674 : unit = ()
        let v675 : (unit -> unit) = closure9(v643, v671)
        let v676 : unit = (fun () -> v675 (); v674) ()
        let v679 : string = "; "
        let v680 : string = $"{v679}"
        let v683 : unit = ()
        let v684 : (unit -> unit) = closure9(v643, v680)
        let v685 : unit = (fun () -> v684 (); v683) ()
        let v688 : string = "rolls"
        let v689 : string = $"{v688}"
        let v692 : unit = ()
        let v693 : (unit -> unit) = closure9(v643, v689)
        let v694 : unit = (fun () -> v693 (); v692) ()
        let v697 : string = $"{v662}"
        let v700 : unit = ()
        let v701 : (unit -> unit) = closure9(v643, v697)
        let v702 : unit = (fun () -> v701 (); v700) ()
        let v705 : string = $"{v639}"
        let v708 : unit = ()
        let v709 : (unit -> unit) = closure9(v643, v705)
        let v710 : unit = (fun () -> v709 (); v708) ()
        let v713 : string = $"{v679}"
        let v716 : unit = ()
        let v717 : (unit -> unit) = closure9(v643, v713)
        let v718 : unit = (fun () -> v717 (); v716) ()
        let v721 : string = "result"
        let v722 : string = $"{v721}"
        let v725 : unit = ()
        let v726 : (unit -> unit) = closure9(v643, v722)
        let v727 : unit = (fun () -> v726 (); v725) ()
        let v730 : string = $"{v662}"
        let v733 : unit = ()
        let v734 : (unit -> unit) = closure9(v643, v730)
        let v735 : unit = (fun () -> v734 (); v733) ()
        let v738 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v739 : string = "format!(\"{:#?}\", $0)"
        let v740 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v739 
        let v741 : string = "fable_library_rust::String_::fromString($0)"
        let v742 : string = Fable.Core.RustInterop.emitRustExpr v740 v741 
        let _v738 = v742 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v743 : string = "format!(\"{:#?}\", $0)"
        let v744 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v743 
        let v745 : string = "fable_library_rust::String_::fromString($0)"
        let v746 : string = Fable.Core.RustInterop.emitRustExpr v744 v745 
        let _v738 = v746 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v747 : string = "format!(\"{:#?}\", $0)"
        let v748 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v747 
        let v749 : string = "fable_library_rust::String_::fromString($0)"
        let v750 : string = Fable.Core.RustInterop.emitRustExpr v748 v749 
        let _v738 = v750 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v751 : string = $"%A{v2}"
        let _v738 = v751 
        #endif
#if FABLE_COMPILER_PYTHON
        let v754 : string = $"%A{v2}"
        let _v738 = v754 
        #endif
#else
        let v757 : string = $"%A{v2}"
        let _v738 = v757 
        #endif
        let v760 : string = _v738 
        let v765 : string = $"{v760}"
        let v768 : unit = ()
        let v769 : (unit -> unit) = closure9(v643, v765)
        let v770 : unit = (fun () -> v769 (); v768) ()
        let v773 : string = " }"
        let v774 : string = $"{v773}"
        let v777 : unit = ()
        let v778 : (unit -> unit) = closure9(v643, v774)
        let v779 : unit = (fun () -> v778 (); v777) ()
        let v782 : string = v643.l0
        let v783 : string = "dice_contract.roll_within_bounds"
        let v784 : string = $"{v497} {v632} #{v638} %s{v783} / {v782}"
        let v787 : char list = []
        let v788 : (char list -> (char [])) = List.toArray
        let v789 : (char []) = v788 v787
        let v792 : string = v784.TrimStart v789 
        let v810 : char list = []
        let v811 : char list = '/' :: v810 
        let v814 : char list = ' ' :: v811 
        let v817 : (char list -> (char [])) = List.toArray
        let v818 : (char []) = v817 v814
        let v821 : string = v792.TrimEnd v818 
        let v839 : (string -> unit) = closure10()
        let v840 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v841 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v821 v841 
        let _v840 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v842 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v821 v842 
        let _v840 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v843 : string = v22.l0
        let v844 : bool = v843 = ""
        let v852 : string =
            if v844 then
                v821
            else
                let v845 : bool = v821 = ""
                if v845 then
                    let v846 : string = v22.l0
                    v846
                else
                    let v847 : string = v22.l0
                    let v848 : string = "\n"
                    let v849 : string = v847 + v848 
                    let v850 : string = v849 + v821 
                    v850
        let v853 : string = "&*$0"
        let v854 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v852 v853 
        let v855 : string = $"$0.chars()"
        let v856 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v854 v855 
        let v857 : string = "v856"
        let v858 : _ = Fable.Core.RustInterop.emitRustExpr () v857 
        let v859 : string = "v858.collect::<Vec<_>>()"
        let v860 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v859 
        let v861 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v862 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v860 v861 
        let v863 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v864 : bool = Fable.Core.RustInterop.emitRustExpr v862 v863 
        let v865 : string = "x"
        let v866 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v865 
        let v867 : string = "String::from_iter($0)"
        let v868 : std_string_String = Fable.Core.RustInterop.emitRustExpr v866 v867 
        let v869 : string = "true; $0 }).collect::<Vec<_>>()"
        let v870 : bool = Fable.Core.RustInterop.emitRustExpr v868 v869 
        let v871 : string = "_vec_map"
        let v872 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v871 
        let v873 : string = "$0.len()"
        let v874 : unativeint = Fable.Core.RustInterop.emitRustExpr v872 v873 
        let v875 : (unativeint -> int32) = int32
        let v876 : int32 = v875 v874
        let v877 : string = ""
        let v878 : bool = v821 <> v877 
        let v882 : bool =
            if v878 then
                let v881 : bool = v876 <= 1
                v881
            else
                false
        if v882 then
            v22.l0 <- v852
            ()
        else
            v22.l0 <- v877
            let v883 : string = "true; $0.into_iter().for_each(|x| { //"
            let v884 : bool = Fable.Core.RustInterop.emitRustExpr v872 v883 
            let v885 : string = "x"
            let v886 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v885 
            let v887 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v886 v887 
            let v888 : string = $"true;"
            let v889 : bool = Fable.Core.RustInterop.emitRustExpr () v888 
            let v890 : string = "true; }}); { //"
            let v891 : bool = Fable.Core.RustInterop.emitRustExpr () v890 
            ()
        let _v840 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v839 v821
        let _v840 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v839 v821
        let _v840 = () 
        #endif
#else
        v839 v821
        let _v840 = () 
        #endif
        _v840 
        let v892 : (string -> unit) = v20.l0
        v892 v821
and closure84 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure2()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 1 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure6(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure7(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure8(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure7(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure8(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method5()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure7(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure8(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure7(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure8(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure7(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure8(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure7(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure8(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Debug"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_bright_blue"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_bright_blue"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_bright_blue"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[94m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[94m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[94m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = ""
        let v640 : (string -> unit) = closure10()
        let v641 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v642 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v642 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v643 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v643 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v644 : string = v19.l0
        let v645 : bool = v644 = ""
        let v653 : string =
            if v645 then
                v639
            else
                let v646 : bool = v639 = ""
                if v646 then
                    let v647 : string = v19.l0
                    v647
                else
                    let v648 : string = v19.l0
                    let v649 : string = "\n"
                    let v650 : string = v648 + v649 
                    let v651 : string = v650 + v639 
                    v651
        let v654 : string = "&*$0"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v653 v654 
        let v656 : string = $"$0.chars()"
        let v657 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v655 v656 
        let v658 : string = "v657"
        let v659 : _ = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "v659.collect::<Vec<_>>()"
        let v661 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v660 
        let v662 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v663 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v661 v662 
        let v664 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v665 : bool = Fable.Core.RustInterop.emitRustExpr v663 v664 
        let v666 : string = "x"
        let v667 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "String::from_iter($0)"
        let v669 : std_string_String = Fable.Core.RustInterop.emitRustExpr v667 v668 
        let v670 : string = "true; $0 }).collect::<Vec<_>>()"
        let v671 : bool = Fable.Core.RustInterop.emitRustExpr v669 v670 
        let v672 : string = "_vec_map"
        let v673 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v672 
        let v674 : string = "$0.len()"
        let v675 : unativeint = Fable.Core.RustInterop.emitRustExpr v673 v674 
        let v676 : (unativeint -> int32) = int32
        let v677 : int32 = v676 v675
        let v678 : bool = v639 <> v639 
        let v682 : bool =
            if v678 then
                let v681 : bool = v677 <= 1
                v681
            else
                false
        if v682 then
            v19.l0 <- v653
            ()
        else
            v19.l0 <- v639
            let v683 : string = "true; $0.into_iter().for_each(|x| { //"
            let v684 : bool = Fable.Core.RustInterop.emitRustExpr v673 v683 
            let v685 : string = "x"
            let v686 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v685 
            let v687 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v686 v687 
            let v688 : string = $"true;"
            let v689 : bool = Fable.Core.RustInterop.emitRustExpr () v688 
            let v690 : string = "true; }}); { //"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr () v690 
            ()
        let _v641 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v640 v639
        let _v641 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v640 v639
        let _v641 = () 
        #endif
#else
        v640 v639
        let _v641 = () 
        #endif
        _v641 
        let v692 : (string -> unit) = v17.l0
        v692 v639
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
    let v69 : string = "        Self((old_state.version, old_state.seeds)) //"
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
    let _result = struct (1u, v87) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
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
    let v913 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v913 
    let v914 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v914 
    let v915 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v915 
    let v916 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v916 
    let v917 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v918 : bool = Fable.Core.RustInterop.emitRustExpr () v917 
    let v919 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v920 : bool = Fable.Core.RustInterop.emitRustExpr () v919 
    let v921 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v921 
    let v922 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v922 
    let v923 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v923 
    let v924 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v924 
    let v925 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v925 
    let v926 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v926 
    let v927 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v928 : bool = Fable.Core.RustInterop.emitRustExpr () v927 
    let v929 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v930 : bool = Fable.Core.RustInterop.emitRustExpr () v929 
    let v931 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v931 
    let v932 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v932 
    let v933 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v933 
    let v934 : string = $"key"
    let v935 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v934 
    let v936 : string = $"proof"
    let v937 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v936 
    let v938 : string = $"max"
    let v939 : uint64 = Fable.Core.RustInterop.emitRustExpr () v938 
    let v940 : string = $"&self.0.1"
    let v941 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v940 
    let v942 : string = $"v941.iter().map(|x| *x).collect::<Vec<u8>>()"
    let v943 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v942 
    let v944 : string = $"near_sdk::env::random_seed()"
    let v945 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v944 
    let v946 : string = $"near_sdk::env::block_timestamp()"
    let v947 : uint64 = Fable.Core.RustInterop.emitRustExpr () v946 
    let v948 : string = $"near_sdk::env::block_height()"
    let v949 : uint64 = Fable.Core.RustInterop.emitRustExpr () v948 
    let v950 : string = $"near_sdk::env::epoch_height()"
    let v951 : uint64 = Fable.Core.RustInterop.emitRustExpr () v950 
    let v952 : string = $"near_sdk::env::account_balance()"
    let v953 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v952 
    let v954 : string = $"near_sdk::env::signer_account_id()"
    let v955 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v954 
    let v956 : string = $"v951.to_le_bytes()"
    let v957 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v956 
    let v958 : string = $"v957.to_vec()"
    let v959 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v958 
    let v960 : string = $"v949.to_le_bytes()"
    let v961 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v960 
    let v962 : string = $"v961.to_vec()"
    let v963 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v962 
    let v964 : string = $"v947.to_le_bytes()"
    let v965 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v964 
    let v966 : string = $"v965.to_vec()"
    let v967 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v966 
    let v968 : string = "$0.as_yoctonear()"
    let v969 : u128 = Fable.Core.RustInterop.emitRustExpr v953 v968 
    let v970 : string = $"v969.to_le_bytes()"
    let v971 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v970 
    let v972 : string = $"v971.to_vec()"
    let v973 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v972 
    let v974 : string = $"v955.as_bytes()"
    let v975 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v974 
    let v976 : string = $"v975.to_vec()"
    let v977 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v976 
    let v978 : string = $"$0.into_bytes()"
    let v979 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v937 v978 
    let v980 : string = $"$0.into_bytes()"
    let v981 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v935 v980 
    let v982 : (Vec<uint8> []) = [|v945; v943; v959; v963; v967; v973; v977; v979; v981|]
    let v983 : string = "$0.to_vec()"
    let v984 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v982 v983 
    let v985 : string = $"v984.concat()"
    let v986 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v985 
    let v987 : string = "$0.len()"
    let v988 : unativeint = Fable.Core.RustInterop.emitRustExpr v986 v987 
    let v989 : string = $"near_sdk::env::keccak512(&v986)"
    let v990 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v989 
    let v991 : string = "self.contribute_seed(v990.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v991 
    let v992 : string = "let hash_stream = Util::vec_u8_to_stream(v990.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v992 
    let v993 : string = "let rolls_list = Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)( //"
    Fable.Core.RustInterop.emitRustExpr () v993 
    let v994 : string = "    hash_stream.into(), //"
    Fable.Core.RustInterop.emitRustExpr () v994 
    let v995 : string = ")); //"
    Fable.Core.RustInterop.emitRustExpr () v995 
    let v996 : string = "Util::list_u8_to_vec(rolls_list.clone().into())"
    let v997 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v996 
    let v998 : unit = ()
    let v999 : (unit -> unit) = closure12(v943, v935, v937, v939, v945, v947, v949, v951, v953, v955, v986, v988, v990, v997)
    let v1000 : unit = (fun () -> v999 (); v998) ()
    let v2354 : string = "let sequential_roll = //"
    Fable.Core.RustInterop.emitRustExpr () v2354 
    let v2355 : string = "    dice_contract_lib::Dice::create_sequential_roller(rolls_list.into()); //"
    Fable.Core.RustInterop.emitRustExpr () v2355 
    let v2356 : string = "let result = dice_contract_lib::Dice::roll_progressively //"
    Fable.Core.RustInterop.emitRustExpr () v2356 
    let v2357 : string = "    (sequential_roll)(true)(max); //"
    Fable.Core.RustInterop.emitRustExpr () v2357 
    let v2358 : unit = ()
    let v2359 : (unit -> unit) = closure13()
    let v2360 : unit = (fun () -> v2359 (); v2358) ()
    let v3054 : string = "result as u64"
    let v3055 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3054 
    let v3056 : string = "v3055 //"
    Fable.Core.RustInterop.emitRustExpr () v3056 
    let v3057 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3057 
    let v3058 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3058 
    let v3059 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3059 
    let v3060 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3060 
    let v3061 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v3061 
    let v3062 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 4uy"
    let v3063 : bool = Fable.Core.RustInterop.emitRustExpr () v3062 
    let v3064 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 4uy"
    let v3065 : bool = Fable.Core.RustInterop.emitRustExpr () v3064 
    let v3066 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v3066 
    let v3067 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v3067 
    let v3068 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v3068 
    let v3069 : string = $"max"
    let v3070 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3069 
    let v3071 : string = $"rolls"
    let v3072 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v3071 
    let v3073 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v3074 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v3072 v3073 
    let v3075 : uint8 list = v3074 |> Array.toList
    let v3076 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v3077 : (uint8 -> (UH0 -> UH0)) = method9()
    let v3078 : (uint8 list -> (UH0 -> UH0)) = v3076 v3077
    let v3079 : (UH0 -> UH0) = v3078 v3075
    let v3080 : UH0 = UH0_0
    let v3081 : UH0 = v3079 v3080
    let v3086 : int8 = 0y
    let v3087 : int8 = method10(v3081, v3086)
    let v3088 : int8 = v3087 - 1y
    let v3089 : uint64 = 0UL
    let v3090 : US4 = method11(v3088, v3081, v3089)
    let v3100 : US5 =
        match v3090 with
        | US4_0(v3091, v3092) -> (* Some *)
            let v3093 : bool = v3091 >= 1UL
            let v3095 : bool =
                if v3093 then
                    let v3094 : bool = v3091 <= v3070
                    v3094
                else
                    false
            if v3095 then
                US5_0(v3091)
            else
                US5_1
        | _ ->
            US5_1
    let v3107 : uint64 option =
        match v3100 with
        | US5_1 -> (* None *)
            let v3105 : uint64 option = None
            v3105
        | US5_0(v3101) -> (* Some *)
            let v3102 : uint64 option = Some v3101 
            v3102
    let v3108 : unit = ()
    let v3109 : (unit -> unit) = closure83(v3070, v3081, v3107)
    let v3110 : unit = (fun () -> v3109 (); v3108) ()
    let v4001 : unit = ()
    let v4002 : (unit -> unit) = closure84()
    let v4003 : unit = (fun () -> v4002 (); v4001) ()
    let v4697 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v3107 v4697 
    let v4698 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4698 
    let v4699 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4699 
    let v4700 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4700 
    let v4701 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 10uy / n: 2uy"
    let v4702 : bool = Fable.Core.RustInterop.emitRustExpr () v4701 
    let v4703 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 10uy / n: 2uy"
    let v4704 : bool = Fable.Core.RustInterop.emitRustExpr () v4703 
    let v4705 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v4705 
    let v4706 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v4706 
    let v4707 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v4707 
    let v4708 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v4708 
    let v4709 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v4709 
    let v4710 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v4710 
    let v4711 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v4711 
    let v4712 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v4712 
    let v4713 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v4713 
    let v4714 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4714 
    let v4715 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4715 
    let v4716 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 12uy / n: 1uy"
    let v4717 : bool = Fable.Core.RustInterop.emitRustExpr () v4716 
    let v4718 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 12uy / n: 1uy"
    let v4719 : bool = Fable.Core.RustInterop.emitRustExpr () v4718 
    let v4720 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v4720 
    let v4721 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v4721 
    let v4722 : string = "true; { (); // ?? / i': 1uy / n: 13uy"
    let v4723 : bool = Fable.Core.RustInterop.emitRustExpr () v4722 
    let v4724 : string = "true; { (); // ?? / i': 2uy / n: 13uy"
    let v4725 : bool = Fable.Core.RustInterop.emitRustExpr () v4724 
    let v4726 : string = "true; { (); // ?? / i': 3uy / n: 13uy"
    let v4727 : bool = Fable.Core.RustInterop.emitRustExpr () v4726 
    let v4728 : string = "true; { (); // ?? / i': 4uy / n: 13uy"
    let v4729 : bool = Fable.Core.RustInterop.emitRustExpr () v4728 
    let v4730 : string = "true; { (); // ?? / i': 5uy / n: 13uy"
    let v4731 : bool = Fable.Core.RustInterop.emitRustExpr () v4730 
    let v4732 : string = "true; { (); // ?? / i': 6uy / n: 13uy"
    let v4733 : bool = Fable.Core.RustInterop.emitRustExpr () v4732 
    let v4734 : string = "true; { (); // ?? / i': 7uy / n: 13uy"
    let v4735 : bool = Fable.Core.RustInterop.emitRustExpr () v4734 
    let v4736 : string = "true; { (); // ?? / i': 8uy / n: 13uy"
    let v4737 : bool = Fable.Core.RustInterop.emitRustExpr () v4736 
    let v4738 : string = "true; { (); // ?? / i': 9uy / n: 13uy"
    let v4739 : bool = Fable.Core.RustInterop.emitRustExpr () v4738 
    let v4740 : string = "true; { (); // ?? / i': 10uy / n: 13uy"
    let v4741 : bool = Fable.Core.RustInterop.emitRustExpr () v4740 
    let v4742 : string = "true; { (); // ?? / i': 11uy / n: 13uy"
    let v4743 : bool = Fable.Core.RustInterop.emitRustExpr () v4742 
    let v4744 : string = "true; { (); // ?? / i': 12uy / n: 13uy"
    let v4745 : bool = Fable.Core.RustInterop.emitRustExpr () v4744 
    let v4746 : string = "true; { (); // ?? / i': 13uy / n: 13uy"
    let v4747 : bool = Fable.Core.RustInterop.emitRustExpr () v4746 
    let v4748 : string = "true; { { (); // ? / i': 14uy / n: 13uy"
    let v4749 : bool = Fable.Core.RustInterop.emitRustExpr () v4748 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
