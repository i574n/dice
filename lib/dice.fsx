module TraceState = let mutable trace_state = None
let spiralStringIndex (s : string) (i : int) : char = char (System.Text.Encoding.UTF8.GetBytes(s).[i])
let spiralStringSlice (s : string) (from : int) (upto : int) : string =
    let bytes = System.Text.Encoding.UTF8.GetBytes(s)
    let length = bytes.Length
    if from < 0 || from > length || upto < from - 1 || upto >= length then exit 3
    elif upto < from then ""
    elif (bytes.[from] &&& 0xC0uy) = 0x80uy || (upto + 1 < length && (bytes.[upto + 1] &&& 0xC0uy) = 0x80uy) then exit 3
    else System.Text.Encoding.UTF8.GetString(bytes, from, upto - from + 1)
type UH0 =
    | UH0_StreamCons of uint8 * (unit -> UH0)
    | UH0_StreamNil
and UH1 =
    | UH1_Nil
    | UH1_Cons of uint8 * UH1
and [<Struct>] US0 =
    | US0_NotComputed of f0_0 : (unit -> UH0)
    | US0_Computed of f1_0 : UH0
and Mut0 = {mutable l0 : US0}
and Mut1 = {mutable l0 : int64}
and [<Struct>] US1 =
    | US1_Some of f0_0 : uint8
    | US1_None
and Mut2 = {mutable l0 : US1}
and [<Struct>] US2 =
    | US2_Verbose
    | US2_Debug
    | US2_Info
    | US2_Warning
    | US2_Critical
and Mut3 = {mutable l0 : (string -> unit)}
and Mut4 = {mutable l0 : bool}
and Mut5 = {mutable l0 : string}
and Mut6 = {mutable l0 : US2}
and [<Struct>] US3 =
    | US3_Some of f0_0 : US2
    | US3_None
and [<Struct>] US4 =
    | US4_Some of f0_0 : int64
    | US4_None
and [<Struct>] US5 =
    | US5_Some of f0_0 : string
    | US5_None
and Mut7 = {mutable l0 : int32; mutable l1 : US3}
and [<Struct>] US6 =
    | US6_Some of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut5 * f0_4 : Mut6 * f0_5 : int64 option
    | US6_None
and [<Struct>] US7 =
    | US7_Some of f0_0 : uint64 * f0_1 : UH1
    | US7_None
and UH2 =
    | UH2_StreamCons of uint64 * (unit -> UH2)
    | UH2_StreamNil
and [<Struct>] US8 =
    | US8_Some of f0_0 : uint64
    | US8_None
and [<Struct>] US9 =
    | US9_Ok of f0_0 : int32
    | US9_Error of f1_0 : exn
and [<Struct>] US10 =
    | US10_Some of f0_0 : int32
    | US10_None
and [<Struct>] US11 =
    | US11_Ok of f0_0 : uint8
    | US11_Error of f1_0 : exn
and [<Struct>] US12 =
    | US12_Some of f0_0 : int64 * f0_1 : UH1
    | US12_None
let rec closure2 (v0 : UH0) () : UH0 =
    v0
and method0 (v0 : int64, v1 : UH0, v2 : UH0) : UH0 =
    match v1 with
    | UH0_StreamCons(v3, v4) -> (* StreamCons *)
        let v5 : UH0 = v4 ()
        let v6 : UH0 = method0(v0, v5, v2)
        let v7 : int64 = int64 v3
        let v8 : int64 = v7 - 1L
        let v9 : int64 = v8 + v0
        let v10 : int64 = v9 % v0
        let v11 : int64 = v10 + 1L
        let v12 : uint8 = uint8 v11
        let v13 : (unit -> UH0) = closure2(v6)
        UH0_StreamCons(v12, v13)
    | UH0_StreamNil -> (* StreamNil *)
        v2
and closure1 (v0 : int64) (v1 : UH0) : UH0 =
    let v2 : UH0 = UH0_StreamNil
    method0(v0, v1, v2)
and closure0 () (v0 : int64) : (UH0 -> UH0) =
    closure1(v0)
and method1 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_Cons(v2, v1)
        method1(v3, v4)
    | UH1_Nil -> (* Nil *)
        v1
and method2 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : UH1 = method2(v3, v1)
        UH1_Cons(v2, v4)
    | UH1_Nil -> (* Nil *)
        v1
and closure4 (v0 : UH0) () : UH0 =
    v0
and method3 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : UH0 = method3(v3, v1)
        let v5 : (unit -> UH0) = closure4(v4)
        UH0_StreamCons(v2, v5)
    | UH1_Nil -> (* Nil *)
        v1
and closure5 (v0 : UH0) () : UH0 =
    v0
and closure6 (v0 : UH0, v1 : Mut0) () : UH0 =
    let v2 : US0 = v1.l0
    match v2 with
    | US0_Computed(v3) -> (* Computed *)
        v3
    | US0_NotComputed(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_StreamCons(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method4(v0, v8)
                UH0_StreamCons(v7, v9)
            | UH0_StreamNil -> (* StreamNil *)
                UH0_StreamNil
        let v13 : US0 = US0_Computed(v12)
        v1.l0 <- v13
        v12
and method4 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US0 = US0_NotComputed(v1)
    let v3 : Mut0 = {l0 = v2} : Mut0
    closure6(v0, v3)
and closure8 () (v0 : string) : US5 =
    US5_Some(v0)
and method9 () : (string -> US5) =
    closure8()
and get_environment_variable_8 (v0 : string) : string =
    let v1 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v2 : string = v1 v0
    let v3 : (string -> string option) = Option.ofObj
    let v4 : string option = v3 v2
    let v5 : (string -> US5) = method9()
    let v6 : US5 option = v4 |> Option.map v5 
    let v7 : US5 = US5_None
    let v8 : US5 = v6 |> Option.defaultValue v7 
    match v8 with
    | US5_None -> (* None *)
        let v10 : string = ""
        v10
    | US5_Some(v9) -> (* Some *)
        v9
and method10 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method7 () : struct (US3 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = get_environment_variable_8(v0)
    
    
    
    
    
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
    let v17 : struct (string * US2) list = []
    let v18 : US2 = US2_Critical
    let v19 : struct (string * US2) list = struct (v4, v18) :: v17 
    let v20 : US2 = US2_Warning
    let v21 : struct (string * US2) list = struct (v7, v20) :: v19 
    let v22 : US2 = US2_Info
    let v23 : struct (string * US2) list = struct (v10, v22) :: v21 
    let v24 : US2 = US2_Debug
    let v25 : struct (string * US2) list = struct (v13, v24) :: v23 
    let v26 : US2 = US2_Verbose
    let v27 : struct (string * US2) list = struct (v16, v26) :: v25 
    let v28 : US2 = US2_Critical
    let v29 : struct (string * US2) list = struct (v2, v28) :: v27 
    let v30 : US2 = US2_Warning
    let v31 : struct (string * US2) list = struct (v5, v30) :: v29 
    let v32 : US2 = US2_Info
    let v33 : struct (string * US2) list = struct (v8, v32) :: v31 
    let v34 : US2 = US2_Debug
    let v35 : struct (string * US2) list = struct (v11, v34) :: v33 
    let v36 : US2 = US2_Verbose
    let v37 : struct (string * US2) list = struct (v14, v36) :: v35 
    let v38 : (struct (string * US2) list -> (struct (string * US2) [])) = List.toArray
    let v39 : (struct (string * US2) []) = v38 v37
    let v40 : int32 = v39.Length
    let v41 : US3 = US3_None
    let v42 : Mut7 = {l0 = 0; l1 = v41} : Mut7
    while method10(v40, v42) do
        let v44 : int32 = v42.l0
        let v45 : int32 =  -v44
        let v46 : int32 = v45 + v40
        let v47 : int32 = v46 - 1
        let v48 : US3 = v42.l1
        let struct (v49 : string, v50 : US2) = v39.[int v47]
        let v57 : US3 =
            match v48 with
            | US3_None -> (* None *)
                let v52 : bool = v49 = v1 
                if v52 then
                    US3_Some(v50)
                else
                    US3_None
            | US3_Some(v51) -> (* Some *)
                v48
        let v58 : int32 = v44 + 1
        v42.l0 <- v58
        v42.l1 <- v57
        ()
    let v59 : US3 = v42.l1
    let v60 : string = "AUTOMATION"
    let v61 : string = get_environment_variable_8(v60)
    let v62 : string = "True"
    let v63 : bool = v61 <> v62 
    let v68 : US4 =
        if v63 then
            US4_None
        else
            let v65 : System.DateTime = System.DateTime.Now
            let v66 : int64 = (v65.Ticks - 621355968000000000L) / 10L
            US4_Some(v66)
    struct (v59, v68)
and closure9 () (v0 : string) : unit =
    ()
and new_trace_state_6 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    let struct (v1 : US3, v2 : US4) = method7()
    let v3 : Mut1 = {l0 = 1L} : Mut1
    let v4 : (string -> unit) = closure9()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : Mut4 = {l0 = true} : Mut4
    let v7 : string = ""
    let v8 : Mut5 = {l0 = v7} : Mut5
    let v11 : US2 =
        match v1 with
        | US3_None -> (* None *)
            v0
        | US3_Some(v9) -> (* Some *)
            v9
    let v12 : Mut6 = {l0 = v11} : Mut6
    let v17 : int64 option =
        match v2 with
        | US4_None -> (* None *)
            let v15 : int64 option = None
            v15
        | US4_Some(v13) -> (* Some *)
            let v14 : int64 option = Some v13 
            v14
    struct (v3, v5, v6, v8, v12, v17)
and closure10 () (v0 : int64) : US4 =
    US4_Some(v0)
and method12 () : (int64 -> US4) =
    closure10()
and method13 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method11 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    let v6 : (int64 -> US4) = method12()
    let v7 : US4 option = v5 |> Option.map v6 
    let v8 : US4 = US4_None
    let v9 : US4 = v7 |> Option.defaultValue v8 
    let v26 : System.DateTime =
        match v9 with
        | US4_None -> (* None *)
            let v24 : System.DateTime = System.DateTime.Now
            v24
        | US4_Some(v10) -> (* Some *)
            let v11 : System.DateTime = System.DateTime.Now
            let v12 : int64 = (v11.Ticks - 621355968000000000L) / 10L
            let v13 : int64 = v12 - v10
            let v14 : System.TimeSpan = System.TimeSpan.FromTicks(v13 * 10L)
            let v15 : (System.TimeSpan -> int32) = _.Hours
            let v16 : int32 = v15 v14
            let v17 : (System.TimeSpan -> int32) = _.Minutes
            let v18 : int32 = v17 v14
            let v19 : (System.TimeSpan -> int32) = _.Seconds
            let v20 : int32 = v19 v14
            let v21 : (System.TimeSpan -> int32) = _.Milliseconds
            let v22 : int32 = v21 v14
            let v23 : System.DateTime = System.DateTime (1, 1, 1, v16, v18, v20, v22)
            v23
    let v27 : string = method13()
    let v28 : bool = v27 = ""
    let v30 : string =
        if v28 then
            let v29 : string = "M-d-y hh:mm:ss tt"
            v29
        else
            v27
    let v31 : (string -> string) = v26.ToString
    v31 v30
and method16 () : string =
    let v0 : string = ""
    v0
and method17 (v0 : Mut5, v1 : string) : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and format_real_15 (v0 : char) : string =
    let v1 : string = method16()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method17(v2, v3)
    let v4 : string = v2.l0
    v4
and method14 () : string =
    let v0 : string = "\u001b[94m"
    
    
    
    
    
    let v1 : string = "Debug"
    let v2 : (unit -> string) = v1.ToLower
    let v3 : string = v2 ()
    let v4 : char = (spiralStringIndex v3 (int 0))
    let v5 : string = format_real_15(v4)
    let v6 : string = v0 + v5 
    let v7 : string = "\u001b[0m"
    let v8 : string = v6 + v7 
    v8
and format_real_19 (v0 : int64) : string =
    let v1 : string = method16()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method17(v2, v3)
    let v4 : string = v2.l0
    v4
and method21 (v0 : string, v1 : int32, v2 : int32) : int32 =
    let v3 : bool = v2 >= v1
    if v3 then
        v1
    else
        let v4 : char = (spiralStringIndex v0 (int v2))
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
            method21(v0, v1, v12)
        else
            v2
and method22 (v0 : string, v1 : int32) : int32 =
    let v2 : bool = v1 <= 0
    if v2 then
        -1
    else
        let v3 : int32 = v1 - 1
        let v4 : char = (spiralStringIndex v0 (int v3))
        let v5 : bool = v4 = ' '
        let v7 : bool =
            if v5 then
                true
            else
                let v6 : bool = v4 = '/'
                v6
        if v7 then
            method22(v0, v3)
        else
            v3
and method20 (v0 : string) : string =
    let v1 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v2 : int32 = 0
    let v3 : int32 = method21(v0, v1, v2)
    let v4 : int32 = v1 - 1
    let v5 : string = (spiralStringSlice v0 (int v3) (int v4))
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v5))
    let v7 : int32 = method22(v5, v6)
    let v8 : string = (spiralStringSlice v5 (int 0) (int v7))
    v8
and method18 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v15 : string = format_real_19(v12)
    let v16 : string = v14 + v15 
    let v17 : string = v16 + v7 
    let v18 : string = v17 + v13 
    let v19 : string = "dice.create_sequential_roller / roll"
    let v20 : string = v18 + v19 
    let v21 : string = " / "
    let v22 : string = v20 + v21 
    let v23 : string = ""
    let v24 : string = v23 + v23 
    let v25 : string = "current_index"
    let v26 : string = v24 + v25 
    let v27 : string = " = "
    let v28 : string = v26 + v27 
    let v29 : string = format_real_19(v8)
    let v30 : string = v28 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v27 
    let v36 : string = format_real_19(v9)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "len"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v27 
    let v42 : string = format_real_19(v10)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "last_item"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v27 
    let v48 : string = v47 + v11 
    let v49 : string = "{ "
    let v50 : string = v49 + v48 
    let v51 : string = " }"
    let v52 : string = v50 + v51 
    let v53 : string = v22 + v52 
    method20(v53)
and closure11 () (v0 : string) : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and method23 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_StreamCons(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_Some(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method23(v6, v7)
    | UH0_StreamNil -> (* StreamNil *)
        US1_None
and format_real_25 () : string =
    let v0 : string = method16()
    let v1 : Mut5 = {l0 = v0} : Mut5
    let v2 : string = v1.l0
    v2
and method24 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v9 : string = " "
    let v10 : string = v6 + v9 
    let v11 : string = format_real_19(v8)
    let v12 : string = v10 + v11 
    let v13 : string = v12 + v7 
    let v14 : string = v13 + v9 
    let v15 : string = "dice.create_sequential_roller / roll / None"
    let v16 : string = v14 + v15 
    let v17 : string = " / "
    let v18 : string = v16 + v17 
    let v19 : string = format_real_25()
    let v20 : string = v18 + v19 
    method20(v20)
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) : uint8 =
    let v5 : int64 = v1.l0
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : US1 = v4.l0
    let v13 : uint8 option =
        match v8 with
        | US1_None -> (* None *)
            let v11 : uint8 option = None
            v11
        | US1_Some(v9) -> (* Some *)
            let v10 : uint8 option = Some v9 
            v10
    let v14 : bool = TraceState.trace_state.IsNone
    if v14 then
        let v15 : US2 = US2_Verbose
        let struct (v16 : Mut1, v17 : Mut3, v18 : Mut4, v19 : Mut5, v20 : Mut6, v21 : int64 option) = new_trace_state_6(v15)
        let v22 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v16, v17, v18, v19, v20, v21) 
        TraceState.trace_state <- v22 
        ()
    let struct (v23 : Mut1, v24 : Mut3, v25 : Mut4, v26 : Mut5, v27 : Mut6, v28 : int64 option) = TraceState.trace_state.Value
    let v29 : US2 = v27.l0
    let v34 : int32 =
        match v29 with
        | US2_Critical -> (* Critical *)
            50
        | US2_Debug -> (* Debug *)
            20
        | US2_Info -> (* Info *)
            30
        | US2_Verbose -> (* Verbose *)
            10
        | US2_Warning -> (* Warning *)
            40
    let v35 : bool = v25.l0
    let v36 : bool = v35 = false
    let v38 : bool =
        if v36 then
            false
        else
            let v37 : bool = 20 >= v34
            v37
    let v39 : bool = v38 = false
    let v80 : US6 =
        if v39 then
            US6_None
        else
            let v41 : bool = TraceState.trace_state.IsNone
            if v41 then
                let v42 : US2 = US2_Verbose
                let struct (v43 : Mut1, v44 : Mut3, v45 : Mut4, v46 : Mut5, v47 : Mut6, v48 : int64 option) = new_trace_state_6(v42)
                let v49 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v43, v44, v45, v46, v47, v48) 
                TraceState.trace_state <- v49 
                ()
            let struct (v50 : Mut1, v51 : Mut3, v52 : Mut4, v53 : Mut5, v54 : Mut6, v55 : int64 option) = TraceState.trace_state.Value
            let v56 : string = method11(v50, v51, v52, v53, v54, v55)
            let v57 : string = method14()
            let v58 : string = $"%A{v13}"
            let v59 : string = method18(v50, v51, v52, v53, v54, v55, v56, v57, v5, v6, v7, v58)
            let v60 : bool = TraceState.trace_state.IsNone
            if v60 then
                let v61 : US2 = US2_Verbose
                let struct (v62 : Mut1, v63 : Mut3, v64 : Mut4, v65 : Mut5, v66 : Mut6, v67 : int64 option) = new_trace_state_6(v61)
                let v68 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v62, v63, v64, v65, v66, v67) 
                TraceState.trace_state <- v68 
                ()
            let struct (v69 : Mut1, v70 : Mut3, v71 : Mut4, v72 : Mut5, v73 : Mut6, v74 : int64 option) = TraceState.trace_state.Value
            let v75 : int64 = v69.l0
            let v76 : int64 = v75 + 1L
            v69.l0 <- v76
            let v77 : (string -> unit) = closure11()
            v77 v59
            let v78 : (string -> unit) = v70.l0
            v78 v59
            US6_Some(v69, v70, v71, v72, v73, v74)
    let v81 : UH0 = v0 ()
    let v82 : int64 = v1.l0
    let v83 : US1 = method23(v82, v81)
    match v83 with
    | US1_None -> (* None *)
        let v88 : bool = TraceState.trace_state.IsNone
        if v88 then
            let v89 : US2 = US2_Verbose
            let struct (v90 : Mut1, v91 : Mut3, v92 : Mut4, v93 : Mut5, v94 : Mut6, v95 : int64 option) = new_trace_state_6(v89)
            let v96 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v90, v91, v92, v93, v94, v95) 
            TraceState.trace_state <- v96 
            ()
        let struct (v97 : Mut1, v98 : Mut3, v99 : Mut4, v100 : Mut5, v101 : Mut6, v102 : int64 option) = TraceState.trace_state.Value
        let v103 : US2 = v101.l0
        let v108 : int32 =
            match v103 with
            | US2_Critical -> (* Critical *)
                50
            | US2_Debug -> (* Debug *)
                20
            | US2_Info -> (* Info *)
                30
            | US2_Verbose -> (* Verbose *)
                10
            | US2_Warning -> (* Warning *)
                40
        let v109 : bool = v99.l0
        let v110 : bool = v109 = false
        let v112 : bool =
            if v110 then
                false
            else
                let v111 : bool = 20 >= v108
                v111
        let v113 : bool = v112 = false
        let v153 : US6 =
            if v113 then
                US6_None
            else
                let v115 : bool = TraceState.trace_state.IsNone
                if v115 then
                    let v116 : US2 = US2_Verbose
                    let struct (v117 : Mut1, v118 : Mut3, v119 : Mut4, v120 : Mut5, v121 : Mut6, v122 : int64 option) = new_trace_state_6(v116)
                    let v123 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v117, v118, v119, v120, v121, v122) 
                    TraceState.trace_state <- v123 
                    ()
                let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = TraceState.trace_state.Value
                let v130 : string = method11(v124, v125, v126, v127, v128, v129)
                let v131 : string = method14()
                let v132 : string = method24(v124, v125, v126, v127, v128, v129, v130, v131)
                let v133 : bool = TraceState.trace_state.IsNone
                if v133 then
                    let v134 : US2 = US2_Verbose
                    let struct (v135 : Mut1, v136 : Mut3, v137 : Mut4, v138 : Mut5, v139 : Mut6, v140 : int64 option) = new_trace_state_6(v134)
                    let v141 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v135, v136, v137, v138, v139, v140) 
                    TraceState.trace_state <- v141 
                    ()
                let struct (v142 : Mut1, v143 : Mut3, v144 : Mut4, v145 : Mut5, v146 : Mut6, v147 : int64 option) = TraceState.trace_state.Value
                let v148 : int64 = v142.l0
                let v149 : int64 = v148 + 1L
                v142.l0 <- v149
                let v150 : (string -> unit) = closure11()
                v150 v132
                let v151 : (string -> unit) = v143.l0
                v151 v132
                US6_Some(v142, v143, v144, v145, v146, v147)
        let v154 : int64 = v3.l0
        let v155 : bool = v154 = -1L
        if v155 then
            let v156 : int64 = v1.l0
            v3.l0 <- v156
            ()
        let v157 : int64 = v2.l0
        let v158 : int64 = v3.l0
        let v159 : bool = v157 >= v158
        let v162 : int64 =
            if v159 then
                1L
            else
                let v160 : int64 = v2.l0
                let v161 : int64 = v160 + 1L
                v161
        v2.l0 <- v162
        let v163 : int64 = v2.l0
        let v164 : int64 = v163 - 1L
        v1.l0 <- v164
        let v165 : US1 = US1_None
        v4.l0 <- v165
        method5(v0, v1, v2, v3, v4)
    | US1_Some(v84) -> (* Some *)
        let v85 : int64 = v1.l0
        let v86 : int64 = v85 + 1L
        v1.l0 <- v86
        let v87 : US1 = US1_Some(v84)
        v4.l0 <- v87
        v84
and closure7 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1, v4 : Mut2) () : uint8 =
    method5(v0, v1, v2, v3, v4)
and closure3 () (v0 : UH1) : (unit -> uint8) =
    let v1 : UH1 = UH1_Nil
    let v2 : UH1 = method1(v0, v1)
    let v3 : UH1 = method2(v0, v2)
    let v4 : UH0 = UH0_StreamNil
    let v5 : UH0 = method3(v3, v4)
    let v6 : (unit -> UH0) = closure5(v5)
    let v7 : (unit -> UH0) = method4(v5, v6)
    let v8 : Mut1 = {l0 = 0L} : Mut1
    let v9 : Mut1 = {l0 = 1L} : Mut1
    let v10 : Mut1 = {l0 = -1L} : Mut1
    let v11 : US1 = US1_None
    let v12 : Mut2 = {l0 = v11} : Mut2
    closure7(v7, v8, v9, v10, v12)
and format_real_27 (v0 : uint64) : string =
    let v1 : string = method16()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method17(v2, v3)
    let v4 : string = v2.l0
    v4
and format_real_29 (v0 : int8) : string =
    let v1 : string = method16()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method17(v2, v3)
    let v4 : string = v2.l0
    v4
and method28 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.calculate_dice_count"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "max"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = format_real_27(v8)
    let v29 : string = v27 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "p"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v26 
    let v35 : string = format_real_27(v9)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "n"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v26 
    let v41 : string = format_real_29(v10)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v21 + v46 
    method20(v47)
and method26 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : bool = v2 > 3074457345618258602UL
        if v4 then
            let v5 : string = format_real_27(v0)
            let v6 : string = "dice.calculate_dice_count / max: "
            let v7 : string = v6 + v5 
            let v8 : string = " is above the largest supported bound "
            let v9 : string = v7 + v8 
            let v10 : string = format_real_27(v2)
            let v11 : string = v9 + v10 
            failwith<int8> v11
        else
            let v13 : int8 = v1 + 1y
            let v14 : uint64 = v2 * 6UL
            method26(v0, v13, v14)
    else
        let v17 : bool = TraceState.trace_state.IsNone
        if v17 then
            let v18 : US2 = US2_Verbose
            let struct (v19 : Mut1, v20 : Mut3, v21 : Mut4, v22 : Mut5, v23 : Mut6, v24 : int64 option) = new_trace_state_6(v18)
            let v25 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v19, v20, v21, v22, v23, v24) 
            TraceState.trace_state <- v25 
            ()
        let struct (v26 : Mut1, v27 : Mut3, v28 : Mut4, v29 : Mut5, v30 : Mut6, v31 : int64 option) = TraceState.trace_state.Value
        let v32 : US2 = v30.l0
        let v37 : int32 =
            match v32 with
            | US2_Critical -> (* Critical *)
                50
            | US2_Debug -> (* Debug *)
                20
            | US2_Info -> (* Info *)
                30
            | US2_Verbose -> (* Verbose *)
                10
            | US2_Warning -> (* Warning *)
                40
        let v38 : bool = v28.l0
        let v39 : bool = v38 = false
        let v41 : bool =
            if v39 then
                false
            else
                let v40 : bool = 20 >= v37
                v40
        let v42 : bool = v41 = false
        let v82 : US6 =
            if v42 then
                US6_None
            else
                let v44 : bool = TraceState.trace_state.IsNone
                if v44 then
                    let v45 : US2 = US2_Verbose
                    let struct (v46 : Mut1, v47 : Mut3, v48 : Mut4, v49 : Mut5, v50 : Mut6, v51 : int64 option) = new_trace_state_6(v45)
                    let v52 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v46, v47, v48, v49, v50, v51) 
                    TraceState.trace_state <- v52 
                    ()
                let struct (v53 : Mut1, v54 : Mut3, v55 : Mut4, v56 : Mut5, v57 : Mut6, v58 : int64 option) = TraceState.trace_state.Value
                let v59 : string = method11(v53, v54, v55, v56, v57, v58)
                let v60 : string = method14()
                let v61 : string = method28(v53, v54, v55, v56, v57, v58, v59, v60, v0, v2, v1)
                let v62 : bool = TraceState.trace_state.IsNone
                if v62 then
                    let v63 : US2 = US2_Verbose
                    let struct (v64 : Mut1, v65 : Mut3, v66 : Mut4, v67 : Mut5, v68 : Mut6, v69 : int64 option) = new_trace_state_6(v63)
                    let v70 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v64, v65, v66, v67, v68, v69) 
                    TraceState.trace_state <- v70 
                    ()
                let struct (v71 : Mut1, v72 : Mut3, v73 : Mut4, v74 : Mut5, v75 : Mut6, v76 : int64 option) = TraceState.trace_state.Value
                let v77 : int64 = v71.l0
                let v78 : int64 = v77 + 1L
                v71.l0 <- v78
                let v79 : (string -> unit) = closure11()
                v79 v61
                let v80 : (string -> unit) = v72.l0
                v80 v61
                US6_Some(v71, v72, v73, v74, v75, v76)
        v1
and method32 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = format_real_29(v8)
    let v29 : string = v27 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v26 
    let v35 : string = format_real_27(v9)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "result"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v26 
    let v41 : string = format_real_27(v10)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v21 + v46 
    method20(v47)
and closure78 () () : UH2 =
    UH2_StreamNil
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_StreamCons(9223372036854775808UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_StreamCons(4611686018427387904UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_StreamCons(6917529027641081856UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_StreamCons(1152921504606846976UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_StreamCons(15564440312192434176UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_StreamCons(11817445422220181504UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_StreamCons(5044031582654955520UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_StreamCons(6989586621679009792UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_StreamCons(16537217831704461312UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_StreamCons(11979575008805519360UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_StreamCons(14294425217273954304UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_StreamCons(2382404202878992384UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_StreamCons(6545982058383015936UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_StreamCons(10314369046585278464UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_StreamCons(4793518853382471680UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_StreamCons(3873377154515337216UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_StreamCons(645562859085889536UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_StreamCons(107593809847648256UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_StreamCons(3092389647259533312UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_StreamCons(9738770311398031360UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_StreamCons(16995415113324298240UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_StreamCons(8981483876790566912UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_StreamCons(13794743361938128896UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_StreamCons(2299123893656354816UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_StreamCons(3457644661227651072UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_StreamCons(576274110204608512UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_StreamCons(6244960376270618624UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_StreamCons(13338656111851470848UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_StreamCons(14520938734448279552UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_StreamCons(14717985838214414336UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_StreamCons(5527454985320660992UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_StreamCons(16293529225644736512UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_StreamCons(11938960241128898560UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_StreamCons(8138741398091333632UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_StreamCons(7505371590918406144UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_StreamCons(16623181993244360704UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_StreamCons(8919445023443910656UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_StreamCons(4561031516192243712UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_StreamCons(9983543956220149760UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_StreamCons(4738381338321616896UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_StreamCons(789730223053602816UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_StreamCons(131621703842267136UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_StreamCons(21936950640377856UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_StreamCons(3656158440062976UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_StreamCons(609359740010496UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_StreamCons(101559956668416UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_StreamCons(16926659444736UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_StreamCons(2821109907456UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_StreamCons(470184984576UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_StreamCons(78364164096UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_StreamCons(13060694016UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_StreamCons(2176782336UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_StreamCons(362797056UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_StreamCons(60466176UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_StreamCons(10077696UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_StreamCons(1679616UL, v0)
and closure21 () () : UH2 =
    let v0 : (unit -> UH2) = closure22()
    UH2_StreamCons(279936UL, v0)
and closure20 () () : UH2 =
    let v0 : (unit -> UH2) = closure21()
    UH2_StreamCons(46656UL, v0)
and closure19 () () : UH2 =
    let v0 : (unit -> UH2) = closure20()
    UH2_StreamCons(7776UL, v0)
and closure18 () () : UH2 =
    let v0 : (unit -> UH2) = closure19()
    UH2_StreamCons(1296UL, v0)
and closure17 () () : UH2 =
    let v0 : (unit -> UH2) = closure18()
    UH2_StreamCons(216UL, v0)
and closure16 () () : UH2 =
    let v0 : (unit -> UH2) = closure17()
    UH2_StreamCons(36UL, v0)
and closure15 () () : UH2 =
    let v0 : (unit -> UH2) = closure16()
    UH2_StreamCons(6UL, v0)
and method33 (v0 : int8, v1 : UH2) : US8 =
    match v1 with
    | UH2_StreamCons(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US8_Some(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method33(v6, v7)
    | UH2_StreamNil -> (* StreamNil *)
        US8_None
and format_real_35 (v0 : uint8) : string =
    let v1 : string = method16()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v3 : string = $"{v0}"
    method17(v2, v3)
    let v4 : string = v2.l0
    v4
and method34 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v15 : string = format_real_19(v12)
    let v16 : string = v14 + v15 
    let v17 : string = v16 + v7 
    let v18 : string = v17 + v13 
    let v19 : string = "dice.accumulate_dice_rolls"
    let v20 : string = v18 + v19 
    let v21 : string = " / "
    let v22 : string = v20 + v21 
    let v23 : string = ""
    let v24 : string = v23 + v23 
    let v25 : string = "power"
    let v26 : string = v24 + v25 
    let v27 : string = " = "
    let v28 : string = v26 + v27 
    let v29 : string = format_real_29(v8)
    let v30 : string = v28 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v27 
    let v36 : string = format_real_27(v9)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v27 
    let v42 : string = format_real_35(v10)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v27 
    let v48 : string = format_real_27(v11)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v22 + v53 
    method20(v54)
and method36 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : string = format_real_29(v8)
    let v29 : string = v27 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v26 
    let v35 : string = format_real_27(v9)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v26 
    let v41 : string = format_real_35(v10)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v21 + v46 
    method20(v47)
and method31 (v0 : int8, v1 : UH1, v2 : uint64) : US7 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : bool = TraceState.trace_state.IsNone
        if v5 then
            let v6 : US2 = US2_Verbose
            let struct (v7 : Mut1, v8 : Mut3, v9 : Mut4, v10 : Mut5, v11 : Mut6, v12 : int64 option) = new_trace_state_6(v6)
            let v13 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v7, v8, v9, v10, v11, v12) 
            TraceState.trace_state <- v13 
            ()
        let struct (v14 : Mut1, v15 : Mut3, v16 : Mut4, v17 : Mut5, v18 : Mut6, v19 : int64 option) = TraceState.trace_state.Value
        let v20 : US2 = v18.l0
        let v25 : int32 =
            match v20 with
            | US2_Critical -> (* Critical *)
                50
            | US2_Debug -> (* Debug *)
                20
            | US2_Info -> (* Info *)
                30
            | US2_Verbose -> (* Verbose *)
                10
            | US2_Warning -> (* Warning *)
                40
        let v26 : bool = v16.l0
        let v27 : bool = v26 = false
        let v29 : bool =
            if v27 then
                false
            else
                let v28 : bool = 20 >= v25
                v28
        let v30 : bool = v29 = false
        let v70 : US6 =
            if v30 then
                US6_None
            else
                let v32 : bool = TraceState.trace_state.IsNone
                if v32 then
                    let v33 : US2 = US2_Verbose
                    let struct (v34 : Mut1, v35 : Mut3, v36 : Mut4, v37 : Mut5, v38 : Mut6, v39 : int64 option) = new_trace_state_6(v33)
                    let v40 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v34, v35, v36, v37, v38, v39) 
                    TraceState.trace_state <- v40 
                    ()
                let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
                let v47 : string = method11(v41, v42, v43, v44, v45, v46)
                let v48 : string = method14()
                let v49 : string = method32(v41, v42, v43, v44, v45, v46, v47, v48, v0, v2, v4)
                let v50 : bool = TraceState.trace_state.IsNone
                if v50 then
                    let v51 : US2 = US2_Verbose
                    let struct (v52 : Mut1, v53 : Mut3, v54 : Mut4, v55 : Mut5, v56 : Mut6, v57 : int64 option) = new_trace_state_6(v51)
                    let v58 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v52, v53, v54, v55, v56, v57) 
                    TraceState.trace_state <- v58 
                    ()
                let struct (v59 : Mut1, v60 : Mut3, v61 : Mut4, v62 : Mut5, v63 : Mut6, v64 : int64 option) = TraceState.trace_state.Value
                let v65 : int64 = v59.l0
                let v66 : int64 = v65 + 1L
                v59.l0 <- v66
                let v67 : (string -> unit) = closure11()
                v67 v49
                let v68 : (string -> unit) = v60.l0
                v68 v49
                US6_Some(v59, v60, v61, v62, v63, v64)
        US7_Some(v4, v1)
    else
        match v1 with
        | UH1_Cons(v73, v74) -> (* Cons *)
            let v75 : bool = v73 > 1uy
            if v75 then
                let v76 : uint64 = 1UL
                let v77 : (unit -> UH2) = closure15()
                let v78 : UH2 = UH2_StreamCons(v76, v77)
                let v79 : US8 = method33(v0, v78)
                let v83 : uint64 =
                    match v79 with
                    | US8_None -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US8_Some(v80) -> (* Some *)
                        v80
                let v84 : uint8 = v73 - 1uy
                let v85 : uint64 = uint64 v84
                let v86 : uint64 = v85 * v83
                let v87 : bool = TraceState.trace_state.IsNone
                if v87 then
                    let v88 : US2 = US2_Verbose
                    let struct (v89 : Mut1, v90 : Mut3, v91 : Mut4, v92 : Mut5, v93 : Mut6, v94 : int64 option) = new_trace_state_6(v88)
                    let v95 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v89, v90, v91, v92, v93, v94) 
                    TraceState.trace_state <- v95 
                    ()
                let struct (v96 : Mut1, v97 : Mut3, v98 : Mut4, v99 : Mut5, v100 : Mut6, v101 : int64 option) = TraceState.trace_state.Value
                let v102 : US2 = v100.l0
                let v107 : int32 =
                    match v102 with
                    | US2_Critical -> (* Critical *)
                        50
                    | US2_Debug -> (* Debug *)
                        20
                    | US2_Info -> (* Info *)
                        30
                    | US2_Verbose -> (* Verbose *)
                        10
                    | US2_Warning -> (* Warning *)
                        40
                let v108 : bool = v98.l0
                let v109 : bool = v108 = false
                let v111 : bool =
                    if v109 then
                        false
                    else
                        let v110 : bool = 20 >= v107
                        v110
                let v112 : bool = v111 = false
                let v152 : US6 =
                    if v112 then
                        US6_None
                    else
                        let v114 : bool = TraceState.trace_state.IsNone
                        if v114 then
                            let v115 : US2 = US2_Verbose
                            let struct (v116 : Mut1, v117 : Mut3, v118 : Mut4, v119 : Mut5, v120 : Mut6, v121 : int64 option) = new_trace_state_6(v115)
                            let v122 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v116, v117, v118, v119, v120, v121) 
                            TraceState.trace_state <- v122 
                            ()
                        let struct (v123 : Mut1, v124 : Mut3, v125 : Mut4, v126 : Mut5, v127 : Mut6, v128 : int64 option) = TraceState.trace_state.Value
                        let v129 : string = method11(v123, v124, v125, v126, v127, v128)
                        let v130 : string = method14()
                        let v131 : string = method34(v123, v124, v125, v126, v127, v128, v129, v130, v0, v2, v73, v86)
                        let v132 : bool = TraceState.trace_state.IsNone
                        if v132 then
                            let v133 : US2 = US2_Verbose
                            let struct (v134 : Mut1, v135 : Mut3, v136 : Mut4, v137 : Mut5, v138 : Mut6, v139 : int64 option) = new_trace_state_6(v133)
                            let v140 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v134, v135, v136, v137, v138, v139) 
                            TraceState.trace_state <- v140 
                            ()
                        let struct (v141 : Mut1, v142 : Mut3, v143 : Mut4, v144 : Mut5, v145 : Mut6, v146 : int64 option) = TraceState.trace_state.Value
                        let v147 : int64 = v141.l0
                        let v148 : int64 = v147 + 1L
                        v141.l0 <- v148
                        let v149 : (string -> unit) = closure11()
                        v149 v131
                        let v150 : (string -> unit) = v142.l0
                        v150 v131
                        US6_Some(v141, v142, v143, v144, v145, v146)
                let v153 : uint64 = v2 + v86
                let v154 : int8 = v0 - 1y
                method31(v154, v74, v153)
            else
                let v156 : bool = TraceState.trace_state.IsNone
                if v156 then
                    let v157 : US2 = US2_Verbose
                    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = new_trace_state_6(v157)
                    let v164 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v158, v159, v160, v161, v162, v163) 
                    TraceState.trace_state <- v164 
                    ()
                let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
                let v171 : US2 = v169.l0
                let v176 : int32 =
                    match v171 with
                    | US2_Critical -> (* Critical *)
                        50
                    | US2_Debug -> (* Debug *)
                        20
                    | US2_Info -> (* Info *)
                        30
                    | US2_Verbose -> (* Verbose *)
                        10
                    | US2_Warning -> (* Warning *)
                        40
                let v177 : bool = v167.l0
                let v178 : bool = v177 = false
                let v180 : bool =
                    if v178 then
                        false
                    else
                        let v179 : bool = 20 >= v176
                        v179
                let v181 : bool = v180 = false
                let v221 : US6 =
                    if v181 then
                        US6_None
                    else
                        let v183 : bool = TraceState.trace_state.IsNone
                        if v183 then
                            let v184 : US2 = US2_Verbose
                            let struct (v185 : Mut1, v186 : Mut3, v187 : Mut4, v188 : Mut5, v189 : Mut6, v190 : int64 option) = new_trace_state_6(v184)
                            let v191 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v185, v186, v187, v188, v189, v190) 
                            TraceState.trace_state <- v191 
                            ()
                        let struct (v192 : Mut1, v193 : Mut3, v194 : Mut4, v195 : Mut5, v196 : Mut6, v197 : int64 option) = TraceState.trace_state.Value
                        let v198 : string = method11(v192, v193, v194, v195, v196, v197)
                        let v199 : string = method14()
                        let v200 : string = method36(v192, v193, v194, v195, v196, v197, v198, v199, v0, v2, v73)
                        let v201 : bool = TraceState.trace_state.IsNone
                        if v201 then
                            let v202 : US2 = US2_Verbose
                            let struct (v203 : Mut1, v204 : Mut3, v205 : Mut4, v206 : Mut5, v207 : Mut6, v208 : int64 option) = new_trace_state_6(v202)
                            let v209 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v203, v204, v205, v206, v207, v208) 
                            TraceState.trace_state <- v209 
                            ()
                        let struct (v210 : Mut1, v211 : Mut3, v212 : Mut4, v213 : Mut5, v214 : Mut6, v215 : int64 option) = TraceState.trace_state.Value
                        let v216 : int64 = v210.l0
                        let v217 : int64 = v216 + 1L
                        v210.l0 <- v217
                        let v218 : (string -> unit) = closure11()
                        v218 v200
                        let v219 : (string -> unit) = v211.l0
                        v219 v200
                        US6_Some(v210, v211, v212, v213, v214, v215)
                let v222 : int8 = v0 - 1y
                method31(v222, v74, v2)
        | UH1_Nil -> (* Nil *)
            US7_None
and method37 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method37(v0, v1, v5)
        UH1_Cons(v4, v6)
    else
        UH1_Nil
and method38 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_Cons(v7, v4)
        method30(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US7 = method31(v3, v4, v10)
        match v11 with
        | US7_Some(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method37(v3, v0, v15)
                    method38(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_Cons(v18, v4)
                    method30(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method37(v3, v0, v23)
                method38(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_Cons(v26, v4)
                method30(v0, v1, v2, v3, v27, v5)
and method30 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_Cons(v8, v4)
        let v10 : int8 = v5 + 1y
        method30(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US7 = method31(v3, v4, v12)
        match v13 with
        | US7_Some(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method37(v3, v0, v17)
                    method38(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_Cons(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method30(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method37(v3, v0, v26)
                method38(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_Cons(v29, v4)
                let v31 : int8 = v5 + 1y
                method30(v0, v1, v2, v3, v30, v31)
and closure14 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method26(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_Nil
    let v10 : int8 = 0y
    method30(v0, v1, v2, v8, v9, v10)
and closure13 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure14(v0, v1)
and closure12 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure13(v0)
and method39 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method39(v3, v4)
    | UH1_Nil -> (* Nil *)
        v1
and closure80 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method39(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US7 = method31(v4, v1, v5)
    let v16 : US8 =
        match v6 with
        | US7_Some(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US8_Some(v7)
            else
                US8_None
        | _ ->
            US8_None
    match v16 with
    | US8_None -> (* None *)
        let v19 : uint64 option = None
        v19
    | US8_Some(v17) -> (* Some *)
        let v18 : uint64 option = Some v17 
        v18
and roll_within_bounds__c79 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure80(v0)
and method40 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v9 : string = " "
    let v10 : string = v6 + v9 
    let v11 : string = format_real_19(v8)
    let v12 : string = v10 + v11 
    let v13 : string = v12 + v7 
    let v14 : string = v13 + v9 
    let v15 : string = "dice.calculate_dice_count"
    let v16 : string = v14 + v15 
    let v17 : string = " / "
    let v18 : string = v16 + v17 
    let v19 : string = ""
    let v20 : string = v19 + v19 
    let v21 : string = "max"
    let v22 : string = v20 + v21 
    let v23 : string = " = "
    let v24 : string = v22 + v23 
    let v25 : int64 = 4738381338321616896L
    let v26 : string = format_real_19(v25)
    let v27 : string = v24 + v26 
    let v28 : string = "; "
    let v29 : string = v27 + v28 
    let v30 : string = "p"
    let v31 : string = v29 + v30 
    let v32 : string = v31 + v23 
    let v33 : int64 = 4738381338321616896L
    let v34 : string = format_real_19(v33)
    let v35 : string = v32 + v34 
    let v36 : string = v35 + v28 
    let v37 : string = "n"
    let v38 : string = v36 + v37 
    let v39 : string = v38 + v23 
    let v40 : int8 = 24y
    let v41 : string = format_real_29(v40)
    let v42 : string = v39 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v18 + v46 
    method20(v47)
and closure82 () () : int32 =
    let v0 : int32 = 1uy |> int32 
    v0
and ok_c83 () (v0 : int32) : US9 =
    US9_Ok(v0)
and closure84 () (v0 : (unit -> exn)) : exn =
    v0 ()
and error_c85 () (v0 : exn) : US9 =
    US9_Error(v0)
and method43 () : US9 =
    let v0 : (unit -> int32) = closure82()
    let v1 : (int32 -> US9) = ok_c83()
    let v2 : ((unit -> exn) -> exn) = closure84()
    let v3 : (exn -> US9) = error_c85()
    let v4 : US9 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure86 () () : int32 =
    let v0 : int32 = 7uy |> int32 
    v0
and method44 () : US9 =
    let v0 : (unit -> int32) = closure86()
    let v1 : (int32 -> US9) = ok_c83()
    let v2 : ((unit -> exn) -> exn) = closure84()
    let v3 : (exn -> US9) = error_c85()
    let v4 : US9 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure87 (v0 : int32) () : uint8 =
    let v1 : uint8 = v0 |> uint8 
    v1
and ok_c88 () (v0 : uint8) : US11 =
    US11_Ok(v0)
and error_c89 () (v0 : exn) : US11 =
    US11_Error(v0)
and method45 (v0 : int32) : US11 =
    let v1 : (unit -> uint8) = closure87(v0)
    let v2 : (uint8 -> US11) = ok_c88()
    let v3 : ((unit -> exn) -> exn) = closure84()
    let v4 : (exn -> US11) = error_c89()
    let v5 : US11 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and roll_dice_42 () : uint8 =
    let v0 : (unit -> System.Random) = System.Random 
    let v1 : System.Random = v0 ()
    let v2 : US9 = method43()
    let v8 : US10 =
        match v2 with
        | US9_Error(v5) -> (* Error *)
            US10_None
        | US9_Ok(v3) -> (* Ok *)
            US10_Some(v3)
    let v12 : int32 =
        match v8 with
        | US10_None -> (* None *)
            failwith<int32> "Option does not have a value."
        | US10_Some(v9) -> (* Some *)
            v9
    let v13 : US9 = method44()
    let v19 : US10 =
        match v13 with
        | US9_Error(v16) -> (* Error *)
            US10_None
        | US9_Ok(v14) -> (* Ok *)
            US10_Some(v14)
    let v23 : int32 =
        match v19 with
        | US10_None -> (* None *)
            failwith<int32> "Option does not have a value."
        | US10_Some(v20) -> (* Some *)
            v20
    let v24 : int32 = v1.Next (v12, v23)
    let v25 : US11 = method45(v24)
    let v31 : US1 =
        match v25 with
        | US11_Error(v28) -> (* Error *)
            US1_None
        | US11_Ok(v26) -> (* Ok *)
            US1_Some(v26)
    match v31 with
    | US1_None -> (* None *)
        failwith<uint8> "Option does not have a value."
    | US1_Some(v32) -> (* Some *)
        v32
and method47 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 23y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method49 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 22y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method51 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 21y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method53 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 20y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method55 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 19y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method57 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 18y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method59 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 17y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method61 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 16y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method63 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 15y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method65 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 14y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method67 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 13y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method69 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 12y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method71 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 11y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method73 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 10y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method75 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 9y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method77 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 8y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method79 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 7y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method81 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 6y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method83 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 5y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method85 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 4y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method87 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 3y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method89 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 2y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method91 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 1y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method93 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = format_real_19(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = ""
    let v23 : string = v22 + v22 
    let v24 : string = "power"
    let v25 : string = v23 + v24 
    let v26 : string = " = "
    let v27 : string = v25 + v26 
    let v28 : int8 = 0y
    let v29 : string = format_real_29(v28)
    let v30 : string = v27 + v29 
    let v31 : string = "; "
    let v32 : string = v30 + v31 
    let v33 : string = "acc"
    let v34 : string = v32 + v33 
    let v35 : string = v34 + v26 
    let v36 : string = format_real_19(v8)
    let v37 : string = v35 + v36 
    let v38 : string = v37 + v31 
    let v39 : string = "roll"
    let v40 : string = v38 + v39 
    let v41 : string = v40 + v26 
    let v42 : string = format_real_35(v9)
    let v43 : string = v41 + v42 
    let v44 : string = v43 + v31 
    let v45 : string = "value"
    let v46 : string = v44 + v45 
    let v47 : string = v46 + v26 
    let v48 : string = format_real_19(v10)
    let v49 : string = v47 + v48 
    let v50 : string = "{ "
    let v51 : string = v50 + v49 
    let v52 : string = " }"
    let v53 : string = v51 + v52 
    let v54 : string = v21 + v53 
    method20(v54)
and method95 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = -1y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "result"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_19(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method94 (v0 : UH1, v1 : int64) : US12 =
    let v2 : int64 = v1 + 1L
    let v3 : bool = TraceState.trace_state.IsNone
    if v3 then
        let v4 : US2 = US2_Verbose
        let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = new_trace_state_6(v4)
        let v11 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v5, v6, v7, v8, v9, v10) 
        TraceState.trace_state <- v11 
        ()
    let struct (v12 : Mut1, v13 : Mut3, v14 : Mut4, v15 : Mut5, v16 : Mut6, v17 : int64 option) = TraceState.trace_state.Value
    let v18 : US2 = v16.l0
    let v23 : int32 =
        match v18 with
        | US2_Critical -> (* Critical *)
            50
        | US2_Debug -> (* Debug *)
            20
        | US2_Info -> (* Info *)
            30
        | US2_Verbose -> (* Verbose *)
            10
        | US2_Warning -> (* Warning *)
            40
    let v24 : bool = v14.l0
    let v25 : bool = v24 = false
    let v27 : bool =
        if v25 then
            false
        else
            let v26 : bool = 20 >= v23
            v26
    let v28 : bool = v27 = false
    let v68 : US6 =
        if v28 then
            US6_None
        else
            let v30 : bool = TraceState.trace_state.IsNone
            if v30 then
                let v31 : US2 = US2_Verbose
                let struct (v32 : Mut1, v33 : Mut3, v34 : Mut4, v35 : Mut5, v36 : Mut6, v37 : int64 option) = new_trace_state_6(v31)
                let v38 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v32, v33, v34, v35, v36, v37) 
                TraceState.trace_state <- v38 
                ()
            let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
            let v45 : string = method11(v39, v40, v41, v42, v43, v44)
            let v46 : string = method14()
            let v47 : string = method95(v39, v40, v41, v42, v43, v44, v45, v46, v1, v2)
            let v48 : bool = TraceState.trace_state.IsNone
            if v48 then
                let v49 : US2 = US2_Verbose
                let struct (v50 : Mut1, v51 : Mut3, v52 : Mut4, v53 : Mut5, v54 : Mut6, v55 : int64 option) = new_trace_state_6(v49)
                let v56 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v50, v51, v52, v53, v54, v55) 
                TraceState.trace_state <- v56 
                ()
            let struct (v57 : Mut1, v58 : Mut3, v59 : Mut4, v60 : Mut5, v61 : Mut6, v62 : int64 option) = TraceState.trace_state.Value
            let v63 : int64 = v57.l0
            let v64 : int64 = v63 + 1L
            v57.l0 <- v64
            let v65 : (string -> unit) = closure11()
            v65 v47
            let v66 : (string -> unit) = v58.l0
            v66 v47
            US6_Some(v57, v58, v59, v60, v61, v62)
    US12_Some(v2, v0)
and method96 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 0y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method92 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : bool = TraceState.trace_state.IsNone
            if v8 then
                let v9 : US2 = US2_Verbose
                let struct (v10 : Mut1, v11 : Mut3, v12 : Mut4, v13 : Mut5, v14 : Mut6, v15 : int64 option) = new_trace_state_6(v9)
                let v16 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v10, v11, v12, v13, v14, v15) 
                TraceState.trace_state <- v16 
                ()
            let struct (v17 : Mut1, v18 : Mut3, v19 : Mut4, v20 : Mut5, v21 : Mut6, v22 : int64 option) = TraceState.trace_state.Value
            let v23 : US2 = v21.l0
            let v28 : int32 =
                match v23 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v29 : bool = v19.l0
            let v30 : bool = v29 = false
            let v32 : bool =
                if v30 then
                    false
                else
                    let v31 : bool = 20 >= v28
                    v31
            let v33 : bool = v32 = false
            let v73 : US6 =
                if v33 then
                    US6_None
                else
                    let v35 : bool = TraceState.trace_state.IsNone
                    if v35 then
                        let v36 : US2 = US2_Verbose
                        let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = new_trace_state_6(v36)
                        let v43 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v37, v38, v39, v40, v41, v42) 
                        TraceState.trace_state <- v43 
                        ()
                    let struct (v44 : Mut1, v45 : Mut3, v46 : Mut4, v47 : Mut5, v48 : Mut6, v49 : int64 option) = TraceState.trace_state.Value
                    let v50 : string = method11(v44, v45, v46, v47, v48, v49)
                    let v51 : string = method14()
                    let v52 : string = method93(v44, v45, v46, v47, v48, v49, v50, v51, v1, v3, v7)
                    let v53 : bool = TraceState.trace_state.IsNone
                    if v53 then
                        let v54 : US2 = US2_Verbose
                        let struct (v55 : Mut1, v56 : Mut3, v57 : Mut4, v58 : Mut5, v59 : Mut6, v60 : int64 option) = new_trace_state_6(v54)
                        let v61 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v55, v56, v57, v58, v59, v60) 
                        TraceState.trace_state <- v61 
                        ()
                    let struct (v62 : Mut1, v63 : Mut3, v64 : Mut4, v65 : Mut5, v66 : Mut6, v67 : int64 option) = TraceState.trace_state.Value
                    let v68 : int64 = v62.l0
                    let v69 : int64 = v68 + 1L
                    v62.l0 <- v69
                    let v70 : (string -> unit) = closure11()
                    v70 v52
                    let v71 : (string -> unit) = v63.l0
                    v71 v52
                    US6_Some(v62, v63, v64, v65, v66, v67)
            let v74 : int64 = v1 + v7
            method94(v4, v74)
        else
            let v76 : bool = TraceState.trace_state.IsNone
            if v76 then
                let v77 : US2 = US2_Verbose
                let struct (v78 : Mut1, v79 : Mut3, v80 : Mut4, v81 : Mut5, v82 : Mut6, v83 : int64 option) = new_trace_state_6(v77)
                let v84 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v78, v79, v80, v81, v82, v83) 
                TraceState.trace_state <- v84 
                ()
            let struct (v85 : Mut1, v86 : Mut3, v87 : Mut4, v88 : Mut5, v89 : Mut6, v90 : int64 option) = TraceState.trace_state.Value
            let v91 : US2 = v89.l0
            let v96 : int32 =
                match v91 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v97 : bool = v87.l0
            let v98 : bool = v97 = false
            let v100 : bool =
                if v98 then
                    false
                else
                    let v99 : bool = 20 >= v96
                    v99
            let v101 : bool = v100 = false
            let v141 : US6 =
                if v101 then
                    US6_None
                else
                    let v103 : bool = TraceState.trace_state.IsNone
                    if v103 then
                        let v104 : US2 = US2_Verbose
                        let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = new_trace_state_6(v104)
                        let v111 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v105, v106, v107, v108, v109, v110) 
                        TraceState.trace_state <- v111 
                        ()
                    let struct (v112 : Mut1, v113 : Mut3, v114 : Mut4, v115 : Mut5, v116 : Mut6, v117 : int64 option) = TraceState.trace_state.Value
                    let v118 : string = method11(v112, v113, v114, v115, v116, v117)
                    let v119 : string = method14()
                    let v120 : string = method96(v112, v113, v114, v115, v116, v117, v118, v119, v1, v3)
                    let v121 : bool = TraceState.trace_state.IsNone
                    if v121 then
                        let v122 : US2 = US2_Verbose
                        let struct (v123 : Mut1, v124 : Mut3, v125 : Mut4, v126 : Mut5, v127 : Mut6, v128 : int64 option) = new_trace_state_6(v122)
                        let v129 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v123, v124, v125, v126, v127, v128) 
                        TraceState.trace_state <- v129 
                        ()
                    let struct (v130 : Mut1, v131 : Mut3, v132 : Mut4, v133 : Mut5, v134 : Mut6, v135 : int64 option) = TraceState.trace_state.Value
                    let v136 : int64 = v130.l0
                    let v137 : int64 = v136 + 1L
                    v130.l0 <- v137
                    let v138 : (string -> unit) = closure11()
                    v138 v120
                    let v139 : (string -> unit) = v131.l0
                    v139 v120
                    US6_Some(v130, v131, v132, v133, v134, v135)
            method94(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method97 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 1y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method90 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method91(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method92(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method97(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method92(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method98 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 2y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method88 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method89(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method90(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method98(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method90(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method99 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 3y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method86 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method87(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method88(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method99(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method88(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method100 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 4y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method84 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method85(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method86(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method100(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method86(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 5y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method82 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method83(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method84(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method101(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method84(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method102 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 6y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method80 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method81(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method82(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method102(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method82(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 7y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method78 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method79(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method80(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method103(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method80(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method104 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 8y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method76 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method77(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method78(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method104(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method78(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 9y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method74 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method75(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method76(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method105(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method76(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method106 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 10y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method72 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method73(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method74(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method106(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method74(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 11y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method70 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method71(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method72(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method107(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method72(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method108 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 12y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method68 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method69(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method70(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method108(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method70(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 13y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method66 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method67(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method68(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method109(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method68(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method110 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 14y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method64 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method65(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method66(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method110(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method66(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 15y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method62 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method63(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method64(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method111(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method64(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method112 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 16y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method60 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method61(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method62(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method112(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method62(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 17y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method58 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method59(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method60(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method113(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method60(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method114 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 18y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method56 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method57(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method58(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method114(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method58(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method115 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 19y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method54 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method55(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method56(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method115(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method56(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method116 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 20y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method52 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method53(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method54(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method116(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method54(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method117 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 21y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method50 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method51(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method52(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method117(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method52(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method118 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 22y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method48 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method49(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method50(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method118(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method50(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method119 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = format_real_19(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : string = ""
    let v22 : string = v21 + v21 
    let v23 : string = "power"
    let v24 : string = v22 + v23 
    let v25 : string = " = "
    let v26 : string = v24 + v25 
    let v27 : int8 = 23y
    let v28 : string = format_real_29(v27)
    let v29 : string = v26 + v28 
    let v30 : string = "; "
    let v31 : string = v29 + v30 
    let v32 : string = "acc"
    let v33 : string = v31 + v32 
    let v34 : string = v33 + v25 
    let v35 : string = format_real_19(v8)
    let v36 : string = v34 + v35 
    let v37 : string = v36 + v30 
    let v38 : string = "roll"
    let v39 : string = v37 + v38 
    let v40 : string = v39 + v25 
    let v41 : string = format_real_35(v9)
    let v42 : string = v40 + v41 
    let v43 : string = "{ "
    let v44 : string = v43 + v42 
    let v45 : string = " }"
    let v46 : string = v44 + v45 
    let v47 : string = v20 + v46 
    method20(v47)
and method46 (v0 : UH1, v1 : int64) : US12 =
    match v0 with
    | UH1_Cons(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_Verbose
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = new_trace_state_6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US6 =
                if v34 then
                    US6_None
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_Verbose
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = new_trace_state_6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method11(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method14()
                    let v53 : string = method47(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_Verbose
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = new_trace_state_6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure11()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US6_Some(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method48(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_Verbose
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = new_trace_state_6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
                | US2_Critical -> (* Critical *)
                    50
                | US2_Debug -> (* Debug *)
                    20
                | US2_Info -> (* Info *)
                    30
                | US2_Verbose -> (* Verbose *)
                    10
                | US2_Warning -> (* Warning *)
                    40
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US6 =
                if v102 then
                    US6_None
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_Verbose
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = new_trace_state_6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method11(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method14()
                    let v121 : string = method119(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_Verbose
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = new_trace_state_6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure11()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US6_Some(v131, v132, v133, v134, v135, v136)
            method48(v4, v1)
    | UH1_Nil -> (* Nil *)
        US12_None
and method41 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = roll_dice_42()
        let v4 : UH1 = UH1_Cons(v3, v0)
        let v5 : int8 = v1 + 1y
        method41(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US12 = method46(v0, v7)
        match v8 with
        | US12_Some(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 4738381338321616896L
            if v11 then
                v9
            else
                let v12 : uint8 = roll_dice_42()
                let v13 : uint8 = roll_dice_42()
                let v14 : uint8 = roll_dice_42()
                let v15 : uint8 = roll_dice_42()
                let v16 : uint8 = roll_dice_42()
                let v17 : uint8 = roll_dice_42()
                let v18 : uint8 = roll_dice_42()
                let v19 : uint8 = roll_dice_42()
                let v20 : uint8 = roll_dice_42()
                let v21 : uint8 = roll_dice_42()
                let v22 : uint8 = roll_dice_42()
                let v23 : uint8 = roll_dice_42()
                let v24 : uint8 = roll_dice_42()
                let v25 : uint8 = roll_dice_42()
                let v26 : uint8 = roll_dice_42()
                let v27 : uint8 = roll_dice_42()
                let v28 : uint8 = roll_dice_42()
                let v29 : uint8 = roll_dice_42()
                let v30 : uint8 = roll_dice_42()
                let v31 : uint8 = roll_dice_42()
                let v32 : uint8 = roll_dice_42()
                let v33 : uint8 = roll_dice_42()
                let v34 : uint8 = roll_dice_42()
                let v35 : UH1 = UH1_Nil
                let v36 : UH1 = UH1_Cons(v34, v35)
                let v37 : UH1 = UH1_Cons(v33, v36)
                let v38 : UH1 = UH1_Cons(v32, v37)
                let v39 : UH1 = UH1_Cons(v31, v38)
                let v40 : UH1 = UH1_Cons(v30, v39)
                let v41 : UH1 = UH1_Cons(v29, v40)
                let v42 : UH1 = UH1_Cons(v28, v41)
                let v43 : UH1 = UH1_Cons(v27, v42)
                let v44 : UH1 = UH1_Cons(v26, v43)
                let v45 : UH1 = UH1_Cons(v25, v44)
                let v46 : UH1 = UH1_Cons(v24, v45)
                let v47 : UH1 = UH1_Cons(v23, v46)
                let v48 : UH1 = UH1_Cons(v22, v47)
                let v49 : UH1 = UH1_Cons(v21, v48)
                let v50 : UH1 = UH1_Cons(v20, v49)
                let v51 : UH1 = UH1_Cons(v19, v50)
                let v52 : UH1 = UH1_Cons(v18, v51)
                let v53 : UH1 = UH1_Cons(v17, v52)
                let v54 : UH1 = UH1_Cons(v16, v53)
                let v55 : UH1 = UH1_Cons(v15, v54)
                let v56 : UH1 = UH1_Cons(v14, v55)
                let v57 : UH1 = UH1_Cons(v13, v56)
                let v58 : UH1 = UH1_Cons(v12, v57)
                let v59 : int8 = 23y
                method41(v58, v59)
        | _ ->
            let v62 : uint8 = roll_dice_42()
            let v63 : uint8 = roll_dice_42()
            let v64 : uint8 = roll_dice_42()
            let v65 : uint8 = roll_dice_42()
            let v66 : uint8 = roll_dice_42()
            let v67 : uint8 = roll_dice_42()
            let v68 : uint8 = roll_dice_42()
            let v69 : uint8 = roll_dice_42()
            let v70 : uint8 = roll_dice_42()
            let v71 : uint8 = roll_dice_42()
            let v72 : uint8 = roll_dice_42()
            let v73 : uint8 = roll_dice_42()
            let v74 : uint8 = roll_dice_42()
            let v75 : uint8 = roll_dice_42()
            let v76 : uint8 = roll_dice_42()
            let v77 : uint8 = roll_dice_42()
            let v78 : uint8 = roll_dice_42()
            let v79 : uint8 = roll_dice_42()
            let v80 : uint8 = roll_dice_42()
            let v81 : uint8 = roll_dice_42()
            let v82 : uint8 = roll_dice_42()
            let v83 : uint8 = roll_dice_42()
            let v84 : uint8 = roll_dice_42()
            let v85 : UH1 = UH1_Nil
            let v86 : UH1 = UH1_Cons(v84, v85)
            let v87 : UH1 = UH1_Cons(v83, v86)
            let v88 : UH1 = UH1_Cons(v82, v87)
            let v89 : UH1 = UH1_Cons(v81, v88)
            let v90 : UH1 = UH1_Cons(v80, v89)
            let v91 : UH1 = UH1_Cons(v79, v90)
            let v92 : UH1 = UH1_Cons(v78, v91)
            let v93 : UH1 = UH1_Cons(v77, v92)
            let v94 : UH1 = UH1_Cons(v76, v93)
            let v95 : UH1 = UH1_Cons(v75, v94)
            let v96 : UH1 = UH1_Cons(v74, v95)
            let v97 : UH1 = UH1_Cons(v73, v96)
            let v98 : UH1 = UH1_Cons(v72, v97)
            let v99 : UH1 = UH1_Cons(v71, v98)
            let v100 : UH1 = UH1_Cons(v70, v99)
            let v101 : UH1 = UH1_Cons(v69, v100)
            let v102 : UH1 = UH1_Cons(v68, v101)
            let v103 : UH1 = UH1_Cons(v67, v102)
            let v104 : UH1 = UH1_Cons(v66, v103)
            let v105 : UH1 = UH1_Cons(v65, v104)
            let v106 : UH1 = UH1_Cons(v64, v105)
            let v107 : UH1 = UH1_Cons(v63, v106)
            let v108 : UH1 = UH1_Cons(v62, v107)
            let v109 : int8 = 23y
            method41(v108, v109)
and method120 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = format_real_19(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v16 : string = "dice.main"
    let v17 : string = v15 + v16 
    let v18 : string = " / "
    let v19 : string = v17 + v18 
    let v20 : string = ""
    let v21 : string = v20 + v20 
    let v22 : string = "result"
    let v23 : string = v21 + v22 
    let v24 : string = " = "
    let v25 : string = v23 + v24 
    let v26 : string = format_real_19(v8)
    let v27 : string = v25 + v26 
    let v28 : string = "{ "
    let v29 : string = v28 + v27 
    let v30 : string = " }"
    let v31 : string = v29 + v30 
    let v32 : string = v19 + v31 
    method20(v32)
and closure81 () (v0 : (string [])) : int32 =
    let v1 : bool = TraceState.trace_state.IsNone
    if v1 then
        let v2 : US2 = US2_Verbose
        let struct (v3 : Mut1, v4 : Mut3, v5 : Mut4, v6 : Mut5, v7 : Mut6, v8 : int64 option) = new_trace_state_6(v2)
        let v9 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v3, v4, v5, v6, v7, v8) 
        TraceState.trace_state <- v9 
        ()
    let struct (v10 : Mut1, v11 : Mut3, v12 : Mut4, v13 : Mut5, v14 : Mut6, v15 : int64 option) = TraceState.trace_state.Value
    let v16 : US2 = v14.l0
    let v21 : int32 =
        match v16 with
        | US2_Critical -> (* Critical *)
            50
        | US2_Debug -> (* Debug *)
            20
        | US2_Info -> (* Info *)
            30
        | US2_Verbose -> (* Verbose *)
            10
        | US2_Warning -> (* Warning *)
            40
    let v22 : bool = v12.l0
    let v23 : bool = v22 = false
    let v25 : bool =
        if v23 then
            false
        else
            let v24 : bool = 20 >= v21
            v24
    let v26 : bool = v25 = false
    let v66 : US6 =
        if v26 then
            US6_None
        else
            let v28 : bool = TraceState.trace_state.IsNone
            if v28 then
                let v29 : US2 = US2_Verbose
                let struct (v30 : Mut1, v31 : Mut3, v32 : Mut4, v33 : Mut5, v34 : Mut6, v35 : int64 option) = new_trace_state_6(v29)
                let v36 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v30, v31, v32, v33, v34, v35) 
                TraceState.trace_state <- v36 
                ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : string = method11(v37, v38, v39, v40, v41, v42)
            let v44 : string = method14()
            let v45 : string = method40(v37, v38, v39, v40, v41, v42, v43, v44)
            let v46 : bool = TraceState.trace_state.IsNone
            if v46 then
                let v47 : US2 = US2_Verbose
                let struct (v48 : Mut1, v49 : Mut3, v50 : Mut4, v51 : Mut5, v52 : Mut6, v53 : int64 option) = new_trace_state_6(v47)
                let v54 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v48, v49, v50, v51, v52, v53) 
                TraceState.trace_state <- v54 
                ()
            let struct (v55 : Mut1, v56 : Mut3, v57 : Mut4, v58 : Mut5, v59 : Mut6, v60 : int64 option) = TraceState.trace_state.Value
            let v61 : int64 = v55.l0
            let v62 : int64 = v61 + 1L
            v55.l0 <- v62
            let v63 : (string -> unit) = closure11()
            v63 v45
            let v64 : (string -> unit) = v56.l0
            v64 v45
            US6_Some(v55, v56, v57, v58, v59, v60)
    let v67 : UH1 = UH1_Nil
    let v68 : int8 = 0y
    let v69 : int64 = method41(v67, v68)
    let v70 : bool = TraceState.trace_state.IsNone
    if v70 then
        let v71 : US2 = US2_Verbose
        let struct (v72 : Mut1, v73 : Mut3, v74 : Mut4, v75 : Mut5, v76 : Mut6, v77 : int64 option) = new_trace_state_6(v71)
        let v78 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v72, v73, v74, v75, v76, v77) 
        TraceState.trace_state <- v78 
        ()
    let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = TraceState.trace_state.Value
    let v85 : US2 = v83.l0
    let v90 : int32 =
        match v85 with
        | US2_Critical -> (* Critical *)
            50
        | US2_Debug -> (* Debug *)
            20
        | US2_Info -> (* Info *)
            30
        | US2_Verbose -> (* Verbose *)
            10
        | US2_Warning -> (* Warning *)
            40
    let v91 : bool = v81.l0
    let v92 : bool = v91 = false
    let v94 : bool =
        if v92 then
            false
        else
            let v93 : bool = 20 >= v90
            v93
    let v95 : bool = v94 = false
    let v135 : US6 =
        if v95 then
            US6_None
        else
            let v97 : bool = TraceState.trace_state.IsNone
            if v97 then
                let v98 : US2 = US2_Verbose
                let struct (v99 : Mut1, v100 : Mut3, v101 : Mut4, v102 : Mut5, v103 : Mut6, v104 : int64 option) = new_trace_state_6(v98)
                let v105 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v99, v100, v101, v102, v103, v104) 
                TraceState.trace_state <- v105 
                ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v112 : string = method11(v106, v107, v108, v109, v110, v111)
            let v113 : string = method14()
            let v114 : string = method120(v106, v107, v108, v109, v110, v111, v112, v113, v69)
            let v115 : bool = TraceState.trace_state.IsNone
            if v115 then
                let v116 : US2 = US2_Verbose
                let struct (v117 : Mut1, v118 : Mut3, v119 : Mut4, v120 : Mut5, v121 : Mut6, v122 : int64 option) = new_trace_state_6(v116)
                let v123 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v117, v118, v119, v120, v121, v122) 
                TraceState.trace_state <- v123 
                ()
            let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = TraceState.trace_state.Value
            let v130 : int64 = v124.l0
            let v131 : int64 = v130 + 1L
            v124.l0 <- v131
            let v132 : (string -> unit) = closure11()
            v132 v114
            let v133 : (string -> unit) = v125.l0
            v133 v114
            US6_Some(v124, v125, v126, v127, v128, v129)
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure12()
let roll_progressively x = v2 x
let v3 : (uint64 -> (UH1 -> uint64 option)) = roll_within_bounds__c79()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure81()
let main args = v4 args
()
