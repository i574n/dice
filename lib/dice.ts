import { compare, IComparable, IEquatable, createAtom } from "../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_3, Option } from "../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { op_Multiply, toUInt64, equals, compare as compare_1, toUInt8, fromUInt8, op_Subtraction, op_Modulus, op_Addition, toInt64, uint64, int64 } from "../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { int8, int32, uint8 } from "../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { uint64_type, bool_type, string_type, record_type, int64_type, union_type, lambda_type, unit_type, uint8_type, TypeInfo } from "../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { create, toString, now, getTicks } from "../../polyglot/deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../polyglot/deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../polyglot/deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { nonSeeded } from "../../polyglot/deps/Fable/src/fable-library-ts/Random.js";

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

export function closure6(v0_1: FSharpRef<Option<US1_$union>>, v1_1: Option<US1_$union>): FSharpRef<Option<US1_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure7(v0_1: Option<string>, v1_1: ((arg0: Option<US1_$union>) => FSharpRef<Option<US1_$union>>), unitVar: void): void {
    let x: string;
    v1_1((v0_1 == null) ? undefined : ((x = value_3(v0_1), ((): US1_$union => US1_US1_0(x))())));
}

export function method3(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method5(): string {
    return "AUTOMATION";
}

export function closure8(unitVar: void, v0_1: string): void {
}

export function method1(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method3(method2());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method3(method5()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure8(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure5(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method1(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function closure9(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure10(v0_1: FSharpRef<Option<US3_$union>>, v1_1: Option<US3_$union>): FSharpRef<Option<US3_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure11(v0_1: Option<int64>, v1_1: ((arg0: Option<US3_$union>) => FSharpRef<Option<US3_$union>>), unitVar: void): void {
    let x: int64;
    v1_1((v0_1 == null) ? undefined : ((x = value_3(v0_1), ((): US3_$union => US3_US3_0(x))())));
}

export function method6(): string {
    return "hh:mm:ss";
}

export function method7(): string {
    return "HH:mm:ss";
}

export function method8(): string {
    return "\u001b[0m";
}

export function method9(): string {
    return "";
}

export function closure13(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure12(unitVar: void, v0_1: string): void {
    let v3_1: any;
    closure13(v0_1, undefined);
    v3_1 = undefined;
}

export function closure4(unitVar: void, unitVar_1: void): void {
    let v314: int64, v324: number;
    const v1_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v35: any;
    v1_1();
    v35 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v67: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v67, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v75: any;
        closure9(patternInput[0], undefined);
        v75 = undefined;
        let v79: any;
        v1_1();
        v79 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v290: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v295: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v290, v), undefined);
        v295 = undefined;
        const v310: US3_$union = defaultArg(_v290.contents, US3_US3_1());
        const v355: string = toString((v310.tag === /* US3_0 */ 0) ? ((v314 = v310.fields[0], (v324 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v314))), create(1, 1, 1, hours(v324), minutes(v324), seconds(v324), milliseconds(v324))))) : now(), method7());
        const v620: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v635: int64 = patternInput_2[0].l0;
        const v637: Mut3 = new Mut3(method9());
        const v697: string = trimEnd(trimStart(`${v355} ${v620} #${v635} ${"dice.create_sequential_roller ()"} / ${v637.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v697);
        patternInput[1].l0(v697);
    }
}

export function method10(v0_1_mut: UH1_$union, v1_1_mut: UH1_$union): UH1_$union {
    method10:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: UH1_$union = v1_1_mut;
        if (v0_1.tag === /* UH1_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = UH1_UH1_1(v0_1.fields[0], v1_1);
            continue method10;
        }
        break;
    }
}

export function method11(v0_1: UH1_$union, v1_1: UH1_$union): UH1_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return UH1_UH1_1(v0_1.fields[0], method11(v0_1.fields[1], v1_1));
    }
}

export function closure14(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method12(v0_1: UH1_$union, v1_1: UH0_$union): UH0_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        const v2_1: uint8 = v0_1.fields[0];
        const v4_1: UH0_$union = method12(v0_1.fields[1], v1_1);
        return UH0_UH0_0(v2_1, (): UH0_$union => closure14(v4_1, undefined));
    }
}

export function closure15(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function closure16(v0_1: UH0_$union, v1_1: Mut5, unitVar: void): UH0_$union {
    const v2_1: US4_$union = v1_1.l0;
    if (v2_1.tag === /* US4_0 */ 0) {
        const v5: UH0_$union = v2_1.fields[0]();
        const v12: UH0_$union = (v5.tag === /* UH0_1 */ 1) ? UH0_UH0_1() : UH0_UH0_0(v5.fields[0], method13(v0_1, v5.fields[1]));
        v1_1.l0 = US4_US4_1(v12);
        return v12;
    }
    else {
        return v2_1.fields[0];
    }
}

export function method13(v0_1: UH0_$union, v1_1: (() => UH0_$union)): (() => UH0_$union) {
    const v3_1: Mut5 = new Mut5(US4_US4_0(v1_1));
    return (): UH0_$union => closure16(v0_1, v3_1, undefined);
}

export function closure19(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3_1: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3_1;
}

export function closure18(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: Option<uint8>, unitVar: void): void {
    let v318: int64, v328: number;
    const v5 = (): void => {
        closure5(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v39: any;
    v5();
    v39 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v71: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v71, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v79: any;
        closure9(patternInput[0], undefined);
        v79 = undefined;
        let v83: any;
        v5();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v294: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v299: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v294, v), undefined);
        v299 = undefined;
        const v314: US3_$union = defaultArg(_v294.contents, US3_US3_1());
        const v359: string = toString((v314.tag === /* US3_0 */ 0) ? ((v318 = v314.fields[0], (v328 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v318))), create(1, 1, 1, hours(v328), minutes(v328), seconds(v328), milliseconds(v328))))) : now(), method7());
        const v624: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v639: int64 = patternInput_2[0].l0;
        const v641: Mut3 = new Mut3(method9());
        let v648: any;
        closure19(v641, `${"{ "}`, undefined);
        v648 = undefined;
        let v657: any;
        closure19(v641, `${"current_index"}`, undefined);
        v657 = undefined;
        let v666: any;
        closure19(v641, `${" = "}`, undefined);
        v666 = undefined;
        let v674: any;
        closure19(v641, `${v0_1}`, undefined);
        v674 = undefined;
        let v683: any;
        closure19(v641, `${"; "}`, undefined);
        v683 = undefined;
        let v692: any;
        closure19(v641, `${"acc"}`, undefined);
        v692 = undefined;
        let v700: any;
        closure19(v641, `${" = "}`, undefined);
        v700 = undefined;
        let v708: any;
        closure19(v641, `${v1_1}`, undefined);
        v708 = undefined;
        let v716: any;
        closure19(v641, `${"; "}`, undefined);
        v716 = undefined;
        let v725: any;
        closure19(v641, `${"len"}`, undefined);
        v725 = undefined;
        let v733: any;
        closure19(v641, `${" = "}`, undefined);
        v733 = undefined;
        let v741: any;
        closure19(v641, `${v2_1}`, undefined);
        v741 = undefined;
        let v749: any;
        closure19(v641, `${"; "}`, undefined);
        v749 = undefined;
        let v758: any;
        closure19(v641, `${"last_item"}`, undefined);
        v758 = undefined;
        let v766: any;
        closure19(v641, `${" = "}`, undefined);
        v766 = undefined;
        let v801: any;
        closure19(v641, `${toText(interpolate("%A%P()", [v3_1]))}`, undefined);
        v801 = undefined;
        let v810: any;
        closure19(v641, `${" }"}`, undefined);
        v810 = undefined;
        const v872: string = trimEnd(trimStart(`${v359} ${v624} #${v639} ${"dice.create_sequential_roller / roll"} / ${v641.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v872);
        patternInput[1].l0(v872);
    }
}

export function method15(v0_1_mut: int64, v1_1_mut: UH0_$union): US5_$union {
    method15:
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
                continue method15;
            }
        }
        break;
    }
}

export function closure20(unitVar: void, unitVar_1: void): void {
    let v314: int64, v324: number;
    const v1_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v35: any;
    v1_1();
    v35 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v67: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v67, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v75: any;
        closure9(patternInput[0], undefined);
        v75 = undefined;
        let v79: any;
        v1_1();
        v79 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v290: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v295: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v290, v), undefined);
        v295 = undefined;
        const v310: US3_$union = defaultArg(_v290.contents, US3_US3_1());
        const v355: string = toString((v310.tag === /* US3_0 */ 0) ? ((v314 = v310.fields[0], (v324 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v314))), create(1, 1, 1, hours(v324), minutes(v324), seconds(v324), milliseconds(v324))))) : now(), method7());
        const v620: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v635: int64 = patternInput_2[0].l0;
        const v637: Mut3 = new Mut3(method9());
        const v697: string = trimEnd(trimStart(`${v355} ${v620} #${v635} ${"dice.create_sequential_roller / roll / None"} / ${v637.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v697);
        patternInput[1].l0(v697);
    }
}

export function method14(v0_1_mut: (() => UH0_$union), v1_1_mut: Mut0, v2_1_mut: Mut0, v3_1_mut: Mut0, v4_1_mut: Mut6): uint8 {
    method14:
    while (true) {
        const v0_1: (() => UH0_$union) = v0_1_mut, v1_1: Mut0 = v1_1_mut, v2_1: Mut0 = v2_1_mut, v3_1: Mut0 = v3_1_mut, v4_1: Mut6 = v4_1_mut;
        const v5: int64 = v1_1.l0;
        const v6: int64 = v2_1.l0;
        const v7: int64 = v3_1.l0;
        const v8: US5_$union = v4_1.l0;
        let v18: any;
        closure18(v5, v6, v7, (v8.tag === /* US5_0 */ 0) ? v8.fields[0] : undefined, undefined);
        v18 = undefined;
        const v942: UH0_$union = v0_1();
        const v944: US5_$union = method15(v1_1.l0, v942);
        if (v944.tag === /* US5_0 */ 0) {
            const v945: uint8 = v944.fields[0];
            const v947: int64 = toInt64(op_Addition(v1_1.l0, 1n));
            v1_1.l0 = v947;
            v4_1.l0 = US5_US5_0(v945);
            return v945;
        }
        else {
            let v951: any;
            closure20(undefined, undefined);
            v951 = undefined;
            if (equals(v3_1.l0, -1n)) {
                const v1706: int64 = v1_1.l0;
                v3_1.l0 = v1706;
            }
            const v1712: int64 = (compare_1(v2_1.l0, v3_1.l0) >= 0) ? (1n) : toInt64(op_Addition(v2_1.l0, 1n));
            v2_1.l0 = v1712;
            const v1714: int64 = toInt64(op_Subtraction(v2_1.l0, 1n));
            v1_1.l0 = v1714;
            v4_1.l0 = US5_US5_1();
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            continue method14;
        }
        break;
    }
}

export function closure17(v0_1: (() => UH0_$union), v1_1: Mut0, v2_1: Mut0, v3_1: Mut0, v4_1: Mut6, unitVar: void): uint8 {
    return method14(v0_1, v1_1, v2_1, v3_1, v4_1);
}

export function closure3(unitVar: void, v0_1: UH1_$union): (() => uint8) {
    let v3_1: any;
    closure4(undefined, undefined);
    v3_1 = undefined;
    const v760: UH0_$union = method12(method11(v0_1, method10(v0_1, UH1_UH1_0())), UH0_UH0_1());
    const v762: (() => UH0_$union) = method13(v760, (): UH0_$union => closure15(v760, undefined));
    const v763: Mut0 = new Mut0(0n);
    const v764: Mut0 = new Mut0(1n);
    const v765: Mut0 = new Mut0(-1n);
    const v767: Mut6 = new Mut6(US5_US5_1());
    return (): uint8 => closure17(v762, v763, v764, v765, v767, undefined);
}

export function closure24(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"max"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${v0_1}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"n"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v1_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"p"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v2_1}`, undefined);
        v740 = undefined;
        let v749: any;
        closure19(v640, `${" }"}`, undefined);
        v749 = undefined;
        const v811: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.calculate_dice_count"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v811);
        patternInput[1].l0(v811);
    }
}

export function method16(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64): int8 {
    method16:
    while (true) {
        const v0_1: uint64 = v0_1_mut, v1_1: int8 = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (compare_1(v2_1, v0_1) < 0) {
            const v4_1: uint64 = toUInt64(op_Multiply(v2_1, 6n));
            if (compare_1(v4_1, v2_1) > 0) {
                v0_1_mut = v0_1;
                v1_1_mut = (v1_1 + 1);
                v2_1_mut = v4_1;
                continue method16;
            }
            else {
                let v10: any;
                closure24(v0_1, v1_1, v2_1, undefined);
                v10 = undefined;
                return v1_1 | 0;
            }
        }
        else {
            let v877: any;
            closure24(v0_1, v1_1, v2_1, undefined);
            v877 = undefined;
            return v1_1 | 0;
        }
        break;
    }
}

export function closure25(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${v1_1}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"result"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v2_1}`, undefined);
        v740 = undefined;
        let v749: any;
        closure19(v640, `${" }"}`, undefined);
        v749 = undefined;
        const v811: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v811);
        patternInput[1].l0(v811);
    }
}

export function closure89(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(0n, (): UH2_$union => closure89(undefined, undefined));
}

export function closure88(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9223372036854775808n, (): UH2_$union => closure89(undefined, undefined));
}

export function closure87(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4611686018427387904n, (): UH2_$union => closure88(undefined, undefined));
}

export function closure86(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6917529027641081856n, (): UH2_$union => closure87(undefined, undefined));
}

export function closure85(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1152921504606846976n, (): UH2_$union => closure86(undefined, undefined));
}

export function closure84(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(15564440312192434176n, (): UH2_$union => closure85(undefined, undefined));
}

export function closure83(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11817445422220181504n, (): UH2_$union => closure84(undefined, undefined));
}

export function closure82(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5044031582654955520n, (): UH2_$union => closure83(undefined, undefined));
}

export function closure81(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6989586621679009792n, (): UH2_$union => closure82(undefined, undefined));
}

export function closure80(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16537217831704461312n, (): UH2_$union => closure81(undefined, undefined));
}

export function closure79(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11979575008805519360n, (): UH2_$union => closure80(undefined, undefined));
}

export function closure78(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14294425217273954304n, (): UH2_$union => closure79(undefined, undefined));
}

export function closure77(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2382404202878992384n, (): UH2_$union => closure78(undefined, undefined));
}

export function closure76(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6545982058383015936n, (): UH2_$union => closure77(undefined, undefined));
}

export function closure75(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10314369046585278464n, (): UH2_$union => closure76(undefined, undefined));
}

export function closure74(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4793518853382471680n, (): UH2_$union => closure75(undefined, undefined));
}

export function closure73(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3873377154515337216n, (): UH2_$union => closure74(undefined, undefined));
}

export function closure72(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(645562859085889536n, (): UH2_$union => closure73(undefined, undefined));
}

export function closure71(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(107593809847648256n, (): UH2_$union => closure72(undefined, undefined));
}

export function closure70(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3092389647259533312n, (): UH2_$union => closure71(undefined, undefined));
}

export function closure69(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9738770311398031360n, (): UH2_$union => closure70(undefined, undefined));
}

export function closure68(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16995415113324298240n, (): UH2_$union => closure69(undefined, undefined));
}

export function closure67(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8981483876790566912n, (): UH2_$union => closure68(undefined, undefined));
}

export function closure66(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13794743361938128896n, (): UH2_$union => closure67(undefined, undefined));
}

export function closure65(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2299123893656354816n, (): UH2_$union => closure66(undefined, undefined));
}

export function closure64(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3457644661227651072n, (): UH2_$union => closure65(undefined, undefined));
}

export function closure63(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(576274110204608512n, (): UH2_$union => closure64(undefined, undefined));
}

export function closure62(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6244960376270618624n, (): UH2_$union => closure63(undefined, undefined));
}

export function closure61(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13338656111851470848n, (): UH2_$union => closure62(undefined, undefined));
}

export function closure60(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14520938734448279552n, (): UH2_$union => closure61(undefined, undefined));
}

export function closure59(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14717985838214414336n, (): UH2_$union => closure60(undefined, undefined));
}

export function closure58(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5527454985320660992n, (): UH2_$union => closure59(undefined, undefined));
}

export function closure57(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16293529225644736512n, (): UH2_$union => closure58(undefined, undefined));
}

export function closure56(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11938960241128898560n, (): UH2_$union => closure57(undefined, undefined));
}

export function closure55(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8138741398091333632n, (): UH2_$union => closure56(undefined, undefined));
}

export function closure54(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7505371590918406144n, (): UH2_$union => closure55(undefined, undefined));
}

export function closure53(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16623181993244360704n, (): UH2_$union => closure54(undefined, undefined));
}

export function closure52(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8919445023443910656n, (): UH2_$union => closure53(undefined, undefined));
}

export function closure51(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4561031516192243712n, (): UH2_$union => closure52(undefined, undefined));
}

export function closure50(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9983543956220149760n, (): UH2_$union => closure51(undefined, undefined));
}

export function closure49(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4738381338321616896n, (): UH2_$union => closure50(undefined, undefined));
}

export function closure48(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(789730223053602816n, (): UH2_$union => closure49(undefined, undefined));
}

export function closure47(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(131621703842267136n, (): UH2_$union => closure48(undefined, undefined));
}

export function closure46(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(21936950640377856n, (): UH2_$union => closure47(undefined, undefined));
}

export function closure45(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3656158440062976n, (): UH2_$union => closure46(undefined, undefined));
}

export function closure44(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(609359740010496n, (): UH2_$union => closure45(undefined, undefined));
}

export function closure43(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(101559956668416n, (): UH2_$union => closure44(undefined, undefined));
}

export function closure42(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16926659444736n, (): UH2_$union => closure43(undefined, undefined));
}

export function closure41(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2821109907456n, (): UH2_$union => closure42(undefined, undefined));
}

export function closure40(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(470184984576n, (): UH2_$union => closure41(undefined, undefined));
}

export function closure39(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(78364164096n, (): UH2_$union => closure40(undefined, undefined));
}

export function closure38(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13060694016n, (): UH2_$union => closure39(undefined, undefined));
}

export function closure37(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2176782336n, (): UH2_$union => closure38(undefined, undefined));
}

export function closure36(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(362797056n, (): UH2_$union => closure37(undefined, undefined));
}

export function closure35(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(60466176n, (): UH2_$union => closure36(undefined, undefined));
}

export function closure34(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10077696n, (): UH2_$union => closure35(undefined, undefined));
}

export function closure33(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1679616n, (): UH2_$union => closure34(undefined, undefined));
}

export function closure32(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(279936n, (): UH2_$union => closure33(undefined, undefined));
}

export function closure31(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(46656n, (): UH2_$union => closure32(undefined, undefined));
}

export function closure30(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7776n, (): UH2_$union => closure31(undefined, undefined));
}

export function closure29(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1296n, (): UH2_$union => closure30(undefined, undefined));
}

export function closure28(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(216n, (): UH2_$union => closure29(undefined, undefined));
}

export function closure27(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(36n, (): UH2_$union => closure28(undefined, undefined));
}

export function closure26(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6n, (): UH2_$union => closure27(undefined, undefined));
}

export function method19(v0_1_mut: int8, v1_1_mut: UH2_$union): US7_$union {
    method19:
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
            continue method19;
        }
        break;
    }
}

export function closure90(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unitVar: void): void {
    let v318: int64, v328: number;
    const v5 = (): void => {
        closure5(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v39: any;
    v5();
    v39 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v71: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v71, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v79: any;
        closure9(patternInput[0], undefined);
        v79 = undefined;
        let v83: any;
        v5();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v294: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v299: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v294, v), undefined);
        v299 = undefined;
        const v314: US3_$union = defaultArg(_v294.contents, US3_US3_1());
        const v359: string = toString((v314.tag === /* US3_0 */ 0) ? ((v318 = v314.fields[0], (v328 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v318))), create(1, 1, 1, hours(v328), minutes(v328), seconds(v328), milliseconds(v328))))) : now(), method7());
        const v624: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v639: int64 = patternInput_2[0].l0;
        const v641: Mut3 = new Mut3(method9());
        let v648: any;
        closure19(v641, `${"{ "}`, undefined);
        v648 = undefined;
        let v657: any;
        closure19(v641, `${"power"}`, undefined);
        v657 = undefined;
        let v666: any;
        closure19(v641, `${" = "}`, undefined);
        v666 = undefined;
        let v674: any;
        closure19(v641, `${v1_1}`, undefined);
        v674 = undefined;
        let v683: any;
        closure19(v641, `${"; "}`, undefined);
        v683 = undefined;
        let v692: any;
        closure19(v641, `${"acc"}`, undefined);
        v692 = undefined;
        let v700: any;
        closure19(v641, `${" = "}`, undefined);
        v700 = undefined;
        let v708: any;
        closure19(v641, `${v0_1}`, undefined);
        v708 = undefined;
        let v716: any;
        closure19(v641, `${"; "}`, undefined);
        v716 = undefined;
        let v725: any;
        closure19(v641, `${"roll"}`, undefined);
        v725 = undefined;
        let v733: any;
        closure19(v641, `${" = "}`, undefined);
        v733 = undefined;
        let v741: any;
        closure19(v641, `${v2_1}`, undefined);
        v741 = undefined;
        let v749: any;
        closure19(v641, `${"; "}`, undefined);
        v749 = undefined;
        let v758: any;
        closure19(v641, `${"value"}`, undefined);
        v758 = undefined;
        let v766: any;
        closure19(v641, `${" = "}`, undefined);
        v766 = undefined;
        let v774: any;
        closure19(v641, `${v3_1}`, undefined);
        v774 = undefined;
        let v783: any;
        closure19(v641, `${" }"}`, undefined);
        v783 = undefined;
        const v845: string = trimEnd(trimStart(`${v359} ${v624} #${v639} ${"dice.accumulate_dice_rolls"} / ${v641.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v845);
        patternInput[1].l0(v845);
    }
}

export function closure91(v0_1: uint64, v1_1: int8, v2_1: uint8, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${v1_1}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v2_1}`, undefined);
        v740 = undefined;
        let v749: any;
        closure19(v640, `${" }"}`, undefined);
        v749 = undefined;
        const v811: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v811);
        patternInput[1].l0(v811);
    }
}

export function method18(v0_1_mut: int8, v1_1_mut: UH1_$union, v2_1_mut: uint64): US6_$union {
    method18:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH1_$union = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (v0_1 < 0) {
            const v4_1: uint64 = toUInt64(op_Addition(v2_1, 1n));
            let v7: any;
            closure25(v2_1, v0_1, v4_1, undefined);
            v7 = undefined;
            return US6_US6_0(v4_1, v1_1);
        }
        else if (v1_1.tag === /* UH1_0 */ 0) {
            return US6_US6_1();
        }
        else {
            const v874: UH1_$union = v1_1.fields[1];
            const v873: uint8 = v1_1.fields[0];
            if (v873 > 1) {
                const v879: US7_$union = method19(v0_1, UH2_UH2_0(1n, (): UH2_$union => closure26(undefined, undefined)));
                let v883: uint64;
                if (v879.tag === /* US7_0 */ 0) {
                    v883 = v879.fields[0];
                }
                else {
                    throw new Error("Option does not have a value.");
                }
                const v886: uint64 = toUInt64(op_Multiply(toUInt64(fromUInt8(v873 - 1)), v883));
                let v889: any;
                closure90(v2_1, v0_1, v873, v886, undefined);
                v889 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v874;
                v2_1_mut = toUInt64(op_Addition(v2_1, v886));
                continue method18;
            }
            else {
                let v1791: any;
                closure91(v2_1, v0_1, v873, undefined);
                v1791 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v874;
                v2_1_mut = v2_1;
                continue method18;
            }
        }
        break;
    }
}

export function method20(v0_1: int8, v1_1: (() => uint8), v2_1: int8): UH1_$union {
    if (v2_1 < v0_1) {
        return UH1_UH1_1(v1_1(), method20(v0_1, v1_1, v2_1 + 1));
    }
    else {
        return UH1_UH1_0();
    }
}

export function method21(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union): uint64 {
    method21:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut;
        const v5: int8 = (v3_1 + 1) | 0;
        if (v3_1 < v5) {
            return method17(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
        }
        else {
            const v11: US6_$union = method18(v3_1, v4_1, 0n);
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
                    v4_1_mut = method20(v3_1, v0_1, 0);
                    continue method21;
                }
                else {
                    return method17(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
                }
            }
            else if (v1_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = method20(v3_1, v0_1, 0);
                continue method21;
            }
            else {
                return method17(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
            }
        }
        break;
    }
}

export function method17(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union, v5_mut: int8): uint64 {
    method17:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut, v5: int8 = v5_mut;
        if (v5 < (v3_1 + 1)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
            v5_mut = (v5 + 1);
            continue method17;
        }
        else {
            const v13: US6_$union = method18(v3_1, v4_1, 0n);
            if (v13.tag === /* US6_0 */ 0) {
                const v15: UH1_$union = v13.fields[1];
                const v14: uint64 = v13.fields[0];
                if (compare_1(v14, v2_1) <= 0) {
                    return v14;
                }
                else if (v1_1) {
                    return method21(v0_1, v1_1, v2_1, v3_1, method20(v3_1, v0_1, 0));
                }
                else {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                    v5_mut = (v5 + 1);
                    continue method17;
                }
            }
            else if (v1_1) {
                return method21(v0_1, v1_1, v2_1, v3_1, method20(v3_1, v0_1, 0));
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                v5_mut = (v5 + 1);
                continue method17;
            }
        }
        break;
    }
}

export function closure23(v0_1: (() => uint8), v1_1: boolean, v2_1: uint64): uint64 {
    return method17(v0_1, v1_1, v2_1, (equals(v2_1, 1n) ? 1 : method16(v2_1, 0, 1n)) - 1, UH1_UH1_0(), 0);
}

export function closure22(v0_1: (() => uint8), v1_1: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure23(v0_1, v1_1, v);
}

export function closure21(unitVar: void, v0_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure22(v0_1, v);
}

export function method22(v0_1_mut: UH1_$union, v1_1_mut: int8): int8 {
    method22:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v0_1.tag === /* UH1_0 */ 0) {
            return v1_1 | 0;
        }
        else {
            const v2_1: uint8 = v0_1.fields[0];
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v1_1 + 1);
            continue method22;
        }
        break;
    }
}

export function closure93(v0_1: uint64, v1_1: UH1_$union): Option<uint64> {
    const v6: US6_$union = method18(method22(v1_1, 0) - 1, v1_1, 0n);
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

export function closure92(unitVar: void, v0_1: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return (v: UH1_$union): Option<uint64> => closure93(v0_1, v);
}

export function closure95(unitVar: void, unitVar_1: void): void {
    let v314: int64, v324: number;
    const v1_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v35: any;
    v1_1();
    v35 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v67: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v67, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v75: any;
        closure9(patternInput[0], undefined);
        v75 = undefined;
        let v79: any;
        v1_1();
        v79 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v290: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v295: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v290, v), undefined);
        v295 = undefined;
        const v310: US3_$union = defaultArg(_v290.contents, US3_US3_1());
        const v355: string = toString((v310.tag === /* US3_0 */ 0) ? ((v314 = v310.fields[0], (v324 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v314))), create(1, 1, 1, hours(v324), minutes(v324), seconds(v324), milliseconds(v324))))) : now(), method7());
        const v620: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v635: int64 = patternInput_2[0].l0;
        const v637: Mut3 = new Mut3(method9());
        let v644: any;
        closure19(v637, `${"{ "}`, undefined);
        v644 = undefined;
        let v653: any;
        closure19(v637, `${"max"}`, undefined);
        v653 = undefined;
        let v662: any;
        closure19(v637, `${" = "}`, undefined);
        v662 = undefined;
        let v670: any;
        closure19(v637, `${9223372036854775807n}`, undefined);
        v670 = undefined;
        let v679: any;
        closure19(v637, `${"; "}`, undefined);
        v679 = undefined;
        let v688: any;
        closure19(v637, `${"n"}`, undefined);
        v688 = undefined;
        let v696: any;
        closure19(v637, `${" = "}`, undefined);
        v696 = undefined;
        let v704: any;
        closure19(v637, `${24}`, undefined);
        v704 = undefined;
        let v712: any;
        closure19(v637, `${"; "}`, undefined);
        v712 = undefined;
        let v721: any;
        closure19(v637, `${"p"}`, undefined);
        v721 = undefined;
        let v729: any;
        closure19(v637, `${" = "}`, undefined);
        v729 = undefined;
        let v737: any;
        closure19(v637, `${4738381338321616896n}`, undefined);
        v737 = undefined;
        let v746: any;
        closure19(v637, `${" }"}`, undefined);
        v746 = undefined;
        const v808: string = trimEnd(trimStart(`${v355} ${v620} #${v635} ${"dice.calculate_dice_count"} / ${v637.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v808);
        patternInput[1].l0(v808);
    }
}

export function method24(): uint8 {
    const v7: any = nonSeeded();
    const v9: int32 = ~~1 | 0;
    const v11: int32 = ~~7 | 0;
    const value_2: int32 = v7.Next2(v9, v11) | 0;
    return value_2 & 0xFF;
}

export function closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${23}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${22}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${21}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${20}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${19}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${18}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${17}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${16}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${15}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${14}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${13}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${12}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${11}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${10}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${9}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${8}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${7}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${6}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${5}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${4}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${3}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure117(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${2}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure118(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${1}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure119(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    let v317: int64, v327: number;
    const v4_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v5: any;
    v4_1();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4_1();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure9(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4_1();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method7());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut3 = new Mut3(method9());
        let v647: any;
        closure19(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure19(v640, `${"power"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure19(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure19(v640, `${0}`, undefined);
        v673 = undefined;
        let v682: any;
        closure19(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure19(v640, `${"acc"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure19(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure19(v640, `${v0_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure19(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure19(v640, `${"roll"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure19(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure19(v640, `${v1_1}`, undefined);
        v740 = undefined;
        let v748: any;
        closure19(v640, `${"; "}`, undefined);
        v748 = undefined;
        let v757: any;
        closure19(v640, `${"value"}`, undefined);
        v757 = undefined;
        let v765: any;
        closure19(v640, `${" = "}`, undefined);
        v765 = undefined;
        let v773: any;
        closure19(v640, `${v2_1}`, undefined);
        v773 = undefined;
        let v782: any;
        closure19(v640, `${" }"}`, undefined);
        v782 = undefined;
        const v844: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"dice.accumulate_dice_rolls"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v844);
        patternInput[1].l0(v844);
    }
}

export function closure120(v0_1: int64, v1_1: int64, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${-1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"result"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method49(v0_1: UH1_$union, v1_1: int64): US8_$union {
    const v2_1: int64 = toInt64(op_Addition(v1_1, 1n));
    let v5: any;
    closure120(v1_1, v2_1, undefined);
    v5 = undefined;
    return US8_US8_0(v2_1, v0_1);
}

export function closure121(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${0}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v7: int64 = toInt64(fromUInt8(v3_1 - 1));
            let v10: any;
            closure119(v1_1, v3_1, v7, undefined);
            v10 = undefined;
            return method49(v4_1, toInt64(op_Addition(v1_1, v7)));
        }
        else {
            let v911: any;
            closure121(v1_1, v3_1, undefined);
            v911 = undefined;
            return method49(v4_1, v1_1);
        }
    }
}

export function closure122(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 6n));
            let v11: any;
            closure118(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method48(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure122(v1_1, v3_1, undefined);
            v912 = undefined;
            return method48(v4_1, v1_1);
        }
    }
}

export function closure123(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${2}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 36n));
            let v11: any;
            closure117(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method47(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure123(v1_1, v3_1, undefined);
            v912 = undefined;
            return method47(v4_1, v1_1);
        }
    }
}

export function closure124(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${3}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 216n));
            let v11: any;
            closure116(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method46(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure124(v1_1, v3_1, undefined);
            v912 = undefined;
            return method46(v4_1, v1_1);
        }
    }
}

export function closure125(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${4}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1296n));
            let v11: any;
            closure115(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method45(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure125(v1_1, v3_1, undefined);
            v912 = undefined;
            return method45(v4_1, v1_1);
        }
    }
}

export function closure126(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${5}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 7776n));
            let v11: any;
            closure114(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method44(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure126(v1_1, v3_1, undefined);
            v912 = undefined;
            return method44(v4_1, v1_1);
        }
    }
}

export function closure127(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${6}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 46656n));
            let v11: any;
            closure113(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method43(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure127(v1_1, v3_1, undefined);
            v912 = undefined;
            return method43(v4_1, v1_1);
        }
    }
}

export function closure128(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${7}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 279936n));
            let v11: any;
            closure112(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method42(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure128(v1_1, v3_1, undefined);
            v912 = undefined;
            return method42(v4_1, v1_1);
        }
    }
}

export function closure129(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${8}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1679616n));
            let v11: any;
            closure111(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method41(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure129(v1_1, v3_1, undefined);
            v912 = undefined;
            return method41(v4_1, v1_1);
        }
    }
}

export function closure130(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${9}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method39(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 10077696n));
            let v11: any;
            closure110(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method40(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure130(v1_1, v3_1, undefined);
            v912 = undefined;
            return method40(v4_1, v1_1);
        }
    }
}

export function closure131(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${10}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
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
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 60466176n));
            let v11: any;
            closure109(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method39(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure131(v1_1, v3_1, undefined);
            v912 = undefined;
            return method39(v4_1, v1_1);
        }
    }
}

export function closure132(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${11}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method37(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 362797056n));
            let v11: any;
            closure108(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method38(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure132(v1_1, v3_1, undefined);
            v912 = undefined;
            return method38(v4_1, v1_1);
        }
    }
}

export function closure133(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${12}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method36(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2176782336n));
            let v11: any;
            closure107(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method37(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure133(v1_1, v3_1, undefined);
            v912 = undefined;
            return method37(v4_1, v1_1);
        }
    }
}

export function closure134(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${13}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method35(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 13060694016n));
            let v11: any;
            closure106(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method36(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure134(v1_1, v3_1, undefined);
            v912 = undefined;
            return method36(v4_1, v1_1);
        }
    }
}

export function closure135(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${14}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method34(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 78364164096n));
            let v11: any;
            closure105(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method35(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure135(v1_1, v3_1, undefined);
            v912 = undefined;
            return method35(v4_1, v1_1);
        }
    }
}

export function closure136(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${15}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method33(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 470184984576n));
            let v11: any;
            closure104(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method34(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure136(v1_1, v3_1, undefined);
            v912 = undefined;
            return method34(v4_1, v1_1);
        }
    }
}

export function closure137(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${16}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method32(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2821109907456n));
            let v11: any;
            closure103(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method33(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure137(v1_1, v3_1, undefined);
            v912 = undefined;
            return method33(v4_1, v1_1);
        }
    }
}

export function closure138(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${17}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method31(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 16926659444736n));
            let v11: any;
            closure102(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method32(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure138(v1_1, v3_1, undefined);
            v912 = undefined;
            return method32(v4_1, v1_1);
        }
    }
}

export function closure139(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${18}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method30(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 101559956668416n));
            let v11: any;
            closure101(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method31(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure139(v1_1, v3_1, undefined);
            v912 = undefined;
            return method31(v4_1, v1_1);
        }
    }
}

export function closure140(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${19}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method29(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 609359740010496n));
            let v11: any;
            closure100(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method30(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure140(v1_1, v3_1, undefined);
            v912 = undefined;
            return method30(v4_1, v1_1);
        }
    }
}

export function closure141(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${20}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method28(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 3656158440062976n));
            let v11: any;
            closure99(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method29(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure141(v1_1, v3_1, undefined);
            v912 = undefined;
            return method29(v4_1, v1_1);
        }
    }
}

export function closure142(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${21}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method27(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 21936950640377856n));
            let v11: any;
            closure98(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method28(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure142(v1_1, v3_1, undefined);
            v912 = undefined;
            return method28(v4_1, v1_1);
        }
    }
}

export function closure143(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${22}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method26(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 131621703842267136n));
            let v11: any;
            closure97(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method27(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure143(v1_1, v3_1, undefined);
            v912 = undefined;
            return method27(v4_1, v1_1);
        }
    }
}

export function closure144(v0_1: int64, v1_1: uint8, unitVar: void): void {
    let v316: int64, v326: number;
    const v3_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v4_1: any;
    v3_1();
    v4_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3_1();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure9(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3_1();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method7());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method9());
        let v646: any;
        closure19(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure19(v639, `${"power"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure19(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure19(v639, `${23}`, undefined);
        v672 = undefined;
        let v681: any;
        closure19(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure19(v639, `${"acc"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure19(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure19(v639, `${v0_1}`, undefined);
        v706 = undefined;
        let v714: any;
        closure19(v639, `${"; "}`, undefined);
        v714 = undefined;
        let v723: any;
        closure19(v639, `${"roll"}`, undefined);
        v723 = undefined;
        let v731: any;
        closure19(v639, `${" = "}`, undefined);
        v731 = undefined;
        let v739: any;
        closure19(v639, `${v1_1}`, undefined);
        v739 = undefined;
        let v748: any;
        closure19(v639, `${" }"}`, undefined);
        v748 = undefined;
        const v810: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"dice.accumulate_dice_rolls"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v810);
        patternInput[1].l0(v810);
    }
}

export function method25(v0_1: UH1_$union, v1_1: int64): US8_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return US8_US8_1();
    }
    else {
        const v4_1: UH1_$union = v0_1.fields[1];
        const v3_1: uint8 = v0_1.fields[0];
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 789730223053602816n));
            let v11: any;
            closure96(v1_1, v3_1, v8, undefined);
            v11 = undefined;
            return method26(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v912: any;
            closure144(v1_1, v3_1, undefined);
            v912 = undefined;
            return method26(v4_1, v1_1);
        }
    }
}

export function method23(v0_1_mut: UH1_$union, v1_1_mut: int8): int64 {
    method23:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v1_1 < 24) {
            v0_1_mut = UH1_UH1_1(method24(), v0_1);
            v1_1_mut = (v1_1 + 1);
            continue method23;
        }
        else {
            const v8: US8_$union = method25(v0_1, 0n);
            if (v8.tag === /* US8_0 */ 0) {
                const v9: int64 = v8.fields[0];
                const v10: UH1_$union = v8.fields[1];
                if (compare_1(v9, 9223372036854775807n) <= 0) {
                    return v9;
                }
                else {
                    v0_1_mut = UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_0())))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method23;
                }
            }
            else {
                v0_1_mut = UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_1(method24(), UH1_UH1_0())))))))))))))))))))))));
                v1_1_mut = 23;
                continue method23;
            }
        }
        break;
    }
}

export function closure145(v0_1: int64, unitVar: void): void {
    let v315: int64, v325: number;
    const v2_1 = (): void => {
        closure5(undefined, undefined);
    };
    let v3_1: any;
    v2_1();
    v3_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v36: any;
    v2_1();
    v36 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v68: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v68, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v76: any;
        closure9(patternInput[0], undefined);
        v76 = undefined;
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v291: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v296: any;
        closure11(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure10(_v291, v), undefined);
        v296 = undefined;
        const v311: US3_$union = defaultArg(_v291.contents, US3_US3_1());
        const v356: string = toString((v311.tag === /* US3_0 */ 0) ? ((v315 = v311.fields[0], (v325 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v315))), create(1, 1, 1, hours(v325), minutes(v325), seconds(v325), milliseconds(v325))))) : now(), method7());
        const v621: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method8();
        const v636: int64 = patternInput_2[0].l0;
        const v638: Mut3 = new Mut3(method9());
        let v645: any;
        closure19(v638, `${"{ "}`, undefined);
        v645 = undefined;
        let v654: any;
        closure19(v638, `${"result"}`, undefined);
        v654 = undefined;
        let v663: any;
        closure19(v638, `${" = "}`, undefined);
        v663 = undefined;
        let v671: any;
        closure19(v638, `${v0_1}`, undefined);
        v671 = undefined;
        let v680: any;
        closure19(v638, `${" }"}`, undefined);
        v680 = undefined;
        const v742: string = trimEnd(trimStart(`${v356} ${v621} #${v636} ${"dice.main"} / ${v638.l0}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v742);
        patternInput[1].l0(v742);
    }
}

export function closure94(unitVar: void, v0_1: string[]): int32 {
    let v3_1: any;
    closure95(undefined, undefined);
    v3_1 = undefined;
    let v872: any;
    closure145(method23(UH1_UH1_0(), 0), undefined);
    v872 = undefined;
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

export const v2 = (v: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) => closure21(undefined, v);

export function roll_progressively(x: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return v2(x);
}

export const v3 = (v: uint64): ((arg0: UH1_$union) => Option<uint64>) => closure92(undefined, v);

export function roll_within_bounds(x: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return v3(x);
}

export const v4 = (v: string[]): int32 => closure94(undefined, v);

(v4)(typeof process === 'object' ? process.argv.slice(2) : []);

