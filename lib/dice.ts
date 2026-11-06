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
type US0_Verbose = { readonly tag: 0 };
type US0_Debug = { readonly tag: 1 };
type US0_Info = { readonly tag: 2 };
type US0_Warning = { readonly tag: 3 };
type US0_Critical = { readonly tag: 4 };
type US0 = US0_Verbose | US0_Debug | US0_Info | US0_Warning | US0_Critical;
const US0_Verbose_shared: US0 = { tag: 0 }; function US0_Verbose(): US0 { return US0_Verbose_shared; }
const US0_Debug_shared: US0 = { tag: 1 }; function US0_Debug(): US0 { return US0_Debug_shared; }
const US0_Info_shared: US0 = { tag: 2 }; function US0_Info(): US0 { return US0_Info_shared; }
const US0_Warning_shared: US0 = { tag: 3 }; function US0_Warning(): US0 { return US0_Warning_shared; }
const US0_Critical_shared: US0 = { tag: 4 }; function US0_Critical(): US0 { return US0_Critical_shared; }
type Mut0 = { l0: bigint };
type Mut1 = { l0: ((a0: string) => void) };
type Mut2 = { l0: boolean };
type Mut3 = { l0: string };
type Mut4 = { l0: US0 };
type US1_Some = { readonly tag: 0, readonly f0: US0 };
type US1_None = { readonly tag: 1 };
type US1 = US1_Some | US1_None;
function US1_Some(f0: US0): US1 { return { tag: 0, f0: f0 }; }
const US1_None_shared: US1 = { tag: 1 }; function US1_None(): US1 { return US1_None_shared; }
type US2_Some = { readonly tag: 0, readonly f0: Mut0, readonly f1: Mut1, readonly f2: Mut2, readonly f3: Mut3, readonly f4: Mut4, readonly f5: bigint };
type US2_None = { readonly tag: 1 };
type US2 = US2_Some | US2_None;
function US2_Some(f0: Mut0, f1: Mut1, f2: Mut2, f3: Mut3, f4: Mut4, f5: bigint): US2 { return { tag: 0, f0: f0, f1: f1, f2: f2, f3: f3, f4: f4, f5: f5 }; }
const US2_None_shared: US2 = { tag: 1 }; function US2_None(): US2 { return US2_None_shared; }
type UH0_Nil = { readonly tag: 0 };
type UH0_Cons = { readonly tag: 1, readonly f0: number, readonly f1: UH0 };
type UH0 = UH0_Nil | UH0_Cons;
const UH0_Nil_shared: UH0 = { tag: 0 }; function UH0_Nil(): UH0 { return UH0_Nil_shared; }
function UH0_Cons(f0: number, f1: UH0): UH0 { return { tag: 1, f0: f0, f1: f1 }; }
type US3_Some = { readonly tag: 0, readonly f0: bigint, readonly f1: UH0 };
type US3_None = { readonly tag: 1 };
type US3 = US3_Some | US3_None;
function US3_Some(f0: bigint, f1: UH0): US3 { return { tag: 0, f0: f0, f1: f1 }; }
const US3_None_shared: US3 = { tag: 1 }; function US3_None(): US3 { return US3_None_shared; }
function get_environment_variable_1(v0: string): string {
    let v1: string = (process.env[v0] ?? "");
    return v1;
}
function closure0(): ((a0: string) => void) {
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
    const v3: string = "Critical";
    const v4: string = v3.toLowerCase();
    const v5: string = "Warning";
    const v6: string = v5.toLowerCase();
    let v7: string = "Info";
    const v8: string = v7.toLowerCase();
    let v9: string = "Debug";
    const v10: string = v9.toLowerCase();
    let v11: string = "Verbose";
    const v12: string = v11.toLowerCase();
    let v13: boolean = v11 === v2 ;
    let v17: US1;
    if (v13) {
        const v14: US0 = US0_Verbose();
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
                const v21: US0 = US0_Debug();
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
                            const v34: boolean = v5 === v2 ;
                            let v38: US1;
                            if (v34) {
                                const v35: US0 = US0_Warning();
                                v38 = US1_Some(v35);
                            } else {
                                v38 = US1_None();
                            }
                            switch (v38.tag) {
                                case 1: {
                                    const v41: boolean = v3 === v2 ;
                                    let v45: US1;
                                    if (v41) {
                                        const v42: US0 = US0_Critical();
                                        v45 = US1_Some(v42);
                                    } else {
                                        v45 = US1_None();
                                    }
                                    switch (v45.tag) {
                                        case 1: {
                                            const v48: boolean = v12 === v2 ;
                                            let v52: US1;
                                            if (v48) {
                                                const v49: US0 = US0_Verbose();
                                                v52 = US1_Some(v49);
                                            } else {
                                                v52 = US1_None();
                                            }
                                            switch (v52.tag) {
                                                case 1: {
                                                    const v55: boolean = v10 === v2 ;
                                                    let v59: US1;
                                                    if (v55) {
                                                        const v56: US0 = US0_Debug();
                                                        v59 = US1_Some(v56);
                                                    } else {
                                                        v59 = US1_None();
                                                    }
                                                    switch (v59.tag) {
                                                        case 1: {
                                                            const v62: boolean = v8 === v2 ;
                                                            let v66: US1;
                                                            if (v62) {
                                                                let v63: US0 = US0_Info();
                                                                v66 = US1_Some(v63);
                                                            } else {
                                                                v66 = US1_None();
                                                            }
                                                            switch (v66.tag) {
                                                                case 1: {
                                                                    const v69: boolean = v6 === v2 ;
                                                                    let v73: US1;
                                                                    if (v69) {
                                                                        let v70: US0 = US0_Warning();
                                                                        v73 = US1_Some(v70);
                                                                    } else {
                                                                        v73 = US1_None();
                                                                    }
                                                                    switch (v73.tag) {
                                                                        case 1: {
                                                                            const v76: boolean = v4 === v2 ;
                                                                            let v80: US1;
                                                                            if (v76) {
                                                                                const v77: US0 = US0_Critical();
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
                                                                                    const v81: US0 = v80.f0;
                                                                                    v103 = US1_Some(v81);
                                                                                    break;
                                                                                }
                                                                                default: throw new Error("Compiler error: unreachable union case.");
                                                                            }
                                                                            break;
                                                                        }
                                                                        case 0: {
                                                                            const v74: US0 = v73.f0;
                                                                            v103 = US1_Some(v74);
                                                                            break;
                                                                        }
                                                                        default: throw new Error("Compiler error: unreachable union case.");
                                                                    }
                                                                    break;
                                                                }
                                                                case 0: {
                                                                    const v67: US0 = v66.f0;
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
                                                    const v53: US0 = v52.f0;
                                                    v103 = US1_Some(v53);
                                                    break;
                                                }
                                                default: throw new Error("Compiler error: unreachable union case.");
                                            }
                                            break;
                                        }
                                        case 0: {
                                            const v46: US0 = v45.f0;
                                            v103 = US1_Some(v46);
                                            break;
                                        }
                                        default: throw new Error("Compiler error: unreachable union case.");
                                    }
                                    break;
                                }
                                case 0: {
                                    const v39: US0 = v38.f0;
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
                    const v25: US0 = v24.f0;
                    v103 = US1_Some(v25);
                    break;
                }
                default: throw new Error("Compiler error: unreachable union case.");
            }
            break;
        }
        case 0: {
            const v18: US0 = v17.f0;
            v103 = US1_Some(v18);
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    const v104: Mut0 = { l0: 1n };
    const v105: ((a0: string) => void) = closure0();
    const v106: Mut1 = { l0: v105 };
    const v107: Mut2 = { l0: true };
    const v108: string = "";
    const v109: Mut3 = { l0: v108 };
    let v112: US0;
    switch (v103.tag) {
        case 1: {
            v112 = v0;
            break;
        }
        case 0: {
            const v110: US0 = v103.f0;
            v112 = v110;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    const v113: Mut4 = { l0: v112 };
    const v114: bigint = undefined;
    return [v104, v106, v107, v109, v113, v114];
}
function method2(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint): string {
    const v6: Date = new Date();
    let v7: number = v6.getHours();
    const v8: number = v6.getMinutes();
    let v9: number = v6.getSeconds();
    const v10: boolean = v7 < 10;
    let v13: string;
    if (v10) {
        let v11: string = "0";
        v13 = v11;
    } else {
        const v12: string = "";
        v13 = v12;
    }
    const v14: string = String(v7);
    const v15: string = v13 + v14;
    const v16: string = v15 + ":";
    let v17: boolean = v8 < 10;
    let v20: string;
    if (v17) {
        const v18: string = "0";
        v20 = v18;
    } else {
        const v19: string = "";
        v20 = v19;
    }
    const v21: string = String(v8);
    let v22: string = v20 + v21;
    const v23: string = v16 + v22;
    let v24: string = v23 + ":";
    const v25: boolean = v9 < 10;
    let v28: string;
    if (v25) {
        let v26: string = "0";
        v28 = v26;
    } else {
        let v27: string = "";
        v28 = v27;
    }
    const v29: string = String(v9);
    const v30: string = v28 + v29;
    let v31: string = v24 + v30;
    return v31;
}
function method5(v0: Mut3, v1: string): void {
    let v2: string = v0.l0;
    const v3: string = v2 + v1;
    v0.l0 = v3;
}
function format_real_4(v0: number): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    const v3: string = String.fromCharCode(v0);
    method5(v2, v3);
    const v4: string = v2.l0;
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
    const v3: number = spiral_string_index(v2, 0);
    const v4: string = format_real_4(v3);
    const v5: string = v0 + v4;
    const v6: string = "\u001b[0m";
    let v7: string = v5 + v6;
    return v7;
}
function method8(v0: string, v1: number, v2: number): number {
    tail: while (true) {
        const v3: boolean = v2 >= v1;
        if (v3) {
            return v1;
        } else {
            const v4: number = spiral_string_index(v0, v2);
            const v5: boolean = v4 === 32;
            let v11: boolean;
            if (v5) {
                v11 = true;
            } else {
                const v6: boolean = v4 === 9;
                if (v6) {
                    v11 = true;
                } else {
                    let v7: boolean = v4 === 13;
                    if (v7) {
                        v11 = true;
                    } else {
                        const v8: boolean = v4 === 10;
                        v11 = v8;
                    }
                }
            }
            if (v11) {
                const v12: number = (v2 + 1) | 0;
                v2 = v12;
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
            const v3: number = (v1 - 1) | 0;
            const v4: number = spiral_string_index(v0, v3);
            const v5: boolean = v4 === 32;
            let v7: boolean;
            if (v5) {
                v7 = true;
            } else {
                const v6: boolean = v4 === 47;
                v7 = v6;
            }
            if (v7) {
                v1 = v3;
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
    const v3: number = method8(v0, v1, v2);
    const v4: number = (v1 - 1) | 0;
    const v5: string = spiral_string_slice(v0, v3, v4);
    const v6: number = spiral_string_length(v5);
    let v7: number = method9(v5, v6);
    const v8: string = spiral_string_slice(v5, 0, v7);
    return v8;
}
function format_real_10(v0: bigint): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    const v3: string = String(v0);
    method5(v2, v3);
    const v4: string = v2.l0;
    return v4;
}
function format_real_11(v0: number): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    const v3: string = String(v0);
    method5(v2, v3);
    const v4: string = v2.l0;
    return v4;
}
function method6(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string): string {
    const v8: bigint = v0.l0;
    let v9: string = v6 + " ";
    const v10: string = format_real_10(v8);
    let v11: string = v9 + v10;
    const v12: string = v11 + v7;
    let v13: string = v12 + " ";
    const v14: string = v13 + "dice.calculate_dice_count";
    const v15: string = v14 + " / ";
    const v16: bigint = 4738381338321616896n;
    let v17: string = format_real_10(v16);
    const v18: string = "max = " + v17;
    const v19: string = v18 + "; ";
    let v20: string = v19 + "p";
    const v21: string = v20 + " = ";
    let v22: bigint = 4738381338321616896n;
    const v23: string = format_real_10(v22);
    let v24: string = v21 + v23;
    const v25: string = v24 + "; ";
    let v26: string = v25 + "n";
    let v27: string = v26 + " = ";
    let v28: number = 24;
    const v29: string = format_real_11(v28);
    const v30: string = v27 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v15 + v32;
    return method7(v33);
}
function closure1(): ((a0: string) => void) {
    return (v0: string): void => {
        process.stdout.write(String(v0) + "\n");
    };
}
function roll_dice_13(): number {
    let v0: bigint = BigInt(Math.floor(Math.random() * 9007199254740992));
    let v1: bigint = BigInt.asIntN(64, BigInt(1));
    let v2: bigint = BigInt.asIntN(64, BigInt(7));
    const v3: bigint = BigInt.asIntN(64, v2 - v1);
    const v4: boolean = v3 <= 0n;
    let v9: bigint;
    if (v4) {
        v9 = v1;
    } else {
        const v5: bigint = BigInt.asUintN(64, BigInt(v3));
        const v6: bigint = BigInt.asUintN(64, v0 % v5);
        let v7: bigint = BigInt.asIntN(64, BigInt(v6));
        const v8: bigint = BigInt.asIntN(64, v1 + v7);
        v9 = v8;
    }
    const v10: number = Number(BigInt.asUintN(8, v9));
    return v10;
}
function method39(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: bigint): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = (-1);
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "result";
    let v28: string = v27 + " = ";
    const v29: string = format_real_10(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method38(v0: UH0, v1: bigint): US3 {
    let v2: bigint = BigInt.asIntN(64, v1 + 1n);
    const v3: boolean = spiral_trace_state === undefined;
    if (v3) {
        const v4: US0 = US0_Verbose();
        let [v5, v6, v7, v8, v9, v10]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v4);
        spiral_trace_state = [v5, v6, v7, v8, v9, v10] ;
    }
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
    const v23: boolean = v13.l0;
    let v24: boolean = v23 === false;
    let v26: boolean;
    if (v24) {
        v26 = false;
    } else {
        const v25: boolean = 20 >= v22;
        v26 = v25;
    }
    let v27: boolean = v26 === false;
    let v65: US2;
    if (v27) {
        v65 = US2_None();
    } else {
        const v29: boolean = spiral_trace_state === undefined;
        if (v29) {
            const v30: US0 = US0_Verbose();
            let [v31, v32, v33, v34, v35, v36]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v30);
            spiral_trace_state = [v31, v32, v33, v34, v35, v36] ;
        }
        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        const v43: string = method2(v37, v38, v39, v40, v41, v42);
        const v44: string = method3();
        let v45: string = method39(v37, v38, v39, v40, v41, v42, v43, v44, v1, v2);
        const v46: boolean = spiral_trace_state === undefined;
        if (v46) {
            const v47: US0 = US0_Verbose();
            let [v48, v49, v50, v51, v52, v53]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v47);
            spiral_trace_state = [v48, v49, v50, v51, v52, v53] ;
        }
        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v60: bigint = v54.l0;
        const v61: bigint = BigInt.asIntN(64, v60 + 1n);
        v54.l0 = v61;
        const v62: ((a0: string) => void) = closure1();
        v62(v45);
        let v63: ((a0: string) => void) = v55.l0;
        v63(v45);
        v65 = US2_Some(v54, v55, v56, v57, v58, v59);
    }
    return US3_Some(v2, v0);
}
function format_real_41(v0: number): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    const v3: string = String(v0);
    method5(v2, v3);
    const v4: string = v2.l0;
    return v4;
}
function method40(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 0;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method42(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 0;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method37(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: boolean = spiral_trace_state === undefined;
                if (v8) {
                    let v9: US0 = US0_Verbose();
                    let [v10, v11, v12, v13, v14, v15]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v9);
                    spiral_trace_state = [v10, v11, v12, v13, v14, v15] ;
                }
                let [v16, v17, v18, v19, v20, v21]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                let v22: US0 = v20.l0;
                let v27: number;
                switch (v22.tag) {
                    case 4: {
                        v27 = 50;
                        break;
                    }
                    case 1: {
                        v27 = 20;
                        break;
                    }
                    case 2: {
                        v27 = 30;
                        break;
                    }
                    case 0: {
                        v27 = 10;
                        break;
                    }
                    case 3: {
                        v27 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v28: boolean = v18.l0;
                const v29: boolean = v28 === false;
                let v31: boolean;
                if (v29) {
                    v31 = false;
                } else {
                    const v30: boolean = 20 >= v27;
                    v31 = v30;
                }
                let v32: boolean = v31 === false;
                let v70: US2;
                if (v32) {
                    v70 = US2_None();
                } else {
                    const v34: boolean = spiral_trace_state === undefined;
                    if (v34) {
                        const v35: US0 = US0_Verbose();
                        let [v36, v37, v38, v39, v40, v41]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v35);
                        spiral_trace_state = [v36, v37, v38, v39, v40, v41] ;
                    }
                    let [v42, v43, v44, v45, v46, v47]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v48: string = method2(v42, v43, v44, v45, v46, v47);
                    const v49: string = method3();
                    const v50: string = method40(v42, v43, v44, v45, v46, v47, v48, v49, v1, v3, v7);
                    const v51: boolean = spiral_trace_state === undefined;
                    if (v51) {
                        let v52: US0 = US0_Verbose();
                        let [v53, v54, v55, v56, v57, v58]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v52);
                        spiral_trace_state = [v53, v54, v55, v56, v57, v58] ;
                    }
                    let [v59, v60, v61, v62, v63, v64]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v65: bigint = v59.l0;
                    let v66: bigint = BigInt.asIntN(64, v65 + 1n);
                    v59.l0 = v66;
                    const v67: ((a0: string) => void) = closure1();
                    v67(v50);
                    const v68: ((a0: string) => void) = v60.l0;
                    v68(v50);
                    v70 = US2_Some(v59, v60, v61, v62, v63, v64);
                }
                let v71: bigint = BigInt.asIntN(64, v1 + v7);
                return method38(v4, v71);
            } else {
                let v73: boolean = spiral_trace_state === undefined;
                if (v73) {
                    const v74: US0 = US0_Verbose();
                    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v74);
                    spiral_trace_state = [v75, v76, v77, v78, v79, v80] ;
                }
                let [v81, v82, v83, v84, v85, v86]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v87: US0 = v85.l0;
                let v92: number;
                switch (v87.tag) {
                    case 4: {
                        v92 = 50;
                        break;
                    }
                    case 1: {
                        v92 = 20;
                        break;
                    }
                    case 2: {
                        v92 = 30;
                        break;
                    }
                    case 0: {
                        v92 = 10;
                        break;
                    }
                    case 3: {
                        v92 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                let v93: boolean = v83.l0;
                const v94: boolean = v93 === false;
                let v96: boolean;
                if (v94) {
                    v96 = false;
                } else {
                    const v95: boolean = 20 >= v92;
                    v96 = v95;
                }
                let v97: boolean = v96 === false;
                let v135: US2;
                if (v97) {
                    v135 = US2_None();
                } else {
                    const v99: boolean = spiral_trace_state === undefined;
                    if (v99) {
                        const v100: US0 = US0_Verbose();
                        let [v101, v102, v103, v104, v105, v106]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v100);
                        spiral_trace_state = [v101, v102, v103, v104, v105, v106] ;
                    }
                    let [v107, v108, v109, v110, v111, v112]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v113: string = method2(v107, v108, v109, v110, v111, v112);
                    const v114: string = method3();
                    const v115: string = method42(v107, v108, v109, v110, v111, v112, v113, v114, v1, v3);
                    const v116: boolean = spiral_trace_state === undefined;
                    if (v116) {
                        const v117: US0 = US0_Verbose();
                        let [v118, v119, v120, v121, v122, v123]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v117);
                        spiral_trace_state = [v118, v119, v120, v121, v122, v123] ;
                    }
                    let [v124, v125, v126, v127, v128, v129]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v130: bigint = v124.l0;
                    const v131: bigint = BigInt.asIntN(64, v130 + 1n);
                    v124.l0 = v131;
                    const v132: ((a0: string) => void) = closure1();
                    v132(v115);
                    const v133: ((a0: string) => void) = v125.l0;
                    v133(v115);
                    v135 = US2_Some(v124, v125, v126, v127, v128, v129);
                }
                return method38(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method43(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 1;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method44(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 1;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method36(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 6n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method43(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method37(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method44(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method37(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method45(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 2;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method46(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 2;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method35(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 36n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method45(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method36(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method46(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method36(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method47(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 3;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method48(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 3;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method34(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 216n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method47(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method35(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method48(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method35(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method49(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 4;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method50(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 4;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method33(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 1296n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method49(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method34(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method50(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method34(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method51(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 5;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method52(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 5;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method32(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 7776n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method51(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method33(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method52(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method33(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method53(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 6;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method54(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 6;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method31(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 46656n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method53(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method32(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method54(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method32(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method55(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 7;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method56(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 7;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method30(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 279936n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method55(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method31(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method56(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method31(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method57(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 8;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method58(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 8;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method29(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 1679616n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method57(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method30(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method58(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method30(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method59(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 9;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method60(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 9;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method28(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 10077696n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method59(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method29(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method60(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method29(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method61(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 10;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method62(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 10;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method27(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 60466176n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method61(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method28(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method62(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method28(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method63(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 11;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method64(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 11;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method26(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 362797056n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method63(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method27(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method64(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method27(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method65(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 12;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method66(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 12;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method25(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 2176782336n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method65(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method26(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method66(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method26(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method67(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 13;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method68(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 13;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method24(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 13060694016n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method67(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method25(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method68(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method25(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method69(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 14;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method70(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 14;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method23(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 78364164096n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method69(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method24(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method70(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method24(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method71(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 15;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method72(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 15;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method22(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 470184984576n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method71(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method23(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method72(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method23(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method73(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 16;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method74(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 16;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method21(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 2821109907456n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method73(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method22(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method74(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method22(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method75(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 17;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method76(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 17;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method20(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 16926659444736n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method75(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method21(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method76(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method21(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method77(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 18;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method78(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 18;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method19(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 101559956668416n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method77(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method20(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method78(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method20(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method79(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 19;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method80(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 19;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method18(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 609359740010496n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method79(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method19(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method80(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method19(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method81(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 20;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method82(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 20;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method17(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 3656158440062976n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method81(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method18(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method82(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method18(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method83(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 21;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method84(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 21;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method16(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 21936950640377856n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method83(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method17(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method84(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method17(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method85(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 22;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method86(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 22;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method15(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 131621703842267136n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method85(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method16(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method86(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method16(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method87(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number, v10: bigint): string {
    let v11: bigint = v0.l0;
    const v12: string = v6 + " ";
    let v13: string = format_real_10(v11);
    const v14: string = v12 + v13;
    const v15: string = v14 + v7;
    const v16: string = v15 + " ";
    let v17: string = v16 + "dice.accumulate_dice_rolls";
    const v18: string = v17 + " / ";
    const v19: number = 23;
    let v20: string = format_real_11(v19);
    const v21: string = "power = " + v20;
    let v22: string = v21 + "; ";
    const v23: string = v22 + "acc";
    let v24: string = v23 + " = ";
    const v25: string = format_real_10(v8);
    let v26: string = v24 + v25;
    let v27: string = v26 + "; ";
    let v28: string = v27 + "roll";
    const v29: string = v28 + " = ";
    const v30: string = format_real_41(v9);
    let v31: string = v29 + v30;
    let v32: string = v31 + "; ";
    const v33: string = v32 + "value";
    const v34: string = v33 + " = ";
    const v35: string = format_real_10(v10);
    const v36: string = v34 + v35;
    const v37: string = "{ " + v36;
    let v38: string = v37 + " }";
    const v39: string = v18 + v38;
    return method7(v39);
}
function method88(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint, v9: number): string {
    const v10: bigint = v0.l0;
    let v11: string = v6 + " ";
    const v12: string = format_real_10(v10);
    let v13: string = v11 + v12;
    const v14: string = v13 + v7;
    const v15: string = v14 + " ";
    const v16: string = v15 + "dice.accumulate_dice_rolls";
    let v17: string = v16 + " / ";
    const v18: number = 23;
    const v19: string = format_real_11(v18);
    let v20: string = "power = " + v19;
    const v21: string = v20 + "; ";
    let v22: string = v21 + "acc";
    const v23: string = v22 + " = ";
    let v24: string = format_real_10(v8);
    const v25: string = v23 + v24;
    let v26: string = v25 + "; ";
    let v27: string = v26 + "roll";
    let v28: string = v27 + " = ";
    const v29: string = format_real_41(v9);
    const v30: string = v28 + v29;
    let v31: string = "{ " + v30;
    let v32: string = v31 + " }";
    const v33: string = v17 + v32;
    return method7(v33);
}
function method14(v0: UH0, v1: bigint): US3 {
    switch (v0.tag) {
        case 1: {
            const v3: number = v0.f0;
            const v4: UH0 = v0.f1;
            const v5: boolean = v3 > 1;
            if (v5) {
                const v6: number = (v3 - 1) & 0xff;
                let v7: bigint = BigInt.asIntN(64, BigInt(v6));
                const v8: bigint = BigInt.asIntN(64, v7 * 789730223053602816n);
                let v9: boolean = spiral_trace_state === undefined;
                if (v9) {
                    const v10: US0 = US0_Verbose();
                    let [v11, v12, v13, v14, v15, v16]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v10);
                    spiral_trace_state = [v11, v12, v13, v14, v15, v16] ;
                }
                let [v17, v18, v19, v20, v21, v22]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v23: US0 = v21.l0;
                let v28: number;
                switch (v23.tag) {
                    case 4: {
                        v28 = 50;
                        break;
                    }
                    case 1: {
                        v28 = 20;
                        break;
                    }
                    case 2: {
                        v28 = 30;
                        break;
                    }
                    case 0: {
                        v28 = 10;
                        break;
                    }
                    case 3: {
                        v28 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v29: boolean = v19.l0;
                const v30: boolean = v29 === false;
                let v32: boolean;
                if (v30) {
                    v32 = false;
                } else {
                    let v31: boolean = 20 >= v28;
                    v32 = v31;
                }
                const v33: boolean = v32 === false;
                let v71: US2;
                if (v33) {
                    v71 = US2_None();
                } else {
                    const v35: boolean = spiral_trace_state === undefined;
                    if (v35) {
                        const v36: US0 = US0_Verbose();
                        let [v37, v38, v39, v40, v41, v42]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v36);
                        spiral_trace_state = [v37, v38, v39, v40, v41, v42] ;
                    }
                    let [v43, v44, v45, v46, v47, v48]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v49: string = method2(v43, v44, v45, v46, v47, v48);
                    const v50: string = method3();
                    const v51: string = method87(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8);
                    let v52: boolean = spiral_trace_state === undefined;
                    if (v52) {
                        const v53: US0 = US0_Verbose();
                        let [v54, v55, v56, v57, v58, v59]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v53);
                        spiral_trace_state = [v54, v55, v56, v57, v58, v59] ;
                    }
                    let [v60, v61, v62, v63, v64, v65]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    let v66: bigint = v60.l0;
                    const v67: bigint = BigInt.asIntN(64, v66 + 1n);
                    v60.l0 = v67;
                    const v68: ((a0: string) => void) = closure1();
                    v68(v51);
                    const v69: ((a0: string) => void) = v61.l0;
                    v69(v51);
                    v71 = US2_Some(v60, v61, v62, v63, v64, v65);
                }
                const v72: bigint = BigInt.asIntN(64, v1 + v8);
                return method15(v4, v72);
            } else {
                const v74: boolean = spiral_trace_state === undefined;
                if (v74) {
                    const v75: US0 = US0_Verbose();
                    let [v76, v77, v78, v79, v80, v81]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v75);
                    spiral_trace_state = [v76, v77, v78, v79, v80, v81] ;
                }
                let [v82, v83, v84, v85, v86, v87]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                const v88: US0 = v86.l0;
                let v93: number;
                switch (v88.tag) {
                    case 4: {
                        v93 = 50;
                        break;
                    }
                    case 1: {
                        v93 = 20;
                        break;
                    }
                    case 2: {
                        v93 = 30;
                        break;
                    }
                    case 0: {
                        v93 = 10;
                        break;
                    }
                    case 3: {
                        v93 = 40;
                        break;
                    }
                    default: throw new Error("Compiler error: unreachable union case.");
                }
                const v94: boolean = v84.l0;
                const v95: boolean = v94 === false;
                let v97: boolean;
                if (v95) {
                    v97 = false;
                } else {
                    let v96: boolean = 20 >= v93;
                    v97 = v96;
                }
                const v98: boolean = v97 === false;
                let v136: US2;
                if (v98) {
                    v136 = US2_None();
                } else {
                    const v100: boolean = spiral_trace_state === undefined;
                    if (v100) {
                        const v101: US0 = US0_Verbose();
                        let [v102, v103, v104, v105, v106, v107]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v101);
                        spiral_trace_state = [v102, v103, v104, v105, v106, v107] ;
                    }
                    let [v108, v109, v110, v111, v112, v113]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v114: string = method2(v108, v109, v110, v111, v112, v113);
                    const v115: string = method3();
                    const v116: string = method88(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3);
                    const v117: boolean = spiral_trace_state === undefined;
                    if (v117) {
                        let v118: US0 = US0_Verbose();
                        let [v119, v120, v121, v122, v123, v124]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v118);
                        spiral_trace_state = [v119, v120, v121, v122, v123, v124] ;
                    }
                    let [v125, v126, v127, v128, v129, v130]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
                    const v131: bigint = v125.l0;
                    const v132: bigint = BigInt.asIntN(64, v131 + 1n);
                    v125.l0 = v132;
                    const v133: ((a0: string) => void) = closure1();
                    v133(v116);
                    const v134: ((a0: string) => void) = v126.l0;
                    v134(v116);
                    v136 = US2_Some(v125, v126, v127, v128, v129, v130);
                }
                return method15(v4, v1);
            }
            break;
        }
        case 0: {
            return US3_None();
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
}
function method12(v0: UH0, v1: number): bigint {
    tail: while (true) {
        let v2: boolean = v1 < 24;
        if (v2) {
            const v3: number = roll_dice_13();
            const v4: UH0 = UH0_Cons(v3, v0);
            const v5: number = (v1 + 1) << 24 >> 24;
            v0 = v4;
            v1 = v5;
            continue tail;
        } else {
            let v7: bigint = 0n;
            const v8: US3 = method14(v0, v7);
            switch (v8.tag) {
                case 0: {
                    let v9: bigint = v8.f0;
                    const v10: UH0 = v8.f1;
                    let v11: boolean = v9 <= 4738381338321616896n;
                    if (v11) {
                        return v9;
                    } else {
                        const v12: number = roll_dice_13();
                        let v13: number = roll_dice_13();
                        const v14: number = roll_dice_13();
                        const v15: number = roll_dice_13();
                        const v16: number = roll_dice_13();
                        let v17: number = roll_dice_13();
                        const v18: number = roll_dice_13();
                        const v19: number = roll_dice_13();
                        let v20: number = roll_dice_13();
                        const v21: number = roll_dice_13();
                        let v22: number = roll_dice_13();
                        const v23: number = roll_dice_13();
                        let v24: number = roll_dice_13();
                        const v25: number = roll_dice_13();
                        let v26: number = roll_dice_13();
                        let v27: number = roll_dice_13();
                        let v28: number = roll_dice_13();
                        const v29: number = roll_dice_13();
                        const v30: number = roll_dice_13();
                        let v31: number = roll_dice_13();
                        let v32: number = roll_dice_13();
                        const v33: number = roll_dice_13();
                        const v34: number = roll_dice_13();
                        const v35: UH0 = UH0_Nil();
                        const v36: UH0 = UH0_Cons(v34, v35);
                        const v37: UH0 = UH0_Cons(v33, v36);
                        let v38: UH0 = UH0_Cons(v32, v37);
                        const v39: UH0 = UH0_Cons(v31, v38);
                        const v40: UH0 = UH0_Cons(v30, v39);
                        const v41: UH0 = UH0_Cons(v29, v40);
                        const v42: UH0 = UH0_Cons(v28, v41);
                        const v43: UH0 = UH0_Cons(v27, v42);
                        const v44: UH0 = UH0_Cons(v26, v43);
                        let v45: UH0 = UH0_Cons(v25, v44);
                        const v46: UH0 = UH0_Cons(v24, v45);
                        const v47: UH0 = UH0_Cons(v23, v46);
                        const v48: UH0 = UH0_Cons(v22, v47);
                        const v49: UH0 = UH0_Cons(v21, v48);
                        const v50: UH0 = UH0_Cons(v20, v49);
                        const v51: UH0 = UH0_Cons(v19, v50);
                        let v52: UH0 = UH0_Cons(v18, v51);
                        const v53: UH0 = UH0_Cons(v17, v52);
                        let v54: UH0 = UH0_Cons(v16, v53);
                        const v55: UH0 = UH0_Cons(v15, v54);
                        const v56: UH0 = UH0_Cons(v14, v55);
                        const v57: UH0 = UH0_Cons(v13, v56);
                        const v58: UH0 = UH0_Cons(v12, v57);
                        let v59: number = 23;
                        v0 = v58;
                        v1 = v59;
                        continue tail;
                    }
                    break;
                }
                default: {
                    const v62: number = roll_dice_13();
                    let v63: number = roll_dice_13();
                    const v64: number = roll_dice_13();
                    let v65: number = roll_dice_13();
                    let v66: number = roll_dice_13();
                    const v67: number = roll_dice_13();
                    const v68: number = roll_dice_13();
                    const v69: number = roll_dice_13();
                    let v70: number = roll_dice_13();
                    let v71: number = roll_dice_13();
                    const v72: number = roll_dice_13();
                    let v73: number = roll_dice_13();
                    const v74: number = roll_dice_13();
                    const v75: number = roll_dice_13();
                    const v76: number = roll_dice_13();
                    const v77: number = roll_dice_13();
                    const v78: number = roll_dice_13();
                    const v79: number = roll_dice_13();
                    let v80: number = roll_dice_13();
                    const v81: number = roll_dice_13();
                    const v82: number = roll_dice_13();
                    const v83: number = roll_dice_13();
                    const v84: number = roll_dice_13();
                    const v85: UH0 = UH0_Nil();
                    let v86: UH0 = UH0_Cons(v84, v85);
                    const v87: UH0 = UH0_Cons(v83, v86);
                    const v88: UH0 = UH0_Cons(v82, v87);
                    const v89: UH0 = UH0_Cons(v81, v88);
                    let v90: UH0 = UH0_Cons(v80, v89);
                    const v91: UH0 = UH0_Cons(v79, v90);
                    let v92: UH0 = UH0_Cons(v78, v91);
                    let v93: UH0 = UH0_Cons(v77, v92);
                    const v94: UH0 = UH0_Cons(v76, v93);
                    const v95: UH0 = UH0_Cons(v75, v94);
                    let v96: UH0 = UH0_Cons(v74, v95);
                    let v97: UH0 = UH0_Cons(v73, v96);
                    const v98: UH0 = UH0_Cons(v72, v97);
                    const v99: UH0 = UH0_Cons(v71, v98);
                    const v100: UH0 = UH0_Cons(v70, v99);
                    const v101: UH0 = UH0_Cons(v69, v100);
                    const v102: UH0 = UH0_Cons(v68, v101);
                    let v103: UH0 = UH0_Cons(v67, v102);
                    const v104: UH0 = UH0_Cons(v66, v103);
                    const v105: UH0 = UH0_Cons(v65, v104);
                    const v106: UH0 = UH0_Cons(v64, v105);
                    const v107: UH0 = UH0_Cons(v63, v106);
                    const v108: UH0 = UH0_Cons(v62, v107);
                    const v109: number = 23;
                    v0 = v108;
                    v1 = v109;
                    continue tail;
                }
            }
        }
    }
}
function method89(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: string, v7: string, v8: bigint): string {
    let v9: bigint = v0.l0;
    const v10: string = v6 + " ";
    let v11: string = format_real_10(v9);
    const v12: string = v10 + v11;
    let v13: string = v12 + v7;
    const v14: string = v13 + " ";
    const v15: string = v14 + "dice.main";
    const v16: string = v15 + " / ";
    let v17: string = format_real_10(v8);
    const v18: string = "result = " + v17;
    const v19: string = "{ " + v18;
    let v20: string = v19 + " }";
    const v21: string = v16 + v20;
    return method7(v21);
}
export function main(): void {
    let v1: boolean = spiral_trace_state === undefined;
    if (v1) {
        let v2: US0 = US0_Verbose();
        let [v3, v4, v5, v6, v7, v8]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v2);
        spiral_trace_state = [v3, v4, v5, v6, v7, v8] ;
    }
    let [v9, v10, v11, v12, v13, v14]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
    const v15: US0 = v13.l0;
    let v20: number;
    switch (v15.tag) {
        case 4: {
            v20 = 50;
            break;
        }
        case 1: {
            v20 = 20;
            break;
        }
        case 2: {
            v20 = 30;
            break;
        }
        case 0: {
            v20 = 10;
            break;
        }
        case 3: {
            v20 = 40;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    const v21: boolean = v11.l0;
    let v22: boolean = v21 === false;
    let v24: boolean;
    if (v22) {
        v24 = false;
    } else {
        const v23: boolean = 20 >= v20;
        v24 = v23;
    }
    const v25: boolean = v24 === false;
    let v63: US2;
    if (v25) {
        v63 = US2_None();
    } else {
        let v27: boolean = spiral_trace_state === undefined;
        if (v27) {
            let v28: US0 = US0_Verbose();
            let [v29, v30, v31, v32, v33, v34]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v28);
            spiral_trace_state = [v29, v30, v31, v32, v33, v34] ;
        }
        let [v35, v36, v37, v38, v39, v40]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        const v41: string = method2(v35, v36, v37, v38, v39, v40);
        const v42: string = method3();
        const v43: string = method6(v35, v36, v37, v38, v39, v40, v41, v42);
        const v44: boolean = spiral_trace_state === undefined;
        if (v44) {
            let v45: US0 = US0_Verbose();
            let [v46, v47, v48, v49, v50, v51]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v45);
            spiral_trace_state = [v46, v47, v48, v49, v50, v51] ;
        }
        let [v52, v53, v54, v55, v56, v57]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        const v58: bigint = v52.l0;
        let v59: bigint = BigInt.asIntN(64, v58 + 1n);
        v52.l0 = v59;
        let v60: ((a0: string) => void) = closure1();
        v60(v43);
        const v61: ((a0: string) => void) = v53.l0;
        v61(v43);
        v63 = US2_Some(v52, v53, v54, v55, v56, v57);
    }
    const v64: UH0 = UH0_Nil();
    let v65: number = 0;
    let v66: bigint = method12(v64, v65);
    const v67: boolean = spiral_trace_state === undefined;
    if (v67) {
        const v68: US0 = US0_Verbose();
        let [v69, v70, v71, v72, v73, v74]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v68);
        spiral_trace_state = [v69, v70, v71, v72, v73, v74] ;
    }
    let [v75, v76, v77, v78, v79, v80]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
    const v81: US0 = v79.l0;
    let v86: number;
    switch (v81.tag) {
        case 4: {
            v86 = 50;
            break;
        }
        case 1: {
            v86 = 20;
            break;
        }
        case 2: {
            v86 = 30;
            break;
        }
        case 0: {
            v86 = 10;
            break;
        }
        case 3: {
            v86 = 40;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    const v87: boolean = v77.l0;
    const v88: boolean = v87 === false;
    let v90: boolean;
    if (v88) {
        v90 = false;
    } else {
        const v89: boolean = 20 >= v86;
        v90 = v89;
    }
    const v91: boolean = v90 === false;
    let v129: US2;
    if (v91) {
        v129 = US2_None();
    } else {
        let v93: boolean = spiral_trace_state === undefined;
        if (v93) {
            const v94: US0 = US0_Verbose();
            let [v95, v96, v97, v98, v99, v100]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v94);
            spiral_trace_state = [v95, v96, v97, v98, v99, v100] ;
        }
        let [v101, v102, v103, v104, v105, v106]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        const v107: string = method2(v101, v102, v103, v104, v105, v106);
        const v108: string = method3();
        const v109: string = method89(v101, v102, v103, v104, v105, v106, v107, v108, v66);
        const v110: boolean = spiral_trace_state === undefined;
        if (v110) {
            const v111: US0 = US0_Verbose();
            let [v112, v113, v114, v115, v116, v117]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_0(v111);
            spiral_trace_state = [v112, v113, v114, v115, v116, v117] ;
        }
        let [v118, v119, v120, v121, v122, v123]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        let v124: bigint = v118.l0;
        let v125: bigint = BigInt.asIntN(64, v124 + 1n);
        v118.l0 = v125;
        const v126: ((a0: string) => void) = closure1();
        v126(v109);
        const v127: ((a0: string) => void) = v119.l0;
        v127(v109);
        v129 = US2_Some(v118, v119, v120, v121, v122, v123);
    }
}
main();
