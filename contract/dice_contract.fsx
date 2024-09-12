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
and closure14 (v0 : uint64, v1 : Vec<uint8>) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure2()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 1 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure6(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure7(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure8(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method5()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure7(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure8(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method5()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure7(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure8(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure7(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure8(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method6()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure7(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure8(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method6()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure7(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure8(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method6()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Debug"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_blue"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_bright_blue"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_bright_blue"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[94m"
        let v620 : string = method7()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[94m"
        let v624 : string = method7()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[94m"
        let v628 : string = method7()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = $"%A{v1}"
        let v641 : string = method8()
        let v642 : Mut3 = {l0 = v641} : Mut3
        let v643 : string = "{ "
        let v644 : string = $"{v643}"
        let v647 : unit = ()
        let v648 : (unit -> unit) = closure9(v642, v644)
        let v649 : unit = (fun () -> v648 (); v647) ()
        let v652 : string = "max"
        let v653 : string = $"{v652}"
        let v656 : unit = ()
        let v657 : (unit -> unit) = closure9(v642, v653)
        let v658 : unit = (fun () -> v657 (); v656) ()
        let v661 : string = " = "
        let v662 : string = $"{v661}"
        let v665 : unit = ()
        let v666 : (unit -> unit) = closure9(v642, v662)
        let v667 : unit = (fun () -> v666 (); v665) ()
        let v670 : string = $"{v0}"
        let v673 : unit = ()
        let v674 : (unit -> unit) = closure9(v642, v670)
        let v675 : unit = (fun () -> v674 (); v673) ()
        let v678 : string = "; "
        let v679 : string = $"{v678}"
        let v682 : unit = ()
        let v683 : (unit -> unit) = closure9(v642, v679)
        let v684 : unit = (fun () -> v683 (); v682) ()
        let v687 : string = "rolls"
        let v688 : string = $"{v687}"
        let v691 : unit = ()
        let v692 : (unit -> unit) = closure9(v642, v688)
        let v693 : unit = (fun () -> v692 (); v691) ()
        let v696 : string = $"{v661}"
        let v699 : unit = ()
        let v700 : (unit -> unit) = closure9(v642, v696)
        let v701 : unit = (fun () -> v700 (); v699) ()
        let v704 : string = $"{v638}"
        let v707 : unit = ()
        let v708 : (unit -> unit) = closure9(v642, v704)
        let v709 : unit = (fun () -> v708 (); v707) ()
        let v712 : string = " }"
        let v713 : string = $"{v712}"
        let v716 : unit = ()
        let v717 : (unit -> unit) = closure9(v642, v713)
        let v718 : unit = (fun () -> v717 (); v716) ()
        let v721 : string = v642.l0
        let v722 : string = $"dice_contract.roll_within_bounds"
        let v723 : bool = v722 = ""
        let v780 : string =
            if v723 then
                let v724 : string = ""
                v724
            else
                let v725 : string = $"{v496} {v631} #{v637} %s{v722} / {v721}"
                let v728 : char list = []
                let v729 : (char list -> (char [])) = List.toArray
                let v730 : (char []) = v729 v728
                let v733 : string = v725.TrimStart v730 
                let v751 : char list = []
                let v752 : char list = '/' :: v751 
                let v755 : char list = ' ' :: v752 
                let v758 : (char list -> (char [])) = List.toArray
                let v759 : (char []) = v758 v755
                let v762 : string = v733.TrimEnd v759 
                v762
        let v781 : (string -> unit) = closure10()
        let v782 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v783 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v783 
        let _v782 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v784 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v784 
        let _v782 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v785 : string = v21.l0
        let v786 : bool = v785 = ""
        let v794 : string =
            if v786 then
                v780
            else
                let v787 : bool = v780 = ""
                if v787 then
                    let v788 : string = v21.l0
                    v788
                else
                    let v789 : string = v21.l0
                    let v790 : string = "\n"
                    let v791 : string = v789 + v790 
                    let v792 : string = v791 + v780 
                    v792
        let v795 : string = "&*$0"
        let v796 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v794 v795 
        let v797 : string = $"$0.chars()"
        let v798 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v796 v797 
        let v799 : string = "v798"
        let v800 : _ = Fable.Core.RustInterop.emitRustExpr () v799 
        let v801 : string = "v800.collect::<Vec<_>>()"
        let v802 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v801 
        let v803 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v804 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v802 v803 
        let v805 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v806 : bool = Fable.Core.RustInterop.emitRustExpr v804 v805 
        let v807 : string = "x"
        let v808 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v807 
        let v809 : string = "String::from_iter($0)"
        let v810 : std_string_String = Fable.Core.RustInterop.emitRustExpr v808 v809 
        let v811 : string = "true; $0 }).collect::<Vec<_>>()"
        let v812 : bool = Fable.Core.RustInterop.emitRustExpr v810 v811 
        let v813 : string = "_vec_map"
        let v814 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v813 
        let v815 : string = "$0.len()"
        let v816 : unativeint = Fable.Core.RustInterop.emitRustExpr v814 v815 
        let v817 : (unativeint -> int32) = int32
        let v818 : int32 = v817 v816
        let v819 : string = ""
        let v820 : bool = v780 <> v819 
        let v824 : bool =
            if v820 then
                let v823 : bool = v818 <= 1
                v823
            else
                false
        if v824 then
            v21.l0 <- v794
            ()
        else
            v21.l0 <- v819
            let v825 : string = "true; $0.into_iter().for_each(|x| { //"
            let v826 : bool = Fable.Core.RustInterop.emitRustExpr v814 v825 
            let v827 : string = "x"
            let v828 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v827 
            let v829 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v828 v829 
            let v830 : string = $"true;"
            let v831 : bool = Fable.Core.RustInterop.emitRustExpr () v830 
            let v832 : string = "true; }}); { //"
            let v833 : bool = Fable.Core.RustInterop.emitRustExpr () v832 
            ()
        let _v782 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v781 v780
        let _v782 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v781 v780
        let _v782 = () 
        #endif
#else
        v781 v780
        let _v782 = () 
        #endif
        _v782 
        let v834 : (string -> unit) = v19.l0
        v834 v780
and closure15 () () : unit =
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
    let v8 : string = "                dice_contract_lib::Dice::UH1::UH1_1(*n, Self::stream_u8_to_list(f()).into()) //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "            dice_contract_lib::Dice::UH0::UH0_1 => dice_contract_lib::Dice::UH1::UH1_0, //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "    fn list_u8_to_vec( //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "        s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH1>, //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "    ) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "        match s.as_ref() { //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "            dice_contract_lib::Dice::UH1::UH1_1(n, f) => { //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "                let mut v = Self::list_u8_to_vec(f.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "                v.insert(0, *n); //"
    Fable.Core.RustInterop.emitRustExpr () v19 
    let v20 : string = "                v //"
    Fable.Core.RustInterop.emitRustExpr () v20 
    let v21 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "            dice_contract_lib::Dice::UH1::UH1_0 => vec![], //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "    fn vec_u8_to_list(v: Vec<u8>) -> dice_contract_lib::Dice::UH1 { //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "        v.iter() //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "            .rev() //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "            .fold(dice_contract_lib::Dice::UH1::UH1_0, |acc, x| { //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "                dice_contract_lib::Dice::UH1::UH1_1(*x, acc.into()) //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "            }) //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "    fn vec_u8_to_stream(v: Vec<u8>) -> dice_contract_lib::Dice::UH0 { //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "        v.iter() //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "            .rev() //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "            .fold(dice_contract_lib::Dice::UH0::UH0_1, |acc, x| { //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "                dice_contract_lib::Dice::UH0::UH0_0( //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "                    *x, //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "                    fable_library_rust::Native_::Func0::new(move || acc.clone().into()), //"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "                ) //"
    Fable.Core.RustInterop.emitRustExpr () v39 
    let v40 : string = "            }) //"
    Fable.Core.RustInterop.emitRustExpr () v40 
    let v41 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "pub struct OldState { //"
    Fable.Core.RustInterop.emitRustExpr () v48 
    let v49 : string = "    version: u32, //"
    Fable.Core.RustInterop.emitRustExpr () v49 
    let v50 : string = "    seeds: near_sdk::store::vec::Vector<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v54 
    let v55 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v55 
    let v56 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v56 
    let v57 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v57 
    let v58 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v58 
    let v59 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v59 
    let v60 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v63 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v63 
    let v64 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v64 
    let v65 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v65 
    let v66 : string = "        Self((old_state.version, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v66 
    let v67 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v68 
    let v69 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v69 
    let v70 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v70 
    let v71 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v71 
    let v72 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "true; /*"
    let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v78 : string = "true; */"
    let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "seeds"
    let v81 : string = "b\"" + v80 + "\""
    let v82 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v81 
    let v83 : string = "near_sdk::store::vec::Vector::new(v82)"
    let v84 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr () v83 
    let _result = struct (1u, v84) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v85 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v85 
    let v86 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v91 : bool = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = $"&mut self.0.1"
    let v96 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = $"seed"
    let v98 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : string = "    v96.extend(v98); //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : unativeint = 100 |> unativeint 
    let v103 : string = "(v96.len() as i32) - v100 as i32"
    let v104 : int32 = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : bool = v104 > 0
    if v105 then
        let v106 : string = "v96.drain(0..$0 as u32).collect()"
        let v107 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v104 v106 
        let v108 : unit = ()
        let v109 : (unit -> unit) = closure1(v107)
        let v110 : unit = (fun () -> v109 (); v108) ()
        ()
    let v910 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v910 
    let v911 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v911 
    let v912 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v912 
    let v913 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v913 
    let v914 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v915 : bool = Fable.Core.RustInterop.emitRustExpr () v914 
    let v916 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v917 : bool = Fable.Core.RustInterop.emitRustExpr () v916 
    let v918 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v918 
    let v919 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v919 
    let v920 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v920 
    let v921 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v921 
    let v922 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v922 
    let v923 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v923 
    let v924 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v925 : bool = Fable.Core.RustInterop.emitRustExpr () v924 
    let v926 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v927 : bool = Fable.Core.RustInterop.emitRustExpr () v926 
    let v928 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v928 
    let v929 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v929 
    let v930 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v930 
    let v931 : string = $"key"
    let v932 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v931 
    let v933 : string = $"proof"
    let v934 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v933 
    let v935 : string = $"max"
    let v936 : uint64 = Fable.Core.RustInterop.emitRustExpr () v935 
    let v937 : string = $"&self.0.1"
    let v938 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v937 
    let v939 : string = $"v938.iter().map(|x| *x).collect::<Vec<u8>>()"
    let v940 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v939 
    let v941 : string = $"near_sdk::env::random_seed()"
    let v942 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v941 
    let v943 : string = $"near_sdk::env::block_timestamp()"
    let v944 : uint64 = Fable.Core.RustInterop.emitRustExpr () v943 
    let v945 : string = $"near_sdk::env::block_height()"
    let v946 : uint64 = Fable.Core.RustInterop.emitRustExpr () v945 
    let v947 : string = $"near_sdk::env::epoch_height()"
    let v948 : uint64 = Fable.Core.RustInterop.emitRustExpr () v947 
    let v949 : string = $"near_sdk::env::account_balance()"
    let v950 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v949 
    let v951 : string = $"near_sdk::env::signer_account_id()"
    let v952 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v951 
    let v953 : string = $"v948.to_le_bytes()"
    let v954 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v953 
    let v955 : string = $"v954.to_vec()"
    let v956 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v955 
    let v957 : string = $"v946.to_le_bytes()"
    let v958 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v957 
    let v959 : string = $"v958.to_vec()"
    let v960 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v959 
    let v961 : string = $"v944.to_le_bytes()"
    let v962 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v961 
    let v963 : string = $"v962.to_vec()"
    let v964 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v963 
    let v965 : string = "$0.as_yoctonear()"
    let v966 : u128 = Fable.Core.RustInterop.emitRustExpr v950 v965 
    let v967 : string = $"v966.to_le_bytes()"
    let v968 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v967 
    let v969 : string = $"v968.to_vec()"
    let v970 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v969 
    let v971 : string = $"v952.as_bytes()"
    let v972 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v971 
    let v973 : string = $"v972.to_vec()"
    let v974 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v973 
    let v975 : string = $"$0.into_bytes()"
    let v976 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v934 v975 
    let v977 : string = $"$0.into_bytes()"
    let v978 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v932 v977 
    let v979 : (Vec<uint8> []) = [|v942; v940; v956; v960; v964; v970; v974; v976; v978|]
    let v980 : string = "$0.to_vec()"
    let v981 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v979 v980 
    let v982 : string = $"v981.concat()"
    let v983 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v982 
    let v984 : string = "$0.len()"
    let v985 : unativeint = Fable.Core.RustInterop.emitRustExpr v983 v984 
    let v986 : string = $"near_sdk::env::keccak512(&v983)"
    let v987 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v986 
    let v988 : string = "    self.contribute_seed(v987.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v988 
    let v989 : string = "    let hash_stream = Util::vec_u8_to_stream(v987.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v989 
    let v990 : string = "    let rolls_list = Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)( //"
    Fable.Core.RustInterop.emitRustExpr () v990 
    let v991 : string = "        hash_stream.into(), //"
    Fable.Core.RustInterop.emitRustExpr () v991 
    let v992 : string = "    )); //"
    Fable.Core.RustInterop.emitRustExpr () v992 
    let v993 : string = "Util::list_u8_to_vec(rolls_list.clone().into())"
    let v994 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v993 
    let v995 : unit = ()
    let v996 : (unit -> unit) = closure12(v940, v932, v934, v936, v942, v944, v946, v948, v950, v952, v983, v985, v987, v994)
    let v997 : unit = (fun () -> v996 (); v995) ()
    let v2351 : string = "    let sequential_roll = //"
    Fable.Core.RustInterop.emitRustExpr () v2351 
    let v2352 : string = "        dice_contract_lib::Dice::create_sequential_roller(rolls_list.into()); //"
    Fable.Core.RustInterop.emitRustExpr () v2352 
    let v2353 : string = "    let result = dice_contract_lib::Dice::roll_progressively //"
    Fable.Core.RustInterop.emitRustExpr () v2353 
    let v2354 : string = "        (sequential_roll)(true)(max); //"
    Fable.Core.RustInterop.emitRustExpr () v2354 
    let v2355 : unit = ()
    let v2356 : (unit -> unit) = closure13()
    let v2357 : unit = (fun () -> v2356 (); v2355) ()
    let v3051 : string = "result as u64"
    let v3052 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3051 
    let v3053 : string = "v3052 //"
    Fable.Core.RustInterop.emitRustExpr () v3053 
    let v3054 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3054 
    let v3055 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3055 
    let v3056 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3056 
    let v3057 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3057 
    let v3058 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v3058 
    let v3059 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 4uy"
    let v3060 : bool = Fable.Core.RustInterop.emitRustExpr () v3059 
    let v3061 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 4uy"
    let v3062 : bool = Fable.Core.RustInterop.emitRustExpr () v3061 
    let v3063 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v3063 
    let v3064 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v3064 
    let v3065 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v3065 
    let v3066 : string = $"max"
    let v3067 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3066 
    let v3068 : string = $"rolls"
    let v3069 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v3068 
    let v3070 : unit = ()
    let v3071 : (unit -> unit) = closure14(v3067, v3069)
    let v3072 : unit = (fun () -> v3071 (); v3070) ()
    let v3906 : string = "    let rolls = Util::vec_u8_to_list($0); //"
    Fable.Core.RustInterop.emitRustExpr v3069 v3906 
    let v3907 : string = "    let result = //"
    Fable.Core.RustInterop.emitRustExpr () v3907 
    let v3908 : string = "        dice_contract_lib::Dice::roll_within_bounds(max)(rolls.into()); //"
    Fable.Core.RustInterop.emitRustExpr () v3908 
    let v3909 : unit = ()
    let v3910 : (unit -> unit) = closure15()
    let v3911 : unit = (fun () -> v3910 (); v3909) ()
    let v4605 : string = "result"
    let v4606 : uint64 option = Fable.Core.RustInterop.emitRustExpr () v4605 
    let v4607 : string = "v4606 //"
    Fable.Core.RustInterop.emitRustExpr () v4607 
    let v4608 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4608 
    let v4609 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4609 
    let v4610 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4610 
    let v4611 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4611 
    let v4612 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 10uy / n: 3uy"
    let v4613 : bool = Fable.Core.RustInterop.emitRustExpr () v4612 
    let v4614 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 10uy / n: 3uy"
    let v4615 : bool = Fable.Core.RustInterop.emitRustExpr () v4614 
    let v4616 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v4616 
    let v4617 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v4617 
    let v4618 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v4618 
    let v4619 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v4619 
    let v4620 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v4620 
    let v4621 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v4621 
    let v4622 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v4622 
    let v4623 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v4623 
    let v4624 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v4624 
    let v4625 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4625 
    let v4626 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4626 
    let v4627 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 13uy / n: 1uy"
    let v4628 : bool = Fable.Core.RustInterop.emitRustExpr () v4627 
    let v4629 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 13uy / n: 1uy"
    let v4630 : bool = Fable.Core.RustInterop.emitRustExpr () v4629 
    let v4631 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v4631 
    let v4632 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v4632 
    let v4633 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v4634 : bool = Fable.Core.RustInterop.emitRustExpr () v4633 
    let v4635 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v4636 : bool = Fable.Core.RustInterop.emitRustExpr () v4635 
    let v4637 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v4638 : bool = Fable.Core.RustInterop.emitRustExpr () v4637 
    let v4639 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v4640 : bool = Fable.Core.RustInterop.emitRustExpr () v4639 
    let v4641 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v4642 : bool = Fable.Core.RustInterop.emitRustExpr () v4641 
    let v4643 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v4644 : bool = Fable.Core.RustInterop.emitRustExpr () v4643 
    let v4645 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v4646 : bool = Fable.Core.RustInterop.emitRustExpr () v4645 
    let v4647 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v4648 : bool = Fable.Core.RustInterop.emitRustExpr () v4647 
    let v4649 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v4650 : bool = Fable.Core.RustInterop.emitRustExpr () v4649 
    let v4651 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v4652 : bool = Fable.Core.RustInterop.emitRustExpr () v4651 
    let v4653 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v4654 : bool = Fable.Core.RustInterop.emitRustExpr () v4653 
    let v4655 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v4656 : bool = Fable.Core.RustInterop.emitRustExpr () v4655 
    let v4657 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v4658 : bool = Fable.Core.RustInterop.emitRustExpr () v4657 
    let v4659 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v4660 : bool = Fable.Core.RustInterop.emitRustExpr () v4659 
    let v4661 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v4662 : bool = Fable.Core.RustInterop.emitRustExpr () v4661 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
