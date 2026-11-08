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
and [<Struct>] US2 =
    | US2_Fresh
    | US2_Slide
    | US2_Recycle
and [<Struct>] US4 =
    | US4_EmptyRange
    | US4_AboveLargest of f1_0 : uint64 * f1_1 : uint64
and [<Struct>] US3 =
    | US3_Ok of f0_0 : uint64
    | US3_Error of f1_0 : US4
and Mut2 = {mutable l0 : string}
and [<Struct>] US5 =
    | US5_One
    | US5_Two
    | US5_Three
    | US5_Four
    | US5_Five
    | US5_Six
and [<Struct>] US6 =
    | US6_Some of f0_0 : US5
    | US6_None
and [<Struct>] US7 =
    | US7_Ok of f0_0 : uint64
    | US7_Error of f1_0 : uint64 * f1_1 : uint64
and UH2 =
    | UH2_Nil
    | UH2_Cons of US5 * UH2
and [<Struct>] US8 =
    | US8_Some of f0_0 : uint64
    | US8_None
and [<Struct>] US9 =
    | US9_Some of f0_0 : UH2
    | US9_None
and [<Struct>] US10 =
    | US10_Verbose
    | US10_Debug
    | US10_Info
    | US10_Warning
    | US10_Critical
and Mut3 = {mutable l0 : (string -> unit)}
and Mut4 = {mutable l0 : bool}
and Mut5 = {mutable l0 : US10}
and [<Struct>] US11 =
    | US11_Some of f0_0 : US10
    | US11_None
and [<Struct>] US12 =
    | US12_Some of f0_0 : int64
    | US12_None
and [<Struct>] US13 =
    | US13_Some of f0_0 : string
    | US13_None
and Mut6 = {mutable l0 : int32; mutable l1 : US11}
and [<Struct>] US14 =
    | US14_Some of f0_0 : Mut1 * f0_1 : Mut3 * f0_2 : Mut4 * f0_3 : Mut2 * f0_4 : Mut5 * f0_5 : int64 option
    | US14_None
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
and method6 (v0 : int64, v1 : UH0) : US1 =
    match v1 with
    | UH0_StreamCons(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US1_Some(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method6(v6, v7)
    | UH0_StreamNil -> (* StreamNil *)
        US1_None
and method5 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1) : uint8 =
    let v4 : UH0 = v0 ()
    let v5 : int64 = v1.l0
    let v6 : US1 = method6(v5, v4)
    match v6 with
    | US1_None -> (* None *)
        let v10 : int64 = v3.l0
        let v11 : bool = v10 = -1L
        if v11 then
            let v12 : int64 = v1.l0
            v3.l0 <- v12
            ()
        let v13 : int64 = v2.l0
        let v14 : int64 = v3.l0
        let v15 : bool = v13 >= v14
        let v18 : int64 =
            if v15 then
                1L
            else
                let v16 : int64 = v2.l0
                let v17 : int64 = v16 + 1L
                v17
        v2.l0 <- v18
        let v19 : int64 = v2.l0
        let v20 : int64 = v19 - 1L
        v1.l0 <- v20
        method5(v0, v1, v2, v3)
    | US1_Some(v7) -> (* Some *)
        let v8 : int64 = v1.l0
        let v9 : int64 = v8 + 1L
        v1.l0 <- v9
        v7
and closure7 (v0 : (unit -> UH0), v1 : Mut1, v2 : Mut1, v3 : Mut1) () : uint8 =
    method5(v0, v1, v2, v3)
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
    closure7(v7, v8, v9, v10)
and method8 () : string =
    let v0 : string = ""
    v0
and method9 (v0 : Mut2, v1 : string) : unit =
    let v2 : string = v0.l0
    let v3 : string = (v2 + v1)
    v0.l0 <- v3
    ()
and format_real_7 (v0 : uint64) : string =
    let v1 : string = method8()
    let v2 : Mut2 = {l0 = v1} : Mut2
    let v3 : string = $"{v0}"
    method9(v2, v3)
    let v4 : string = v2.l0
    v4
and go_10 (v0 : uint64, v1 : int32, v2 : uint64) : int32 =
    let v3 : bool = v2 >= v0
    if v3 then
        v1
    else
        let v4 : int32 = v1 + 1
        let v5 : uint64 = v2 * 6UL
        go_10(v0, v4, v5)
and draw_rolled_13 (v0 : (unit -> uint8)) : US5 =
    let v1 : uint8 = v0 ()
    let v2 : bool = v1 >= 1uy
    let v4 : bool =
        if v2 then
            let v3 : bool = v1 <= 6uy
            v3
        else
            false
    let v25 : US6 =
        if v4 then
            let v5 : uint8 = v1 - 1uy
            let v6 : int32 = int32 v5
            let v7 : bool = 0 = v6
            let v22 : US5 =
                if v7 then
                    US5_One
                else
                    let v9 : bool = 1 = v6
                    if v9 then
                        US5_Two
                    else
                        let v11 : bool = 2 = v6
                        if v11 then
                            US5_Three
                        else
                            let v13 : bool = 3 = v6
                            if v13 then
                                US5_Four
                            else
                                let v15 : bool = 4 = v6
                                if v15 then
                                    US5_Five
                                else
                                    US5_Six
            US6_Some(v22)
        else
            US6_None
    match v25 with
    | US6_None -> (* None *)
        draw_rolled_13(v0)
    | US6_Some(v26) -> (* Some *)
        v26
and read_12 (v0 : int32, v1 : uint64, v2 : uint64, v3 : (unit -> uint8)) : struct (uint64 * (unit -> uint8)) =
    let v4 : bool = v0 <= 0
    if v4 then
        struct (v2, v3)
    else
        let v5 : US5 = draw_rolled_13(v3)
        let v6 : int32 = v0 - 1
        let v7 : uint64 = v1 * 6UL
        let v8 : int32 = (match v5 with | US5_One -> 0 | US5_Two -> 1 | US5_Three -> 2 | US5_Four -> 3 | US5_Five -> 4 | US5_Six -> 5)
        let v9 : uint64 = uint64 v8
        let v10 : uint64 = v9 * v1
        let v11 : uint64 = v2 + v10
        read_12(v6, v7, v11, v3)
and roll_fresh_11 (v0 : uint64, v1 : int32, v2 : (unit -> uint8)) : struct (uint64 * (unit -> uint8)) =
    let v3 : uint64 = 1UL
    let v4 : uint64 = 0UL
    let struct (v5 : uint64, v6 : (unit -> uint8)) = read_12(v1, v3, v4, v2)
    let v7 : bool = v5 < v0
    if v7 then
        let v8 : uint64 = v5 + 1UL
        struct (v8, v6)
    else
        roll_fresh_11(v0, v1, v6)
and roll_recycled_14 (v0 : uint64, v1 : uint64, v2 : uint64, v3 : (unit -> uint8)) : struct (uint64 * (unit -> uint8)) =
    let v4 : uint64 = v2 / v0
    let v5 : uint64 = v4 * v0
    let v6 : bool = v1 < v5
    let v13 : US7 =
        if v6 then
            let v7 : uint64 = v1 % v0
            let v8 : uint64 = v7 + 1UL
            US7_Ok(v8)
        else
            let v10 : uint64 = v1 - v5
            let v11 : uint64 = v2 - v5
            US7_Error(v10, v11)
    match v13 with
    | US7_Error(v15, v16) -> (* Error *)
        let v17 : US5 = draw_rolled_13(v3)
        let v18 : bool = v16 > 3074457345618258602UL
        let struct (v26 : uint64, v27 : uint64) =
            if v18 then
                let v19 : int32 = (match v17 with | US5_One -> 0 | US5_Two -> 1 | US5_Three -> 2 | US5_Four -> 3 | US5_Five -> 4 | US5_Six -> 5)
                let v20 : uint64 = uint64 v19
                struct (v20, 6UL)
            else
                let v21 : uint64 = v15 * 6UL
                let v22 : int32 = (match v17 with | US5_One -> 0 | US5_Two -> 1 | US5_Three -> 2 | US5_Four -> 3 | US5_Five -> 4 | US5_Six -> 5)
                let v23 : uint64 = uint64 v22
                let v24 : uint64 = v21 + v23
                let v25 : uint64 = v16 * 6UL
                struct (v24, v25)
        roll_recycled_14(v0, v26, v27, v3)
    | US7_Ok(v14) -> (* Ok *)
        struct (v14, v3)
and roll_hand_15 (v0 : int32, v1 : UH2, v2 : (unit -> uint8)) : struct (UH2 * (unit -> uint8)) =
    let v3 : bool = v0 <= 0
    if v3 then
        struct (v1, v2)
    else
        let v4 : US5 = draw_rolled_13(v2)
        let v5 : int32 = v0 - 1
        let v6 : UH2 = UH2_Cons(v4, v1)
        roll_hand_15(v5, v6, v2)
and go_17 (v0 : uint64, v1 : int32, v2 : UH2, v3 : uint64) : US8 =
    let v4 : bool = v1 <= 0
    if v4 then
        let v5 : bool = v3 < v0
        if v5 then
            let v6 : uint64 = v3 + 1UL
            US8_Some(v6)
        else
            US8_None
    else
        match v2 with
        | UH2_Cons(v10, v11) -> (* Cons *)
            let v12 : int32 = (match v10 with | US5_One -> 0 | US5_Two -> 1 | US5_Three -> 2 | US5_Four -> 3 | US5_Five -> 4 | US5_Six -> 5)
            let v13 : uint64 = uint64 v12
            let v14 : bool = v13 >= v0
            let v19 : bool =
                if v14 then
                    true
                else
                    let v15 : uint64 = v0 - 1UL
                    let v16 : uint64 = v15 - v13
                    let v17 : uint64 = v16 / 6UL
                    let v18 : bool = v3 > v17
                    v18
            if v19 then
                US8_None
            else
                let v21 : int32 = v1 - 1
                let v22 : uint64 = v3 * 6UL
                let v23 : uint64 = v22 + v13
                go_17(v0, v21, v11, v23)
        | UH2_Nil -> (* Nil *)
            US8_None
and roll_slid_16 (v0 : uint64, v1 : int32, v2 : UH2, v3 : (unit -> uint8)) : struct (uint64 * (unit -> uint8)) =
    let v4 : uint64 = 0UL
    let v5 : US8 = go_17(v0, v1, v2, v4)
    match v5 with
    | US8_None -> (* None *)
        let v7 : US5 = draw_rolled_13(v3)
        let v8 : UH2 = UH2_Cons(v7, v2)
        roll_slid_16(v0, v1, v8, v3)
    | US8_Some(v6) -> (* Some *)
        struct (v6, v3)
and closure10 (v0 : (unit -> uint8), v1 : bool) (v2 : uint64) : uint64 =
    let v5 : US2 =
        if v1 then
            US2_Fresh
        else
            US2_Slide
    let v6 : bool = v2 < 1UL
    let v14 : US3 =
        if v6 then
            let v7 : US4 = US4_EmptyRange
            US3_Error(v7)
        else
            let v9 : bool = v2 > 4738381338321616896UL
            if v9 then
                let v10 : US4 = US4_AboveLargest(v2, 4738381338321616896UL)
                US3_Error(v10)
            else
                US3_Ok(v2)
    match v14 with
    | US3_Error(v38) -> (* Error *)
        let v48 : string =
            match v38 with
            | US4_AboveLargest(v40, v41) -> (* AboveLargest *)
                let v42 : string = format_real_7(v40)
                let v43 : string = ("max: " + v42)
                let v44 : string = (v43 + " is above the largest supported bound ")
                let v45 : string = format_real_7(v41)
                let v46 : string = (v44 + v45)
                v46
            | US4_EmptyRange -> (* EmptyRange *)
                let v39 : string = "max must be at least 1"
                v39
        failwith<uint64> v48
    | US3_Ok(v15) -> (* Ok *)
        let v16 : bool = v15 = 1UL
        let v20 : int32 =
            if v16 then
                1
            else
                let v17 : int32 = 0
                let v18 : uint64 = 1UL
                go_10(v15, v17, v18)
        let struct (v36 : uint64, v37 : (unit -> uint8)) =
            match v5 with
            | US2_Fresh -> (* Fresh *)
                roll_fresh_11(v15, v20, v0)
            | US2_Recycle -> (* Recycle *)
                let v21 : uint64 = 0UL
                let v22 : uint64 = 1UL
                roll_recycled_14(v15, v21, v22, v0)
            | US2_Slide -> (* Slide *)
                let v27 : UH2 = UH2_Nil
                let struct (v28 : UH2, v29 : (unit -> uint8)) = roll_hand_15(v20, v27, v0)
                roll_slid_16(v15, v20, v28, v29)
        v36
and closure9 (v0 : (unit -> uint8)) (v1 : bool) : (uint64 -> uint64) =
    closure10(v0, v1)
and closure8 () (v0 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure9(v0)
and method19 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_Cons(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_Cons(v2, v1)
        method19(v3, v4)
    | UH2_Nil -> (* Nil *)
        v1
and go_18 (v0 : UH1, v1 : UH2) : US9 =
    match v0 with
    | UH1_Cons(v2, v3) -> (* Cons *)
        let v4 : bool = v2 >= 1uy
        let v6 : bool =
            if v4 then
                let v5 : bool = v2 <= 6uy
                v5
            else
                false
        let v27 : US6 =
            if v6 then
                let v7 : uint8 = v2 - 1uy
                let v8 : int32 = int32 v7
                let v9 : bool = 0 = v8
                let v24 : US5 =
                    if v9 then
                        US5_One
                    else
                        let v11 : bool = 1 = v8
                        if v11 then
                            US5_Two
                        else
                            let v13 : bool = 2 = v8
                            if v13 then
                                US5_Three
                            else
                                let v15 : bool = 3 = v8
                                if v15 then
                                    US5_Four
                                else
                                    let v17 : bool = 4 = v8
                                    if v17 then
                                        US5_Five
                                    else
                                        US5_Six
                US6_Some(v24)
            else
                US6_None
        match v27 with
        | US6_None -> (* None *)
            US9_None
        | US6_Some(v28) -> (* Some *)
            let v29 : UH2 = UH2_Cons(v28, v1)
            go_18(v3, v29)
    | UH1_Nil -> (* Nil *)
        let v34 : UH2 = UH2_Nil
        let v35 : UH2 = method19(v1, v34)
        US9_Some(v35)
and method20 (v0 : UH2, v1 : int32) : int32 =
    match v0 with
    | UH2_Cons(v2, v3) -> (* Cons *)
        let v4 : int32 = v1 + 1
        method20(v3, v4)
    | UH2_Nil -> (* Nil *)
        v1
and closure12 (v0 : uint64) (v1 : UH1) : uint64 option =
    let v2 : bool = v0 < 1UL
    let v10 : US3 =
        if v2 then
            let v3 : US4 = US4_EmptyRange
            US3_Error(v3)
        else
            let v5 : bool = v0 > 4738381338321616896UL
            if v5 then
                let v6 : US4 = US4_AboveLargest(v0, 4738381338321616896UL)
                US3_Error(v6)
            else
                US3_Ok(v0)
    let v11 : UH2 = UH2_Nil
    let v12 : US9 = go_18(v1, v11)
    let v22 : US8 =
        match v10 with
        | US3_Ok(v13) -> (* Ok *)
            match v12 with
            | US9_Some(v14) -> (* Some *)
                let v15 : int32 = 0
                let v16 : int32 = method20(v14, v15)
                let v17 : uint64 = 0UL
                go_17(v13, v16, v14, v17)
            | _ ->
                US8_None
        | _ ->
            US8_None
    match v22 with
    | US8_None -> (* None *)
        let v25 : uint64 option = None
        v25
    | US8_Some(v23) -> (* Some *)
        let v24 : uint64 option = Some v23 
        v24
and roll_within_bounds__c11 () (v0 : uint64) : (UH1 -> uint64 option) =
    closure12(v0)
and go_21 (v0 : int32, v1 : int64) : int32 =
    let v2 : bool = v1 >= 4738381338321616896L
    if v2 then
        v0
    else
        let v3 : int32 = v0 + 1
        let v4 : int64 = v1 * 6L
        go_21(v3, v4)
and read_23 (v0 : int32, v1 : int64, v2 : int64) : int64 =
    let v3 : bool = v0 <= 0
    if v3 then
        v2
    else
        let v4 : (unit -> System.Random) = System.Random 
        let v5 : System.Random = v4 ()
        let v6 : int32 = v5.Next (0, 6)
        let v7 : bool = 0 = v6
        let v22 : US5 =
            if v7 then
                US5_One
            else
                let v9 : bool = 1 = v6
                if v9 then
                    US5_Two
                else
                    let v11 : bool = 2 = v6
                    if v11 then
                        US5_Three
                    else
                        let v13 : bool = 3 = v6
                        if v13 then
                            US5_Four
                        else
                            let v15 : bool = 4 = v6
                            if v15 then
                                US5_Five
                            else
                                US5_Six
        let v23 : int32 = v0 - 1
        let v24 : int64 = v1 * 6L
        let v25 : int32 = (match v22 with | US5_One -> 0 | US5_Two -> 1 | US5_Three -> 2 | US5_Four -> 3 | US5_Five -> 4 | US5_Six -> 5)
        let v26 : int64 = int64 v25
        let v27 : int64 = v26 * v1
        let v28 : int64 = v2 + v27
        read_23(v23, v24, v28)
and roll_fresh_22 (v0 : int64, v1 : int32) : int64 =
    let v2 : int64 = 1L
    let v3 : int64 = 0L
    let v4 : int64 = read_23(v1, v2, v3)
    let v5 : bool = v4 < v0
    if v5 then
        let v6 : int64 = v4 + 1L
        v6
    else
        roll_fresh_22(v0, v1)
and closure14 () (v0 : string) : US13 =
    US13_Some(v0)
and method27 () : (string -> US13) =
    closure14()
and get_environment_variable_26 (v0 : string) : string =
    let v1 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v2 : string = v1 v0
    let v3 : (string -> string option) = Option.ofObj
    let v4 : string option = v3 v2
    let v5 : (string -> US13) = method27()
    let v6 : US13 option = v4 |> Option.map v5 
    let v7 : US13 = US13_None
    let v8 : US13 = v6 |> Option.defaultValue v7 
    match v8 with
    | US13_None -> (* None *)
        let v10 : string = ""
        v10
    | US13_Some(v9) -> (* Some *)
        v9
and method28 (v0 : Mut6) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 > 0
    v2
and method25 () : struct (US11 * US12) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = get_environment_variable_26(v0)
    
    
    
    
    
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
    let v17 : struct (string * US10) list = []
    let v18 : US10 = US10_Critical
    let v19 : struct (string * US10) list = struct (v4, v18) :: v17 
    let v20 : US10 = US10_Warning
    let v21 : struct (string * US10) list = struct (v7, v20) :: v19 
    let v22 : US10 = US10_Info
    let v23 : struct (string * US10) list = struct (v10, v22) :: v21 
    let v24 : US10 = US10_Debug
    let v25 : struct (string * US10) list = struct (v13, v24) :: v23 
    let v26 : US10 = US10_Verbose
    let v27 : struct (string * US10) list = struct (v16, v26) :: v25 
    let v28 : US10 = US10_Critical
    let v29 : struct (string * US10) list = struct (v2, v28) :: v27 
    let v30 : US10 = US10_Warning
    let v31 : struct (string * US10) list = struct (v5, v30) :: v29 
    let v32 : US10 = US10_Info
    let v33 : struct (string * US10) list = struct (v8, v32) :: v31 
    let v34 : US10 = US10_Debug
    let v35 : struct (string * US10) list = struct (v11, v34) :: v33 
    let v36 : US10 = US10_Verbose
    let v37 : struct (string * US10) list = struct (v14, v36) :: v35 
    let v38 : (struct (string * US10) list -> (struct (string * US10) [])) = List.toArray
    let v39 : (struct (string * US10) []) = v38 v37
    let v40 : int32 = v39.Length
    let v41 : US11 = US11_None
    let v42 : Mut6 = {l0 = v40; l1 = v41} : Mut6
    while method28(v42) do
        let v44 : int32 = v42.l0
        let v45 : int32 = v44 - 1
        let v46 : US11 = v42.l1
        let struct (v47 : string, v48 : US10) = v39.[int v45]
        let v55 : US11 =
            match v46 with
            | US11_None -> (* None *)
                let v50 : bool = v47 = v1 
                if v50 then
                    US11_Some(v48)
                else
                    US11_None
            | US11_Some(v49) -> (* Some *)
                v46
        v42.l0 <- v45
        v42.l1 <- v55
        ()
    let v56 : US11 = v42.l1
    let v57 : string = "AUTOMATION"
    let v58 : string = get_environment_variable_26(v57)
    let v59 : string = "True"
    let v60 : bool = v58 <> v59 
    let v67 : US12 =
        if v60 then
            US12_None
        else
            let v62 : System.DateTime = System.DateTime.Now
            let v63 : int64 = v62.Ticks
            let v64 : int64 = v63 - 621355968000000000L
            let v65 : int64 = v64 / 10L
            US12_Some(v65)
    struct (v56, v67)
and closure15 () (v0 : string) : unit =
    ()
and new_trace_state_24 (v0 : US10) : struct (Mut1 * Mut3 * Mut4 * Mut2 * Mut5 * int64 option) =
    let struct (v1 : US11, v2 : US12) = method25()
    let v3 : Mut1 = {l0 = 1L} : Mut1
    let v4 : (string -> unit) = closure15()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : Mut4 = {l0 = true} : Mut4
    let v7 : string = ""
    let v8 : Mut2 = {l0 = v7} : Mut2
    let v11 : US10 =
        match v1 with
        | US11_None -> (* None *)
            v0
        | US11_Some(v9) -> (* Some *)
            v9
    let v12 : Mut5 = {l0 = v11} : Mut5
    let v17 : int64 option =
        match v2 with
        | US12_None -> (* None *)
            let v15 : int64 option = None
            v15
        | US12_Some(v13) -> (* Some *)
            let v14 : int64 option = Some v13 
            v14
    struct (v3, v5, v6, v8, v12, v17)
and closure16 () (v0 : int64) : US12 =
    US12_Some(v0)
and method31 () : (int64 -> US12) =
    closure16()
and method32 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and time_30 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut2, v4 : Mut5, v5 : int64 option) : string =
    let v6 : (int64 -> US12) = method31()
    let v7 : US12 option = v5 |> Option.map v6 
    let v8 : US12 = US12_None
    let v9 : US12 = v7 |> Option.defaultValue v8 
    let v29 : System.DateTime =
        match v9 with
        | US12_None -> (* None *)
            let v27 : System.DateTime = System.DateTime.Now
            v27
        | US12_Some(v10) -> (* Some *)
            let v11 : System.DateTime = System.DateTime.Now
            let v12 : int64 = v11.Ticks
            let v13 : int64 = v12 - 621355968000000000L
            let v14 : int64 = v13 / 10L
            let v15 : int64 = v14 - v10
            let v16 : int64 = v15 * 10L
            let v17 : System.TimeSpan = System.TimeSpan.FromTicks(v16)
            let v18 : (System.TimeSpan -> int32) = _.Hours
            let v19 : int32 = v18 v17
            let v20 : (System.TimeSpan -> int32) = _.Minutes
            let v21 : int32 = v20 v17
            let v22 : (System.TimeSpan -> int32) = _.Seconds
            let v23 : int32 = v22 v17
            let v24 : (System.TimeSpan -> int32) = _.Milliseconds
            let v25 : int32 = v24 v17
            let v26 : System.DateTime = System.DateTime (1, 1, 1, v19, v21, v23, v25)
            v26
    let v30 : string = method32()
    let v31 : bool = v30 = ""
    let v33 : string =
        if v31 then
            let v32 : string = "M-d-y hh:mm:ss tt"
            v32
        else
            v30
    let v34 : (string -> string) = v29.ToString
    v34 v33
and format_real_33 (v0 : int64) : string =
    let v1 : string = method8()
    let v2 : Mut2 = {l0 = v1} : Mut2
    let v3 : string = $"{v0}"
    method9(v2, v3)
    let v4 : string = v2.l0
    v4
and level_str_34 () : string =
    let v0 : string = "\u001b[94m"
    let v1 : string = (v0 + "d")
    let v2 : string = "\u001b[0m"
    let v3 : string = (v1 + v2)
    v3
and method36 (v0 : string, v1 : int32, v2 : int32) : int32 =
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
            method36(v0, v1, v12)
        else
            v2
and method37 (v0 : string, v1 : int32) : int32 =
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
            method37(v0, v3)
        else
            v3
and method35 (v0 : string) : string =
    let v1 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v0))
    let v2 : int32 = 0
    let v3 : int32 = method36(v0, v1, v2)
    let v4 : int32 = v1 - 1
    let v5 : string = (spiralStringSlice v0 (int v3) (int v4))
    let v6 : int32 = (System.Text.Encoding.UTF8.GetByteCount(v5))
    let v7 : int32 = method37(v5, v6)
    let v8 : string = (spiralStringSlice v5 (int 0) (int v7))
    v8
and method29 (v0 : Mut1, v1 : Mut3, v2 : Mut4, v3 : Mut2, v4 : Mut5, v5 : int64 option, v6 : Mut1, v7 : Mut3, v8 : Mut4, v9 : Mut2, v10 : Mut5, v11 : int64 option, v12 : int64) : string =
    let v13 : int64 = v0.l0
    let v14 : string = time_30(v6, v7, v8, v9, v10, v11)
    let v15 : string = (v14 + " ")
    let v16 : string = format_real_33(v13)
    let v17 : string = (v15 + v16)
    let v18 : string = level_str_34()
    let v19 : string = (v17 + v18)
    let v20 : string = (v19 + " ")
    let v21 : string = (v20 + "dice.main")
    let v22 : string = (v21 + " / ")
    let v23 : string = format_real_33(v12)
    let v24 : string = ("result = " + v23)
    let v25 : string = ("{ " + v24)
    let v26 : string = (v25 + " }")
    let v27 : string = (v22 + v26)
    method35(v27)
and closure17 () (v0 : string) : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure13 () (v0 : (string [])) : int32 =
    let v1 : int32 = 0
    let v2 : int64 = 1L
    let v3 : int32 = go_21(v1, v2)
    let v4 : int64 = 4738381338321616896L
    let v5 : int64 = roll_fresh_22(v4, v3)
    let v6 : bool = TraceState.trace_state.IsNone
    if v6 then
        let v7 : US10 = US10_Verbose
        let struct (v8 : Mut1, v9 : Mut3, v10 : Mut4, v11 : Mut2, v12 : Mut5, v13 : int64 option) = new_trace_state_24(v7)
        let v14 : struct (Mut1 * Mut3 * Mut4 * Mut2 * Mut5 * int64 option) option = Some struct (v8, v9, v10, v11, v12, v13) 
        TraceState.trace_state <- v14 
        ()
    let struct (v15 : Mut1, v16 : Mut3, v17 : Mut4, v18 : Mut2, v19 : Mut5, v20 : int64 option) = TraceState.trace_state.Value
    let v21 : US10 = v19.l0
    let v26 : int32 =
        match v21 with
        | US10_Critical -> (* Critical *)
            50
        | US10_Debug -> (* Debug *)
            20
        | US10_Info -> (* Info *)
            30
        | US10_Verbose -> (* Verbose *)
            10
        | US10_Warning -> (* Warning *)
            40
    let v27 : bool = v17.l0
    let v28 : bool = v27 = false
    let v30 : bool =
        if v28 then
            false
        else
            let v29 : bool = 20 >= v26
            v29
    let v31 : bool = v30 = false
    let v69 : US14 =
        if v31 then
            US14_None
        else
            let v33 : bool = TraceState.trace_state.IsNone
            if v33 then
                let v34 : US10 = US10_Verbose
                let struct (v35 : Mut1, v36 : Mut3, v37 : Mut4, v38 : Mut2, v39 : Mut5, v40 : int64 option) = new_trace_state_24(v34)
                let v41 : struct (Mut1 * Mut3 * Mut4 * Mut2 * Mut5 * int64 option) option = Some struct (v35, v36, v37, v38, v39, v40) 
                TraceState.trace_state <- v41 
                ()
            let struct (v42 : Mut1, v43 : Mut3, v44 : Mut4, v45 : Mut2, v46 : Mut5, v47 : int64 option) = TraceState.trace_state.Value
            let v48 : string = method29(v42, v43, v44, v45, v46, v47, v42, v43, v44, v45, v46, v47, v5)
            let v49 : bool = TraceState.trace_state.IsNone
            if v49 then
                let v50 : US10 = US10_Verbose
                let struct (v51 : Mut1, v52 : Mut3, v53 : Mut4, v54 : Mut2, v55 : Mut5, v56 : int64 option) = new_trace_state_24(v50)
                let v57 : struct (Mut1 * Mut3 * Mut4 * Mut2 * Mut5 * int64 option) option = Some struct (v51, v52, v53, v54, v55, v56) 
                TraceState.trace_state <- v57 
                ()
            let struct (v58 : Mut1, v59 : Mut3, v60 : Mut4, v61 : Mut2, v62 : Mut5, v63 : int64 option) = TraceState.trace_state.Value
            let v64 : int64 = v58.l0
            let v65 : int64 = v64 + 1L
            v58.l0 <- v65
            let v66 : (string -> unit) = closure17()
            v66 v48
            let v67 : (string -> unit) = v59.l0
            v67 v48
            US14_Some(v58, v59, v60, v61, v62, v63)
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : (UH1 -> (unit -> uint8)) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) = closure8()
let roll_progressively x = v2 x
let v3 : (uint64 -> (UH1 -> uint64 option)) = roll_within_bounds__c11()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure13()
let main args = v4 args
()
