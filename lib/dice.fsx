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
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
and Mut7 = {mutable l0 : int32; mutable l1 : US3}
and [<Struct>] US9 =
    | US9_0 of f0_0 : int64
    | US9_1 of f1_0 : exn
and [<Struct>] US10 =
    | US10_0 of f0_0 : int64
    | US10_1
and [<Struct>] US11 =
    | US11_0 of f0_0 : int64
    | US11_1 of f1_0 : exn
and [<Struct>] US12 =
    | US12_0 of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut5 * f0_4 : Mut6 * f0_5 : int64 option
    | US12_1
and Mut8 = {mutable l0 : int32}
and [<Struct>] US13 =
    | US13_0 of f0_0 : uint64 * f0_1 : UH1
    | US13_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US14 =
    | US14_0 of f0_0 : uint64
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : int32
    | US15_1 of f1_0 : exn
and [<Struct>] US16 =
    | US16_0 of f0_0 : int32
    | US16_1
and [<Struct>] US17 =
    | US17_0 of f0_0 : uint8
    | US17_1 of f1_0 : exn
and [<Struct>] US18 =
    | US18_0 of f0_0 : int64 * f0_1 : UH1
    | US18_1
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
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : US7) : string =
    let v1 : string = method13()
    let v18 : Mut5 = {l0 = v1} : Mut5
    let v21 : string = $"%A{v0}"
    method14(v18, v21)
    let v66 : string = v18.l0
    v66
and method15 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut5 = {l0 = v1} : Mut5
    method14(v2, v0)
    let v3 : string = v2.l0
    v3
and method11 (v0 : string) : string =
    let v1 : US5 = US5_0
    let v2 : US6 = US6_0(v1)
    let v3 : US7 = US7_5(v2)
    let v4 : string = method12(v3)
    let v9 : string = "env.get_environment_variable / target: "
    let v10 : string = v9 + v4 
    let v22 : string = " / var: "
    let v23 : string = v10 + v22 
    let v31 : string = method15(v0)
    let v32 : string = v23 + v31 
    failwith<string> v32
and method16 (v0 : string) : string =
    let v1 : US5 = US5_1
    let v2 : US6 = US6_0(v1)
    let v3 : US7 = US7_5(v2)
    let v4 : string = method12(v3)
    let v5 : string = "env.get_environment_variable / target: "
    let v6 : string = v5 + v4 
    let v7 : string = " / var: "
    let v8 : string = v6 + v7 
    let v9 : string = method15(v0)
    let v10 : string = v8 + v9 
    failwith<string> v10
and closure10 () (v0 : string) : US8 =
    US8_0(v0)
and method17 () : (string -> US8) =
    closure10()
and method8 (v0 : string) : string =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method9(v0)
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result_map_"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method10()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = method11(v0)
    let _run_target_args'_v2 = v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : string = method16(v0)
    let _run_target_args'_v2 = v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : string = "process.env[$0] ?? \"\""
    let v22 : string = Fable.Core.JsInterop.emitJsExpr v0 v21 
    let _run_target_args'_v2 = v22 
    #endif
#else
    let v23 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v24 : string = v23 v0
    let mutable _v24 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v25 : (string -> string option) = Option.ofObj
    let v26 : string option = v25 v24
    v26 
    #else
    Some v24 
    #endif
    |> fun x -> _v24 <- Some x
    let v27 : string option = match _v24 with Some x -> x | None -> failwith "optionm'.of_obj / _v24=None"
    let v28 : (string -> US8) = method17()
    let v29 : US8 option = v27 |> Option.map v28 
    let v30 : US8 = US8_1
    let v31 : US8 = v29 |> Option.defaultValue v30 
    let v35 : string =
        match v31 with
        | US8_1 -> (* None *)
            let v33 : string = ""
            v33
        | US8_0(v32) -> (* Some *)
            v32
    let _run_target_args'_v2 = v35 
    #endif
    let v36 : string = _run_target_args'_v2 
    v36
and method18 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure11 (v0 : float) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure12 () (v0 : int64) : US9 =
    US9_0(v0)
and closure13 () (v0 : (unit -> exn)) : exn =
    v0 ()
and closure14 () (v0 : exn) : US9 =
    US9_1(v0)
and method19 (v0 : float) : US9 =
    let v1 : (unit -> int64) = closure11(v0)
    let v2 : (int64 -> US9) = closure12()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US9) = closure14()
    let v5 : US9 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and closure15 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure16 () (v0 : int64) : US11 =
    US11_0(v0)
and closure17 () (v0 : exn) : US11 =
    US11_1(v0)
and method20 (v0 : int64) : US11 =
    let v1 : (unit -> int64) = closure15(v0)
    let v2 : (int64 -> US11) = closure16()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US11) = closure17()
    let v5 : US11 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method7 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method8(v0)
    
    
    
    
    
    let v2 : string = "Critical"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v5 : string = "Warning"
    let v6 : (unit -> string) = v5.ToLower
    let v7 : string = v6 ()
    let v8 : string = "Info"
    let v9 : (unit -> string) = v8.ToLower
    let v10 : string = v9 ()
    let v11 : string = "Debug"
    let v12 : (unit -> string) = v11.ToLower
    let v13 : string = v12 ()
    let v14 : string = "Verbose"
    let v15 : (unit -> string) = v14.ToLower
    let v16 : string = v15 ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : struct (string * US2) list = []
    let v19 : US2 = US2_4
    let v20 : struct (string * US2) list = struct (v4, v19) :: v18 
    let v21 : US2 = US2_3
    let v22 : struct (string * US2) list = struct (v7, v21) :: v20 
    let v23 : US2 = US2_2
    let v24 : struct (string * US2) list = struct (v10, v23) :: v22 
    let v25 : US2 = US2_1
    let v26 : struct (string * US2) list = struct (v13, v25) :: v24 
    let v27 : US2 = US2_0
    let v28 : struct (string * US2) list = struct (v16, v27) :: v26 
    let v29 : US2 = US2_4
    let v30 : struct (string * US2) list = struct (v2, v29) :: v28 
    let v31 : US2 = US2_3
    let v32 : struct (string * US2) list = struct (v5, v31) :: v30 
    let v33 : US2 = US2_2
    let v34 : struct (string * US2) list = struct (v8, v33) :: v32 
    let v35 : US2 = US2_1
    let v36 : struct (string * US2) list = struct (v11, v35) :: v34 
    let v37 : US2 = US2_0
    let v38 : struct (string * US2) list = struct (v14, v37) :: v36 
    let _run_target_args'_v17 = v38 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v39 : struct (string * US2) list = []
    let v40 : US2 = US2_4
    let v41 : struct (string * US2) list = struct (v4, v40) :: v39 
    let v42 : US2 = US2_3
    let v43 : struct (string * US2) list = struct (v7, v42) :: v41 
    let v44 : US2 = US2_2
    let v45 : struct (string * US2) list = struct (v10, v44) :: v43 
    let v46 : US2 = US2_1
    let v47 : struct (string * US2) list = struct (v13, v46) :: v45 
    let v48 : US2 = US2_0
    let v49 : struct (string * US2) list = struct (v16, v48) :: v47 
    let v50 : US2 = US2_4
    let v51 : struct (string * US2) list = struct (v2, v50) :: v49 
    let v52 : US2 = US2_3
    let v53 : struct (string * US2) list = struct (v5, v52) :: v51 
    let v54 : US2 = US2_2
    let v55 : struct (string * US2) list = struct (v8, v54) :: v53 
    let v56 : US2 = US2_1
    let v57 : struct (string * US2) list = struct (v11, v56) :: v55 
    let v58 : US2 = US2_0
    let v59 : struct (string * US2) list = struct (v14, v58) :: v57 
    let _run_target_args'_v17 = v59 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : struct (string * US2) list = []
    let v61 : US2 = US2_4
    let v62 : struct (string * US2) list = struct (v4, v61) :: v60 
    let v63 : US2 = US2_3
    let v64 : struct (string * US2) list = struct (v7, v63) :: v62 
    let v65 : US2 = US2_2
    let v66 : struct (string * US2) list = struct (v10, v65) :: v64 
    let v67 : US2 = US2_1
    let v68 : struct (string * US2) list = struct (v13, v67) :: v66 
    let v69 : US2 = US2_0
    let v70 : struct (string * US2) list = struct (v16, v69) :: v68 
    let v71 : US2 = US2_4
    let v72 : struct (string * US2) list = struct (v2, v71) :: v70 
    let v73 : US2 = US2_3
    let v74 : struct (string * US2) list = struct (v5, v73) :: v72 
    let v75 : US2 = US2_2
    let v76 : struct (string * US2) list = struct (v8, v75) :: v74 
    let v77 : US2 = US2_1
    let v78 : struct (string * US2) list = struct (v11, v77) :: v76 
    let v79 : US2 = US2_0
    let v80 : struct (string * US2) list = struct (v14, v79) :: v78 
    let _run_target_args'_v17 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : struct (string * US2) list = []
    let v82 : US2 = US2_4
    let v83 : struct (string * US2) list = struct (v4, v82) :: v81 
    let v84 : US2 = US2_3
    let v85 : struct (string * US2) list = struct (v7, v84) :: v83 
    let v86 : US2 = US2_2
    let v87 : struct (string * US2) list = struct (v10, v86) :: v85 
    let v88 : US2 = US2_1
    let v89 : struct (string * US2) list = struct (v13, v88) :: v87 
    let v90 : US2 = US2_0
    let v91 : struct (string * US2) list = struct (v16, v90) :: v89 
    let v92 : US2 = US2_4
    let v93 : struct (string * US2) list = struct (v2, v92) :: v91 
    let v94 : US2 = US2_3
    let v95 : struct (string * US2) list = struct (v5, v94) :: v93 
    let v96 : US2 = US2_2
    let v97 : struct (string * US2) list = struct (v8, v96) :: v95 
    let v98 : US2 = US2_1
    let v99 : struct (string * US2) list = struct (v11, v98) :: v97 
    let v100 : US2 = US2_0
    let v101 : struct (string * US2) list = struct (v14, v100) :: v99 
    let _run_target_args'_v17 = v101 
    #endif
#else
    let v102 : struct (string * US2) list = []
    let v103 : US2 = US2_4
    let v104 : struct (string * US2) list = struct (v4, v103) :: v102 
    let v105 : US2 = US2_3
    let v106 : struct (string * US2) list = struct (v7, v105) :: v104 
    let v107 : US2 = US2_2
    let v108 : struct (string * US2) list = struct (v10, v107) :: v106 
    let v109 : US2 = US2_1
    let v110 : struct (string * US2) list = struct (v13, v109) :: v108 
    let v111 : US2 = US2_0
    let v112 : struct (string * US2) list = struct (v16, v111) :: v110 
    let v113 : US2 = US2_4
    let v114 : struct (string * US2) list = struct (v2, v113) :: v112 
    let v115 : US2 = US2_3
    let v116 : struct (string * US2) list = struct (v5, v115) :: v114 
    let v117 : US2 = US2_2
    let v118 : struct (string * US2) list = struct (v8, v117) :: v116 
    let v119 : US2 = US2_1
    let v120 : struct (string * US2) list = struct (v11, v119) :: v118 
    let v121 : US2 = US2_0
    let v122 : struct (string * US2) list = struct (v14, v121) :: v120 
    let _run_target_args'_v17 = v122 
    #endif
    let v123 : struct (string * US2) list = _run_target_args'_v17 
    let v124 : (struct (string * US2) list -> (struct (string * US2) [])) = List.toArray
    let v125 : (struct (string * US2) []) = v124 v123
    let v126 : int32 = v125.Length
    let v127 : US3 = US3_1
    let v128 : Mut7 = {l0 = 0; l1 = v127} : Mut7
    while method18(v126, v128) do
        let v130 : int32 = v128.l0
        let v131 : int32 =  -v130
        let v132 : int32 = v131 + v126
        let v133 : int32 = v132 - 1
        let v134 : US3 = v128.l1
        let struct (v135 : string, v136 : US2) = v125.[int v133]
        let v143 : US3 =
            match v134 with
            | US3_1 -> (* None *)
                let v138 : bool = v135 = v1 
                if v138 then
                    US3_0(v136)
                else
                    US3_1
            | US3_0(v137) -> (* Some *)
                v134
        let v144 : int32 = v130 + 1
        v128.l0 <- v144
        v128.l1 <- v143
        ()
    let v145 : US3 = v128.l1
    let v146 : string = "AUTOMATION"
    let v147 : string = method8(v146)
    let v148 : string = "True"
    let v149 : bool = v147 <> v148 
    let v203 : US4 =
        if v149 then
            US4_1
        else
            (* run_target_args'
            let v151 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v151 = v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v153 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v151 = v153 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v154 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v151 = v154 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v155 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v151 = v155 
            #endif
#else
            let v156 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v151 = v156 
            #endif
            let v157 : System.DateTime = _run_target_args'_v151 
            let v158 : System.DateTime = System.DateTime.MinValue
            (* run_target_args'
            let v159 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v160 : System.TimeSpan = v157 - v158 
            let _run_target_args'_v159 = v160 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v161 : System.TimeSpan = v157 - v158 
            let _run_target_args'_v159 = v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v162 : System.TimeSpan = null |> unbox<System.TimeSpan>
            let _run_target_args'_v159 = v162 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : System.TimeSpan = v157 - v158 
            let _run_target_args'_v159 = v163 
            #endif
#else
            let v164 : System.TimeSpan = v157 - v158 
            let _run_target_args'_v159 = v164 
            #endif
            let v165 : System.TimeSpan = _run_target_args'_v159 
            (* run_target_args'
            let v166 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v167 : (System.TimeSpan -> int64) = _.Ticks
            let v168 : int64 = v167 v165
            let _run_target_args'_v166 = v168 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v169 : (System.TimeSpan -> int64) = _.Ticks
            let v170 : int64 = v169 v165
            let _run_target_args'_v166 = v170 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : int64 = null |> unbox<int64>
            let _run_target_args'_v166 = v171 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : (System.TimeSpan -> int64) = _.Ticks
            let v173 : int64 = v172 v165
            let _run_target_args'_v166 = v173 
            #endif
#else
            let v174 : (System.TimeSpan -> int64) = _.Ticks
            let v175 : int64 = v174 v165
            let _run_target_args'_v166 = v175 
            #endif
            let v176 : int64 = _run_target_args'_v166 
            let v177 : int64 = v176 / 10000000L
            let v178 : float = float v177
            let v179 : float = 10000000.0 * v178
            let v180 : US9 = method19(v179)
            let v186 : US10 =
                match v180 with
                | US9_1(v183) -> (* Error *)
                    US10_1
                | US9_0(v181) -> (* Ok *)
                    US10_0(v181)
            let v190 : int64 =
                match v186 with
                | US10_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US10_0(v187) -> (* Some *)
                    v187
            let v191 : US11 = method20(v190)
            let v197 : US4 =
                match v191 with
                | US11_1(v194) -> (* Error *)
                    US4_1
                | US11_0(v192) -> (* Ok *)
                    US4_0(v192)
            let v201 : int64 =
                match v197 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v198) -> (* Some *)
                    v198
            US4_0(v201)
    struct (v145, v203)
and closure18 () (v0 : string) : unit =
    ()
and method6 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : US3 = US3_1
    let v3 : US4 = US4_1
    let _run_target_args'_v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US3 = US3_1
    let v5 : US4 = US4_1
    let _run_target_args'_v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : std_string_String = v9 |> unbox<std_string_String>
    let _run_target_args'_v10 = v17 
    #endif
#else
    let v18 : std_string_String = v9 |> unbox<std_string_String>
    let _run_target_args'_v10 = v18 
    #endif
    let v19 : std_string_String = _run_target_args'_v10 
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20 
    let _run_target_args'_v7 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v22 
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v25 
    let _run_target_args'_v24 = v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v27 
    let _run_target_args'_v24 = v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v29 
    let _run_target_args'_v24 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : std_string_String = v23 |> unbox<std_string_String>
    let _run_target_args'_v24 = v31 
    #endif
#else
    let v32 : std_string_String = v23 |> unbox<std_string_String>
    let _run_target_args'_v24 = v32 
    #endif
    let v33 : std_string_String = _run_target_args'_v24 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let _run_target_args'_v7 = v35 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36 
    (* run_target_args'
    let v38 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39 
    let _run_target_args'_v38 = v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41 
    let _run_target_args'_v38 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43 
    let _run_target_args'_v38 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = v37 |> unbox<std_string_String>
    let _run_target_args'_v38 = v45 
    #endif
#else
    let v46 : std_string_String = v37 |> unbox<std_string_String>
    let _run_target_args'_v38 = v46 
    #endif
    let v47 : std_string_String = _run_target_args'_v38 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v7 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = null |> unbox<string>
    let _run_target_args'_v7 = v50 
    #endif
#else
    let v51 : string = null |> unbox<string>
    let _run_target_args'_v7 = v51 
    #endif
    let v52 : string = _run_target_args'_v7 
    let v53 : string = "True"
    let v54 : bool = v52 <> v53 
    let v61 : US4 =
        if v54 then
            US4_1
        else
            let v56 : string = $"near_sdk::env::block_timestamp()"
            let v57 : uint64 = Fable.Core.RustInterop.emitRustExpr () v56 
            let v58 : (uint64 -> int64) = int64
            let v59 : int64 = v58 v57
            US4_0(v59)
    let v62 : US3 = US3_1
    let _run_target_args'_v1 = struct (v62, v61) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v63 : US3, v64 : US4) = method7()
    let _run_target_args'_v1 = struct (v63, v64) 
    #endif
#else
    let struct (v65 : US3, v66 : US4) = method7()
    let _run_target_args'_v1 = struct (v65, v66) 
    #endif
    let struct (v67 : US3, v68 : US4) = _run_target_args'_v1 
    let v69 : Mut1 = {l0 = 1L} : Mut1
    let v70 : (string -> unit) = closure18()
    let v71 : Mut3 = {l0 = v70} : Mut3
    let v72 : Mut4 = {l0 = true} : Mut4
    let v73 : string = ""
    let v74 : Mut5 = {l0 = v73} : Mut5
    let v77 : US2 =
        match v67 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v75) -> (* Some *)
            v75
    let v78 : Mut6 = {l0 = v77} : Mut6
    let v83 : int64 option =
        match v68 with
        | US4_1 -> (* None *)
            let v81 : int64 option = None
            v81
        | US4_0(v79) -> (* Some *)
            let v80 : int64 option = Some v79 
            v80
    struct (v69, v71, v72, v74, v78, v83)
and closure9 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US2 = US2_0
        let struct (v2 : Mut1, v3 : Mut3, v4 : Mut4, v5 : Mut5, v6 : Mut6, v7 : int64 option) = method6(v1)
        let v8 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure19 () (v0 : int64) : US4 =
    US4_0(v0)
and method22 () : (int64 -> US4) =
    closure19()
and method23 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method24 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method21 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US4) = method22()
    let v8 : US4 option = v5 |> Option.map v7 
    let v9 : US4 = US4_1
    let v10 : US4 = v8 |> Option.defaultValue v9 
    let v82 : System.DateTime =
        match v10 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v74 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v75 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v74 = v75 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v74 = v76 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v77 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v74 = v77 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v74 = v78 
            #endif
#else
            let v79 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v74 = v79 
            #endif
            let v80 : System.DateTime = _run_target_args'_v74 
            v80
        | US4_0(v11) -> (* Some *)
            (* run_target_args'
            let v12 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v12 = v13 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v12 = v14 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v12 = v15 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v12 = v16 
            #endif
#else
            let v17 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v12 = v17 
            #endif
            let v18 : System.DateTime = _run_target_args'_v12 
            let v19 : System.DateTime = System.DateTime.MinValue
            (* run_target_args'
            let v20 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v21 : System.TimeSpan = v18 - v19 
            let _run_target_args'_v20 = v21 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v22 : System.TimeSpan = v18 - v19 
            let _run_target_args'_v20 = v22 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v23 : System.TimeSpan = null |> unbox<System.TimeSpan>
            let _run_target_args'_v20 = v23 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : System.TimeSpan = v18 - v19 
            let _run_target_args'_v20 = v24 
            #endif
#else
            let v25 : System.TimeSpan = v18 - v19 
            let _run_target_args'_v20 = v25 
            #endif
            let v26 : System.TimeSpan = _run_target_args'_v20 
            (* run_target_args'
            let v27 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : (System.TimeSpan -> int64) = _.Ticks
            let v29 : int64 = v28 v26
            let _run_target_args'_v27 = v29 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v30 : (System.TimeSpan -> int64) = _.Ticks
            let v31 : int64 = v30 v26
            let _run_target_args'_v27 = v31 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v32 : int64 = null |> unbox<int64>
            let _run_target_args'_v27 = v32 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v33 : (System.TimeSpan -> int64) = _.Ticks
            let v34 : int64 = v33 v26
            let _run_target_args'_v27 = v34 
            #endif
#else
            let v35 : (System.TimeSpan -> int64) = _.Ticks
            let v36 : int64 = v35 v26
            let _run_target_args'_v27 = v36 
            #endif
            let v37 : int64 = _run_target_args'_v27 
            let v38 : int64 = v37 / 10000000L
            let v39 : float = float v38
            let v40 : float = 10000000.0 * v39
            let v41 : US9 = method19(v40)
            let v47 : US10 =
                match v41 with
                | US9_1(v44) -> (* Error *)
                    US10_1
                | US9_0(v42) -> (* Ok *)
                    US10_0(v42)
            let v51 : int64 =
                match v47 with
                | US10_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US10_0(v48) -> (* Some *)
                    v48
            let v52 : US11 = method20(v51)
            let v58 : US4 =
                match v52 with
                | US11_1(v55) -> (* Error *)
                    US4_1
                | US11_0(v53) -> (* Ok *)
                    US4_0(v53)
            let v62 : int64 =
                match v58 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v59) -> (* Some *)
                    v59
            let v63 : int64 = v62 - v11
            let v64 : System.TimeSpan = v63 |> System.TimeSpan 
            let v65 : (System.TimeSpan -> int32) = _.Hours
            let v66 : int32 = v65 v64
            let v67 : (System.TimeSpan -> int32) = _.Minutes
            let v68 : int32 = v67 v64
            let v69 : (System.TimeSpan -> int32) = _.Seconds
            let v70 : int32 = v69 v64
            let v71 : (System.TimeSpan -> int32) = _.Milliseconds
            let v72 : int32 = v71 v64
            let v73 : System.DateTime = System.DateTime (1, 1, 1, v66, v68, v70, v72)
            v73
    let v83 : string = method23()
    let v84 : bool = v83 = ""
    let v86 : string =
        if v84 then
            let v85 : string = "M-d-y hh:mm:ss tt"
            v85
        else
            v83
    let v87 : (string -> string) = v82.ToString
    let v88 : string = v87 v86
    let _run_target_args'_v6 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : (int64 -> US4) = method22()
    let v90 : US4 option = v5 |> Option.map v89 
    let v91 : US4 = US4_1
    let v92 : US4 = v90 |> Option.defaultValue v91 
    let v164 : System.DateTime =
        match v92 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v156 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v157 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v156 = v157 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v158 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v156 = v158 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v159 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v156 = v159 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v160 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v156 = v160 
            #endif
#else
            let v161 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v156 = v161 
            #endif
            let v162 : System.DateTime = _run_target_args'_v156 
            v162
        | US4_0(v93) -> (* Some *)
            (* run_target_args'
            let v94 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v95 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v94 = v95 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v96 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v94 = v96 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v94 = v97 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v98 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v94 = v98 
            #endif
#else
            let v99 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v94 = v99 
            #endif
            let v100 : System.DateTime = _run_target_args'_v94 
            let v101 : System.DateTime = System.DateTime.MinValue
            (* run_target_args'
            let v102 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v103 : System.TimeSpan = v100 - v101 
            let _run_target_args'_v102 = v103 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104 : System.TimeSpan = v100 - v101 
            let _run_target_args'_v102 = v104 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v105 : System.TimeSpan = null |> unbox<System.TimeSpan>
            let _run_target_args'_v102 = v105 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v106 : System.TimeSpan = v100 - v101 
            let _run_target_args'_v102 = v106 
            #endif
#else
            let v107 : System.TimeSpan = v100 - v101 
            let _run_target_args'_v102 = v107 
            #endif
            let v108 : System.TimeSpan = _run_target_args'_v102 
            (* run_target_args'
            let v109 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v110 : (System.TimeSpan -> int64) = _.Ticks
            let v111 : int64 = v110 v108
            let _run_target_args'_v109 = v111 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v112 : (System.TimeSpan -> int64) = _.Ticks
            let v113 : int64 = v112 v108
            let _run_target_args'_v109 = v113 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v114 : int64 = null |> unbox<int64>
            let _run_target_args'_v109 = v114 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v115 : (System.TimeSpan -> int64) = _.Ticks
            let v116 : int64 = v115 v108
            let _run_target_args'_v109 = v116 
            #endif
#else
            let v117 : (System.TimeSpan -> int64) = _.Ticks
            let v118 : int64 = v117 v108
            let _run_target_args'_v109 = v118 
            #endif
            let v119 : int64 = _run_target_args'_v109 
            let v120 : int64 = v119 / 10000000L
            let v121 : float = float v120
            let v122 : float = 10000000.0 * v121
            let v123 : US9 = method19(v122)
            let v129 : US10 =
                match v123 with
                | US9_1(v126) -> (* Error *)
                    US10_1
                | US9_0(v124) -> (* Ok *)
                    US10_0(v124)
            let v133 : int64 =
                match v129 with
                | US10_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US10_0(v130) -> (* Some *)
                    v130
            let v134 : US11 = method20(v133)
            let v140 : US4 =
                match v134 with
                | US11_1(v137) -> (* Error *)
                    US4_1
                | US11_0(v135) -> (* Ok *)
                    US4_0(v135)
            let v144 : int64 =
                match v140 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v141) -> (* Some *)
                    v141
            let v145 : int64 = v144 - v93
            let v146 : System.TimeSpan = v145 |> System.TimeSpan 
            let v147 : (System.TimeSpan -> int32) = _.Hours
            let v148 : int32 = v147 v146
            let v149 : (System.TimeSpan -> int32) = _.Minutes
            let v150 : int32 = v149 v146
            let v151 : (System.TimeSpan -> int32) = _.Seconds
            let v152 : int32 = v151 v146
            let v153 : (System.TimeSpan -> int32) = _.Milliseconds
            let v154 : int32 = v153 v146
            let v155 : System.DateTime = System.DateTime (1, 1, 1, v148, v150, v152, v154)
            v155
    let v165 : string = method23()
    let v166 : bool = v165 = ""
    let v168 : string =
        if v166 then
            let v167 : string = "M-d-y hh:mm:ss tt"
            v167
        else
            v165
    let v169 : (string -> string) = v164.ToString
    let v170 : string = v169 v168
    let _run_target_args'_v6 = v170 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v171 : string = $"near_sdk::env::block_timestamp()"
    let v172 : uint64 = Fable.Core.RustInterop.emitRustExpr () v171 
    let v173 : (int64 -> US4) = method22()
    let v174 : US4 option = v5 |> Option.map v173 
    let v175 : US4 = US4_1
    let v176 : US4 = v174 |> Option.defaultValue v175 
    let v182 : uint64 =
        match v176 with
        | US4_1 -> (* None *)
            v172
        | US4_0(v177) -> (* Some *)
            let v178 : (int64 -> uint64) = uint64
            let v179 : uint64 = v178 v177
            let v180 : uint64 = v172 - v179
            v180
    let v183 : uint64 = v182 / 1000000000UL
    let v184 : uint64 = v183 % 60UL
    let v185 : uint64 = v183 / 60UL
    let v186 : uint64 = v185 % 60UL
    let v187 : uint64 = v183 / 3600UL
    let v188 : uint64 = v187 % 24UL
    let v189 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v188, v186, v184) v189 
    let v191 : string = "fable_library_rust::String_::fromString($0)"
    let v192 : string = Fable.Core.RustInterop.emitRustExpr v190 v191 
    let _run_target_args'_v6 = v192 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v193 : (int64 -> US4) = method22()
    let v194 : US4 option = v5 |> Option.map v193 
    let v195 : US4 = US4_1
    let v196 : US4 = v194 |> Option.defaultValue v195 
    let v268 : System.DateTime =
        match v196 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v260 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v261 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v260 = v261 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v262 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v260 = v262 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v263 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v260 = v263 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v264 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v260 = v264 
            #endif
#else
            let v265 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v260 = v265 
            #endif
            let v266 : System.DateTime = _run_target_args'_v260 
            v266
        | US4_0(v197) -> (* Some *)
            (* run_target_args'
            let v198 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v199 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v198 = v199 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v200 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v198 = v200 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v201 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v198 = v201 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v202 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v198 = v202 
            #endif
#else
            let v203 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v198 = v203 
            #endif
            let v204 : System.DateTime = _run_target_args'_v198 
            let v205 : System.DateTime = System.DateTime.MinValue
            (* run_target_args'
            let v206 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v207 : System.TimeSpan = v204 - v205 
            let _run_target_args'_v206 = v207 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v208 : System.TimeSpan = v204 - v205 
            let _run_target_args'_v206 = v208 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v209 : System.TimeSpan = null |> unbox<System.TimeSpan>
            let _run_target_args'_v206 = v209 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v210 : System.TimeSpan = v204 - v205 
            let _run_target_args'_v206 = v210 
            #endif
#else
            let v211 : System.TimeSpan = v204 - v205 
            let _run_target_args'_v206 = v211 
            #endif
            let v212 : System.TimeSpan = _run_target_args'_v206 
            (* run_target_args'
            let v213 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v214 : (System.TimeSpan -> int64) = _.Ticks
            let v215 : int64 = v214 v212
            let _run_target_args'_v213 = v215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v216 : (System.TimeSpan -> int64) = _.Ticks
            let v217 : int64 = v216 v212
            let _run_target_args'_v213 = v217 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : int64 = null |> unbox<int64>
            let _run_target_args'_v213 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v219 : (System.TimeSpan -> int64) = _.Ticks
            let v220 : int64 = v219 v212
            let _run_target_args'_v213 = v220 
            #endif
#else
            let v221 : (System.TimeSpan -> int64) = _.Ticks
            let v222 : int64 = v221 v212
            let _run_target_args'_v213 = v222 
            #endif
            let v223 : int64 = _run_target_args'_v213 
            let v224 : int64 = v223 / 10000000L
            let v225 : float = float v224
            let v226 : float = 10000000.0 * v225
            let v227 : US9 = method19(v226)
            let v233 : US10 =
                match v227 with
                | US9_1(v230) -> (* Error *)
                    US10_1
                | US9_0(v228) -> (* Ok *)
                    US10_0(v228)
            let v237 : int64 =
                match v233 with
                | US10_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US10_0(v234) -> (* Some *)
                    v234
            let v238 : US11 = method20(v237)
            let v244 : US4 =
                match v238 with
                | US11_1(v241) -> (* Error *)
                    US4_1
                | US11_0(v239) -> (* Ok *)
                    US4_0(v239)
            let v248 : int64 =
                match v244 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v245) -> (* Some *)
                    v245
            let v249 : int64 = v248 - v197
            let v250 : System.TimeSpan = v249 |> System.TimeSpan 
            let v251 : (System.TimeSpan -> int32) = _.Hours
            let v252 : int32 = v251 v250
            let v253 : (System.TimeSpan -> int32) = _.Minutes
            let v254 : int32 = v253 v250
            let v255 : (System.TimeSpan -> int32) = _.Seconds
            let v256 : int32 = v255 v250
            let v257 : (System.TimeSpan -> int32) = _.Milliseconds
            let v258 : int32 = v257 v250
            let v259 : System.DateTime = System.DateTime (1, 1, 1, v252, v254, v256, v258)
            v259
    let v269 : string = method24()
    let v270 : bool = v269 = ""
    let v272 : string =
        if v270 then
            let v271 : string = "M-d-y hh:mm:ss tt"
            v271
        else
            v269
    let v273 : (string -> string) = v268.ToString
    let v274 : string = v273 v272
    let _run_target_args'_v6 = v274 
    #endif
#else
    let v275 : (int64 -> US4) = method22()
    let v276 : US4 option = v5 |> Option.map v275 
    let v277 : US4 = US4_1
    let v278 : US4 = v276 |> Option.defaultValue v277 
    let v350 : System.DateTime =
        match v278 with
        | US4_1 -> (* None *)
            (* run_target_args'
            let v342 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v343 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v342 = v343 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v344 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v342 = v344 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v345 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v342 = v345 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v346 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v342 = v346 
            #endif
#else
            let v347 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v342 = v347 
            #endif
            let v348 : System.DateTime = _run_target_args'_v342 
            v348
        | US4_0(v279) -> (* Some *)
            (* run_target_args'
            let v280 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v281 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v280 = v281 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v282 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v280 = v282 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v283 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v280 = v283 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v284 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v280 = v284 
            #endif
#else
            let v285 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v280 = v285 
            #endif
            let v286 : System.DateTime = _run_target_args'_v280 
            let v287 : System.DateTime = System.DateTime.MinValue
            (* run_target_args'
            let v288 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v289 : System.TimeSpan = v286 - v287 
            let _run_target_args'_v288 = v289 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v290 : System.TimeSpan = v286 - v287 
            let _run_target_args'_v288 = v290 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v291 : System.TimeSpan = null |> unbox<System.TimeSpan>
            let _run_target_args'_v288 = v291 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v292 : System.TimeSpan = v286 - v287 
            let _run_target_args'_v288 = v292 
            #endif
#else
            let v293 : System.TimeSpan = v286 - v287 
            let _run_target_args'_v288 = v293 
            #endif
            let v294 : System.TimeSpan = _run_target_args'_v288 
            (* run_target_args'
            let v295 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v296 : (System.TimeSpan -> int64) = _.Ticks
            let v297 : int64 = v296 v294
            let _run_target_args'_v295 = v297 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v298 : (System.TimeSpan -> int64) = _.Ticks
            let v299 : int64 = v298 v294
            let _run_target_args'_v295 = v299 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v300 : int64 = null |> unbox<int64>
            let _run_target_args'_v295 = v300 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v301 : (System.TimeSpan -> int64) = _.Ticks
            let v302 : int64 = v301 v294
            let _run_target_args'_v295 = v302 
            #endif
#else
            let v303 : (System.TimeSpan -> int64) = _.Ticks
            let v304 : int64 = v303 v294
            let _run_target_args'_v295 = v304 
            #endif
            let v305 : int64 = _run_target_args'_v295 
            let v306 : int64 = v305 / 10000000L
            let v307 : float = float v306
            let v308 : float = 10000000.0 * v307
            let v309 : US9 = method19(v308)
            let v315 : US10 =
                match v309 with
                | US9_1(v312) -> (* Error *)
                    US10_1
                | US9_0(v310) -> (* Ok *)
                    US10_0(v310)
            let v319 : int64 =
                match v315 with
                | US10_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US10_0(v316) -> (* Some *)
                    v316
            let v320 : US11 = method20(v319)
            let v326 : US4 =
                match v320 with
                | US11_1(v323) -> (* Error *)
                    US4_1
                | US11_0(v321) -> (* Ok *)
                    US4_0(v321)
            let v330 : int64 =
                match v326 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v327) -> (* Some *)
                    v327
            let v331 : int64 = v330 - v279
            let v332 : System.TimeSpan = v331 |> System.TimeSpan 
            let v333 : (System.TimeSpan -> int32) = _.Hours
            let v334 : int32 = v333 v332
            let v335 : (System.TimeSpan -> int32) = _.Minutes
            let v336 : int32 = v335 v332
            let v337 : (System.TimeSpan -> int32) = _.Seconds
            let v338 : int32 = v337 v332
            let v339 : (System.TimeSpan -> int32) = _.Milliseconds
            let v340 : int32 = v339 v332
            let v341 : System.DateTime = System.DateTime (1, 1, 1, v334, v336, v338, v340)
            v341
    let v351 : string = method24()
    let v352 : bool = v351 = ""
    let v354 : string =
        if v352 then
            let v353 : string = "M-d-y hh:mm:ss tt"
            v353
        else
            v351
    let v355 : (string -> string) = v350.ToString
    let v356 : string = v355 v354
    let _run_target_args'_v6 = v356 
    #endif
    let v357 : string = _run_target_args'_v6 
    v357
and method26 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method14(v2, v3)
    let v4 : string = v2.l0
    v4
and method25 () : string =
    (* run_target_args'
    let v0 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "inline_colorization::color_bright_blue"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1 
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let _run_target_args'_v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v6 
    let _run_target_args'_v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let _run_target_args'_v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_string_String = v2 |> unbox<std_string_String>
    let _run_target_args'_v3 = v10 
    #endif
#else
    let v11 : std_string_String = v2 |> unbox<std_string_String>
    let _run_target_args'_v3 = v11 
    #endif
    let v12 : std_string_String = _run_target_args'_v3 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let _run_target_args'_v0 = v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = "inline_colorization::color_bright_blue"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v15 
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "String::from($0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v18 
    let _run_target_args'_v17 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "String::from($0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v20 
    let _run_target_args'_v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v22 
    let _run_target_args'_v17 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : std_string_String = v16 |> unbox<std_string_String>
    let _run_target_args'_v17 = v24 
    #endif
#else
    let v25 : std_string_String = v16 |> unbox<std_string_String>
    let _run_target_args'_v17 = v25 
    #endif
    let v26 : std_string_String = _run_target_args'_v17 
    let v27 : string = "fable_library_rust::String_::fromString($0)"
    let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let _run_target_args'_v0 = v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = "inline_colorization::color_bright_blue"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v29 
    (* run_target_args'
    let v31 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "String::from($0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v32 
    let _run_target_args'_v31 = v33 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v34 : string = "String::from($0)"
    let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v34 
    let _run_target_args'_v31 = v35 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : string = "String::from($0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v36 
    let _run_target_args'_v31 = v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v31 = v38 
    #endif
#else
    let v39 : std_string_String = v30 |> unbox<std_string_String>
    let _run_target_args'_v31 = v39 
    #endif
    let v40 : std_string_String = _run_target_args'_v31 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _run_target_args'_v0 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = "\u001b[94m"
    let _run_target_args'_v0 = v43 
    #endif
#else
    let v44 : string = "\u001b[94m"
    let _run_target_args'_v0 = v44 
    #endif
    let v45 : string = _run_target_args'_v0 
    
    
    
    
    
    let v46 : string = "Debug"
    let v47 : (unit -> string) = v46.ToLower
    let v48 : string = v47 ()
    let v49 : char = v48.[int 0]
    let v50 : string = method26(v49)
    let v51 : string = v45 + v50 
    (* run_target_args'
    let v52 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : string = "inline_colorization::color_reset"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53 
    (* run_target_args'
    let v55 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : string = "String::from($0)"
    let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v56 
    let _run_target_args'_v55 = v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : string = "String::from($0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v58 
    let _run_target_args'_v55 = v59 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v60 
    let _run_target_args'_v55 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : std_string_String = v54 |> unbox<std_string_String>
    let _run_target_args'_v55 = v62 
    #endif
#else
    let v63 : std_string_String = v54 |> unbox<std_string_String>
    let _run_target_args'_v55 = v63 
    #endif
    let v64 : std_string_String = _run_target_args'_v55 
    let v65 : string = "fable_library_rust::String_::fromString($0)"
    let v66 : string = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let _run_target_args'_v52 = v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : string = "inline_colorization::color_reset"
    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67 
    (* run_target_args'
    let v69 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v70 : string = "String::from($0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v70 
    let _run_target_args'_v69 = v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "String::from($0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v72 
    let _run_target_args'_v69 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "String::from($0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v74 
    let _run_target_args'_v69 = v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : std_string_String = v68 |> unbox<std_string_String>
    let _run_target_args'_v69 = v76 
    #endif
#else
    let v77 : std_string_String = v68 |> unbox<std_string_String>
    let _run_target_args'_v69 = v77 
    #endif
    let v78 : std_string_String = _run_target_args'_v69 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v52 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "inline_colorization::color_reset"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81 
    (* run_target_args'
    let v83 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v84 : string = "String::from($0)"
    let v85 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v84 
    let _run_target_args'_v83 = v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : string = "String::from($0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v86 
    let _run_target_args'_v83 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "String::from($0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v88 
    let _run_target_args'_v83 = v89 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : std_string_String = v82 |> unbox<std_string_String>
    let _run_target_args'_v83 = v90 
    #endif
#else
    let v91 : std_string_String = v82 |> unbox<std_string_String>
    let _run_target_args'_v83 = v91 
    #endif
    let v92 : std_string_String = _run_target_args'_v83 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _run_target_args'_v52 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[0m"
    let _run_target_args'_v52 = v95 
    #endif
#else
    let v96 : string = "\u001b[0m"
    let _run_target_args'_v52 = v96 
    #endif
    let v97 : string = _run_target_args'_v52 
    let v98 : string = v51 + v97 
    v98
and method28 (v0 : int64) : string =
    let v1 : string = method13()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method14(v2, v3)
    let v4 : string = v2.l0
    v4
and method30 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "{ "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method31 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "current_index"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method32 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = " = "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method33 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "; "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method34 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "acc"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method35 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "len"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method36 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "last_item"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method37 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = " }"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method29 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method13()
    let v5 : Mut5 = {l0 = v4} : Mut5
    method30(v5)
    method31(v5)
    method32(v5)
    let v6 : string = $"{v0}"
    method14(v5, v6)
    method33(v5)
    method34(v5)
    method32(v5)
    let v7 : string = $"{v1}"
    method14(v5, v7)
    method33(v5)
    method35(v5)
    method32(v5)
    let v8 : string = $"{v2}"
    method14(v5, v8)
    method33(v5)
    method36(v5)
    method32(v5)
    method14(v5, v3)
    method37(v5)
    let v9 : string = v5.l0
    v9
and method39 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = v0.[int v2]
        let v5 : bool = v4 = ' '
        let v11 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '\t'
                if v6 then
                    true
                else
                    let v7 : bool = v4 = '\r'
                    if v7 then
                        true
                    else
                        let v8 : bool = v4 = '\n'
                        v8
        if v11 then
            let v12 : int32 = v2 + 1
            method39(v0, v1, v12)
        else
            v2
and method40 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        -1
    else
        let v3 : int32 = v1 - 1
        let v4 : char = v0.[int v3]
        let v5 : bool = v4 = ' '
        let v7 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '/'
                v6
        if v7 then
            method40(v0, v3)
        else
            v3
and method38 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method39(v0, v1, v2)
    let v4 : int32 = v1 - 1
    let v5 : string = v0.[int v3..int v4]
    let v6 : int32 = v5.Length
    let v7 : int32 = method40(v5, v6)
    let v8 : string = v5.[int 0..int v7]
    v8
and method27 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v15 : string = method28(v12)
    let v16 : string = v14 + v15 
    let v17 : string = v16 + v7 
    let v18 : string = v17 + v13 
    let v19 : string = "dice.create_sequential_roller / roll"
    let v20 : string = v18 + v19 
    let v21 : string = " / "
    let v22 : string = v20 + v21 
    let v23 : string = method29(v8, v9, v10, v11)
    let v24 : string = v22 + v23 
    method38(v24)
and closure20 (v0 : Mut1) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure22 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure21 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure22(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method41 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure8 (v0 : int64, v1 : int64, v2 : int64, v3 : uint8 option) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure9()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v7 : Mut1, v8 : Mut3, v9 : Mut4, v10 : Mut5, v11 : Mut6, v12 : int64 option) = TraceState.trace_state.Value
    let v13 : US2 = v11.l0
    let v18 : int32 =
        match v13 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v19 : bool = v9.l0
    let v20 : bool = v19 = false
    let v22 : bool =
        if v20 then
            false
        else
            let v21 : bool = 20 >= v18
            v21
    let v23 : bool = v22 = false
    let v106 : US12 =
        if v23 then
            US12_1
        else
            let v25 : unit = ()
            let v26 : unit = (fun () -> v5 (); v25) ()
            let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
            let v33 : string = method21(v27, v28, v29, v30, v31, v32)
            let v34 : string = method25()
            let v35 : string = $"%A{v3}"
            let v36 : string = method27(v27, v28, v29, v30, v31, v32, v33, v34, v0, v1, v2, v35)
            let v37 : unit = ()
            let v38 : unit = (fun () -> v5 (); v37) ()
            let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
            let v45 : unit = ()
            let v46 : (unit -> unit) = closure20(v39)
            let v47 : unit = (fun () -> v46 (); v45) ()
            let v48 : (string -> unit) = closure21()
            (* run_target_args'
            let v49 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v36 v50 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v51 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v36 v51 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52 : string = v42.l0
            let v53 : bool = v52 = ""
            let v61 : string =
                if v53 then
                    v36
                else
                    let v54 : bool = v36 = ""
                    if v54 then
                        let v55 : string = v42.l0
                        v55
                    else
                        let v56 : string = v42.l0
                        let v57 : string = "\n"
                        let v58 : string = v56 + v57 
                        let v59 : string = v58 + v36 
                        v59
            (* run_target_args'
            let v62 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v61 v63 
            let _run_target_args'_v62 = v64 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v61 v65 
            let _run_target_args'_v62 = v66 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v67 : string = "&*$0"
            let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v61 v67 
            let _run_target_args'_v62 = v68 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v69 : Ref<Str> = v61 |> unbox<Ref<Str>>
            let _run_target_args'_v62 = v69 
            #endif
#else
            let v70 : Ref<Str> = v61 |> unbox<Ref<Str>>
            let _run_target_args'_v62 = v70 
            #endif
            let v71 : Ref<Str> = _run_target_args'_v62 
            let v72 : string = $"$0.chars()"
            let v73 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0"
            let v75 : _ = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.collect::<Vec<_>>()"
            let v77 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v79 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v81 : bool = Fable.Core.RustInterop.emitRustExpr v79 v80 
            let v82 : string = "x"
            let v83 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v82 
            let v84 : string = "String::from_iter($0)"
            let v85 : std_string_String = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "true; $0 }).collect::<Vec<_>>()"
            let v87 : bool = Fable.Core.RustInterop.emitRustExpr v85 v86 
            let v88 : string = "_vec_map"
            let v89 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v88 
            let v90 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v91 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v89 v90 
            let v92 : int32 = v91.Length
            let v93 : string = ""
            let v94 : bool = v36 <> v93 
            let v96 : bool =
                if v94 then
                    let v95 : bool = v92 <= 1
                    v95
                else
                    false
            if v96 then
                v42.l0 <- v61
                ()
            else
                v42.l0 <- v93
                let v97 : Mut8 = {l0 = 0} : Mut8
                while method41(v92, v97) do
                    let v99 : int32 = v97.l0
                    let v100 : std_string_String = v91.[int v99]
                    let v101 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v102 : bool = Fable.Core.RustInterop.emitRustExpr v100 v101 
                    let v103 : int32 = v99 + 1
                    v97.l0 <- v103
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v48 v36
            #endif
#else
            v48 v36
            #endif
            // run_target_args' is_unit
            let v104 : (string -> unit) = v40.l0
            v104 v36
            US12_0(v39, v40, v41, v42, v43, v44)
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
    let v1 : Mut5 = {l0 = v0} : Mut5
    let v2 : string = v1.l0
    v2
and method43 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v9 : string = " "
    let v10 : string = v6 + v9 
    let v11 : string = method28(v8)
    let v12 : string = v10 + v11 
    let v13 : string = v12 + v7 
    let v14 : string = v13 + v9 
    let v15 : string = "dice.create_sequential_roller / roll / None"
    let v16 : string = v14 + v15 
    let v17 : string = " / "
    let v18 : string = v16 + v17 
    let v19 : string = method44()
    let v20 : string = v18 + v19 
    method38(v20)
and closure23 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure9()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v3 : Mut1, v4 : Mut3, v5 : Mut4, v6 : Mut5, v7 : Mut6, v8 : int64 option) = TraceState.trace_state.Value
    let v9 : US2 = v7.l0
    let v14 : int32 =
        match v9 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v15 : bool = v5.l0
    let v16 : bool = v15 = false
    let v18 : bool =
        if v16 then
            false
        else
            let v17 : bool = 20 >= v14
            v17
    let v19 : bool = v18 = false
    let v101 : US12 =
        if v19 then
            US12_1
        else
            let v21 : unit = ()
            let v22 : unit = (fun () -> v1 (); v21) ()
            let struct (v23 : Mut1, v24 : Mut3, v25 : Mut4, v26 : Mut5, v27 : Mut6, v28 : int64 option) = TraceState.trace_state.Value
            let v29 : string = method21(v23, v24, v25, v26, v27, v28)
            let v30 : string = method25()
            let v31 : string = method43(v23, v24, v25, v26, v27, v28, v29, v30)
            let v32 : unit = ()
            let v33 : unit = (fun () -> v1 (); v32) ()
            let struct (v34 : Mut1, v35 : Mut3, v36 : Mut4, v37 : Mut5, v38 : Mut6, v39 : int64 option) = TraceState.trace_state.Value
            let v40 : unit = ()
            let v41 : (unit -> unit) = closure20(v34)
            let v42 : unit = (fun () -> v41 (); v40) ()
            let v43 : (string -> unit) = closure21()
            (* run_target_args'
            let v44 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v31 v45 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v46 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v31 v46 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v47 : string = v37.l0
            let v48 : bool = v47 = ""
            let v56 : string =
                if v48 then
                    v31
                else
                    let v49 : bool = v31 = ""
                    if v49 then
                        let v50 : string = v37.l0
                        v50
                    else
                        let v51 : string = v37.l0
                        let v52 : string = "\n"
                        let v53 : string = v51 + v52 
                        let v54 : string = v53 + v31 
                        v54
            (* run_target_args'
            let v57 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v58 : string = "&*$0"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v58 
            let _run_target_args'_v57 = v59 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v60 
            let _run_target_args'_v57 = v61 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v62 
            let _run_target_args'_v57 = v63 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v64 : Ref<Str> = v56 |> unbox<Ref<Str>>
            let _run_target_args'_v57 = v64 
            #endif
#else
            let v65 : Ref<Str> = v56 |> unbox<Ref<Str>>
            let _run_target_args'_v57 = v65 
            #endif
            let v66 : Ref<Str> = _run_target_args'_v57 
            let v67 : string = $"$0.chars()"
            let v68 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v66 v67 
            let v69 : string = "$0"
            let v70 : _ = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0.collect::<Vec<_>>()"
            let v72 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v74 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v76 : bool = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "x"
            let v78 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v77 
            let v79 : string = "String::from_iter($0)"
            let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v79 
            let v81 : string = "true; $0 }).collect::<Vec<_>>()"
            let v82 : bool = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "_vec_map"
            let v84 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v83 
            let v85 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v86 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v84 v85 
            let v87 : int32 = v86.Length
            let v88 : string = ""
            let v89 : bool = v31 <> v88 
            let v91 : bool =
                if v89 then
                    let v90 : bool = v87 <= 1
                    v90
                else
                    false
            if v91 then
                v37.l0 <- v56
                ()
            else
                v37.l0 <- v88
                let v92 : Mut8 = {l0 = 0} : Mut8
                while method41(v87, v92) do
                    let v94 : int32 = v92.l0
                    let v95 : std_string_String = v86.[int v94]
                    let v96 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v97 : bool = Fable.Core.RustInterop.emitRustExpr v95 v96 
                    let v98 : int32 = v94 + 1
                    v92.l0 <- v98
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v43 v31
            #endif
#else
            v43 v31
            #endif
            // run_target_args' is_unit
            let v99 : (string -> unit) = v35.l0
            v99 v31
            US12_0(v34, v35, v36, v37, v38, v39)
    ()
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US1 = v4.l0
    let v43 : uint8 option =
        match v8 with
        | US1_1 -> (* None *)
            let v34 : uint8 option = None
            v34
        | US1_0(v9) -> (* Some *)
            let v12 : uint8 option = Some v9 
            v12
    let v786 : unit = ()
    let v787 : (unit -> unit) = closure8(v5, v6, v7, v43)
    let v788 : unit = (fun () -> v787 (); v786) ()
    let v952 : UH0 = v0 ()
    let v953 : int64 = v1.l0
    let v954 : US1 = method42(v953, v952)
    match v954 with
    | US1_1 -> (* None *)
        let v1058 : unit = ()
        let v1059 : (unit -> unit) = closure23()
        let v1060 : unit = (fun () -> v1059 (); v1058) ()
        let v1215 : int64 = v3.l0
        let v1216 : bool = v1215 = -1L
        if v1216 then
            let v1217 : int64 = v1.l0
            v3.l0 <- v1217
            ()
        let v1218 : int64 = v2.l0
        let v1219 : int64 = v3.l0
        let v1220 : bool = v1218 >= v1219
        let v1223 : int64 =
            if v1220 then
                1L
            else
                let v1221 : int64 = v2.l0
                let v1222 : int64 = v1221 + 1L
                v1222
        v2.l0 <- v1223
        let v1224 : int64 = v2.l0
        let v1225 : int64 = v1224 - 1L
        v1.l0 <- v1225
        let v1226 : US1 = US1_1
        v4.l0 <- v1226
        method5(v0, v1, v2, v3, v4)
    | US1_0(v955) -> (* Some *)
        let v956 : int64 = v1.l0
        let v957 : int64 = v956 + 1L
        v1.l0 <- v957
        let v958 : US1 = US1_0(v955)
        v4.l0 <- v958
        v955
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
and method46 (v0 : uint64) : string =
    let v1 : string = method13()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v15 : string = $"{v0}"
    method14(v2, v15)
    let v23 : string = v2.l0
    v23
and method49 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "max"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method50 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "p"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method51 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "n"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method48 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method13()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method30(v4)
    method49(v4)
    method32(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method33(v4)
    method50(v4)
    method32(v4)
    let v6 : string = $"{v1}"
    method14(v4, v6)
    method33(v4)
    method51(v4)
    method32(v4)
    let v7 : string = $"{v2}"
    method14(v4, v7)
    method37(v4)
    let v8 : string = v4.l0
    v8
and method47 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.calculate_dice_count"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = method48(v8, v9, v10)
    let v23 : string = v21 + v22 
    method38(v23)
and closure27 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method47(v26, v27, v28, v29, v30, v31, v32, v33, v0, v2, v1)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method45 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : bool = v2 > 3074457345618258602UL
        if v4 then
            let v5 : string = method46(v0)
            let v10 : string = "dice.calculate_dice_count / max: "
            let v11 : string = v10 + v5 
            let v23 : string = " is above the largest supported bound "
            let v24 : string = v11 + v23 
            let v32 : string = method46(v2)
            let v33 : string = v24 + v32 
            failwith<int8> v33
        else
            let v35 : int8 = v1 + 1y
            let v36 : uint64 = v2 * 6UL
            method45(v0, v35, v36)
    else
        let v138 : unit = ()
        let v139 : (unit -> unit) = closure27(v0, v1, v2)
        let v140 : unit = (fun () -> v139 (); v138) ()
        v1
and method56 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "power"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method57 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "result"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method55 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method13()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method30(v4)
    method56(v4)
    method32(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method33(v4)
    method34(v4)
    method32(v4)
    let v6 : string = $"{v1}"
    method14(v4, v6)
    method33(v4)
    method57(v4)
    method32(v4)
    let v7 : string = $"{v2}"
    method14(v4, v7)
    method37(v4)
    let v8 : string = v4.l0
    v8
and method54 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = method55(v8, v9, v10)
    let v23 : string = v21 + v22 
    method38(v23)
and closure28 (v0 : uint64, v1 : int8, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method54(v26, v27, v28, v29, v30, v31, v32, v33, v1, v0, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and closure92 () () : UH2 =
    UH2_1
and closure91 () () : UH2 =
    let v0 : (unit -> UH2) = closure92()
    UH2_0(9223372036854775808UL, v0)
and closure90 () () : UH2 =
    let v0 : (unit -> UH2) = closure91()
    UH2_0(4611686018427387904UL, v0)
and closure89 () () : UH2 =
    let v0 : (unit -> UH2) = closure90()
    UH2_0(6917529027641081856UL, v0)
and closure88 () () : UH2 =
    let v0 : (unit -> UH2) = closure89()
    UH2_0(1152921504606846976UL, v0)
and closure87 () () : UH2 =
    let v0 : (unit -> UH2) = closure88()
    UH2_0(15564440312192434176UL, v0)
and closure86 () () : UH2 =
    let v0 : (unit -> UH2) = closure87()
    UH2_0(11817445422220181504UL, v0)
and closure85 () () : UH2 =
    let v0 : (unit -> UH2) = closure86()
    UH2_0(5044031582654955520UL, v0)
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(6989586621679009792UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(16537217831704461312UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(11979575008805519360UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(14294425217273954304UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(2382404202878992384UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(6545982058383015936UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(10314369046585278464UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(4793518853382471680UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(3873377154515337216UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(645562859085889536UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(107593809847648256UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(3092389647259533312UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(9738770311398031360UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(16995415113324298240UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(8981483876790566912UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(13794743361938128896UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(2299123893656354816UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(3457644661227651072UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(576274110204608512UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(6244960376270618624UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(13338656111851470848UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(14520938734448279552UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(14717985838214414336UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(5527454985320660992UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(16293529225644736512UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(11938960241128898560UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(8138741398091333632UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(7505371590918406144UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(16623181993244360704UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(8919445023443910656UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(4561031516192243712UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(9983543956220149760UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(4738381338321616896UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(789730223053602816UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(131621703842267136UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(21936950640377856UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(3656158440062976UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(609359740010496UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(101559956668416UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(16926659444736UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(2821109907456UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(470184984576UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(78364164096UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(13060694016UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(2176782336UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(362797056UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(60466176UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(10077696UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(1679616UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(279936UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(46656UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(7776UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(1296UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(216UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(36UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(6UL, v0)
and method58 (v0 : int8, v1 : UH2) : US14 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US14_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method58(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US14_1
and method61 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "roll"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method62 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "value"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method60 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method13()
    let v5 : Mut5 = {l0 = v4} : Mut5
    method30(v5)
    method56(v5)
    method32(v5)
    let v6 : string = $"{v0}"
    method14(v5, v6)
    method33(v5)
    method34(v5)
    method32(v5)
    let v7 : string = $"{v1}"
    method14(v5, v7)
    method33(v5)
    method61(v5)
    method32(v5)
    let v8 : string = $"{v2}"
    method14(v5, v8)
    method33(v5)
    method62(v5)
    method32(v5)
    let v9 : string = $"{v3}"
    method14(v5, v9)
    method37(v5)
    let v10 : string = v5.l0
    v10
and method59 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v15 : string = method28(v12)
    let v16 : string = v14 + v15 
    let v17 : string = v16 + v7 
    let v18 : string = v17 + v13 
    let v19 : string = "dice.accumulate_dice_rolls"
    let v20 : string = v18 + v19 
    let v21 : string = " / "
    let v22 : string = v20 + v21 
    let v23 : string = method60(v8, v9, v10, v11)
    let v24 : string = v22 + v23 
    method38(v24)
and closure93 (v0 : uint64, v1 : int8, v2 : uint8, v3 : uint64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure9()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v7 : Mut1, v8 : Mut3, v9 : Mut4, v10 : Mut5, v11 : Mut6, v12 : int64 option) = TraceState.trace_state.Value
    let v13 : US2 = v11.l0
    let v18 : int32 =
        match v13 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v19 : bool = v9.l0
    let v20 : bool = v19 = false
    let v22 : bool =
        if v20 then
            false
        else
            let v21 : bool = 20 >= v18
            v21
    let v23 : bool = v22 = false
    let v105 : US12 =
        if v23 then
            US12_1
        else
            let v25 : unit = ()
            let v26 : unit = (fun () -> v5 (); v25) ()
            let struct (v27 : Mut1, v28 : Mut3, v29 : Mut4, v30 : Mut5, v31 : Mut6, v32 : int64 option) = TraceState.trace_state.Value
            let v33 : string = method21(v27, v28, v29, v30, v31, v32)
            let v34 : string = method25()
            let v35 : string = method59(v27, v28, v29, v30, v31, v32, v33, v34, v1, v0, v2, v3)
            let v36 : unit = ()
            let v37 : unit = (fun () -> v5 (); v36) ()
            let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = TraceState.trace_state.Value
            let v44 : unit = ()
            let v45 : (unit -> unit) = closure20(v38)
            let v46 : unit = (fun () -> v45 (); v44) ()
            let v47 : (string -> unit) = closure21()
            (* run_target_args'
            let v48 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v35 v49 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v50 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v35 v50 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v51 : string = v41.l0
            let v52 : bool = v51 = ""
            let v60 : string =
                if v52 then
                    v35
                else
                    let v53 : bool = v35 = ""
                    if v53 then
                        let v54 : string = v41.l0
                        v54
                    else
                        let v55 : string = v41.l0
                        let v56 : string = "\n"
                        let v57 : string = v55 + v56 
                        let v58 : string = v57 + v35 
                        v58
            (* run_target_args'
            let v61 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v62 
            let _run_target_args'_v61 = v63 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v64 
            let _run_target_args'_v61 = v65 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v66 : string = "&*$0"
            let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
            let _run_target_args'_v61 = v67 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v68 : Ref<Str> = v60 |> unbox<Ref<Str>>
            let _run_target_args'_v61 = v68 
            #endif
#else
            let v69 : Ref<Str> = v60 |> unbox<Ref<Str>>
            let _run_target_args'_v61 = v69 
            #endif
            let v70 : Ref<Str> = _run_target_args'_v61 
            let v71 : string = $"$0.chars()"
            let v72 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0"
            let v74 : _ = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.collect::<Vec<_>>()"
            let v76 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v78 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
            let v81 : string = "x"
            let v82 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v81 
            let v83 : string = "String::from_iter($0)"
            let v84 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "true; $0 }).collect::<Vec<_>>()"
            let v86 : bool = Fable.Core.RustInterop.emitRustExpr v84 v85 
            let v87 : string = "_vec_map"
            let v88 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v87 
            let v89 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v90 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v88 v89 
            let v91 : int32 = v90.Length
            let v92 : string = ""
            let v93 : bool = v35 <> v92 
            let v95 : bool =
                if v93 then
                    let v94 : bool = v91 <= 1
                    v94
                else
                    false
            if v95 then
                v41.l0 <- v60
                ()
            else
                v41.l0 <- v92
                let v96 : Mut8 = {l0 = 0} : Mut8
                while method41(v91, v96) do
                    let v98 : int32 = v96.l0
                    let v99 : std_string_String = v90.[int v98]
                    let v100 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v101 : bool = Fable.Core.RustInterop.emitRustExpr v99 v100 
                    let v102 : int32 = v98 + 1
                    v96.l0 <- v102
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v47 v35
            #endif
#else
            v47 v35
            #endif
            // run_target_args' is_unit
            let v103 : (string -> unit) = v39.l0
            v103 v35
            US12_0(v38, v39, v40, v41, v42, v43)
    ()
and method64 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method13()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method30(v4)
    method56(v4)
    method32(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method33(v4)
    method34(v4)
    method32(v4)
    let v6 : string = $"{v1}"
    method14(v4, v6)
    method33(v4)
    method61(v4)
    method32(v4)
    let v7 : string = $"{v2}"
    method14(v4, v7)
    method37(v4)
    let v8 : string = v4.l0
    v8
and method63 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = method64(v8, v9, v10)
    let v23 : string = v21 + v22 
    method38(v23)
and closure94 (v0 : uint64, v1 : int8, v2 : uint8) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method63(v26, v27, v28, v29, v30, v31, v32, v33, v1, v0, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method53 (v0 : int8, v1 : UH1, v2 : uint64) : US13 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure28(v2, v0, v4)
        let v106 : unit = (fun () -> v105 (); v104) ()
        US13_0(v4, v1)
    else
        match v1 with
        | UH1_1(v263, v264) -> (* Cons *)
            let v265 : bool = v263 > 1uy
            if v265 then
                let v266 : uint64 = 1UL
                let v267 : (unit -> UH2) = closure29()
                let v268 : UH2 = UH2_0(v266, v267)
                let v269 : US14 = method58(v0, v268)
                let v273 : uint64 =
                    match v269 with
                    | US14_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US14_0(v270) -> (* Some *)
                        v270
                let v274 : uint8 = v263 - 1uy
                let v275 : uint64 = uint64 v274
                let v276 : uint64 = v275 * v273
                let v376 : unit = ()
                let v377 : (unit -> unit) = closure93(v2, v0, v263, v276)
                let v378 : unit = (fun () -> v377 (); v376) ()
                let v533 : uint64 = v2 + v276
                let v534 : int8 = v0 - 1y
                method53(v534, v264, v533)
            else
                let v635 : unit = ()
                let v636 : (unit -> unit) = closure94(v2, v0, v263)
                let v637 : unit = (fun () -> v636 (); v635) ()
                let v792 : int8 = v0 - 1y
                method53(v792, v264, v2)
        | UH1_0 -> (* Nil *)
            US13_1
and method65 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method65(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method66 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method52(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US13 = method53(v3, v4, v10)
        match v11 with
        | US13_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method65(v3, v0, v15)
                    method66(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method52(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method65(v3, v0, v23)
                method66(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method52(v0, v1, v2, v3, v27, v5)
and method52 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method52(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US13 = method53(v3, v4, v12)
        match v13 with
        | US13_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method65(v3, v0, v17)
                    method66(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method52(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method65(v3, v0, v26)
                method66(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method52(v0, v1, v2, v3, v30, v31)
and closure26 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
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
    method52(v0, v1, v2, v8, v9, v10)
and closure25 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure26(v0, v1)
and closure24 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure25(v0)
and method67 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method67(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure96 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method67(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US13 = method53(v4, v1, v5)
    let v16 : US14 =
        match v6 with
        | US13_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US14_0(v7)
            else
                US14_1
        | _ ->
            US14_1
    match v16 with
    | US14_1 -> (* None *)
        let v42 : uint64 option = None
        v42
    | US14_0(v17) -> (* Some *)
        let v20 : uint64 option = Some v17 
        v20
and closure95 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure96(v0)
and method69 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method13()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method30(v4)
    method49(v4)
    method32(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method33(v4)
    method50(v4)
    method32(v4)
    let v6 : string = $"{v1}"
    method14(v4, v6)
    method33(v4)
    method51(v4)
    method32(v4)
    let v7 : string = $"{v2}"
    method14(v4, v7)
    method37(v4)
    let v8 : string = v4.l0
    v8
and method68 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v9 : string = " "
    let v10 : string = v6 + v9 
    let v11 : string = method28(v8)
    let v12 : string = v10 + v11 
    let v13 : string = v12 + v7 
    let v14 : string = v13 + v9 
    let v15 : string = "dice.calculate_dice_count"
    let v16 : string = v14 + v15 
    let v17 : string = " / "
    let v18 : string = v16 + v17 
    let v19 : int64 = 4738381338321616896L
    let v20 : int64 = 4738381338321616896L
    let v21 : int8 = 24y
    let v22 : string = method69(v19, v20, v21)
    let v23 : string = v18 + v22 
    method38(v23)
and closure98 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure9()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v3 : Mut1, v4 : Mut3, v5 : Mut4, v6 : Mut5, v7 : Mut6, v8 : int64 option) = TraceState.trace_state.Value
    let v9 : US2 = v7.l0
    let v14 : int32 =
        match v9 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v15 : bool = v5.l0
    let v16 : bool = v15 = false
    let v18 : bool =
        if v16 then
            false
        else
            let v17 : bool = 20 >= v14
            v17
    let v19 : bool = v18 = false
    let v101 : US12 =
        if v19 then
            US12_1
        else
            let v21 : unit = ()
            let v22 : unit = (fun () -> v1 (); v21) ()
            let struct (v23 : Mut1, v24 : Mut3, v25 : Mut4, v26 : Mut5, v27 : Mut6, v28 : int64 option) = TraceState.trace_state.Value
            let v29 : string = method21(v23, v24, v25, v26, v27, v28)
            let v30 : string = method25()
            let v31 : string = method68(v23, v24, v25, v26, v27, v28, v29, v30)
            let v32 : unit = ()
            let v33 : unit = (fun () -> v1 (); v32) ()
            let struct (v34 : Mut1, v35 : Mut3, v36 : Mut4, v37 : Mut5, v38 : Mut6, v39 : int64 option) = TraceState.trace_state.Value
            let v40 : unit = ()
            let v41 : (unit -> unit) = closure20(v34)
            let v42 : unit = (fun () -> v41 (); v40) ()
            let v43 : (string -> unit) = closure21()
            (* run_target_args'
            let v44 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v31 v45 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v46 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v31 v46 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v47 : string = v37.l0
            let v48 : bool = v47 = ""
            let v56 : string =
                if v48 then
                    v31
                else
                    let v49 : bool = v31 = ""
                    if v49 then
                        let v50 : string = v37.l0
                        v50
                    else
                        let v51 : string = v37.l0
                        let v52 : string = "\n"
                        let v53 : string = v51 + v52 
                        let v54 : string = v53 + v31 
                        v54
            (* run_target_args'
            let v57 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v58 : string = "&*$0"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v58 
            let _run_target_args'_v57 = v59 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v60 
            let _run_target_args'_v57 = v61 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v62 
            let _run_target_args'_v57 = v63 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v64 : Ref<Str> = v56 |> unbox<Ref<Str>>
            let _run_target_args'_v57 = v64 
            #endif
#else
            let v65 : Ref<Str> = v56 |> unbox<Ref<Str>>
            let _run_target_args'_v57 = v65 
            #endif
            let v66 : Ref<Str> = _run_target_args'_v57 
            let v67 : string = $"$0.chars()"
            let v68 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v66 v67 
            let v69 : string = "$0"
            let v70 : _ = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0.collect::<Vec<_>>()"
            let v72 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v74 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v76 : bool = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "x"
            let v78 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v77 
            let v79 : string = "String::from_iter($0)"
            let v80 : std_string_String = Fable.Core.RustInterop.emitRustExpr v78 v79 
            let v81 : string = "true; $0 }).collect::<Vec<_>>()"
            let v82 : bool = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "_vec_map"
            let v84 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v83 
            let v85 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v86 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v84 v85 
            let v87 : int32 = v86.Length
            let v88 : string = ""
            let v89 : bool = v31 <> v88 
            let v91 : bool =
                if v89 then
                    let v90 : bool = v87 <= 1
                    v90
                else
                    false
            if v91 then
                v37.l0 <- v56
                ()
            else
                v37.l0 <- v88
                let v92 : Mut8 = {l0 = 0} : Mut8
                while method41(v87, v92) do
                    let v94 : int32 = v92.l0
                    let v95 : std_string_String = v86.[int v94]
                    let v96 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v97 : bool = Fable.Core.RustInterop.emitRustExpr v95 v96 
                    let v98 : int32 = v94 + 1
                    v92.l0 <- v98
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v43 v31
            #endif
#else
            v43 v31
            #endif
            // run_target_args' is_unit
            let v99 : (string -> unit) = v35.l0
            v99 v31
            US12_0(v34, v35, v36, v37, v38, v39)
    ()
and closure99 () () : int32 =
    let v0 : int32 = 1uy |> int32 
    v0
and closure100 () (v0 : int32) : US15 =
    US15_0(v0)
and closure101 () (v0 : exn) : US15 =
    US15_1(v0)
and method72 () : US15 =
    let v0 : (unit -> int32) = closure99()
    let v1 : (int32 -> US15) = closure100()
    let v2 : ((unit -> exn) -> exn) = closure13()
    let v3 : (exn -> US15) = closure101()
    let v4 : US15 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure102 () () : int32 =
    let v0 : int32 = 7uy |> int32 
    v0
and method73 () : US15 =
    let v0 : (unit -> int32) = closure102()
    let v1 : (int32 -> US15) = closure100()
    let v2 : ((unit -> exn) -> exn) = closure13()
    let v3 : (exn -> US15) = closure101()
    let v4 : US15 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure103 (v0 : int32) () : uint8 =
    let v1 : uint8 = v0 |> uint8 
    v1
and closure104 () (v0 : uint8) : US17 =
    US17_0(v0)
and closure105 () (v0 : exn) : US17 =
    US17_1(v0)
and method74 (v0 : int32) : US17 =
    let v1 : (unit -> uint8) = closure103(v0)
    let v2 : (uint8 -> US17) = closure104()
    let v3 : ((unit -> exn) -> exn) = closure13()
    let v4 : (exn -> US17) = closure105()
    let v5 : US17 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method71 () : uint8 =
    (* run_target_args'
    let v416 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v417 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v418 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v417 
    let _run_target_args'_v416 = v418 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v419 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v420 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v419 
    let _run_target_args'_v416 = v420 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v421 : uint8 = failwith<uint8> "common.random' / target=Rust(Contract)"
    let _run_target_args'_v416 = v421 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v422 : (unit -> System.Random) = System.Random 
    let v423 : System.Random = v422 ()
    let v424 : US15 = method72()
    let v430 : US16 =
        match v424 with
        | US15_1(v427) -> (* Error *)
            US16_1
        | US15_0(v425) -> (* Ok *)
            US16_0(v425)
    let v434 : int32 =
        match v430 with
        | US16_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US16_0(v431) -> (* Some *)
            v431
    let v435 : US15 = method73()
    let v441 : US16 =
        match v435 with
        | US15_1(v438) -> (* Error *)
            US16_1
        | US15_0(v436) -> (* Ok *)
            US16_0(v436)
    let v445 : int32 =
        match v441 with
        | US16_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US16_0(v442) -> (* Some *)
            v442
    let v446 : int32 = v423.Next (v434, v445)
    let v447 : US17 = method74(v446)
    let v453 : US1 =
        match v447 with
        | US17_1(v450) -> (* Error *)
            US1_1
        | US17_0(v448) -> (* Ok *)
            US1_0(v448)
    let v457 : uint8 =
        match v453 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v454) -> (* Some *)
            v454
    let _run_target_args'_v416 = v457 
    #endif
#else
    let v458 : (unit -> System.Random) = System.Random 
    let v459 : System.Random = v458 ()
    let v460 : US15 = method72()
    let v466 : US16 =
        match v460 with
        | US15_1(v463) -> (* Error *)
            US16_1
        | US15_0(v461) -> (* Ok *)
            US16_0(v461)
    let v470 : int32 =
        match v466 with
        | US16_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US16_0(v467) -> (* Some *)
            v467
    let v471 : US15 = method73()
    let v477 : US16 =
        match v471 with
        | US15_1(v474) -> (* Error *)
            US16_1
        | US15_0(v472) -> (* Ok *)
            US16_0(v472)
    let v481 : int32 =
        match v477 with
        | US16_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US16_0(v478) -> (* Some *)
            v478
    let v482 : int32 = v459.Next (v470, v481)
    let v483 : US17 = method74(v482)
    let v489 : US1 =
        match v483 with
        | US17_1(v486) -> (* Error *)
            US1_1
        | US17_0(v484) -> (* Ok *)
            US1_0(v484)
    let v493 : uint8 =
        match v489 with
        | US1_1 -> (* None *)
            failwith<uint8> "Option does not have a value."
        | US1_0(v490) -> (* Some *)
            v490
    let _run_target_args'_v416 = v493 
    #endif
    let v494 : uint8 = _run_target_args'_v416 
    v494
and method77 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method13()
    let v5 : Mut5 = {l0 = v4} : Mut5
    method30(v5)
    method56(v5)
    method32(v5)
    let v6 : string = $"{v0}"
    method14(v5, v6)
    method33(v5)
    method34(v5)
    method32(v5)
    let v7 : string = $"{v1}"
    method14(v5, v7)
    method33(v5)
    method61(v5)
    method32(v5)
    let v8 : string = $"{v2}"
    method14(v5, v8)
    method33(v5)
    method62(v5)
    method32(v5)
    let v9 : string = $"{v3}"
    method14(v5, v9)
    method37(v5)
    let v10 : string = v5.l0
    v10
and method76 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 23y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure106 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method76(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method79 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 22y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure107 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method79(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method81 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 21y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure108 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method81(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method83 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 20y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure109 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method83(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method85 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 19y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure110 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method85(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method87 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 18y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure111 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method87(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method89 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 17y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure112 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method89(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method91 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 16y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure113 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method91(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method93 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 15y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure114 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method93(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method95 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 14y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure115 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method95(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method97 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 13y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure116 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method97(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method99 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 12y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure117 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method99(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 11y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure118 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method101(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 10y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure119 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method103(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 9y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure120 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method105(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 8y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure121 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method107(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 7y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure122 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method109(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 6y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure123 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method111(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 5y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure124 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method113(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method115 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 4y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure125 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method115(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method117 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 3y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure126 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method117(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method119 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 2y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure127 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method119(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method121 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 1y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure128 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method121(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method123 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method28(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 0y
    let v23 : string = method77(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method38(v24)
and closure129 (v0 : int64, v1 : uint8, v2 : int64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure9()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut5, v10 : Mut6, v11 : int64 option) = TraceState.trace_state.Value
    let v12 : US2 = v10.l0
    let v17 : int32 =
        match v12 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v18 : bool = v8.l0
    let v19 : bool = v18 = false
    let v21 : bool =
        if v19 then
            false
        else
            let v20 : bool = 20 >= v17
            v20
    let v22 : bool = v21 = false
    let v104 : US12 =
        if v22 then
            US12_1
        else
            let v24 : unit = ()
            let v25 : unit = (fun () -> v4 (); v24) ()
            let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
            let v32 : string = method21(v26, v27, v28, v29, v30, v31)
            let v33 : string = method25()
            let v34 : string = method123(v26, v27, v28, v29, v30, v31, v32, v33, v0, v1, v2)
            let v35 : unit = ()
            let v36 : unit = (fun () -> v4 (); v35) ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : unit = ()
            let v44 : (unit -> unit) = closure20(v37)
            let v45 : unit = (fun () -> v44 (); v43) ()
            let v46 : (string -> unit) = closure21()
            (* run_target_args'
            let v47 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v34 v49 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : string = v40.l0
            let v51 : bool = v50 = ""
            let v59 : string =
                if v51 then
                    v34
                else
                    let v52 : bool = v34 = ""
                    if v52 then
                        let v53 : string = v40.l0
                        v53
                    else
                        let v54 : string = v40.l0
                        let v55 : string = "\n"
                        let v56 : string = v54 + v55 
                        let v57 : string = v56 + v34 
                        v57
            (* run_target_args'
            let v60 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v61 
            let _run_target_args'_v60 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v63 
            let _run_target_args'_v60 = v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = "&*$0"
            let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v65 
            let _run_target_args'_v60 = v66 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v67 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v67 
            #endif
#else
            let v68 : Ref<Str> = v59 |> unbox<Ref<Str>>
            let _run_target_args'_v60 = v68 
            #endif
            let v69 : Ref<Str> = _run_target_args'_v60 
            let v70 : string = $"$0.chars()"
            let v71 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0"
            let v73 : _ = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.collect::<Vec<_>>()"
            let v75 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v77 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "x"
            let v81 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "String::from_iter($0)"
            let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "true; $0 }).collect::<Vec<_>>()"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "_vec_map"
            let v87 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v89 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : int32 = v89.Length
            let v91 : string = ""
            let v92 : bool = v34 <> v91 
            let v94 : bool =
                if v92 then
                    let v93 : bool = v90 <= 1
                    v93
                else
                    false
            if v94 then
                v40.l0 <- v59
                ()
            else
                v40.l0 <- v91
                let v95 : Mut8 = {l0 = 0} : Mut8
                while method41(v90, v95) do
                    let v97 : int32 = v95.l0
                    let v98 : std_string_String = v89.[int v97]
                    let v99 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
                    let v101 : int32 = v97 + 1
                    v95.l0 <- v101
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v46 v34
            #endif
#else
            v46 v34
            #endif
            // run_target_args' is_unit
            let v102 : (string -> unit) = v38.l0
            v102 v34
            US12_0(v37, v38, v39, v40, v41, v42)
    ()
and method126 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method13()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method30(v4)
    method56(v4)
    method32(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method33(v4)
    method34(v4)
    method32(v4)
    let v6 : string = $"{v1}"
    method14(v4, v6)
    method33(v4)
    method57(v4)
    method32(v4)
    let v7 : string = $"{v2}"
    method14(v4, v7)
    method37(v4)
    let v8 : string = v4.l0
    v8
and method125 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = -1y
    let v22 : string = method126(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure130 (v0 : int64, v1 : int64) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method125(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method124 (v0 : UH1, v1 : int64) : US18 =
    let v2 : int64 = v1 + 1L
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure130(v1, v2)
    let v104 : unit = (fun () -> v103 (); v102) ()
    US18_0(v2, v0)
and method128 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method13()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method30(v4)
    method56(v4)
    method32(v4)
    let v5 : string = $"{v0}"
    method14(v4, v5)
    method33(v4)
    method34(v4)
    method32(v4)
    let v6 : string = $"{v1}"
    method14(v4, v6)
    method33(v4)
    method61(v4)
    method32(v4)
    let v7 : string = $"{v2}"
    method14(v4, v7)
    method37(v4)
    let v8 : string = v4.l0
    v8
and method127 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 0y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure131 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method127(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method122 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v107 : unit = ()
            let v108 : (unit -> unit) = closure129(v1, v3, v7)
            let v109 : unit = (fun () -> v108 (); v107) ()
            let v264 : int64 = v1 + v7
            method124(v4, v264)
        else
            let v365 : unit = ()
            let v366 : (unit -> unit) = closure131(v1, v3)
            let v367 : unit = (fun () -> v366 (); v365) ()
            method124(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method129 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 1y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure132 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method129(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method120 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure128(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method122(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure132(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method122(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method130 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 2y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure133 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method130(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method118 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure127(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method120(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure133(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method120(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method131 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 3y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure134 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method131(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method116 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure126(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method118(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure134(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method118(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method132 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 4y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure135 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method132(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method114 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure125(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method116(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure135(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method116(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method133 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 5y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure136 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method133(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method112 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure124(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method114(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure136(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method114(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method134 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 6y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure137 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method134(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method110 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure123(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method112(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure137(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method112(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method135 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 7y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure138 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method135(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method108 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure122(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method110(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure138(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method110(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method136 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 8y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure139 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method136(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method106 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure121(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method108(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure139(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method108(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method137 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 9y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure140 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method137(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method104 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure120(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method106(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure140(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method106(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method138 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 10y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure141 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method138(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method102 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure119(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method104(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure141(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method104(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method139 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 11y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure142 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method139(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method100 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure118(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method102(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure142(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method102(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method140 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 12y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure143 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method140(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method98 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure117(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method100(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure143(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method100(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method141 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 13y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure144 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method141(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method96 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure116(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method98(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure144(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method98(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method142 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 14y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure145 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method142(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method94 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure115(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method96(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure145(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method96(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method143 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 15y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure146 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method143(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method92 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure114(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method94(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure146(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method94(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method144 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 16y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure147 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method144(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method90 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure113(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method92(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure147(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method92(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method145 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 17y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure148 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method145(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method88 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure112(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method90(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure148(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method90(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method146 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 18y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure149 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method146(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method86 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure111(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method88(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure149(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method88(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method147 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 19y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure150 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method147(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method84 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure110(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method86(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure150(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method86(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method148 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 20y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure151 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method148(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method82 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure109(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method84(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure151(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method84(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method149 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 21y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure152 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method149(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method80 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure108(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method82(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure152(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method82(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method150 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 22y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure153 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method150(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method78 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure107(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method80(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure153(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method80(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method151 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method28(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 23y
    let v22 : string = method128(v21, v8, v9)
    let v23 : string = v20 + v22 
    method38(v23)
and closure154 (v0 : int64, v1 : uint8) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = TraceState.trace_state.Value
    let v11 : US2 = v9.l0
    let v16 : int32 =
        match v11 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v17 : bool = v7.l0
    let v18 : bool = v17 = false
    let v20 : bool =
        if v18 then
            false
        else
            let v19 : bool = 20 >= v16
            v19
    let v21 : bool = v20 = false
    let v103 : US12 =
        if v21 then
            US12_1
        else
            let v23 : unit = ()
            let v24 : unit = (fun () -> v3 (); v23) ()
            let struct (v25 : Mut1, v26 : Mut3, v27 : Mut4, v28 : Mut5, v29 : Mut6, v30 : int64 option) = TraceState.trace_state.Value
            let v31 : string = method21(v25, v26, v27, v28, v29, v30)
            let v32 : string = method25()
            let v33 : string = method151(v25, v26, v27, v28, v29, v30, v31, v32, v0, v1)
            let v34 : unit = ()
            let v35 : unit = (fun () -> v3 (); v34) ()
            let struct (v36 : Mut1, v37 : Mut3, v38 : Mut4, v39 : Mut5, v40 : Mut6, v41 : int64 option) = TraceState.trace_state.Value
            let v42 : unit = ()
            let v43 : (unit -> unit) = closure20(v36)
            let v44 : unit = (fun () -> v43 (); v42) ()
            let v45 : (string -> unit) = closure21()
            (* run_target_args'
            let v46 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v33 v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v49 : string = v39.l0
            let v50 : bool = v49 = ""
            let v58 : string =
                if v50 then
                    v33
                else
                    let v51 : bool = v33 = ""
                    if v51 then
                        let v52 : string = v39.l0
                        v52
                    else
                        let v53 : string = v39.l0
                        let v54 : string = "\n"
                        let v55 : string = v53 + v54 
                        let v56 : string = v55 + v33 
                        v56
            (* run_target_args'
            let v59 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : string = "&*$0"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v60 
            let _run_target_args'_v59 = v61 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62 : string = "&*$0"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v62 
            let _run_target_args'_v59 = v63 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v64 : string = "&*$0"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v64 
            let _run_target_args'_v59 = v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v66 
            #endif
#else
            let v67 : Ref<Str> = v58 |> unbox<Ref<Str>>
            let _run_target_args'_v59 = v67 
            #endif
            let v68 : Ref<Str> = _run_target_args'_v59 
            let v69 : string = $"$0.chars()"
            let v70 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "$0"
            let v72 : _ = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "$0.collect::<Vec<_>>()"
            let v74 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v76 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr v76 v77 
            let v79 : string = "x"
            let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "String::from_iter($0)"
            let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
            let v83 : string = "true; $0 }).collect::<Vec<_>>()"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
            let v85 : string = "_vec_map"
            let v86 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v88 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v86 v87 
            let v89 : int32 = v88.Length
            let v90 : string = ""
            let v91 : bool = v33 <> v90 
            let v93 : bool =
                if v91 then
                    let v92 : bool = v89 <= 1
                    v92
                else
                    false
            if v93 then
                v39.l0 <- v58
                ()
            else
                v39.l0 <- v90
                let v94 : Mut8 = {l0 = 0} : Mut8
                while method41(v89, v94) do
                    let v96 : int32 = v94.l0
                    let v97 : std_string_String = v88.[int v96]
                    let v98 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
                    let v100 : int32 = v96 + 1
                    v94.l0 <- v100
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v45 v33
            #endif
#else
            v45 v33
            #endif
            // run_target_args' is_unit
            let v101 : (string -> unit) = v37.l0
            v101 v33
            US12_0(v36, v37, v38, v39, v40, v41)
    ()
and method75 (v0 : UH1, v1 : int64) : US18 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v108 : unit = ()
            let v109 : (unit -> unit) = closure106(v1, v3, v8)
            let v110 : unit = (fun () -> v109 (); v108) ()
            let v265 : int64 = v1 + v8
            method78(v4, v265)
        else
            let v366 : unit = ()
            let v367 : (unit -> unit) = closure154(v1, v3)
            let v368 : unit = (fun () -> v367 (); v366) ()
            method78(v4, v1)
    | UH1_0 -> (* Nil *)
        US18_1
and method70 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method71()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method70(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US18 = method75(v0, v7)
        match v8 with
        | US18_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 4738381338321616896L
            if v11 then
                v9
            else
                let v12 : uint8 = method71()
                let v13 : uint8 = method71()
                let v14 : uint8 = method71()
                let v15 : uint8 = method71()
                let v16 : uint8 = method71()
                let v17 : uint8 = method71()
                let v18 : uint8 = method71()
                let v19 : uint8 = method71()
                let v20 : uint8 = method71()
                let v21 : uint8 = method71()
                let v22 : uint8 = method71()
                let v23 : uint8 = method71()
                let v24 : uint8 = method71()
                let v25 : uint8 = method71()
                let v26 : uint8 = method71()
                let v27 : uint8 = method71()
                let v28 : uint8 = method71()
                let v29 : uint8 = method71()
                let v30 : uint8 = method71()
                let v31 : uint8 = method71()
                let v32 : uint8 = method71()
                let v33 : uint8 = method71()
                let v34 : uint8 = method71()
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
                method70(v58, v59)
        | _ ->
            let v62 : uint8 = method71()
            let v63 : uint8 = method71()
            let v64 : uint8 = method71()
            let v65 : uint8 = method71()
            let v66 : uint8 = method71()
            let v67 : uint8 = method71()
            let v68 : uint8 = method71()
            let v69 : uint8 = method71()
            let v70 : uint8 = method71()
            let v71 : uint8 = method71()
            let v72 : uint8 = method71()
            let v73 : uint8 = method71()
            let v74 : uint8 = method71()
            let v75 : uint8 = method71()
            let v76 : uint8 = method71()
            let v77 : uint8 = method71()
            let v78 : uint8 = method71()
            let v79 : uint8 = method71()
            let v80 : uint8 = method71()
            let v81 : uint8 = method71()
            let v82 : uint8 = method71()
            let v83 : uint8 = method71()
            let v84 : uint8 = method71()
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
            method70(v108, v109)
and method153 (v0 : int64) : string =
    let v1 : string = method13()
    let v2 : Mut5 = {l0 = v1} : Mut5
    method30(v2)
    method57(v2)
    method32(v2)
    let v3 : string = $"{v0}"
    method14(v2, v3)
    method37(v2)
    let v4 : string = v2.l0
    v4
and method152 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method28(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "dice.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = method153(v8)
    let v21 : string = v19 + v20 
    method38(v21)
and closure155 (v0 : int64) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v4 : Mut1, v5 : Mut3, v6 : Mut4, v7 : Mut5, v8 : Mut6, v9 : int64 option) = TraceState.trace_state.Value
    let v10 : US2 = v8.l0
    let v15 : int32 =
        match v10 with
        | US2_4 -> (* Critical *)
            50
        | US2_1 -> (* Debug *)
            20
        | US2_2 -> (* Info *)
            30
        | US2_0 -> (* Verbose *)
            10
        | US2_3 -> (* Warning *)
            40
    let v16 : bool = v6.l0
    let v17 : bool = v16 = false
    let v19 : bool =
        if v17 then
            false
        else
            let v18 : bool = 20 >= v15
            v18
    let v20 : bool = v19 = false
    let v102 : US12 =
        if v20 then
            US12_1
        else
            let v22 : unit = ()
            let v23 : unit = (fun () -> v2 (); v22) ()
            let struct (v24 : Mut1, v25 : Mut3, v26 : Mut4, v27 : Mut5, v28 : Mut6, v29 : int64 option) = TraceState.trace_state.Value
            let v30 : string = method21(v24, v25, v26, v27, v28, v29)
            let v31 : string = method25()
            let v32 : string = method152(v24, v25, v26, v27, v28, v29, v30, v31, v0)
            let v33 : unit = ()
            let v34 : unit = (fun () -> v2 (); v33) ()
            let struct (v35 : Mut1, v36 : Mut3, v37 : Mut4, v38 : Mut5, v39 : Mut6, v40 : int64 option) = TraceState.trace_state.Value
            let v41 : unit = ()
            let v42 : (unit -> unit) = closure20(v35)
            let v43 : unit = (fun () -> v42 (); v41) ()
            let v44 : (string -> unit) = closure21()
            (* run_target_args'
            let v45 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v46 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v32 v46 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v47 : string = "println!(\"{}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v32 v47 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v48 : string = v38.l0
            let v49 : bool = v48 = ""
            let v57 : string =
                if v49 then
                    v32
                else
                    let v50 : bool = v32 = ""
                    if v50 then
                        let v51 : string = v38.l0
                        v51
                    else
                        let v52 : string = v38.l0
                        let v53 : string = "\n"
                        let v54 : string = v52 + v53 
                        let v55 : string = v54 + v32 
                        v55
            (* run_target_args'
            let v58 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v59 : string = "&*$0"
            let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v59 
            let _run_target_args'_v58 = v60 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v61 : string = "&*$0"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v61 
            let _run_target_args'_v58 = v62 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v63 : string = "&*$0"
            let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v63 
            let _run_target_args'_v58 = v64 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v65 : Ref<Str> = v57 |> unbox<Ref<Str>>
            let _run_target_args'_v58 = v65 
            #endif
#else
            let v66 : Ref<Str> = v57 |> unbox<Ref<Str>>
            let _run_target_args'_v58 = v66 
            #endif
            let v67 : Ref<Str> = _run_target_args'_v58 
            let v68 : string = $"$0.chars()"
            let v69 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v67 v68 
            let v70 : string = "$0"
            let v71 : _ = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0.collect::<Vec<_>>()"
            let v73 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v75 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76 
            let v78 : string = "x"
            let v79 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v78 
            let v80 : string = "String::from_iter($0)"
            let v81 : std_string_String = Fable.Core.RustInterop.emitRustExpr v79 v80 
            let v82 : string = "true; $0 }).collect::<Vec<_>>()"
            let v83 : bool = Fable.Core.RustInterop.emitRustExpr v81 v82 
            let v84 : string = "_vec_map"
            let v85 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v84 
            let v86 : string = "fable_library_rust::NativeArray_::array_from($0.clone())"
            let v87 : (std_string_String []) = Fable.Core.RustInterop.emitRustExpr v85 v86 
            let v88 : int32 = v87.Length
            let v89 : string = ""
            let v90 : bool = v32 <> v89 
            let v92 : bool =
                if v90 then
                    let v91 : bool = v88 <= 1
                    v91
                else
                    false
            if v92 then
                v38.l0 <- v57
                ()
            else
                v38.l0 <- v89
                let v93 : Mut8 = {l0 = 0} : Mut8
                while method41(v88, v93) do
                    let v95 : int32 = v93.l0
                    let v96 : std_string_String = v87.[int v95]
                    let v97 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                    let v98 : bool = Fable.Core.RustInterop.emitRustExpr v96 v97 
                    let v99 : int32 = v95 + 1
                    v93.l0 <- v99
                    ()
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v44 v32
            #endif
#else
            v44 v32
            #endif
            // run_target_args' is_unit
            let v100 : (string -> unit) = v36.l0
            v100 v32
            US12_0(v35, v36, v37, v38, v39, v40)
    ()
and closure97 () (v0 : (string [])) : int32 =
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure98()
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v257 : UH1 = UH1_0
    let v258 : int8 = 0y
    let v259 : int64 = method70(v257, v258)
    let v359 : unit = ()
    let v360 : (unit -> unit) = closure155(v259)
    let v361 : unit = (fun () -> v360 (); v359) ()
    0
let v6 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v6 x
let v17 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v17 x
let v22 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure24()
let roll_progressively x = v22 x
let v27 : (uint64 -> (UH1 -> uint64 option)) = closure95()
let roll_within_bounds x = v27 x
let v32 : ((string []) -> int32) = closure97()
let main args = v32 args
()
