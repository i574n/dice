module TraceState = let mutable trace_state = None
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
    | US5_0 of f0_0 : string
    | US5_1
and Mut7 = {mutable l0 : int32; mutable l1 : US3}
and [<Struct>] US6 =
    | US6_0 of f0_0 : int64
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : int64
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : int64
    | US8_1 of f1_0 : exn
and [<Struct>] US9 =
    | US9_0 of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut5 * f0_4 : Mut6 * f0_5 : int64 option
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : uint64 * f0_1 : UH1
    | US10_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US11 =
    | US11_0 of f0_0 : uint64
    | US11_1
and [<Struct>] US12 =
    | US12_0 of f0_0 : int32
    | US12_1 of f1_0 : exn
and [<Struct>] US13 =
    | US13_0 of f0_0 : int32
    | US13_1
and [<Struct>] US14 =
    | US14_0 of f0_0 : uint8
    | US14_1 of f1_0 : exn
and [<Struct>] US15 =
    | US15_0 of f0_0 : int64 * f0_1 : UH1
    | US15_1
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
and closure8 () (v0 : string) : US5 =
    US5_0(v0)
and method9 () : (string -> US5) =
    closure8()
and method8 (v0 : string) : string =
    let v2 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v3 : string = v2 v0
    let v4 : (string -> string option) = Option.ofObj
    let v5 : string option = v4 v3
    let v6 : (string -> US5) = method9()
    let v7 : US5 option = v5 |> Option.map v6 
    let v8 : US5 = US5_1
    let v9 : US5 = v7 |> Option.defaultValue v8 
    match v9 with
    | US5_1 -> (* None *)
        let v11 : string = ""
        v11
    | US5_0(v10) -> (* Some *)
        v10
and method10 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure9 (v0 : float) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure10 () (v0 : int64) : US6 =
    US6_0(v0)
and closure11 () (v0 : (unit -> exn)) : exn =
    v0 ()
and closure12 () (v0 : exn) : US6 =
    US6_1(v0)
and method11 (v0 : float) : US6 =
    let v1 : (unit -> int64) = closure9(v0)
    let v2 : (int64 -> US6) = closure10()
    let v3 : ((unit -> exn) -> exn) = closure11()
    let v4 : (exn -> US6) = closure12()
    let v5 : US6 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and closure13 (v0 : int64) () : int64 =
    let v1 : int64 = v0 |> int64 
    v1
and closure14 () (v0 : int64) : US8 =
    US8_0(v0)
and closure15 () (v0 : exn) : US8 =
    US8_1(v0)
and method12 (v0 : int64) : US8 =
    let v1 : (unit -> int64) = closure13(v0)
    let v2 : (int64 -> US8) = closure14()
    let v3 : ((unit -> exn) -> exn) = closure11()
    let v4 : (exn -> US8) = closure15()
    let v5 : US8 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
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
    let v17 : struct (string * US2) list = []
    let v18 : US2 = US2_4
    let v19 : struct (string * US2) list = struct (v4, v18) :: v17 
    let v20 : US2 = US2_3
    let v21 : struct (string * US2) list = struct (v7, v20) :: v19 
    let v22 : US2 = US2_2
    let v23 : struct (string * US2) list = struct (v10, v22) :: v21 
    let v24 : US2 = US2_1
    let v25 : struct (string * US2) list = struct (v13, v24) :: v23 
    let v26 : US2 = US2_0
    let v27 : struct (string * US2) list = struct (v16, v26) :: v25 
    let v28 : US2 = US2_4
    let v29 : struct (string * US2) list = struct (v2, v28) :: v27 
    let v30 : US2 = US2_3
    let v31 : struct (string * US2) list = struct (v5, v30) :: v29 
    let v32 : US2 = US2_2
    let v33 : struct (string * US2) list = struct (v8, v32) :: v31 
    let v34 : US2 = US2_1
    let v35 : struct (string * US2) list = struct (v11, v34) :: v33 
    let v36 : US2 = US2_0
    let v37 : struct (string * US2) list = struct (v14, v36) :: v35 
    let v38 : (struct (string * US2) list -> (struct (string * US2) [])) = List.toArray
    let v39 : (struct (string * US2) []) = v38 v37
    let v40 : int32 = v39.Length
    let v41 : US3 = US3_1
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
            | US3_1 -> (* None *)
                let v52 : bool = v49 = v1 
                if v52 then
                    US3_0(v50)
                else
                    US3_1
            | US3_0(v51) -> (* Some *)
                v48
        let v58 : int32 = v44 + 1
        v42.l0 <- v58
        v42.l1 <- v57
        ()
    let v59 : US3 = v42.l1
    let v60 : string = "AUTOMATION"
    let v61 : string = method8(v60)
    let v62 : string = "True"
    let v63 : bool = v61 <> v62 
    let v96 : US4 =
        if v63 then
            US4_1
        else
            let v65 : System.DateTime = System.DateTime.Now
            let v66 : System.DateTime = System.DateTime.MinValue
            let v67 : System.TimeSpan = v65 - v66 
            let v68 : (System.TimeSpan -> int64) = _.Ticks
            let v69 : int64 = v68 v67
            let v70 : int64 = v69 / 10000000L
            let v71 : float = float v70
            let v72 : float = 10000000.0 * v71
            let v73 : US6 = method11(v72)
            let v79 : US7 =
                match v73 with
                | US6_1(v76) -> (* Error *)
                    US7_1
                | US6_0(v74) -> (* Ok *)
                    US7_0(v74)
            let v83 : int64 =
                match v79 with
                | US7_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US7_0(v80) -> (* Some *)
                    v80
            let v84 : US8 = method12(v83)
            let v90 : US4 =
                match v84 with
                | US8_1(v87) -> (* Error *)
                    US4_1
                | US8_0(v85) -> (* Ok *)
                    US4_0(v85)
            let v94 : int64 =
                match v90 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v91) -> (* Some *)
                    v91
            US4_0(v94)
    struct (v59, v96)
and closure16 () (v0 : string) : unit =
    ()
and method6 (v0 : US2) : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) =
    let struct (v1 : US3, v2 : US4) = method7()
    let v3 : Mut1 = {l0 = 1L} : Mut1
    let v4 : (string -> unit) = closure16()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : Mut4 = {l0 = true} : Mut4
    let v7 : string = ""
    let v8 : Mut5 = {l0 = v7} : Mut5
    let v11 : US2 =
        match v1 with
        | US3_1 -> (* None *)
            v0
        | US3_0(v9) -> (* Some *)
            v9
    let v12 : Mut6 = {l0 = v11} : Mut6
    let v17 : int64 option =
        match v2 with
        | US4_1 -> (* None *)
            let v15 : int64 option = None
            v15
        | US4_0(v13) -> (* Some *)
            let v14 : int64 option = Some v13 
            v14
    struct (v3, v5, v6, v8, v12, v17)
and closure17 () (v0 : int64) : US4 =
    US4_0(v0)
and method14 () : (int64 -> US4) =
    closure17()
and method15 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method13 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option) : string =
    let v747 : (int64 -> US4) = method14()
    let v748 : US4 option = v5 |> Option.map v747 
    let v749 : US4 = US4_1
    let v750 : US4 = v748 |> Option.defaultValue v749 
    let v795 : System.DateTime =
        match v750 with
        | US4_1 -> (* None *)
            let v793 : System.DateTime = System.DateTime.Now
            v793
        | US4_0(v751) -> (* Some *)
            let v752 : System.DateTime = System.DateTime.Now
            let v753 : System.DateTime = System.DateTime.MinValue
            let v754 : System.TimeSpan = v752 - v753 
            let v755 : (System.TimeSpan -> int64) = _.Ticks
            let v756 : int64 = v755 v754
            let v757 : int64 = v756 / 10000000L
            let v758 : float = float v757
            let v759 : float = 10000000.0 * v758
            let v760 : US6 = method11(v759)
            let v766 : US7 =
                match v760 with
                | US6_1(v763) -> (* Error *)
                    US7_1
                | US6_0(v761) -> (* Ok *)
                    US7_0(v761)
            let v770 : int64 =
                match v766 with
                | US7_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US7_0(v767) -> (* Some *)
                    v767
            let v771 : US8 = method12(v770)
            let v777 : US4 =
                match v771 with
                | US8_1(v774) -> (* Error *)
                    US4_1
                | US8_0(v772) -> (* Ok *)
                    US4_0(v772)
            let v781 : int64 =
                match v777 with
                | US4_1 -> (* None *)
                    failwith<int64> "Option does not have a value."
                | US4_0(v778) -> (* Some *)
                    v778
            let v782 : int64 = v781 - v751
            let v783 : System.TimeSpan = v782 |> System.TimeSpan 
            let v784 : (System.TimeSpan -> int32) = _.Hours
            let v785 : int32 = v784 v783
            let v786 : (System.TimeSpan -> int32) = _.Minutes
            let v787 : int32 = v786 v783
            let v788 : (System.TimeSpan -> int32) = _.Seconds
            let v789 : int32 = v788 v783
            let v790 : (System.TimeSpan -> int32) = _.Milliseconds
            let v791 : int32 = v790 v783
            let v792 : System.DateTime = System.DateTime (1, 1, 1, v785, v787, v789, v791)
            v792
    let v796 : string = method15()
    let v852 : bool = v796 = ""
    let v854 : string =
        if v852 then
            let v853 : string = "M-d-y hh:mm:ss tt"
            v853
        else
            v796
    let v855 : (string -> string) = v795.ToString
    v855 v854
and method18 () : string =
    let v0 : string = ""
    v0
and method19 (v0 : Mut5, v1 : string) : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method17 (v0 : char) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v15 : string = $"{v0}"
    method19(v2, v15)
    let v23 : string = v2.l0
    v23
and method16 () : string =
    let v2 : string = "\u001b[94m"
    
    
    
    
    
    let v8 : string = "Debug"
    let v9 : (unit -> string) = v8.ToLower
    let v10 : string = v9 ()
    let v11 : char = v10.[int 0]
    let v12 : string = method17(v11)
    let v13 : string = v2 + v12 
    let v16 : string = "\u001b[0m"
    let v22 : string = v13 + v16 
    v22
and method21 (v0 : int64) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v15 : string = $"{v0}"
    method19(v2, v15)
    let v23 : string = v2.l0
    v23
and method23 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "{ "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method24 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "current_index"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method25 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = " = "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method26 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "; "
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method27 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "acc"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method28 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "len"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method29 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "last_item"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method30 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = " }"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method22 (v0 : int64, v1 : int64, v2 : int64, v3 : string) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    method23(v5)
    method24(v5)
    method25(v5)
    let v75 : string = $"{v0}"
    method19(v5, v75)
    method26(v5)
    method27(v5)
    method25(v5)
    let v122 : string = $"{v1}"
    method19(v5, v122)
    method26(v5)
    method28(v5)
    method25(v5)
    let v146 : string = $"{v2}"
    method19(v5, v146)
    method26(v5)
    method29(v5)
    method25(v5)
    method19(v5, v3)
    method30(v5)
    let v193 : string = v5.l0
    v193
and method32 (v0 : string, v1 : int32, v2 : int32) : int32 =
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
            method32(v0, v1, v12)
        else
            v2
and method33 (v0 : string, v1 : int32) : int32 =
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
            method33(v0, v3)
        else
            v3
and method31 (v0 : string) : string =
    let v1 : int32 = v0.Length
    let v2 : int32 = 0
    let v3 : int32 = method32(v0, v1, v2)
    let v4 : int32 = v1 - 1
    let v7 : string = v0.[int v3..int v4]
    let v14 : int32 = v7.Length
    let v15 : int32 = method33(v7, v14)
    let v18 : string = v7.[int 0..int v15]
    v18
and method20 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64, v10 : int64, v11 : string) : string =
    let v12 : int64 = v0.l0
    let v15 : string = " "
    let v16 : string = v6 + v15 
    let v17 : string = method21(v12)
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v7 
    let v20 : string = v19 + v15 
    let v25 : string = "dice.create_sequential_roller / roll"
    let v26 : string = v20 + v25 
    let v38 : string = " / "
    let v39 : string = v26 + v38 
    let v47 : string = method22(v8, v9, v10, v11)
    let v48 : string = v39 + v47 
    method31(v48)
and closure18 () (v0 : string) : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and method34 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method34(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US1_1
and method36 () : string =
    let v0 : string = method18()
    let v1 : Mut5 = {l0 = v0} : Mut5
    let v2 : string = v1.l0
    v2
and method35 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v9 : string = " "
    let v10 : string = v6 + v9 
    let v11 : string = method21(v8)
    let v12 : string = v10 + v11 
    let v13 : string = v12 + v7 
    let v14 : string = v13 + v9 
    let v19 : string = "dice.create_sequential_roller / roll / None"
    let v20 : string = v14 + v19 
    let v28 : string = " / "
    let v29 : string = v20 + v28 
    let v30 : string = method36()
    let v31 : string = v29 + v30 
    method31(v31)
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
    let v52 : bool = TraceState.trace_state.IsNone
    if v52 then
        let v53 : US2 = US2_0
        let struct (v54 : Mut1, v55 : Mut3, v56 : Mut4, v57 : Mut5, v58 : Mut6, v59 : int64 option) = method6(v53)
        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v54, v55, v56, v57, v58, v59) 
        TraceState.trace_state <- v62 
        ()
    let struct (v104 : Mut1, v105 : Mut3, v106 : Mut4, v107 : Mut5, v108 : Mut6, v109 : int64 option) = TraceState.trace_state.Value
    let v196 : US2 = v108.l0
    let v201 : int32 =
        match v196 with
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
    let v202 : bool = v106.l0
    let v203 : bool = v202 = false
    let v205 : bool =
        if v203 then
            false
        else
            let v204 : bool = 20 >= v201
            v204
    let v206 : bool = v205 = false
    let v330 : US9 =
        if v206 then
            US9_1
        else
            let v208 : bool = TraceState.trace_state.IsNone
            if v208 then
                let v209 : US2 = US2_0
                let struct (v210 : Mut1, v211 : Mut3, v212 : Mut4, v213 : Mut5, v214 : Mut6, v215 : int64 option) = method6(v209)
                let v216 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v210, v211, v212, v213, v214, v215) 
                TraceState.trace_state <- v216 
                ()
            let struct (v217 : Mut1, v218 : Mut3, v219 : Mut4, v220 : Mut5, v221 : Mut6, v222 : int64 option) = TraceState.trace_state.Value
            let v223 : string = method13(v217, v218, v219, v220, v221, v222)
            let v224 : string = method16()
            let v227 : string = $"%A{v43}"
            let v264 : string = method20(v217, v218, v219, v220, v221, v222, v223, v224, v5, v6, v7, v227)
            let v265 : bool = TraceState.trace_state.IsNone
            if v265 then
                let v266 : US2 = US2_0
                let struct (v267 : Mut1, v268 : Mut3, v269 : Mut4, v270 : Mut5, v271 : Mut6, v272 : int64 option) = method6(v266)
                let v273 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v267, v268, v269, v270, v271, v272) 
                TraceState.trace_state <- v273 
                ()
            let struct (v274 : Mut1, v275 : Mut3, v276 : Mut4, v277 : Mut5, v278 : Mut6, v279 : int64 option) = TraceState.trace_state.Value
            let v280 : int64 = v274.l0
            let v281 : int64 = v280 + 1L
            v274.l0 <- v281
            let v282 : (string -> unit) = closure18()
            v282 v264
            let v328 : (string -> unit) = v275.l0
            v328 v264
            US9_0(v274, v275, v276, v277, v278, v279)
    let v353 : UH0 = v0 ()
    let v354 : int64 = v1.l0
    let v355 : US1 = method34(v354, v353)
    match v355 with
    | US1_1 -> (* None *)
        let v360 : bool = TraceState.trace_state.IsNone
        if v360 then
            let v361 : US2 = US2_0
            let struct (v362 : Mut1, v363 : Mut3, v364 : Mut4, v365 : Mut5, v366 : Mut6, v367 : int64 option) = method6(v361)
            let v368 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v362, v363, v364, v365, v366, v367) 
            TraceState.trace_state <- v368 
            ()
        let struct (v369 : Mut1, v370 : Mut3, v371 : Mut4, v372 : Mut5, v373 : Mut6, v374 : int64 option) = TraceState.trace_state.Value
        let v375 : US2 = v373.l0
        let v380 : int32 =
            match v375 with
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
        let v381 : bool = v371.l0
        let v382 : bool = v381 = false
        let v384 : bool =
            if v382 then
                false
            else
                let v383 : bool = 20 >= v380
                v383
        let v385 : bool = v384 = false
        let v425 : US9 =
            if v385 then
                US9_1
            else
                let v387 : bool = TraceState.trace_state.IsNone
                if v387 then
                    let v388 : US2 = US2_0
                    let struct (v389 : Mut1, v390 : Mut3, v391 : Mut4, v392 : Mut5, v393 : Mut6, v394 : int64 option) = method6(v388)
                    let v395 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v389, v390, v391, v392, v393, v394) 
                    TraceState.trace_state <- v395 
                    ()
                let struct (v396 : Mut1, v397 : Mut3, v398 : Mut4, v399 : Mut5, v400 : Mut6, v401 : int64 option) = TraceState.trace_state.Value
                let v402 : string = method13(v396, v397, v398, v399, v400, v401)
                let v403 : string = method16()
                let v404 : string = method35(v396, v397, v398, v399, v400, v401, v402, v403)
                let v405 : bool = TraceState.trace_state.IsNone
                if v405 then
                    let v406 : US2 = US2_0
                    let struct (v407 : Mut1, v408 : Mut3, v409 : Mut4, v410 : Mut5, v411 : Mut6, v412 : int64 option) = method6(v406)
                    let v413 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v407, v408, v409, v410, v411, v412) 
                    TraceState.trace_state <- v413 
                    ()
                let struct (v414 : Mut1, v415 : Mut3, v416 : Mut4, v417 : Mut5, v418 : Mut6, v419 : int64 option) = TraceState.trace_state.Value
                let v420 : int64 = v414.l0
                let v421 : int64 = v420 + 1L
                v414.l0 <- v421
                let v422 : (string -> unit) = closure18()
                v422 v404
                let v423 : (string -> unit) = v415.l0
                v423 v404
                US9_0(v414, v415, v416, v417, v418, v419)
        let v426 : int64 = v3.l0
        let v427 : bool = v426 = -1L
        if v427 then
            let v428 : int64 = v1.l0
            v3.l0 <- v428
            ()
        let v429 : int64 = v2.l0
        let v430 : int64 = v3.l0
        let v431 : bool = v429 >= v430
        let v434 : int64 =
            if v431 then
                1L
            else
                let v432 : int64 = v2.l0
                let v433 : int64 = v432 + 1L
                v433
        v2.l0 <- v434
        let v435 : int64 = v2.l0
        let v436 : int64 = v435 - 1L
        v1.l0 <- v436
        let v437 : US1 = US1_1
        v4.l0 <- v437
        method5(v0, v1, v2, v3, v4)
    | US1_0(v356) -> (* Some *)
        let v357 : int64 = v1.l0
        let v358 : int64 = v357 + 1L
        v1.l0 <- v358
        let v359 : US1 = US1_0(v356)
        v4.l0 <- v359
        v356
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
and method38 (v0 : uint64) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    let v5 : string = $"{v0}"
    method19(v2, v5)
    let v13 : string = v2.l0
    v13
and method41 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "max"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method42 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "p"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method43 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "n"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method40 (v0 : uint64, v1 : uint64, v2 : int8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method23(v4)
    method41(v4)
    method25(v4)
    let v28 : string = $"{v0}"
    method19(v4, v28)
    method26(v4)
    method42(v4)
    method25(v4)
    let v52 : string = $"{v1}"
    method19(v4, v52)
    method26(v4)
    method43(v4)
    method25(v4)
    let v88 : string = $"{v2}"
    method19(v4, v88)
    method30(v4)
    let v96 : string = v4.l0
    v96
and method39 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : uint64, v9 : uint64, v10 : int8) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v22 : string = "dice.calculate_dice_count"
    let v23 : string = v17 + v22 
    let v31 : string = " / "
    let v32 : string = v23 + v31 
    let v33 : string = method40(v8, v9, v10)
    let v34 : string = v32 + v33 
    method31(v34)
and method37 (v0 : uint64, v1 : int8, v2 : uint64) : int8 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : bool = v2 > 3074457345618258602UL
        if v4 then
            let v5 : string = method38(v0)
            let v10 : string = "dice.calculate_dice_count / max: "
            let v11 : string = v10 + v5 
            let v23 : string = " is above the largest supported bound "
            let v24 : string = v11 + v23 
            let v32 : string = method38(v2)
            let v33 : string = v24 + v32 
            failwith<int8> v33
        else
            let v35 : int8 = v1 + 1y
            let v36 : uint64 = v2 * 6UL
            method37(v0, v35, v36)
    else
        let v39 : bool = TraceState.trace_state.IsNone
        if v39 then
            let v40 : US2 = US2_0
            let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = method6(v40)
            let v47 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v41, v42, v43, v44, v45, v46) 
            TraceState.trace_state <- v47 
            ()
        let struct (v48 : Mut1, v49 : Mut3, v50 : Mut4, v51 : Mut5, v52 : Mut6, v53 : int64 option) = TraceState.trace_state.Value
        let v54 : US2 = v52.l0
        let v59 : int32 =
            match v54 with
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
        let v60 : bool = v50.l0
        let v61 : bool = v60 = false
        let v63 : bool =
            if v61 then
                false
            else
                let v62 : bool = 20 >= v59
                v62
        let v64 : bool = v63 = false
        let v104 : US9 =
            if v64 then
                US9_1
            else
                let v66 : bool = TraceState.trace_state.IsNone
                if v66 then
                    let v67 : US2 = US2_0
                    let struct (v68 : Mut1, v69 : Mut3, v70 : Mut4, v71 : Mut5, v72 : Mut6, v73 : int64 option) = method6(v67)
                    let v74 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v68, v69, v70, v71, v72, v73) 
                    TraceState.trace_state <- v74 
                    ()
                let struct (v75 : Mut1, v76 : Mut3, v77 : Mut4, v78 : Mut5, v79 : Mut6, v80 : int64 option) = TraceState.trace_state.Value
                let v81 : string = method13(v75, v76, v77, v78, v79, v80)
                let v82 : string = method16()
                let v83 : string = method39(v75, v76, v77, v78, v79, v80, v81, v82, v0, v2, v1)
                let v84 : bool = TraceState.trace_state.IsNone
                if v84 then
                    let v85 : US2 = US2_0
                    let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = method6(v85)
                    let v92 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v86, v87, v88, v89, v90, v91) 
                    TraceState.trace_state <- v92 
                    ()
                let struct (v93 : Mut1, v94 : Mut3, v95 : Mut4, v96 : Mut5, v97 : Mut6, v98 : int64 option) = TraceState.trace_state.Value
                let v99 : int64 = v93.l0
                let v100 : int64 = v99 + 1L
                v93.l0 <- v100
                let v101 : (string -> unit) = closure18()
                v101 v83
                let v102 : (string -> unit) = v94.l0
                v102 v83
                US9_0(v93, v94, v95, v96, v97, v98)
        v1
and method48 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "power"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method49 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "result"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method47 (v0 : int8, v1 : uint64, v2 : uint64) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method23(v4)
    method48(v4)
    method25(v4)
    let v28 : string = $"{v0}"
    method19(v4, v28)
    method26(v4)
    method27(v4)
    method25(v4)
    let v29 : string = $"{v1}"
    method19(v4, v29)
    method26(v4)
    method49(v4)
    method25(v4)
    let v53 : string = $"{v2}"
    method19(v4, v53)
    method30(v4)
    let v54 : string = v4.l0
    v54
and method46 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v22 : string = "dice.accumulate_dice_rolls"
    let v23 : string = v17 + v22 
    let v31 : string = " / "
    let v32 : string = v23 + v31 
    let v33 : string = method47(v8, v9, v10)
    let v34 : string = v32 + v33 
    method31(v34)
and closure85 () () : UH2 =
    UH2_1
and closure84 () () : UH2 =
    let v0 : (unit -> UH2) = closure85()
    UH2_0(9223372036854775808UL, v0)
and closure83 () () : UH2 =
    let v0 : (unit -> UH2) = closure84()
    UH2_0(4611686018427387904UL, v0)
and closure82 () () : UH2 =
    let v0 : (unit -> UH2) = closure83()
    UH2_0(6917529027641081856UL, v0)
and closure81 () () : UH2 =
    let v0 : (unit -> UH2) = closure82()
    UH2_0(1152921504606846976UL, v0)
and closure80 () () : UH2 =
    let v0 : (unit -> UH2) = closure81()
    UH2_0(15564440312192434176UL, v0)
and closure79 () () : UH2 =
    let v0 : (unit -> UH2) = closure80()
    UH2_0(11817445422220181504UL, v0)
and closure78 () () : UH2 =
    let v0 : (unit -> UH2) = closure79()
    UH2_0(5044031582654955520UL, v0)
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure78()
    UH2_0(6989586621679009792UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(16537217831704461312UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(11979575008805519360UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(14294425217273954304UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(2382404202878992384UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(6545982058383015936UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(10314369046585278464UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(4793518853382471680UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(3873377154515337216UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(645562859085889536UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(107593809847648256UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(3092389647259533312UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(9738770311398031360UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(16995415113324298240UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(8981483876790566912UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(13794743361938128896UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(2299123893656354816UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(3457644661227651072UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(576274110204608512UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(6244960376270618624UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(13338656111851470848UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(14520938734448279552UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(14717985838214414336UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(5527454985320660992UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(16293529225644736512UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(11938960241128898560UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(8138741398091333632UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(7505371590918406144UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(16623181993244360704UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(8919445023443910656UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(4561031516192243712UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(9983543956220149760UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(4738381338321616896UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(789730223053602816UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(131621703842267136UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(21936950640377856UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(3656158440062976UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(609359740010496UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(101559956668416UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(16926659444736UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(2821109907456UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(470184984576UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(78364164096UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(13060694016UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(2176782336UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(362797056UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(60466176UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(10077696UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(1679616UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(279936UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(46656UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(7776UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(1296UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(216UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(36UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_0(6UL, v0)
and method50 (v0 : int8, v1 : UH2) : US11 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US11_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method50(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US11_1
and method53 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "roll"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method54 (v0 : Mut5) : unit =
    let v1 : string = v0.l0
    let v2 : string = "value"
    let v3 : string = v1 + v2 
    v0.l0 <- v3
    ()
and method52 (v0 : int8, v1 : uint64, v2 : uint8, v3 : uint64) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    method23(v5)
    method48(v5)
    method25(v5)
    let v6 : string = $"{v0}"
    method19(v5, v6)
    method26(v5)
    method27(v5)
    method25(v5)
    let v7 : string = $"{v1}"
    method19(v5, v7)
    method26(v5)
    method53(v5)
    method25(v5)
    let v34 : string = $"{v2}"
    method19(v5, v34)
    method26(v5)
    method54(v5)
    method25(v5)
    let v65 : string = $"{v3}"
    method19(v5, v65)
    method30(v5)
    let v66 : string = v5.l0
    v66
and method51 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8, v11 : uint64) : string =
    let v12 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v15 : string = method21(v12)
    let v16 : string = v14 + v15 
    let v17 : string = v16 + v7 
    let v18 : string = v17 + v13 
    let v19 : string = "dice.accumulate_dice_rolls"
    let v20 : string = v18 + v19 
    let v21 : string = " / "
    let v22 : string = v20 + v21 
    let v23 : string = method52(v8, v9, v10, v11)
    let v24 : string = v22 + v23 
    method31(v24)
and method56 (v0 : int8, v1 : uint64, v2 : uint8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method23(v4)
    method48(v4)
    method25(v4)
    let v5 : string = $"{v0}"
    method19(v4, v5)
    method26(v4)
    method27(v4)
    method25(v4)
    let v6 : string = $"{v1}"
    method19(v4, v6)
    method26(v4)
    method53(v4)
    method25(v4)
    let v7 : string = $"{v2}"
    method19(v4, v7)
    method30(v4)
    let v8 : string = v4.l0
    v8
and method55 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int8, v9 : uint64, v10 : uint8) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : string = method56(v8, v9, v10)
    let v23 : string = v21 + v22 
    method31(v23)
and method45 (v0 : int8, v1 : UH1, v2 : uint64) : US10 =
    let v3 : bool = v0 < 0y
    if v3 then
        let v4 : uint64 = v2 + 1UL
        let v5 : bool = TraceState.trace_state.IsNone
        if v5 then
            let v6 : US2 = US2_0
            let struct (v7 : Mut1, v8 : Mut3, v9 : Mut4, v10 : Mut5, v11 : Mut6, v12 : int64 option) = method6(v6)
            let v13 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v7, v8, v9, v10, v11, v12) 
            TraceState.trace_state <- v13 
            ()
        let struct (v14 : Mut1, v15 : Mut3, v16 : Mut4, v17 : Mut5, v18 : Mut6, v19 : int64 option) = TraceState.trace_state.Value
        let v20 : US2 = v18.l0
        let v25 : int32 =
            match v20 with
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
        let v26 : bool = v16.l0
        let v27 : bool = v26 = false
        let v29 : bool =
            if v27 then
                false
            else
                let v28 : bool = 20 >= v25
                v28
        let v30 : bool = v29 = false
        let v70 : US9 =
            if v30 then
                US9_1
            else
                let v32 : bool = TraceState.trace_state.IsNone
                if v32 then
                    let v33 : US2 = US2_0
                    let struct (v34 : Mut1, v35 : Mut3, v36 : Mut4, v37 : Mut5, v38 : Mut6, v39 : int64 option) = method6(v33)
                    let v40 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v34, v35, v36, v37, v38, v39) 
                    TraceState.trace_state <- v40 
                    ()
                let struct (v41 : Mut1, v42 : Mut3, v43 : Mut4, v44 : Mut5, v45 : Mut6, v46 : int64 option) = TraceState.trace_state.Value
                let v47 : string = method13(v41, v42, v43, v44, v45, v46)
                let v48 : string = method16()
                let v49 : string = method46(v41, v42, v43, v44, v45, v46, v47, v48, v0, v2, v4)
                let v50 : bool = TraceState.trace_state.IsNone
                if v50 then
                    let v51 : US2 = US2_0
                    let struct (v52 : Mut1, v53 : Mut3, v54 : Mut4, v55 : Mut5, v56 : Mut6, v57 : int64 option) = method6(v51)
                    let v58 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v52, v53, v54, v55, v56, v57) 
                    TraceState.trace_state <- v58 
                    ()
                let struct (v59 : Mut1, v60 : Mut3, v61 : Mut4, v62 : Mut5, v63 : Mut6, v64 : int64 option) = TraceState.trace_state.Value
                let v65 : int64 = v59.l0
                let v66 : int64 = v65 + 1L
                v59.l0 <- v66
                let v67 : (string -> unit) = closure18()
                v67 v49
                let v68 : (string -> unit) = v60.l0
                v68 v49
                US9_0(v59, v60, v61, v62, v63, v64)
        US10_0(v4, v1)
    else
        match v1 with
        | UH1_1(v73, v74) -> (* Cons *)
            let v75 : bool = v73 > 1uy
            if v75 then
                let v76 : uint64 = 1UL
                let v77 : (unit -> UH2) = closure22()
                let v78 : UH2 = UH2_0(v76, v77)
                let v79 : US11 = method50(v0, v78)
                let v83 : uint64 =
                    match v79 with
                    | US11_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US11_0(v80) -> (* Some *)
                        v80
                let v84 : uint8 = v73 - 1uy
                let v85 : uint64 = uint64 v84
                let v86 : uint64 = v85 * v83
                let v87 : bool = TraceState.trace_state.IsNone
                if v87 then
                    let v88 : US2 = US2_0
                    let struct (v89 : Mut1, v90 : Mut3, v91 : Mut4, v92 : Mut5, v93 : Mut6, v94 : int64 option) = method6(v88)
                    let v95 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v89, v90, v91, v92, v93, v94) 
                    TraceState.trace_state <- v95 
                    ()
                let struct (v96 : Mut1, v97 : Mut3, v98 : Mut4, v99 : Mut5, v100 : Mut6, v101 : int64 option) = TraceState.trace_state.Value
                let v102 : US2 = v100.l0
                let v107 : int32 =
                    match v102 with
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
                let v108 : bool = v98.l0
                let v109 : bool = v108 = false
                let v111 : bool =
                    if v109 then
                        false
                    else
                        let v110 : bool = 20 >= v107
                        v110
                let v112 : bool = v111 = false
                let v152 : US9 =
                    if v112 then
                        US9_1
                    else
                        let v114 : bool = TraceState.trace_state.IsNone
                        if v114 then
                            let v115 : US2 = US2_0
                            let struct (v116 : Mut1, v117 : Mut3, v118 : Mut4, v119 : Mut5, v120 : Mut6, v121 : int64 option) = method6(v115)
                            let v122 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v116, v117, v118, v119, v120, v121) 
                            TraceState.trace_state <- v122 
                            ()
                        let struct (v123 : Mut1, v124 : Mut3, v125 : Mut4, v126 : Mut5, v127 : Mut6, v128 : int64 option) = TraceState.trace_state.Value
                        let v129 : string = method13(v123, v124, v125, v126, v127, v128)
                        let v130 : string = method16()
                        let v131 : string = method51(v123, v124, v125, v126, v127, v128, v129, v130, v0, v2, v73, v86)
                        let v132 : bool = TraceState.trace_state.IsNone
                        if v132 then
                            let v133 : US2 = US2_0
                            let struct (v134 : Mut1, v135 : Mut3, v136 : Mut4, v137 : Mut5, v138 : Mut6, v139 : int64 option) = method6(v133)
                            let v140 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v134, v135, v136, v137, v138, v139) 
                            TraceState.trace_state <- v140 
                            ()
                        let struct (v141 : Mut1, v142 : Mut3, v143 : Mut4, v144 : Mut5, v145 : Mut6, v146 : int64 option) = TraceState.trace_state.Value
                        let v147 : int64 = v141.l0
                        let v148 : int64 = v147 + 1L
                        v141.l0 <- v148
                        let v149 : (string -> unit) = closure18()
                        v149 v131
                        let v150 : (string -> unit) = v142.l0
                        v150 v131
                        US9_0(v141, v142, v143, v144, v145, v146)
                let v153 : uint64 = v2 + v86
                let v154 : int8 = v0 - 1y
                method45(v154, v74, v153)
            else
                let v156 : bool = TraceState.trace_state.IsNone
                if v156 then
                    let v157 : US2 = US2_0
                    let struct (v158 : Mut1, v159 : Mut3, v160 : Mut4, v161 : Mut5, v162 : Mut6, v163 : int64 option) = method6(v157)
                    let v164 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v158, v159, v160, v161, v162, v163) 
                    TraceState.trace_state <- v164 
                    ()
                let struct (v165 : Mut1, v166 : Mut3, v167 : Mut4, v168 : Mut5, v169 : Mut6, v170 : int64 option) = TraceState.trace_state.Value
                let v171 : US2 = v169.l0
                let v176 : int32 =
                    match v171 with
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
                let v177 : bool = v167.l0
                let v178 : bool = v177 = false
                let v180 : bool =
                    if v178 then
                        false
                    else
                        let v179 : bool = 20 >= v176
                        v179
                let v181 : bool = v180 = false
                let v221 : US9 =
                    if v181 then
                        US9_1
                    else
                        let v183 : bool = TraceState.trace_state.IsNone
                        if v183 then
                            let v184 : US2 = US2_0
                            let struct (v185 : Mut1, v186 : Mut3, v187 : Mut4, v188 : Mut5, v189 : Mut6, v190 : int64 option) = method6(v184)
                            let v191 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v185, v186, v187, v188, v189, v190) 
                            TraceState.trace_state <- v191 
                            ()
                        let struct (v192 : Mut1, v193 : Mut3, v194 : Mut4, v195 : Mut5, v196 : Mut6, v197 : int64 option) = TraceState.trace_state.Value
                        let v198 : string = method13(v192, v193, v194, v195, v196, v197)
                        let v199 : string = method16()
                        let v200 : string = method55(v192, v193, v194, v195, v196, v197, v198, v199, v0, v2, v73)
                        let v201 : bool = TraceState.trace_state.IsNone
                        if v201 then
                            let v202 : US2 = US2_0
                            let struct (v203 : Mut1, v204 : Mut3, v205 : Mut4, v206 : Mut5, v207 : Mut6, v208 : int64 option) = method6(v202)
                            let v209 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v203, v204, v205, v206, v207, v208) 
                            TraceState.trace_state <- v209 
                            ()
                        let struct (v210 : Mut1, v211 : Mut3, v212 : Mut4, v213 : Mut5, v214 : Mut6, v215 : int64 option) = TraceState.trace_state.Value
                        let v216 : int64 = v210.l0
                        let v217 : int64 = v216 + 1L
                        v210.l0 <- v217
                        let v218 : (string -> unit) = closure18()
                        v218 v200
                        let v219 : (string -> unit) = v211.l0
                        v219 v200
                        US9_0(v210, v211, v212, v213, v214, v215)
                let v222 : int8 = v0 - 1y
                method45(v222, v74, v2)
        | UH1_0 -> (* Nil *)
            US10_1
and method57 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method57(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method58 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1) : uint64 =
    let v5 : int8 = v3 + 1y
    let v6 : bool = v3 < v5
    if v6 then
        let v7 : uint8 = v0 ()
        let v8 : UH1 = UH1_1(v7, v4)
        method44(v0, v1, v2, v3, v8, v5)
    else
        let v10 : uint64 = 0UL
        let v11 : US10 = method45(v3, v4, v10)
        match v11 with
        | US10_0(v12, v13) -> (* Some *)
            let v14 : bool = v12 <= v2
            if v14 then
                v12
            else
                if v1 then
                    let v15 : int8 = 0y
                    let v16 : UH1 = method57(v3, v0, v15)
                    method58(v0, v1, v2, v3, v16)
                else
                    let v18 : uint8 = v0 ()
                    let v19 : UH1 = UH1_1(v18, v4)
                    method44(v0, v1, v2, v3, v19, v5)
        | _ ->
            if v1 then
                let v23 : int8 = 0y
                let v24 : UH1 = method57(v3, v0, v23)
                method58(v0, v1, v2, v3, v24)
            else
                let v26 : uint8 = v0 ()
                let v27 : UH1 = UH1_1(v26, v4)
                method44(v0, v1, v2, v3, v27, v5)
and method44 (v0 : (unit -> uint8), v1 : bool, v2 : uint64, v3 : int8, v4 : UH1, v5 : int8) : uint64 =
    let v6 : int8 = v3 + 1y
    let v7 : bool = v5 < v6
    if v7 then
        let v8 : uint8 = v0 ()
        let v9 : UH1 = UH1_1(v8, v4)
        let v10 : int8 = v5 + 1y
        method44(v0, v1, v2, v3, v9, v10)
    else
        let v12 : uint64 = 0UL
        let v13 : US10 = method45(v3, v4, v12)
        match v13 with
        | US10_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 <= v2
            if v16 then
                v14
            else
                if v1 then
                    let v17 : int8 = 0y
                    let v18 : UH1 = method57(v3, v0, v17)
                    method58(v0, v1, v2, v3, v18)
                else
                    let v20 : uint8 = v0 ()
                    let v21 : UH1 = UH1_1(v20, v4)
                    let v22 : int8 = v5 + 1y
                    method44(v0, v1, v2, v3, v21, v22)
        | _ ->
            if v1 then
                let v26 : int8 = 0y
                let v27 : UH1 = method57(v3, v0, v26)
                method58(v0, v1, v2, v3, v27)
            else
                let v29 : uint8 = v0 ()
                let v30 : UH1 = UH1_1(v29, v4)
                let v31 : int8 = v5 + 1y
                method44(v0, v1, v2, v3, v30, v31)
and closure21 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v3 : bool = v2 = 1UL
    let v7 : int8 =
        if v3 then
            1y
        else
            let v4 : int8 = 0y
            let v5 : uint64 = 1UL
            method37(v2, v4, v5)
    let v8 : int8 = v7 - 1y
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    method44(v0, v1, v2, v8, v9, v10)
and closure20 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure21(v0, v1)
and closure19 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure20(v0)
and method59 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method59(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure87 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : int8 = 0y
    let v3 : int8 = method59(v1, v2)
    let v4 : int8 = v3 - 1y
    let v5 : uint64 = 0UL
    let v6 : US10 = method45(v4, v1, v5)
    let v16 : US11 =
        match v6 with
        | US10_0(v7, v8) -> (* Some *)
            let v9 : bool = v7 >= 1UL
            let v11 : bool =
                if v9 then
                    let v10 : bool = v7 <= v0
                    v10
                else
                    false
            if v11 then
                US11_0(v7)
            else
                US11_1
        | _ ->
            US11_1
    match v16 with
    | US11_1 -> (* None *)
        let v42 : uint64 option = None
        v42
    | US11_0(v17) -> (* Some *)
        let v20 : uint64 option = Some v17 
        v20
and closure86 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure87(v0)
and method61 (v0 : int64, v1 : int64, v2 : int8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method23(v4)
    method41(v4)
    method25(v4)
    let v5 : string = $"{v0}"
    method19(v4, v5)
    method26(v4)
    method42(v4)
    method25(v4)
    let v6 : string = $"{v1}"
    method19(v4, v6)
    method26(v4)
    method43(v4)
    method25(v4)
    let v7 : string = $"{v2}"
    method19(v4, v7)
    method30(v4)
    let v8 : string = v4.l0
    v8
and method60 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : int64 = v0.l0
    let v9 : string = " "
    let v10 : string = v6 + v9 
    let v11 : string = method21(v8)
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
    let v22 : string = method61(v19, v20, v21)
    let v23 : string = v18 + v22 
    method31(v23)
and closure89 () () : int32 =
    let v0 : int32 = 1uy |> int32 
    v0
and closure90 () (v0 : int32) : US12 =
    US12_0(v0)
and closure91 () (v0 : exn) : US12 =
    US12_1(v0)
and method64 () : US12 =
    let v0 : (unit -> int32) = closure89()
    let v1 : (int32 -> US12) = closure90()
    let v2 : ((unit -> exn) -> exn) = closure11()
    let v3 : (exn -> US12) = closure91()
    let v4 : US12 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure92 () () : int32 =
    let v0 : int32 = 7uy |> int32 
    v0
and method65 () : US12 =
    let v0 : (unit -> int32) = closure92()
    let v1 : (int32 -> US12) = closure90()
    let v2 : ((unit -> exn) -> exn) = closure11()
    let v3 : (exn -> US12) = closure91()
    let v4 : US12 = try v0 () |> v1 with ex -> (fun () -> ex) |> v2 |> v3 
    v4
and closure93 (v0 : int32) () : uint8 =
    let v1 : uint8 = v0 |> uint8 
    v1
and closure94 () (v0 : uint8) : US14 =
    US14_0(v0)
and closure95 () (v0 : exn) : US14 =
    US14_1(v0)
and method66 (v0 : int32) : US14 =
    let v1 : (unit -> uint8) = closure93(v0)
    let v2 : (uint8 -> US14) = closure94()
    let v3 : ((unit -> exn) -> exn) = closure11()
    let v4 : (exn -> US14) = closure95()
    let v5 : US14 = try v1 () |> v2 with ex -> (fun () -> ex) |> v3 |> v4 
    v5
and method63 () : uint8 =
    let v416 : (unit -> System.Random) = System.Random 
    let v417 : System.Random = v416 ()
    let v418 : US12 = method64()
    let v424 : US13 =
        match v418 with
        | US12_1(v421) -> (* Error *)
            US13_1
        | US12_0(v419) -> (* Ok *)
            US13_0(v419)
    let v428 : int32 =
        match v424 with
        | US13_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US13_0(v425) -> (* Some *)
            v425
    let v429 : US12 = method65()
    let v435 : US13 =
        match v429 with
        | US12_1(v432) -> (* Error *)
            US13_1
        | US12_0(v430) -> (* Ok *)
            US13_0(v430)
    let v439 : int32 =
        match v435 with
        | US13_1 -> (* None *)
            failwith<int32> "Option does not have a value."
        | US13_0(v436) -> (* Some *)
            v436
    let v440 : int32 = v417.Next (v428, v439)
    let v441 : US14 = method66(v440)
    let v447 : US1 =
        match v441 with
        | US14_1(v444) -> (* Error *)
            US1_1
        | US14_0(v442) -> (* Ok *)
            US1_0(v442)
    match v447 with
    | US1_1 -> (* None *)
        failwith<uint8> "Option does not have a value."
    | US1_0(v448) -> (* Some *)
        v448
and method69 (v0 : int8, v1 : int64, v2 : uint8, v3 : int64) : string =
    let v4 : string = method18()
    let v5 : Mut5 = {l0 = v4} : Mut5
    method23(v5)
    method48(v5)
    method25(v5)
    let v6 : string = $"{v0}"
    method19(v5, v6)
    method26(v5)
    method27(v5)
    method25(v5)
    let v7 : string = $"{v1}"
    method19(v5, v7)
    method26(v5)
    method53(v5)
    method25(v5)
    let v8 : string = $"{v2}"
    method19(v5, v8)
    method26(v5)
    method54(v5)
    method25(v5)
    let v9 : string = $"{v3}"
    method19(v5, v9)
    method30(v5)
    let v10 : string = v5.l0
    v10
and method68 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 23y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method71 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 22y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method73 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 21y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method75 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 20y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method77 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 19y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method79 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 18y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method81 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 17y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method83 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 16y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method85 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 15y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method87 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 14y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method89 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 13y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method91 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 12y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method93 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 11y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method95 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 10y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method97 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 9y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method99 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 8y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method101 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 7y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method103 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 6y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method105 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 5y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method107 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 4y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method109 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 3y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method111 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 2y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method113 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 1y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method115 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8, v10 : int64) : string =
    let v11 : int64 = v0.l0
    let v12 : string = " "
    let v13 : string = v6 + v12 
    let v14 : string = method21(v11)
    let v15 : string = v13 + v14 
    let v16 : string = v15 + v7 
    let v17 : string = v16 + v12 
    let v18 : string = "dice.accumulate_dice_rolls"
    let v19 : string = v17 + v18 
    let v20 : string = " / "
    let v21 : string = v19 + v20 
    let v22 : int8 = 0y
    let v23 : string = method69(v22, v8, v9, v10)
    let v24 : string = v21 + v23 
    method31(v24)
and method118 (v0 : int8, v1 : int64, v2 : int64) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method23(v4)
    method48(v4)
    method25(v4)
    let v5 : string = $"{v0}"
    method19(v4, v5)
    method26(v4)
    method27(v4)
    method25(v4)
    let v6 : string = $"{v1}"
    method19(v4, v6)
    method26(v4)
    method49(v4)
    method25(v4)
    let v7 : string = $"{v2}"
    method19(v4, v7)
    method30(v4)
    let v8 : string = v4.l0
    v8
and method117 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : int64) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = -1y
    let v22 : string = method118(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method116 (v0 : UH1, v1 : int64) : US15 =
    let v2 : int64 = v1 + 1L
    let v3 : bool = TraceState.trace_state.IsNone
    if v3 then
        let v4 : US2 = US2_0
        let struct (v5 : Mut1, v6 : Mut3, v7 : Mut4, v8 : Mut5, v9 : Mut6, v10 : int64 option) = method6(v4)
        let v11 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v5, v6, v7, v8, v9, v10) 
        TraceState.trace_state <- v11 
        ()
    let struct (v12 : Mut1, v13 : Mut3, v14 : Mut4, v15 : Mut5, v16 : Mut6, v17 : int64 option) = TraceState.trace_state.Value
    let v18 : US2 = v16.l0
    let v23 : int32 =
        match v18 with
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
    let v24 : bool = v14.l0
    let v25 : bool = v24 = false
    let v27 : bool =
        if v25 then
            false
        else
            let v26 : bool = 20 >= v23
            v26
    let v28 : bool = v27 = false
    let v68 : US9 =
        if v28 then
            US9_1
        else
            let v30 : bool = TraceState.trace_state.IsNone
            if v30 then
                let v31 : US2 = US2_0
                let struct (v32 : Mut1, v33 : Mut3, v34 : Mut4, v35 : Mut5, v36 : Mut6, v37 : int64 option) = method6(v31)
                let v38 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v32, v33, v34, v35, v36, v37) 
                TraceState.trace_state <- v38 
                ()
            let struct (v39 : Mut1, v40 : Mut3, v41 : Mut4, v42 : Mut5, v43 : Mut6, v44 : int64 option) = TraceState.trace_state.Value
            let v45 : string = method13(v39, v40, v41, v42, v43, v44)
            let v46 : string = method16()
            let v47 : string = method117(v39, v40, v41, v42, v43, v44, v45, v46, v1, v2)
            let v48 : bool = TraceState.trace_state.IsNone
            if v48 then
                let v49 : US2 = US2_0
                let struct (v50 : Mut1, v51 : Mut3, v52 : Mut4, v53 : Mut5, v54 : Mut6, v55 : int64 option) = method6(v49)
                let v56 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v50, v51, v52, v53, v54, v55) 
                TraceState.trace_state <- v56 
                ()
            let struct (v57 : Mut1, v58 : Mut3, v59 : Mut4, v60 : Mut5, v61 : Mut6, v62 : int64 option) = TraceState.trace_state.Value
            let v63 : int64 = v57.l0
            let v64 : int64 = v63 + 1L
            v57.l0 <- v64
            let v65 : (string -> unit) = closure18()
            v65 v47
            let v66 : (string -> unit) = v58.l0
            v66 v47
            US9_0(v57, v58, v59, v60, v61, v62)
    US15_0(v2, v0)
and method120 (v0 : int8, v1 : int64, v2 : uint8) : string =
    let v3 : string = method18()
    let v4 : Mut5 = {l0 = v3} : Mut5
    method23(v4)
    method48(v4)
    method25(v4)
    let v5 : string = $"{v0}"
    method19(v4, v5)
    method26(v4)
    method27(v4)
    method25(v4)
    let v6 : string = $"{v1}"
    method19(v4, v6)
    method26(v4)
    method53(v4)
    method25(v4)
    let v7 : string = $"{v2}"
    method19(v4, v7)
    method30(v4)
    let v8 : string = v4.l0
    v8
and method119 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 0y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method114 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : bool = TraceState.trace_state.IsNone
            if v8 then
                let v9 : US2 = US2_0
                let struct (v10 : Mut1, v11 : Mut3, v12 : Mut4, v13 : Mut5, v14 : Mut6, v15 : int64 option) = method6(v9)
                let v16 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v10, v11, v12, v13, v14, v15) 
                TraceState.trace_state <- v16 
                ()
            let struct (v17 : Mut1, v18 : Mut3, v19 : Mut4, v20 : Mut5, v21 : Mut6, v22 : int64 option) = TraceState.trace_state.Value
            let v23 : US2 = v21.l0
            let v28 : int32 =
                match v23 with
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
            let v29 : bool = v19.l0
            let v30 : bool = v29 = false
            let v32 : bool =
                if v30 then
                    false
                else
                    let v31 : bool = 20 >= v28
                    v31
            let v33 : bool = v32 = false
            let v73 : US9 =
                if v33 then
                    US9_1
                else
                    let v35 : bool = TraceState.trace_state.IsNone
                    if v35 then
                        let v36 : US2 = US2_0
                        let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = method6(v36)
                        let v43 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v37, v38, v39, v40, v41, v42) 
                        TraceState.trace_state <- v43 
                        ()
                    let struct (v44 : Mut1, v45 : Mut3, v46 : Mut4, v47 : Mut5, v48 : Mut6, v49 : int64 option) = TraceState.trace_state.Value
                    let v50 : string = method13(v44, v45, v46, v47, v48, v49)
                    let v51 : string = method16()
                    let v52 : string = method115(v44, v45, v46, v47, v48, v49, v50, v51, v1, v3, v7)
                    let v53 : bool = TraceState.trace_state.IsNone
                    if v53 then
                        let v54 : US2 = US2_0
                        let struct (v55 : Mut1, v56 : Mut3, v57 : Mut4, v58 : Mut5, v59 : Mut6, v60 : int64 option) = method6(v54)
                        let v61 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v55, v56, v57, v58, v59, v60) 
                        TraceState.trace_state <- v61 
                        ()
                    let struct (v62 : Mut1, v63 : Mut3, v64 : Mut4, v65 : Mut5, v66 : Mut6, v67 : int64 option) = TraceState.trace_state.Value
                    let v68 : int64 = v62.l0
                    let v69 : int64 = v68 + 1L
                    v62.l0 <- v69
                    let v70 : (string -> unit) = closure18()
                    v70 v52
                    let v71 : (string -> unit) = v63.l0
                    v71 v52
                    US9_0(v62, v63, v64, v65, v66, v67)
            let v74 : int64 = v1 + v7
            method116(v4, v74)
        else
            let v76 : bool = TraceState.trace_state.IsNone
            if v76 then
                let v77 : US2 = US2_0
                let struct (v78 : Mut1, v79 : Mut3, v80 : Mut4, v81 : Mut5, v82 : Mut6, v83 : int64 option) = method6(v77)
                let v84 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v78, v79, v80, v81, v82, v83) 
                TraceState.trace_state <- v84 
                ()
            let struct (v85 : Mut1, v86 : Mut3, v87 : Mut4, v88 : Mut5, v89 : Mut6, v90 : int64 option) = TraceState.trace_state.Value
            let v91 : US2 = v89.l0
            let v96 : int32 =
                match v91 with
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
            let v97 : bool = v87.l0
            let v98 : bool = v97 = false
            let v100 : bool =
                if v98 then
                    false
                else
                    let v99 : bool = 20 >= v96
                    v99
            let v101 : bool = v100 = false
            let v141 : US9 =
                if v101 then
                    US9_1
                else
                    let v103 : bool = TraceState.trace_state.IsNone
                    if v103 then
                        let v104 : US2 = US2_0
                        let struct (v105 : Mut1, v106 : Mut3, v107 : Mut4, v108 : Mut5, v109 : Mut6, v110 : int64 option) = method6(v104)
                        let v111 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v105, v106, v107, v108, v109, v110) 
                        TraceState.trace_state <- v111 
                        ()
                    let struct (v112 : Mut1, v113 : Mut3, v114 : Mut4, v115 : Mut5, v116 : Mut6, v117 : int64 option) = TraceState.trace_state.Value
                    let v118 : string = method13(v112, v113, v114, v115, v116, v117)
                    let v119 : string = method16()
                    let v120 : string = method119(v112, v113, v114, v115, v116, v117, v118, v119, v1, v3)
                    let v121 : bool = TraceState.trace_state.IsNone
                    if v121 then
                        let v122 : US2 = US2_0
                        let struct (v123 : Mut1, v124 : Mut3, v125 : Mut4, v126 : Mut5, v127 : Mut6, v128 : int64 option) = method6(v122)
                        let v129 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v123, v124, v125, v126, v127, v128) 
                        TraceState.trace_state <- v129 
                        ()
                    let struct (v130 : Mut1, v131 : Mut3, v132 : Mut4, v133 : Mut5, v134 : Mut6, v135 : int64 option) = TraceState.trace_state.Value
                    let v136 : int64 = v130.l0
                    let v137 : int64 = v136 + 1L
                    v130.l0 <- v137
                    let v138 : (string -> unit) = closure18()
                    v138 v120
                    let v139 : (string -> unit) = v131.l0
                    v139 v120
                    US9_0(v130, v131, v132, v133, v134, v135)
            method116(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method121 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 1y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method112 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method113(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method114(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method121(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method114(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method122 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 2y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method110 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method111(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method112(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method122(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method112(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method123 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 3y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method108 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method109(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method110(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method123(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method110(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method124 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 4y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method106 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method107(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method108(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method124(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method108(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method125 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 5y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method104 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method105(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method106(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method125(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method106(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method126 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 6y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method102 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method103(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method104(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method126(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method104(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method127 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 7y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method100 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method101(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method102(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method127(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method102(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method128 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 8y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method98 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method99(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method100(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method128(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method100(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method129 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 9y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method96 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method97(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method98(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method129(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method98(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method130 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 10y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method94 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method95(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method96(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method130(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method96(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method131 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 11y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method92 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method93(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method94(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method131(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method94(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method132 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 12y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method90 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method91(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method92(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method132(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method92(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method133 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 13y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method88 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method89(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method90(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method133(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method90(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method134 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 14y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method86 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method87(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method88(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method134(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method88(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method135 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 15y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method84 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method85(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method86(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method135(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method86(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method136 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 16y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method82 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method83(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method84(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method136(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method84(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method137 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 17y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method80 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method81(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method82(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method137(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method82(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method138 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 18y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method78 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method79(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method80(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method138(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method80(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method139 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 19y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method76 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method77(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method78(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method139(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method78(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method140 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 20y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method74 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method75(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method76(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method140(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method76(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method141 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 21y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method72 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method73(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method74(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method141(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method74(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method142 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 22y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method70 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method71(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method72(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method142(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method72(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method143 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : uint8) : string =
    let v10 : int64 = v0.l0
    let v11 : string = " "
    let v12 : string = v6 + v11 
    let v13 : string = method21(v10)
    let v14 : string = v12 + v13 
    let v15 : string = v14 + v7 
    let v16 : string = v15 + v11 
    let v17 : string = "dice.accumulate_dice_rolls"
    let v18 : string = v16 + v17 
    let v19 : string = " / "
    let v20 : string = v18 + v19 
    let v21 : int8 = 23y
    let v22 : string = method120(v21, v8, v9)
    let v23 : string = v20 + v22 
    method31(v23)
and method67 (v0 : UH1, v1 : int64) : US15 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : bool = TraceState.trace_state.IsNone
            if v9 then
                let v10 : US2 = US2_0
                let struct (v11 : Mut1, v12 : Mut3, v13 : Mut4, v14 : Mut5, v15 : Mut6, v16 : int64 option) = method6(v10)
                let v17 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v11, v12, v13, v14, v15, v16) 
                TraceState.trace_state <- v17 
                ()
            let struct (v18 : Mut1, v19 : Mut3, v20 : Mut4, v21 : Mut5, v22 : Mut6, v23 : int64 option) = TraceState.trace_state.Value
            let v24 : US2 = v22.l0
            let v29 : int32 =
                match v24 with
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
            let v30 : bool = v20.l0
            let v31 : bool = v30 = false
            let v33 : bool =
                if v31 then
                    false
                else
                    let v32 : bool = 20 >= v29
                    v32
            let v34 : bool = v33 = false
            let v74 : US9 =
                if v34 then
                    US9_1
                else
                    let v36 : bool = TraceState.trace_state.IsNone
                    if v36 then
                        let v37 : US2 = US2_0
                        let struct (v38 : Mut1, v39 : Mut3, v40 : Mut4, v41 : Mut5, v42 : Mut6, v43 : int64 option) = method6(v37)
                        let v44 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v38, v39, v40, v41, v42, v43) 
                        TraceState.trace_state <- v44 
                        ()
                    let struct (v45 : Mut1, v46 : Mut3, v47 : Mut4, v48 : Mut5, v49 : Mut6, v50 : int64 option) = TraceState.trace_state.Value
                    let v51 : string = method13(v45, v46, v47, v48, v49, v50)
                    let v52 : string = method16()
                    let v53 : string = method68(v45, v46, v47, v48, v49, v50, v51, v52, v1, v3, v8)
                    let v54 : bool = TraceState.trace_state.IsNone
                    if v54 then
                        let v55 : US2 = US2_0
                        let struct (v56 : Mut1, v57 : Mut3, v58 : Mut4, v59 : Mut5, v60 : Mut6, v61 : int64 option) = method6(v55)
                        let v62 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v56, v57, v58, v59, v60, v61) 
                        TraceState.trace_state <- v62 
                        ()
                    let struct (v63 : Mut1, v64 : Mut3, v65 : Mut4, v66 : Mut5, v67 : Mut6, v68 : int64 option) = TraceState.trace_state.Value
                    let v69 : int64 = v63.l0
                    let v70 : int64 = v69 + 1L
                    v63.l0 <- v70
                    let v71 : (string -> unit) = closure18()
                    v71 v53
                    let v72 : (string -> unit) = v64.l0
                    v72 v53
                    US9_0(v63, v64, v65, v66, v67, v68)
            let v75 : int64 = v1 + v8
            method70(v4, v75)
        else
            let v77 : bool = TraceState.trace_state.IsNone
            if v77 then
                let v78 : US2 = US2_0
                let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = method6(v78)
                let v85 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v79, v80, v81, v82, v83, v84) 
                TraceState.trace_state <- v85 
                ()
            let struct (v86 : Mut1, v87 : Mut3, v88 : Mut4, v89 : Mut5, v90 : Mut6, v91 : int64 option) = TraceState.trace_state.Value
            let v92 : US2 = v90.l0
            let v97 : int32 =
                match v92 with
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
            let v98 : bool = v88.l0
            let v99 : bool = v98 = false
            let v101 : bool =
                if v99 then
                    false
                else
                    let v100 : bool = 20 >= v97
                    v100
            let v102 : bool = v101 = false
            let v142 : US9 =
                if v102 then
                    US9_1
                else
                    let v104 : bool = TraceState.trace_state.IsNone
                    if v104 then
                        let v105 : US2 = US2_0
                        let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = method6(v105)
                        let v112 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v106, v107, v108, v109, v110, v111) 
                        TraceState.trace_state <- v112 
                        ()
                    let struct (v113 : Mut1, v114 : Mut3, v115 : Mut4, v116 : Mut5, v117 : Mut6, v118 : int64 option) = TraceState.trace_state.Value
                    let v119 : string = method13(v113, v114, v115, v116, v117, v118)
                    let v120 : string = method16()
                    let v121 : string = method143(v113, v114, v115, v116, v117, v118, v119, v120, v1, v3)
                    let v122 : bool = TraceState.trace_state.IsNone
                    if v122 then
                        let v123 : US2 = US2_0
                        let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = method6(v123)
                        let v130 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v124, v125, v126, v127, v128, v129) 
                        TraceState.trace_state <- v130 
                        ()
                    let struct (v131 : Mut1, v132 : Mut3, v133 : Mut4, v134 : Mut5, v135 : Mut6, v136 : int64 option) = TraceState.trace_state.Value
                    let v137 : int64 = v131.l0
                    let v138 : int64 = v137 + 1L
                    v131.l0 <- v138
                    let v139 : (string -> unit) = closure18()
                    v139 v121
                    let v140 : (string -> unit) = v132.l0
                    v140 v121
                    US9_0(v131, v132, v133, v134, v135, v136)
            method70(v4, v1)
    | UH1_0 -> (* Nil *)
        US15_1
and method62 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method63()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method62(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US15 = method67(v0, v7)
        match v8 with
        | US15_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 4738381338321616896L
            if v11 then
                v9
            else
                let v12 : uint8 = method63()
                let v13 : uint8 = method63()
                let v14 : uint8 = method63()
                let v15 : uint8 = method63()
                let v16 : uint8 = method63()
                let v17 : uint8 = method63()
                let v18 : uint8 = method63()
                let v19 : uint8 = method63()
                let v20 : uint8 = method63()
                let v21 : uint8 = method63()
                let v22 : uint8 = method63()
                let v23 : uint8 = method63()
                let v24 : uint8 = method63()
                let v25 : uint8 = method63()
                let v26 : uint8 = method63()
                let v27 : uint8 = method63()
                let v28 : uint8 = method63()
                let v29 : uint8 = method63()
                let v30 : uint8 = method63()
                let v31 : uint8 = method63()
                let v32 : uint8 = method63()
                let v33 : uint8 = method63()
                let v34 : uint8 = method63()
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
                method62(v58, v59)
        | _ ->
            let v62 : uint8 = method63()
            let v63 : uint8 = method63()
            let v64 : uint8 = method63()
            let v65 : uint8 = method63()
            let v66 : uint8 = method63()
            let v67 : uint8 = method63()
            let v68 : uint8 = method63()
            let v69 : uint8 = method63()
            let v70 : uint8 = method63()
            let v71 : uint8 = method63()
            let v72 : uint8 = method63()
            let v73 : uint8 = method63()
            let v74 : uint8 = method63()
            let v75 : uint8 = method63()
            let v76 : uint8 = method63()
            let v77 : uint8 = method63()
            let v78 : uint8 = method63()
            let v79 : uint8 = method63()
            let v80 : uint8 = method63()
            let v81 : uint8 = method63()
            let v82 : uint8 = method63()
            let v83 : uint8 = method63()
            let v84 : uint8 = method63()
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
            method62(v108, v109)
and method145 (v0 : int64) : string =
    let v1 : string = method18()
    let v2 : Mut5 = {l0 = v1} : Mut5
    method23(v2)
    method49(v2)
    method25(v2)
    let v3 : string = $"{v0}"
    method19(v2, v3)
    method30(v2)
    let v4 : string = v2.l0
    v4
and method144 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut5, v4 : Mut6, v5 : int64 option, v6 : string, v7 : string, v8 : int64) : string =
    let v9 : int64 = v0.l0
    let v10 : string = " "
    let v11 : string = v6 + v10 
    let v12 : string = method21(v9)
    let v13 : string = v11 + v12 
    let v14 : string = v13 + v7 
    let v15 : string = v14 + v10 
    let v20 : string = "dice.main"
    let v21 : string = v15 + v20 
    let v29 : string = " / "
    let v30 : string = v21 + v29 
    let v31 : string = method145(v8)
    let v32 : string = v30 + v31 
    method31(v32)
and closure88 () (v0 : (string [])) : int32 =
    let v1 : bool = TraceState.trace_state.IsNone
    if v1 then
        let v2 : US2 = US2_0
        let struct (v3 : Mut1, v4 : Mut3, v5 : Mut4, v6 : Mut5, v7 : Mut6, v8 : int64 option) = method6(v2)
        let v9 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v3, v4, v5, v6, v7, v8) 
        TraceState.trace_state <- v9 
        ()
    let struct (v10 : Mut1, v11 : Mut3, v12 : Mut4, v13 : Mut5, v14 : Mut6, v15 : int64 option) = TraceState.trace_state.Value
    let v16 : US2 = v14.l0
    let v21 : int32 =
        match v16 with
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
    let v22 : bool = v12.l0
    let v23 : bool = v22 = false
    let v25 : bool =
        if v23 then
            false
        else
            let v24 : bool = 20 >= v21
            v24
    let v26 : bool = v25 = false
    let v66 : US9 =
        if v26 then
            US9_1
        else
            let v28 : bool = TraceState.trace_state.IsNone
            if v28 then
                let v29 : US2 = US2_0
                let struct (v30 : Mut1, v31 : Mut3, v32 : Mut4, v33 : Mut5, v34 : Mut6, v35 : int64 option) = method6(v29)
                let v36 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v30, v31, v32, v33, v34, v35) 
                TraceState.trace_state <- v36 
                ()
            let struct (v37 : Mut1, v38 : Mut3, v39 : Mut4, v40 : Mut5, v41 : Mut6, v42 : int64 option) = TraceState.trace_state.Value
            let v43 : string = method13(v37, v38, v39, v40, v41, v42)
            let v44 : string = method16()
            let v45 : string = method60(v37, v38, v39, v40, v41, v42, v43, v44)
            let v46 : bool = TraceState.trace_state.IsNone
            if v46 then
                let v47 : US2 = US2_0
                let struct (v48 : Mut1, v49 : Mut3, v50 : Mut4, v51 : Mut5, v52 : Mut6, v53 : int64 option) = method6(v47)
                let v54 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v48, v49, v50, v51, v52, v53) 
                TraceState.trace_state <- v54 
                ()
            let struct (v55 : Mut1, v56 : Mut3, v57 : Mut4, v58 : Mut5, v59 : Mut6, v60 : int64 option) = TraceState.trace_state.Value
            let v61 : int64 = v55.l0
            let v62 : int64 = v61 + 1L
            v55.l0 <- v62
            let v63 : (string -> unit) = closure18()
            v63 v45
            let v64 : (string -> unit) = v56.l0
            v64 v45
            US9_0(v55, v56, v57, v58, v59, v60)
    let v67 : UH1 = UH1_0
    let v68 : int8 = 0y
    let v69 : int64 = method62(v67, v68)
    let v70 : bool = TraceState.trace_state.IsNone
    if v70 then
        let v71 : US2 = US2_0
        let struct (v72 : Mut1, v73 : Mut3, v74 : Mut4, v75 : Mut5, v76 : Mut6, v77 : int64 option) = method6(v71)
        let v78 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v72, v73, v74, v75, v76, v77) 
        TraceState.trace_state <- v78 
        ()
    let struct (v79 : Mut1, v80 : Mut3, v81 : Mut4, v82 : Mut5, v83 : Mut6, v84 : int64 option) = TraceState.trace_state.Value
    let v85 : US2 = v83.l0
    let v90 : int32 =
        match v85 with
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
    let v91 : bool = v81.l0
    let v92 : bool = v91 = false
    let v94 : bool =
        if v92 then
            false
        else
            let v93 : bool = 20 >= v90
            v93
    let v95 : bool = v94 = false
    let v135 : US9 =
        if v95 then
            US9_1
        else
            let v97 : bool = TraceState.trace_state.IsNone
            if v97 then
                let v98 : US2 = US2_0
                let struct (v99 : Mut1, v100 : Mut3, v101 : Mut4, v102 : Mut5, v103 : Mut6, v104 : int64 option) = method6(v98)
                let v105 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v99, v100, v101, v102, v103, v104) 
                TraceState.trace_state <- v105 
                ()
            let struct (v106 : Mut1, v107 : Mut3, v108 : Mut4, v109 : Mut5, v110 : Mut6, v111 : int64 option) = TraceState.trace_state.Value
            let v112 : string = method13(v106, v107, v108, v109, v110, v111)
            let v113 : string = method16()
            let v114 : string = method144(v106, v107, v108, v109, v110, v111, v112, v113, v69)
            let v115 : bool = TraceState.trace_state.IsNone
            if v115 then
                let v116 : US2 = US2_0
                let struct (v117 : Mut1, v118 : Mut3, v119 : Mut4, v120 : Mut5, v121 : Mut6, v122 : int64 option) = method6(v116)
                let v123 : struct (Mut1 * Mut3 * Mut4 * Mut5 * Mut6 * int64 option) option = Some struct (v117, v118, v119, v120, v121, v122) 
                TraceState.trace_state <- v123 
                ()
            let struct (v124 : Mut1, v125 : Mut3, v126 : Mut4, v127 : Mut5, v128 : Mut6, v129 : int64 option) = TraceState.trace_state.Value
            let v130 : int64 = v124.l0
            let v131 : int64 = v130 + 1L
            v124.l0 <- v131
            let v132 : (string -> unit) = closure18()
            v132 v114
            let v133 : (string -> unit) = v125.l0
            v133 v114
            US9_0(v124, v125, v126, v127, v128, v129)
    0
let v6 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v6 x
let v17 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v17 x
let v22 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure19()
let roll_progressively x = v22 x
let v27 : (uint64 -> (UH1 -> uint64 option)) = closure86()
let roll_within_bounds x = v27 x
let v32 : ((string []) -> int32) = closure88()
let main args = v32 args
()
