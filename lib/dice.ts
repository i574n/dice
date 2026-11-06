let spiral_trace_state: any = undefined;
const spiral_utf8_encoder = new TextEncoder();
const spiral_utf8_decoder = new TextDecoder("utf-8");
let spiral_utf8_last = "";
let spiral_utf8_bytes: Uint8Array = new Uint8Array(0);
function spiral_utf8(value: string): Uint8Array {
    if (value !== spiral_utf8_last) {
        spiral_utf8_bytes = spiral_utf8_encoder.encode(value);
        spiral_utf8_last = value;
    }
    return spiral_utf8_bytes;
}
function spiral_string_length(value: string): number {
    return spiral_utf8(value).length;
}
function spiral_string_index(value: string, index: number): number {
    const bytes = spiral_utf8(value);
    if (!(index >= 0 && index < bytes.length)) throw new RangeError("string index " + index + " out of bounds for length " + bytes.length);
    return bytes[index];
}
function spiral_slice_abort(message: string): never {
    console.error(message);
    process.exit(3);
}
function spiral_string_slice(value: string, from: number, to: number): string {
    const bytes = spiral_utf8(value);
    const length = bytes.length;
    if (from < 0 || from > length || to < from - 1 || to >= length) spiral_slice_abort("string slice " + from + ".." + to + " out of bounds for length " + length);
    if (to < from) return "";
    if ((bytes[from] & 0xc0) === 0x80 || (to + 1 < length && (bytes[to + 1] & 0xc0) === 0x80)) spiral_slice_abort("string slice " + from + ".." + to + " splits a code point");
    return spiral_utf8_decoder.decode(bytes.subarray(from, to + 1));
}
type Mut0 = { l0: bigint };
type Mut1 = { l0: ((a0: string) => void) };
type Mut2 = { l0: boolean };
type Mut3 = { l0: string };
type US0_Verbose = { readonly tag: 0 };
type US0_Debug = { readonly tag: 1 };
type US0_Info = { readonly tag: 2 };
type US0_Warning = { readonly tag: 3 };
type US0_Critical = { readonly tag: 4 };
type US0 = US0_Verbose | US0_Debug | US0_Info | US0_Warning | US0_Critical;
function US0_Verbose(): US0 { return { tag: 0 }; }
function US0_Debug(): US0 { return { tag: 1 }; }
function US0_Info(): US0 { return { tag: 2 }; }
function US0_Warning(): US0 { return { tag: 3 }; }
function US0_Critical(): US0 { return { tag: 4 }; }
type Mut4 = { l0: US0 };
type US1_Some = { readonly tag: 0, readonly f0: US0 };
type US1_None = { readonly tag: 1 };
type US1 = US1_Some | US1_None;
function US1_Some(f0: US0): US1 { return { tag: 0, f0: f0 }; }
function US1_None(): US1 { return { tag: 1 }; }
type US2_Some = { readonly tag: 0, readonly f0: Mut0, readonly f1: Mut1, readonly f2: Mut2, readonly f3: Mut3, readonly f4: Mut4, readonly f5: bigint };
type US2_None = { readonly tag: 1 };
type US2 = US2_Some | US2_None;
function US2_Some(f0: Mut0, f1: Mut1, f2: Mut2, f3: Mut3, f4: Mut4, f5: bigint): US2 { return { tag: 0, f0: f0, f1: f1, f2: f2, f3: f3, f4: f4, f5: f5 }; }
function US2_None(): US2 { return { tag: 1 }; }
type UH0_Nil = { readonly tag: 0 };
type UH0_Cons = { readonly tag: 1, readonly f0: number, readonly f1: UH0 };
type UH0 = UH0_Nil | UH0_Cons;
function UH0_Nil(): UH0 { return { tag: 0 }; }
function UH0_Cons(f0: number, f1: UH0): UH0 { return { tag: 1, f0: f0, f1: f1 }; }
type US3_Some = { readonly tag: 0, readonly f0: bigint, readonly f1: UH0 };
type US3_None = { readonly tag: 1 };
type US3 = US3_Some | US3_None;
function US3_Some(f0: bigint, f1: UH0): US3 { return { tag: 0, f0: f0, f1: f1 }; }
function US3_None(): US3 { return { tag: 1 }; }
function get_environment_variable_1(v0: string): string {
    let v1: string = (process.env[v0] ?? "");
    return v1;
}
function closure1(): ((a0: string) => void) {
    return (v0: string): void => {
    };
}
function new_trace_state_0(v0: US0): [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] {
    let v1: string = "TRACE_LEVEL";
    let v2: string = get_environment_variable_1(v1);
    ;
    ;
    ;
    ;
    ;
    let v3: string = "Critical";
    let v4: string = v3.toLowerCase();
    let v5: string = "Warning";
    let v6: string = v5.toLowerCase();
    let v7: string = "Info";
    let v8: string = v7.toLowerCase();
    let v9: string = "Debug";
    let v10: string = v9.toLowerCase();
    let v11: string = "Verbose";
    let v12: string = v11.toLowerCase();
    let v13: boolean = v11 === v2 ;
    let v17: US1;
    if (v13) {
        let v14: US0 = US0_Verbose();
        v17 = US1_Some(v14);
    } else {
        v17 = US1_None();
    }
    let v103: US1;
    switch (v17.tag) {
        case 1: {
            let v20: boolean = v9 === v2 ;
            let v24: US1;
            if (v20) {
                let v21: US0 = US0_Debug();
                v24 = US1_Some(v21);
            } else {
                v24 = US1_None();
            }
            switch (v24.tag) {
                case 1: {
                    let v27: boolean = v7 === v2 ;
                    let v31: US1;
                    if (v27) {
                        let v28: US0 = US0_Info();
                        v31 = US1_Some(v28);
                    } else {
                        v31 = US1_None();
                    }
                    switch (v31.tag) {
                        case 1: {
                            let v34: boolean = v5 === v2 ;
                            let v38: US1;
                            if (v34) {
                                let v35: US0 = US0_Warning();
                                v38 = US1_Some(v35);
                            } else {
                                v38 = US1_None();
                            }
                            switch (v38.tag) {
                                case 1: {
                                    let v41: boolean = v3 === v2 ;
                                    let v45: US1;
                                    if (v41) {
                                        let v42: US0 = US0_Critical();
                                        v45 = US1_Some(v42);
                                    } else {
                                        v45 = US1_None();
                                    }
                                    switch (v45.tag) {
                                        case 1: {
                                            let v48: boolean = v12 === v2 ;
                                            let v52: US1;
                                            if (v48) {
                                                let v49: US0 = US0_Verbose();
                                                v52 = US1_Some(v49);
                                            } else {
                                                v52 = US1_None();
                                            }
                                            switch (v52.tag) {
                                                case 1: {
                                                    let v55: boolean = v10 === v2 ;
                                                    let v59: US1;
                                                    if (v55) {
                                                        let v56: US0 = US0_Debug();
                                                        v59 = US1_Some(v56);
                                                    } else {
                                                        v59 = US1_None();
                                                    }
                                                    switch (v59.tag) {
                                                        case 1: {
                                                            let v62: boolean = v8 === v2 ;
                                                            let v66: US1;
                                                            if (v62) {
                                                                let v63: US0 = US0_Info();
                                                                v66 = US1_Some(v63);
                                                            } else {
                                                                v66 = US1_None();
                                                            }
                                                            switch (v66.tag) {
                                                                case 1: {
                                                                    let v69: boolean = v6 === v2 ;
                                                                    let v73: US1;
                                                                    if (v69) {
                                                                        let v70: US0 = US0_Warning();
                                                                        v73 = US1_Some(v70);
                                                                    } else {
                                                                        v73 = US1_None();
                                                                    }
                                                                    switch (v73.tag) {
                                                                        case 1: {
                                                                            let v76: boolean = v4 === v2 ;
                                                                            let v80: US1;
                                                                            if (v76) {
                                                                                let v77: US0 = US0_Critical();
                                                                                v80 = US1_Some(v77);
                                                                            } else {
                                                                                v80 = US1_None();
                                                                            }
                                                                            switch (v80.tag) {
                                                                                case 1: {
                                                                                    v103 = US1_None();
                                                                                    break;
                                                                                }
                                                                                case 0: {
                                                                                    let v81: US0 = v80.f0;
                                                                                    v103 = US1_Some(v81);
                                                                                    break;
                                                                                }
                                                                                default: throw new Error("Compiler error: unreachable union case.");
                                                                            }
                                                                            break;
                                                                        }
                                                                        case 0: {
                                                                            let v74: US0 = v73.f0;
                                                                            v103 = US1_Some(v74);
                                                                            break;
                                                                        }
                                                                        default: throw new Error("Compiler error: unreachable union case.");
                                                                    }
                                                                    break;
                                                                }
                                                                case 0: {
                                                                    let v67: US0 = v66.f0;
                                                                    v103 = US1_Some(v67);
                                                                    break;
                                                                }
                                                                default: throw new Error("Compiler error: unreachable union case.");
                                                            }
                                                            break;
                                                        }
                                                        case 0: {
                                                            let v60: US0 = v59.f0;
                                                            v103 = US1_Some(v60);
                                                            break;
                                                        }
                                                        default: throw new Error("Compiler error: unreachable union case.");
                                                    }
                                                    break;
                                                }
                                                case 0: {
                                                    let v53: US0 = v52.f0;
                                                    v103 = US1_Some(v53);
                                                    break;
                                                }
                                                default: throw new Error("Compiler error: unreachable union case.");
                                            }
                                            break;
                                        }
                                        case 0: {
                                            let v46: US0 = v45.f0;
                                            v103 = US1_Some(v46);
                                            break;
                                        }
                                        default: throw new Error("Compiler error: unreachable union case.");
                                    }
                                    break;
                                }
                                case 0: {
                                    let v39: US0 = v38.f0;
                                    v103 = US1_Some(v39);
                                    break;
                                }
                                default: throw new Error("Compiler error: unreachable union case.");
                            }
                            break;
                        }
                        case 0: {
                            let v32: US0 = v31.f0;
                            v103 = US1_Some(v32);
                            break;
                        }
                        default: throw new Error("Compiler error: unreachable union case.");
                    }
                    break;
                }
                case 0: {
                    let v25: US0 = v24.f0;
                    v103 = US1_Some(v25);
                    break;
                }
                default: throw new Error("Compiler error: unreachable union case.");
            }
            break;
        }
        case 0: {
            let v18: US0 = v17.f0;
            v103 = US1_Some(v18);
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    let v104: Mut0 = { l0: 1n };
    let v105: ((a0: string) => void) = closure1();
    let v106: Mut1 = { l0: v105 };
    let v107: Mut2 = { l0: true };
    let v108: string = "";
    let v109: Mut3 = { l0: v108 };
    let v112: US0;
    switch (v103.tag) {
        case 1: {
            v112 = v0;
            break;
        }
        case 0: {
            let v110: US0 = v103.f0;
            v112 = v110;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    let v113: Mut4 = { l0: v112 };
    let v114: bigint = undefined;
    return [v104, v106, v107, v109, v113, v114];
}
function closure0(): ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) {
    return (v0: US0): [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] => {
        let [v1, v2, v3, v4, v5, v6]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v0);
        return [v1, v2, v3, v4, v5, v6];
    };
}
function method2(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint): string {
    let v6: string = (() => { const d = new Date(); const p = (n: number) => String(n).padStart(2, "0"); return p(d.getHours()) + ":" + p(d.getMinutes()) + ":" + p(d.getSeconds()); })();
    return v6;
}
function method5(v0: Mut3, v1: string): void {
    let v2: string = v0.l0;
    let v3: string = v2 + v1 ;
    v0.l0 = v3;
}
function format_real_4(v0: number): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    let v3: string = String.fromCharCode(v0);
    method5(v2, v3);
    let v4: string = v2.l0;
    return v4;
}
function method3(): string {
    let v0: string = "\u001b[94m";
    ;
    ;
    ;
    ;
    ;
    let v1: string = "Debug";
    let v2: string = v1.toLowerCase();
    let v3: number = spiral_string_index(v2, 0);
    let v4: string = format_real_4(v3);
    let v5: string = v0 + v4 ;
    let v6: string = "\u001b[0m";
    let v7: string = v5 + v6 ;
    return v7;
}
function method8(v0: string, v1: number, v2: number): number {
    tail: while (true) {
        let v3: boolean = v2 >= v1;
        if (v3) {
            return v1;
        } else {
            let v4: number = spiral_string_index(v0, v2);
            let v5: boolean = v4 === 32;
            let v11: boolean;
            if (v5) {
                v11 = true;
            } else {
                let v6: boolean = v4 === 9;
                if (v6) {
                    v11 = true;
                } else {
                    let v7: boolean = v4 === 13;
                    if (v7) {
                        v11 = true;
                    } else {
                        let v8: boolean = v4 === 10;
                        v11 = v8;
                    }
                }
            }
            if (v11) {
                let v12: number = (v2 + 1) | 0;
                {
                    let t0 = v0;
                    let t1 = v1;
                    let t2 = v12;
                    v0 = t0;
                    v1 = t1;
                    v2 = t2;
                }
                continue tail;
            } else {
                return v2;
            }
        }
    }
}
function method9(v0: string, v1: number): number {
    tail: while (true) {
        let v2: boolean = v1 <= 0;
        if (v2) {
            return (-1);
        } else {
            let v3: number = (v1 - 1) | 0;
            let v4: number = spiral_string_index(v0, v3);
            let v5: boolean = v4 === 32;
            let v7: boolean;
            if (v5) {
                v7 = true;
            } else {
                let v6: boolean = v4 === 47;
                v7 = v6;
            }
            if (v7) {
                {
                    let t0 = v0;
                    let t1 = v3;
                    v0 = t0;
                    v1 = t1;
                }
                continue tail;
            } else {
                return v3;
            }
        }
    }
}
function method7(v0: string): string {
    let v1: number = spiral_string_length(v0);
    let v2: number = 0;
    let v3: number = method8(v0, v1, v2);
    let v4: number = (v1 - 1) | 0;
    let v5: string = spiral_string_slice(v0, v3, v4);
    let v6: number = spiral_string_length(v5);
    let v7: number = method9(v5, v6);
    let v8: string = spiral_string_slice(v5, 0, v7);
    return v8;
}
function format_real_10(v0: bigint): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    let v3: string = String(v0);
    method5(v2, v3);
    let v4: string = v2.l0;
    return v4;
}
function format_real_11(v0: number): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    let v3: string = String(v0);
    method5(v2, v3);
    let v4: string = v2.l0;
    return v4;
}
function method6(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string): string {
    let v8: bigint = v0.l0;
    let v9: string = " ";
    let v10: string = v6 + v9 ;
    let v11: string = format_real_10(v8);
    let v12: string = v10 + v11 ;
    let v13: string = v12 + v7 ;
    let v14: string = v13 + v9 ;
    let v15: string = "dice.calculate_dice_count";
    let v16: string = v14 + v15 ;
    let v17: string = " / ";
    let v18: string = v16 + v17 ;
    let v19: string = "";
    let v20: string = v19 + v19 ;
    let v21: string = "max";
    let v22: string = v20 + v21 ;
    let v23: string = " = ";
    let v24: string = v22 + v23 ;
    let v25: bigint = 4738381338321616896n;
    let v26: string = format_real_10(v25);
    let v27: string = v24 + v26 ;
    let v28: string = "; ";
    let v29: string = v27 + v28 ;
    let v30: string = "p";
    let v31: string = v29 + v30 ;
    let v32: string = v31 + v23 ;
    let v33: bigint = 4738381338321616896n;
    let v34: string = format_real_10(v33);
    let v35: string = v32 + v34 ;
    let v36: string = v35 + v28 ;
    let v37: string = "n";
    let v38: string = v36 + v37 ;
    let v39: string = v38 + v23 ;
    let v40: number = 24;
    let v41: string = format_real_11(v40);
    let v42: string = v39 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v18 + v46 ;
    return method7(v47);
}
function closure2(): ((a0: string) => void) {
    return (v0: string): void => {
        process.stdout.write(String(v0) + "\n");
    };
}
function roll_dice_13(): number {
    let v0: number = (() => { const a = Number(1), b = Number(7); const r = a + Math.floor(Math.random() * Math.max(0, b - a)); return (typeof 1 === "bigint" ? BigInt(r) : r); })();
    return v0;
}
function method39(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: bigint): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = (-1);
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "result";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_10(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method38(v0: UH0, v1: bigint): US3 {
    let v2: bigint = BigInt.asIntN(64, v1 + 1n);
    let v3: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
    let v4: US0 = US0_Verbose();
    if (spiral_trace_state === undefined) spiral_trace_state = v3(v4);
    let [v5, v6, v7, v8, v9, v10]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
    let v11: US0 = v9.l0;
    let v16: number;
    switch (v11.tag) {
        case 4: {
            v16 = 50;
            break;
        }
        case 1: {
            v16 = 20;
            break;
        }
        case 2: {
            v16 = 30;
            break;
        }
        case 0: {
            v16 = 10;
            break;
        }
        case 3: {
            v16 = 40;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    let v17: boolean = v7.l0;
    let v18: boolean = v17 === false;
    let v20: boolean;
    if (v18) {
        v20 = false;
    } else {
        let v19: boolean = 20 >= v16;
        v20 = v19;
    }
    let v21: boolean = v20 === false;
    let v45: US2;
    if (v21) {
        v45 = US2_None();
    } else {
        let v23: US0 = US0_Verbose();
        if (spiral_trace_state === undefined) spiral_trace_state = v3(v23);
        let [v24, v25, v26, v27, v28, v29]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v30: string = method2(v24, v25, v26, v27, v28, v29);
        let v31: string = method3();
        let v32: string = method39(v24, v25, v26, v27, v28, v29, v30, v31, v1, v2);
        let v33: US0 = US0_Verbose();
        if (spiral_trace_state === undefined) spiral_trace_state = v3(v33);
        let [v34, v35, v36, v37, v38, v39]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v40: bigint = v34.l0;
        let v41: bigint = BigInt.asIntN(64, v40 + 1n);
        v34.l0 = v41;
        let v42: ((a0: string) => void) = closure2();
        v42(v32);
        let v43: ((a0: string) => void) = v35.l0;
        v43(v32);
        v45 = US2_Some(v34, v35, v36, v37, v38, v39);
    }
    return US3_Some(v2, v0);
}
function format_real_41(v0: number): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    let v3: string = String(v0);
    method5(v2, v3);
    let v4: string = v2.l0;
    return v4;
}
function method40(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 0;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method42(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 0;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method37(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v9: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v8(v9);
                let [v10, v11, v12, v13, v14, v15]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v16: US0 = v14.l0;
                let v21: number;
                switch (v16.tag) {
                    case 4: {
                        v21 = 50;
                        break;
                    }
                    case 1: {
                        v21 = 20;
                        break;
                    }
                    case 2: {
                        v21 = 30;
                        break;
                    }
                    case 0: {
                        v21 = 10;
                        break;
                    }
                    case 3: {
                        v21 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v22: boolean = v12.l0;
                let v23: boolean = v22 === false;
                let v25: boolean;
                if (v23) {
                    v25 = false;
                } else {
                    let v24: boolean = 20 >= v21;
                    v25 = v24;
                }
                let v26: boolean = v25 === false;
                let v50: US2;
                if (v26) {
                    v50 = US2_None();
                } else {
                    let v28: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v8(v28);
                    let [v29, v30, v31, v32, v33, v34]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v35: string = method2(v29, v30, v31, v32, v33, v34);
                    let v36: string = method3();
                    let v37: string = method40(v29, v30, v31, v32, v33, v34, v35, v36, v1, v3, v7);
                    let v38: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v8(v38);
                    let [v39, v40, v41, v42, v43, v44]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v45: bigint = v39.l0;
                    let v46: bigint = BigInt.asIntN(64, v45 + 1n);
                    v39.l0 = v46;
                    let v47: ((a0: string) => void) = closure2();
                    v47(v37);
                    let v48: ((a0: string) => void) = v40.l0;
                    v48(v37);
                    v50 = US2_Some(v39, v40, v41, v42, v43, v44);
                }
                let v51: bigint = BigInt.asIntN(64, v1 + v7);
                return method38(v4, v51);
            } else {
                let v53: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v54: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v53(v54);
                let [v55, v56, v57, v58, v59, v60]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v61: US0 = v59.l0;
                let v66: number;
                switch (v61.tag) {
                    case 4: {
                        v66 = 50;
                        break;
                    }
                    case 1: {
                        v66 = 20;
                        break;
                    }
                    case 2: {
                        v66 = 30;
                        break;
                    }
                    case 0: {
                        v66 = 10;
                        break;
                    }
                    case 3: {
                        v66 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v67: boolean = v57.l0;
                let v68: boolean = v67 === false;
                let v70: boolean;
                if (v68) {
                    v70 = false;
                } else {
                    let v69: boolean = 20 >= v66;
                    v70 = v69;
                }
                let v71: boolean = v70 === false;
                let v95: US2;
                if (v71) {
                    v95 = US2_None();
                } else {
                    let v73: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v53(v73);
                    let [v74, v75, v76, v77, v78, v79]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v80: string = method2(v74, v75, v76, v77, v78, v79);
                    let v81: string = method3();
                    let v82: string = method42(v74, v75, v76, v77, v78, v79, v80, v81, v1, v3);
                    let v83: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v53(v83);
                    let [v84, v85, v86, v87, v88, v89]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v90: bigint = v84.l0;
                    let v91: bigint = BigInt.asIntN(64, v90 + 1n);
                    v84.l0 = v91;
                    let v92: ((a0: string) => void) = closure2();
                    v92(v82);
                    let v93: ((a0: string) => void) = v85.l0;
                    v93(v82);
                    v95 = US2_Some(v84, v85, v86, v87, v88, v89);
                }
                return method38(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method43(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 1;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method44(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 1;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method36(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 6n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method43(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method37(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method44(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method37(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method45(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 2;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method46(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 2;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method35(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 36n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method45(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method36(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method46(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method36(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method47(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 3;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method48(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 3;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method34(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 216n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method47(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method35(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method48(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method35(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method49(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 4;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method50(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 4;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method33(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 1296n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method49(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method34(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method50(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method34(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method51(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 5;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method52(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 5;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method32(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 7776n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method51(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method33(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method52(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method33(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method53(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 6;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method54(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 6;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method31(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 46656n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method53(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method32(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method54(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method32(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method55(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 7;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method56(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 7;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method30(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 279936n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method55(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method31(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method56(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method31(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method57(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 8;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method58(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 8;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method29(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 1679616n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method57(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method30(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method58(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method30(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method59(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 9;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method60(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 9;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method28(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 10077696n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method59(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method29(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method60(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method29(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method61(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 10;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method62(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 10;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method27(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 60466176n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method61(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method28(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method62(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method28(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method63(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 11;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method64(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 11;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method26(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 362797056n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method63(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method27(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method64(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method27(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method65(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 12;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method66(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 12;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method25(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 2176782336n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method65(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method26(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method66(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method26(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method67(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 13;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method68(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 13;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method24(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 13060694016n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method67(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method25(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method68(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method25(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method69(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 14;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method70(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 14;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method23(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 78364164096n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method69(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method24(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method70(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method24(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method71(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 15;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method72(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 15;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method22(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 470184984576n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method71(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method23(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method72(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method23(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method73(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 16;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method74(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 16;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method21(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 2821109907456n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method73(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method22(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method74(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method22(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method75(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 17;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method76(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 17;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method20(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 16926659444736n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method75(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method21(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method76(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method21(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method77(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 18;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method78(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 18;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method19(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 101559956668416n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method77(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method20(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method78(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method20(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method79(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 19;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method80(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 19;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method18(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 609359740010496n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method79(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method19(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method80(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method19(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method81(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 20;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method82(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 20;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method17(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 3656158440062976n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method81(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method18(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method82(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method18(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method83(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 21;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method84(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 21;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method16(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 21936950640377856n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method83(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method17(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method84(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method17(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method85(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 22;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method86(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 22;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method15(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 131621703842267136n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method85(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method16(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method86(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method16(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method87(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    let v12: string = " ";
    let v13: string = v6 + v12 ;
    let v14: string = format_real_10(v11);
    let v15: string = v13 + v14 ;
    let v16: string = v15 + v7 ;
    let v17: string = v16 + v12 ;
    let v18: string = "dice.accumulate_dice_rolls";
    let v19: string = v17 + v18 ;
    let v20: string = " / ";
    let v21: string = v19 + v20 ;
    let v22: string = "";
    let v23: string = v22 + v22 ;
    let v24: string = "power";
    let v25: string = v23 + v24 ;
    let v26: string = " = ";
    let v27: string = v25 + v26 ;
    let v28: number = 23;
    let v29: string = format_real_11(v28);
    let v30: string = v27 + v29 ;
    let v31: string = "; ";
    let v32: string = v30 + v31 ;
    let v33: string = "acc";
    let v34: string = v32 + v33 ;
    let v35: string = v34 + v26 ;
    let v36: string = format_real_10(v8);
    let v37: string = v35 + v36 ;
    let v38: string = v37 + v31 ;
    let v39: string = "roll";
    let v40: string = v38 + v39 ;
    let v41: string = v40 + v26 ;
    let v42: string = format_real_41(v9);
    let v43: string = v41 + v42 ;
    let v44: string = v43 + v31 ;
    let v45: string = "value";
    let v46: string = v44 + v45 ;
    let v47: string = v46 + v26 ;
    let v48: string = format_real_10(v10);
    let v49: string = v47 + v48 ;
    let v50: string = "{ ";
    let v51: string = v50 + v49 ;
    let v52: string = " }";
    let v53: string = v51 + v52 ;
    let v54: string = v21 + v53 ;
    return method7(v54);
}
function method88(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    let v10: bigint = v0.l0;
    let v11: string = " ";
    let v12: string = v6 + v11 ;
    let v13: string = format_real_10(v10);
    let v14: string = v12 + v13 ;
    let v15: string = v14 + v7 ;
    let v16: string = v15 + v11 ;
    let v17: string = "dice.accumulate_dice_rolls";
    let v18: string = v16 + v17 ;
    let v19: string = " / ";
    let v20: string = v18 + v19 ;
    let v21: string = "";
    let v22: string = v21 + v21 ;
    let v23: string = "power";
    let v24: string = v22 + v23 ;
    let v25: string = " = ";
    let v26: string = v24 + v25 ;
    let v27: number = 23;
    let v28: string = format_real_11(v27);
    let v29: string = v26 + v28 ;
    let v30: string = "; ";
    let v31: string = v29 + v30 ;
    let v32: string = "acc";
    let v33: string = v31 + v32 ;
    let v34: string = v33 + v25 ;
    let v35: string = format_real_10(v8);
    let v36: string = v34 + v35 ;
    let v37: string = v36 + v30 ;
    let v38: string = "roll";
    let v39: string = v37 + v38 ;
    let v40: string = v39 + v25 ;
    let v41: string = format_real_41(v9);
    let v42: string = v40 + v41 ;
    let v43: string = "{ ";
    let v44: string = v43 + v42 ;
    let v45: string = " }";
    let v46: string = v44 + v45 ;
    let v47: string = v20 + v46 ;
    return method7(v47);
}
function method14(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            let v3: number = v0.f0;
            let v4: UH0 = v0.f1;
            let v5: boolean = v3 > 1;
            if (v5) {
                let v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                let v8: bigint = BigInt.asIntN(64, v7 * 789730223053602816n);
                let v9: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v10: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v9(v10);
                let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v17: US0 = v15.l0;
                let v22: number;
                switch (v17.tag) {
                    case 4: {
                        v22 = 50;
                        break;
                    }
                    case 1: {
                        v22 = 20;
                        break;
                    }
                    case 2: {
                        v22 = 30;
                        break;
                    }
                    case 0: {
                        v22 = 10;
                        break;
                    }
                    case 3: {
                        v22 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v23: boolean = v13.l0;
                let v24: boolean = v23 === false;
                let v26: boolean;
                if (v24) {
                    v26 = false;
                } else {
                    let v25: boolean = 20 >= v22;
                    v26 = v25;
                }
                let v27: boolean = v26 === false;
                let v51: US2;
                if (v27) {
                    v51 = US2_None();
                } else {
                    let v29: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v29);
                    let [v30, v31, v32, v33, v34, v35]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v36: string = method2(v30, v31, v32, v33, v34, v35);
                    let v37: string = method3();
                    let v38: string = method87(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8);
                    let v39: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v9(v39);
                    let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v46: bigint = v40.l0;
                    let v47: bigint = BigInt.asIntN(64, v46 + 1n);
                    v40.l0 = v47;
                    let v48: ((a0: string) => void) = closure2();
                    v48(v38);
                    let v49: ((a0: string) => void) = v41.l0;
                    v49(v38);
                    v51 = US2_Some(v40, v41, v42, v43, v44, v45);
                }
                let v52: bigint = BigInt.asIntN(64, v1 + v8);
                return method15(v4, v52);
            } else {
                let v54: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
                let v55: US0 = US0_Verbose();
                if (spiral_trace_state === undefined) spiral_trace_state = v54(v55);
                let [v56, v57, v58, v59, v60, v61]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v62: US0 = v60.l0;
                let v67: number;
                switch (v62.tag) {
                    case 4: {
                        v67 = 50;
                        break;
                    }
                    case 1: {
                        v67 = 20;
                        break;
                    }
                    case 2: {
                        v67 = 30;
                        break;
                    }
                    case 0: {
                        v67 = 10;
                        break;
                    }
                    case 3: {
                        v67 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v68: boolean = v58.l0;
                let v69: boolean = v68 === false;
                let v71: boolean;
                if (v69) {
                    v71 = false;
                } else {
                    let v70: boolean = 20 >= v67;
                    v71 = v70;
                }
                let v72: boolean = v71 === false;
                let v96: US2;
                if (v72) {
                    v96 = US2_None();
                } else {
                    let v74: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v74);
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v81: string = method2(v75, v76, v77, v78, v79, v80);
                    let v82: string = method3();
                    let v83: string = method88(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3);
                    let v84: US0 = US0_Verbose();
                    if (spiral_trace_state === undefined) spiral_trace_state = v54(v84);
                    let [v85, v86, v87, v88, v89, v90]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v91: bigint = v85.l0;
                    let v92: bigint = BigInt.asIntN(64, v91 + 1n);
                    v85.l0 = v92;
                    let v93: ((a0: string) => void) = closure2();
                    v93(v83);
                    let v94: ((a0: string) => void) = v86.l0;
                    v94(v83);
                    v96 = US2_Some(v85, v86, v87, v88, v89, v90);
                }
                return method15(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method12(v0: UH0, v1: number): bigint {
    tail: while (true) {
        let v2: boolean = v1 < 24;
        if (v2) {
            let v3: number = roll_dice_13();
            let v4: UH0 = UH0_Cons(v3, v0);
            let v5: number = (v1 + 1) << 24 >> 24;
            {
                let t0 = v4;
                let t1 = v5;
                v0 = t0;
                v1 = t1;
            }
            continue tail;
        } else {
            let v7: bigint = 0n;
            let v8: US3 = method14(v0, v7);
            switch (v8.tag) {
                case 0: {
                    let v9: bigint = v8.f0;
                    let v10: UH0 = v8.f1;
                    let v11: boolean = v9 <= 4738381338321616896n;
                    if (v11) {
                        return v9;
                    } else {
                        let v12: number = roll_dice_13();
                        let v13: number = roll_dice_13();
                        let v14: number = roll_dice_13();
                        let v15: number = roll_dice_13();
                        let v16: number = roll_dice_13();
                        let v17: number = roll_dice_13();
                        let v18: number = roll_dice_13();
                        let v19: number = roll_dice_13();
                        let v20: number = roll_dice_13();
                        let v21: number = roll_dice_13();
                        let v22: number = roll_dice_13();
                        let v23: number = roll_dice_13();
                        let v24: number = roll_dice_13();
                        let v25: number = roll_dice_13();
                        let v26: number = roll_dice_13();
                        let v27: number = roll_dice_13();
                        let v28: number = roll_dice_13();
                        let v29: number = roll_dice_13();
                        let v30: number = roll_dice_13();
                        let v31: number = roll_dice_13();
                        let v32: number = roll_dice_13();
                        let v33: number = roll_dice_13();
                        let v34: number = roll_dice_13();
                        let v35: UH0 = UH0_Nil();
                        let v36: UH0 = UH0_Cons(v34, v35);
                        let v37: UH0 = UH0_Cons(v33, v36);
                        let v38: UH0 = UH0_Cons(v32, v37);
                        let v39: UH0 = UH0_Cons(v31, v38);
                        let v40: UH0 = UH0_Cons(v30, v39);
                        let v41: UH0 = UH0_Cons(v29, v40);
                        let v42: UH0 = UH0_Cons(v28, v41);
                        let v43: UH0 = UH0_Cons(v27, v42);
                        let v44: UH0 = UH0_Cons(v26, v43);
                        let v45: UH0 = UH0_Cons(v25, v44);
                        let v46: UH0 = UH0_Cons(v24, v45);
                        let v47: UH0 = UH0_Cons(v23, v46);
                        let v48: UH0 = UH0_Cons(v22, v47);
                        let v49: UH0 = UH0_Cons(v21, v48);
                        let v50: UH0 = UH0_Cons(v20, v49);
                        let v51: UH0 = UH0_Cons(v19, v50);
                        let v52: UH0 = UH0_Cons(v18, v51);
                        let v53: UH0 = UH0_Cons(v17, v52);
                        let v54: UH0 = UH0_Cons(v16, v53);
                        let v55: UH0 = UH0_Cons(v15, v54);
                        let v56: UH0 = UH0_Cons(v14, v55);
                        let v57: UH0 = UH0_Cons(v13, v56);
                        let v58: UH0 = UH0_Cons(v12, v57);
                        let v59: number = 23;
                        {
                            let t0 = v58;
                            let t1 = v59;
                            v0 = t0;
                            v1 = t1;
                        }
                        continue tail;
                    }
                    break;
                }
                default: {
                    let v62: number = roll_dice_13();
                    let v63: number = roll_dice_13();
                    let v64: number = roll_dice_13();
                    let v65: number = roll_dice_13();
                    let v66: number = roll_dice_13();
                    let v67: number = roll_dice_13();
                    let v68: number = roll_dice_13();
                    let v69: number = roll_dice_13();
                    let v70: number = roll_dice_13();
                    let v71: number = roll_dice_13();
                    let v72: number = roll_dice_13();
                    let v73: number = roll_dice_13();
                    let v74: number = roll_dice_13();
                    let v75: number = roll_dice_13();
                    let v76: number = roll_dice_13();
                    let v77: number = roll_dice_13();
                    let v78: number = roll_dice_13();
                    let v79: number = roll_dice_13();
                    let v80: number = roll_dice_13();
                    let v81: number = roll_dice_13();
                    let v82: number = roll_dice_13();
                    let v83: number = roll_dice_13();
                    let v84: number = roll_dice_13();
                    let v85: UH0 = UH0_Nil();
                    let v86: UH0 = UH0_Cons(v84, v85);
                    let v87: UH0 = UH0_Cons(v83, v86);
                    let v88: UH0 = UH0_Cons(v82, v87);
                    let v89: UH0 = UH0_Cons(v81, v88);
                    let v90: UH0 = UH0_Cons(v80, v89);
                    let v91: UH0 = UH0_Cons(v79, v90);
                    let v92: UH0 = UH0_Cons(v78, v91);
                    let v93: UH0 = UH0_Cons(v77, v92);
                    let v94: UH0 = UH0_Cons(v76, v93);
                    let v95: UH0 = UH0_Cons(v75, v94);
                    let v96: UH0 = UH0_Cons(v74, v95);
                    let v97: UH0 = UH0_Cons(v73, v96);
                    let v98: UH0 = UH0_Cons(v72, v97);
                    let v99: UH0 = UH0_Cons(v71, v98);
                    let v100: UH0 = UH0_Cons(v70, v99);
                    let v101: UH0 = UH0_Cons(v69, v100);
                    let v102: UH0 = UH0_Cons(v68, v101);
                    let v103: UH0 = UH0_Cons(v67, v102);
                    let v104: UH0 = UH0_Cons(v66, v103);
                    let v105: UH0 = UH0_Cons(v65, v104);
                    let v106: UH0 = UH0_Cons(v64, v105);
                    let v107: UH0 = UH0_Cons(v63, v106);
                    let v108: UH0 = UH0_Cons(v62, v107);
                    let v109: number = 23;
                    {
                        let t0 = v108;
                        let t1 = v109;
                        v0 = t0;
                        v1 = t1;
                    }
                    continue tail;
                }
            }
        }
    }
}
function method89(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint): string {
    let v9: bigint = v0.l0;
    let v10: string = " ";
    let v11: string = v6 + v10 ;
    let v12: string = format_real_10(v9);
    let v13: string = v11 + v12 ;
    let v14: string = v13 + v7 ;
    let v15: string = v14 + v10 ;
    let v16: string = "dice.main";
    let v17: string = v15 + v16 ;
    let v18: string = " / ";
    let v19: string = v17 + v18 ;
    let v20: string = "";
    let v21: string = v20 + v20 ;
    let v22: string = "result";
    let v23: string = v21 + v22 ;
    let v24: string = " = ";
    let v25: string = v23 + v24 ;
    let v26: string = format_real_10(v8);
    let v27: string = v25 + v26 ;
    let v28: string = "{ ";
    let v29: string = v28 + v27 ;
    let v30: string = " }";
    let v31: string = v29 + v30 ;
    let v32: string = v19 + v31 ;
    return method7(v32);
}
export function main(): void {
    let v1: ((a0: US0) => [Mut0, Mut1, Mut2, Mut3, Mut4, bigint]) = closure0();
    let v2: US0 = US0_Verbose();
    if (spiral_trace_state === undefined) spiral_trace_state = v1(v2);
    let [v3, v4, v5, v6, v7, v8]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
    let v9: US0 = v7.l0;
    let v14: number;
    switch (v9.tag) {
        case 4: {
            v14 = 50;
            break;
        }
        case 1: {
            v14 = 20;
            break;
        }
        case 2: {
            v14 = 30;
            break;
        }
        case 0: {
            v14 = 10;
            break;
        }
        case 3: {
            v14 = 40;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    let v15: boolean = v5.l0;
    let v16: boolean = v15 === false;
    let v18: boolean;
    if (v16) {
        v18 = false;
    } else {
        let v17: boolean = 20 >= v14;
        v18 = v17;
    }
    let v19: boolean = v18 === false;
    let v43: US2;
    if (v19) {
        v43 = US2_None();
    } else {
        let v21: US0 = US0_Verbose();
        if (spiral_trace_state === undefined) spiral_trace_state = v1(v21);
        let [v22, v23, v24, v25, v26, v27]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v28: string = method2(v22, v23, v24, v25, v26, v27);
        let v29: string = method3();
        let v30: string = method6(v22, v23, v24, v25, v26, v27, v28, v29);
        let v31: US0 = US0_Verbose();
        if (spiral_trace_state === undefined) spiral_trace_state = v1(v31);
        let [v32, v33, v34, v35, v36, v37]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v38: bigint = v32.l0;
        let v39: bigint = BigInt.asIntN(64, v38 + 1n);
        v32.l0 = v39;
        let v40: ((a0: string) => void) = closure2();
        v40(v30);
        let v41: ((a0: string) => void) = v33.l0;
        v41(v30);
        v43 = US2_Some(v32, v33, v34, v35, v36, v37);
    }
    let v44: UH0 = UH0_Nil();
    let v45: number = 0;
    let v46: bigint = method12(v44, v45);
    let v47: US0 = US0_Verbose();
    if (spiral_trace_state === undefined) spiral_trace_state = v1(v47);
    let [v48, v49, v50, v51, v52, v53]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
    let v54: US0 = v52.l0;
    let v59: number;
    switch (v54.tag) {
        case 4: {
            v59 = 50;
            break;
        }
        case 1: {
            v59 = 20;
            break;
        }
        case 2: {
            v59 = 30;
            break;
        }
        case 0: {
            v59 = 10;
            break;
        }
        case 3: {
            v59 = 40;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    let v60: boolean = v50.l0;
    let v61: boolean = v60 === false;
    let v63: boolean;
    if (v61) {
        v63 = false;
    } else {
        let v62: boolean = 20 >= v59;
        v63 = v62;
    }
    let v64: boolean = v63 === false;
    let v88: US2;
    if (v64) {
        v88 = US2_None();
    } else {
        let v66: US0 = US0_Verbose();
        if (spiral_trace_state === undefined) spiral_trace_state = v1(v66);
        let [v67, v68, v69, v70, v71, v72]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v73: string = method2(v67, v68, v69, v70, v71, v72);
        let v74: string = method3();
        let v75: string = method89(v67, v68, v69, v70, v71, v72, v73, v74, v46);
        let v76: US0 = US0_Verbose();
        if (spiral_trace_state === undefined) spiral_trace_state = v1(v76);
        let [v77, v78, v79, v80, v81, v82]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v83: bigint = v77.l0;
        let v84: bigint = BigInt.asIntN(64, v83 + 1n);
        v77.l0 = v84;
        let v85: ((a0: string) => void) = closure2();
        v85(v75);
        let v86: ((a0: string) => void) = v78.l0;
        v86(v75);
        v88 = US2_Some(v77, v78, v79, v80, v81, v82);
    }
}
main();
