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
and closure4 () (v0 : (string -> unit)) : US0 =
    US0_0(v0)
and method1 () : ((string -> unit) -> US0) =
    closure4()
and method2 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_1(v2, v1)
        method2(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and method3 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method3(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure6 (v0 : UH0) () : UH0 =
    v0
and method4 (v0 : UH1, v1 : UH0) : UH0 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method4(v3, v1)
        let v5 : (unit -> UH0) = closure6(v4)
        UH0_0(v2, v5)
    | UH1_0 -> (* Nil *)
        v1
and closure7 (v0 : UH0) () : UH0 =
    v0
and closure8 (v0 : UH0, v1 : Mut0) () : UH0 =
    let v2 : US1 = v1.l0
    match v2 with
    | US1_1(v3) -> (* Computed *)
        v3
    | US1_0(v4) -> (* NotComputed *)
        let v5 : UH0 = v4 ()
        let v12 : UH0 =
            match v5 with
            | UH0_0(v7, v8) -> (* StreamCons *)
                let v9 : (unit -> UH0) = method5(v0, v8)
                UH0_0(v7, v9)
            | UH0_1 -> (* StreamNil *)
                UH0_1
        let v13 : US1 = US1_1(v12)
        v1.l0 <- v13
        v12
and method5 (v0 : UH0, v1 : (unit -> UH0)) : (unit -> UH0) =
    let v2 : US1 = US1_0(v1)
    let v3 : Mut0 = {l0 = v2} : Mut0
    closure8(v0, v3)
and method7 (v0 : int64, v1 : UH0) : US2 =
    match v1 with
    | UH0_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0L
        if v4 then
            US2_0(v2)
        else
            let v6 : int64 = v0 - 1L
            let v7 : UH0 = v3 ()
            method7(v6, v7)
    | UH0_1 -> (* StreamNil *)
        US2_1
and method6 (v0 : US0, v1 : (unit -> UH0), v2 : Mut1, v3 : Mut1, v4 : Mut1, v5 : Mut2) : uint8 =
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
    let v14 : US2 = method7(v13, v12)
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
        method6(v0, v1, v2, v3, v4, v5)
    | US2_0(v15) -> (* Some *)
        let v16 : int64 = v2.l0
        let v17 : int64 = v16 + 1L
        v2.l0 <- v17
        let v18 : US2 = US2_0(v15)
        v5.l0 <- v18
        v15
and closure9 (v0 : US0, v1 : (unit -> UH0), v2 : Mut1, v3 : Mut1, v4 : Mut1, v5 : Mut2) () : uint8 =
    method6(v0, v1, v2, v3, v4, v5)
and closure5 (v0 : US0) (v1 : UH1) : (unit -> uint8) =
    let v2 : string = $"create_sequential_roller ()"
    match v0 with
    | US0_1 -> (* None *)
        ()
    | US0_0(v3) -> (* Some *)
        v3 v2
    let v4 : UH1 = UH1_0
    let v5 : UH1 = method2(v1, v4)
    let v6 : UH1 = method3(v1, v5)
    let v7 : UH0 = UH0_1
    let v8 : UH0 = method4(v6, v7)
    let v9 : (unit -> UH0) = closure7(v8)
    let v10 : (unit -> UH0) = method5(v8, v9)
    let v11 : Mut1 = {l0 = 0L} : Mut1
    let v12 : Mut1 = {l0 = 1L} : Mut1
    let v13 : Mut1 = {l0 = -1L} : Mut1
    let v14 : US2 = US2_1
    let v15 : Mut2 = {l0 = v14} : Mut2
    closure9(v0, v10, v11, v12, v13, v15)
and closure3 () (v0 : (string -> unit) option) : (UH1 -> (unit -> uint8)) =
    let v1 : ((string -> unit) -> US0) = method1()
    let v2 : US0 = US0_1
    let v3 : US0 = v0 |> Option.map v1 |> Option.defaultValue v2 
    closure5(v3)
and method8 (v0 : US0, v1 : uint64, v2 : int8, v3 : uint64) : int8 =
    let v4 : bool = v3 < v1
    if v4 then
        let v5 : uint64 = v3 * 6UL
        let v6 : bool = v5 > v3
        if v6 then
            let v7 : int8 = v2 + 1y
            method8(v0, v1, v7, v5)
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
and closure77 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(0UL, v0)
and closure76 () () : UH2 =
    let v0 : (unit -> UH2) = closure77()
    UH2_0(9223372036854775808UL, v0)
and closure75 () () : UH2 =
    let v0 : (unit -> UH2) = closure76()
    UH2_0(4611686018427387904UL, v0)
and closure74 () () : UH2 =
    let v0 : (unit -> UH2) = closure75()
    UH2_0(6917529027641081856UL, v0)
and closure73 () () : UH2 =
    let v0 : (unit -> UH2) = closure74()
    UH2_0(1152921504606846976UL, v0)
and closure72 () () : UH2 =
    let v0 : (unit -> UH2) = closure73()
    UH2_0(15564440312192434176UL, v0)
and closure71 () () : UH2 =
    let v0 : (unit -> UH2) = closure72()
    UH2_0(11817445422220181504UL, v0)
and closure70 () () : UH2 =
    let v0 : (unit -> UH2) = closure71()
    UH2_0(5044031582654955520UL, v0)
and closure69 () () : UH2 =
    let v0 : (unit -> UH2) = closure70()
    UH2_0(6989586621679009792UL, v0)
and closure68 () () : UH2 =
    let v0 : (unit -> UH2) = closure69()
    UH2_0(16537217831704461312UL, v0)
and closure67 () () : UH2 =
    let v0 : (unit -> UH2) = closure68()
    UH2_0(11979575008805519360UL, v0)
and closure66 () () : UH2 =
    let v0 : (unit -> UH2) = closure67()
    UH2_0(14294425217273954304UL, v0)
and closure65 () () : UH2 =
    let v0 : (unit -> UH2) = closure66()
    UH2_0(2382404202878992384UL, v0)
and closure64 () () : UH2 =
    let v0 : (unit -> UH2) = closure65()
    UH2_0(6545982058383015936UL, v0)
and closure63 () () : UH2 =
    let v0 : (unit -> UH2) = closure64()
    UH2_0(10314369046585278464UL, v0)
and closure62 () () : UH2 =
    let v0 : (unit -> UH2) = closure63()
    UH2_0(4793518853382471680UL, v0)
and closure61 () () : UH2 =
    let v0 : (unit -> UH2) = closure62()
    UH2_0(3873377154515337216UL, v0)
and closure60 () () : UH2 =
    let v0 : (unit -> UH2) = closure61()
    UH2_0(645562859085889536UL, v0)
and closure59 () () : UH2 =
    let v0 : (unit -> UH2) = closure60()
    UH2_0(107593809847648256UL, v0)
and closure58 () () : UH2 =
    let v0 : (unit -> UH2) = closure59()
    UH2_0(3092389647259533312UL, v0)
and closure57 () () : UH2 =
    let v0 : (unit -> UH2) = closure58()
    UH2_0(9738770311398031360UL, v0)
and closure56 () () : UH2 =
    let v0 : (unit -> UH2) = closure57()
    UH2_0(16995415113324298240UL, v0)
and closure55 () () : UH2 =
    let v0 : (unit -> UH2) = closure56()
    UH2_0(8981483876790566912UL, v0)
and closure54 () () : UH2 =
    let v0 : (unit -> UH2) = closure55()
    UH2_0(13794743361938128896UL, v0)
and closure53 () () : UH2 =
    let v0 : (unit -> UH2) = closure54()
    UH2_0(2299123893656354816UL, v0)
and closure52 () () : UH2 =
    let v0 : (unit -> UH2) = closure53()
    UH2_0(3457644661227651072UL, v0)
and closure51 () () : UH2 =
    let v0 : (unit -> UH2) = closure52()
    UH2_0(576274110204608512UL, v0)
and closure50 () () : UH2 =
    let v0 : (unit -> UH2) = closure51()
    UH2_0(6244960376270618624UL, v0)
and closure49 () () : UH2 =
    let v0 : (unit -> UH2) = closure50()
    UH2_0(13338656111851470848UL, v0)
and closure48 () () : UH2 =
    let v0 : (unit -> UH2) = closure49()
    UH2_0(14520938734448279552UL, v0)
and closure47 () () : UH2 =
    let v0 : (unit -> UH2) = closure48()
    UH2_0(14717985838214414336UL, v0)
and closure46 () () : UH2 =
    let v0 : (unit -> UH2) = closure47()
    UH2_0(5527454985320660992UL, v0)
and closure45 () () : UH2 =
    let v0 : (unit -> UH2) = closure46()
    UH2_0(16293529225644736512UL, v0)
and closure44 () () : UH2 =
    let v0 : (unit -> UH2) = closure45()
    UH2_0(11938960241128898560UL, v0)
and closure43 () () : UH2 =
    let v0 : (unit -> UH2) = closure44()
    UH2_0(8138741398091333632UL, v0)
and closure42 () () : UH2 =
    let v0 : (unit -> UH2) = closure43()
    UH2_0(7505371590918406144UL, v0)
and closure41 () () : UH2 =
    let v0 : (unit -> UH2) = closure42()
    UH2_0(16623181993244360704UL, v0)
and closure40 () () : UH2 =
    let v0 : (unit -> UH2) = closure41()
    UH2_0(8919445023443910656UL, v0)
and closure39 () () : UH2 =
    let v0 : (unit -> UH2) = closure40()
    UH2_0(4561031516192243712UL, v0)
and closure38 () () : UH2 =
    let v0 : (unit -> UH2) = closure39()
    UH2_0(9983543956220149760UL, v0)
and closure37 () () : UH2 =
    let v0 : (unit -> UH2) = closure38()
    UH2_0(4738381338321616896UL, v0)
and closure36 () () : UH2 =
    let v0 : (unit -> UH2) = closure37()
    UH2_0(789730223053602816UL, v0)
and closure35 () () : UH2 =
    let v0 : (unit -> UH2) = closure36()
    UH2_0(131621703842267136UL, v0)
and closure34 () () : UH2 =
    let v0 : (unit -> UH2) = closure35()
    UH2_0(21936950640377856UL, v0)
and closure33 () () : UH2 =
    let v0 : (unit -> UH2) = closure34()
    UH2_0(3656158440062976UL, v0)
and closure32 () () : UH2 =
    let v0 : (unit -> UH2) = closure33()
    UH2_0(609359740010496UL, v0)
and closure31 () () : UH2 =
    let v0 : (unit -> UH2) = closure32()
    UH2_0(101559956668416UL, v0)
and closure30 () () : UH2 =
    let v0 : (unit -> UH2) = closure31()
    UH2_0(16926659444736UL, v0)
and closure29 () () : UH2 =
    let v0 : (unit -> UH2) = closure30()
    UH2_0(2821109907456UL, v0)
and closure28 () () : UH2 =
    let v0 : (unit -> UH2) = closure29()
    UH2_0(470184984576UL, v0)
and closure27 () () : UH2 =
    let v0 : (unit -> UH2) = closure28()
    UH2_0(78364164096UL, v0)
and closure26 () () : UH2 =
    let v0 : (unit -> UH2) = closure27()
    UH2_0(13060694016UL, v0)
and closure25 () () : UH2 =
    let v0 : (unit -> UH2) = closure26()
    UH2_0(2176782336UL, v0)
and closure24 () () : UH2 =
    let v0 : (unit -> UH2) = closure25()
    UH2_0(362797056UL, v0)
and closure23 () () : UH2 =
    let v0 : (unit -> UH2) = closure24()
    UH2_0(60466176UL, v0)
and closure22 () () : UH2 =
    let v0 : (unit -> UH2) = closure23()
    UH2_0(10077696UL, v0)
and closure21 () () : UH2 =
    let v0 : (unit -> UH2) = closure22()
    UH2_0(1679616UL, v0)
and closure20 () () : UH2 =
    let v0 : (unit -> UH2) = closure21()
    UH2_0(279936UL, v0)
and closure19 () () : UH2 =
    let v0 : (unit -> UH2) = closure20()
    UH2_0(46656UL, v0)
and closure18 () () : UH2 =
    let v0 : (unit -> UH2) = closure19()
    UH2_0(7776UL, v0)
and closure17 () () : UH2 =
    let v0 : (unit -> UH2) = closure18()
    UH2_0(1296UL, v0)
and closure16 () () : UH2 =
    let v0 : (unit -> UH2) = closure17()
    UH2_0(216UL, v0)
and closure15 () () : UH2 =
    let v0 : (unit -> UH2) = closure16()
    UH2_0(36UL, v0)
and closure14 () () : UH2 =
    let v0 : (unit -> UH2) = closure15()
    UH2_0(6UL, v0)
and method11 (v0 : int8, v1 : UH2) : US4 =
    match v1 with
    | UH2_0(v2, v3) -> (* StreamCons *)
        let v4 : bool = v0 <= 0y
        if v4 then
            US4_0(v2)
        else
            let v6 : int8 = v0 - 1y
            let v7 : UH2 = v3 ()
            method11(v6, v7)
    | UH2_1 -> (* StreamNil *)
        US4_1
and method10 (v0 : US0, v1 : int8, v2 : UH1, v3 : uint64) : US3 =
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
                let v14 : (unit -> UH2) = closure14()
                let v15 : UH2 = UH2_0(v13, v14)
                let v16 : US4 = method11(v1, v15)
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
                method10(v0, v27, v11, v26)
            else
                let v29 : string = $"accumulate_dice_rolls / power: {v1} / acc: {v3} / roll: {v10}"
                match v0 with
                | US0_1 -> (* None *)
                    ()
                | US0_0(v30) -> (* Some *)
                    v30 v29
                let v31 : int8 = v1 - 1y
                method10(v0, v31, v11, v3)
        | UH1_0 -> (* Nil *)
            US3_1
and method12 (v0 : int8, v1 : (unit -> uint8), v2 : int8) : UH1 =
    let v3 : bool = v2 < v0
    if v3 then
        let v4 : uint8 = v1 ()
        let v5 : int8 = v2 + 1y
        let v6 : UH1 = method12(v0, v1, v5)
        UH1_1(v4, v6)
    else
        UH1_0
and method13 (v0 : US0, v1 : (unit -> uint8), v2 : bool, v3 : uint64, v4 : int8, v5 : UH1) : uint64 =
    let v6 : int8 = v4 + 1y
    let v7 : bool = v4 < v6
    if v7 then
        let v8 : uint8 = v1 ()
        let v9 : UH1 = UH1_1(v8, v5)
        method9(v0, v1, v2, v3, v4, v9, v6)
    else
        let v11 : uint64 = 0UL
        let v12 : US3 = method10(v0, v4, v5, v11)
        match v12 with
        | US3_0(v13, v14) -> (* Some *)
            let v15 : bool = v13 <= v3
            if v15 then
                v13
            else
                if v2 then
                    let v16 : int8 = 0y
                    let v17 : UH1 = method12(v4, v1, v16)
                    method13(v0, v1, v2, v3, v4, v17)
                else
                    let v19 : uint8 = v1 ()
                    let v20 : UH1 = UH1_1(v19, v5)
                    method9(v0, v1, v2, v3, v4, v20, v6)
        | _ ->
            if v2 then
                let v24 : int8 = 0y
                let v25 : UH1 = method12(v4, v1, v24)
                method13(v0, v1, v2, v3, v4, v25)
            else
                let v27 : uint8 = v1 ()
                let v28 : UH1 = UH1_1(v27, v5)
                method9(v0, v1, v2, v3, v4, v28, v6)
and method9 (v0 : US0, v1 : (unit -> uint8), v2 : bool, v3 : uint64, v4 : int8, v5 : UH1, v6 : int8) : uint64 =
    let v7 : int8 = v4 + 1y
    let v8 : bool = v6 < v7
    if v8 then
        let v9 : uint8 = v1 ()
        let v10 : UH1 = UH1_1(v9, v5)
        let v11 : int8 = v6 + 1y
        method9(v0, v1, v2, v3, v4, v10, v11)
    else
        let v13 : uint64 = 0UL
        let v14 : US3 = method10(v0, v4, v5, v13)
        match v14 with
        | US3_0(v15, v16) -> (* Some *)
            let v17 : bool = v15 <= v3
            if v17 then
                v15
            else
                if v2 then
                    let v18 : int8 = 0y
                    let v19 : UH1 = method12(v4, v1, v18)
                    method13(v0, v1, v2, v3, v4, v19)
                else
                    let v21 : uint8 = v1 ()
                    let v22 : UH1 = UH1_1(v21, v5)
                    let v23 : int8 = v6 + 1y
                    method9(v0, v1, v2, v3, v4, v22, v23)
        | _ ->
            if v2 then
                let v27 : int8 = 0y
                let v28 : UH1 = method12(v4, v1, v27)
                method13(v0, v1, v2, v3, v4, v28)
            else
                let v30 : uint8 = v1 ()
                let v31 : UH1 = UH1_1(v30, v5)
                let v32 : int8 = v6 + 1y
                method9(v0, v1, v2, v3, v4, v31, v32)
and closure13 (v0 : US0, v1 : (unit -> uint8), v2 : bool) (v3 : uint64) : uint64 =
    let v4 : bool = v3 = 1UL
    let v8 : int8 =
        if v4 then
            1y
        else
            let v5 : int8 = 0y
            let v6 : uint64 = 1UL
            method8(v0, v3, v5, v6)
    let v9 : int8 = v8 - 1y
    let v10 : UH1 = UH1_0
    let v11 : int8 = 0y
    method9(v0, v1, v2, v3, v9, v10, v11)
and closure12 (v0 : US0, v1 : (unit -> uint8)) (v2 : bool) : (uint64 -> uint64) =
    closure13(v0, v1, v2)
and closure11 (v0 : US0) (v1 : (unit -> uint8)) : (bool -> (uint64 -> uint64)) =
    closure12(v0, v1)
and closure10 () (v0 : (string -> unit) option) : ((unit -> uint8) -> (bool -> (uint64 -> uint64))) =
    let v1 : ((string -> unit) -> US0) = method1()
    let v2 : US0 = US0_1
    let v3 : US0 = v0 |> Option.map v1 |> Option.defaultValue v2 
    closure11(v3)
and method14 (v0 : UH1, v1 : int8) : int8 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : int8 = v1 + 1y
        method14(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and closure80 (v0 : (string -> unit) option, v1 : uint64) (v2 : UH1) : uint64 option =
    let v3 : ((string -> unit) -> US0) = method1()
    let v4 : US0 = US0_1
    let v5 : US0 = v0 |> Option.map v3 |> Option.defaultValue v4 
    let v6 : int8 = 0y
    let v7 : int8 = method14(v2, v6)
    let v8 : int8 = v7 - 1y
    let v9 : uint64 = 0UL
    let v10 : US3 = method10(v5, v8, v2, v9)
    let v20 : US4 =
        match v10 with
        | US3_0(v11, v12) -> (* Some *)
            let v13 : bool = v11 >= 1UL
            let v15 : bool =
                if v13 then
                    let v14 : bool = v11 <= v1
                    v14
                else
                    false
            if v15 then
                US4_0(v11)
            else
                US4_1
        | _ ->
            US4_1
    match v20 with
    | US4_1 -> (* None *)
        let v23 : uint64 option = None
        v23
    | US4_0(v21) -> (* Some *)
        let v22 : uint64 option = Some v21 
        v22
and closure79 (v0 : (string -> unit) option) (v1 : uint64) : (UH1 -> uint64 option) =
    closure80(v0, v1)
and closure78 () (v0 : (string -> unit) option) : (uint64 -> (UH1 -> uint64 option)) =
    closure79(v0)
and method40 (v0 : UH1, v1 : int64) : US5 =
    let v2 : int64 = v1 + 1L
    let v3 : string = $"accumulate_dice_rolls / power: {-1y} / acc: {v1} / result: {v2}"
    System.Console.WriteLine v3
    US5_0(v2, v0)
and method39 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3} / value: {v7}"
            System.Console.WriteLine v8
            let v9 : int64 = v1 + v7
            method40(v4, v9)
        else
            let v11 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v11
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method39(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method38(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method37(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method36(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method35(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method34(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method33(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method32(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method31(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method30(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method29(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method28(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method27(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method26(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method25(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method24(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method23(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method22(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method21(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method20(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method19(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method18(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method17(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
            method17(v4, v1)
    | UH1_0 -> (* Nil *)
        US5_1
and method15 (v0 : UH1, v1 : int8) : int64 =
    let v2 : bool = v1 < 24y
    if v2 then
        let v3 : uint8 option = None
        let mutable _v3 = v3
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
        let v5 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4
        v5 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v6 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4
        v6 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v7 : string = "1"
        let v8 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7
        v8 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v9 : uint8 = System.Random().Next (1, 7) |> uint8
        v9 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v10 : uint8 = System.Random().Next (1, 7) |> uint8
        v10 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<uint8>
        #endif
        |> fun x -> _v3 <- Some x
        let v11 : uint8 = _v3.Value
        let v12 : UH1 = UH1_1(v11, v0)
        let v13 : int8 = v1 + 1y
        method15(v12, v13)
    else
        let v15 : int64 = 0L
        let v16 : US5 = method16(v0, v15)
        match v16 with
        | US5_0(v17, v18) -> (* Some *)
            let v19 : bool = v17 <= 9223372036854775807L
            if v19 then
                v17
            else
                let v20 : uint8 option = None
                let mutable _v20 = v20
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v21 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v22 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v22 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v23 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v23 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v24 : string = "1"
                let v25 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v25 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v26 : uint8 = System.Random().Next (1, 7) |> uint8
                v26 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v27 : uint8 = System.Random().Next (1, 7) |> uint8
                v27 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v20 <- Some x
                let v28 : uint8 = _v20.Value
                let v29 : uint8 option = None
                let mutable _v29 = v29
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v30 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v30 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v31 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v31 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v32 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v32 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v33 : uint8 = System.Random().Next (1, 7) |> uint8
                v33 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v34 : uint8 = System.Random().Next (1, 7) |> uint8
                v34 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v29 <- Some x
                let v35 : uint8 = _v29.Value
                let v36 : uint8 option = None
                let mutable _v36 = v36
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v37 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v37 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v38 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v38 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v39 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v39 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v40 : uint8 = System.Random().Next (1, 7) |> uint8
                v40 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v41 : uint8 = System.Random().Next (1, 7) |> uint8
                v41 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v36 <- Some x
                let v42 : uint8 = _v36.Value
                let v43 : uint8 option = None
                let mutable _v43 = v43
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v44 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v44 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v45 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v45 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v46 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v46 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v47 : uint8 = System.Random().Next (1, 7) |> uint8
                v47 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v48 : uint8 = System.Random().Next (1, 7) |> uint8
                v48 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v43 <- Some x
                let v49 : uint8 = _v43.Value
                let v50 : uint8 option = None
                let mutable _v50 = v50
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v51 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v51 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v52 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v52 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v53 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v53 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v54 : uint8 = System.Random().Next (1, 7) |> uint8
                v54 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v55 : uint8 = System.Random().Next (1, 7) |> uint8
                v55 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v50 <- Some x
                let v56 : uint8 = _v50.Value
                let v57 : uint8 option = None
                let mutable _v57 = v57
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v58 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v58 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v59 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v59 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v60 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v60 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v61 : uint8 = System.Random().Next (1, 7) |> uint8
                v61 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v62 : uint8 = System.Random().Next (1, 7) |> uint8
                v62 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v57 <- Some x
                let v63 : uint8 = _v57.Value
                let v64 : uint8 option = None
                let mutable _v64 = v64
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v65 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v65 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v66 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v66 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v67 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v67 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v68 : uint8 = System.Random().Next (1, 7) |> uint8
                v68 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v69 : uint8 = System.Random().Next (1, 7) |> uint8
                v69 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v64 <- Some x
                let v70 : uint8 = _v64.Value
                let v71 : uint8 option = None
                let mutable _v71 = v71
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v72 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v72 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v73 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v73 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v74 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v74 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v75 : uint8 = System.Random().Next (1, 7) |> uint8
                v75 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v76 : uint8 = System.Random().Next (1, 7) |> uint8
                v76 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v71 <- Some x
                let v77 : uint8 = _v71.Value
                let v78 : uint8 option = None
                let mutable _v78 = v78
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v79 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v79 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v80 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v80 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v81 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v81 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v82 : uint8 = System.Random().Next (1, 7) |> uint8
                v82 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v83 : uint8 = System.Random().Next (1, 7) |> uint8
                v83 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v78 <- Some x
                let v84 : uint8 = _v78.Value
                let v85 : uint8 option = None
                let mutable _v85 = v85
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v86 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v86 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v87 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v87 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v88 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v88 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v89 : uint8 = System.Random().Next (1, 7) |> uint8
                v89 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v90 : uint8 = System.Random().Next (1, 7) |> uint8
                v90 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v85 <- Some x
                let v91 : uint8 = _v85.Value
                let v92 : uint8 option = None
                let mutable _v92 = v92
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v93 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v93 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v94 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v94 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v95 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v95 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v96 : uint8 = System.Random().Next (1, 7) |> uint8
                v96 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v97 : uint8 = System.Random().Next (1, 7) |> uint8
                v97 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v92 <- Some x
                let v98 : uint8 = _v92.Value
                let v99 : uint8 option = None
                let mutable _v99 = v99
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v100 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v100 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v101 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v101 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v102 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v102 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v103 : uint8 = System.Random().Next (1, 7) |> uint8
                v103 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v104 : uint8 = System.Random().Next (1, 7) |> uint8
                v104 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v99 <- Some x
                let v105 : uint8 = _v99.Value
                let v106 : uint8 option = None
                let mutable _v106 = v106
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v107 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v107 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v108 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v108 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v109 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v109 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v110 : uint8 = System.Random().Next (1, 7) |> uint8
                v110 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v111 : uint8 = System.Random().Next (1, 7) |> uint8
                v111 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v106 <- Some x
                let v112 : uint8 = _v106.Value
                let v113 : uint8 option = None
                let mutable _v113 = v113
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v114 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v114 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v115 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v115 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v116 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v116 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v117 : uint8 = System.Random().Next (1, 7) |> uint8
                v117 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v118 : uint8 = System.Random().Next (1, 7) |> uint8
                v118 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v113 <- Some x
                let v119 : uint8 = _v113.Value
                let v120 : uint8 option = None
                let mutable _v120 = v120
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v121 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v121 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v122 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v122 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v123 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v123 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v124 : uint8 = System.Random().Next (1, 7) |> uint8
                v124 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v125 : uint8 = System.Random().Next (1, 7) |> uint8
                v125 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v120 <- Some x
                let v126 : uint8 = _v120.Value
                let v127 : uint8 option = None
                let mutable _v127 = v127
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v128 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v128 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v129 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v129 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v130 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v130 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v131 : uint8 = System.Random().Next (1, 7) |> uint8
                v131 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v132 : uint8 = System.Random().Next (1, 7) |> uint8
                v132 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v127 <- Some x
                let v133 : uint8 = _v127.Value
                let v134 : uint8 option = None
                let mutable _v134 = v134
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v135 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v135 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v136 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v136 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v137 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v137 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v138 : uint8 = System.Random().Next (1, 7) |> uint8
                v138 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v139 : uint8 = System.Random().Next (1, 7) |> uint8
                v139 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v134 <- Some x
                let v140 : uint8 = _v134.Value
                let v141 : uint8 option = None
                let mutable _v141 = v141
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v142 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v142 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v143 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v143 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v144 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v144 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v145 : uint8 = System.Random().Next (1, 7) |> uint8
                v145 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v146 : uint8 = System.Random().Next (1, 7) |> uint8
                v146 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v141 <- Some x
                let v147 : uint8 = _v141.Value
                let v148 : uint8 option = None
                let mutable _v148 = v148
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v149 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v149 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v150 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v150 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v151 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v151 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v152 : uint8 = System.Random().Next (1, 7) |> uint8
                v152 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v153 : uint8 = System.Random().Next (1, 7) |> uint8
                v153 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v148 <- Some x
                let v154 : uint8 = _v148.Value
                let v155 : uint8 option = None
                let mutable _v155 = v155
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v156 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v156 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v157 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v157 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v158 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v158 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v159 : uint8 = System.Random().Next (1, 7) |> uint8
                v159 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v160 : uint8 = System.Random().Next (1, 7) |> uint8
                v160 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v155 <- Some x
                let v161 : uint8 = _v155.Value
                let v162 : uint8 option = None
                let mutable _v162 = v162
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v163 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v163 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v164 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v164 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v165 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v165 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v166 : uint8 = System.Random().Next (1, 7) |> uint8
                v166 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v167 : uint8 = System.Random().Next (1, 7) |> uint8
                v167 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v162 <- Some x
                let v168 : uint8 = _v162.Value
                let v169 : uint8 option = None
                let mutable _v169 = v169
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v170 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v170 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v171 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v171 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v172 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v172 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v173 : uint8 = System.Random().Next (1, 7) |> uint8
                v173 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v174 : uint8 = System.Random().Next (1, 7) |> uint8
                v174 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v169 <- Some x
                let v175 : uint8 = _v169.Value
                let v176 : uint8 option = None
                let mutable _v176 = v176
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v177 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v177 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v178 : uint8 = Fable.Core.RustInterop.emitRustExpr () v21
                v178 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v179 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v179 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v180 : uint8 = System.Random().Next (1, 7) |> uint8
                v180 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v181 : uint8 = System.Random().Next (1, 7) |> uint8
                v181 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                Unchecked.defaultof<uint8>
                #endif
                |> fun x -> _v176 <- Some x
                let v182 : uint8 = _v176.Value
                let v183 : UH1 = UH1_0
                let v184 : UH1 = UH1_1(v182, v183)
                let v185 : UH1 = UH1_1(v175, v184)
                let v186 : UH1 = UH1_1(v168, v185)
                let v187 : UH1 = UH1_1(v161, v186)
                let v188 : UH1 = UH1_1(v154, v187)
                let v189 : UH1 = UH1_1(v147, v188)
                let v190 : UH1 = UH1_1(v140, v189)
                let v191 : UH1 = UH1_1(v133, v190)
                let v192 : UH1 = UH1_1(v126, v191)
                let v193 : UH1 = UH1_1(v119, v192)
                let v194 : UH1 = UH1_1(v112, v193)
                let v195 : UH1 = UH1_1(v105, v194)
                let v196 : UH1 = UH1_1(v98, v195)
                let v197 : UH1 = UH1_1(v91, v196)
                let v198 : UH1 = UH1_1(v84, v197)
                let v199 : UH1 = UH1_1(v77, v198)
                let v200 : UH1 = UH1_1(v70, v199)
                let v201 : UH1 = UH1_1(v63, v200)
                let v202 : UH1 = UH1_1(v56, v201)
                let v203 : UH1 = UH1_1(v49, v202)
                let v204 : UH1 = UH1_1(v42, v203)
                let v205 : UH1 = UH1_1(v35, v204)
                let v206 : UH1 = UH1_1(v28, v205)
                let v207 : int8 = 23y
                method15(v206, v207)
        | _ ->
            let v210 : uint8 option = None
            let mutable _v210 = v210
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v211 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v212 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v212 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v213 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v213 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v214 : string = "1"
            let v215 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v215 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v216 : uint8 = System.Random().Next (1, 7) |> uint8
            v216 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v217 : uint8 = System.Random().Next (1, 7) |> uint8
            v217 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v210 <- Some x
            let v218 : uint8 = _v210.Value
            let v219 : uint8 option = None
            let mutable _v219 = v219
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v220 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v220 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v221 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v221 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v222 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v222 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v223 : uint8 = System.Random().Next (1, 7) |> uint8
            v223 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v224 : uint8 = System.Random().Next (1, 7) |> uint8
            v224 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v219 <- Some x
            let v225 : uint8 = _v219.Value
            let v226 : uint8 option = None
            let mutable _v226 = v226
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v227 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v227 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v228 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v228 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v229 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v229 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v230 : uint8 = System.Random().Next (1, 7) |> uint8
            v230 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v231 : uint8 = System.Random().Next (1, 7) |> uint8
            v231 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v226 <- Some x
            let v232 : uint8 = _v226.Value
            let v233 : uint8 option = None
            let mutable _v233 = v233
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v234 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v235 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v235 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v236 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v236 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v237 : uint8 = System.Random().Next (1, 7) |> uint8
            v237 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v238 : uint8 = System.Random().Next (1, 7) |> uint8
            v238 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v233 <- Some x
            let v239 : uint8 = _v233.Value
            let v240 : uint8 option = None
            let mutable _v240 = v240
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v241 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v241 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v242 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v242 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v243 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v243 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v244 : uint8 = System.Random().Next (1, 7) |> uint8
            v244 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v245 : uint8 = System.Random().Next (1, 7) |> uint8
            v245 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v240 <- Some x
            let v246 : uint8 = _v240.Value
            let v247 : uint8 option = None
            let mutable _v247 = v247
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v248 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v248 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v249 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v249 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v250 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v250 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v251 : uint8 = System.Random().Next (1, 7) |> uint8
            v251 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v252 : uint8 = System.Random().Next (1, 7) |> uint8
            v252 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v247 <- Some x
            let v253 : uint8 = _v247.Value
            let v254 : uint8 option = None
            let mutable _v254 = v254
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v255 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v255 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v256 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v256 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v257 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v257 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v258 : uint8 = System.Random().Next (1, 7) |> uint8
            v258 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v259 : uint8 = System.Random().Next (1, 7) |> uint8
            v259 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v254 <- Some x
            let v260 : uint8 = _v254.Value
            let v261 : uint8 option = None
            let mutable _v261 = v261
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v262 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v262 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v263 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v263 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v264 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v264 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v265 : uint8 = System.Random().Next (1, 7) |> uint8
            v265 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v266 : uint8 = System.Random().Next (1, 7) |> uint8
            v266 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v261 <- Some x
            let v267 : uint8 = _v261.Value
            let v268 : uint8 option = None
            let mutable _v268 = v268
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v269 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v269 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v270 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v270 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v271 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v271 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v272 : uint8 = System.Random().Next (1, 7) |> uint8
            v272 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v273 : uint8 = System.Random().Next (1, 7) |> uint8
            v273 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v268 <- Some x
            let v274 : uint8 = _v268.Value
            let v275 : uint8 option = None
            let mutable _v275 = v275
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v276 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v276 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v277 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v277 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v278 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v278 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v279 : uint8 = System.Random().Next (1, 7) |> uint8
            v279 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v280 : uint8 = System.Random().Next (1, 7) |> uint8
            v280 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v275 <- Some x
            let v281 : uint8 = _v275.Value
            let v282 : uint8 option = None
            let mutable _v282 = v282
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v283 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v283 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v284 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v284 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v285 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v285 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v286 : uint8 = System.Random().Next (1, 7) |> uint8
            v286 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v287 : uint8 = System.Random().Next (1, 7) |> uint8
            v287 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v282 <- Some x
            let v288 : uint8 = _v282.Value
            let v289 : uint8 option = None
            let mutable _v289 = v289
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v290 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v290 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v291 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v291 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v292 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v292 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v293 : uint8 = System.Random().Next (1, 7) |> uint8
            v293 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v294 : uint8 = System.Random().Next (1, 7) |> uint8
            v294 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v289 <- Some x
            let v295 : uint8 = _v289.Value
            let v296 : uint8 option = None
            let mutable _v296 = v296
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v297 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v297 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v298 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v298 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v299 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v299 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v300 : uint8 = System.Random().Next (1, 7) |> uint8
            v300 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v301 : uint8 = System.Random().Next (1, 7) |> uint8
            v301 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v296 <- Some x
            let v302 : uint8 = _v296.Value
            let v303 : uint8 option = None
            let mutable _v303 = v303
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v304 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v304 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v305 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v305 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v306 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v306 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v307 : uint8 = System.Random().Next (1, 7) |> uint8
            v307 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v308 : uint8 = System.Random().Next (1, 7) |> uint8
            v308 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v303 <- Some x
            let v309 : uint8 = _v303.Value
            let v310 : uint8 option = None
            let mutable _v310 = v310
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v311 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v311 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v312 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v312 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v313 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v313 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v314 : uint8 = System.Random().Next (1, 7) |> uint8
            v314 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v315 : uint8 = System.Random().Next (1, 7) |> uint8
            v315 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v310 <- Some x
            let v316 : uint8 = _v310.Value
            let v317 : uint8 option = None
            let mutable _v317 = v317
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v318 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v318 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v319 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v319 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v320 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v320 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v321 : uint8 = System.Random().Next (1, 7) |> uint8
            v321 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v322 : uint8 = System.Random().Next (1, 7) |> uint8
            v322 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v317 <- Some x
            let v323 : uint8 = _v317.Value
            let v324 : uint8 option = None
            let mutable _v324 = v324
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v325 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v325 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v326 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v326 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v327 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v327 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v328 : uint8 = System.Random().Next (1, 7) |> uint8
            v328 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v329 : uint8 = System.Random().Next (1, 7) |> uint8
            v329 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v324 <- Some x
            let v330 : uint8 = _v324.Value
            let v331 : uint8 option = None
            let mutable _v331 = v331
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v332 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v332 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v333 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v333 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v334 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v334 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v335 : uint8 = System.Random().Next (1, 7) |> uint8
            v335 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v336 : uint8 = System.Random().Next (1, 7) |> uint8
            v336 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v331 <- Some x
            let v337 : uint8 = _v331.Value
            let v338 : uint8 option = None
            let mutable _v338 = v338
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v339 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v339 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v340 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v340 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v341 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v341 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v342 : uint8 = System.Random().Next (1, 7) |> uint8
            v342 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v343 : uint8 = System.Random().Next (1, 7) |> uint8
            v343 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v338 <- Some x
            let v344 : uint8 = _v338.Value
            let v345 : uint8 option = None
            let mutable _v345 = v345
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v346 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v346 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v347 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v347 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v348 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v348 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v349 : uint8 = System.Random().Next (1, 7) |> uint8
            v349 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v350 : uint8 = System.Random().Next (1, 7) |> uint8
            v350 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v345 <- Some x
            let v351 : uint8 = _v345.Value
            let v352 : uint8 option = None
            let mutable _v352 = v352
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v353 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v353 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v354 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v354 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v355 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v355 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v356 : uint8 = System.Random().Next (1, 7) |> uint8
            v356 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v357 : uint8 = System.Random().Next (1, 7) |> uint8
            v357 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v352 <- Some x
            let v358 : uint8 = _v352.Value
            let v359 : uint8 option = None
            let mutable _v359 = v359
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v360 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v360 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v361 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v361 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v362 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v362 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v363 : uint8 = System.Random().Next (1, 7) |> uint8
            v363 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v364 : uint8 = System.Random().Next (1, 7) |> uint8
            v364 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v359 <- Some x
            let v365 : uint8 = _v359.Value
            let v366 : uint8 option = None
            let mutable _v366 = v366
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v367 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v367 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v368 : uint8 = Fable.Core.RustInterop.emitRustExpr () v211
            v368 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v369 : uint8 = Fable.Core.RustInterop.emitRustExpr () v214
            v369 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v370 : uint8 = System.Random().Next (1, 7) |> uint8
            v370 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v371 : uint8 = System.Random().Next (1, 7) |> uint8
            v371 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            Unchecked.defaultof<uint8>
            #endif
            |> fun x -> _v366 <- Some x
            let v372 : uint8 = _v366.Value
            let v373 : UH1 = UH1_0
            let v374 : UH1 = UH1_1(v372, v373)
            let v375 : UH1 = UH1_1(v365, v374)
            let v376 : UH1 = UH1_1(v358, v375)
            let v377 : UH1 = UH1_1(v351, v376)
            let v378 : UH1 = UH1_1(v344, v377)
            let v379 : UH1 = UH1_1(v337, v378)
            let v380 : UH1 = UH1_1(v330, v379)
            let v381 : UH1 = UH1_1(v323, v380)
            let v382 : UH1 = UH1_1(v316, v381)
            let v383 : UH1 = UH1_1(v309, v382)
            let v384 : UH1 = UH1_1(v302, v383)
            let v385 : UH1 = UH1_1(v295, v384)
            let v386 : UH1 = UH1_1(v288, v385)
            let v387 : UH1 = UH1_1(v281, v386)
            let v388 : UH1 = UH1_1(v274, v387)
            let v389 : UH1 = UH1_1(v267, v388)
            let v390 : UH1 = UH1_1(v260, v389)
            let v391 : UH1 = UH1_1(v253, v390)
            let v392 : UH1 = UH1_1(v246, v391)
            let v393 : UH1 = UH1_1(v239, v392)
            let v394 : UH1 = UH1_1(v232, v393)
            let v395 : UH1 = UH1_1(v225, v394)
            let v396 : UH1 = UH1_1(v218, v395)
            let v397 : int8 = 23y
            method15(v396, v397)
and closure81 () (v0 : (string [])) : int32 =
    let v1 : string = $"calculate_dice_count / max: {9223372036854775807L} / n: {24y} / p: {4738381338321616896L}"
    System.Console.WriteLine v1
    let v2 : UH1 = UH1_0
    let v3 : int8 = 0y
    let v4 : int64 = method15(v2, v3)
    let v5 : string = $"result: {v4}"
    System.Console.WriteLine v5
    0
let v0 : (int64 -> (UH0 -> UH0)) = closure0()
let rotate_numbers x = v0 x
let v1 : ((string -> unit) option -> (UH1 -> (unit -> uint8))) = closure3()
let create_sequential_roller x = v1 x
let v2 : ((string -> unit) option -> ((unit -> uint8) -> (bool -> (uint64 -> uint64)))) = closure10()
let roll_progressively x = v2 x
let v3 : ((string -> unit) option -> (uint64 -> (UH1 -> uint64 option))) = closure78()
let roll_within_bounds x = v3 x
let v4 : ((string []) -> int32) = closure81()
let main args = v4 args
()
