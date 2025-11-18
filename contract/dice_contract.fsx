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
    | US0_0 of f0_0 : int32
    | US0_1 of f1_0 : exn
and [<Struct>] US1 =
    | US1_0 of f0_0 : int32
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : unativeint
    | US2_1 of f1_0 : exn
and [<Struct>] US3 =
    | US3_0 of f0_0 : unativeint
    | US3_1
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
    | US4_3
    | US4_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US4}
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : int64
    | US6_1
and [<Struct>] US7 =
    | US7_0
    | US7_1
    | US7_2
and [<Struct>] US8 =
    | US8_0 of f0_0 : US7
    | US8_1 of f1_0 : US7
    | US8_2 of f2_0 : US7
    | US8_3 of f3_0 : US7
    | US8_4 of f4_0 : US7
    | US8_5 of f5_0 : US7
    | US8_6 of f6_0 : US7
and [<Struct>] US9 =
    | US9_0 of f0_0 : string
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : int64
    | US10_1 of f1_0 : exn
and [<Struct>] US11 =
    | US11_0 of f0_0 : Mut0 * f0_1 : Mut1 * f0_2 : Mut2 * f0_3 : Mut3 * f0_4 : Mut4 * f0_5 : int64 option
    | US11_1
and [<Struct>] US12 =
    | US12_0 of f0_0 : char
    | US12_1
and Mut5 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of uint8 * UH0
and UH1 =
    | UH1_0 of uint8 * (unit -> UH1)
    | UH1_1
and [<Struct>] US13 =
    | US13_0 of f0_0 : (unit -> UH1)
    | US13_1 of f1_0 : UH1
and Mut6 = {mutable l0 : US13}
and [<Struct>] US14 =
    | US14_0 of f0_0 : uint8
    | US14_1
and Mut7 = {mutable l0 : US14}
and [<Struct>] US15 =
    | US15_0 of f0_0 : uint64 * f0_1 : UH0
    | US15_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US16 =
    | US16_0 of f0_0 : uint64
    | US16_1
let rec closure1 (v0 : uint32) () : int32 =
    let v1 : int32 = v0 |> int32 
    v1
and closure2 () (v0 : int32) : US0 =
    US0_0(v0)
and closure3 () (v0 : (unit -> exn)) : exn =
    v0 ()
and closure4 () (v0 : exn) : US0 =
    US0_1(v0)
and method0 (v0 : uint32) : US0 =
    let v1 : (unit -> int32) = closure1(v0)
    let v2 : (int32 -> US0) = closure2()
    let v3 : ((unit -> exn) -> exn) = closure3()
    let v4 : (exn -> US0) = closure4()
    let v5 : US0 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and closure5 () () : unativeint =
    let v0 : unativeint = 100 |> unativeint 
    v0
and closure6 () (v0 : unativeint) : US2 =
    US2_0(v0)
and closure7 () (v0 : exn) : US2 =
    US2_1(v0)
and method1 () : US2 =
    let v0 : (unit -> unativeint) = closure5()
    let v1 : (unativeint -> US2) = closure6()
    let v2 : ((unit -> exn) -> exn) = closure3()
    let v3 : (exn -> US2) = closure7()
    let v4 : US2 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure8 (v0 : unativeint) () : int32 =
    let v1 : int32 = v0 |> int32 
    v1
and method2 (v0 : unativeint) : US0 =
    let v1 : (unit -> int32) = closure8(v0)
    let v2 : (int32 -> US0) = closure2()
    let v3 : ((unit -> exn) -> exn) = closure3()
    let v4 : (exn -> US0) = closure4()
    let v5 : US0 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method6 (v0 : string) : string =
    v0
and method7 () : string =
    let v0 : string = ""
    v0
and closure11 () (v0 : string) : US9 =
    US9_0(v0)
and method8 () : (string -> US9) =
    closure11()
and method5 (v0 : string) : string =
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = method6(v0)
    let v22 : string = "std::env::var(&*$0)"
    let v23 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "x"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "true; $0 })"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "_result_map_"
    let v33 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = method7()
    let v35 : string = "$0.unwrap_or($1)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr struct (v33, v34) v35 
    let _run_target_args'_v20 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : US7 = US7_1
    let v38 : US8 = US8_4(v37)
    let v39 : string = $"env.get_environment_variable / target: {v38} / var: {v0}"
    let v40 : string = failwith<string> v39
    let _run_target_args'_v20 = v40 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v41 : US7 = US7_2
    let v42 : US8 = US8_4(v41)
    let v43 : string = $"env.get_environment_variable / target: {v42} / var: {v0}"
    let v44 : string = failwith<string> v43
    let _run_target_args'_v20 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = "process.env[$0] ?? \"\""
    let v46 : string = Fable.Core.JsInterop.emitJsExpr v0 v45 
    let _run_target_args'_v20 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : string = "os"
    let v53 : IOsEnviron = Fable.Core.PyInterop.importAll v52 
    let v54 : string = "v53.environ"
    let v55 : obj = Fable.Core.PyInterop.emitPyExpr () v54 
    let v70 : string = "v55.get($0)"
    let v71 : string = Fable.Core.PyInterop.emitPyExpr v0 v70 
    let mutable _v71 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v91 : (string -> string option) = Option.ofObj
    let v92 : string option = v91 v71
    v92 
    #else
    Some v71 
    #endif
    |> fun x -> _v71 <- Some x
    let v93 : string option = match _v71 with Some x -> x | None -> failwith "optionm'.of_obj / _v71=None"
    let v114 : (string -> US9) = method8()
    let v115 : US9 option = v93 |> Option.map v114 
    let v163 : US9 = US9_1
    let v164 : US9 = v115 |> Option.defaultValue v163 
    let v178 : string =
        match v164 with
        | US9_1 -> (* None *)
            let v176 : string = ""
            v176
        | US9_0(v175) -> (* Some *)
            v175
    let _run_target_args'_v20 = v178 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v179 : US7 = US7_1
    let v180 : US8 = US8_1(v179)
    let v181 : string = $"env.get_environment_variable / target: {v180} / var: {v0}"
    let v182 : string = failwith<string> v181
    let _run_target_args'_v20 = v182 
    #endif
#else
    let v183 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v184 : string = v183 v0
    let mutable _v184 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v195 : (string -> string option) = Option.ofObj
    let v196 : string option = v195 v184
    v196 
    #else
    Some v184 
    #endif
    |> fun x -> _v184 <- Some x
    let v197 : string option = match _v184 with Some x -> x | None -> failwith "optionm'.of_obj / _v184=None"
    let v218 : (string -> US9) = method8()
    let v219 : US9 option = v197 |> Option.map v218 
    let v267 : US9 = US9_1
    let v268 : US9 = v219 |> Option.defaultValue v267 
    let v282 : string =
        match v268 with
        | US9_1 -> (* None *)
            let v280 : string = ""
            v280
        | US9_0(v279) -> (* Some *)
            v279
    let _run_target_args'_v20 = v282 
    #endif
    let v283 : string = _run_target_args'_v20 
    v283
and closure12 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure13 () (v0 : int64) : US10 =
    US10_0(v0)
and closure14 () (v0 : exn) : US10 =
    US10_1(v0)
and method9 (v0 : int64) : US10 =
    let v1 : (unit -> int64) = closure12(v0)
    let v2 : (int64 -> US10) = closure13()
    let v3 : ((unit -> exn) -> exn) = closure3()
    let v4 : (exn -> US10) = closure14()
    let v5 : US10 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method4 () : struct (US5 * US6) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method5(v0)
    
    
    
    
    
    
    
    
    
    
    let v4 : string = "Critical"
    let v5 : (unit -> string) = v4.ToLower
    let v6 : string = v5 ()
    let v18 : string = "Warning"
    let v19 : (unit -> string) = v18.ToLower
    let v20 : string = v19 ()
    let v32 : string = "Info"
    let v33 : (unit -> string) = v32.ToLower
    let v34 : string = v33 ()
    let v46 : string = "Debug"
    let v47 : (unit -> string) = v46.ToLower
    let v48 : string = v47 ()
    let v60 : string = "Verbose"
    let v61 : (unit -> string) = v60.ToLower
    let v62 : string = v61 ()
    let v72 : bool = "Verbose" = v1
    let v76 : US5 =
        if v72 then
            let v73 : US4 = US4_0
            US5_0(v73)
        else
            US5_1
    let v162 : US5 =
        match v76 with
        | US5_1 -> (* None *)
            let v79 : bool = "Debug" = v1
            let v83 : US5 =
                if v79 then
                    let v80 : US4 = US4_1
                    US5_0(v80)
                else
                    US5_1
            match v83 with
            | US5_1 -> (* None *)
                let v86 : bool = "Info" = v1
                let v90 : US5 =
                    if v86 then
                        let v87 : US4 = US4_2
                        US5_0(v87)
                    else
                        US5_1
                match v90 with
                | US5_1 -> (* None *)
                    let v93 : bool = "Warning" = v1
                    let v97 : US5 =
                        if v93 then
                            let v94 : US4 = US4_3
                            US5_0(v94)
                        else
                            US5_1
                    match v97 with
                    | US5_1 -> (* None *)
                        let v100 : bool = "Critical" = v1
                        let v104 : US5 =
                            if v100 then
                                let v101 : US4 = US4_4
                                US5_0(v101)
                            else
                                US5_1
                        match v104 with
                        | US5_1 -> (* None *)
                            let v107 : bool = v62 = v1
                            let v111 : US5 =
                                if v107 then
                                    let v108 : US4 = US4_0
                                    US5_0(v108)
                                else
                                    US5_1
                            match v111 with
                            | US5_1 -> (* None *)
                                let v114 : bool = v48 = v1
                                let v118 : US5 =
                                    if v114 then
                                        let v115 : US4 = US4_1
                                        US5_0(v115)
                                    else
                                        US5_1
                                match v118 with
                                | US5_1 -> (* None *)
                                    let v121 : bool = v34 = v1
                                    let v125 : US5 =
                                        if v121 then
                                            let v122 : US4 = US4_2
                                            US5_0(v122)
                                        else
                                            US5_1
                                    match v125 with
                                    | US5_1 -> (* None *)
                                        let v128 : bool = v20 = v1
                                        let v132 : US5 =
                                            if v128 then
                                                let v129 : US4 = US4_3
                                                US5_0(v129)
                                            else
                                                US5_1
                                        match v132 with
                                        | US5_1 -> (* None *)
                                            let v135 : bool = v6 = v1
                                            let v139 : US5 =
                                                if v135 then
                                                    let v136 : US4 = US4_4
                                                    US5_0(v136)
                                                else
                                                    US5_1
                                            match v139 with
                                            | US5_1 -> (* None *)
                                                US5_1
                                            | US5_0(v140) -> (* Some *)
                                                US5_0(v140)
                                        | US5_0(v133) -> (* Some *)
                                            US5_0(v133)
                                    | US5_0(v126) -> (* Some *)
                                        US5_0(v126)
                                | US5_0(v119) -> (* Some *)
                                    US5_0(v119)
                            | US5_0(v112) -> (* Some *)
                                US5_0(v112)
                        | US5_0(v105) -> (* Some *)
                            US5_0(v105)
                    | US5_0(v98) -> (* Some *)
                        US5_0(v98)
                | US5_0(v91) -> (* Some *)
                    US5_0(v91)
            | US5_0(v84) -> (* Some *)
                US5_0(v84)
        | US5_0(v77) -> (* Some *)
            US5_0(v77)
    let v163 : string = "AUTOMATION"
    let v164 : string = method5(v163)
    let v167 : string = "True"
    let v168 : bool = v164 <> v167 
    let v441 : US6 =
        if v168 then
            US6_1
        else
            (* run_target_args'
            let v194 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v195 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v194 = v195 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v196 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v194 = v196 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v198 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v194 = v198 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v208 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v194 = v208 
            #endif
#if FABLE_COMPILER_PYTHON
            let v209 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v194 = v209 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v210 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v194 = v210 
            #endif
#else
            let v211 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v194 = v211 
            #endif
            let v212 : System.DateTime = _run_target_args'_v194 
            (* run_target_args'
            let v230 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v231 : (System.DateTime -> int64) = _.Ticks
            let v232 : int64 = v231 v212
            let _run_target_args'_v230 = v232 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v233 : (System.DateTime -> int64) = _.Ticks
            let v234 : int64 = v233 v212
            let _run_target_args'_v230 = v234 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : int64 = null |> unbox<int64>
            let _run_target_args'_v230 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v212
            let _run_target_args'_v230 = v247 
            #endif
#if FABLE_COMPILER_PYTHON
            let v248 : (System.DateTime -> int64) = _.Ticks
            let v249 : int64 = v248 v212
            let _run_target_args'_v230 = v249 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v250 : (System.DateTime -> int64) = _.Ticks
            let v251 : int64 = v250 v212
            let _run_target_args'_v230 = v251 
            #endif
#else
            let v252 : (System.DateTime -> int64) = _.Ticks
            let v253 : int64 = v252 v212
            let _run_target_args'_v230 = v253 
            #endif
            let v254 : int64 = _run_target_args'_v230 
            let v365 : US10 = method9(v254)
            let v384 : US6 =
                match v365 with
                | US10_1(v381) -> (* Error *)
                    US6_1
                | US10_0(v379) -> (* Ok *)
                    US6_0(v379)
            let v421 : int64 =
                match v384 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v418) -> (* Some *)
                    v418
            US6_0(v421)
    struct (v162, v441)
and closure15 () (v0 : string) : unit =
    ()
and method3 (v0 : US4) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US5, v5 : US6) = method4()
    let _run_target_args'_v3 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : US5 = US5_1
    let v7 : US6 = US6_1
    let _run_target_args'_v3 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "AUTOMATION"
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v21 
    (* run_target_args'
    let v34 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = "String::from($0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v35 
    let _run_target_args'_v34 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "String::from($0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v37 
    let _run_target_args'_v34 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v39 
    let _run_target_args'_v34 = v40 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v42 : std_string_String = v22 |> unbox<std_string_String>
    let _run_target_args'_v34 = v42 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : std_string_String = v22 |> unbox<std_string_String>
    let _run_target_args'_v34 = v53 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : std_string_String = v22 |> unbox<std_string_String>
    let _run_target_args'_v34 = v64 
    #endif
#else
    let v75 : std_string_String = v22 |> unbox<std_string_String>
    let _run_target_args'_v34 = v75 
    #endif
    let v85 : std_string_String = _run_target_args'_v34 
    let v108 : string = "fable_library_rust::String_::fromString($0)"
    let v109 : string = Fable.Core.RustInterop.emitRustExpr v85 v108 
    let _run_target_args'_v20 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v110 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v110 
    (* run_target_args'
    let v123 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v111 v124 
    let _run_target_args'_v123 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v126 : string = "String::from($0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v111 v126 
    let _run_target_args'_v123 = v127 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v128 : string = "String::from($0)"
    let v129 : std_string_String = Fable.Core.RustInterop.emitRustExpr v111 v128 
    let _run_target_args'_v123 = v129 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : std_string_String = v111 |> unbox<std_string_String>
    let _run_target_args'_v123 = v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : std_string_String = v111 |> unbox<std_string_String>
    let _run_target_args'_v123 = v142 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v153 : std_string_String = v111 |> unbox<std_string_String>
    let _run_target_args'_v123 = v153 
    #endif
#else
    let v164 : std_string_String = v111 |> unbox<std_string_String>
    let _run_target_args'_v123 = v164 
    #endif
    let v174 : std_string_String = _run_target_args'_v123 
    let v197 : string = "fable_library_rust::String_::fromString($0)"
    let v198 : string = Fable.Core.RustInterop.emitRustExpr v174 v197 
    let _run_target_args'_v20 = v198 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v199 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v200 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v199 
    (* run_target_args'
    let v212 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v213 : string = "String::from($0)"
    let v214 : std_string_String = Fable.Core.RustInterop.emitRustExpr v200 v213 
    let _run_target_args'_v212 = v214 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v215 : string = "String::from($0)"
    let v216 : std_string_String = Fable.Core.RustInterop.emitRustExpr v200 v215 
    let _run_target_args'_v212 = v216 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v217 : string = "String::from($0)"
    let v218 : std_string_String = Fable.Core.RustInterop.emitRustExpr v200 v217 
    let _run_target_args'_v212 = v218 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v220 : std_string_String = v200 |> unbox<std_string_String>
    let _run_target_args'_v212 = v220 
    #endif
#if FABLE_COMPILER_PYTHON
    let v231 : std_string_String = v200 |> unbox<std_string_String>
    let _run_target_args'_v212 = v231 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v242 : std_string_String = v200 |> unbox<std_string_String>
    let _run_target_args'_v212 = v242 
    #endif
#else
    let v253 : std_string_String = v200 |> unbox<std_string_String>
    let _run_target_args'_v212 = v253 
    #endif
    let v263 : std_string_String = _run_target_args'_v212 
    let v286 : string = "fable_library_rust::String_::fromString($0)"
    let v287 : string = Fable.Core.RustInterop.emitRustExpr v263 v286 
    let _run_target_args'_v20 = v287 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v289 : string = null |> unbox<string>
    let _run_target_args'_v20 = v289 
    #endif
#if FABLE_COMPILER_PYTHON
    let v300 : string = null |> unbox<string>
    let _run_target_args'_v20 = v300 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v311 : string = null |> unbox<string>
    let _run_target_args'_v20 = v311 
    #endif
#else
    let v322 : string = null |> unbox<string>
    let _run_target_args'_v20 = v322 
    #endif
    let v332 : string = _run_target_args'_v20 
    let v357 : string = "True"
    let v358 : bool = v332 <> v357 
    let v384 : US6 =
        if v358 then
            US6_1
        else
            let v369 : string = $"near_sdk::env::block_timestamp()"
            let v370 : uint64 = Fable.Core.RustInterop.emitRustExpr () v369 
            let v372 : (uint64 -> int64) = int64
            let v373 : int64 = v372 v370
            US6_0(v373)
    let v385 : US5 = US5_1
    let _run_target_args'_v3 = struct (v385, v384) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v386 : US5, v387 : US6) = method4()
    let _run_target_args'_v3 = struct (v386, v387) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v388 : US5, v389 : US6) = method4()
    let _run_target_args'_v3 = struct (v388, v389) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v390 : US5, v391 : US6) = method4()
    let _run_target_args'_v3 = struct (v390, v391) 
    #endif
#else
    let struct (v392 : US5, v393 : US6) = method4()
    let _run_target_args'_v3 = struct (v392, v393) 
    #endif
    let struct (v394 : US5, v395 : US6) = _run_target_args'_v3 
    let v400 : Mut0 = {l0 = 1L} : Mut0
    let v401 : (string -> unit) = closure15()
    let v402 : Mut1 = {l0 = v401} : Mut1
    let v403 : Mut2 = {l0 = true} : Mut2
    let v404 : string = ""
    let v405 : Mut3 = {l0 = v404} : Mut3
    let v408 : US4 =
        match v394 with
        | US5_1 -> (* None *)
            v0
        | US5_0(v406) -> (* Some *)
            v406
    let v409 : Mut4 = {l0 = v408} : Mut4
    let v434 : int64 option =
        match v395 with
        | US6_1 -> (* None *)
            let v423 : int64 option = None
            v423
        | US6_0(v410) -> (* Some *)
            let v412 : int64 option = Some v410 
            v412
    struct (v400, v402, v403, v405, v409, v434)
and closure10 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US4 = US4_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method3(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and closure16 () (v0 : int64) : US6 =
    US6_0(v0)
and method11 () : (int64 -> US6) =
    closure16()
and method12 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method13 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v571 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v583 : (int64 -> US6) = method11()
    let v584 : US6 option = v5 |> Option.map v583 
    let v632 : US6 = US6_1
    let v633 : US6 = v584 |> Option.defaultValue v632 
    let v1111 : System.DateTime =
        match v633 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v1080 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1081 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1080 = v1081 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1082 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1080 = v1082 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1084 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1080 = v1084 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1094 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1080 = v1094 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1095 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1080 = v1095 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1096 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1080 = v1096 
            #endif
#else
            let v1097 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1080 = v1097 
            #endif
            let v1098 : System.DateTime = _run_target_args'_v1080 
            v1098
        | US6_0(v644) -> (* Some *)
            (* run_target_args'
            let v660 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v661 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v660 = v661 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v662 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v660 = v662 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v664 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v660 = v664 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v674 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v660 = v674 
            #endif
#if FABLE_COMPILER_PYTHON
            let v675 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v660 = v675 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v676 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v660 = v676 
            #endif
#else
            let v677 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v660 = v677 
            #endif
            let v678 : System.DateTime = _run_target_args'_v660 
            (* run_target_args'
            let v696 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v697 : (System.DateTime -> int64) = _.Ticks
            let v698 : int64 = v697 v678
            let _run_target_args'_v696 = v698 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v699 : (System.DateTime -> int64) = _.Ticks
            let v700 : int64 = v699 v678
            let _run_target_args'_v696 = v700 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v702 : int64 = null |> unbox<int64>
            let _run_target_args'_v696 = v702 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v712 : (System.DateTime -> int64) = _.Ticks
            let v713 : int64 = v712 v678
            let _run_target_args'_v696 = v713 
            #endif
#if FABLE_COMPILER_PYTHON
            let v714 : (System.DateTime -> int64) = _.Ticks
            let v715 : int64 = v714 v678
            let _run_target_args'_v696 = v715 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v716 : (System.DateTime -> int64) = _.Ticks
            let v717 : int64 = v716 v678
            let _run_target_args'_v696 = v717 
            #endif
#else
            let v718 : (System.DateTime -> int64) = _.Ticks
            let v719 : int64 = v718 v678
            let _run_target_args'_v696 = v719 
            #endif
            let v720 : int64 = _run_target_args'_v696 
            let v831 : US10 = method9(v720)
            let v850 : US6 =
                match v831 with
                | US10_1(v847) -> (* Error *)
                    US6_1
                | US10_0(v845) -> (* Ok *)
                    US6_0(v845)
            let v887 : int64 =
                match v850 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v884) -> (* Some *)
                    v884
            let v897 : int64 = v887 - v644
            let v957 : System.TimeSpan = v897 |> System.TimeSpan 
            let v968 : (System.TimeSpan -> int32) = _.Hours
            let v969 : int32 = v968 v957
            let v980 : (System.TimeSpan -> int32) = _.Minutes
            let v981 : int32 = v980 v957
            let v992 : (System.TimeSpan -> int32) = _.Seconds
            let v993 : int32 = v992 v957
            let v1004 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1005 : int32 = v1004 v957
            let v1055 : System.DateTime = System.DateTime (1, 1, 1, v969, v981, v993, v1005)
            v1055
    let v1112 : string = method12()
    let v1131 : bool = v1112 = ""
    let v1133 : string =
        if v1131 then
            let v1132 : string = "M-d-y hh:mm:ss tt"
            v1132
        else
            v1112
    let v1134 : (string -> string) = v1111.ToString
    let v1135 : string = v1134 v1133
    let _run_target_args'_v571 = v1135 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1175 : (int64 -> US6) = method11()
    let v1176 : US6 option = v5 |> Option.map v1175 
    let v1224 : US6 = US6_1
    let v1225 : US6 = v1176 |> Option.defaultValue v1224 
    let v1703 : System.DateTime =
        match v1225 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v1672 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1673 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1672 = v1673 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1674 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1672 = v1674 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1676 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1672 = v1676 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1686 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1672 = v1686 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1687 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1672 = v1687 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1688 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1672 = v1688 
            #endif
#else
            let v1689 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1672 = v1689 
            #endif
            let v1690 : System.DateTime = _run_target_args'_v1672 
            v1690
        | US6_0(v1236) -> (* Some *)
            (* run_target_args'
            let v1252 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1253 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1252 = v1253 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1254 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1252 = v1254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1256 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1252 = v1256 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1266 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1252 = v1266 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1267 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1252 = v1267 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1268 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1252 = v1268 
            #endif
#else
            let v1269 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1252 = v1269 
            #endif
            let v1270 : System.DateTime = _run_target_args'_v1252 
            (* run_target_args'
            let v1288 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1289 : (System.DateTime -> int64) = _.Ticks
            let v1290 : int64 = v1289 v1270
            let _run_target_args'_v1288 = v1290 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1291 : (System.DateTime -> int64) = _.Ticks
            let v1292 : int64 = v1291 v1270
            let _run_target_args'_v1288 = v1292 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1294 : int64 = null |> unbox<int64>
            let _run_target_args'_v1288 = v1294 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1304 : (System.DateTime -> int64) = _.Ticks
            let v1305 : int64 = v1304 v1270
            let _run_target_args'_v1288 = v1305 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1306 : (System.DateTime -> int64) = _.Ticks
            let v1307 : int64 = v1306 v1270
            let _run_target_args'_v1288 = v1307 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1308 : (System.DateTime -> int64) = _.Ticks
            let v1309 : int64 = v1308 v1270
            let _run_target_args'_v1288 = v1309 
            #endif
#else
            let v1310 : (System.DateTime -> int64) = _.Ticks
            let v1311 : int64 = v1310 v1270
            let _run_target_args'_v1288 = v1311 
            #endif
            let v1312 : int64 = _run_target_args'_v1288 
            let v1423 : US10 = method9(v1312)
            let v1442 : US6 =
                match v1423 with
                | US10_1(v1439) -> (* Error *)
                    US6_1
                | US10_0(v1437) -> (* Ok *)
                    US6_0(v1437)
            let v1479 : int64 =
                match v1442 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v1476) -> (* Some *)
                    v1476
            let v1489 : int64 = v1479 - v1236
            let v1549 : System.TimeSpan = v1489 |> System.TimeSpan 
            let v1560 : (System.TimeSpan -> int32) = _.Hours
            let v1561 : int32 = v1560 v1549
            let v1572 : (System.TimeSpan -> int32) = _.Minutes
            let v1573 : int32 = v1572 v1549
            let v1584 : (System.TimeSpan -> int32) = _.Seconds
            let v1585 : int32 = v1584 v1549
            let v1596 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1597 : int32 = v1596 v1549
            let v1647 : System.DateTime = System.DateTime (1, 1, 1, v1561, v1573, v1585, v1597)
            v1647
    let v1704 : string = method12()
    let v1723 : bool = v1704 = ""
    let v1725 : string =
        if v1723 then
            let v1724 : string = "M-d-y hh:mm:ss tt"
            v1724
        else
            v1704
    let v1726 : (string -> string) = v1703.ToString
    let v1727 : string = v1726 v1725
    let _run_target_args'_v571 = v1727 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1756 : string = $"near_sdk::env::block_timestamp()"
    let v1757 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1756 
    let v1769 : (int64 -> US6) = method11()
    let v1770 : US6 option = v5 |> Option.map v1769 
    let v1818 : US6 = US6_1
    let v1819 : US6 = v1770 |> Option.defaultValue v1818 
    let v1845 : uint64 =
        match v1819 with
        | US6_1 -> (* None *)
            v1757
        | US6_0(v1830) -> (* Some *)
            let v1832 : (int64 -> uint64) = uint64
            let v1833 : uint64 = v1832 v1830
            let v1843 : uint64 = v1757 - v1833
            v1843
    let v1846 : uint64 = v1845 / 1000000000UL
    let v1847 : uint64 = v1846 % 60UL
    let v1848 : uint64 = v1846 / 60UL
    let v1849 : uint64 = v1848 % 60UL
    let v1850 : uint64 = v1846 / 3600UL
    let v1851 : uint64 = v1850 % 24UL
    let v1852 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v1853 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1851, v1849, v1847) v1852 
    let v1854 : string = "fable_library_rust::String_::fromString($0)"
    let v1855 : string = Fable.Core.RustInterop.emitRustExpr v1853 v1854 
    let _run_target_args'_v571 = v1855 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1867 : (int64 -> US6) = method11()
    let v1868 : US6 option = v5 |> Option.map v1867 
    let v1916 : US6 = US6_1
    let v1917 : US6 = v1868 |> Option.defaultValue v1916 
    let v2395 : System.DateTime =
        match v1917 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v2364 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2365 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2364 = v2365 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2366 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2364 = v2366 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2368 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2364 = v2368 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2378 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2364 = v2378 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2379 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2364 = v2379 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2380 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2364 = v2380 
            #endif
#else
            let v2381 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2364 = v2381 
            #endif
            let v2382 : System.DateTime = _run_target_args'_v2364 
            v2382
        | US6_0(v1928) -> (* Some *)
            (* run_target_args'
            let v1944 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1945 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1944 = v1945 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1946 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1944 = v1946 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1948 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1944 = v1948 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1958 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1944 = v1958 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1959 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1944 = v1959 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1960 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1944 = v1960 
            #endif
#else
            let v1961 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1944 = v1961 
            #endif
            let v1962 : System.DateTime = _run_target_args'_v1944 
            (* run_target_args'
            let v1980 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1981 : (System.DateTime -> int64) = _.Ticks
            let v1982 : int64 = v1981 v1962
            let _run_target_args'_v1980 = v1982 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1983 : (System.DateTime -> int64) = _.Ticks
            let v1984 : int64 = v1983 v1962
            let _run_target_args'_v1980 = v1984 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1986 : int64 = null |> unbox<int64>
            let _run_target_args'_v1980 = v1986 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1996 : (System.DateTime -> int64) = _.Ticks
            let v1997 : int64 = v1996 v1962
            let _run_target_args'_v1980 = v1997 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1998 : (System.DateTime -> int64) = _.Ticks
            let v1999 : int64 = v1998 v1962
            let _run_target_args'_v1980 = v1999 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2000 : (System.DateTime -> int64) = _.Ticks
            let v2001 : int64 = v2000 v1962
            let _run_target_args'_v1980 = v2001 
            #endif
#else
            let v2002 : (System.DateTime -> int64) = _.Ticks
            let v2003 : int64 = v2002 v1962
            let _run_target_args'_v1980 = v2003 
            #endif
            let v2004 : int64 = _run_target_args'_v1980 
            let v2115 : US10 = method9(v2004)
            let v2134 : US6 =
                match v2115 with
                | US10_1(v2131) -> (* Error *)
                    US6_1
                | US10_0(v2129) -> (* Ok *)
                    US6_0(v2129)
            let v2171 : int64 =
                match v2134 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v2168) -> (* Some *)
                    v2168
            let v2181 : int64 = v2171 - v1928
            let v2241 : System.TimeSpan = v2181 |> System.TimeSpan 
            let v2252 : (System.TimeSpan -> int32) = _.Hours
            let v2253 : int32 = v2252 v2241
            let v2264 : (System.TimeSpan -> int32) = _.Minutes
            let v2265 : int32 = v2264 v2241
            let v2276 : (System.TimeSpan -> int32) = _.Seconds
            let v2277 : int32 = v2276 v2241
            let v2288 : (System.TimeSpan -> int32) = _.Milliseconds
            let v2289 : int32 = v2288 v2241
            let v2339 : System.DateTime = System.DateTime (1, 1, 1, v2253, v2265, v2277, v2289)
            v2339
    let v2396 : string = method13()
    let v2415 : bool = v2396 = ""
    let v2417 : string =
        if v2415 then
            let v2416 : string = "M-d-y hh:mm:ss tt"
            v2416
        else
            v2396
    let v2418 : (string -> string) = v2395.ToString
    let v2419 : string = v2418 v2417
    let _run_target_args'_v571 = v2419 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2459 : (int64 -> US6) = method11()
    let v2460 : US6 option = v5 |> Option.map v2459 
    let v2508 : US6 = US6_1
    let v2509 : US6 = v2460 |> Option.defaultValue v2508 
    let v2987 : System.DateTime =
        match v2509 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v2956 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2957 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2956 = v2957 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2958 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2956 = v2958 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2960 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2956 = v2960 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2970 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2956 = v2970 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2971 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2956 = v2971 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2972 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2956 = v2972 
            #endif
#else
            let v2973 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2956 = v2973 
            #endif
            let v2974 : System.DateTime = _run_target_args'_v2956 
            v2974
        | US6_0(v2520) -> (* Some *)
            (* run_target_args'
            let v2536 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2537 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2536 = v2537 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2538 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2536 = v2538 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2540 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2536 = v2540 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2550 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2536 = v2550 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2551 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2536 = v2551 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2552 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2536 = v2552 
            #endif
#else
            let v2553 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2536 = v2553 
            #endif
            let v2554 : System.DateTime = _run_target_args'_v2536 
            (* run_target_args'
            let v2572 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2573 : (System.DateTime -> int64) = _.Ticks
            let v2574 : int64 = v2573 v2554
            let _run_target_args'_v2572 = v2574 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2575 : (System.DateTime -> int64) = _.Ticks
            let v2576 : int64 = v2575 v2554
            let _run_target_args'_v2572 = v2576 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2578 : int64 = null |> unbox<int64>
            let _run_target_args'_v2572 = v2578 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2588 : (System.DateTime -> int64) = _.Ticks
            let v2589 : int64 = v2588 v2554
            let _run_target_args'_v2572 = v2589 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2590 : (System.DateTime -> int64) = _.Ticks
            let v2591 : int64 = v2590 v2554
            let _run_target_args'_v2572 = v2591 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2592 : (System.DateTime -> int64) = _.Ticks
            let v2593 : int64 = v2592 v2554
            let _run_target_args'_v2572 = v2593 
            #endif
#else
            let v2594 : (System.DateTime -> int64) = _.Ticks
            let v2595 : int64 = v2594 v2554
            let _run_target_args'_v2572 = v2595 
            #endif
            let v2596 : int64 = _run_target_args'_v2572 
            let v2707 : US10 = method9(v2596)
            let v2726 : US6 =
                match v2707 with
                | US10_1(v2723) -> (* Error *)
                    US6_1
                | US10_0(v2721) -> (* Ok *)
                    US6_0(v2721)
            let v2763 : int64 =
                match v2726 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v2760) -> (* Some *)
                    v2760
            let v2773 : int64 = v2763 - v2520
            let v2833 : System.TimeSpan = v2773 |> System.TimeSpan 
            let v2844 : (System.TimeSpan -> int32) = _.Hours
            let v2845 : int32 = v2844 v2833
            let v2856 : (System.TimeSpan -> int32) = _.Minutes
            let v2857 : int32 = v2856 v2833
            let v2868 : (System.TimeSpan -> int32) = _.Seconds
            let v2869 : int32 = v2868 v2833
            let v2880 : (System.TimeSpan -> int32) = _.Milliseconds
            let v2881 : int32 = v2880 v2833
            let v2931 : System.DateTime = System.DateTime (1, 1, 1, v2845, v2857, v2869, v2881)
            v2931
    let v2988 : string = method13()
    let v3007 : bool = v2988 = ""
    let v3009 : string =
        if v3007 then
            let v3008 : string = "M-d-y hh:mm:ss tt"
            v3008
        else
            v2988
    let v3010 : (string -> string) = v2987.ToString
    let v3011 : string = v3010 v3009
    let _run_target_args'_v571 = v3011 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3051 : (int64 -> US6) = method11()
    let v3052 : US6 option = v5 |> Option.map v3051 
    let v3100 : US6 = US6_1
    let v3101 : US6 = v3052 |> Option.defaultValue v3100 
    let v3579 : System.DateTime =
        match v3101 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v3548 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3549 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3548 = v3549 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3550 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3548 = v3550 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3552 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3548 = v3552 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3562 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3548 = v3562 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3563 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3548 = v3563 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3564 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3548 = v3564 
            #endif
#else
            let v3565 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3548 = v3565 
            #endif
            let v3566 : System.DateTime = _run_target_args'_v3548 
            v3566
        | US6_0(v3112) -> (* Some *)
            (* run_target_args'
            let v3128 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3129 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3128 = v3129 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3130 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3128 = v3130 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3132 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3128 = v3132 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3142 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3128 = v3142 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3128 = v3143 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3128 = v3144 
            #endif
#else
            let v3145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3128 = v3145 
            #endif
            let v3146 : System.DateTime = _run_target_args'_v3128 
            (* run_target_args'
            let v3164 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3165 : (System.DateTime -> int64) = _.Ticks
            let v3166 : int64 = v3165 v3146
            let _run_target_args'_v3164 = v3166 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3167 : (System.DateTime -> int64) = _.Ticks
            let v3168 : int64 = v3167 v3146
            let _run_target_args'_v3164 = v3168 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3170 : int64 = null |> unbox<int64>
            let _run_target_args'_v3164 = v3170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3180 : (System.DateTime -> int64) = _.Ticks
            let v3181 : int64 = v3180 v3146
            let _run_target_args'_v3164 = v3181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3182 : (System.DateTime -> int64) = _.Ticks
            let v3183 : int64 = v3182 v3146
            let _run_target_args'_v3164 = v3183 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3184 : (System.DateTime -> int64) = _.Ticks
            let v3185 : int64 = v3184 v3146
            let _run_target_args'_v3164 = v3185 
            #endif
#else
            let v3186 : (System.DateTime -> int64) = _.Ticks
            let v3187 : int64 = v3186 v3146
            let _run_target_args'_v3164 = v3187 
            #endif
            let v3188 : int64 = _run_target_args'_v3164 
            let v3299 : US10 = method9(v3188)
            let v3318 : US6 =
                match v3299 with
                | US10_1(v3315) -> (* Error *)
                    US6_1
                | US10_0(v3313) -> (* Ok *)
                    US6_0(v3313)
            let v3355 : int64 =
                match v3318 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v3352) -> (* Some *)
                    v3352
            let v3365 : int64 = v3355 - v3112
            let v3425 : System.TimeSpan = v3365 |> System.TimeSpan 
            let v3436 : (System.TimeSpan -> int32) = _.Hours
            let v3437 : int32 = v3436 v3425
            let v3448 : (System.TimeSpan -> int32) = _.Minutes
            let v3449 : int32 = v3448 v3425
            let v3460 : (System.TimeSpan -> int32) = _.Seconds
            let v3461 : int32 = v3460 v3425
            let v3472 : (System.TimeSpan -> int32) = _.Milliseconds
            let v3473 : int32 = v3472 v3425
            let v3523 : System.DateTime = System.DateTime (1, 1, 1, v3437, v3449, v3461, v3473)
            v3523
    let v3580 : string = method13()
    let v3599 : bool = v3580 = ""
    let v3601 : string =
        if v3599 then
            let v3600 : string = "M-d-y hh:mm:ss tt"
            v3600
        else
            v3580
    let v3602 : (string -> string) = v3579.ToString
    let v3603 : string = v3602 v3601
    let _run_target_args'_v571 = v3603 
    #endif
#else
    let v3643 : (int64 -> US6) = method11()
    let v3644 : US6 option = v5 |> Option.map v3643 
    let v3692 : US6 = US6_1
    let v3693 : US6 = v3644 |> Option.defaultValue v3692 
    let v4171 : System.DateTime =
        match v3693 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v4140 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4141 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4140 = v4141 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4142 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4140 = v4142 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4144 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v4140 = v4144 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4154 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4140 = v4154 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4155 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4140 = v4155 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4156 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4140 = v4156 
            #endif
#else
            let v4157 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4140 = v4157 
            #endif
            let v4158 : System.DateTime = _run_target_args'_v4140 
            v4158
        | US6_0(v3704) -> (* Some *)
            (* run_target_args'
            let v3720 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3721 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3720 = v3721 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3722 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3720 = v3722 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3724 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3720 = v3724 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3734 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3720 = v3734 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3735 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3720 = v3735 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3736 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3720 = v3736 
            #endif
#else
            let v3737 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3720 = v3737 
            #endif
            let v3738 : System.DateTime = _run_target_args'_v3720 
            (* run_target_args'
            let v3756 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3757 : (System.DateTime -> int64) = _.Ticks
            let v3758 : int64 = v3757 v3738
            let _run_target_args'_v3756 = v3758 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3759 : (System.DateTime -> int64) = _.Ticks
            let v3760 : int64 = v3759 v3738
            let _run_target_args'_v3756 = v3760 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3762 : int64 = null |> unbox<int64>
            let _run_target_args'_v3756 = v3762 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3772 : (System.DateTime -> int64) = _.Ticks
            let v3773 : int64 = v3772 v3738
            let _run_target_args'_v3756 = v3773 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3774 : (System.DateTime -> int64) = _.Ticks
            let v3775 : int64 = v3774 v3738
            let _run_target_args'_v3756 = v3775 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3776 : (System.DateTime -> int64) = _.Ticks
            let v3777 : int64 = v3776 v3738
            let _run_target_args'_v3756 = v3777 
            #endif
#else
            let v3778 : (System.DateTime -> int64) = _.Ticks
            let v3779 : int64 = v3778 v3738
            let _run_target_args'_v3756 = v3779 
            #endif
            let v3780 : int64 = _run_target_args'_v3756 
            let v3891 : US10 = method9(v3780)
            let v3910 : US6 =
                match v3891 with
                | US10_1(v3907) -> (* Error *)
                    US6_1
                | US10_0(v3905) -> (* Ok *)
                    US6_0(v3905)
            let v3947 : int64 =
                match v3910 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v3944) -> (* Some *)
                    v3944
            let v3957 : int64 = v3947 - v3704
            let v4017 : System.TimeSpan = v3957 |> System.TimeSpan 
            let v4028 : (System.TimeSpan -> int32) = _.Hours
            let v4029 : int32 = v4028 v4017
            let v4040 : (System.TimeSpan -> int32) = _.Minutes
            let v4041 : int32 = v4040 v4017
            let v4052 : (System.TimeSpan -> int32) = _.Seconds
            let v4053 : int32 = v4052 v4017
            let v4064 : (System.TimeSpan -> int32) = _.Milliseconds
            let v4065 : int32 = v4064 v4017
            let v4115 : System.DateTime = System.DateTime (1, 1, 1, v4029, v4041, v4053, v4065)
            v4115
    let v4172 : string = method13()
    let v4191 : bool = v4172 = ""
    let v4193 : string =
        if v4191 then
            let v4192 : string = "M-d-y hh:mm:ss tt"
            v4192
        else
            v4172
    let v4194 : (string -> string) = v4171.ToString
    let v4195 : string = v4194 v4193
    let _run_target_args'_v571 = v4195 
    #endif
    let v4224 : string = _run_target_args'_v571 
    v4224
and method16 () : string =
    let v0 : string = ""
    v0
and method17 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method15 (v0 : char) : string =
    let v1 : string = method16()
    let v10 : Mut3 = {l0 = v1} : Mut3
    let v22 : string = $"{v0}"
    method17(v10, v22)
    let v67 : string = v10.l0
    v67
and method14 () : string =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "inline_colorization::color_bright_blue"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2 
    (* run_target_args'
    let v15 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v16 
    let _run_target_args'_v15 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : string = "String::from($0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v18 
    let _run_target_args'_v15 = v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : string = "String::from($0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v20 
    let _run_target_args'_v15 = v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v23 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v15 = v23 
    #endif
#if FABLE_COMPILER_PYTHON
    let v34 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v15 = v34 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v45 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v15 = v45 
    #endif
#else
    let v56 : std_string_String = v3 |> unbox<std_string_String>
    let _run_target_args'_v15 = v56 
    #endif
    let v66 : std_string_String = _run_target_args'_v15 
    let v89 : string = "fable_library_rust::String_::fromString($0)"
    let v90 : string = Fable.Core.RustInterop.emitRustExpr v66 v89 
    let _run_target_args'_v1 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "inline_colorization::color_bright_blue"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v91 
    (* run_target_args'
    let v104 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : string = "String::from($0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v92 v105 
    let _run_target_args'_v104 = v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v107 : string = "String::from($0)"
    let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v92 v107 
    let _run_target_args'_v104 = v108 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v109 : string = "String::from($0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v92 v109 
    let _run_target_args'_v104 = v110 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : std_string_String = v92 |> unbox<std_string_String>
    let _run_target_args'_v104 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : std_string_String = v92 |> unbox<std_string_String>
    let _run_target_args'_v104 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v134 : std_string_String = v92 |> unbox<std_string_String>
    let _run_target_args'_v104 = v134 
    #endif
#else
    let v145 : std_string_String = v92 |> unbox<std_string_String>
    let _run_target_args'_v104 = v145 
    #endif
    let v155 : std_string_String = _run_target_args'_v104 
    let v178 : string = "fable_library_rust::String_::fromString($0)"
    let v179 : string = Fable.Core.RustInterop.emitRustExpr v155 v178 
    let _run_target_args'_v1 = v179 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v180 : string = "inline_colorization::color_bright_blue"
    let v181 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v180 
    (* run_target_args'
    let v193 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "String::from($0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v181 v194 
    let _run_target_args'_v193 = v195 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v196 : string = "String::from($0)"
    let v197 : std_string_String = Fable.Core.RustInterop.emitRustExpr v181 v196 
    let _run_target_args'_v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : string = "String::from($0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v181 v198 
    let _run_target_args'_v193 = v199 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v201 : std_string_String = v181 |> unbox<std_string_String>
    let _run_target_args'_v193 = v201 
    #endif
#if FABLE_COMPILER_PYTHON
    let v212 : std_string_String = v181 |> unbox<std_string_String>
    let _run_target_args'_v193 = v212 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v223 : std_string_String = v181 |> unbox<std_string_String>
    let _run_target_args'_v193 = v223 
    #endif
#else
    let v234 : std_string_String = v181 |> unbox<std_string_String>
    let _run_target_args'_v193 = v234 
    #endif
    let v244 : std_string_String = _run_target_args'_v193 
    let v267 : string = "fable_library_rust::String_::fromString($0)"
    let v268 : string = Fable.Core.RustInterop.emitRustExpr v244 v267 
    let _run_target_args'_v1 = v268 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v269 : string = "\u001b[94m"
    let _run_target_args'_v1 = v269 
    #endif
#if FABLE_COMPILER_PYTHON
    let v270 : string = "\u001b[94m"
    let _run_target_args'_v1 = v270 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v271 : string = "\u001b[94m"
    let _run_target_args'_v1 = v271 
    #endif
#else
    let v272 : string = "\u001b[94m"
    let _run_target_args'_v1 = v272 
    #endif
    let v273 : string = _run_target_args'_v1 
    
    
    
    
    
    let v278 : string = "Debug"
    let v279 : (unit -> string) = v278.ToLower
    let v280 : string = v279 ()
    let v290 : char = v280.[int 0]
    let v291 : string = method15(v290)
    let v293 : string = v273 + v291 
    (* run_target_args'
    let v304 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v305 : string = "inline_colorization::color_reset"
    let v306 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v305 
    (* run_target_args'
    let v318 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v319 : string = "String::from($0)"
    let v320 : std_string_String = Fable.Core.RustInterop.emitRustExpr v306 v319 
    let _run_target_args'_v318 = v320 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v321 : string = "String::from($0)"
    let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr v306 v321 
    let _run_target_args'_v318 = v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v323 : string = "String::from($0)"
    let v324 : std_string_String = Fable.Core.RustInterop.emitRustExpr v306 v323 
    let _run_target_args'_v318 = v324 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326 : std_string_String = v306 |> unbox<std_string_String>
    let _run_target_args'_v318 = v326 
    #endif
#if FABLE_COMPILER_PYTHON
    let v337 : std_string_String = v306 |> unbox<std_string_String>
    let _run_target_args'_v318 = v337 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v348 : std_string_String = v306 |> unbox<std_string_String>
    let _run_target_args'_v318 = v348 
    #endif
#else
    let v359 : std_string_String = v306 |> unbox<std_string_String>
    let _run_target_args'_v318 = v359 
    #endif
    let v369 : std_string_String = _run_target_args'_v318 
    let v392 : string = "fable_library_rust::String_::fromString($0)"
    let v393 : string = Fable.Core.RustInterop.emitRustExpr v369 v392 
    let _run_target_args'_v304 = v393 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v394 : string = "inline_colorization::color_reset"
    let v395 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v394 
    (* run_target_args'
    let v407 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v408 : string = "String::from($0)"
    let v409 : std_string_String = Fable.Core.RustInterop.emitRustExpr v395 v408 
    let _run_target_args'_v407 = v409 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v410 : string = "String::from($0)"
    let v411 : std_string_String = Fable.Core.RustInterop.emitRustExpr v395 v410 
    let _run_target_args'_v407 = v411 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v412 : string = "String::from($0)"
    let v413 : std_string_String = Fable.Core.RustInterop.emitRustExpr v395 v412 
    let _run_target_args'_v407 = v413 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v415 : std_string_String = v395 |> unbox<std_string_String>
    let _run_target_args'_v407 = v415 
    #endif
#if FABLE_COMPILER_PYTHON
    let v426 : std_string_String = v395 |> unbox<std_string_String>
    let _run_target_args'_v407 = v426 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v437 : std_string_String = v395 |> unbox<std_string_String>
    let _run_target_args'_v407 = v437 
    #endif
#else
    let v448 : std_string_String = v395 |> unbox<std_string_String>
    let _run_target_args'_v407 = v448 
    #endif
    let v458 : std_string_String = _run_target_args'_v407 
    let v481 : string = "fable_library_rust::String_::fromString($0)"
    let v482 : string = Fable.Core.RustInterop.emitRustExpr v458 v481 
    let _run_target_args'_v304 = v482 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v483 : string = "inline_colorization::color_reset"
    let v484 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v483 
    (* run_target_args'
    let v496 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v497 : string = "String::from($0)"
    let v498 : std_string_String = Fable.Core.RustInterop.emitRustExpr v484 v497 
    let _run_target_args'_v496 = v498 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v499 : string = "String::from($0)"
    let v500 : std_string_String = Fable.Core.RustInterop.emitRustExpr v484 v499 
    let _run_target_args'_v496 = v500 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v501 : string = "String::from($0)"
    let v502 : std_string_String = Fable.Core.RustInterop.emitRustExpr v484 v501 
    let _run_target_args'_v496 = v502 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v504 : std_string_String = v484 |> unbox<std_string_String>
    let _run_target_args'_v496 = v504 
    #endif
#if FABLE_COMPILER_PYTHON
    let v515 : std_string_String = v484 |> unbox<std_string_String>
    let _run_target_args'_v496 = v515 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v526 : std_string_String = v484 |> unbox<std_string_String>
    let _run_target_args'_v496 = v526 
    #endif
#else
    let v537 : std_string_String = v484 |> unbox<std_string_String>
    let _run_target_args'_v496 = v537 
    #endif
    let v547 : std_string_String = _run_target_args'_v496 
    let v570 : string = "fable_library_rust::String_::fromString($0)"
    let v571 : string = Fable.Core.RustInterop.emitRustExpr v547 v570 
    let _run_target_args'_v304 = v571 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v572 : string = "\u001b[0m"
    let _run_target_args'_v304 = v572 
    #endif
#if FABLE_COMPILER_PYTHON
    let v573 : string = "\u001b[0m"
    let _run_target_args'_v304 = v573 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v574 : string = "\u001b[0m"
    let _run_target_args'_v304 = v574 
    #endif
#else
    let v575 : string = "\u001b[0m"
    let _run_target_args'_v304 = v575 
    #endif
    let v576 : string = _run_target_args'_v304 
    let v580 : string = v293 + v576 
    v580
and method20 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "{ "
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method21 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "seed_excess_len"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method22 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = " = "
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method23 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "; "
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method24 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "seed_excess"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method25 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = " }"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method19 (v0 : int32, v1 : string) : string =
    let v2 : string = method16()
    let v11 : Mut3 = {l0 = v2} : Mut3
    method20(v11)
    method21(v11)
    method22(v11)
    let v155 : string = $"{v0}"
    method17(v11, v155)
    method23(v11)
    method24(v11)
    method22(v11)
    method17(v11, v1)
    method25(v11)
    let v419 : string = v11.l0
    v419
and method28 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US12 =
            if v3 then
                US12_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US12_0('\t')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US12_0('\r')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US12_0('\n')
                        else
                            let v14 : int64 = v11 - 1L
                            US12_1
        let v23 : char =
            match v19 with
            | US12_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US12_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method28(v0, v25)
and method27 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = v0.[int v2]
        let v5 : int64 = 0L
        let v6 : bool = method28(v4, v5)
        if v6 then
            let v7 : int32 = v2 + 1
            method27(v0, v1, v7)
        else
            v2
and method30 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US12 =
            if v3 then
                US12_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US12_0('/')
                else
                    let v8 : int64 = v5 - 1L
                    US12_1
        let v15 : char =
            match v11 with
            | US12_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US12_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method30(v0, v17)
and method29 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        0
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
        let v5 : int64 = 0L
        let v6 : bool = method30(v4, v5)
        if v6 then
            method29(v0, v3)
        else
            v3
and method26 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method27(v0, v1, v2)
    let v492 : string = v0.[int v3..int v1]
    let v503 : int32 = v492.Length
    let v504 : int32 = method29(v492, v503)
    let v993 : string = v492.[int 0..int v504]
    v993
and method18 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method19(v8, v9)
    let v11 : int64 = v0.l0
    let v14 : string = " "
    let v15 : string = v6 + v14 
    let v26 : string = v15 + v7 
    let v38 : string = " #"
    let v39 : string = v26 + v38 
    let v60 : string = v11 |> _.ToString()
    let v71 : string = v39 + v60 
    let v82 : string = v71 + v14 
    let v94 : string = "dice_contract.contribute_seed"
    let v95 : string = v82 + v94 
    let v107 : string = " / "
    let v108 : string = v95 + v107 
    let v119 : string = v108 + v10 
    method26(v119)
and closure17 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure19 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure18 () (v0 : string) : unit =
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure19(v0)
    let v22 : unit = (fun () -> v21 (); v20) ()
    ()
and method31 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure9 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure10()
    let v33 : unit = (fun () -> v32 (); v31) ()
    let struct (v71 : Mut0, v72 : Mut1, v73 : Mut2, v74 : Mut3, v75 : Mut4, v76 : int64 option) = TraceState.trace_state.Value
    let v111 : US4 = v75.l0
    let v112 : bool = v73.l0
    let v113 : bool = v112 = false
    let v116 : bool =
        if v113 then
            false
        else
            let v114 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v111
            let v115 : bool = 1 >= v114
            v115
    let v117 : bool = v116 = false
    let v525 : US11 =
        if v117 then
            US11_1
        else
            let v148 : unit = ()
            let v149 : unit = (fun () -> v32 (); v148) ()
            let struct (v187 : Mut0, v188 : Mut1, v189 : Mut2, v190 : Mut3, v191 : Mut4, v192 : int64 option) = TraceState.trace_state.Value
            let v227 : string = method10(v187, v188, v189, v190, v191, v192)
            let v228 : string = method14()
            let v230 : string = $"%A{v1}"
            let v240 : string = method18(v187, v188, v189, v190, v191, v192, v227, v228, v0, v230)
            let v270 : unit = ()
            let v271 : unit = (fun () -> v32 (); v270) ()
            let struct (v309 : Mut0, v310 : Mut1, v311 : Mut2, v312 : Mut3, v313 : Mut4, v314 : int64 option) = TraceState.trace_state.Value
            let v351 : unit = ()
            let v352 : (unit -> unit) = closure17(v309)
            let v353 : unit = (fun () -> v352 (); v351) ()
            let v360 : (string -> unit) = closure18()
            (* run_target_args'
            let v361 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v362 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v240 v362 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v363 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v240 v363 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v364 : string = v312.l0
            let v365 : bool = v364 = ""
            let v394 : string =
                if v365 then
                    v240
                else
                    let v366 : bool = v240 = ""
                    if v366 then
                        let v367 : string = v312.l0
                        v367
                    else
                        let v368 : string = v312.l0
                        let v371 : string = "\n"
                        let v372 : string = v368 + v371 
                        let v383 : string = v372 + v240 
                        v383
            (* run_target_args'
            let v406 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v407 : string = "&*$0"
            let v408 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v394 v407 
            let _run_target_args'_v406 = v408 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v409 : string = "&*$0"
            let v410 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v394 v409 
            let _run_target_args'_v406 = v410 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v411 : string = "&*$0"
            let v412 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v394 v411 
            let _run_target_args'_v406 = v412 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v414 : Ref<Str> = v394 |> unbox<Ref<Str>>
            let _run_target_args'_v406 = v414 
            #endif
#if FABLE_COMPILER_PYTHON
            let v425 : Ref<Str> = v394 |> unbox<Ref<Str>>
            let _run_target_args'_v406 = v425 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v436 : Ref<Str> = v394 |> unbox<Ref<Str>>
            let _run_target_args'_v406 = v436 
            #endif
#else
            let v447 : Ref<Str> = v394 |> unbox<Ref<Str>>
            let _run_target_args'_v406 = v447 
            #endif
            let v457 : Ref<Str> = _run_target_args'_v406 
            let v480 : string = $"$0.chars()"
            let v481 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v457 v480 
            let v482 : string = "$0"
            let v483 : _ = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "$0.collect::<Vec<_>>()"
            let v485 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v483 v484 
            let v486 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v487 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v485 v486 
            let v488 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v489 : bool = Fable.Core.RustInterop.emitRustExpr v487 v488 
            let v490 : string = "x"
            let v491 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v490 
            let v492 : string = "String::from_iter($0)"
            let v493 : std_string_String = Fable.Core.RustInterop.emitRustExpr v491 v492 
            let v494 : string = "true; $0 }).collect::<Vec<_>>()"
            let v495 : bool = Fable.Core.RustInterop.emitRustExpr v493 v494 
            let v496 : string = "_vec_map"
            let v497 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v496 
            let v498 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v499 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v497 v498 
            let v500 : int32 = v499.Length
            let v503 : string = ""
            let v504 : bool = v240 <> v503 
            let v515 : bool =
                if v504 then
                    let v514 : bool = v500 <= 1
                    v514
                else
                    false
            if v515 then
                v312.l0 <- v394
                ()
            else
                v312.l0 <- v503
                let v516 : Mut5 = {l0 = 0} : Mut5
                while method31(v500, v516) do
                    let v518 : int32 = v516.l0
                    let v519 : std_string_String = v499.[int v518]
                    let v520 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v521 : bool = Fable.Core.RustInterop.emitRustExpr v519 v520 
                    let v522 : int32 = v518 + 1
                    v516.l0 <- v522
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v360 v240
            #endif
#if FABLE_COMPILER_PYTHON
            v360 v240
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v360 v240
            #endif
#else
            v360 v240
            #endif
            // run_target_args' is_unit
            let v523 : (string -> unit) = v310.l0
            v523 v240
            US11_0(v309, v310, v311, v312, v313, v314)
    let v557 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v557 
    ()
and closure20 () () : unit =
    ()
and method32 () : (unit -> unit) =
    closure20()
and closure21 (v0 : (unit -> unit)) () : unit =
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure10()
    let v32 : unit = (fun () -> v31 (); v30) ()
    let struct (v70 : Mut0, v71 : Mut1, v72 : Mut2, v73 : Mut3, v74 : Mut4, v75 : int64 option) = TraceState.trace_state.Value
    let v110 : US4 = v74.l0
    let v111 : bool = v72.l0
    let v112 : bool = v111 = false
    let v115 : bool =
        if v112 then
            false
        else
            let v113 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v110
            let v114 : bool = 1 >= v113
            v114
    let v116 : bool = v115 = false
    let v511 : US11 =
        if v116 then
            US11_1
        else
            let v147 : unit = ()
            let v148 : unit = (fun () -> v31 (); v147) ()
            let struct (v186 : Mut0, v187 : Mut1, v188 : Mut2, v189 : Mut3, v190 : Mut4, v191 : int64 option) = TraceState.trace_state.Value
            let v226 : string = method10(v186, v187, v188, v189, v190, v191)
            let v227 : string = method14()
            let v257 : unit = ()
            let v258 : unit = (fun () -> v31 (); v257) ()
            let struct (v296 : Mut0, v297 : Mut1, v298 : Mut2, v299 : Mut3, v300 : Mut4, v301 : int64 option) = TraceState.trace_state.Value
            let v338 : unit = ()
            let v339 : (unit -> unit) = closure17(v296)
            let v340 : unit = (fun () -> v339 (); v338) ()
            let v347 : string = ""
            let v348 : (string -> unit) = closure18()
            (* run_target_args'
            let v349 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v350 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v347 v350 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v351 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v347 v351 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v352 : string = v299.l0
            let v353 : bool = v352 = ""
            let v382 : string =
                if v353 then
                    v347
                else
                    let v354 : bool = v347 = ""
                    if v354 then
                        let v355 : string = v299.l0
                        v355
                    else
                        let v356 : string = v299.l0
                        let v359 : string = "\n"
                        let v360 : string = v356 + v359 
                        let v371 : string = v360 + v347 
                        v371
            (* run_target_args'
            let v394 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v395 : string = "&*$0"
            let v396 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v395 
            let _run_target_args'_v394 = v396 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v397 : string = "&*$0"
            let v398 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v397 
            let _run_target_args'_v394 = v398 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399 : string = "&*$0"
            let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v399 
            let _run_target_args'_v394 = v400 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v402 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v402 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v424 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v424 
            #endif
#else
            let v435 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v435 
            #endif
            let v445 : Ref<Str> = _run_target_args'_v394 
            let v468 : string = $"$0.chars()"
            let v469 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v445 v468 
            let v470 : string = "$0"
            let v471 : _ = Fable.Core.RustInterop.emitRustExpr v469 v470 
            let v472 : string = "$0.collect::<Vec<_>>()"
            let v473 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v475 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v473 v474 
            let v476 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v477 : bool = Fable.Core.RustInterop.emitRustExpr v475 v476 
            let v478 : string = "x"
            let v479 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v478 
            let v480 : string = "String::from_iter($0)"
            let v481 : std_string_String = Fable.Core.RustInterop.emitRustExpr v479 v480 
            let v482 : string = "true; $0 }).collect::<Vec<_>>()"
            let v483 : bool = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "_vec_map"
            let v485 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v484 
            let v486 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v487 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v485 v486 
            let v488 : int32 = v487.Length
            let v490 : bool = v347 <> v347 
            let v501 : bool =
                if v490 then
                    let v500 : bool = v488 <= 1
                    v500
                else
                    false
            if v501 then
                v299.l0 <- v382
                ()
            else
                v299.l0 <- v347
                let v502 : Mut5 = {l0 = 0} : Mut5
                while method31(v488, v502) do
                    let v504 : int32 = v502.l0
                    let v505 : std_string_String = v487.[int v504]
                    let v506 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v507 : bool = Fable.Core.RustInterop.emitRustExpr v505 v506 
                    let v508 : int32 = v504 + 1
                    v502.l0 <- v508
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v348 v347
            #endif
#if FABLE_COMPILER_PYTHON
            v348 v347
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v348 v347
            #endif
#else
            v348 v347
            #endif
            // run_target_args' is_unit
            let v509 : (string -> unit) = v297.l0
            v509 v347
            US11_0(v296, v297, v298, v299, v300, v301)
    let v543 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v543 
    ()
and closure23 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure22 () (v0 : uint8) : (UH0 -> UH0) =
    closure23(v0)
and method33 () : (uint8 -> (UH0 -> UH0)) =
    closure22()
and closure24 (v0 : UH1) () : UH1 =
    v0
and method34 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method34(v3, v1)
        let v5 : (unit -> UH1) = closure24(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure25 (v0 : UH1) () : UH1 =
    v0
and method35 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method35(v4, v1)
        let v6 : int64 = int64 v2
        let v7 : int64 = v6 - 1L
        let v8 : int64 = v7 + 6L
        let v9 : int64 = v8 % 6L
        let v10 : int64 = v9 + 1L
        let v11 : uint8 = uint8 v10
        let v12 : (unit -> UH1) = closure25(v5)
        UH1_0(v11, v12)
    | UH1_1 -> (* StreamNil *)
        v1
and method36 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method36(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method37 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method37(v3, v1)
        let v6 : uint8 list = v2 :: v4 
        v6
    | UH0_0 -> (* Nil *)
        v1
and method40 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "max"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method41 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "key"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method42 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "proof"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method43 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "block_timestamp"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method44 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "block_height"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method45 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "epoch_height"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method46 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "account_balance"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method47 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "signer_account_id"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method48 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "predecessor_account_id"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method49 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "seed"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method50 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "seeds"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method51 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "entropy_len"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method52 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "entropy"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method53 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "hash_u8"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method54 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "rolls"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method39 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : std_string_String, v9 : string, v10 : string, v11 : unativeint, v12 : string, v13 : string, v14 : string) : string =
    let v15 : string = method16()
    let v24 : Mut3 = {l0 = v15} : Mut3
    method20(v24)
    method40(v24)
    method22(v24)
    let v168 : string = $"{v0}"
    method17(v24, v168)
    method23(v24)
    method41(v24)
    method22(v24)
    (* run_target_args'
    let v356 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v357 : string = "format!(\"{:#?}\", $0)"
    let v358 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v357 
    let v359 : string = "fable_library_rust::String_::fromString($0)"
    let v360 : string = Fable.Core.RustInterop.emitRustExpr v358 v359 
    let _run_target_args'_v356 = v360 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v361 : string = "format!(\"{:#?}\", $0)"
    let v362 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v361 
    let v363 : string = "fable_library_rust::String_::fromString($0)"
    let v364 : string = Fable.Core.RustInterop.emitRustExpr v362 v363 
    let _run_target_args'_v356 = v364 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v365 : string = "format!(\"{:#?}\", $0)"
    let v366 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v365 
    let v367 : string = "fable_library_rust::String_::fromString($0)"
    let v368 : string = Fable.Core.RustInterop.emitRustExpr v366 v367 
    let _run_target_args'_v356 = v368 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v370 : string = $"%A{v1}"
    let _run_target_args'_v356 = v370 
    #endif
#if FABLE_COMPILER_PYTHON
    let v381 : string = $"%A{v1}"
    let _run_target_args'_v356 = v381 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v392 : string = $"%A{v1}"
    let _run_target_args'_v356 = v392 
    #endif
#else
    let v403 : string = $"%A{v1}"
    let _run_target_args'_v356 = v403 
    #endif
    let v413 : string = _run_target_args'_v356 
    method17(v24, v413)
    method23(v24)
    method42(v24)
    method22(v24)
    (* run_target_args'
    let v622 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v623 : string = "format!(\"{:#?}\", $0)"
    let v624 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v623 
    let v625 : string = "fable_library_rust::String_::fromString($0)"
    let v626 : string = Fable.Core.RustInterop.emitRustExpr v624 v625 
    let _run_target_args'_v622 = v626 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v627 : string = "format!(\"{:#?}\", $0)"
    let v628 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v627 
    let v629 : string = "fable_library_rust::String_::fromString($0)"
    let v630 : string = Fable.Core.RustInterop.emitRustExpr v628 v629 
    let _run_target_args'_v622 = v630 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v631 : string = "format!(\"{:#?}\", $0)"
    let v632 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v631 
    let v633 : string = "fable_library_rust::String_::fromString($0)"
    let v634 : string = Fable.Core.RustInterop.emitRustExpr v632 v633 
    let _run_target_args'_v622 = v634 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v636 : string = $"%A{v2}"
    let _run_target_args'_v622 = v636 
    #endif
#if FABLE_COMPILER_PYTHON
    let v647 : string = $"%A{v2}"
    let _run_target_args'_v622 = v647 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v658 : string = $"%A{v2}"
    let _run_target_args'_v622 = v658 
    #endif
#else
    let v669 : string = $"%A{v2}"
    let _run_target_args'_v622 = v669 
    #endif
    let v679 : string = _run_target_args'_v622 
    method17(v24, v679)
    method23(v24)
    method43(v24)
    method22(v24)
    let v888 : string = $"{v3}"
    method17(v24, v888)
    method23(v24)
    method44(v24)
    method22(v24)
    let v1076 : string = $"{v4}"
    method17(v24, v1076)
    method23(v24)
    method45(v24)
    method22(v24)
    let v1264 : string = $"{v5}"
    method17(v24, v1264)
    method23(v24)
    method46(v24)
    method22(v24)
    method17(v24, v6)
    method23(v24)
    method47(v24)
    method22(v24)
    (* run_target_args'
    let v1627 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1628 : string = "format!(\"{:#?}\", $0)"
    let v1629 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v1628 
    let v1630 : string = "fable_library_rust::String_::fromString($0)"
    let v1631 : string = Fable.Core.RustInterop.emitRustExpr v1629 v1630 
    let _run_target_args'_v1627 = v1631 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1632 : string = "format!(\"{:#?}\", $0)"
    let v1633 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v1632 
    let v1634 : string = "fable_library_rust::String_::fromString($0)"
    let v1635 : string = Fable.Core.RustInterop.emitRustExpr v1633 v1634 
    let _run_target_args'_v1627 = v1635 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1636 : string = "format!(\"{:#?}\", $0)"
    let v1637 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v1636 
    let v1638 : string = "fable_library_rust::String_::fromString($0)"
    let v1639 : string = Fable.Core.RustInterop.emitRustExpr v1637 v1638 
    let _run_target_args'_v1627 = v1639 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1641 : string = $"%A{v7}"
    let _run_target_args'_v1627 = v1641 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1652 : string = $"%A{v7}"
    let _run_target_args'_v1627 = v1652 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1663 : string = $"%A{v7}"
    let _run_target_args'_v1627 = v1663 
    #endif
#else
    let v1674 : string = $"%A{v7}"
    let _run_target_args'_v1627 = v1674 
    #endif
    let v1684 : string = _run_target_args'_v1627 
    method17(v24, v1684)
    method23(v24)
    method48(v24)
    method22(v24)
    (* run_target_args'
    let v1893 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1894 : string = "format!(\"{:#?}\", $0)"
    let v1895 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v1894 
    let v1896 : string = "fable_library_rust::String_::fromString($0)"
    let v1897 : string = Fable.Core.RustInterop.emitRustExpr v1895 v1896 
    let _run_target_args'_v1893 = v1897 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1898 : string = "format!(\"{:#?}\", $0)"
    let v1899 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v1898 
    let v1900 : string = "fable_library_rust::String_::fromString($0)"
    let v1901 : string = Fable.Core.RustInterop.emitRustExpr v1899 v1900 
    let _run_target_args'_v1893 = v1901 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1902 : string = "format!(\"{:#?}\", $0)"
    let v1903 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v1902 
    let v1904 : string = "fable_library_rust::String_::fromString($0)"
    let v1905 : string = Fable.Core.RustInterop.emitRustExpr v1903 v1904 
    let _run_target_args'_v1893 = v1905 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1907 : string = $"%A{v8}"
    let _run_target_args'_v1893 = v1907 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1918 : string = $"%A{v8}"
    let _run_target_args'_v1893 = v1918 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1929 : string = $"%A{v8}"
    let _run_target_args'_v1893 = v1929 
    #endif
#else
    let v1940 : string = $"%A{v8}"
    let _run_target_args'_v1893 = v1940 
    #endif
    let v1950 : string = _run_target_args'_v1893 
    method17(v24, v1950)
    method23(v24)
    method49(v24)
    method22(v24)
    method17(v24, v9)
    method23(v24)
    method50(v24)
    method22(v24)
    method17(v24, v10)
    method23(v24)
    method51(v24)
    method22(v24)
    (* run_target_args'
    let v2509 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2510 : string = "format!(\"{:#?}\", $0)"
    let v2511 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v2510 
    let v2512 : string = "fable_library_rust::String_::fromString($0)"
    let v2513 : string = Fable.Core.RustInterop.emitRustExpr v2511 v2512 
    let _run_target_args'_v2509 = v2513 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2514 : string = "format!(\"{:#?}\", $0)"
    let v2515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v2514 
    let v2516 : string = "fable_library_rust::String_::fromString($0)"
    let v2517 : string = Fable.Core.RustInterop.emitRustExpr v2515 v2516 
    let _run_target_args'_v2509 = v2517 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2518 : string = "format!(\"{:#?}\", $0)"
    let v2519 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v2518 
    let v2520 : string = "fable_library_rust::String_::fromString($0)"
    let v2521 : string = Fable.Core.RustInterop.emitRustExpr v2519 v2520 
    let _run_target_args'_v2509 = v2521 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2523 : string = $"%A{v11}"
    let _run_target_args'_v2509 = v2523 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2534 : string = $"%A{v11}"
    let _run_target_args'_v2509 = v2534 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2545 : string = $"%A{v11}"
    let _run_target_args'_v2509 = v2545 
    #endif
#else
    let v2556 : string = $"%A{v11}"
    let _run_target_args'_v2509 = v2556 
    #endif
    let v2566 : string = _run_target_args'_v2509 
    method17(v24, v2566)
    method23(v24)
    method52(v24)
    method22(v24)
    method17(v24, v12)
    method23(v24)
    method53(v24)
    method22(v24)
    method17(v24, v13)
    method23(v24)
    method54(v24)
    method22(v24)
    method17(v24, v14)
    method25(v24)
    let v3201 : string = v24.l0
    v3201
and method38 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : string = method39(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v24 : int64 = v0.l0
    let v27 : string = " "
    let v28 : string = v6 + v27 
    let v39 : string = v28 + v7 
    let v51 : string = " #"
    let v52 : string = v39 + v51 
    let v73 : string = v24 |> _.ToString()
    let v84 : string = v52 + v73 
    let v95 : string = v84 + v27 
    let v107 : string = "dice_contract.generate_random_number"
    let v108 : string = v95 + v107 
    let v120 : string = " / "
    let v121 : string = v108 + v120 
    let v132 : string = v121 + v23 
    method26(v132)
and closure26 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure10()
    let v45 : unit = (fun () -> v44 (); v43) ()
    let struct (v83 : Mut0, v84 : Mut1, v85 : Mut2, v86 : Mut3, v87 : Mut4, v88 : int64 option) = TraceState.trace_state.Value
    let v123 : US4 = v87.l0
    let v124 : bool = v85.l0
    let v125 : bool = v124 = false
    let v128 : bool =
        if v125 then
            false
        else
            let v126 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v123
            let v127 : bool = 1 >= v126
            v127
    let v129 : bool = v128 = false
    let v631 : US11 =
        if v129 then
            US11_1
        else
            let v160 : unit = ()
            let v161 : unit = (fun () -> v44 (); v160) ()
            let struct (v199 : Mut0, v200 : Mut1, v201 : Mut2, v202 : Mut3, v203 : Mut4, v204 : int64 option) = TraceState.trace_state.Value
            let v239 : string = method10(v199, v200, v201, v202, v203, v204)
            let v240 : string = method14()
            let v242 : string = $"%A{v8}"
            let v252 : string = $"v9.to_string()"
            let v253 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v252 
            let v254 : string = $"v10.to_string()"
            let v255 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v254 
            let v257 : string = $"%A{v4}"
            let v268 : string = $"%A{v0}"
            let v278 : string = "$0.len()"
            let v279 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v278 
            let v281 : string = $"%A{v11}"
            let v292 : string = $"%A{v12}"
            let v302 : uint8 list = []
            let v303 : uint8 list = method37(v13, v302)
            let v322 : (uint8 list -> (uint8 [])) = List.toArray
            let v323 : (uint8 []) = v322 v303
            let v333 : string = "$0.to_vec()"
            let v334 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v323 v333 
            let v336 : string = $"%A{v334}"
            let v346 : string = method38(v199, v200, v201, v202, v203, v204, v239, v240, v3, v1, v2, v7, v6, v5, v242, v253, v255, v257, v268, v279, v281, v292, v336)
            let v376 : unit = ()
            let v377 : unit = (fun () -> v44 (); v376) ()
            let struct (v415 : Mut0, v416 : Mut1, v417 : Mut2, v418 : Mut3, v419 : Mut4, v420 : int64 option) = TraceState.trace_state.Value
            let v457 : unit = ()
            let v458 : (unit -> unit) = closure17(v415)
            let v459 : unit = (fun () -> v458 (); v457) ()
            let v466 : (string -> unit) = closure18()
            (* run_target_args'
            let v467 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v468 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v346 v468 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v469 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v346 v469 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v470 : string = v418.l0
            let v471 : bool = v470 = ""
            let v500 : string =
                if v471 then
                    v346
                else
                    let v472 : bool = v346 = ""
                    if v472 then
                        let v473 : string = v418.l0
                        v473
                    else
                        let v474 : string = v418.l0
                        let v477 : string = "\n"
                        let v478 : string = v474 + v477 
                        let v489 : string = v478 + v346 
                        v489
            (* run_target_args'
            let v512 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v513 : string = "&*$0"
            let v514 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v500 v513 
            let _run_target_args'_v512 = v514 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v515 : string = "&*$0"
            let v516 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v500 v515 
            let _run_target_args'_v512 = v516 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v517 : string = "&*$0"
            let v518 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v500 v517 
            let _run_target_args'_v512 = v518 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v520 : Ref<Str> = v500 |> unbox<Ref<Str>>
            let _run_target_args'_v512 = v520 
            #endif
#if FABLE_COMPILER_PYTHON
            let v531 : Ref<Str> = v500 |> unbox<Ref<Str>>
            let _run_target_args'_v512 = v531 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v542 : Ref<Str> = v500 |> unbox<Ref<Str>>
            let _run_target_args'_v512 = v542 
            #endif
#else
            let v553 : Ref<Str> = v500 |> unbox<Ref<Str>>
            let _run_target_args'_v512 = v553 
            #endif
            let v563 : Ref<Str> = _run_target_args'_v512 
            let v586 : string = $"$0.chars()"
            let v587 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v563 v586 
            let v588 : string = "$0"
            let v589 : _ = Fable.Core.RustInterop.emitRustExpr v587 v588 
            let v590 : string = "$0.collect::<Vec<_>>()"
            let v591 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v589 v590 
            let v592 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v593 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v591 v592 
            let v594 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v595 : bool = Fable.Core.RustInterop.emitRustExpr v593 v594 
            let v596 : string = "x"
            let v597 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v596 
            let v598 : string = "String::from_iter($0)"
            let v599 : std_string_String = Fable.Core.RustInterop.emitRustExpr v597 v598 
            let v600 : string = "true; $0 }).collect::<Vec<_>>()"
            let v601 : bool = Fable.Core.RustInterop.emitRustExpr v599 v600 
            let v602 : string = "_vec_map"
            let v603 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v602 
            let v604 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v605 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v603 v604 
            let v606 : int32 = v605.Length
            let v609 : string = ""
            let v610 : bool = v346 <> v609 
            let v621 : bool =
                if v610 then
                    let v620 : bool = v606 <= 1
                    v620
                else
                    false
            if v621 then
                v418.l0 <- v500
                ()
            else
                v418.l0 <- v609
                let v622 : Mut5 = {l0 = 0} : Mut5
                while method31(v606, v622) do
                    let v624 : int32 = v622.l0
                    let v625 : std_string_String = v605.[int v624]
                    let v626 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v627 : bool = Fable.Core.RustInterop.emitRustExpr v625 v626 
                    let v628 : int32 = v624 + 1
                    v622.l0 <- v628
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v466 v346
            #endif
#if FABLE_COMPILER_PYTHON
            v466 v346
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v466 v346
            #endif
#else
            v466 v346
            #endif
            // run_target_args' is_unit
            let v629 : (string -> unit) = v416.l0
            v629 v346
            US11_0(v415, v416, v417, v418, v419, v420)
    let v663 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v663 
    ()
and method55 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method55(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method56 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method56(v3, v1)
        UH0_1(v2, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure27 (v0 : UH1) () : UH1 =
    v0
and closure28 (v0 : UH1, v1 : Mut6) () : UH1 =
    let v2 : US13 = v1.l0
    match v2 with
    | US13_1(v3) -> (* Computed *)
        v3
    | US13_0(v4) -> (* NotComputed *)
        let v5 : UH1 = v4 ()
        let v12 : UH1 =
            match v5 with
            | UH1_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH1) = method57(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US13 = US13_1(v12)
        v1.l0 <- v13
        v12
and method57 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US13 = US13_0(v1)
    let v3 : Mut6 = {l0 = v2} : Mut6
    closure28(v0, v3)
and method61 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "p"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method62 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "n"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method60 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method16()
    let v12 : Mut3 = {l0 = v3} : Mut3
    method20(v12)
    method40(v12)
    method22(v12)
    let v156 : string = $"{v0}"
    method17(v12, v156)
    method23(v12)
    method61(v12)
    method22(v12)
    let v344 : string = $"{v1}"
    method17(v12, v344)
    method23(v12)
    method62(v12)
    method22(v12)
    let v532 : string = $"{v2}"
    method17(v12, v532)
    method25(v12)
    let v621 : string = v12.l0
    v621
and method59 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : string = method60(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v27 : string = v16 + v7 
    let v39 : string = " #"
    let v40 : string = v27 + v39 
    let v61 : string = v12 |> _.ToString()
    let v72 : string = v40 + v61 
    let v83 : string = v72 + v15 
    let v95 : string = "dice.calculate_dice_count"
    let v96 : string = v83 + v95 
    let v108 : string = " / "
    let v109 : string = v96 + v108 
    let v120 : string = v109 + v11 
    method26(v120)
and closure29 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure10()
    let v34 : unit = (fun () -> v33 (); v32) ()
    let struct (v72 : Mut0, v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : Mut4, v77 : int64 option) = TraceState.trace_state.Value
    let v112 : US4 = v76.l0
    let v113 : bool = v74.l0
    let v114 : bool = v113 = false
    let v117 : bool =
        if v114 then
            false
        else
            let v115 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v112
            let v116 : bool = 1 >= v115
            v116
    let v118 : bool = v117 = false
    let v515 : US11 =
        if v118 then
            US11_1
        else
            let v149 : unit = ()
            let v150 : unit = (fun () -> v33 (); v149) ()
            let struct (v188 : Mut0, v189 : Mut1, v190 : Mut2, v191 : Mut3, v192 : Mut4, v193 : int64 option) = TraceState.trace_state.Value
            let v228 : string = method10(v188, v189, v190, v191, v192, v193)
            let v229 : string = method14()
            let v230 : string = method59(v188, v189, v190, v191, v192, v193, v228, v229, v0, v2, v1)
            let v260 : unit = ()
            let v261 : unit = (fun () -> v33 (); v260) ()
            let struct (v299 : Mut0, v300 : Mut1, v301 : Mut2, v302 : Mut3, v303 : Mut4, v304 : int64 option) = TraceState.trace_state.Value
            let v341 : unit = ()
            let v342 : (unit -> unit) = closure17(v299)
            let v343 : unit = (fun () -> v342 (); v341) ()
            let v350 : (string -> unit) = closure18()
            (* run_target_args'
            let v351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v230 v352 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v353 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v230 v353 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v354 : string = v302.l0
            let v355 : bool = v354 = ""
            let v384 : string =
                if v355 then
                    v230
                else
                    let v356 : bool = v230 = ""
                    if v356 then
                        let v357 : string = v302.l0
                        v357
                    else
                        let v358 : string = v302.l0
                        let v361 : string = "\n"
                        let v362 : string = v358 + v361 
                        let v373 : string = v362 + v230 
                        v373
            (* run_target_args'
            let v396 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v397 : string = "&*$0"
            let v398 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v397 
            let _run_target_args'_v396 = v398 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v399 : string = "&*$0"
            let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v399 
            let _run_target_args'_v396 = v400 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v401 : string = "&*$0"
            let v402 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v401 
            let _run_target_args'_v396 = v402 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v404 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v404 
            #endif
#if FABLE_COMPILER_PYTHON
            let v415 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v415 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v426 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v426 
            #endif
#else
            let v437 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v437 
            #endif
            let v447 : Ref<Str> = _run_target_args'_v396 
            let v470 : string = $"$0.chars()"
            let v471 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v447 v470 
            let v472 : string = "$0"
            let v473 : _ = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "$0.collect::<Vec<_>>()"
            let v475 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v473 v474 
            let v476 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v477 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v475 v476 
            let v478 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v479 : bool = Fable.Core.RustInterop.emitRustExpr v477 v478 
            let v480 : string = "x"
            let v481 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v480 
            let v482 : string = "String::from_iter($0)"
            let v483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "true; $0 }).collect::<Vec<_>>()"
            let v485 : bool = Fable.Core.RustInterop.emitRustExpr v483 v484 
            let v486 : string = "_vec_map"
            let v487 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v486 
            let v488 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v489 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v487 v488 
            let v490 : int32 = v489.Length
            let v493 : string = ""
            let v494 : bool = v230 <> v493 
            let v505 : bool =
                if v494 then
                    let v504 : bool = v490 <= 1
                    v504
                else
                    false
            if v505 then
                v302.l0 <- v384
                ()
            else
                v302.l0 <- v493
                let v506 : Mut5 = {l0 = 0} : Mut5
                while method31(v490, v506) do
                    let v508 : int32 = v506.l0
                    let v509 : std_string_String = v489.[int v508]
                    let v510 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v511 : bool = Fable.Core.RustInterop.emitRustExpr v509 v510 
                    let v512 : int32 = v508 + 1
                    v506.l0 <- v512
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v350 v230
            #endif
#if FABLE_COMPILER_PYTHON
            v350 v230
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v350 v230
            #endif
#else
            v350 v230
            #endif
            // run_target_args' is_unit
            let v513 : (string -> unit) = v300.l0
            v513 v230
            US11_0(v299, v300, v301, v302, v303, v304)
    let v547 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v547 
    ()
and method58 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method58(v0, v6, v4)
        else
            let v557 : unit = ()
            let v558 : (unit -> unit) = closure29(v0, v1, v2)
            let v559 : unit = (fun () -> v558 (); v557) ()
            v1
    else
        let v1666 : unit = ()
        let v1667 : (unit -> unit) = closure29(v0, v1, v2)
        let v1668 : unit = (fun () -> v1667 (); v1666) ()
        v1
and method67 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "current_index"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method68 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "acc"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method69 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "len"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method70 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "last_item"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method66 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method16()
    let v13 : Mut3 = {l0 = v4} : Mut3
    method20(v13)
    method67(v13)
    method22(v13)
    let v157 : string = $"{v0}"
    method17(v13, v157)
    method23(v13)
    method68(v13)
    method22(v13)
    let v345 : string = $"{v1}"
    method17(v13, v345)
    method23(v13)
    method69(v13)
    method22(v13)
    let v533 : string = $"{v2}"
    method17(v13, v533)
    method23(v13)
    method70(v13)
    method22(v13)
    method17(v13, v3)
    method25(v13)
    let v797 : string = v13.l0
    v797
and method65 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : string = method66(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v28 : string = v17 + v7 
    let v40 : string = " #"
    let v41 : string = v28 + v40 
    let v62 : string = v13 |> _.ToString()
    let v73 : string = v41 + v62 
    let v84 : string = v73 + v16 
    let v96 : string = "dice.create_sequential_roller / roll"
    let v97 : string = v84 + v96 
    let v109 : string = " / "
    let v110 : string = v97 + v109 
    let v121 : string = v110 + v12 
    method26(v121)
and closure30 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure10()
    let v35 : unit = (fun () -> v34 (); v33) ()
    let struct (v73 : Mut0, v74 : Mut1, v75 : Mut2, v76 : Mut3, v77 : Mut4, v78 : int64 option) = TraceState.trace_state.Value
    let v113 : US4 = v77.l0
    let v114 : bool = v75.l0
    let v115 : bool = v114 = false
    let v118 : bool =
        if v115 then
            false
        else
            let v116 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v113
            let v117 : bool = 1 >= v116
            v117
    let v119 : bool = v118 = false
    let v527 : US11 =
        if v119 then
            US11_1
        else
            let v150 : unit = ()
            let v151 : unit = (fun () -> v34 (); v150) ()
            let struct (v189 : Mut0, v190 : Mut1, v191 : Mut2, v192 : Mut3, v193 : Mut4, v194 : int64 option) = TraceState.trace_state.Value
            let v229 : string = method10(v189, v190, v191, v192, v193, v194)
            let v230 : string = method14()
            let v232 : string = $"%A{v3}"
            let v242 : string = method65(v189, v190, v191, v192, v193, v194, v229, v230, v0, v1, v2, v232)
            let v272 : unit = ()
            let v273 : unit = (fun () -> v34 (); v272) ()
            let struct (v311 : Mut0, v312 : Mut1, v313 : Mut2, v314 : Mut3, v315 : Mut4, v316 : int64 option) = TraceState.trace_state.Value
            let v353 : unit = ()
            let v354 : (unit -> unit) = closure17(v311)
            let v355 : unit = (fun () -> v354 (); v353) ()
            let v362 : (string -> unit) = closure18()
            (* run_target_args'
            let v363 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v364 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v242 v364 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v365 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v242 v365 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v366 : string = v314.l0
            let v367 : bool = v366 = ""
            let v396 : string =
                if v367 then
                    v242
                else
                    let v368 : bool = v242 = ""
                    if v368 then
                        let v369 : string = v314.l0
                        v369
                    else
                        let v370 : string = v314.l0
                        let v373 : string = "\n"
                        let v374 : string = v370 + v373 
                        let v385 : string = v374 + v242 
                        v385
            (* run_target_args'
            let v408 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v409 : string = "&*$0"
            let v410 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v396 v409 
            let _run_target_args'_v408 = v410 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v411 : string = "&*$0"
            let v412 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v396 v411 
            let _run_target_args'_v408 = v412 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v413 : string = "&*$0"
            let v414 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v396 v413 
            let _run_target_args'_v408 = v414 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : Ref<Str> = v396 |> unbox<Ref<Str>>
            let _run_target_args'_v408 = v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v427 : Ref<Str> = v396 |> unbox<Ref<Str>>
            let _run_target_args'_v408 = v427 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v438 : Ref<Str> = v396 |> unbox<Ref<Str>>
            let _run_target_args'_v408 = v438 
            #endif
#else
            let v449 : Ref<Str> = v396 |> unbox<Ref<Str>>
            let _run_target_args'_v408 = v449 
            #endif
            let v459 : Ref<Str> = _run_target_args'_v408 
            let v482 : string = $"$0.chars()"
            let v483 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v459 v482 
            let v484 : string = "$0"
            let v485 : _ = Fable.Core.RustInterop.emitRustExpr v483 v484 
            let v486 : string = "$0.collect::<Vec<_>>()"
            let v487 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v485 v486 
            let v488 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v489 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v487 v488 
            let v490 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v491 : bool = Fable.Core.RustInterop.emitRustExpr v489 v490 
            let v492 : string = "x"
            let v493 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v492 
            let v494 : string = "String::from_iter($0)"
            let v495 : std_string_String = Fable.Core.RustInterop.emitRustExpr v493 v494 
            let v496 : string = "true; $0 }).collect::<Vec<_>>()"
            let v497 : bool = Fable.Core.RustInterop.emitRustExpr v495 v496 
            let v498 : string = "_vec_map"
            let v499 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v498 
            let v500 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v501 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v499 v500 
            let v502 : int32 = v501.Length
            let v505 : string = ""
            let v506 : bool = v242 <> v505 
            let v517 : bool =
                if v506 then
                    let v516 : bool = v502 <= 1
                    v516
                else
                    false
            if v517 then
                v314.l0 <- v396
                ()
            else
                v314.l0 <- v505
                let v518 : Mut5 = {l0 = 0} : Mut5
                while method31(v502, v518) do
                    let v520 : int32 = v518.l0
                    let v521 : std_string_String = v501.[int v520]
                    let v522 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v523 : bool = Fable.Core.RustInterop.emitRustExpr v521 v522 
                    let v524 : int32 = v520 + 1
                    v518.l0 <- v524
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v362 v242
            #endif
#if FABLE_COMPILER_PYTHON
            v362 v242
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v362 v242
            #endif
#else
            v362 v242
            #endif
            // run_target_args' is_unit
            let v525 : (string -> unit) = v312.l0
            v525 v242
            US11_0(v311, v312, v313, v314, v315, v316)
    let v559 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v559 
    ()
and method71 (v0 : int64, v1 : UH1) : US14 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US14_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method71(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US14_1
and method73 () : string =
    let v0 : string = method16()
    let v9 : Mut3 = {l0 = v0} : Mut3
    let v10 : string = v9.l0
    v10
and method72 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method73()
    let v9 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v24 : string = v13 + v7 
    let v36 : string = " #"
    let v37 : string = v24 + v36 
    let v58 : string = v9 |> _.ToString()
    let v69 : string = v37 + v58 
    let v80 : string = v69 + v12 
    let v92 : string = "dice.create_sequential_roller / roll / None"
    let v93 : string = v80 + v92 
    let v105 : string = " / "
    let v106 : string = v93 + v105 
    let v117 : string = v106 + v8 
    method26(v117)
and closure31 () () : unit =
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure10()
    let v31 : unit = (fun () -> v30 (); v29) ()
    let struct (v69 : Mut0, v70 : Mut1, v71 : Mut2, v72 : Mut3, v73 : Mut4, v74 : int64 option) = TraceState.trace_state.Value
    let v109 : US4 = v73.l0
    let v110 : bool = v71.l0
    let v111 : bool = v110 = false
    let v114 : bool =
        if v111 then
            false
        else
            let v112 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v109
            let v113 : bool = 1 >= v112
            v113
    let v115 : bool = v114 = false
    let v512 : US11 =
        if v115 then
            US11_1
        else
            let v146 : unit = ()
            let v147 : unit = (fun () -> v30 (); v146) ()
            let struct (v185 : Mut0, v186 : Mut1, v187 : Mut2, v188 : Mut3, v189 : Mut4, v190 : int64 option) = TraceState.trace_state.Value
            let v225 : string = method10(v185, v186, v187, v188, v189, v190)
            let v226 : string = method14()
            let v227 : string = method72(v185, v186, v187, v188, v189, v190, v225, v226)
            let v257 : unit = ()
            let v258 : unit = (fun () -> v30 (); v257) ()
            let struct (v296 : Mut0, v297 : Mut1, v298 : Mut2, v299 : Mut3, v300 : Mut4, v301 : int64 option) = TraceState.trace_state.Value
            let v338 : unit = ()
            let v339 : (unit -> unit) = closure17(v296)
            let v340 : unit = (fun () -> v339 (); v338) ()
            let v347 : (string -> unit) = closure18()
            (* run_target_args'
            let v348 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v349 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v227 v349 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v350 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v227 v350 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v351 : string = v299.l0
            let v352 : bool = v351 = ""
            let v381 : string =
                if v352 then
                    v227
                else
                    let v353 : bool = v227 = ""
                    if v353 then
                        let v354 : string = v299.l0
                        v354
                    else
                        let v355 : string = v299.l0
                        let v358 : string = "\n"
                        let v359 : string = v355 + v358 
                        let v370 : string = v359 + v227 
                        v370
            (* run_target_args'
            let v393 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v394 : string = "&*$0"
            let v395 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v381 v394 
            let _run_target_args'_v393 = v395 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v396 : string = "&*$0"
            let v397 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v381 v396 
            let _run_target_args'_v393 = v397 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v398 : string = "&*$0"
            let v399 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v381 v398 
            let _run_target_args'_v393 = v399 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v401 : Ref<Str> = v381 |> unbox<Ref<Str>>
            let _run_target_args'_v393 = v401 
            #endif
#if FABLE_COMPILER_PYTHON
            let v412 : Ref<Str> = v381 |> unbox<Ref<Str>>
            let _run_target_args'_v393 = v412 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v423 : Ref<Str> = v381 |> unbox<Ref<Str>>
            let _run_target_args'_v393 = v423 
            #endif
#else
            let v434 : Ref<Str> = v381 |> unbox<Ref<Str>>
            let _run_target_args'_v393 = v434 
            #endif
            let v444 : Ref<Str> = _run_target_args'_v393 
            let v467 : string = $"$0.chars()"
            let v468 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v444 v467 
            let v469 : string = "$0"
            let v470 : _ = Fable.Core.RustInterop.emitRustExpr v468 v469 
            let v471 : string = "$0.collect::<Vec<_>>()"
            let v472 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v470 v471 
            let v473 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v474 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v472 v473 
            let v475 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v476 : bool = Fable.Core.RustInterop.emitRustExpr v474 v475 
            let v477 : string = "x"
            let v478 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v477 
            let v479 : string = "String::from_iter($0)"
            let v480 : std_string_String = Fable.Core.RustInterop.emitRustExpr v478 v479 
            let v481 : string = "true; $0 }).collect::<Vec<_>>()"
            let v482 : bool = Fable.Core.RustInterop.emitRustExpr v480 v481 
            let v483 : string = "_vec_map"
            let v484 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v483 
            let v485 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v486 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v484 v485 
            let v487 : int32 = v486.Length
            let v490 : string = ""
            let v491 : bool = v227 <> v490 
            let v502 : bool =
                if v491 then
                    let v501 : bool = v487 <= 1
                    v501
                else
                    false
            if v502 then
                v299.l0 <- v381
                ()
            else
                v299.l0 <- v490
                let v503 : Mut5 = {l0 = 0} : Mut5
                while method31(v487, v503) do
                    let v505 : int32 = v503.l0
                    let v506 : std_string_String = v486.[int v505]
                    let v507 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v508 : bool = Fable.Core.RustInterop.emitRustExpr v506 v507 
                    let v509 : int32 = v505 + 1
                    v503.l0 <- v509
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v347 v227
            #endif
#if FABLE_COMPILER_PYTHON
            v347 v227
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v347 v227
            #endif
#else
            v347 v227
            #endif
            // run_target_args' is_unit
            let v510 : (string -> unit) = v297.l0
            v510 v227
            US11_0(v296, v297, v298, v299, v300, v301)
    let v544 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v544 
    ()
and method64 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut7) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US14 = v4.l0
    let v33 : uint8 option =
        match v8 with
        | US14_1 -> (* None *)
            let v22 : uint8 option = None
            v22
        | US14_0(v9) -> (* Some *)
            let v11 : uint8 option = Some v9 
            v11
    let v594 : unit = ()
    let v595 : (unit -> unit) = closure30(v5, v6, v7, v33)
    let v596 : unit = (fun () -> v595 (); v594) ()
    let v1164 : UH1 = v0 ()
    let v1165 : int64 = v1.l0
    let v1166 : US14 = method71(v1165, v1164)
    match v1166 with
    | US14_1 -> (* None *)
        let v1720 : unit = ()
        let v1721 : (unit -> unit) = closure31()
        let v1722 : unit = (fun () -> v1721 (); v1720) ()
        let v2279 : int64 = v3.l0
        let v2280 : bool = v2279 = -1L
        if v2280 then
            let v2281 : int64 = v1.l0
            v3.l0 <- v2281
            ()
        let v2282 : int64 = v2.l0
        let v2283 : int64 = v3.l0
        let v2284 : bool = v2282 >= v2283
        let v2287 : int64 =
            if v2284 then
                1L
            else
                let v2285 : int64 = v2.l0
                let v2286 : int64 = v2285 + 1L
                v2286
        v2.l0 <- v2287
        let v2288 : int64 = v2.l0
        let v2289 : int64 = v2288 - 1L
        v1.l0 <- v2289
        let v2290 : US14 = US14_1
        v4.l0 <- v2290
        method64(v0, v1, v2, v3, v4)
    | US14_0(v1167) -> (* Some *)
        let v1168 : int64 = v1.l0
        let v1169 : int64 = v1168 + 1L
        v1.l0 <- v1169
        let v1170 : US14 = US14_0(v1167)
        v4.l0 <- v1170
        v1167
and method77 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "power"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method78 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "result"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method76 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method16()
    let v12 : Mut3 = {l0 = v3} : Mut3
    method20(v12)
    method77(v12)
    method22(v12)
    let v156 : string = $"{v0}"
    method17(v12, v156)
    method23(v12)
    method68(v12)
    method22(v12)
    let v344 : string = $"{v1}"
    method17(v12, v344)
    method23(v12)
    method78(v12)
    method22(v12)
    let v532 : string = $"{v2}"
    method17(v12, v532)
    method25(v12)
    let v621 : string = v12.l0
    v621
and method75 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : string = method76(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v27 : string = v16 + v7 
    let v39 : string = " #"
    let v40 : string = v27 + v39 
    let v61 : string = v12 |> _.ToString()
    let v72 : string = v40 + v61 
    let v83 : string = v72 + v15 
    let v95 : string = "dice.accumulate_dice_rolls"
    let v96 : string = v83 + v95 
    let v108 : string = " / "
    let v109 : string = v96 + v108 
    let v120 : string = v109 + v11 
    method26(v120)
and closure32 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure10()
    let v34 : unit = (fun () -> v33 (); v32) ()
    let struct (v72 : Mut0, v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : Mut4, v77 : int64 option) = TraceState.trace_state.Value
    let v112 : US4 = v76.l0
    let v113 : bool = v74.l0
    let v114 : bool = v113 = false
    let v117 : bool =
        if v114 then
            false
        else
            let v115 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v112
            let v116 : bool = 1 >= v115
            v116
    let v118 : bool = v117 = false
    let v515 : US11 =
        if v118 then
            US11_1
        else
            let v149 : unit = ()
            let v150 : unit = (fun () -> v33 (); v149) ()
            let struct (v188 : Mut0, v189 : Mut1, v190 : Mut2, v191 : Mut3, v192 : Mut4, v193 : int64 option) = TraceState.trace_state.Value
            let v228 : string = method10(v188, v189, v190, v191, v192, v193)
            let v229 : string = method14()
            let v230 : string = method75(v188, v189, v190, v191, v192, v193, v228, v229, v1, v0, v2)
            let v260 : unit = ()
            let v261 : unit = (fun () -> v33 (); v260) ()
            let struct (v299 : Mut0, v300 : Mut1, v301 : Mut2, v302 : Mut3, v303 : Mut4, v304 : int64 option) = TraceState.trace_state.Value
            let v341 : unit = ()
            let v342 : (unit -> unit) = closure17(v299)
            let v343 : unit = (fun () -> v342 (); v341) ()
            let v350 : (string -> unit) = closure18()
            (* run_target_args'
            let v351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v230 v352 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v353 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v230 v353 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v354 : string = v302.l0
            let v355 : bool = v354 = ""
            let v384 : string =
                if v355 then
                    v230
                else
                    let v356 : bool = v230 = ""
                    if v356 then
                        let v357 : string = v302.l0
                        v357
                    else
                        let v358 : string = v302.l0
                        let v361 : string = "\n"
                        let v362 : string = v358 + v361 
                        let v373 : string = v362 + v230 
                        v373
            (* run_target_args'
            let v396 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v397 : string = "&*$0"
            let v398 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v397 
            let _run_target_args'_v396 = v398 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v399 : string = "&*$0"
            let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v399 
            let _run_target_args'_v396 = v400 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v401 : string = "&*$0"
            let v402 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v401 
            let _run_target_args'_v396 = v402 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v404 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v404 
            #endif
#if FABLE_COMPILER_PYTHON
            let v415 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v415 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v426 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v426 
            #endif
#else
            let v437 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v437 
            #endif
            let v447 : Ref<Str> = _run_target_args'_v396 
            let v470 : string = $"$0.chars()"
            let v471 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v447 v470 
            let v472 : string = "$0"
            let v473 : _ = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "$0.collect::<Vec<_>>()"
            let v475 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v473 v474 
            let v476 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v477 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v475 v476 
            let v478 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v479 : bool = Fable.Core.RustInterop.emitRustExpr v477 v478 
            let v480 : string = "x"
            let v481 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v480 
            let v482 : string = "String::from_iter($0)"
            let v483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "true; $0 }).collect::<Vec<_>>()"
            let v485 : bool = Fable.Core.RustInterop.emitRustExpr v483 v484 
            let v486 : string = "_vec_map"
            let v487 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v486 
            let v488 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v489 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v487 v488 
            let v490 : int32 = v489.Length
            let v493 : string = ""
            let v494 : bool = v230 <> v493 
            let v505 : bool =
                if v494 then
                    let v504 : bool = v490 <= 1
                    v504
                else
                    false
            if v505 then
                v302.l0 <- v384
                ()
            else
                v302.l0 <- v493
                let v506 : Mut5 = {l0 = 0} : Mut5
                while method31(v490, v506) do
                    let v508 : int32 = v506.l0
                    let v509 : std_string_String = v489.[int v508]
                    let v510 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v511 : bool = Fable.Core.RustInterop.emitRustExpr v509 v510 
                    let v512 : int32 = v508 + 1
                    v506.l0 <- v512
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v350 v230
            #endif
#if FABLE_COMPILER_PYTHON
            v350 v230
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v350 v230
            #endif
#else
            v350 v230
            #endif
            // run_target_args' is_unit
            let v513 : (string -> unit) = v300.l0
            v513 v230
            US11_0(v299, v300, v301, v302, v303, v304)
    let v547 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v547 
    ()
and closure96 () () : UH2 =
    UH2_1
and closure95 () () : UH2 =
    let v0 : (unit -> UH2) = closure96()
    UH2_0(9223372036854775808UL, v0)
and closure94 () () : UH2 =
    let v0 : (unit -> UH2) = closure95()
    UH2_0(4611686018427387904UL, v0)
and closure93 () () : UH2 =
    let v0 : (unit -> UH2) = closure94()
    UH2_0(6917529027641081856UL, v0)
and closure92 () () : UH2 =
    let v0 : (unit -> UH2) = closure93()
    UH2_0(1152921504606846976UL, v0)
and closure91 () () : UH2 =
    let v0 : (unit -> UH2) = closure92()
    UH2_0(15564440312192434176UL, v0)
and closure90 () () : UH2 =
    let v0 : (unit -> UH2) = closure91()
    UH2_0(11817445422220181504UL, v0)
and closure89 () () : UH2 =
    let v0 : (unit -> UH2) = closure90()
    UH2_0(5044031582654955520UL, v0)
and closure88 () () : UH2 =
    let v0 : (unit -> UH2) = closure89()
    UH2_0(6989586621679009792UL, v0)
and closure87 () () : UH2 =
    let v0 : (unit -> UH2) = closure88()
    UH2_0(16537217831704461312UL, v0)
and closure86 () () : UH2 =
    let v0 : (unit -> UH2) = closure87()
    UH2_0(11979575008805519360UL, v0)
and closure85 () () : UH2 =
    let v0 : (unit -> UH2) = closure86()
    UH2_0(14294425217273954304UL, v0)
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(2382404202878992384UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(6545982058383015936UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(10314369046585278464UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(4793518853382471680UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(3873377154515337216UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(645562859085889536UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(107593809847648256UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(3092389647259533312UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(9738770311398031360UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(16995415113324298240UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(8981483876790566912UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(13794743361938128896UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(2299123893656354816UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(3457644661227651072UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(576274110204608512UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(6244960376270618624UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(13338656111851470848UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(14520938734448279552UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(14717985838214414336UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(5527454985320660992UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(16293529225644736512UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(11938960241128898560UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(8138741398091333632UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(7505371590918406144UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(16623181993244360704UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(8919445023443910656UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(4561031516192243712UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(9983543956220149760UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(4738381338321616896UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(789730223053602816UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(131621703842267136UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(21936950640377856UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(3656158440062976UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(609359740010496UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(101559956668416UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(16926659444736UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(2821109907456UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(470184984576UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(78364164096UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(13060694016UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(2176782336UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(362797056UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(60466176UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(10077696UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(1679616UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(279936UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(46656UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(7776UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(1296UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(216UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(36UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(6UL, v0)
and method79 (v0 : int8, v1 : UH2) : US16 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US16_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method79(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US16_1
and method82 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "roll"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method83 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "value"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method81 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method16()
    let v13 : Mut3 = {l0 = v4} : Mut3
    method20(v13)
    method77(v13)
    method22(v13)
    let v157 : string = $"{v0}"
    method17(v13, v157)
    method23(v13)
    method68(v13)
    method22(v13)
    let v345 : string = $"{v1}"
    method17(v13, v345)
    method23(v13)
    method82(v13)
    method22(v13)
    let v533 : string = $"{v2}"
    method17(v13, v533)
    method23(v13)
    method83(v13)
    method22(v13)
    let v721 : string = $"{v3}"
    method17(v13, v721)
    method25(v13)
    let v810 : string = v13.l0
    v810
and method80 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : string = method81(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v28 : string = v17 + v7 
    let v40 : string = " #"
    let v41 : string = v28 + v40 
    let v62 : string = v13 |> _.ToString()
    let v73 : string = v41 + v62 
    let v84 : string = v73 + v16 
    let v96 : string = "dice.accumulate_dice_rolls"
    let v97 : string = v84 + v96 
    let v109 : string = " / "
    let v110 : string = v97 + v109 
    let v121 : string = v110 + v12 
    method26(v121)
and closure97 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure10()
    let v35 : unit = (fun () -> v34 (); v33) ()
    let struct (v73 : Mut0, v74 : Mut1, v75 : Mut2, v76 : Mut3, v77 : Mut4, v78 : int64 option) = TraceState.trace_state.Value
    let v113 : US4 = v77.l0
    let v114 : bool = v75.l0
    let v115 : bool = v114 = false
    let v118 : bool =
        if v115 then
            false
        else
            let v116 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v113
            let v117 : bool = 1 >= v116
            v117
    let v119 : bool = v118 = false
    let v516 : US11 =
        if v119 then
            US11_1
        else
            let v150 : unit = ()
            let v151 : unit = (fun () -> v34 (); v150) ()
            let struct (v189 : Mut0, v190 : Mut1, v191 : Mut2, v192 : Mut3, v193 : Mut4, v194 : int64 option) = TraceState.trace_state.Value
            let v229 : string = method10(v189, v190, v191, v192, v193, v194)
            let v230 : string = method14()
            let v231 : string = method80(v189, v190, v191, v192, v193, v194, v229, v230, v1, v0, v2, v3)
            let v261 : unit = ()
            let v262 : unit = (fun () -> v34 (); v261) ()
            let struct (v300 : Mut0, v301 : Mut1, v302 : Mut2, v303 : Mut3, v304 : Mut4, v305 : int64 option) = TraceState.trace_state.Value
            let v342 : unit = ()
            let v343 : (unit -> unit) = closure17(v300)
            let v344 : unit = (fun () -> v343 (); v342) ()
            let v351 : (string -> unit) = closure18()
            (* run_target_args'
            let v352 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v353 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v231 v353 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v354 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v231 v354 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v355 : string = v303.l0
            let v356 : bool = v355 = ""
            let v385 : string =
                if v356 then
                    v231
                else
                    let v357 : bool = v231 = ""
                    if v357 then
                        let v358 : string = v303.l0
                        v358
                    else
                        let v359 : string = v303.l0
                        let v362 : string = "\n"
                        let v363 : string = v359 + v362 
                        let v374 : string = v363 + v231 
                        v374
            (* run_target_args'
            let v397 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v398 : string = "&*$0"
            let v399 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v385 v398 
            let _run_target_args'_v397 = v399 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v400 : string = "&*$0"
            let v401 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v385 v400 
            let _run_target_args'_v397 = v401 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v402 : string = "&*$0"
            let v403 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v385 v402 
            let _run_target_args'_v397 = v403 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v405 : Ref<Str> = v385 |> unbox<Ref<Str>>
            let _run_target_args'_v397 = v405 
            #endif
#if FABLE_COMPILER_PYTHON
            let v416 : Ref<Str> = v385 |> unbox<Ref<Str>>
            let _run_target_args'_v397 = v416 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v427 : Ref<Str> = v385 |> unbox<Ref<Str>>
            let _run_target_args'_v397 = v427 
            #endif
#else
            let v438 : Ref<Str> = v385 |> unbox<Ref<Str>>
            let _run_target_args'_v397 = v438 
            #endif
            let v448 : Ref<Str> = _run_target_args'_v397 
            let v471 : string = $"$0.chars()"
            let v472 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v448 v471 
            let v473 : string = "$0"
            let v474 : _ = Fable.Core.RustInterop.emitRustExpr v472 v473 
            let v475 : string = "$0.collect::<Vec<_>>()"
            let v476 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v474 v475 
            let v477 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v478 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v476 v477 
            let v479 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v480 : bool = Fable.Core.RustInterop.emitRustExpr v478 v479 
            let v481 : string = "x"
            let v482 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v481 
            let v483 : string = "String::from_iter($0)"
            let v484 : std_string_String = Fable.Core.RustInterop.emitRustExpr v482 v483 
            let v485 : string = "true; $0 }).collect::<Vec<_>>()"
            let v486 : bool = Fable.Core.RustInterop.emitRustExpr v484 v485 
            let v487 : string = "_vec_map"
            let v488 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v487 
            let v489 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v490 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v488 v489 
            let v491 : int32 = v490.Length
            let v494 : string = ""
            let v495 : bool = v231 <> v494 
            let v506 : bool =
                if v495 then
                    let v505 : bool = v491 <= 1
                    v505
                else
                    false
            if v506 then
                v303.l0 <- v385
                ()
            else
                v303.l0 <- v494
                let v507 : Mut5 = {l0 = 0} : Mut5
                while method31(v491, v507) do
                    let v509 : int32 = v507.l0
                    let v510 : std_string_String = v490.[int v509]
                    let v511 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v512 : bool = Fable.Core.RustInterop.emitRustExpr v510 v511 
                    let v513 : int32 = v509 + 1
                    v507.l0 <- v513
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v351 v231
            #endif
#if FABLE_COMPILER_PYTHON
            v351 v231
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v351 v231
            #endif
#else
            v351 v231
            #endif
            // run_target_args' is_unit
            let v514 : (string -> unit) = v301.l0
            v514 v231
            US11_0(v300, v301, v302, v303, v304, v305)
    let v548 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v548 
    ()
and method85 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method16()
    let v12 : Mut3 = {l0 = v3} : Mut3
    method20(v12)
    method77(v12)
    method22(v12)
    let v156 : string = $"{v0}"
    method17(v12, v156)
    method23(v12)
    method68(v12)
    method22(v12)
    let v344 : string = $"{v1}"
    method17(v12, v344)
    method23(v12)
    method82(v12)
    method22(v12)
    let v532 : string = $"{v2}"
    method17(v12, v532)
    method25(v12)
    let v621 : string = v12.l0
    v621
and method84 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : string = method85(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v27 : string = v16 + v7 
    let v39 : string = " #"
    let v40 : string = v27 + v39 
    let v61 : string = v12 |> _.ToString()
    let v72 : string = v40 + v61 
    let v83 : string = v72 + v15 
    let v95 : string = "dice.accumulate_dice_rolls"
    let v96 : string = v83 + v95 
    let v108 : string = " / "
    let v109 : string = v96 + v108 
    let v120 : string = v109 + v11 
    method26(v120)
and closure98 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure10()
    let v34 : unit = (fun () -> v33 (); v32) ()
    let struct (v72 : Mut0, v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : Mut4, v77 : int64 option) = TraceState.trace_state.Value
    let v112 : US4 = v76.l0
    let v113 : bool = v74.l0
    let v114 : bool = v113 = false
    let v117 : bool =
        if v114 then
            false
        else
            let v115 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v112
            let v116 : bool = 1 >= v115
            v116
    let v118 : bool = v117 = false
    let v515 : US11 =
        if v118 then
            US11_1
        else
            let v149 : unit = ()
            let v150 : unit = (fun () -> v33 (); v149) ()
            let struct (v188 : Mut0, v189 : Mut1, v190 : Mut2, v191 : Mut3, v192 : Mut4, v193 : int64 option) = TraceState.trace_state.Value
            let v228 : string = method10(v188, v189, v190, v191, v192, v193)
            let v229 : string = method14()
            let v230 : string = method84(v188, v189, v190, v191, v192, v193, v228, v229, v1, v0, v2)
            let v260 : unit = ()
            let v261 : unit = (fun () -> v33 (); v260) ()
            let struct (v299 : Mut0, v300 : Mut1, v301 : Mut2, v302 : Mut3, v303 : Mut4, v304 : int64 option) = TraceState.trace_state.Value
            let v341 : unit = ()
            let v342 : (unit -> unit) = closure17(v299)
            let v343 : unit = (fun () -> v342 (); v341) ()
            let v350 : (string -> unit) = closure18()
            (* run_target_args'
            let v351 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v230 v352 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v353 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v230 v353 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v354 : string = v302.l0
            let v355 : bool = v354 = ""
            let v384 : string =
                if v355 then
                    v230
                else
                    let v356 : bool = v230 = ""
                    if v356 then
                        let v357 : string = v302.l0
                        v357
                    else
                        let v358 : string = v302.l0
                        let v361 : string = "\n"
                        let v362 : string = v358 + v361 
                        let v373 : string = v362 + v230 
                        v373
            (* run_target_args'
            let v396 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v397 : string = "&*$0"
            let v398 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v397 
            let _run_target_args'_v396 = v398 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v399 : string = "&*$0"
            let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v399 
            let _run_target_args'_v396 = v400 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v401 : string = "&*$0"
            let v402 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v401 
            let _run_target_args'_v396 = v402 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v404 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v404 
            #endif
#if FABLE_COMPILER_PYTHON
            let v415 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v415 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v426 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v426 
            #endif
#else
            let v437 : Ref<Str> = v384 |> unbox<Ref<Str>>
            let _run_target_args'_v396 = v437 
            #endif
            let v447 : Ref<Str> = _run_target_args'_v396 
            let v470 : string = $"$0.chars()"
            let v471 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v447 v470 
            let v472 : string = "$0"
            let v473 : _ = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "$0.collect::<Vec<_>>()"
            let v475 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v473 v474 
            let v476 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v477 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v475 v476 
            let v478 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v479 : bool = Fable.Core.RustInterop.emitRustExpr v477 v478 
            let v480 : string = "x"
            let v481 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v480 
            let v482 : string = "String::from_iter($0)"
            let v483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "true; $0 }).collect::<Vec<_>>()"
            let v485 : bool = Fable.Core.RustInterop.emitRustExpr v483 v484 
            let v486 : string = "_vec_map"
            let v487 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v486 
            let v488 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v489 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v487 v488 
            let v490 : int32 = v489.Length
            let v493 : string = ""
            let v494 : bool = v230 <> v493 
            let v505 : bool =
                if v494 then
                    let v504 : bool = v490 <= 1
                    v504
                else
                    false
            if v505 then
                v302.l0 <- v384
                ()
            else
                v302.l0 <- v493
                let v506 : Mut5 = {l0 = 0} : Mut5
                while method31(v490, v506) do
                    let v508 : int32 = v506.l0
                    let v509 : std_string_String = v489.[int v508]
                    let v510 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v511 : bool = Fable.Core.RustInterop.emitRustExpr v509 v510 
                    let v512 : int32 = v508 + 1
                    v506.l0 <- v512
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v350 v230
            #endif
#if FABLE_COMPILER_PYTHON
            v350 v230
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v350 v230
            #endif
#else
            v350 v230
            #endif
            // run_target_args' is_unit
            let v513 : (string -> unit) = v300.l0
            v513 v230
            US11_0(v299, v300, v301, v302, v303, v304)
    let v547 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v547 
    ()
and method74 (v0 : int8, v1 : UH0, v2 : uint64) : US15 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v554 : unit = ()
        let v555 : (unit -> unit) = closure32(v2, v0, v4)
        let v556 : unit = (fun () -> v555 (); v554) ()
        US15_0(v4, v1)
    else
        match v1 with
        | UH0_1(v1115, v1116) -> (* Cons *)
            let v1117 : bool = v1115 > 1uy
            if v1117 then
                let v1118 : uint64 = 1UL
                let v1119 : (unit -> UH2) = closure33()
                let v1120 : UH2 = UH2_0(v1118, v1119)
                let v1121 : US16 = method79(v0, v1120)
                let v1125 : uint64 =
                    match v1121 with
                    | US16_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US16_0(v1122) -> (* Some *)
                        v1122
                let v1126 : uint8 = v1115 - 1uy
                let v1127 : uint64 = uint64 v1126
                let v1128 : uint64 = v1127 * v1125
                let v1678 : unit = ()
                let v1679 : (unit -> unit) = closure97(v2, v0, v1115, v1128)
                let v1680 : unit = (fun () -> v1679 (); v1678) ()
                let v2237 : uint64 = v2 + v1128
                let v2238 : int8 = v0 - 1y
                method74(v2238, v1116, v2237)
            else
                let v2789 : unit = ()
                let v2790 : (unit -> unit) = closure98(v2, v0, v1115)
                let v2791 : unit = (fun () -> v2790 (); v2789) ()
                let v3348 : int8 = v0 - 1y
                method74(v3348, v1116, v2)
        | UH0_0 -> (* Nil *)
            US15_1
and method86 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut7, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method64(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method86(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method87 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut7, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method64(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method63(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US15 = method74(v6, v7, v13)
        match v14 with
        | US15_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method86(v6, v0, v1, v2, v3, v4, v18)
                method87(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method86(v6, v0, v1, v2, v3, v4, v22)
            method87(v0, v1, v2, v3, v4, v5, v6, v23)
and method63 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut7, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method64(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method63(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US15 = method74(v6, v7, v15)
        match v16 with
        | US15_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method86(v6, v0, v1, v2, v3, v4, v20)
                method87(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method86(v6, v0, v1, v2, v3, v4, v24)
            method87(v0, v1, v2, v3, v4, v5, v6, v25)
and method88 () : (unit -> unit) =
    closure20()
and closure99 (v0 : (unit -> unit)) () : unit =
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure10()
    let v32 : unit = (fun () -> v31 (); v30) ()
    let struct (v70 : Mut0, v71 : Mut1, v72 : Mut2, v73 : Mut3, v74 : Mut4, v75 : int64 option) = TraceState.trace_state.Value
    let v110 : US4 = v74.l0
    let v111 : bool = v72.l0
    let v112 : bool = v111 = false
    let v115 : bool =
        if v112 then
            false
        else
            let v113 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v110
            let v114 : bool = 1 >= v113
            v114
    let v116 : bool = v115 = false
    let v511 : US11 =
        if v116 then
            US11_1
        else
            let v147 : unit = ()
            let v148 : unit = (fun () -> v31 (); v147) ()
            let struct (v186 : Mut0, v187 : Mut1, v188 : Mut2, v189 : Mut3, v190 : Mut4, v191 : int64 option) = TraceState.trace_state.Value
            let v226 : string = method10(v186, v187, v188, v189, v190, v191)
            let v227 : string = method14()
            let v257 : unit = ()
            let v258 : unit = (fun () -> v31 (); v257) ()
            let struct (v296 : Mut0, v297 : Mut1, v298 : Mut2, v299 : Mut3, v300 : Mut4, v301 : int64 option) = TraceState.trace_state.Value
            let v338 : unit = ()
            let v339 : (unit -> unit) = closure17(v296)
            let v340 : unit = (fun () -> v339 (); v338) ()
            let v347 : string = ""
            let v348 : (string -> unit) = closure18()
            (* run_target_args'
            let v349 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v350 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v347 v350 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v351 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v347 v351 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v352 : string = v299.l0
            let v353 : bool = v352 = ""
            let v382 : string =
                if v353 then
                    v347
                else
                    let v354 : bool = v347 = ""
                    if v354 then
                        let v355 : string = v299.l0
                        v355
                    else
                        let v356 : string = v299.l0
                        let v359 : string = "\n"
                        let v360 : string = v356 + v359 
                        let v371 : string = v360 + v347 
                        v371
            (* run_target_args'
            let v394 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v395 : string = "&*$0"
            let v396 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v395 
            let _run_target_args'_v394 = v396 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v397 : string = "&*$0"
            let v398 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v397 
            let _run_target_args'_v394 = v398 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399 : string = "&*$0"
            let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v399 
            let _run_target_args'_v394 = v400 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v402 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v402 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v424 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v424 
            #endif
#else
            let v435 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v435 
            #endif
            let v445 : Ref<Str> = _run_target_args'_v394 
            let v468 : string = $"$0.chars()"
            let v469 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v445 v468 
            let v470 : string = "$0"
            let v471 : _ = Fable.Core.RustInterop.emitRustExpr v469 v470 
            let v472 : string = "$0.collect::<Vec<_>>()"
            let v473 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v475 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v473 v474 
            let v476 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v477 : bool = Fable.Core.RustInterop.emitRustExpr v475 v476 
            let v478 : string = "x"
            let v479 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v478 
            let v480 : string = "String::from_iter($0)"
            let v481 : std_string_String = Fable.Core.RustInterop.emitRustExpr v479 v480 
            let v482 : string = "true; $0 }).collect::<Vec<_>>()"
            let v483 : bool = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "_vec_map"
            let v485 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v484 
            let v486 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v487 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v485 v486 
            let v488 : int32 = v487.Length
            let v490 : bool = v347 <> v347 
            let v501 : bool =
                if v490 then
                    let v500 : bool = v488 <= 1
                    v500
                else
                    false
            if v501 then
                v299.l0 <- v382
                ()
            else
                v299.l0 <- v347
                let v502 : Mut5 = {l0 = 0} : Mut5
                while method31(v488, v502) do
                    let v504 : int32 = v502.l0
                    let v505 : std_string_String = v487.[int v504]
                    let v506 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v507 : bool = Fable.Core.RustInterop.emitRustExpr v505 v506 
                    let v508 : int32 = v504 + 1
                    v502.l0 <- v508
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v348 v347
            #endif
#if FABLE_COMPILER_PYTHON
            v348 v347
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v348 v347
            #endif
#else
            v348 v347
            #endif
            // run_target_args' is_unit
            let v509 : (string -> unit) = v297.l0
            v509 v347
            US11_0(v296, v297, v298, v299, v300, v301)
    let v543 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v543 
    ()
and method89 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method89(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method91 (v0 : uint64, v1 : string, v2 : string) : string =
    let v3 : string = method16()
    let v12 : Mut3 = {l0 = v3} : Mut3
    method20(v12)
    method40(v12)
    method22(v12)
    let v156 : string = $"{v0}"
    method17(v12, v156)
    method23(v12)
    method54(v12)
    method22(v12)
    method17(v12, v1)
    method23(v12)
    method78(v12)
    method22(v12)
    method17(v12, v2)
    method25(v12)
    let v595 : string = v12.l0
    v595
and method90 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : string = method91(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v27 : string = v16 + v7 
    let v39 : string = " #"
    let v40 : string = v27 + v39 
    let v61 : string = v12 |> _.ToString()
    let v72 : string = v40 + v61 
    let v83 : string = v72 + v15 
    let v95 : string = "dice_contract.roll_within_bounds"
    let v96 : string = v83 + v95 
    let v108 : string = " / "
    let v109 : string = v96 + v108 
    let v120 : string = v109 + v11 
    method26(v120)
and closure100 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure10()
    let v34 : unit = (fun () -> v33 (); v32) ()
    let struct (v72 : Mut0, v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : Mut4, v77 : int64 option) = TraceState.trace_state.Value
    let v112 : US4 = v76.l0
    let v113 : bool = v74.l0
    let v114 : bool = v113 = false
    let v117 : bool =
        if v114 then
            false
        else
            let v115 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v112
            let v116 : bool = 1 >= v115
            v116
    let v118 : bool = v117 = false
    let v537 : US11 =
        if v118 then
            US11_1
        else
            let v149 : unit = ()
            let v150 : unit = (fun () -> v33 (); v149) ()
            let struct (v188 : Mut0, v189 : Mut1, v190 : Mut2, v191 : Mut3, v192 : Mut4, v193 : int64 option) = TraceState.trace_state.Value
            let v228 : string = method10(v188, v189, v190, v191, v192, v193)
            let v229 : string = method14()
            let v231 : string = $"%A{v1}"
            let v242 : string = $"%A{v2}"
            let v252 : string = method90(v188, v189, v190, v191, v192, v193, v228, v229, v0, v231, v242)
            let v282 : unit = ()
            let v283 : unit = (fun () -> v33 (); v282) ()
            let struct (v321 : Mut0, v322 : Mut1, v323 : Mut2, v324 : Mut3, v325 : Mut4, v326 : int64 option) = TraceState.trace_state.Value
            let v363 : unit = ()
            let v364 : (unit -> unit) = closure17(v321)
            let v365 : unit = (fun () -> v364 (); v363) ()
            let v372 : (string -> unit) = closure18()
            (* run_target_args'
            let v373 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v374 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v252 v374 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v375 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v252 v375 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v376 : string = v324.l0
            let v377 : bool = v376 = ""
            let v406 : string =
                if v377 then
                    v252
                else
                    let v378 : bool = v252 = ""
                    if v378 then
                        let v379 : string = v324.l0
                        v379
                    else
                        let v380 : string = v324.l0
                        let v383 : string = "\n"
                        let v384 : string = v380 + v383 
                        let v395 : string = v384 + v252 
                        v395
            (* run_target_args'
            let v418 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v419 : string = "&*$0"
            let v420 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v406 v419 
            let _run_target_args'_v418 = v420 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v421 : string = "&*$0"
            let v422 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v406 v421 
            let _run_target_args'_v418 = v422 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v423 : string = "&*$0"
            let v424 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v406 v423 
            let _run_target_args'_v418 = v424 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v426 : Ref<Str> = v406 |> unbox<Ref<Str>>
            let _run_target_args'_v418 = v426 
            #endif
#if FABLE_COMPILER_PYTHON
            let v437 : Ref<Str> = v406 |> unbox<Ref<Str>>
            let _run_target_args'_v418 = v437 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v448 : Ref<Str> = v406 |> unbox<Ref<Str>>
            let _run_target_args'_v418 = v448 
            #endif
#else
            let v459 : Ref<Str> = v406 |> unbox<Ref<Str>>
            let _run_target_args'_v418 = v459 
            #endif
            let v469 : Ref<Str> = _run_target_args'_v418 
            let v492 : string = $"$0.chars()"
            let v493 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v469 v492 
            let v494 : string = "$0"
            let v495 : _ = Fable.Core.RustInterop.emitRustExpr v493 v494 
            let v496 : string = "$0.collect::<Vec<_>>()"
            let v497 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v495 v496 
            let v498 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v499 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v497 v498 
            let v500 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v501 : bool = Fable.Core.RustInterop.emitRustExpr v499 v500 
            let v502 : string = "x"
            let v503 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v502 
            let v504 : string = "String::from_iter($0)"
            let v505 : std_string_String = Fable.Core.RustInterop.emitRustExpr v503 v504 
            let v506 : string = "true; $0 }).collect::<Vec<_>>()"
            let v507 : bool = Fable.Core.RustInterop.emitRustExpr v505 v506 
            let v508 : string = "_vec_map"
            let v509 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v508 
            let v510 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v511 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v509 v510 
            let v512 : int32 = v511.Length
            let v515 : string = ""
            let v516 : bool = v252 <> v515 
            let v527 : bool =
                if v516 then
                    let v526 : bool = v512 <= 1
                    v526
                else
                    false
            if v527 then
                v324.l0 <- v406
                ()
            else
                v324.l0 <- v515
                let v528 : Mut5 = {l0 = 0} : Mut5
                while method31(v512, v528) do
                    let v530 : int32 = v528.l0
                    let v531 : std_string_String = v511.[int v530]
                    let v532 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v533 : bool = Fable.Core.RustInterop.emitRustExpr v531 v532 
                    let v534 : int32 = v530 + 1
                    v528.l0 <- v534
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v372 v252
            #endif
#if FABLE_COMPILER_PYTHON
            v372 v252
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v372 v252
            #endif
#else
            v372 v252
            #endif
            // run_target_args' is_unit
            let v535 : (string -> unit) = v322.l0
            v535 v252
            US11_0(v321, v322, v323, v324, v325, v326)
    let v569 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v569 
    ()
and method92 () : (unit -> unit) =
    closure20()
and closure101 (v0 : (unit -> unit)) () : unit =
    let v30 : unit = ()
    let v31 : (unit -> unit) = closure10()
    let v32 : unit = (fun () -> v31 (); v30) ()
    let struct (v70 : Mut0, v71 : Mut1, v72 : Mut2, v73 : Mut3, v74 : Mut4, v75 : int64 option) = TraceState.trace_state.Value
    let v110 : US4 = v74.l0
    let v111 : bool = v72.l0
    let v112 : bool = v111 = false
    let v115 : bool =
        if v112 then
            false
        else
            let v113 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v110
            let v114 : bool = 1 >= v113
            v114
    let v116 : bool = v115 = false
    let v511 : US11 =
        if v116 then
            US11_1
        else
            let v147 : unit = ()
            let v148 : unit = (fun () -> v31 (); v147) ()
            let struct (v186 : Mut0, v187 : Mut1, v188 : Mut2, v189 : Mut3, v190 : Mut4, v191 : int64 option) = TraceState.trace_state.Value
            let v226 : string = method10(v186, v187, v188, v189, v190, v191)
            let v227 : string = method14()
            let v257 : unit = ()
            let v258 : unit = (fun () -> v31 (); v257) ()
            let struct (v296 : Mut0, v297 : Mut1, v298 : Mut2, v299 : Mut3, v300 : Mut4, v301 : int64 option) = TraceState.trace_state.Value
            let v338 : unit = ()
            let v339 : (unit -> unit) = closure17(v296)
            let v340 : unit = (fun () -> v339 (); v338) ()
            let v347 : string = ""
            let v348 : (string -> unit) = closure18()
            (* run_target_args'
            let v349 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v350 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v347 v350 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v351 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v347 v351 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v352 : string = v299.l0
            let v353 : bool = v352 = ""
            let v382 : string =
                if v353 then
                    v347
                else
                    let v354 : bool = v347 = ""
                    if v354 then
                        let v355 : string = v299.l0
                        v355
                    else
                        let v356 : string = v299.l0
                        let v359 : string = "\n"
                        let v360 : string = v356 + v359 
                        let v371 : string = v360 + v347 
                        v371
            (* run_target_args'
            let v394 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v395 : string = "&*$0"
            let v396 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v395 
            let _run_target_args'_v394 = v396 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v397 : string = "&*$0"
            let v398 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v397 
            let _run_target_args'_v394 = v398 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399 : string = "&*$0"
            let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v382 v399 
            let _run_target_args'_v394 = v400 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v402 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v402 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v424 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v424 
            #endif
#else
            let v435 : Ref<Str> = v382 |> unbox<Ref<Str>>
            let _run_target_args'_v394 = v435 
            #endif
            let v445 : Ref<Str> = _run_target_args'_v394 
            let v468 : string = $"$0.chars()"
            let v469 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v445 v468 
            let v470 : string = "$0"
            let v471 : _ = Fable.Core.RustInterop.emitRustExpr v469 v470 
            let v472 : string = "$0.collect::<Vec<_>>()"
            let v473 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v471 v472 
            let v474 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v475 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v473 v474 
            let v476 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v477 : bool = Fable.Core.RustInterop.emitRustExpr v475 v476 
            let v478 : string = "x"
            let v479 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v478 
            let v480 : string = "String::from_iter($0)"
            let v481 : std_string_String = Fable.Core.RustInterop.emitRustExpr v479 v480 
            let v482 : string = "true; $0 }).collect::<Vec<_>>()"
            let v483 : bool = Fable.Core.RustInterop.emitRustExpr v481 v482 
            let v484 : string = "_vec_map"
            let v485 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v484 
            let v486 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v487 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v485 v486 
            let v488 : int32 = v487.Length
            let v490 : bool = v347 <> v347 
            let v501 : bool =
                if v490 then
                    let v500 : bool = v488 <= 1
                    v500
                else
                    false
            if v501 then
                v299.l0 <- v382
                ()
            else
                v299.l0 <- v347
                let v502 : Mut5 = {l0 = 0} : Mut5
                while method31(v488, v502) do
                    let v504 : int32 = v502.l0
                    let v505 : std_string_String = v487.[int v504]
                    let v506 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v507 : bool = Fable.Core.RustInterop.emitRustExpr v505 v506 
                    let v508 : int32 = v504 + 1
                    v502.l0 <- v508
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v348 v347
            #endif
#if FABLE_COMPILER_PYTHON
            v348 v347
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v348 v347
            #endif
#else
            v348 v347
            #endif
            // run_target_args' is_unit
            let v509 : (string -> unit) = v297.l0
            v509 v347
            US11_0(v296, v297, v298, v299, v300, v301)
    let v543 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v543 
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
    let v29 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "        Self((old_state.version + 1, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "true; /*"
    let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
    let v42 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v52 : string = "true; */"
    let v53 : bool = Fable.Core.RustInterop.emitRustExpr () v52 
    let v54 : string = "seeds"
    let v55 : string = "b\"" + v54 + "\""
    let v56 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = "near_sdk::store::vec::Vector::new($0)"
    let v58 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let _result = struct (2u, v58) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v59 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v59 
    let v60 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v60 
    let v61 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v61 
    let v62 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
    let v64 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v65 : bool = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v66 
    let v67 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v68 
    let v69 : string = $"&mut self.0.1"
    let v70 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : string = $"seed"
    let v72 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v71 
    let v73 : string = "true; v70.extend($0); //"
    let v74 : bool = Fable.Core.RustInterop.emitRustExpr v72 v73 
    let v75 : string = $"v70.len()"
    let v76 : uint32 = Fable.Core.RustInterop.emitRustExpr () v75 
    let v156 : US0 = method0(v76)
    let v175 : US1 =
        match v156 with
        | US0_1(v172) -> (* Error *)
            US1_1
        | US0_0(v170) -> (* Ok *)
            US1_0(v170)
    let v212 : int32 =
        match v175 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v209) -> (* Some *)
            v209
    let v295 : US2 = method1()
    let v314 : US3 =
        match v295 with
        | US2_1(v311) -> (* Error *)
            US3_1
        | US2_0(v309) -> (* Ok *)
            US3_0(v309)
    let v351 : unativeint =
        match v314 with
        | US3_1 -> (* None *)
            failwith<unativeint> "Option does not have a value."
        | US3_0(v348) -> (* Some *)
            v348
    let v431 : US0 = method2(v351)
    let v450 : US1 =
        match v431 with
        | US0_1(v447) -> (* Error *)
            US1_1
        | US0_0(v445) -> (* Ok *)
            US1_0(v445)
    let v487 : int32 =
        match v450 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v484) -> (* Some *)
            v484
    let v564 : int32 = v212 - v487
    let v565 : bool = v564 > 0
    if v565 then
        let v566 : string = "v70.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v567 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v564 v566 
        let v1128 : unit = ()
        let v1129 : (unit -> unit) = closure9(v564, v567)
        let v1130 : unit = (fun () -> v1129 (); v1128) ()
        ()
    let v1698 : (unit -> unit) = method32()
    let v2246 : unit = ()
    let v2247 : (unit -> unit) = closure21(v1698)
    let v2248 : unit = (fun () -> v2247 (); v2246) ()
    let v2803 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v2803 
    let v2804 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v2804 
    let v2805 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v2805 
    let v2806 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v2806 
    let v2807 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v2808 : bool = Fable.Core.RustInterop.emitRustExpr () v2807 
    let v2809 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v2810 : bool = Fable.Core.RustInterop.emitRustExpr () v2809 
    let v2811 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v2811 
    let v2812 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v2812 
    let v2813 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v2813 
    let v2814 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v2814 
    let v2815 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v2815 
    let v2816 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v2816 
    let v2817 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v2818 : bool = Fable.Core.RustInterop.emitRustExpr () v2817 
    let v2819 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v2820 : bool = Fable.Core.RustInterop.emitRustExpr () v2819 
    let v2821 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v2821 
    let v2822 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v2822 
    let v2823 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v2823 
    let v2824 : string = $"key"
    let v2825 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2824 
    let v2826 : string = $"proof"
    let v2827 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2826 
    let v2828 : string = $"max"
    let v2829 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2828 
    let v2830 : string = $"&mut self.0.1"
    let v2831 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v2830 
    let v2832 : string = $"near_sdk::env::random_seed()"
    let v2833 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2832 
    let v2834 : string = $"near_sdk::env::epoch_height()"
    let v2835 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2834 
    let v2836 : string = $"near_sdk::env::block_height()"
    let v2837 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2836 
    let v2838 : string = $"near_sdk::env::block_timestamp()"
    let v2839 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2838 
    let v2840 : string = $"near_sdk::env::account_balance()"
    let v2841 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v2840 
    let v2842 : string = $"near_sdk::env::signer_account_id()"
    let v2843 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v2842 
    let v2844 : string = $"near_sdk::env::predecessor_account_id()"
    let v2845 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v2844 
    let v2846 : string = $"&*v2831"
    let v2847 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v2846 
    let v2848 : string = $"v2847.iter().map(|x| *x).collect::<Vec<_>>()"
    let v2849 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2848 
    let v2850 : string = $"v2835.to_le_bytes()"
    let v2851 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v2850 
    let v2852 : string = $"v2851.to_vec()"
    let v2853 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2852 
    let v2854 : string = $"v2837.to_le_bytes()"
    let v2855 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v2854 
    let v2856 : string = $"v2855.to_vec()"
    let v2857 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2856 
    let v2858 : string = $"v2839.to_le_bytes()"
    let v2859 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v2858 
    let v2860 : string = $"v2859.to_vec()"
    let v2861 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2860 
    let v2862 : string = "$0.as_yoctonear()"
    let v2863 : u128 = Fable.Core.RustInterop.emitRustExpr v2841 v2862 
    let v2864 : string = $"v2863.to_le_bytes()"
    let v2865 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v2864 
    let v2866 : string = $"v2865.to_vec()"
    let v2867 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2866 
    let v2868 : string = $"v2843.as_bytes()"
    let v2869 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v2868 
    let v2870 : string = $"v2869.to_vec()"
    let v2871 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2870 
    let v2872 : string = $"v2845.as_bytes()"
    let v2873 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v2872 
    let v2874 : string = $"v2873.to_vec()"
    let v2875 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2874 
    let v2876 : string = $"$0.into_bytes()"
    let v2877 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2827 v2876 
    let v2878 : string = $"$0.into_bytes()"
    let v2879 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2825 v2878 
    let v2880 : (Vec<uint8> []) = [|v2833; v2849; v2853; v2857; v2861; v2867; v2871; v2875; v2877; v2879|]
    let v2881 : string = "$0.to_vec()"
    let v2882 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v2880 v2881 
    let v2883 : string = $"v2882.concat()"
    let v2884 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v2883 
    let v2885 : string = $"near_sdk::env::keccak512(&$0)"
    let v2886 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2884 v2885 
    let v2887 : string = "true; v2831.extend($0); //"
    let v2888 : bool = Fable.Core.RustInterop.emitRustExpr v2886 v2887 
    let v2889 : string = $"v2831.len()"
    let v2890 : uint32 = Fable.Core.RustInterop.emitRustExpr () v2889 
    let v2970 : US0 = method0(v2890)
    let v2989 : US1 =
        match v2970 with
        | US0_1(v2986) -> (* Error *)
            US1_1
        | US0_0(v2984) -> (* Ok *)
            US1_0(v2984)
    let v3026 : int32 =
        match v2989 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v3023) -> (* Some *)
            v3023
    let v3109 : US2 = method1()
    let v3128 : US3 =
        match v3109 with
        | US2_1(v3125) -> (* Error *)
            US3_1
        | US2_0(v3123) -> (* Ok *)
            US3_0(v3123)
    let v3165 : unativeint =
        match v3128 with
        | US3_1 -> (* None *)
            failwith<unativeint> "Option does not have a value."
        | US3_0(v3162) -> (* Some *)
            v3162
    let v3245 : US0 = method2(v3165)
    let v3264 : US1 =
        match v3245 with
        | US0_1(v3261) -> (* Error *)
            US1_1
        | US0_0(v3259) -> (* Ok *)
            US1_0(v3259)
    let v3301 : int32 =
        match v3264 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v3298) -> (* Some *)
            v3298
    let v3378 : int32 = v3026 - v3301
    let v3379 : bool = v3378 > 0
    if v3379 then
        let v3380 : string = "v2831.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v3381 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v3378 v3380 
        let v3942 : unit = ()
        let v3943 : (unit -> unit) = closure9(v3378, v3381)
        let v3944 : unit = (fun () -> v3943 (); v3942) ()
        ()
    let v4512 : (unit -> unit) = method32()
    let v5060 : unit = ()
    let v5061 : (unit -> unit) = closure21(v4512)
    let v5062 : unit = (fun () -> v5061 (); v5060) ()
    let v5617 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v5618 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v2886 v5617 
    let v5620 : uint8 list = v5618 |> Array.toList
    let v5635 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v5636 : (uint8 -> (UH0 -> UH0)) = method33()
    let v5637 : (uint8 list -> (UH0 -> UH0)) = v5635 v5636
    let v5638 : (UH0 -> UH0) = v5637 v5620
    let v5639 : UH0 = UH0_0
    let v5640 : UH0 = v5638 v5639
    let v5697 : UH1 = UH1_1
    let v5698 : UH1 = method34(v5640, v5697)
    let v5699 : UH1 = UH1_1
    let v5700 : UH1 = method35(v5698, v5699)
    let v5701 : UH0 = UH0_0
    let v5702 : UH0 = method36(v5700, v5701)
    let v6357 : unit = ()
    let v6358 : (unit -> unit) = closure26(v2831, v2825, v2827, v2829, v2833, v2835, v2837, v2839, v2841, v2843, v2845, v2884, v2886, v5702)
    let v6359 : unit = (fun () -> v6358 (); v6357) ()
    let v7021 : UH0 = UH0_0
    let v7022 : UH0 = method55(v5702, v7021)
    let v7023 : UH0 = method56(v5702, v7022)
    let v7024 : UH1 = UH1_1
    let v7025 : UH1 = method34(v7023, v7024)
    let v7026 : (unit -> UH1) = closure27(v7025)
    let v7027 : (unit -> UH1) = method57(v7025, v7026)
    let v7028 : Mut0 = {l0 = 0L} : Mut0
    let v7029 : Mut0 = {l0 = 1L} : Mut0
    let v7030 : Mut0 = {l0 = -1L} : Mut0
    let v7031 : US14 = US14_1
    let v7032 : Mut7 = {l0 = v7031} : Mut7
    let v7033 : bool = v2829 = 1UL
    let v7037 : int8 =
        if v7033 then
            1y
        else
            let v7034 : int8 = 0y
            let v7035 : uint64 = 1UL
            method58(v2829, v7034, v7035)
    let v7038 : int8 = v7037 - 1y
    let v7039 : UH0 = UH0_0
    let v7040 : int8 = 0y
    let v7041 : uint64 = method63(v7027, v7028, v7029, v7030, v7032, v2829, v7038, v7039, v7040)
    let v7042 : (unit -> unit) = method88()
    let v7590 : unit = ()
    let v7591 : (unit -> unit) = closure99(v7042)
    let v7592 : unit = (fun () -> v7591 (); v7590) ()
    let v8147 : string = "v7041 //"
    Fable.Core.RustInterop.emitRustExpr () v8147 
    let v8148 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v8148 
    let v8149 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v8149 
    let v8150 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v8150 
    let v8151 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v8151 
    let v8152 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v8153 : bool = Fable.Core.RustInterop.emitRustExpr () v8152 
    let v8154 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v8155 : bool = Fable.Core.RustInterop.emitRustExpr () v8154 
    let v8156 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v8156 
    let v8157 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v8157 
    let v8158 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v8158 
    let v8159 : string = $"max"
    let v8160 : uint64 = Fable.Core.RustInterop.emitRustExpr () v8159 
    let v8161 : string = $"rolls"
    let v8162 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v8161 
    let v8163 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v8164 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v8162 v8163 
    let v8166 : uint8 list = v8164 |> Array.toList
    let v8181 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v8182 : (uint8 -> (UH0 -> UH0)) = method33()
    let v8183 : (uint8 list -> (UH0 -> UH0)) = v8181 v8182
    let v8184 : (UH0 -> UH0) = v8183 v8166
    let v8185 : UH0 = UH0_0
    let v8186 : UH0 = v8184 v8185
    let v8243 : int8 = 0y
    let v8244 : int8 = method89(v8186, v8243)
    let v8245 : int8 = v8244 - 1y
    let v8246 : uint64 = 0UL
    let v8247 : US15 = method74(v8245, v8186, v8246)
    let v8257 : US16 =
        match v8247 with
        | US15_0(v8248, v8249) -> (* Some *)
            let v8250 : bool = v8248 >= 1UL
            let v8252 : bool =
                if v8250 then
                    let v8251 : bool = v8248 <= v8160
                    v8251
                else
                    false
            if v8252 then
                US16_0(v8248)
            else
                US16_1
        | _ ->
            US16_1
    let v8282 : uint64 option =
        match v8257 with
        | US16_1 -> (* None *)
            let v8271 : uint64 option = None
            v8271
        | US16_0(v8258) -> (* Some *)
            let v8260 : uint64 option = Some v8258 
            v8260
    let v8854 : unit = ()
    let v8855 : (unit -> unit) = closure100(v8160, v8162, v8282)
    let v8856 : unit = (fun () -> v8855 (); v8854) ()
    let v9435 : (unit -> unit) = method92()
    let v9983 : unit = ()
    let v9984 : (unit -> unit) = closure101(v9435)
    let v9985 : unit = (fun () -> v9984 (); v9983) ()
    let v10540 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v8282 v10540 
    let v10541 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v10541 
    let v10542 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v10542 
    let v10543 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v10543 
    let v10544 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v10545 : bool = Fable.Core.RustInterop.emitRustExpr () v10544 
    let v10546 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v10547 : bool = Fable.Core.RustInterop.emitRustExpr () v10546 
    let v10548 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v10548 
    let v10549 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v10549 
    let v10550 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v10550 
    let v10551 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v10551 
    let v10552 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v10552 
    let v10553 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v10553 
    let v10554 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v10554 
    let v10555 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v10555 
    let v10556 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v10556 
    let v10557 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v10557 
    let v10558 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v10558 
    let v10559 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v10560 : bool = Fable.Core.RustInterop.emitRustExpr () v10559 
    let v10561 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v10562 : bool = Fable.Core.RustInterop.emitRustExpr () v10561 
    let v10563 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v10563 
    let v10564 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v10564 
    let v10565 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v10566 : bool = Fable.Core.RustInterop.emitRustExpr () v10565 
    let v10567 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v10568 : bool = Fable.Core.RustInterop.emitRustExpr () v10567 
    let v10569 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v10570 : bool = Fable.Core.RustInterop.emitRustExpr () v10569 
    let v10571 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v10572 : bool = Fable.Core.RustInterop.emitRustExpr () v10571 
    let v10573 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v10574 : bool = Fable.Core.RustInterop.emitRustExpr () v10573 
    let v10575 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v10576 : bool = Fable.Core.RustInterop.emitRustExpr () v10575 
    let v10577 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v10578 : bool = Fable.Core.RustInterop.emitRustExpr () v10577 
    let v10579 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v10580 : bool = Fable.Core.RustInterop.emitRustExpr () v10579 
    let v10581 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v10582 : bool = Fable.Core.RustInterop.emitRustExpr () v10581 
    let v10583 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v10584 : bool = Fable.Core.RustInterop.emitRustExpr () v10583 
    let v10585 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v10586 : bool = Fable.Core.RustInterop.emitRustExpr () v10585 
    let v10587 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v10588 : bool = Fable.Core.RustInterop.emitRustExpr () v10587 
    let v10589 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v10590 : bool = Fable.Core.RustInterop.emitRustExpr () v10589 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
