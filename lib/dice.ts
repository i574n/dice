import { FSharpRef, Record, Union } from "./fable_modules/fable-library-ts.4.14.0/Types.js";
import { int32, int8, uint8 } from "./fable_modules/fable-library-ts.4.14.0/Int32.js";
import { uint64_type, int64_type, record_type, string_type, union_type, lambda_type, unit_type, uint8_type, TypeInfo } from "./fable_modules/fable-library-ts.4.14.0/Reflection.js";
import { op_Multiply, toUInt64, equals, compare, toUInt8, fromUInt8, op_Subtraction, op_Modulus, op_Addition, toInt64, uint64, int64 } from "./fable_modules/fable-library-ts.4.14.0/BigInt.js";
import { IComparable, IEquatable } from "./fable_modules/fable-library-ts.4.14.0/Util.js";
import { interpolate, toText } from "./fable_modules/fable-library-ts.4.14.0/String.js";
import { value as value_47, Option, map, defaultArg } from "./fable_modules/fable-library-ts.4.14.0/Option.js";
import { nonSeeded } from "./fable_modules/fable-library-ts.4.14.0/Random.js";

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
        return UH0_UH0_0(toUInt8(v11) & 0xFF, (): UH0_$union => closure2(v6, void 0));
    }
}

export function closure1(v0_1: int64, v1_1: UH0_$union): UH0_$union {
    return method0(v0_1, v1_1, UH0_UH0_1());
}

export function closure0(unitVar: void, v0_1: int64): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure1(v0_1, v);
}

export function closure4(unitVar: void, v0_1: ((arg0: string) => void)): US0_$union {
    return US0_US0_0(v0_1);
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

export function closure6(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method3(v0_1: UH1_$union, v1_1: UH0_$union): UH0_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        const v2_1: uint8 = v0_1.fields[0];
        const v4_1: UH0_$union = method3(v0_1.fields[1], v1_1);
        return UH0_UH0_0(v2_1, (): UH0_$union => closure6(v4_1, void 0));
    }
}

export function closure7(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function closure8(v0_1: UH0_$union, v1_1: Mut0, unitVar: void): UH0_$union {
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
    return (): UH0_$union => closure8(v0_1, v3_1, void 0);
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

export function closure9(v0_1: US0_$union, v1_1: (() => UH0_$union), v2_1: Mut1, v3_1: Mut1, v4_1: Mut1, v5: Mut2, unitVar: void): uint8 {
    return method5(v0_1, v1_1, v2_1, v3_1, v4_1, v5);
}

export function closure5(v0_1: US0_$union, v1_1: UH1_$union): (() => uint8) {
    if (v0_1.tag === /* US0_0 */ 0) {
        v0_1.fields[0]("create_sequential_roller ()");
    }
    const v8: UH0_$union = method3(method2(v1_1, method1(v1_1, UH1_UH1_0())), UH0_UH0_1());
    const v10: (() => UH0_$union) = method4(v8, (): UH0_$union => closure7(v8, void 0));
    const v11: Mut1 = new Mut1(0n);
    const v12: Mut1 = new Mut1(1n);
    const v13: Mut1 = new Mut1(-1n);
    const v15: Mut2 = new Mut2(US2_US2_1());
    return (): uint8 => closure9(v0_1, v10, v11, v12, v13, v15, void 0);
}

export function closure3(unitVar: void, v0_1: Option<((arg0: string) => void)>): ((arg0: UH1_$union) => (() => uint8)) {
    const v3_1: US0_$union = defaultArg(map<((arg0: string) => void), US0_$union>((v: ((arg0: string) => void)): US0_$union => closure4(void 0, v), v0_1), US0_US0_1());
    return (v_1: UH1_$union): (() => uint8) => closure5(v3_1, v_1);
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

export function closure77(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(0n, (): UH2_$union => closure77(void 0, void 0));
}

export function closure76(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9223372036854775808n, (): UH2_$union => closure77(void 0, void 0));
}

export function closure75(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4611686018427387904n, (): UH2_$union => closure76(void 0, void 0));
}

export function closure74(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6917529027641081856n, (): UH2_$union => closure75(void 0, void 0));
}

export function closure73(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1152921504606846976n, (): UH2_$union => closure74(void 0, void 0));
}

export function closure72(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(15564440312192434176n, (): UH2_$union => closure73(void 0, void 0));
}

export function closure71(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11817445422220181504n, (): UH2_$union => closure72(void 0, void 0));
}

export function closure70(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5044031582654955520n, (): UH2_$union => closure71(void 0, void 0));
}

export function closure69(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6989586621679009792n, (): UH2_$union => closure70(void 0, void 0));
}

export function closure68(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16537217831704461312n, (): UH2_$union => closure69(void 0, void 0));
}

export function closure67(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11979575008805519360n, (): UH2_$union => closure68(void 0, void 0));
}

export function closure66(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14294425217273954304n, (): UH2_$union => closure67(void 0, void 0));
}

export function closure65(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2382404202878992384n, (): UH2_$union => closure66(void 0, void 0));
}

export function closure64(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6545982058383015936n, (): UH2_$union => closure65(void 0, void 0));
}

export function closure63(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10314369046585278464n, (): UH2_$union => closure64(void 0, void 0));
}

export function closure62(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4793518853382471680n, (): UH2_$union => closure63(void 0, void 0));
}

export function closure61(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3873377154515337216n, (): UH2_$union => closure62(void 0, void 0));
}

export function closure60(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(645562859085889536n, (): UH2_$union => closure61(void 0, void 0));
}

export function closure59(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(107593809847648256n, (): UH2_$union => closure60(void 0, void 0));
}

export function closure58(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3092389647259533312n, (): UH2_$union => closure59(void 0, void 0));
}

export function closure57(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9738770311398031360n, (): UH2_$union => closure58(void 0, void 0));
}

export function closure56(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16995415113324298240n, (): UH2_$union => closure57(void 0, void 0));
}

export function closure55(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8981483876790566912n, (): UH2_$union => closure56(void 0, void 0));
}

export function closure54(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13794743361938128896n, (): UH2_$union => closure55(void 0, void 0));
}

export function closure53(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2299123893656354816n, (): UH2_$union => closure54(void 0, void 0));
}

export function closure52(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3457644661227651072n, (): UH2_$union => closure53(void 0, void 0));
}

export function closure51(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(576274110204608512n, (): UH2_$union => closure52(void 0, void 0));
}

export function closure50(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6244960376270618624n, (): UH2_$union => closure51(void 0, void 0));
}

export function closure49(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13338656111851470848n, (): UH2_$union => closure50(void 0, void 0));
}

export function closure48(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14520938734448279552n, (): UH2_$union => closure49(void 0, void 0));
}

export function closure47(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14717985838214414336n, (): UH2_$union => closure48(void 0, void 0));
}

export function closure46(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5527454985320660992n, (): UH2_$union => closure47(void 0, void 0));
}

export function closure45(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16293529225644736512n, (): UH2_$union => closure46(void 0, void 0));
}

export function closure44(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11938960241128898560n, (): UH2_$union => closure45(void 0, void 0));
}

export function closure43(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8138741398091333632n, (): UH2_$union => closure44(void 0, void 0));
}

export function closure42(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7505371590918406144n, (): UH2_$union => closure43(void 0, void 0));
}

export function closure41(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16623181993244360704n, (): UH2_$union => closure42(void 0, void 0));
}

export function closure40(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8919445023443910656n, (): UH2_$union => closure41(void 0, void 0));
}

export function closure39(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4561031516192243712n, (): UH2_$union => closure40(void 0, void 0));
}

export function closure38(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9983543956220149760n, (): UH2_$union => closure39(void 0, void 0));
}

export function closure37(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4738381338321616896n, (): UH2_$union => closure38(void 0, void 0));
}

export function closure36(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(789730223053602816n, (): UH2_$union => closure37(void 0, void 0));
}

export function closure35(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(131621703842267136n, (): UH2_$union => closure36(void 0, void 0));
}

export function closure34(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(21936950640377856n, (): UH2_$union => closure35(void 0, void 0));
}

export function closure33(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3656158440062976n, (): UH2_$union => closure34(void 0, void 0));
}

export function closure32(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(609359740010496n, (): UH2_$union => closure33(void 0, void 0));
}

export function closure31(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(101559956668416n, (): UH2_$union => closure32(void 0, void 0));
}

export function closure30(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16926659444736n, (): UH2_$union => closure31(void 0, void 0));
}

export function closure29(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2821109907456n, (): UH2_$union => closure30(void 0, void 0));
}

export function closure28(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(470184984576n, (): UH2_$union => closure29(void 0, void 0));
}

export function closure27(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(78364164096n, (): UH2_$union => closure28(void 0, void 0));
}

export function closure26(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13060694016n, (): UH2_$union => closure27(void 0, void 0));
}

export function closure25(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2176782336n, (): UH2_$union => closure26(void 0, void 0));
}

export function closure24(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(362797056n, (): UH2_$union => closure25(void 0, void 0));
}

export function closure23(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(60466176n, (): UH2_$union => closure24(void 0, void 0));
}

export function closure22(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10077696n, (): UH2_$union => closure23(void 0, void 0));
}

export function closure21(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1679616n, (): UH2_$union => closure22(void 0, void 0));
}

export function closure20(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(279936n, (): UH2_$union => closure21(void 0, void 0));
}

export function closure19(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(46656n, (): UH2_$union => closure20(void 0, void 0));
}

export function closure18(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7776n, (): UH2_$union => closure19(void 0, void 0));
}

export function closure17(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1296n, (): UH2_$union => closure18(void 0, void 0));
}

export function closure16(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(216n, (): UH2_$union => closure17(void 0, void 0));
}

export function closure15(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(36n, (): UH2_$union => closure16(void 0, void 0));
}

export function closure14(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6n, (): UH2_$union => closure15(void 0, void 0));
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
                const v16: US4_$union = method10(v1_1, UH2_UH2_0(1n, (): UH2_$union => closure14(void 0, void 0)));
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

export function closure13(v0_1: US0_$union, v1_1: (() => uint8), v2_1: boolean, v3_1: uint64): uint64 {
    return method8(v0_1, v1_1, v2_1, v3_1, (equals(v3_1, 1n) ? 1 : method7(v0_1, v3_1, 0, 1n)) - 1, UH1_UH1_0(), 0);
}

export function closure12(v0_1: US0_$union, v1_1: (() => uint8), v2_1: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure13(v0_1, v1_1, v2_1, v);
}

export function closure11(v0_1: US0_$union, v1_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure12(v0_1, v1_1, v);
}

export function closure10(unitVar: void, v0_1: Option<((arg0: string) => void)>): ((arg0: (() => uint8)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) {
    const v3_1: US0_$union = defaultArg(map<((arg0: string) => void), US0_$union>((v: ((arg0: string) => void)): US0_$union => closure4(void 0, v), v0_1), US0_US0_1());
    return (v_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) => closure11(v3_1, v_1);
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

export function closure80(v0_1: Option<((arg0: string) => void)>, v1_1: uint64, v2_1: UH1_$union): Option<uint64> {
    const v10: US3_$union = method9(defaultArg(map<((arg0: string) => void), US0_$union>((v: ((arg0: string) => void)): US0_$union => closure4(void 0, v), v0_1), US0_US0_1()), method13(v2_1, 0) - 1, v2_1, 0n);
    let v20: US4_$union;
    if (v10.tag === /* US3_0 */ 0) {
        const v12: UH1_$union = v10.fields[1];
        const v11: uint64 = v10.fields[0];
        v20 = (((compare(v11, 1n) >= 0) && (compare(v11, v1_1) <= 0)) ? US4_US4_0(v11) : US4_US4_1());
    }
    else {
        v20 = US4_US4_1();
    }
    if (v20.tag === /* US4_0 */ 0) {
        return v20.fields[0];
    }
    else {
        return void 0;
    }
}

export function closure79(v0_1: Option<((arg0: string) => void)>, v1_1: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return (v: UH1_$union): Option<uint64> => closure80(v0_1, v1_1, v);
}

export function closure78(unitVar: void, v0_1: Option<((arg0: string) => void)>): ((arg0: uint64) => ((arg0: UH1_$union) => Option<uint64>)) {
    return (v: uint64): ((arg0: UH1_$union) => Option<uint64>) => closure79(v0_1, v);
}

export function method39(v0_1: UH1_$union, v1_1: int64): US5_$union {
    const v2_1: int64 = toInt64(op_Addition(v1_1, 1n));
    const v3_1 = `accumulate_dice_rolls / power: ${-1} / acc: ${v1_1} / result: ${v2_1}`;
    console.log(v3_1);
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
            const v8 = `accumulate_dice_rolls / power: ${0} / acc: ${v1_1} / roll: ${v3_1} / value: ${v7}`;
            console.log(v8);
            return method39(v4_1, toInt64(op_Addition(v1_1, v7)));
        }
        else {
            const v11 = `accumulate_dice_rolls / power: ${0} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v11);
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
            const v9 = `accumulate_dice_rolls / power: ${1} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method38(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${1} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${2} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method37(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${2} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${3} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method36(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${3} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${4} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method35(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${4} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${5} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method34(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${5} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${6} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method33(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${6} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${7} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method32(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${7} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${8} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method31(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${8} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${9} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method30(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${9} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${10} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method29(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${10} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${11} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method28(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${11} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${12} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method27(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${12} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${13} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method26(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${13} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${14} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method25(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${14} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${15} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method24(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${15} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${16} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method23(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${16} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${17} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method22(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${17} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${18} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method21(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${18} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${19} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method20(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${19} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${20} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method19(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${20} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${21} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method18(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${21} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${22} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method17(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${22} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
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
            const v9 = `accumulate_dice_rolls / power: ${23} / acc: ${v1_1} / roll: ${v3_1} / value: ${v8}`;
            console.log(v9);
            return method16(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            const v12 = `accumulate_dice_rolls / power: ${23} / acc: ${v1_1} / roll: ${v3_1}`;
            console.log(v12);
            return method16(v4_1, v1_1);
        }
    }
}

export function method14(v0_1_mut: UH1_$union, v1_1_mut: int8): int64 {
    method14:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v1_1 < 24) {
            let _v3: Option<uint8> = void 0;
            let x: uint8;
            const value: int32 = nonSeeded().Next2(1, 7) | 0;
            x = (value & 0xFF);
            _v3 = x;
            v0_1_mut = UH1_UH1_1(value_47(_v3), v0_1);
            v1_1_mut = (v1_1 + 1);
            continue method14;
        }
        else {
            const v16: US5_$union = method15(v0_1, 0n);
            if (v16.tag === /* US5_0 */ 0) {
                const v18: UH1_$union = v16.fields[1];
                const v17: int64 = v16.fields[0];
                if (compare(v17, 9223372036854775807n) <= 0) {
                    return v17;
                }
                else {
                    let _v20: Option<uint8> = void 0;
                    let x_1: uint8;
                    const value_1: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_1 = (value_1 & 0xFF);
                    _v20 = x_1;
                    const v28: uint8 = value_47(_v20);
                    let _v29: Option<uint8> = void 0;
                    let x_2: uint8;
                    const value_2: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_2 = (value_2 & 0xFF);
                    _v29 = x_2;
                    const v35: uint8 = value_47(_v29);
                    let _v36: Option<uint8> = void 0;
                    let x_3: uint8;
                    const value_3: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_3 = (value_3 & 0xFF);
                    _v36 = x_3;
                    const v42: uint8 = value_47(_v36);
                    let _v43: Option<uint8> = void 0;
                    let x_4: uint8;
                    const value_4: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_4 = (value_4 & 0xFF);
                    _v43 = x_4;
                    const v49: uint8 = value_47(_v43);
                    let _v50: Option<uint8> = void 0;
                    let x_5: uint8;
                    const value_5: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_5 = (value_5 & 0xFF);
                    _v50 = x_5;
                    const v56: uint8 = value_47(_v50);
                    let _v57: Option<uint8> = void 0;
                    let x_6: uint8;
                    const value_6: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_6 = (value_6 & 0xFF);
                    _v57 = x_6;
                    const v63: uint8 = value_47(_v57);
                    let _v64: Option<uint8> = void 0;
                    let x_7: uint8;
                    const value_7: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_7 = (value_7 & 0xFF);
                    _v64 = x_7;
                    const v70: uint8 = value_47(_v64);
                    let _v71: Option<uint8> = void 0;
                    let x_8: uint8;
                    const value_8: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_8 = (value_8 & 0xFF);
                    _v71 = x_8;
                    const v77: uint8 = value_47(_v71);
                    let _v78: Option<uint8> = void 0;
                    let x_9: uint8;
                    const value_9: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_9 = (value_9 & 0xFF);
                    _v78 = x_9;
                    const v84: uint8 = value_47(_v78);
                    let _v85: Option<uint8> = void 0;
                    let x_10: uint8;
                    const value_10: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_10 = (value_10 & 0xFF);
                    _v85 = x_10;
                    const v91: uint8 = value_47(_v85);
                    let _v92: Option<uint8> = void 0;
                    let x_11: uint8;
                    const value_11: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_11 = (value_11 & 0xFF);
                    _v92 = x_11;
                    const v98: uint8 = value_47(_v92);
                    let _v99: Option<uint8> = void 0;
                    let x_12: uint8;
                    const value_12: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_12 = (value_12 & 0xFF);
                    _v99 = x_12;
                    const v105: uint8 = value_47(_v99);
                    let _v106: Option<uint8> = void 0;
                    let x_13: uint8;
                    const value_13: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_13 = (value_13 & 0xFF);
                    _v106 = x_13;
                    const v112: uint8 = value_47(_v106);
                    let _v113: Option<uint8> = void 0;
                    let x_14: uint8;
                    const value_14: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_14 = (value_14 & 0xFF);
                    _v113 = x_14;
                    const v119: uint8 = value_47(_v113);
                    let _v120: Option<uint8> = void 0;
                    let x_15: uint8;
                    const value_15: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_15 = (value_15 & 0xFF);
                    _v120 = x_15;
                    const v126: uint8 = value_47(_v120);
                    let _v127: Option<uint8> = void 0;
                    let x_16: uint8;
                    const value_16: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_16 = (value_16 & 0xFF);
                    _v127 = x_16;
                    const v133: uint8 = value_47(_v127);
                    let _v134: Option<uint8> = void 0;
                    let x_17: uint8;
                    const value_17: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_17 = (value_17 & 0xFF);
                    _v134 = x_17;
                    const v140: uint8 = value_47(_v134);
                    let _v141: Option<uint8> = void 0;
                    let x_18: uint8;
                    const value_18: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_18 = (value_18 & 0xFF);
                    _v141 = x_18;
                    const v147: uint8 = value_47(_v141);
                    let _v148: Option<uint8> = void 0;
                    let x_19: uint8;
                    const value_19: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_19 = (value_19 & 0xFF);
                    _v148 = x_19;
                    const v154: uint8 = value_47(_v148);
                    let _v155: Option<uint8> = void 0;
                    let x_20: uint8;
                    const value_20: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_20 = (value_20 & 0xFF);
                    _v155 = x_20;
                    const v161: uint8 = value_47(_v155);
                    let _v162: Option<uint8> = void 0;
                    let x_21: uint8;
                    const value_21: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_21 = (value_21 & 0xFF);
                    _v162 = x_21;
                    const v168: uint8 = value_47(_v162);
                    let _v169: Option<uint8> = void 0;
                    let x_22: uint8;
                    const value_22: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_22 = (value_22 & 0xFF);
                    _v169 = x_22;
                    const v175: uint8 = value_47(_v169);
                    let _v176: Option<uint8> = void 0;
                    let x_23: uint8;
                    const value_23: int32 = nonSeeded().Next2(1, 7) | 0;
                    x_23 = (value_23 & 0xFF);
                    _v176 = x_23;
                    v0_1_mut = UH1_UH1_1(v28, UH1_UH1_1(v35, UH1_UH1_1(v42, UH1_UH1_1(v49, UH1_UH1_1(v56, UH1_UH1_1(v63, UH1_UH1_1(v70, UH1_UH1_1(v77, UH1_UH1_1(v84, UH1_UH1_1(v91, UH1_UH1_1(v98, UH1_UH1_1(v105, UH1_UH1_1(v112, UH1_UH1_1(v119, UH1_UH1_1(v126, UH1_UH1_1(v133, UH1_UH1_1(v140, UH1_UH1_1(v147, UH1_UH1_1(v154, UH1_UH1_1(v161, UH1_UH1_1(v168, UH1_UH1_1(v175, UH1_UH1_1(value_47(_v176), UH1_UH1_0())))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method14;
                }
            }
            else {
                let _v210: Option<uint8> = void 0;
                let x_24: uint8;
                const value_24: int32 = nonSeeded().Next2(1, 7) | 0;
                x_24 = (value_24 & 0xFF);
                _v210 = x_24;
                const v218: uint8 = value_47(_v210);
                let _v219: Option<uint8> = void 0;
                let x_25: uint8;
                const value_25: int32 = nonSeeded().Next2(1, 7) | 0;
                x_25 = (value_25 & 0xFF);
                _v219 = x_25;
                const v225: uint8 = value_47(_v219);
                let _v226: Option<uint8> = void 0;
                let x_26: uint8;
                const value_26: int32 = nonSeeded().Next2(1, 7) | 0;
                x_26 = (value_26 & 0xFF);
                _v226 = x_26;
                const v232: uint8 = value_47(_v226);
                let _v233: Option<uint8> = void 0;
                let x_27: uint8;
                const value_27: int32 = nonSeeded().Next2(1, 7) | 0;
                x_27 = (value_27 & 0xFF);
                _v233 = x_27;
                const v239: uint8 = value_47(_v233);
                let _v240: Option<uint8> = void 0;
                let x_28: uint8;
                const value_28: int32 = nonSeeded().Next2(1, 7) | 0;
                x_28 = (value_28 & 0xFF);
                _v240 = x_28;
                const v246: uint8 = value_47(_v240);
                let _v247: Option<uint8> = void 0;
                let x_29: uint8;
                const value_29: int32 = nonSeeded().Next2(1, 7) | 0;
                x_29 = (value_29 & 0xFF);
                _v247 = x_29;
                const v253: uint8 = value_47(_v247);
                let _v254: Option<uint8> = void 0;
                let x_30: uint8;
                const value_30: int32 = nonSeeded().Next2(1, 7) | 0;
                x_30 = (value_30 & 0xFF);
                _v254 = x_30;
                const v260: uint8 = value_47(_v254);
                let _v261: Option<uint8> = void 0;
                let x_31: uint8;
                const value_31: int32 = nonSeeded().Next2(1, 7) | 0;
                x_31 = (value_31 & 0xFF);
                _v261 = x_31;
                const v267: uint8 = value_47(_v261);
                let _v268: Option<uint8> = void 0;
                let x_32: uint8;
                const value_32: int32 = nonSeeded().Next2(1, 7) | 0;
                x_32 = (value_32 & 0xFF);
                _v268 = x_32;
                const v274: uint8 = value_47(_v268);
                let _v275: Option<uint8> = void 0;
                let x_33: uint8;
                const value_33: int32 = nonSeeded().Next2(1, 7) | 0;
                x_33 = (value_33 & 0xFF);
                _v275 = x_33;
                const v281: uint8 = value_47(_v275);
                let _v282: Option<uint8> = void 0;
                let x_34: uint8;
                const value_34: int32 = nonSeeded().Next2(1, 7) | 0;
                x_34 = (value_34 & 0xFF);
                _v282 = x_34;
                const v288: uint8 = value_47(_v282);
                let _v289: Option<uint8> = void 0;
                let x_35: uint8;
                const value_35: int32 = nonSeeded().Next2(1, 7) | 0;
                x_35 = (value_35 & 0xFF);
                _v289 = x_35;
                const v295: uint8 = value_47(_v289);
                let _v296: Option<uint8> = void 0;
                let x_36: uint8;
                const value_36: int32 = nonSeeded().Next2(1, 7) | 0;
                x_36 = (value_36 & 0xFF);
                _v296 = x_36;
                const v302: uint8 = value_47(_v296);
                let _v303: Option<uint8> = void 0;
                let x_37: uint8;
                const value_37: int32 = nonSeeded().Next2(1, 7) | 0;
                x_37 = (value_37 & 0xFF);
                _v303 = x_37;
                const v309: uint8 = value_47(_v303);
                let _v310: Option<uint8> = void 0;
                let x_38: uint8;
                const value_38: int32 = nonSeeded().Next2(1, 7) | 0;
                x_38 = (value_38 & 0xFF);
                _v310 = x_38;
                const v316: uint8 = value_47(_v310);
                let _v317: Option<uint8> = void 0;
                let x_39: uint8;
                const value_39: int32 = nonSeeded().Next2(1, 7) | 0;
                x_39 = (value_39 & 0xFF);
                _v317 = x_39;
                const v323: uint8 = value_47(_v317);
                let _v324: Option<uint8> = void 0;
                let x_40: uint8;
                const value_40: int32 = nonSeeded().Next2(1, 7) | 0;
                x_40 = (value_40 & 0xFF);
                _v324 = x_40;
                const v330: uint8 = value_47(_v324);
                let _v331: Option<uint8> = void 0;
                let x_41: uint8;
                const value_41: int32 = nonSeeded().Next2(1, 7) | 0;
                x_41 = (value_41 & 0xFF);
                _v331 = x_41;
                const v337: uint8 = value_47(_v331);
                let _v338: Option<uint8> = void 0;
                let x_42: uint8;
                const value_42: int32 = nonSeeded().Next2(1, 7) | 0;
                x_42 = (value_42 & 0xFF);
                _v338 = x_42;
                const v344: uint8 = value_47(_v338);
                let _v345: Option<uint8> = void 0;
                let x_43: uint8;
                const value_43: int32 = nonSeeded().Next2(1, 7) | 0;
                x_43 = (value_43 & 0xFF);
                _v345 = x_43;
                const v351: uint8 = value_47(_v345);
                let _v352: Option<uint8> = void 0;
                let x_44: uint8;
                const value_44: int32 = nonSeeded().Next2(1, 7) | 0;
                x_44 = (value_44 & 0xFF);
                _v352 = x_44;
                const v358: uint8 = value_47(_v352);
                let _v359: Option<uint8> = void 0;
                let x_45: uint8;
                const value_45: int32 = nonSeeded().Next2(1, 7) | 0;
                x_45 = (value_45 & 0xFF);
                _v359 = x_45;
                const v365: uint8 = value_47(_v359);
                let _v366: Option<uint8> = void 0;
                let x_46: uint8;
                const value_46: int32 = nonSeeded().Next2(1, 7) | 0;
                x_46 = (value_46 & 0xFF);
                _v366 = x_46;
                v0_1_mut = UH1_UH1_1(v218, UH1_UH1_1(v225, UH1_UH1_1(v232, UH1_UH1_1(v239, UH1_UH1_1(v246, UH1_UH1_1(v253, UH1_UH1_1(v260, UH1_UH1_1(v267, UH1_UH1_1(v274, UH1_UH1_1(v281, UH1_UH1_1(v288, UH1_UH1_1(v295, UH1_UH1_1(v302, UH1_UH1_1(v309, UH1_UH1_1(v316, UH1_UH1_1(v323, UH1_UH1_1(v330, UH1_UH1_1(v337, UH1_UH1_1(v344, UH1_UH1_1(v351, UH1_UH1_1(v358, UH1_UH1_1(v365, UH1_UH1_1(value_47(_v366), UH1_UH1_0())))))))))))))))))))))));
                v1_1_mut = 23;
                continue method14;
            }
        }
        break;
    }
}

export function closure81(unitVar: void, v0_1: string[]): int32 {
    const v1_1 = `calculate_dice_count / max: ${9223372036854775807n} / n: ${24} / p: ${4738381338321616896n}`;
    console.log(v1_1);
    const v5 = `result: ${method14(UH1_UH1_0(), 0)}`;
    console.log(v5);
    return 0;
}

export const v0 = (v: int64): ((arg0: UH0_$union) => UH0_$union) => closure0(void 0, v);

export function rotate_numbers(x: int64): ((arg0: UH0_$union) => UH0_$union) {
    return v0(x);
}

export const v1 = (v: Option<((arg0: string) => void)>): ((arg0: UH1_$union) => (() => uint8)) => closure3(void 0, v);

export function create_sequential_roller(x: Option<((arg0: string) => void)>): ((arg0: UH1_$union) => (() => uint8)) {
    return v1(x);
}

export const v2 = (v: Option<((arg0: string) => void)>): ((arg0: (() => uint8)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) => closure10(void 0, v);

export function roll_progressively(x: Option<((arg0: string) => void)>): ((arg0: (() => uint8)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) {
    return v2(x);
}

export const v3 = (v: Option<((arg0: string) => void)>): ((arg0: uint64) => ((arg0: UH1_$union) => Option<uint64>)) => closure78(void 0, v);

export function roll_within_bounds(x: Option<((arg0: string) => void)>): ((arg0: uint64) => ((arg0: UH1_$union) => Option<uint64>)) {
    return v3(x);
}

export const v4 = (v: string[]): int32 => closure81(void 0, v);

(v4)(typeof process === 'object' ? process.argv.slice(2) : []);

