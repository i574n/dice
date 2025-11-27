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
and [<Struct>] US8 =
    | US8_0 of f0_0 : US7
    | US8_1
and [<Struct>] US9 =
    | US9_0
    | US9_1
    | US9_2
    | US9_3
    | US9_4
    | US9_5 of f5_0 : US8
    | US9_6
    | US9_7
and [<Struct>] US10 =
    | US10_0 of f0_0 : string
    | US10_1
and [<Struct>] US11 =
    | US11_0 of f0_0 : int64
    | US11_1 of f1_0 : exn
and [<Struct>] US12 =
    | US12_0 of f0_0 : Mut0 * f0_1 : Mut1 * f0_2 : Mut2 * f0_3 : Mut3 * f0_4 : Mut4 * f0_5 : int64 option
    | US12_1
and [<Struct>] US13 =
    | US13_0 of f0_0 : char
    | US13_1
and Mut5 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of uint8 * UH0
and UH1 =
    | UH1_0 of uint8 * (unit -> UH1)
    | UH1_1
and [<Struct>] US14 =
    | US14_0 of f0_0 : (unit -> UH1)
    | US14_1 of f1_0 : UH1
and Mut6 = {mutable l0 : US14}
and [<Struct>] US15 =
    | US15_0 of f0_0 : uint8
    | US15_1
and Mut7 = {mutable l0 : US15}
and [<Struct>] US16 =
    | US16_0 of f0_0 : uint64 * f0_1 : UH0
    | US16_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US17 =
    | US17_0 of f0_0 : uint64
    | US17_1
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
and method10 () : string =
    let v0 : string = ""
    v0
and method11 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v5 : string = v2 + v1 
    v0.l0 <- v5
    ()
and method9 (v0 : US9) : string =
    let v1 : string = method10()
    let v12 : Mut3 = {l0 = v1} : Mut3
    let v15 : string = $"%A{v0}"
    method11(v12, v15)
    let v148 : string = v12.l0
    v148
and method12 (v0 : string) : string =
    let v1 : string = method10()
    let v12 : Mut3 = {l0 = v1} : Mut3
    method11(v12, v0)
    let v134 : string = v12.l0
    v134
and method8 (v0 : string) : string =
    let v1 : US7 = US7_0
    let v2 : US8 = US8_0(v1)
    let v3 : US9 = US9_5(v2)
    let v4 : string = method9(v3)
    let v9 : string = "env.get_environment_variable / target: "
    let v10 : string = v9 + v4 
    let v26 : string = " / var: "
    let v27 : string = v10 + v26 
    let v39 : string = method12(v0)
    let v42 : string = v27 + v39 
    failwith<string> v42
and method13 (v0 : string) : string =
    let v1 : US7 = US7_1
    let v2 : US8 = US8_0(v1)
    let v3 : US9 = US9_5(v2)
    let v4 : string = method9(v3)
    let v9 : string = "env.get_environment_variable / target: "
    let v10 : string = v9 + v4 
    let v26 : string = " / var: "
    let v27 : string = v10 + v26 
    let v39 : string = method12(v0)
    let v42 : string = v27 + v39 
    failwith<string> v42
and closure11 () (v0 : string) : US10 =
    US10_0(v0)
and method14 () : (string -> US10) =
    closure11()
and method5 (v0 : string) : string =
    (* run_target_args'
    let v31 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = method6(v0)
    let v33 : string = "std::env::var(&*$0)"
    let v34 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : string = "x"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "fable_library_rust::String_::fromString($0)"
    let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39 
    let v41 : string = "true; $0 })"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let v43 : string = "_result_map_"
    let v44 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = method7()
    let v46 : string = "$0.unwrap_or($1)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v46 
    let _run_target_args'_v31 = v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : string = method8(v0)
    let _run_target_args'_v31 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = method13(v0)
    let _run_target_args'_v31 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "process.env[$0] ?? \"\""
    let v51 : string = Fable.Core.JsInterop.emitJsExpr v0 v50 
    let _run_target_args'_v31 = v51 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : string = "os"
    let v66 : IOsEnviron = Fable.Core.PyInterop.importAll v65 
    let v67 : string = "v66.environ"
    let v68 : obj = Fable.Core.PyInterop.emitPyExpr () v67 
    let v93 : string = "v68.get($0)"
    let v94 : string = Fable.Core.PyInterop.emitPyExpr v0 v93 
    let mutable _v94 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v122 : (string -> string option) = Option.ofObj
    let v123 : string option = v122 v94
    v123 
    #else
    Some v94 
    #endif
    |> fun x -> _v94 <- Some x
    let v124 : string option = match _v94 with Some x -> x | None -> failwith "optionm'.of_obj / _v94=None"
    let v198 : (string -> US10) = method14()
    let v199 : US10 option = v124 |> Option.map v198 
    let v260 : US10 = US10_1
    let v261 : US10 = v199 |> Option.defaultValue v260 
    let v277 : string =
        match v261 with
        | US10_1 -> (* None *)
            let v275 : string = ""
            v275
        | US10_0(v274) -> (* Some *)
            v274
    let _run_target_args'_v31 = v277 
    #endif
#else
    let v278 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v279 : string = v278 v0
    let mutable _v279 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v296 : (string -> string option) = Option.ofObj
    let v297 : string option = v296 v279
    v297 
    #else
    Some v279 
    #endif
    |> fun x -> _v279 <- Some x
    let v298 : string option = match _v279 with Some x -> x | None -> failwith "optionm'.of_obj / _v279=None"
    let v372 : (string -> US10) = method14()
    let v373 : US10 option = v298 |> Option.map v372 
    let v434 : US10 = US10_1
    let v435 : US10 = v373 |> Option.defaultValue v434 
    let v451 : string =
        match v435 with
        | US10_1 -> (* None *)
            let v449 : string = ""
            v449
        | US10_0(v448) -> (* Some *)
            v448
    let _run_target_args'_v31 = v451 
    #endif
    let v452 : string = _run_target_args'_v31 
    v452
and closure12 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure13 () (v0 : int64) : US11 =
    US11_0(v0)
and closure14 () (v0 : exn) : US11 =
    US11_1(v0)
and method15 (v0 : int64) : US11 =
    let v1 : (unit -> int64) = closure12(v0)
    let v2 : (int64 -> US11) = closure13()
    let v3 : ((unit -> exn) -> exn) = closure3()
    let v4 : (exn -> US11) = closure14()
    let v5 : US11 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method4 () : struct (US5 * US6) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method5(v0)
    
    
    
    
    
    
    
    
    
    
    let v6 : string = "Critical"
    let v7 : (unit -> string) = v6.ToLower
    let v8 : string = v7 ()
    let v24 : string = "Warning"
    let v25 : (unit -> string) = v24.ToLower
    let v26 : string = v25 ()
    let v42 : string = "Info"
    let v43 : (unit -> string) = v42.ToLower
    let v44 : string = v43 ()
    let v60 : string = "Debug"
    let v61 : (unit -> string) = v60.ToLower
    let v62 : string = v61 ()
    let v78 : string = "Verbose"
    let v79 : (unit -> string) = v78.ToLower
    let v80 : string = v79 ()
    let v92 : bool = "Verbose" = v1
    let v96 : US5 =
        if v92 then
            let v93 : US4 = US4_0
            US5_0(v93)
        else
            US5_1
    let v182 : US5 =
        match v96 with
        | US5_1 -> (* None *)
            let v99 : bool = "Debug" = v1
            let v103 : US5 =
                if v99 then
                    let v100 : US4 = US4_1
                    US5_0(v100)
                else
                    US5_1
            match v103 with
            | US5_1 -> (* None *)
                let v106 : bool = "Info" = v1
                let v110 : US5 =
                    if v106 then
                        let v107 : US4 = US4_2
                        US5_0(v107)
                    else
                        US5_1
                match v110 with
                | US5_1 -> (* None *)
                    let v113 : bool = "Warning" = v1
                    let v117 : US5 =
                        if v113 then
                            let v114 : US4 = US4_3
                            US5_0(v114)
                        else
                            US5_1
                    match v117 with
                    | US5_1 -> (* None *)
                        let v120 : bool = "Critical" = v1
                        let v124 : US5 =
                            if v120 then
                                let v121 : US4 = US4_4
                                US5_0(v121)
                            else
                                US5_1
                        match v124 with
                        | US5_1 -> (* None *)
                            let v127 : bool = v80 = v1
                            let v131 : US5 =
                                if v127 then
                                    let v128 : US4 = US4_0
                                    US5_0(v128)
                                else
                                    US5_1
                            match v131 with
                            | US5_1 -> (* None *)
                                let v134 : bool = v62 = v1
                                let v138 : US5 =
                                    if v134 then
                                        let v135 : US4 = US4_1
                                        US5_0(v135)
                                    else
                                        US5_1
                                match v138 with
                                | US5_1 -> (* None *)
                                    let v141 : bool = v44 = v1
                                    let v145 : US5 =
                                        if v141 then
                                            let v142 : US4 = US4_2
                                            US5_0(v142)
                                        else
                                            US5_1
                                    match v145 with
                                    | US5_1 -> (* None *)
                                        let v148 : bool = v26 = v1
                                        let v152 : US5 =
                                            if v148 then
                                                let v149 : US4 = US4_3
                                                US5_0(v149)
                                            else
                                                US5_1
                                        match v152 with
                                        | US5_1 -> (* None *)
                                            let v155 : bool = v8 = v1
                                            let v159 : US5 =
                                                if v155 then
                                                    let v156 : US4 = US4_4
                                                    US5_0(v156)
                                                else
                                                    US5_1
                                            match v159 with
                                            | US5_1 -> (* None *)
                                                US5_1
                                            | US5_0(v160) -> (* Some *)
                                                US5_0(v160)
                                        | US5_0(v153) -> (* Some *)
                                            US5_0(v153)
                                    | US5_0(v146) -> (* Some *)
                                        US5_0(v146)
                                | US5_0(v139) -> (* Some *)
                                    US5_0(v139)
                            | US5_0(v132) -> (* Some *)
                                US5_0(v132)
                        | US5_0(v125) -> (* Some *)
                            US5_0(v125)
                    | US5_0(v118) -> (* Some *)
                        US5_0(v118)
                | US5_0(v111) -> (* Some *)
                    US5_0(v111)
            | US5_0(v104) -> (* Some *)
                US5_0(v104)
        | US5_0(v97) -> (* Some *)
            US5_0(v97)
    let v183 : string = "AUTOMATION"
    let v184 : string = method5(v183)
    let v189 : string = "True"
    let v190 : bool = v184 <> v189 
    let v558 : US6 =
        if v190 then
            US6_1
        else
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
            let v236 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v231 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v248 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v248 
            #endif
#if FABLE_COMPILER_PYTHON
            let v249 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v249 
            #endif
#else
            let v250 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v250 
            #endif
            let v251 : System.DateTime = _run_target_args'_v231 
            (* run_target_args'
            let v280 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v281 : (System.DateTime -> int64) = _.Ticks
            let v282 : int64 = v281 v251
            let _run_target_args'_v280 = v282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v283 : (System.DateTime -> int64) = _.Ticks
            let v284 : int64 = v283 v251
            let _run_target_args'_v280 = v284 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v287 : int64 = null |> unbox<int64>
            let _run_target_args'_v280 = v287 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v299 : (System.DateTime -> int64) = _.Ticks
            let v300 : int64 = v299 v251
            let _run_target_args'_v280 = v300 
            #endif
#if FABLE_COMPILER_PYTHON
            let v301 : (System.DateTime -> int64) = _.Ticks
            let v302 : int64 = v301 v251
            let _run_target_args'_v280 = v302 
            #endif
#else
            let v303 : (System.DateTime -> int64) = _.Ticks
            let v304 : int64 = v303 v251
            let _run_target_args'_v280 = v304 
            #endif
            let v305 : int64 = _run_target_args'_v280 
            let v463 : US11 = method15(v305)
            let v484 : US6 =
                match v463 with
                | US11_1(v481) -> (* Error *)
                    US6_1
                | US11_0(v479) -> (* Ok *)
                    US6_0(v479)
            let v531 : int64 =
                match v484 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v528) -> (* Some *)
                    v528
            US6_0(v531)
    struct (v182, v558)
and closure15 () (v0 : string) : unit =
    ()
and method3 (v0 : US4) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v6 : US5, v7 : US6) = method4()
    let _run_target_args'_v5 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : US5 = US5_1
    let v9 : US6 = US6_1
    let _run_target_args'_v5 = struct (v8, v9) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "AUTOMATION"
    (* run_target_args'
    let v39 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "option_env!(\"" + v10 + "\").unwrap_or(\"\")"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    (* run_target_args'
    let v70 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v71 : string = "String::from($0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v41 v71 
    let _run_target_args'_v70 = v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = "String::from($0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v41 v73 
    let _run_target_args'_v70 = v74 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : string = "String::from($0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v41 v75 
    let _run_target_args'_v70 = v76 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v79 : std_string_String = v41 |> unbox<std_string_String>
    let _run_target_args'_v70 = v79 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : std_string_String = v41 |> unbox<std_string_String>
    let _run_target_args'_v70 = v93 
    #endif
#else
    let v107 : std_string_String = v41 |> unbox<std_string_String>
    let _run_target_args'_v70 = v107 
    #endif
    let v119 : std_string_String = _run_target_args'_v70 
    let v148 : string = "fable_library_rust::String_::fromString($0)"
    let v149 : string = Fable.Core.RustInterop.emitRustExpr v119 v148 
    let _run_target_args'_v39 = v149 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v150 : string = "option_env!(\"" + v10 + "\").unwrap_or(\"\")"
    let v151 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v150 
    (* run_target_args'
    let v180 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v181 : string = "String::from($0)"
    let v182 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v181 
    let _run_target_args'_v180 = v182 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v183 : string = "String::from($0)"
    let v184 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v183 
    let _run_target_args'_v180 = v184 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : string = "String::from($0)"
    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v185 
    let _run_target_args'_v180 = v186 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v189 : std_string_String = v151 |> unbox<std_string_String>
    let _run_target_args'_v180 = v189 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : std_string_String = v151 |> unbox<std_string_String>
    let _run_target_args'_v180 = v203 
    #endif
#else
    let v217 : std_string_String = v151 |> unbox<std_string_String>
    let _run_target_args'_v180 = v217 
    #endif
    let v229 : std_string_String = _run_target_args'_v180 
    let v258 : string = "fable_library_rust::String_::fromString($0)"
    let v259 : string = Fable.Core.RustInterop.emitRustExpr v229 v258 
    let _run_target_args'_v39 = v259 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v260 : string = "option_env!(\"" + v10 + "\").unwrap_or(\"\")"
    let v261 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v260 
    (* run_target_args'
    let v290 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v291 : string = "String::from($0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v261 v291 
    let _run_target_args'_v290 = v292 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v293 : string = "String::from($0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v261 v293 
    let _run_target_args'_v290 = v294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = "String::from($0)"
    let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v261 v295 
    let _run_target_args'_v290 = v296 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v299 : std_string_String = v261 |> unbox<std_string_String>
    let _run_target_args'_v290 = v299 
    #endif
#if FABLE_COMPILER_PYTHON
    let v313 : std_string_String = v261 |> unbox<std_string_String>
    let _run_target_args'_v290 = v313 
    #endif
#else
    let v327 : std_string_String = v261 |> unbox<std_string_String>
    let _run_target_args'_v290 = v327 
    #endif
    let v339 : std_string_String = _run_target_args'_v290 
    let v368 : string = "fable_library_rust::String_::fromString($0)"
    let v369 : string = Fable.Core.RustInterop.emitRustExpr v339 v368 
    let _run_target_args'_v39 = v369 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v372 : string = null |> unbox<string>
    let _run_target_args'_v39 = v372 
    #endif
#if FABLE_COMPILER_PYTHON
    let v386 : string = null |> unbox<string>
    let _run_target_args'_v39 = v386 
    #endif
#else
    let v400 : string = null |> unbox<string>
    let _run_target_args'_v39 = v400 
    #endif
    let v412 : string = _run_target_args'_v39 
    let v445 : string = "True"
    let v446 : bool = v412 <> v445 
    let v554 : US6 =
        if v446 then
            US6_1
        else
            let v459 : string = $"near_sdk::env::block_timestamp()"
            let v460 : uint64 = Fable.Core.RustInterop.emitRustExpr () v459 
            let v540 : (uint64 -> int64) = int64
            let v541 : int64 = v540 v460
            US6_0(v541)
    let v555 : US5 = US5_1
    let _run_target_args'_v5 = struct (v555, v554) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v556 : US5, v557 : US6) = method4()
    let _run_target_args'_v5 = struct (v556, v557) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v558 : US5, v559 : US6) = method4()
    let _run_target_args'_v5 = struct (v558, v559) 
    #endif
#else
    let struct (v560 : US5, v561 : US6) = method4()
    let _run_target_args'_v5 = struct (v560, v561) 
    #endif
    let struct (v562 : US5, v563 : US6) = _run_target_args'_v5 
    let v568 : Mut0 = {l0 = 1L} : Mut0
    let v569 : (string -> unit) = closure15()
    let v570 : Mut1 = {l0 = v569} : Mut1
    let v571 : Mut2 = {l0 = true} : Mut2
    let v572 : string = ""
    let v573 : Mut3 = {l0 = v572} : Mut3
    let v576 : US4 =
        match v562 with
        | US5_1 -> (* None *)
            v0
        | US5_0(v574) -> (* Some *)
            v574
    let v577 : Mut4 = {l0 = v576} : Mut4
    let v608 : int64 option =
        match v563 with
        | US6_1 -> (* None *)
            let v595 : int64 option = None
            v595
        | US6_0(v578) -> (* Some *)
            let v581 : int64 option = Some v578 
            v581
    struct (v568, v570, v571, v573, v577, v608)
and closure10 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US4 = US4_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method3(v1)
        let v10 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v10 
        ()
and closure16 () (v0 : int64) : US6 =
    US6_0(v0)
and method17 () : (int64 -> US6) =
    closure16()
and method18 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method19 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method16 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v1630 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1693 : (int64 -> US6) = method17()
    let v1694 : US6 option = v5 |> Option.map v1693 
    let v1755 : US6 = US6_1
    let v1756 : US6 = v1694 |> Option.defaultValue v1755 
    let v2414 : System.DateTime =
        match v1756 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v2379 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2380 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2379 = v2380 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2381 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2379 = v2381 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2384 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2379 = v2384 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2396 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2379 = v2396 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2397 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2379 = v2397 
            #endif
#else
            let v2398 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2379 = v2398 
            #endif
            let v2399 : System.DateTime = _run_target_args'_v2379 
            v2399
        | US6_0(v1769) -> (* Some *)
            (* run_target_args'
            let v1798 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1799 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1798 = v1799 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1800 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1798 = v1800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1803 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1798 = v1803 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1815 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1798 = v1815 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1816 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1798 = v1816 
            #endif
#else
            let v1817 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1798 = v1817 
            #endif
            let v1818 : System.DateTime = _run_target_args'_v1798 
            (* run_target_args'
            let v1847 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1848 : (System.DateTime -> int64) = _.Ticks
            let v1849 : int64 = v1848 v1818
            let _run_target_args'_v1847 = v1849 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1850 : (System.DateTime -> int64) = _.Ticks
            let v1851 : int64 = v1850 v1818
            let _run_target_args'_v1847 = v1851 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1854 : int64 = null |> unbox<int64>
            let _run_target_args'_v1847 = v1854 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1866 : (System.DateTime -> int64) = _.Ticks
            let v1867 : int64 = v1866 v1818
            let _run_target_args'_v1847 = v1867 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1868 : (System.DateTime -> int64) = _.Ticks
            let v1869 : int64 = v1868 v1818
            let _run_target_args'_v1847 = v1869 
            #endif
#else
            let v1870 : (System.DateTime -> int64) = _.Ticks
            let v1871 : int64 = v1870 v1818
            let _run_target_args'_v1847 = v1871 
            #endif
            let v1872 : int64 = _run_target_args'_v1847 
            let v2030 : US11 = method15(v1872)
            let v2051 : US6 =
                match v2030 with
                | US11_1(v2048) -> (* Error *)
                    US6_1
                | US11_0(v2046) -> (* Ok *)
                    US6_0(v2046)
            let v2098 : int64 =
                match v2051 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v2095) -> (* Some *)
                    v2095
            let v2110 : int64 = v2098 - v1769
            let v2196 : System.TimeSpan = v2110 |> System.TimeSpan 
            let v2216 : (System.TimeSpan -> int32) = _.Hours
            let v2217 : int32 = v2216 v2196
            let v2237 : (System.TimeSpan -> int32) = _.Minutes
            let v2238 : int32 = v2237 v2196
            let v2258 : (System.TimeSpan -> int32) = _.Seconds
            let v2259 : int32 = v2258 v2196
            let v2279 : (System.TimeSpan -> int32) = _.Milliseconds
            let v2280 : int32 = v2279 v2196
            let v2339 : System.DateTime = System.DateTime (1, 1, 1, v2217, v2238, v2259, v2280)
            v2339
    let v2415 : string = method18()
    let v2443 : bool = v2415 = ""
    let v2445 : string =
        if v2443 then
            let v2444 : string = "M-d-y hh:mm:ss tt"
            v2444
        else
            v2415
    let v2446 : (string -> string) = v2414.ToString
    let v2447 : string = v2446 v2445
    let _run_target_args'_v1630 = v2447 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2549 : (int64 -> US6) = method17()
    let v2550 : US6 option = v5 |> Option.map v2549 
    let v2611 : US6 = US6_1
    let v2612 : US6 = v2550 |> Option.defaultValue v2611 
    let v3270 : System.DateTime =
        match v2612 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v3235 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3236 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3235 = v3236 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3237 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3235 = v3237 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3240 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3235 = v3240 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3252 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3235 = v3252 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3253 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3235 = v3253 
            #endif
#else
            let v3254 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3235 = v3254 
            #endif
            let v3255 : System.DateTime = _run_target_args'_v3235 
            v3255
        | US6_0(v2625) -> (* Some *)
            (* run_target_args'
            let v2654 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2655 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2654 = v2655 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2656 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2654 = v2656 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2659 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2654 = v2659 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2671 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2654 = v2671 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2672 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2654 = v2672 
            #endif
#else
            let v2673 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2654 = v2673 
            #endif
            let v2674 : System.DateTime = _run_target_args'_v2654 
            (* run_target_args'
            let v2703 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2704 : (System.DateTime -> int64) = _.Ticks
            let v2705 : int64 = v2704 v2674
            let _run_target_args'_v2703 = v2705 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2706 : (System.DateTime -> int64) = _.Ticks
            let v2707 : int64 = v2706 v2674
            let _run_target_args'_v2703 = v2707 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2710 : int64 = null |> unbox<int64>
            let _run_target_args'_v2703 = v2710 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2722 : (System.DateTime -> int64) = _.Ticks
            let v2723 : int64 = v2722 v2674
            let _run_target_args'_v2703 = v2723 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2724 : (System.DateTime -> int64) = _.Ticks
            let v2725 : int64 = v2724 v2674
            let _run_target_args'_v2703 = v2725 
            #endif
#else
            let v2726 : (System.DateTime -> int64) = _.Ticks
            let v2727 : int64 = v2726 v2674
            let _run_target_args'_v2703 = v2727 
            #endif
            let v2728 : int64 = _run_target_args'_v2703 
            let v2886 : US11 = method15(v2728)
            let v2907 : US6 =
                match v2886 with
                | US11_1(v2904) -> (* Error *)
                    US6_1
                | US11_0(v2902) -> (* Ok *)
                    US6_0(v2902)
            let v2954 : int64 =
                match v2907 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v2951) -> (* Some *)
                    v2951
            let v2966 : int64 = v2954 - v2625
            let v3052 : System.TimeSpan = v2966 |> System.TimeSpan 
            let v3072 : (System.TimeSpan -> int32) = _.Hours
            let v3073 : int32 = v3072 v3052
            let v3093 : (System.TimeSpan -> int32) = _.Minutes
            let v3094 : int32 = v3093 v3052
            let v3114 : (System.TimeSpan -> int32) = _.Seconds
            let v3115 : int32 = v3114 v3052
            let v3135 : (System.TimeSpan -> int32) = _.Milliseconds
            let v3136 : int32 = v3135 v3052
            let v3195 : System.DateTime = System.DateTime (1, 1, 1, v3073, v3094, v3115, v3136)
            v3195
    let v3271 : string = method18()
    let v3299 : bool = v3271 = ""
    let v3301 : string =
        if v3299 then
            let v3300 : string = "M-d-y hh:mm:ss tt"
            v3300
        else
            v3271
    let v3302 : (string -> string) = v3270.ToString
    let v3303 : string = v3302 v3301
    let _run_target_args'_v1630 = v3303 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3343 : string = $"near_sdk::env::block_timestamp()"
    let v3344 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3343 
    let v3407 : (int64 -> US6) = method17()
    let v3408 : US6 option = v5 |> Option.map v3407 
    let v3469 : US6 = US6_1
    let v3470 : US6 = v3408 |> Option.defaultValue v3469 
    let v3578 : uint64 =
        match v3470 with
        | US6_1 -> (* None *)
            v3344
        | US6_0(v3483) -> (* Some *)
            let v3563 : (int64 -> uint64) = uint64
            let v3564 : uint64 = v3563 v3483
            let v3576 : uint64 = v3344 - v3564
            v3576
    let v3579 : uint64 = v3578 / 1000000000UL
    let v3580 : uint64 = v3579 % 60UL
    let v3581 : uint64 = v3579 / 60UL
    let v3582 : uint64 = v3581 % 60UL
    let v3583 : uint64 = v3579 / 3600UL
    let v3584 : uint64 = v3583 % 24UL
    let v3585 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v3586 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3584, v3582, v3580) v3585 
    let v3587 : string = "fable_library_rust::String_::fromString($0)"
    let v3588 : string = Fable.Core.RustInterop.emitRustExpr v3586 v3587 
    let _run_target_args'_v1630 = v3588 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3651 : (int64 -> US6) = method17()
    let v3652 : US6 option = v5 |> Option.map v3651 
    let v3713 : US6 = US6_1
    let v3714 : US6 = v3652 |> Option.defaultValue v3713 
    let v4372 : System.DateTime =
        match v3714 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v4337 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4338 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4337 = v4338 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4339 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4337 = v4339 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4342 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v4337 = v4342 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4354 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4337 = v4354 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4355 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4337 = v4355 
            #endif
#else
            let v4356 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4337 = v4356 
            #endif
            let v4357 : System.DateTime = _run_target_args'_v4337 
            v4357
        | US6_0(v3727) -> (* Some *)
            (* run_target_args'
            let v3756 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3757 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3756 = v3757 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3758 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3756 = v3758 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3761 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3756 = v3761 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3773 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3756 = v3773 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3774 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3756 = v3774 
            #endif
#else
            let v3775 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3756 = v3775 
            #endif
            let v3776 : System.DateTime = _run_target_args'_v3756 
            (* run_target_args'
            let v3805 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3806 : (System.DateTime -> int64) = _.Ticks
            let v3807 : int64 = v3806 v3776
            let _run_target_args'_v3805 = v3807 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3808 : (System.DateTime -> int64) = _.Ticks
            let v3809 : int64 = v3808 v3776
            let _run_target_args'_v3805 = v3809 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3812 : int64 = null |> unbox<int64>
            let _run_target_args'_v3805 = v3812 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3824 : (System.DateTime -> int64) = _.Ticks
            let v3825 : int64 = v3824 v3776
            let _run_target_args'_v3805 = v3825 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3826 : (System.DateTime -> int64) = _.Ticks
            let v3827 : int64 = v3826 v3776
            let _run_target_args'_v3805 = v3827 
            #endif
#else
            let v3828 : (System.DateTime -> int64) = _.Ticks
            let v3829 : int64 = v3828 v3776
            let _run_target_args'_v3805 = v3829 
            #endif
            let v3830 : int64 = _run_target_args'_v3805 
            let v3988 : US11 = method15(v3830)
            let v4009 : US6 =
                match v3988 with
                | US11_1(v4006) -> (* Error *)
                    US6_1
                | US11_0(v4004) -> (* Ok *)
                    US6_0(v4004)
            let v4056 : int64 =
                match v4009 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v4053) -> (* Some *)
                    v4053
            let v4068 : int64 = v4056 - v3727
            let v4154 : System.TimeSpan = v4068 |> System.TimeSpan 
            let v4174 : (System.TimeSpan -> int32) = _.Hours
            let v4175 : int32 = v4174 v4154
            let v4195 : (System.TimeSpan -> int32) = _.Minutes
            let v4196 : int32 = v4195 v4154
            let v4216 : (System.TimeSpan -> int32) = _.Seconds
            let v4217 : int32 = v4216 v4154
            let v4237 : (System.TimeSpan -> int32) = _.Milliseconds
            let v4238 : int32 = v4237 v4154
            let v4297 : System.DateTime = System.DateTime (1, 1, 1, v4175, v4196, v4217, v4238)
            v4297
    let v4373 : string = method19()
    let v4401 : bool = v4373 = ""
    let v4403 : string =
        if v4401 then
            let v4402 : string = "M-d-y hh:mm:ss tt"
            v4402
        else
            v4373
    let v4404 : (string -> string) = v4372.ToString
    let v4405 : string = v4404 v4403
    let _run_target_args'_v1630 = v4405 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4507 : (int64 -> US6) = method17()
    let v4508 : US6 option = v5 |> Option.map v4507 
    let v4569 : US6 = US6_1
    let v4570 : US6 = v4508 |> Option.defaultValue v4569 
    let v5228 : System.DateTime =
        match v4570 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v5193 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5194 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5193 = v5194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5195 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5193 = v5195 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5198 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v5193 = v5198 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5210 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5193 = v5210 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5211 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5193 = v5211 
            #endif
#else
            let v5212 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5193 = v5212 
            #endif
            let v5213 : System.DateTime = _run_target_args'_v5193 
            v5213
        | US6_0(v4583) -> (* Some *)
            (* run_target_args'
            let v4612 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4613 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4612 = v4613 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4614 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4612 = v4614 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4617 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v4612 = v4617 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4629 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4612 = v4629 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4630 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4612 = v4630 
            #endif
#else
            let v4631 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4612 = v4631 
            #endif
            let v4632 : System.DateTime = _run_target_args'_v4612 
            (* run_target_args'
            let v4661 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4662 : (System.DateTime -> int64) = _.Ticks
            let v4663 : int64 = v4662 v4632
            let _run_target_args'_v4661 = v4663 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4664 : (System.DateTime -> int64) = _.Ticks
            let v4665 : int64 = v4664 v4632
            let _run_target_args'_v4661 = v4665 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4668 : int64 = null |> unbox<int64>
            let _run_target_args'_v4661 = v4668 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4680 : (System.DateTime -> int64) = _.Ticks
            let v4681 : int64 = v4680 v4632
            let _run_target_args'_v4661 = v4681 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4682 : (System.DateTime -> int64) = _.Ticks
            let v4683 : int64 = v4682 v4632
            let _run_target_args'_v4661 = v4683 
            #endif
#else
            let v4684 : (System.DateTime -> int64) = _.Ticks
            let v4685 : int64 = v4684 v4632
            let _run_target_args'_v4661 = v4685 
            #endif
            let v4686 : int64 = _run_target_args'_v4661 
            let v4844 : US11 = method15(v4686)
            let v4865 : US6 =
                match v4844 with
                | US11_1(v4862) -> (* Error *)
                    US6_1
                | US11_0(v4860) -> (* Ok *)
                    US6_0(v4860)
            let v4912 : int64 =
                match v4865 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v4909) -> (* Some *)
                    v4909
            let v4924 : int64 = v4912 - v4583
            let v5010 : System.TimeSpan = v4924 |> System.TimeSpan 
            let v5030 : (System.TimeSpan -> int32) = _.Hours
            let v5031 : int32 = v5030 v5010
            let v5051 : (System.TimeSpan -> int32) = _.Minutes
            let v5052 : int32 = v5051 v5010
            let v5072 : (System.TimeSpan -> int32) = _.Seconds
            let v5073 : int32 = v5072 v5010
            let v5093 : (System.TimeSpan -> int32) = _.Milliseconds
            let v5094 : int32 = v5093 v5010
            let v5153 : System.DateTime = System.DateTime (1, 1, 1, v5031, v5052, v5073, v5094)
            v5153
    let v5229 : string = method19()
    let v5257 : bool = v5229 = ""
    let v5259 : string =
        if v5257 then
            let v5258 : string = "M-d-y hh:mm:ss tt"
            v5258
        else
            v5229
    let v5260 : (string -> string) = v5228.ToString
    let v5261 : string = v5260 v5259
    let _run_target_args'_v1630 = v5261 
    #endif
#else
    let v5363 : (int64 -> US6) = method17()
    let v5364 : US6 option = v5 |> Option.map v5363 
    let v5425 : US6 = US6_1
    let v5426 : US6 = v5364 |> Option.defaultValue v5425 
    let v6084 : System.DateTime =
        match v5426 with
        | US6_1 -> (* None *)
            (* run_target_args'
            let v6049 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6050 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6049 = v6050 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6051 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6049 = v6051 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6054 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v6049 = v6054 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6066 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6049 = v6066 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6067 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6049 = v6067 
            #endif
#else
            let v6068 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6049 = v6068 
            #endif
            let v6069 : System.DateTime = _run_target_args'_v6049 
            v6069
        | US6_0(v5439) -> (* Some *)
            (* run_target_args'
            let v5468 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5469 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5468 = v5469 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5470 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5468 = v5470 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5473 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v5468 = v5473 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5485 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5468 = v5485 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5486 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5468 = v5486 
            #endif
#else
            let v5487 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5468 = v5487 
            #endif
            let v5488 : System.DateTime = _run_target_args'_v5468 
            (* run_target_args'
            let v5517 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5518 : (System.DateTime -> int64) = _.Ticks
            let v5519 : int64 = v5518 v5488
            let _run_target_args'_v5517 = v5519 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5520 : (System.DateTime -> int64) = _.Ticks
            let v5521 : int64 = v5520 v5488
            let _run_target_args'_v5517 = v5521 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5524 : int64 = null |> unbox<int64>
            let _run_target_args'_v5517 = v5524 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5536 : (System.DateTime -> int64) = _.Ticks
            let v5537 : int64 = v5536 v5488
            let _run_target_args'_v5517 = v5537 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5538 : (System.DateTime -> int64) = _.Ticks
            let v5539 : int64 = v5538 v5488
            let _run_target_args'_v5517 = v5539 
            #endif
#else
            let v5540 : (System.DateTime -> int64) = _.Ticks
            let v5541 : int64 = v5540 v5488
            let _run_target_args'_v5517 = v5541 
            #endif
            let v5542 : int64 = _run_target_args'_v5517 
            let v5700 : US11 = method15(v5542)
            let v5721 : US6 =
                match v5700 with
                | US11_1(v5718) -> (* Error *)
                    US6_1
                | US11_0(v5716) -> (* Ok *)
                    US6_0(v5716)
            let v5768 : int64 =
                match v5721 with
                | US6_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US6_0(v5765) -> (* Some *)
                    v5765
            let v5780 : int64 = v5768 - v5439
            let v5866 : System.TimeSpan = v5780 |> System.TimeSpan 
            let v5886 : (System.TimeSpan -> int32) = _.Hours
            let v5887 : int32 = v5886 v5866
            let v5907 : (System.TimeSpan -> int32) = _.Minutes
            let v5908 : int32 = v5907 v5866
            let v5928 : (System.TimeSpan -> int32) = _.Seconds
            let v5929 : int32 = v5928 v5866
            let v5949 : (System.TimeSpan -> int32) = _.Milliseconds
            let v5950 : int32 = v5949 v5866
            let v6009 : System.DateTime = System.DateTime (1, 1, 1, v5887, v5908, v5929, v5950)
            v6009
    let v6085 : string = method19()
    let v6113 : bool = v6085 = ""
    let v6115 : string =
        if v6113 then
            let v6114 : string = "M-d-y hh:mm:ss tt"
            v6114
        else
            v6085
    let v6116 : (string -> string) = v6084.ToString
    let v6117 : string = v6116 v6115
    let _run_target_args'_v1630 = v6117 
    #endif
    let v6157 : string = _run_target_args'_v1630 
    v6157
and method21 (v0 : char) : string =
    let v1 : string = method10()
    let v12 : Mut3 = {l0 = v1} : Mut3
    let v41 : string = $"{v0}"
    method11(v12, v41)
    let v164 : string = v12.l0
    v164
and method20 () : string =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "inline_colorization::color_bright_blue"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3 
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = "String::from($0)"
    let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v34 
    let _run_target_args'_v33 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "String::from($0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v36 
    let _run_target_args'_v33 = v37 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v38 
    let _run_target_args'_v33 = v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v42 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v33 = v42 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v33 = v56 
    #endif
#else
    let v70 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v33 = v70 
    #endif
    let v82 : std_string_String = _run_target_args'_v33 
    let v111 : string = "fable_library_rust::String_::fromString($0)"
    let v112 : string = Fable.Core.RustInterop.emitRustExpr v82 v111 
    let _run_target_args'_v2 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "inline_colorization::color_bright_blue"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v113 
    (* run_target_args'
    let v143 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : string = "String::from($0)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v114 v144 
    let _run_target_args'_v143 = v145 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v146 : string = "String::from($0)"
    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v114 v146 
    let _run_target_args'_v143 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = "String::from($0)"
    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v114 v148 
    let _run_target_args'_v143 = v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v152 : std_string_String = v114 |> unbox<std_string_String>
    let _run_target_args'_v143 = v152 
    #endif
#if FABLE_COMPILER_PYTHON
    let v166 : std_string_String = v114 |> unbox<std_string_String>
    let _run_target_args'_v143 = v166 
    #endif
#else
    let v180 : std_string_String = v114 |> unbox<std_string_String>
    let _run_target_args'_v143 = v180 
    #endif
    let v192 : std_string_String = _run_target_args'_v143 
    let v221 : string = "fable_library_rust::String_::fromString($0)"
    let v222 : string = Fable.Core.RustInterop.emitRustExpr v192 v221 
    let _run_target_args'_v2 = v222 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v223 : string = "inline_colorization::color_bright_blue"
    let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v223 
    (* run_target_args'
    let v253 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v254 : string = "String::from($0)"
    let v255 : std_string_String = Fable.Core.RustInterop.emitRustExpr v224 v254 
    let _run_target_args'_v253 = v255 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v256 : string = "String::from($0)"
    let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v224 v256 
    let _run_target_args'_v253 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : string = "String::from($0)"
    let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v224 v258 
    let _run_target_args'_v253 = v259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v262 : std_string_String = v224 |> unbox<std_string_String>
    let _run_target_args'_v253 = v262 
    #endif
#if FABLE_COMPILER_PYTHON
    let v276 : std_string_String = v224 |> unbox<std_string_String>
    let _run_target_args'_v253 = v276 
    #endif
#else
    let v290 : std_string_String = v224 |> unbox<std_string_String>
    let _run_target_args'_v253 = v290 
    #endif
    let v302 : std_string_String = _run_target_args'_v253 
    let v331 : string = "fable_library_rust::String_::fromString($0)"
    let v332 : string = Fable.Core.RustInterop.emitRustExpr v302 v331 
    let _run_target_args'_v2 = v332 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v333 : string = "\u001b[94m"
    let _run_target_args'_v2 = v333 
    #endif
#if FABLE_COMPILER_PYTHON
    let v334 : string = "\u001b[94m"
    let _run_target_args'_v2 = v334 
    #endif
#else
    let v335 : string = "\u001b[94m"
    let _run_target_args'_v2 = v335 
    #endif
    let v336 : string = _run_target_args'_v2 
    
    
    
    
    
    let v343 : string = "Debug"
    let v344 : (unit -> string) = v343.ToLower
    let v345 : string = v344 ()
    let v357 : char = v345.[int 0]
    let v358 : string = method21(v357)
    let v361 : string = v336 + v358 
    (* run_target_args'
    let v375 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v376 : string = "inline_colorization::color_reset"
    let v377 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v376 
    (* run_target_args'
    let v406 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v407 : string = "String::from($0)"
    let v408 : std_string_String = Fable.Core.RustInterop.emitRustExpr v377 v407 
    let _run_target_args'_v406 = v408 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v409 : string = "String::from($0)"
    let v410 : std_string_String = Fable.Core.RustInterop.emitRustExpr v377 v409 
    let _run_target_args'_v406 = v410 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v411 : string = "String::from($0)"
    let v412 : std_string_String = Fable.Core.RustInterop.emitRustExpr v377 v411 
    let _run_target_args'_v406 = v412 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v415 : std_string_String = v377 |> unbox<std_string_String>
    let _run_target_args'_v406 = v415 
    #endif
#if FABLE_COMPILER_PYTHON
    let v429 : std_string_String = v377 |> unbox<std_string_String>
    let _run_target_args'_v406 = v429 
    #endif
#else
    let v443 : std_string_String = v377 |> unbox<std_string_String>
    let _run_target_args'_v406 = v443 
    #endif
    let v455 : std_string_String = _run_target_args'_v406 
    let v484 : string = "fable_library_rust::String_::fromString($0)"
    let v485 : string = Fable.Core.RustInterop.emitRustExpr v455 v484 
    let _run_target_args'_v375 = v485 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v486 : string = "inline_colorization::color_reset"
    let v487 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v486 
    (* run_target_args'
    let v516 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v517 : string = "String::from($0)"
    let v518 : std_string_String = Fable.Core.RustInterop.emitRustExpr v487 v517 
    let _run_target_args'_v516 = v518 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v519 : string = "String::from($0)"
    let v520 : std_string_String = Fable.Core.RustInterop.emitRustExpr v487 v519 
    let _run_target_args'_v516 = v520 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v521 : string = "String::from($0)"
    let v522 : std_string_String = Fable.Core.RustInterop.emitRustExpr v487 v521 
    let _run_target_args'_v516 = v522 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v525 : std_string_String = v487 |> unbox<std_string_String>
    let _run_target_args'_v516 = v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v539 : std_string_String = v487 |> unbox<std_string_String>
    let _run_target_args'_v516 = v539 
    #endif
#else
    let v553 : std_string_String = v487 |> unbox<std_string_String>
    let _run_target_args'_v516 = v553 
    #endif
    let v565 : std_string_String = _run_target_args'_v516 
    let v594 : string = "fable_library_rust::String_::fromString($0)"
    let v595 : string = Fable.Core.RustInterop.emitRustExpr v565 v594 
    let _run_target_args'_v375 = v595 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v596 : string = "inline_colorization::color_reset"
    let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
    (* run_target_args'
    let v626 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v627 : string = "String::from($0)"
    let v628 : std_string_String = Fable.Core.RustInterop.emitRustExpr v597 v627 
    let _run_target_args'_v626 = v628 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v629 : string = "String::from($0)"
    let v630 : std_string_String = Fable.Core.RustInterop.emitRustExpr v597 v629 
    let _run_target_args'_v626 = v630 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v631 : string = "String::from($0)"
    let v632 : std_string_String = Fable.Core.RustInterop.emitRustExpr v597 v631 
    let _run_target_args'_v626 = v632 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v635 : std_string_String = v597 |> unbox<std_string_String>
    let _run_target_args'_v626 = v635 
    #endif
#if FABLE_COMPILER_PYTHON
    let v649 : std_string_String = v597 |> unbox<std_string_String>
    let _run_target_args'_v626 = v649 
    #endif
#else
    let v663 : std_string_String = v597 |> unbox<std_string_String>
    let _run_target_args'_v626 = v663 
    #endif
    let v675 : std_string_String = _run_target_args'_v626 
    let v704 : string = "fable_library_rust::String_::fromString($0)"
    let v705 : string = Fable.Core.RustInterop.emitRustExpr v675 v704 
    let _run_target_args'_v375 = v705 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v706 : string = "\u001b[0m"
    let _run_target_args'_v375 = v706 
    #endif
#if FABLE_COMPILER_PYTHON
    let v707 : string = "\u001b[0m"
    let _run_target_args'_v375 = v707 
    #endif
#else
    let v708 : string = "\u001b[0m"
    let _run_target_args'_v375 = v708 
    #endif
    let v709 : string = _run_target_args'_v375 
    let v714 : string = v361 + v709 
    v714
and method23 (v0 : int64) : string =
    let v1 : string = method10()
    let v12 : Mut3 = {l0 = v1} : Mut3
    let v41 : string = $"{v0}"
    method11(v12, v41)
    let v164 : string = v12.l0
    v164
and method25 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "{ "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method26 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "seed_excess_len"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method27 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = " = "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method28 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "; "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method29 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "seed_excess"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method30 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = " }"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method24 (v0 : int32, v1 : string) : string =
    let v2 : string = method10()
    let v13 : Mut3 = {l0 = v2} : Mut3
    method25(v13)
    method26(v13)
    method27(v13)
    let v417 : string = $"{v0}"
    method11(v13, v417)
    method28(v13)
    method29(v13)
    method27(v13)
    method11(v13, v1)
    method30(v13)
    let v1161 : string = v13.l0
    v1161
and method33 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US13 =
            if v3 then
                US13_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US13_0('\t')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US13_0('\r')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US13_0('\n')
                        else
                            let v14 : int64 = v11 - 1L
                            US13_1
        let v23 : char =
            match v19 with
            | US13_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US13_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method33(v0, v25)
and method32 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = v0.[int v2]
        let v5 : int64 = 0L
        let v6 : bool = method33(v4, v5)
        if v6 then
            let v7 : int32 = v2 + 1
            method32(v0, v1, v7)
        else
            v2
and method35 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US13 =
            if v3 then
                US13_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US13_0('/')
                else
                    let v8 : int64 = v5 - 1L
                    US13_1
        let v15 : char =
            match v11 with
            | US13_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US13_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method35(v0, v17)
and method34 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        0
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
        let v5 : int64 = 0L
        let v6 : bool = method35(v4, v5)
        if v6 then
            method34(v0, v3)
        else
            v3
and method31 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method32(v0, v1, v2)
    let v716 : string = v0.[int v3..int v1]
    let v729 : int32 = v716.Length
    let v730 : int32 = method34(v716, v729)
    let v1443 : string = v716.[int 0..int v730]
    v1443
and method22 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method23(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice_contract.contribute_seed"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : string = method24(v8, v9)
    let v108 : string = v93 + v105 
    method31(v108)
and closure17 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure19 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure18 () (v0 : string) : unit =
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure19(v0)
    let v33 : unit = (fun () -> v32 (); v31) ()
    ()
and method36 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure9 (v0 : int32, v1 : Vec<uint8>) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure10()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut0, v114 : Mut1, v115 : Mut2, v116 : Mut3, v117 : Mut4, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US4 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v710 : US12 =
        if v166 then
            US12_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut0, v279 : Mut1, v280 : Mut2, v281 : Mut3, v282 : Mut4, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method16(v278, v279, v280, v281, v282, v283)
            let v326 : string = method20()
            let v329 : string = $"%A{v1}"
            let v341 : string = method22(v278, v279, v280, v281, v282, v283, v325, v326, v0, v329)
            let v402 : unit = ()
            let v403 : unit = (fun () -> v63 (); v402) ()
            let struct (v452 : Mut0, v453 : Mut1, v454 : Mut2, v455 : Mut3, v456 : Mut4, v457 : int64 option) = TraceState.trace_state.Value
            let v503 : unit = ()
            let v504 : (unit -> unit) = closure17(v452)
            let v505 : unit = (fun () -> v504 (); v503) ()
            let v513 : (string -> unit) = closure18()
            (* run_target_args'
            let v514 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v515 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v341 v515 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v516 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v341 v516 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v517 : string = v455.l0
            let v518 : bool = v517 = ""
            let v554 : string =
                if v518 then
                    v341
                else
                    let v519 : bool = v341 = ""
                    if v519 then
                        let v520 : string = v455.l0
                        v520
                    else
                        let v521 : string = v455.l0
                        let v526 : string = "\n"
                        let v527 : string = v521 + v526 
                        let v541 : string = v527 + v341 
                        v541
            (* run_target_args'
            let v583 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v584 : string = "&*$0"
            let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v554 v584 
            let _run_target_args'_v583 = v585 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v586 : string = "&*$0"
            let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v554 v586 
            let _run_target_args'_v583 = v587 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v588 : string = "&*$0"
            let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v554 v588 
            let _run_target_args'_v583 = v589 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v592 : Ref<Str> = v554 |> unbox<Ref<Str>>
            let _run_target_args'_v583 = v592 
            #endif
#if FABLE_COMPILER_PYTHON
            let v606 : Ref<Str> = v554 |> unbox<Ref<Str>>
            let _run_target_args'_v583 = v606 
            #endif
#else
            let v620 : Ref<Str> = v554 |> unbox<Ref<Str>>
            let _run_target_args'_v583 = v620 
            #endif
            let v632 : Ref<Str> = _run_target_args'_v583 
            let v661 : string = $"$0.chars()"
            let v662 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v632 v661 
            let v663 : string = "$0"
            let v664 : _ = Fable.Core.RustInterop.emitRustExpr v662 v663 
            let v665 : string = "$0.collect::<Vec<_>>()"
            let v666 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v668 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v666 v667 
            let v669 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v670 : bool = Fable.Core.RustInterop.emitRustExpr v668 v669 
            let v671 : string = "x"
            let v672 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v671 
            let v673 : string = "String::from_iter($0)"
            let v674 : std_string_String = Fable.Core.RustInterop.emitRustExpr v672 v673 
            let v675 : string = "true; $0 }).collect::<Vec<_>>()"
            let v676 : bool = Fable.Core.RustInterop.emitRustExpr v674 v675 
            let v677 : string = "_vec_map"
            let v678 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v677 
            let v679 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v680 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v678 v679 
            let v681 : int32 = v680.Length
            let v686 : string = ""
            let v687 : bool = v341 <> v686 
            let v700 : bool =
                if v687 then
                    let v699 : bool = v681 <= 1
                    v699
                else
                    false
            if v700 then
                v455.l0 <- v554
                ()
            else
                v455.l0 <- v686
                let v701 : Mut5 = {l0 = 0} : Mut5
                while method36(v681, v701) do
                    let v703 : int32 = v701.l0
                    let v704 : std_string_String = v680.[int v703]
                    let v705 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v706 : bool = Fable.Core.RustInterop.emitRustExpr v704 v705 
                    let v707 : int32 = v703 + 1
                    v701.l0 <- v707
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v513 v341
            #endif
#if FABLE_COMPILER_PYTHON
            v513 v341
            #endif
#else
            v513 v341
            #endif
            // run_target_args' is_unit
            let v708 : (string -> unit) = v453.l0
            v708 v341
            US12_0(v452, v453, v454, v455, v456, v457)
    let v751 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v751 
    ()
and closure20 () () : unit =
    ()
and method37 () : (unit -> unit) =
    closure20()
and closure21 (v0 : (unit -> unit)) () : unit =
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure10()
    let v63 : unit = (fun () -> v62 (); v61) ()
    let struct (v112 : Mut0, v113 : Mut1, v114 : Mut2, v115 : Mut3, v116 : Mut4, v117 : int64 option) = TraceState.trace_state.Value
    let v159 : US4 = v116.l0
    let v160 : bool = v114.l0
    let v161 : bool = v160 = false
    let v164 : bool =
        if v161 then
            false
        else
            let v162 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v159
            let v163 : bool = 1 >= v162
            v163
    let v165 : bool = v164 = false
    let v692 : US12 =
        if v165 then
            US12_1
        else
            let v227 : unit = ()
            let v228 : unit = (fun () -> v62 (); v227) ()
            let struct (v277 : Mut0, v278 : Mut1, v279 : Mut2, v280 : Mut3, v281 : Mut4, v282 : int64 option) = TraceState.trace_state.Value
            let v324 : string = method16(v277, v278, v279, v280, v281, v282)
            let v325 : string = method20()
            let v386 : unit = ()
            let v387 : unit = (fun () -> v62 (); v386) ()
            let struct (v436 : Mut0, v437 : Mut1, v438 : Mut2, v439 : Mut3, v440 : Mut4, v441 : int64 option) = TraceState.trace_state.Value
            let v487 : unit = ()
            let v488 : (unit -> unit) = closure17(v436)
            let v489 : unit = (fun () -> v488 (); v487) ()
            let v497 : string = ""
            let v498 : (string -> unit) = closure18()
            (* run_target_args'
            let v499 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v500 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v497 v500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v497 v501 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v502 : string = v439.l0
            let v503 : bool = v502 = ""
            let v539 : string =
                if v503 then
                    v497
                else
                    let v504 : bool = v497 = ""
                    if v504 then
                        let v505 : string = v439.l0
                        v505
                    else
                        let v506 : string = v439.l0
                        let v511 : string = "\n"
                        let v512 : string = v506 + v511 
                        let v526 : string = v512 + v497 
                        v526
            (* run_target_args'
            let v568 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v569 : string = "&*$0"
            let v570 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v569 
            let _run_target_args'_v568 = v570 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v571 : string = "&*$0"
            let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v571 
            let _run_target_args'_v568 = v572 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v573 : string = "&*$0"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v573 
            let _run_target_args'_v568 = v574 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v577 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v591 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v591 
            #endif
#else
            let v605 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v605 
            #endif
            let v617 : Ref<Str> = _run_target_args'_v568 
            let v646 : string = $"$0.chars()"
            let v647 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v617 v646 
            let v648 : string = "$0"
            let v649 : _ = Fable.Core.RustInterop.emitRustExpr v647 v648 
            let v650 : string = "$0.collect::<Vec<_>>()"
            let v651 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v653 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v651 v652 
            let v654 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v655 : bool = Fable.Core.RustInterop.emitRustExpr v653 v654 
            let v656 : string = "x"
            let v657 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v656 
            let v658 : string = "String::from_iter($0)"
            let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr v657 v658 
            let v660 : string = "true; $0 }).collect::<Vec<_>>()"
            let v661 : bool = Fable.Core.RustInterop.emitRustExpr v659 v660 
            let v662 : string = "_vec_map"
            let v663 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v662 
            let v664 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v665 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v663 v664 
            let v666 : int32 = v665.Length
            let v669 : bool = v497 <> v497 
            let v682 : bool =
                if v669 then
                    let v681 : bool = v666 <= 1
                    v681
                else
                    false
            if v682 then
                v439.l0 <- v539
                ()
            else
                v439.l0 <- v497
                let v683 : Mut5 = {l0 = 0} : Mut5
                while method36(v666, v683) do
                    let v685 : int32 = v683.l0
                    let v686 : std_string_String = v665.[int v685]
                    let v687 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v688 : bool = Fable.Core.RustInterop.emitRustExpr v686 v687 
                    let v689 : int32 = v685 + 1
                    v683.l0 <- v689
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v498 v497
            #endif
#if FABLE_COMPILER_PYTHON
            v498 v497
            #endif
#else
            v498 v497
            #endif
            // run_target_args' is_unit
            let v690 : (string -> unit) = v437.l0
            v690 v497
            US12_0(v436, v437, v438, v439, v440, v441)
    let v733 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v733 
    ()
and closure23 (v0 : uint8) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure22 () (v0 : uint8) : (UH0 -> UH0) =
    closure23(v0)
and method38 () : (uint8 -> (UH0 -> UH0)) =
    closure22()
and closure24 (v0 : UH1) () : UH1 =
    v0
and method39 (v0 : UH0, v1 : UH1) : UH1 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method39(v3, v1)
        let v5 : (unit -> UH1) = closure24(v4)
        UH1_0(v2, v5)
    | UH0_0 -> (* Nil *)
        v1
and closure25 (v0 : UH1) () : UH1 =
    v0
and method40 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH1 = method40(v4, v1)
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
and method41 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : UH1 = v3 ()
        let v5 : UH0 = method41(v4, v1)
        UH0_1(v2, v5)
    | UH1_1 -> (* StreamNil *)
        v1
and method42 (v0 : UH0, v1 : uint8 list) : uint8 list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : uint8 list = method42(v3, v1)
        let v7 : uint8 list = v2 :: v4 
        v7
    | UH0_0 -> (* Nil *)
        v1
and method45 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "max"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method46 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "key"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method47 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "proof"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method48 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "block_timestamp"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method49 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "block_height"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method50 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "epoch_height"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method51 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "account_balance"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method52 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "signer_account_id"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method53 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "predecessor_account_id"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method54 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "seed"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method55 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "seeds"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method56 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "entropy_len"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method57 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "entropy"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method58 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "hash_u8"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method59 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "rolls"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method44 (v0 : uint64, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : uint64, v5 : uint64, v6 : string, v7 : std_string_String, v8 : std_string_String, v9 : string, v10 : string, v11 : unativeint, v12 : string, v13 : string, v14 : string) : string =
    let v15 : string = method10()
    let v26 : Mut3 = {l0 = v15} : Mut3
    method25(v26)
    method45(v26)
    method27(v26)
    let v430 : string = $"{v0}"
    method11(v26, v430)
    method28(v26)
    method46(v26)
    method27(v26)
    (* run_target_args'
    let v956 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v957 : string = "format!(\"{:#?}\", $0)"
    let v958 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v957 
    let v959 : string = "fable_library_rust::String_::fromString($0)"
    let v960 : string = Fable.Core.RustInterop.emitRustExpr v958 v959 
    let _run_target_args'_v956 = v960 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v961 : string = "format!(\"{:#?}\", $0)"
    let v962 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v961 
    let v963 : string = "fable_library_rust::String_::fromString($0)"
    let v964 : string = Fable.Core.RustInterop.emitRustExpr v962 v963 
    let _run_target_args'_v956 = v964 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v965 : string = "format!(\"{:#?}\", $0)"
    let v966 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v965 
    let v967 : string = "fable_library_rust::String_::fromString($0)"
    let v968 : string = Fable.Core.RustInterop.emitRustExpr v966 v967 
    let _run_target_args'_v956 = v968 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v971 : string = $"%A{v1}"
    let _run_target_args'_v956 = v971 
    #endif
#if FABLE_COMPILER_PYTHON
    let v985 : string = $"%A{v1}"
    let _run_target_args'_v956 = v985 
    #endif
#else
    let v999 : string = $"%A{v1}"
    let _run_target_args'_v956 = v999 
    #endif
    let v1011 : string = _run_target_args'_v956 
    method11(v26, v1011)
    method28(v26)
    method47(v26)
    method27(v26)
    (* run_target_args'
    let v1564 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1565 : string = "format!(\"{:#?}\", $0)"
    let v1566 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v1565 
    let v1567 : string = "fable_library_rust::String_::fromString($0)"
    let v1568 : string = Fable.Core.RustInterop.emitRustExpr v1566 v1567 
    let _run_target_args'_v1564 = v1568 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1569 : string = "format!(\"{:#?}\", $0)"
    let v1570 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v1569 
    let v1571 : string = "fable_library_rust::String_::fromString($0)"
    let v1572 : string = Fable.Core.RustInterop.emitRustExpr v1570 v1571 
    let _run_target_args'_v1564 = v1572 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1573 : string = "format!(\"{:#?}\", $0)"
    let v1574 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v1573 
    let v1575 : string = "fable_library_rust::String_::fromString($0)"
    let v1576 : string = Fable.Core.RustInterop.emitRustExpr v1574 v1575 
    let _run_target_args'_v1564 = v1576 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1579 : string = $"%A{v2}"
    let _run_target_args'_v1564 = v1579 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1593 : string = $"%A{v2}"
    let _run_target_args'_v1564 = v1593 
    #endif
#else
    let v1607 : string = $"%A{v2}"
    let _run_target_args'_v1564 = v1607 
    #endif
    let v1619 : string = _run_target_args'_v1564 
    method11(v26, v1619)
    method28(v26)
    method48(v26)
    method27(v26)
    let v2172 : string = $"{v3}"
    method11(v26, v2172)
    method28(v26)
    method49(v26)
    method27(v26)
    let v2698 : string = $"{v4}"
    method11(v26, v2698)
    method28(v26)
    method50(v26)
    method27(v26)
    let v3224 : string = $"{v5}"
    method11(v26, v3224)
    method28(v26)
    method51(v26)
    method27(v26)
    method11(v26, v6)
    method28(v26)
    method52(v26)
    method27(v26)
    (* run_target_args'
    let v4246 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4247 : string = "format!(\"{:#?}\", $0)"
    let v4248 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v4247 
    let v4249 : string = "fable_library_rust::String_::fromString($0)"
    let v4250 : string = Fable.Core.RustInterop.emitRustExpr v4248 v4249 
    let _run_target_args'_v4246 = v4250 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4251 : string = "format!(\"{:#?}\", $0)"
    let v4252 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v4251 
    let v4253 : string = "fable_library_rust::String_::fromString($0)"
    let v4254 : string = Fable.Core.RustInterop.emitRustExpr v4252 v4253 
    let _run_target_args'_v4246 = v4254 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4255 : string = "format!(\"{:#?}\", $0)"
    let v4256 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v4255 
    let v4257 : string = "fable_library_rust::String_::fromString($0)"
    let v4258 : string = Fable.Core.RustInterop.emitRustExpr v4256 v4257 
    let _run_target_args'_v4246 = v4258 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4261 : string = $"%A{v7}"
    let _run_target_args'_v4246 = v4261 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4275 : string = $"%A{v7}"
    let _run_target_args'_v4246 = v4275 
    #endif
#else
    let v4289 : string = $"%A{v7}"
    let _run_target_args'_v4246 = v4289 
    #endif
    let v4301 : string = _run_target_args'_v4246 
    method11(v26, v4301)
    method28(v26)
    method53(v26)
    method27(v26)
    (* run_target_args'
    let v4854 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4855 : string = "format!(\"{:#?}\", $0)"
    let v4856 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v4855 
    let v4857 : string = "fable_library_rust::String_::fromString($0)"
    let v4858 : string = Fable.Core.RustInterop.emitRustExpr v4856 v4857 
    let _run_target_args'_v4854 = v4858 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4859 : string = "format!(\"{:#?}\", $0)"
    let v4860 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v4859 
    let v4861 : string = "fable_library_rust::String_::fromString($0)"
    let v4862 : string = Fable.Core.RustInterop.emitRustExpr v4860 v4861 
    let _run_target_args'_v4854 = v4862 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4863 : string = "format!(\"{:#?}\", $0)"
    let v4864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v4863 
    let v4865 : string = "fable_library_rust::String_::fromString($0)"
    let v4866 : string = Fable.Core.RustInterop.emitRustExpr v4864 v4865 
    let _run_target_args'_v4854 = v4866 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4869 : string = $"%A{v8}"
    let _run_target_args'_v4854 = v4869 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4883 : string = $"%A{v8}"
    let _run_target_args'_v4854 = v4883 
    #endif
#else
    let v4897 : string = $"%A{v8}"
    let _run_target_args'_v4854 = v4897 
    #endif
    let v4909 : string = _run_target_args'_v4854 
    method11(v26, v4909)
    method28(v26)
    method54(v26)
    method27(v26)
    method11(v26, v9)
    method28(v26)
    method55(v26)
    method27(v26)
    method11(v26, v10)
    method28(v26)
    method56(v26)
    method27(v26)
    (* run_target_args'
    let v6454 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6455 : string = "format!(\"{:#?}\", $0)"
    let v6456 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v6455 
    let v6457 : string = "fable_library_rust::String_::fromString($0)"
    let v6458 : string = Fable.Core.RustInterop.emitRustExpr v6456 v6457 
    let _run_target_args'_v6454 = v6458 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6459 : string = "format!(\"{:#?}\", $0)"
    let v6460 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v6459 
    let v6461 : string = "fable_library_rust::String_::fromString($0)"
    let v6462 : string = Fable.Core.RustInterop.emitRustExpr v6460 v6461 
    let _run_target_args'_v6454 = v6462 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6463 : string = "format!(\"{:#?}\", $0)"
    let v6464 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v6463 
    let v6465 : string = "fable_library_rust::String_::fromString($0)"
    let v6466 : string = Fable.Core.RustInterop.emitRustExpr v6464 v6465 
    let _run_target_args'_v6454 = v6466 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6469 : string = $"%A{v11}"
    let _run_target_args'_v6454 = v6469 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6483 : string = $"%A{v11}"
    let _run_target_args'_v6454 = v6483 
    #endif
#else
    let v6497 : string = $"%A{v11}"
    let _run_target_args'_v6454 = v6497 
    #endif
    let v6509 : string = _run_target_args'_v6454 
    method11(v26, v6509)
    method28(v26)
    method57(v26)
    method27(v26)
    method11(v26, v12)
    method28(v26)
    method58(v26)
    method27(v26)
    method11(v26, v13)
    method28(v26)
    method59(v26)
    method27(v26)
    method11(v26, v14)
    method30(v26)
    let v8272 : string = v26.l0
    v8272
and method43 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : std_string_String, v10 : std_string_String, v11 : uint64, v12 : uint64, v13 : uint64, v14 : string, v15 : std_string_String, v16 : std_string_String, v17 : string, v18 : string, v19 : unativeint, v20 : string, v21 : string, v22 : string) : string =
    let v23 : int64 = v0.l0
    let v28 : string = " "
    let v29 : string = v6 + v28 
    let v41 : string = method23(v23)
    let v44 : string = v29 + v41 
    let v58 : string = v44 + v7 
    let v72 : string = v58 + v28 
    let v88 : string = "dice_contract.generate_random_number"
    let v89 : string = v72 + v88 
    let v105 : string = " / "
    let v106 : string = v89 + v105 
    let v118 : string = method44(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22)
    let v121 : string = v106 + v118 
    method31(v121)
and closure26 (v0 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>>, v1 : std_string_String, v2 : std_string_String, v3 : uint64, v4 : Vec<uint8>, v5 : uint64, v6 : uint64, v7 : uint64, v8 : near_token_NearToken, v9 : near_sdk_AccountId, v10 : near_sdk_AccountId, v11 : Vec<uint8>, v12 : Vec<uint8>, v13 : UH0) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure10()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v125 : Mut0, v126 : Mut1, v127 : Mut2, v128 : Mut3, v129 : Mut4, v130 : int64 option) = TraceState.trace_state.Value
    let v172 : US4 = v129.l0
    let v173 : bool = v127.l0
    let v174 : bool = v173 = false
    let v177 : bool =
        if v174 then
            false
        else
            let v175 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v172
            let v176 : bool = 1 >= v175
            v176
    let v178 : bool = v177 = false
    let v837 : US12 =
        if v178 then
            US12_1
        else
            let v240 : unit = ()
            let v241 : unit = (fun () -> v75 (); v240) ()
            let struct (v290 : Mut0, v291 : Mut1, v292 : Mut2, v293 : Mut3, v294 : Mut4, v295 : int64 option) = TraceState.trace_state.Value
            let v337 : string = method16(v290, v291, v292, v293, v294, v295)
            let v338 : string = method20()
            let v341 : string = $"%A{v8}"
            let v353 : string = $"v9.to_string()"
            let v354 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v353 
            let v355 : string = $"v10.to_string()"
            let v356 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v355 
            let v359 : string = $"%A{v4}"
            let v373 : string = $"%A{v0}"
            let v385 : string = "$0.len()"
            let v386 : unativeint = Fable.Core.RustInterop.emitRustExpr v11 v385 
            let v389 : string = $"%A{v11}"
            let v403 : string = $"%A{v12}"
            let v415 : uint8 list = []
            let v416 : uint8 list = method42(v13, v415)
            let v439 : (uint8 list -> (uint8 [])) = List.toArray
            let v440 : (uint8 []) = v439 v416
            let v452 : string = "$0.to_vec()"
            let v453 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v440 v452 
            let v456 : string = $"%A{v453}"
            let v468 : string = method43(v290, v291, v292, v293, v294, v295, v337, v338, v3, v1, v2, v7, v6, v5, v341, v354, v356, v359, v373, v386, v389, v403, v456)
            let v529 : unit = ()
            let v530 : unit = (fun () -> v75 (); v529) ()
            let struct (v579 : Mut0, v580 : Mut1, v581 : Mut2, v582 : Mut3, v583 : Mut4, v584 : int64 option) = TraceState.trace_state.Value
            let v630 : unit = ()
            let v631 : (unit -> unit) = closure17(v579)
            let v632 : unit = (fun () -> v631 (); v630) ()
            let v640 : (string -> unit) = closure18()
            (* run_target_args'
            let v641 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v642 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v468 v642 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v643 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v468 v643 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v644 : string = v582.l0
            let v645 : bool = v644 = ""
            let v681 : string =
                if v645 then
                    v468
                else
                    let v646 : bool = v468 = ""
                    if v646 then
                        let v647 : string = v582.l0
                        v647
                    else
                        let v648 : string = v582.l0
                        let v653 : string = "\n"
                        let v654 : string = v648 + v653 
                        let v668 : string = v654 + v468 
                        v668
            (* run_target_args'
            let v710 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v711 : string = "&*$0"
            let v712 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v681 v711 
            let _run_target_args'_v710 = v712 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v713 : string = "&*$0"
            let v714 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v681 v713 
            let _run_target_args'_v710 = v714 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v681 v715 
            let _run_target_args'_v710 = v716 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v719 : Ref<Str> = v681 |> unbox<Ref<Str>>
            let _run_target_args'_v710 = v719 
            #endif
#if FABLE_COMPILER_PYTHON
            let v733 : Ref<Str> = v681 |> unbox<Ref<Str>>
            let _run_target_args'_v710 = v733 
            #endif
#else
            let v747 : Ref<Str> = v681 |> unbox<Ref<Str>>
            let _run_target_args'_v710 = v747 
            #endif
            let v759 : Ref<Str> = _run_target_args'_v710 
            let v788 : string = $"$0.chars()"
            let v789 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v759 v788 
            let v790 : string = "$0"
            let v791 : _ = Fable.Core.RustInterop.emitRustExpr v789 v790 
            let v792 : string = "$0.collect::<Vec<_>>()"
            let v793 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v791 v792 
            let v794 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v795 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v793 v794 
            let v796 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v797 : bool = Fable.Core.RustInterop.emitRustExpr v795 v796 
            let v798 : string = "x"
            let v799 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v798 
            let v800 : string = "String::from_iter($0)"
            let v801 : std_string_String = Fable.Core.RustInterop.emitRustExpr v799 v800 
            let v802 : string = "true; $0 }).collect::<Vec<_>>()"
            let v803 : bool = Fable.Core.RustInterop.emitRustExpr v801 v802 
            let v804 : string = "_vec_map"
            let v805 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v804 
            let v806 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v807 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v805 v806 
            let v808 : int32 = v807.Length
            let v813 : string = ""
            let v814 : bool = v468 <> v813 
            let v827 : bool =
                if v814 then
                    let v826 : bool = v808 <= 1
                    v826
                else
                    false
            if v827 then
                v582.l0 <- v681
                ()
            else
                v582.l0 <- v813
                let v828 : Mut5 = {l0 = 0} : Mut5
                while method36(v808, v828) do
                    let v830 : int32 = v828.l0
                    let v831 : std_string_String = v807.[int v830]
                    let v832 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v833 : bool = Fable.Core.RustInterop.emitRustExpr v831 v832 
                    let v834 : int32 = v830 + 1
                    v828.l0 <- v834
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v640 v468
            #endif
#if FABLE_COMPILER_PYTHON
            v640 v468
            #endif
#else
            v640 v468
            #endif
            // run_target_args' is_unit
            let v835 : (string -> unit) = v580.l0
            v835 v468
            US12_0(v579, v580, v581, v582, v583, v584)
    let v878 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v878 
    ()
and method60 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method60(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method61 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method61(v3, v1)
        UH0_1(v2, v4)
    | UH0_0 -> (* Nil *)
        v1
and closure27 (v0 : UH1) () : UH1 =
    v0
and closure28 (v0 : UH1, v1 : Mut6) () : UH1 =
    let v2 : US14 = v1.l0
    match v2 with
    | US14_1(v3) -> (* Computed *)
        v3
    | US14_0(v4) -> (* NotComputed *)
        let v5 : UH1 = v4 ()
        let v12 : UH1 =
            match v5 with
            | UH1_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH1) = method62(v0, v8)
                UH1_0(v7, v9)
            | UH1_1 -> (* StreamNil *)
                UH1_1
        let v13 : US14 = US14_1(v12)
        v1.l0 <- v13
        v12
and method62 (v0 : UH1, v1 : (unit -> UH1)) : (unit -> UH1) =
    let v2 : US14 = US14_0(v1)
    let v3 : Mut6 = {l0 = v2} : Mut6
    closure28(v0, v3)
and method66 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "p"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method67 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "n"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method65 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method10()
    let v14 : Mut3 = {l0 = v3} : Mut3
    method25(v14)
    method45(v14)
    method27(v14)
    let v418 : string = $"{v0}"
    method11(v14, v418)
    method28(v14)
    method66(v14)
    method27(v14)
    let v944 : string = $"{v1}"
    method11(v14, v944)
    method28(v14)
    method67(v14)
    method27(v14)
    let v1470 : string = $"{v2}"
    method11(v14, v1470)
    method30(v14)
    let v1718 : string = v14.l0
    v1718
and method64 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method23(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.calculate_dice_count"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method65(v8, v9, v10)
    let v109 : string = v94 + v106 
    method31(v109)
and closure29 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure10()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut0, v115 : Mut1, v116 : Mut2, v117 : Mut3, v118 : Mut4, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US4 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US12 =
        if v167 then
            US12_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut0, v280 : Mut1, v281 : Mut2, v282 : Mut3, v283 : Mut4, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method16(v279, v280, v281, v282, v283, v284)
            let v327 : string = method20()
            let v328 : string = method64(v279, v280, v281, v282, v283, v284, v326, v327, v0, v2, v1)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut0, v440 : Mut1, v441 : Mut2, v442 : Mut3, v443 : Mut4, v444 : int64 option) = TraceState.trace_state.Value
            let v490 : unit = ()
            let v491 : (unit -> unit) = closure17(v439)
            let v492 : unit = (fun () -> v491 (); v490) ()
            let v500 : (string -> unit) = closure18()
            (* run_target_args'
            let v501 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v328 v502 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v503 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v328 v503 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v504 : string = v442.l0
            let v505 : bool = v504 = ""
            let v541 : string =
                if v505 then
                    v328
                else
                    let v506 : bool = v328 = ""
                    if v506 then
                        let v507 : string = v442.l0
                        v507
                    else
                        let v508 : string = v442.l0
                        let v513 : string = "\n"
                        let v514 : string = v508 + v513 
                        let v528 : string = v514 + v328 
                        v528
            (* run_target_args'
            let v570 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v571 : string = "&*$0"
            let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v571 
            let _run_target_args'_v570 = v572 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v573 : string = "&*$0"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v573 
            let _run_target_args'_v570 = v574 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v575 : string = "&*$0"
            let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v575 
            let _run_target_args'_v570 = v576 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v579 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v579 
            #endif
#if FABLE_COMPILER_PYTHON
            let v593 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v593 
            #endif
#else
            let v607 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v607 
            #endif
            let v619 : Ref<Str> = _run_target_args'_v570 
            let v648 : string = $"$0.chars()"
            let v649 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v619 v648 
            let v650 : string = "$0"
            let v651 : _ = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "$0.collect::<Vec<_>>()"
            let v653 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v651 v652 
            let v654 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v655 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v653 v654 
            let v656 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v657 : bool = Fable.Core.RustInterop.emitRustExpr v655 v656 
            let v658 : string = "x"
            let v659 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v658 
            let v660 : string = "String::from_iter($0)"
            let v661 : std_string_String = Fable.Core.RustInterop.emitRustExpr v659 v660 
            let v662 : string = "true; $0 }).collect::<Vec<_>>()"
            let v663 : bool = Fable.Core.RustInterop.emitRustExpr v661 v662 
            let v664 : string = "_vec_map"
            let v665 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v664 
            let v666 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v667 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v665 v666 
            let v668 : int32 = v667.Length
            let v673 : string = ""
            let v674 : bool = v328 <> v673 
            let v687 : bool =
                if v674 then
                    let v686 : bool = v668 <= 1
                    v686
                else
                    false
            if v687 then
                v442.l0 <- v541
                ()
            else
                v442.l0 <- v673
                let v688 : Mut5 = {l0 = 0} : Mut5
                while method36(v668, v688) do
                    let v690 : int32 = v688.l0
                    let v691 : std_string_String = v667.[int v690]
                    let v692 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v693 : bool = Fable.Core.RustInterop.emitRustExpr v691 v692 
                    let v694 : int32 = v690 + 1
                    v688.l0 <- v694
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v500 v328
            #endif
#if FABLE_COMPILER_PYTHON
            v500 v328
            #endif
#else
            v500 v328
            #endif
            // run_target_args' is_unit
            let v695 : (string -> unit) = v440.l0
            v695 v328
            US12_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method63 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method63(v0, v6, v4)
        else
            let v1495 : unit = ()
            let v1496 : (unit -> unit) = closure29(v0, v1, v2)
            let v1497 : unit = (fun () -> v1496 (); v1495) ()
            v1
    else
        let v3736 : unit = ()
        let v3737 : (unit -> unit) = closure29(v0, v1, v2)
        let v3738 : unit = (fun () -> v3737 (); v3736) ()
        v1
and method72 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "current_index"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method73 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "acc"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method74 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "len"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method75 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "last_item"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method71 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method10()
    let v15 : Mut3 = {l0 = v4} : Mut3
    method25(v15)
    method72(v15)
    method27(v15)
    let v419 : string = $"{v0}"
    method11(v15, v419)
    method28(v15)
    method73(v15)
    method27(v15)
    let v945 : string = $"{v1}"
    method11(v15, v945)
    method28(v15)
    method74(v15)
    method27(v15)
    let v1471 : string = $"{v2}"
    method11(v15, v1471)
    method28(v15)
    method75(v15)
    method27(v15)
    method11(v15, v3)
    method30(v15)
    let v2215 : string = v15.l0
    v2215
and method70 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : int64 = v0.l0
    let v17 : string = " "
    let v18 : string = v6 + v17 
    let v30 : string = method23(v12)
    let v33 : string = v18 + v30 
    let v47 : string = v33 + v7 
    let v61 : string = v47 + v17 
    let v77 : string = "dice.create_sequential_roller / roll"
    let v78 : string = v61 + v77 
    let v94 : string = " / "
    let v95 : string = v78 + v94 
    let v107 : string = method71(v8, v9, v10, v11)
    let v110 : string = v95 + v107 
    method31(v110)
and closure30 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure10()
    let v66 : unit = (fun () -> v65 (); v64) ()
    let struct (v115 : Mut0, v116 : Mut1, v117 : Mut2, v118 : Mut3, v119 : Mut4, v120 : int64 option) = TraceState.trace_state.Value
    let v162 : US4 = v119.l0
    let v163 : bool = v117.l0
    let v164 : bool = v163 = false
    let v167 : bool =
        if v164 then
            false
        else
            let v165 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v162
            let v166 : bool = 1 >= v165
            v166
    let v168 : bool = v167 = false
    let v712 : US12 =
        if v168 then
            US12_1
        else
            let v230 : unit = ()
            let v231 : unit = (fun () -> v65 (); v230) ()
            let struct (v280 : Mut0, v281 : Mut1, v282 : Mut2, v283 : Mut3, v284 : Mut4, v285 : int64 option) = TraceState.trace_state.Value
            let v327 : string = method16(v280, v281, v282, v283, v284, v285)
            let v328 : string = method20()
            let v331 : string = $"%A{v3}"
            let v343 : string = method70(v280, v281, v282, v283, v284, v285, v327, v328, v0, v1, v2, v331)
            let v404 : unit = ()
            let v405 : unit = (fun () -> v65 (); v404) ()
            let struct (v454 : Mut0, v455 : Mut1, v456 : Mut2, v457 : Mut3, v458 : Mut4, v459 : int64 option) = TraceState.trace_state.Value
            let v505 : unit = ()
            let v506 : (unit -> unit) = closure17(v454)
            let v507 : unit = (fun () -> v506 (); v505) ()
            let v515 : (string -> unit) = closure18()
            (* run_target_args'
            let v516 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v517 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v343 v517 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v518 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v343 v518 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v519 : string = v457.l0
            let v520 : bool = v519 = ""
            let v556 : string =
                if v520 then
                    v343
                else
                    let v521 : bool = v343 = ""
                    if v521 then
                        let v522 : string = v457.l0
                        v522
                    else
                        let v523 : string = v457.l0
                        let v528 : string = "\n"
                        let v529 : string = v523 + v528 
                        let v543 : string = v529 + v343 
                        v543
            (* run_target_args'
            let v585 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v586 : string = "&*$0"
            let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v556 v586 
            let _run_target_args'_v585 = v587 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v588 : string = "&*$0"
            let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v556 v588 
            let _run_target_args'_v585 = v589 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v590 : string = "&*$0"
            let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v556 v590 
            let _run_target_args'_v585 = v591 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v594 : Ref<Str> = v556 |> unbox<Ref<Str>>
            let _run_target_args'_v585 = v594 
            #endif
#if FABLE_COMPILER_PYTHON
            let v608 : Ref<Str> = v556 |> unbox<Ref<Str>>
            let _run_target_args'_v585 = v608 
            #endif
#else
            let v622 : Ref<Str> = v556 |> unbox<Ref<Str>>
            let _run_target_args'_v585 = v622 
            #endif
            let v634 : Ref<Str> = _run_target_args'_v585 
            let v663 : string = $"$0.chars()"
            let v664 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v634 v663 
            let v665 : string = "$0"
            let v666 : _ = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : string = "$0.collect::<Vec<_>>()"
            let v668 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v666 v667 
            let v669 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v670 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v668 v669 
            let v671 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v672 : bool = Fable.Core.RustInterop.emitRustExpr v670 v671 
            let v673 : string = "x"
            let v674 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v673 
            let v675 : string = "String::from_iter($0)"
            let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v674 v675 
            let v677 : string = "true; $0 }).collect::<Vec<_>>()"
            let v678 : bool = Fable.Core.RustInterop.emitRustExpr v676 v677 
            let v679 : string = "_vec_map"
            let v680 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v679 
            let v681 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v682 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v680 v681 
            let v683 : int32 = v682.Length
            let v688 : string = ""
            let v689 : bool = v343 <> v688 
            let v702 : bool =
                if v689 then
                    let v701 : bool = v683 <= 1
                    v701
                else
                    false
            if v702 then
                v457.l0 <- v556
                ()
            else
                v457.l0 <- v688
                let v703 : Mut5 = {l0 = 0} : Mut5
                while method36(v683, v703) do
                    let v705 : int32 = v703.l0
                    let v706 : std_string_String = v682.[int v705]
                    let v707 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v708 : bool = Fable.Core.RustInterop.emitRustExpr v706 v707 
                    let v709 : int32 = v705 + 1
                    v703.l0 <- v709
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v515 v343
            #endif
#if FABLE_COMPILER_PYTHON
            v515 v343
            #endif
#else
            v515 v343
            #endif
            // run_target_args' is_unit
            let v710 : (string -> unit) = v455.l0
            v710 v343
            US12_0(v454, v455, v456, v457, v458, v459)
    let v753 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v753 
    ()
and method76 (v0 : int64, v1 : UH1) : US15 =
    match v1 with
    | UH1_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US15_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH1 = v3 ()
            method76(v6, v7)
    | UH1_1 -> (* StreamNil *)
        US15_1
and method78 () : string =
    let v0 : string = method10()
    let v11 : Mut3 = {l0 = v0} : Mut3
    let v12 : string = v11.l0
    v12
and method77 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v26 : string = method23(v8)
    let v29 : string = v14 + v26 
    let v43 : string = v29 + v7 
    let v57 : string = v43 + v13 
    let v73 : string = "dice.create_sequential_roller / roll / None"
    let v74 : string = v57 + v73 
    let v90 : string = " / "
    let v91 : string = v74 + v90 
    let v103 : string = method78()
    let v106 : string = v91 + v103 
    method31(v106)
and closure31 () () : unit =
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure10()
    let v62 : unit = (fun () -> v61 (); v60) ()
    let struct (v111 : Mut0, v112 : Mut1, v113 : Mut2, v114 : Mut3, v115 : Mut4, v116 : int64 option) = TraceState.trace_state.Value
    let v158 : US4 = v115.l0
    let v159 : bool = v113.l0
    let v160 : bool = v159 = false
    let v163 : bool =
        if v160 then
            false
        else
            let v161 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v158
            let v162 : bool = 1 >= v161
            v162
    let v164 : bool = v163 = false
    let v694 : US12 =
        if v164 then
            US12_1
        else
            let v226 : unit = ()
            let v227 : unit = (fun () -> v61 (); v226) ()
            let struct (v276 : Mut0, v277 : Mut1, v278 : Mut2, v279 : Mut3, v280 : Mut4, v281 : int64 option) = TraceState.trace_state.Value
            let v323 : string = method16(v276, v277, v278, v279, v280, v281)
            let v324 : string = method20()
            let v325 : string = method77(v276, v277, v278, v279, v280, v281, v323, v324)
            let v386 : unit = ()
            let v387 : unit = (fun () -> v61 (); v386) ()
            let struct (v436 : Mut0, v437 : Mut1, v438 : Mut2, v439 : Mut3, v440 : Mut4, v441 : int64 option) = TraceState.trace_state.Value
            let v487 : unit = ()
            let v488 : (unit -> unit) = closure17(v436)
            let v489 : unit = (fun () -> v488 (); v487) ()
            let v497 : (string -> unit) = closure18()
            (* run_target_args'
            let v498 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v499 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v325 v499 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v500 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v325 v500 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v501 : string = v439.l0
            let v502 : bool = v501 = ""
            let v538 : string =
                if v502 then
                    v325
                else
                    let v503 : bool = v325 = ""
                    if v503 then
                        let v504 : string = v439.l0
                        v504
                    else
                        let v505 : string = v439.l0
                        let v510 : string = "\n"
                        let v511 : string = v505 + v510 
                        let v525 : string = v511 + v325 
                        v525
            (* run_target_args'
            let v567 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v568 : string = "&*$0"
            let v569 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v538 v568 
            let _run_target_args'_v567 = v569 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v538 v570 
            let _run_target_args'_v567 = v571 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v538 v572 
            let _run_target_args'_v567 = v573 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v576 : Ref<Str> = v538 |> unbox<Ref<Str>>
            let _run_target_args'_v567 = v576 
            #endif
#if FABLE_COMPILER_PYTHON
            let v590 : Ref<Str> = v538 |> unbox<Ref<Str>>
            let _run_target_args'_v567 = v590 
            #endif
#else
            let v604 : Ref<Str> = v538 |> unbox<Ref<Str>>
            let _run_target_args'_v567 = v604 
            #endif
            let v616 : Ref<Str> = _run_target_args'_v567 
            let v645 : string = $"$0.chars()"
            let v646 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v616 v645 
            let v647 : string = "$0"
            let v648 : _ = Fable.Core.RustInterop.emitRustExpr v646 v647 
            let v649 : string = "$0.collect::<Vec<_>>()"
            let v650 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v652 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v654 : bool = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "x"
            let v656 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v655 
            let v657 : string = "String::from_iter($0)"
            let v658 : std_string_String = Fable.Core.RustInterop.emitRustExpr v656 v657 
            let v659 : string = "true; $0 }).collect::<Vec<_>>()"
            let v660 : bool = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "_vec_map"
            let v662 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v661 
            let v663 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v664 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v662 v663 
            let v665 : int32 = v664.Length
            let v670 : string = ""
            let v671 : bool = v325 <> v670 
            let v684 : bool =
                if v671 then
                    let v683 : bool = v665 <= 1
                    v683
                else
                    false
            if v684 then
                v439.l0 <- v538
                ()
            else
                v439.l0 <- v670
                let v685 : Mut5 = {l0 = 0} : Mut5
                while method36(v665, v685) do
                    let v687 : int32 = v685.l0
                    let v688 : std_string_String = v664.[int v687]
                    let v689 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v690 : bool = Fable.Core.RustInterop.emitRustExpr v688 v689 
                    let v691 : int32 = v687 + 1
                    v685.l0 <- v691
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v497 v325
            #endif
#if FABLE_COMPILER_PYTHON
            v497 v325
            #endif
#else
            v497 v325
            #endif
            // run_target_args' is_unit
            let v692 : (string -> unit) = v437.l0
            v692 v325
            US12_0(v436, v437, v438, v439, v440, v441)
    let v735 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v735 
    ()
and method69 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut7) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US15 = v4.l0
    let v39 : uint8 option =
        match v8 with
        | US15_1 -> (* None *)
            let v26 : uint8 option = None
            v26
        | US15_0(v9) -> (* Some *)
            let v12 : uint8 option = Some v9 
            v12
    let v1555 : unit = ()
    let v1556 : (unit -> unit) = closure30(v5, v6, v7, v39)
    let v1557 : unit = (fun () -> v1556 (); v1555) ()
    let v2322 : UH1 = v0 ()
    let v2323 : int64 = v1.l0
    let v2324 : US15 = method76(v2323, v2322)
    match v2324 with
    | US15_1 -> (* None *)
        let v3816 : unit = ()
        let v3817 : (unit -> unit) = closure31()
        let v3818 : unit = (fun () -> v3817 (); v3816) ()
        let v4569 : int64 = v3.l0
        let v4570 : bool = v4569 = -1L
        if v4570 then
            let v4571 : int64 = v1.l0
            v3.l0 <- v4571
            ()
        let v4572 : int64 = v2.l0
        let v4573 : int64 = v3.l0
        let v4574 : bool = v4572 >= v4573
        let v4577 : int64 =
            if v4574 then
                1L
            else
                let v4575 : int64 = v2.l0
                let v4576 : int64 = v4575 + 1L
                v4576
        v2.l0 <- v4577
        let v4578 : int64 = v2.l0
        let v4579 : int64 = v4578 - 1L
        v1.l0 <- v4579
        let v4580 : US15 = US15_1
        v4.l0 <- v4580
        method69(v0, v1, v2, v3, v4)
    | US15_0(v2325) -> (* Some *)
        let v2326 : int64 = v1.l0
        let v2327 : int64 = v2326 + 1L
        v1.l0 <- v2327
        let v2328 : US15 = US15_0(v2325)
        v4.l0 <- v2328
        v2325
and method82 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "power"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method83 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "result"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method81 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method10()
    let v14 : Mut3 = {l0 = v3} : Mut3
    method25(v14)
    method82(v14)
    method27(v14)
    let v418 : string = $"{v0}"
    method11(v14, v418)
    method28(v14)
    method73(v14)
    method27(v14)
    let v944 : string = $"{v1}"
    method11(v14, v944)
    method28(v14)
    method83(v14)
    method27(v14)
    let v1470 : string = $"{v2}"
    method11(v14, v1470)
    method30(v14)
    let v1718 : string = v14.l0
    v1718
and method80 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method23(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method81(v8, v9, v10)
    let v109 : string = v94 + v106 
    method31(v109)
and closure32 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure10()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut0, v115 : Mut1, v116 : Mut2, v117 : Mut3, v118 : Mut4, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US4 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US12 =
        if v167 then
            US12_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut0, v280 : Mut1, v281 : Mut2, v282 : Mut3, v283 : Mut4, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method16(v279, v280, v281, v282, v283, v284)
            let v327 : string = method20()
            let v328 : string = method80(v279, v280, v281, v282, v283, v284, v326, v327, v1, v0, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut0, v440 : Mut1, v441 : Mut2, v442 : Mut3, v443 : Mut4, v444 : int64 option) = TraceState.trace_state.Value
            let v490 : unit = ()
            let v491 : (unit -> unit) = closure17(v439)
            let v492 : unit = (fun () -> v491 (); v490) ()
            let v500 : (string -> unit) = closure18()
            (* run_target_args'
            let v501 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v328 v502 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v503 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v328 v503 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v504 : string = v442.l0
            let v505 : bool = v504 = ""
            let v541 : string =
                if v505 then
                    v328
                else
                    let v506 : bool = v328 = ""
                    if v506 then
                        let v507 : string = v442.l0
                        v507
                    else
                        let v508 : string = v442.l0
                        let v513 : string = "\n"
                        let v514 : string = v508 + v513 
                        let v528 : string = v514 + v328 
                        v528
            (* run_target_args'
            let v570 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v571 : string = "&*$0"
            let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v571 
            let _run_target_args'_v570 = v572 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v573 : string = "&*$0"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v573 
            let _run_target_args'_v570 = v574 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v575 : string = "&*$0"
            let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v575 
            let _run_target_args'_v570 = v576 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v579 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v579 
            #endif
#if FABLE_COMPILER_PYTHON
            let v593 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v593 
            #endif
#else
            let v607 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v607 
            #endif
            let v619 : Ref<Str> = _run_target_args'_v570 
            let v648 : string = $"$0.chars()"
            let v649 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v619 v648 
            let v650 : string = "$0"
            let v651 : _ = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "$0.collect::<Vec<_>>()"
            let v653 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v651 v652 
            let v654 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v655 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v653 v654 
            let v656 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v657 : bool = Fable.Core.RustInterop.emitRustExpr v655 v656 
            let v658 : string = "x"
            let v659 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v658 
            let v660 : string = "String::from_iter($0)"
            let v661 : std_string_String = Fable.Core.RustInterop.emitRustExpr v659 v660 
            let v662 : string = "true; $0 }).collect::<Vec<_>>()"
            let v663 : bool = Fable.Core.RustInterop.emitRustExpr v661 v662 
            let v664 : string = "_vec_map"
            let v665 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v664 
            let v666 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v667 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v665 v666 
            let v668 : int32 = v667.Length
            let v673 : string = ""
            let v674 : bool = v328 <> v673 
            let v687 : bool =
                if v674 then
                    let v686 : bool = v668 <= 1
                    v686
                else
                    false
            if v687 then
                v442.l0 <- v541
                ()
            else
                v442.l0 <- v673
                let v688 : Mut5 = {l0 = 0} : Mut5
                while method36(v668, v688) do
                    let v690 : int32 = v688.l0
                    let v691 : std_string_String = v667.[int v690]
                    let v692 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v693 : bool = Fable.Core.RustInterop.emitRustExpr v691 v692 
                    let v694 : int32 = v690 + 1
                    v688.l0 <- v694
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v500 v328
            #endif
#if FABLE_COMPILER_PYTHON
            v500 v328
            #endif
#else
            v500 v328
            #endif
            // run_target_args' is_unit
            let v695 : (string -> unit) = v440.l0
            v695 v328
            US12_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
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
and method84 (v0 : int8, v1 : UH2) : US17 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US17_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method84(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US17_1
and method87 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "roll"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method88 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "value"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method86 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method10()
    let v15 : Mut3 = {l0 = v4} : Mut3
    method25(v15)
    method82(v15)
    method27(v15)
    let v419 : string = $"{v0}"
    method11(v15, v419)
    method28(v15)
    method73(v15)
    method27(v15)
    let v945 : string = $"{v1}"
    method11(v15, v945)
    method28(v15)
    method87(v15)
    method27(v15)
    let v1471 : string = $"{v2}"
    method11(v15, v1471)
    method28(v15)
    method88(v15)
    method27(v15)
    let v1997 : string = $"{v3}"
    method11(v15, v1997)
    method30(v15)
    let v2245 : string = v15.l0
    v2245
and method85 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : int64 = v0.l0
    let v17 : string = " "
    let v18 : string = v6 + v17 
    let v30 : string = method23(v12)
    let v33 : string = v18 + v30 
    let v47 : string = v33 + v7 
    let v61 : string = v47 + v17 
    let v77 : string = "dice.accumulate_dice_rolls"
    let v78 : string = v61 + v77 
    let v94 : string = " / "
    let v95 : string = v78 + v94 
    let v107 : string = method86(v8, v9, v10, v11)
    let v110 : string = v95 + v107 
    method31(v110)
and closure97 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure10()
    let v66 : unit = (fun () -> v65 (); v64) ()
    let struct (v115 : Mut0, v116 : Mut1, v117 : Mut2, v118 : Mut3, v119 : Mut4, v120 : int64 option) = TraceState.trace_state.Value
    let v162 : US4 = v119.l0
    let v163 : bool = v117.l0
    let v164 : bool = v163 = false
    let v167 : bool =
        if v164 then
            false
        else
            let v165 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v162
            let v166 : bool = 1 >= v165
            v166
    let v168 : bool = v167 = false
    let v698 : US12 =
        if v168 then
            US12_1
        else
            let v230 : unit = ()
            let v231 : unit = (fun () -> v65 (); v230) ()
            let struct (v280 : Mut0, v281 : Mut1, v282 : Mut2, v283 : Mut3, v284 : Mut4, v285 : int64 option) = TraceState.trace_state.Value
            let v327 : string = method16(v280, v281, v282, v283, v284, v285)
            let v328 : string = method20()
            let v329 : string = method85(v280, v281, v282, v283, v284, v285, v327, v328, v1, v0, v2, v3)
            let v390 : unit = ()
            let v391 : unit = (fun () -> v65 (); v390) ()
            let struct (v440 : Mut0, v441 : Mut1, v442 : Mut2, v443 : Mut3, v444 : Mut4, v445 : int64 option) = TraceState.trace_state.Value
            let v491 : unit = ()
            let v492 : (unit -> unit) = closure17(v440)
            let v493 : unit = (fun () -> v492 (); v491) ()
            let v501 : (string -> unit) = closure18()
            (* run_target_args'
            let v502 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v503 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v329 v503 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v504 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v329 v504 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v505 : string = v443.l0
            let v506 : bool = v505 = ""
            let v542 : string =
                if v506 then
                    v329
                else
                    let v507 : bool = v329 = ""
                    if v507 then
                        let v508 : string = v443.l0
                        v508
                    else
                        let v509 : string = v443.l0
                        let v514 : string = "\n"
                        let v515 : string = v509 + v514 
                        let v529 : string = v515 + v329 
                        v529
            (* run_target_args'
            let v571 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v542 v572 
            let _run_target_args'_v571 = v573 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v542 v574 
            let _run_target_args'_v571 = v575 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v576 : string = "&*$0"
            let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v542 v576 
            let _run_target_args'_v571 = v577 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v580 : Ref<Str> = v542 |> unbox<Ref<Str>>
            let _run_target_args'_v571 = v580 
            #endif
#if FABLE_COMPILER_PYTHON
            let v594 : Ref<Str> = v542 |> unbox<Ref<Str>>
            let _run_target_args'_v571 = v594 
            #endif
#else
            let v608 : Ref<Str> = v542 |> unbox<Ref<Str>>
            let _run_target_args'_v571 = v608 
            #endif
            let v620 : Ref<Str> = _run_target_args'_v571 
            let v649 : string = $"$0.chars()"
            let v650 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v620 v649 
            let v651 : string = "$0"
            let v652 : _ = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.collect::<Vec<_>>()"
            let v654 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v656 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v658 : bool = Fable.Core.RustInterop.emitRustExpr v656 v657 
            let v659 : string = "x"
            let v660 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v659 
            let v661 : string = "String::from_iter($0)"
            let v662 : std_string_String = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "true; $0 }).collect::<Vec<_>>()"
            let v664 : bool = Fable.Core.RustInterop.emitRustExpr v662 v663 
            let v665 : string = "_vec_map"
            let v666 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v665 
            let v667 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v668 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v666 v667 
            let v669 : int32 = v668.Length
            let v674 : string = ""
            let v675 : bool = v329 <> v674 
            let v688 : bool =
                if v675 then
                    let v687 : bool = v669 <= 1
                    v687
                else
                    false
            if v688 then
                v443.l0 <- v542
                ()
            else
                v443.l0 <- v674
                let v689 : Mut5 = {l0 = 0} : Mut5
                while method36(v669, v689) do
                    let v691 : int32 = v689.l0
                    let v692 : std_string_String = v668.[int v691]
                    let v693 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v694 : bool = Fable.Core.RustInterop.emitRustExpr v692 v693 
                    let v695 : int32 = v691 + 1
                    v689.l0 <- v695
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v501 v329
            #endif
#if FABLE_COMPILER_PYTHON
            v501 v329
            #endif
#else
            v501 v329
            #endif
            // run_target_args' is_unit
            let v696 : (string -> unit) = v441.l0
            v696 v329
            US12_0(v440, v441, v442, v443, v444, v445)
    let v739 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v739 
    ()
and method90 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method10()
    let v14 : Mut3 = {l0 = v3} : Mut3
    method25(v14)
    method82(v14)
    method27(v14)
    let v418 : string = $"{v0}"
    method11(v14, v418)
    method28(v14)
    method73(v14)
    method27(v14)
    let v944 : string = $"{v1}"
    method11(v14, v944)
    method28(v14)
    method87(v14)
    method27(v14)
    let v1470 : string = $"{v2}"
    method11(v14, v1470)
    method30(v14)
    let v1718 : string = v14.l0
    v1718
and method89 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method23(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method90(v8, v9, v10)
    let v109 : string = v94 + v106 
    method31(v109)
and closure98 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure10()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut0, v115 : Mut1, v116 : Mut2, v117 : Mut3, v118 : Mut4, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US4 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US12 =
        if v167 then
            US12_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut0, v280 : Mut1, v281 : Mut2, v282 : Mut3, v283 : Mut4, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method16(v279, v280, v281, v282, v283, v284)
            let v327 : string = method20()
            let v328 : string = method89(v279, v280, v281, v282, v283, v284, v326, v327, v1, v0, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut0, v440 : Mut1, v441 : Mut2, v442 : Mut3, v443 : Mut4, v444 : int64 option) = TraceState.trace_state.Value
            let v490 : unit = ()
            let v491 : (unit -> unit) = closure17(v439)
            let v492 : unit = (fun () -> v491 (); v490) ()
            let v500 : (string -> unit) = closure18()
            (* run_target_args'
            let v501 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v328 v502 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v503 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v328 v503 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v504 : string = v442.l0
            let v505 : bool = v504 = ""
            let v541 : string =
                if v505 then
                    v328
                else
                    let v506 : bool = v328 = ""
                    if v506 then
                        let v507 : string = v442.l0
                        v507
                    else
                        let v508 : string = v442.l0
                        let v513 : string = "\n"
                        let v514 : string = v508 + v513 
                        let v528 : string = v514 + v328 
                        v528
            (* run_target_args'
            let v570 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v571 : string = "&*$0"
            let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v571 
            let _run_target_args'_v570 = v572 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v573 : string = "&*$0"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v573 
            let _run_target_args'_v570 = v574 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v575 : string = "&*$0"
            let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v541 v575 
            let _run_target_args'_v570 = v576 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v579 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v579 
            #endif
#if FABLE_COMPILER_PYTHON
            let v593 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v593 
            #endif
#else
            let v607 : Ref<Str> = v541 |> unbox<Ref<Str>>
            let _run_target_args'_v570 = v607 
            #endif
            let v619 : Ref<Str> = _run_target_args'_v570 
            let v648 : string = $"$0.chars()"
            let v649 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v619 v648 
            let v650 : string = "$0"
            let v651 : _ = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "$0.collect::<Vec<_>>()"
            let v653 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v651 v652 
            let v654 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v655 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v653 v654 
            let v656 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v657 : bool = Fable.Core.RustInterop.emitRustExpr v655 v656 
            let v658 : string = "x"
            let v659 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v658 
            let v660 : string = "String::from_iter($0)"
            let v661 : std_string_String = Fable.Core.RustInterop.emitRustExpr v659 v660 
            let v662 : string = "true; $0 }).collect::<Vec<_>>()"
            let v663 : bool = Fable.Core.RustInterop.emitRustExpr v661 v662 
            let v664 : string = "_vec_map"
            let v665 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v664 
            let v666 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v667 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v665 v666 
            let v668 : int32 = v667.Length
            let v673 : string = ""
            let v674 : bool = v328 <> v673 
            let v687 : bool =
                if v674 then
                    let v686 : bool = v668 <= 1
                    v686
                else
                    false
            if v687 then
                v442.l0 <- v541
                ()
            else
                v442.l0 <- v673
                let v688 : Mut5 = {l0 = 0} : Mut5
                while method36(v668, v688) do
                    let v690 : int32 = v688.l0
                    let v691 : std_string_String = v667.[int v690]
                    let v692 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v693 : bool = Fable.Core.RustInterop.emitRustExpr v691 v692 
                    let v694 : int32 = v690 + 1
                    v688.l0 <- v694
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v500 v328
            #endif
#if FABLE_COMPILER_PYTHON
            v500 v328
            #endif
#else
            v500 v328
            #endif
            // run_target_args' is_unit
            let v695 : (string -> unit) = v440.l0
            v695 v328
            US12_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method79 (v0 : int8, v1 : UH0, v2 : uint64) : US16 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v1492 : unit = ()
        let v1493 : (unit -> unit) = closure32(v2, v0, v4)
        let v1494 : unit = (fun () -> v1493 (); v1492) ()
        US16_0(v4, v1)
    else
        match v1 with
        | UH0_1(v2247, v2248) -> (* Cons *)
            let v2249 : bool = v2247 > 1uy
            if v2249 then
                let v2250 : uint64 = 1UL
                let v2251 : (unit -> UH2) = closure33()
                let v2252 : UH2 = UH2_0(v2250, v2251)
                let v2253 : US17 = method84(v0, v2252)
                let v2257 : uint64 =
                    match v2253 with
                    | US17_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US17_0(v2254) -> (* Some *)
                        v2254
                let v2258 : uint8 = v2247 - 1uy
                let v2259 : uint64 = uint64 v2258
                let v2260 : uint64 = v2259 * v2257
                let v3748 : unit = ()
                let v3749 : (unit -> unit) = closure97(v2, v0, v2247, v2260)
                let v3750 : unit = (fun () -> v3749 (); v3748) ()
                let v4501 : uint64 = v2 + v2260
                let v4502 : int8 = v0 - 1y
                method79(v4502, v2248, v4501)
            else
                let v5991 : unit = ()
                let v5992 : (unit -> unit) = closure98(v2, v0, v2247)
                let v5993 : unit = (fun () -> v5992 (); v5991) ()
                let v6744 : int8 = v0 - 1y
                method79(v6744, v2248, v2)
        | UH0_0 -> (* Nil *)
            US16_1
and method91 (v0 : int8, v1 : (unit -> UH1), v2 : Mut0, v3 : Mut0, v4 : Mut0, v5 : Mut7, v6 : int8) : UH0 =
    let v7 : bool = v6 < v0
    if v7 then
        let v8 : uint8 = method69(v1, v2, v3, v4, v5)
        let v9 : int8 = v6 + 1y
        let v10 : UH0 = method91(v0, v1, v2, v3, v4, v5, v9)
        UH0_1(v8, v10)
    else
        UH0_0
and method92 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut7, v5 : uint64, v6 : int8, v7 : UH0) : uint64 =
    let v8 : int8 = v6 + 1y
    let v9 : bool = v6 < v8
    if v9 then
        let v10 : uint8 = method69(v0, v1, v2, v3, v4)
        let v11 : UH0 = UH0_1(v10, v7)
        method68(v0, v1, v2, v3, v4, v5, v6, v11, v8)
    else
        let v13 : uint64 = 0UL
        let v14 : US16 = method79(v6, v7, v13)
        match v14 with
        | US16_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v5
            if v17 then
                v15
            else
                let v18 : int8 = 0y
                let v19 : UH0 = method91(v6, v0, v1, v2, v3, v4, v18)
                method92(v0, v1, v2, v3, v4, v5, v6, v19)
        | _ ->
            let v22 : int8 = 0y
            let v23 : UH0 = method91(v6, v0, v1, v2, v3, v4, v22)
            method92(v0, v1, v2, v3, v4, v5, v6, v23)
and method68 (v0 : (unit -> UH1), v1 : Mut0, v2 : Mut0, v3 : Mut0, v4 : Mut7, v5 : uint64, v6 : int8, v7 : UH0, v8 : int8) : uint64 =
    let v9 : int8 = v6 + 1y
    let v10 : bool = v8 < v9
    if v10 then
        let v11 : uint8 = method69(v0, v1, v2, v3, v4)
        let v12 : UH0 = UH0_1(v11, v7)
        let v13 : int8 = v8 + 1y
        method68(v0, v1, v2, v3, v4, v5, v6, v12, v13)
    else
        let v15 : uint64 = 0UL
        let v16 : US16 = method79(v6, v7, v15)
        match v16 with
        | US16_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= v5
            if v19 then
                v17
            else
                let v20 : int8 = 0y
                let v21 : UH0 = method91(v6, v0, v1, v2, v3, v4, v20)
                method92(v0, v1, v2, v3, v4, v5, v6, v21)
        | _ ->
            let v24 : int8 = 0y
            let v25 : UH0 = method91(v6, v0, v1, v2, v3, v4, v24)
            method92(v0, v1, v2, v3, v4, v5, v6, v25)
and method93 () : (unit -> unit) =
    closure20()
and closure99 (v0 : (unit -> unit)) () : unit =
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure10()
    let v63 : unit = (fun () -> v62 (); v61) ()
    let struct (v112 : Mut0, v113 : Mut1, v114 : Mut2, v115 : Mut3, v116 : Mut4, v117 : int64 option) = TraceState.trace_state.Value
    let v159 : US4 = v116.l0
    let v160 : bool = v114.l0
    let v161 : bool = v160 = false
    let v164 : bool =
        if v161 then
            false
        else
            let v162 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v159
            let v163 : bool = 1 >= v162
            v163
    let v165 : bool = v164 = false
    let v692 : US12 =
        if v165 then
            US12_1
        else
            let v227 : unit = ()
            let v228 : unit = (fun () -> v62 (); v227) ()
            let struct (v277 : Mut0, v278 : Mut1, v279 : Mut2, v280 : Mut3, v281 : Mut4, v282 : int64 option) = TraceState.trace_state.Value
            let v324 : string = method16(v277, v278, v279, v280, v281, v282)
            let v325 : string = method20()
            let v386 : unit = ()
            let v387 : unit = (fun () -> v62 (); v386) ()
            let struct (v436 : Mut0, v437 : Mut1, v438 : Mut2, v439 : Mut3, v440 : Mut4, v441 : int64 option) = TraceState.trace_state.Value
            let v487 : unit = ()
            let v488 : (unit -> unit) = closure17(v436)
            let v489 : unit = (fun () -> v488 (); v487) ()
            let v497 : string = ""
            let v498 : (string -> unit) = closure18()
            (* run_target_args'
            let v499 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v500 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v497 v500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v497 v501 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v502 : string = v439.l0
            let v503 : bool = v502 = ""
            let v539 : string =
                if v503 then
                    v497
                else
                    let v504 : bool = v497 = ""
                    if v504 then
                        let v505 : string = v439.l0
                        v505
                    else
                        let v506 : string = v439.l0
                        let v511 : string = "\n"
                        let v512 : string = v506 + v511 
                        let v526 : string = v512 + v497 
                        v526
            (* run_target_args'
            let v568 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v569 : string = "&*$0"
            let v570 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v569 
            let _run_target_args'_v568 = v570 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v571 : string = "&*$0"
            let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v571 
            let _run_target_args'_v568 = v572 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v573 : string = "&*$0"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v573 
            let _run_target_args'_v568 = v574 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v577 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v591 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v591 
            #endif
#else
            let v605 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v605 
            #endif
            let v617 : Ref<Str> = _run_target_args'_v568 
            let v646 : string = $"$0.chars()"
            let v647 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v617 v646 
            let v648 : string = "$0"
            let v649 : _ = Fable.Core.RustInterop.emitRustExpr v647 v648 
            let v650 : string = "$0.collect::<Vec<_>>()"
            let v651 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v653 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v651 v652 
            let v654 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v655 : bool = Fable.Core.RustInterop.emitRustExpr v653 v654 
            let v656 : string = "x"
            let v657 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v656 
            let v658 : string = "String::from_iter($0)"
            let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr v657 v658 
            let v660 : string = "true; $0 }).collect::<Vec<_>>()"
            let v661 : bool = Fable.Core.RustInterop.emitRustExpr v659 v660 
            let v662 : string = "_vec_map"
            let v663 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v662 
            let v664 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v665 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v663 v664 
            let v666 : int32 = v665.Length
            let v669 : bool = v497 <> v497 
            let v682 : bool =
                if v669 then
                    let v681 : bool = v666 <= 1
                    v681
                else
                    false
            if v682 then
                v439.l0 <- v539
                ()
            else
                v439.l0 <- v497
                let v683 : Mut5 = {l0 = 0} : Mut5
                while method36(v666, v683) do
                    let v685 : int32 = v683.l0
                    let v686 : std_string_String = v665.[int v685]
                    let v687 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v688 : bool = Fable.Core.RustInterop.emitRustExpr v686 v687 
                    let v689 : int32 = v685 + 1
                    v683.l0 <- v689
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v498 v497
            #endif
#if FABLE_COMPILER_PYTHON
            v498 v497
            #endif
#else
            v498 v497
            #endif
            // run_target_args' is_unit
            let v690 : (string -> unit) = v437.l0
            v690 v497
            US12_0(v436, v437, v438, v439, v440, v441)
    let v733 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v733 
    ()
and method94 (v0 : UH0, v1 : int8) : int8 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method94(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method96 (v0 : uint64, v1 : string, v2 : string) : string =
    let v3 : string = method10()
    let v14 : Mut3 = {l0 = v3} : Mut3
    method25(v14)
    method45(v14)
    method27(v14)
    let v418 : string = $"{v0}"
    method11(v14, v418)
    method28(v14)
    method59(v14)
    method27(v14)
    method11(v14, v1)
    method28(v14)
    method83(v14)
    method27(v14)
    method11(v14, v2)
    method30(v14)
    let v1658 : string = v14.l0
    v1658
and method95 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : string, v10 : string) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method23(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice_contract.roll_within_bounds"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method96(v8, v9, v10)
    let v109 : string = v94 + v106 
    method31(v109)
and closure100 (v0 : uint64, v1 : Vec<uint8>, v2 : uint64 option) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure10()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut0, v115 : Mut1, v116 : Mut2, v117 : Mut3, v118 : Mut4, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US4 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v725 : US12 =
        if v167 then
            US12_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut0, v280 : Mut1, v281 : Mut2, v282 : Mut3, v283 : Mut4, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method16(v279, v280, v281, v282, v283, v284)
            let v327 : string = method20()
            let v330 : string = $"%A{v1}"
            let v344 : string = $"%A{v2}"
            let v356 : string = method95(v279, v280, v281, v282, v283, v284, v326, v327, v0, v330, v344)
            let v417 : unit = ()
            let v418 : unit = (fun () -> v64 (); v417) ()
            let struct (v467 : Mut0, v468 : Mut1, v469 : Mut2, v470 : Mut3, v471 : Mut4, v472 : int64 option) = TraceState.trace_state.Value
            let v518 : unit = ()
            let v519 : (unit -> unit) = closure17(v467)
            let v520 : unit = (fun () -> v519 (); v518) ()
            let v528 : (string -> unit) = closure18()
            (* run_target_args'
            let v529 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v530 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v356 v530 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v531 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v356 v531 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v532 : string = v470.l0
            let v533 : bool = v532 = ""
            let v569 : string =
                if v533 then
                    v356
                else
                    let v534 : bool = v356 = ""
                    if v534 then
                        let v535 : string = v470.l0
                        v535
                    else
                        let v536 : string = v470.l0
                        let v541 : string = "\n"
                        let v542 : string = v536 + v541 
                        let v556 : string = v542 + v356 
                        v556
            (* run_target_args'
            let v598 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v599 : string = "&*$0"
            let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v599 
            let _run_target_args'_v598 = v600 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v601 : string = "&*$0"
            let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v601 
            let _run_target_args'_v598 = v602 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v603 : string = "&*$0"
            let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v603 
            let _run_target_args'_v598 = v604 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v607 : Ref<Str> = v569 |> unbox<Ref<Str>>
            let _run_target_args'_v598 = v607 
            #endif
#if FABLE_COMPILER_PYTHON
            let v621 : Ref<Str> = v569 |> unbox<Ref<Str>>
            let _run_target_args'_v598 = v621 
            #endif
#else
            let v635 : Ref<Str> = v569 |> unbox<Ref<Str>>
            let _run_target_args'_v598 = v635 
            #endif
            let v647 : Ref<Str> = _run_target_args'_v598 
            let v676 : string = $"$0.chars()"
            let v677 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v647 v676 
            let v678 : string = "$0"
            let v679 : _ = Fable.Core.RustInterop.emitRustExpr v677 v678 
            let v680 : string = "$0.collect::<Vec<_>>()"
            let v681 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v679 v680 
            let v682 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v683 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v681 v682 
            let v684 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v685 : bool = Fable.Core.RustInterop.emitRustExpr v683 v684 
            let v686 : string = "x"
            let v687 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v686 
            let v688 : string = "String::from_iter($0)"
            let v689 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v688 
            let v690 : string = "true; $0 }).collect::<Vec<_>>()"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr v689 v690 
            let v692 : string = "_vec_map"
            let v693 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v692 
            let v694 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v695 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v693 v694 
            let v696 : int32 = v695.Length
            let v701 : string = ""
            let v702 : bool = v356 <> v701 
            let v715 : bool =
                if v702 then
                    let v714 : bool = v696 <= 1
                    v714
                else
                    false
            if v715 then
                v470.l0 <- v569
                ()
            else
                v470.l0 <- v701
                let v716 : Mut5 = {l0 = 0} : Mut5
                while method36(v696, v716) do
                    let v718 : int32 = v716.l0
                    let v719 : std_string_String = v695.[int v718]
                    let v720 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v721 : bool = Fable.Core.RustInterop.emitRustExpr v719 v720 
                    let v722 : int32 = v718 + 1
                    v716.l0 <- v722
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v528 v356
            #endif
#if FABLE_COMPILER_PYTHON
            v528 v356
            #endif
#else
            v528 v356
            #endif
            // run_target_args' is_unit
            let v723 : (string -> unit) = v468.l0
            v723 v356
            US12_0(v467, v468, v469, v470, v471, v472)
    let v766 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v766 
    ()
and method97 () : (unit -> unit) =
    closure20()
and closure101 (v0 : (unit -> unit)) () : unit =
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure10()
    let v63 : unit = (fun () -> v62 (); v61) ()
    let struct (v112 : Mut0, v113 : Mut1, v114 : Mut2, v115 : Mut3, v116 : Mut4, v117 : int64 option) = TraceState.trace_state.Value
    let v159 : US4 = v116.l0
    let v160 : bool = v114.l0
    let v161 : bool = v160 = false
    let v164 : bool =
        if v161 then
            false
        else
            let v162 : int32 = [ US4_0, 0; US4_1, 1; US4_2, 2; US4_3, 3; US4_4, 4 ] |> Map |> Map.find v159
            let v163 : bool = 1 >= v162
            v163
    let v165 : bool = v164 = false
    let v692 : US12 =
        if v165 then
            US12_1
        else
            let v227 : unit = ()
            let v228 : unit = (fun () -> v62 (); v227) ()
            let struct (v277 : Mut0, v278 : Mut1, v279 : Mut2, v280 : Mut3, v281 : Mut4, v282 : int64 option) = TraceState.trace_state.Value
            let v324 : string = method16(v277, v278, v279, v280, v281, v282)
            let v325 : string = method20()
            let v386 : unit = ()
            let v387 : unit = (fun () -> v62 (); v386) ()
            let struct (v436 : Mut0, v437 : Mut1, v438 : Mut2, v439 : Mut3, v440 : Mut4, v441 : int64 option) = TraceState.trace_state.Value
            let v487 : unit = ()
            let v488 : (unit -> unit) = closure17(v436)
            let v489 : unit = (fun () -> v488 (); v487) ()
            let v497 : string = ""
            let v498 : (string -> unit) = closure18()
            (* run_target_args'
            let v499 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v500 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v497 v500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v497 v501 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v502 : string = v439.l0
            let v503 : bool = v502 = ""
            let v539 : string =
                if v503 then
                    v497
                else
                    let v504 : bool = v497 = ""
                    if v504 then
                        let v505 : string = v439.l0
                        v505
                    else
                        let v506 : string = v439.l0
                        let v511 : string = "\n"
                        let v512 : string = v506 + v511 
                        let v526 : string = v512 + v497 
                        v526
            (* run_target_args'
            let v568 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v569 : string = "&*$0"
            let v570 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v569 
            let _run_target_args'_v568 = v570 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v571 : string = "&*$0"
            let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v571 
            let _run_target_args'_v568 = v572 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v573 : string = "&*$0"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v539 v573 
            let _run_target_args'_v568 = v574 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v577 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v591 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v591 
            #endif
#else
            let v605 : Ref<Str> = v539 |> unbox<Ref<Str>>
            let _run_target_args'_v568 = v605 
            #endif
            let v617 : Ref<Str> = _run_target_args'_v568 
            let v646 : string = $"$0.chars()"
            let v647 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v617 v646 
            let v648 : string = "$0"
            let v649 : _ = Fable.Core.RustInterop.emitRustExpr v647 v648 
            let v650 : string = "$0.collect::<Vec<_>>()"
            let v651 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v653 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v651 v652 
            let v654 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v655 : bool = Fable.Core.RustInterop.emitRustExpr v653 v654 
            let v656 : string = "x"
            let v657 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v656 
            let v658 : string = "String::from_iter($0)"
            let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr v657 v658 
            let v660 : string = "true; $0 }).collect::<Vec<_>>()"
            let v661 : bool = Fable.Core.RustInterop.emitRustExpr v659 v660 
            let v662 : string = "_vec_map"
            let v663 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v662 
            let v664 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v665 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v663 v664 
            let v666 : int32 = v665.Length
            let v669 : bool = v497 <> v497 
            let v682 : bool =
                if v669 then
                    let v681 : bool = v666 <= 1
                    v681
                else
                    false
            if v682 then
                v439.l0 <- v539
                ()
            else
                v439.l0 <- v497
                let v683 : Mut5 = {l0 = 0} : Mut5
                while method36(v666, v683) do
                    let v685 : int32 = v683.l0
                    let v686 : std_string_String = v665.[int v685]
                    let v687 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v688 : bool = Fable.Core.RustInterop.emitRustExpr v686 v687 
                    let v689 : int32 = v685 + 1
                    v683.l0 <- v689
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v498 v497
            #endif
#if FABLE_COMPILER_PYTHON
            v498 v497
            #endif
#else
            v498 v497
            #endif
            // run_target_args' is_unit
            let v690 : (string -> unit) = v437.l0
            v690 v497
            US12_0(v436, v437, v438, v439, v440, v441)
    let v733 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v733 
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
    let v20 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v32 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "        Self((old_state.version + 1, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v39 
    let v40 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v40 
    let v41 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "true; /*"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr () v42 
    let v46 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v58 : string = "true; */"
    let v59 : bool = Fable.Core.RustInterop.emitRustExpr () v58 
    let v60 : string = "seeds"
    let v61 : string = "b\"" + v60 + "\""
    let v62 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v61 
    let v63 : string = "near_sdk::store::vec::Vector::new($0)"
    let v64 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr v62 v63 
    let _result = struct (2u, v64) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v65 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v65 
    let v66 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v66 
    let v67 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v69 : bool = Fable.Core.RustInterop.emitRustExpr () v68 
    let v70 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v71 : bool = Fable.Core.RustInterop.emitRustExpr () v70 
    let v72 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v73 
    let v74 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v74 
    let v75 : string = $"&mut self.0.1"
    let v76 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v75 
    let v77 : string = $"seed"
    let v78 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v77 
    let v79 : string = "true; v76.extend($0); //"
    let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = $"v76.len()"
    let v82 : uint32 = Fable.Core.RustInterop.emitRustExpr () v81 
    let v271 : US0 = method0(v82)
    let v292 : US1 =
        match v271 with
        | US0_1(v289) -> (* Error *)
            US1_1
        | US0_0(v287) -> (* Ok *)
            US1_0(v287)
    let v339 : int32 =
        match v292 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v336) -> (* Some *)
            v336
    let v450 : US2 = method1()
    let v471 : US3 =
        match v450 with
        | US2_1(v468) -> (* Error *)
            US3_1
        | US2_0(v466) -> (* Ok *)
            US3_0(v466)
    let v518 : unativeint =
        match v471 with
        | US3_1 -> (* None *)
            failwith<unativeint> "Option does not have a value."
        | US3_0(v515) -> (* Some *)
            v515
    let v707 : US0 = method2(v518)
    let v728 : US1 =
        match v707 with
        | US0_1(v725) -> (* Error *)
            US1_1
        | US0_0(v723) -> (* Ok *)
            US1_0(v723)
    let v775 : int32 =
        match v728 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v772) -> (* Some *)
            v772
    let v873 : int32 = v339 - v775
    let v874 : bool = v873 > 0
    if v874 then
        let v875 : string = "v76.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v876 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v873 v875 
        let v2392 : unit = ()
        let v2393 : (unit -> unit) = closure9(v873, v876)
        let v2394 : unit = (fun () -> v2393 (); v2392) ()
        ()
    let v3159 : (unit -> unit) = method37()
    let v4641 : unit = ()
    let v4642 : (unit -> unit) = closure21(v3159)
    let v4643 : unit = (fun () -> v4642 (); v4641) ()
    let v5391 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5391 
    let v5392 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5392 
    let v5393 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5393 
    let v5394 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v5394 
    let v5395 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v5396 : bool = Fable.Core.RustInterop.emitRustExpr () v5395 
    let v5397 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v5398 : bool = Fable.Core.RustInterop.emitRustExpr () v5397 
    let v5399 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v5399 
    let v5400 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v5400 
    let v5401 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v5401 
    let v5402 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v5402 
    let v5403 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5403 
    let v5404 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v5404 
    let v5405 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v5406 : bool = Fable.Core.RustInterop.emitRustExpr () v5405 
    let v5407 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v5408 : bool = Fable.Core.RustInterop.emitRustExpr () v5407 
    let v5409 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v5409 
    let v5410 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v5410 
    let v5411 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v5411 
    let v5412 : string = $"key"
    let v5413 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5412 
    let v5414 : string = $"proof"
    let v5415 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5414 
    let v5416 : string = $"max"
    let v5417 : uint64 = Fable.Core.RustInterop.emitRustExpr () v5416 
    let v5418 : string = $"&mut self.0.1"
    let v5419 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v5418 
    let v5420 : string = $"near_sdk::env::random_seed()"
    let v5421 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5420 
    let v5422 : string = $"near_sdk::env::epoch_height()"
    let v5423 : uint64 = Fable.Core.RustInterop.emitRustExpr () v5422 
    let v5424 : string = $"near_sdk::env::block_height()"
    let v5425 : uint64 = Fable.Core.RustInterop.emitRustExpr () v5424 
    let v5426 : string = $"near_sdk::env::block_timestamp()"
    let v5427 : uint64 = Fable.Core.RustInterop.emitRustExpr () v5426 
    let v5428 : string = $"near_sdk::env::account_balance()"
    let v5429 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr () v5428 
    let v5430 : string = $"near_sdk::env::signer_account_id()"
    let v5431 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v5430 
    let v5432 : string = $"near_sdk::env::predecessor_account_id()"
    let v5433 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v5432 
    let v5434 : string = $"&*v5419"
    let v5435 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v5434 
    let v5436 : string = $"v5435.iter().map(|x| *x).collect::<Vec<_>>()"
    let v5437 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5436 
    let v5438 : string = $"v5423.to_le_bytes()"
    let v5439 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v5438 
    let v5440 : string = $"v5439.to_vec()"
    let v5441 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5440 
    let v5442 : string = $"v5425.to_le_bytes()"
    let v5443 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v5442 
    let v5444 : string = $"v5443.to_vec()"
    let v5445 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5444 
    let v5446 : string = $"v5427.to_le_bytes()"
    let v5447 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v5446 
    let v5448 : string = $"v5447.to_vec()"
    let v5449 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5448 
    let v5450 : string = "$0.as_yoctonear()"
    let v5451 : u128 = Fable.Core.RustInterop.emitRustExpr v5429 v5450 
    let v5452 : string = $"v5451.to_le_bytes()"
    let v5453 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr () v5452 
    let v5454 : string = $"v5453.to_vec()"
    let v5455 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5454 
    let v5456 : string = $"v5431.as_bytes()"
    let v5457 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v5456 
    let v5458 : string = $"v5457.to_vec()"
    let v5459 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5458 
    let v5460 : string = $"v5433.as_bytes()"
    let v5461 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v5460 
    let v5462 : string = $"v5461.to_vec()"
    let v5463 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5462 
    let v5464 : string = $"$0.into_bytes()"
    let v5465 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v5415 v5464 
    let v5466 : string = $"$0.into_bytes()"
    let v5467 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v5413 v5466 
    let v5468 : (Vec<uint8> []) = [|v5421; v5437; v5441; v5445; v5449; v5455; v5459; v5463; v5465; v5467|]
    let v5469 : string = "$0.to_vec()"
    let v5470 : Vec<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v5468 v5469 
    let v5471 : string = $"v5470.concat()"
    let v5472 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v5471 
    let v5473 : string = $"near_sdk::env::keccak512(&$0)"
    let v5474 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v5472 v5473 
    let v5475 : string = "true; v5419.extend($0); //"
    let v5476 : bool = Fable.Core.RustInterop.emitRustExpr v5474 v5475 
    let v5477 : string = $"v5419.len()"
    let v5478 : uint32 = Fable.Core.RustInterop.emitRustExpr () v5477 
    let v5667 : US0 = method0(v5478)
    let v5688 : US1 =
        match v5667 with
        | US0_1(v5685) -> (* Error *)
            US1_1
        | US0_0(v5683) -> (* Ok *)
            US1_0(v5683)
    let v5735 : int32 =
        match v5688 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v5732) -> (* Some *)
            v5732
    let v5846 : US2 = method1()
    let v5867 : US3 =
        match v5846 with
        | US2_1(v5864) -> (* Error *)
            US3_1
        | US2_0(v5862) -> (* Ok *)
            US3_0(v5862)
    let v5914 : unativeint =
        match v5867 with
        | US3_1 -> (* None *)
            failwith<unativeint> "Option does not have a value."
        | US3_0(v5911) -> (* Some *)
            v5911
    let v6103 : US0 = method2(v5914)
    let v6124 : US1 =
        match v6103 with
        | US0_1(v6121) -> (* Error *)
            US1_1
        | US0_0(v6119) -> (* Ok *)
            US1_0(v6119)
    let v6171 : int32 =
        match v6124 with
        | US1_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US1_0(v6168) -> (* Some *)
            v6168
    let v6269 : int32 = v5735 - v6171
    let v6270 : bool = v6269 > 0
    if v6270 then
        let v6271 : string = "v5419.drain(0..$0 as u32).collect::<Vec<_>>()"
        let v6272 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v6269 v6271 
        let v7788 : unit = ()
        let v7789 : (unit -> unit) = closure9(v6269, v6272)
        let v7790 : unit = (fun () -> v7789 (); v7788) ()
        ()
    let v8555 : (unit -> unit) = method37()
    let v10037 : unit = ()
    let v10038 : (unit -> unit) = closure21(v8555)
    let v10039 : unit = (fun () -> v10038 (); v10037) ()
    let v10787 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v10788 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v5474 v10787 
    let v10791 : uint8 list = v10788 |> Array.toList
    let v10815 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v10816 : (uint8 -> (UH0 -> UH0)) = method38()
    let v10817 : (uint8 list -> (UH0 -> UH0)) = v10815 v10816
    let v10818 : (UH0 -> UH0) = v10817 v10791
    let v10819 : UH0 = UH0_0
    let v10820 : UH0 = v10818 v10819
    let v10906 : UH1 = UH1_1
    let v10907 : UH1 = method39(v10820, v10906)
    let v10908 : UH1 = UH1_1
    let v10909 : UH1 = method40(v10907, v10908)
    let v10910 : UH0 = UH0_0
    let v10911 : UH0 = method41(v10909, v10910)
    let v12655 : unit = ()
    let v12656 : (unit -> unit) = closure26(v5419, v5413, v5415, v5417, v5421, v5423, v5425, v5427, v5429, v5431, v5433, v5472, v5474, v10911)
    let v12657 : unit = (fun () -> v12656 (); v12655) ()
    let v13537 : UH0 = UH0_0
    let v13538 : UH0 = method60(v10911, v13537)
    let v13539 : UH0 = method61(v10911, v13538)
    let v13540 : UH1 = UH1_1
    let v13541 : UH1 = method39(v13539, v13540)
    let v13542 : (unit -> UH1) = closure27(v13541)
    let v13543 : (unit -> UH1) = method62(v13541, v13542)
    let v13544 : Mut0 = {l0 = 0L} : Mut0
    let v13545 : Mut0 = {l0 = 1L} : Mut0
    let v13546 : Mut0 = {l0 = -1L} : Mut0
    let v13547 : US15 = US15_1
    let v13548 : Mut7 = {l0 = v13547} : Mut7
    let v13549 : bool = v5417 = 1UL
    let v13553 : int8 =
        if v13549 then
            1y
        else
            let v13550 : int8 = 0y
            let v13551 : uint64 = 1UL
            method63(v5417, v13550, v13551)
    let v13554 : int8 = v13553 - 1y
    let v13555 : UH0 = UH0_0
    let v13556 : int8 = 0y
    let v13557 : uint64 = method68(v13543, v13544, v13545, v13546, v13548, v5417, v13554, v13555, v13556)
    let v13558 : (unit -> unit) = method93()
    let v15040 : unit = ()
    let v15041 : (unit -> unit) = closure99(v13558)
    let v15042 : unit = (fun () -> v15041 (); v15040) ()
    let v15790 : string = "v13557 //"
    Fable.Core.RustInterop.emitRustExpr () v15790 
    let v15791 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v15791 
    let v15792 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v15792 
    let v15793 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v15793 
    let v15794 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v15794 
    let v15795 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 3uy"
    let v15796 : bool = Fable.Core.RustInterop.emitRustExpr () v15795 
    let v15797 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 3uy"
    let v15798 : bool = Fable.Core.RustInterop.emitRustExpr () v15797 
    let v15799 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v15799 
    let v15800 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v15800 
    let v15801 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v15801 
    let v15802 : string = $"max"
    let v15803 : uint64 = Fable.Core.RustInterop.emitRustExpr () v15802 
    let v15804 : string = $"rolls"
    let v15805 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v15804 
    let v15806 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
    let v15807 : (uint8 []) = Fable.Core.RustInterop.emitRustExpr v15805 v15806 
    let v15810 : uint8 list = v15807 |> Array.toList
    let v15834 : ((uint8 -> (UH0 -> UH0)) -> (uint8 list -> (UH0 -> UH0))) = List.foldBack
    let v15835 : (uint8 -> (UH0 -> UH0)) = method38()
    let v15836 : (uint8 list -> (UH0 -> UH0)) = v15834 v15835
    let v15837 : (UH0 -> UH0) = v15836 v15810
    let v15838 : UH0 = UH0_0
    let v15839 : UH0 = v15837 v15838
    let v15925 : int8 = 0y
    let v15926 : int8 = method94(v15839, v15925)
    let v15927 : int8 = v15926 - 1y
    let v15928 : uint64 = 0UL
    let v15929 : US16 = method79(v15927, v15839, v15928)
    let v15939 : US17 =
        match v15929 with
        | US16_0(v15930, v15931) -> (* Some *)
            let v15932 : bool = v15930 >= 1UL
            let v15934 : bool =
                if v15932 then
                    let v15933 : bool = v15930 <= v15803
                    v15933
                else
                    false
            if v15934 then
                US17_0(v15930)
            else
                US17_1
        | _ ->
            US17_1
    let v15970 : uint64 option =
        match v15939 with
        | US17_1 -> (* None *)
            let v15957 : uint64 option = None
            v15957
        | US17_0(v15940) -> (* Some *)
            let v15943 : uint64 option = Some v15940 
            v15943
    let v17514 : unit = ()
    let v17515 : (unit -> unit) = closure100(v15803, v15805, v15970)
    let v17516 : unit = (fun () -> v17515 (); v17514) ()
    let v18295 : (unit -> unit) = method97()
    let v19777 : unit = ()
    let v19778 : (unit -> unit) = closure101(v18295)
    let v19779 : unit = (fun () -> v19778 (); v19777) ()
    let v20527 : string = "$0 //"
    Fable.Core.RustInterop.emitRustExpr v15970 v20527 
    let v20528 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v20528 
    let v20529 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v20529 
    let v20530 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v20530 
    let v20531 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 9uy / n: 2uy"
    let v20532 : bool = Fable.Core.RustInterop.emitRustExpr () v20531 
    let v20533 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 9uy / n: 2uy"
    let v20534 : bool = Fable.Core.RustInterop.emitRustExpr () v20533 
    let v20535 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v20535 
    let v20536 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v20536 
    let v20537 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v20537 
    let v20538 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v20538 
    let v20539 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v20539 
    let v20540 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v20540 
    let v20541 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v20541 
    let v20542 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v20542 
    let v20543 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v20543 
    let v20544 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v20544 
    let v20545 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v20545 
    let v20546 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 11uy / n: 1uy"
    let v20547 : bool = Fable.Core.RustInterop.emitRustExpr () v20546 
    let v20548 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 11uy / n: 1uy"
    let v20549 : bool = Fable.Core.RustInterop.emitRustExpr () v20548 
    let v20550 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v20550 
    let v20551 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v20551 
    let v20552 : string = "true; { (); // ?? / i': 1uy / n: 12uy"
    let v20553 : bool = Fable.Core.RustInterop.emitRustExpr () v20552 
    let v20554 : string = "true; { (); // ?? / i': 2uy / n: 12uy"
    let v20555 : bool = Fable.Core.RustInterop.emitRustExpr () v20554 
    let v20556 : string = "true; { (); // ?? / i': 3uy / n: 12uy"
    let v20557 : bool = Fable.Core.RustInterop.emitRustExpr () v20556 
    let v20558 : string = "true; { (); // ?? / i': 4uy / n: 12uy"
    let v20559 : bool = Fable.Core.RustInterop.emitRustExpr () v20558 
    let v20560 : string = "true; { (); // ?? / i': 5uy / n: 12uy"
    let v20561 : bool = Fable.Core.RustInterop.emitRustExpr () v20560 
    let v20562 : string = "true; { (); // ?? / i': 6uy / n: 12uy"
    let v20563 : bool = Fable.Core.RustInterop.emitRustExpr () v20562 
    let v20564 : string = "true; { (); // ?? / i': 7uy / n: 12uy"
    let v20565 : bool = Fable.Core.RustInterop.emitRustExpr () v20564 
    let v20566 : string = "true; { (); // ?? / i': 8uy / n: 12uy"
    let v20567 : bool = Fable.Core.RustInterop.emitRustExpr () v20566 
    let v20568 : string = "true; { (); // ?? / i': 9uy / n: 12uy"
    let v20569 : bool = Fable.Core.RustInterop.emitRustExpr () v20568 
    let v20570 : string = "true; { (); // ?? / i': 10uy / n: 12uy"
    let v20571 : bool = Fable.Core.RustInterop.emitRustExpr () v20570 
    let v20572 : string = "true; { (); // ?? / i': 11uy / n: 12uy"
    let v20573 : bool = Fable.Core.RustInterop.emitRustExpr () v20572 
    let v20574 : string = "true; { (); // ?? / i': 12uy / n: 12uy"
    let v20575 : bool = Fable.Core.RustInterop.emitRustExpr () v20574 
    let v20576 : string = "true; { { (); // ? / i': 13uy / n: 12uy"
    let v20577 : bool = Fable.Core.RustInterop.emitRustExpr () v20576 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
