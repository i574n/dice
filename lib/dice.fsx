type UH0 =
    | UH0_0 of uint8 * (unit -> UH0)
    | UH0_1
and UH1 =
    | UH1_0
    | UH1_1 of uint8 * UH1
and [<Struct>] US0 =
    | US0_0 of f0_0 : (string -> unit)
    | US0_1
and [<Struct>] US1 =
    | US1_0 of f0_0 : (unit -> UH0)
    | US1_1 of f1_0 : UH0
and Mut0 = {mutable l0 : US1}
and Mut1 = {mutable l0 : int64}
and [<Struct>] US2 =
    | US2_0 of f0_0 : uint8
    | US2_1
and Mut2 = {mutable l0 : US2}
and [<Struct>] US3 =
    | US3_0 of f0_0 : uint64 * f0_1 : UH1
    | US3_1
and UH2 =
    | UH2_0 of uint64 * (unit -> UH2)
    | UH2_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : uint64
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64 * f0_1 : UH1
    | US5_1
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
and closure5 (v0 : UH0) () : UH0 =
    v0
and method3 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method3(v3, v1)
        let v5 : (unit -> UH0) = closure5(v4)
        UH0_0(v2, v5)
    | UH1_0 -> (* Nil *)
        v1
and closure6 (v0 : UH0) () : UH0 =
    v0
and closure7 (v0 : UH0, v1 : Mut0) () : UH0 =
    let v2 : US1 = v1.l0
    match v2 with
    | US1_1(v3) -> (* Computed *)
        v3
    | US1_0(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method4(v0, v8)
                UH0_0(v7, v9)
            | UH0_1 -> (* StreamNil *)
                UH0_1
        let v13 : US1 = US1_1(v12)
        v1.l0 <- v13
        v12
and method4 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US1 = US1_0(v1)
    let v3 : Mut0 = {l0 = v2} : Mut0
    closure7(v0, v3)
and method6 (v0 : int64, v1 : UH0) : US2 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US2_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method6(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US2_1
and method5 (v0 : US0, v1 : (unit -> UH0), v2 : Mut1, v3 : Mut1, v4 : Mut1, v5 : Mut2) : uint8 =
    let v6 : int64 = v2.l0
    let v7 : int64 = v3.l0
    let v8 : int64 = v4.l0
    let v9 : US2 = v5.l0
    let v10 : string = $"create_sequential_roller / roll / current_index: {v6} / acc: {v7} / len: {v8} / last_item: %A{v9}"
    match v0 with
    | US0_1 -> (* None *)
        ()
    | US0_0(v11) -> (* Some *)
        v11 v10
    let v12 : UH0 = v1 ()
    let v13 : int64 = v2.l0
    let v14 : US2 = method6(v13, v12)
    match v14 with
    | US2_1 -> (* None *)
        let v19 : string = $"create_sequential_roller / roll / None"
        match v0 with
        | US0_1 -> (* None *)
            ()
        | US0_0(v20) -> (* Some *)
            v20 v19
        let v21 : int64 = v4.l0
        let v22 : bool = v21 = -1L
        if v22 then
            let v23 : int64 = v2.l0
            v4.l0 <- v23
            ()
        let v24 : int64 = v3.l0
        let v25 : int64 = v4.l0
        let v26 : bool = v24 >= v25
        let v29 : int64 =
            if v26 then
                1L
            else
                let v27 : int64 = v3.l0
                let v28 : int64 = v27 + 1L
                v28
        v3.l0 <- v29
        let v30 : int64 = v3.l0
        let v31 : int64 = v30 - 1L
        v2.l0 <- v31
        let v32 : US2 = US2_1
        v5.l0 <- v32
        method5(v0, v1, v2, v3, v4, v5)
    | US2_0(v15) -> (* Some *)
        let v16 : int64 = v2.l0
        let v17 : int64 = v16 + 1L
        v2.l0 <- v17
        let v18 : US2 = US2_0(v15)
        v5.l0 <- v18
        v15
and closure8 (v0 : US0, v1 : (unit -> UH0), v2 : Mut1, v3 : Mut1, v4 : Mut1, v5 : Mut2) () : uint8 =
    method5(v0, v1, v2, v3, v4, v5)
and closure4 (v0 : US0) (v1 : UH1) : (unit -> uint8) =
    let v2 : string = $"create_sequential_roller ()"
    match v0 with
    | US0_1 -> (* None *)
        ()
    | US0_0(v3) -> (* Some *)
        v3 v2
    let v4 : UH1 = UH1_0
    let v5 : UH1 = method1(v1, v4)
    let v6 : UH1 = method2(v1, v5)
    let v7 : UH0 = UH0_1
    let v8 : UH0 = method3(v6, v7)
    let v9 : (unit -> UH0) = closure6(v8)
    let v10 : (unit -> UH0) = method4(v8, v9)
    let v11 : Mut1 = {l0 = 0L} : Mut1
    let v12 : Mut1 = {l0 = 1L} : Mut1
    let v13 : Mut1 = {l0 = -1L} : Mut1
    let v14 : US2 = US2_1
    let v15 : Mut2 = {l0 = v14} : Mut2
    closure8(v0, v10, v11, v12, v13, v15)
and closure3 () (v0 : (string -> unit) option) : (UH1 -> (unit -> uint8)) =
    let v3 : US0 option = None
    let _v3 = ref v3 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : (string -> unit) = x
    let v5 : US0 = US0_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US0 option = _v3.Value 
    let v29 : US0 = US0_1
    let v30 : US0 = v6 |> Option.defaultValue v29 
    closure4(v30)
and method7 (v0 : US0, v1 : uint64, v2 : int8, v3 : uint64) : int8 =
    let v4 : bool = v3 < v1
    if v4 then
        let v5 : uint64 = v3 * 6UL
        let v6 : bool = v5 > v3
        if v6 then
            let v7 : int8 = v2 + 1y
            method7(v0, v1, v7, v5)
        else
            let v9 : string = $"calculate_dice_count / max: {v1} / n: {v2} / p: {v3}"
            match v0 with
            | US0_1 -> (* None *)
                ()
            | US0_0(v10) -> (* Some *)
                v10 v9
            v2
    else
        let v12 : string = $"calculate_dice_count / max: {v1} / n: {v2} / p: {v3}"
        match v0 with
        | US0_1 -> (* None *)
            ()
        | US0_0(v13) -> (* Some *)
            v13 v12
        v2
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(0UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(9223372036854775808UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(4611686018427387904UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(6917529027641081856UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(1152921504606846976UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(15564440312192434176UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(11817445422220181504UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(5044031582654955520UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(6989586621679009792UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(16537217831704461312UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(11979575008805519360UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(14294425217273954304UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(2382404202878992384UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(6545982058383015936UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(10314369046585278464UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(4793518853382471680UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(3873377154515337216UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(645562859085889536UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(107593809847648256UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(3092389647259533312UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(9738770311398031360UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(16995415113324298240UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(8981483876790566912UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(13794743361938128896UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(2299123893656354816UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(3457644661227651072UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(576274110204608512UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(6244960376270618624UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(13338656111851470848UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(14520938734448279552UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(14717985838214414336UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(5527454985320660992UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(16293529225644736512UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(11938960241128898560UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(8138741398091333632UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(7505371590918406144UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(16623181993244360704UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(8919445023443910656UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(4561031516192243712UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(9983543956220149760UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(4738381338321616896UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(789730223053602816UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(131621703842267136UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(21936950640377856UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(3656158440062976UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(609359740010496UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(101559956668416UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(16926659444736UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(2821109907456UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(470184984576UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(78364164096UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(13060694016UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(2176782336UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(362797056UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_0(60466176UL, v0)
and closure21 () () : UH2 =
    let v0 : (unit -> UH2) = closure22()
    UH2_0(10077696UL, v0)
and closure20 () () : UH2 =
    let v0 : (unit -> UH2) = closure21()
    UH2_0(1679616UL, v0)
and closure19 () () : UH2 =
    let v0 : (unit -> UH2) = closure20()
    UH2_0(279936UL, v0)
and closure18 () () : UH2 =
    let v0 : (unit -> UH2) = closure19()
    UH2_0(46656UL, v0)
and closure17 () () : UH2 =
    let v0 : (unit -> UH2) = closure18()
    UH2_0(7776UL, v0)
and closure16 () () : UH2 =
    let v0 : (unit -> UH2) = closure17()
    UH2_0(1296UL, v0)
and closure15 () () : UH2 =
    let v0 : (unit -> UH2) = closure16()
    UH2_0(216UL, v0)
and closure14 () () : UH2 =
    let v0 : (unit -> UH2) = closure15()
    UH2_0(36UL, v0)
and closure13 () () : UH2 =
    let v0 : (unit -> UH2) = closure14()
    UH2_0(6UL, v0)
and method10 (v0 : int8, v1 : UH2) : US4 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US4_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method10(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US4_1
and method9 (v0 : US0, v1 : int8, v2 : UH1, v3 : uint64) : US3 =
    let v4 : bool = v1 < 0y
    if v4 then
        let v5 : uint64 = v3 + 1UL
        let v6 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / result: {v5}"
        match v0 with
        | US0_1 -> (* None *)
            ()
        | US0_0(v7) -> (* Some *)
            v7 v6
        US3_0(v5, v2)
    else
        match v2 with
        | UH1_1(v10, v11) -> (* Cons *)
            let v12 : bool = v10 > 1uy
            if v12 then
                let v13 : uint64 = 1UL
                let v14 : (unit -> UH2) = closure13()
                let v15 : UH2 = UH2_0(v13, v14)
                let v16 : US4 = method10(v1, v15)
                let v20 : uint64 =
                    match v16 with
                    | US4_1 -> (* None *)
                        failwith<uint64> "Option does not have a value."
                    | US4_0(v17) -> (* Some *)
                        v17
                let v21 : uint8 = v10 - 1uy
                let v22 : uint64 = uint64 v21
                let v23 : uint64 = v22 * v20
                let v24 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10} / value: {v23}"
                match v0 with
                | US0_1 -> (* None *)
                    ()
                | US0_0(v25) -> (* Some *)
                    v25 v24
                let v26 : uint64 = v3 + v23
                let v27 : int8 = v1 - 1y
                method9(v0, v27, v11, v26)
            else
                let v29 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10}"
                match v0 with
                | US0_1 -> (* None *)
                    ()
                | US0_0(v30) -> (* Some *)
                    v30 v29
                let v31 : int8 = v1 - 1y
                method9(v0, v31, v11, v3)
        | UH1_0 -> (* Nil *)
            US3_1
and method11 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method11(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method12 (v0 : US0, v1 : (unit -> uint8), v2 : bool, v3 : uint64, v4 : int8, v5 : UH1) : uint64 =
    let v6 : int8 = v4 + 1y
    let v7 : bool = v4 < v6
    if v7 then
        let v8 : uint8 = v1 ()
        let v9 : UH1 = UH1_1(v8, v5)
        method8(v0, v1, v2, v3, v4, v9, v6)
    else
        let v11 : uint64 = 0UL
        let v12 : US3 = method9(v0, v4, v5, v11)
        match v12 with
        | US3_0(v13, v14) -> (* Some *)
            let v15 : bool = v13 <= v3
            if v15 then
                v13
            else
                if v2 then
                    let v16 : int8 = 0y
                    let v17 : UH1 = method11(v4, v1, v16)
                    method12(v0, v1, v2, v3, v4, v17)
                else
                    let v19 : uint8 = v1 ()
                    let v20 : UH1 = UH1_1(v19, v5)
                    method8(v0, v1, v2, v3, v4, v20, v6)
        | _ ->
            if v2 then
                let v24 : int8 = 0y
                let v25 : UH1 = method11(v4, v1, v24)
                method12(v0, v1, v2, v3, v4, v25)
            else
                let v27 : uint8 = v1 ()
                let v28 : UH1 = UH1_1(v27, v5)
                method8(v0, v1, v2, v3, v4, v28, v6)
and method8 (v0 : US0, v1 : (unit -> uint8), v2 : bool, v3 : uint64, v4 : int8, v5 : UH1, v6 : int8) : uint64 =
    let v7 : int8 = v4 + 1y
    let v8 : bool = v6 < v7
    if v8 then
        let v9 : uint8 = v1 ()
        let v10 : UH1 = UH1_1(v9, v5)
        let v11 : int8 = v6 + 1y
        method8(v0, v1, v2, v3, v4, v10, v11)
    else
        let v13 : uint64 = 0UL
        let v14 : US3 = method9(v0, v4, v5, v13)
        match v14 with
        | US3_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v3
            if v17 then
                v15
            else
                if v2 then
                    let v18 : int8 = 0y
                    let v19 : UH1 = method11(v4, v1, v18)
                    method12(v0, v1, v2, v3, v4, v19)
                else
                    let v21 : uint8 = v1 ()
                    let v22 : UH1 = UH1_1(v21, v5)
                    let v23 : int8 = v6 + 1y
                    method8(v0, v1, v2, v3, v4, v22, v23)
        | _ ->
            if v2 then
                let v27 : int8 = 0y
                let v28 : UH1 = method11(v4, v1, v27)
                method12(v0, v1, v2, v3, v4, v28)
            else
                let v30 : uint8 = v1 ()
                let v31 : UH1 = UH1_1(v30, v5)
                let v32 : int8 = v6 + 1y
                method8(v0, v1, v2, v3, v4, v31, v32)
and closure12 (v0 : US0, v1 : (unit -> uint8), v2 : bool) (v3 : uint64) : uint64 =
    let v4 : bool = v3 = 1UL
    let v8 : int8 =
        if v4 then
            1y
        else
            let v5 : int8 = 0y
            let v6 : uint64 = 1UL
            method7(v0, v3, v5, v6)
    let v9 : int8 = v8 - 1y
    let v10 : UH1 = UH1_0
    let v11 : int8 = 0y
    method8(v0, v1, v2, v3, v9, v10, v11)
and closure11 (v0 : US0, v1 : (unit -> uint8)) (v2 : bool) : (uint64 -> uint64) =
    closure12(v0, v1, v2)
and closure10 (v0 : US0) (v1 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure11(v0, v1)
and closure9 () (v0 : (string -> unit) option) : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) =
    let v3 : US0 option = None
    let _v3 = ref v3 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v4 : (string -> unit) = x
    let v5 : US0 = US0_0(v4)
    v5 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v3.Value <- x
    let v6 : US0 option = _v3.Value 
    let v29 : US0 = US0_1
    let v30 : US0 = v6 |> Option.defaultValue v29 
    closure10(v30)
and method13 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method13(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure79 (v0 : (string -> unit) option, v1 : uint64) (v2 : UH1) : uint64 option =
    let v5 : US0 option = None
    let _v5 = ref v5 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v6 : (string -> unit) = x
    let v7 : US0 = US0_0(v6)
    v7 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v5.Value <- x
    let v8 : US0 option = _v5.Value 
    let v31 : US0 = US0_1
    let v32 : US0 = v8 |> Option.defaultValue v31 
    let v40 : int8 = 0y
    let v41 : int8 = method13(v2, v40)
    let v42 : int8 = v41 - 1y
    let v43 : uint64 = 0UL
    let v44 : US3 = method9(v32, v42, v2, v43)
    let v54 : US4 =
        match v44 with
        | US3_0(v45, v46) -> (* Some *)
            let v47 : bool = v45 >= 1UL
            let v49 : bool =
                if v47 then
                    let v48 : bool = v45 <= v1
                    v48
                else
                    false
            if v49 then
                US4_0(v45)
            else
                US4_1
        | _ ->
            US4_1
    match v54 with
    | US4_1 -> (* None *)
        let v65 : uint64 option = None
        v65
    | US4_0(v55) -> (* Some *)
        let v58 : uint64 option = Some v55 
        v58
and closure78 (v0 : (string -> unit) option) (v1 : uint64) : (UH1 -> uint64 option) =
    closure79(v0, v1)
and closure77 () (v0 : (string -> unit) option) : (uint64 -> (UH1 -> uint64 option)) =
    closure78(v0)
and method15 () : uint8 =
    let v2 : bool = true
    let mutable _v2 : uint8 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v4 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v3 
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), $0..$1)"
    let v6 : uint8 = Fable.Core.RustInterop.emitRustExpr struct (1uy, 7uy) v5 
    v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : uint8 = failwith<uint8> "common.random' / target=Rust(Contract)"
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (unit -> System.Random) = System.Random 
    let v9 : System.Random = v8 ()
    let v10 : (uint8 -> int32) = int32
    let v11 : int32 = v10 1uy
    let v12 : (uint8 -> int32) = int32
    let v13 : int32 = v12 7uy
    let v14 : int32 = v9.Next (v11, v13)
    let v17 : uint8 = v14 |> uint8 
    v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : (unit -> System.Random) = System.Random 
    let v25 : System.Random = v24 ()
    let v26 : (uint8 -> int32) = int32
    let v27 : int32 = v26 1uy
    let v28 : (uint8 -> int32) = int32
    let v29 : int32 = v28 7uy
    let v30 : int32 = v25.Next (v27, v29)
    let v33 : uint8 = v30 |> uint8 
    v33 
    #endif
#else
    let v40 : (unit -> System.Random) = System.Random 
    let v41 : System.Random = v40 ()
    let v42 : (uint8 -> int32) = int32
    let v43 : int32 = v42 1uy
    let v44 : (uint8 -> int32) = int32
    let v45 : int32 = v44 7uy
    let v46 : int32 = v41.Next (v43, v45)
    let v49 : uint8 = v46 |> uint8 
    v49 
    #endif
    |> fun x -> _v2 <- Some x
    let v56 : uint8 = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v56
and method40 (v0 : UH1, v1 : int64) : US5 =
    let v2 : int64 = v1 + 1L
    let v3 : string = $"accumulate_dice_rolls / power: {-1y} / acc: {v1} / result: {v2}"
    let v6 : (string -> unit) = System.Console.WriteLine
    v6 v3
    US5_0(v2, v0)
and method39 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3} / value: {v7}"
            let v11 : (string -> unit) = System.Console.WriteLine
            v11 v8
            let v16 : int64 = v1 + v7
            method40(v4, v16)
        else
            let v18 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3}"
            let v21 : (string -> unit) = System.Console.WriteLine
            v21 v18
            method40(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method38 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 6L
            let v9 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method39(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method39(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method37 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 36L
            let v9 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method38(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method38(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method36 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 216L
            let v9 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method37(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method37(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method35 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1296L
            let v9 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method36(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method36(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method34 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 7776L
            let v9 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method35(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method35(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method33 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 46656L
            let v9 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method34(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method34(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method32 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 279936L
            let v9 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method33(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method33(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method31 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 1679616L
            let v9 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method32(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method32(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method30 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 10077696L
            let v9 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method31(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method31(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method29 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 60466176L
            let v9 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method30(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method30(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method28 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 362797056L
            let v9 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method29(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method29(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method27 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2176782336L
            let v9 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method28(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method28(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method26 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 13060694016L
            let v9 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method27(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method27(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method25 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 78364164096L
            let v9 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method26(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method26(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method24 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 470184984576L
            let v9 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method25(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method25(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method23 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 2821109907456L
            let v9 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method24(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method24(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method22 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 16926659444736L
            let v9 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method23(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method23(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method21 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 101559956668416L
            let v9 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method22(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method22(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method20 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 609359740010496L
            let v9 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method21(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method21(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method19 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method20(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method20(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method18 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method19(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method19(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method17 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method18(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method18(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method16 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v12 : (string -> unit) = System.Console.WriteLine
            v12 v9
            let v17 : int64 = v1 + v8
            method17(v4, v17)
        else
            let v19 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3}"
            let v22 : (string -> unit) = System.Console.WriteLine
            v22 v19
            method17(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method14 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 = method15()
        let v4 : UH1 = UH1_1(v3, v0)
        let v5 : int8 = v1 + 1y
        method14(v4, v5)
    else
        let v7 : int64 = 0L
        let v8 : US5 = method16(v0, v7)
        match v8 with
        | US5_0(v9, v10) -> (* Some *)
            let v11 : bool = v9 <= 9223372036854775807L
            if v11 then
                v9
            else
                let v12 : uint8 = method15()
                let v13 : uint8 = method15()
                let v14 : uint8 = method15()
                let v15 : uint8 = method15()
                let v16 : uint8 = method15()
                let v17 : uint8 = method15()
                let v18 : uint8 = method15()
                let v19 : uint8 = method15()
                let v20 : uint8 = method15()
                let v21 : uint8 = method15()
                let v22 : uint8 = method15()
                let v23 : uint8 = method15()
                let v24 : uint8 = method15()
                let v25 : uint8 = method15()
                let v26 : uint8 = method15()
                let v27 : uint8 = method15()
                let v28 : uint8 = method15()
                let v29 : uint8 = method15()
                let v30 : uint8 = method15()
                let v31 : uint8 = method15()
                let v32 : uint8 = method15()
                let v33 : uint8 = method15()
                let v34 : uint8 = method15()
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
                method14(v58, v59)
        | _ ->
            let v62 : uint8 = method15()
            let v63 : uint8 = method15()
            let v64 : uint8 = method15()
            let v65 : uint8 = method15()
            let v66 : uint8 = method15()
            let v67 : uint8 = method15()
            let v68 : uint8 = method15()
            let v69 : uint8 = method15()
            let v70 : uint8 = method15()
            let v71 : uint8 = method15()
            let v72 : uint8 = method15()
            let v73 : uint8 = method15()
            let v74 : uint8 = method15()
            let v75 : uint8 = method15()
            let v76 : uint8 = method15()
            let v77 : uint8 = method15()
            let v78 : uint8 = method15()
            let v79 : uint8 = method15()
            let v80 : uint8 = method15()
            let v81 : uint8 = method15()
            let v82 : uint8 = method15()
            let v83 : uint8 = method15()
            let v84 : uint8 = method15()
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
            method14(v108, v109)
and closure80 () (v0 : (string [])) : int32 =
    let v1 : string = $"calculate_dice_count / max: {9223372036854775807L} / n: {24y} / p: {4738381338321616896L}"
    let v4 : (string -> unit) = System.Console.WriteLine
    v4 v1
    let v9 : UH1 = UH1_0
    let v10 : int8 = 0y
    let v11 : int64 = method14(v9, v10)
    let v12 : string = $"result: {v11}"
    let v15 : (string -> unit) = System.Console.WriteLine
    v15 v12
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : ((string -> unit) option -> (UH1 -> (unit -> uint8))) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((string -> unit) option -> ((unit -> uint8) -> (bool -> (uint64 -> uint64)))) = closure9()
let roll_progressively x = v2 x
let v3 : ((string -> unit) option -> (uint64 -> (UH1 -> uint64 option))) = closure77()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure80()
let main args = v4 args
()
