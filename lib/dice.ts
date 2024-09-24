import { compare, IComparable, IEquatable, createAtom } from "../../../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_3, map, defaultArg, Option } from "../../../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Multiply, toUInt64, equals, compare as compare_1, toUInt8, fromUInt8, op_Subtraction, op_Modulus, op_Addition, toInt64, uint64, int64 } from "../../../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../../../deps/Fable/src/fable-library-ts/Types.js";
import { int8, int32, uint8 } from "../../../../deps/Fable/src/fable-library-ts/Int32.js";
import { uint64_type, bool_type, string_type, record_type, int64_type, union_type, lambda_type, unit_type, uint8_type, TypeInfo } from "../../../../deps/Fable/src/fable-library-ts/Reflection.js";
import { create, toString, now, getTicks } from "../../../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../../../deps/Fable/src/fable-library-ts/Map.js";
import { nonSeeded } from "../../../../deps/Fable/src/fable-library-ts/Random.js";

export let TraceState_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>>(undefined);

export interface IOsEnviron {
    environ(): any
}

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
    | US0<2>
    | US0<3>
    | US0<4>

export type US0_$cases = {
    0: ["US0_0", []],
    1: ["US0_1", []],
    2: ["US0_2", []],
    3: ["US0_3", []],
    4: ["US0_4", []]
}

export function US0_US0_0() {
    return new US0<0>(0, []);
}

export function US0_US0_1() {
    return new US0<1>(1, []);
}

export function US0_US0_2() {
    return new US0<2>(2, []);
}

export function US0_US0_3() {
    return new US0<3>(3, []);
}

export function US0_US0_4() {
    return new US0<4>(4, []);
}

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Dice.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Dice.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Dice.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Dice.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Dice.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Dice.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", [string]],
    1: ["US1_1", []]
}

export function US1_US1_0(f0_0: string) {
    return new US1<0>(0, [f0_0]);
}

export function US1_US1_1() {
    return new US1<1>(1, []);
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
    return union_type("Dice.US1", [], US1, () => [[["f0_0", string_type]], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", [US0_$union]],
    1: ["US2_1", []]
}

export function US2_US2_0(f0_0: US0_$union) {
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
    return union_type("Dice.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [int64]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: int64) {
    return new US3<0>(0, [f0_0]);
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
    return union_type("Dice.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [(() => UH0_$union)]],
    1: ["US4_1", [UH0_$union]]
}

export function US4_US4_0(f0_0: (() => UH0_$union)) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1(f1_0: UH0_$union) {
    return new US4<1>(1, [f1_0]);
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
    return union_type("Dice.US4", [], US4, () => [[["f0_0", lambda_type(unit_type, UH0_$reflection())]], [["f1_0", UH0_$reflection()]]]);
}

export class Mut5 extends Record {
    l0: US4_$union;
    constructor(l0: US4_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut5_$reflection(): TypeInfo {
    return record_type("Dice.Mut5", [], Mut5, () => [["l0", US4_$reflection()]]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [uint8]],
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: uint8) {
    return new US5<0>(0, [f0_0]);
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
    return union_type("Dice.US5", [], US5, () => [[["f0_0", uint8_type]], []]);
}

export class Mut6 extends Record implements IEquatable<Mut6>, IComparable<Mut6> {
    l0: US5_$union;
    constructor(l0: US5_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut6_$reflection(): TypeInfo {
    return record_type("Dice.Mut6", [], Mut6, () => [["l0", US5_$reflection()]]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [uint64, UH1_$union]],
    1: ["US6_1", []]
}

export function US6_US6_0(f0_0: uint64, f0_1: UH1_$union) {
    return new US6<0>(0, [f0_0, f0_1]);
}

export function US6_US6_1() {
    return new US6<1>(1, []);
}

export class US6<Tag extends keyof US6_$cases> extends Union<Tag, US6_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US6_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US6_0", "US6_1"];
    }
}

export function US6_$reflection(): TypeInfo {
    return union_type("Dice.US6", [], US6, () => [[["f0_0", uint64_type], ["f0_1", UH1_$reflection()]], []]);
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

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [uint64]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: uint64) {
    return new US7<0>(0, [f0_0]);
}

export function US7_US7_1() {
    return new US7<1>(1, []);
}

export class US7<Tag extends keyof US7_$cases> extends Union<Tag, US7_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US7_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US7_0", "US7_1"];
    }
}

export function US7_$reflection(): TypeInfo {
    return union_type("Dice.US7", [], US7, () => [[["f0_0", uint64_type]], []]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [int64, UH1_$union]],
    1: ["US8_1", []]
}

export function US8_US8_0(f0_0: int64, f0_1: UH1_$union) {
    return new US8<0>(0, [f0_0, f0_1]);
}

export function US8_US8_1() {
    return new US8<1>(1, []);
}

export class US8<Tag extends keyof US8_$cases> extends Union<Tag, US8_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US8_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US8_0", "US8_1"];
    }
}

export function US8_$reflection(): TypeInfo {
    return union_type("Dice.US8", [], US8, () => [[["f0_0", int64_type], ["f0_1", UH1_$reflection()]], []]);
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

export function method2(): string {
    return "TRACE_LEVEL";
}

export function method4(): string {
    return "";
}

export function closure6(unitVar: void, v0_1: string): US1_$union {
    return US1_US1_0(v0_1);
}

export function method5(): ((arg0: string) => US1_$union) {
    return (v: string): US1_$union => closure6(undefined, v);
}

export function method3(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method6(): string {
    return "AUTOMATION";
}

export function closure7(unitVar: void, v0_1: string): void {
}

export function method1(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method3(method2());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method3(method6()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(1n), new Mut1((v: string): void => {
        closure7(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure5(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method1(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function closure8(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method8(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure8(undefined, v);
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3_1: Mut3, v4_1: Mut4, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method8(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method10());
}

export function method12(): string {
    return "\u001b[0m";
}

export function method11(): string {
    return ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method12();
}

export function method14(): string {
    return "";
}

export function method13(): string {
    const v1_1: Mut3 = new Mut3(method14());
    return v1_1.l0;
}

export function method15(v0_1: string, v1_1: string, v2_1: string, v3_1: int64, v4_1: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v3_1} ${v2_1} / ${v4_1}`, ...[]), ...[" ", "/"]);
}

export function closure9(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure11(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure10(unitVar: void, v0_1: string): void {
    let v3_1: any;
    closure11(v0_1, undefined);
    v3_1 = undefined;
}

export function method16(v0_1: string, v1_1: Mut0, v2_1: Mut1, v3_1: Mut2, v4_1: Mut3, v5: Mut4, v6: Option<int64>): void {
    let v9: any;
    closure9(v1_1, undefined);
    v9 = undefined;
    closure10(undefined, v0_1);
    v2_1.l0(v0_1);
}

export function closure4(unitVar: void, unitVar_1: void): void {
    const v1_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v34: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v34, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v41: any;
        v1_1();
        v41 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v55: Mut0 = patternInput_1[0];
        const v81: string = method15(method7(v55, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.create_sequential_roller ()", v55.l0, method13());
        let v83: any;
        v1_1();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v81, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method17(v0_1_mut: UH1_$union, v1_1_mut: UH1_$union): UH1_$union {
    method17:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: UH1_$union = v1_1_mut;
        if (v0_1.tag === /* UH1_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = UH1_UH1_1(v0_1.fields[0], v1_1);
            continue method17;
        }
        break;
    }
}

export function method18(v0_1: UH1_$union, v1_1: UH1_$union): UH1_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return UH1_UH1_1(v0_1.fields[0], method18(v0_1.fields[1], v1_1));
    }
}

export function closure12(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method19(v0_1: UH1_$union, v1_1: UH0_$union): UH0_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        const v2_1: uint8 = v0_1.fields[0];
        const v4_1: UH0_$union = method19(v0_1.fields[1], v1_1);
        return UH0_UH0_0(v2_1, (): UH0_$union => closure12(v4_1, undefined));
    }
}

export function closure13(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function closure14(v0_1: UH0_$union, v1_1: Mut5, unitVar: void): UH0_$union {
    const v2_1: US4_$union = v1_1.l0;
    if (v2_1.tag === /* US4_0 */ 0) {
        const v5: UH0_$union = v2_1.fields[0]();
        const v12: UH0_$union = (v5.tag === /* UH0_1 */ 1) ? UH0_UH0_1() : UH0_UH0_0(v5.fields[0], method20(v0_1, v5.fields[1]));
        v1_1.l0 = US4_US4_1(v12);
        return v12;
    }
    else {
        return v2_1.fields[0];
    }
}

export function method20(v0_1: UH0_$union, v1_1: (() => UH0_$union)): (() => UH0_$union) {
    const v3_1: Mut5 = new Mut5(US4_US4_0(v1_1));
    return (): UH0_$union => closure14(v0_1, v3_1, undefined);
}

export function closure17(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3_1: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3_1;
}

export function method22(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: Option<uint8>): string {
    const v5: Mut3 = new Mut3(method14());
    let v12: any;
    closure17(v5, `${"{ "}`, undefined);
    v12 = undefined;
    let v21: any;
    closure17(v5, `${"current_index"}`, undefined);
    v21 = undefined;
    let v30: any;
    closure17(v5, `${" = "}`, undefined);
    v30 = undefined;
    let v38: any;
    closure17(v5, `${v0_1}`, undefined);
    v38 = undefined;
    let v47: any;
    closure17(v5, `${"; "}`, undefined);
    v47 = undefined;
    let v56: any;
    closure17(v5, `${"acc"}`, undefined);
    v56 = undefined;
    let v64: any;
    closure17(v5, `${" = "}`, undefined);
    v64 = undefined;
    let v72: any;
    closure17(v5, `${v1_1}`, undefined);
    v72 = undefined;
    let v80: any;
    closure17(v5, `${"; "}`, undefined);
    v80 = undefined;
    let v89: any;
    closure17(v5, `${"len"}`, undefined);
    v89 = undefined;
    let v97: any;
    closure17(v5, `${" = "}`, undefined);
    v97 = undefined;
    let v105: any;
    closure17(v5, `${v2_1}`, undefined);
    v105 = undefined;
    let v113: any;
    closure17(v5, `${"; "}`, undefined);
    v113 = undefined;
    let v122: any;
    closure17(v5, `${"last_item"}`, undefined);
    v122 = undefined;
    let v130: any;
    closure17(v5, `${" = "}`, undefined);
    v130 = undefined;
    let v165: any;
    closure17(v5, `${toText(interpolate("%A%P()", [v3_1]))}`, undefined);
    v165 = undefined;
    let v174: any;
    closure17(v5, `${" }"}`, undefined);
    v174 = undefined;
    return v5.l0;
}

export function closure16(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: Option<uint8>, unitVar: void): void {
    const v5 = (): void => {
        closure5(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v38: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v38, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v45: any;
        v5();
        v45 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v59: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v59, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.create_sequential_roller / roll", v59.l0, method22(v0_1, v1_1, v2_1, v3_1));
        let v87: any;
        v5();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method23(v0_1_mut: int64, v1_1_mut: UH0_$union): US5_$union {
    method23:
    while (true) {
        const v0_1: int64 = v0_1_mut, v1_1: UH0_$union = v1_1_mut;
        if (v1_1.tag === /* UH0_1 */ 1) {
            return US5_US5_1();
        }
        else {
            const v3_1: (() => UH0_$union) = v1_1.fields[1];
            const v2_1: uint8 = v1_1.fields[0];
            if (compare_1(v0_1, 0n) <= 0) {
                return US5_US5_0(v2_1);
            }
            else {
                v0_1_mut = toInt64(op_Subtraction(v0_1, 1n));
                v1_1_mut = v3_1();
                continue method23;
            }
        }
        break;
    }
}

export function closure18(unitVar: void, unitVar_1: void): void {
    const v1_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v34: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v34, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v41: any;
        v1_1();
        v41 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v55: Mut0 = patternInput_1[0];
        const v81: string = method15(method7(v55, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.create_sequential_roller / roll / None", v55.l0, method13());
        let v83: any;
        v1_1();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v81, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method21(v0_1_mut: (() => UH0_$union), v1_1_mut: Mut0, v2_1_mut: Mut0, v3_1_mut: Mut0, v4_1_mut: Mut6): uint8 {
    method21:
    while (true) {
        const v0_1: (() => UH0_$union) = v0_1_mut, v1_1: Mut0 = v1_1_mut, v2_1: Mut0 = v2_1_mut, v3_1: Mut0 = v3_1_mut, v4_1: Mut6 = v4_1_mut;
        const v5: int64 = v1_1.l0;
        const v6: int64 = v2_1.l0;
        const v7: int64 = v3_1.l0;
        const v8: US5_$union = v4_1.l0;
        let v18: any;
        closure16(v5, v6, v7, (v8.tag === /* US5_0 */ 0) ? v8.fields[0] : undefined, undefined);
        v18 = undefined;
        const v134: UH0_$union = v0_1();
        const v136: US5_$union = method23(v1_1.l0, v134);
        if (v136.tag === /* US5_0 */ 0) {
            const v137: uint8 = v136.fields[0];
            const v139: int64 = toInt64(op_Addition(v1_1.l0, 1n));
            v1_1.l0 = v139;
            v4_1.l0 = US5_US5_0(v137);
            return v137;
        }
        else {
            let v143: any;
            closure18(undefined, undefined);
            v143 = undefined;
            if (equals(v3_1.l0, -1n)) {
                const v261: int64 = v1_1.l0;
                v3_1.l0 = v261;
            }
            const v267: int64 = (compare_1(v2_1.l0, v3_1.l0) >= 0) ? (1n) : toInt64(op_Addition(v2_1.l0, 1n));
            v2_1.l0 = v267;
            const v269: int64 = toInt64(op_Subtraction(v2_1.l0, 1n));
            v1_1.l0 = v269;
            v4_1.l0 = US5_US5_1();
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            continue method21;
        }
        break;
    }
}

export function closure15(v0_1: (() => UH0_$union), v1_1: Mut0, v2_1: Mut0, v3_1: Mut0, v4_1: Mut6, unitVar: void): uint8 {
    return method21(v0_1, v1_1, v2_1, v3_1, v4_1);
}

export function closure3(unitVar: void, v0_1: UH1_$union): (() => uint8) {
    let v3_1: any;
    closure4(undefined, undefined);
    v3_1 = undefined;
    const v123: UH0_$union = method19(method18(v0_1, method17(v0_1, UH1_UH1_0())), UH0_UH0_1());
    const v125: (() => UH0_$union) = method20(v123, (): UH0_$union => closure13(v123, undefined));
    const v126: Mut0 = new Mut0(0n);
    const v127: Mut0 = new Mut0(1n);
    const v128: Mut0 = new Mut0(-1n);
    const v130: Mut6 = new Mut6(US5_US5_1());
    return (): uint8 => closure15(v125, v126, v127, v128, v130, undefined);
}

export function method25(v0_1: uint64, v1_1: int8, v2_1: uint64): string {
    const v4_1: Mut3 = new Mut3(method14());
    let v11: any;
    closure17(v4_1, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure17(v4_1, `${"max"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure17(v4_1, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure17(v4_1, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure17(v4_1, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure17(v4_1, `${"n"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure17(v4_1, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure17(v4_1, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure17(v4_1, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure17(v4_1, `${"p"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure17(v4_1, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure17(v4_1, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure17(v4_1, `${" }"}`, undefined);
    v113 = undefined;
    return v4_1.l0;
}

export function closure22(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.calculate_dice_count", v58.l0, method25(v0_1, v1_1, v2_1));
        let v86: any;
        v4_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method24(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64): int8 {
    method24:
    while (true) {
        const v0_1: uint64 = v0_1_mut, v1_1: int8 = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (compare_1(v2_1, v0_1) < 0) {
            const v4_1: uint64 = toUInt64(op_Multiply(v2_1, 6n));
            if (compare_1(v4_1, v2_1) > 0) {
                v0_1_mut = v0_1;
                v1_1_mut = (v1_1 + 1);
                v2_1_mut = v4_1;
                continue method24;
            }
            else {
                let v10: any;
                closure22(v0_1, v1_1, v2_1, undefined);
                v10 = undefined;
                return v1_1 | 0;
            }
        }
        else {
            let v129: any;
            closure22(v0_1, v1_1, v2_1, undefined);
            v129 = undefined;
            return v1_1 | 0;
        }
        break;
    }
}

export function method28(v0_1: int8, v1_1: uint64, v2_1: uint64): string {
    const v4_1: Mut3 = new Mut3(method14());
    let v11: any;
    closure17(v4_1, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure17(v4_1, `${"power"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure17(v4_1, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure17(v4_1, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure17(v4_1, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure17(v4_1, `${"acc"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure17(v4_1, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure17(v4_1, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure17(v4_1, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure17(v4_1, `${"result"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure17(v4_1, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure17(v4_1, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure17(v4_1, `${" }"}`, undefined);
    v113 = undefined;
    return v4_1.l0;
}

export function closure23(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method28(v1_1, v0_1, v2_1));
        let v86: any;
        v4_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure87(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_1();
}

export function closure86(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9223372036854775808n, (): UH2_$union => closure87(undefined, undefined));
}

export function closure85(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4611686018427387904n, (): UH2_$union => closure86(undefined, undefined));
}

export function closure84(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6917529027641081856n, (): UH2_$union => closure85(undefined, undefined));
}

export function closure83(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1152921504606846976n, (): UH2_$union => closure84(undefined, undefined));
}

export function closure82(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(15564440312192434176n, (): UH2_$union => closure83(undefined, undefined));
}

export function closure81(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11817445422220181504n, (): UH2_$union => closure82(undefined, undefined));
}

export function closure80(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5044031582654955520n, (): UH2_$union => closure81(undefined, undefined));
}

export function closure79(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6989586621679009792n, (): UH2_$union => closure80(undefined, undefined));
}

export function closure78(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16537217831704461312n, (): UH2_$union => closure79(undefined, undefined));
}

export function closure77(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11979575008805519360n, (): UH2_$union => closure78(undefined, undefined));
}

export function closure76(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14294425217273954304n, (): UH2_$union => closure77(undefined, undefined));
}

export function closure75(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2382404202878992384n, (): UH2_$union => closure76(undefined, undefined));
}

export function closure74(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6545982058383015936n, (): UH2_$union => closure75(undefined, undefined));
}

export function closure73(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10314369046585278464n, (): UH2_$union => closure74(undefined, undefined));
}

export function closure72(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4793518853382471680n, (): UH2_$union => closure73(undefined, undefined));
}

export function closure71(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3873377154515337216n, (): UH2_$union => closure72(undefined, undefined));
}

export function closure70(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(645562859085889536n, (): UH2_$union => closure71(undefined, undefined));
}

export function closure69(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(107593809847648256n, (): UH2_$union => closure70(undefined, undefined));
}

export function closure68(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3092389647259533312n, (): UH2_$union => closure69(undefined, undefined));
}

export function closure67(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9738770311398031360n, (): UH2_$union => closure68(undefined, undefined));
}

export function closure66(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16995415113324298240n, (): UH2_$union => closure67(undefined, undefined));
}

export function closure65(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8981483876790566912n, (): UH2_$union => closure66(undefined, undefined));
}

export function closure64(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13794743361938128896n, (): UH2_$union => closure65(undefined, undefined));
}

export function closure63(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2299123893656354816n, (): UH2_$union => closure64(undefined, undefined));
}

export function closure62(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3457644661227651072n, (): UH2_$union => closure63(undefined, undefined));
}

export function closure61(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(576274110204608512n, (): UH2_$union => closure62(undefined, undefined));
}

export function closure60(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6244960376270618624n, (): UH2_$union => closure61(undefined, undefined));
}

export function closure59(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13338656111851470848n, (): UH2_$union => closure60(undefined, undefined));
}

export function closure58(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14520938734448279552n, (): UH2_$union => closure59(undefined, undefined));
}

export function closure57(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14717985838214414336n, (): UH2_$union => closure58(undefined, undefined));
}

export function closure56(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5527454985320660992n, (): UH2_$union => closure57(undefined, undefined));
}

export function closure55(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16293529225644736512n, (): UH2_$union => closure56(undefined, undefined));
}

export function closure54(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11938960241128898560n, (): UH2_$union => closure55(undefined, undefined));
}

export function closure53(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8138741398091333632n, (): UH2_$union => closure54(undefined, undefined));
}

export function closure52(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7505371590918406144n, (): UH2_$union => closure53(undefined, undefined));
}

export function closure51(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16623181993244360704n, (): UH2_$union => closure52(undefined, undefined));
}

export function closure50(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8919445023443910656n, (): UH2_$union => closure51(undefined, undefined));
}

export function closure49(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4561031516192243712n, (): UH2_$union => closure50(undefined, undefined));
}

export function closure48(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9983543956220149760n, (): UH2_$union => closure49(undefined, undefined));
}

export function closure47(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4738381338321616896n, (): UH2_$union => closure48(undefined, undefined));
}

export function closure46(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(789730223053602816n, (): UH2_$union => closure47(undefined, undefined));
}

export function closure45(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(131621703842267136n, (): UH2_$union => closure46(undefined, undefined));
}

export function closure44(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(21936950640377856n, (): UH2_$union => closure45(undefined, undefined));
}

export function closure43(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3656158440062976n, (): UH2_$union => closure44(undefined, undefined));
}

export function closure42(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(609359740010496n, (): UH2_$union => closure43(undefined, undefined));
}

export function closure41(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(101559956668416n, (): UH2_$union => closure42(undefined, undefined));
}

export function closure40(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16926659444736n, (): UH2_$union => closure41(undefined, undefined));
}

export function closure39(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2821109907456n, (): UH2_$union => closure40(undefined, undefined));
}

export function closure38(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(470184984576n, (): UH2_$union => closure39(undefined, undefined));
}

export function closure37(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(78364164096n, (): UH2_$union => closure38(undefined, undefined));
}

export function closure36(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13060694016n, (): UH2_$union => closure37(undefined, undefined));
}

export function closure35(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2176782336n, (): UH2_$union => closure36(undefined, undefined));
}

export function closure34(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(362797056n, (): UH2_$union => closure35(undefined, undefined));
}

export function closure33(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(60466176n, (): UH2_$union => closure34(undefined, undefined));
}

export function closure32(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10077696n, (): UH2_$union => closure33(undefined, undefined));
}

export function closure31(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1679616n, (): UH2_$union => closure32(undefined, undefined));
}

export function closure30(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(279936n, (): UH2_$union => closure31(undefined, undefined));
}

export function closure29(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(46656n, (): UH2_$union => closure30(undefined, undefined));
}

export function closure28(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7776n, (): UH2_$union => closure29(undefined, undefined));
}

export function closure27(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1296n, (): UH2_$union => closure28(undefined, undefined));
}

export function closure26(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(216n, (): UH2_$union => closure27(undefined, undefined));
}

export function closure25(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(36n, (): UH2_$union => closure26(undefined, undefined));
}

export function closure24(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6n, (): UH2_$union => closure25(undefined, undefined));
}

export function method29(v0_1_mut: int8, v1_1_mut: UH2_$union): US7_$union {
    method29:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if (v1_1.tag === /* UH2_1 */ 1) {
            return US7_US7_1();
        }
        else if (v0_1 <= 0) {
            return US7_US7_0(v1_1.fields[0]);
        }
        else {
            v0_1_mut = (v0_1 - 1);
            v1_1_mut = v1_1.fields[1]();
            continue method29;
        }
        break;
    }
}

export function method30(v0_1: int8, v1_1: uint64, v2_1: uint8, v3_1: uint64): string {
    const v5: Mut3 = new Mut3(method14());
    let v12: any;
    closure17(v5, `${"{ "}`, undefined);
    v12 = undefined;
    let v21: any;
    closure17(v5, `${"power"}`, undefined);
    v21 = undefined;
    let v30: any;
    closure17(v5, `${" = "}`, undefined);
    v30 = undefined;
    let v38: any;
    closure17(v5, `${v0_1}`, undefined);
    v38 = undefined;
    let v47: any;
    closure17(v5, `${"; "}`, undefined);
    v47 = undefined;
    let v56: any;
    closure17(v5, `${"acc"}`, undefined);
    v56 = undefined;
    let v64: any;
    closure17(v5, `${" = "}`, undefined);
    v64 = undefined;
    let v72: any;
    closure17(v5, `${v1_1}`, undefined);
    v72 = undefined;
    let v80: any;
    closure17(v5, `${"; "}`, undefined);
    v80 = undefined;
    let v89: any;
    closure17(v5, `${"roll"}`, undefined);
    v89 = undefined;
    let v97: any;
    closure17(v5, `${" = "}`, undefined);
    v97 = undefined;
    let v105: any;
    closure17(v5, `${v2_1}`, undefined);
    v105 = undefined;
    let v113: any;
    closure17(v5, `${"; "}`, undefined);
    v113 = undefined;
    let v122: any;
    closure17(v5, `${"value"}`, undefined);
    v122 = undefined;
    let v130: any;
    closure17(v5, `${" = "}`, undefined);
    v130 = undefined;
    let v138: any;
    closure17(v5, `${v3_1}`, undefined);
    v138 = undefined;
    let v147: any;
    closure17(v5, `${" }"}`, undefined);
    v147 = undefined;
    return v5.l0;
}

export function closure88(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unitVar: void): void {
    const v5 = (): void => {
        closure5(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v38: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v38, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v45: any;
        v5();
        v45 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v59: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v59, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v59.l0, method30(v1_1, v0_1, v2_1, v3_1));
        let v87: any;
        v5();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method31(v0_1: int8, v1_1: uint64, v2_1: uint8): string {
    const v4_1: Mut3 = new Mut3(method14());
    let v11: any;
    closure17(v4_1, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure17(v4_1, `${"power"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure17(v4_1, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure17(v4_1, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure17(v4_1, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure17(v4_1, `${"acc"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure17(v4_1, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure17(v4_1, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure17(v4_1, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure17(v4_1, `${"roll"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure17(v4_1, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure17(v4_1, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure17(v4_1, `${" }"}`, undefined);
    v113 = undefined;
    return v4_1.l0;
}

export function closure89(v0_1: uint64, v1_1: int8, v2_1: uint8, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method31(v1_1, v0_1, v2_1));
        let v86: any;
        v4_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method27(v0_1_mut: int8, v1_1_mut: UH1_$union, v2_1_mut: uint64): US6_$union {
    method27:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH1_$union = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (v0_1 < 0) {
            const v4_1: uint64 = toUInt64(op_Addition(v2_1, 1n));
            let v7: any;
            closure23(v2_1, v0_1, v4_1, undefined);
            v7 = undefined;
            return US6_US6_0(v4_1, v1_1);
        }
        else if (v1_1.tag === /* UH1_0 */ 0) {
            return US6_US6_1();
        }
        else {
            const v126: UH1_$union = v1_1.fields[1];
            const v125: uint8 = v1_1.fields[0];
            if (v125 > 1) {
                const v131: US7_$union = method29(v0_1, UH2_UH2_0(1n, (): UH2_$union => closure24(undefined, undefined)));
                let v135: uint64;
                if (v131.tag === /* US7_0 */ 0) {
                    v135 = v131.fields[0];
                }
                else {
                    throw new Error("Option does not have a value.");
                }
                const v138: uint64 = toUInt64(op_Multiply(toUInt64(fromUInt8(v125 - 1)), v135));
                let v141: any;
                closure88(v2_1, v0_1, v125, v138, undefined);
                v141 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v126;
                v2_1_mut = toUInt64(op_Addition(v2_1, v138));
                continue method27;
            }
            else {
                let v262: any;
                closure89(v2_1, v0_1, v125, undefined);
                v262 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v126;
                v2_1_mut = v2_1;
                continue method27;
            }
        }
        break;
    }
}

export function method32(v0_1: int8, v1_1: (() => uint8), v2_1: int8): UH1_$union {
    if (v2_1 < v0_1) {
        return UH1_UH1_1(v1_1(), method32(v0_1, v1_1, v2_1 + 1));
    }
    else {
        return UH1_UH1_0();
    }
}

export function method33(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union): uint64 {
    method33:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut;
        const v5: int8 = (v3_1 + 1) | 0;
        if (v3_1 < v5) {
            return method26(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
        }
        else {
            const v11: US6_$union = method27(v3_1, v4_1, 0n);
            if (v11.tag === /* US6_0 */ 0) {
                const v13: UH1_$union = v11.fields[1];
                const v12: uint64 = v11.fields[0];
                if (compare_1(v12, v2_1) <= 0) {
                    return v12;
                }
                else if (v1_1) {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = method32(v3_1, v0_1, 0);
                    continue method33;
                }
                else {
                    return method26(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
                }
            }
            else if (v1_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = method32(v3_1, v0_1, 0);
                continue method33;
            }
            else {
                return method26(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
            }
        }
        break;
    }
}

export function method26(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union, v5_mut: int8): uint64 {
    method26:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut, v5: int8 = v5_mut;
        if (v5 < (v3_1 + 1)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
            v5_mut = (v5 + 1);
            continue method26;
        }
        else {
            const v13: US6_$union = method27(v3_1, v4_1, 0n);
            if (v13.tag === /* US6_0 */ 0) {
                const v15: UH1_$union = v13.fields[1];
                const v14: uint64 = v13.fields[0];
                if (compare_1(v14, v2_1) <= 0) {
                    return v14;
                }
                else if (v1_1) {
                    return method33(v0_1, v1_1, v2_1, v3_1, method32(v3_1, v0_1, 0));
                }
                else {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                    v5_mut = (v5 + 1);
                    continue method26;
                }
            }
            else if (v1_1) {
                return method33(v0_1, v1_1, v2_1, v3_1, method32(v3_1, v0_1, 0));
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                v5_mut = (v5 + 1);
                continue method26;
            }
        }
        break;
    }
}

export function closure21(v0_1: (() => uint8), v1_1: boolean, v2_1: uint64): uint64 {
    return method26(v0_1, v1_1, v2_1, (equals(v2_1, 1n) ? 1 : method24(v2_1, 0, 1n)) - 1, UH1_UH1_0(), 0);
}

export function closure20(v0_1: (() => uint8), v1_1: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure21(v0_1, v1_1, v);
}

export function closure19(unitVar: void, v0_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure20(v0_1, v);
}

export function method34(v0_1_mut: UH1_$union, v1_1_mut: int8): int8 {
    method34:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v0_1.tag === /* UH1_0 */ 0) {
            return v1_1 | 0;
        }
        else {
            const v2_1: uint8 = v0_1.fields[0];
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v1_1 + 1);
            continue method34;
        }
        break;
    }
}

export function closure91(v0_1: uint64, v1_1: UH1_$union): Option<uint64> {
    const v6: US6_$union = method27(method34(v1_1, 0) - 1, v1_1, 0n);
    let v16: US7_$union;
    if (v6.tag === /* US6_0 */ 0) {
        const v8: UH1_$union = v6.fields[1];
        const v7: uint64 = v6.fields[0];
        v16 = (((compare_1(v7, 1n) >= 0) && (compare_1(v7, v0_1) <= 0)) ? US7_US7_0(v7) : US7_US7_1());
    }
    else {
        v16 = US7_US7_1();
    }
    if (v16.tag === /* US7_0 */ 0) {
        return v16.fields[0];
    }
    else {
        return undefined;
    }
}

export function closure90(unitVar: void, v0_1: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return (v: UH1_$union): Option<uint64> => closure91(v0_1, v);
}

export function method35(v0_1: int64, v1_1: int8, v2_1: int64): string {
    const v4_1: Mut3 = new Mut3(method14());
    let v11: any;
    closure17(v4_1, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure17(v4_1, `${"max"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure17(v4_1, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure17(v4_1, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure17(v4_1, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure17(v4_1, `${"n"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure17(v4_1, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure17(v4_1, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure17(v4_1, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure17(v4_1, `${"p"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure17(v4_1, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure17(v4_1, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure17(v4_1, `${" }"}`, undefined);
    v113 = undefined;
    return v4_1.l0;
}

export function closure93(unitVar: void, unitVar_1: void): void {
    const v1_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v34: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v34, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v41: any;
        v1_1();
        v41 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v55: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v55, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.calculate_dice_count", v55.l0, method35(9223372036854775807n, 24, 4738381338321616896n));
        let v86: any;
        v1_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method37(): uint8 {
    const v7: any = nonSeeded();
    const v9: int32 = ~~1 | 0;
    const v11: int32 = ~~7 | 0;
    const value_2: int32 = v7.Next2(v9, v11) | 0;
    return value_2 & 0xFF;
}

export function method39(v0_1: int8, v1_1: int64, v2_1: uint8, v3_1: int64): string {
    const v5: Mut3 = new Mut3(method14());
    let v12: any;
    closure17(v5, `${"{ "}`, undefined);
    v12 = undefined;
    let v21: any;
    closure17(v5, `${"power"}`, undefined);
    v21 = undefined;
    let v30: any;
    closure17(v5, `${" = "}`, undefined);
    v30 = undefined;
    let v38: any;
    closure17(v5, `${v0_1}`, undefined);
    v38 = undefined;
    let v47: any;
    closure17(v5, `${"; "}`, undefined);
    v47 = undefined;
    let v56: any;
    closure17(v5, `${"acc"}`, undefined);
    v56 = undefined;
    let v64: any;
    closure17(v5, `${" = "}`, undefined);
    v64 = undefined;
    let v72: any;
    closure17(v5, `${v1_1}`, undefined);
    v72 = undefined;
    let v80: any;
    closure17(v5, `${"; "}`, undefined);
    v80 = undefined;
    let v89: any;
    closure17(v5, `${"roll"}`, undefined);
    v89 = undefined;
    let v97: any;
    closure17(v5, `${" = "}`, undefined);
    v97 = undefined;
    let v105: any;
    closure17(v5, `${v2_1}`, undefined);
    v105 = undefined;
    let v113: any;
    closure17(v5, `${"; "}`, undefined);
    v113 = undefined;
    let v122: any;
    closure17(v5, `${"value"}`, undefined);
    v122 = undefined;
    let v130: any;
    closure17(v5, `${" = "}`, undefined);
    v130 = undefined;
    let v138: any;
    closure17(v5, `${v3_1}`, undefined);
    v138 = undefined;
    let v147: any;
    closure17(v5, `${" }"}`, undefined);
    v147 = undefined;
    return v5.l0;
}

export function closure94(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(23, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure95(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(22, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(21, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(20, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(19, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(18, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(17, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(16, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(15, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(14, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(13, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(12, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(11, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(10, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(9, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(8, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(7, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(6, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(5, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(4, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(3, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(2, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(1, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure117(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4_1();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v85: string = method15(method7(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(0, v0_1, v1_1, v2_1));
        let v87: any;
        v4_1();
        v87 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v85, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method64(v0_1: int8, v1_1: int64, v2_1: int64): string {
    const v4_1: Mut3 = new Mut3(method14());
    let v11: any;
    closure17(v4_1, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure17(v4_1, `${"power"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure17(v4_1, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure17(v4_1, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure17(v4_1, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure17(v4_1, `${"acc"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure17(v4_1, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure17(v4_1, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure17(v4_1, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure17(v4_1, `${"result"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure17(v4_1, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure17(v4_1, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure17(v4_1, `${" }"}`, undefined);
    v113 = undefined;
    return v4_1.l0;
}

export function closure118(v0_1: int64, v1_1: int64, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method64(-1, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method63(v0_1: UH1_$union, v1_1: int64): US8_$union {
    const v2_1: int64 = toInt64(op_Addition(v1_1, 1n));
    let v5: any;
    closure118(v1_1, v2_1, undefined);
    v5 = undefined;
    return US8_US8_0(v2_1, v0_1);
}

export function method65(v0_1: int8, v1_1: int64, v2_1: uint8): string {
    const v4_1: Mut3 = new Mut3(method14());
    let v11: any;
    closure17(v4_1, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure17(v4_1, `${"power"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure17(v4_1, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure17(v4_1, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure17(v4_1, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure17(v4_1, `${"acc"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure17(v4_1, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure17(v4_1, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure17(v4_1, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure17(v4_1, `${"roll"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure17(v4_1, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure17(v4_1, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure17(v4_1, `${" }"}`, undefined);
    v113 = undefined;
    return v4_1.l0;
}

export function closure119(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(0, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method62(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v7: int64 = toInt64(fromUInt8(v3_1 - 1));
            let v10: any;
            closure117(v1_1, v3_1, v7, undefined);
            v10 = undefined;
            return method63(v4_1, toInt64(op_Addition(v1_1, v7)));
        }
        else {
            let v131: any;
            closure119(v1_1, v3_1, undefined);
            v131 = undefined;
            return method63(v4_1, v1_1);
        }
    }
}

export function closure120(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(1, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method61(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 6n));
            let v11: any;
            closure116(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method62(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure120(v1_1, v3_1, undefined);
            v132 = undefined;
            return method62(v4_1, v1_1);
        }
    }
}

export function closure121(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(2, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method60(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 36n));
            let v11: any;
            closure115(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method61(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure121(v1_1, v3_1, undefined);
            v132 = undefined;
            return method61(v4_1, v1_1);
        }
    }
}

export function closure122(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(3, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method59(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 216n));
            let v11: any;
            closure114(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method60(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure122(v1_1, v3_1, undefined);
            v132 = undefined;
            return method60(v4_1, v1_1);
        }
    }
}

export function closure123(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(4, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method58(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1296n));
            let v11: any;
            closure113(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method59(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure123(v1_1, v3_1, undefined);
            v132 = undefined;
            return method59(v4_1, v1_1);
        }
    }
}

export function closure124(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(5, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method57(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 7776n));
            let v11: any;
            closure112(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method58(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure124(v1_1, v3_1, undefined);
            v132 = undefined;
            return method58(v4_1, v1_1);
        }
    }
}

export function closure125(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(6, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method56(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 46656n));
            let v11: any;
            closure111(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method57(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure125(v1_1, v3_1, undefined);
            v132 = undefined;
            return method57(v4_1, v1_1);
        }
    }
}

export function closure126(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(7, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method55(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 279936n));
            let v11: any;
            closure110(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method56(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure126(v1_1, v3_1, undefined);
            v132 = undefined;
            return method56(v4_1, v1_1);
        }
    }
}

export function closure127(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(8, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method54(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1679616n));
            let v11: any;
            closure109(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method55(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure127(v1_1, v3_1, undefined);
            v132 = undefined;
            return method55(v4_1, v1_1);
        }
    }
}

export function closure128(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(9, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method53(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 10077696n));
            let v11: any;
            closure108(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method54(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure128(v1_1, v3_1, undefined);
            v132 = undefined;
            return method54(v4_1, v1_1);
        }
    }
}

export function closure129(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(10, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method52(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 60466176n));
            let v11: any;
            closure107(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method53(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure129(v1_1, v3_1, undefined);
            v132 = undefined;
            return method53(v4_1, v1_1);
        }
    }
}

export function closure130(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(11, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method51(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 362797056n));
            let v11: any;
            closure106(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method52(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure130(v1_1, v3_1, undefined);
            v132 = undefined;
            return method52(v4_1, v1_1);
        }
    }
}

export function closure131(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(12, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method50(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2176782336n));
            let v11: any;
            closure105(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method51(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure131(v1_1, v3_1, undefined);
            v132 = undefined;
            return method51(v4_1, v1_1);
        }
    }
}

export function closure132(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(13, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method49(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 13060694016n));
            let v11: any;
            closure104(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method50(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure132(v1_1, v3_1, undefined);
            v132 = undefined;
            return method50(v4_1, v1_1);
        }
    }
}

export function closure133(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(14, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method48(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 78364164096n));
            let v11: any;
            closure103(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method49(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure133(v1_1, v3_1, undefined);
            v132 = undefined;
            return method49(v4_1, v1_1);
        }
    }
}

export function closure134(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(15, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method47(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 470184984576n));
            let v11: any;
            closure102(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method48(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure134(v1_1, v3_1, undefined);
            v132 = undefined;
            return method48(v4_1, v1_1);
        }
    }
}

export function closure135(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(16, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method46(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2821109907456n));
            let v11: any;
            closure101(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method47(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure135(v1_1, v3_1, undefined);
            v132 = undefined;
            return method47(v4_1, v1_1);
        }
    }
}

export function closure136(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(17, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method45(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 16926659444736n));
            let v11: any;
            closure100(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method46(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure136(v1_1, v3_1, undefined);
            v132 = undefined;
            return method46(v4_1, v1_1);
        }
    }
}

export function closure137(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(18, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method44(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 101559956668416n));
            let v11: any;
            closure99(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method45(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure137(v1_1, v3_1, undefined);
            v132 = undefined;
            return method45(v4_1, v1_1);
        }
    }
}

export function closure138(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(19, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method43(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 609359740010496n));
            let v11: any;
            closure98(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method44(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure138(v1_1, v3_1, undefined);
            v132 = undefined;
            return method44(v4_1, v1_1);
        }
    }
}

export function closure139(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(20, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method42(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 3656158440062976n));
            let v11: any;
            closure97(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method43(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure139(v1_1, v3_1, undefined);
            v132 = undefined;
            return method43(v4_1, v1_1);
        }
    }
}

export function closure140(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(21, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method41(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 21936950640377856n));
            let v11: any;
            closure96(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method42(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure140(v1_1, v3_1, undefined);
            v132 = undefined;
            return method42(v4_1, v1_1);
        }
    }
}

export function closure141(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(22, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method40(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 131621703842267136n));
            let v11: any;
            closure95(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method41(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure141(v1_1, v3_1, undefined);
            v132 = undefined;
            return method41(v4_1, v1_1);
        }
    }
}

export function closure142(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3_1();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v84: string = method15(method7(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(23, v0_1, v1_1));
        let v86: any;
        v3_1();
        v86 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v84, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method38(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 789730223053602816n));
            let v11: any;
            closure94(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method40(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v132: any;
            closure142(v1_1, v3_1, undefined);
            v132 = undefined;
            return method40(v4_1, v1_1);
        }
    }
}

export function method36(v0_1_mut: UH1_$union, v1_1_mut: int8): int64 {
    method36:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v1_1 < 24) {
            v0_1_mut = UH1_UH1_1(method37(), v0_1);
            v1_1_mut = (v1_1 + 1);
            continue method36;
        }
        else {
            const v8: US8_$union = method38(v0_1, 0n);
            if (v8.tag === /* US8_0 */ 0) {
                const v9: int64 = v8.fields[0];
                const v10: UH1_$union = v8.fields[1];
                if (compare_1(v9, 9223372036854775807n) <= 0) {
                    return v9;
                }
                else {
                    v0_1_mut = UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_0())))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method36;
                }
            }
            else {
                v0_1_mut = UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_1(method37(), UH1_UH1_0())))))))))))))))))))))));
                v1_1_mut = 23;
                continue method36;
            }
        }
        break;
    }
}

export function method66(v0_1: int64): string {
    const v2_1: Mut3 = new Mut3(method14());
    let v9: any;
    closure17(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18: any;
    closure17(v2_1, `${"result"}`, undefined);
    v18 = undefined;
    let v27: any;
    closure17(v2_1, `${" = "}`, undefined);
    v27 = undefined;
    let v35: any;
    closure17(v2_1, `${v0_1}`, undefined);
    v35 = undefined;
    let v44: any;
    closure17(v2_1, `${" }"}`, undefined);
    v44 = undefined;
    return v2_1.l0;
}

export function closure143(v0_1: int64, unitVar: void): void {
    const v2_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v3_1: any;
    v2_1();
    v3_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v35: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v35, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v42: any;
        v2_1();
        v42 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v56: Mut0 = patternInput_1[0];
        const v82: string = method15(method7(v56, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method11(), "dice.main", v56.l0, method66(v0_1));
        let v84: any;
        v2_1();
        v84 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method16(v82, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure92(unitVar: void, v0_1: string[]): int32 {
    let v3_1: any;
    closure93(undefined, undefined);
    v3_1 = undefined;
    let v127: any;
    closure143(method36(UH1_UH1_0(), 0), undefined);
    v127 = undefined;
    return 0;
}

export const v0 = (v: int64): ((arg0: UH0_$union) => UH0_$union) => closure0(undefined, v);

export function rotate_numbers(x: int64): ((arg0: UH0_$union) => UH0_$union) {
    return v0(x);
}

export const v1 = (v: UH1_$union): (() => uint8) => closure3(undefined, v);

export function create_sequential_roller(x: UH1_$union): (() => uint8) {
    return v1(x);
}

export const v2 = (v: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) => closure19(undefined, v);

export function roll_progressively(x: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return v2(x);
}

export const v3 = (v: uint64): ((arg0: UH1_$union) => Option<uint64>) => closure90(undefined, v);

export function roll_within_bounds(x: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return v3(x);
}

export const v4 = (v: string[]): int32 => closure92(undefined, v);

(v4)(typeof process === 'object' ? process.argv.slice(2) : []);

