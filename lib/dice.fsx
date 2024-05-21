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
    let v1 : US0 option = None
    let _v1 = ref v1 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : (string -> unit) = x
    let v3 : US0 = US0_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v1.Value <- x
    let v4 : US0 option = _v1.Value 
    let v5 : US0 = US0_1
    let v6 : US0 = v4 |> Option.defaultValue v5 
    closure4(v6)
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
    let v1 : US0 option = None
    let _v1 = ref v1 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : (string -> unit) = x
    let v3 : US0 = US0_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v1.Value <- x
    let v4 : US0 option = _v1.Value 
    let v5 : US0 = US0_1
    let v6 : US0 = v4 |> Option.defaultValue v5 
    closure10(v6)
and method13 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method13(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure79 (v0 : (string -> unit) option, v1 : uint64) (v2 : UH1) : uint64 option =
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
    let v7 : US0 = US0_1
    let v8 : US0 = v6 |> Option.defaultValue v7 
    let v9 : int8 = 0y
    let v10 : int8 = method13(v2, v9)
    let v11 : int8 = v10 - 1y
    let v12 : uint64 = 0UL
    let v13 : US3 = method9(v8, v11, v2, v12)
    let v23 : US4 =
        match v13 with
        | US3_0(v14, v15) -> (* Some *)
            let v16 : bool = v14 >= 1UL
            let v18 : bool =
                if v16 then
                    let v17 : bool = v14 <= v1
                    v17
                else
                    false
            if v18 then
                US4_0(v14)
            else
                US4_1
        | _ ->
            US4_1
    match v23 with
    | US4_1 -> (* None *)
        let v26 : uint64 option = None
        v26
    | US4_0(v24) -> (* Some *)
        let v25 : uint64 option = Some v24 
        v25
and closure78 (v0 : (string -> unit) option) (v1 : uint64) : (UH1 -> uint64 option) =
    closure79(v0, v1)
and closure77 () (v0 : (string -> unit) option) : (uint64 -> (UH1 -> uint64 option)) =
    closure78(v0)
and method39 (v0 : UH1, v1 : int64) : US5 =
    let v2 : int64 = v1 + 1L
    let v3 : string = $"accumulate_dice_rolls / power: {-1y} / acc: {v1} / result: {v2}"
    let v4 : (string -> unit) = System.Console.WriteLine
    v4 v3
    US5_0(v2, v0)
and method38 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3} / value: {v7}"
            let v9 : (string -> unit) = System.Console.WriteLine
            v9 v8
            let v10 : int64 = v1 + v7
            method39(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3}"
            let v13 : (string -> unit) = System.Console.WriteLine
            v13 v12
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
            let v8 : int64 = v7 * 6L
            let v9 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method38(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 36L
            let v9 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method37(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 216L
            let v9 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method36(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 1296L
            let v9 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method35(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 7776L
            let v9 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method34(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 46656L
            let v9 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method33(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 279936L
            let v9 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method32(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 1679616L
            let v9 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method31(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 10077696L
            let v9 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method30(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 60466176L
            let v9 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method29(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 362797056L
            let v9 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method28(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 2176782336L
            let v9 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method27(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 13060694016L
            let v9 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method26(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 78364164096L
            let v9 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method25(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 470184984576L
            let v9 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method24(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 2821109907456L
            let v9 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method23(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 16926659444736L
            let v9 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method22(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 101559956668416L
            let v9 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method21(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 609359740010496L
            let v9 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method20(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method19(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method18(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
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
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method17(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
            method17(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method15 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : int64 = v7 * 789730223053602816L
            let v9 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3} / value: {v8}"
            let v10 : (string -> unit) = System.Console.WriteLine
            v10 v9
            let v11 : int64 = v1 + v8
            method16(v4, v11)
        else
            let v13 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3}"
            let v14 : (string -> unit) = System.Console.WriteLine
            v14 v13
            method16(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method14 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : bool = true
        let mutable _v3 : uint8 option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
        let v5 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4 
        v5 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
        let v7 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6 
        v7 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v8 : string = "1"
        let v9 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8 
        v9 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v10 : uint8 = System.Random().Next (1, 7) |> uint8
        v10 
        #endif
#if FABLE_COMPILER_PYTHON
        let v11 : uint8 = System.Random().Next (1, 7) |> uint8
        v11 
        #endif
#else
        let v12 : uint8 = System.Random().Next (1, 7) |> uint8
        v12 
        #endif
        |> fun x -> _v3 <- Some x
        let v13 : uint8 = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
        let v14 : UH1 = UH1_1(v13, v0)
        let v15 : int8 = v1 + 1y
        method14(v14, v15)
    else
        let v17 : int64 = 0L
        let v18 : US5 = method15(v0, v17)
        match v18 with
        | US5_0(v19, v20) -> (* Some *)
            let v21 : bool = v19 <= 9223372036854775807L
            if v21 then
                v19
            else
                let v22 : bool = true
                let mutable _v22 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v23 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v24 : uint8 = Fable.Core.RustInterop.emitRustExpr () v23 
                v24 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v25 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v26 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25 
                v26 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v27 : string = "1"
                let v28 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27 
                v28 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v29 : uint8 = System.Random().Next (1, 7) |> uint8
                v29 
                #endif
#if FABLE_COMPILER_PYTHON
                let v30 : uint8 = System.Random().Next (1, 7) |> uint8
                v30 
                #endif
#else
                let v31 : uint8 = System.Random().Next (1, 7) |> uint8
                v31 
                #endif
                |> fun x -> _v22 <- Some x
                let v32 : uint8 = match _v22 with Some x -> x | None -> failwith "base.run_target / _v22=None"
                let v33 : bool = true
                let mutable _v33 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v34 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v35 : uint8 = Fable.Core.RustInterop.emitRustExpr () v34 
                v35 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v36 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v37 : uint8 = Fable.Core.RustInterop.emitRustExpr () v36 
                v37 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v38 : string = "1"
                let v39 : uint8 = Fable.Core.RustInterop.emitRustExpr () v38 
                v39 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v40 : uint8 = System.Random().Next (1, 7) |> uint8
                v40 
                #endif
#if FABLE_COMPILER_PYTHON
                let v41 : uint8 = System.Random().Next (1, 7) |> uint8
                v41 
                #endif
#else
                let v42 : uint8 = System.Random().Next (1, 7) |> uint8
                v42 
                #endif
                |> fun x -> _v33 <- Some x
                let v43 : uint8 = match _v33 with Some x -> x | None -> failwith "base.run_target / _v33=None"
                let v44 : bool = true
                let mutable _v44 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v45 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v46 : uint8 = Fable.Core.RustInterop.emitRustExpr () v45 
                v46 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v47 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v48 : uint8 = Fable.Core.RustInterop.emitRustExpr () v47 
                v48 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v49 : string = "1"
                let v50 : uint8 = Fable.Core.RustInterop.emitRustExpr () v49 
                v50 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v51 : uint8 = System.Random().Next (1, 7) |> uint8
                v51 
                #endif
#if FABLE_COMPILER_PYTHON
                let v52 : uint8 = System.Random().Next (1, 7) |> uint8
                v52 
                #endif
#else
                let v53 : uint8 = System.Random().Next (1, 7) |> uint8
                v53 
                #endif
                |> fun x -> _v44 <- Some x
                let v54 : uint8 = match _v44 with Some x -> x | None -> failwith "base.run_target / _v44=None"
                let v55 : bool = true
                let mutable _v55 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v56 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v57 : uint8 = Fable.Core.RustInterop.emitRustExpr () v56 
                v57 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v58 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v59 : uint8 = Fable.Core.RustInterop.emitRustExpr () v58 
                v59 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v60 : string = "1"
                let v61 : uint8 = Fable.Core.RustInterop.emitRustExpr () v60 
                v61 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v62 : uint8 = System.Random().Next (1, 7) |> uint8
                v62 
                #endif
#if FABLE_COMPILER_PYTHON
                let v63 : uint8 = System.Random().Next (1, 7) |> uint8
                v63 
                #endif
#else
                let v64 : uint8 = System.Random().Next (1, 7) |> uint8
                v64 
                #endif
                |> fun x -> _v55 <- Some x
                let v65 : uint8 = match _v55 with Some x -> x | None -> failwith "base.run_target / _v55=None"
                let v66 : bool = true
                let mutable _v66 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v67 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v68 : uint8 = Fable.Core.RustInterop.emitRustExpr () v67 
                v68 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v69 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v70 : uint8 = Fable.Core.RustInterop.emitRustExpr () v69 
                v70 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v71 : string = "1"
                let v72 : uint8 = Fable.Core.RustInterop.emitRustExpr () v71 
                v72 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v73 : uint8 = System.Random().Next (1, 7) |> uint8
                v73 
                #endif
#if FABLE_COMPILER_PYTHON
                let v74 : uint8 = System.Random().Next (1, 7) |> uint8
                v74 
                #endif
#else
                let v75 : uint8 = System.Random().Next (1, 7) |> uint8
                v75 
                #endif
                |> fun x -> _v66 <- Some x
                let v76 : uint8 = match _v66 with Some x -> x | None -> failwith "base.run_target / _v66=None"
                let v77 : bool = true
                let mutable _v77 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v78 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v79 : uint8 = Fable.Core.RustInterop.emitRustExpr () v78 
                v79 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v80 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v81 : uint8 = Fable.Core.RustInterop.emitRustExpr () v80 
                v81 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v82 : string = "1"
                let v83 : uint8 = Fable.Core.RustInterop.emitRustExpr () v82 
                v83 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v84 : uint8 = System.Random().Next (1, 7) |> uint8
                v84 
                #endif
#if FABLE_COMPILER_PYTHON
                let v85 : uint8 = System.Random().Next (1, 7) |> uint8
                v85 
                #endif
#else
                let v86 : uint8 = System.Random().Next (1, 7) |> uint8
                v86 
                #endif
                |> fun x -> _v77 <- Some x
                let v87 : uint8 = match _v77 with Some x -> x | None -> failwith "base.run_target / _v77=None"
                let v88 : bool = true
                let mutable _v88 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v89 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v90 : uint8 = Fable.Core.RustInterop.emitRustExpr () v89 
                v90 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v91 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v92 : uint8 = Fable.Core.RustInterop.emitRustExpr () v91 
                v92 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v93 : string = "1"
                let v94 : uint8 = Fable.Core.RustInterop.emitRustExpr () v93 
                v94 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v95 : uint8 = System.Random().Next (1, 7) |> uint8
                v95 
                #endif
#if FABLE_COMPILER_PYTHON
                let v96 : uint8 = System.Random().Next (1, 7) |> uint8
                v96 
                #endif
#else
                let v97 : uint8 = System.Random().Next (1, 7) |> uint8
                v97 
                #endif
                |> fun x -> _v88 <- Some x
                let v98 : uint8 = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
                let v99 : bool = true
                let mutable _v99 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v100 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v101 : uint8 = Fable.Core.RustInterop.emitRustExpr () v100 
                v101 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v102 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v103 : uint8 = Fable.Core.RustInterop.emitRustExpr () v102 
                v103 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v104 : string = "1"
                let v105 : uint8 = Fable.Core.RustInterop.emitRustExpr () v104 
                v105 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v106 : uint8 = System.Random().Next (1, 7) |> uint8
                v106 
                #endif
#if FABLE_COMPILER_PYTHON
                let v107 : uint8 = System.Random().Next (1, 7) |> uint8
                v107 
                #endif
#else
                let v108 : uint8 = System.Random().Next (1, 7) |> uint8
                v108 
                #endif
                |> fun x -> _v99 <- Some x
                let v109 : uint8 = match _v99 with Some x -> x | None -> failwith "base.run_target / _v99=None"
                let v110 : bool = true
                let mutable _v110 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v111 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v112 : uint8 = Fable.Core.RustInterop.emitRustExpr () v111 
                v112 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v113 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v114 : uint8 = Fable.Core.RustInterop.emitRustExpr () v113 
                v114 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v115 : string = "1"
                let v116 : uint8 = Fable.Core.RustInterop.emitRustExpr () v115 
                v116 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v117 : uint8 = System.Random().Next (1, 7) |> uint8
                v117 
                #endif
#if FABLE_COMPILER_PYTHON
                let v118 : uint8 = System.Random().Next (1, 7) |> uint8
                v118 
                #endif
#else
                let v119 : uint8 = System.Random().Next (1, 7) |> uint8
                v119 
                #endif
                |> fun x -> _v110 <- Some x
                let v120 : uint8 = match _v110 with Some x -> x | None -> failwith "base.run_target / _v110=None"
                let v121 : bool = true
                let mutable _v121 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v122 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v123 : uint8 = Fable.Core.RustInterop.emitRustExpr () v122 
                v123 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v124 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v125 : uint8 = Fable.Core.RustInterop.emitRustExpr () v124 
                v125 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v126 : string = "1"
                let v127 : uint8 = Fable.Core.RustInterop.emitRustExpr () v126 
                v127 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v128 : uint8 = System.Random().Next (1, 7) |> uint8
                v128 
                #endif
#if FABLE_COMPILER_PYTHON
                let v129 : uint8 = System.Random().Next (1, 7) |> uint8
                v129 
                #endif
#else
                let v130 : uint8 = System.Random().Next (1, 7) |> uint8
                v130 
                #endif
                |> fun x -> _v121 <- Some x
                let v131 : uint8 = match _v121 with Some x -> x | None -> failwith "base.run_target / _v121=None"
                let v132 : bool = true
                let mutable _v132 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v133 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v134 : uint8 = Fable.Core.RustInterop.emitRustExpr () v133 
                v134 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v135 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v136 : uint8 = Fable.Core.RustInterop.emitRustExpr () v135 
                v136 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v137 : string = "1"
                let v138 : uint8 = Fable.Core.RustInterop.emitRustExpr () v137 
                v138 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v139 : uint8 = System.Random().Next (1, 7) |> uint8
                v139 
                #endif
#if FABLE_COMPILER_PYTHON
                let v140 : uint8 = System.Random().Next (1, 7) |> uint8
                v140 
                #endif
#else
                let v141 : uint8 = System.Random().Next (1, 7) |> uint8
                v141 
                #endif
                |> fun x -> _v132 <- Some x
                let v142 : uint8 = match _v132 with Some x -> x | None -> failwith "base.run_target / _v132=None"
                let v143 : bool = true
                let mutable _v143 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v144 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v145 : uint8 = Fable.Core.RustInterop.emitRustExpr () v144 
                v145 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v146 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v147 : uint8 = Fable.Core.RustInterop.emitRustExpr () v146 
                v147 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v148 : string = "1"
                let v149 : uint8 = Fable.Core.RustInterop.emitRustExpr () v148 
                v149 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v150 : uint8 = System.Random().Next (1, 7) |> uint8
                v150 
                #endif
#if FABLE_COMPILER_PYTHON
                let v151 : uint8 = System.Random().Next (1, 7) |> uint8
                v151 
                #endif
#else
                let v152 : uint8 = System.Random().Next (1, 7) |> uint8
                v152 
                #endif
                |> fun x -> _v143 <- Some x
                let v153 : uint8 = match _v143 with Some x -> x | None -> failwith "base.run_target / _v143=None"
                let v154 : bool = true
                let mutable _v154 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v155 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v156 : uint8 = Fable.Core.RustInterop.emitRustExpr () v155 
                v156 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v157 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v158 : uint8 = Fable.Core.RustInterop.emitRustExpr () v157 
                v158 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v159 : string = "1"
                let v160 : uint8 = Fable.Core.RustInterop.emitRustExpr () v159 
                v160 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v161 : uint8 = System.Random().Next (1, 7) |> uint8
                v161 
                #endif
#if FABLE_COMPILER_PYTHON
                let v162 : uint8 = System.Random().Next (1, 7) |> uint8
                v162 
                #endif
#else
                let v163 : uint8 = System.Random().Next (1, 7) |> uint8
                v163 
                #endif
                |> fun x -> _v154 <- Some x
                let v164 : uint8 = match _v154 with Some x -> x | None -> failwith "base.run_target / _v154=None"
                let v165 : bool = true
                let mutable _v165 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v166 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v167 : uint8 = Fable.Core.RustInterop.emitRustExpr () v166 
                v167 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v168 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v169 : uint8 = Fable.Core.RustInterop.emitRustExpr () v168 
                v169 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v170 : string = "1"
                let v171 : uint8 = Fable.Core.RustInterop.emitRustExpr () v170 
                v171 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v172 : uint8 = System.Random().Next (1, 7) |> uint8
                v172 
                #endif
#if FABLE_COMPILER_PYTHON
                let v173 : uint8 = System.Random().Next (1, 7) |> uint8
                v173 
                #endif
#else
                let v174 : uint8 = System.Random().Next (1, 7) |> uint8
                v174 
                #endif
                |> fun x -> _v165 <- Some x
                let v175 : uint8 = match _v165 with Some x -> x | None -> failwith "base.run_target / _v165=None"
                let v176 : bool = true
                let mutable _v176 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v177 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v178 : uint8 = Fable.Core.RustInterop.emitRustExpr () v177 
                v178 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v179 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v180 : uint8 = Fable.Core.RustInterop.emitRustExpr () v179 
                v180 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v181 : string = "1"
                let v182 : uint8 = Fable.Core.RustInterop.emitRustExpr () v181 
                v182 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v183 : uint8 = System.Random().Next (1, 7) |> uint8
                v183 
                #endif
#if FABLE_COMPILER_PYTHON
                let v184 : uint8 = System.Random().Next (1, 7) |> uint8
                v184 
                #endif
#else
                let v185 : uint8 = System.Random().Next (1, 7) |> uint8
                v185 
                #endif
                |> fun x -> _v176 <- Some x
                let v186 : uint8 = match _v176 with Some x -> x | None -> failwith "base.run_target / _v176=None"
                let v187 : bool = true
                let mutable _v187 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v188 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v189 : uint8 = Fable.Core.RustInterop.emitRustExpr () v188 
                v189 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v190 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v191 : uint8 = Fable.Core.RustInterop.emitRustExpr () v190 
                v191 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v192 : string = "1"
                let v193 : uint8 = Fable.Core.RustInterop.emitRustExpr () v192 
                v193 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v194 : uint8 = System.Random().Next (1, 7) |> uint8
                v194 
                #endif
#if FABLE_COMPILER_PYTHON
                let v195 : uint8 = System.Random().Next (1, 7) |> uint8
                v195 
                #endif
#else
                let v196 : uint8 = System.Random().Next (1, 7) |> uint8
                v196 
                #endif
                |> fun x -> _v187 <- Some x
                let v197 : uint8 = match _v187 with Some x -> x | None -> failwith "base.run_target / _v187=None"
                let v198 : bool = true
                let mutable _v198 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v199 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v200 : uint8 = Fable.Core.RustInterop.emitRustExpr () v199 
                v200 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v201 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v202 : uint8 = Fable.Core.RustInterop.emitRustExpr () v201 
                v202 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v203 : string = "1"
                let v204 : uint8 = Fable.Core.RustInterop.emitRustExpr () v203 
                v204 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v205 : uint8 = System.Random().Next (1, 7) |> uint8
                v205 
                #endif
#if FABLE_COMPILER_PYTHON
                let v206 : uint8 = System.Random().Next (1, 7) |> uint8
                v206 
                #endif
#else
                let v207 : uint8 = System.Random().Next (1, 7) |> uint8
                v207 
                #endif
                |> fun x -> _v198 <- Some x
                let v208 : uint8 = match _v198 with Some x -> x | None -> failwith "base.run_target / _v198=None"
                let v209 : bool = true
                let mutable _v209 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v210 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v211 : uint8 = Fable.Core.RustInterop.emitRustExpr () v210 
                v211 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v212 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v213 : uint8 = Fable.Core.RustInterop.emitRustExpr () v212 
                v213 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v214 : string = "1"
                let v215 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214 
                v215 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v216 : uint8 = System.Random().Next (1, 7) |> uint8
                v216 
                #endif
#if FABLE_COMPILER_PYTHON
                let v217 : uint8 = System.Random().Next (1, 7) |> uint8
                v217 
                #endif
#else
                let v218 : uint8 = System.Random().Next (1, 7) |> uint8
                v218 
                #endif
                |> fun x -> _v209 <- Some x
                let v219 : uint8 = match _v209 with Some x -> x | None -> failwith "base.run_target / _v209=None"
                let v220 : bool = true
                let mutable _v220 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v221 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v222 : uint8 = Fable.Core.RustInterop.emitRustExpr () v221 
                v222 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v223 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v224 : uint8 = Fable.Core.RustInterop.emitRustExpr () v223 
                v224 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v225 : string = "1"
                let v226 : uint8 = Fable.Core.RustInterop.emitRustExpr () v225 
                v226 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v227 : uint8 = System.Random().Next (1, 7) |> uint8
                v227 
                #endif
#if FABLE_COMPILER_PYTHON
                let v228 : uint8 = System.Random().Next (1, 7) |> uint8
                v228 
                #endif
#else
                let v229 : uint8 = System.Random().Next (1, 7) |> uint8
                v229 
                #endif
                |> fun x -> _v220 <- Some x
                let v230 : uint8 = match _v220 with Some x -> x | None -> failwith "base.run_target / _v220=None"
                let v231 : bool = true
                let mutable _v231 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v232 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v233 : uint8 = Fable.Core.RustInterop.emitRustExpr () v232 
                v233 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v234 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v235 : uint8 = Fable.Core.RustInterop.emitRustExpr () v234 
                v235 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v236 : string = "1"
                let v237 : uint8 = Fable.Core.RustInterop.emitRustExpr () v236 
                v237 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v238 : uint8 = System.Random().Next (1, 7) |> uint8
                v238 
                #endif
#if FABLE_COMPILER_PYTHON
                let v239 : uint8 = System.Random().Next (1, 7) |> uint8
                v239 
                #endif
#else
                let v240 : uint8 = System.Random().Next (1, 7) |> uint8
                v240 
                #endif
                |> fun x -> _v231 <- Some x
                let v241 : uint8 = match _v231 with Some x -> x | None -> failwith "base.run_target / _v231=None"
                let v242 : bool = true
                let mutable _v242 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v243 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v244 : uint8 = Fable.Core.RustInterop.emitRustExpr () v243 
                v244 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v245 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v246 : uint8 = Fable.Core.RustInterop.emitRustExpr () v245 
                v246 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v247 : string = "1"
                let v248 : uint8 = Fable.Core.RustInterop.emitRustExpr () v247 
                v248 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v249 : uint8 = System.Random().Next (1, 7) |> uint8
                v249 
                #endif
#if FABLE_COMPILER_PYTHON
                let v250 : uint8 = System.Random().Next (1, 7) |> uint8
                v250 
                #endif
#else
                let v251 : uint8 = System.Random().Next (1, 7) |> uint8
                v251 
                #endif
                |> fun x -> _v242 <- Some x
                let v252 : uint8 = match _v242 with Some x -> x | None -> failwith "base.run_target / _v242=None"
                let v253 : bool = true
                let mutable _v253 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v254 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v255 : uint8 = Fable.Core.RustInterop.emitRustExpr () v254 
                v255 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v256 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v257 : uint8 = Fable.Core.RustInterop.emitRustExpr () v256 
                v257 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v258 : string = "1"
                let v259 : uint8 = Fable.Core.RustInterop.emitRustExpr () v258 
                v259 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v260 : uint8 = System.Random().Next (1, 7) |> uint8
                v260 
                #endif
#if FABLE_COMPILER_PYTHON
                let v261 : uint8 = System.Random().Next (1, 7) |> uint8
                v261 
                #endif
#else
                let v262 : uint8 = System.Random().Next (1, 7) |> uint8
                v262 
                #endif
                |> fun x -> _v253 <- Some x
                let v263 : uint8 = match _v253 with Some x -> x | None -> failwith "base.run_target / _v253=None"
                let v264 : bool = true
                let mutable _v264 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v265 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v266 : uint8 = Fable.Core.RustInterop.emitRustExpr () v265 
                v266 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v267 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v268 : uint8 = Fable.Core.RustInterop.emitRustExpr () v267 
                v268 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v269 : string = "1"
                let v270 : uint8 = Fable.Core.RustInterop.emitRustExpr () v269 
                v270 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v271 : uint8 = System.Random().Next (1, 7) |> uint8
                v271 
                #endif
#if FABLE_COMPILER_PYTHON
                let v272 : uint8 = System.Random().Next (1, 7) |> uint8
                v272 
                #endif
#else
                let v273 : uint8 = System.Random().Next (1, 7) |> uint8
                v273 
                #endif
                |> fun x -> _v264 <- Some x
                let v274 : uint8 = match _v264 with Some x -> x | None -> failwith "base.run_target / _v264=None"
                let v275 : UH1 = UH1_0
                let v276 : UH1 = UH1_1(v274, v275)
                let v277 : UH1 = UH1_1(v263, v276)
                let v278 : UH1 = UH1_1(v252, v277)
                let v279 : UH1 = UH1_1(v241, v278)
                let v280 : UH1 = UH1_1(v230, v279)
                let v281 : UH1 = UH1_1(v219, v280)
                let v282 : UH1 = UH1_1(v208, v281)
                let v283 : UH1 = UH1_1(v197, v282)
                let v284 : UH1 = UH1_1(v186, v283)
                let v285 : UH1 = UH1_1(v175, v284)
                let v286 : UH1 = UH1_1(v164, v285)
                let v287 : UH1 = UH1_1(v153, v286)
                let v288 : UH1 = UH1_1(v142, v287)
                let v289 : UH1 = UH1_1(v131, v288)
                let v290 : UH1 = UH1_1(v120, v289)
                let v291 : UH1 = UH1_1(v109, v290)
                let v292 : UH1 = UH1_1(v98, v291)
                let v293 : UH1 = UH1_1(v87, v292)
                let v294 : UH1 = UH1_1(v76, v293)
                let v295 : UH1 = UH1_1(v65, v294)
                let v296 : UH1 = UH1_1(v54, v295)
                let v297 : UH1 = UH1_1(v43, v296)
                let v298 : UH1 = UH1_1(v32, v297)
                let v299 : int8 = 23y
                method14(v298, v299)
        | _ ->
            let v302 : bool = true
            let mutable _v302 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v303 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v304 : uint8 = Fable.Core.RustInterop.emitRustExpr () v303 
            v304 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v305 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v306 : uint8 = Fable.Core.RustInterop.emitRustExpr () v305 
            v306 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v307 : string = "1"
            let v308 : uint8 = Fable.Core.RustInterop.emitRustExpr () v307 
            v308 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v309 : uint8 = System.Random().Next (1, 7) |> uint8
            v309 
            #endif
#if FABLE_COMPILER_PYTHON
            let v310 : uint8 = System.Random().Next (1, 7) |> uint8
            v310 
            #endif
#else
            let v311 : uint8 = System.Random().Next (1, 7) |> uint8
            v311 
            #endif
            |> fun x -> _v302 <- Some x
            let v312 : uint8 = match _v302 with Some x -> x | None -> failwith "base.run_target / _v302=None"
            let v313 : bool = true
            let mutable _v313 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v315 : uint8 = Fable.Core.RustInterop.emitRustExpr () v314 
            v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v317 : uint8 = Fable.Core.RustInterop.emitRustExpr () v316 
            v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "1"
            let v319 : uint8 = Fable.Core.RustInterop.emitRustExpr () v318 
            v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : uint8 = System.Random().Next (1, 7) |> uint8
            v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : uint8 = System.Random().Next (1, 7) |> uint8
            v321 
            #endif
#else
            let v322 : uint8 = System.Random().Next (1, 7) |> uint8
            v322 
            #endif
            |> fun x -> _v313 <- Some x
            let v323 : uint8 = match _v313 with Some x -> x | None -> failwith "base.run_target / _v313=None"
            let v324 : bool = true
            let mutable _v324 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v325 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v326 : uint8 = Fable.Core.RustInterop.emitRustExpr () v325 
            v326 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v327 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v328 : uint8 = Fable.Core.RustInterop.emitRustExpr () v327 
            v328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : string = "1"
            let v330 : uint8 = Fable.Core.RustInterop.emitRustExpr () v329 
            v330 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v331 : uint8 = System.Random().Next (1, 7) |> uint8
            v331 
            #endif
#if FABLE_COMPILER_PYTHON
            let v332 : uint8 = System.Random().Next (1, 7) |> uint8
            v332 
            #endif
#else
            let v333 : uint8 = System.Random().Next (1, 7) |> uint8
            v333 
            #endif
            |> fun x -> _v324 <- Some x
            let v334 : uint8 = match _v324 with Some x -> x | None -> failwith "base.run_target / _v324=None"
            let v335 : bool = true
            let mutable _v335 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v336 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v337 : uint8 = Fable.Core.RustInterop.emitRustExpr () v336 
            v337 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v338 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v339 : uint8 = Fable.Core.RustInterop.emitRustExpr () v338 
            v339 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v340 : string = "1"
            let v341 : uint8 = Fable.Core.RustInterop.emitRustExpr () v340 
            v341 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v342 : uint8 = System.Random().Next (1, 7) |> uint8
            v342 
            #endif
#if FABLE_COMPILER_PYTHON
            let v343 : uint8 = System.Random().Next (1, 7) |> uint8
            v343 
            #endif
#else
            let v344 : uint8 = System.Random().Next (1, 7) |> uint8
            v344 
            #endif
            |> fun x -> _v335 <- Some x
            let v345 : uint8 = match _v335 with Some x -> x | None -> failwith "base.run_target / _v335=None"
            let v346 : bool = true
            let mutable _v346 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v347 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v348 : uint8 = Fable.Core.RustInterop.emitRustExpr () v347 
            v348 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v349 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v350 : uint8 = Fable.Core.RustInterop.emitRustExpr () v349 
            v350 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v351 : string = "1"
            let v352 : uint8 = Fable.Core.RustInterop.emitRustExpr () v351 
            v352 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v353 : uint8 = System.Random().Next (1, 7) |> uint8
            v353 
            #endif
#if FABLE_COMPILER_PYTHON
            let v354 : uint8 = System.Random().Next (1, 7) |> uint8
            v354 
            #endif
#else
            let v355 : uint8 = System.Random().Next (1, 7) |> uint8
            v355 
            #endif
            |> fun x -> _v346 <- Some x
            let v356 : uint8 = match _v346 with Some x -> x | None -> failwith "base.run_target / _v346=None"
            let v357 : bool = true
            let mutable _v357 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v358 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v359 : uint8 = Fable.Core.RustInterop.emitRustExpr () v358 
            v359 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v360 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v361 : uint8 = Fable.Core.RustInterop.emitRustExpr () v360 
            v361 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v362 : string = "1"
            let v363 : uint8 = Fable.Core.RustInterop.emitRustExpr () v362 
            v363 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v364 : uint8 = System.Random().Next (1, 7) |> uint8
            v364 
            #endif
#if FABLE_COMPILER_PYTHON
            let v365 : uint8 = System.Random().Next (1, 7) |> uint8
            v365 
            #endif
#else
            let v366 : uint8 = System.Random().Next (1, 7) |> uint8
            v366 
            #endif
            |> fun x -> _v357 <- Some x
            let v367 : uint8 = match _v357 with Some x -> x | None -> failwith "base.run_target / _v357=None"
            let v368 : bool = true
            let mutable _v368 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v369 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v370 : uint8 = Fable.Core.RustInterop.emitRustExpr () v369 
            v370 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v371 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v372 : uint8 = Fable.Core.RustInterop.emitRustExpr () v371 
            v372 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v373 : string = "1"
            let v374 : uint8 = Fable.Core.RustInterop.emitRustExpr () v373 
            v374 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v375 : uint8 = System.Random().Next (1, 7) |> uint8
            v375 
            #endif
#if FABLE_COMPILER_PYTHON
            let v376 : uint8 = System.Random().Next (1, 7) |> uint8
            v376 
            #endif
#else
            let v377 : uint8 = System.Random().Next (1, 7) |> uint8
            v377 
            #endif
            |> fun x -> _v368 <- Some x
            let v378 : uint8 = match _v368 with Some x -> x | None -> failwith "base.run_target / _v368=None"
            let v379 : bool = true
            let mutable _v379 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v380 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v381 : uint8 = Fable.Core.RustInterop.emitRustExpr () v380 
            v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v382 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v383 : uint8 = Fable.Core.RustInterop.emitRustExpr () v382 
            v383 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v384 : string = "1"
            let v385 : uint8 = Fable.Core.RustInterop.emitRustExpr () v384 
            v385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v386 : uint8 = System.Random().Next (1, 7) |> uint8
            v386 
            #endif
#if FABLE_COMPILER_PYTHON
            let v387 : uint8 = System.Random().Next (1, 7) |> uint8
            v387 
            #endif
#else
            let v388 : uint8 = System.Random().Next (1, 7) |> uint8
            v388 
            #endif
            |> fun x -> _v379 <- Some x
            let v389 : uint8 = match _v379 with Some x -> x | None -> failwith "base.run_target / _v379=None"
            let v390 : bool = true
            let mutable _v390 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v391 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v392 : uint8 = Fable.Core.RustInterop.emitRustExpr () v391 
            v392 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v393 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v394 : uint8 = Fable.Core.RustInterop.emitRustExpr () v393 
            v394 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v395 : string = "1"
            let v396 : uint8 = Fable.Core.RustInterop.emitRustExpr () v395 
            v396 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v397 : uint8 = System.Random().Next (1, 7) |> uint8
            v397 
            #endif
#if FABLE_COMPILER_PYTHON
            let v398 : uint8 = System.Random().Next (1, 7) |> uint8
            v398 
            #endif
#else
            let v399 : uint8 = System.Random().Next (1, 7) |> uint8
            v399 
            #endif
            |> fun x -> _v390 <- Some x
            let v400 : uint8 = match _v390 with Some x -> x | None -> failwith "base.run_target / _v390=None"
            let v401 : bool = true
            let mutable _v401 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v402 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v403 : uint8 = Fable.Core.RustInterop.emitRustExpr () v402 
            v403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v405 : uint8 = Fable.Core.RustInterop.emitRustExpr () v404 
            v405 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v406 : string = "1"
            let v407 : uint8 = Fable.Core.RustInterop.emitRustExpr () v406 
            v407 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : uint8 = System.Random().Next (1, 7) |> uint8
            v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : uint8 = System.Random().Next (1, 7) |> uint8
            v409 
            #endif
#else
            let v410 : uint8 = System.Random().Next (1, 7) |> uint8
            v410 
            #endif
            |> fun x -> _v401 <- Some x
            let v411 : uint8 = match _v401 with Some x -> x | None -> failwith "base.run_target / _v401=None"
            let v412 : bool = true
            let mutable _v412 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v413 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v414 : uint8 = Fable.Core.RustInterop.emitRustExpr () v413 
            v414 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v416 : uint8 = Fable.Core.RustInterop.emitRustExpr () v415 
            v416 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v417 : string = "1"
            let v418 : uint8 = Fable.Core.RustInterop.emitRustExpr () v417 
            v418 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v419 : uint8 = System.Random().Next (1, 7) |> uint8
            v419 
            #endif
#if FABLE_COMPILER_PYTHON
            let v420 : uint8 = System.Random().Next (1, 7) |> uint8
            v420 
            #endif
#else
            let v421 : uint8 = System.Random().Next (1, 7) |> uint8
            v421 
            #endif
            |> fun x -> _v412 <- Some x
            let v422 : uint8 = match _v412 with Some x -> x | None -> failwith "base.run_target / _v412=None"
            let v423 : bool = true
            let mutable _v423 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v424 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v425 : uint8 = Fable.Core.RustInterop.emitRustExpr () v424 
            v425 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v426 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v427 : uint8 = Fable.Core.RustInterop.emitRustExpr () v426 
            v427 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v428 : string = "1"
            let v429 : uint8 = Fable.Core.RustInterop.emitRustExpr () v428 
            v429 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v430 : uint8 = System.Random().Next (1, 7) |> uint8
            v430 
            #endif
#if FABLE_COMPILER_PYTHON
            let v431 : uint8 = System.Random().Next (1, 7) |> uint8
            v431 
            #endif
#else
            let v432 : uint8 = System.Random().Next (1, 7) |> uint8
            v432 
            #endif
            |> fun x -> _v423 <- Some x
            let v433 : uint8 = match _v423 with Some x -> x | None -> failwith "base.run_target / _v423=None"
            let v434 : bool = true
            let mutable _v434 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v435 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v436 : uint8 = Fable.Core.RustInterop.emitRustExpr () v435 
            v436 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v437 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v438 : uint8 = Fable.Core.RustInterop.emitRustExpr () v437 
            v438 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v439 : string = "1"
            let v440 : uint8 = Fable.Core.RustInterop.emitRustExpr () v439 
            v440 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v441 : uint8 = System.Random().Next (1, 7) |> uint8
            v441 
            #endif
#if FABLE_COMPILER_PYTHON
            let v442 : uint8 = System.Random().Next (1, 7) |> uint8
            v442 
            #endif
#else
            let v443 : uint8 = System.Random().Next (1, 7) |> uint8
            v443 
            #endif
            |> fun x -> _v434 <- Some x
            let v444 : uint8 = match _v434 with Some x -> x | None -> failwith "base.run_target / _v434=None"
            let v445 : bool = true
            let mutable _v445 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v446 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v447 : uint8 = Fable.Core.RustInterop.emitRustExpr () v446 
            v447 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v448 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v449 : uint8 = Fable.Core.RustInterop.emitRustExpr () v448 
            v449 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v450 : string = "1"
            let v451 : uint8 = Fable.Core.RustInterop.emitRustExpr () v450 
            v451 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v452 : uint8 = System.Random().Next (1, 7) |> uint8
            v452 
            #endif
#if FABLE_COMPILER_PYTHON
            let v453 : uint8 = System.Random().Next (1, 7) |> uint8
            v453 
            #endif
#else
            let v454 : uint8 = System.Random().Next (1, 7) |> uint8
            v454 
            #endif
            |> fun x -> _v445 <- Some x
            let v455 : uint8 = match _v445 with Some x -> x | None -> failwith "base.run_target / _v445=None"
            let v456 : bool = true
            let mutable _v456 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v457 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v458 : uint8 = Fable.Core.RustInterop.emitRustExpr () v457 
            v458 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v459 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v460 : uint8 = Fable.Core.RustInterop.emitRustExpr () v459 
            v460 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : string = "1"
            let v462 : uint8 = Fable.Core.RustInterop.emitRustExpr () v461 
            v462 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v463 : uint8 = System.Random().Next (1, 7) |> uint8
            v463 
            #endif
#if FABLE_COMPILER_PYTHON
            let v464 : uint8 = System.Random().Next (1, 7) |> uint8
            v464 
            #endif
#else
            let v465 : uint8 = System.Random().Next (1, 7) |> uint8
            v465 
            #endif
            |> fun x -> _v456 <- Some x
            let v466 : uint8 = match _v456 with Some x -> x | None -> failwith "base.run_target / _v456=None"
            let v467 : bool = true
            let mutable _v467 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v468 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v469 : uint8 = Fable.Core.RustInterop.emitRustExpr () v468 
            v469 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v470 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v471 : uint8 = Fable.Core.RustInterop.emitRustExpr () v470 
            v471 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v472 : string = "1"
            let v473 : uint8 = Fable.Core.RustInterop.emitRustExpr () v472 
            v473 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v474 : uint8 = System.Random().Next (1, 7) |> uint8
            v474 
            #endif
#if FABLE_COMPILER_PYTHON
            let v475 : uint8 = System.Random().Next (1, 7) |> uint8
            v475 
            #endif
#else
            let v476 : uint8 = System.Random().Next (1, 7) |> uint8
            v476 
            #endif
            |> fun x -> _v467 <- Some x
            let v477 : uint8 = match _v467 with Some x -> x | None -> failwith "base.run_target / _v467=None"
            let v478 : bool = true
            let mutable _v478 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v479 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v480 : uint8 = Fable.Core.RustInterop.emitRustExpr () v479 
            v480 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v481 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v482 : uint8 = Fable.Core.RustInterop.emitRustExpr () v481 
            v482 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v483 : string = "1"
            let v484 : uint8 = Fable.Core.RustInterop.emitRustExpr () v483 
            v484 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v485 : uint8 = System.Random().Next (1, 7) |> uint8
            v485 
            #endif
#if FABLE_COMPILER_PYTHON
            let v486 : uint8 = System.Random().Next (1, 7) |> uint8
            v486 
            #endif
#else
            let v487 : uint8 = System.Random().Next (1, 7) |> uint8
            v487 
            #endif
            |> fun x -> _v478 <- Some x
            let v488 : uint8 = match _v478 with Some x -> x | None -> failwith "base.run_target / _v478=None"
            let v489 : bool = true
            let mutable _v489 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v490 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v491 : uint8 = Fable.Core.RustInterop.emitRustExpr () v490 
            v491 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v492 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v493 : uint8 = Fable.Core.RustInterop.emitRustExpr () v492 
            v493 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v494 : string = "1"
            let v495 : uint8 = Fable.Core.RustInterop.emitRustExpr () v494 
            v495 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v496 : uint8 = System.Random().Next (1, 7) |> uint8
            v496 
            #endif
#if FABLE_COMPILER_PYTHON
            let v497 : uint8 = System.Random().Next (1, 7) |> uint8
            v497 
            #endif
#else
            let v498 : uint8 = System.Random().Next (1, 7) |> uint8
            v498 
            #endif
            |> fun x -> _v489 <- Some x
            let v499 : uint8 = match _v489 with Some x -> x | None -> failwith "base.run_target / _v489=None"
            let v500 : bool = true
            let mutable _v500 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v502 : uint8 = Fable.Core.RustInterop.emitRustExpr () v501 
            v502 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v503 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v504 : uint8 = Fable.Core.RustInterop.emitRustExpr () v503 
            v504 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v505 : string = "1"
            let v506 : uint8 = Fable.Core.RustInterop.emitRustExpr () v505 
            v506 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v507 : uint8 = System.Random().Next (1, 7) |> uint8
            v507 
            #endif
#if FABLE_COMPILER_PYTHON
            let v508 : uint8 = System.Random().Next (1, 7) |> uint8
            v508 
            #endif
#else
            let v509 : uint8 = System.Random().Next (1, 7) |> uint8
            v509 
            #endif
            |> fun x -> _v500 <- Some x
            let v510 : uint8 = match _v500 with Some x -> x | None -> failwith "base.run_target / _v500=None"
            let v511 : bool = true
            let mutable _v511 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v512 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v513 : uint8 = Fable.Core.RustInterop.emitRustExpr () v512 
            v513 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v514 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v515 : uint8 = Fable.Core.RustInterop.emitRustExpr () v514 
            v515 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v516 : string = "1"
            let v517 : uint8 = Fable.Core.RustInterop.emitRustExpr () v516 
            v517 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v518 : uint8 = System.Random().Next (1, 7) |> uint8
            v518 
            #endif
#if FABLE_COMPILER_PYTHON
            let v519 : uint8 = System.Random().Next (1, 7) |> uint8
            v519 
            #endif
#else
            let v520 : uint8 = System.Random().Next (1, 7) |> uint8
            v520 
            #endif
            |> fun x -> _v511 <- Some x
            let v521 : uint8 = match _v511 with Some x -> x | None -> failwith "base.run_target / _v511=None"
            let v522 : bool = true
            let mutable _v522 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v523 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v524 : uint8 = Fable.Core.RustInterop.emitRustExpr () v523 
            v524 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v525 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v526 : uint8 = Fable.Core.RustInterop.emitRustExpr () v525 
            v526 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v527 : string = "1"
            let v528 : uint8 = Fable.Core.RustInterop.emitRustExpr () v527 
            v528 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v529 : uint8 = System.Random().Next (1, 7) |> uint8
            v529 
            #endif
#if FABLE_COMPILER_PYTHON
            let v530 : uint8 = System.Random().Next (1, 7) |> uint8
            v530 
            #endif
#else
            let v531 : uint8 = System.Random().Next (1, 7) |> uint8
            v531 
            #endif
            |> fun x -> _v522 <- Some x
            let v532 : uint8 = match _v522 with Some x -> x | None -> failwith "base.run_target / _v522=None"
            let v533 : bool = true
            let mutable _v533 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v534 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v535 : uint8 = Fable.Core.RustInterop.emitRustExpr () v534 
            v535 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v536 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v537 : uint8 = Fable.Core.RustInterop.emitRustExpr () v536 
            v537 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v538 : string = "1"
            let v539 : uint8 = Fable.Core.RustInterop.emitRustExpr () v538 
            v539 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v540 : uint8 = System.Random().Next (1, 7) |> uint8
            v540 
            #endif
#if FABLE_COMPILER_PYTHON
            let v541 : uint8 = System.Random().Next (1, 7) |> uint8
            v541 
            #endif
#else
            let v542 : uint8 = System.Random().Next (1, 7) |> uint8
            v542 
            #endif
            |> fun x -> _v533 <- Some x
            let v543 : uint8 = match _v533 with Some x -> x | None -> failwith "base.run_target / _v533=None"
            let v544 : bool = true
            let mutable _v544 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v545 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v546 : uint8 = Fable.Core.RustInterop.emitRustExpr () v545 
            v546 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v547 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v548 : uint8 = Fable.Core.RustInterop.emitRustExpr () v547 
            v548 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v549 : string = "1"
            let v550 : uint8 = Fable.Core.RustInterop.emitRustExpr () v549 
            v550 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v551 : uint8 = System.Random().Next (1, 7) |> uint8
            v551 
            #endif
#if FABLE_COMPILER_PYTHON
            let v552 : uint8 = System.Random().Next (1, 7) |> uint8
            v552 
            #endif
#else
            let v553 : uint8 = System.Random().Next (1, 7) |> uint8
            v553 
            #endif
            |> fun x -> _v544 <- Some x
            let v554 : uint8 = match _v544 with Some x -> x | None -> failwith "base.run_target / _v544=None"
            let v555 : UH1 = UH1_0
            let v556 : UH1 = UH1_1(v554, v555)
            let v557 : UH1 = UH1_1(v543, v556)
            let v558 : UH1 = UH1_1(v532, v557)
            let v559 : UH1 = UH1_1(v521, v558)
            let v560 : UH1 = UH1_1(v510, v559)
            let v561 : UH1 = UH1_1(v499, v560)
            let v562 : UH1 = UH1_1(v488, v561)
            let v563 : UH1 = UH1_1(v477, v562)
            let v564 : UH1 = UH1_1(v466, v563)
            let v565 : UH1 = UH1_1(v455, v564)
            let v566 : UH1 = UH1_1(v444, v565)
            let v567 : UH1 = UH1_1(v433, v566)
            let v568 : UH1 = UH1_1(v422, v567)
            let v569 : UH1 = UH1_1(v411, v568)
            let v570 : UH1 = UH1_1(v400, v569)
            let v571 : UH1 = UH1_1(v389, v570)
            let v572 : UH1 = UH1_1(v378, v571)
            let v573 : UH1 = UH1_1(v367, v572)
            let v574 : UH1 = UH1_1(v356, v573)
            let v575 : UH1 = UH1_1(v345, v574)
            let v576 : UH1 = UH1_1(v334, v575)
            let v577 : UH1 = UH1_1(v323, v576)
            let v578 : UH1 = UH1_1(v312, v577)
            let v579 : int8 = 23y
            method14(v578, v579)
and closure80 () (v0 : (string [])) : int32 =
    let v1 : string = $"calculate_dice_count / max: {9223372036854775807L} / n: {24y} / p: {4738381338321616896L}"
    let v2 : (string -> unit) = System.Console.WriteLine
    v2 v1
    let v3 : UH1 = UH1_0
    let v4 : int8 = 0y
    let v5 : int64 = method14(v3, v4)
    let v6 : string = $"result: {v5}"
    let v7 : (string -> unit) = System.Console.WriteLine
    v7 v6
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
