import { FSharpRef, Record, Union } from "../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { int32, int8, uint8 } from "../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { uint64_type, int64_type, record_type, string_type, union_type, lambda_type, unit_type, uint8_type, TypeInfo } from "../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { op_Multiply, toUInt64, equals, compare, toUInt8, fromUInt8, op_Subtraction, op_Modulus, op_Addition, toInt64, uint64, int64 } from "../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { IComparable, IEquatable } from "../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { interpolate, toText } from "../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { defaultArg, value as value_47, Option } from "../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { nonSeeded } from "../../polyglot/deps/Fable/src/fable-library-ts/Random.js";

export type UH0_$union = 
    | UH0<0>
    | UH0<1>

export type UH0_$cases = {
    0: ["UH0_0", [uint8, (() => UH0_$union)]],
    1: ["UH0_1", []]
}

export function UH0_UH0_0(Item1: uint8, Item2: (() => UH0_$union)) {
    return new UH0<0>(0, [Item1, Item2]);
}

export function UH0_UH0_1() {
    return new UH0<1>(1, []);
}

export class UH0<Tag extends keyof UH0_$cases> extends Union<Tag, UH0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH0_0", "UH0_1"];
    }
}

export function UH0_$reflection(): TypeInfo {
    return union_type("Dice.UH0", [], UH0, () => [[["Item1", uint8_type], ["Item2", lambda_type(unit_type, UH0_$reflection())]], []]);
}

export type UH1_$union = 
    | UH1<0>
    | UH1<1>

export type UH1_$cases = {
    0: ["UH1_0", []],
    1: ["UH1_1", [uint8, UH1_$union]]
}

export function UH1_UH1_0() {
    return new UH1<0>(0, []);
}

export function UH1_UH1_1(Item1: uint8, Item2: UH1_$union) {
    return new UH1<1>(1, [Item1, Item2]);
}

export class UH1<Tag extends keyof UH1_$cases> extends Union<Tag, UH1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH1_0", "UH1_1"];
    }
}

export function UH1_$reflection(): TypeInfo {
    return union_type("Dice.UH1", [], UH1, () => [[], [["Item1", uint8_type], ["Item2", UH1_$reflection()]]]);
}

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", [((arg0: string) => void)]],
    1: ["US0_1", []]
}

export function US0_US0_0(f0_0: ((arg0: string) => void)) {
    return new US0<0>(0, [f0_0]);
}

export function US0_US0_1() {
    return new US0<1>(1, []);
}

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Dice.US0", [], US0, () => [[["f0_0", lambda_type(string_type, unit_type)]], []]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", [(() => UH0_$union)]],
    1: ["US1_1", [UH0_$union]]
}

export function US1_US1_0(f0_0: (() => UH0_$union)) {
    return new US1<0>(0, [f0_0]);
}

export function US1_US1_1(f1_0: UH0_$union) {
    return new US1<1>(1, [f1_0]);
}

export class US1<Tag extends keyof US1_$cases> extends Union<Tag, US1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US1_0", "US1_1"];
    }
}

export function US1_$reflection(): TypeInfo {
    return union_type("Dice.US1", [], US1, () => [[["f0_0", lambda_type(unit_type, UH0_$reflection())]], [["f1_0", UH0_$reflection()]]]);
}

export class Mut0 extends Record {
    l0: US1_$union;
    constructor(l0: US1_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Dice.Mut0", [], Mut0, () => [["l0", US1_$reflection()]]);
}

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Dice.Mut1", [], Mut1, () => [["l0", int64_type]]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", [uint8]],
    1: ["US2_1", []]
}

export function US2_US2_0(f0_0: uint8) {
    return new US2<0>(0, [f0_0]);
}

export function US2_US2_1() {
    return new US2<1>(1, []);
}

export class US2<Tag extends keyof US2_$cases> extends Union<Tag, US2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1"];
    }
}

export function US2_$reflection(): TypeInfo {
    return union_type("Dice.US2", [], US2, () => [[["f0_0", uint8_type]], []]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: US2_$union;
    constructor(l0: US2_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Dice.Mut2", [], Mut2, () => [["l0", US2_$reflection()]]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [uint64, UH1_$union]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: uint64, f0_1: UH1_$union) {
    return new US3<0>(0, [f0_0, f0_1]);
}

export function US3_US3_1() {
    return new US3<1>(1, []);
}

export class US3<Tag extends keyof US3_$cases> extends Union<Tag, US3_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US3_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1"];
    }
}

export function US3_$reflection(): TypeInfo {
    return union_type("Dice.US3", [], US3, () => [[["f0_0", uint64_type], ["f0_1", UH1_$reflection()]], []]);
}

export type UH2_$union = 
    | UH2<0>
    | UH2<1>

export type UH2_$cases = {
    0: ["UH2_0", [uint64, (() => UH2_$union)]],
    1: ["UH2_1", []]
}

export function UH2_UH2_0(Item1: uint64, Item2: (() => UH2_$union)) {
    return new UH2<0>(0, [Item1, Item2]);
}

export function UH2_UH2_1() {
    return new UH2<1>(1, []);
}

export class UH2<Tag extends keyof UH2_$cases> extends Union<Tag, UH2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH2_0", "UH2_1"];
    }
}

export function UH2_$reflection(): TypeInfo {
    return union_type("Dice.UH2", [], UH2, () => [[["Item1", uint64_type], ["Item2", lambda_type(unit_type, UH2_$reflection())]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [uint64]],
    1: ["US4_1", []]
}

export function US4_US4_0(f0_0: uint64) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1() {
    return new US4<1>(1, []);
}

export class US4<Tag extends keyof US4_$cases> extends Union<Tag, US4_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US4_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1"];
    }
}

export function US4_$reflection(): TypeInfo {
    return union_type("Dice.US4", [], US4, () => [[["f0_0", uint64_type]], []]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [int64, UH1_$union]],
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: int64, f0_1: UH1_$union) {
    return new US5<0>(0, [f0_0, f0_1]);
}

export function US5_US5_1() {
    return new US5<1>(1, []);
}

export class US5<Tag extends keyof US5_$cases> extends Union<Tag, US5_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US5_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US5_0", "US5_1"];
    }
}

export function US5_$reflection(): TypeInfo {
    return union_type("Dice.US5", [], US5, () => [[["f0_0", int64_type], ["f0_1", UH1_$reflection()]], []]);
}

export function UH0__get_IsUH0_0(this$: UH0_$union, unitArg: void): boolean {
    if (this$.tag === /* UH0_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH0__get_IsUH0_1(this$: UH0_$union, unitArg: void): boolean {
    if (this$.tag === /* UH0_1 */ 1) {
        return true;
    }
    else {
        return false;
    }
}

export function UH1__get_IsUH1_0(this$: UH1_$union, unitArg: void): boolean {
    if (this$.tag === /* UH1_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH1__get_IsUH1_1(this$: UH1_$union, unitArg: void): boolean {
    if (this$.tag === /* UH1_1 */ 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_0(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_1(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_0(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_1(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_0(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_1(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US3__get_IsUS3_0(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US3__get_IsUS3_1(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function UH2__get_IsUH2_0(this$: UH2_$union, unitArg: void): boolean {
    if (this$.tag === /* UH2_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH2__get_IsUH2_1(this$: UH2_$union, unitArg: void): boolean {
    if (this$.tag === /* UH2_1 */ 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US4__get_IsUS4_0(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US4__get_IsUS4_1(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_0(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_1(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function closure2(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method0(v0_1: int64, v1_1: UH0_$union, v2_1: UH0_$union): UH0_$union {
    if (v1_1.tag === /* UH0_1 */ 1) {
        return v2_1;
    }
    else {
        const v3_1: uint8 = v1_1.fields[0];
        const v6: UH0_$union = method0(v0_1, v1_1.fields[1](), v2_1);
        const v11: int64 = toInt64(op_Addition(toInt64(op_Modulus(toInt64(op_Addition(toInt64(op_Subtraction(toInt64(fromUInt8(v3_1)), 1n)), v0_1)), v0_1)), 1n));
        return UH0_UH0_0(toUInt8(v11) & 0xFF, (): UH0_$union => closure2(v6, undefined));
    }
}

export function closure1(v0_1: int64, v1_1: UH0_$union): UH0_$union {
    return method0(v0_1, v1_1, UH0_UH0_1());
}

export function closure0(unitVar: void, v0_1: int64): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure1(v0_1, v);
}

export function method1(v0_1_mut: UH1_$union, v1_1_mut: UH1_$union): UH1_$union {
    method1:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: UH1_$union = v1_1_mut;
        if (v0_1.tag === /* UH1_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = UH1_UH1_1(v0_1.fields[0], v1_1);
            continue method1;
        }
        break;
    }
}

export function method2(v0_1: UH1_$union, v1_1: UH1_$union): UH1_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return UH1_UH1_1(v0_1.fields[0], method2(v0_1.fields[1], v1_1));
    }
}

export function closure5(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method3(v0_1: UH1_$union, v1_1: UH0_$union): UH0_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        const v2_1: uint8 = v0_1.fields[0];
        const v4_1: UH0_$union = method3(v0_1.fields[1], v1_1);
        return UH0_UH0_0(v2_1, (): UH0_$union => closure5(v4_1, undefined));
    }
}

export function closure6(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function closure7(v0_1: UH0_$union, v1_1: Mut0, unitVar: void): UH0_$union {
    const v2_1: US1_$union = v1_1.l0;
    if (v2_1.tag === /* US1_0 */ 0) {
        const v5: UH0_$union = v2_1.fields[0]();
        const v12: UH0_$union = (v5.tag === /* UH0_1 */ 1) ? UH0_UH0_1() : UH0_UH0_0(v5.fields[0], method4(v0_1, v5.fields[1]));
        v1_1.l0 = US1_US1_1(v12);
        return v12;
    }
    else {
        return v2_1.fields[0];
    }
}

export function method4(v0_1: UH0_$union, v1_1: (() => UH0_$union)): (() => UH0_$union) {
    const v3_1: Mut0 = new Mut0(US1_US1_0(v1_1));
    return (): UH0_$union => closure7(v0_1, v3_1, undefined);
}

export function method6(v0_1_mut: int64, v1_1_mut: UH0_$union): US2_$union {
    method6:
    while (true) {
        const v0_1: int64 = v0_1_mut, v1_1: UH0_$union = v1_1_mut;
        if (v1_1.tag === /* UH0_1 */ 1) {
            return US2_US2_1();
        }
        else {
            const v3_1: (() => UH0_$union) = v1_1.fields[1];
            const v2_1: uint8 = v1_1.fields[0];
            if (compare(v0_1, 0n) <= 0) {
                return US2_US2_0(v2_1);
            }
            else {
                v0_1_mut = toInt64(op_Subtraction(v0_1, 1n));
                v1_1_mut = v3_1();
                continue method6;
            }
        }
        break;
    }
}

export function method5(v0_1_mut: US0_$union, v1_1_mut: (() => UH0_$union), v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut1, v5_mut: Mut2): uint8 {
    method5:
    while (true) {
        const v0_1: US0_$union = v0_1_mut, v1_1: (() => UH0_$union) = v1_1_mut, v2_1: Mut1 = v2_1_mut, v3_1: Mut1 = v3_1_mut, v4_1: Mut1 = v4_1_mut, v5: Mut2 = v5_mut;
        const v10: string = toText(interpolate("create_sequential_roller / roll / current_index: %P() / acc: %P() / len: %P() / last_item: %A%P()", [v2_1.l0, v3_1.l0, v4_1.l0, v5.l0]));
        if (v0_1.tag === /* US0_0 */ 0) {
            v0_1.fields[0](v10);
        }
        const v12: UH0_$union = v1_1();
        const v14: US2_$union = method6(v2_1.l0, v12);
        if (v14.tag === /* US2_0 */ 0) {
            const v15: uint8 = v14.fields[0];
            const v17: int64 = toInt64(op_Addition(v2_1.l0, 1n));
            v2_1.l0 = v17;
            v5.l0 = US2_US2_0(v15);
            return v15;
        }
        else {
            if (v0_1.tag === /* US0_0 */ 0) {
                v0_1.fields[0]("create_sequential_roller / roll / None");
            }
            if (equals(v4_1.l0, -1n)) {
                const v23: int64 = v2_1.l0;
                v4_1.l0 = v23;
            }
            const v29: int64 = (compare(v3_1.l0, v4_1.l0) >= 0) ? (1n) : toInt64(op_Addition(v3_1.l0, 1n));
            v3_1.l0 = v29;
            const v31: int64 = toInt64(op_Subtraction(v3_1.l0, 1n));
            v2_1.l0 = v31;
            v5.l0 = US2_US2_1();
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            v5_mut = v5;
            continue method5;
        }
        break;
    }
}

export function closure8(v0_1: US0_$union, v1_1: (() => UH0_$union), v2_1: Mut1, v3_1: Mut1, v4_1: Mut1, v5: Mut2, unitVar: void): uint8 {
    return method5(v0_1, v1_1, v2_1, v3_1, v4_1, v5);
}

export function closure4(v0_1: US0_$union, v1_1: UH1_$union): (() => uint8) {
    if (v0_1.tag === /* US0_0 */ 0) {
        v0_1.fields[0]("create_sequential_roller ()");
    }
    const v8: UH0_$union = method3(method2(v1_1, method1(v1_1, UH1_UH1_0())), UH0_UH0_1());
    const v10: (() => UH0_$union) = method4(v8, (): UH0_$union => closure6(v8, undefined));
    const v11: Mut1 = new Mut1(0n);
    const v12: Mut1 = new Mut1(1n);
    const v13: Mut1 = new Mut1(-1n);
    const v15: Mut2 = new Mut2(US2_US2_1());
    return (): uint8 => closure8(v0_1, v10, v11, v12, v13, v15, undefined);
}

export function closure3(unitVar: void, v0_1: Option<((arg0: string) => void)>): ((arg0: UH1_$union) => (() => uint8)) {
    const _v1: FSharpRef<Option<US0_$union>> = new FSharpRef<Option<US0_$union>>(undefined);
    let x_2: Option<US0_$union>;
    if (v0_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: ((arg0: string) => void) = value_47(v0_1);
        x_2 = ((): US0_$union => US0_US0_0(x))();
    }
    _v1.contents = x_2;
    const v6: US0_$union = defaultArg(_v1.contents, US0_US0_1());
    return (v: UH1_$union): (() => uint8) => closure4(v6, v);
}

export function method7(v0_1_mut: US0_$union, v1_1_mut: uint64, v2_1_mut: int8, v3_1_mut: uint64): int8 {
    method7:
    while (true) {
        const v0_1: US0_$union = v0_1_mut, v1_1: uint64 = v1_1_mut, v2_1: int8 = v2_1_mut, v3_1: uint64 = v3_1_mut;
        if (compare(v3_1, v1_1) < 0) {
            const v5: uint64 = toUInt64(op_Multiply(v3_1, 6n));
            if (compare(v5, v3_1) > 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = (v2_1 + 1);
                v3_1_mut = v5;
                continue method7;
            }
            else {
                const v9 = `calculate_dice_count / max: ${v1_1} / n: ${v2_1} / p: ${v3_1}`;
                if (v0_1.tag === /* US0_0 */ 0) {
                    v0_1.fields[0](v9);
                }
                return v2_1 | 0;
            }
        }
        else {
            const v12 = `calculate_dice_count / max: ${v1_1} / n: ${v2_1} / p: ${v3_1}`;
            if (v0_1.tag === /* US0_0 */ 0) {
                v0_1.fields[0](v12);
            }
            return v2_1 | 0;
        }
        break;
    }
}

export function closure76(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(0n, (): UH2_$union => closure76(undefined, undefined));
}

export function closure75(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9223372036854775808n, (): UH2_$union => closure76(undefined, undefined));
}

export function closure74(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4611686018427387904n, (): UH2_$union => closure75(undefined, undefined));
}

export function closure73(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6917529027641081856n, (): UH2_$union => closure74(undefined, undefined));
}

export function closure72(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1152921504606846976n, (): UH2_$union => closure73(undefined, undefined));
}

export function closure71(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(15564440312192434176n, (): UH2_$union => closure72(undefined, undefined));
}

export function closure70(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11817445422220181504n, (): UH2_$union => closure71(undefined, undefined));
}

export function closure69(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5044031582654955520n, (): UH2_$union => closure70(undefined, undefined));
}

export function closure68(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6989586621679009792n, (): UH2_$union => closure69(undefined, undefined));
}

export function closure67(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16537217831704461312n, (): UH2_$union => closure68(undefined, undefined));
}

export function closure66(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11979575008805519360n, (): UH2_$union => closure67(undefined, undefined));
}

export function closure65(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14294425217273954304n, (): UH2_$union => closure66(undefined, undefined));
}

export function closure64(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2382404202878992384n, (): UH2_$union => closure65(undefined, undefined));
}

export function closure63(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6545982058383015936n, (): UH2_$union => closure64(undefined, undefined));
}

export function closure62(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10314369046585278464n, (): UH2_$union => closure63(undefined, undefined));
}

export function closure61(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4793518853382471680n, (): UH2_$union => closure62(undefined, undefined));
}

export function closure60(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3873377154515337216n, (): UH2_$union => closure61(undefined, undefined));
}

export function closure59(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(645562859085889536n, (): UH2_$union => closure60(undefined, undefined));
}

export function closure58(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(107593809847648256n, (): UH2_$union => closure59(undefined, undefined));
}

export function closure57(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3092389647259533312n, (): UH2_$union => closure58(undefined, undefined));
}

export function closure56(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9738770311398031360n, (): UH2_$union => closure57(undefined, undefined));
}

export function closure55(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16995415113324298240n, (): UH2_$union => closure56(undefined, undefined));
}

export function closure54(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8981483876790566912n, (): UH2_$union => closure55(undefined, undefined));
}

export function closure53(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13794743361938128896n, (): UH2_$union => closure54(undefined, undefined));
}

export function closure52(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2299123893656354816n, (): UH2_$union => closure53(undefined, undefined));
}

export function closure51(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3457644661227651072n, (): UH2_$union => closure52(undefined, undefined));
}

export function closure50(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(576274110204608512n, (): UH2_$union => closure51(undefined, undefined));
}

export function closure49(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6244960376270618624n, (): UH2_$union => closure50(undefined, undefined));
}

export function closure48(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13338656111851470848n, (): UH2_$union => closure49(undefined, undefined));
}

export function closure47(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14520938734448279552n, (): UH2_$union => closure48(undefined, undefined));
}

export function closure46(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14717985838214414336n, (): UH2_$union => closure47(undefined, undefined));
}

export function closure45(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5527454985320660992n, (): UH2_$union => closure46(undefined, undefined));
}

export function closure44(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16293529225644736512n, (): UH2_$union => closure45(undefined, undefined));
}

export function closure43(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11938960241128898560n, (): UH2_$union => closure44(undefined, undefined));
}

export function closure42(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8138741398091333632n, (): UH2_$union => closure43(undefined, undefined));
}

export function closure41(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7505371590918406144n, (): UH2_$union => closure42(undefined, undefined));
}

export function closure40(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16623181993244360704n, (): UH2_$union => closure41(undefined, undefined));
}

export function closure39(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8919445023443910656n, (): UH2_$union => closure40(undefined, undefined));
}

export function closure38(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4561031516192243712n, (): UH2_$union => closure39(undefined, undefined));
}

export function closure37(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9983543956220149760n, (): UH2_$union => closure38(undefined, undefined));
}

export function closure36(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4738381338321616896n, (): UH2_$union => closure37(undefined, undefined));
}

export function closure35(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(789730223053602816n, (): UH2_$union => closure36(undefined, undefined));
}

export function closure34(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(131621703842267136n, (): UH2_$union => closure35(undefined, undefined));
}

export function closure33(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(21936950640377856n, (): UH2_$union => closure34(undefined, undefined));
}

export function closure32(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3656158440062976n, (): UH2_$union => closure33(undefined, undefined));
}

export function closure31(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(609359740010496n, (): UH2_$union => closure32(undefined, undefined));
}

export function closure30(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(101559956668416n, (): UH2_$union => closure31(undefined, undefined));
}

export function closure29(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16926659444736n, (): UH2_$union => closure30(undefined, undefined));
}

export function closure28(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2821109907456n, (): UH2_$union => closure29(undefined, undefined));
}

export function closure27(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(470184984576n, (): UH2_$union => closure28(undefined, undefined));
}

export function closure26(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(78364164096n, (): UH2_$union => closure27(undefined, undefined));
}

export function closure25(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13060694016n, (): UH2_$union => closure26(undefined, undefined));
}

export function closure24(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2176782336n, (): UH2_$union => closure25(undefined, undefined));
}

export function closure23(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(362797056n, (): UH2_$union => closure24(undefined, undefined));
}

export function closure22(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(60466176n, (): UH2_$union => closure23(undefined, undefined));
}

export function closure21(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10077696n, (): UH2_$union => closure22(undefined, undefined));
}

export function closure20(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1679616n, (): UH2_$union => closure21(undefined, undefined));
}

export function closure19(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(279936n, (): UH2_$union => closure20(undefined, undefined));
}

export function closure18(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(46656n, (): UH2_$union => closure19(undefined, undefined));
}

export function closure17(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7776n, (): UH2_$union => closure18(undefined, undefined));
}

export function closure16(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1296n, (): UH2_$union => closure17(undefined, undefined));
}

export function closure15(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(216n, (): UH2_$union => closure16(undefined, undefined));
}

export function closure14(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(36n, (): UH2_$union => closure15(undefined, undefined));
}

export function closure13(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6n, (): UH2_$union => closure14(undefined, undefined));
}

export function method10(v0_1_mut: int8, v1_1_mut: UH2_$union): US4_$union {
    method10:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if (v1_1.tag === /* UH2_1 */ 1) {
            return US4_US4_1();
        }
        else if (v0_1 <= 0) {
            return US4_US4_0(v1_1.fields[0]);
        }
        else {
            v0_1_mut = (v0_1 - 1);
            v1_1_mut = v1_1.fields[1]();
            continue method10;
        }
        break;
    }
}

export function method9(v0_1_mut: US0_$union, v1_1_mut: int8, v2_1_mut: UH1_$union, v3_1_mut: uint64): US3_$union {
    method9:
    while (true) {
        const v0_1: US0_$union = v0_1_mut, v1_1: int8 = v1_1_mut, v2_1: UH1_$union = v2_1_mut, v3_1: uint64 = v3_1_mut;
        if (v1_1 < 0) {
            const v5: uint64 = toUInt64(op_Addition(v3_1, 1n));
            const v6 = `accumulate_dice_rolls / power: ${v1_1} / acc: ${v3_1} / result: ${v5}`;
            if (v0_1.tag === /* US0_0 */ 0) {
                v0_1.fields[0](v6);
            }
            return US3_US3_0(v5, v2_1);
        }
        else if (v2_1.tag === /* UH1_0 */ 0) {
            return US3_US3_1();
        }
        else {
            const v11: UH1_$union = v2_1.fields[1];
            const v10: uint8 = v2_1.fields[0];
            if (v10 > 1) {
                const v16: US4_$union = method10(v1_1, UH2_UH2_0(1n, (): UH2_$union => closure13(undefined, undefined)));
                let v20: uint64;
                if (v16.tag === /* US4_0 */ 0) {
                    v20 = v16.fields[0];
                }
                else {
                    throw new Error("Option does not have a value.");
                }
                const v23: uint64 = toUInt64(op_Multiply(toUInt64(fromUInt8(v10 - 1)), v20));
                const v24 = `accumulate_dice_rolls / power: ${v1_1} / acc: ${v3_1} / roll: ${v10} / value: ${v23}`;
                if (v0_1.tag === /* US0_0 */ 0) {
                    v0_1.fields[0](v24);
                }
                v0_1_mut = v0_1;
                v1_1_mut = (v1_1 - 1);
                v2_1_mut = v11;
                v3_1_mut = toUInt64(op_Addition(v3_1, v23));
                continue method9;
            }
            else {
                const v29 = `accumulate_dice_rolls / power: ${v1_1} / acc: ${v3_1} / roll: ${v10}`;
                if (v0_1.tag === /* US0_0 */ 0) {
                    v0_1.fields[0](v29);
                }
                v0_1_mut = v0_1;
                v1_1_mut = (v1_1 - 1);
                v2_1_mut = v11;
                v3_1_mut = v3_1;
                continue method9;
            }
        }
        break;
    }
}

export function method11(v0_1: int8, v1_1: (() => uint8), v2_1: int8): UH1_$union {
    if (v2_1 < v0_1) {
        return UH1_UH1_1(v1_1(), method11(v0_1, v1_1, v2_1 + 1));
    }
    else {
        return UH1_UH1_0();
    }
}

export function method12(v0_1_mut: US0_$union, v1_1_mut: (() => uint8), v2_1_mut: boolean, v3_1_mut: uint64, v4_1_mut: int8, v5_mut: UH1_$union): uint64 {
    method12:
    while (true) {
        const v0_1: US0_$union = v0_1_mut, v1_1: (() => uint8) = v1_1_mut, v2_1: boolean = v2_1_mut, v3_1: uint64 = v3_1_mut, v4_1: int8 = v4_1_mut, v5: UH1_$union = v5_mut;
        const v6: int8 = (v4_1 + 1) | 0;
        if (v4_1 < v6) {
            return method8(v0_1, v1_1, v2_1, v3_1, v4_1, UH1_UH1_1(v1_1(), v5), v6);
        }
        else {
            const v12: US3_$union = method9(v0_1, v4_1, v5, 0n);
            if (v12.tag === /* US3_0 */ 0) {
                const v14: UH1_$union = v12.fields[1];
                const v13: uint64 = v12.fields[0];
                if (compare(v13, v3_1) <= 0) {
                    return v13;
                }
                else if (v2_1) {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = v4_1;
                    v5_mut = method11(v4_1, v1_1, 0);
                    continue method12;
                }
                else {
                    return method8(v0_1, v1_1, v2_1, v3_1, v4_1, UH1_UH1_1(v1_1(), v5), v6);
                }
            }
            else if (v2_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = v4_1;
                v5_mut = method11(v4_1, v1_1, 0);
                continue method12;
            }
            else {
                return method8(v0_1, v1_1, v2_1, v3_1, v4_1, UH1_UH1_1(v1_1(), v5), v6);
            }
        }
        break;
    }
}

export function method8(v0_1_mut: US0_$union, v1_1_mut: (() => uint8), v2_1_mut: boolean, v3_1_mut: uint64, v4_1_mut: int8, v5_mut: UH1_$union, v6_mut: int8): uint64 {
    method8:
    while (true) {
        const v0_1: US0_$union = v0_1_mut, v1_1: (() => uint8) = v1_1_mut, v2_1: boolean = v2_1_mut, v3_1: uint64 = v3_1_mut, v4_1: int8 = v4_1_mut, v5: UH1_$union = v5_mut, v6: int8 = v6_mut;
        if (v6 < (v4_1 + 1)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            v5_mut = UH1_UH1_1(v1_1(), v5);
            v6_mut = (v6 + 1);
            continue method8;
        }
        else {
            const v14: US3_$union = method9(v0_1, v4_1, v5, 0n);
            if (v14.tag === /* US3_0 */ 0) {
                const v16: UH1_$union = v14.fields[1];
                const v15: uint64 = v14.fields[0];
                if (compare(v15, v3_1) <= 0) {
                    return v15;
                }
                else if (v2_1) {
                    return method12(v0_1, v1_1, v2_1, v3_1, v4_1, method11(v4_1, v1_1, 0));
                }
                else {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = v4_1;
                    v5_mut = UH1_UH1_1(v1_1(), v5);
                    v6_mut = (v6 + 1);
                    continue method8;
                }
            }
            else if (v2_1) {
                return method12(v0_1, v1_1, v2_1, v3_1, v4_1, method11(v4_1, v1_1, 0));
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = v4_1;
                v5_mut = UH1_UH1_1(v1_1(), v5);
                v6_mut = (v6 + 1);
                continue method8;
            }
        }
        break;
    }
}

export function closure12(v0_1: US0_$union, v1_1: (() => uint8), v2_1: boolean, v3_1: uint64): uint64 {
    return method8(v0_1, v1_1, v2_1, v3_1, (equals(v3_1, 1n) ? 1 : method7(v0_1, v3_1, 0, 1n)) - 1, UH1_UH1_0(), 0);
}

export function closure11(v0_1: US0_$union, v1_1: (() => uint8), v2_1: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure12(v0_1, v1_1, v2_1, v);
}

export function closure10(v0_1: US0_$union, v1_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure11(v0_1, v1_1, v);
}

export function closure9(unitVar: void, v0_1: Option<((arg0: string) => void)>): ((arg0: (() => uint8)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) {
    const _v1: FSharpRef<Option<US0_$union>> = new FSharpRef<Option<US0_$union>>(undefined);
    let x_2: Option<US0_$union>;
    if (v0_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: ((arg0: string) => void) = value_47(v0_1);
        x_2 = ((): US0_$union => US0_US0_0(x))();
    }
    _v1.contents = x_2;
    const v6: US0_$union = defaultArg(_v1.contents, US0_US0_1());
    return (v: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) => closure10(v6, v);
}

export function method13(v0_1_mut: UH1_$union, v1_1_mut: int8): int8 {
    method13:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v0_1.tag === /* UH1_0 */ 0) {
            return v1_1 | 0;
        }
        else {
            const v2_1: uint8 = v0_1.fields[0];
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v1_1 + 1);
            continue method13;
        }
        break;
    }
}

export function closure79(v0_1: Option<((arg0: string) => void)>, v1_1: uint64, v2_1: UH1_$union): Option<uint64> {
    const _v3: FSharpRef<Option<US0_$union>> = new FSharpRef<Option<US0_$union>>(undefined);
    let x_2: Option<US0_$union>;
    if (v0_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: ((arg0: string) => void) = value_47(v0_1);
        x_2 = ((): US0_$union => US0_US0_0(x))();
    }
    _v3.contents = x_2;
    const v13: US3_$union = method9(defaultArg(_v3.contents, US0_US0_1()), method13(v2_1, 0) - 1, v2_1, 0n);
    let v23: US4_$union;
    if (v13.tag === /* US3_0 */ 0) {
        const v15: UH1_$union = v13.fields[1];
        const v14: uint64 = v13.fields[0];
        v23 = (((compare(v14, 1n) >= 0) && (compare(v14, v1_1) <= 0)) ? US4_US4_0(v14) : US4_US4_1());
    }
    else {
        v23 = US4_US4_1();
    }
    if (v23.tag === /* US4_0 */ 0) {
        return v23.fields[0];
    }
    else {
        return undefined;
    }
}

export function closure78(v0_1: Option<((arg0: string) => void)>, v1_1: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return (v: UH1_$union): Option<uint64> => closure79(v0_1, v1_1, v);
}

export function closure77(unitVar: void, v0_1: Option<((arg0: string) => void)>): ((arg0: uint64) => ((arg0: UH1_$union) => Option<uint64>)) {
    return (v: uint64): ((arg0: UH1_$union) => Option<uint64>) => closure78(v0_1, v);
}

export function method39(v0_1: UH1_$union, v1_1: int64): US5_$union {
    const v2_1: int64 = toInt64(op_Addition(v1_1, 1n));
    const value = `accumulate_dice_rolls / power: ${-1} / acc: ${v1_1} / result: ${v2_1}`;
    console.log(value);
    return US5_US5_0(v2_1, v0_1);
}

export function method38(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v7: int64 = toInt64(fromUInt8(v3_1 - 1));
            const value = `accumulate_dice_rolls / power: ${0} / acc: ${v1_1} / roll: ${v3_1} / value: ${v7}`;
            console.log(value);
            return method39(v4_1, toInt64(op_Addition(v1_1, v7)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${0} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method39(v4_1, v1_1);
        }
    }
}

export function method37(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 6n));
            const value = `accumulate_dice_rolls / power: ${1} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method38(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${1} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method38(v4_1, v1_1);
        }
    }
}

export function method36(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 36n));
            const value = `accumulate_dice_rolls / power: ${2} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method37(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${2} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method37(v4_1, v1_1);
        }
    }
}

export function method35(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 216n));
            const value = `accumulate_dice_rolls / power: ${3} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method36(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${3} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method36(v4_1, v1_1);
        }
    }
}

export function method34(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1296n));
            const value = `accumulate_dice_rolls / power: ${4} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method35(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${4} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method35(v4_1, v1_1);
        }
    }
}

export function method33(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 7776n));
            const value = `accumulate_dice_rolls / power: ${5} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method34(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${5} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method34(v4_1, v1_1);
        }
    }
}

export function method32(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 46656n));
            const value = `accumulate_dice_rolls / power: ${6} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method33(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${6} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method33(v4_1, v1_1);
        }
    }
}

export function method31(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 279936n));
            const value = `accumulate_dice_rolls / power: ${7} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method32(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${7} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method32(v4_1, v1_1);
        }
    }
}

export function method30(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1679616n));
            const value = `accumulate_dice_rolls / power: ${8} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method31(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${8} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method31(v4_1, v1_1);
        }
    }
}

export function method29(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 10077696n));
            const value = `accumulate_dice_rolls / power: ${9} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method30(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${9} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method30(v4_1, v1_1);
        }
    }
}

export function method28(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 60466176n));
            const value = `accumulate_dice_rolls / power: ${10} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method29(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${10} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method29(v4_1, v1_1);
        }
    }
}

export function method27(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 362797056n));
            const value = `accumulate_dice_rolls / power: ${11} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method28(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${11} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method28(v4_1, v1_1);
        }
    }
}

export function method26(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2176782336n));
            const value = `accumulate_dice_rolls / power: ${12} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method27(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${12} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method27(v4_1, v1_1);
        }
    }
}

export function method25(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 13060694016n));
            const value = `accumulate_dice_rolls / power: ${13} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method26(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${13} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method26(v4_1, v1_1);
        }
    }
}

export function method24(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 78364164096n));
            const value = `accumulate_dice_rolls / power: ${14} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method25(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${14} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method25(v4_1, v1_1);
        }
    }
}

export function method23(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 470184984576n));
            const value = `accumulate_dice_rolls / power: ${15} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method24(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${15} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method24(v4_1, v1_1);
        }
    }
}

export function method22(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2821109907456n));
            const value = `accumulate_dice_rolls / power: ${16} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method23(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${16} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method23(v4_1, v1_1);
        }
    }
}

export function method21(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 16926659444736n));
            const value = `accumulate_dice_rolls / power: ${17} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method22(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${17} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method22(v4_1, v1_1);
        }
    }
}

export function method20(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 101559956668416n));
            const value = `accumulate_dice_rolls / power: ${18} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method21(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${18} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method21(v4_1, v1_1);
        }
    }
}

export function method19(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 609359740010496n));
            const value = `accumulate_dice_rolls / power: ${19} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method20(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${19} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method20(v4_1, v1_1);
        }
    }
}

export function method18(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 3656158440062976n));
            const value = `accumulate_dice_rolls / power: ${20} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method19(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${20} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method19(v4_1, v1_1);
        }
    }
}

export function method17(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 21936950640377856n));
            const value = `accumulate_dice_rolls / power: ${21} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method18(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${21} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method18(v4_1, v1_1);
        }
    }
}

export function method16(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 131621703842267136n));
            const value = `accumulate_dice_rolls / power: ${22} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method17(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${22} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method17(v4_1, v1_1);
        }
    }
}

export function method15(v0_1: UH1_$union, v1_1: int64): US5_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US5_US5_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 789730223053602816n));
            const value = `accumulate_dice_rolls / power: ${23} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(value);
            return method16(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const value_1 = `accumulate_dice_rolls / power: ${23} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(value_1);
            return method16(v4_1, v1_1);
        }
    }
}

export function method14(v0_1_mut: UH1_$union, v1_1_mut: int8): int64 {
    method14:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v1_1 < 24) {
            let _v3: Option<uint8> = undefined;
            let x: uint8;
            const value: int32 = nonSeeded().Next2(1, 7) | 0;
            x = (value & 0xFF);
            _v3 = x;
            v0_1_mut = UH1_UH1_1((_v3 == null) ? (() => {
                throw new Error("base.run_target / _v3=None");
            })() : value_47(_v3), v0_1);
            v1_1_mut = (v1_1 + 1);
            continue method14;
        }
        else {
            const v18: US5_$union = method15(v0_1, 0n);
            if (v18.tag === /* US5_0 */ 0) {
                const v20: UH1_$union = v18.fields[1];
                const v19: int64 = v18.fields[0];
                if (compare(v19, 9223372036854775807n) <= 0) {
                    return v19;
                }
                else {
                    let _v22: Option<uint8> = undefined;
                    let x_2: uint8;
                    const value_1: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_2 = (value_1 & 0xFF);
                    _v22 = x_2;
                    let v32: uint8;
                    if (_v22 == null) {
                        throw new Error("base.run_target / _v22=None");
                    }
                    else {
                        v32 = value_47(_v22);
                    }
                    let _v33: Option<uint8> = undefined;
                    let x_4: uint8;
                    const value_2: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_4 = (value_2 & 0xFF);
                    _v33 = x_4;
                    let v43: uint8;
                    if (_v33 == null) {
                        throw new Error("base.run_target / _v33=None");
                    }
                    else {
                        v43 = value_47(_v33);
                    }
                    let _v44: Option<uint8> = undefined;
                    let x_6: uint8;
                    const value_3: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_6 = (value_3 & 0xFF);
                    _v44 = x_6;
                    let v54: uint8;
                    if (_v44 == null) {
                        throw new Error("base.run_target / _v44=None");
                    }
                    else {
                        v54 = value_47(_v44);
                    }
                    let _v55: Option<uint8> = undefined;
                    let x_8: uint8;
                    const value_4: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_8 = (value_4 & 0xFF);
                    _v55 = x_8;
                    let v65: uint8;
                    if (_v55 == null) {
                        throw new Error("base.run_target / _v55=None");
                    }
                    else {
                        v65 = value_47(_v55);
                    }
                    let _v66: Option<uint8> = undefined;
                    let x_10: uint8;
                    const value_5: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_10 = (value_5 & 0xFF);
                    _v66 = x_10;
                    let v76: uint8;
                    if (_v66 == null) {
                        throw new Error("base.run_target / _v66=None");
                    }
                    else {
                        v76 = value_47(_v66);
                    }
                    let _v77: Option<uint8> = undefined;
                    let x_12: uint8;
                    const value_6: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_12 = (value_6 & 0xFF);
                    _v77 = x_12;
                    let v87: uint8;
                    if (_v77 == null) {
                        throw new Error("base.run_target / _v77=None");
                    }
                    else {
                        v87 = value_47(_v77);
                    }
                    let _v88: Option<uint8> = undefined;
                    let x_14: uint8;
                    const value_7: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_14 = (value_7 & 0xFF);
                    _v88 = x_14;
                    let v98: uint8;
                    if (_v88 == null) {
                        throw new Error("base.run_target / _v88=None");
                    }
                    else {
                        v98 = value_47(_v88);
                    }
                    let _v99: Option<uint8> = undefined;
                    let x_16: uint8;
                    const value_8: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_16 = (value_8 & 0xFF);
                    _v99 = x_16;
                    let v109: uint8;
                    if (_v99 == null) {
                        throw new Error("base.run_target / _v99=None");
                    }
                    else {
                        v109 = value_47(_v99);
                    }
                    let _v110: Option<uint8> = undefined;
                    let x_18: uint8;
                    const value_9: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_18 = (value_9 & 0xFF);
                    _v110 = x_18;
                    let v120: uint8;
                    if (_v110 == null) {
                        throw new Error("base.run_target / _v110=None");
                    }
                    else {
                        v120 = value_47(_v110);
                    }
                    let _v121: Option<uint8> = undefined;
                    let x_20: uint8;
                    const value_10: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_20 = (value_10 & 0xFF);
                    _v121 = x_20;
                    let v131: uint8;
                    if (_v121 == null) {
                        throw new Error("base.run_target / _v121=None");
                    }
                    else {
                        v131 = value_47(_v121);
                    }
                    let _v132: Option<uint8> = undefined;
                    let x_22: uint8;
                    const value_11: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_22 = (value_11 & 0xFF);
                    _v132 = x_22;
                    let v142: uint8;
                    if (_v132 == null) {
                        throw new Error("base.run_target / _v132=None");
                    }
                    else {
                        v142 = value_47(_v132);
                    }
                    let _v143: Option<uint8> = undefined;
                    let x_24: uint8;
                    const value_12: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_24 = (value_12 & 0xFF);
                    _v143 = x_24;
                    let v153: uint8;
                    if (_v143 == null) {
                        throw new Error("base.run_target / _v143=None");
                    }
                    else {
                        v153 = value_47(_v143);
                    }
                    let _v154: Option<uint8> = undefined;
                    let x_26: uint8;
                    const value_13: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_26 = (value_13 & 0xFF);
                    _v154 = x_26;
                    let v164: uint8;
                    if (_v154 == null) {
                        throw new Error("base.run_target / _v154=None");
                    }
                    else {
                        v164 = value_47(_v154);
                    }
                    let _v165: Option<uint8> = undefined;
                    let x_28: uint8;
                    const value_14: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_28 = (value_14 & 0xFF);
                    _v165 = x_28;
                    let v175: uint8;
                    if (_v165 == null) {
                        throw new Error("base.run_target / _v165=None");
                    }
                    else {
                        v175 = value_47(_v165);
                    }
                    let _v176: Option<uint8> = undefined;
                    let x_30: uint8;
                    const value_15: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_30 = (value_15 & 0xFF);
                    _v176 = x_30;
                    let v186: uint8;
                    if (_v176 == null) {
                        throw new Error("base.run_target / _v176=None");
                    }
                    else {
                        v186 = value_47(_v176);
                    }
                    let _v187: Option<uint8> = undefined;
                    let x_32: uint8;
                    const value_16: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_32 = (value_16 & 0xFF);
                    _v187 = x_32;
                    let v197: uint8;
                    if (_v187 == null) {
                        throw new Error("base.run_target / _v187=None");
                    }
                    else {
                        v197 = value_47(_v187);
                    }
                    let _v198: Option<uint8> = undefined;
                    let x_34: uint8;
                    const value_17: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_34 = (value_17 & 0xFF);
                    _v198 = x_34;
                    let v208: uint8;
                    if (_v198 == null) {
                        throw new Error("base.run_target / _v198=None");
                    }
                    else {
                        v208 = value_47(_v198);
                    }
                    let _v209: Option<uint8> = undefined;
                    let x_36: uint8;
                    const value_18: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_36 = (value_18 & 0xFF);
                    _v209 = x_36;
                    let v219: uint8;
                    if (_v209 == null) {
                        throw new Error("base.run_target / _v209=None");
                    }
                    else {
                        v219 = value_47(_v209);
                    }
                    let _v220: Option<uint8> = undefined;
                    let x_38: uint8;
                    const value_19: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_38 = (value_19 & 0xFF);
                    _v220 = x_38;
                    let v230: uint8;
                    if (_v220 == null) {
                        throw new Error("base.run_target / _v220=None");
                    }
                    else {
                        v230 = value_47(_v220);
                    }
                    let _v231: Option<uint8> = undefined;
                    let x_40: uint8;
                    const value_20: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_40 = (value_20 & 0xFF);
                    _v231 = x_40;
                    let v241: uint8;
                    if (_v231 == null) {
                        throw new Error("base.run_target / _v231=None");
                    }
                    else {
                        v241 = value_47(_v231);
                    }
                    let _v242: Option<uint8> = undefined;
                    let x_42: uint8;
                    const value_21: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_42 = (value_21 & 0xFF);
                    _v242 = x_42;
                    let v252: uint8;
                    if (_v242 == null) {
                        throw new Error("base.run_target / _v242=None");
                    }
                    else {
                        v252 = value_47(_v242);
                    }
                    let _v253: Option<uint8> = undefined;
                    let x_44: uint8;
                    const value_22: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_44 = (value_22 & 0xFF);
                    _v253 = x_44;
                    let v263: uint8;
                    if (_v253 == null) {
                        throw new Error("base.run_target / _v253=None");
                    }
                    else {
                        v263 = value_47(_v253);
                    }
                    let _v264: Option<uint8> = undefined;
                    let x_46: uint8;
                    const value_23: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_46 = (value_23 & 0xFF);
                    _v264 = x_46;
                    v0_1_mut = UH1_UH1_1(v32, UH1_UH1_1(v43, UH1_UH1_1(v54, UH1_UH1_1(v65, UH1_UH1_1(v76, UH1_UH1_1(v87, UH1_UH1_1(v98, UH1_UH1_1(v109, UH1_UH1_1(v120, UH1_UH1_1(v131, UH1_UH1_1(v142, UH1_UH1_1(v153, UH1_UH1_1(v164, UH1_UH1_1(v175, UH1_UH1_1(v186, UH1_UH1_1(v197, UH1_UH1_1(v208, UH1_UH1_1(v219, UH1_UH1_1(v230, UH1_UH1_1(v241, UH1_UH1_1(v252, UH1_UH1_1(v263, UH1_UH1_1((_v264 == null) ? (() => {
                        throw new Error("base.run_target / _v264=None");
                    })() : value_47(_v264), UH1_UH1_0())))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method14;
                }
            }
            else {
                let _v302: Option<uint8> = undefined;
                let x_48: uint8;
                const value_24: int32 = nonSeeded().Next2(1, 7) | 0;
                x_48 = (value_24 & 0xFF);
                _v302 = x_48;
                let v312: uint8;
                if (_v302 == null) {
                    throw new Error("base.run_target / _v302=None");
                }
                else {
                    v312 = value_47(_v302);
                }
                let _v313: Option<uint8> = undefined;
                let x_50: uint8;
                const value_25: int32 = nonSeeded().Next2(1, 7) | 0;
                x_50 = (value_25 & 0xFF);
                _v313 = x_50;
                let v323: uint8;
                if (_v313 == null) {
                    throw new Error("base.run_target / _v313=None");
                }
                else {
                    v323 = value_47(_v313);
                }
                let _v324: Option<uint8> = undefined;
                let x_52: uint8;
                const value_26: int32 = nonSeeded().Next2(1, 7) | 0;
                x_52 = (value_26 & 0xFF);
                _v324 = x_52;
                let v334: uint8;
                if (_v324 == null) {
                    throw new Error("base.run_target / _v324=None");
                }
                else {
                    v334 = value_47(_v324);
                }
                let _v335: Option<uint8> = undefined;
                let x_54: uint8;
                const value_27: int32 = nonSeeded().Next2(1, 7) | 0;
                x_54 = (value_27 & 0xFF);
                _v335 = x_54;
                let v345: uint8;
                if (_v335 == null) {
                    throw new Error("base.run_target / _v335=None");
                }
                else {
                    v345 = value_47(_v335);
                }
                let _v346: Option<uint8> = undefined;
                let x_56: uint8;
                const value_28: int32 = nonSeeded().Next2(1, 7) | 0;
                x_56 = (value_28 & 0xFF);
                _v346 = x_56;
                let v356: uint8;
                if (_v346 == null) {
                    throw new Error("base.run_target / _v346=None");
                }
                else {
                    v356 = value_47(_v346);
                }
                let _v357: Option<uint8> = undefined;
                let x_58: uint8;
                const value_29: int32 = nonSeeded().Next2(1, 7) | 0;
                x_58 = (value_29 & 0xFF);
                _v357 = x_58;
                let v367: uint8;
                if (_v357 == null) {
                    throw new Error("base.run_target / _v357=None");
                }
                else {
                    v367 = value_47(_v357);
                }
                let _v368: Option<uint8> = undefined;
                let x_60: uint8;
                const value_30: int32 = nonSeeded().Next2(1, 7) | 0;
                x_60 = (value_30 & 0xFF);
                _v368 = x_60;
                let v378: uint8;
                if (_v368 == null) {
                    throw new Error("base.run_target / _v368=None");
                }
                else {
                    v378 = value_47(_v368);
                }
                let _v379: Option<uint8> = undefined;
                let x_62: uint8;
                const value_31: int32 = nonSeeded().Next2(1, 7) | 0;
                x_62 = (value_31 & 0xFF);
                _v379 = x_62;
                let v389: uint8;
                if (_v379 == null) {
                    throw new Error("base.run_target / _v379=None");
                }
                else {
                    v389 = value_47(_v379);
                }
                let _v390: Option<uint8> = undefined;
                let x_64: uint8;
                const value_32: int32 = nonSeeded().Next2(1, 7) | 0;
                x_64 = (value_32 & 0xFF);
                _v390 = x_64;
                let v400: uint8;
                if (_v390 == null) {
                    throw new Error("base.run_target / _v390=None");
                }
                else {
                    v400 = value_47(_v390);
                }
                let _v401: Option<uint8> = undefined;
                let x_66: uint8;
                const value_33: int32 = nonSeeded().Next2(1, 7) | 0;
                x_66 = (value_33 & 0xFF);
                _v401 = x_66;
                let v411: uint8;
                if (_v401 == null) {
                    throw new Error("base.run_target / _v401=None");
                }
                else {
                    v411 = value_47(_v401);
                }
                let _v412: Option<uint8> = undefined;
                let x_68: uint8;
                const value_34: int32 = nonSeeded().Next2(1, 7) | 0;
                x_68 = (value_34 & 0xFF);
                _v412 = x_68;
                let v422: uint8;
                if (_v412 == null) {
                    throw new Error("base.run_target / _v412=None");
                }
                else {
                    v422 = value_47(_v412);
                }
                let _v423: Option<uint8> = undefined;
                let x_70: uint8;
                const value_35: int32 = nonSeeded().Next2(1, 7) | 0;
                x_70 = (value_35 & 0xFF);
                _v423 = x_70;
                let v433: uint8;
                if (_v423 == null) {
                    throw new Error("base.run_target / _v423=None");
                }
                else {
                    v433 = value_47(_v423);
                }
                let _v434: Option<uint8> = undefined;
                let x_72: uint8;
                const value_36: int32 = nonSeeded().Next2(1, 7) | 0;
                x_72 = (value_36 & 0xFF);
                _v434 = x_72;
                let v444: uint8;
                if (_v434 == null) {
                    throw new Error("base.run_target / _v434=None");
                }
                else {
                    v444 = value_47(_v434);
                }
                let _v445: Option<uint8> = undefined;
                let x_74: uint8;
                const value_37: int32 = nonSeeded().Next2(1, 7) | 0;
                x_74 = (value_37 & 0xFF);
                _v445 = x_74;
                let v455: uint8;
                if (_v445 == null) {
                    throw new Error("base.run_target / _v445=None");
                }
                else {
                    v455 = value_47(_v445);
                }
                let _v456: Option<uint8> = undefined;
                let x_76: uint8;
                const value_38: int32 = nonSeeded().Next2(1, 7) | 0;
                x_76 = (value_38 & 0xFF);
                _v456 = x_76;
                let v466: uint8;
                if (_v456 == null) {
                    throw new Error("base.run_target / _v456=None");
                }
                else {
                    v466 = value_47(_v456);
                }
                let _v467: Option<uint8> = undefined;
                let x_78: uint8;
                const value_39: int32 = nonSeeded().Next2(1, 7) | 0;
                x_78 = (value_39 & 0xFF);
                _v467 = x_78;
                let v477: uint8;
                if (_v467 == null) {
                    throw new Error("base.run_target / _v467=None");
                }
                else {
                    v477 = value_47(_v467);
                }
                let _v478: Option<uint8> = undefined;
                let x_80: uint8;
                const value_40: int32 = nonSeeded().Next2(1, 7) | 0;
                x_80 = (value_40 & 0xFF);
                _v478 = x_80;
                let v488: uint8;
                if (_v478 == null) {
                    throw new Error("base.run_target / _v478=None");
                }
                else {
                    v488 = value_47(_v478);
                }
                let _v489: Option<uint8> = undefined;
                let x_82: uint8;
                const value_41: int32 = nonSeeded().Next2(1, 7) | 0;
                x_82 = (value_41 & 0xFF);
                _v489 = x_82;
                let v499: uint8;
                if (_v489 == null) {
                    throw new Error("base.run_target / _v489=None");
                }
                else {
                    v499 = value_47(_v489);
                }
                let _v500: Option<uint8> = undefined;
                let x_84: uint8;
                const value_42: int32 = nonSeeded().Next2(1, 7) | 0;
                x_84 = (value_42 & 0xFF);
                _v500 = x_84;
                let v510: uint8;
                if (_v500 == null) {
                    throw new Error("base.run_target / _v500=None");
                }
                else {
                    v510 = value_47(_v500);
                }
                let _v511: Option<uint8> = undefined;
                let x_86: uint8;
                const value_43: int32 = nonSeeded().Next2(1, 7) | 0;
                x_86 = (value_43 & 0xFF);
                _v511 = x_86;
                let v521: uint8;
                if (_v511 == null) {
                    throw new Error("base.run_target / _v511=None");
                }
                else {
                    v521 = value_47(_v511);
                }
                let _v522: Option<uint8> = undefined;
                let x_88: uint8;
                const value_44: int32 = nonSeeded().Next2(1, 7) | 0;
                x_88 = (value_44 & 0xFF);
                _v522 = x_88;
                let v532: uint8;
                if (_v522 == null) {
                    throw new Error("base.run_target / _v522=None");
                }
                else {
                    v532 = value_47(_v522);
                }
                let _v533: Option<uint8> = undefined;
                let x_90: uint8;
                const value_45: int32 = nonSeeded().Next2(1, 7) | 0;
                x_90 = (value_45 & 0xFF);
                _v533 = x_90;
                let v543: uint8;
                if (_v533 == null) {
                    throw new Error("base.run_target / _v533=None");
                }
                else {
                    v543 = value_47(_v533);
                }
                let _v544: Option<uint8> = undefined;
                let x_92: uint8;
                const value_46: int32 = nonSeeded().Next2(1, 7) | 0;
                x_92 = (value_46 & 0xFF);
                _v544 = x_92;
                v0_1_mut = UH1_UH1_1(v312, UH1_UH1_1(v323, UH1_UH1_1(v334, UH1_UH1_1(v345, UH1_UH1_1(v356, UH1_UH1_1(v367, UH1_UH1_1(v378, UH1_UH1_1(v389, UH1_UH1_1(v400, UH1_UH1_1(v411, UH1_UH1_1(v422, UH1_UH1_1(v433, UH1_UH1_1(v444, UH1_UH1_1(v455, UH1_UH1_1(v466, UH1_UH1_1(v477, UH1_UH1_1(v488, UH1_UH1_1(v499, UH1_UH1_1(v510, UH1_UH1_1(v521, UH1_UH1_1(v532, UH1_UH1_1(v543, UH1_UH1_1((_v544 == null) ? (() => {
                    throw new Error("base.run_target / _v544=None");
                })() : value_47(_v544), UH1_UH1_0())))))))))))))))))))))));
                v1_1_mut = 23;
                continue method14;
            }
        }
        break;
    }
}

export function closure80(unitVar: void, v0_1: string[]): int32 {
    const value = `calculate_dice_count / max: ${9223372036854775807n} / n: ${24} / p: ${4738381338321616896n}`;
    console.log(value);
    const value_1 = `result: ${method14(UH1_UH1_0(), 0)}`;
    console.log(value_1);
    return 0;
}

export const v0 = (v: int64): ((arg0: UH0_$union) => UH0_$union) => closure0(undefined, v);

export function rotate_numbers(x: int64): ((arg0: UH0_$union) => UH0_$union) {
    return v0(x);
}

export const v1 = (v: Option<((arg0: string) => void)>): ((arg0: UH1_$union) => (() => uint8)) => closure3(undefined, v);

export function create_sequential_roller(x: Option<((arg0: string) => void)>): ((arg0: UH1_$union) => (() => uint8)) {
    return v1(x);
}

export const v2 = (v: Option<((arg0: string) => void)>): ((arg0: (() => uint8)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) => closure9(undefined, v);

export function roll_progressively(x: Option<((arg0: string) => void)>): ((arg0: (() => uint8)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) {
    return v2(x);
}

export const v3 = (v: Option<((arg0: string) => void)>): ((arg0: uint64) => ((arg0: UH1_$union) => Option<uint64>)) => closure77(undefined, v);

export function roll_within_bounds(x: Option<((arg0: string) => void)>): ((arg0: uint64) => ((arg0: UH1_$union) => Option<uint64>)) {
    return v3(x);
}

export const v4 = (v: string[]): int32 => closure80(undefined, v);

(v4)(typeof process === 'object' ? process.argv.slice(2) : []);

