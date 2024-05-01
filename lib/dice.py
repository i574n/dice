from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
import sys
from typing import Any
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, op_multiply)
from fable_modules.fable_library.option import (default_arg, map, value as value_47)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, string_type, record_type, int64_type, uint64_type)
from fable_modules.fable_library.string_ import (to_text, interpolate)
from fable_modules.fable_library.types import (Array, Union, Record, int64, FSharpRef, uint8, uint64, int8)
from fable_modules.fable_library.util import randint

def _expr226() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr226

def _expr227() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr227

def _expr228() -> TypeInfo:
    return union_type("Dice.US0", [], US0, lambda: [[("f0_0", lambda_type(string_type, unit_type))], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr228

def _expr229() -> TypeInfo:
    return union_type("Dice.US1", [], US1, lambda: [[("f0_0", lambda_type(unit_type, UH0_reflection()))], [("f1_0", UH0_reflection())]])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr229

def _expr230() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US1_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: US1

Mut0_reflection = _expr230

def _expr231() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr231

def _expr232() -> TypeInfo:
    return union_type("Dice.US2", [], US2, lambda: [[("f0_0", uint8_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr232

def _expr233() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", US2_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US2

Mut2_reflection = _expr233

def _expr234() -> TypeInfo:
    return union_type("Dice.US3", [], US3, lambda: [[("f0_0", uint64_type), ("f0_1", UH1_reflection())], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr234

def _expr235() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr235

def _expr236() -> TypeInfo:
    return union_type("Dice.US4", [], US4, lambda: [[("f0_0", uint64_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr236

def _expr237() -> TypeInfo:
    return union_type("Dice.US5", [], US5, lambda: [[("f0_0", int64_type), ("f0_1", UH1_reflection())], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr237

def UH0__get_IsUH0_0(this: UH0, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH0__get_IsUH0_1(this: UH0, unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def UH1__get_IsUH1_0(this: UH1, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH1__get_IsUH1_1(this: UH1, unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US0__get_IsUS0_0(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US0__get_IsUS0_1(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US1__get_IsUS1_0(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US1__get_IsUS1_1(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US2__get_IsUS2_0(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US2__get_IsUS2_1(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US3__get_IsUS3_0(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US3__get_IsUS3_1(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def UH2__get_IsUH2_0(this: UH2, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH2__get_IsUH2_1(this: UH2, unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US4__get_IsUS4_0(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US4__get_IsUS4_1(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US5__get_IsUS5_0(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US5__get_IsUS5_1(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def closure2(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def method0(v0_1: int64, v1_1: UH0, v2_1: UH0) -> UH0:
    if v1_1.tag == 1:
        return v2_1

    else: 
        v6: UH0 = method0(v0_1, v1_1.fields[1](None), v2_1)
        v11: int64 = op_addition(op_modulus(op_addition(op_subtraction(from_integer(v1_1.fields[0], False, 4), int64(1)), v0_1), v0_1), int64(1))
        def v13(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH0:
            return closure2(v6, None)

        return UH0(0, int(to_int(v11)+0x100 if to_int(v11) < 0 else to_int(v11)) & 0xFF, v13)



def closure1(v0_1: int64, v1_1: UH0) -> UH0:
    return method0(v0_1, v1_1, UH0(1))


def closure0(unit_var: None, v0_1: int64) -> Callable[[UH0], UH0]:
    def _arrow238(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow238


def closure4(unit_var: None, v0_1: Callable[[str], None]) -> US0:
    return US0(0, v0_1)


def method1(__unit: None=None) -> Callable[[Callable[[str], None]], US0]:
    def _arrow239(v: Callable[[str], None]) -> US0:
        return closure4(None, v)

    return _arrow239


def method2(v0_1_mut: UH1, v1_1_mut: UH1) -> UH1:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH1(1, v0_1.fields[0], v1_1)
            continue

        break


def method3(v0_1: UH1, v1_1: UH1) -> UH1:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return UH1(1, v0_1.fields[0], method3(v0_1.fields[1], v1_1))



def closure6(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def method4(v0_1: UH1, v1_1: UH0) -> UH0:
    if v0_1.tag == 0:
        return v1_1

    else: 
        v4_1: UH0 = method4(v0_1.fields[1], v1_1)
        def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
            return closure6(v4_1, None)

        return UH0(0, v0_1.fields[0], v5)



def closure7(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def closure8(v0_1: UH0, v1_1: Mut0, unit_var: None) -> UH0:
    v2_1: US1 = v1_1.l0
    if v2_1.tag == 0:
        v5: UH0 = v2_1.fields[0](None)
        v12: UH0 = UH0(1) if (v5.tag == 1) else UH0(0, v5.fields[0], method5(v0_1, v5.fields[1]))
        v1_1.l0 = US1(1, v12)
        return v12

    else: 
        return v2_1.fields[0]



def method5(v0_1: UH0, v1_1: Callable[[], UH0]) -> Callable[[], UH0]:
    v3_1: Mut0 = Mut0(US1(0, v1_1))
    def _arrow240(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure8(v0_1, v3_1, None)

    return _arrow240


def method7(v0_1_mut: int64, v1_1_mut: UH0) -> US2:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US2(1)

        elif v0_1 <= int64(0):
            return US2(0, v1_1.fields[0])

        else: 
            v0_1_mut = op_subtraction(v0_1, int64(1))
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method6(v0_1_mut: US0, v1_1_mut: Callable[[], UH0], v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut1, v5_mut: Mut2) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut, v5_mut)
        v10: str = to_text(interpolate("create_sequential_roller / roll / current_index: %P() / acc: %P() / len: %P() / last_item: %A%P()", [v2_1.l0, v3_1.l0, v4_1.l0, v5.l0]))
        if v0_1.tag == 0:
            v0_1.fields[0](v10)

        v12: UH0 = v1_1(None)
        v14: US2 = method7(v2_1.l0, v12)
        if v14.tag == 0:
            v15: uint8 = v14.fields[0]
            v17: int64 = op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v17
            v5.l0 = US2(0, v15)
            return v15

        else: 
            if v0_1.tag == 0:
                v0_1.fields[0]("create_sequential_roller / roll / None")

            if v4_1.l0 == int64(-1):
                v23: int64 = v2_1.l0
                v4_1.l0 = v23

            v29: int64 = int64(1) if (v3_1.l0 >= v4_1.l0) else op_addition(v3_1.l0, int64(1))
            v3_1.l0 = v29
            v31: int64 = op_subtraction(v3_1.l0, int64(1))
            v2_1.l0 = v31
            v5.l0 = US2(1)
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1
            v3_1_mut = v3_1
            v4_1_mut = v4_1
            v5_mut = v5
            continue

        break


def closure9(v0_1: US0, v1_1: Callable[[], UH0], v2_1: Mut1, v3_1: Mut1, v4_1: Mut1, v5: Mut2, unit_var: None) -> uint8:
    return method6(v0_1, v1_1, v2_1, v3_1, v4_1, v5)


def closure5(v0_1: US0, v1_1: UH1) -> Callable[[], uint8]:
    if v0_1.tag == 0:
        v0_1.fields[0]("create_sequential_roller ()")

    v8: UH0 = method4(method3(v1_1, method2(v1_1, UH1(0))), UH0(1))
    def v9(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure7(v8, None)

    v10: Callable[[], UH0] = method5(v8, v9)
    v11: Mut1 = Mut1(int64(0))
    v12: Mut1 = Mut1(int64(1))
    v13: Mut1 = Mut1(int64(-1))
    v15: Mut2 = Mut2(US2(1))
    def _arrow241(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint8:
        return closure9(v0_1, v10, v11, v12, v13, v15, None)

    return _arrow241


def closure3(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    v3_1: US0 = default_arg(map(method1(), v0_1), US0(1))
    def _arrow242(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[], uint8]:
        return closure5(v3_1, v)

    return _arrow242


def method8(v0_1_mut: US0, v1_1_mut: uint64, v2_1_mut: int8, v3_1_mut: uint64) -> int8:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v3_1 < v1_1:
            v5: uint64 = op_multiply(v3_1, uint64(6))
            if v5 > v3_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1 + int8(1)
                v3_1_mut = v5
                continue

            else: 
                if v0_1.tag == 0:
                    v0_1.fields[0](((((("calculate_dice_count / max: " + str(v1_1)) + " / n: ") + str(v2_1)) + " / p: ") + str(v3_1)) + "")

                return v2_1


        else: 
            if v0_1.tag == 0:
                v0_1.fields[0](((((("calculate_dice_count / max: " + str(v1_1)) + " / n: ") + str(v2_1)) + " / p: ") + str(v3_1)) + "")

            return v2_1

        break


def closure77(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure77(None, None)

    return UH2(0, uint64(0), v0_1)


def closure76(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure77(None, None)

    return UH2(0, uint64(9223372036854775808), v0_1)


def closure75(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure76(None, None)

    return UH2(0, uint64(4611686018427387904), v0_1)


def closure74(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure75(None, None)

    return UH2(0, uint64(6917529027641081856), v0_1)


def closure73(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure74(None, None)

    return UH2(0, uint64(1152921504606846976), v0_1)


def closure72(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure73(None, None)

    return UH2(0, uint64(15564440312192434176), v0_1)


def closure71(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure72(None, None)

    return UH2(0, uint64(11817445422220181504), v0_1)


def closure70(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure71(None, None)

    return UH2(0, uint64(5044031582654955520), v0_1)


def closure69(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure70(None, None)

    return UH2(0, uint64(6989586621679009792), v0_1)


def closure68(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure69(None, None)

    return UH2(0, uint64(16537217831704461312), v0_1)


def closure67(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure68(None, None)

    return UH2(0, uint64(11979575008805519360), v0_1)


def closure66(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure67(None, None)

    return UH2(0, uint64(14294425217273954304), v0_1)


def closure65(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure66(None, None)

    return UH2(0, uint64(2382404202878992384), v0_1)


def closure64(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure65(None, None)

    return UH2(0, uint64(6545982058383015936), v0_1)


def closure63(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure64(None, None)

    return UH2(0, uint64(10314369046585278464), v0_1)


def closure62(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure63(None, None)

    return UH2(0, uint64(4793518853382471680), v0_1)


def closure61(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure62(None, None)

    return UH2(0, uint64(3873377154515337216), v0_1)


def closure60(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure61(None, None)

    return UH2(0, uint64(645562859085889536), v0_1)


def closure59(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure60(None, None)

    return UH2(0, uint64(107593809847648256), v0_1)


def closure58(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure59(None, None)

    return UH2(0, uint64(3092389647259533312), v0_1)


def closure57(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure58(None, None)

    return UH2(0, uint64(9738770311398031360), v0_1)


def closure56(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure57(None, None)

    return UH2(0, uint64(16995415113324298240), v0_1)


def closure55(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure56(None, None)

    return UH2(0, uint64(8981483876790566912), v0_1)


def closure54(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure55(None, None)

    return UH2(0, uint64(13794743361938128896), v0_1)


def closure53(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure54(None, None)

    return UH2(0, uint64(2299123893656354816), v0_1)


def closure52(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure53(None, None)

    return UH2(0, uint64(3457644661227651072), v0_1)


def closure51(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure52(None, None)

    return UH2(0, uint64(576274110204608512), v0_1)


def closure50(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure51(None, None)

    return UH2(0, uint64(6244960376270618624), v0_1)


def closure49(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure50(None, None)

    return UH2(0, uint64(13338656111851470848), v0_1)


def closure48(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure49(None, None)

    return UH2(0, uint64(14520938734448279552), v0_1)


def closure47(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure48(None, None)

    return UH2(0, uint64(14717985838214414336), v0_1)


def closure46(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure47(None, None)

    return UH2(0, uint64(5527454985320660992), v0_1)


def closure45(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure46(None, None)

    return UH2(0, uint64(16293529225644736512), v0_1)


def closure44(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure45(None, None)

    return UH2(0, uint64(11938960241128898560), v0_1)


def closure43(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure44(None, None)

    return UH2(0, uint64(8138741398091333632), v0_1)


def closure42(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure43(None, None)

    return UH2(0, uint64(7505371590918406144), v0_1)


def closure41(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure42(None, None)

    return UH2(0, uint64(16623181993244360704), v0_1)


def closure40(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure41(None, None)

    return UH2(0, uint64(8919445023443910656), v0_1)


def closure39(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure40(None, None)

    return UH2(0, uint64(4561031516192243712), v0_1)


def closure38(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure39(None, None)

    return UH2(0, uint64(9983543956220149760), v0_1)


def closure37(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure38(None, None)

    return UH2(0, uint64(4738381338321616896), v0_1)


def closure36(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure37(None, None)

    return UH2(0, uint64(789730223053602816), v0_1)


def closure35(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure36(None, None)

    return UH2(0, uint64(131621703842267136), v0_1)


def closure34(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure35(None, None)

    return UH2(0, uint64(21936950640377856), v0_1)


def closure33(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure34(None, None)

    return UH2(0, uint64(3656158440062976), v0_1)


def closure32(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure33(None, None)

    return UH2(0, uint64(609359740010496), v0_1)


def closure31(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure32(None, None)

    return UH2(0, uint64(101559956668416), v0_1)


def closure30(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure31(None, None)

    return UH2(0, uint64(16926659444736), v0_1)


def closure29(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure30(None, None)

    return UH2(0, uint64(2821109907456), v0_1)


def closure28(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure29(None, None)

    return UH2(0, uint64(470184984576), v0_1)


def closure27(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure28(None, None)

    return UH2(0, uint64(78364164096), v0_1)


def closure26(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure27(None, None)

    return UH2(0, uint64(13060694016), v0_1)


def closure25(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure26(None, None)

    return UH2(0, uint64(2176782336), v0_1)


def closure24(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure25(None, None)

    return UH2(0, uint64(362797056), v0_1)


def closure23(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure24(None, None)

    return UH2(0, uint64(60466176), v0_1)


def closure22(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure23(None, None)

    return UH2(0, uint64(10077696), v0_1)


def closure21(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure22(None, None)

    return UH2(0, uint64(1679616), v0_1)


def closure20(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure21(None, None)

    return UH2(0, uint64(279936), v0_1)


def closure19(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure20(None, None)

    return UH2(0, uint64(46656), v0_1)


def closure18(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure19(None, None)

    return UH2(0, uint64(7776), v0_1)


def closure17(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure18(None, None)

    return UH2(0, uint64(1296), v0_1)


def closure16(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure17(None, None)

    return UH2(0, uint64(216), v0_1)


def closure15(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure16(None, None)

    return UH2(0, uint64(36), v0_1)


def closure14(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure15(None, None)

    return UH2(0, uint64(6), v0_1)


def method11(v0_1_mut: int8, v1_1_mut: UH2) -> US4:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US4(1)

        elif v0_1 <= int8(0):
            return US4(0, v1_1.fields[0])

        else: 
            v0_1_mut = v0_1 - int8(1)
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method10(v0_1_mut: US0, v1_1_mut: int8, v2_1_mut: UH1, v3_1_mut: uint64) -> US3:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v1_1 < int8(0):
            v5: uint64 = op_addition(v3_1, uint64(1))
            if v0_1.tag == 0:
                v0_1.fields[0](((((("accumulate_dice_rolls / power: " + str(v1_1)) + " / acc: ") + str(v3_1)) + " / result: ") + str(v5)) + "")

            return US3(0, v5, v2_1)

        elif v2_1.tag == 0:
            return US3(1)

        else: 
            v11: UH1 = v2_1.fields[1]
            v10: uint8 = v2_1.fields[0]
            if v10 > uint8(1):
                def v14(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> UH2:
                    return closure14(None, None)

                v16: US4 = method11(v1_1, UH2(0, uint64(1), v14))
                v20: uint64
                if v16.tag == 0:
                    v20 = v16.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v23: uint64 = op_multiply(from_integer(v10 - uint8(1), True, 4), v20)
                if v0_1.tag == 0:
                    v0_1.fields[0](((((((("accumulate_dice_rolls / power: " + str(v1_1)) + " / acc: ") + str(v3_1)) + " / roll: ") + str(v10)) + " / value: ") + str(v23)) + "")

                v0_1_mut = v0_1
                v1_1_mut = v1_1 - int8(1)
                v2_1_mut = v11
                v3_1_mut = op_addition(v3_1, v23)
                continue

            else: 
                if v0_1.tag == 0:
                    v0_1.fields[0](((((("accumulate_dice_rolls / power: " + str(v1_1)) + " / acc: ") + str(v3_1)) + " / roll: ") + str(v10)) + "")

                v0_1_mut = v0_1
                v1_1_mut = v1_1 - int8(1)
                v2_1_mut = v11
                v3_1_mut = v3_1
                continue


        break


def method12(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method12(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method13(v0_1_mut: US0, v1_1_mut: Callable[[], uint8], v2_1_mut: bool, v3_1_mut: uint64, v4_1_mut: int8, v5_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut, v5_mut)
        v6: int8 = (v4_1 + int8(1)) or 0
        if v4_1 < v6:
            return method9(v0_1, v1_1, v2_1, v3_1, v4_1, UH1(1, v1_1(None), v5), v6)

        else: 
            v12: US3 = method10(v0_1, v4_1, v5, uint64(0))
            if v12.tag == 0:
                v13: uint64 = v12.fields[0]
                if v13 <= v3_1:
                    return v13

                elif v2_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = v4_1
                    v5_mut = method12(v4_1, v1_1, int8(0))
                    continue

                else: 
                    return method9(v0_1, v1_1, v2_1, v3_1, v4_1, UH1(1, v1_1(None), v5), v6)


            elif v2_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = v4_1
                v5_mut = method12(v4_1, v1_1, int8(0))
                continue

            else: 
                return method9(v0_1, v1_1, v2_1, v3_1, v4_1, UH1(1, v1_1(None), v5), v6)


        break


def method9(v0_1_mut: US0, v1_1_mut: Callable[[], uint8], v2_1_mut: bool, v3_1_mut: uint64, v4_1_mut: int8, v5_mut: UH1, v6_mut: int8) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5, v6) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut, v5_mut, v6_mut)
        if v6 < (v4_1 + int8(1)):
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1
            v3_1_mut = v3_1
            v4_1_mut = v4_1
            v5_mut = UH1(1, v1_1(None), v5)
            v6_mut = v6 + int8(1)
            continue

        else: 
            v14: US3 = method10(v0_1, v4_1, v5, uint64(0))
            if v14.tag == 0:
                v15: uint64 = v14.fields[0]
                if v15 <= v3_1:
                    return v15

                elif v2_1:
                    return method13(v0_1, v1_1, v2_1, v3_1, v4_1, method12(v4_1, v1_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = v4_1
                    v5_mut = UH1(1, v1_1(None), v5)
                    v6_mut = v6 + int8(1)
                    continue


            elif v2_1:
                return method13(v0_1, v1_1, v2_1, v3_1, v4_1, method12(v4_1, v1_1, int8(0)))

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = v4_1
                v5_mut = UH1(1, v1_1(None), v5)
                v6_mut = v6 + int8(1)
                continue


        break


def closure13(v0_1: US0, v1_1: Callable[[], uint8], v2_1: bool, v3_1: uint64) -> uint64:
    return method9(v0_1, v1_1, v2_1, v3_1, (int8(1) if (v3_1 == uint64(1)) else method8(v0_1, v3_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure12(v0_1: US0, v1_1: Callable[[], uint8], v2_1: bool) -> Callable[[uint64], uint64]:
    def _arrow243(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> uint64:
        return closure13(v0_1, v1_1, v2_1, v)

    return _arrow243


def closure11(v0_1: US0, v1_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow244(v: bool, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[uint64], uint64]:
        return closure12(v0_1, v1_1, v)

    return _arrow244


def closure10(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    v3_1: US0 = default_arg(map(method1(), v0_1), US0(1))
    def _arrow245(v: Callable[[], uint8], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[bool, uint64], uint64]:
        return closure11(v3_1, v)

    return _arrow245


def method14(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = v1_1 + int8(1)
            continue

        break


def closure80(v0_1: Callable[[str], None] | None, v1_1: uint64, v2_1: UH1) -> uint64 | None:
    v10: US3 = method10(default_arg(map(method1(), v0_1), US0(1)), method14(v2_1, int8(0)) - int8(1), v2_1, uint64(0))
    v20: US4
    if v10.tag == 0:
        v11: uint64 = v10.fields[0]
        v20 = US4(0, v11) if ((v11 <= v1_1) if (v11 >= uint64(1)) else False) else US4(1)

    else: 
        v20 = US4(1)

    if v20.tag == 0:
        return v20.fields[0]

    else: 
        return None



def closure79(v0_1: Callable[[str], None] | None, v1_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow246(v: UH1, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64 | None:
        return closure80(v0_1, v1_1, v)

    return _arrow246


def closure78(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    def _arrow247(v: uint64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[UH1], uint64 | None]:
        return closure79(v0_1, v)

    return _arrow247


def method40(v0_1: UH1, v1_1: int64) -> US5:
    v2_1: int64 = op_addition(v1_1, int64(1))
    print(((((("accumulate_dice_rolls / power: " + str(int8(-1))) + " / acc: ") + str(v1_1)) + " / result: ") + str(v2_1)) + "")
    return US5(0, v2_1, v0_1)


def method39(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            print(((((((("accumulate_dice_rolls / power: " + str(int8(0))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v7)) + "")
            return method40(v4_1, op_addition(v1_1, v7))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(0))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method40(v4_1, v1_1)




def method38(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(1))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method39(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(1))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method39(v4_1, v1_1)




def method37(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(2))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method38(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(2))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method38(v4_1, v1_1)




def method36(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(3))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method37(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(3))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method37(v4_1, v1_1)




def method35(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(4))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method36(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(4))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method36(v4_1, v1_1)




def method34(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(5))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method35(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(5))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method35(v4_1, v1_1)




def method33(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(6))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method34(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(6))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method34(v4_1, v1_1)




def method32(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(7))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method33(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(7))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method33(v4_1, v1_1)




def method31(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(8))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method32(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(8))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method32(v4_1, v1_1)




def method30(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(9))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method31(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(9))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method31(v4_1, v1_1)




def method29(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(10))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method30(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(10))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method30(v4_1, v1_1)




def method28(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(11))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method29(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(11))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method29(v4_1, v1_1)




def method27(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(12))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method28(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(12))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method28(v4_1, v1_1)




def method26(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(13))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method27(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(13))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method27(v4_1, v1_1)




def method25(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(14))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method26(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(14))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method26(v4_1, v1_1)




def method24(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(15))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method25(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(15))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method25(v4_1, v1_1)




def method23(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(16))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method24(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(16))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method24(v4_1, v1_1)




def method22(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(17))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method23(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(17))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method23(v4_1, v1_1)




def method21(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(18))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method22(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(18))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method22(v4_1, v1_1)




def method20(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(19))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method21(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(19))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method21(v4_1, v1_1)




def method19(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(20))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method20(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(20))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method20(v4_1, v1_1)




def method18(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(21))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method19(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(21))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method19(v4_1, v1_1)




def method17(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(22))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method18(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(22))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method18(v4_1, v1_1)




def method16(v0_1: UH1, v1_1: int64) -> US5:
    if v0_1.tag == 0:
        return US5(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            print(((((((("accumulate_dice_rolls / power: " + str(int8(23))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + " / value: ") + str(v8)) + "")
            return method17(v4_1, op_addition(v1_1, v8))

        else: 
            print(((((("accumulate_dice_rolls / power: " + str(int8(23))) + " / acc: ") + str(v1_1)) + " / roll: ") + str(v3_1)) + "")
            return method17(v4_1, v1_1)




def method15(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            _v3: uint8 | None = None
            x: uint8
            value: int = randint(1, 7) or 0
            x = int(value+0x100 if value < 0 else value) & 0xFF
            _v3 = x
            v0_1_mut = UH1(1, value_47(_v3), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v18: US5 = method16(v0_1, int64(0))
            if v18.tag == 0:
                v19: int64 = v18.fields[0]
                if v19 <= int64(9223372036854775807):
                    return v19

                else: 
                    _v22: uint8 | None = None
                    x_1: uint8
                    value_1: int = randint(1, 7) or 0
                    x_1 = int(value_1+0x100 if value_1 < 0 else value_1) & 0xFF
                    _v22 = x_1
                    v32: uint8 = value_47(_v22)
                    _v33: uint8 | None = None
                    x_2: uint8
                    value_2: int = randint(1, 7) or 0
                    x_2 = int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF
                    _v33 = x_2
                    v41: uint8 = value_47(_v33)
                    _v42: uint8 | None = None
                    x_3: uint8
                    value_3: int = randint(1, 7) or 0
                    x_3 = int(value_3+0x100 if value_3 < 0 else value_3) & 0xFF
                    _v42 = x_3
                    v50: uint8 = value_47(_v42)
                    _v51: uint8 | None = None
                    x_4: uint8
                    value_4: int = randint(1, 7) or 0
                    x_4 = int(value_4+0x100 if value_4 < 0 else value_4) & 0xFF
                    _v51 = x_4
                    v59: uint8 = value_47(_v51)
                    _v60: uint8 | None = None
                    x_5: uint8
                    value_5: int = randint(1, 7) or 0
                    x_5 = int(value_5+0x100 if value_5 < 0 else value_5) & 0xFF
                    _v60 = x_5
                    v68: uint8 = value_47(_v60)
                    _v69: uint8 | None = None
                    x_6: uint8
                    value_6: int = randint(1, 7) or 0
                    x_6 = int(value_6+0x100 if value_6 < 0 else value_6) & 0xFF
                    _v69 = x_6
                    v77: uint8 = value_47(_v69)
                    _v78: uint8 | None = None
                    x_7: uint8
                    value_7: int = randint(1, 7) or 0
                    x_7 = int(value_7+0x100 if value_7 < 0 else value_7) & 0xFF
                    _v78 = x_7
                    v86: uint8 = value_47(_v78)
                    _v87: uint8 | None = None
                    x_8: uint8
                    value_8: int = randint(1, 7) or 0
                    x_8 = int(value_8+0x100 if value_8 < 0 else value_8) & 0xFF
                    _v87 = x_8
                    v95: uint8 = value_47(_v87)
                    _v96: uint8 | None = None
                    x_9: uint8
                    value_9: int = randint(1, 7) or 0
                    x_9 = int(value_9+0x100 if value_9 < 0 else value_9) & 0xFF
                    _v96 = x_9
                    v104: uint8 = value_47(_v96)
                    _v105: uint8 | None = None
                    x_10: uint8
                    value_10: int = randint(1, 7) or 0
                    x_10 = int(value_10+0x100 if value_10 < 0 else value_10) & 0xFF
                    _v105 = x_10
                    v113: uint8 = value_47(_v105)
                    _v114: uint8 | None = None
                    x_11: uint8
                    value_11: int = randint(1, 7) or 0
                    x_11 = int(value_11+0x100 if value_11 < 0 else value_11) & 0xFF
                    _v114 = x_11
                    v122: uint8 = value_47(_v114)
                    _v123: uint8 | None = None
                    x_12: uint8
                    value_12: int = randint(1, 7) or 0
                    x_12 = int(value_12+0x100 if value_12 < 0 else value_12) & 0xFF
                    _v123 = x_12
                    v131: uint8 = value_47(_v123)
                    _v132: uint8 | None = None
                    x_13: uint8
                    value_13: int = randint(1, 7) or 0
                    x_13 = int(value_13+0x100 if value_13 < 0 else value_13) & 0xFF
                    _v132 = x_13
                    v140: uint8 = value_47(_v132)
                    _v141: uint8 | None = None
                    x_14: uint8
                    value_14: int = randint(1, 7) or 0
                    x_14 = int(value_14+0x100 if value_14 < 0 else value_14) & 0xFF
                    _v141 = x_14
                    v149: uint8 = value_47(_v141)
                    _v150: uint8 | None = None
                    x_15: uint8
                    value_15: int = randint(1, 7) or 0
                    x_15 = int(value_15+0x100 if value_15 < 0 else value_15) & 0xFF
                    _v150 = x_15
                    v158: uint8 = value_47(_v150)
                    _v159: uint8 | None = None
                    x_16: uint8
                    value_16: int = randint(1, 7) or 0
                    x_16 = int(value_16+0x100 if value_16 < 0 else value_16) & 0xFF
                    _v159 = x_16
                    v167: uint8 = value_47(_v159)
                    _v168: uint8 | None = None
                    x_17: uint8
                    value_17: int = randint(1, 7) or 0
                    x_17 = int(value_17+0x100 if value_17 < 0 else value_17) & 0xFF
                    _v168 = x_17
                    v176: uint8 = value_47(_v168)
                    _v177: uint8 | None = None
                    x_18: uint8
                    value_18: int = randint(1, 7) or 0
                    x_18 = int(value_18+0x100 if value_18 < 0 else value_18) & 0xFF
                    _v177 = x_18
                    v185: uint8 = value_47(_v177)
                    _v186: uint8 | None = None
                    x_19: uint8
                    value_19: int = randint(1, 7) or 0
                    x_19 = int(value_19+0x100 if value_19 < 0 else value_19) & 0xFF
                    _v186 = x_19
                    v194: uint8 = value_47(_v186)
                    _v195: uint8 | None = None
                    x_20: uint8
                    value_20: int = randint(1, 7) or 0
                    x_20 = int(value_20+0x100 if value_20 < 0 else value_20) & 0xFF
                    _v195 = x_20
                    v203: uint8 = value_47(_v195)
                    _v204: uint8 | None = None
                    x_21: uint8
                    value_21: int = randint(1, 7) or 0
                    x_21 = int(value_21+0x100 if value_21 < 0 else value_21) & 0xFF
                    _v204 = x_21
                    v212: uint8 = value_47(_v204)
                    _v213: uint8 | None = None
                    x_22: uint8
                    value_22: int = randint(1, 7) or 0
                    x_22 = int(value_22+0x100 if value_22 < 0 else value_22) & 0xFF
                    _v213 = x_22
                    v221: uint8 = value_47(_v213)
                    _v222: uint8 | None = None
                    x_23: uint8
                    value_23: int = randint(1, 7) or 0
                    x_23 = int(value_23+0x100 if value_23 < 0 else value_23) & 0xFF
                    _v222 = x_23
                    v0_1_mut = UH1(1, v32, UH1(1, v41, UH1(1, v50, UH1(1, v59, UH1(1, v68, UH1(1, v77, UH1(1, v86, UH1(1, v95, UH1(1, v104, UH1(1, v113, UH1(1, v122, UH1(1, v131, UH1(1, v140, UH1(1, v149, UH1(1, v158, UH1(1, v167, UH1(1, v176, UH1(1, v185, UH1(1, v194, UH1(1, v203, UH1(1, v212, UH1(1, v221, UH1(1, value_47(_v222), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                _v258: uint8 | None = None
                x_24: uint8
                value_24: int = randint(1, 7) or 0
                x_24 = int(value_24+0x100 if value_24 < 0 else value_24) & 0xFF
                _v258 = x_24
                v268: uint8 = value_47(_v258)
                _v269: uint8 | None = None
                x_25: uint8
                value_25: int = randint(1, 7) or 0
                x_25 = int(value_25+0x100 if value_25 < 0 else value_25) & 0xFF
                _v269 = x_25
                v277: uint8 = value_47(_v269)
                _v278: uint8 | None = None
                x_26: uint8
                value_26: int = randint(1, 7) or 0
                x_26 = int(value_26+0x100 if value_26 < 0 else value_26) & 0xFF
                _v278 = x_26
                v286: uint8 = value_47(_v278)
                _v287: uint8 | None = None
                x_27: uint8
                value_27: int = randint(1, 7) or 0
                x_27 = int(value_27+0x100 if value_27 < 0 else value_27) & 0xFF
                _v287 = x_27
                v295: uint8 = value_47(_v287)
                _v296: uint8 | None = None
                x_28: uint8
                value_28: int = randint(1, 7) or 0
                x_28 = int(value_28+0x100 if value_28 < 0 else value_28) & 0xFF
                _v296 = x_28
                v304: uint8 = value_47(_v296)
                _v305: uint8 | None = None
                x_29: uint8
                value_29: int = randint(1, 7) or 0
                x_29 = int(value_29+0x100 if value_29 < 0 else value_29) & 0xFF
                _v305 = x_29
                v313: uint8 = value_47(_v305)
                _v314: uint8 | None = None
                x_30: uint8
                value_30: int = randint(1, 7) or 0
                x_30 = int(value_30+0x100 if value_30 < 0 else value_30) & 0xFF
                _v314 = x_30
                v322: uint8 = value_47(_v314)
                _v323: uint8 | None = None
                x_31: uint8
                value_31: int = randint(1, 7) or 0
                x_31 = int(value_31+0x100 if value_31 < 0 else value_31) & 0xFF
                _v323 = x_31
                v331: uint8 = value_47(_v323)
                _v332: uint8 | None = None
                x_32: uint8
                value_32: int = randint(1, 7) or 0
                x_32 = int(value_32+0x100 if value_32 < 0 else value_32) & 0xFF
                _v332 = x_32
                v340: uint8 = value_47(_v332)
                _v341: uint8 | None = None
                x_33: uint8
                value_33: int = randint(1, 7) or 0
                x_33 = int(value_33+0x100 if value_33 < 0 else value_33) & 0xFF
                _v341 = x_33
                v349: uint8 = value_47(_v341)
                _v350: uint8 | None = None
                x_34: uint8
                value_34: int = randint(1, 7) or 0
                x_34 = int(value_34+0x100 if value_34 < 0 else value_34) & 0xFF
                _v350 = x_34
                v358: uint8 = value_47(_v350)
                _v359: uint8 | None = None
                x_35: uint8
                value_35: int = randint(1, 7) or 0
                x_35 = int(value_35+0x100 if value_35 < 0 else value_35) & 0xFF
                _v359 = x_35
                v367: uint8 = value_47(_v359)
                _v368: uint8 | None = None
                x_36: uint8
                value_36: int = randint(1, 7) or 0
                x_36 = int(value_36+0x100 if value_36 < 0 else value_36) & 0xFF
                _v368 = x_36
                v376: uint8 = value_47(_v368)
                _v377: uint8 | None = None
                x_37: uint8
                value_37: int = randint(1, 7) or 0
                x_37 = int(value_37+0x100 if value_37 < 0 else value_37) & 0xFF
                _v377 = x_37
                v385: uint8 = value_47(_v377)
                _v386: uint8 | None = None
                x_38: uint8
                value_38: int = randint(1, 7) or 0
                x_38 = int(value_38+0x100 if value_38 < 0 else value_38) & 0xFF
                _v386 = x_38
                v394: uint8 = value_47(_v386)
                _v395: uint8 | None = None
                x_39: uint8
                value_39: int = randint(1, 7) or 0
                x_39 = int(value_39+0x100 if value_39 < 0 else value_39) & 0xFF
                _v395 = x_39
                v403: uint8 = value_47(_v395)
                _v404: uint8 | None = None
                x_40: uint8
                value_40: int = randint(1, 7) or 0
                x_40 = int(value_40+0x100 if value_40 < 0 else value_40) & 0xFF
                _v404 = x_40
                v412: uint8 = value_47(_v404)
                _v413: uint8 | None = None
                x_41: uint8
                value_41: int = randint(1, 7) or 0
                x_41 = int(value_41+0x100 if value_41 < 0 else value_41) & 0xFF
                _v413 = x_41
                v421: uint8 = value_47(_v413)
                _v422: uint8 | None = None
                x_42: uint8
                value_42: int = randint(1, 7) or 0
                x_42 = int(value_42+0x100 if value_42 < 0 else value_42) & 0xFF
                _v422 = x_42
                v430: uint8 = value_47(_v422)
                _v431: uint8 | None = None
                x_43: uint8
                value_43: int = randint(1, 7) or 0
                x_43 = int(value_43+0x100 if value_43 < 0 else value_43) & 0xFF
                _v431 = x_43
                v439: uint8 = value_47(_v431)
                _v440: uint8 | None = None
                x_44: uint8
                value_44: int = randint(1, 7) or 0
                x_44 = int(value_44+0x100 if value_44 < 0 else value_44) & 0xFF
                _v440 = x_44
                v448: uint8 = value_47(_v440)
                _v449: uint8 | None = None
                x_45: uint8
                value_45: int = randint(1, 7) or 0
                x_45 = int(value_45+0x100 if value_45 < 0 else value_45) & 0xFF
                _v449 = x_45
                v457: uint8 = value_47(_v449)
                _v458: uint8 | None = None
                x_46: uint8
                value_46: int = randint(1, 7) or 0
                x_46 = int(value_46+0x100 if value_46 < 0 else value_46) & 0xFF
                _v458 = x_46
                v0_1_mut = UH1(1, v268, UH1(1, v277, UH1(1, v286, UH1(1, v295, UH1(1, v304, UH1(1, v313, UH1(1, v322, UH1(1, v331, UH1(1, v340, UH1(1, v349, UH1(1, v358, UH1(1, v367, UH1(1, v376, UH1(1, v385, UH1(1, v394, UH1(1, v403, UH1(1, v412, UH1(1, v421, UH1(1, v430, UH1(1, v439, UH1(1, v448, UH1(1, v457, UH1(1, value_47(_v458), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def closure81(unit_var: None, v0_1: Array[str]) -> int:
    print(((((("calculate_dice_count / max: " + str(int64(9223372036854775807))) + " / n: ") + str(int8(24))) + " / p: ") + str(int64(4738381338321616896))) + "")
    print(("result: " + str(method15(UH1(0), int8(0)))) + "")
    return 0


def _arrow248(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow248

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow249(v: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    return closure3(None, v)


v1: Callable[[Callable[[str], None] | None, UH1, None], uint8] = _arrow249

def create_sequential_roller(x: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    return v1(x)


def _arrow250(v: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    return closure10(None, v)


v2: Callable[[Callable[[str], None] | None, Callable[[], uint8], bool, uint64], uint64] = _arrow250

def roll_progressively(x: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    return v2(x)


def _arrow251(v: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    return closure78(None, v)


v3: Callable[[Callable[[str], None] | None, uint64, UH1], uint64 | None] = _arrow251

def roll_within_bounds(x: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    return v3(x)


def _arrow252(v: Array[str]) -> int:
    return closure81(None, v)


v4: Callable[[Array[str]], int] = _arrow252

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


