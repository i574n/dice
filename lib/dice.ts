import { compare as compare_1, IComparable, IEquatable, createAtom } from "../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { value as value_1, map, defaultArg, Option } from "../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { op_Multiply, toUInt64, equals, compare, fromInt64, toUInt8, fromUInt8, op_Subtraction, op_Modulus, op_Addition, toInt64, uint64, int64 } from "../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { int8, int32, uint8 } from "../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { uint64_type, int32_type, char_type, option_type, class_type, bool_type, string_type, int64_type, record_type, union_type, lambda_type, unit_type, uint8_type, TypeInfo } from "../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { toString, create, now, getTicks } from "../../polyglot/deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../polyglot/deps/Fable/src/fable-library-ts/TimeSpan.js";
import { ofSeq, find } from "../../polyglot/deps/Fable/src/fable-library-ts/Map.js";
import { interpolate, toText } from "../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { nonSeeded } from "../../polyglot/deps/Fable/src/fable-library-ts/Random.js";

export interface IOsEnviron {
    environ(): any
}

export let TraceState_trace_state = createAtom<Option<[Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>]>>(undefined);

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
    | US6<6>
    | US6<7>

export type US6_$cases = {
    0: ["US6_0", [US5_$union]],
    1: ["US6_1", [US5_$union]],
    2: ["US6_2", [US5_$union]],
    3: ["US6_3", [US5_$union]],
    4: ["US6_4", [US5_$union]],
    5: ["US6_5", [US5_$union]],
    6: ["US6_6", [US5_$union]],
    7: ["US6_7", [US5_$union]]
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

export function US6_US6_6(f6_0: US5_$union) {
    return new US6<6>(6, [f6_0]);
}

export function US6_US6_7(f7_0: US5_$union) {
    return new US6<7>(7, [f7_0]);
}

export class US6<Tag extends keyof US6_$cases> extends Union<Tag, US6_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US6_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US6_0", "US6_1", "US6_2", "US6_3", "US6_4", "US6_5", "US6_6", "US6_7"];
    }
}

export function US6_$reflection(): TypeInfo {
    return union_type("Dice.US6", [], US6, () => [[["f0_0", US5_$reflection()]], [["f1_0", US5_$reflection()]], [["f2_0", US5_$reflection()]], [["f3_0", US5_$reflection()]], [["f4_0", US5_$reflection()]], [["f5_0", US5_$reflection()]], [["f6_0", US5_$reflection()]], [["f7_0", US5_$reflection()]]]);
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
    0: ["US8_0", [int64]],
    1: ["US8_1", [Error]]
}

export function US8_US8_0(f0_0: int64) {
    return new US8<0>(0, [f0_0]);
}

export function US8_US8_1(f1_0: Error) {
    return new US8<1>(1, [f1_0]);
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
    return union_type("Dice.US8", [], US8, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US9_$union = 
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>]],
    1: ["US9_1", []]
}

export function US9_US9_0(f0_0: Mut1, f0_1: Mut3, f0_2: Mut4, f0_3: Mut5, f0_4: Mut6, f0_5: Option<int64>) {
    return new US9<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4, f0_5]);
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
    return union_type("Dice.US9", [], US9, () => [[["f0_0", Mut1_$reflection()], ["f0_1", Mut3_$reflection()], ["f0_2", Mut4_$reflection()], ["f0_3", Mut5_$reflection()], ["f0_4", Mut6_$reflection()], ["f0_5", option_type(int64_type)]], []]);
}

export type US10_$union = 
    | US10<0>
    | US10<1>

export type US10_$cases = {
    0: ["US10_0", [string]],
    1: ["US10_1", []]
}

export function US10_US10_0(f0_0: string) {
    return new US10<0>(0, [f0_0]);
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
    return union_type("Dice.US10", [], US10, () => [[["f0_0", char_type]], []]);
}

export class Mut7 extends Record implements IEquatable<Mut7>, IComparable<Mut7> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut7_$reflection(): TypeInfo {
    return record_type("Dice.Mut7", [], Mut7, () => [["l0", int32_type]]);
}

export type US11_$union = 
    | US11<0>
    | US11<1>

export type US11_$cases = {
    0: ["US11_0", [uint64, UH1_$union]],
    1: ["US11_1", []]
}

export function US11_US11_0(f0_0: uint64, f0_1: UH1_$union) {
    return new US11<0>(0, [f0_0, f0_1]);
}

export function US11_US11_1() {
    return new US11<1>(1, []);
}

export class US11<Tag extends keyof US11_$cases> extends Union<Tag, US11_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US11_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US11_0", "US11_1"];
    }
}

export function US11_$reflection(): TypeInfo {
    return union_type("Dice.US11", [], US11, () => [[["f0_0", uint64_type], ["f0_1", UH1_$reflection()]], []]);
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

export type US12_$union = 
    | US12<0>
    | US12<1>

export type US12_$cases = {
    0: ["US12_0", [uint64]],
    1: ["US12_1", []]
}

export function US12_US12_0(f0_0: uint64) {
    return new US12<0>(0, [f0_0]);
}

export function US12_US12_1() {
    return new US12<1>(1, []);
}

export class US12<Tag extends keyof US12_$cases> extends Union<Tag, US12_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US12_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US12_0", "US12_1"];
    }
}

export function US12_$reflection(): TypeInfo {
    return union_type("Dice.US12", [], US12, () => [[["f0_0", uint64_type]], []]);
}

export type US13_$union = 
    | US13<0>
    | US13<1>

export type US13_$cases = {
    0: ["US13_0", [int32]],
    1: ["US13_1", [Error]]
}

export function US13_US13_0(f0_0: int32) {
    return new US13<0>(0, [f0_0]);
}

export function US13_US13_1(f1_0: Error) {
    return new US13<1>(1, [f1_0]);
}

export class US13<Tag extends keyof US13_$cases> extends Union<Tag, US13_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US13_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US13_0", "US13_1"];
    }
}

export function US13_$reflection(): TypeInfo {
    return union_type("Dice.US13", [], US13, () => [[["f0_0", int32_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US14_$union = 
    | US14<0>
    | US14<1>

export type US14_$cases = {
    0: ["US14_0", [int32]],
    1: ["US14_1", []]
}

export function US14_US14_0(f0_0: int32) {
    return new US14<0>(0, [f0_0]);
}

export function US14_US14_1() {
    return new US14<1>(1, []);
}

export class US14<Tag extends keyof US14_$cases> extends Union<Tag, US14_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US14_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US14_0", "US14_1"];
    }
}

export function US14_$reflection(): TypeInfo {
    return union_type("Dice.US14", [], US14, () => [[["f0_0", int32_type]], []]);
}

export type US15_$union = 
    | US15<0>
    | US15<1>

export type US15_$cases = {
    0: ["US15_0", [uint8]],
    1: ["US15_1", [Error]]
}

export function US15_US15_0(f0_0: uint8) {
    return new US15<0>(0, [f0_0]);
}

export function US15_US15_1(f1_0: Error) {
    return new US15<1>(1, [f1_0]);
}

export class US15<Tag extends keyof US15_$cases> extends Union<Tag, US15_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US15_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US15_0", "US15_1"];
    }
}

export function US15_$reflection(): TypeInfo {
    return union_type("Dice.US15", [], US15, () => [[["f0_0", uint8_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US16_$union = 
    | US16<0>
    | US16<1>

export type US16_$cases = {
    0: ["US16_0", [int64, UH1_$union]],
    1: ["US16_1", []]
}

export function US16_US16_0(f0_0: int64, f0_1: UH1_$union) {
    return new US16<0>(0, [f0_0, f0_1]);
}

export function US16_US16_1() {
    return new US16<1>(1, []);
}

export class US16<Tag extends keyof US16_$cases> extends Union<Tag, US16_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US16_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US16_0", "US16_1"];
    }
}

export function US16_$reflection(): TypeInfo {
    return union_type("Dice.US16", [], US16, () => [[["f0_0", int64_type], ["f0_1", UH1_$reflection()]], []]);
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

export function method9(v0_1: string): string {
    return v0_1;
}

export function method10(): string {
    return "";
}

export function closure10(unitVar: void, v0_1: string): US7_$union {
    return US7_US7_0(v0_1);
}

export function method11(): ((arg0: string) => US7_$union) {
    return (v: string): US7_$union => closure10(undefined, v);
}

export function method8(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function closure11(v0_1: int64, unitVar: void): int64 {
    return toInt64(fromInt64(v0_1));
}

export function closure12(unitVar: void, v0_1: int64): US8_$union {
    return US8_US8_0(v0_1);
}

export function closure13(unitVar: void, v0_1: (() => Error)): Error {
    return v0_1();
}

export function closure14(unitVar: void, v0_1: Error): US8_$union {
    return US8_US8_1(v0_1);
}

export function method12(v0_1: int64): US8_$union {
    try {
        return closure12(undefined, closure11(v0_1, undefined));
    }
    catch (ex: any) {
        return closure14(undefined, closure13(undefined, (): Error => ex));
    }
}

export function method7(): [US3_$union, US4_$union] {
    let v128: US3_$union, v135: US3_$union, v142: US3_$union, v149: US3_$union, v156: US3_$union, v163: US3_$union, v170: US3_$union, v177: US3_$union, v184: US3_$union, v526: US8_$union, v547: US4_$union, v544: Error;
    const v1_1: string = method8("TRACE_LEVEL");
    const v13: string = "Critical".toLocaleLowerCase();
    const v36: string = "Warning".toLocaleLowerCase();
    const v59: string = "Info".toLocaleLowerCase();
    const v82: string = "Debug".toLocaleLowerCase();
    const v105: string = "Verbose".toLocaleLowerCase();
    const v121: US3_$union = ("Verbose" === v1_1) ? US3_US3_0(US2_US2_0()) : US3_US3_1();
    return [((v121.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v121.fields[0] as any) : ((v128 = (("Debug" === v1_1) ? US3_US3_0(US2_US2_1()) : US3_US3_1()), ((v128.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v128.fields[0] as any) : ((v135 = (("Info" === v1_1) ? US3_US3_0(US2_US2_2()) : US3_US3_1()), ((v135.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v135.fields[0] as any) : ((v142 = (("Warning" === v1_1) ? US3_US3_0(US2_US2_3()) : US3_US3_1()), ((v142.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v142.fields[0] as any) : ((v149 = (("Critical" === v1_1) ? US3_US3_0(US2_US2_4()) : US3_US3_1()), ((v149.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v149.fields[0] as any) : ((v156 = ((v105 === v1_1) ? US3_US3_0(US2_US2_0()) : US3_US3_1()), ((v156.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v156.fields[0] as any) : ((v163 = ((v82 === v1_1) ? US3_US3_0(US2_US2_1()) : US3_US3_1()), ((v163.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v163.fields[0] as any) : ((v170 = ((v59 === v1_1) ? US3_US3_0(US2_US2_2()) : US3_US3_1()), ((v170.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v170.fields[0] as any) : ((v177 = ((v36 === v1_1) ? US3_US3_0(US2_US2_3()) : US3_US3_1()), ((v177.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v177.fields[0] as any) : ((v184 = ((v13 === v1_1) ? US3_US3_0(US2_US2_4()) : US3_US3_1()), ((v184.tag as int32) === /* US3_0 */ 0) ? US3_US3_0(v184.fields[0] as any) : US3_US3_1())))))))))))))))))), (method8("AUTOMATION") !== "True") ? US4_US4_1() : ((v526 = method12(getTicks(now())), (v547 = (((v526.tag as int32) === /* US8_0 */ 0) ? US4_US4_0(v526.fields[0] as any) : ((v544 = (v526.fields[0] as any), US4_US4_1()))), US4_US4_0(((v547.tag as int32) === /* US4_0 */ 0) ? (v547.fields[0] as any) : (() => {
        throw new Error("Option does not have a value.");
    })()))))] as [US3_$union, US4_$union];
}

export function closure15(unitVar: void, v0_1: string): void {
}

export function method6(v0_1: US2_$union): [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] {
    const patternInput: [US3_$union, US4_$union] = method7();
    const _run_target_args$0027_v5 = [patternInput[0], patternInput[1]] as [US3_$union, US4_$union];
    const v747: US4_$union = _run_target_args$0027_v5[1];
    const v746: US3_$union = _run_target_args$0027_v5[0];
    return [new Mut1(1n), new Mut3((v: string): void => {
        closure15(undefined, v);
    }), new Mut4(true), new Mut5(""), new Mut6(((v746.tag as int32) === /* US3_0 */ 0) ? (v746.fields[0] as any) : v0_1), ((v747.tag as int32) === /* US4_0 */ 0) ? (v747.fields[0] as any) : undefined] as [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>];
}

export function closure9(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = method6(US2_US2_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>]);
    }
}

export function closure16(unitVar: void, v0_1: int64): US4_$union {
    return US4_US4_0(v0_1);
}

export function method14(): ((arg0: int64) => US4_$union) {
    return (v: int64): US4_$union => closure16(undefined, v);
}

export function method15(): string {
    return "hh:mm:ss";
}

export function method16(): string {
    return "HH:mm:ss";
}

export function method13(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>): string {
    const v3874: US4_$union = defaultArg(map<int64, US4_$union>(method14(), v5), US4_US4_1());
    let v4611: Date;
    if ((v3874.tag as int32) === /* US4_0 */ 0) {
        const v3887 = v3874.fields[0] as any;
        const v4181: US8_$union = method12(getTicks(now()));
        let v4202: US4_$union;
        if ((v4181.tag as int32) === /* US8_0 */ 0) {
            v4202 = US4_US4_0(v4181.fields[0] as any);
        }
        else {
            const v4199 = v4181.fields[0] as any;
            v4202 = US4_US4_1();
        }
        const v4366: number = fromTicks(toInt64(op_Subtraction(((v4202.tag as int32) === /* US4_0 */ 0) ? (v4202.fields[0] as any) : (() => {
            throw new Error("Option does not have a value.");
        })(), v3887)));
        v4611 = create(1, 1, 1, hours(v4366), minutes(v4366), seconds(v4366), milliseconds(v4366));
    }
    else {
        v4611 = now();
    }
    const v4619: string = method16();
    return toString(v4611, (v4619 === "") ? "M-d-y hh:mm:ss tt" : v4619);
}

export function method19(): string {
    return "";
}

export function method20(v0_1: Mut5, v1_1: string): void {
    const v5: string = v0_1.l0 + v1_1;
    v0_1.l0 = v5;
}

export function method18(v0_1: string): string {
    const v12: Mut5 = new Mut5(method19());
    method20(v12, `${v0_1}`);
    return v12.l0;
}

export function method17(): string {
    const v537: string = "Debug".toLocaleLowerCase();
    return ("\u001b[94m" + method18(v537[0])) + "\u001b[0m";
}

export function method22(v0_1: int64): string {
    const v12: Mut5 = new Mut5(method19());
    method20(v12, `${v0_1}`);
    return v12.l0;
}

export function method24(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "{ ";
    v0_1.l0 = v7;
}

export function method25(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "current_index";
    v0_1.l0 = v7;
}

export function method26(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + " = ";
    v0_1.l0 = v7;
}

export function method27(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "; ";
    v0_1.l0 = v7;
}

export function method28(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "acc";
    v0_1.l0 = v7;
}

export function method29(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "len";
    v0_1.l0 = v7;
}

export function method30(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "last_item";
    v0_1.l0 = v7;
}

export function method31(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + " }";
    v0_1.l0 = v7;
}

export function method23(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: string): string {
    const v15: Mut5 = new Mut5(method19());
    method24(v15);
    method25(v15);
    method26(v15);
    method20(v15, `${v0_1}`);
    method27(v15);
    method28(v15);
    method26(v15);
    method20(v15, `${v1_1}`);
    method27(v15);
    method29(v15);
    method26(v15);
    method20(v15, `${v2_1}`);
    method27(v15);
    method30(v15);
    method26(v15);
    method20(v15, v3_1);
    method31(v15);
    return v15.l0;
}

export function method34(v0_1_mut: string, v1_1_mut: int64): boolean {
    method34:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare(v1_1, 4n) >= 0) {
            return false;
        }
        else {
            let v19: US10_$union;
            if (equals(v1_1, 0n)) {
                v19 = US10_US10_0(" ");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v19 = US10_US10_0("\t");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v19 = US10_US10_0("\r");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        if (equals(v11, 0n)) {
                            v19 = US10_US10_0("\n");
                        }
                        else {
                            const v14: int64 = toInt64(op_Subtraction(v11, 1n));
                            v19 = US10_US10_1();
                        }
                    }
                }
            }
            if (v0_1 === (((v19.tag as int32) === /* US10_0 */ 0) ? (v19.fields[0] as any) : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method34;
            }
        }
        break;
    }
}

export function method33(v0_1_mut: string, v1_1_mut: int32, v2_1_mut: int32): int32 {
    method33:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int32 = v1_1_mut, v2_1: int32 = v2_1_mut;
        if (v2_1 >= v1_1) {
            return v1_1 | 0;
        }
        else if (method34(v0_1[v2_1], 0n)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = (v2_1 + 1);
            continue method33;
        }
        else {
            return v2_1 | 0;
        }
        break;
    }
}

export function method36(v0_1_mut: string, v1_1_mut: int64): boolean {
    method36:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare(v1_1, 2n) >= 0) {
            return false;
        }
        else {
            let v11: US10_$union;
            if (equals(v1_1, 0n)) {
                v11 = US10_US10_0(" ");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v11 = US10_US10_0("/");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    v11 = US10_US10_1();
                }
            }
            if (v0_1 === (((v11.tag as int32) === /* US10_0 */ 0) ? (v11.fields[0] as any) : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method36;
            }
        }
        break;
    }
}

export function method35(v0_1_mut: string, v1_1_mut: int32): int32 {
    method35:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v1_1 <= 0) {
            return 0;
        }
        else {
            const v3_1: int32 = (v1_1 - 1) | 0;
            if (method36(v0_1[v3_1], 0n)) {
                v0_1_mut = v0_1;
                v1_1_mut = v3_1;
                continue method35;
            }
            else {
                return v3_1 | 0;
            }
        }
        break;
    }
}

export function method32(v0_1: string): string {
    const v1_1: int32 = v0_1.length | 0;
    const v3_1: int32 = method33(v0_1, v1_1, 0) | 0;
    const v716: string = v0_1.slice(v3_1, v1_1 + 1);
    const v730: int32 = method35(v716, v716.length) | 0;
    return v716.slice(0, v730 + 1);
}

export function method21(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: int64, v10: int64, v11: string): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.create_sequential_roller / roll") + " / ") + method23(v8, v9, v10, v11));
}

export function closure17(v0_1: Mut1, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure19(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure18(unitVar: void, v0_1: string): void {
    let v33: any;
    closure19(v0_1, undefined);
    v33 = undefined;
}

export function method37(v0_1: int32, v1_1: Mut7): boolean {
    return v1_1.l0 < v0_1;
}

export function closure8(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: Option<uint8>, unitVar: void): void {
    const v77 = (): void => {
        closure9(undefined, undefined);
    };
    let v78: any;
    v77();
    v78 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v206: US2_$union = patternInput[4].l0;
    let v911: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v206, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v911 = US9_US9_1();
    }
    else {
        let v287: any;
        v77();
        v287 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v373: Option<int64> = patternInput_1[5];
        const v372: Mut6 = patternInput_1[4];
        const v371: Mut5 = patternInput_1[3];
        const v370: Mut4 = patternInput_1[2];
        const v369: Mut3 = patternInput_1[1];
        const v368: Mut1 = patternInput_1[0];
        const v431: string = method21(v368, v369, v370, v371, v372, v373, method13(v368, v369, v370, v371, v372, v373), method17(), v0_1, v1_1, v2_1, toText(interpolate("%A%P()", [v3_1])));
        let v505: any;
        v77();
        v505 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v587: Mut3 = patternInput_2[1];
        const v586: Mut1 = patternInput_2[0];
        let v639: any;
        closure17(v586, undefined);
        v639 = undefined;
        closure18(undefined, v431);
        v587.l0(v431);
        v911 = US9_US9_0(v586, v587, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method38(v0_1_mut: int64, v1_1_mut: UH0_$union): US1_$union {
    method38:
    while (true) {
        const v0_1: int64 = v0_1_mut, v1_1: UH0_$union = v1_1_mut;
        if ((v1_1.tag as int32) === /* UH0_1 */ 1) {
            return US1_US1_1();
        }
        else {
            const v3_1 = v1_1.fields[1] as any;
            const v2_1 = v1_1.fields[0] as any;
            if (compare(v0_1, 0n) <= 0) {
                return US1_US1_0(v2_1);
            }
            else {
                v0_1_mut = toInt64(op_Subtraction(v0_1, 1n));
                v1_1_mut = v3_1();
                continue method38;
            }
        }
        break;
    }
}

export function method40(): string {
    const v11: Mut5 = new Mut5(method19());
    return v11.l0;
}

export function method39(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + method40());
}

export function closure20(unitVar: void, unitVar_1: void): void {
    const v73 = (): void => {
        closure9(undefined, undefined);
    };
    let v74: any;
    v73();
    v74 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v202: US2_$union = patternInput[4].l0;
    let v893: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v202, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v893 = US9_US9_1();
    }
    else {
        let v283: any;
        v73();
        v283 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v369: Option<int64> = patternInput_1[5];
        const v368: Mut6 = patternInput_1[4];
        const v367: Mut5 = patternInput_1[3];
        const v366: Mut4 = patternInput_1[2];
        const v365: Mut3 = patternInput_1[1];
        const v364: Mut1 = patternInput_1[0];
        const v413: string = method39(v364, v365, v366, v367, v368, v369, method13(v364, v365, v366, v367, v368, v369), method17());
        let v487: any;
        v73();
        v487 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v569: Mut3 = patternInput_2[1];
        const v568: Mut1 = patternInput_2[0];
        let v621: any;
        closure17(v568, undefined);
        v621 = undefined;
        closure18(undefined, v413);
        v569.l0(v413);
        v893 = US9_US9_0(v568, v569, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
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
        let v1935: any;
        closure8(v5, v6, v7, ((v8.tag as int32) === /* US1_0 */ 0) ? (v8.fields[0] as any) : undefined, undefined);
        v1935 = undefined;
        const v2911: UH0_$union = v0_1();
        const v2913: US1_$union = method38(v1_1.l0, v2911);
        if ((v2913.tag as int32) === /* US1_0 */ 0) {
            const v2914 = v2913.fields[0] as any;
            const v2916: int64 = toInt64(op_Addition(v1_1.l0, 1n));
            v1_1.l0 = v2916;
            v4_1.l0 = US1_US1_0(v2914);
            return v2914;
        }
        else {
            let v4773: any;
            closure20(undefined, undefined);
            v4773 = undefined;
            if (equals(v3_1.l0, -1n)) {
                const v5737: int64 = v1_1.l0;
                v3_1.l0 = v5737;
            }
            const v5743: int64 = (compare(v2_1.l0, v3_1.l0) >= 0) ? (1n) : toInt64(op_Addition(v2_1.l0, 1n));
            v2_1.l0 = v5743;
            const v5745: int64 = toInt64(op_Subtraction(v2_1.l0, 1n));
            v1_1.l0 = v5745;
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

export function method44(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "max";
    v0_1.l0 = v7;
}

export function method45(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "p";
    v0_1.l0 = v7;
}

export function method46(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "n";
    v0_1.l0 = v7;
}

export function method43(v0_1: uint64, v1_1: uint64, v2_1: int8): string {
    const v14: Mut5 = new Mut5(method19());
    method24(v14);
    method44(v14);
    method26(v14);
    method20(v14, `${v0_1}`);
    method27(v14);
    method45(v14);
    method26(v14);
    method20(v14, `${v1_1}`);
    method27(v14);
    method46(v14);
    method26(v14);
    method20(v14, `${v2_1}`);
    method31(v14);
    return v14.l0;
}

export function method42(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: uint64, v9: uint64, v10: int8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.calculate_dice_count") + " / ") + method43(v8, v9, v10));
}

export function closure24(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method42(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v2_1, v1_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method41(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64): int8 {
    method41:
    while (true) {
        const v0_1: uint64 = v0_1_mut, v1_1: int8 = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (compare(v2_1, v0_1) < 0) {
            const v4_1: uint64 = toUInt64(op_Multiply(v2_1, 6n));
            if (compare(v4_1, v2_1) > 0) {
                v0_1_mut = v0_1;
                v1_1_mut = (v1_1 + 1);
                v2_1_mut = v4_1;
                continue method41;
            }
            else {
                let v1863: any;
                closure24(v0_1, v1_1, v2_1, undefined);
                v1863 = undefined;
                return v1_1 | 0;
            }
        }
        else {
            let v4681: any;
            closure24(v0_1, v1_1, v2_1, undefined);
            v4681 = undefined;
            return v1_1 | 0;
        }
        break;
    }
}

export function method51(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "power";
    v0_1.l0 = v7;
}

export function method52(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "result";
    v0_1.l0 = v7;
}

export function method50(v0_1: int8, v1_1: uint64, v2_1: uint64): string {
    const v14: Mut5 = new Mut5(method19());
    method24(v14);
    method51(v14);
    method26(v14);
    method20(v14, `${v0_1}`);
    method27(v14);
    method28(v14);
    method26(v14);
    method20(v14, `${v1_1}`);
    method27(v14);
    method52(v14);
    method26(v14);
    method20(v14, `${v2_1}`);
    method31(v14);
    return v14.l0;
}

export function method49(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int8, v9: uint64, v10: uint64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method50(v8, v9, v10));
}

export function closure25(v0_1: uint64, v1_1: int8, v2_1: uint64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method49(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v1_1, v0_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure89(unitVar: void, unitVar_1: void): UH2_$union {
    return UH2_UH2_1();
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

export function method53(v0_1_mut: int8, v1_1_mut: UH2_$union): US12_$union {
    method53:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if ((v1_1.tag as int32) === /* UH2_1 */ 1) {
            return US12_US12_1();
        }
        else if (v0_1 <= 0) {
            return US12_US12_0(v1_1.fields[0] as any);
        }
        else {
            v0_1_mut = (v0_1 - 1);
            v1_1_mut = (v1_1.fields[1] as any)();
            continue method53;
        }
        break;
    }
}

export function method56(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "roll";
    v0_1.l0 = v7;
}

export function method57(v0_1: Mut5): void {
    const v7: string = v0_1.l0 + "value";
    v0_1.l0 = v7;
}

export function method55(v0_1: int8, v1_1: uint64, v2_1: uint8, v3_1: uint64): string {
    const v15: Mut5 = new Mut5(method19());
    method24(v15);
    method51(v15);
    method26(v15);
    method20(v15, `${v0_1}`);
    method27(v15);
    method28(v15);
    method26(v15);
    method20(v15, `${v1_1}`);
    method27(v15);
    method56(v15);
    method26(v15);
    method20(v15, `${v2_1}`);
    method27(v15);
    method57(v15);
    method26(v15);
    method20(v15, `${v3_1}`);
    method31(v15);
    return v15.l0;
}

export function method54(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int8, v9: uint64, v10: uint8, v11: uint64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method55(v8, v9, v10, v11));
}

export function closure90(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unitVar: void): void {
    const v77 = (): void => {
        closure9(undefined, undefined);
    };
    let v78: any;
    v77();
    v78 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v206: US2_$union = patternInput[4].l0;
    let v897: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v206, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v897 = US9_US9_1();
    }
    else {
        let v287: any;
        v77();
        v287 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v373: Option<int64> = patternInput_1[5];
        const v372: Mut6 = patternInput_1[4];
        const v371: Mut5 = patternInput_1[3];
        const v370: Mut4 = patternInput_1[2];
        const v369: Mut3 = patternInput_1[1];
        const v368: Mut1 = patternInput_1[0];
        const v417: string = method54(v368, v369, v370, v371, v372, v373, method13(v368, v369, v370, v371, v372, v373), method17(), v1_1, v0_1, v2_1, v3_1);
        let v491: any;
        v77();
        v491 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v573: Mut3 = patternInput_2[1];
        const v572: Mut1 = patternInput_2[0];
        let v625: any;
        closure17(v572, undefined);
        v625 = undefined;
        closure18(undefined, v417);
        v573.l0(v417);
        v897 = US9_US9_0(v572, v573, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method59(v0_1: int8, v1_1: uint64, v2_1: uint8): string {
    const v14: Mut5 = new Mut5(method19());
    method24(v14);
    method51(v14);
    method26(v14);
    method20(v14, `${v0_1}`);
    method27(v14);
    method28(v14);
    method26(v14);
    method20(v14, `${v1_1}`);
    method27(v14);
    method56(v14);
    method26(v14);
    method20(v14, `${v2_1}`);
    method31(v14);
    return v14.l0;
}

export function method58(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int8, v9: uint64, v10: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method59(v8, v9, v10));
}

export function closure91(v0_1: uint64, v1_1: int8, v2_1: uint8, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method58(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v1_1, v0_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method48(v0_1_mut: int8, v1_1_mut: UH1_$union, v2_1_mut: uint64): US11_$union {
    method48:
    while (true) {
        const v0_1: int8 = v0_1_mut, v1_1: UH1_$union = v1_1_mut, v2_1: uint64 = v2_1_mut;
        if (v0_1 < 0) {
            const v4_1: uint64 = toUInt64(op_Addition(v2_1, 1n));
            let v1860: any;
            closure25(v2_1, v0_1, v4_1, undefined);
            v1860 = undefined;
            return US11_US11_0(v4_1, v1_1);
        }
        else if ((v1_1.tag as int32) === /* UH1_0 */ 0) {
            return US11_US11_1();
        }
        else {
            const v2825 = v1_1.fields[1] as any;
            const v2824 = v1_1.fields[0] as any;
            if (v2824 > 1) {
                const v2830: US12_$union = method53(v0_1, UH2_UH2_0(1n, (): UH2_$union => closure26(undefined, undefined)));
                let v2834: uint64;
                if ((v2830.tag as int32) === /* US12_0 */ 0) {
                    v2834 = (v2830.fields[0] as any);
                }
                else {
                    throw new Error("Option does not have a value.");
                }
                const v2837: uint64 = toUInt64(op_Multiply(toUInt64(fromUInt8(v2824 - 1)), v2834));
                let v4693: any;
                closure90(v2_1, v0_1, v2824, v2837, undefined);
                v4693 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v2825;
                v2_1_mut = toUInt64(op_Addition(v2_1, v2837));
                continue method48;
            }
            else {
                let v7513: any;
                closure91(v2_1, v0_1, v2824, undefined);
                v7513 = undefined;
                v0_1_mut = (v0_1 - 1);
                v1_1_mut = v2825;
                v2_1_mut = v2_1;
                continue method48;
            }
        }
        break;
    }
}

export function method60(v0_1: int8, v1_1: (() => uint8), v2_1: int8): UH1_$union {
    if (v2_1 < v0_1) {
        return UH1_UH1_1(v1_1(), method60(v0_1, v1_1, v2_1 + 1));
    }
    else {
        return UH1_UH1_0();
    }
}

export function method61(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union): uint64 {
    method61:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut;
        const v5: int8 = (v3_1 + 1) | 0;
        if (v3_1 < v5) {
            return method47(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
        }
        else {
            const v11: US11_$union = method48(v3_1, v4_1, 0n);
            if ((v11.tag as int32) === /* US11_0 */ 0) {
                const v13 = v11.fields[1] as any;
                const v12 = v11.fields[0] as any;
                if (compare(v12, v2_1) <= 0) {
                    return v12;
                }
                else if (v1_1) {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = method60(v3_1, v0_1, 0);
                    continue method61;
                }
                else {
                    return method47(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
                }
            }
            else if (v1_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = method60(v3_1, v0_1, 0);
                continue method61;
            }
            else {
                return method47(v0_1, v1_1, v2_1, v3_1, UH1_UH1_1(v0_1(), v4_1), v5);
            }
        }
        break;
    }
}

export function method47(v0_1_mut: (() => uint8), v1_1_mut: boolean, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1_$union, v5_mut: int8): uint64 {
    method47:
    while (true) {
        const v0_1: (() => uint8) = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: uint64 = v2_1_mut, v3_1: int8 = v3_1_mut, v4_1: UH1_$union = v4_1_mut, v5: int8 = v5_mut;
        if (v5 < (v3_1 + 1)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
            v5_mut = (v5 + 1);
            continue method47;
        }
        else {
            const v13: US11_$union = method48(v3_1, v4_1, 0n);
            if ((v13.tag as int32) === /* US11_0 */ 0) {
                const v15 = v13.fields[1] as any;
                const v14 = v13.fields[0] as any;
                if (compare(v14, v2_1) <= 0) {
                    return v14;
                }
                else if (v1_1) {
                    return method61(v0_1, v1_1, v2_1, v3_1, method60(v3_1, v0_1, 0));
                }
                else {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                    v5_mut = (v5 + 1);
                    continue method47;
                }
            }
            else if (v1_1) {
                return method61(v0_1, v1_1, v2_1, v3_1, method60(v3_1, v0_1, 0));
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = UH1_UH1_1(v0_1(), v4_1);
                v5_mut = (v5 + 1);
                continue method47;
            }
        }
        break;
    }
}

export function closure23(v0_1: (() => uint8), v1_1: boolean, v2_1: uint64): uint64 {
    return method47(v0_1, v1_1, v2_1, (equals(v2_1, 1n) ? 1 : method41(v2_1, 0, 1n)) - 1, UH1_UH1_0(), 0);
}

export function closure22(v0_1: (() => uint8), v1_1: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure23(v0_1, v1_1, v);
}

export function closure21(unitVar: void, v0_1: (() => uint8)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure22(v0_1, v);
}

export function method62(v0_1_mut: UH1_$union, v1_1_mut: int8): int8 {
    method62:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
            return v1_1 | 0;
        }
        else {
            const v2_1 = v0_1.fields[0] as any;
            v0_1_mut = (v0_1.fields[1] as any);
            v1_1_mut = (v1_1 + 1);
            continue method62;
        }
        break;
    }
}

export function closure93(v0_1: uint64, v1_1: UH1_$union): Option<uint64> {
    const v6: US11_$union = method48(method62(v1_1, 0) - 1, v1_1, 0n);
    let v16: US12_$union;
    if ((v6.tag as int32) === /* US11_0 */ 0) {
        const v8 = v6.fields[1] as any;
        const v7 = v6.fields[0] as any;
        v16 = (((compare(v7, 1n) >= 0) && (compare(v7, v0_1) <= 0)) ? US12_US12_0(v7) : US12_US12_1());
    }
    else {
        v16 = US12_US12_1();
    }
    if ((v16.tag as int32) === /* US12_0 */ 0) {
        return v16.fields[0] as any;
    }
    else {
        return undefined;
    }
}

export function closure92(unitVar: void, v0_1: uint64): ((arg0: UH1_$union) => Option<uint64>) {
    return (v: UH1_$union): Option<uint64> => closure93(v0_1, v);
}

export function method64(v0_1: int64, v1_1: int64, v2_1: int8): string {
    const v14: Mut5 = new Mut5(method19());
    method24(v14);
    method44(v14);
    method26(v14);
    method20(v14, `${v0_1}`);
    method27(v14);
    method45(v14);
    method26(v14);
    method20(v14, `${v1_1}`);
    method27(v14);
    method46(v14);
    method26(v14);
    method20(v14, `${v2_1}`);
    method31(v14);
    return v14.l0;
}

export function method63(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.calculate_dice_count") + " / ") + method64(9223372036854775807n, 4738381338321616896n, 24));
}

export function closure95(unitVar: void, unitVar_1: void): void {
    const v73 = (): void => {
        closure9(undefined, undefined);
    };
    let v74: any;
    v73();
    v74 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v202: US2_$union = patternInput[4].l0;
    let v893: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v202, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v893 = US9_US9_1();
    }
    else {
        let v283: any;
        v73();
        v283 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v369: Option<int64> = patternInput_1[5];
        const v368: Mut6 = patternInput_1[4];
        const v367: Mut5 = patternInput_1[3];
        const v366: Mut4 = patternInput_1[2];
        const v365: Mut3 = patternInput_1[1];
        const v364: Mut1 = patternInput_1[0];
        const v413: string = method63(v364, v365, v366, v367, v368, v369, method13(v364, v365, v366, v367, v368, v369), method17());
        let v487: any;
        v73();
        v487 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v569: Mut3 = patternInput_2[1];
        const v568: Mut1 = patternInput_2[0];
        let v621: any;
        closure17(v568, undefined);
        v621 = undefined;
        closure18(undefined, v413);
        v569.l0(v413);
        v893 = US9_US9_0(v568, v569, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure96(unitVar: void, unitVar_1: void): int32 {
    return ~~1;
}

export function closure97(unitVar: void, v0_1: int32): US13_$union {
    return US13_US13_0(v0_1);
}

export function closure98(unitVar: void, v0_1: Error): US13_$union {
    return US13_US13_1(v0_1);
}

export function method67(): US13_$union {
    try {
        return closure97(undefined, closure96(undefined, undefined));
    }
    catch (ex: any) {
        return closure98(undefined, closure13(undefined, (): Error => ex));
    }
}

export function closure99(unitVar: void, unitVar_1: void): int32 {
    return ~~7;
}

export function method68(): US13_$union {
    try {
        return closure97(undefined, closure99(undefined, undefined));
    }
    catch (ex: any) {
        return closure98(undefined, closure13(undefined, (): Error => ex));
    }
}

export function closure100(v0_1: int32, unitVar: void): uint8 {
    return v0_1 & 0xFF;
}

export function closure101(unitVar: void, v0_1: uint8): US15_$union {
    return US15_US15_0(v0_1);
}

export function closure102(unitVar: void, v0_1: Error): US15_$union {
    return US15_US15_1(v0_1);
}

export function method69(v0_1: int32): US15_$union {
    try {
        return closure101(undefined, closure100(v0_1, undefined));
    }
    catch (ex: any) {
        return closure102(undefined, closure13(undefined, (): Error => ex));
    }
}

export function method66(): uint8 {
    const v1387: any = nonSeeded();
    const v1518: US13_$union = method67();
    let v1539: US14_$union;
    if ((v1518.tag as int32) === /* US13_0 */ 0) {
        v1539 = US14_US14_0(v1518.fields[0] as any);
    }
    else {
        const v1536 = v1518.fields[0] as any;
        v1539 = US14_US14_1();
    }
    let v1588: int32;
    if ((v1539.tag as int32) === /* US14_0 */ 0) {
        v1588 = (v1539.fields[0] as any);
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v1826: US13_$union = method68();
    let v1847: US14_$union;
    if ((v1826.tag as int32) === /* US13_0 */ 0) {
        v1847 = US14_US14_0(v1826.fields[0] as any);
    }
    else {
        const v1844 = v1826.fields[0] as any;
        v1847 = US14_US14_1();
    }
    let v1896: int32;
    if ((v1847.tag as int32) === /* US14_0 */ 0) {
        v1896 = (v1847.fields[0] as any);
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v2026: US15_$union = method69(v1387.Next2(v1588, v1896));
    let v2047: US1_$union;
    if ((v2026.tag as int32) === /* US15_0 */ 0) {
        v2047 = US1_US1_0(v2026.fields[0] as any);
    }
    else {
        const v2044 = v2026.fields[0] as any;
        v2047 = US1_US1_1();
    }
    if ((v2047.tag as int32) === /* US1_0 */ 0) {
        return v2047.fields[0] as any;
    }
    else {
        throw new Error("Option does not have a value.");
    }
}

export function method72(v0_1: int8, v1_1: int64, v2_1: uint8, v3_1: int64): string {
    const v15: Mut5 = new Mut5(method19());
    method24(v15);
    method51(v15);
    method26(v15);
    method20(v15, `${v0_1}`);
    method27(v15);
    method28(v15);
    method26(v15);
    method20(v15, `${v1_1}`);
    method27(v15);
    method56(v15);
    method26(v15);
    method20(v15, `${v2_1}`);
    method27(v15);
    method57(v15);
    method26(v15);
    method20(v15, `${v3_1}`);
    method31(v15);
    return v15.l0;
}

export function method71(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(23, v8, v9, v10));
}

export function closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method71(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method74(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(22, v8, v9, v10));
}

export function closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method74(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method76(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(21, v8, v9, v10));
}

export function closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method76(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method78(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(20, v8, v9, v10));
}

export function closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method78(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method80(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(19, v8, v9, v10));
}

export function closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method80(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method82(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(18, v8, v9, v10));
}

export function closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method82(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method84(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(17, v8, v9, v10));
}

export function closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method84(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method86(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(16, v8, v9, v10));
}

export function closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method86(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method88(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(15, v8, v9, v10));
}

export function closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method88(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method90(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(14, v8, v9, v10));
}

export function closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method90(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method92(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(13, v8, v9, v10));
}

export function closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method92(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method94(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(12, v8, v9, v10));
}

export function closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method94(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method96(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(11, v8, v9, v10));
}

export function closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method96(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method98(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(10, v8, v9, v10));
}

export function closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method98(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method100(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(9, v8, v9, v10));
}

export function closure117(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method100(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method102(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(8, v8, v9, v10));
}

export function closure118(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method102(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method104(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(7, v8, v9, v10));
}

export function closure119(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method104(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method106(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(6, v8, v9, v10));
}

export function closure120(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method106(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method108(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(5, v8, v9, v10));
}

export function closure121(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method108(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method110(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(4, v8, v9, v10));
}

export function closure122(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method110(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method112(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(3, v8, v9, v10));
}

export function closure123(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method112(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method114(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(2, v8, v9, v10));
}

export function closure124(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method114(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method116(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(1, v8, v9, v10));
}

export function closure125(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method116(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method118(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8, v10: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method72(0, v8, v9, v10));
}

export function closure126(v0_1: int64, v1_1: uint8, v2_1: int64, unitVar: void): void {
    const v76 = (): void => {
        closure9(undefined, undefined);
    };
    let v77: any;
    v76();
    v77 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v205: US2_$union = patternInput[4].l0;
    let v896: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v205, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v896 = US9_US9_1();
    }
    else {
        let v286: any;
        v76();
        v286 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v372: Option<int64> = patternInput_1[5];
        const v371: Mut6 = patternInput_1[4];
        const v370: Mut5 = patternInput_1[3];
        const v369: Mut4 = patternInput_1[2];
        const v368: Mut3 = patternInput_1[1];
        const v367: Mut1 = patternInput_1[0];
        const v416: string = method118(v367, v368, v369, v370, v371, v372, method13(v367, v368, v369, v370, v371, v372), method17(), v0_1, v1_1, v2_1);
        let v490: any;
        v76();
        v490 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v572: Mut3 = patternInput_2[1];
        const v571: Mut1 = patternInput_2[0];
        let v624: any;
        closure17(v571, undefined);
        v624 = undefined;
        closure18(undefined, v416);
        v572.l0(v416);
        v896 = US9_US9_0(v571, v572, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method121(v0_1: int8, v1_1: int64, v2_1: int64): string {
    const v14: Mut5 = new Mut5(method19());
    method24(v14);
    method51(v14);
    method26(v14);
    method20(v14, `${v0_1}`);
    method27(v14);
    method28(v14);
    method26(v14);
    method20(v14, `${v1_1}`);
    method27(v14);
    method52(v14);
    method26(v14);
    method20(v14, `${v2_1}`);
    method31(v14);
    return v14.l0;
}

export function method120(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method121(-1, v8, v9));
}

export function closure127(v0_1: int64, v1_1: int64, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method120(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method119(v0_1: UH1_$union, v1_1: int64): US16_$union {
    const v2_1: int64 = toInt64(op_Addition(v1_1, 1n));
    let v1858: any;
    closure127(v1_1, v2_1, undefined);
    v1858 = undefined;
    return US16_US16_0(v2_1, v0_1);
}

export function method123(v0_1: int8, v1_1: int64, v2_1: uint8): string {
    const v14: Mut5 = new Mut5(method19());
    method24(v14);
    method51(v14);
    method26(v14);
    method20(v14, `${v0_1}`);
    method27(v14);
    method28(v14);
    method26(v14);
    method20(v14, `${v1_1}`);
    method27(v14);
    method56(v14);
    method26(v14);
    method20(v14, `${v2_1}`);
    method31(v14);
    return v14.l0;
}

export function method122(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(0, v8, v9));
}

export function closure128(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method122(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method117(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v7: int64 = toInt64(fromUInt8(v3_1 - 1));
            let v1863: any;
            closure126(v1_1, v3_1, v7, undefined);
            v1863 = undefined;
            return method119(v4_1, toInt64(op_Addition(v1_1, v7)));
        }
        else {
            let v4682: any;
            closure128(v1_1, v3_1, undefined);
            v4682 = undefined;
            return method119(v4_1, v1_1);
        }
    }
}

export function method124(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(1, v8, v9));
}

export function closure129(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method124(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method115(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 6n));
            let v1864: any;
            closure125(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method117(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure129(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method117(v4_1, v1_1);
        }
    }
}

export function method125(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(2, v8, v9));
}

export function closure130(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method125(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method113(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 36n));
            let v1864: any;
            closure124(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method115(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure130(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method115(v4_1, v1_1);
        }
    }
}

export function method126(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(3, v8, v9));
}

export function closure131(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method126(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method111(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 216n));
            let v1864: any;
            closure123(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method113(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure131(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method113(v4_1, v1_1);
        }
    }
}

export function method127(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(4, v8, v9));
}

export function closure132(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method127(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method109(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1296n));
            let v1864: any;
            closure122(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method111(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure132(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method111(v4_1, v1_1);
        }
    }
}

export function method128(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(5, v8, v9));
}

export function closure133(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method128(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method107(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 7776n));
            let v1864: any;
            closure121(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method109(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure133(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method109(v4_1, v1_1);
        }
    }
}

export function method129(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(6, v8, v9));
}

export function closure134(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method129(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method105(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 46656n));
            let v1864: any;
            closure120(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method107(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure134(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method107(v4_1, v1_1);
        }
    }
}

export function method130(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(7, v8, v9));
}

export function closure135(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method130(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method103(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 279936n));
            let v1864: any;
            closure119(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method105(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure135(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method105(v4_1, v1_1);
        }
    }
}

export function method131(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(8, v8, v9));
}

export function closure136(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method131(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method101(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 1679616n));
            let v1864: any;
            closure118(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method103(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure136(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method103(v4_1, v1_1);
        }
    }
}

export function method132(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(9, v8, v9));
}

export function closure137(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method132(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method99(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 10077696n));
            let v1864: any;
            closure117(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method101(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure137(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method101(v4_1, v1_1);
        }
    }
}

export function method133(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(10, v8, v9));
}

export function closure138(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method133(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method97(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 60466176n));
            let v1864: any;
            closure116(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method99(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure138(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method99(v4_1, v1_1);
        }
    }
}

export function method134(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(11, v8, v9));
}

export function closure139(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method134(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method95(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 362797056n));
            let v1864: any;
            closure115(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method97(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure139(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method97(v4_1, v1_1);
        }
    }
}

export function method135(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(12, v8, v9));
}

export function closure140(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method135(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method93(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2176782336n));
            let v1864: any;
            closure114(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method95(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure140(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method95(v4_1, v1_1);
        }
    }
}

export function method136(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(13, v8, v9));
}

export function closure141(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method136(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method91(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 13060694016n));
            let v1864: any;
            closure113(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method93(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure141(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method93(v4_1, v1_1);
        }
    }
}

export function method137(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(14, v8, v9));
}

export function closure142(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method137(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method89(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 78364164096n));
            let v1864: any;
            closure112(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method91(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure142(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method91(v4_1, v1_1);
        }
    }
}

export function method138(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(15, v8, v9));
}

export function closure143(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method138(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method87(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 470184984576n));
            let v1864: any;
            closure111(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method89(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure143(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method89(v4_1, v1_1);
        }
    }
}

export function method139(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(16, v8, v9));
}

export function closure144(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method139(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method85(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 2821109907456n));
            let v1864: any;
            closure110(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method87(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure144(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method87(v4_1, v1_1);
        }
    }
}

export function method140(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(17, v8, v9));
}

export function closure145(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method140(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method83(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 16926659444736n));
            let v1864: any;
            closure109(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method85(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure145(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method85(v4_1, v1_1);
        }
    }
}

export function method141(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(18, v8, v9));
}

export function closure146(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method141(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method81(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 101559956668416n));
            let v1864: any;
            closure108(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method83(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure146(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method83(v4_1, v1_1);
        }
    }
}

export function method142(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(19, v8, v9));
}

export function closure147(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method142(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method79(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 609359740010496n));
            let v1864: any;
            closure107(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method81(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure147(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method81(v4_1, v1_1);
        }
    }
}

export function method143(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(20, v8, v9));
}

export function closure148(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method143(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method77(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 3656158440062976n));
            let v1864: any;
            closure106(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method79(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure148(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method79(v4_1, v1_1);
        }
    }
}

export function method144(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(21, v8, v9));
}

export function closure149(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method144(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method75(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 21936950640377856n));
            let v1864: any;
            closure105(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method77(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure149(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method77(v4_1, v1_1);
        }
    }
}

export function method145(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(22, v8, v9));
}

export function closure150(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method145(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method73(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 131621703842267136n));
            let v1864: any;
            closure104(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method75(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure150(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method75(v4_1, v1_1);
        }
    }
}

export function method146(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: uint8): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method123(23, v8, v9));
}

export function closure151(v0_1: int64, v1_1: uint8, unitVar: void): void {
    const v75 = (): void => {
        closure9(undefined, undefined);
    };
    let v76: any;
    v75();
    v76 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v204: US2_$union = patternInput[4].l0;
    let v895: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v204, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v895 = US9_US9_1();
    }
    else {
        let v285: any;
        v75();
        v285 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v371: Option<int64> = patternInput_1[5];
        const v370: Mut6 = patternInput_1[4];
        const v369: Mut5 = patternInput_1[3];
        const v368: Mut4 = patternInput_1[2];
        const v367: Mut3 = patternInput_1[1];
        const v366: Mut1 = patternInput_1[0];
        const v415: string = method146(v366, v367, v368, v369, v370, v371, method13(v366, v367, v368, v369, v370, v371), method17(), v0_1, v1_1);
        let v489: any;
        v75();
        v489 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v571: Mut3 = patternInput_2[1];
        const v570: Mut1 = patternInput_2[0];
        let v623: any;
        closure17(v570, undefined);
        v623 = undefined;
        closure18(undefined, v415);
        v571.l0(v415);
        v895 = US9_US9_0(v570, v571, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method70(v0_1: UH1_$union, v1_1: int64): US16_$union {
    if ((v0_1.tag as int32) === /* UH1_0 */ 0) {
        return US16_US16_1();
    }
    else {
        const v4_1 = v0_1.fields[1] as any;
        const v3_1 = v0_1.fields[0] as any;
        if (v3_1 > 1) {
            const v8: int64 = toInt64(op_Multiply(toInt64(fromUInt8(v3_1 - 1)), 789730223053602816n));
            let v1864: any;
            closure103(v1_1, v3_1, v8, undefined);
            v1864 = undefined;
            return method73(v4_1, toInt64(op_Addition(v1_1, v8)));
        }
        else {
            let v4683: any;
            closure151(v1_1, v3_1, undefined);
            v4683 = undefined;
            return method73(v4_1, v1_1);
        }
    }
}

export function method65(v0_1_mut: UH1_$union, v1_1_mut: int8): int64 {
    method65:
    while (true) {
        const v0_1: UH1_$union = v0_1_mut, v1_1: int8 = v1_1_mut;
        if (v1_1 < 24) {
            v0_1_mut = UH1_UH1_1(method66(), v0_1);
            v1_1_mut = (v1_1 + 1);
            continue method65;
        }
        else {
            const v8: US16_$union = method70(v0_1, 0n);
            if ((v8.tag as int32) === /* US16_0 */ 0) {
                const v9 = v8.fields[0] as any;
                const v10 = v8.fields[1] as any;
                if (compare(v9, 9223372036854775807n) <= 0) {
                    return v9;
                }
                else {
                    v0_1_mut = UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_0())))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method65;
                }
            }
            else {
                v0_1_mut = UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_1(method66(), UH1_UH1_0())))))))))))))))))))))));
                v1_1_mut = 23;
                continue method65;
            }
        }
        break;
    }
}

export function method148(v0_1: int64): string {
    const v12: Mut5 = new Mut5(method19());
    method24(v12);
    method52(v12);
    method26(v12);
    method20(v12, `${v0_1}`);
    method31(v12);
    return v12.l0;
}

export function method147(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: Option<int64>, v6: string, v7: string, v8: int64): string {
    return method32(((((((v6 + " ") + method22(v0_1.l0)) + v7) + " ") + "dice.main") + " / ") + method148(v8));
}

export function closure152(v0_1: int64, unitVar: void): void {
    const v74 = (): void => {
        closure9(undefined, undefined);
    };
    let v75: any;
    v74();
    v75 = undefined;
    const patternInput: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
    const v203: US2_$union = patternInput[4].l0;
    let v894: US9_$union;
    if (((patternInput[2].l0 === false) ? false : (1 >= find<US2_$union, int32>(v203, ofSeq([[US2_US2_0(), 0] as [US2_$union, int32], [US2_US2_1(), 1] as [US2_$union, int32], [US2_US2_2(), 2] as [US2_$union, int32], [US2_US2_3(), 3] as [US2_$union, int32], [US2_US2_4(), 4] as [US2_$union, int32]], {
        Compare: compare_1,
    })))) === false) {
        v894 = US9_US9_1();
    }
    else {
        let v284: any;
        v74();
        v284 = undefined;
        const patternInput_1: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v370: Option<int64> = patternInput_1[5];
        const v369: Mut6 = patternInput_1[4];
        const v368: Mut5 = patternInput_1[3];
        const v367: Mut4 = patternInput_1[2];
        const v366: Mut3 = patternInput_1[1];
        const v365: Mut1 = patternInput_1[0];
        const v414: string = method147(v365, v366, v367, v368, v369, v370, method13(v365, v366, v367, v368, v369, v370), method17(), v0_1);
        let v488: any;
        v74();
        v488 = undefined;
        const patternInput_2: [Mut1, Mut3, Mut4, Mut5, Mut6, Option<int64>] = value_1(TraceState_trace_state());
        const v570: Mut3 = patternInput_2[1];
        const v569: Mut1 = patternInput_2[0];
        let v622: any;
        closure17(v569, undefined);
        v622 = undefined;
        closure18(undefined, v414);
        v570.l0(v414);
        v894 = US9_US9_0(v569, v570, patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure94(unitVar: void, v0_1: string[]): int32 {
    let v1856: any;
    closure95(undefined, undefined);
    v1856 = undefined;
    let v4676: any;
    closure152(method65(UH1_UH1_0(), 0), undefined);
    v4676 = undefined;
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

