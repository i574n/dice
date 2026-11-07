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
type US0_One = { readonly tag: 0 };
type US0_Two = { readonly tag: 1 };
type US0_Three = { readonly tag: 2 };
type US0_Four = { readonly tag: 3 };
type US0_Five = { readonly tag: 4 };
type US0_Six = { readonly tag: 5 };
type US0 = US0_One | US0_Two | US0_Three | US0_Four | US0_Five | US0_Six;
const US0_One_shared: US0 = { tag: 0 }; function US0_One(): US0 { return US0_One_shared; }
const US0_Two_shared: US0 = { tag: 1 }; function US0_Two(): US0 { return US0_Two_shared; }
const US0_Three_shared: US0 = { tag: 2 }; function US0_Three(): US0 { return US0_Three_shared; }
const US0_Four_shared: US0 = { tag: 3 }; function US0_Four(): US0 { return US0_Four_shared; }
const US0_Five_shared: US0 = { tag: 4 }; function US0_Five(): US0 { return US0_Five_shared; }
const US0_Six_shared: US0 = { tag: 5 }; function US0_Six(): US0 { return US0_Six_shared; }
type US1_Verbose = { readonly tag: 0 };
type US1_Debug = { readonly tag: 1 };
type US1_Info = { readonly tag: 2 };
type US1_Warning = { readonly tag: 3 };
type US1_Critical = { readonly tag: 4 };
type US1 = US1_Verbose | US1_Debug | US1_Info | US1_Warning | US1_Critical;
const US1_Verbose_shared: US1 = { tag: 0 }; function US1_Verbose(): US1 { return US1_Verbose_shared; }
const US1_Debug_shared: US1 = { tag: 1 }; function US1_Debug(): US1 { return US1_Debug_shared; }
const US1_Info_shared: US1 = { tag: 2 }; function US1_Info(): US1 { return US1_Info_shared; }
const US1_Warning_shared: US1 = { tag: 3 }; function US1_Warning(): US1 { return US1_Warning_shared; }
const US1_Critical_shared: US1 = { tag: 4 }; function US1_Critical(): US1 { return US1_Critical_shared; }
type Mut0 = { l0: bigint };
type Mut1 = { l0: ((a0: string) => void) };
type Mut2 = { l0: boolean };
type Mut3 = { l0: string };
type Mut4 = { l0: US1 };
type US2_Some = { readonly tag: 0, readonly f0: US1 };
type US2_None = { readonly tag: 1 };
type US2 = US2_Some | US2_None;
function US2_Some(f0: US1): US2 { return { tag: 0, f0: f0 }; }
const US2_None_shared: US2 = { tag: 1 }; function US2_None(): US2 { return US2_None_shared; }
type US3_Some = { readonly tag: 0, readonly f0: Mut0, readonly f1: Mut1, readonly f2: Mut2, readonly f3: Mut3, readonly f4: Mut4, readonly f5: bigint };
type US3_None = { readonly tag: 1 };
type US3 = US3_Some | US3_None;
function US3_Some(f0: Mut0, f1: Mut1, f2: Mut2, f3: Mut3, f4: Mut4, f5: bigint): US3 { return { tag: 0, f0: f0, f1: f1, f2: f2, f3: f3, f4: f4, f5: f5 }; }
const US3_None_shared: US3 = { tag: 1 }; function US3_None(): US3 { return US3_None_shared; }
function go_0(v0: number, v1: bigint): number {
    tail: while (true) {
        let v2: boolean = v1 >= 4738381338321616896n;
        if (v2) {
            return v0;
        } else {
            const v3: number = (v0 + 1) | 0;
            const v4: bigint = BigInt.asIntN(64, v1 * 6n);
            v0 = v3;
            v1 = v4;
            continue tail;
        }
    }
}
function read_2(v0: number, v1: bigint, v2: bigint): bigint {
    tail: while (true) {
        const v3: boolean = v0 <= 0;
        if (v3) {
            return v2;
        } else {
            const v4: bigint = BigInt(Math.floor(Math.random() * 9007199254740992));
            const v5: bigint = BigInt.asIntN(64, BigInt(0));
            const v6: bigint = BigInt.asIntN(64, BigInt(6));
            let v7: bigint = BigInt.asIntN(64, v6 - v5);
            const v8: boolean = v7 <= 0n;
            let v13: bigint;
            if (v8) {
                v13 = v5;
            } else {
                const v9: bigint = BigInt.asUintN(64, BigInt(v7));
                const v10: bigint = BigInt.asUintN(64, v4 % v9);
                let v11: bigint = BigInt.asIntN(64, BigInt(v10));
                const v12: bigint = BigInt.asIntN(64, v5 + v11);
                v13 = v12;
            }
            const v14: number = Number(BigInt.asIntN(32, v13));
            const v15: boolean = 0 === v14;
            let v30: US0;
            if (v15) {
                v30 = US0_One();
            } else {
                let v17: boolean = 1 === v14;
                if (v17) {
                    v30 = US0_Two();
                } else {
                    const v19: boolean = 2 === v14;
                    if (v19) {
                        v30 = US0_Three();
                    } else {
                        const v21: boolean = 3 === v14;
                        if (v21) {
                            v30 = US0_Four();
                        } else {
                            const v23: boolean = 4 === v14;
                            if (v23) {
                                v30 = US0_Five();
                            } else {
                                v30 = US0_Six();
                            }
                        }
                    }
                }
            }
            let v31: number = (v0 - 1) | 0;
            const v32: bigint = BigInt.asIntN(64, v1 * 6n);
            const v33: number = v30.tag;
            const v34: bigint = BigInt.asIntN(64, BigInt(v33));
            const v35: bigint = BigInt.asIntN(64, v34 * v1);
            const v36: bigint = BigInt.asIntN(64, v2 + v35);
            v0 = v31;
            v1 = v32;
            v2 = v36;
            continue tail;
        }
    }
}
function roll_fresh_1(v0: bigint, v1: number): bigint {
    tail: while (true) {
        let v2: bigint = 1n;
        const v3: bigint = 0n;
        const v4: bigint = read_2(v1, v2, v3);
        const v5: boolean = v4 < v0;
        if (v5) {
            const v6: bigint = BigInt.asIntN(64, v4 + 1n);
            return v6;
        } else {
            continue tail;
        }
    }
}
function get_environment_variable_4(v0: string): string {
    let v1: string = (process.env[v0] ?? "");
    return v1;
}
function closure0(): ((a0: string) => void) {
    return (v0: string): void => {
    };
}
function new_trace_state_3(v0: US1): [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] {
    let v1: string = "TRACE_LEVEL";
    let v2: string = get_environment_variable_4(v1);
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
    const v9: string = "Debug";
    const v10: string = v9.toLowerCase();
    let v11: string = "Verbose";
    const v12: string = v11.toLowerCase();
    let v13: boolean = v11 === v2 ;
    let v17: US2;
    if (v13) {
        const v14: US1 = US1_Verbose();
        v17 = US2_Some(v14);
    } else {
        v17 = US2_None();
    }
    let v103: US2;
    switch (v17.tag) {
        case 1: {
            let v20: boolean = v9 === v2 ;
            let v24: US2;
            if (v20) {
                const v21: US1 = US1_Debug();
                v24 = US2_Some(v21);
            } else {
                v24 = US2_None();
            }
            switch (v24.tag) {
                case 1: {
                    const v27: boolean = v7 === v2 ;
                    let v31: US2;
                    if (v27) {
                        let v28: US1 = US1_Info();
                        v31 = US2_Some(v28);
                    } else {
                        v31 = US2_None();
                    }
                    switch (v31.tag) {
                        case 1: {
                            const v34: boolean = v5 === v2 ;
                            let v38: US2;
                            if (v34) {
                                const v35: US1 = US1_Warning();
                                v38 = US2_Some(v35);
                            } else {
                                v38 = US2_None();
                            }
                            switch (v38.tag) {
                                case 1: {
                                    const v41: boolean = v3 === v2 ;
                                    let v45: US2;
                                    if (v41) {
                                        const v42: US1 = US1_Critical();
                                        v45 = US2_Some(v42);
                                    } else {
                                        v45 = US2_None();
                                    }
                                    switch (v45.tag) {
                                        case 1: {
                                            const v48: boolean = v12 === v2 ;
                                            let v52: US2;
                                            if (v48) {
                                                const v49: US1 = US1_Verbose();
                                                v52 = US2_Some(v49);
                                            } else {
                                                v52 = US2_None();
                                            }
                                            switch (v52.tag) {
                                                case 1: {
                                                    let v55: boolean = v10 === v2 ;
                                                    let v59: US2;
                                                    if (v55) {
                                                        const v56: US1 = US1_Debug();
                                                        v59 = US2_Some(v56);
                                                    } else {
                                                        v59 = US2_None();
                                                    }
                                                    switch (v59.tag) {
                                                        case 1: {
                                                            const v62: boolean = v8 === v2 ;
                                                            let v66: US2;
                                                            if (v62) {
                                                                const v63: US1 = US1_Info();
                                                                v66 = US2_Some(v63);
                                                            } else {
                                                                v66 = US2_None();
                                                            }
                                                            switch (v66.tag) {
                                                                case 1: {
                                                                    const v69: boolean = v6 === v2 ;
                                                                    let v73: US2;
                                                                    if (v69) {
                                                                        const v70: US1 = US1_Warning();
                                                                        v73 = US2_Some(v70);
                                                                    } else {
                                                                        v73 = US2_None();
                                                                    }
                                                                    switch (v73.tag) {
                                                                        case 1: {
                                                                            const v76: boolean = v4 === v2 ;
                                                                            let v80: US2;
                                                                            if (v76) {
                                                                                const v77: US1 = US1_Critical();
                                                                                v80 = US2_Some(v77);
                                                                            } else {
                                                                                v80 = US2_None();
                                                                            }
                                                                            switch (v80.tag) {
                                                                                case 1: {
                                                                                    v103 = US2_None();
                                                                                    break;
                                                                                }
                                                                                case 0: {
                                                                                    const v81: US1 = v80.f0;
                                                                                    v103 = US2_Some(v81);
                                                                                    break;
                                                                                }
                                                                                default: throw new Error("Compiler error: unreachable union case.");
                                                                            }
                                                                            break;
                                                                        }
                                                                        case 0: {
                                                                            const v74: US1 = v73.f0;
                                                                            v103 = US2_Some(v74);
                                                                            break;
                                                                        }
                                                                        default: throw new Error("Compiler error: unreachable union case.");
                                                                    }
                                                                    break;
                                                                }
                                                                case 0: {
                                                                    const v67: US1 = v66.f0;
                                                                    v103 = US2_Some(v67);
                                                                    break;
                                                                }
                                                                default: throw new Error("Compiler error: unreachable union case.");
                                                            }
                                                            break;
                                                        }
                                                        case 0: {
                                                            const v60: US1 = v59.f0;
                                                            v103 = US2_Some(v60);
                                                            break;
                                                        }
                                                        default: throw new Error("Compiler error: unreachable union case.");
                                                    }
                                                    break;
                                                }
                                                case 0: {
                                                    const v53: US1 = v52.f0;
                                                    v103 = US2_Some(v53);
                                                    break;
                                                }
                                                default: throw new Error("Compiler error: unreachable union case.");
                                            }
                                            break;
                                        }
                                        case 0: {
                                            const v46: US1 = v45.f0;
                                            v103 = US2_Some(v46);
                                            break;
                                        }
                                        default: throw new Error("Compiler error: unreachable union case.");
                                    }
                                    break;
                                }
                                case 0: {
                                    const v39: US1 = v38.f0;
                                    v103 = US2_Some(v39);
                                    break;
                                }
                                default: throw new Error("Compiler error: unreachable union case.");
                            }
                            break;
                        }
                        case 0: {
                            const v32: US1 = v31.f0;
                            v103 = US2_Some(v32);
                            break;
                        }
                        default: throw new Error("Compiler error: unreachable union case.");
                    }
                    break;
                }
                case 0: {
                    let v25: US1 = v24.f0;
                    v103 = US2_Some(v25);
                    break;
                }
                default: throw new Error("Compiler error: unreachable union case.");
            }
            break;
        }
        case 0: {
            const v18: US1 = v17.f0;
            v103 = US2_Some(v18);
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
    let v112: US1;
    switch (v103.tag) {
        case 1: {
            v112 = v0;
            break;
        }
        case 0: {
            const v110: US1 = v103.f0;
            v112 = v110;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    const v113: Mut4 = { l0: v112 };
    const v114: bigint = undefined;
    return [v104, v106, v107, v109, v113, v114];
}
function method7(v0: string, v1: number, v2: number): number {
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
function method8(v0: string, v1: number): number {
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
function method6(v0: string): string {
    let v1: number = spiral_string_length(v0);
    let v2: number = 0;
    const v3: number = method7(v0, v1, v2);
    const v4: number = (v1 - 1) | 0;
    const v5: string = spiral_string_slice(v0, v3, v4);
    const v6: number = spiral_string_length(v5);
    let v7: number = method8(v5, v6);
    const v8: string = spiral_string_slice(v5, 0, v7);
    return v8;
}
function time_9(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint): string {
    const v6: Date = new Date();
    let v7: number = v6.getHours();
    const v8: number = v6.getMinutes();
    const v9: number = v6.getSeconds();
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
    const v22: string = v20 + v21;
    const v23: string = v16 + v22;
    let v24: string = v23 + ":";
    let v25: boolean = v9 < 10;
    let v28: string;
    if (v25) {
        const v26: string = "0";
        v28 = v26;
    } else {
        const v27: string = "";
        v28 = v27;
    }
    let v29: string = String(v9);
    let v30: string = v28 + v29;
    let v31: string = v24 + v30;
    return v31;
}
function method11(v0: Mut3, v1: string): void {
    let v2: string = v0.l0;
    const v3: string = v2 + v1;
    v0.l0 = v3;
}
function format_real_10(v0: bigint): string {
    let v1: string = "";
    let v2: Mut3 = { l0: v1 };
    const v3: string = String(v0);
    method11(v2, v3);
    const v4: string = v2.l0;
    return v4;
}
function level_str_12(): string {
    let v0: string = "\u001b[94m";
    let v1: string = v0 + "d";
    let v2: string = "\u001b[0m";
    const v3: string = v1 + v2;
    return v3;
}
function method5(v0: Mut0, v1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: bigint, v6: Mut0, v7: Mut1, v8: Mut2, v9: Mut3, v10: Mut4, v11: bigint, v12: bigint): string {
    let v13: bigint = v0.l0;
    const v14: string = time_9(v6, v7, v8, v9, v10, v11);
    const v15: string = v14 + " ";
    const v16: string = format_real_10(v13);
    let v17: string = v15 + v16;
    const v18: string = level_str_12();
    const v19: string = v17 + v18;
    let v20: string = v19 + " ";
    const v21: string = v20 + "dice.main";
    const v22: string = v21 + " / ";
    const v23: string = format_real_10(v12);
    let v24: string = "result = " + v23;
    let v25: string = "{ " + v24;
    const v26: string = v25 + " }";
    const v27: string = v22 + v26;
    return method6(v27);
}
function closure1(): ((a0: string) => void) {
    return (v0: string): void => {
        process.stdout.write(String(v0) + "\n");
    };
}
export function main(): void {
    let v1: number = 0;
    let v2: bigint = 1n;
    const v3: number = go_0(v1, v2);
    const v4: bigint = 4738381338321616896n;
    const v5: bigint = roll_fresh_1(v4, v3);
    const v6: boolean = spiral_trace_state === undefined;
    if (v6) {
        let v7: US1 = US1_Verbose();
        let [v8, v9, v10, v11, v12, v13]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_3(v7);
        spiral_trace_state = [v8, v9, v10, v11, v12, v13] ;
    }
    let [v14, v15, v16, v17, v18, v19]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
    let v20: US1 = v18.l0;
    let v25: number;
    switch (v20.tag) {
        case 4: {
            v25 = 50;
            break;
        }
        case 1: {
            v25 = 20;
            break;
        }
        case 2: {
            v25 = 30;
            break;
        }
        case 0: {
            v25 = 10;
            break;
        }
        case 3: {
            v25 = 40;
            break;
        }
        default: throw new Error("Compiler error: unreachable union case.");
    }
    const v26: boolean = v16.l0;
    const v27: boolean = v26 === false;
    let v29: boolean;
    if (v27) {
        v29 = false;
    } else {
        let v28: boolean = 20 >= v25;
        v29 = v28;
    }
    let v30: boolean = v29 === false;
    let v66: US3;
    if (v30) {
        v66 = US3_None();
    } else {
        const v32: boolean = spiral_trace_state === undefined;
        if (v32) {
            const v33: US1 = US1_Verbose();
            let [v34, v35, v36, v37, v38, v39]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_3(v33);
            spiral_trace_state = [v34, v35, v36, v37, v38, v39] ;
        }
        let [v40, v41, v42, v43, v44, v45]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        const v46: string = method5(v40, v41, v42, v43, v44, v45, v40, v41, v42, v43, v44, v45, v5);
        const v47: boolean = spiral_trace_state === undefined;
        if (v47) {
            const v48: US1 = US1_Verbose();
            let [v49, v50, v51, v52, v53, v54]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = new_trace_state_3(v48);
            spiral_trace_state = [v49, v50, v51, v52, v53, v54] ;
        }
        let [v55, v56, v57, v58, v59, v60]: [Mut0, Mut1, Mut2, Mut3, Mut4, bigint] = spiral_trace_state;
        const v61: bigint = v55.l0;
        const v62: bigint = BigInt.asIntN(64, v61 + 1n);
        v55.l0 = v62;
        const v63: ((a0: string) => void) = closure1();
        v63(v46);
        const v64: ((a0: string) => void) = v56.l0;
        v64(v46);
        v66 = US3_Some(v55, v56, v57, v58, v59, v60);
    }
}
main();
