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
    | US5_2
and [<Struct>] US6 =
    | US6_0 of f0_0 : US5
    | US6_1 of f1_0 : US5
    | US6_2 of f2_0 : US5
    | US6_3 of f3_0 : US5
    | US6_4 of f4_0 : US5
    | US6_5 of f5_0 : US5
    | US6_6 of f6_0 : US5
    | US6_7 of f7_0 : US5
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : int64
    | US8_1 of f1_0 : exn
and [<Struct>] US9 =
    | US9_0 of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut5 * f0_4 : Mut6 * f0_5 : int64 option
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : char
    | US10_1
and Mut7 = {mutable l0 : int32}
and [<Struct>] US11 =
    | US11_0 of f0_0 : uint64 * f0_1 : UH1
    | US11_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US12 =
    | US12_0 of f0_0 : uint64
    | US12_1
and [<Struct>] US13 =
    | US13_0 of f0_0 : int32
    | US13_1 of f1_0 : exn
and [<Struct>] US14 =
    | US14_0 of f0_0 : int32
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : uint8
    | US15_1 of f1_0 : exn
and [<Struct>] US16 =
    | US16_0 of f0_0 : int64 * f0_1 : UH1
    | US16_1
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
and closure10 () (v0 : string) : US7 =
    US7_0(v0)
and method11 () : (string -> US7) =
    closure10()
and method8 (v0 : string) : string =
    (* run_target_args'
    let v34 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = method9(v0)
    let v36 : string = "std::env::var(&*$0)"
    let v37 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "x"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "fable_library_rust::String_::fromString($0)"
    let v43 : string = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "true; $0 })"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let v46 : string = "_result_map_"
    let v47 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = method10()
    let v49 : string = "$0.unwrap_or($1)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49 
    let _run_target_args'_v34 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : US5 = US5_1
    let v52 : US6 = US6_5(v51)
    let v53 : string = $"env.get_environment_variable / target: {v52} / var: {v0}"
    let v54 : string = failwith<string> v53
    let _run_target_args'_v34 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : US5 = US5_2
    let v56 : US6 = US6_5(v55)
    let v57 : string = $"env.get_environment_variable / target: {v56} / var: {v0}"
    let v58 : string = failwith<string> v57
    let _run_target_args'_v34 = v58 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : string = "process.env[$0] ?? \"\""
    let v60 : string = Fable.Core.JsInterop.emitJsExpr v0 v59 
    let _run_target_args'_v34 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : string = "os"
    let v75 : IOsEnviron = Fable.Core.PyInterop.importAll v74 
    let v76 : string = "v75.environ"
    let v77 : obj = Fable.Core.PyInterop.emitPyExpr () v76 
    let v102 : string = "v77.get($0)"
    let v103 : string = Fable.Core.PyInterop.emitPyExpr v0 v102 
    let mutable _v103 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v137 : (string -> string option) = Option.ofObj
    let v138 : string option = v137 v103
    v138 
    #else
    Some v103 
    #endif
    |> fun x -> _v103 <- Some x
    let v139 : string option = match _v103 with Some x -> x | None -> failwith "optionm'.of_obj / _v103=None"
    let v174 : (string -> US7) = method11()
    let v175 : US7 option = v139 |> Option.map v174 
    let v259 : US7 = US7_1
    let v260 : US7 = v175 |> Option.defaultValue v259 
    let v276 : string =
        match v260 with
        | US7_1 -> (* None *)
            let v274 : string = ""
            v274
        | US7_0(v273) -> (* Some *)
            v273
    let _run_target_args'_v34 = v276 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v277 : US5 = US5_1
    let v278 : US6 = US6_2(v277)
    let v279 : string = $"env.get_environment_variable / target: {v278} / var: {v0}"
    let v280 : string = failwith<string> v279
    let _run_target_args'_v34 = v280 
    #endif
#else
    let v281 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v282 : string = v281 v0
    let mutable _v282 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v305 : (string -> string option) = Option.ofObj
    let v306 : string option = v305 v282
    v306 
    #else
    Some v282 
    #endif
    |> fun x -> _v282 <- Some x
    let v307 : string option = match _v282 with Some x -> x | None -> failwith "optionm'.of_obj / _v282=None"
    let v342 : (string -> US7) = method11()
    let v343 : US7 option = v307 |> Option.map v342 
    let v427 : US7 = US7_1
    let v428 : US7 = v343 |> Option.defaultValue v427 
    let v444 : string =
        match v428 with
        | US7_1 -> (* None *)
            let v442 : string = ""
            v442
        | US7_0(v441) -> (* Some *)
            v441
    let _run_target_args'_v34 = v444 
    #endif
    let v445 : string = _run_target_args'_v34 
    v445
and closure11 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure12 () (v0 : int64) : US8 =
    US8_0(v0)
and closure13 () (v0 : (unit -> exn)) : exn =
    v0 ()
and closure14 () (v0 : exn) : US8 =
    US8_1(v0)
and method12 (v0 : int64) : US8 =
    let v1 : (unit -> int64) = closure11(v0)
    let v2 : (int64 -> US8) = closure12()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US8) = closure14()
    let v5 : US8 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method7 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method8(v0)
    
    
    
    
    
    
    
    
    
    
    let v11 : string = "Critical"
    let v12 : (unit -> string) = v11.ToLower
    let v13 : string = v12 ()
    let v34 : string = "Warning"
    let v35 : (unit -> string) = v34.ToLower
    let v36 : string = v35 ()
    let v57 : string = "Info"
    let v58 : (unit -> string) = v57.ToLower
    let v59 : string = v58 ()
    let v80 : string = "Debug"
    let v81 : (unit -> string) = v80.ToLower
    let v82 : string = v81 ()
    let v103 : string = "Verbose"
    let v104 : (unit -> string) = v103.ToLower
    let v105 : string = v104 ()
    let v117 : bool = "Verbose" = v1
    let v121 : US3 =
        if v117 then
            let v118 : US2 = US2_0
            US3_0(v118)
        else
            US3_1
    let v207 : US3 =
        match v121 with
        | US3_1 -> (* None *)
            let v124 : bool = "Debug" = v1
            let v128 : US3 =
                if v124 then
                    let v125 : US2 = US2_1
                    US3_0(v125)
                else
                    US3_1
            match v128 with
            | US3_1 -> (* None *)
                let v131 : bool = "Info" = v1
                let v135 : US3 =
                    if v131 then
                        let v132 : US2 = US2_2
                        US3_0(v132)
                    else
                        US3_1
                match v135 with
                | US3_1 -> (* None *)
                    let v138 : bool = "Warning" = v1
                    let v142 : US3 =
                        if v138 then
                            let v139 : US2 = US2_3
                            US3_0(v139)
                        else
                            US3_1
                    match v142 with
                    | US3_1 -> (* None *)
                        let v145 : bool = "Critical" = v1
                        let v149 : US3 =
                            if v145 then
                                let v146 : US2 = US2_4
                                US3_0(v146)
                            else
                                US3_1
                        match v149 with
                        | US3_1 -> (* None *)
                            let v152 : bool = v105 = v1
                            let v156 : US3 =
                                if v152 then
                                    let v153 : US2 = US2_0
                                    US3_0(v153)
                                else
                                    US3_1
                            match v156 with
                            | US3_1 -> (* None *)
                                let v159 : bool = v82 = v1
                                let v163 : US3 =
                                    if v159 then
                                        let v160 : US2 = US2_1
                                        US3_0(v160)
                                    else
                                        US3_1
                                match v163 with
                                | US3_1 -> (* None *)
                                    let v166 : bool = v59 = v1
                                    let v170 : US3 =
                                        if v166 then
                                            let v167 : US2 = US2_2
                                            US3_0(v167)
                                        else
                                            US3_1
                                    match v170 with
                                    | US3_1 -> (* None *)
                                        let v173 : bool = v36 = v1
                                        let v177 : US3 =
                                            if v173 then
                                                let v174 : US2 = US2_3
                                                US3_0(v174)
                                            else
                                                US3_1
                                        match v177 with
                                        | US3_1 -> (* None *)
                                            let v180 : bool = v13 = v1
                                            let v184 : US3 =
                                                if v180 then
                                                    let v181 : US2 = US2_4
                                                    US3_0(v181)
                                                else
                                                    US3_1
                                            match v184 with
                                            | US3_1 -> (* None *)
                                                US3_1
                                            | US3_0(v185) -> (* Some *)
                                                US3_0(v185)
                                        | US3_0(v178) -> (* Some *)
                                            US3_0(v178)
                                    | US3_0(v171) -> (* Some *)
                                        US3_0(v171)
                                | US3_0(v164) -> (* Some *)
                                    US3_0(v164)
                            | US3_0(v157) -> (* Some *)
                                US3_0(v157)
                        | US3_0(v150) -> (* Some *)
                            US3_0(v150)
                    | US3_0(v143) -> (* Some *)
                        US3_0(v143)
                | US3_0(v136) -> (* Some *)
                    US3_0(v136)
            | US3_0(v129) -> (* Some *)
                US3_0(v129)
        | US3_0(v122) -> (* Some *)
            US3_0(v122)
    let v208 : string = "AUTOMATION"
    let v209 : string = method8(v208)
    let v219 : string = "True"
    let v220 : bool = v209 <> v219 
    let v623 : US4 =
        if v220 then
            US4_1
        else
            (* run_target_args'
            let v261 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v262 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v261 = v262 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v263 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v261 = v263 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v272 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v261 = v272 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v284 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v261 = v284 
            #endif
#if FABLE_COMPILER_PYTHON
            let v285 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v261 = v285 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v286 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v261 = v286 
            #endif
#else
            let v287 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v261 = v287 
            #endif
            let v288 : System.DateTime = _run_target_args'_v261 
            (* run_target_args'
            let v317 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v318 : (System.DateTime -> int64) = _.Ticks
            let v319 : int64 = v318 v288
            let _run_target_args'_v317 = v319 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v320 : (System.DateTime -> int64) = _.Ticks
            let v321 : int64 = v320 v288
            let _run_target_args'_v317 = v321 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v330 : int64 = null |> unbox<int64>
            let _run_target_args'_v317 = v330 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v342 : (System.DateTime -> int64) = _.Ticks
            let v343 : int64 = v342 v288
            let _run_target_args'_v317 = v343 
            #endif
#if FABLE_COMPILER_PYTHON
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v288
            let _run_target_args'_v317 = v345 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v346 : (System.DateTime -> int64) = _.Ticks
            let v347 : int64 = v346 v288
            let _run_target_args'_v317 = v347 
            #endif
#else
            let v348 : (System.DateTime -> int64) = _.Ticks
            let v349 : int64 = v348 v288
            let _run_target_args'_v317 = v349 
            #endif
            let v350 : int64 = _run_target_args'_v317 
            let v526 : US8 = method12(v350)
            let v547 : US4 =
                match v526 with
                | US8_1(v544) -> (* Error *)
                    US4_1
                | US8_0(v542) -> (* Ok *)
                    US4_0(v542)
            let v596 : int64 =
                match v547 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v593) -> (* Some *)
                    v593
            US4_0(v596)
    struct (v207, v623)
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
    let v51 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "option_env!(\"" + v10 + "\").unwrap_or(\"\")"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v52 
    (* run_target_args'
    let v94 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v95 
    let _run_target_args'_v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v97 
    let _run_target_args'_v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v99 
    let _run_target_args'_v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : std_string_String = v53 |> unbox<std_string_String>
    let _run_target_args'_v94 = v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v129 : std_string_String = v53 |> unbox<std_string_String>
    let _run_target_args'_v94 = v129 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v149 : std_string_String = v53 |> unbox<std_string_String>
    let _run_target_args'_v94 = v149 
    #endif
#else
    let v169 : std_string_String = v53 |> unbox<std_string_String>
    let _run_target_args'_v94 = v169 
    #endif
    let v181 : std_string_String = _run_target_args'_v94 
    let v222 : string = "fable_library_rust::String_::fromString($0)"
    let v223 : string = Fable.Core.RustInterop.emitRustExpr v181 v222 
    let _run_target_args'_v51 = v223 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v224 : string = "option_env!(\"" + v10 + "\").unwrap_or(\"\")"
    let v225 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v224 
    (* run_target_args'
    let v266 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v267 : string = "String::from($0)"
    let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v225 v267 
    let _run_target_args'_v266 = v268 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v269 : string = "String::from($0)"
    let v270 : std_string_String = Fable.Core.RustInterop.emitRustExpr v225 v269 
    let _run_target_args'_v266 = v270 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = "String::from($0)"
    let v272 : std_string_String = Fable.Core.RustInterop.emitRustExpr v225 v271 
    let _run_target_args'_v266 = v272 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v281 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v266 = v281 
    #endif
#if FABLE_COMPILER_PYTHON
    let v301 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v266 = v301 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v321 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v266 = v321 
    #endif
#else
    let v341 : std_string_String = v225 |> unbox<std_string_String>
    let _run_target_args'_v266 = v341 
    #endif
    let v353 : std_string_String = _run_target_args'_v266 
    let v394 : string = "fable_library_rust::String_::fromString($0)"
    let v395 : string = Fable.Core.RustInterop.emitRustExpr v353 v394 
    let _run_target_args'_v51 = v395 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v396 : string = "option_env!(\"" + v10 + "\").unwrap_or(\"\")"
    let v397 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v396 
    (* run_target_args'
    let v438 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v439 : string = "String::from($0)"
    let v440 : std_string_String = Fable.Core.RustInterop.emitRustExpr v397 v439 
    let _run_target_args'_v438 = v440 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v441 : string = "String::from($0)"
    let v442 : std_string_String = Fable.Core.RustInterop.emitRustExpr v397 v441 
    let _run_target_args'_v438 = v442 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v443 : string = "String::from($0)"
    let v444 : std_string_String = Fable.Core.RustInterop.emitRustExpr v397 v443 
    let _run_target_args'_v438 = v444 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v453 : std_string_String = v397 |> unbox<std_string_String>
    let _run_target_args'_v438 = v453 
    #endif
#if FABLE_COMPILER_PYTHON
    let v473 : std_string_String = v397 |> unbox<std_string_String>
    let _run_target_args'_v438 = v473 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v493 : std_string_String = v397 |> unbox<std_string_String>
    let _run_target_args'_v438 = v493 
    #endif
#else
    let v513 : std_string_String = v397 |> unbox<std_string_String>
    let _run_target_args'_v438 = v513 
    #endif
    let v525 : std_string_String = _run_target_args'_v438 
    let v566 : string = "fable_library_rust::String_::fromString($0)"
    let v567 : string = Fable.Core.RustInterop.emitRustExpr v525 v566 
    let _run_target_args'_v51 = v567 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v576 : string = null |> unbox<string>
    let _run_target_args'_v51 = v576 
    #endif
#if FABLE_COMPILER_PYTHON
    let v596 : string = null |> unbox<string>
    let _run_target_args'_v51 = v596 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v616 : string = null |> unbox<string>
    let _run_target_args'_v51 = v616 
    #endif
#else
    let v636 : string = null |> unbox<string>
    let _run_target_args'_v51 = v636 
    #endif
    let v648 : string = _run_target_args'_v51 
    let v698 : string = "True"
    let v699 : bool = v648 <> v698 
    let v736 : US4 =
        if v699 then
            US4_1
        else
            let v712 : string = $"near_sdk::env::block_timestamp()"
            let v713 : uint64 = Fable.Core.RustInterop.emitRustExpr () v712 
            let v722 : (uint64 -> int64) = int64
            let v723 : int64 = v722 v713
            US4_0(v723)
    let v737 : US3 = US3_1
    let _run_target_args'_v5 = struct (v737, v736) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v738 : US3, v739 : US4) = method7()
    let _run_target_args'_v5 = struct (v738, v739) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v740 : US3, v741 : US4) = method7()
    let _run_target_args'_v5 = struct (v740, v741) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v742 : US3, v743 : US4) = method7()
    let _run_target_args'_v5 = struct (v742, v743) 
    #endif
#else
    let struct (v744 : US3, v745 : US4) = method7()
    let _run_target_args'_v5 = struct (v744, v745) 
    #endif
    let struct (v746 : US3, v747 : US4) = _run_target_args'_v5 
    let v752 : Mut1 = {l0 = 1L} : Mut1
    let v753 : (string -> unit) = closure15()
    let v754 : Mut3 = {l0 = v753} : Mut3
    let v755 : Mut4 = {l0 = true} : Mut4
    let v756 : string = ""
    let v757 : Mut5 = {l0 = v756} : Mut5
    let v760 : US2 =
        match v746 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v758) -> (* Some *)
            v758
    let v761 : Mut6 = {l0 = v760} : Mut6
    let v804 : int64 option =
        match v747 with
        | US4_1 -> (* None *)
            let v791 : int64 option = None
            v791
        | US4_0(v762) -> (* Some *)
            let v771 : int64 option = Some v762 
            v771
    struct (v752, v754, v755, v757, v761, v804)
and closure9 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US2 = US2_0
        let struct (v2 : Mut1, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : Mut6, v7 : int64 option) = method6(v1)
        let v16 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v16 
        ()
and closure16 () (v0 : int64) : US4 =
    US4_0(v0)
and method14 () : (int64 -> US4) =
    closure16()
and method15 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method16 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method13 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    (* run_target_args'
    let v1753 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1777 : (int64 -> US4) = method14()
    let v1778 : US4 option = v5 |> Option.map v1777 
    let v1862 : US4 = US4_1
    let v1863 : US4 = v1778 |> Option.defaultValue v1862 
    let v2600 : System.DateTime =
        match v1863 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v2558 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2559 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2558 = v2559 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2560 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2558 = v2560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2569 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2558 = v2569 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2581 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2558 = v2581 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2582 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2558 = v2582 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2583 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2558 = v2583 
            #endif
#else
            let v2584 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2558 = v2584 
            #endif
            let v2585 : System.DateTime = _run_target_args'_v2558 
            v2585
        | US4_0(v1876) -> (* Some *)
            (* run_target_args'
            let v1905 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1906 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1905 = v1906 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1907 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1905 = v1907 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1916 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1905 = v1916 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1928 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1905 = v1928 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1929 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1905 = v1929 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1930 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1905 = v1930 
            #endif
#else
            let v1931 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1905 = v1931 
            #endif
            let v1932 : System.DateTime = _run_target_args'_v1905 
            (* run_target_args'
            let v1961 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1962 : (System.DateTime -> int64) = _.Ticks
            let v1963 : int64 = v1962 v1932
            let _run_target_args'_v1961 = v1963 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1964 : (System.DateTime -> int64) = _.Ticks
            let v1965 : int64 = v1964 v1932
            let _run_target_args'_v1961 = v1965 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1974 : int64 = null |> unbox<int64>
            let _run_target_args'_v1961 = v1974 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1986 : (System.DateTime -> int64) = _.Ticks
            let v1987 : int64 = v1986 v1932
            let _run_target_args'_v1961 = v1987 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1988 : (System.DateTime -> int64) = _.Ticks
            let v1989 : int64 = v1988 v1932
            let _run_target_args'_v1961 = v1989 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1990 : (System.DateTime -> int64) = _.Ticks
            let v1991 : int64 = v1990 v1932
            let _run_target_args'_v1961 = v1991 
            #endif
#else
            let v1992 : (System.DateTime -> int64) = _.Ticks
            let v1993 : int64 = v1992 v1932
            let _run_target_args'_v1961 = v1993 
            #endif
            let v1994 : int64 = _run_target_args'_v1961 
            let v2170 : US8 = method12(v1994)
            let v2191 : US4 =
                match v2170 with
                | US8_1(v2188) -> (* Error *)
                    US4_1
                | US8_0(v2186) -> (* Ok *)
                    US4_0(v2186)
            let v2240 : int64 =
                match v2191 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v2237) -> (* Some *)
                    v2237
            let v2259 : int64 = v2240 - v1876
            let v2355 : System.TimeSpan = v2259 |> System.TimeSpan 
            let v2375 : (System.TimeSpan -> int32) = _.Hours
            let v2376 : int32 = v2375 v2355
            let v2396 : (System.TimeSpan -> int32) = _.Minutes
            let v2397 : int32 = v2396 v2355
            let v2417 : (System.TimeSpan -> int32) = _.Seconds
            let v2418 : int32 = v2417 v2355
            let v2438 : (System.TimeSpan -> int32) = _.Milliseconds
            let v2439 : int32 = v2438 v2355
            let v2518 : System.DateTime = System.DateTime (1, 1, 1, v2376, v2397, v2418, v2439)
            v2518
    let v2608 : string = method15()
    let v2636 : bool = v2608 = ""
    let v2638 : string =
        if v2636 then
            let v2637 : string = "M-d-y hh:mm:ss tt"
            v2637
        else
            v2608
    let v2639 : (string -> string) = v2600.ToString
    let v2640 : string = v2639 v2638
    let _run_target_args'_v1753 = v2640 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2703 : (int64 -> US4) = method14()
    let v2704 : US4 option = v5 |> Option.map v2703 
    let v2788 : US4 = US4_1
    let v2789 : US4 = v2704 |> Option.defaultValue v2788 
    let v3526 : System.DateTime =
        match v2789 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v3484 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3485 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3484 = v3485 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3486 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3484 = v3486 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3495 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3484 = v3495 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3507 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3484 = v3507 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3508 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3484 = v3508 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3509 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3484 = v3509 
            #endif
#else
            let v3510 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3484 = v3510 
            #endif
            let v3511 : System.DateTime = _run_target_args'_v3484 
            v3511
        | US4_0(v2802) -> (* Some *)
            (* run_target_args'
            let v2831 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2832 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2831 = v2832 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2833 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2831 = v2833 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2842 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v2831 = v2842 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2854 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2831 = v2854 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2855 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2831 = v2855 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2856 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2831 = v2856 
            #endif
#else
            let v2857 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v2831 = v2857 
            #endif
            let v2858 : System.DateTime = _run_target_args'_v2831 
            (* run_target_args'
            let v2887 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2888 : (System.DateTime -> int64) = _.Ticks
            let v2889 : int64 = v2888 v2858
            let _run_target_args'_v2887 = v2889 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2890 : (System.DateTime -> int64) = _.Ticks
            let v2891 : int64 = v2890 v2858
            let _run_target_args'_v2887 = v2891 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2900 : int64 = null |> unbox<int64>
            let _run_target_args'_v2887 = v2900 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2912 : (System.DateTime -> int64) = _.Ticks
            let v2913 : int64 = v2912 v2858
            let _run_target_args'_v2887 = v2913 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2914 : (System.DateTime -> int64) = _.Ticks
            let v2915 : int64 = v2914 v2858
            let _run_target_args'_v2887 = v2915 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2916 : (System.DateTime -> int64) = _.Ticks
            let v2917 : int64 = v2916 v2858
            let _run_target_args'_v2887 = v2917 
            #endif
#else
            let v2918 : (System.DateTime -> int64) = _.Ticks
            let v2919 : int64 = v2918 v2858
            let _run_target_args'_v2887 = v2919 
            #endif
            let v2920 : int64 = _run_target_args'_v2887 
            let v3096 : US8 = method12(v2920)
            let v3117 : US4 =
                match v3096 with
                | US8_1(v3114) -> (* Error *)
                    US4_1
                | US8_0(v3112) -> (* Ok *)
                    US4_0(v3112)
            let v3166 : int64 =
                match v3117 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v3163) -> (* Some *)
                    v3163
            let v3185 : int64 = v3166 - v2802
            let v3281 : System.TimeSpan = v3185 |> System.TimeSpan 
            let v3301 : (System.TimeSpan -> int32) = _.Hours
            let v3302 : int32 = v3301 v3281
            let v3322 : (System.TimeSpan -> int32) = _.Minutes
            let v3323 : int32 = v3322 v3281
            let v3343 : (System.TimeSpan -> int32) = _.Seconds
            let v3344 : int32 = v3343 v3281
            let v3364 : (System.TimeSpan -> int32) = _.Milliseconds
            let v3365 : int32 = v3364 v3281
            let v3444 : System.DateTime = System.DateTime (1, 1, 1, v3302, v3323, v3344, v3365)
            v3444
    let v3534 : string = method15()
    let v3562 : bool = v3534 = ""
    let v3564 : string =
        if v3562 then
            let v3563 : string = "M-d-y hh:mm:ss tt"
            v3563
        else
            v3534
    let v3565 : (string -> string) = v3526.ToString
    let v3566 : string = v3565 v3564
    let _run_target_args'_v1753 = v3566 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3606 : string = $"near_sdk::env::block_timestamp()"
    let v3607 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3606 
    let v3631 : (int64 -> US4) = method14()
    let v3632 : US4 option = v5 |> Option.map v3631 
    let v3716 : US4 = US4_1
    let v3717 : US4 = v3632 |> Option.defaultValue v3716 
    let v3754 : uint64 =
        match v3717 with
        | US4_1 -> (* None *)
            v3607
        | US4_0(v3730) -> (* Some *)
            let v3739 : (int64 -> uint64) = uint64
            let v3740 : uint64 = v3739 v3730
            let v3752 : uint64 = v3607 - v3740
            v3752
    let v3755 : uint64 = v3754 / 1000000000UL
    let v3756 : uint64 = v3755 % 60UL
    let v3757 : uint64 = v3755 / 60UL
    let v3758 : uint64 = v3757 % 60UL
    let v3759 : uint64 = v3755 / 3600UL
    let v3760 : uint64 = v3759 % 24UL
    let v3761 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v3762 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3760, v3758, v3756) v3761 
    let v3763 : string = "fable_library_rust::String_::fromString($0)"
    let v3764 : string = Fable.Core.RustInterop.emitRustExpr v3762 v3763 
    let _run_target_args'_v1753 = v3764 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3788 : (int64 -> US4) = method14()
    let v3789 : US4 option = v5 |> Option.map v3788 
    let v3873 : US4 = US4_1
    let v3874 : US4 = v3789 |> Option.defaultValue v3873 
    let v4611 : System.DateTime =
        match v3874 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v4569 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4570 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4569 = v4570 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4571 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4569 = v4571 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4580 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v4569 = v4580 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4592 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4569 = v4592 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4593 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4569 = v4593 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4594 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4569 = v4594 
            #endif
#else
            let v4595 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4569 = v4595 
            #endif
            let v4596 : System.DateTime = _run_target_args'_v4569 
            v4596
        | US4_0(v3887) -> (* Some *)
            (* run_target_args'
            let v3916 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3917 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3916 = v3917 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3918 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3916 = v3918 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3927 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v3916 = v3927 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3939 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3916 = v3939 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3940 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3916 = v3940 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3941 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3916 = v3941 
            #endif
#else
            let v3942 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v3916 = v3942 
            #endif
            let v3943 : System.DateTime = _run_target_args'_v3916 
            (* run_target_args'
            let v3972 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3973 : (System.DateTime -> int64) = _.Ticks
            let v3974 : int64 = v3973 v3943
            let _run_target_args'_v3972 = v3974 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3975 : (System.DateTime -> int64) = _.Ticks
            let v3976 : int64 = v3975 v3943
            let _run_target_args'_v3972 = v3976 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3985 : int64 = null |> unbox<int64>
            let _run_target_args'_v3972 = v3985 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3997 : (System.DateTime -> int64) = _.Ticks
            let v3998 : int64 = v3997 v3943
            let _run_target_args'_v3972 = v3998 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3999 : (System.DateTime -> int64) = _.Ticks
            let v4000 : int64 = v3999 v3943
            let _run_target_args'_v3972 = v4000 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4001 : (System.DateTime -> int64) = _.Ticks
            let v4002 : int64 = v4001 v3943
            let _run_target_args'_v3972 = v4002 
            #endif
#else
            let v4003 : (System.DateTime -> int64) = _.Ticks
            let v4004 : int64 = v4003 v3943
            let _run_target_args'_v3972 = v4004 
            #endif
            let v4005 : int64 = _run_target_args'_v3972 
            let v4181 : US8 = method12(v4005)
            let v4202 : US4 =
                match v4181 with
                | US8_1(v4199) -> (* Error *)
                    US4_1
                | US8_0(v4197) -> (* Ok *)
                    US4_0(v4197)
            let v4251 : int64 =
                match v4202 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v4248) -> (* Some *)
                    v4248
            let v4270 : int64 = v4251 - v3887
            let v4366 : System.TimeSpan = v4270 |> System.TimeSpan 
            let v4386 : (System.TimeSpan -> int32) = _.Hours
            let v4387 : int32 = v4386 v4366
            let v4407 : (System.TimeSpan -> int32) = _.Minutes
            let v4408 : int32 = v4407 v4366
            let v4428 : (System.TimeSpan -> int32) = _.Seconds
            let v4429 : int32 = v4428 v4366
            let v4449 : (System.TimeSpan -> int32) = _.Milliseconds
            let v4450 : int32 = v4449 v4366
            let v4529 : System.DateTime = System.DateTime (1, 1, 1, v4387, v4408, v4429, v4450)
            v4529
    let v4619 : string = method16()
    let v4647 : bool = v4619 = ""
    let v4649 : string =
        if v4647 then
            let v4648 : string = "M-d-y hh:mm:ss tt"
            v4648
        else
            v4619
    let v4650 : (string -> string) = v4611.ToString
    let v4651 : string = v4650 v4649
    let _run_target_args'_v1753 = v4651 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4714 : (int64 -> US4) = method14()
    let v4715 : US4 option = v5 |> Option.map v4714 
    let v4799 : US4 = US4_1
    let v4800 : US4 = v4715 |> Option.defaultValue v4799 
    let v5537 : System.DateTime =
        match v4800 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v5495 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5496 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5495 = v5496 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5497 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5495 = v5497 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5506 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v5495 = v5506 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5518 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5495 = v5518 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5519 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5495 = v5519 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5520 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5495 = v5520 
            #endif
#else
            let v5521 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5495 = v5521 
            #endif
            let v5522 : System.DateTime = _run_target_args'_v5495 
            v5522
        | US4_0(v4813) -> (* Some *)
            (* run_target_args'
            let v4842 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4843 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4842 = v4843 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4844 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4842 = v4844 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4853 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v4842 = v4853 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4865 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4842 = v4865 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4866 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4842 = v4866 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4867 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4842 = v4867 
            #endif
#else
            let v4868 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v4842 = v4868 
            #endif
            let v4869 : System.DateTime = _run_target_args'_v4842 
            (* run_target_args'
            let v4898 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4899 : (System.DateTime -> int64) = _.Ticks
            let v4900 : int64 = v4899 v4869
            let _run_target_args'_v4898 = v4900 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4901 : (System.DateTime -> int64) = _.Ticks
            let v4902 : int64 = v4901 v4869
            let _run_target_args'_v4898 = v4902 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4911 : int64 = null |> unbox<int64>
            let _run_target_args'_v4898 = v4911 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4923 : (System.DateTime -> int64) = _.Ticks
            let v4924 : int64 = v4923 v4869
            let _run_target_args'_v4898 = v4924 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4925 : (System.DateTime -> int64) = _.Ticks
            let v4926 : int64 = v4925 v4869
            let _run_target_args'_v4898 = v4926 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4927 : (System.DateTime -> int64) = _.Ticks
            let v4928 : int64 = v4927 v4869
            let _run_target_args'_v4898 = v4928 
            #endif
#else
            let v4929 : (System.DateTime -> int64) = _.Ticks
            let v4930 : int64 = v4929 v4869
            let _run_target_args'_v4898 = v4930 
            #endif
            let v4931 : int64 = _run_target_args'_v4898 
            let v5107 : US8 = method12(v4931)
            let v5128 : US4 =
                match v5107 with
                | US8_1(v5125) -> (* Error *)
                    US4_1
                | US8_0(v5123) -> (* Ok *)
                    US4_0(v5123)
            let v5177 : int64 =
                match v5128 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v5174) -> (* Some *)
                    v5174
            let v5196 : int64 = v5177 - v4813
            let v5292 : System.TimeSpan = v5196 |> System.TimeSpan 
            let v5312 : (System.TimeSpan -> int32) = _.Hours
            let v5313 : int32 = v5312 v5292
            let v5333 : (System.TimeSpan -> int32) = _.Minutes
            let v5334 : int32 = v5333 v5292
            let v5354 : (System.TimeSpan -> int32) = _.Seconds
            let v5355 : int32 = v5354 v5292
            let v5375 : (System.TimeSpan -> int32) = _.Milliseconds
            let v5376 : int32 = v5375 v5292
            let v5455 : System.DateTime = System.DateTime (1, 1, 1, v5313, v5334, v5355, v5376)
            v5455
    let v5545 : string = method16()
    let v5573 : bool = v5545 = ""
    let v5575 : string =
        if v5573 then
            let v5574 : string = "M-d-y hh:mm:ss tt"
            v5574
        else
            v5545
    let v5576 : (string -> string) = v5537.ToString
    let v5577 : string = v5576 v5575
    let _run_target_args'_v1753 = v5577 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v5640 : (int64 -> US4) = method14()
    let v5641 : US4 option = v5 |> Option.map v5640 
    let v5725 : US4 = US4_1
    let v5726 : US4 = v5641 |> Option.defaultValue v5725 
    let v6463 : System.DateTime =
        match v5726 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v6421 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6422 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6421 = v6422 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6423 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6421 = v6423 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6432 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v6421 = v6432 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6444 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6421 = v6444 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6445 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6421 = v6445 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6446 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6421 = v6446 
            #endif
#else
            let v6447 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6421 = v6447 
            #endif
            let v6448 : System.DateTime = _run_target_args'_v6421 
            v6448
        | US4_0(v5739) -> (* Some *)
            (* run_target_args'
            let v5768 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5769 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5768 = v5769 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5770 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5768 = v5770 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5779 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v5768 = v5779 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5791 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5768 = v5791 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5792 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5768 = v5792 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5793 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5768 = v5793 
            #endif
#else
            let v5794 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v5768 = v5794 
            #endif
            let v5795 : System.DateTime = _run_target_args'_v5768 
            (* run_target_args'
            let v5824 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5825 : (System.DateTime -> int64) = _.Ticks
            let v5826 : int64 = v5825 v5795
            let _run_target_args'_v5824 = v5826 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5827 : (System.DateTime -> int64) = _.Ticks
            let v5828 : int64 = v5827 v5795
            let _run_target_args'_v5824 = v5828 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5837 : int64 = null |> unbox<int64>
            let _run_target_args'_v5824 = v5837 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5849 : (System.DateTime -> int64) = _.Ticks
            let v5850 : int64 = v5849 v5795
            let _run_target_args'_v5824 = v5850 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5851 : (System.DateTime -> int64) = _.Ticks
            let v5852 : int64 = v5851 v5795
            let _run_target_args'_v5824 = v5852 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5853 : (System.DateTime -> int64) = _.Ticks
            let v5854 : int64 = v5853 v5795
            let _run_target_args'_v5824 = v5854 
            #endif
#else
            let v5855 : (System.DateTime -> int64) = _.Ticks
            let v5856 : int64 = v5855 v5795
            let _run_target_args'_v5824 = v5856 
            #endif
            let v5857 : int64 = _run_target_args'_v5824 
            let v6033 : US8 = method12(v5857)
            let v6054 : US4 =
                match v6033 with
                | US8_1(v6051) -> (* Error *)
                    US4_1
                | US8_0(v6049) -> (* Ok *)
                    US4_0(v6049)
            let v6103 : int64 =
                match v6054 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v6100) -> (* Some *)
                    v6100
            let v6122 : int64 = v6103 - v5739
            let v6218 : System.TimeSpan = v6122 |> System.TimeSpan 
            let v6238 : (System.TimeSpan -> int32) = _.Hours
            let v6239 : int32 = v6238 v6218
            let v6259 : (System.TimeSpan -> int32) = _.Minutes
            let v6260 : int32 = v6259 v6218
            let v6280 : (System.TimeSpan -> int32) = _.Seconds
            let v6281 : int32 = v6280 v6218
            let v6301 : (System.TimeSpan -> int32) = _.Milliseconds
            let v6302 : int32 = v6301 v6218
            let v6381 : System.DateTime = System.DateTime (1, 1, 1, v6239, v6260, v6281, v6302)
            v6381
    let v6471 : string = method16()
    let v6499 : bool = v6471 = ""
    let v6501 : string =
        if v6499 then
            let v6500 : string = "M-d-y hh:mm:ss tt"
            v6500
        else
            v6471
    let v6502 : (string -> string) = v6463.ToString
    let v6503 : string = v6502 v6501
    let _run_target_args'_v1753 = v6503 
    #endif
#else
    let v6566 : (int64 -> US4) = method14()
    let v6567 : US4 option = v5 |> Option.map v6566 
    let v6651 : US4 = US4_1
    let v6652 : US4 = v6567 |> Option.defaultValue v6651 
    let v7389 : System.DateTime =
        match v6652 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v7347 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7348 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v7347 = v7348 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7349 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v7347 = v7349 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7358 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v7347 = v7358 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7370 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v7347 = v7370 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7371 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v7347 = v7371 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7372 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v7347 = v7372 
            #endif
#else
            let v7373 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v7347 = v7373 
            #endif
            let v7374 : System.DateTime = _run_target_args'_v7347 
            v7374
        | US4_0(v6665) -> (* Some *)
            (* run_target_args'
            let v6694 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6695 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6694 = v6695 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6696 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6694 = v6696 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6705 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v6694 = v6705 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6717 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6694 = v6717 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6718 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6694 = v6718 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6719 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6694 = v6719 
            #endif
#else
            let v6720 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v6694 = v6720 
            #endif
            let v6721 : System.DateTime = _run_target_args'_v6694 
            (* run_target_args'
            let v6750 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6751 : (System.DateTime -> int64) = _.Ticks
            let v6752 : int64 = v6751 v6721
            let _run_target_args'_v6750 = v6752 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6753 : (System.DateTime -> int64) = _.Ticks
            let v6754 : int64 = v6753 v6721
            let _run_target_args'_v6750 = v6754 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6763 : int64 = null |> unbox<int64>
            let _run_target_args'_v6750 = v6763 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6775 : (System.DateTime -> int64) = _.Ticks
            let v6776 : int64 = v6775 v6721
            let _run_target_args'_v6750 = v6776 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6777 : (System.DateTime -> int64) = _.Ticks
            let v6778 : int64 = v6777 v6721
            let _run_target_args'_v6750 = v6778 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6779 : (System.DateTime -> int64) = _.Ticks
            let v6780 : int64 = v6779 v6721
            let _run_target_args'_v6750 = v6780 
            #endif
#else
            let v6781 : (System.DateTime -> int64) = _.Ticks
            let v6782 : int64 = v6781 v6721
            let _run_target_args'_v6750 = v6782 
            #endif
            let v6783 : int64 = _run_target_args'_v6750 
            let v6959 : US8 = method12(v6783)
            let v6980 : US4 =
                match v6959 with
                | US8_1(v6977) -> (* Error *)
                    US4_1
                | US8_0(v6975) -> (* Ok *)
                    US4_0(v6975)
            let v7029 : int64 =
                match v6980 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v7026) -> (* Some *)
                    v7026
            let v7048 : int64 = v7029 - v6665
            let v7144 : System.TimeSpan = v7048 |> System.TimeSpan 
            let v7164 : (System.TimeSpan -> int32) = _.Hours
            let v7165 : int32 = v7164 v7144
            let v7185 : (System.TimeSpan -> int32) = _.Minutes
            let v7186 : int32 = v7185 v7144
            let v7206 : (System.TimeSpan -> int32) = _.Seconds
            let v7207 : int32 = v7206 v7144
            let v7227 : (System.TimeSpan -> int32) = _.Milliseconds
            let v7228 : int32 = v7227 v7144
            let v7307 : System.DateTime = System.DateTime (1, 1, 1, v7165, v7186, v7207, v7228)
            v7307
    let v7397 : string = method16()
    let v7425 : bool = v7397 = ""
    let v7427 : string =
        if v7425 then
            let v7426 : string = "M-d-y hh:mm:ss tt"
            v7426
        else
            v7397
    let v7428 : (string -> string) = v7389.ToString
    let v7429 : string = v7428 v7427
    let _run_target_args'_v1753 = v7429 
    #endif
    let v7469 : string = _run_target_args'_v1753 
    v7469
and method19 () : string =
    let v0 : string = ""
    v0
and method20 (v0 : Mut5, v1 : string) : unit =
    let v2 : string = v0.l0
    let v5 : string = v2 + v1 
    v0.l0 <- v5
    ()
and method18 (v0 : char) : string =
    let v1 : string = method19()
    let v12 : Mut5 = {l0 = v1} : Mut5
    let v41 : string = $"{v0}"
    method20(v12, v41)
    let v164 : string = v12.l0
    v164
and method17 () : string =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "inline_colorization::color_bright_blue"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v46 
    let _run_target_args'_v45 = v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v48 
    let _run_target_args'_v45 = v49 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v50 : string = "String::from($0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v50 
    let _run_target_args'_v45 = v51 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v45 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v80 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v45 = v80 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v100 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v45 = v100 
    #endif
#else
    let v120 : std_string_String = v4 |> unbox<std_string_String>
    let _run_target_args'_v45 = v120 
    #endif
    let v132 : std_string_String = _run_target_args'_v45 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v132 v173 
    let _run_target_args'_v2 = v174 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v175 : string = "inline_colorization::color_bright_blue"
    let v176 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v175 
    (* run_target_args'
    let v217 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v218 : string = "String::from($0)"
    let v219 : std_string_String = Fable.Core.RustInterop.emitRustExpr v176 v218 
    let _run_target_args'_v217 = v219 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v220 : string = "String::from($0)"
    let v221 : std_string_String = Fable.Core.RustInterop.emitRustExpr v176 v220 
    let _run_target_args'_v217 = v221 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v222 : string = "String::from($0)"
    let v223 : std_string_String = Fable.Core.RustInterop.emitRustExpr v176 v222 
    let _run_target_args'_v217 = v223 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v232 : std_string_String = v176 |> unbox<std_string_String>
    let _run_target_args'_v217 = v232 
    #endif
#if FABLE_COMPILER_PYTHON
    let v252 : std_string_String = v176 |> unbox<std_string_String>
    let _run_target_args'_v217 = v252 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v272 : std_string_String = v176 |> unbox<std_string_String>
    let _run_target_args'_v217 = v272 
    #endif
#else
    let v292 : std_string_String = v176 |> unbox<std_string_String>
    let _run_target_args'_v217 = v292 
    #endif
    let v304 : std_string_String = _run_target_args'_v217 
    let v345 : string = "fable_library_rust::String_::fromString($0)"
    let v346 : string = Fable.Core.RustInterop.emitRustExpr v304 v345 
    let _run_target_args'_v2 = v346 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v347 : string = "inline_colorization::color_bright_blue"
    let v348 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v347 
    (* run_target_args'
    let v389 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : string = "String::from($0)"
    let v391 : std_string_String = Fable.Core.RustInterop.emitRustExpr v348 v390 
    let _run_target_args'_v389 = v391 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v392 : string = "String::from($0)"
    let v393 : std_string_String = Fable.Core.RustInterop.emitRustExpr v348 v392 
    let _run_target_args'_v389 = v393 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v394 : string = "String::from($0)"
    let v395 : std_string_String = Fable.Core.RustInterop.emitRustExpr v348 v394 
    let _run_target_args'_v389 = v395 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v404 : std_string_String = v348 |> unbox<std_string_String>
    let _run_target_args'_v389 = v404 
    #endif
#if FABLE_COMPILER_PYTHON
    let v424 : std_string_String = v348 |> unbox<std_string_String>
    let _run_target_args'_v389 = v424 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v444 : std_string_String = v348 |> unbox<std_string_String>
    let _run_target_args'_v389 = v444 
    #endif
#else
    let v464 : std_string_String = v348 |> unbox<std_string_String>
    let _run_target_args'_v389 = v464 
    #endif
    let v476 : std_string_String = _run_target_args'_v389 
    let v517 : string = "fable_library_rust::String_::fromString($0)"
    let v518 : string = Fable.Core.RustInterop.emitRustExpr v476 v517 
    let _run_target_args'_v2 = v518 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v519 : string = "\u001b[94m"
    let _run_target_args'_v2 = v519 
    #endif
#if FABLE_COMPILER_PYTHON
    let v520 : string = "\u001b[94m"
    let _run_target_args'_v2 = v520 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v521 : string = "\u001b[94m"
    let _run_target_args'_v2 = v521 
    #endif
#else
    let v522 : string = "\u001b[94m"
    let _run_target_args'_v2 = v522 
    #endif
    let v523 : string = _run_target_args'_v2 
    
    
    
    
    
    let v535 : string = "Debug"
    let v536 : (unit -> string) = v535.ToLower
    let v537 : string = v536 ()
    let v549 : char = v537.[int 0]
    let v550 : string = method18(v549)
    let v553 : string = v523 + v550 
    (* run_target_args'
    let v567 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v568 : string = "inline_colorization::color_reset"
    let v569 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v568 
    (* run_target_args'
    let v610 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v611 : string = "String::from($0)"
    let v612 : std_string_String = Fable.Core.RustInterop.emitRustExpr v569 v611 
    let _run_target_args'_v610 = v612 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v613 : string = "String::from($0)"
    let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr v569 v613 
    let _run_target_args'_v610 = v614 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v615 : string = "String::from($0)"
    let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr v569 v615 
    let _run_target_args'_v610 = v616 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v625 : std_string_String = v569 |> unbox<std_string_String>
    let _run_target_args'_v610 = v625 
    #endif
#if FABLE_COMPILER_PYTHON
    let v645 : std_string_String = v569 |> unbox<std_string_String>
    let _run_target_args'_v610 = v645 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v665 : std_string_String = v569 |> unbox<std_string_String>
    let _run_target_args'_v610 = v665 
    #endif
#else
    let v685 : std_string_String = v569 |> unbox<std_string_String>
    let _run_target_args'_v610 = v685 
    #endif
    let v697 : std_string_String = _run_target_args'_v610 
    let v738 : string = "fable_library_rust::String_::fromString($0)"
    let v739 : string = Fable.Core.RustInterop.emitRustExpr v697 v738 
    let _run_target_args'_v567 = v739 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v740 : string = "inline_colorization::color_reset"
    let v741 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v740 
    (* run_target_args'
    let v782 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v783 : string = "String::from($0)"
    let v784 : std_string_String = Fable.Core.RustInterop.emitRustExpr v741 v783 
    let _run_target_args'_v782 = v784 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v785 : string = "String::from($0)"
    let v786 : std_string_String = Fable.Core.RustInterop.emitRustExpr v741 v785 
    let _run_target_args'_v782 = v786 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v787 : string = "String::from($0)"
    let v788 : std_string_String = Fable.Core.RustInterop.emitRustExpr v741 v787 
    let _run_target_args'_v782 = v788 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v797 : std_string_String = v741 |> unbox<std_string_String>
    let _run_target_args'_v782 = v797 
    #endif
#if FABLE_COMPILER_PYTHON
    let v817 : std_string_String = v741 |> unbox<std_string_String>
    let _run_target_args'_v782 = v817 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v837 : std_string_String = v741 |> unbox<std_string_String>
    let _run_target_args'_v782 = v837 
    #endif
#else
    let v857 : std_string_String = v741 |> unbox<std_string_String>
    let _run_target_args'_v782 = v857 
    #endif
    let v869 : std_string_String = _run_target_args'_v782 
    let v910 : string = "fable_library_rust::String_::fromString($0)"
    let v911 : string = Fable.Core.RustInterop.emitRustExpr v869 v910 
    let _run_target_args'_v567 = v911 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v912 : string = "inline_colorization::color_reset"
    let v913 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v912 
    (* run_target_args'
    let v954 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v955 : string = "String::from($0)"
    let v956 : std_string_String = Fable.Core.RustInterop.emitRustExpr v913 v955 
    let _run_target_args'_v954 = v956 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v957 : string = "String::from($0)"
    let v958 : std_string_String = Fable.Core.RustInterop.emitRustExpr v913 v957 
    let _run_target_args'_v954 = v958 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v959 : string = "String::from($0)"
    let v960 : std_string_String = Fable.Core.RustInterop.emitRustExpr v913 v959 
    let _run_target_args'_v954 = v960 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v969 : std_string_String = v913 |> unbox<std_string_String>
    let _run_target_args'_v954 = v969 
    #endif
#if FABLE_COMPILER_PYTHON
    let v989 : std_string_String = v913 |> unbox<std_string_String>
    let _run_target_args'_v954 = v989 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1009 : std_string_String = v913 |> unbox<std_string_String>
    let _run_target_args'_v954 = v1009 
    #endif
#else
    let v1029 : std_string_String = v913 |> unbox<std_string_String>
    let _run_target_args'_v954 = v1029 
    #endif
    let v1041 : std_string_String = _run_target_args'_v954 
    let v1082 : string = "fable_library_rust::String_::fromString($0)"
    let v1083 : string = Fable.Core.RustInterop.emitRustExpr v1041 v1082 
    let _run_target_args'_v567 = v1083 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1084 : string = "\u001b[0m"
    let _run_target_args'_v567 = v1084 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1085 : string = "\u001b[0m"
    let _run_target_args'_v567 = v1085 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1086 : string = "\u001b[0m"
    let _run_target_args'_v567 = v1086 
    #endif
#else
    let v1087 : string = "\u001b[0m"
    let _run_target_args'_v567 = v1087 
    #endif
    let v1088 : string = _run_target_args'_v567 
    let v1093 : string = v553 + v1088 
    v1093
and method22 (v0 : int64) : string =
    let v1 : string = method19()
    let v12 : Mut5 = {l0 = v1} : Mut5
    let v41 : string = $"{v0}"
    method20(v12, v41)
    let v164 : string = v12.l0
    v164
and method24 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "{ "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method25 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "current_index"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method26 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = " = "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method27 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "; "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method28 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "acc"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method29 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "len"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method30 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "last_item"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method31 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = " }"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method23 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method19()
    let v15 : Mut5 = {l0 = v4} : Mut5
    method24(v15)
    method25(v15)
    method26(v15)
    let v419 : string = $"{v0}"
    method20(v15, v419)
    method27(v15)
    method28(v15)
    method26(v15)
    let v945 : string = $"{v1}"
    method20(v15, v945)
    method27(v15)
    method29(v15)
    method26(v15)
    let v1471 : string = $"{v2}"
    method20(v15, v1471)
    method27(v15)
    method30(v15)
    method26(v15)
    method20(v15, v3)
    method31(v15)
    let v2215 : string = v15.l0
    v2215
and method34 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US10 =
            if v3 then
                US10_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US10_0('\t')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US10_0('\r')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US10_0('\n')
                        else
                            let v14 : int64 = v11 - 1L
                            US10_1
        let v23 : char =
            match v19 with
            | US10_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US10_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method34(v0, v25)
and method33 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = v0.[int v2]
        let v5 : int64 = 0L
        let v6 : bool = method34(v4, v5)
        if v6 then
            let v7 : int32 = v2 + 1
            method33(v0, v1, v7)
        else
            v2
and method36 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US10 =
            if v3 then
                US10_0(' ')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US10_0('/')
                else
                    let v8 : int64 = v5 - 1L
                    US10_1
        let v15 : char =
            match v11 with
            | US10_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US10_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method36(v0, v17)
and method35 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        0
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
        let v5 : int64 = 0L
        let v6 : bool = method36(v4, v5)
        if v6 then
            method35(v0, v3)
        else
            v3
and method32 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method33(v0, v1, v2)
    let v716 : string = v0.[int v3..int v1]
    let v729 : int32 = v716.Length
    let v730 : int32 = method35(v716, v729)
    let v1443 : string = v716.[int 0..int v730]
    v1443
and method21 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : int64 = v0.l0
    let v17 : string = " "
    let v18 : string = v6 + v17 
    let v30 : string = method22(v12)
    let v33 : string = v18 + v30 
    let v47 : string = v33 + v7 
    let v61 : string = v47 + v17 
    let v77 : string = "dice.create_sequential_roller / roll"
    let v78 : string = v61 + v77 
    let v94 : string = " / "
    let v95 : string = v78 + v94 
    let v107 : string = method23(v8, v9, v10, v11)
    let v110 : string = v95 + v107 
    method32(v110)
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
and method37 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure9()
    let v78 : unit = (fun () -> v77 (); v76) ()
    let struct (v159 : Mut1, v160 : Mut3, v161 : Mut4, v162 : Mut5, v163 : Mut6, v164 : int64 option) = TraceState.trace_state.Value
    let v206 : US2 = v163.l0
    let v207 : bool = v161.l0
    let v208 : bool = v207 = false
    let v211 : bool =
        if v208 then
            false
        else
            let v209 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v206
            let v210 : bool = 1 >= v209
            v210
    let v212 : bool = v211 = false
    let v911 : US9 =
        if v212 then
            US9_1
        else
            let v286 : unit = ()
            let v287 : unit = (fun () -> v77 (); v286) ()
            let struct (v368 : Mut1, v369 : Mut3, v370 : Mut4, v371 : Mut5, v372 : Mut6, v373 : int64 option) = TraceState.trace_state.Value
            let v415 : string = method13(v368, v369, v370, v371, v372, v373)
            let v416 : string = method17()
            let v419 : string = $"%A{v3}"
            let v431 : string = method21(v368, v369, v370, v371, v372, v373, v415, v416, v0, v1, v2, v419)
            let v504 : unit = ()
            let v505 : unit = (fun () -> v77 (); v504) ()
            let struct (v586 : Mut1, v587 : Mut3, v588 : Mut4, v589 : Mut5, v590 : Mut6, v591 : int64 option) = TraceState.trace_state.Value
            let v637 : unit = ()
            let v638 : (unit -> unit) = closure17(v586)
            let v639 : unit = (fun () -> v638 (); v637) ()
            let v647 : (string -> unit) = closure18()
            (* run_target_args'
            let v648 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v649 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v431 v649 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v650 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v431 v650 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v651 : string = v589.l0
            let v652 : bool = v651 = ""
            let v688 : string =
                if v652 then
                    v431
                else
                    let v653 : bool = v431 = ""
                    if v653 then
                        let v654 : string = v589.l0
                        v654
                    else
                        let v655 : string = v589.l0
                        let v660 : string = "\n"
                        let v661 : string = v655 + v660 
                        let v675 : string = v661 + v431 
                        v675
            (* run_target_args'
            let v729 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v730 : string = "&*$0"
            let v731 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v688 v730 
            let _run_target_args'_v729 = v731 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v732 : string = "&*$0"
            let v733 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v688 v732 
            let _run_target_args'_v729 = v733 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v734 : string = "&*$0"
            let v735 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v688 v734 
            let _run_target_args'_v729 = v735 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v744 : Ref<Str> = v688 |> unbox<Ref<Str>>
            let _run_target_args'_v729 = v744 
            #endif
#if FABLE_COMPILER_PYTHON
            let v764 : Ref<Str> = v688 |> unbox<Ref<Str>>
            let _run_target_args'_v729 = v764 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v784 : Ref<Str> = v688 |> unbox<Ref<Str>>
            let _run_target_args'_v729 = v784 
            #endif
#else
            let v804 : Ref<Str> = v688 |> unbox<Ref<Str>>
            let _run_target_args'_v729 = v804 
            #endif
            let v816 : Ref<Str> = _run_target_args'_v729 
            let v857 : string = $"$0.chars()"
            let v858 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v816 v857 
            let v859 : string = "$0"
            let v860 : _ = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : string = "$0.collect::<Vec<_>>()"
            let v862 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v860 v861 
            let v863 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v864 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v862 v863 
            let v865 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v866 : bool = Fable.Core.RustInterop.emitRustExpr v864 v865 
            let v867 : string = "x"
            let v868 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v867 
            let v869 : string = "String::from_iter($0)"
            let v870 : std_string_String = Fable.Core.RustInterop.emitRustExpr v868 v869 
            let v871 : string = "true; $0 }).collect::<Vec<_>>()"
            let v872 : bool = Fable.Core.RustInterop.emitRustExpr v870 v871 
            let v873 : string = "_vec_map"
            let v874 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v873 
            let v875 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v876 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v874 v875 
            let v877 : int32 = v876.Length
            let v887 : string = ""
            let v888 : bool = v431 <> v887 
            let v901 : bool =
                if v888 then
                    let v900 : bool = v877 <= 1
                    v900
                else
                    false
            if v901 then
                v589.l0 <- v688
                ()
            else
                v589.l0 <- v887
                let v902 : Mut7 = {l0 = 0} : Mut7
                while method37(v877, v902) do
                    let v904 : int32 = v902.l0
                    let v905 : std_string_String = v876.[int v904]
                    let v906 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v907 : bool = Fable.Core.RustInterop.emitRustExpr v905 v906 
                    let v908 : int32 = v904 + 1
                    v902.l0 <- v908
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v647 v431
            #endif
#if FABLE_COMPILER_PYTHON
            v647 v431
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v647 v431
            #endif
#else
            v647 v431
            #endif
            // run_target_args' is_unit
            let v909 : (string -> unit) = v587.l0
            v909 v431
            US9_0(v586, v587, v588, v589, v590, v591)
    let v964 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v964 
    ()
and method38 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method38(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method40 () : string =
    let v0 : string = method19()
    let v11 : Mut5 = {l0 = v0} : Mut5
    let v12 : string = v11.l0
    v12
and method39 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v26 : string = method22(v8)
    let v29 : string = v14 + v26 
    let v43 : string = v29 + v7 
    let v57 : string = v43 + v13 
    let v73 : string = "dice.create_sequential_roller / roll / None"
    let v74 : string = v57 + v73 
    let v90 : string = " / "
    let v91 : string = v74 + v90 
    let v103 : string = method40()
    let v106 : string = v91 + v103 
    method32(v106)
and closure20 () () : unit =
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure9()
    let v74 : unit = (fun () -> v73 (); v72) ()
    let struct (v155 : Mut1, v156 : Mut3, v157 : Mut4, v158 : Mut5, v159 : Mut6, v160 : int64 option) = TraceState.trace_state.Value
    let v202 : US2 = v159.l0
    let v203 : bool = v157.l0
    let v204 : bool = v203 = false
    let v207 : bool =
        if v204 then
            false
        else
            let v205 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v202
            let v206 : bool = 1 >= v205
            v206
    let v208 : bool = v207 = false
    let v893 : US9 =
        if v208 then
            US9_1
        else
            let v282 : unit = ()
            let v283 : unit = (fun () -> v73 (); v282) ()
            let struct (v364 : Mut1, v365 : Mut3, v366 : Mut4, v367 : Mut5, v368 : Mut6, v369 : int64 option) = TraceState.trace_state.Value
            let v411 : string = method13(v364, v365, v366, v367, v368, v369)
            let v412 : string = method17()
            let v413 : string = method39(v364, v365, v366, v367, v368, v369, v411, v412)
            let v486 : unit = ()
            let v487 : unit = (fun () -> v73 (); v486) ()
            let struct (v568 : Mut1, v569 : Mut3, v570 : Mut4, v571 : Mut5, v572 : Mut6, v573 : int64 option) = TraceState.trace_state.Value
            let v619 : unit = ()
            let v620 : (unit -> unit) = closure17(v568)
            let v621 : unit = (fun () -> v620 (); v619) ()
            let v629 : (string -> unit) = closure18()
            (* run_target_args'
            let v630 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v631 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v413 v631 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v632 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v413 v632 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v633 : string = v571.l0
            let v634 : bool = v633 = ""
            let v670 : string =
                if v634 then
                    v413
                else
                    let v635 : bool = v413 = ""
                    if v635 then
                        let v636 : string = v571.l0
                        v636
                    else
                        let v637 : string = v571.l0
                        let v642 : string = "\n"
                        let v643 : string = v637 + v642 
                        let v657 : string = v643 + v413 
                        v657
            (* run_target_args'
            let v711 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v712 : string = "&*$0"
            let v713 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v670 v712 
            let _run_target_args'_v711 = v713 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v670 v714 
            let _run_target_args'_v711 = v715 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v670 v716 
            let _run_target_args'_v711 = v717 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v726 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v726 
            #endif
#if FABLE_COMPILER_PYTHON
            let v746 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v746 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v766 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v766 
            #endif
#else
            let v786 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v786 
            #endif
            let v798 : Ref<Str> = _run_target_args'_v711 
            let v839 : string = $"$0.chars()"
            let v840 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v798 v839 
            let v841 : string = "$0"
            let v842 : _ = Fable.Core.RustInterop.emitRustExpr v840 v841 
            let v843 : string = "$0.collect::<Vec<_>>()"
            let v844 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v846 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v848 : bool = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "x"
            let v850 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v849 
            let v851 : string = "String::from_iter($0)"
            let v852 : std_string_String = Fable.Core.RustInterop.emitRustExpr v850 v851 
            let v853 : string = "true; $0 }).collect::<Vec<_>>()"
            let v854 : bool = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "_vec_map"
            let v856 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v855 
            let v857 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v858 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v856 v857 
            let v859 : int32 = v858.Length
            let v869 : string = ""
            let v870 : bool = v413 <> v869 
            let v883 : bool =
                if v870 then
                    let v882 : bool = v859 <= 1
                    v882
                else
                    false
            if v883 then
                v571.l0 <- v670
                ()
            else
                v571.l0 <- v869
                let v884 : Mut7 = {l0 = 0} : Mut7
                while method37(v859, v884) do
                    let v886 : int32 = v884.l0
                    let v887 : std_string_String = v858.[int v886]
                    let v888 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v889 : bool = Fable.Core.RustInterop.emitRustExpr v887 v888 
                    let v890 : int32 = v886 + 1
                    v884.l0 <- v890
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v629 v413
            #endif
#if FABLE_COMPILER_PYTHON
            v629 v413
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v629 v413
            #endif
#else
            v629 v413
            #endif
            // run_target_args' is_unit
            let v891 : (string -> unit) = v569.l0
            v891 v413
            US9_0(v568, v569, v570, v571, v572, v573)
    let v946 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v946 
    ()
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US1 = v4.l0
    let v51 : uint8 option =
        match v8 with
        | US1_1 -> (* None *)
            let v38 : uint8 option = None
            v38
        | US1_0(v9) -> (* Some *)
            let v18 : uint8 option = Some v9 
            v18
    let v1933 : unit = ()
    let v1934 : (unit -> unit) = closure8(v5, v6, v7, v51)
    let v1935 : unit = (fun () -> v1934 (); v1933) ()
    let v2911 : UH0 = v0 ()
    let v2912 : int64 = v1.l0
    let v2913 : US1 = method38(v2912, v2911)
    match v2913 with
    | US1_1 -> (* None *)
        let v4771 : unit = ()
        let v4772 : (unit -> unit) = closure20()
        let v4773 : unit = (fun () -> v4772 (); v4771) ()
        let v5735 : int64 = v3.l0
        let v5736 : bool = v5735 = -1L
        if v5736 then
            let v5737 : int64 = v1.l0
            v3.l0 <- v5737
            ()
        let v5738 : int64 = v2.l0
        let v5739 : int64 = v3.l0
        let v5740 : bool = v5738 >= v5739
        let v5743 : int64 =
            if v5740 then
                1L
            else
                let v5741 : int64 = v2.l0
                let v5742 : int64 = v5741 + 1L
                v5742
        v2.l0 <- v5743
        let v5744 : int64 = v2.l0
        let v5745 : int64 = v5744 - 1L
        v1.l0 <- v5745
        let v5746 : US1 = US1_1
        v4.l0 <- v5746
        method5(v0, v1, v2, v3, v4)
    | US1_0(v2914) -> (* Some *)
        let v2915 : int64 = v1.l0
        let v2916 : int64 = v2915 + 1L
        v1.l0 <- v2916
        let v2917 : US1 = US1_0(v2914)
        v4.l0 <- v2917
        v2914
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
and method44 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "max"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method45 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "p"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method46 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "n"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method43 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method19()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method24(v14)
    method44(v14)
    method26(v14)
    let v418 : string = $"{v0}"
    method20(v14, v418)
    method27(v14)
    method45(v14)
    method26(v14)
    let v944 : string = $"{v1}"
    method20(v14, v944)
    method27(v14)
    method46(v14)
    method26(v14)
    let v1470 : string = $"{v2}"
    method20(v14, v1470)
    method31(v14)
    let v1718 : string = v14.l0
    v1718
and method42 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.calculate_dice_count"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method43(v8, v9, v10)
    let v109 : string = v94 + v106 
    method32(v109)
and closure24 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method42(v367, v368, v369, v370, v371, v372, v414, v415, v0, v2, v1)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method41 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint64 = v2 * 6UL
        let v5 : bool = v4 > v2
        if v5 then
            let v6 : int8 = v1 + 1y
            method41(v0, v6, v4)
        else
            let v1861 : unit = ()
            let v1862 : (unit -> unit) = closure24(v0, v1, v2)
            let v1863 : unit = (fun () -> v1862 (); v1861) ()
            v1
    else
        let v4679 : unit = ()
        let v4680 : (unit -> unit) = closure24(v0, v1, v2)
        let v4681 : unit = (fun () -> v4680 (); v4679) ()
        v1
and method51 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "power"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method52 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "result"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method50 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method19()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method24(v14)
    method51(v14)
    method26(v14)
    let v418 : string = $"{v0}"
    method20(v14, v418)
    method27(v14)
    method28(v14)
    method26(v14)
    let v944 : string = $"{v1}"
    method20(v14, v944)
    method27(v14)
    method52(v14)
    method26(v14)
    let v1470 : string = $"{v2}"
    method20(v14, v1470)
    method31(v14)
    let v1718 : string = v14.l0
    v1718
and method49 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method50(v8, v9, v10)
    let v109 : string = v94 + v106 
    method32(v109)
and closure25 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method49(v367, v368, v369, v370, v371, v372, v414, v415, v1, v0, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
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
and method53 (v0 : int8, v1 : UH2) : US12 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US12_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method53(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US12_1
and method56 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "roll"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method57 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v6 : string = "value"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method55 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method19()
    let v15 : Mut5 = {l0 = v4} : Mut5
    method24(v15)
    method51(v15)
    method26(v15)
    let v419 : string = $"{v0}"
    method20(v15, v419)
    method27(v15)
    method28(v15)
    method26(v15)
    let v945 : string = $"{v1}"
    method20(v15, v945)
    method27(v15)
    method56(v15)
    method26(v15)
    let v1471 : string = $"{v2}"
    method20(v15, v1471)
    method27(v15)
    method57(v15)
    method26(v15)
    let v1997 : string = $"{v3}"
    method20(v15, v1997)
    method31(v15)
    let v2245 : string = v15.l0
    v2245
and method54 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : int64 = v0.l0
    let v17 : string = " "
    let v18 : string = v6 + v17 
    let v30 : string = method22(v12)
    let v33 : string = v18 + v30 
    let v47 : string = v33 + v7 
    let v61 : string = v47 + v17 
    let v77 : string = "dice.accumulate_dice_rolls"
    let v78 : string = v61 + v77 
    let v94 : string = " / "
    let v95 : string = v78 + v94 
    let v107 : string = method55(v8, v9, v10, v11)
    let v110 : string = v95 + v107 
    method32(v110)
and closure90 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v76 : unit = ()
    let v77 : (unit -> unit) = closure9()
    let v78 : unit = (fun () -> v77 (); v76) ()
    let struct (v159 : Mut1, v160 : Mut3, v161 : Mut4, v162 : Mut5, v163 : Mut6, v164 : int64 option) = TraceState.trace_state.Value
    let v206 : US2 = v163.l0
    let v207 : bool = v161.l0
    let v208 : bool = v207 = false
    let v211 : bool =
        if v208 then
            false
        else
            let v209 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v206
            let v210 : bool = 1 >= v209
            v210
    let v212 : bool = v211 = false
    let v897 : US9 =
        if v212 then
            US9_1
        else
            let v286 : unit = ()
            let v287 : unit = (fun () -> v77 (); v286) ()
            let struct (v368 : Mut1, v369 : Mut3, v370 : Mut4, v371 : Mut5, v372 : Mut6, v373 : int64 option) = TraceState.trace_state.Value
            let v415 : string = method13(v368, v369, v370, v371, v372, v373)
            let v416 : string = method17()
            let v417 : string = method54(v368, v369, v370, v371, v372, v373, v415, v416, v1, v0, v2, v3)
            let v490 : unit = ()
            let v491 : unit = (fun () -> v77 (); v490) ()
            let struct (v572 : Mut1, v573 : Mut3, v574 : Mut4, v575 : Mut5, v576 : Mut6, v577 : int64 option) = TraceState.trace_state.Value
            let v623 : unit = ()
            let v624 : (unit -> unit) = closure17(v572)
            let v625 : unit = (fun () -> v624 (); v623) ()
            let v633 : (string -> unit) = closure18()
            (* run_target_args'
            let v634 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v417 v635 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v636 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v417 v636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v637 : string = v575.l0
            let v638 : bool = v637 = ""
            let v674 : string =
                if v638 then
                    v417
                else
                    let v639 : bool = v417 = ""
                    if v639 then
                        let v640 : string = v575.l0
                        v640
                    else
                        let v641 : string = v575.l0
                        let v646 : string = "\n"
                        let v647 : string = v641 + v646 
                        let v661 : string = v647 + v417 
                        v661
            (* run_target_args'
            let v715 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v674 v716 
            let _run_target_args'_v715 = v717 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v674 v718 
            let _run_target_args'_v715 = v719 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v720 : string = "&*$0"
            let v721 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v674 v720 
            let _run_target_args'_v715 = v721 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v730 : Ref<Str> = v674 |> unbox<Ref<Str>>
            let _run_target_args'_v715 = v730 
            #endif
#if FABLE_COMPILER_PYTHON
            let v750 : Ref<Str> = v674 |> unbox<Ref<Str>>
            let _run_target_args'_v715 = v750 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v770 : Ref<Str> = v674 |> unbox<Ref<Str>>
            let _run_target_args'_v715 = v770 
            #endif
#else
            let v790 : Ref<Str> = v674 |> unbox<Ref<Str>>
            let _run_target_args'_v715 = v790 
            #endif
            let v802 : Ref<Str> = _run_target_args'_v715 
            let v843 : string = $"$0.chars()"
            let v844 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v802 v843 
            let v845 : string = "$0"
            let v846 : _ = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.collect::<Vec<_>>()"
            let v848 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v850 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v852 : bool = Fable.Core.RustInterop.emitRustExpr v850 v851 
            let v853 : string = "x"
            let v854 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v853 
            let v855 : string = "String::from_iter($0)"
            let v856 : std_string_String = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "true; $0 }).collect::<Vec<_>>()"
            let v858 : bool = Fable.Core.RustInterop.emitRustExpr v856 v857 
            let v859 : string = "_vec_map"
            let v860 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v859 
            let v861 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v862 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v860 v861 
            let v863 : int32 = v862.Length
            let v873 : string = ""
            let v874 : bool = v417 <> v873 
            let v887 : bool =
                if v874 then
                    let v886 : bool = v863 <= 1
                    v886
                else
                    false
            if v887 then
                v575.l0 <- v674
                ()
            else
                v575.l0 <- v873
                let v888 : Mut7 = {l0 = 0} : Mut7
                while method37(v863, v888) do
                    let v890 : int32 = v888.l0
                    let v891 : std_string_String = v862.[int v890]
                    let v892 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v893 : bool = Fable.Core.RustInterop.emitRustExpr v891 v892 
                    let v894 : int32 = v890 + 1
                    v888.l0 <- v894
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v633 v417
            #endif
#if FABLE_COMPILER_PYTHON
            v633 v417
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v633 v417
            #endif
#else
            v633 v417
            #endif
            // run_target_args' is_unit
            let v895 : (string -> unit) = v573.l0
            v895 v417
            US9_0(v572, v573, v574, v575, v576, v577)
    let v950 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v950 
    ()
and method59 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method19()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method24(v14)
    method51(v14)
    method26(v14)
    let v418 : string = $"{v0}"
    method20(v14, v418)
    method27(v14)
    method28(v14)
    method26(v14)
    let v944 : string = $"{v1}"
    method20(v14, v944)
    method27(v14)
    method56(v14)
    method26(v14)
    let v1470 : string = $"{v2}"
    method20(v14, v1470)
    method31(v14)
    let v1718 : string = v14.l0
    v1718
and method58 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : string = method59(v8, v9, v10)
    let v109 : string = v94 + v106 
    method32(v109)
and closure91 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method58(v367, v368, v369, v370, v371, v372, v414, v415, v1, v0, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method48 (v0 : int8, v1 : UH1, v2 : uint64) : US11 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v1858 : unit = ()
        let v1859 : (unit -> unit) = closure25(v2, v0, v4)
        let v1860 : unit = (fun () -> v1859 (); v1858) ()
        US11_0(v4, v1)
    else
        match v1 with
        | UH1_1(v2824, v2825) -> (* Cons *)
            let v2826 : bool = v2824 > 1uy
            if v2826 then
                let v2827 : uint64 = 1UL
                let v2828 : (unit -> UH2) = closure26()
                let v2829 : UH2 = UH2_0(v2827, v2828)
                let v2830 : US12 = method53(v0, v2829)
                let v2834 : uint64 =
                    match v2830 with
                    | US12_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US12_0(v2831) -> (* Some *)
                        v2831
                let v2835 : uint8 = v2824 - 1uy
                let v2836 : uint64 = uint64 v2835
                let v2837 : uint64 = v2836 * v2834
                let v4691 : unit = ()
                let v4692 : (unit -> unit) = closure90(v2, v0, v2824, v2837)
                let v4693 : unit = (fun () -> v4692 (); v4691) ()
                let v5655 : uint64 = v2 + v2837
                let v5656 : int8 = v0 - 1y
                method48(v5656, v2825, v5655)
            else
                let v7511 : unit = ()
                let v7512 : (unit -> unit) = closure91(v2, v0, v2824)
                let v7513 : unit = (fun () -> v7512 (); v7511) ()
                let v8475 : int8 = v0 - 1y
                method48(v8475, v2825, v2)
        | UH1_0 -> (* Nil *)
            US11_1
and method60 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method60(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method61 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method47(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US11 = method48(v3, v4, v10)
        match v11 with
        | US11_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method60(v3, v0, v15)
                    method61(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method47(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method60(v3, v0, v23)
                method61(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method47(v0, v1, v2, v3, v27, v5)
and method47 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method47(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US11 = method48(v3, v4, v12)
        match v13 with
        | US11_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method60(v3, v0, v17)
                    method61(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method47(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method60(v3, v0, v26)
                method61(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method47(v0, v1, v2, v3, v30, v31)
and closure23 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method41(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method47(v0, v1, v2, v8, v9, v10)
and closure22 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure23(v0, v1)
and closure21 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure22(v0)
and method62 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method62(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure93 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method62(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US11 = method48(v4, v1, v5)
    let v16 : US12 =
        match v6 with
        | US11_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US12_0(v7)
            else
                US12_1
        | _ ->
            US12_1
    match v16 with
    | US12_1 -> (* None *)
        let v46 : uint64 option = None
        v46
    | US12_0(v17) -> (* Some *)
        let v26 : uint64 option = Some v17 
        v26
and closure92 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure93(v0)
and method64 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method19()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method24(v14)
    method44(v14)
    method26(v14)
    let v418 : string = $"{v0}"
    method20(v14, v418)
    method27(v14)
    method45(v14)
    method26(v14)
    let v944 : string = $"{v1}"
    method20(v14, v944)
    method27(v14)
    method46(v14)
    method26(v14)
    let v1470 : string = $"{v2}"
    method20(v14, v1470)
    method31(v14)
    let v1718 : string = v14.l0
    v1718
and method63 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v26 : string = method22(v8)
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
    let v106 : string = method64(v103, v104, v105)
    let v109 : string = v91 + v106 
    method32(v109)
and closure95 () () : unit =
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure9()
    let v74 : unit = (fun () -> v73 (); v72) ()
    let struct (v155 : Mut1, v156 : Mut3, v157 : Mut4, v158 : Mut5, v159 : Mut6, v160 : int64 option) = TraceState.trace_state.Value
    let v202 : US2 = v159.l0
    let v203 : bool = v157.l0
    let v204 : bool = v203 = false
    let v207 : bool =
        if v204 then
            false
        else
            let v205 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v202
            let v206 : bool = 1 >= v205
            v206
    let v208 : bool = v207 = false
    let v893 : US9 =
        if v208 then
            US9_1
        else
            let v282 : unit = ()
            let v283 : unit = (fun () -> v73 (); v282) ()
            let struct (v364 : Mut1, v365 : Mut3, v366 : Mut4, v367 : Mut5, v368 : Mut6, v369 : int64 option) = TraceState.trace_state.Value
            let v411 : string = method13(v364, v365, v366, v367, v368, v369)
            let v412 : string = method17()
            let v413 : string = method63(v364, v365, v366, v367, v368, v369, v411, v412)
            let v486 : unit = ()
            let v487 : unit = (fun () -> v73 (); v486) ()
            let struct (v568 : Mut1, v569 : Mut3, v570 : Mut4, v571 : Mut5, v572 : Mut6, v573 : int64 option) = TraceState.trace_state.Value
            let v619 : unit = ()
            let v620 : (unit -> unit) = closure17(v568)
            let v621 : unit = (fun () -> v620 (); v619) ()
            let v629 : (string -> unit) = closure18()
            (* run_target_args'
            let v630 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v631 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v413 v631 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v632 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v413 v632 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v633 : string = v571.l0
            let v634 : bool = v633 = ""
            let v670 : string =
                if v634 then
                    v413
                else
                    let v635 : bool = v413 = ""
                    if v635 then
                        let v636 : string = v571.l0
                        v636
                    else
                        let v637 : string = v571.l0
                        let v642 : string = "\n"
                        let v643 : string = v637 + v642 
                        let v657 : string = v643 + v413 
                        v657
            (* run_target_args'
            let v711 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v712 : string = "&*$0"
            let v713 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v670 v712 
            let _run_target_args'_v711 = v713 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v670 v714 
            let _run_target_args'_v711 = v715 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v670 v716 
            let _run_target_args'_v711 = v717 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v726 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v726 
            #endif
#if FABLE_COMPILER_PYTHON
            let v746 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v746 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v766 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v766 
            #endif
#else
            let v786 : Ref<Str> = v670 |> unbox<Ref<Str>>
            let _run_target_args'_v711 = v786 
            #endif
            let v798 : Ref<Str> = _run_target_args'_v711 
            let v839 : string = $"$0.chars()"
            let v840 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v798 v839 
            let v841 : string = "$0"
            let v842 : _ = Fable.Core.RustInterop.emitRustExpr v840 v841 
            let v843 : string = "$0.collect::<Vec<_>>()"
            let v844 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v846 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v848 : bool = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "x"
            let v850 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v849 
            let v851 : string = "String::from_iter($0)"
            let v852 : std_string_String = Fable.Core.RustInterop.emitRustExpr v850 v851 
            let v853 : string = "true; $0 }).collect::<Vec<_>>()"
            let v854 : bool = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "_vec_map"
            let v856 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v855 
            let v857 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v858 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v856 v857 
            let v859 : int32 = v858.Length
            let v869 : string = ""
            let v870 : bool = v413 <> v869 
            let v883 : bool =
                if v870 then
                    let v882 : bool = v859 <= 1
                    v882
                else
                    false
            if v883 then
                v571.l0 <- v670
                ()
            else
                v571.l0 <- v869
                let v884 : Mut7 = {l0 = 0} : Mut7
                while method37(v859, v884) do
                    let v886 : int32 = v884.l0
                    let v887 : std_string_String = v858.[int v886]
                    let v888 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v889 : bool = Fable.Core.RustInterop.emitRustExpr v887 v888 
                    let v890 : int32 = v886 + 1
                    v884.l0 <- v890
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v629 v413
            #endif
#if FABLE_COMPILER_PYTHON
            v629 v413
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v629 v413
            #endif
#else
            v629 v413
            #endif
            // run_target_args' is_unit
            let v891 : (string -> unit) = v569.l0
            v891 v413
            US9_0(v568, v569, v570, v571, v572, v573)
    let v946 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v946 
    ()
and closure96 () () : int32 =
    let v0 : int32 = 1uy |> int32 
    v0
and closure97 () (v0 : int32) : US13 =
    US13_0(v0)
and closure98 () (v0 : exn) : US13 =
    US13_1(v0)
and method67 () : US13 =
    let v0 : (unit -> int32) = closure96()
    let v1 : (int32 -> US13) = closure97()
    let v2 : ((unit -> exn) -> exn) = closure13()
    let v3 : (exn -> US13) = closure98()
    let v4 : US13 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure99 () () : int32 =
    let v0 : int32 = 7uy |> int32 
    v0
and method68 () : US13 =
    let v0 : (unit -> int32) = closure99()
    let v1 : (int32 -> US13) = closure97()
    let v2 : ((unit -> exn) -> exn) = closure13()
    let v3 : (exn -> US13) = closure98()
    let v4 : US13 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure100 (v0 : int32) () : uint8 =
    let v1 : uint8 = v0 |> uint8 
    v1
and closure101 () (v0 : uint8) : US15 =
    US15_0(v0)
and closure102 () (v0 : exn) : US15 =
    US15_1(v0)
and method69 (v0 : int32) : US15 =
    let v1 : (unit -> uint8) = closure100(v0)
    let v2 : (uint8 -> US15) = closure101()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US15) = closure102()
    let v5 : US15 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method66 () : uint8 =
    (* run_target_args'
    let v1380 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1381 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v1382 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v1381 
    let _run_target_args'_v1380 = v1382 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1383 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v1384 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v1383 
    let _run_target_args'_v1380 = v1384 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1385 : uint8 = failwith<uint8> "common.random' / target=Rust(Contract)"
    let _run_target_args'_v1380 = v1385 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1386 : (unit -> System.Random) = System.Random 
    let v1387 : System.Random = v1386 ()
    let v1518 : US13 = method67()
    let v1539 : US14 =
        match v1518 with
        | US13_1(v1536) -> (* Error *)
            US14_1
        | US13_0(v1534) -> (* Ok *)
            US14_0(v1534)
    let v1588 : int32 =
        match v1539 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v1585) -> (* Some *)
            v1585
    let v1826 : US13 = method68()
    let v1847 : US14 =
        match v1826 with
        | US13_1(v1844) -> (* Error *)
            US14_1
        | US13_0(v1842) -> (* Ok *)
            US14_0(v1842)
    let v1896 : int32 =
        match v1847 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v1893) -> (* Some *)
            v1893
    let v2004 : int32 = v1387.Next (v1588, v1896)
    let v2026 : US15 = method69(v2004)
    let v2047 : US1 =
        match v2026 with
        | US15_1(v2044) -> (* Error *)
            US1_1
        | US15_0(v2042) -> (* Ok *)
            US1_0(v2042)
    let v2096 : uint8 =
        match v2047 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v2093) -> (* Some *)
            v2093
    let _run_target_args'_v1380 = v2096 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2097 : (unit -> System.Random) = System.Random 
    let v2098 : System.Random = v2097 ()
    let v2229 : US13 = method67()
    let v2250 : US14 =
        match v2229 with
        | US13_1(v2247) -> (* Error *)
            US14_1
        | US13_0(v2245) -> (* Ok *)
            US14_0(v2245)
    let v2299 : int32 =
        match v2250 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v2296) -> (* Some *)
            v2296
    let v2537 : US13 = method68()
    let v2558 : US14 =
        match v2537 with
        | US13_1(v2555) -> (* Error *)
            US14_1
        | US13_0(v2553) -> (* Ok *)
            US14_0(v2553)
    let v2607 : int32 =
        match v2558 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v2604) -> (* Some *)
            v2604
    let v2715 : int32 = v2098.Next (v2299, v2607)
    let v2737 : US15 = method69(v2715)
    let v2758 : US1 =
        match v2737 with
        | US15_1(v2755) -> (* Error *)
            US1_1
        | US15_0(v2753) -> (* Ok *)
            US1_0(v2753)
    let v2807 : uint8 =
        match v2758 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v2804) -> (* Some *)
            v2804
    let _run_target_args'_v1380 = v2807 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2808 : (unit -> System.Random) = System.Random 
    let v2809 : System.Random = v2808 ()
    let v2940 : US13 = method67()
    let v2961 : US14 =
        match v2940 with
        | US13_1(v2958) -> (* Error *)
            US14_1
        | US13_0(v2956) -> (* Ok *)
            US14_0(v2956)
    let v3010 : int32 =
        match v2961 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v3007) -> (* Some *)
            v3007
    let v3248 : US13 = method68()
    let v3269 : US14 =
        match v3248 with
        | US13_1(v3266) -> (* Error *)
            US14_1
        | US13_0(v3264) -> (* Ok *)
            US14_0(v3264)
    let v3318 : int32 =
        match v3269 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v3315) -> (* Some *)
            v3315
    let v3426 : int32 = v2809.Next (v3010, v3318)
    let v3448 : US15 = method69(v3426)
    let v3469 : US1 =
        match v3448 with
        | US15_1(v3466) -> (* Error *)
            US1_1
        | US15_0(v3464) -> (* Ok *)
            US1_0(v3464)
    let v3518 : uint8 =
        match v3469 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v3515) -> (* Some *)
            v3515
    let _run_target_args'_v1380 = v3518 
    #endif
#else
    let v3519 : (unit -> System.Random) = System.Random 
    let v3520 : System.Random = v3519 ()
    let v3651 : US13 = method67()
    let v3672 : US14 =
        match v3651 with
        | US13_1(v3669) -> (* Error *)
            US14_1
        | US13_0(v3667) -> (* Ok *)
            US14_0(v3667)
    let v3721 : int32 =
        match v3672 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v3718) -> (* Some *)
            v3718
    let v3959 : US13 = method68()
    let v3980 : US14 =
        match v3959 with
        | US13_1(v3977) -> (* Error *)
            US14_1
        | US13_0(v3975) -> (* Ok *)
            US14_0(v3975)
    let v4029 : int32 =
        match v3980 with
        | US14_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US14_0(v4026) -> (* Some *)
            v4026
    let v4137 : int32 = v3520.Next (v3721, v4029)
    let v4159 : US15 = method69(v4137)
    let v4180 : US1 =
        match v4159 with
        | US15_1(v4177) -> (* Error *)
            US1_1
        | US15_0(v4175) -> (* Ok *)
            US1_0(v4175)
    let v4229 : uint8 =
        match v4180 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v4226) -> (* Some *)
            v4226
    let _run_target_args'_v1380 = v4229 
    #endif
    let v4230 : uint8 = _run_target_args'_v1380 
    v4230
and method72 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method19()
    let v15 : Mut5 = {l0 = v4} : Mut5
    method24(v15)
    method51(v15)
    method26(v15)
    let v419 : string = $"{v0}"
    method20(v15, v419)
    method27(v15)
    method28(v15)
    method26(v15)
    let v945 : string = $"{v1}"
    method20(v15, v945)
    method27(v15)
    method56(v15)
    method26(v15)
    let v1471 : string = $"{v2}"
    method20(v15, v1471)
    method27(v15)
    method57(v15)
    method26(v15)
    let v1997 : string = $"{v3}"
    method20(v15, v1997)
    method31(v15)
    let v2245 : string = v15.l0
    v2245
and method71 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 23y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure103 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method71(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method74 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 22y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure104 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method74(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method76 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 21y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure105 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method76(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method78 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 20y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method78(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method80 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 19y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method80(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method82 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 18y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method82(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method84 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 17y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method84(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method86 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 16y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method86(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method88 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 15y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method88(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method90 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 14y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method90(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method92 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 13y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method92(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method94 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 12y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method94(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method96 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 11y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method96(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method98 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 10y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method98(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method100 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 9y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure117 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method100(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 8y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure118 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method102(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 7y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure119 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method104(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 6y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure120 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method106(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 5y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure121 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method108(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 4y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure122 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method110(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 3y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure123 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method112(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method114 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 2y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure124 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method114(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method116 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 1y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure125 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method116(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method118 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v29 : string = method22(v11)
    let v32 : string = v17 + v29 
    let v46 : string = v32 + v7 
    let v60 : string = v46 + v16 
    let v76 : string = "dice.accumulate_dice_rolls"
    let v77 : string = v60 + v76 
    let v93 : string = " / "
    let v94 : string = v77 + v93 
    let v106 : int8 = 0y
    let v107 : string = method72(v106, v8, v9, v10)
    let v110 : string = v94 + v107 
    method32(v110)
and closure126 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure9()
    let v77 : unit = (fun () -> v76 (); v75) ()
    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = TraceState.trace_state.Value
    let v205 : US2 = v162.l0
    let v206 : bool = v160.l0
    let v207 : bool = v206 = false
    let v210 : bool =
        if v207 then
            false
        else
            let v208 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v205
            let v209 : bool = 1 >= v208
            v209
    let v211 : bool = v210 = false
    let v896 : US9 =
        if v211 then
            US9_1
        else
            let v285 : unit = ()
            let v286 : unit = (fun () -> v76 (); v285) ()
            let struct (v367 : Mut1, v368 : Mut3, v369 : Mut4, v370 : Mut5, v371 : Mut6, v372 : int64 option) = TraceState.trace_state.Value
            let v414 : string = method13(v367, v368, v369, v370, v371, v372)
            let v415 : string = method17()
            let v416 : string = method118(v367, v368, v369, v370, v371, v372, v414, v415, v0, v1, v2)
            let v489 : unit = ()
            let v490 : unit = (fun () -> v76 (); v489) ()
            let struct (v571 : Mut1, v572 : Mut3, v573 : Mut4, v574 : Mut5, v575 : Mut6, v576 : int64 option) = TraceState.trace_state.Value
            let v622 : unit = ()
            let v623 : (unit -> unit) = closure17(v571)
            let v624 : unit = (fun () -> v623 (); v622) ()
            let v632 : (string -> unit) = closure18()
            (* run_target_args'
            let v633 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v635 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v416 v635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v636 : string = v574.l0
            let v637 : bool = v636 = ""
            let v673 : string =
                if v637 then
                    v416
                else
                    let v638 : bool = v416 = ""
                    if v638 then
                        let v639 : string = v574.l0
                        v639
                    else
                        let v640 : string = v574.l0
                        let v645 : string = "\n"
                        let v646 : string = v640 + v645 
                        let v660 : string = v646 + v416 
                        v660
            (* run_target_args'
            let v714 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v715 
            let _run_target_args'_v714 = v716 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v717 
            let _run_target_args'_v714 = v718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v719 : string = "&*$0"
            let v720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v673 v719 
            let _run_target_args'_v714 = v720 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v769 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v769 
            #endif
#else
            let v789 : Ref<Str> = v673 |> unbox<Ref<Str>>
            let _run_target_args'_v714 = v789 
            #endif
            let v801 : Ref<Str> = _run_target_args'_v714 
            let v842 : string = $"$0.chars()"
            let v843 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v801 v842 
            let v844 : string = "$0"
            let v845 : _ = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.collect::<Vec<_>>()"
            let v847 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v849 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v852 : string = "x"
            let v853 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v852 
            let v854 : string = "String::from_iter($0)"
            let v855 : std_string_String = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "true; $0 }).collect::<Vec<_>>()"
            let v857 : bool = Fable.Core.RustInterop.emitRustExpr v855 v856 
            let v858 : string = "_vec_map"
            let v859 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v858 
            let v860 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v861 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v859 v860 
            let v862 : int32 = v861.Length
            let v872 : string = ""
            let v873 : bool = v416 <> v872 
            let v886 : bool =
                if v873 then
                    let v885 : bool = v862 <= 1
                    v885
                else
                    false
            if v886 then
                v574.l0 <- v673
                ()
            else
                v574.l0 <- v872
                let v887 : Mut7 = {l0 = 0} : Mut7
                while method37(v862, v887) do
                    let v889 : int32 = v887.l0
                    let v890 : std_string_String = v861.[int v889]
                    let v891 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v890 v891 
                    let v893 : int32 = v889 + 1
                    v887.l0 <- v893
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v632 v416
            #endif
#if FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v632 v416
            #endif
#else
            v632 v416
            #endif
            // run_target_args' is_unit
            let v894 : (string -> unit) = v572.l0
            v894 v416
            US9_0(v571, v572, v573, v574, v575, v576)
    let v949 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v949 
    ()
and method121 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method19()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method24(v14)
    method51(v14)
    method26(v14)
    let v418 : string = $"{v0}"
    method20(v14, v418)
    method27(v14)
    method28(v14)
    method26(v14)
    let v944 : string = $"{v1}"
    method20(v14, v944)
    method27(v14)
    method52(v14)
    method26(v14)
    let v1470 : string = $"{v2}"
    method20(v14, v1470)
    method31(v14)
    let v1718 : string = v14.l0
    v1718
and method120 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = -1y
    let v106 : string = method121(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure127 (v0 : int64, v1 : int64) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method120(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method119 (v0 : UH1, v1 : int64) : US16 =
    let v2 : int64 = v1 + 1L
    let v1856 : unit = ()
    let v1857 : (unit -> unit) = closure127(v1, v2)
    let v1858 : unit = (fun () -> v1857 (); v1856) ()
    US16_0(v2, v0)
and method123 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method19()
    let v14 : Mut5 = {l0 = v3} : Mut5
    method24(v14)
    method51(v14)
    method26(v14)
    let v418 : string = $"{v0}"
    method20(v14, v418)
    method27(v14)
    method28(v14)
    method26(v14)
    let v944 : string = $"{v1}"
    method20(v14, v944)
    method27(v14)
    method56(v14)
    method26(v14)
    let v1470 : string = $"{v2}"
    method20(v14, v1470)
    method31(v14)
    let v1718 : string = v14.l0
    v1718
and method122 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 0y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure128 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method122(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method117 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v1861 : unit = ()
            let v1862 : (unit -> unit) = closure126(v1, v3, v7)
            let v1863 : unit = (fun () -> v1862 (); v1861) ()
            let v2825 : int64 = v1 + v7
            method119(v4, v2825)
        else
            let v4680 : unit = ()
            let v4681 : (unit -> unit) = closure128(v1, v3)
            let v4682 : unit = (fun () -> v4681 (); v4680) ()
            method119(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method124 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 1y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure129 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method124(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method115 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure125(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method117(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure129(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method117(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method125 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 2y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure130 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method125(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method113 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure124(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method115(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure130(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method115(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method126 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 3y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method126(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method111 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure123(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method113(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure131(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method113(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method127 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 4y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method127(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method109 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure122(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method111(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure132(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method111(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method128 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 5y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method128(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method107 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure121(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method109(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure133(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method109(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method129 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 6y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method129(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method105 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure120(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method107(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure134(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method107(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method130 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 7y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method130(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method103 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure119(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method105(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure135(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method105(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method131 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 8y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method131(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method101 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure118(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method103(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure136(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method103(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method132 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 9y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method132(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method99 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure117(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method101(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure137(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method101(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method133 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 10y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method133(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method97 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure116(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method99(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure138(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method99(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method134 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 11y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method134(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method95 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure115(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method97(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure139(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method97(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method135 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 12y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method135(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method93 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure114(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method95(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure140(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method95(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method136 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 13y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method136(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method91 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure113(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method93(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure141(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method93(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method137 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 14y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure142 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method137(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method89 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure112(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method91(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure142(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method91(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method138 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 15y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure143 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method138(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method87 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure111(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method89(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure143(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method89(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method139 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 16y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure144 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method139(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method85 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure110(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method87(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure144(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method87(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method140 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 17y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure145 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method140(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method83 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure109(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method85(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure145(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method85(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method141 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 18y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure146 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method141(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method81 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure108(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method83(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure146(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method83(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method142 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 19y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure147 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method142(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method79 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure107(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method81(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure147(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method81(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method143 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 20y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure148 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method143(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method77 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure106(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method79(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure148(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method79(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method144 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 21y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure149 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method144(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method75 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure105(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method77(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure149(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method77(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method145 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 22y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure150 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method145(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method73 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure104(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method75(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure150(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method75(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method146 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v28 : string = method22(v10)
    let v31 : string = v16 + v28 
    let v45 : string = v31 + v7 
    let v59 : string = v45 + v15 
    let v75 : string = "dice.accumulate_dice_rolls"
    let v76 : string = v59 + v75 
    let v92 : string = " / "
    let v93 : string = v76 + v92 
    let v105 : int8 = 23y
    let v106 : string = method123(v105, v8, v9)
    let v109 : string = v93 + v106 
    method32(v109)
and closure151 (v0 : int64, v1 : uint8) () : unit =
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure9()
    let v76 : unit = (fun () -> v75 (); v74) ()
    let struct (v157 : Mut1, v158 : Mut3, v159 : Mut4, v160 : Mut5, v161 : Mut6, v162 : int64 option) = TraceState.trace_state.Value
    let v204 : US2 = v161.l0
    let v205 : bool = v159.l0
    let v206 : bool = v205 = false
    let v209 : bool =
        if v206 then
            false
        else
            let v207 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v204
            let v208 : bool = 1 >= v207
            v208
    let v210 : bool = v209 = false
    let v895 : US9 =
        if v210 then
            US9_1
        else
            let v284 : unit = ()
            let v285 : unit = (fun () -> v75 (); v284) ()
            let struct (v366 : Mut1, v367 : Mut3, v368 : Mut4, v369 : Mut5, v370 : Mut6, v371 : int64 option) = TraceState.trace_state.Value
            let v413 : string = method13(v366, v367, v368, v369, v370, v371)
            let v414 : string = method17()
            let v415 : string = method146(v366, v367, v368, v369, v370, v371, v413, v414, v0, v1)
            let v488 : unit = ()
            let v489 : unit = (fun () -> v75 (); v488) ()
            let struct (v570 : Mut1, v571 : Mut3, v572 : Mut4, v573 : Mut5, v574 : Mut6, v575 : int64 option) = TraceState.trace_state.Value
            let v621 : unit = ()
            let v622 : (unit -> unit) = closure17(v570)
            let v623 : unit = (fun () -> v622 (); v621) ()
            let v631 : (string -> unit) = closure18()
            (* run_target_args'
            let v632 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v634 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v415 v634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v635 : string = v573.l0
            let v636 : bool = v635 = ""
            let v672 : string =
                if v636 then
                    v415
                else
                    let v637 : bool = v415 = ""
                    if v637 then
                        let v638 : string = v573.l0
                        v638
                    else
                        let v639 : string = v573.l0
                        let v644 : string = "\n"
                        let v645 : string = v639 + v644 
                        let v659 : string = v645 + v415 
                        v659
            (* run_target_args'
            let v713 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v714 : string = "&*$0"
            let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v714 
            let _run_target_args'_v713 = v715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v716 
            let _run_target_args'_v713 = v717 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v718 : string = "&*$0"
            let v719 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v672 v718 
            let _run_target_args'_v713 = v719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v748 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v768 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v768 
            #endif
#else
            let v788 : Ref<Str> = v672 |> unbox<Ref<Str>>
            let _run_target_args'_v713 = v788 
            #endif
            let v800 : Ref<Str> = _run_target_args'_v713 
            let v841 : string = $"$0.chars()"
            let v842 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v800 v841 
            let v843 : string = "$0"
            let v844 : _ = Fable.Core.RustInterop.emitRustExpr v842 v843 
            let v845 : string = "$0.collect::<Vec<_>>()"
            let v846 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v844 v845 
            let v847 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v848 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v849 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849 
            let v851 : string = "x"
            let v852 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "String::from_iter($0)"
            let v854 : std_string_String = Fable.Core.RustInterop.emitRustExpr v852 v853 
            let v855 : string = "true; $0 }).collect::<Vec<_>>()"
            let v856 : bool = Fable.Core.RustInterop.emitRustExpr v854 v855 
            let v857 : string = "_vec_map"
            let v858 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v857 
            let v859 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v860 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v858 v859 
            let v861 : int32 = v860.Length
            let v871 : string = ""
            let v872 : bool = v415 <> v871 
            let v885 : bool =
                if v872 then
                    let v884 : bool = v861 <= 1
                    v884
                else
                    false
            if v885 then
                v573.l0 <- v672
                ()
            else
                v573.l0 <- v871
                let v886 : Mut7 = {l0 = 0} : Mut7
                while method37(v861, v886) do
                    let v888 : int32 = v886.l0
                    let v889 : std_string_String = v860.[int v888]
                    let v890 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v891 : bool = Fable.Core.RustInterop.emitRustExpr v889 v890 
                    let v892 : int32 = v888 + 1
                    v886.l0 <- v892
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v631 v415
            #endif
#if FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v631 v415
            #endif
#else
            v631 v415
            #endif
            // run_target_args' is_unit
            let v893 : (string -> unit) = v571.l0
            v893 v415
            US9_0(v570, v571, v572, v573, v574, v575)
    let v948 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v948 
    ()
and method70 (v0 : UH1, v1 : int64) : US16 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v1862 : unit = ()
            let v1863 : (unit -> unit) = closure103(v1, v3, v8)
            let v1864 : unit = (fun () -> v1863 (); v1862) ()
            let v2826 : int64 = v1 + v8
            method73(v4, v2826)
        else
            let v4681 : unit = ()
            let v4682 : (unit -> unit) = closure151(v1, v3)
            let v4683 : unit = (fun () -> v4682 (); v4681) ()
            method73(v4, v1)
    | UH1_0 -> (* Nil *)
        US16_1
and method65 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method66()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method65(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US16 = method70(v0, v7)
        match v8 with
        | US16_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method66()
                let v13 : uint8 = method66()
                let v14 : uint8 = method66()
                let v15 : uint8 = method66()
                let v16 : uint8 = method66()
                let v17 : uint8 = method66()
                let v18 : uint8 = method66()
                let v19 : uint8 = method66()
                let v20 : uint8 = method66()
                let v21 : uint8 = method66()
                let v22 : uint8 = method66()
                let v23 : uint8 = method66()
                let v24 : uint8 = method66()
                let v25 : uint8 = method66()
                let v26 : uint8 = method66()
                let v27 : uint8 = method66()
                let v28 : uint8 = method66()
                let v29 : uint8 = method66()
                let v30 : uint8 = method66()
                let v31 : uint8 = method66()
                let v32 : uint8 = method66()
                let v33 : uint8 = method66()
                let v34 : uint8 = method66()
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
                method65(v58, v59)
        | _ ->
            let v62 : uint8 = method66()
            let v63 : uint8 = method66()
            let v64 : uint8 = method66()
            let v65 : uint8 = method66()
            let v66 : uint8 = method66()
            let v67 : uint8 = method66()
            let v68 : uint8 = method66()
            let v69 : uint8 = method66()
            let v70 : uint8 = method66()
            let v71 : uint8 = method66()
            let v72 : uint8 = method66()
            let v73 : uint8 = method66()
            let v74 : uint8 = method66()
            let v75 : uint8 = method66()
            let v76 : uint8 = method66()
            let v77 : uint8 = method66()
            let v78 : uint8 = method66()
            let v79 : uint8 = method66()
            let v80 : uint8 = method66()
            let v81 : uint8 = method66()
            let v82 : uint8 = method66()
            let v83 : uint8 = method66()
            let v84 : uint8 = method66()
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
            method65(v108, v109)
and method148 (v0 : int64) : string =
    let v1 : string = method19()
    let v12 : Mut5 = {l0 = v1} : Mut5
    method24(v12)
    method52(v12)
    method26(v12)
    let v416 : string = $"{v0}"
    method20(v12, v416)
    method31(v12)
    let v664 : string = v12.l0
    v664
and method147 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : int64 = v0.l0
    let v14 : string = " "
    let v15 : string = v6 + v14 
    let v27 : string = method22(v9)
    let v30 : string = v15 + v27 
    let v44 : string = v30 + v7 
    let v58 : string = v44 + v14 
    let v74 : string = "dice.main"
    let v75 : string = v58 + v74 
    let v91 : string = " / "
    let v92 : string = v75 + v91 
    let v104 : string = method148(v8)
    let v107 : string = v92 + v104 
    method32(v107)
and closure152 (v0 : int64) () : unit =
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure9()
    let v75 : unit = (fun () -> v74 (); v73) ()
    let struct (v156 : Mut1, v157 : Mut3, v158 : Mut4, v159 : Mut5, v160 : Mut6, v161 : int64 option) = TraceState.trace_state.Value
    let v203 : US2 = v160.l0
    let v204 : bool = v158.l0
    let v205 : bool = v204 = false
    let v208 : bool =
        if v205 then
            false
        else
            let v206 : int32 = [ US2_0, 0; US2_1, 1; US2_2, 2; US2_3, 3; US2_4, 4 ] |> Map |> Map.find v203
            let v207 : bool = 1 >= v206
            v207
    let v209 : bool = v208 = false
    let v894 : US9 =
        if v209 then
            US9_1
        else
            let v283 : unit = ()
            let v284 : unit = (fun () -> v74 (); v283) ()
            let struct (v365 : Mut1, v366 : Mut3, v367 : Mut4, v368 : Mut5, v369 : Mut6, v370 : int64 option) = TraceState.trace_state.Value
            let v412 : string = method13(v365, v366, v367, v368, v369, v370)
            let v413 : string = method17()
            let v414 : string = method147(v365, v366, v367, v368, v369, v370, v412, v413, v0)
            let v487 : unit = ()
            let v488 : unit = (fun () -> v74 (); v487) ()
            let struct (v569 : Mut1, v570 : Mut3, v571 : Mut4, v572 : Mut5, v573 : Mut6, v574 : int64 option) = TraceState.trace_state.Value
            let v620 : unit = ()
            let v621 : (unit -> unit) = closure17(v569)
            let v622 : unit = (fun () -> v621 (); v620) ()
            let v630 : (string -> unit) = closure18()
            (* run_target_args'
            let v631 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v632 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v414 v632 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v633 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v414 v633 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v634 : string = v572.l0
            let v635 : bool = v634 = ""
            let v671 : string =
                if v635 then
                    v414
                else
                    let v636 : bool = v414 = ""
                    if v636 then
                        let v637 : string = v572.l0
                        v637
                    else
                        let v638 : string = v572.l0
                        let v643 : string = "\n"
                        let v644 : string = v638 + v643 
                        let v658 : string = v644 + v414 
                        v658
            (* run_target_args'
            let v712 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v713 : string = "&*$0"
            let v714 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v671 v713 
            let _run_target_args'_v712 = v714 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v715 : string = "&*$0"
            let v716 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v671 v715 
            let _run_target_args'_v712 = v716 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v717 : string = "&*$0"
            let v718 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v671 v717 
            let _run_target_args'_v712 = v718 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v727 : Ref<Str> = v671 |> unbox<Ref<Str>>
            let _run_target_args'_v712 = v727 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : Ref<Str> = v671 |> unbox<Ref<Str>>
            let _run_target_args'_v712 = v747 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v767 : Ref<Str> = v671 |> unbox<Ref<Str>>
            let _run_target_args'_v712 = v767 
            #endif
#else
            let v787 : Ref<Str> = v671 |> unbox<Ref<Str>>
            let _run_target_args'_v712 = v787 
            #endif
            let v799 : Ref<Str> = _run_target_args'_v712 
            let v840 : string = $"$0.chars()"
            let v841 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v799 v840 
            let v842 : string = "$0"
            let v843 : _ = Fable.Core.RustInterop.emitRustExpr v841 v842 
            let v844 : string = "$0.collect::<Vec<_>>()"
            let v845 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v843 v844 
            let v846 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v847 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v848 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v849 : bool = Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v850 : string = "x"
            let v851 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v850 
            let v852 : string = "String::from_iter($0)"
            let v853 : std_string_String = Fable.Core.RustInterop.emitRustExpr v851 v852 
            let v854 : string = "true; $0 }).collect::<Vec<_>>()"
            let v855 : bool = Fable.Core.RustInterop.emitRustExpr v853 v854 
            let v856 : string = "_vec_map"
            let v857 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v856 
            let v858 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v859 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v857 v858 
            let v860 : int32 = v859.Length
            let v870 : string = ""
            let v871 : bool = v414 <> v870 
            let v884 : bool =
                if v871 then
                    let v883 : bool = v860 <= 1
                    v883
                else
                    false
            if v884 then
                v572.l0 <- v671
                ()
            else
                v572.l0 <- v870
                let v885 : Mut7 = {l0 = 0} : Mut7
                while method37(v860, v885) do
                    let v887 : int32 = v885.l0
                    let v888 : std_string_String = v859.[int v887]
                    let v889 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v890 : bool = Fable.Core.RustInterop.emitRustExpr v888 v889 
                    let v891 : int32 = v887 + 1
                    v885.l0 <- v891
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v630 v414
            #endif
#if FABLE_COMPILER_PYTHON
            v630 v414
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v630 v414
            #endif
#else
            v630 v414
            #endif
            // run_target_args' is_unit
            let v892 : (string -> unit) = v570.l0
            v892 v414
            US9_0(v569, v570, v571, v572, v573, v574)
    let v947 : string = "Fsharp"
    // base.backend_switch / record_type_try_find / key: v947 
    ()
and closure94 () (v0 : (string [])) : int32 =
    let v1854 : unit = ()
    let v1855 : (unit -> unit) = closure95()
    let v1856 : unit = (fun () -> v1855 (); v1854) ()
    let v2818 : UH1 = UH1_0
    let v2819 : int8 = 0y
    let v2820 : int64 = method65(v2818, v2819)
    let v4674 : unit = ()
    let v4675 : (unit -> unit) = closure152(v2820)
    let v4676 : unit = (fun () -> v4675 (); v4674) ()
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
