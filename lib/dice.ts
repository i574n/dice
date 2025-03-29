import { int64ToString, compare, IComparable, IEquatable, createAtom } from "../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_3, Option } from "../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { op_Multiply, toUInt64, equals, compare as compare_1, fromInt64, toUInt8, fromUInt8, op_Subtraction, op_Modulus, op_Addition, toInt64, uint64, int64 } from "../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { int8, int32, uint8 } from "../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { uint64_type, bool_type, string_type, int64_type, record_type, union_type, lambda_type, unit_type, uint8_type, TypeInfo } from "../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { toString, create, now, getTicks } from "../../polyglot/deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../polyglot/deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../polyglot/deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd } from "../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { nonSeeded } from "../../polyglot/deps/Fable/src/fable-library-ts/Random.js";

export let TraceState_trace_state = createAtom<Option<[Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>]>>(undefined);

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

export type US0_$cases = {
    0: ["US0_0", [(() => UH0_$union)]],
    1: ["US0_1", [UH0_$union]]
}

export function US0_US0_0(f0_0: (() => UH0_$union)) {
    return new US0<0>(0, [f0_0]);
}

export function US0_US0_1(f1_0: UH0_$union) {
    return new US0<1>(1, [f1_0]);
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
    return union_type("Dice.US0", [], US0, () => [[["f0_0", lambda_type(unit_type, UH0_$reflection())]], [["f1_0", UH0_$reflection()]]]);
}

export class Mut0 extends Record {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Dice.Mut0", [], Mut0, () => [["l0", US0_$reflection()]]);
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

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", [uint8]],
    1: ["US1_1", []]
}

export function US1_US1_0(f0_0: uint8) {
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
    return union_type("Dice.US1", [], US1, () => [[["f0_0", uint8_type]], []]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: US1_$union;
    constructor(l0: US1_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Dice.Mut2", [], Mut2, () => [["l0", US1_$reflection()]]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>
    | US2<2>
    | US2<3>
    | US2<4>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", []],
    2: ["US2_2", []],
    3: ["US2_3", []],
    4: ["US2_4", []]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
}

export function US2_US2_1() {
    return new US2<1>(1, []);
}

export function US2_US2_2() {
    return new US2<2>(2, []);
}

export function US2_US2_3() {
    return new US2<3>(3, []);
}

export function US2_US2_4() {
    return new US2<4>(4, []);
}

export class US2<Tag extends keyof US2_$cases> extends Union<Tag, US2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1", "US2_2", "US2_3", "US2_4"];
    }
}

export function US2_$reflection(): TypeInfo {
    return union_type("Dice.US2", [], US2, () => [[], [], [], [], []]);
}

export class Mut3 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Dice.Mut3", [], Mut3, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Dice.Mut4", [], Mut4, () => [["l0", bool_type]]);
}

export class Mut5 extends Record implements IEquatable<Mut5>, IComparable<Mut5> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut5_$reflection(): TypeInfo {
    return record_type("Dice.Mut5", [], Mut5, () => [["l0", string_type]]);
}

export class Mut6 extends Record implements IEquatable<Mut6>, IComparable<Mut6> {
    l0: US2_$union;
    constructor(l0: US2_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut6_$reflection(): TypeInfo {
    return record_type("Dice.Mut6", [], Mut6, () => [["l0", US2_$reflection()]]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [US2_$union]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: US2_$union) {
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
    return union_type("Dice.US3", [], US3, () => [[["f0_0", US2_$reflection()]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [int64]],
    1: ["US4_1", []]
}

export function US4_US4_0(f0_0: int64) {
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
    return union_type("Dice.US4", [], US4, () => [[["f0_0", int64_type]], []]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>
    | US5<2>

export type US5_$cases = {
    0: ["US5_0", []],
    1: ["US5_1", []],
    2: ["US5_2", []]
}

export function US5_US5_0() {
    return new US5<0>(0, []);
}

export function US5_US5_1() {
    return new US5<1>(1, []);
}

export function US5_US5_2() {
    return new US5<2>(2, []);
}

export class US5<Tag extends keyof US5_$cases> extends Union<Tag, US5_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US5_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US5_0", "US5_1", "US5_2"];
    }
}

export function US5_$reflection(): TypeInfo {
    return union_type("Dice.US5", [], US5, () => [[], [], []]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>
    | US6<2>
    | US6<3>
    | US6<4>
    | US6<5>

export type US6_$cases = {
    0: ["US6_0", [US5_$union]],
    1: ["US6_1", [US5_$union]],
    2: ["US6_2", [US5_$union]],
    3: ["US6_3", [US5_$union]],
    4: ["US6_4", [US5_$union]],
    5: ["US6_5", [US5_$union]]
}

export function US6_US6_0(f0_0: US5_$union) {
    return new US6<0>(0, [f0_0]);
}

export function US6_US6_1(f1_0: US5_$union) {
    return new US6<1>(1, [f1_0]);
}

export function US6_US6_2(f2_0: US5_$union) {
    return new US6<2>(2, [f2_0]);
}

export function US6_US6_3(f3_0: US5_$union) {
    return new US6<3>(3, [f3_0]);
}

export function US6_US6_4(f4_0: US5_$union) {
    return new US6<4>(4, [f4_0]);
}

export function US6_US6_5(f5_0: US5_$union) {
    return new US6<5>(5, [f5_0]);
}

export class US6<Tag extends keyof US6_$cases> extends Union<Tag, US6_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US6_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US6_0", "US6_1", "US6_2", "US6_3", "US6_4", "US6_5"];
    }
}

export function US6_$reflection(): TypeInfo {
    return union_type("Dice.US6", [], US6, () => [[["f0_0", US5_$reflection()]], [["f1_0", US5_$reflection()]], [["f2_0", US5_$reflection()]], [["f3_0", US5_$reflection()]], [["f4_0", US5_$reflection()]], [["f5_0", US5_$reflection()]]]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [string]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: string) {
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
    return union_type("Dice.US7", [], US7, () => [[["f0_0", string_type]], []]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [uint64, UH1_$union]],
    1: ["US8_1", []]
}

export function US8_US8_0(f0_0: uint64, f0_1: UH1_$union) {
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
    return union_type("Dice.US8", [], US8, () => [[["f0_0", uint64_type], ["f0_1", UH1_$reflection()]], []]);
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

export type US9_$union = 
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [uint64]],
    1: ["US9_1", []]
}

export function US9_US9_0(f0_0: uint64) {
    return new US9<0>(0, [f0_0]);
}

export function US9_US9_1() {
    return new US9<1>(1, []);
}

export class US9<Tag extends keyof US9_$cases> extends Union<Tag, US9_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US9_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US9_0", "US9_1"];
    }
}

export function US9_$reflection(): TypeInfo {
    return union_type("Dice.US9", [], US9, () => [[["f0_0", uint64_type]], []]);
}

export type US10_$union = 
    | US10<0>
    | US10<1>

export type US10_$cases = {
    0: ["US10_0", [int64, UH1_$union]],
    1: ["US10_1", []]
}

export function US10_US10_0(f0_0: int64, f0_1: UH1_$union) {
    return new US10<0>(0, [f0_0, f0_1]);
}

export function US10_US10_1() {
    return new US10<1>(1, []);
}

export class US10<Tag extends keyof US10_$cases> extends Union<Tag, US10_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US10_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US10_0", "US10_1"];
    }
}

export function US10_$reflection(): TypeInfo {
    return union_type("Dice.US10", [], US10, () => [[["f0_0", int64_type], ["f0_1", UH1_$reflection()]], []]);
}

export function closure2(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method0(v0_1: int64, v1_1: UH0_$union, v2_1: UH0_$union): UH0_$union {
    if ((v1_1.tag as int32) === /* UH0_1 */ 1) {
        return v2_1;
    }
    else {
        const v3_1 = v1_1.fields[0] as any;
        const v6: UH0_$union = method0(v0_1, (v1_1.fields[1] as any)(), v2_1);
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
        if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = (v0_1.fields[1] as any);
            v1_1_mut = UH1_UH1_1(v0_1.fields[0] as any, v1_1);
            continue method1;
        }
        break;
    }
}

export function method2(v0_1: UH1_$union, v1_1: UH1_$union): UH1_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return UH1_UH1_1(v0_1.fields[0] as any, method2(v0_1.fields[1] as any, v1_1));
    }
}

export function closure4(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function method3(v0_1: UH1_$union, v1_1: UH0_$union): UH0_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        const v2_1 = v0_1.fields[0] as any;
        const v4_1: UH0_$union = method3(v0_1.fields[1] as any, v1_1);
        return UH0_UH0_0(v2_1, (): UH0_$union => closure4(v4_1, undefined));
    }
}

export function closure5(v0_1: UH0_$union, unitVar: void): UH0_$union {
    return v0_1;
}

export function closure6(v0_1: UH0_$union, v1_1: Mut0, unitVar: void): UH0_$union {
    const v2_1: US0_$union = v1_1.l0;
    if ((v2_1.tag as int32) === /* US0_0 */ 0) {
        const v5: UH0_$union = (v2_1.fields[0] as any)();
        const v12: UH0_$union = ((v5.tag as int32) === /* UH0_1 */ 1) ? UH0_UH0_1() : UH0_UH0_0(v5.fields[0] as any, method4(v0_1, v5.fields[1] as any));
        v1_1.l0 = US0_US0_1(v12);
        return v12;
    }
    else {
        return v2_1.fields[0] as any;
    }
}

export function method4(v0_1: UH0_$union, v1_1: (() => UH0_$union)): (() => UH0_$union) {
    const v3_1: Mut0 = new Mut0(US0_US0_0(v1_1));
    return (): UH0_$union => closure6(v0_1, v3_1, undefined);
}

export function method10(v0_1: string): string {
    return v0_1;
}

export function method11(): string {
    return "";
}

export function closure10(unitVar: void, v0_1: string): US7_$union {
    return US7_US7_0(v0_1);
}

export function method12(): ((arg0: string) => US7_$union) {
    return (v: string): US7_$union => closure10(undefined, v);
}

export function method9(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method8(): [US3_$union, US4_$union] {
    let v48: US3_$union, v55: US3_$union, v62: US3_$union, v69: US3_$union, v76: US3_$union, v83: US3_$union, v90: US3_$union, v97: US3_$union, v104: US3_$union;
    const v1_1: string = method9("TRACE_LEVEL");
    const v6: string = "Critical".toLocaleLowerCase();
    const v13: string = "Warning".toLocaleLowerCase();
    const v20: string = "Info".toLocaleLowerCase();
    const v27: string = "Debug".toLocaleLowerCase();
    const v34: string = "Verbose".toLocaleLowerCase();
    const v41: US3_$union = ("Verbose" === v1_1) ? US3_US3_0(US2_US2_0()) : US3_US3_1();
    return [((v41.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v41.fields[0] as any) : ((v48 = (("Debug" === v1_1) ? US3_US3_0(US2_US2_1()) : US3_US3_1()), ((v48.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v48.fields[0] as any) : ((v55 = (("Info" === v1_1) ? US3_US3_0(US2_US2_2()) : US3_US3_1()), ((v55.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v55.fields[0] as any) : ((v62 = (("Warning" === v1_1) ? US3_US3_0(US2_US2_3()) : US3_US3_1()), ((v62.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v62.fields[0] as any) : ((v69 = (("Critical" === v1_1) ? US3_US3_0(US2_US2_4()) : US3_US3_1()), ((v69.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v69.fields[0] as any) : ((v76 = ((v34 === v1_1) ? US3_US3_0(US2_US2_0()) : US3_US3_1()), ((v76.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v76.fields[0] as any) : ((v83 = ((v27 === v1_1) ? US3_US3_0(US2_US2_1()) : US3_US3_1()), ((v83.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v83.fields[0] as any) : ((v90 = ((v20 === v1_1) ? US3_US3_0(US2_US2_2()) : US3_US3_1()), ((v90.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v90.fields[0] as any) : ((v97 = ((v13 === v1_1) ? US3_US3_0(US2_US2_3()) : US3_US3_1()), ((v97.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v97.fields[0] as any) : ((v104 = ((v6 === v1_1) ? US3_US3_0(US2_US2_4()) : US3_US3_1()), ((v104.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v104.fields[0] as any) : US3_US3_1())))))))))))))))))), (method9("AUTOMATION") !== "True") ? US4_US4_1() : US4_US4_0(toInt64(fromInt64(getTicks(now()))))] as [US3_$union, US4_$union];
}

export function closure11(unitVar: void, v0_1: string): void {
}

export function method7(v0_1: US2_$union): [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] {
    const patternInput: [US3_$union, US4_$union] = method8();
    const _run_target_args$0027_v3 = [patternInput[0], patternInput[1]] as [US3_$union, US4_$union];
    const v173: US4_$union = _run_target_args$0027_v3[1];
    const v172: US3_$union = _run_target_args$0027_v3[0];
    return [new Mut1(1n), new Mut3((v: string): void => {
        closure11(undefined, v);
    }), new Mut4(true), new Mut5(""), new Mut6(((v172.tag as int32) === /* US3_0 */ 0) ? (v172.fields[0] as any) : v0_1), ((v173.tag as int32) === /* US4_0 */ 0) ? (v173.fields[0] as any) : undefined] as [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>];
}

export function closure9(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = method7(US2_US2_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>]);
    }
}

export function method6(v0_1: US2_$union): boolean {
    let v17: any;
    closure9(undefined, undefined);
    v17 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
    const v56: US2_$union = patternInput[4].l0;
    if (patternInput[2].l0 === false) {
        return false;
    }
    else {
        return find<US2_$union, int32>(v0_1, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
            Compare: compare,
        })) >= find<US2_$union, int32>(v56, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
            Compare: compare,
        }));
    }
}

export function closure12(unitVar: void, v0_1: int64): US4_$union {
    return US4_US4_0(v0_1);
}

export function method14(): ((arg0: int64) => US4_$union) {
    return (v: int64): US4_$union => closure12(undefined, v);
}

export function method15(): string {
    return "hh:mm:ss";
}

export function method16(): string {
    return "HH:mm:ss";
}

export function method13(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>): string {
    const v623: US4_$union = defaultArg(map<int64, US4_$union>(method14(), v5), US4_US4_1());
    let v755: Date;
    if ((v623.tag as int32) === /* US4_0 */ 0) {
        const v627 = v623.fields[0] as any;
        const v703: number = fromTicks(toInt64(op_Subtraction(toInt64(fromInt64(getTicks(now()))), v627)));
        v755 = create(1, 1, 1, hours(v703), minutes(v703), seconds(v703), milliseconds(v703));
    }
    else {
        v755 = now();
    }
    const v757: string = method16();
    return toString(v755, (v757 === "") ? "M-d-y hh:mm:ss tt" : v757);
}

export function method18(): string {
    return "";
}

export function closure13(v0_1: Mut5, v1_1: string, unitVar: void): void {
    const v4_1: string = v0_1.l0 + v1_1;
    v0_1.l0 = v4_1;
}

export function method19(): string {
    return "\u001b[0m";
}

export function method17(): string {
    const v4_1: string = "Debug".toLocaleLowerCase();
    const v7: string = v4_1[0];
    const v9: Mut5 = new Mut5(method18());
    let v24: any;
    closure13(v9, `${v7}`, undefined);
    v24 = undefined;
    return ("\u001b[94m" + v9.l0) + method19();
}

export function method21(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method20(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: int64, v10: int64, v11: string): string {
    const v13: Mut5 = new Mut5(method18());
    let v27: any;
    closure13(v13, "{ ", undefined);
    v27 = undefined;
    let v46: any;
    closure13(v13, "current_index", undefined);
    v46 = undefined;
    let v65: any;
    closure13(v13, " = ", undefined);
    v65 = undefined;
    let v85: any;
    closure13(v13, `${v8}`, undefined);
    v85 = undefined;
    let v104: any;
    closure13(v13, "; ", undefined);
    v104 = undefined;
    let v123: any;
    closure13(v13, "acc", undefined);
    v123 = undefined;
    let v140: any;
    closure13(v13, " = ", undefined);
    v140 = undefined;
    let v160: any;
    closure13(v13, `${v9}`, undefined);
    v160 = undefined;
    let v177: any;
    closure13(v13, "; ", undefined);
    v177 = undefined;
    let v196: any;
    closure13(v13, "len", undefined);
    v196 = undefined;
    let v213: any;
    closure13(v13, " = ", undefined);
    v213 = undefined;
    let v233: any;
    closure13(v13, `${v10}`, undefined);
    v233 = undefined;
    let v250: any;
    closure13(v13, "; ", undefined);
    v250 = undefined;
    let v269: any;
    closure13(v13, "last_item", undefined);
    v269 = undefined;
    let v286: any;
    closure13(v13, " = ", undefined);
    v286 = undefined;
    let v303: any;
    closure13(v13, v11, undefined);
    v303 = undefined;
    let v322: any;
    closure13(v13, " }", undefined);
    v322 = undefined;
    const v328: string = v13.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll") + " / ") + v328);
}

export function closure14(v0_1: Mut1, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure16(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure15(unitVar: void, v0_1: string): void {
    let v4_1: any;
    closure16(v0_1, undefined);
    v4_1 = undefined;
}

export function method22(v0_1: string): void {
    let v17: any;
    closure9(undefined, undefined);
    v17 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
    let v60: any;
    closure14(patternInput[0], undefined);
    v60 = undefined;
    closure15(undefined, v0_1);
    patternInput[1].l0(v0_1);
}

export function closure8(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: Option<uint8>, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v22: any;
        closure9(undefined, undefined);
        v22 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v48: Option<int64> = patternInput[5];
        const v47: Mut6 = patternInput[4];
        const v46: Mut5 = patternInput[3];
        const v45: Mut4 = patternInput[2];
        const v44: Mut3 = patternInput[1];
        const v43: Mut1 = patternInput[0];
        method22(method20(v43, v44, v45, v46, v47, v48, method13(v43, v44, v45, v46, v47, v48), method17(), v0_1, v1_1, v2_1, toText(interpolate("%A%P()", [v3_1]))));
    }
}

export function method23(v0_1_mut: int64, v1_1_mut: UH0_$union): US1_$union {
    method23:
    while (true) {
        const v0_1: int64 = v0_1_mut, v1_1: UH0_$union = v1_1_mut;
        if ((v1_1.tag as int32) === /* UH0_1 */ 1) {
            return US1_US1_1();
        }
        else {
            const v3_1 = v1_1.fields[1] as any;
            const v2_1 = v1_1.fields[0] as any;
            if (compare_1(v0_1, 0n) <= 0) {
                return US1_US1_0(v2_1);
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

export function method24(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string): string {
    const v9: Mut5 = new Mut5(method18());
    const v10: string = v9.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + v10);
}

export function closure17(unitVar: void, unitVar_1: void): void {
    if (method6(US2_US2_1())) {
        let v18: any;
        closure9(undefined, undefined);
        v18 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v44: Option<int64> = patternInput[5];
        const v43: Mut6 = patternInput[4];
        const v42: Mut5 = patternInput[3];
        const v41: Mut4 = patternInput[2];
        const v40: Mut3 = patternInput[1];
        const v39: Mut1 = patternInput[0];
        method22(method24(v39, v40, v41, v42, v43, v44, method13(v39, v40, v41, v42, v43, v44), method17()));
    }
}

export function method5(v0_1_mut: (() => UH0_$union), v1_1_mut: Mut1, v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut2): uint8 {
    method5:
    while (true) {
        const v0_1: (() => UH0_$union) = v0_1_mut, v1_1: Mut1 = v1_1_mut, v2_1: Mut1 = v2_1_mut, v3_1: Mut1 = v3_1_mut, v4_1: Mut2 = v4_1_mut;
        const v5: int64 = v1_1.l0;
        const v6: int64 = v2_1.l0;
        const v7: int64 = v3_1.l0;
        const v8: US1_$union = v4_1.l0;
        let v86: any;
        closure8(v5, v6, v7, ((v8.tag as int32) === /* US1_0 */ 0) ? (v8.fields[0] as any) : undefined, undefined);
        v86 = undefined;
        const v151: UH0_$union = v0_1();
        const v153: US1_$union = method23(v1_1.l0, v151);
        if ((v153.tag as int32) === /* US1_0 */ 0) {
            const v154 = v153.fields[0] as any;
            const v156: int64 = toInt64(op_Addition(v1_1.l0, 1n));
            v1_1.l0 = v156;
            v4_1.l0 = US1_US1_0(v154);
            return v154;
        }
        else {
            let v220: any;
            closure17(undefined, undefined);
            v220 = undefined;
            if (equals(v3_1.l0, -1n)) {
                const v283: int64 = v1_1.l0;
                v3_1.l0 = v283;
            }
            const v289: int64 = (compare_1(v2_1.l0, v3_1.l0) >= 0) ? (1n) : toInt64(op_Addition(v2_1.l0, 1n));
            v2_1.l0 = v289;
            const v291: int64 = toInt64(op_Subtraction(v2_1.l0, 1n));
            v1_1.l0 = v291;
            v4_1.l0 = US1_US1_1();
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            continue method5;
        }
        break;
    }
}

export function closure7(v0_1: (() => UH0_$union), v1_1: Mut1, v2_1: Mut1, v3_1: Mut1, v4_1: Mut2, unitVar: void): uint8 {
    return method5(v0_1, v1_1, v2_1, v3_1, v4_1);
}

export function closure3(unitVar: void, v0_1: UH1_$union): (() => uint8) {
    const v5: UH0_$union = method3(method2(v0_1, method1(v0_1, UH1_UH1_0())), UH0_UH0_1());
    const v7: (() => UH0_$union) = method4(v5, (): UH0_$union => closure5(v5, undefined));
    const v8: Mut1 = new Mut1(0n);
    const v9: Mut1 = new Mut1(1n);
    const v10: Mut1 = new Mut1(-1n);
    const v12: Mut2 = new Mut2(US1_US1_1());
    return (): uint8 => closure7(v7, v8, v9, v10, v12, undefined);
}

export function method26(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: uint64, v9: uint64, v10: int8): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "max", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${v8}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "p", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v9}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "n", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v10}`, undefined);
    v232 = undefined;
    let v251: any;
    closure13(v12, " }", undefined);
    v251 = undefined;
    const v257: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v257);
}

export function closure21(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method26(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v2_1, v1_1));
    }
}

export function method25(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64): int8 {
    method25:
    while (true) {
        const v0_1: uint64 = v0_1_mut, v1_1: int8 = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (compare_1(v2_1, v0_1) < 0) {
            const v4_1: uint64 = toUInt64(op_Multiply(v2_1, 6n));
            if (compare_1(v4_1, v2_1) > 0) {
                v0_1_mut = v0_1;
                v1_1_mut = (v1_1 + 1);
                v2_1_mut = v4_1;
                continue method25;
            }
            else {
                let v70: any;
                closure21(v0_1, v1_1, v2_1, undefined);
                v70 = undefined;
                return v1_1 | 0;
            }
        }
        else {
            let v194: any;
            closure21(v0_1, v1_1, v2_1, undefined);
            v194 = undefined;
            return v1_1 | 0;
        }
        break;
    }
}

export function method29(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int8, v9: uint64, v10: uint64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${v8}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v9}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "result", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v10}`, undefined);
    v232 = undefined;
    let v251: any;
    closure13(v12, " }", undefined);
    v251 = undefined;
    const v257: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v257);
}

export function closure22(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method29(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v1_1, v0_1, v2_1));
    }
}

export function closure86(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_1();
}

export function closure85(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9223372036854775808n, (): UH2_$union => closure86(undefined, undefined));
}

export function closure84(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4611686018427387904n, (): UH2_$union => closure85(undefined, undefined));
}

export function closure83(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6917529027641081856n, (): UH2_$union => closure84(undefined, undefined));
}

export function closure82(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1152921504606846976n, (): UH2_$union => closure83(undefined, undefined));
}

export function closure81(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(15564440312192434176n, (): UH2_$union => closure82(undefined, undefined));
}

export function closure80(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11817445422220181504n, (): UH2_$union => closure81(undefined, undefined));
}

export function closure79(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5044031582654955520n, (): UH2_$union => closure80(undefined, undefined));
}

export function closure78(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6989586621679009792n, (): UH2_$union => closure79(undefined, undefined));
}

export function closure77(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16537217831704461312n, (): UH2_$union => closure78(undefined, undefined));
}

export function closure76(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11979575008805519360n, (): UH2_$union => closure77(undefined, undefined));
}

export function closure75(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14294425217273954304n, (): UH2_$union => closure76(undefined, undefined));
}

export function closure74(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2382404202878992384n, (): UH2_$union => closure75(undefined, undefined));
}

export function closure73(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6545982058383015936n, (): UH2_$union => closure74(undefined, undefined));
}

export function closure72(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10314369046585278464n, (): UH2_$union => closure73(undefined, undefined));
}

export function closure71(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4793518853382471680n, (): UH2_$union => closure72(undefined, undefined));
}

export function closure70(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3873377154515337216n, (): UH2_$union => closure71(undefined, undefined));
}

export function closure69(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(645562859085889536n, (): UH2_$union => closure70(undefined, undefined));
}

export function closure68(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(107593809847648256n, (): UH2_$union => closure69(undefined, undefined));
}

export function closure67(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3092389647259533312n, (): UH2_$union => closure68(undefined, undefined));
}

export function closure66(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9738770311398031360n, (): UH2_$union => closure67(undefined, undefined));
}

export function closure65(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16995415113324298240n, (): UH2_$union => closure66(undefined, undefined));
}

export function closure64(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8981483876790566912n, (): UH2_$union => closure65(undefined, undefined));
}

export function closure63(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13794743361938128896n, (): UH2_$union => closure64(undefined, undefined));
}

export function closure62(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2299123893656354816n, (): UH2_$union => closure63(undefined, undefined));
}

export function closure61(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3457644661227651072n, (): UH2_$union => closure62(undefined, undefined));
}

export function closure60(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(576274110204608512n, (): UH2_$union => closure61(undefined, undefined));
}

export function closure59(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6244960376270618624n, (): UH2_$union => closure60(undefined, undefined));
}

export function closure58(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13338656111851470848n, (): UH2_$union => closure59(undefined, undefined));
}

export function closure57(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14520938734448279552n, (): UH2_$union => closure58(undefined, undefined));
}

export function closure56(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(14717985838214414336n, (): UH2_$union => closure57(undefined, undefined));
}

export function closure55(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(5527454985320660992n, (): UH2_$union => closure56(undefined, undefined));
}

export function closure54(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16293529225644736512n, (): UH2_$union => closure55(undefined, undefined));
}

export function closure53(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(11938960241128898560n, (): UH2_$union => closure54(undefined, undefined));
}

export function closure52(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8138741398091333632n, (): UH2_$union => closure53(undefined, undefined));
}

export function closure51(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7505371590918406144n, (): UH2_$union => closure52(undefined, undefined));
}

export function closure50(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16623181993244360704n, (): UH2_$union => closure51(undefined, undefined));
}

export function closure49(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(8919445023443910656n, (): UH2_$union => closure50(undefined, undefined));
}

export function closure48(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4561031516192243712n, (): UH2_$union => closure49(undefined, undefined));
}

export function closure47(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(9983543956220149760n, (): UH2_$union => closure48(undefined, undefined));
}

export function closure46(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(4738381338321616896n, (): UH2_$union => closure47(undefined, undefined));
}

export function closure45(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(789730223053602816n, (): UH2_$union => closure46(undefined, undefined));
}

export function closure44(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(131621703842267136n, (): UH2_$union => closure45(undefined, undefined));
}

export function closure43(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(21936950640377856n, (): UH2_$union => closure44(undefined, undefined));
}

export function closure42(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(3656158440062976n, (): UH2_$union => closure43(undefined, undefined));
}

export function closure41(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(609359740010496n, (): UH2_$union => closure42(undefined, undefined));
}

export function closure40(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(101559956668416n, (): UH2_$union => closure41(undefined, undefined));
}

export function closure39(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(16926659444736n, (): UH2_$union => closure40(undefined, undefined));
}

export function closure38(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2821109907456n, (): UH2_$union => closure39(undefined, undefined));
}

export function closure37(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(470184984576n, (): UH2_$union => closure38(undefined, undefined));
}

export function closure36(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(78364164096n, (): UH2_$union => closure37(undefined, undefined));
}

export function closure35(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(13060694016n, (): UH2_$union => closure36(undefined, undefined));
}

export function closure34(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(2176782336n, (): UH2_$union => closure35(undefined, undefined));
}

export function closure33(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(362797056n, (): UH2_$union => closure34(undefined, undefined));
}

export function closure32(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(60466176n, (): UH2_$union => closure33(undefined, undefined));
}

export function closure31(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(10077696n, (): UH2_$union => closure32(undefined, undefined));
}

export function closure30(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1679616n, (): UH2_$union => closure31(undefined, undefined));
}

export function closure29(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(279936n, (): UH2_$union => closure30(undefined, undefined));
}

export function closure28(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(46656n, (): UH2_$union => closure29(undefined, undefined));
}

export function closure27(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(7776n, (): UH2_$union => closure28(undefined, undefined));
}

export function closure26(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(1296n, (): UH2_$union => closure27(undefined, undefined));
}

export function closure25(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(216n, (): UH2_$union => closure26(undefined, undefined));
}

export function closure24(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(36n, (): UH2_$union => closure25(undefined, undefined));
}

export function closure23(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_0(6n, (): UH2_$union => closure24(undefined, undefined));
}

export function method30(v0_1_mut: int8, v1_1_mut: UH2_$union): US9_$union {
    method30:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if ((v1_1.tag as int32) === /* UH2_1 */ 1) {
            return US9_US9_1();
        }
        else if (v0_1 <= 0) {
            return US9_US9_0(v1_1.fields[0] as any);
        }
        else {
            v0_1_mut = (v0_1 - 1);
            v1_1_mut = (v1_1.fields[1] as any)();
            continue method30;
        }
        break;
    }
}

export function method31(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int8, v9: uint64, v10: uint8, v11: uint64): string {
    const v13: Mut5 = new Mut5(method18());
    let v27: any;
    closure13(v13, "{ ", undefined);
    v27 = undefined;
    let v46: any;
    closure13(v13, "power", undefined);
    v46 = undefined;
    let v65: any;
    closure13(v13, " = ", undefined);
    v65 = undefined;
    let v85: any;
    closure13(v13, `${v8}`, undefined);
    v85 = undefined;
    let v104: any;
    closure13(v13, "; ", undefined);
    v104 = undefined;
    let v123: any;
    closure13(v13, "acc", undefined);
    v123 = undefined;
    let v140: any;
    closure13(v13, " = ", undefined);
    v140 = undefined;
    let v160: any;
    closure13(v13, `${v9}`, undefined);
    v160 = undefined;
    let v177: any;
    closure13(v13, "; ", undefined);
    v177 = undefined;
    let v196: any;
    closure13(v13, "roll", undefined);
    v196 = undefined;
    let v213: any;
    closure13(v13, " = ", undefined);
    v213 = undefined;
    let v233: any;
    closure13(v13, `${v10}`, undefined);
    v233 = undefined;
    let v250: any;
    closure13(v13, "; ", undefined);
    v250 = undefined;
    let v269: any;
    closure13(v13, "value", undefined);
    v269 = undefined;
    let v286: any;
    closure13(v13, " = ", undefined);
    v286 = undefined;
    let v306: any;
    closure13(v13, `${v11}`, undefined);
    v306 = undefined;
    let v325: any;
    closure13(v13, " }", undefined);
    v325 = undefined;
    const v331: string = v13.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v331);
}

export function closure87(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v22: any;
        closure9(undefined, undefined);
        v22 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v48: Option<int64> = patternInput[5];
        const v47: Mut6 = patternInput[4];
        const v46: Mut5 = patternInput[3];
        const v45: Mut4 = patternInput[2];
        const v44: Mut3 = patternInput[1];
        const v43: Mut1 = patternInput[0];
        method22(method31(v43, v44, v45, v46, v47, v48, method13(v43, v44, v45, v46, v47, v48), method17(), v1_1, v0_1, v2_1, v3_1));
    }
}

export function method32(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int8, v9: uint64, v10: uint8): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${v8}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v9}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v10}`, undefined);
    v232 = undefined;
    let v251: any;
    closure13(v12, " }", undefined);
    v251 = undefined;
    const v257: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v257);
}

export function closure88(v0_1: uint64, v1_1: int8, v2_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method32(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v1_1, v0_1, v2_1));
    }
}

export function method28(v0_1_mut: int8, v1_1_mut: UH1_$union, v2_1_mut: uint64): US8_$union {
    method28:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH1_$union = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (v0_1 < 0) {
            const v4_1: uint64 = toUInt64(op_Addition(v2_1, 1n));
            let v67: any;
            closure22(v2_1, v0_1, v4_1, undefined);
            v67 = undefined;
            return US8_US8_0(v4_1, v1_1);
        }
        else if ((v1_1.tag as int32) === /* UH1_0 */ 0) {
            return US8_US8_1();
        }
        else {
            const v131 = v1_1.fields[1] as any;
            const v130 = v1_1.fields[0] as any;
            if (v130 > 1) {
                const v136: US9_$union = method30(v0_1, UH2_UH2_0(1n, (): UH2_$union => closure23(undefined, undefined)));
                let v140: uint64;
                if ((v136.tag as int32) === /* US9_0 */ 0) {
                    v140 = (v136.fields[0] as any);
                }
                else {
                    throw new Error("Option does not have a value.");
                }
                const v143: uint64 = toUInt64(op_Multiply(toUInt64(fromUInt8(v130 - 1)), v140));
                let v206: any;
                closure87(v2_1, v0_1, v130, v143, undefined);
                v206 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v131;
                v2_1_mut = toUInt64(op_Addition(v2_1, v143));
                continue method28;
            }
            else {
                let v332: any;
                closure88(v2_1, v0_1, v130, undefined);
                v332 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v131;
                v2_1_mut = v2_1;
                continue method28;
            }
        }
        break;
    }
}

export function method33(v0_1: int8, v1_1: (() => uint8), v2_1: int8): UH1_$union {
    if (v2_1 < v0_1) {
        return UH1_UH1_1(v1_1(), method33(v0_1, v1_1, v2_1 + 1));
    }
    else {
        return UH1_UH1_0();
    }
}

export function method34(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union): uint64 {
    method34:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut;
        const v5: int8 = (v3_1 + 1) | 0;
        if (v3_1 < v5) {
            return method27(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
        }
        else {
            const v11: US8_$union = method28(v3_1, v4_1, 0n);
            if ((v11.tag as int32) === /* US8_0 */ 0) {
                const v13 = v11.fields[1] as any;
                const v12 = v11.fields[0] as any;
                if (compare_1(v12, v2_1) <= 0) {
                    return v12;
                }
                else if (v1_1) {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = method33(v3_1, v0_1, 0);
                    continue method34;
                }
                else {
                    return method27(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
                }
            }
            else if (v1_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = method33(v3_1, v0_1, 0);
                continue method34;
            }
            else {
                return method27(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
            }
        }
        break;
    }
}

export function method27(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union, v5_mut: int8): uint64 {
    method27:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut, v5: int8 = v5_mut;
        if (v5 < (v3_1 + 1)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
            v5_mut = (v5 + 1);
            continue method27;
        }
        else {
            const v13: US8_$union = method28(v3_1, v4_1, 0n);
            if ((v13.tag as int32) === /* US8_0 */ 0) {
                const v15 = v13.fields[1] as any;
                const v14 = v13.fields[0] as any;
                if (compare_1(v14, v2_1) <= 0) {
                    return v14;
                }
                else if (v1_1) {
                    return method34(v0_1, v1_1, v2_1, v3_1, method33(v3_1, v0_1, 0));
                }
                else {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                    v5_mut = (v5 + 1);
                    continue method27;
                }
            }
            else if (v1_1) {
                return method34(v0_1, v1_1, v2_1, v3_1, method33(v3_1, v0_1, 0));
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                v5_mut = (v5 + 1);
                continue method27;
            }
        }
        break;
    }
}

export function closure20(v0_1: (() => uint8), v1_1: boolean, v2_1: uint64): uint64 {
    return method27(v0_1, v1_1, v2_1, (equals(v2_1, 1n) ? 1 : method25(v2_1, 0, 1n)) - 1, UH1_UH1_0(), 0);
}

export function closure19(v0_1: (() => uint8), v1_1: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure20(v0_1, v1_1, v);
}

export function closure18(unitVar: void, v0_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure19(v0_1, v);
}

export function method35(v0_1_mut: UH1_$union, v1_1_mut: int8): int8 {
    method35:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
            return v1_1 | 0;
        }
        else {
            const v2_1 = v0_1.fields[0] as any;
            v0_1_mut = (v0_1.fields[1] as any);
            v1_1_mut = (v1_1 + 1);
            continue method35;
        }
        break;
    }
}

export function closure90(v0_1: uint64, v1_1: UH1_$union): Option<uint64> {
    const v6: US8_$union = method28(method35(v1_1, 0) - 1, v1_1, 0n);
    let v16: US9_$union;
    if ((v6.tag as int32) === /* US8_0 */ 0) {
        const v8 = v6.fields[1] as any;
        const v7 = v6.fields[0] as any;
        v16 = (((compare_1(v7, 1n) >= 0) && (compare_1(v7, v0_1) <= 0)) ? US9_US9_0(v7) : US9_US9_1());
    }
    else {
        v16 = US9_US9_1();
    }
    if ((v16.tag as int32) === /* US9_0 */ 0) {
        return v16.fields[0] as any;
    }
    else {
        return undefined;
    }
}

export function closure89(unitVar: void, v0_1: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return (v: UH1_$union): Option<uint64> => closure90(v0_1, v);
}

export function method36(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string): string {
    const v9: Mut5 = new Mut5(method18());
    let v23: any;
    closure13(v9, "{ ", undefined);
    v23 = undefined;
    let v42: any;
    closure13(v9, "max", undefined);
    v42 = undefined;
    let v61: any;
    closure13(v9, " = ", undefined);
    v61 = undefined;
    let v81: any;
    closure13(v9, `${9223372036854775807n}`, undefined);
    v81 = undefined;
    let v100: any;
    closure13(v9, "; ", undefined);
    v100 = undefined;
    let v119: any;
    closure13(v9, "p", undefined);
    v119 = undefined;
    let v136: any;
    closure13(v9, " = ", undefined);
    v136 = undefined;
    let v156: any;
    closure13(v9, `${4738381338321616896n}`, undefined);
    v156 = undefined;
    let v173: any;
    closure13(v9, "; ", undefined);
    v173 = undefined;
    let v192: any;
    closure13(v9, "n", undefined);
    v192 = undefined;
    let v209: any;
    closure13(v9, " = ", undefined);
    v209 = undefined;
    let v229: any;
    closure13(v9, `${24}`, undefined);
    v229 = undefined;
    let v248: any;
    closure13(v9, " }", undefined);
    v248 = undefined;
    const v254: string = v9.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v254);
}

export function closure92(unitVar: void, unitVar_1: void): void {
    if (method6(US2_US2_1())) {
        let v18: any;
        closure9(undefined, undefined);
        v18 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v44: Option<int64> = patternInput[5];
        const v43: Mut6 = patternInput[4];
        const v42: Mut5 = patternInput[3];
        const v41: Mut4 = patternInput[2];
        const v40: Mut3 = patternInput[1];
        const v39: Mut1 = patternInput[0];
        method22(method36(v39, v40, v41, v42, v43, v44, method13(v39, v40, v41, v42, v43, v44), method17()));
    }
}

export function method38(): uint8 {
    const v40: any = nonSeeded();
    const v46: int32 = ~~1 | 0;
    const v59: int32 = ~~7 | 0;
    const value_2: int32 = v40.Next2(v46, v59) | 0;
    return value_2 & 0xFF;
}

export function method40(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${23}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure93(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method40(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method42(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${22}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure94(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method42(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method44(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${21}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure95(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method44(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method46(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${20}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method46(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method48(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${19}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method48(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method50(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${18}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method50(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method52(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${17}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method52(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method54(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${16}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method54(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method56(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${15}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method56(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method58(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${14}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method58(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method60(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${13}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method60(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method62(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${12}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method62(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method64(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${11}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method64(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method66(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${10}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method66(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method68(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${9}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method68(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method70(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${8}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method70(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method72(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${7}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method72(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method74(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${6}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method74(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method76(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${5}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method76(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method78(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${4}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method78(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method80(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${3}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method80(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method82(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${2}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method82(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method84(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${1}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method84(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method86(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    const v12: Mut5 = new Mut5(method18());
    let v26: any;
    closure13(v12, "{ ", undefined);
    v26 = undefined;
    let v45: any;
    closure13(v12, "power", undefined);
    v45 = undefined;
    let v64: any;
    closure13(v12, " = ", undefined);
    v64 = undefined;
    let v84: any;
    closure13(v12, `${0}`, undefined);
    v84 = undefined;
    let v103: any;
    closure13(v12, "; ", undefined);
    v103 = undefined;
    let v122: any;
    closure13(v12, "acc", undefined);
    v122 = undefined;
    let v139: any;
    closure13(v12, " = ", undefined);
    v139 = undefined;
    let v159: any;
    closure13(v12, `${v8}`, undefined);
    v159 = undefined;
    let v176: any;
    closure13(v12, "; ", undefined);
    v176 = undefined;
    let v195: any;
    closure13(v12, "roll", undefined);
    v195 = undefined;
    let v212: any;
    closure13(v12, " = ", undefined);
    v212 = undefined;
    let v232: any;
    closure13(v12, `${v9}`, undefined);
    v232 = undefined;
    let v249: any;
    closure13(v12, "; ", undefined);
    v249 = undefined;
    let v268: any;
    closure13(v12, "value", undefined);
    v268 = undefined;
    let v285: any;
    closure13(v12, " = ", undefined);
    v285 = undefined;
    let v305: any;
    closure13(v12, `${v10}`, undefined);
    v305 = undefined;
    let v324: any;
    closure13(v12, " }", undefined);
    v324 = undefined;
    const v330: string = v12.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330);
}

export function closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v21: any;
        closure9(undefined, undefined);
        v21 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v47: Option<int64> = patternInput[5];
        const v46: Mut6 = patternInput[4];
        const v45: Mut5 = patternInput[3];
        const v44: Mut4 = patternInput[2];
        const v43: Mut3 = patternInput[1];
        const v42: Mut1 = patternInput[0];
        method22(method86(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1));
    }
}

export function method88(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: int64): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${-1}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "result", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure117(v0_1: int64, v1_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method88(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method87(v0_1: UH1_$union, v1_1: int64): US10_$union {
    const v2_1: int64 = toInt64(op_Addition(v1_1, 1n));
    let v65: any;
    closure117(v1_1, v2_1, undefined);
    v65 = undefined;
    return US10_US10_0(v2_1, v0_1);
}

export function method89(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${0}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure118(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method89(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method85(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v7: int64 = toInt64(fromUInt8(v3_1 - 1));
            let v70: any;
            closure116(v1_1, v3_1, v7, undefined);
            v70 = undefined;
            return method87(v4_1, toInt64(op_Addition(v1_1, v7)));
        }
        else {
            let v195: any;
            closure118(v1_1, v3_1, undefined);
            v195 = undefined;
            return method87(v4_1, v1_1);
        }
    }
}

export function method90(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${1}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure119(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method90(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method83(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 6n));
            let v71: any;
            closure115(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method85(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure119(v1_1, v3_1, undefined);
            v196 = undefined;
            return method85(v4_1, v1_1);
        }
    }
}

export function method91(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${2}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure120(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method91(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method81(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 36n));
            let v71: any;
            closure114(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method83(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure120(v1_1, v3_1, undefined);
            v196 = undefined;
            return method83(v4_1, v1_1);
        }
    }
}

export function method92(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${3}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure121(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method92(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method79(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 216n));
            let v71: any;
            closure113(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method81(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure121(v1_1, v3_1, undefined);
            v196 = undefined;
            return method81(v4_1, v1_1);
        }
    }
}

export function method93(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${4}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure122(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method93(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method77(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1296n));
            let v71: any;
            closure112(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method79(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure122(v1_1, v3_1, undefined);
            v196 = undefined;
            return method79(v4_1, v1_1);
        }
    }
}

export function method94(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${5}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure123(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method94(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method75(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 7776n));
            let v71: any;
            closure111(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method77(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure123(v1_1, v3_1, undefined);
            v196 = undefined;
            return method77(v4_1, v1_1);
        }
    }
}

export function method95(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${6}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure124(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method95(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method73(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 46656n));
            let v71: any;
            closure110(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method75(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure124(v1_1, v3_1, undefined);
            v196 = undefined;
            return method75(v4_1, v1_1);
        }
    }
}

export function method96(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${7}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure125(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method96(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method71(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 279936n));
            let v71: any;
            closure109(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method73(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure125(v1_1, v3_1, undefined);
            v196 = undefined;
            return method73(v4_1, v1_1);
        }
    }
}

export function method97(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${8}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure126(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method97(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method69(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1679616n));
            let v71: any;
            closure108(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method71(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure126(v1_1, v3_1, undefined);
            v196 = undefined;
            return method71(v4_1, v1_1);
        }
    }
}

export function method98(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${9}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure127(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method98(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method67(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 10077696n));
            let v71: any;
            closure107(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method69(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure127(v1_1, v3_1, undefined);
            v196 = undefined;
            return method69(v4_1, v1_1);
        }
    }
}

export function method99(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${10}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure128(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method99(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method65(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 60466176n));
            let v71: any;
            closure106(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method67(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure128(v1_1, v3_1, undefined);
            v196 = undefined;
            return method67(v4_1, v1_1);
        }
    }
}

export function method100(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${11}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure129(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method100(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method63(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 362797056n));
            let v71: any;
            closure105(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method65(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure129(v1_1, v3_1, undefined);
            v196 = undefined;
            return method65(v4_1, v1_1);
        }
    }
}

export function method101(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${12}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure130(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method101(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method61(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2176782336n));
            let v71: any;
            closure104(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method63(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure130(v1_1, v3_1, undefined);
            v196 = undefined;
            return method63(v4_1, v1_1);
        }
    }
}

export function method102(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${13}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure131(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method102(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method59(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 13060694016n));
            let v71: any;
            closure103(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method61(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure131(v1_1, v3_1, undefined);
            v196 = undefined;
            return method61(v4_1, v1_1);
        }
    }
}

export function method103(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${14}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure132(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method103(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method57(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 78364164096n));
            let v71: any;
            closure102(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method59(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure132(v1_1, v3_1, undefined);
            v196 = undefined;
            return method59(v4_1, v1_1);
        }
    }
}

export function method104(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${15}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure133(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method104(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method55(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 470184984576n));
            let v71: any;
            closure101(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method57(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure133(v1_1, v3_1, undefined);
            v196 = undefined;
            return method57(v4_1, v1_1);
        }
    }
}

export function method105(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${16}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure134(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method105(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method53(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2821109907456n));
            let v71: any;
            closure100(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method55(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure134(v1_1, v3_1, undefined);
            v196 = undefined;
            return method55(v4_1, v1_1);
        }
    }
}

export function method106(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${17}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure135(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method106(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method51(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 16926659444736n));
            let v71: any;
            closure99(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method53(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure135(v1_1, v3_1, undefined);
            v196 = undefined;
            return method53(v4_1, v1_1);
        }
    }
}

export function method107(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${18}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure136(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method107(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method49(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 101559956668416n));
            let v71: any;
            closure98(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method51(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure136(v1_1, v3_1, undefined);
            v196 = undefined;
            return method51(v4_1, v1_1);
        }
    }
}

export function method108(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${19}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure137(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method108(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method47(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 609359740010496n));
            let v71: any;
            closure97(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method49(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure137(v1_1, v3_1, undefined);
            v196 = undefined;
            return method49(v4_1, v1_1);
        }
    }
}

export function method109(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${20}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure138(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method109(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method45(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 3656158440062976n));
            let v71: any;
            closure96(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method47(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure138(v1_1, v3_1, undefined);
            v196 = undefined;
            return method47(v4_1, v1_1);
        }
    }
}

export function method110(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${21}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure139(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method110(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method43(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 21936950640377856n));
            let v71: any;
            closure95(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method45(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure139(v1_1, v3_1, undefined);
            v196 = undefined;
            return method45(v4_1, v1_1);
        }
    }
}

export function method111(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${22}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure140(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method111(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method41(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 131621703842267136n));
            let v71: any;
            closure94(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method43(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure140(v1_1, v3_1, undefined);
            v196 = undefined;
            return method43(v4_1, v1_1);
        }
    }
}

export function method112(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    const v11: Mut5 = new Mut5(method18());
    let v25: any;
    closure13(v11, "{ ", undefined);
    v25 = undefined;
    let v44: any;
    closure13(v11, "power", undefined);
    v44 = undefined;
    let v63: any;
    closure13(v11, " = ", undefined);
    v63 = undefined;
    let v83: any;
    closure13(v11, `${23}`, undefined);
    v83 = undefined;
    let v102: any;
    closure13(v11, "; ", undefined);
    v102 = undefined;
    let v121: any;
    closure13(v11, "acc", undefined);
    v121 = undefined;
    let v138: any;
    closure13(v11, " = ", undefined);
    v138 = undefined;
    let v158: any;
    closure13(v11, `${v8}`, undefined);
    v158 = undefined;
    let v175: any;
    closure13(v11, "; ", undefined);
    v175 = undefined;
    let v194: any;
    closure13(v11, "roll", undefined);
    v194 = undefined;
    let v211: any;
    closure13(v11, " = ", undefined);
    v211 = undefined;
    let v231: any;
    closure13(v11, `${v9}`, undefined);
    v231 = undefined;
    let v250: any;
    closure13(v11, " }", undefined);
    v250 = undefined;
    const v256: string = v11.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256);
}

export function closure141(v0_1: int64, v1_1: uint8, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v20: any;
        closure9(undefined, undefined);
        v20 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v46: Option<int64> = patternInput[5];
        const v45: Mut6 = patternInput[4];
        const v44: Mut5 = patternInput[3];
        const v43: Mut4 = patternInput[2];
        const v42: Mut3 = patternInput[1];
        const v41: Mut1 = patternInput[0];
        method22(method112(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1));
    }
}

export function method39(v0_1: UH1_$union, v1_1: int64): US10_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US10_US10_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 789730223053602816n));
            let v71: any;
            closure93(v1_1, v3_1, v8, undefined);
            v71 = undefined;
            return method41(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v196: any;
            closure141(v1_1, v3_1, undefined);
            v196 = undefined;
            return method41(v4_1, v1_1);
        }
    }
}

export function method37(v0_1_mut: UH1_$union, v1_1_mut: int8): int64 {
    method37:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v1_1 < 24) {
            v0_1_mut = UH1_UH1_1(method38(), v0_1);
            v1_1_mut = (v1_1 + 1);
            continue method37;
        }
        else {
            const v8: US10_$union = method39(v0_1, 0n);
            if ((v8.tag as int32) === /* US10_0 */ 0) {
                const v9 = v8.fields[0] as any;
                const v10 = v8.fields[1] as any;
                if (compare_1(v9, 9223372036854775807n) <= 0) {
                    return v9;
                }
                else {
                    v0_1_mut = UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_0())))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method37;
                }
            }
            else {
                v0_1_mut = UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_1(method38(), UH1_UH1_0())))))))))))))))))))))));
                v1_1_mut = 23;
                continue method37;
            }
        }
        break;
    }
}

export function method113(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64): string {
    const v10: Mut5 = new Mut5(method18());
    let v24: any;
    closure13(v10, "{ ", undefined);
    v24 = undefined;
    let v43: any;
    closure13(v10, "result", undefined);
    v43 = undefined;
    let v62: any;
    closure13(v10, " = ", undefined);
    v62 = undefined;
    let v82: any;
    closure13(v10, `${v8}`, undefined);
    v82 = undefined;
    let v101: any;
    closure13(v10, " }", undefined);
    v101 = undefined;
    const v107: string = v10.l0;
    return method21((((((((v6 + " ") + v7) + " #") + int64ToString(v0_1.l0)) + " ") + "dice.main") + " / ") + v107);
}

export function closure142(v0_1: int64, unitVar: void): void {
    if (method6(US2_US2_1())) {
        let v19: any;
        closure9(undefined, undefined);
        v19 = undefined;
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_3(TraceState_trace_state());
        const v45: Option<int64> = patternInput[5];
        const v44: Mut6 = patternInput[4];
        const v43: Mut5 = patternInput[3];
        const v42: Mut4 = patternInput[2];
        const v41: Mut3 = patternInput[1];
        const v40: Mut1 = patternInput[0];
        method22(method113(v40, v41, v42, v43, v44, v45, method13(v40, v41, v42, v43, v44, v45), method17(), v0_1));
    }
}

export function closure91(unitVar: void, v0_1: string[]): int32 {
    let v63: any;
    closure92(undefined, undefined);
    v63 = undefined;
    let v189: any;
    closure142(method37(UH1_UH1_0(), 0), undefined);
    v189 = undefined;
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

export const v2 = (v: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) => closure18(undefined, v);

export function roll_progressively(x: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return v2(x);
}

export const v3 = (v: uint64): ((arg0: UH1_$union) => Option<uint64>) => closure89(undefined, v);

export function roll_within_bounds(x: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return v3(x);
}

export const v4 = (v: string[]): int32 => closure91(undefined, v);

(v4)(typeof process === 'object' ? process.argv.slice(2) : []);

