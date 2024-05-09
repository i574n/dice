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
    System.Console.WriteLine v3
    US5_0(v2, v0)
and method38 (v0 : UH1, v1 : int64) : US5 =
    match v0 with
    | UH1_1(v3, v4) -> (* Cons *)
        let v5 : bool = v3 > 1uy
        if v5 then
            let v6 : uint8 = v3 - 1uy
            let v7 : int64 = int64 v6
            let v8 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3} / value: {v7}"
            System.Console.WriteLine v8
            let v9 : int64 = v1 + v7
            method39(v4, v9)
        else
            let v11 : string = $"accumulate_dice_rolls / power: {0y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v11
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method38(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {1y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 36L
            let v9 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method37(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {2y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 216L
            let v9 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method36(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {3y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 1296L
            let v9 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method35(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {4y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 7776L
            let v9 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method34(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {5y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 46656L
            let v9 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method33(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {6y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 279936L
            let v9 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method32(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {7y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 1679616L
            let v9 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method31(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {8y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 10077696L
            let v9 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method30(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {9y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 60466176L
            let v9 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method29(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {10y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 362797056L
            let v9 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method28(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {11y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 2176782336L
            let v9 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method27(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {12y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 13060694016L
            let v9 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method26(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {13y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 78364164096L
            let v9 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method25(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {14y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 470184984576L
            let v9 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method24(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {15y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 2821109907456L
            let v9 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method23(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {16y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 16926659444736L
            let v9 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method22(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {17y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 101559956668416L
            let v9 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method21(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {18y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 609359740010496L
            let v9 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method20(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {19y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 3656158440062976L
            let v9 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method19(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {20y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 21936950640377856L
            let v9 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method18(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {21y} / acc: {v1} / roll: {v3}"
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
            let v8 : int64 = v7 * 131621703842267136L
            let v9 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3} / value: {v8}"
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method17(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {22y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
            System.Console.WriteLine v9
            let v10 : int64 = v1 + v8
            method16(v4, v10)
        else
            let v12 : string = $"accumulate_dice_rolls / power: {23y} / acc: {v1} / roll: {v3}"
            System.Console.WriteLine v12
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
        let v6 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4
        v6 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v7 : string = "1"
        let v8 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7
        v8 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v9 : uint8 = System.Random().Next (1, 7) |> uint8
        v9 
        #endif
#if FABLE_COMPILER_PYTHON
        let v10 : uint8 = System.Random().Next (1, 7) |> uint8
        v10 
        #endif
#else
        let v11 : uint8 = System.Random().Next (1, 7) |> uint8
        v11 
        #endif
        |> fun x -> _v3 <- Some x
        let v12 : uint8 = _v3.Value
        let v13 : UH1 = UH1_1(v12, v0)
        let v14 : int8 = v1 + 1y
        method14(v13, v14)
    else
        let v16 : int64 = 0L
        let v17 : US5 = method15(v0, v16)
        match v17 with
        | US5_0(v18, v19) -> (* Some *)
            let v20 : bool = v18 <= 9223372036854775807L
            if v20 then
                v18
            else
                let v21 : bool = true
                let mutable _v21 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v22 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
                let v23 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v23 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v24 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v24 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v25 : string = "1"
                let v26 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v26 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v27 : uint8 = System.Random().Next (1, 7) |> uint8
                v27 
                #endif
#if FABLE_COMPILER_PYTHON
                let v28 : uint8 = System.Random().Next (1, 7) |> uint8
                v28 
                #endif
#else
                let v29 : uint8 = System.Random().Next (1, 7) |> uint8
                v29 
                #endif
                |> fun x -> _v21 <- Some x
                let v30 : uint8 = _v21.Value
                let v31 : bool = true
                let mutable _v31 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v32 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v32 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v33 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v33 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v34 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v34 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v35 : uint8 = System.Random().Next (1, 7) |> uint8
                v35 
                #endif
#if FABLE_COMPILER_PYTHON
                let v36 : uint8 = System.Random().Next (1, 7) |> uint8
                v36 
                #endif
#else
                let v37 : uint8 = System.Random().Next (1, 7) |> uint8
                v37 
                #endif
                |> fun x -> _v31 <- Some x
                let v38 : uint8 = _v31.Value
                let v39 : bool = true
                let mutable _v39 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v40 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v40 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v41 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v41 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v42 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v42 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v43 : uint8 = System.Random().Next (1, 7) |> uint8
                v43 
                #endif
#if FABLE_COMPILER_PYTHON
                let v44 : uint8 = System.Random().Next (1, 7) |> uint8
                v44 
                #endif
#else
                let v45 : uint8 = System.Random().Next (1, 7) |> uint8
                v45 
                #endif
                |> fun x -> _v39 <- Some x
                let v46 : uint8 = _v39.Value
                let v47 : bool = true
                let mutable _v47 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v48 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v48 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v49 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v49 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v50 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
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
                |> fun x -> _v47 <- Some x
                let v54 : uint8 = _v47.Value
                let v55 : bool = true
                let mutable _v55 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v56 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v56 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v57 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v57 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v58 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v58 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v59 : uint8 = System.Random().Next (1, 7) |> uint8
                v59 
                #endif
#if FABLE_COMPILER_PYTHON
                let v60 : uint8 = System.Random().Next (1, 7) |> uint8
                v60 
                #endif
#else
                let v61 : uint8 = System.Random().Next (1, 7) |> uint8
                v61 
                #endif
                |> fun x -> _v55 <- Some x
                let v62 : uint8 = _v55.Value
                let v63 : bool = true
                let mutable _v63 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v64 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v64 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v65 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v65 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v66 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v66 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v67 : uint8 = System.Random().Next (1, 7) |> uint8
                v67 
                #endif
#if FABLE_COMPILER_PYTHON
                let v68 : uint8 = System.Random().Next (1, 7) |> uint8
                v68 
                #endif
#else
                let v69 : uint8 = System.Random().Next (1, 7) |> uint8
                v69 
                #endif
                |> fun x -> _v63 <- Some x
                let v70 : uint8 = _v63.Value
                let v71 : bool = true
                let mutable _v71 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v72 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v72 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v73 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v73 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v74 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v74 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v75 : uint8 = System.Random().Next (1, 7) |> uint8
                v75 
                #endif
#if FABLE_COMPILER_PYTHON
                let v76 : uint8 = System.Random().Next (1, 7) |> uint8
                v76 
                #endif
#else
                let v77 : uint8 = System.Random().Next (1, 7) |> uint8
                v77 
                #endif
                |> fun x -> _v71 <- Some x
                let v78 : uint8 = _v71.Value
                let v79 : bool = true
                let mutable _v79 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v80 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v80 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v81 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v81 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v82 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v82 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v83 : uint8 = System.Random().Next (1, 7) |> uint8
                v83 
                #endif
#if FABLE_COMPILER_PYTHON
                let v84 : uint8 = System.Random().Next (1, 7) |> uint8
                v84 
                #endif
#else
                let v85 : uint8 = System.Random().Next (1, 7) |> uint8
                v85 
                #endif
                |> fun x -> _v79 <- Some x
                let v86 : uint8 = _v79.Value
                let v87 : bool = true
                let mutable _v87 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v88 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v88 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v89 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v89 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v90 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v90 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v91 : uint8 = System.Random().Next (1, 7) |> uint8
                v91 
                #endif
#if FABLE_COMPILER_PYTHON
                let v92 : uint8 = System.Random().Next (1, 7) |> uint8
                v92 
                #endif
#else
                let v93 : uint8 = System.Random().Next (1, 7) |> uint8
                v93 
                #endif
                |> fun x -> _v87 <- Some x
                let v94 : uint8 = _v87.Value
                let v95 : bool = true
                let mutable _v95 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v96 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v96 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v97 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v97 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v98 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v98 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v99 : uint8 = System.Random().Next (1, 7) |> uint8
                v99 
                #endif
#if FABLE_COMPILER_PYTHON
                let v100 : uint8 = System.Random().Next (1, 7) |> uint8
                v100 
                #endif
#else
                let v101 : uint8 = System.Random().Next (1, 7) |> uint8
                v101 
                #endif
                |> fun x -> _v95 <- Some x
                let v102 : uint8 = _v95.Value
                let v103 : bool = true
                let mutable _v103 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v104 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v104 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v105 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v105 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v106 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v106 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v107 : uint8 = System.Random().Next (1, 7) |> uint8
                v107 
                #endif
#if FABLE_COMPILER_PYTHON
                let v108 : uint8 = System.Random().Next (1, 7) |> uint8
                v108 
                #endif
#else
                let v109 : uint8 = System.Random().Next (1, 7) |> uint8
                v109 
                #endif
                |> fun x -> _v103 <- Some x
                let v110 : uint8 = _v103.Value
                let v111 : bool = true
                let mutable _v111 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v112 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v112 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v113 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v113 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v114 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v114 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v115 : uint8 = System.Random().Next (1, 7) |> uint8
                v115 
                #endif
#if FABLE_COMPILER_PYTHON
                let v116 : uint8 = System.Random().Next (1, 7) |> uint8
                v116 
                #endif
#else
                let v117 : uint8 = System.Random().Next (1, 7) |> uint8
                v117 
                #endif
                |> fun x -> _v111 <- Some x
                let v118 : uint8 = _v111.Value
                let v119 : bool = true
                let mutable _v119 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v120 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v120 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v121 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v121 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v122 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v122 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v123 : uint8 = System.Random().Next (1, 7) |> uint8
                v123 
                #endif
#if FABLE_COMPILER_PYTHON
                let v124 : uint8 = System.Random().Next (1, 7) |> uint8
                v124 
                #endif
#else
                let v125 : uint8 = System.Random().Next (1, 7) |> uint8
                v125 
                #endif
                |> fun x -> _v119 <- Some x
                let v126 : uint8 = _v119.Value
                let v127 : bool = true
                let mutable _v127 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v128 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v128 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v129 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v129 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v130 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v130 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v131 : uint8 = System.Random().Next (1, 7) |> uint8
                v131 
                #endif
#if FABLE_COMPILER_PYTHON
                let v132 : uint8 = System.Random().Next (1, 7) |> uint8
                v132 
                #endif
#else
                let v133 : uint8 = System.Random().Next (1, 7) |> uint8
                v133 
                #endif
                |> fun x -> _v127 <- Some x
                let v134 : uint8 = _v127.Value
                let v135 : bool = true
                let mutable _v135 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v136 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v136 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v137 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v137 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v138 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
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
                |> fun x -> _v135 <- Some x
                let v142 : uint8 = _v135.Value
                let v143 : bool = true
                let mutable _v143 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v144 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v144 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v145 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v145 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v146 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v146 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v147 : uint8 = System.Random().Next (1, 7) |> uint8
                v147 
                #endif
#if FABLE_COMPILER_PYTHON
                let v148 : uint8 = System.Random().Next (1, 7) |> uint8
                v148 
                #endif
#else
                let v149 : uint8 = System.Random().Next (1, 7) |> uint8
                v149 
                #endif
                |> fun x -> _v143 <- Some x
                let v150 : uint8 = _v143.Value
                let v151 : bool = true
                let mutable _v151 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v152 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v152 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v153 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v153 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v154 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v154 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v155 : uint8 = System.Random().Next (1, 7) |> uint8
                v155 
                #endif
#if FABLE_COMPILER_PYTHON
                let v156 : uint8 = System.Random().Next (1, 7) |> uint8
                v156 
                #endif
#else
                let v157 : uint8 = System.Random().Next (1, 7) |> uint8
                v157 
                #endif
                |> fun x -> _v151 <- Some x
                let v158 : uint8 = _v151.Value
                let v159 : bool = true
                let mutable _v159 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v160 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v160 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v161 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v161 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v162 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v162 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v163 : uint8 = System.Random().Next (1, 7) |> uint8
                v163 
                #endif
#if FABLE_COMPILER_PYTHON
                let v164 : uint8 = System.Random().Next (1, 7) |> uint8
                v164 
                #endif
#else
                let v165 : uint8 = System.Random().Next (1, 7) |> uint8
                v165 
                #endif
                |> fun x -> _v159 <- Some x
                let v166 : uint8 = _v159.Value
                let v167 : bool = true
                let mutable _v167 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v168 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v168 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v169 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v169 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v170 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v170 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v171 : uint8 = System.Random().Next (1, 7) |> uint8
                v171 
                #endif
#if FABLE_COMPILER_PYTHON
                let v172 : uint8 = System.Random().Next (1, 7) |> uint8
                v172 
                #endif
#else
                let v173 : uint8 = System.Random().Next (1, 7) |> uint8
                v173 
                #endif
                |> fun x -> _v167 <- Some x
                let v174 : uint8 = _v167.Value
                let v175 : bool = true
                let mutable _v175 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v176 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v176 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v177 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v177 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v178 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v178 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v179 : uint8 = System.Random().Next (1, 7) |> uint8
                v179 
                #endif
#if FABLE_COMPILER_PYTHON
                let v180 : uint8 = System.Random().Next (1, 7) |> uint8
                v180 
                #endif
#else
                let v181 : uint8 = System.Random().Next (1, 7) |> uint8
                v181 
                #endif
                |> fun x -> _v175 <- Some x
                let v182 : uint8 = _v175.Value
                let v183 : bool = true
                let mutable _v183 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v184 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v184 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v185 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v185 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v186 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v186 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v187 : uint8 = System.Random().Next (1, 7) |> uint8
                v187 
                #endif
#if FABLE_COMPILER_PYTHON
                let v188 : uint8 = System.Random().Next (1, 7) |> uint8
                v188 
                #endif
#else
                let v189 : uint8 = System.Random().Next (1, 7) |> uint8
                v189 
                #endif
                |> fun x -> _v183 <- Some x
                let v190 : uint8 = _v183.Value
                let v191 : bool = true
                let mutable _v191 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v192 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v192 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v193 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v193 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v194 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v194 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v195 : uint8 = System.Random().Next (1, 7) |> uint8
                v195 
                #endif
#if FABLE_COMPILER_PYTHON
                let v196 : uint8 = System.Random().Next (1, 7) |> uint8
                v196 
                #endif
#else
                let v197 : uint8 = System.Random().Next (1, 7) |> uint8
                v197 
                #endif
                |> fun x -> _v191 <- Some x
                let v198 : uint8 = _v191.Value
                let v199 : bool = true
                let mutable _v199 : uint8 option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v200 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v200 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v201 : uint8 = Fable.Core.RustInterop.emitRustExpr () v22
                v201 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v202 : uint8 = Fable.Core.RustInterop.emitRustExpr () v25
                v202 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v203 : uint8 = System.Random().Next (1, 7) |> uint8
                v203 
                #endif
#if FABLE_COMPILER_PYTHON
                let v204 : uint8 = System.Random().Next (1, 7) |> uint8
                v204 
                #endif
#else
                let v205 : uint8 = System.Random().Next (1, 7) |> uint8
                v205 
                #endif
                |> fun x -> _v199 <- Some x
                let v206 : uint8 = _v199.Value
                let v207 : UH1 = UH1_0
                let v208 : UH1 = UH1_1(v206, v207)
                let v209 : UH1 = UH1_1(v198, v208)
                let v210 : UH1 = UH1_1(v190, v209)
                let v211 : UH1 = UH1_1(v182, v210)
                let v212 : UH1 = UH1_1(v174, v211)
                let v213 : UH1 = UH1_1(v166, v212)
                let v214 : UH1 = UH1_1(v158, v213)
                let v215 : UH1 = UH1_1(v150, v214)
                let v216 : UH1 = UH1_1(v142, v215)
                let v217 : UH1 = UH1_1(v134, v216)
                let v218 : UH1 = UH1_1(v126, v217)
                let v219 : UH1 = UH1_1(v118, v218)
                let v220 : UH1 = UH1_1(v110, v219)
                let v221 : UH1 = UH1_1(v102, v220)
                let v222 : UH1 = UH1_1(v94, v221)
                let v223 : UH1 = UH1_1(v86, v222)
                let v224 : UH1 = UH1_1(v78, v223)
                let v225 : UH1 = UH1_1(v70, v224)
                let v226 : UH1 = UH1_1(v62, v225)
                let v227 : UH1 = UH1_1(v54, v226)
                let v228 : UH1 = UH1_1(v46, v227)
                let v229 : UH1 = UH1_1(v38, v228)
                let v230 : UH1 = UH1_1(v30, v229)
                let v231 : int8 = 23y
                method14(v230, v231)
        | _ ->
            let v234 : bool = true
            let mutable _v234 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v235 : string = "rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)"
            let v236 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v236 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v237 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v237 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v238 : string = "1"
            let v239 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v239 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v240 : uint8 = System.Random().Next (1, 7) |> uint8
            v240 
            #endif
#if FABLE_COMPILER_PYTHON
            let v241 : uint8 = System.Random().Next (1, 7) |> uint8
            v241 
            #endif
#else
            let v242 : uint8 = System.Random().Next (1, 7) |> uint8
            v242 
            #endif
            |> fun x -> _v234 <- Some x
            let v243 : uint8 = _v234.Value
            let v244 : bool = true
            let mutable _v244 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v245 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v245 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v246 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v246 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v247 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v247 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v248 : uint8 = System.Random().Next (1, 7) |> uint8
            v248 
            #endif
#if FABLE_COMPILER_PYTHON
            let v249 : uint8 = System.Random().Next (1, 7) |> uint8
            v249 
            #endif
#else
            let v250 : uint8 = System.Random().Next (1, 7) |> uint8
            v250 
            #endif
            |> fun x -> _v244 <- Some x
            let v251 : uint8 = _v244.Value
            let v252 : bool = true
            let mutable _v252 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v253 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v253 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v255 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v255 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v256 : uint8 = System.Random().Next (1, 7) |> uint8
            v256 
            #endif
#if FABLE_COMPILER_PYTHON
            let v257 : uint8 = System.Random().Next (1, 7) |> uint8
            v257 
            #endif
#else
            let v258 : uint8 = System.Random().Next (1, 7) |> uint8
            v258 
            #endif
            |> fun x -> _v252 <- Some x
            let v259 : uint8 = _v252.Value
            let v260 : bool = true
            let mutable _v260 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v261 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v261 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v262 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v262 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v263 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v263 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v264 : uint8 = System.Random().Next (1, 7) |> uint8
            v264 
            #endif
#if FABLE_COMPILER_PYTHON
            let v265 : uint8 = System.Random().Next (1, 7) |> uint8
            v265 
            #endif
#else
            let v266 : uint8 = System.Random().Next (1, 7) |> uint8
            v266 
            #endif
            |> fun x -> _v260 <- Some x
            let v267 : uint8 = _v260.Value
            let v268 : bool = true
            let mutable _v268 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v269 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v269 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v270 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v270 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v271 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v271 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v272 : uint8 = System.Random().Next (1, 7) |> uint8
            v272 
            #endif
#if FABLE_COMPILER_PYTHON
            let v273 : uint8 = System.Random().Next (1, 7) |> uint8
            v273 
            #endif
#else
            let v274 : uint8 = System.Random().Next (1, 7) |> uint8
            v274 
            #endif
            |> fun x -> _v268 <- Some x
            let v275 : uint8 = _v268.Value
            let v276 : bool = true
            let mutable _v276 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v277 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v277 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v278 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v278 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v279 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v279 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v280 : uint8 = System.Random().Next (1, 7) |> uint8
            v280 
            #endif
#if FABLE_COMPILER_PYTHON
            let v281 : uint8 = System.Random().Next (1, 7) |> uint8
            v281 
            #endif
#else
            let v282 : uint8 = System.Random().Next (1, 7) |> uint8
            v282 
            #endif
            |> fun x -> _v276 <- Some x
            let v283 : uint8 = _v276.Value
            let v284 : bool = true
            let mutable _v284 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v285 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v285 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v286 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v286 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v287 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v287 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v288 : uint8 = System.Random().Next (1, 7) |> uint8
            v288 
            #endif
#if FABLE_COMPILER_PYTHON
            let v289 : uint8 = System.Random().Next (1, 7) |> uint8
            v289 
            #endif
#else
            let v290 : uint8 = System.Random().Next (1, 7) |> uint8
            v290 
            #endif
            |> fun x -> _v284 <- Some x
            let v291 : uint8 = _v284.Value
            let v292 : bool = true
            let mutable _v292 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v293 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v293 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v294 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v294 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v295 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v295 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v296 : uint8 = System.Random().Next (1, 7) |> uint8
            v296 
            #endif
#if FABLE_COMPILER_PYTHON
            let v297 : uint8 = System.Random().Next (1, 7) |> uint8
            v297 
            #endif
#else
            let v298 : uint8 = System.Random().Next (1, 7) |> uint8
            v298 
            #endif
            |> fun x -> _v292 <- Some x
            let v299 : uint8 = _v292.Value
            let v300 : bool = true
            let mutable _v300 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v301 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v301 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v302 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v302 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v303 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v303 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v304 : uint8 = System.Random().Next (1, 7) |> uint8
            v304 
            #endif
#if FABLE_COMPILER_PYTHON
            let v305 : uint8 = System.Random().Next (1, 7) |> uint8
            v305 
            #endif
#else
            let v306 : uint8 = System.Random().Next (1, 7) |> uint8
            v306 
            #endif
            |> fun x -> _v300 <- Some x
            let v307 : uint8 = _v300.Value
            let v308 : bool = true
            let mutable _v308 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v309 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v309 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v310 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v310 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v311 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v311 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v312 : uint8 = System.Random().Next (1, 7) |> uint8
            v312 
            #endif
#if FABLE_COMPILER_PYTHON
            let v313 : uint8 = System.Random().Next (1, 7) |> uint8
            v313 
            #endif
#else
            let v314 : uint8 = System.Random().Next (1, 7) |> uint8
            v314 
            #endif
            |> fun x -> _v308 <- Some x
            let v315 : uint8 = _v308.Value
            let v316 : bool = true
            let mutable _v316 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v317 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v317 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v318 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v318 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v319 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
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
            |> fun x -> _v316 <- Some x
            let v323 : uint8 = _v316.Value
            let v324 : bool = true
            let mutable _v324 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v325 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v325 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v326 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v326 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v327 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v327 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v328 : uint8 = System.Random().Next (1, 7) |> uint8
            v328 
            #endif
#if FABLE_COMPILER_PYTHON
            let v329 : uint8 = System.Random().Next (1, 7) |> uint8
            v329 
            #endif
#else
            let v330 : uint8 = System.Random().Next (1, 7) |> uint8
            v330 
            #endif
            |> fun x -> _v324 <- Some x
            let v331 : uint8 = _v324.Value
            let v332 : bool = true
            let mutable _v332 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v333 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v333 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v334 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v334 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v335 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v335 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v336 : uint8 = System.Random().Next (1, 7) |> uint8
            v336 
            #endif
#if FABLE_COMPILER_PYTHON
            let v337 : uint8 = System.Random().Next (1, 7) |> uint8
            v337 
            #endif
#else
            let v338 : uint8 = System.Random().Next (1, 7) |> uint8
            v338 
            #endif
            |> fun x -> _v332 <- Some x
            let v339 : uint8 = _v332.Value
            let v340 : bool = true
            let mutable _v340 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v341 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v341 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v342 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v342 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v343 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v343 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v344 : uint8 = System.Random().Next (1, 7) |> uint8
            v344 
            #endif
#if FABLE_COMPILER_PYTHON
            let v345 : uint8 = System.Random().Next (1, 7) |> uint8
            v345 
            #endif
#else
            let v346 : uint8 = System.Random().Next (1, 7) |> uint8
            v346 
            #endif
            |> fun x -> _v340 <- Some x
            let v347 : uint8 = _v340.Value
            let v348 : bool = true
            let mutable _v348 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v349 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v349 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v350 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v350 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v351 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v351 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v352 : uint8 = System.Random().Next (1, 7) |> uint8
            v352 
            #endif
#if FABLE_COMPILER_PYTHON
            let v353 : uint8 = System.Random().Next (1, 7) |> uint8
            v353 
            #endif
#else
            let v354 : uint8 = System.Random().Next (1, 7) |> uint8
            v354 
            #endif
            |> fun x -> _v348 <- Some x
            let v355 : uint8 = _v348.Value
            let v356 : bool = true
            let mutable _v356 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v357 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v357 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v358 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v358 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v359 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v359 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v360 : uint8 = System.Random().Next (1, 7) |> uint8
            v360 
            #endif
#if FABLE_COMPILER_PYTHON
            let v361 : uint8 = System.Random().Next (1, 7) |> uint8
            v361 
            #endif
#else
            let v362 : uint8 = System.Random().Next (1, 7) |> uint8
            v362 
            #endif
            |> fun x -> _v356 <- Some x
            let v363 : uint8 = _v356.Value
            let v364 : bool = true
            let mutable _v364 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v365 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v365 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v366 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v366 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v367 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v367 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v368 : uint8 = System.Random().Next (1, 7) |> uint8
            v368 
            #endif
#if FABLE_COMPILER_PYTHON
            let v369 : uint8 = System.Random().Next (1, 7) |> uint8
            v369 
            #endif
#else
            let v370 : uint8 = System.Random().Next (1, 7) |> uint8
            v370 
            #endif
            |> fun x -> _v364 <- Some x
            let v371 : uint8 = _v364.Value
            let v372 : bool = true
            let mutable _v372 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v373 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v373 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v374 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v374 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v375 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v375 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v376 : uint8 = System.Random().Next (1, 7) |> uint8
            v376 
            #endif
#if FABLE_COMPILER_PYTHON
            let v377 : uint8 = System.Random().Next (1, 7) |> uint8
            v377 
            #endif
#else
            let v378 : uint8 = System.Random().Next (1, 7) |> uint8
            v378 
            #endif
            |> fun x -> _v372 <- Some x
            let v379 : uint8 = _v372.Value
            let v380 : bool = true
            let mutable _v380 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v381 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v382 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v382 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v383 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v383 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v384 : uint8 = System.Random().Next (1, 7) |> uint8
            v384 
            #endif
#if FABLE_COMPILER_PYTHON
            let v385 : uint8 = System.Random().Next (1, 7) |> uint8
            v385 
            #endif
#else
            let v386 : uint8 = System.Random().Next (1, 7) |> uint8
            v386 
            #endif
            |> fun x -> _v380 <- Some x
            let v387 : uint8 = _v380.Value
            let v388 : bool = true
            let mutable _v388 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v389 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v389 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v390 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v390 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v391 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v391 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v392 : uint8 = System.Random().Next (1, 7) |> uint8
            v392 
            #endif
#if FABLE_COMPILER_PYTHON
            let v393 : uint8 = System.Random().Next (1, 7) |> uint8
            v393 
            #endif
#else
            let v394 : uint8 = System.Random().Next (1, 7) |> uint8
            v394 
            #endif
            |> fun x -> _v388 <- Some x
            let v395 : uint8 = _v388.Value
            let v396 : bool = true
            let mutable _v396 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v397 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v397 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v398 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v398 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v399 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v400 : uint8 = System.Random().Next (1, 7) |> uint8
            v400 
            #endif
#if FABLE_COMPILER_PYTHON
            let v401 : uint8 = System.Random().Next (1, 7) |> uint8
            v401 
            #endif
#else
            let v402 : uint8 = System.Random().Next (1, 7) |> uint8
            v402 
            #endif
            |> fun x -> _v396 <- Some x
            let v403 : uint8 = _v396.Value
            let v404 : bool = true
            let mutable _v404 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v406 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v406 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v407 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
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
            |> fun x -> _v404 <- Some x
            let v411 : uint8 = _v404.Value
            let v412 : bool = true
            let mutable _v412 : uint8 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v413 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v413 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v414 : uint8 = Fable.Core.RustInterop.emitRustExpr () v235
            v414 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v415 : uint8 = Fable.Core.RustInterop.emitRustExpr () v238
            v415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : uint8 = System.Random().Next (1, 7) |> uint8
            v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v417 : uint8 = System.Random().Next (1, 7) |> uint8
            v417 
            #endif
#else
            let v418 : uint8 = System.Random().Next (1, 7) |> uint8
            v418 
            #endif
            |> fun x -> _v412 <- Some x
            let v419 : uint8 = _v412.Value
            let v420 : UH1 = UH1_0
            let v421 : UH1 = UH1_1(v419, v420)
            let v422 : UH1 = UH1_1(v411, v421)
            let v423 : UH1 = UH1_1(v403, v422)
            let v424 : UH1 = UH1_1(v395, v423)
            let v425 : UH1 = UH1_1(v387, v424)
            let v426 : UH1 = UH1_1(v379, v425)
            let v427 : UH1 = UH1_1(v371, v426)
            let v428 : UH1 = UH1_1(v363, v427)
            let v429 : UH1 = UH1_1(v355, v428)
            let v430 : UH1 = UH1_1(v347, v429)
            let v431 : UH1 = UH1_1(v339, v430)
            let v432 : UH1 = UH1_1(v331, v431)
            let v433 : UH1 = UH1_1(v323, v432)
            let v434 : UH1 = UH1_1(v315, v433)
            let v435 : UH1 = UH1_1(v307, v434)
            let v436 : UH1 = UH1_1(v299, v435)
            let v437 : UH1 = UH1_1(v291, v436)
            let v438 : UH1 = UH1_1(v283, v437)
            let v439 : UH1 = UH1_1(v275, v438)
            let v440 : UH1 = UH1_1(v267, v439)
            let v441 : UH1 = UH1_1(v259, v440)
            let v442 : UH1 = UH1_1(v251, v441)
            let v443 : UH1 = UH1_1(v243, v442)
            let v444 : int8 = 23y
            method14(v443, v444)
and closure80 () (v0 : (string [])) : int32 =
    let v1 : string = $"calculate_dice_count / max: {9223372036854775807L} / n: {24y} / p: {4738381338321616896L}"
    System.Console.WriteLine v1
    let v2 : UH1 = UH1_0
    let v3 : int8 = 0y
    let v4 : int64 = method14(v2, v3)
    let v5 : string = $"result: {v4}"
    System.Console.WriteLine v5
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
