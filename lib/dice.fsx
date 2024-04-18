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
        let v4 : bool = true in let mutable _v3 = v3
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
        let v6 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5
        v6
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v7 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5
        v7
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v8 : string = "1"
        let v9 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8
        v9
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v10 : uint8 = System.Random().Next (1, 7) |> uint8
        v10
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v11 : uint8 = System.Random().Next (1, 7) |> uint8
        v11
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v12 : uint8 = Unchecked.defaultof<uint8>
        v12
#endif
        |> fun x -> _v3 <- Some x
        let v13 : uint8 = _v3.Value
        let v14 : UH1 = UH1_1(v13, v0)
        let v15 : int8 = v1 + 1y
        method15(v14, v15)
    else
        let v17 : int64 = 0L
        let v18 : US5 = method16(v0, v17)
        match v18 with
        | US5_0(v19, v20) -> (* Some *)
            let v21 : bool = v19 <= 9223372036854775807L
            if v21 then
                v19
            else
                let v22 : uint8 option = None
                let v23 : bool = true in let mutable _v22 = v22
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v24 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v25 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v25
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v26 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v26
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v27 : string = "1"
                let v28 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v28
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v29 : uint8 = System.Random().Next (1, 7) |> uint8
                v29
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v30 : uint8 = System.Random().Next (1, 7) |> uint8
                v30
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v31 : uint8 = Unchecked.defaultof<uint8>
                v31
#endif
                |> fun x -> _v22 <- Some x
                let v32 : uint8 = _v22.Value
                let v33 : uint8 option = None
                let v34 : bool = true in let mutable _v33 = v33
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v35 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v35
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v36 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v36
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v37 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v37
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v38 : uint8 = System.Random().Next (1, 7) |> uint8
                v38
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v39 : uint8 = System.Random().Next (1, 7) |> uint8
                v39
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v40 : uint8 = Unchecked.defaultof<uint8>
                v40
#endif
                |> fun x -> _v33 <- Some x
                let v41 : uint8 = _v33.Value
                let v42 : uint8 option = None
                let v43 : bool = true in let mutable _v42 = v42
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v44 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v44
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v45 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v45
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v46 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
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
                let v49 : uint8 = Unchecked.defaultof<uint8>
                v49
#endif
                |> fun x -> _v42 <- Some x
                let v50 : uint8 = _v42.Value
                let v51 : uint8 option = None
                let v52 : bool = true in let mutable _v51 = v51
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v53 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v53
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v54 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v54
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v55 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v55
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v56 : uint8 = System.Random().Next (1, 7) |> uint8
                v56
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v57 : uint8 = System.Random().Next (1, 7) |> uint8
                v57
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v58 : uint8 = Unchecked.defaultof<uint8>
                v58
#endif
                |> fun x -> _v51 <- Some x
                let v59 : uint8 = _v51.Value
                let v60 : uint8 option = None
                let v61 : bool = true in let mutable _v60 = v60
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v62 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v62
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v63 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v63
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v64 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v64
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v65 : uint8 = System.Random().Next (1, 7) |> uint8
                v65
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v66 : uint8 = System.Random().Next (1, 7) |> uint8
                v66
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v67 : uint8 = Unchecked.defaultof<uint8>
                v67
#endif
                |> fun x -> _v60 <- Some x
                let v68 : uint8 = _v60.Value
                let v69 : uint8 option = None
                let v70 : bool = true in let mutable _v69 = v69
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v71 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v71
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v72 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v72
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v73 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v73
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v74 : uint8 = System.Random().Next (1, 7) |> uint8
                v74
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v75 : uint8 = System.Random().Next (1, 7) |> uint8
                v75
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v76 : uint8 = Unchecked.defaultof<uint8>
                v76
#endif
                |> fun x -> _v69 <- Some x
                let v77 : uint8 = _v69.Value
                let v78 : uint8 option = None
                let v79 : bool = true in let mutable _v78 = v78
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v80 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v80
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v81 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v81
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v82 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v82
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v83 : uint8 = System.Random().Next (1, 7) |> uint8
                v83
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v84 : uint8 = System.Random().Next (1, 7) |> uint8
                v84
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v85 : uint8 = Unchecked.defaultof<uint8>
                v85
#endif
                |> fun x -> _v78 <- Some x
                let v86 : uint8 = _v78.Value
                let v87 : uint8 option = None
                let v88 : bool = true in let mutable _v87 = v87
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v89 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v89
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v90 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v90
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v91 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v91
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v92 : uint8 = System.Random().Next (1, 7) |> uint8
                v92
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v93 : uint8 = System.Random().Next (1, 7) |> uint8
                v93
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v94 : uint8 = Unchecked.defaultof<uint8>
                v94
#endif
                |> fun x -> _v87 <- Some x
                let v95 : uint8 = _v87.Value
                let v96 : uint8 option = None
                let v97 : bool = true in let mutable _v96 = v96
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v98 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v98
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v99 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v99
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v100 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v100
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v101 : uint8 = System.Random().Next (1, 7) |> uint8
                v101
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v102 : uint8 = System.Random().Next (1, 7) |> uint8
                v102
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v103 : uint8 = Unchecked.defaultof<uint8>
                v103
#endif
                |> fun x -> _v96 <- Some x
                let v104 : uint8 = _v96.Value
                let v105 : uint8 option = None
                let v106 : bool = true in let mutable _v105 = v105
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v107 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v107
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v108 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v108
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v109 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
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
                let v112 : uint8 = Unchecked.defaultof<uint8>
                v112
#endif
                |> fun x -> _v105 <- Some x
                let v113 : uint8 = _v105.Value
                let v114 : uint8 option = None
                let v115 : bool = true in let mutable _v114 = v114
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v116 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v116
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v117 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v117
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v118 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v118
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v119 : uint8 = System.Random().Next (1, 7) |> uint8
                v119
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v120 : uint8 = System.Random().Next (1, 7) |> uint8
                v120
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v121 : uint8 = Unchecked.defaultof<uint8>
                v121
#endif
                |> fun x -> _v114 <- Some x
                let v122 : uint8 = _v114.Value
                let v123 : uint8 option = None
                let v124 : bool = true in let mutable _v123 = v123
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v125 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v125
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v126 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v126
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v127 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v127
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v128 : uint8 = System.Random().Next (1, 7) |> uint8
                v128
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v129 : uint8 = System.Random().Next (1, 7) |> uint8
                v129
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v130 : uint8 = Unchecked.defaultof<uint8>
                v130
#endif
                |> fun x -> _v123 <- Some x
                let v131 : uint8 = _v123.Value
                let v132 : uint8 option = None
                let v133 : bool = true in let mutable _v132 = v132
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v134 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v134
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v135 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v135
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v136 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v136
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v137 : uint8 = System.Random().Next (1, 7) |> uint8
                v137
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v138 : uint8 = System.Random().Next (1, 7) |> uint8
                v138
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v139 : uint8 = Unchecked.defaultof<uint8>
                v139
#endif
                |> fun x -> _v132 <- Some x
                let v140 : uint8 = _v132.Value
                let v141 : uint8 option = None
                let v142 : bool = true in let mutable _v141 = v141
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v143 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v143
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v144 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v144
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v145 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v145
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v146 : uint8 = System.Random().Next (1, 7) |> uint8
                v146
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v147 : uint8 = System.Random().Next (1, 7) |> uint8
                v147
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v148 : uint8 = Unchecked.defaultof<uint8>
                v148
#endif
                |> fun x -> _v141 <- Some x
                let v149 : uint8 = _v141.Value
                let v150 : uint8 option = None
                let v151 : bool = true in let mutable _v150 = v150
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v152 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v152
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v153 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v153
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v154 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v154
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v155 : uint8 = System.Random().Next (1, 7) |> uint8
                v155
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v156 : uint8 = System.Random().Next (1, 7) |> uint8
                v156
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v157 : uint8 = Unchecked.defaultof<uint8>
                v157
#endif
                |> fun x -> _v150 <- Some x
                let v158 : uint8 = _v150.Value
                let v159 : uint8 option = None
                let v160 : bool = true in let mutable _v159 = v159
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v161 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v161
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v162 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v162
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v163 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v163
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v164 : uint8 = System.Random().Next (1, 7) |> uint8
                v164
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v165 : uint8 = System.Random().Next (1, 7) |> uint8
                v165
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v166 : uint8 = Unchecked.defaultof<uint8>
                v166
#endif
                |> fun x -> _v159 <- Some x
                let v167 : uint8 = _v159.Value
                let v168 : uint8 option = None
                let v169 : bool = true in let mutable _v168 = v168
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v170 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v170
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v171 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v171
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v172 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
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
                let v175 : uint8 = Unchecked.defaultof<uint8>
                v175
#endif
                |> fun x -> _v168 <- Some x
                let v176 : uint8 = _v168.Value
                let v177 : uint8 option = None
                let v178 : bool = true in let mutable _v177 = v177
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v179 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v179
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v180 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v180
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v181 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v181
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v182 : uint8 = System.Random().Next (1, 7) |> uint8
                v182
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v183 : uint8 = System.Random().Next (1, 7) |> uint8
                v183
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v184 : uint8 = Unchecked.defaultof<uint8>
                v184
#endif
                |> fun x -> _v177 <- Some x
                let v185 : uint8 = _v177.Value
                let v186 : uint8 option = None
                let v187 : bool = true in let mutable _v186 = v186
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v188 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v188
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v189 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v189
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v190 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v190
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v191 : uint8 = System.Random().Next (1, 7) |> uint8
                v191
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v192 : uint8 = System.Random().Next (1, 7) |> uint8
                v192
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v193 : uint8 = Unchecked.defaultof<uint8>
                v193
#endif
                |> fun x -> _v186 <- Some x
                let v194 : uint8 = _v186.Value
                let v195 : uint8 option = None
                let v196 : bool = true in let mutable _v195 = v195
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v197 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v197
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v198 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v198
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v199 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v199
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v200 : uint8 = System.Random().Next (1, 7) |> uint8
                v200
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v201 : uint8 = System.Random().Next (1, 7) |> uint8
                v201
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v202 : uint8 = Unchecked.defaultof<uint8>
                v202
#endif
                |> fun x -> _v195 <- Some x
                let v203 : uint8 = _v195.Value
                let v204 : uint8 option = None
                let v205 : bool = true in let mutable _v204 = v204
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v206 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v206
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v207 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v207
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v208 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v208
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v209 : uint8 = System.Random().Next (1, 7) |> uint8
                v209
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v210 : uint8 = System.Random().Next (1, 7) |> uint8
                v210
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v211 : uint8 = Unchecked.defaultof<uint8>
                v211
#endif
                |> fun x -> _v204 <- Some x
                let v212 : uint8 = _v204.Value
                let v213 : uint8 option = None
                let v214 : bool = true in let mutable _v213 = v213
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v215 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v215
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v216 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v216
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v217 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v217
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v218 : uint8 = System.Random().Next (1, 7) |> uint8
                v218
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v219 : uint8 = System.Random().Next (1, 7) |> uint8
                v219
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v220 : uint8 = Unchecked.defaultof<uint8>
                v220
#endif
                |> fun x -> _v213 <- Some x
                let v221 : uint8 = _v213.Value
                let v222 : uint8 option = None
                let v223 : bool = true in let mutable _v222 = v222
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v224 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v224
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v225 : uint8 = Fable.Core.RustInterop.emitRustExpr () v24
                v225
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v226 : uint8 = Fable.Core.RustInterop.emitRustExpr () v27
                v226
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v227 : uint8 = System.Random().Next (1, 7) |> uint8
                v227
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v228 : uint8 = System.Random().Next (1, 7) |> uint8
                v228
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v229 : uint8 = Unchecked.defaultof<uint8>
                v229
#endif
                |> fun x -> _v222 <- Some x
                let v230 : uint8 = _v222.Value
                let v231 : UH1 = UH1_0
                let v232 : UH1 = UH1_1(v230, v231)
                let v233 : UH1 = UH1_1(v221, v232)
                let v234 : UH1 = UH1_1(v212, v233)
                let v235 : UH1 = UH1_1(v203, v234)
                let v236 : UH1 = UH1_1(v194, v235)
                let v237 : UH1 = UH1_1(v185, v236)
                let v238 : UH1 = UH1_1(v176, v237)
                let v239 : UH1 = UH1_1(v167, v238)
                let v240 : UH1 = UH1_1(v158, v239)
                let v241 : UH1 = UH1_1(v149, v240)
                let v242 : UH1 = UH1_1(v140, v241)
                let v243 : UH1 = UH1_1(v131, v242)
                let v244 : UH1 = UH1_1(v122, v243)
                let v245 : UH1 = UH1_1(v113, v244)
                let v246 : UH1 = UH1_1(v104, v245)
                let v247 : UH1 = UH1_1(v95, v246)
                let v248 : UH1 = UH1_1(v86, v247)
                let v249 : UH1 = UH1_1(v77, v248)
                let v250 : UH1 = UH1_1(v68, v249)
                let v251 : UH1 = UH1_1(v59, v250)
                let v252 : UH1 = UH1_1(v50, v251)
                let v253 : UH1 = UH1_1(v41, v252)
                let v254 : UH1 = UH1_1(v32, v253)
                let v255 : int8 = 23y
                method15(v254, v255)
        | _ ->
            let v258 : uint8 option = None
            let v259 : bool = true in let mutable _v258 = v258
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v260 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v261 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v261
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v262 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v262
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v263 : string = "1"
            let v264 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
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
            let v267 : uint8 = Unchecked.defaultof<uint8>
            v267
#endif
            |> fun x -> _v258 <- Some x
            let v268 : uint8 = _v258.Value
            let v269 : uint8 option = None
            let v270 : bool = true in let mutable _v269 = v269
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v271 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v271
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v272 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v272
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v273 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v273
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v274 : uint8 = System.Random().Next (1, 7) |> uint8
            v274
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v275 : uint8 = System.Random().Next (1, 7) |> uint8
            v275
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v276 : uint8 = Unchecked.defaultof<uint8>
            v276
#endif
            |> fun x -> _v269 <- Some x
            let v277 : uint8 = _v269.Value
            let v278 : uint8 option = None
            let v279 : bool = true in let mutable _v278 = v278
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v280 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v280
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v281 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v281
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v282 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v282
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v283 : uint8 = System.Random().Next (1, 7) |> uint8
            v283
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v284 : uint8 = System.Random().Next (1, 7) |> uint8
            v284
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v285 : uint8 = Unchecked.defaultof<uint8>
            v285
#endif
            |> fun x -> _v278 <- Some x
            let v286 : uint8 = _v278.Value
            let v287 : uint8 option = None
            let v288 : bool = true in let mutable _v287 = v287
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v289 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v289
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v290 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v290
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v291 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v291
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v292 : uint8 = System.Random().Next (1, 7) |> uint8
            v292
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v293 : uint8 = System.Random().Next (1, 7) |> uint8
            v293
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v294 : uint8 = Unchecked.defaultof<uint8>
            v294
#endif
            |> fun x -> _v287 <- Some x
            let v295 : uint8 = _v287.Value
            let v296 : uint8 option = None
            let v297 : bool = true in let mutable _v296 = v296
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v298 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v298
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v299 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v299
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v300 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v300
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v301 : uint8 = System.Random().Next (1, 7) |> uint8
            v301
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v302 : uint8 = System.Random().Next (1, 7) |> uint8
            v302
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v303 : uint8 = Unchecked.defaultof<uint8>
            v303
#endif
            |> fun x -> _v296 <- Some x
            let v304 : uint8 = _v296.Value
            let v305 : uint8 option = None
            let v306 : bool = true in let mutable _v305 = v305
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v307 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v307
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v308 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v308
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v309 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v309
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v310 : uint8 = System.Random().Next (1, 7) |> uint8
            v310
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v311 : uint8 = System.Random().Next (1, 7) |> uint8
            v311
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v312 : uint8 = Unchecked.defaultof<uint8>
            v312
#endif
            |> fun x -> _v305 <- Some x
            let v313 : uint8 = _v305.Value
            let v314 : uint8 option = None
            let v315 : bool = true in let mutable _v314 = v314
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v316 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v316
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v317 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v317
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v318 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v318
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v319 : uint8 = System.Random().Next (1, 7) |> uint8
            v319
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v320 : uint8 = System.Random().Next (1, 7) |> uint8
            v320
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v321 : uint8 = Unchecked.defaultof<uint8>
            v321
#endif
            |> fun x -> _v314 <- Some x
            let v322 : uint8 = _v314.Value
            let v323 : uint8 option = None
            let v324 : bool = true in let mutable _v323 = v323
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v325 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v325
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v326 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v326
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v327 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
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
            let v330 : uint8 = Unchecked.defaultof<uint8>
            v330
#endif
            |> fun x -> _v323 <- Some x
            let v331 : uint8 = _v323.Value
            let v332 : uint8 option = None
            let v333 : bool = true in let mutable _v332 = v332
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v334 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v334
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v335 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v335
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v336 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v336
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v337 : uint8 = System.Random().Next (1, 7) |> uint8
            v337
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v338 : uint8 = System.Random().Next (1, 7) |> uint8
            v338
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v339 : uint8 = Unchecked.defaultof<uint8>
            v339
#endif
            |> fun x -> _v332 <- Some x
            let v340 : uint8 = _v332.Value
            let v341 : uint8 option = None
            let v342 : bool = true in let mutable _v341 = v341
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v343 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v343
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v344 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v344
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v345 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v345
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v346 : uint8 = System.Random().Next (1, 7) |> uint8
            v346
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v347 : uint8 = System.Random().Next (1, 7) |> uint8
            v347
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v348 : uint8 = Unchecked.defaultof<uint8>
            v348
#endif
            |> fun x -> _v341 <- Some x
            let v349 : uint8 = _v341.Value
            let v350 : uint8 option = None
            let v351 : bool = true in let mutable _v350 = v350
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v352
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v353 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v353
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v354 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v354
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v355 : uint8 = System.Random().Next (1, 7) |> uint8
            v355
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v356 : uint8 = System.Random().Next (1, 7) |> uint8
            v356
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v357 : uint8 = Unchecked.defaultof<uint8>
            v357
#endif
            |> fun x -> _v350 <- Some x
            let v358 : uint8 = _v350.Value
            let v359 : uint8 option = None
            let v360 : bool = true in let mutable _v359 = v359
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v361 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v361
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v362 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v362
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v363 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v363
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v364 : uint8 = System.Random().Next (1, 7) |> uint8
            v364
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v365 : uint8 = System.Random().Next (1, 7) |> uint8
            v365
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v366 : uint8 = Unchecked.defaultof<uint8>
            v366
#endif
            |> fun x -> _v359 <- Some x
            let v367 : uint8 = _v359.Value
            let v368 : uint8 option = None
            let v369 : bool = true in let mutable _v368 = v368
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v370 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v370
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v371 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v371
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v372 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v372
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v373 : uint8 = System.Random().Next (1, 7) |> uint8
            v373
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v374 : uint8 = System.Random().Next (1, 7) |> uint8
            v374
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v375 : uint8 = Unchecked.defaultof<uint8>
            v375
#endif
            |> fun x -> _v368 <- Some x
            let v376 : uint8 = _v368.Value
            let v377 : uint8 option = None
            let v378 : bool = true in let mutable _v377 = v377
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v379 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v379
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v380 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v380
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v381 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v381
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v382 : uint8 = System.Random().Next (1, 7) |> uint8
            v382
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v383 : uint8 = System.Random().Next (1, 7) |> uint8
            v383
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v384 : uint8 = Unchecked.defaultof<uint8>
            v384
#endif
            |> fun x -> _v377 <- Some x
            let v385 : uint8 = _v377.Value
            let v386 : uint8 option = None
            let v387 : bool = true in let mutable _v386 = v386
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v388 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v388
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v389 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v389
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v390 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v390
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v391 : uint8 = System.Random().Next (1, 7) |> uint8
            v391
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v392 : uint8 = System.Random().Next (1, 7) |> uint8
            v392
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v393 : uint8 = Unchecked.defaultof<uint8>
            v393
#endif
            |> fun x -> _v386 <- Some x
            let v394 : uint8 = _v386.Value
            let v395 : uint8 option = None
            let v396 : bool = true in let mutable _v395 = v395
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v397 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v397
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v398 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v398
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v399 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v399
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v400 : uint8 = System.Random().Next (1, 7) |> uint8
            v400
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v401 : uint8 = System.Random().Next (1, 7) |> uint8
            v401
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v402 : uint8 = Unchecked.defaultof<uint8>
            v402
#endif
            |> fun x -> _v395 <- Some x
            let v403 : uint8 = _v395.Value
            let v404 : uint8 option = None
            let v405 : bool = true in let mutable _v404 = v404
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v406 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v406
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v407 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v407
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v408 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v408
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v409 : uint8 = System.Random().Next (1, 7) |> uint8
            v409
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v410 : uint8 = System.Random().Next (1, 7) |> uint8
            v410
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v411 : uint8 = Unchecked.defaultof<uint8>
            v411
#endif
            |> fun x -> _v404 <- Some x
            let v412 : uint8 = _v404.Value
            let v413 : uint8 option = None
            let v414 : bool = true in let mutable _v413 = v413
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v415 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v415
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v416 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v416
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v417 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v417
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v418 : uint8 = System.Random().Next (1, 7) |> uint8
            v418
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v419 : uint8 = System.Random().Next (1, 7) |> uint8
            v419
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v420 : uint8 = Unchecked.defaultof<uint8>
            v420
#endif
            |> fun x -> _v413 <- Some x
            let v421 : uint8 = _v413.Value
            let v422 : uint8 option = None
            let v423 : bool = true in let mutable _v422 = v422
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v424 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v424
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v425 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v425
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v426 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v426
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v427 : uint8 = System.Random().Next (1, 7) |> uint8
            v427
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v428 : uint8 = System.Random().Next (1, 7) |> uint8
            v428
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v429 : uint8 = Unchecked.defaultof<uint8>
            v429
#endif
            |> fun x -> _v422 <- Some x
            let v430 : uint8 = _v422.Value
            let v431 : uint8 option = None
            let v432 : bool = true in let mutable _v431 = v431
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v433 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v433
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v434 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v434
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v435 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v435
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v436 : uint8 = System.Random().Next (1, 7) |> uint8
            v436
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v437 : uint8 = System.Random().Next (1, 7) |> uint8
            v437
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v438 : uint8 = Unchecked.defaultof<uint8>
            v438
#endif
            |> fun x -> _v431 <- Some x
            let v439 : uint8 = _v431.Value
            let v440 : uint8 option = None
            let v441 : bool = true in let mutable _v440 = v440
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v442 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v442
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v443 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v443
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v444 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v444
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v445 : uint8 = System.Random().Next (1, 7) |> uint8
            v445
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v446 : uint8 = System.Random().Next (1, 7) |> uint8
            v446
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v447 : uint8 = Unchecked.defaultof<uint8>
            v447
#endif
            |> fun x -> _v440 <- Some x
            let v448 : uint8 = _v440.Value
            let v449 : uint8 option = None
            let v450 : bool = true in let mutable _v449 = v449
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v451 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v451
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v452 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v452
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v453 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v453
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v454 : uint8 = System.Random().Next (1, 7) |> uint8
            v454
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v455 : uint8 = System.Random().Next (1, 7) |> uint8
            v455
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v456 : uint8 = Unchecked.defaultof<uint8>
            v456
#endif
            |> fun x -> _v449 <- Some x
            let v457 : uint8 = _v449.Value
            let v458 : uint8 option = None
            let v459 : bool = true in let mutable _v458 = v458
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v460 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v460
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v461 : uint8 = Fable.Core.RustInterop.emitRustExpr () v260
            v461
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v462 : uint8 = Fable.Core.RustInterop.emitRustExpr () v263
            v462
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v463 : uint8 = System.Random().Next (1, 7) |> uint8
            v463
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v464 : uint8 = System.Random().Next (1, 7) |> uint8
            v464
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v465 : uint8 = Unchecked.defaultof<uint8>
            v465
#endif
            |> fun x -> _v458 <- Some x
            let v466 : uint8 = _v458.Value
            let v467 : UH1 = UH1_0
            let v468 : UH1 = UH1_1(v466, v467)
            let v469 : UH1 = UH1_1(v457, v468)
            let v470 : UH1 = UH1_1(v448, v469)
            let v471 : UH1 = UH1_1(v439, v470)
            let v472 : UH1 = UH1_1(v430, v471)
            let v473 : UH1 = UH1_1(v421, v472)
            let v474 : UH1 = UH1_1(v412, v473)
            let v475 : UH1 = UH1_1(v403, v474)
            let v476 : UH1 = UH1_1(v394, v475)
            let v477 : UH1 = UH1_1(v385, v476)
            let v478 : UH1 = UH1_1(v376, v477)
            let v479 : UH1 = UH1_1(v367, v478)
            let v480 : UH1 = UH1_1(v358, v479)
            let v481 : UH1 = UH1_1(v349, v480)
            let v482 : UH1 = UH1_1(v340, v481)
            let v483 : UH1 = UH1_1(v331, v482)
            let v484 : UH1 = UH1_1(v322, v483)
            let v485 : UH1 = UH1_1(v313, v484)
            let v486 : UH1 = UH1_1(v304, v485)
            let v487 : UH1 = UH1_1(v295, v486)
            let v488 : UH1 = UH1_1(v286, v487)
            let v489 : UH1 = UH1_1(v277, v488)
            let v490 : UH1 = UH1_1(v268, v489)
            let v491 : int8 = 23y
            method15(v490, v491)
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
