#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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
and [<Struct>] US6 =
    | US6_0 of f0_0 : US5
    | US6_1
and [<Struct>] US7 =
    | US7_0
    | US7_1
    | US7_2
    | US7_3
    | US7_4
    | US7_5 of f5_0 : US6
    | US7_6
    | US7_7
and [<Struct>] US8 =
    | US8_0 of f0_0 : string
    | US8_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : int64
    | US9_1 of f1_0 : exn
and [<Struct>] US10 =
    | US10_0 of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut5 * f0_4 : Mut6 * f0_5 : int64 option
    | US10_1
and [<Struct>] US11 =
    | US11_0 of f0_0 : char
    | US11_1
and Mut7 = {mutable l0 : int32}
and [<Struct>] US12 =
    | US12_0 of f0_0 : uint64 * f0_1 : UH1
    | US12_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US13 =
    | US13_0 of f0_0 : uint64
    | US13_1
and [<Struct>] US14 =
    | US14_0 of f0_0 : int32
    | US14_1 of f1_0 : exn
and [<Struct>] US15 =
    | US15_0 of f0_0 : int32
    | US15_1
and [<Struct>] US16 =
    | US16_0 of f0_0 : uint8
    | US16_1 of f1_0 : exn
and [<Struct>] US17 =
    | US17_0 of f0_0 : int64 * f0_1 : UH1
    | US17_1
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
and method9 (v0 : string) : string =
    v0
and method10 () : string =
    let v0 : string = ""
    v0
and method13 () : string =
    let v0 : string = ""
    v0
and method14 (v0 : Mut5, v1 : string) : unit =
    let v2 : string = v0.l0
    let v5 : string = v2 + v1 
    v0.l0 <- v5
    ()
and method12 (v0 : US7) : string =
    let v1 : string = method13()
    let v12 : Mut5 = {l0 = v1} : Mut5
    let v15 : string = $"%A{v0}"
    method14(v12, v15)
    let v148 : string = v12.l0
    v148
and method15 (v0 : string) : string =
    let v1 : string = method13()
    let v12 : Mut5 = {l0 = v1} : Mut5
    method14(v12, v0)
    let v134 : string = v12.l0
    v134
and method11 (v0 : string) : string =
    let v1 : US5 = US5_0
    let v2 : US6 = US6_0(v1)
    let v3 : US7 = US7_5(v2)
    let v4 : string = method12(v3)
    let v9 : string = "env.get_environment_variable / target: "
    let v10 : string = v9 + v4 
    let v26 : string = " / var: "
    let v27 : string = v10 + v26 
    let v39 : string = method15(v0)
    let v42 : string = v27 + v39 
    failwith<string> v42
and method16 (v0 : string) : string =
    let v1 : US5 = US5_1
    let v2 : US6 = US6_0(v1)
    let v3 : US7 = US7_5(v2)
    let v4 : string = method12(v3)
    let v9 : string = "env.get_environment_variable / target: "
    let v10 : string = v9 + v4 
    let v26 : string = " / var: "
    let v27 : string = v10 + v26 
    let v39 : string = method15(v0)
    let v42 : string = v27 + v39 
    failwith<string> v42
and closure10 () (v0 : string) : US8 =
    US8_0(v0)
and method17 () : (string -> US8) =
    closure10()
and method8 (v0 : string) : string =
    (* run_target_args'
    let v31 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = method9(v0)
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
    let v45 : string = method10()
    let v46 : string = "$0.unwrap_or($1)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v46 
    let _run_target_args'_v31 = v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : string = method11(v0)
    let _run_target_args'_v31 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = method16(v0)
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
    let v198 : (string -> US8) = method17()
    let v199 : US8 option = v124 |> Option.map v198 
    let v260 : US8 = US8_1
    let v261 : US8 = v199 |> Option.defaultValue v260 
    let v277 : string =
        match v261 with
        | US8_1 -> (* None *)
            let v275 : string = ""
            v275
        | US8_0(v274) -> (* Some *)
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
    let v372 : (string -> US8) = method17()
    let v373 : US8 option = v298 |> Option.map v372 
    let v434 : US8 = US8_1
    let v435 : US8 = v373 |> Option.defaultValue v434 
    let v451 : string =
        match v435 with
        | US8_1 -> (* None *)
            let v449 : string = ""
            v449
        | US8_0(v448) -> (* Some *)
            v448
    let _run_target_args'_v31 = v451 
    #endif
    let v452 : string = _run_target_args'_v31 
    v452
and closure11 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure12 () (v0 : int64) : US9 =
    US9_0(v0)
and closure13 () (v0 : (unit -> exn)) : exn =
    v0 ()
and closure14 () (v0 : exn) : US9 =
    US9_1(v0)
and method18 (v0 : int64) : US9 =
    let v1 : (unit -> int64) = closure11(v0)
    let v2 : (int64 -> US9) = closure12()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US9) = closure14()
    let v5 : US9 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method7 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method8(v0)
    
    
    
    
    
    
    
    
    
    
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
    let v96 : US3 =
        if v92 then
            let v93 : US2 = US2_0
            US3_0(v93)
        else
            US3_1
    let v182 : US3 =
        match v96 with
        | US3_1 -> (* None *)
            let v99 : bool = "Debug" = v1
            let v103 : US3 =
                if v99 then
                    let v100 : US2 = US2_1
                    US3_0(v100)
                else
                    US3_1
            match v103 with
            | US3_1 -> (* None *)
                let v106 : bool = "Info" = v1
                let v110 : US3 =
                    if v106 then
                        let v107 : US2 = US2_2
                        US3_0(v107)
                    else
                        US3_1
                match v110 with
                | US3_1 -> (* None *)
                    let v113 : bool = "Warning" = v1
                    let v117 : US3 =
                        if v113 then
                            let v114 : US2 = US2_3
                            US3_0(v114)
                        else
                            US3_1
                    match v117 with
                    | US3_1 -> (* None *)
                        let v120 : bool = "Critical" = v1
                        let v124 : US3 =
                            if v120 then
                                let v121 : US2 = US2_4
                                US3_0(v121)
                            else
                                US3_1
                        match v124 with
                        | US3_1 -> (* None *)
                            let v127 : bool = v80 = v1
                            let v131 : US3 =
                                if v127 then
                                    let v128 : US2 = US2_0
                                    US3_0(v128)
                                else
                                    US3_1
                            match v131 with
                            | US3_1 -> (* None *)
                                let v134 : bool = v62 = v1
                                let v138 : US3 =
                                    if v134 then
                                        let v135 : US2 = US2_1
                                        US3_0(v135)
                                    else
                                        US3_1
                                match v138 with
                                | US3_1 -> (* None *)
                                    let v141 : bool = v44 = v1
                                    let v145 : US3 =
                                        if v141 then
                                            let v142 : US2 = US2_2
                                            US3_0(v142)
                                        else
                                            US3_1
                                    match v145 with
                                    | US3_1 -> (* None *)
                                        let v148 : bool = v26 = v1
                                        let v152 : US3 =
                                            if v148 then
                                                let v149 : US2 = US2_3
                                                US3_0(v149)
                                            else
                                                US3_1
                                        match v152 with
                                        | US3_1 -> (* None *)
                                            let v155 : bool = v8 = v1
                                            let v159 : US3 =
                                                if v155 then
                                                    let v156 : US2 = US2_4
                                                    US3_0(v156)
                                                else
                                                    US3_1
                                            match v159 with
                                            | US3_1 -> (* None *)
                                                US3_1
                                            | US3_0(v160) -> (* Some *)
                                                US3_0(v160)
                                        | US3_0(v153) -> (* Some *)
                                            US3_0(v153)
                                    | US3_0(v146) -> (* Some *)
                                        US3_0(v146)
                                | US3_0(v139) -> (* Some *)
                                    US3_0(v139)
                            | US3_0(v132) -> (* Some *)
                                US3_0(v132)
                        | US3_0(v125) -> (* Some *)
                            US3_0(v125)
                    | US3_0(v118) -> (* Some *)
                        US3_0(v118)
                | US3_0(v111) -> (* Some *)
                    US3_0(v111)
            | US3_0(v104) -> (* Some *)
                US3_0(v104)
        | US3_0(v97) -> (* Some *)
            US3_0(v97)
    let v183 : string = "AUTOMATION"
    let v184 : string = method8(v183)
    let v189 : string = "True"
    let v190 : bool = v184 <> v189 
    let v558 : US4 =
        if v190 then
            US4_1
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
            let v463 : US9 = method18(v305)
            let v484 : US4 =
                match v463 with
                | US9_1(v481) -> (* Error *)
                    US4_1
                | US9_0(v479) -> (* Ok *)
                    US4_0(v479)
            let v531 : int64 =
                match v484 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v528) -> (* Some *)
                    v528
            US4_0(v531)
    struct (v182, v558)
and closure15 () (v0 : string) : unit =
    ()
and method6 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v6 : US3, v7 : US4) = method7()
    let _run_target_args'_v5 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : US3 = US3_1
    let v9 : US4 = US4_1
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
    let v554 : US4 =
        if v446 then
            US4_1
        else
            let v459 : string = $"near_sdk::env::block_timestamp()"
            let v460 : uint64 = Fable.Core.RustInterop.emitRustExpr () v459 
            let v540 : (uint64 -> int64) = int64
            let v541 : int64 = v540 v460
            US4_0(v541)
    let v555 : US3 = US3_1
    let _run_target_args'_v5 = struct (v555, v554) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v556 : US3, v557 : US4) = method7()
    let _run_target_args'_v5 = struct (v556, v557) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v558 : US3, v559 : US4) = method7()
    let _run_target_args'_v5 = struct (v558, v559) 
    #endif
#else
    let struct (v560 : US3, v561 : US4) = method7()
    let _run_target_args'_v5 = struct (v560, v561) 
    #endif
    let struct (v562 : US3, v563 : US4) = _run_target_args'_v5 
    let v568 : Mut1 = {l0 = 1L} : Mut1
    let v569 : (string -> unit) = closure15()
    let v570 : Mut3 = {l0 = v569} : Mut3
    let v571 : Mut4 = {l0 = true} : Mut4
    let v572 : string = ""
    let v573 : Mut5 = {l0 = v572} : Mut5
    let v576 : US2 =
        match v562 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v574) -> (* Some *)
            v574
    let v577 : Mut6 = {l0 = v576} : Mut6
    let v608 : int64 option =
        match v563 with
        | US4_1 -> (* None *)
            let v595 : int64 option = None
            v595
        | US4_0(v578) -> (* Some *)
            let v581 : int64 option = Some v578 
            v581
    struct (v568, v570, v571, v573, v577, v608)
and closure9 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US2 = US2_0
        let struct (v2 : Mut1, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : Mut6, v7 : int64 option) = method6(v1)
        let v10 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v10 
        ()
and closure16 () (v0 : int64) : US4 =
    US4_0(v0)
and method20 () : (int64 -> US4) =
    closure16()
and method21 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method22 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method19 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    (* run_target_args'
    let v1630 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1693 : (int64 -> US4) = method20()
    let v1694 : US4 option = v5 |> Option.map v1693 
    let v1755 : US4 = US4_1
    let v1756 : US4 = v1694 |> Option.defaultValue v1755 
    let v2414 : System.DateTime =
        match v1756 with
        | US4_1 -> (* None *)
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
        | US4_0(v1769) -> (* Some *)
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
            let v2030 : US9 = method18(v1872)
            let v2051 : US4 =
                match v2030 with
                | US9_1(v2048) -> (* Error *)
                    US4_1
                | US9_0(v2046) -> (* Ok *)
                    US4_0(v2046)
            let v2098 : int64 =
                match v2051 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v2095) -> (* Some *)
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
    let v2415 : string = method21()
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
    let v2549 : (int64 -> US4) = method20()
    let v2550 : US4 option = v5 |> Option.map v2549 
    let v2611 : US4 = US4_1
    let v2612 : US4 = v2550 |> Option.defaultValue v2611 
    let v3270 : System.DateTime =
        match v2612 with
        | US4_1 -> (* None *)
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
        | US4_0(v2625) -> (* Some *)
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
            let v2886 : US9 = method18(v2728)
            let v2907 : US4 =
                match v2886 with
                | US9_1(v2904) -> (* Error *)
                    US4_1
                | US9_0(v2902) -> (* Ok *)
                    US4_0(v2902)
            let v2954 : int64 =
                match v2907 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v2951) -> (* Some *)
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
    let v3271 : string = method21()
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
    let v3407 : (int64 -> US4) = method20()
    let v3408 : US4 option = v5 |> Option.map v3407 
    let v3469 : US4 = US4_1
    let v3470 : US4 = v3408 |> Option.defaultValue v3469 
    let v3578 : uint64 =
        match v3470 with
        | US4_1 -> (* None *)
            v3344
        | US4_0(v3483) -> (* Some *)
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
    let v3651 : (int64 -> US4) = method20()
    let v3652 : US4 option = v5 |> Option.map v3651 
    let v3713 : US4 = US4_1
    let v3714 : US4 = v3652 |> Option.defaultValue v3713 
    let v4372 : System.DateTime =
        match v3714 with
        | US4_1 -> (* None *)
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
        | US4_0(v3727) -> (* Some *)
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
            let v3988 : US9 = method18(v3830)
            let v4009 : US4 =
                match v3988 with
                | US9_1(v4006) -> (* Error *)
                    US4_1
                | US9_0(v4004) -> (* Ok *)
                    US4_0(v4004)
            let v4056 : int64 =
                match v4009 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v4053) -> (* Some *)
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
    let v4373 : string = method22()
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
    let v4507 : (int64 -> US4) = method20()
    let v4508 : US4 option = v5 |> Option.map v4507 
    let v4569 : US4 = US4_1
    let v4570 : US4 = v4508 |> Option.defaultValue v4569 
    let v5228 : System.DateTime =
        match v4570 with
        | US4_1 -> (* None *)
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
        | US4_0(v4583) -> (* Some *)
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
            let v4844 : US9 = method18(v4686)
            let v4865 : US4 =
                match v4844 with
                | US9_1(v4862) -> (* Error *)
                    US4_1
                | US9_0(v4860) -> (* Ok *)
                    US4_0(v4860)
            let v4912 : int64 =
                match v4865 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v4909) -> (* Some *)
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
    let v5229 : string = method22()
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
    let v5363 : (int64 -> US4) = method20()
    let v5364 : US4 option = v5 |> Option.map v5363 
    let v5425 : US4 = US4_1
    let v5426 : US4 = v5364 |> Option.defaultValue v5425 
    let v6084 : System.DateTime =
        match v5426 with
        | US4_1 -> (* None *)
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
        | US4_0(v5439) -> (* Some *)
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
            let v5700 : US9 = method18(v5542)
            let v5721 : US4 =
                match v5700 with
                | US9_1(v5718) -> (* Error *)
                    US4_1
                | US9_0(v5716) -> (* Ok *)
                    US4_0(v5716)
            let v5768 : int64 =
                match v5721 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v5765) -> (* Some *)
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
    let v6085 : string = method22()
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
and method24 (v0 : char) : string =
    let v1 : string = method13()
    let v12 : Mut5 = {l0 = v1} : Mut5
    let v41 : string = $"{v0}"
    method14(v12, v41)
    let v164 : string = v12.l0
    v164
and method23 () : string =
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
    let v358 : string = method24(v357)
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
and method26 (v0 : int64) : string =
    let v1 : string = method13()
    let v12 : Mut5 = {l0 = v1} : Mut5
    let v41 : string = $"{v0}"
    method14(v12, v41)
    let v164 : string = v12.l0
    v164
and method28 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "{ "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method29 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "current_index"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method30 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = " = "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method31 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "; "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method32 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "acc"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method33 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "len"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method34 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "last_item"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method35 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = " }"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method27 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method13()
    let v15 : Mut5 = {l0 = v4} : Mut5
    method28(v15)
    method29(v15)
    method30(v15)
    let v419 : string = $"{v0}"
    method14(v15, v419)
    method31(v15)
    method32(v15)
    method30(v15)
    let v945 : string = $"{v1}"
    method14(v15, v945)
    method31(v15)
    method33(v15)
    method30(v15)
    let v1471 : string = $"{v2}"
    method14(v15, v1471)
    method31(v15)
    method34(v15)
    method30(v15)
    method14(v15, v3)
    method35(v15)
    let v2215 : string = v15.l0
    v2215
and method38 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US11 =
            if v3 then
                US11_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US11_0('\t')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US11_0('\r')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US11_0('\n')
                        else
                            let v14 : int64 = v11 - 1L
                            US11_1
        let v23 : char =
            match v19 with
            | US11_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US11_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method38(v0, v25)
and method37 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = v0.[int v2]
        let v5 : int64 = 0L
        let v6 : bool = method38(v4, v5)
        if v6 then
            let v7 : int32 = v2 + 1
            method37(v0, v1, v7)
        else
            v2
and method40 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US11 =
            if v3 then
                US11_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US11_0('/')
                else
                    let v8 : int64 = v5 - 1L
                    US11_1
        let v15 : char =
            match v11 with
            | US11_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US11_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method40(v0, v17)
and method39 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        0
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
        let v5 : int64 = 0L
        let v6 : bool = method40(v4, v5)
        if v6 then
            method39(v0, v3)
        else
            v3
and method36 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method37(v0, v1, v2)
    let v716 : string = v0.[int v3..int v1]
    let v729 : int32 = v716.Length
    let v730 : int32 = method39(v716, v729)
    let v1443 : string = v716.[int 0..int v730]
    v1443
and method25 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : int64 = v0.l0
    let v17 : string = " "
    let v18 : string = v6 + v17 
    let v30 : string = method26(v12)
    let v33 : string = v18 + v30 
    let v47 : string = v33 + v7 
    let v61 : string = v47 + v17 
    let v77 : string = "dice.create_sequential_roller / roll"
    let v78 : string = v61 + v77 
    let v94 : string = " / "
    let v95 : string = v78 + v94 
    let v107 : string = method27(v8, v9, v10, v11)
    let v110 : string = v95 + v107 
    method36(v110)
and closure17 (v0 : Mut1) () : unit =
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
and method41 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure9()
    let v66 : unit = (fun () -> v65 (); v64) ()
    let struct (v115 : Mut1, v116 : Mut3, v117 : Mut4, v118 : Mut5, v119 : Mut6, v120 : int64 option) = TraceState.trace_state.Value
    let v162 : US2 = v119.l0
    let v163 : bool = v117.l0
    let v164 : bool = v163 = false
    let v167 : bool =
        if v164 then
            false
        else
            let v165 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v162
            let v166 : bool = 1 >= v165
            v166
    let v168 : bool = v167 = false
    let v712 : US10 =
        if v168 then
            US10_1
        else
            let v230 : unit = ()
            let v231 : unit = (fun () -> v65 (); v230) ()
            let struct (v280 : Mut1, v281 : Mut3, v282 : Mut4, v283 : Mut5, v284 : Mut6, v285 : int64 option) = TraceState.trace_state.Value
            let v327 : string = method19(v280, v281, v282, v283, v284, v285)
            let v328 : string = method23()
            let v331 : string = $"%A{v3}"
            let v343 : string = method25(v280, v281, v282, v283, v284, v285, v327, v328, v0, v1, v2, v331)
            let v404 : unit = ()
            let v405 : unit = (fun () -> v65 (); v404) ()
            let struct (v454 : Mut1, v455 : Mut3, v456 : Mut4, v457 : Mut5, v458 : Mut6, v459 : int64 option) = TraceState.trace_state.Value
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
                let v703 : Mut7 = {l0 = 0} : Mut7
                while method41(v683, v703) do
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
            US10_0(v454, v455, v456, v457, v458, v459)
    let v753 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v753 
    ()
and method42 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method42(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method44 () : string =
    let v0 : string = method13()
    let v11 : Mut5 = {l0 = v0} : Mut5
    let v12 : string = v11.l0
    v12
and method43 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v26 : string = method26(v8)
    let v29 : string = v14 + v26 
    let v43 : string = v29 + v7 
    let v57 : string = v43 + v13 
    let v73 : string = "dice.create_sequential_roller / roll / None"
    let v74 : string = v57 + v73 
    let v90 : string = " / "
    let v91 : string = v74 + v90 
    let v103 : string = method44()
    let v106 : string = v91 + v103 
    method36(v106)
and closure20 () () : unit =
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure9()
    let v62 : unit = (fun () -> v61 (); v60) ()
    let struct (v111 : Mut1, v112 : Mut3, v113 : Mut4, v114 : Mut5, v115 : Mut6, v116 : int64 option) = TraceState.trace_state.Value
    let v158 : US2 = v115.l0
    let v159 : bool = v113.l0
    let v160 : bool = v159 = false
    let v163 : bool =
        if v160 then
            false
        else
            let v161 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v158
            let v162 : bool = 1 >= v161
            v162
    let v164 : bool = v163 = false
    let v694 : US10 =
        if v164 then
            US10_1
        else
            let v226 : unit = ()
            let v227 : unit = (fun () -> v61 (); v226) ()
            let struct (v276 : Mut1, v277 : Mut3, v278 : Mut4, v279 : Mut5, v280 : Mut6, v281 : int64 option) = TraceState.trace_state.Value
            let v323 : string = method19(v276, v277, v278, v279, v280, v281)
            let v324 : string = method23()
            let v325 : string = method43(v276, v277, v278, v279, v280, v281, v323, v324)
            let v386 : unit = ()
            let v387 : unit = (fun () -> v61 (); v386) ()
            let struct (v436 : Mut1, v437 : Mut3, v438 : Mut4, v439 : Mut5, v440 : Mut6, v441 : int64 option) = TraceState.trace_state.Value
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
                let v685 : Mut7 = {l0 = 0} : Mut7
                while method41(v665, v685) do
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
            US10_0(v436, v437, v438, v439, v440, v441)
    let v735 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v735 
    ()
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US1 = v4.l0
    let v39 : uint8 option =
        match v8 with
        | US1_1 -> (* None *)
            let v26 : uint8 option = None
            v26
        | US1_0(v9) -> (* Some *)
            let v12 : uint8 option = Some v9 
            v12
    let v1555 : unit = ()
    let v1556 : (unit -> unit) = closure8(v5, v6, v7, v39)
    let v1557 : unit = (fun () -> v1556 (); v1555) ()
    let v2322 : UH0 = v0 ()
    let v2323 : int64 = v1.l0
    let v2324 : US1 = method42(v2323, v2322)
    match v2324 with
    | US1_1 -> (* None *)
        let v3816 : unit = ()
        let v3817 : (unit -> unit) = closure20()
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
        let v4580 : US1 = US1_1
        v4.l0 <- v4580
        method5(v0, v1, v2, v3, v4)
    | US1_0(v2325) -> (* Some *)
        let v2326 : int64 = v1.l0
        let v2327 : int64 = v2326 + 1L
        v1.l0 <- v2327
        let v2328 : US1 = US1_0(v2325)
        v4.l0 <- v2328
        v2325
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
and method48 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "max"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method49 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "p"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method50 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "n"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method47 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method13()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method28(v14)
    method48(v14)
    method30(v14)
    let v418 : string = $"{v0}"
    method14(v14, v418)
    method31(v14)
    method49(v14)
    method30(v14)
    let v944 : string = $"{v1}"
    method14(v14, v944)
    method31(v14)
    method50(v14)
    method30(v14)
    let v1470 : string = $"{v2}"
    method14(v14, v1470)
    method35(v14)
    let v1718 : string = v14.l0
    v1718
and method46 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.calculate_dice_count"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method47(v8, v9, v10)
    let v109 : string = v94 + v106 
    method36(v109)
and closure24 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method46(v279, v280, v281, v282, v283, v284, v326, v327, v0, v2, v1)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method45 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method45(v0, v6, v4)
        else
            let v1495 : unit = ()
            let v1496 : (unit -> unit) = closure24(v0, v1, v2)
            let v1497 : unit = (fun () -> v1496 (); v1495) ()
            v1
    else
        let v3736 : unit = ()
        let v3737 : (unit -> unit) = closure24(v0, v1, v2)
        let v3738 : unit = (fun () -> v3737 (); v3736) ()
        v1
and method55 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "power"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method56 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "result"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method54 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method13()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method28(v14)
    method55(v14)
    method30(v14)
    let v418 : string = $"{v0}"
    method14(v14, v418)
    method31(v14)
    method32(v14)
    method30(v14)
    let v944 : string = $"{v1}"
    method14(v14, v944)
    method31(v14)
    method56(v14)
    method30(v14)
    let v1470 : string = $"{v2}"
    method14(v14, v1470)
    method35(v14)
    let v1718 : string = v14.l0
    v1718
and method53 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method54(v8, v9, v10)
    let v109 : string = v94 + v106 
    method36(v109)
and closure25 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method53(v279, v280, v281, v282, v283, v284, v326, v327, v1, v0, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and closure89 () () : UH2 =
    UH2_1
and closure88 () () : UH2 =
    let v0 : (unit -> UH2) = closure89()
    UH2_0(9223372036854775808UL, v0)
and closure87 () () : UH2 =
    let v0 : (unit -> UH2) = closure88()
    UH2_0(4611686018427387904UL, v0)
and closure86 () () : UH2 =
    let v0 : (unit -> UH2) = closure87()
    UH2_0(6917529027641081856UL, v0)
and closure85 () () : UH2 =
    let v0 : (unit -> UH2) = closure86()
    UH2_0(1152921504606846976UL, v0)
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(15564440312192434176UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(11817445422220181504UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(5044031582654955520UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(6989586621679009792UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(16537217831704461312UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(11979575008805519360UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(14294425217273954304UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(2382404202878992384UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(6545982058383015936UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(10314369046585278464UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(4793518853382471680UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(3873377154515337216UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(645562859085889536UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(107593809847648256UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(3092389647259533312UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(9738770311398031360UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(16995415113324298240UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(8981483876790566912UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(13794743361938128896UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(2299123893656354816UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(3457644661227651072UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(576274110204608512UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(6244960376270618624UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(13338656111851470848UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(14520938734448279552UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(14717985838214414336UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(5527454985320660992UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(16293529225644736512UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(11938960241128898560UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(8138741398091333632UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(7505371590918406144UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(16623181993244360704UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(8919445023443910656UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(4561031516192243712UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(9983543956220149760UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(4738381338321616896UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(789730223053602816UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(131621703842267136UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(21936950640377856UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(3656158440062976UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(609359740010496UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(101559956668416UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(16926659444736UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(2821109907456UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(470184984576UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(78364164096UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(13060694016UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(2176782336UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(362797056UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(60466176UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(10077696UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(1679616UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(279936UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(46656UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(7776UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(1296UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(216UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(36UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(6UL, v0)
and method57 (v0 : int8, v1 : UH2) : US13 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US13_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method57(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US13_1
and method60 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "roll"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method61 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "value"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method59 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method13()
    let v15 : Mut5 = {l0 = v4} : Mut5
    method28(v15)
    method55(v15)
    method30(v15)
    let v419 : string = $"{v0}"
    method14(v15, v419)
    method31(v15)
    method32(v15)
    method30(v15)
    let v945 : string = $"{v1}"
    method14(v15, v945)
    method31(v15)
    method60(v15)
    method30(v15)
    let v1471 : string = $"{v2}"
    method14(v15, v1471)
    method31(v15)
    method61(v15)
    method30(v15)
    let v1997 : string = $"{v3}"
    method14(v15, v1997)
    method35(v15)
    let v2245 : string = v15.l0
    v2245
and method58 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : int64 = v0.l0
    let v17 : string = " "
    let v18 : string = v6 + v17 
    let v30 : string = method26(v12)
    let v33 : string = v18 + v30 
    let v47 : string = v33 + v7 
    let v61 : string = v47 + v17 
    let v77 : string = "dice.accumulate_dice_rolls"
    let v78 : string = v61 + v77 
    let v94 : string = " / "
    let v95 : string = v78 + v94 
    let v107 : string = method59(v8, v9, v10, v11)
    let v110 : string = v95 + v107 
    method36(v110)
and closure90 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure9()
    let v66 : unit = (fun () -> v65 (); v64) ()
    let struct (v115 : Mut1, v116 : Mut3, v117 : Mut4, v118 : Mut5, v119 : Mut6, v120 : int64 option) = TraceState.trace_state.Value
    let v162 : US2 = v119.l0
    let v163 : bool = v117.l0
    let v164 : bool = v163 = false
    let v167 : bool =
        if v164 then
            false
        else
            let v165 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v162
            let v166 : bool = 1 >= v165
            v166
    let v168 : bool = v167 = false
    let v698 : US10 =
        if v168 then
            US10_1
        else
            let v230 : unit = ()
            let v231 : unit = (fun () -> v65 (); v230) ()
            let struct (v280 : Mut1, v281 : Mut3, v282 : Mut4, v283 : Mut5, v284 : Mut6, v285 : int64 option) = TraceState.trace_state.Value
            let v327 : string = method19(v280, v281, v282, v283, v284, v285)
            let v328 : string = method23()
            let v329 : string = method58(v280, v281, v282, v283, v284, v285, v327, v328, v1, v0, v2, v3)
            let v390 : unit = ()
            let v391 : unit = (fun () -> v65 (); v390) ()
            let struct (v440 : Mut1, v441 : Mut3, v442 : Mut4, v443 : Mut5, v444 : Mut6, v445 : int64 option) = TraceState.trace_state.Value
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
                let v689 : Mut7 = {l0 = 0} : Mut7
                while method41(v669, v689) do
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
            US10_0(v440, v441, v442, v443, v444, v445)
    let v739 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v739 
    ()
and method63 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method13()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method28(v14)
    method55(v14)
    method30(v14)
    let v418 : string = $"{v0}"
    method14(v14, v418)
    method31(v14)
    method32(v14)
    method30(v14)
    let v944 : string = $"{v1}"
    method14(v14, v944)
    method31(v14)
    method60(v14)
    method30(v14)
    let v1470 : string = $"{v2}"
    method14(v14, v1470)
    method35(v14)
    let v1718 : string = v14.l0
    v1718
and method62 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method63(v8, v9, v10)
    let v109 : string = v94 + v106 
    method36(v109)
and closure91 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method62(v279, v280, v281, v282, v283, v284, v326, v327, v1, v0, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method52 (v0 : int8, v1 : UH1, v2 : uint64) : US12 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v1492 : unit = ()
        let v1493 : (unit -> unit) = closure25(v2, v0, v4)
        let v1494 : unit = (fun () -> v1493 (); v1492) ()
        US12_0(v4, v1)
    else
        match v1 with
        | UH1_1(v2247, v2248) -> (* Cons *)
            let v2249 : bool = v2247 > 1uy
            if v2249 then
                let v2250 : uint64 = 1UL
                let v2251 : (unit -> UH2) = closure26()
                let v2252 : UH2 = UH2_0(v2250, v2251)
                let v2253 : US13 = method57(v0, v2252)
                let v2257 : uint64 =
                    match v2253 with
                    | US13_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US13_0(v2254) -> (* Some *)
                        v2254
                let v2258 : uint8 = v2247 - 1uy
                let v2259 : uint64 = uint64 v2258
                let v2260 : uint64 = v2259 * v2257
                let v3748 : unit = ()
                let v3749 : (unit -> unit) = closure90(v2, v0, v2247, v2260)
                let v3750 : unit = (fun () -> v3749 (); v3748) ()
                let v4501 : uint64 = v2 + v2260
                let v4502 : int8 = v0 - 1y
                method52(v4502, v2248, v4501)
            else
                let v5991 : unit = ()
                let v5992 : (unit -> unit) = closure91(v2, v0, v2247)
                let v5993 : unit = (fun () -> v5992 (); v5991) ()
                let v6744 : int8 = v0 - 1y
                method52(v6744, v2248, v2)
        | UH1_0 -> (* Nil *)
            US12_1
and method64 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method64(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method65 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method51(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US12 = method52(v3, v4, v10)
        match v11 with
        | US12_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method64(v3, v0, v15)
                    method65(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method51(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method64(v3, v0, v23)
                method65(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method51(v0, v1, v2, v3, v27, v5)
and method51 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method51(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US12 = method52(v3, v4, v12)
        match v13 with
        | US12_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method64(v3, v0, v17)
                    method65(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method51(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method64(v3, v0, v26)
                method65(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method51(v0, v1, v2, v3, v30, v31)
and closure23 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method45(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method51(v0, v1, v2, v8, v9, v10)
and closure22 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure23(v0, v1)
and closure21 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure22(v0)
and method66 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method66(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure93 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method66(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US12 = method52(v4, v1, v5)
    let v16 : US13 =
        match v6 with
        | US12_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US13_0(v7)
            else
                US13_1
        | _ ->
            US13_1
    match v16 with
    | US13_1 -> (* None *)
        let v34 : uint64 option = None
        v34
    | US13_0(v17) -> (* Some *)
        let v20 : uint64 option = Some v17 
        v20
and closure92 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure93(v0)
and method68 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method13()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method28(v14)
    method48(v14)
    method30(v14)
    let v418 : string = $"{v0}"
    method14(v14, v418)
    method31(v14)
    method49(v14)
    method30(v14)
    let v944 : string = $"{v1}"
    method14(v14, v944)
    method31(v14)
    method50(v14)
    method30(v14)
    let v1470 : string = $"{v2}"
    method14(v14, v1470)
    method35(v14)
    let v1718 : string = v14.l0
    v1718
and method67 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v26 : string = method26(v8)
    let v29 : string = v14 + v26 
    let v43 : string = v29 + v7 
    let v57 : string = v43 + v13 
    let v73 : string = "dice.calculate_dice_count"
    let v74 : string = v57 + v73 
    let v90 : string = " / "
    let v91 : string = v74 + v90 
    let v103 : int64 = 9223372036854775807L
    let v104 : int64 = 4738381338321616896L
    let v105 : int8 = 24y
    let v106 : string = method68(v103, v104, v105)
    let v109 : string = v91 + v106 
    method36(v109)
and closure95 () () : unit =
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure9()
    let v62 : unit = (fun () -> v61 (); v60) ()
    let struct (v111 : Mut1, v112 : Mut3, v113 : Mut4, v114 : Mut5, v115 : Mut6, v116 : int64 option) = TraceState.trace_state.Value
    let v158 : US2 = v115.l0
    let v159 : bool = v113.l0
    let v160 : bool = v159 = false
    let v163 : bool =
        if v160 then
            false
        else
            let v161 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v158
            let v162 : bool = 1 >= v161
            v162
    let v164 : bool = v163 = false
    let v694 : US10 =
        if v164 then
            US10_1
        else
            let v226 : unit = ()
            let v227 : unit = (fun () -> v61 (); v226) ()
            let struct (v276 : Mut1, v277 : Mut3, v278 : Mut4, v279 : Mut5, v280 : Mut6, v281 : int64 option) = TraceState.trace_state.Value
            let v323 : string = method19(v276, v277, v278, v279, v280, v281)
            let v324 : string = method23()
            let v325 : string = method67(v276, v277, v278, v279, v280, v281, v323, v324)
            let v386 : unit = ()
            let v387 : unit = (fun () -> v61 (); v386) ()
            let struct (v436 : Mut1, v437 : Mut3, v438 : Mut4, v439 : Mut5, v440 : Mut6, v441 : int64 option) = TraceState.trace_state.Value
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
                let v685 : Mut7 = {l0 = 0} : Mut7
                while method41(v665, v685) do
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
            US10_0(v436, v437, v438, v439, v440, v441)
    let v735 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v735 
    ()
and closure96 () () : int32 =
    let v0 : int32 = 1uy |> int32 
    v0
and closure97 () (v0 : int32) : US14 =
    US14_0(v0)
and closure98 () (v0 : exn) : US14 =
    US14_1(v0)
and method71 () : US14 =
    let v0 : (unit -> int32) = closure96()
    let v1 : (int32 -> US14) = closure97()
    let v2 : ((unit -> exn) -> exn) = closure13()
    let v3 : (exn -> US14) = closure98()
    let v4 : US14 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure99 () () : int32 =
    let v0 : int32 = 7uy |> int32 
    v0
and method72 () : US14 =
    let v0 : (unit -> int32) = closure99()
    let v1 : (int32 -> US14) = closure97()
    let v2 : ((unit -> exn) -> exn) = closure13()
    let v3 : (exn -> US14) = closure98()
    let v4 : US14 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure100 (v0 : int32) () : uint8 =
    let v1 : uint8 = v0 |> uint8 
    v1
and closure101 () (v0 : uint8) : US16 =
    US16_0(v0)
and closure102 () (v0 : exn) : US16 =
    US16_1(v0)
and method73 (v0 : int32) : US16 =
    let v1 : (unit -> uint8) = closure100(v0)
    let v2 : (uint8 -> US16) = closure101()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US16) = closure102()
    let v5 : US16 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method70 () : uint8 =
    (* run_target_args'
    let v1578 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1579 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v1580 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v1579 
    let _run_target_args'_v1578 = v1580 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1581 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v1582 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v1581 
    let _run_target_args'_v1578 = v1582 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1583 : uint8 = failwith<uint8> "common.random' / target=Rust(Contract)"
    let _run_target_args'_v1578 = v1583 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1584 : (unit -> System.Random) = System.Random 
    let v1585 : System.Random = v1584 ()
    let v1774 : US14 = method71()
    let v1795 : US15 =
        match v1774 with
        | US14_1(v1792) -> (* Error *)
            US15_1
        | US14_0(v1790) -> (* Ok *)
            US15_0(v1790)
    let v1842 : int32 =
        match v1795 with
        | US15_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US15_0(v1839) -> (* Some *)
            v1839
    let v2128 : US14 = method72()
    let v2149 : US15 =
        match v2128 with
        | US14_1(v2146) -> (* Error *)
            US15_1
        | US14_0(v2144) -> (* Ok *)
            US15_0(v2144)
    let v2196 : int32 =
        match v2149 with
        | US15_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US15_0(v2193) -> (* Some *)
            v2193
    let v2294 : int32 = v1585.Next (v1842, v2196)
    let v2308 : US16 = method73(v2294)
    let v2329 : US1 =
        match v2308 with
        | US16_1(v2326) -> (* Error *)
            US1_1
        | US16_0(v2324) -> (* Ok *)
            US1_0(v2324)
    let v2376 : uint8 =
        match v2329 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v2373) -> (* Some *)
            v2373
    let _run_target_args'_v1578 = v2376 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2377 : (unit -> System.Random) = System.Random 
    let v2378 : System.Random = v2377 ()
    let v2567 : US14 = method71()
    let v2588 : US15 =
        match v2567 with
        | US14_1(v2585) -> (* Error *)
            US15_1
        | US14_0(v2583) -> (* Ok *)
            US15_0(v2583)
    let v2635 : int32 =
        match v2588 with
        | US15_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US15_0(v2632) -> (* Some *)
            v2632
    let v2921 : US14 = method72()
    let v2942 : US15 =
        match v2921 with
        | US14_1(v2939) -> (* Error *)
            US15_1
        | US14_0(v2937) -> (* Ok *)
            US15_0(v2937)
    let v2989 : int32 =
        match v2942 with
        | US15_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US15_0(v2986) -> (* Some *)
            v2986
    let v3087 : int32 = v2378.Next (v2635, v2989)
    let v3101 : US16 = method73(v3087)
    let v3122 : US1 =
        match v3101 with
        | US16_1(v3119) -> (* Error *)
            US1_1
        | US16_0(v3117) -> (* Ok *)
            US1_0(v3117)
    let v3169 : uint8 =
        match v3122 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v3166) -> (* Some *)
            v3166
    let _run_target_args'_v1578 = v3169 
    #endif
#else
    let v3170 : (unit -> System.Random) = System.Random 
    let v3171 : System.Random = v3170 ()
    let v3360 : US14 = method71()
    let v3381 : US15 =
        match v3360 with
        | US14_1(v3378) -> (* Error *)
            US15_1
        | US14_0(v3376) -> (* Ok *)
            US15_0(v3376)
    let v3428 : int32 =
        match v3381 with
        | US15_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US15_0(v3425) -> (* Some *)
            v3425
    let v3714 : US14 = method72()
    let v3735 : US15 =
        match v3714 with
        | US14_1(v3732) -> (* Error *)
            US15_1
        | US14_0(v3730) -> (* Ok *)
            US15_0(v3730)
    let v3782 : int32 =
        match v3735 with
        | US15_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US15_0(v3779) -> (* Some *)
            v3779
    let v3880 : int32 = v3171.Next (v3428, v3782)
    let v3894 : US16 = method73(v3880)
    let v3915 : US1 =
        match v3894 with
        | US16_1(v3912) -> (* Error *)
            US1_1
        | US16_0(v3910) -> (* Ok *)
            US1_0(v3910)
    let v3962 : uint8 =
        match v3915 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v3959) -> (* Some *)
            v3959
    let _run_target_args'_v1578 = v3962 
    #endif
    let v3963 : uint8 = _run_target_args'_v1578 
    v3963
and method76 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method13()
    let v15 : Mut5 = {l0 = v4} : Mut5
    method28(v15)
    method55(v15)
    method30(v15)
    let v419 : string = $"{v0}"
    method14(v15, v419)
    method31(v15)
    method32(v15)
    method30(v15)
    let v945 : string = $"{v1}"
    method14(v15, v945)
    method31(v15)
    method60(v15)
    method30(v15)
    let v1471 : string = $"{v2}"
    method14(v15, v1471)
    method31(v15)
    method61(v15)
    method30(v15)
    let v1997 : string = $"{v3}"
    method14(v15, v1997)
    method35(v15)
    let v2245 : string = v15.l0
    v2245
and method75 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 23y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method75(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method78 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 22y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method78(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method80 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 21y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method80(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method82 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 20y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method82(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method84 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 19y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method84(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method86 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 18y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method86(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method88 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 17y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method88(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method90 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 16y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method90(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method92 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 15y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method92(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method94 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 14y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method94(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method96 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 13y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method96(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method98 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 12y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method98(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method100 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 11y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method100(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 10y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method102(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 9y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure117 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method104(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 8y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure118 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method106(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 7y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure119 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method108(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 6y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure120 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method110(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 5y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure121 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method112(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method114 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 4y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure122 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method114(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method116 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 3y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure123 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method116(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method118 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 2y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure124 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method118(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method120 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 1y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure125 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method120(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method122 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method26(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 0y
    let v107 : string = method76(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method36(v110)
and closure126 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure9()
    let v65 : unit = (fun () -> v64 (); v63) ()
    let struct (v114 : Mut1, v115 : Mut3, v116 : Mut4, v117 : Mut5, v118 : Mut6, v119 : int64 option) = TraceState.trace_state.Value
    let v161 : US2 = v118.l0
    let v162 : bool = v116.l0
    let v163 : bool = v162 = false
    let v166 : bool =
        if v163 then
            false
        else
            let v164 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v161
            let v165 : bool = 1 >= v164
            v165
    let v167 : bool = v166 = false
    let v697 : US10 =
        if v167 then
            US10_1
        else
            let v229 : unit = ()
            let v230 : unit = (fun () -> v64 (); v229) ()
            let struct (v279 : Mut1, v280 : Mut3, v281 : Mut4, v282 : Mut5, v283 : Mut6, v284 : int64 option) = TraceState.trace_state.Value
            let v326 : string = method19(v279, v280, v281, v282, v283, v284)
            let v327 : string = method23()
            let v328 : string = method122(v279, v280, v281, v282, v283, v284, v326, v327, v0, v1, v2)
            let v389 : unit = ()
            let v390 : unit = (fun () -> v64 (); v389) ()
            let struct (v439 : Mut1, v440 : Mut3, v441 : Mut4, v442 : Mut5, v443 : Mut6, v444 : int64 option) = TraceState.trace_state.Value
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
                let v688 : Mut7 = {l0 = 0} : Mut7
                while method41(v668, v688) do
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
            US10_0(v439, v440, v441, v442, v443, v444)
    let v738 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v738 
    ()
and method125 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method13()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method28(v14)
    method55(v14)
    method30(v14)
    let v418 : string = $"{v0}"
    method14(v14, v418)
    method31(v14)
    method32(v14)
    method30(v14)
    let v944 : string = $"{v1}"
    method14(v14, v944)
    method31(v14)
    method56(v14)
    method30(v14)
    let v1470 : string = $"{v2}"
    method14(v14, v1470)
    method35(v14)
    let v1718 : string = v14.l0
    v1718
and method124 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = -1y
    let v106 : string = method125(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure127 (v0 : int64, v1 : int64) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method124(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method123 (v0 : UH1, v1 : int64) : US17 =
    let v2 : int64 = v1 + 1L
    let v1490 : unit = ()
    let v1491 : (unit -> unit) = closure127(v1, v2)
    let v1492 : unit = (fun () -> v1491 (); v1490) ()
    US17_0(v2, v0)
and method127 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method13()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method28(v14)
    method55(v14)
    method30(v14)
    let v418 : string = $"{v0}"
    method14(v14, v418)
    method31(v14)
    method32(v14)
    method30(v14)
    let v944 : string = $"{v1}"
    method14(v14, v944)
    method31(v14)
    method60(v14)
    method30(v14)
    let v1470 : string = $"{v2}"
    method14(v14, v1470)
    method35(v14)
    let v1718 : string = v14.l0
    v1718
and method126 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 0y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method126(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method121 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v1495 : unit = ()
            let v1496 : (unit -> unit) = closure126(v1, v3, v7)
            let v1497 : unit = (fun () -> v1496 (); v1495) ()
            let v2248 : int64 = v1 + v7
            method123(v4, v2248)
        else
            let v3737 : unit = ()
            let v3738 : (unit -> unit) = closure128(v1, v3)
            let v3739 : unit = (fun () -> v3738 (); v3737) ()
            method123(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method128 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 1y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method128(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method119 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure125(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method121(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure129(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method121(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method129 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 2y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method129(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method117 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure124(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method119(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure130(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method119(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method130 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 3y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method130(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method115 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure123(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method117(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure131(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method117(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method131 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 4y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method131(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method113 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure122(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method115(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure132(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method115(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method132 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 5y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method132(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method111 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure121(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method113(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure133(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method113(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method133 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 6y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method133(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method109 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure120(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method111(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure134(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method111(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method134 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 7y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method134(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method107 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure119(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method109(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure135(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method109(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method135 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 8y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method135(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method105 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure118(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method107(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure136(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method107(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method136 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 9y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method136(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method103 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure117(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method105(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure137(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method105(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method137 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 10y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method137(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method101 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure116(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method103(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure138(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method103(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method138 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 11y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method138(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method99 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure115(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method101(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure139(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method101(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method139 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 12y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method139(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method97 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure114(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method99(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure140(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method99(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method140 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 13y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method140(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method95 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure113(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method97(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure141(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method97(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method141 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 14y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure142 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method141(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method93 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure112(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method95(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure142(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method95(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method142 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 15y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure143 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method142(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method91 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure111(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method93(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure143(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method93(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method143 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 16y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure144 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method143(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method89 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure110(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method91(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure144(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method91(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method144 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 17y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure145 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method144(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method87 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure109(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method89(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure145(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method89(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method145 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 18y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure146 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method145(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method85 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure108(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method87(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure146(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method87(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method146 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 19y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure147 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method146(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method83 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure107(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method85(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure147(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method85(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method147 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 20y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure148 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method147(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method81 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure106(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method83(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure148(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method83(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method148 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 21y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure149 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method148(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method79 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure105(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method81(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure149(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method81(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method149 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 22y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure150 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method149(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method77 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure104(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method79(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure150(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method79(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method150 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method26(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 23y
    let v106 : string = method127(v105, v8, v9)
    let v109 : string = v93 + v106 
    method36(v109)
and closure151 (v0 : int64, v1 : uint8) () : unit =
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure9()
    let v64 : unit = (fun () -> v63 (); v62) ()
    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
    let v160 : US2 = v117.l0
    let v161 : bool = v115.l0
    let v162 : bool = v161 = false
    let v165 : bool =
        if v162 then
            false
        else
            let v163 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v160
            let v164 : bool = 1 >= v163
            v164
    let v166 : bool = v165 = false
    let v696 : US10 =
        if v166 then
            US10_1
        else
            let v228 : unit = ()
            let v229 : unit = (fun () -> v63 (); v228) ()
            let struct (v278 : Mut1, v279 : Mut3, v280 : Mut4, v281 : Mut5, v282 : Mut6, v283 : int64 option) = TraceState.trace_state.Value
            let v325 : string = method19(v278, v279, v280, v281, v282, v283)
            let v326 : string = method23()
            let v327 : string = method150(v278, v279, v280, v281, v282, v283, v325, v326, v0, v1)
            let v388 : unit = ()
            let v389 : unit = (fun () -> v63 (); v388) ()
            let struct (v438 : Mut1, v439 : Mut3, v440 : Mut4, v441 : Mut5, v442 : Mut6, v443 : int64 option) = TraceState.trace_state.Value
            let v489 : unit = ()
            let v490 : (unit -> unit) = closure17(v438)
            let v491 : unit = (fun () -> v490 (); v489) ()
            let v499 : (string -> unit) = closure18()
            (* run_target_args'
            let v500 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v501 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v502 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v327 v502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = v441.l0
            let v504 : bool = v503 = ""
            let v540 : string =
                if v504 then
                    v327
                else
                    let v505 : bool = v327 = ""
                    if v505 then
                        let v506 : string = v441.l0
                        v506
                    else
                        let v507 : string = v441.l0
                        let v512 : string = "\n"
                        let v513 : string = v507 + v512 
                        let v527 : string = v513 + v327 
                        v527
            (* run_target_args'
            let v569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v570 : string = "&*$0"
            let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v570 
            let _run_target_args'_v569 = v571 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v572 : string = "&*$0"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v572 
            let _run_target_args'_v569 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v574 
            let _run_target_args'_v569 = v575 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v578 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v592 
            #endif
#else
            let v606 : Ref<Str> = v540 |> unbox<Ref<Str>>
            let _run_target_args'_v569 = v606 
            #endif
            let v618 : Ref<Str> = _run_target_args'_v569 
            let v647 : string = $"$0.chars()"
            let v648 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v618 v647 
            let v649 : string = "$0"
            let v650 : _ = Fable.Core.RustInterop.emitRustExpr v648 v649 
            let v651 : string = "$0.collect::<Vec<_>>()"
            let v652 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v650 v651 
            let v653 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v654 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v652 v653 
            let v655 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v656 : bool = Fable.Core.RustInterop.emitRustExpr v654 v655 
            let v657 : string = "x"
            let v658 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v657 
            let v659 : string = "String::from_iter($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659 
            let v661 : string = "true; $0 }).collect::<Vec<_>>()"
            let v662 : bool = Fable.Core.RustInterop.emitRustExpr v660 v661 
            let v663 : string = "_vec_map"
            let v664 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v663 
            let v665 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v666 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v664 v665 
            let v667 : int32 = v666.Length
            let v672 : string = ""
            let v673 : bool = v327 <> v672 
            let v686 : bool =
                if v673 then
                    let v685 : bool = v667 <= 1
                    v685
                else
                    false
            if v686 then
                v441.l0 <- v540
                ()
            else
                v441.l0 <- v672
                let v687 : Mut7 = {l0 = 0} : Mut7
                while method41(v667, v687) do
                    let v689 : int32 = v687.l0
                    let v690 : std_string_String = v666.[int v689]
                    let v691 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v692 : bool = Fable.Core.RustInterop.emitRustExpr v690 v691 
                    let v693 : int32 = v689 + 1
                    v687.l0 <- v693
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v499 v327
            #endif
#if FABLE_COMPILER_PYTHON
            v499 v327
            #endif
#else
            v499 v327
            #endif
            // run_target_args' is_unit
            let v694 : (string -> unit) = v439.l0
            v694 v327
            US10_0(v438, v439, v440, v441, v442, v443)
    let v737 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v737 
    ()
and method74 (v0 : UH1, v1 : int64) : US17 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v1496 : unit = ()
            let v1497 : (unit -> unit) = closure103(v1, v3, v8)
            let v1498 : unit = (fun () -> v1497 (); v1496) ()
            let v2249 : int64 = v1 + v8
            method77(v4, v2249)
        else
            let v3738 : unit = ()
            let v3739 : (unit -> unit) = closure151(v1, v3)
            let v3740 : unit = (fun () -> v3739 (); v3738) ()
            method77(v4, v1)
    | UH1_0 -> (* Nil *)
        US17_1
and method69 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method70()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method69(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US17 = method74(v0, v7)
        match v8 with
        | US17_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method70()
                let v13 : uint8 = method70()
                let v14 : uint8 = method70()
                let v15 : uint8 = method70()
                let v16 : uint8 = method70()
                let v17 : uint8 = method70()
                let v18 : uint8 = method70()
                let v19 : uint8 = method70()
                let v20 : uint8 = method70()
                let v21 : uint8 = method70()
                let v22 : uint8 = method70()
                let v23 : uint8 = method70()
                let v24 : uint8 = method70()
                let v25 : uint8 = method70()
                let v26 : uint8 = method70()
                let v27 : uint8 = method70()
                let v28 : uint8 = method70()
                let v29 : uint8 = method70()
                let v30 : uint8 = method70()
                let v31 : uint8 = method70()
                let v32 : uint8 = method70()
                let v33 : uint8 = method70()
                let v34 : uint8 = method70()
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
                method69(v58, v59)
        | _ ->
            let v62 : uint8 = method70()
            let v63 : uint8 = method70()
            let v64 : uint8 = method70()
            let v65 : uint8 = method70()
            let v66 : uint8 = method70()
            let v67 : uint8 = method70()
            let v68 : uint8 = method70()
            let v69 : uint8 = method70()
            let v70 : uint8 = method70()
            let v71 : uint8 = method70()
            let v72 : uint8 = method70()
            let v73 : uint8 = method70()
            let v74 : uint8 = method70()
            let v75 : uint8 = method70()
            let v76 : uint8 = method70()
            let v77 : uint8 = method70()
            let v78 : uint8 = method70()
            let v79 : uint8 = method70()
            let v80 : uint8 = method70()
            let v81 : uint8 = method70()
            let v82 : uint8 = method70()
            let v83 : uint8 = method70()
            let v84 : uint8 = method70()
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
            method69(v108, v109)
and method152 (v0 : int64) : string =
    let v1 : string = method13()
    let v12 : Mut5 = {l0 = v1} : Mut5
    method28(v12)
    method56(v12)
    method30(v12)
    let v416 : string = $"{v0}"
    method14(v12, v416)
    method35(v12)
    let v664 : string = v12.l0
    v664
and method151 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : int64 = v0.l0
    let v14 : string = " "
    let v15 : string = v6 + v14 
    let v27 : string = method26(v9)
    let v30 : string = v15 + v27 
    let v44 : string = v30 + v7 
    let v58 : string = v44 + v14 
    let v74 : string = "dice.main"
    let v75 : string = v58 + v74 
    let v91 : string = " / "
    let v92 : string = v75 + v91 
    let v104 : string = method152(v8)
    let v107 : string = v92 + v104 
    method36(v107)
and closure152 (v0 : int64) () : unit =
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure9()
    let v63 : unit = (fun () -> v62 (); v61) ()
    let struct (v112 : Mut1, v113 : Mut3, v114 : Mut4, v115 : Mut5, v116 : Mut6, v117 : int64 option) = TraceState.trace_state.Value
    let v159 : US2 = v116.l0
    let v160 : bool = v114.l0
    let v161 : bool = v160 = false
    let v164 : bool =
        if v161 then
            false
        else
            let v162 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v159
            let v163 : bool = 1 >= v162
            v163
    let v165 : bool = v164 = false
    let v695 : US10 =
        if v165 then
            US10_1
        else
            let v227 : unit = ()
            let v228 : unit = (fun () -> v62 (); v227) ()
            let struct (v277 : Mut1, v278 : Mut3, v279 : Mut4, v280 : Mut5, v281 : Mut6, v282 : int64 option) = TraceState.trace_state.Value
            let v324 : string = method19(v277, v278, v279, v280, v281, v282)
            let v325 : string = method23()
            let v326 : string = method151(v277, v278, v279, v280, v281, v282, v324, v325, v0)
            let v387 : unit = ()
            let v388 : unit = (fun () -> v62 (); v387) ()
            let struct (v437 : Mut1, v438 : Mut3, v439 : Mut4, v440 : Mut5, v441 : Mut6, v442 : int64 option) = TraceState.trace_state.Value
            let v488 : unit = ()
            let v489 : (unit -> unit) = closure17(v437)
            let v490 : unit = (fun () -> v489 (); v488) ()
            let v498 : (string -> unit) = closure18()
            (* run_target_args'
            let v499 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v500 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v326 v500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v501 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v326 v501 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v502 : string = v440.l0
            let v503 : bool = v502 = ""
            let v539 : string =
                if v503 then
                    v326
                else
                    let v504 : bool = v326 = ""
                    if v504 then
                        let v505 : string = v440.l0
                        v505
                    else
                        let v506 : string = v440.l0
                        let v511 : string = "\n"
                        let v512 : string = v506 + v511 
                        let v526 : string = v512 + v326 
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
            let v671 : string = ""
            let v672 : bool = v326 <> v671 
            let v685 : bool =
                if v672 then
                    let v684 : bool = v666 <= 1
                    v684
                else
                    false
            if v685 then
                v440.l0 <- v539
                ()
            else
                v440.l0 <- v671
                let v686 : Mut7 = {l0 = 0} : Mut7
                while method41(v666, v686) do
                    let v688 : int32 = v686.l0
                    let v689 : std_string_String = v665.[int v688]
                    let v690 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v691 : bool = Fable.Core.RustInterop.emitRustExpr v689 v690 
                    let v692 : int32 = v688 + 1
                    v686.l0 <- v692
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v498 v326
            #endif
#if FABLE_COMPILER_PYTHON
            v498 v326
            #endif
#else
            v498 v326
            #endif
            // run_target_args' is_unit
            let v693 : (string -> unit) = v438.l0
            v693 v326
            US10_0(v437, v438, v439, v440, v441, v442)
    let v736 : string = "Fsharp"
    () // base.backend_switch / record_type_try_find / key: v736 
    ()
and closure94 () (v0 : (string [])) : int32 =
    let v1488 : unit = ()
    let v1489 : (unit -> unit) = closure95()
    let v1490 : unit = (fun () -> v1489 (); v1488) ()
    let v2241 : UH1 = UH1_0
    let v2242 : int8 = 0y
    let v2243 : int64 = method69(v2241, v2242)
    let v3731 : unit = ()
    let v3732 : (unit -> unit) = closure152(v2243)
    let v3733 : unit = (fun () -> v3732 (); v3731) ()
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure21()
let roll_progressively x = v2 x
let v3 : (uint64 -> (UH1 -> uint64 option)) = closure92()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure94()
let main args = v4 args
()
