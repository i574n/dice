// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import './fable_modules/fable_library/Option.dart' as option_47;
import './fable_modules/fable_library/Random.dart' as random;
import './fable_modules/fable_library/String.dart' as string;
import './fable_modules/fable_library/Types.dart' as types;
import './fable_modules/fable_library/Util.dart' as util;

class UH0 implements types.Union {
    final int tag;
    const UH0(this.tag);
}

class UH0_UH0_0 extends UH0 {
    final int Item1;
    final UH0 Function() Item2;
    const UH0_UH0_0(this.Item1, this.Item2): super(0);
}

class UH1 implements types.Union, Comparable<UH1> {
    final int tag;
    const UH1(this.tag);
    @override
    bool operator ==(Object other) => (other is UH1) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(UH1 other) => tag.compareTo(other.tag);
}

class UH1_UH1_1 extends UH1 {
    final int Item1;
    final UH1 Item2;
    const UH1_UH1_1(this.Item1, this.Item2): super(1);
    @override
    bool operator ==(Object other) => (other is UH1_UH1_1) && ((other.Item1 == Item1) && (other.Item2 == Item2));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, Item1.hashCode, Item2.hashCode]);
    @override
    int compareTo(UH1 other) {
        if (other is UH1_UH1_1) {
            late int $r;
            if (($r = Item1.compareTo(other.Item1)) == 0) {
                $r = Item2.compareTo(other.Item2);
            }
            return $r;
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class US0 implements types.Union {
    final int tag;
    const US0(this.tag);
}

class US0_US0_0 extends US0 {
    final void Function(String) f0_0;
    const US0_US0_0(this.f0_0): super(0);
}

abstract class US1 implements types.Union {
    final int tag;
    const US1(this.tag);
}

class US1_US1_0 extends US1 {
    final UH0 Function() f0_0;
    const US1_US1_0(this.f0_0): super(0);
}

class US1_US1_1 extends US1 {
    final UH0 f1_0;
    const US1_US1_1(this.f1_0): super(1);
}

class Mut0 implements types.Record {
    US1 l0;
    Mut0(this.l0);
}

class Mut1 implements types.Record, Comparable<Mut1> {
    int l0;
    Mut1(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut1) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut1 other) => l0.compareTo(other.l0);
}

class US2 implements types.Union, Comparable<US2> {
    final int tag;
    const US2(this.tag);
    @override
    bool operator ==(Object other) => (other is US2) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US2 other) => tag.compareTo(other.tag);
}

class US2_US2_0 extends US2 {
    final int f0_0;
    const US2_US2_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US2_US2_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US2 other) {
        if (other is US2_US2_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class Mut2 implements types.Record, Comparable<Mut2> {
    US2 l0;
    Mut2(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut2) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut2 other) => l0.compareTo(other.l0);
}

class US3 implements types.Union, Comparable<US3> {
    final int tag;
    const US3(this.tag);
    @override
    bool operator ==(Object other) => (other is US3) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US3 other) => tag.compareTo(other.tag);
}

class US3_US3_0 extends US3 {
    final int f0_0;
    final UH1 f0_1;
    const US3_US3_0(this.f0_0, this.f0_1): super(0);
    @override
    bool operator ==(Object other) => (other is US3_US3_0) && ((other.f0_0 == f0_0) && (other.f0_1 == f0_1));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode, f0_1.hashCode]);
    @override
    int compareTo(US3 other) {
        if (other is US3_US3_0) {
            late int $r;
            if (($r = f0_0.compareTo(other.f0_0)) == 0) {
                $r = f0_1.compareTo(other.f0_1);
            }
            return $r;
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class UH2 implements types.Union {
    final int tag;
    const UH2(this.tag);
}

class UH2_UH2_0 extends UH2 {
    final int Item1;
    final UH2 Function() Item2;
    const UH2_UH2_0(this.Item1, this.Item2): super(0);
}

class US4 implements types.Union, Comparable<US4> {
    final int tag;
    const US4(this.tag);
    @override
    bool operator ==(Object other) => (other is US4) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US4 other) => tag.compareTo(other.tag);
}

class US4_US4_0 extends US4 {
    final int f0_0;
    const US4_US4_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US4_US4_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US4 other) {
        if (other is US4_US4_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class US5 implements types.Union, Comparable<US5> {
    final int tag;
    const US5(this.tag);
    @override
    bool operator ==(Object other) => (other is US5) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US5 other) => tag.compareTo(other.tag);
}

class US5_US5_0 extends US5 {
    final int f0_0;
    final UH1 f0_1;
    const US5_US5_0(this.f0_0, this.f0_1): super(0);
    @override
    bool operator ==(Object other) => (other is US5_US5_0) && ((other.f0_0 == f0_0) && (other.f0_1 == f0_1));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode, f0_1.hashCode]);
    @override
    int compareTo(US5 other) {
        if (other is US5_US5_0) {
            late int $r;
            if (($r = f0_0.compareTo(other.f0_0)) == 0) {
                $r = f0_1.compareTo(other.f0_1);
            }
            return $r;
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

bool UH0__get_IsUH0_0(UH0 this$, void unitArg) {
    if (this$.tag == /* UH0_0 */ 0) {
        return true;
    } else {
        return false;
    }
}

bool UH0__get_IsUH0_1(UH0 this$, void unitArg) {
    if (this$.tag == /* UH0_1 */ 1) {
        return true;
    } else {
        return false;
    }
}

bool UH1__get_IsUH1_0(UH1 this$, void unitArg) {
    if (this$.tag == /* UH1_0 */ 0) {
        return true;
    } else {
        return false;
    }
}

bool UH1__get_IsUH1_1(UH1 this$, void unitArg) {
    if (this$.tag == /* UH1_1 */ 1) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_0(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_1(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US1__get_IsUS1_0(types.FSharpRef<US1, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US1__get_IsUS1_1(types.FSharpRef<US1, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US2__get_IsUS2_0(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US2__get_IsUS2_1(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US3__get_IsUS3_0(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US3__get_IsUS3_1(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool UH2__get_IsUH2_0(UH2 this$, void unitArg) {
    if (this$.tag == /* UH2_0 */ 0) {
        return true;
    } else {
        return false;
    }
}

bool UH2__get_IsUH2_1(UH2 this$, void unitArg) {
    if (this$.tag == /* UH2_1 */ 1) {
        return true;
    } else {
        return false;
    }
}

bool US4__get_IsUS4_0(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US4__get_IsUS4_1(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US5__get_IsUS5_0(types.FSharpRef<US5, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US5__get_IsUS5_1(types.FSharpRef<US5, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

UH0 closure2(UH0 v0_1, void unitVar) => v0_1;

UH0 method0(int v0_1, UH0 v1_1, UH0 v2_1) {
    if (v1_1.tag == /* UH0_1 */ 1) {
        return v2_1;
    } else {
        final v1_1_1 = v1_1 as UH0_UH0_0;
        final UH0 v6 = method0(v0_1, v1_1_1.Item2(), v2_1);
        final v9 = (v1_1_1.Item1 - 1) + v0_1;
        return UH0_UH0_0(v9.remainder(v0_1) + 1, () => closure2(v6, util.ignore()));
    }
}

UH0 closure1(int v0_1, UH0 v1_1) => method0(v0_1, v1_1, const UH0(/* UH0_1 */ 1));

UH0 Function(UH0) closure0(void unitVar, int v0_1) => (UH0 v) => closure1(v0_1, v);

US0 closure4(void unitVar, void Function(String) v0_1) => US0_US0_0(v0_1);

US0 Function(void Function(String)) method1() => (void Function(String) v) => closure4(util.ignore(), v);

UH1 method2(UH1 v0_1_mut, UH1 v1_1_mut) {
    method2:
    while (true) {
        final UH1 v0_1 = v0_1_mut;
        final UH1 v1_1 = v1_1_mut;
        if (v0_1.tag == /* UH1_0 */ 0) {
            return v1_1;
        } else {
            final v0_1_1 = v0_1 as UH1_UH1_1;
            v0_1_mut = v0_1_1.Item2;
            v1_1_mut = UH1_UH1_1(v0_1_1.Item1, v1_1);
            continue method2;
        }
    }
}

UH1 method3(UH1 v0_1, UH1 v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return v1_1;
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        return UH1_UH1_1(v0_1_1.Item1, method3(v0_1_1.Item2, v1_1));
    }
}

UH0 closure6(UH0 v0_1, void unitVar) => v0_1;

UH0 method4(UH1 v0_1, UH0 v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return v1_1;
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH0 v4_1 = method4(v0_1_1.Item2, v1_1);
        return UH0_UH0_0(v0_1_1.Item1, () => closure6(v4_1, util.ignore()));
    }
}

UH0 closure7(UH0 v0_1, void unitVar) => v0_1;

UH0 closure8(UH0 v0_1, Mut0 v1_1, void unitVar) {
    final US1 v2_1 = v1_1.l0;
    if (v2_1.tag == /* US1_0 */ 0) {
        final v2_1_1 = v2_1 as US1_US1_0;
        final UH0 v5 = v2_1_1.f0_0();
        late final UH0 v12;
        if (v5.tag == /* UH0_1 */ 1) {
            v12 = const UH0(/* UH0_1 */ 1);
        } else {
            final v5_1 = v5 as UH0_UH0_0;
            v12 = UH0_UH0_0(v5_1.Item1, method5(v0_1, v5_1.Item2));
        }
        v1_1.l0 = US1_US1_1(v12);
        return v12;
    } else {
        final v2_1_2 = v2_1 as US1_US1_1;
        return v2_1_2.f1_0;
    }
}

UH0 Function() method5(UH0 v0_1, UH0 Function() v1_1) {
    final v3_1 = Mut0(US1_US1_0(v1_1));
    return () => closure8(v0_1, v3_1, util.ignore());
}

US2 method7(int v0_1_mut, UH0 v1_1_mut) {
    method7:
    while (true) {
        final v0_1 = v0_1_mut;
        final UH0 v1_1 = v1_1_mut;
        if (v1_1.tag == /* UH0_1 */ 1) {
            return const US2(/* US2_1 */ 1);
        } else if (v0_1 <= 0) {
            final v1_1_1 = v1_1 as UH0_UH0_0;
            return US2_US2_0(v1_1_1.Item1);
        } else {
            v0_1_mut = v0_1 - 1;
            final v1_1_2 = v1_1 as UH0_UH0_0;
            v1_1_mut = v1_1_2.Item2();
            continue method7;
        }
    }
}

int method6(US0 v0_1_mut, UH0 Function() v1_1_mut, Mut1 v2_1_mut, Mut1 v3_1_mut, Mut1 v4_1_mut, Mut2 v5_mut) {
    method6:
    while (true) {
        final US0 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        final v4_1 = v4_1_mut;
        final v5 = v5_mut;
        final v10 = string.toText(string.interpolate('create_sequential_roller / roll / current_index: %P() / acc: %P() / len: %P() / last_item: %A%P()', [v2_1.l0, v3_1.l0, v4_1.l0, v5.l0]));
        if (v0_1.tag == /* US0_0 */ 0) {
            final v0_1_1 = v0_1 as US0_US0_0;
            v0_1_1.f0_0(v10);
        }
        final UH0 v12 = v1_1();
        final US2 v14 = method7(v2_1.l0, v12);
        if (v14.tag == /* US2_0 */ 0) {
            final v14_1 = v14 as US2_US2_0;
            final v15 = v14_1.f0_0;
            final v17 = v2_1.l0 + 1;
            v2_1.l0 = v17;
            v5.l0 = US2_US2_0(v15);
            return v15;
        } else {
            if (v0_1.tag == /* US0_0 */ 0) {
                final v0_1_2 = v0_1 as US0_US0_0;
                v0_1_2.f0_0('create_sequential_roller / roll / None');
            }
            if (v4_1.l0 == (-1)) {
                final v23 = v2_1.l0;
                v4_1.l0 = v23;
            }
            final v29 = (v3_1.l0 >= v4_1.l0) ? 1 : (v3_1.l0 + 1);
            v3_1.l0 = v29;
            final v31 = v3_1.l0 - 1;
            v2_1.l0 = v31;
            v5.l0 = const US2(/* US2_1 */ 1);
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            v5_mut = v5;
            continue method6;
        }
    }
}

int closure9(US0 v0_1, UH0 Function() v1_1, Mut1 v2_1, Mut1 v3_1, Mut1 v4_1, Mut2 v5, void unitVar) => method6(v0_1, v1_1, v2_1, v3_1, v4_1, v5);

int Function() closure5(US0 v0_1, UH1 v1_1) {
    if (v0_1.tag == /* US0_0 */ 0) {
        final v0_1_1 = v0_1 as US0_US0_0;
        v0_1_1.f0_0('create_sequential_roller ()');
    }
    final UH0 v8 = method4(method3(v1_1, method2(v1_1, const UH1(/* UH1_0 */ 0))), const UH0(/* UH0_1 */ 1));
    final v10 = method5(v8, () => closure7(v8, util.ignore()));
    final v11 = Mut1(0);
    final v12 = Mut1(1);
    final v13 = Mut1(-1);
    final v15 = Mut2(const US2(/* US2_1 */ 1));
    return () => closure9(v0_1, v10, v11, v12, v13, v15, util.ignore());
}

int Function() Function(UH1) closure3(void unitVar, types.Some<void Function(String)>? v0_1) {
    final US0 v3_1 = option_47.defaultValue(const US0(/* US0_1 */ 1), option_47.map<void Function(String), US0>(method1(), v0_1));
    return (UH1 v) => closure5(v3_1, v);
}

int method8(US0 v0_1_mut, int v1_1_mut, int v2_1_mut, int v3_1_mut) {
    method8:
    while (true) {
        final US0 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        if (v3_1 < v1_1) {
            final v5 = v3_1 * 6;
            if (v5 > v3_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1 + 1;
                v3_1_mut = v5;
                continue method8;
            } else {
                final v9 = 'calculate_dice_count / max: $v1_1 / n: $v2_1 / p: $v3_1';
                if (v0_1.tag == /* US0_0 */ 0) {
                    final v0_1_1 = v0_1 as US0_US0_0;
                    v0_1_1.f0_0(v9);
                }
                return v2_1;
            }
        } else {
            final v12 = 'calculate_dice_count / max: $v1_1 / n: $v2_1 / p: $v3_1';
            if (v0_1.tag == /* US0_0 */ 0) {
                final v0_1_2 = v0_1 as US0_US0_0;
                v0_1_2.f0_0(v12);
            }
            return v2_1;
        }
    }
}

UH2 closure77(void unitVar, void unitVar_1) => UH2_UH2_0(0, () => closure77(util.ignore(), util.ignore()));

UH2 closure76(void unitVar, void unitVar_1) => UH2_UH2_0(-9223372036854775808, () => closure77(util.ignore(), util.ignore()));

UH2 closure75(void unitVar, void unitVar_1) => UH2_UH2_0(4611686018427387904, () => closure76(util.ignore(), util.ignore()));

UH2 closure74(void unitVar, void unitVar_1) => UH2_UH2_0(6917529027641081856, () => closure75(util.ignore(), util.ignore()));

UH2 closure73(void unitVar, void unitVar_1) => UH2_UH2_0(1152921504606846976, () => closure74(util.ignore(), util.ignore()));

UH2 closure72(void unitVar, void unitVar_1) => UH2_UH2_0(-2882303761517117440, () => closure73(util.ignore(), util.ignore()));

UH2 closure71(void unitVar, void unitVar_1) => UH2_UH2_0(-6629298651489370112, () => closure72(util.ignore(), util.ignore()));

UH2 closure70(void unitVar, void unitVar_1) => UH2_UH2_0(5044031582654955520, () => closure71(util.ignore(), util.ignore()));

UH2 closure69(void unitVar, void unitVar_1) => UH2_UH2_0(6989586621679009792, () => closure70(util.ignore(), util.ignore()));

UH2 closure68(void unitVar, void unitVar_1) => UH2_UH2_0(-1909526242005090304, () => closure69(util.ignore(), util.ignore()));

UH2 closure67(void unitVar, void unitVar_1) => UH2_UH2_0(-6467169064904032256, () => closure68(util.ignore(), util.ignore()));

UH2 closure66(void unitVar, void unitVar_1) => UH2_UH2_0(-4152318856435597312, () => closure67(util.ignore(), util.ignore()));

UH2 closure65(void unitVar, void unitVar_1) => UH2_UH2_0(2382404202878992384, () => closure66(util.ignore(), util.ignore()));

UH2 closure64(void unitVar, void unitVar_1) => UH2_UH2_0(6545982058383015936, () => closure65(util.ignore(), util.ignore()));

UH2 closure63(void unitVar, void unitVar_1) => UH2_UH2_0(-8132375027124273152, () => closure64(util.ignore(), util.ignore()));

UH2 closure62(void unitVar, void unitVar_1) => UH2_UH2_0(4793518853382471680, () => closure63(util.ignore(), util.ignore()));

UH2 closure61(void unitVar, void unitVar_1) => UH2_UH2_0(3873377154515337216, () => closure62(util.ignore(), util.ignore()));

UH2 closure60(void unitVar, void unitVar_1) => UH2_UH2_0(645562859085889536, () => closure61(util.ignore(), util.ignore()));

UH2 closure59(void unitVar, void unitVar_1) => UH2_UH2_0(107593809847648256, () => closure60(util.ignore(), util.ignore()));

UH2 closure58(void unitVar, void unitVar_1) => UH2_UH2_0(3092389647259533312, () => closure59(util.ignore(), util.ignore()));

UH2 closure57(void unitVar, void unitVar_1) => UH2_UH2_0(-8707973762311520256, () => closure58(util.ignore(), util.ignore()));

UH2 closure56(void unitVar, void unitVar_1) => UH2_UH2_0(-1451328960385253376, () => closure57(util.ignore(), util.ignore()));

UH2 closure55(void unitVar, void unitVar_1) => UH2_UH2_0(8981483876790566912, () => closure56(util.ignore(), util.ignore()));

UH2 closure54(void unitVar, void unitVar_1) => UH2_UH2_0(-4652000711771422720, () => closure55(util.ignore(), util.ignore()));

UH2 closure53(void unitVar, void unitVar_1) => UH2_UH2_0(2299123893656354816, () => closure54(util.ignore(), util.ignore()));

UH2 closure52(void unitVar, void unitVar_1) => UH2_UH2_0(3457644661227651072, () => closure53(util.ignore(), util.ignore()));

UH2 closure51(void unitVar, void unitVar_1) => UH2_UH2_0(576274110204608512, () => closure52(util.ignore(), util.ignore()));

UH2 closure50(void unitVar, void unitVar_1) => UH2_UH2_0(6244960376270618624, () => closure51(util.ignore(), util.ignore()));

UH2 closure49(void unitVar, void unitVar_1) => UH2_UH2_0(-5108087961858080768, () => closure50(util.ignore(), util.ignore()));

UH2 closure48(void unitVar, void unitVar_1) => UH2_UH2_0(-3925805339261272064, () => closure49(util.ignore(), util.ignore()));

UH2 closure47(void unitVar, void unitVar_1) => UH2_UH2_0(-3728758235495137280, () => closure48(util.ignore(), util.ignore()));

UH2 closure46(void unitVar, void unitVar_1) => UH2_UH2_0(5527454985320660992, () => closure47(util.ignore(), util.ignore()));

UH2 closure45(void unitVar, void unitVar_1) => UH2_UH2_0(-2153214848064815104, () => closure46(util.ignore(), util.ignore()));

UH2 closure44(void unitVar, void unitVar_1) => UH2_UH2_0(-6507783832580653056, () => closure45(util.ignore(), util.ignore()));

UH2 closure43(void unitVar, void unitVar_1) => UH2_UH2_0(8138741398091333632, () => closure44(util.ignore(), util.ignore()));

UH2 closure42(void unitVar, void unitVar_1) => UH2_UH2_0(7505371590918406144, () => closure43(util.ignore(), util.ignore()));

UH2 closure41(void unitVar, void unitVar_1) => UH2_UH2_0(-1823562080465190912, () => closure42(util.ignore(), util.ignore()));

UH2 closure40(void unitVar, void unitVar_1) => UH2_UH2_0(8919445023443910656, () => closure41(util.ignore(), util.ignore()));

UH2 closure39(void unitVar, void unitVar_1) => UH2_UH2_0(4561031516192243712, () => closure40(util.ignore(), util.ignore()));

UH2 closure38(void unitVar, void unitVar_1) => UH2_UH2_0(-8463200117489401856, () => closure39(util.ignore(), util.ignore()));

UH2 closure37(void unitVar, void unitVar_1) => UH2_UH2_0(4738381338321616896, () => closure38(util.ignore(), util.ignore()));

UH2 closure36(void unitVar, void unitVar_1) => UH2_UH2_0(789730223053602816, () => closure37(util.ignore(), util.ignore()));

UH2 closure35(void unitVar, void unitVar_1) => UH2_UH2_0(131621703842267136, () => closure36(util.ignore(), util.ignore()));

UH2 closure34(void unitVar, void unitVar_1) => UH2_UH2_0(21936950640377856, () => closure35(util.ignore(), util.ignore()));

UH2 closure33(void unitVar, void unitVar_1) => UH2_UH2_0(3656158440062976, () => closure34(util.ignore(), util.ignore()));

UH2 closure32(void unitVar, void unitVar_1) => UH2_UH2_0(609359740010496, () => closure33(util.ignore(), util.ignore()));

UH2 closure31(void unitVar, void unitVar_1) => UH2_UH2_0(101559956668416, () => closure32(util.ignore(), util.ignore()));

UH2 closure30(void unitVar, void unitVar_1) => UH2_UH2_0(16926659444736, () => closure31(util.ignore(), util.ignore()));

UH2 closure29(void unitVar, void unitVar_1) => UH2_UH2_0(2821109907456, () => closure30(util.ignore(), util.ignore()));

UH2 closure28(void unitVar, void unitVar_1) => UH2_UH2_0(470184984576, () => closure29(util.ignore(), util.ignore()));

UH2 closure27(void unitVar, void unitVar_1) => UH2_UH2_0(78364164096, () => closure28(util.ignore(), util.ignore()));

UH2 closure26(void unitVar, void unitVar_1) => UH2_UH2_0(13060694016, () => closure27(util.ignore(), util.ignore()));

UH2 closure25(void unitVar, void unitVar_1) => UH2_UH2_0(2176782336, () => closure26(util.ignore(), util.ignore()));

UH2 closure24(void unitVar, void unitVar_1) => UH2_UH2_0(362797056, () => closure25(util.ignore(), util.ignore()));

UH2 closure23(void unitVar, void unitVar_1) => UH2_UH2_0(60466176, () => closure24(util.ignore(), util.ignore()));

UH2 closure22(void unitVar, void unitVar_1) => UH2_UH2_0(10077696, () => closure23(util.ignore(), util.ignore()));

UH2 closure21(void unitVar, void unitVar_1) => UH2_UH2_0(1679616, () => closure22(util.ignore(), util.ignore()));

UH2 closure20(void unitVar, void unitVar_1) => UH2_UH2_0(279936, () => closure21(util.ignore(), util.ignore()));

UH2 closure19(void unitVar, void unitVar_1) => UH2_UH2_0(46656, () => closure20(util.ignore(), util.ignore()));

UH2 closure18(void unitVar, void unitVar_1) => UH2_UH2_0(7776, () => closure19(util.ignore(), util.ignore()));

UH2 closure17(void unitVar, void unitVar_1) => UH2_UH2_0(1296, () => closure18(util.ignore(), util.ignore()));

UH2 closure16(void unitVar, void unitVar_1) => UH2_UH2_0(216, () => closure17(util.ignore(), util.ignore()));

UH2 closure15(void unitVar, void unitVar_1) => UH2_UH2_0(36, () => closure16(util.ignore(), util.ignore()));

UH2 closure14(void unitVar, void unitVar_1) => UH2_UH2_0(6, () => closure15(util.ignore(), util.ignore()));

US4 method11(int v0_1_mut, UH2 v1_1_mut) {
    method11:
    while (true) {
        final v0_1 = v0_1_mut;
        final UH2 v1_1 = v1_1_mut;
        if (v1_1.tag == /* UH2_1 */ 1) {
            return const US4(/* US4_1 */ 1);
        } else if (v0_1 <= 0) {
            final v1_1_1 = v1_1 as UH2_UH2_0;
            return US4_US4_0(v1_1_1.Item1);
        } else {
            v0_1_mut = v0_1 - 1;
            final v1_1_2 = v1_1 as UH2_UH2_0;
            v1_1_mut = v1_1_2.Item2();
            continue method11;
        }
    }
}

US3 method10(US0 v0_1_mut, int v1_1_mut, UH1 v2_1_mut, int v3_1_mut) {
    method10:
    while (true) {
        final US0 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final UH1 v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        if (v1_1 < 0) {
            final v5 = v3_1 + 1;
            final v6 = 'accumulate_dice_rolls / power: $v1_1 / acc: $v3_1 / result: $v5';
            if (v0_1.tag == /* US0_0 */ 0) {
                final v0_1_1 = v0_1 as US0_US0_0;
                v0_1_1.f0_0(v6);
            }
            return US3_US3_0(v5, v2_1);
        } else if (v2_1.tag == /* UH1_0 */ 0) {
            return const US3(/* US3_1 */ 1);
        } else {
            final v2_1_1 = v2_1 as UH1_UH1_1;
            final UH1 v11 = v2_1_1.Item2;
            final v10 = v2_1_1.Item1;
            if (v10 > 1) {
                final US4 v16 = method11(v1_1, UH2_UH2_0(1, () => closure14(util.ignore(), util.ignore())));
                final tmp_combine = v10 - 1;
                late final int tmp_capture;
                if (v16.tag == /* US4_0 */ 0) {
                    final v16_1 = v16 as US4_US4_0;
                    tmp_capture = v16_1.f0_0;
                } else {
                    tmp_capture = throw Exception('Option does not have a value.');
                }
                final v23 = tmp_combine * tmp_capture;
                final v24 = 'accumulate_dice_rolls / power: $v1_1 / acc: $v3_1 / roll: $v10 / value: $v23';
                if (v0_1.tag == /* US0_0 */ 0) {
                    final v0_1_2 = v0_1 as US0_US0_0;
                    v0_1_2.f0_0(v24);
                }
                v0_1_mut = v0_1;
                v1_1_mut = v1_1 - 1;
                v2_1_mut = v11;
                v3_1_mut = v3_1 + v23;
                continue method10;
            } else {
                final v29 = 'accumulate_dice_rolls / power: $v1_1 / acc: $v3_1 / roll: $v10';
                if (v0_1.tag == /* US0_0 */ 0) {
                    final v0_1_3 = v0_1 as US0_US0_0;
                    v0_1_3.f0_0(v29);
                }
                v0_1_mut = v0_1;
                v1_1_mut = v1_1 - 1;
                v2_1_mut = v11;
                v3_1_mut = v3_1;
                continue method10;
            }
        }
    }
}

UH1 method12(int v0_1, int Function() v1_1, int v2_1) {
    if (v2_1 < v0_1) {
        return UH1_UH1_1(v1_1(), method12(v0_1, v1_1, v2_1 + 1));
    } else {
        return const UH1(/* UH1_0 */ 0);
    }
}

int method13(US0 v0_1_mut, int Function() v1_1_mut, bool v2_1_mut, int v3_1_mut, int v4_1_mut, UH1 v5_mut) {
    method13:
    while (true) {
        final US0 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        final v4_1 = v4_1_mut;
        final UH1 v5 = v5_mut;
        final v6 = v4_1 + 1;
        if (v4_1 < v6) {
            return method9(v0_1, v1_1, v2_1, v3_1, v4_1, UH1_UH1_1(v1_1(), v5), v6);
        } else {
            final US3 v12 = method10(v0_1, v4_1, v5, 0);
            if (v12.tag == /* US3_0 */ 0) {
                final v12_1 = v12 as US3_US3_0;
                final v13 = v12_1.f0_0;
                if (v13 <= v3_1) {
                    return v13;
                } else if (v2_1) {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = v4_1;
                    v5_mut = method12(v4_1, v1_1, 0);
                    continue method13;
                } else {
                    return method9(v0_1, v1_1, v2_1, v3_1, v4_1, UH1_UH1_1(v1_1(), v5), v6);
                }
            } else if (v2_1) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = v4_1;
                v5_mut = method12(v4_1, v1_1, 0);
                continue method13;
            } else {
                return method9(v0_1, v1_1, v2_1, v3_1, v4_1, UH1_UH1_1(v1_1(), v5), v6);
            }
        }
    }
}

int method9(US0 v0_1_mut, int Function() v1_1_mut, bool v2_1_mut, int v3_1_mut, int v4_1_mut, UH1 v5_mut, int v6_mut) {
    method9:
    while (true) {
        final US0 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        final v4_1 = v4_1_mut;
        final UH1 v5 = v5_mut;
        final v6 = v6_mut;
        if (v6 < (v4_1 + 1)) {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = v2_1;
            v3_1_mut = v3_1;
            v4_1_mut = v4_1;
            v5_mut = UH1_UH1_1(v1_1(), v5);
            v6_mut = v6 + 1;
            continue method9;
        } else {
            final US3 v14 = method10(v0_1, v4_1, v5, 0);
            if (v14.tag == /* US3_0 */ 0) {
                final v14_1 = v14 as US3_US3_0;
                final v15 = v14_1.f0_0;
                if (v15 <= v3_1) {
                    return v15;
                } else if (v2_1) {
                    return method13(v0_1, v1_1, v2_1, v3_1, v4_1, method12(v4_1, v1_1, 0));
                } else {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v2_1;
                    v3_1_mut = v3_1;
                    v4_1_mut = v4_1;
                    v5_mut = UH1_UH1_1(v1_1(), v5);
                    v6_mut = v6 + 1;
                    continue method9;
                }
            } else if (v2_1) {
                return method13(v0_1, v1_1, v2_1, v3_1, v4_1, method12(v4_1, v1_1, 0));
            } else {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_1_mut = v4_1;
                v5_mut = UH1_UH1_1(v1_1(), v5);
                v6_mut = v6 + 1;
                continue method9;
            }
        }
    }
}

int closure13(US0 v0_1, int Function() v1_1, bool v2_1, int v3_1) => method9(v0_1, v1_1, v2_1, v3_1, ((v3_1 == 1) ? 1 : method8(v0_1, v3_1, 0, 1)) - 1, const UH1(/* UH1_0 */ 0), 0);

int Function(int) closure12(US0 v0_1, int Function() v1_1, bool v2_1) => (int v) => closure13(v0_1, v1_1, v2_1, v);

int Function(int) Function(bool) closure11(US0 v0_1, int Function() v1_1) => (bool v) => closure12(v0_1, v1_1, v);

int Function(int) Function(bool) Function(int Function()) closure10(void unitVar, types.Some<void Function(String)>? v0_1) {
    final US0 v3_1 = option_47.defaultValue(const US0(/* US0_1 */ 1), option_47.map<void Function(String), US0>(method1(), v0_1));
    return (int Function() v) => closure11(v3_1, v);
}

int method14(UH1 v0_1_mut, int v1_1_mut) {
    method14:
    while (true) {
        final UH1 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        if (v0_1.tag == /* UH1_0 */ 0) {
            return v1_1;
        } else {
            final v0_1_1 = v0_1 as UH1_UH1_1;
            v0_1_mut = v0_1_1.Item2;
            v1_1_mut = v1_1 + 1;
            continue method14;
        }
    }
}

types.Some<int>? closure80(types.Some<void Function(String)>? v0_1, int v1_1, UH1 v2_1) {
    final US3 v10 = method10(option_47.defaultValue(const US0(/* US0_1 */ 1), option_47.map<void Function(String), US0>(method1(), v0_1)), method14(v2_1, 0) - 1, v2_1, 0);
    late final US4 v20;
    if (v10.tag == /* US3_0 */ 0) {
        final v10_1 = v10 as US3_US3_0;
        final v11 = v10_1.f0_0;
        v20 = ((v11 >= 1) && (v11 <= v1_1)) ? US4_US4_0(v11) : const US4(/* US4_1 */ 1);
    } else {
        v20 = const US4(/* US4_1 */ 1);
    }
    if (v20.tag == /* US4_0 */ 0) {
        final v20_1 = v20 as US4_US4_0;
        return types.Some(v20_1.f0_0);
    } else {
        return null;
    }
}

types.Some<int>? Function(UH1) closure79(types.Some<void Function(String)>? v0_1, int v1_1) => (UH1 v) => closure80(v0_1, v1_1, v);

types.Some<int>? Function(UH1) Function(int) closure78(void unitVar, types.Some<void Function(String)>? v0_1) => (int v) => closure79(v0_1, v);

US5 method40(UH1 v0_1, int v1_1) {
    final v2_1 = v1_1 + 1;
    final v3_1 = 'accumulate_dice_rolls / power: ${-1} / acc: $v1_1 / result: $v2_1';
    console.log(v3_1);
    return US5_US5_0(v2_1, v0_1);
}

US5 method39(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v7 = v3_1 - 1;
            final v8 = 'accumulate_dice_rolls / power: ${0} / acc: $v1_1 / roll: $v3_1 / value: $v7';
            console.log(v8);
            return method40(v4_1, v1_1 + v7);
        } else {
            final v11 = 'accumulate_dice_rolls / power: ${0} / acc: $v1_1 / roll: $v3_1';
            console.log(v11);
            return method40(v4_1, v1_1);
        }
    }
}

US5 method38(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 6;
            final v9 = 'accumulate_dice_rolls / power: ${1} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method39(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${1} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method39(v4_1, v1_1);
        }
    }
}

US5 method37(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 36;
            final v9 = 'accumulate_dice_rolls / power: ${2} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method38(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${2} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method38(v4_1, v1_1);
        }
    }
}

US5 method36(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 216;
            final v9 = 'accumulate_dice_rolls / power: ${3} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method37(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${3} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method37(v4_1, v1_1);
        }
    }
}

US5 method35(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 1296;
            final v9 = 'accumulate_dice_rolls / power: ${4} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method36(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${4} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method36(v4_1, v1_1);
        }
    }
}

US5 method34(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 7776;
            final v9 = 'accumulate_dice_rolls / power: ${5} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method35(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${5} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method35(v4_1, v1_1);
        }
    }
}

US5 method33(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 46656;
            final v9 = 'accumulate_dice_rolls / power: ${6} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method34(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${6} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method34(v4_1, v1_1);
        }
    }
}

US5 method32(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 279936;
            final v9 = 'accumulate_dice_rolls / power: ${7} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method33(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${7} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method33(v4_1, v1_1);
        }
    }
}

US5 method31(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 1679616;
            final v9 = 'accumulate_dice_rolls / power: ${8} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method32(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${8} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method32(v4_1, v1_1);
        }
    }
}

US5 method30(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 10077696;
            final v9 = 'accumulate_dice_rolls / power: ${9} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method31(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${9} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method31(v4_1, v1_1);
        }
    }
}

US5 method29(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 60466176;
            final v9 = 'accumulate_dice_rolls / power: ${10} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method30(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${10} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method30(v4_1, v1_1);
        }
    }
}

US5 method28(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 362797056;
            final v9 = 'accumulate_dice_rolls / power: ${11} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method29(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${11} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method29(v4_1, v1_1);
        }
    }
}

US5 method27(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 2176782336;
            final v9 = 'accumulate_dice_rolls / power: ${12} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method28(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${12} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method28(v4_1, v1_1);
        }
    }
}

US5 method26(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 13060694016;
            final v9 = 'accumulate_dice_rolls / power: ${13} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method27(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${13} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method27(v4_1, v1_1);
        }
    }
}

US5 method25(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 78364164096;
            final v9 = 'accumulate_dice_rolls / power: ${14} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method26(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${14} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method26(v4_1, v1_1);
        }
    }
}

US5 method24(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 470184984576;
            final v9 = 'accumulate_dice_rolls / power: ${15} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method25(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${15} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method25(v4_1, v1_1);
        }
    }
}

US5 method23(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 2821109907456;
            final v9 = 'accumulate_dice_rolls / power: ${16} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method24(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${16} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method24(v4_1, v1_1);
        }
    }
}

US5 method22(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 16926659444736;
            final v9 = 'accumulate_dice_rolls / power: ${17} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method23(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${17} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method23(v4_1, v1_1);
        }
    }
}

US5 method21(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 101559956668416;
            final v9 = 'accumulate_dice_rolls / power: ${18} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method22(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${18} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method22(v4_1, v1_1);
        }
    }
}

US5 method20(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 609359740010496;
            final v9 = 'accumulate_dice_rolls / power: ${19} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method21(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${19} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method21(v4_1, v1_1);
        }
    }
}

US5 method19(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 3656158440062976;
            final v9 = 'accumulate_dice_rolls / power: ${20} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method20(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${20} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method20(v4_1, v1_1);
        }
    }
}

US5 method18(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 21936950640377856;
            final v9 = 'accumulate_dice_rolls / power: ${21} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method19(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${21} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method19(v4_1, v1_1);
        }
    }
}

US5 method17(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 131621703842267136;
            final v9 = 'accumulate_dice_rolls / power: ${22} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method18(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${22} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method18(v4_1, v1_1);
        }
    }
}

US5 method16(UH1 v0_1, int v1_1) {
    if (v0_1.tag == /* UH1_0 */ 0) {
        return const US5(/* US5_1 */ 1);
    } else {
        final v0_1_1 = v0_1 as UH1_UH1_1;
        final UH1 v4_1 = v0_1_1.Item2;
        final v3_1 = v0_1_1.Item1;
        if (v3_1 > 1) {
            final v8 = (v3_1 - 1) * 789730223053602816;
            final v9 = 'accumulate_dice_rolls / power: ${23} / acc: $v1_1 / roll: $v3_1 / value: $v8';
            console.log(v9);
            return method17(v4_1, v1_1 + v8);
        } else {
            final v12 = 'accumulate_dice_rolls / power: ${23} / acc: $v1_1 / roll: $v3_1';
            console.log(v12);
            return method17(v4_1, v1_1);
        }
    }
}

int method15(UH1 v0_1_mut, int v1_1_mut) {
    method15:
    while (true) {
        final UH1 v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        if (v1_1 < 24) {
            types.Some<int>? _v3;
            final x = random.nonSeeded().Next2(1, 7);
            _v3 = types.Some(x);
            v0_1_mut = UH1_UH1_1(types.value(_v3), v0_1);
            v1_1_mut = v1_1 + 1;
            continue method15;
        } else {
            final US5 v17 = method16(v0_1, 0);
            if (v17.tag == /* US5_0 */ 0) {
                final v17_1 = v17 as US5_US5_0;
                final v18 = v17_1.f0_0;
                if (v18 <= 9223372036854775807) {
                    return v18;
                } else {
                    types.Some<int>? _v21;
                    final x_1 = random.nonSeeded().Next2(1, 7);
                    _v21 = types.Some(x_1);
                    final v30 = types.value(_v21);
                    types.Some<int>? _v31;
                    final x_2 = random.nonSeeded().Next2(1, 7);
                    _v31 = types.Some(x_2);
                    final v38 = types.value(_v31);
                    types.Some<int>? _v39;
                    final x_3 = random.nonSeeded().Next2(1, 7);
                    _v39 = types.Some(x_3);
                    final v46 = types.value(_v39);
                    types.Some<int>? _v47;
                    final x_4 = random.nonSeeded().Next2(1, 7);
                    _v47 = types.Some(x_4);
                    final v54 = types.value(_v47);
                    types.Some<int>? _v55;
                    final x_5 = random.nonSeeded().Next2(1, 7);
                    _v55 = types.Some(x_5);
                    final v62 = types.value(_v55);
                    types.Some<int>? _v63;
                    final x_6 = random.nonSeeded().Next2(1, 7);
                    _v63 = types.Some(x_6);
                    final v70 = types.value(_v63);
                    types.Some<int>? _v71;
                    final x_7 = random.nonSeeded().Next2(1, 7);
                    _v71 = types.Some(x_7);
                    final v78 = types.value(_v71);
                    types.Some<int>? _v79;
                    final x_8 = random.nonSeeded().Next2(1, 7);
                    _v79 = types.Some(x_8);
                    final v86 = types.value(_v79);
                    types.Some<int>? _v87;
                    final x_9 = random.nonSeeded().Next2(1, 7);
                    _v87 = types.Some(x_9);
                    final v94 = types.value(_v87);
                    types.Some<int>? _v95;
                    final x_10 = random.nonSeeded().Next2(1, 7);
                    _v95 = types.Some(x_10);
                    final v102 = types.value(_v95);
                    types.Some<int>? _v103;
                    final x_11 = random.nonSeeded().Next2(1, 7);
                    _v103 = types.Some(x_11);
                    final v110 = types.value(_v103);
                    types.Some<int>? _v111;
                    final x_12 = random.nonSeeded().Next2(1, 7);
                    _v111 = types.Some(x_12);
                    final v118 = types.value(_v111);
                    types.Some<int>? _v119;
                    final x_13 = random.nonSeeded().Next2(1, 7);
                    _v119 = types.Some(x_13);
                    final v126 = types.value(_v119);
                    types.Some<int>? _v127;
                    final x_14 = random.nonSeeded().Next2(1, 7);
                    _v127 = types.Some(x_14);
                    final v134 = types.value(_v127);
                    types.Some<int>? _v135;
                    final x_15 = random.nonSeeded().Next2(1, 7);
                    _v135 = types.Some(x_15);
                    final v142 = types.value(_v135);
                    types.Some<int>? _v143;
                    final x_16 = random.nonSeeded().Next2(1, 7);
                    _v143 = types.Some(x_16);
                    final v150 = types.value(_v143);
                    types.Some<int>? _v151;
                    final x_17 = random.nonSeeded().Next2(1, 7);
                    _v151 = types.Some(x_17);
                    final v158 = types.value(_v151);
                    types.Some<int>? _v159;
                    final x_18 = random.nonSeeded().Next2(1, 7);
                    _v159 = types.Some(x_18);
                    final v166 = types.value(_v159);
                    types.Some<int>? _v167;
                    final x_19 = random.nonSeeded().Next2(1, 7);
                    _v167 = types.Some(x_19);
                    final v174 = types.value(_v167);
                    types.Some<int>? _v175;
                    final x_20 = random.nonSeeded().Next2(1, 7);
                    _v175 = types.Some(x_20);
                    final v182 = types.value(_v175);
                    types.Some<int>? _v183;
                    final x_21 = random.nonSeeded().Next2(1, 7);
                    _v183 = types.Some(x_21);
                    final v190 = types.value(_v183);
                    types.Some<int>? _v191;
                    final x_22 = random.nonSeeded().Next2(1, 7);
                    _v191 = types.Some(x_22);
                    final v198 = types.value(_v191);
                    types.Some<int>? _v199;
                    final x_23 = random.nonSeeded().Next2(1, 7);
                    _v199 = types.Some(x_23);
                    v0_1_mut = UH1_UH1_1(v30, UH1_UH1_1(v38, UH1_UH1_1(v46, UH1_UH1_1(v54, UH1_UH1_1(v62, UH1_UH1_1(v70, UH1_UH1_1(v78, UH1_UH1_1(v86, UH1_UH1_1(v94, UH1_UH1_1(v102, UH1_UH1_1(v110, UH1_UH1_1(v118, UH1_UH1_1(v126, UH1_UH1_1(v134, UH1_UH1_1(v142, UH1_UH1_1(v150, UH1_UH1_1(v158, UH1_UH1_1(v166, UH1_UH1_1(v174, UH1_UH1_1(v182, UH1_UH1_1(v190, UH1_UH1_1(v198, UH1_UH1_1(types.value(_v199), const UH1(/* UH1_0 */ 0))))))))))))))))))))))));
                    v1_1_mut = 23;
                    continue method15;
                }
            } else {
                types.Some<int>? _v234;
                final x_24 = random.nonSeeded().Next2(1, 7);
                _v234 = types.Some(x_24);
                final v243 = types.value(_v234);
                types.Some<int>? _v244;
                final x_25 = random.nonSeeded().Next2(1, 7);
                _v244 = types.Some(x_25);
                final v251 = types.value(_v244);
                types.Some<int>? _v252;
                final x_26 = random.nonSeeded().Next2(1, 7);
                _v252 = types.Some(x_26);
                final v259 = types.value(_v252);
                types.Some<int>? _v260;
                final x_27 = random.nonSeeded().Next2(1, 7);
                _v260 = types.Some(x_27);
                final v267 = types.value(_v260);
                types.Some<int>? _v268;
                final x_28 = random.nonSeeded().Next2(1, 7);
                _v268 = types.Some(x_28);
                final v275 = types.value(_v268);
                types.Some<int>? _v276;
                final x_29 = random.nonSeeded().Next2(1, 7);
                _v276 = types.Some(x_29);
                final v283 = types.value(_v276);
                types.Some<int>? _v284;
                final x_30 = random.nonSeeded().Next2(1, 7);
                _v284 = types.Some(x_30);
                final v291 = types.value(_v284);
                types.Some<int>? _v292;
                final x_31 = random.nonSeeded().Next2(1, 7);
                _v292 = types.Some(x_31);
                final v299 = types.value(_v292);
                types.Some<int>? _v300;
                final x_32 = random.nonSeeded().Next2(1, 7);
                _v300 = types.Some(x_32);
                final v307 = types.value(_v300);
                types.Some<int>? _v308;
                final x_33 = random.nonSeeded().Next2(1, 7);
                _v308 = types.Some(x_33);
                final v315 = types.value(_v308);
                types.Some<int>? _v316;
                final x_34 = random.nonSeeded().Next2(1, 7);
                _v316 = types.Some(x_34);
                final v323 = types.value(_v316);
                types.Some<int>? _v324;
                final x_35 = random.nonSeeded().Next2(1, 7);
                _v324 = types.Some(x_35);
                final v331 = types.value(_v324);
                types.Some<int>? _v332;
                final x_36 = random.nonSeeded().Next2(1, 7);
                _v332 = types.Some(x_36);
                final v339 = types.value(_v332);
                types.Some<int>? _v340;
                final x_37 = random.nonSeeded().Next2(1, 7);
                _v340 = types.Some(x_37);
                final v347 = types.value(_v340);
                types.Some<int>? _v348;
                final x_38 = random.nonSeeded().Next2(1, 7);
                _v348 = types.Some(x_38);
                final v355 = types.value(_v348);
                types.Some<int>? _v356;
                final x_39 = random.nonSeeded().Next2(1, 7);
                _v356 = types.Some(x_39);
                final v363 = types.value(_v356);
                types.Some<int>? _v364;
                final x_40 = random.nonSeeded().Next2(1, 7);
                _v364 = types.Some(x_40);
                final v371 = types.value(_v364);
                types.Some<int>? _v372;
                final x_41 = random.nonSeeded().Next2(1, 7);
                _v372 = types.Some(x_41);
                final v379 = types.value(_v372);
                types.Some<int>? _v380;
                final x_42 = random.nonSeeded().Next2(1, 7);
                _v380 = types.Some(x_42);
                final v387 = types.value(_v380);
                types.Some<int>? _v388;
                final x_43 = random.nonSeeded().Next2(1, 7);
                _v388 = types.Some(x_43);
                final v395 = types.value(_v388);
                types.Some<int>? _v396;
                final x_44 = random.nonSeeded().Next2(1, 7);
                _v396 = types.Some(x_44);
                final v403 = types.value(_v396);
                types.Some<int>? _v404;
                final x_45 = random.nonSeeded().Next2(1, 7);
                _v404 = types.Some(x_45);
                final v411 = types.value(_v404);
                types.Some<int>? _v412;
                final x_46 = random.nonSeeded().Next2(1, 7);
                _v412 = types.Some(x_46);
                v0_1_mut = UH1_UH1_1(v243, UH1_UH1_1(v251, UH1_UH1_1(v259, UH1_UH1_1(v267, UH1_UH1_1(v275, UH1_UH1_1(v283, UH1_UH1_1(v291, UH1_UH1_1(v299, UH1_UH1_1(v307, UH1_UH1_1(v315, UH1_UH1_1(v323, UH1_UH1_1(v331, UH1_UH1_1(v339, UH1_UH1_1(v347, UH1_UH1_1(v355, UH1_UH1_1(v363, UH1_UH1_1(v371, UH1_UH1_1(v379, UH1_UH1_1(v387, UH1_UH1_1(v395, UH1_UH1_1(v403, UH1_UH1_1(v411, UH1_UH1_1(types.value(_v412), const UH1(/* UH1_0 */ 0))))))))))))))))))))))));
                v1_1_mut = 23;
                continue method15;
            }
        }
    }
}

int closure81(void unitVar, List<String> v0_1) {
    final v1_1 = 'calculate_dice_count / max: ${9223372036854775807} / n: ${24} / p: ${4738381338321616896}';
    console.log(v1_1);
    final v5 = 'result: ${method15(const UH1(/* UH1_0 */ 0), 0)}';
    console.log(v5);
    return 0;
}

UH0 Function(UH0) v0(int v) => closure0(util.ignore(), v);

UH0 Function(UH0) rotate_numbers(int x) => v0(x);

int Function() Function(UH1) v1(types.Some<void Function(String)>? v) => closure3(util.ignore(), v);

int Function() Function(UH1) create_sequential_roller(types.Some<void Function(String)>? x) => v1(x);

int Function(int) Function(bool) Function(int Function()) v2(types.Some<void Function(String)>? v) => closure10(util.ignore(), v);

int Function(int) Function(bool) Function(int Function()) roll_progressively(types.Some<void Function(String)>? x) => v2(x);

types.Some<int>? Function(UH1) Function(int) v3(types.Some<void Function(String)>? v) => closure78(util.ignore(), v);

types.Some<int>? Function(UH1) Function(int) roll_within_bounds(types.Some<void Function(String)>? x) => v3(x);

int v4(List<String> v) => closure81(util.ignore(), v);

int main(List<String> args) => v4(args);

