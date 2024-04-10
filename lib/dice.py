from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
import sys
from typing import Any
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, op_multiply)
from fable_modules.fable_library.option import (default_arg, map, value)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, string_type, record_type, int64_type, uint64_type)
from fable_modules.fable_library.string_ import (to_text, interpolate)
from fable_modules.fable_library.types import (Array, Union, Record, int64, FSharpRef, uint8, uint64, int8)

def _expr108() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr108

def _expr109() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr109

def _expr110() -> TypeInfo:
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


US0_reflection = _expr110

def _expr111() -> TypeInfo:
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


US1_reflection = _expr111

def _expr112() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US1_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: US1

Mut0_reflection = _expr112

def _expr113() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr113

def _expr114() -> TypeInfo:
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


US2_reflection = _expr114

def _expr115() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", US2_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US2

Mut2_reflection = _expr115

def _expr116() -> TypeInfo:
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


US3_reflection = _expr116

def _expr117() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr117

def _expr118() -> TypeInfo:
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


US4_reflection = _expr118

def _expr119() -> TypeInfo:
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


US5_reflection = _expr119

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
    def _arrow120(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow120


def closure4(unit_var: None, v0_1: Callable[[str], None]) -> US0:
    return US0(0, v0_1)


def method1(__unit: None=None) -> Callable[[Callable[[str], None]], US0]:
    def _arrow121(v: Callable[[str], None]) -> US0:
        return closure4(None, v)

    return _arrow121


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
    def _arrow122(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure8(v0_1, v3_1, None)

    return _arrow122


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
    def _arrow123(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint8:
        return closure9(v0_1, v10, v11, v12, v13, v15, None)

    return _arrow123


def closure3(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    v3_1: US0 = default_arg(map(method1(), v0_1), US0(1))
    def _arrow124(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[], uint8]:
        return closure5(v3_1, v)

    return _arrow124


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
    def _arrow125(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> uint64:
        return closure13(v0_1, v1_1, v2_1, v)

    return _arrow125


def closure11(v0_1: US0, v1_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow126(v: bool, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[uint64], uint64]:
        return closure12(v0_1, v1_1, v)

    return _arrow126


def closure10(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    v3_1: US0 = default_arg(map(method1(), v0_1), US0(1))
    def _arrow127(v: Callable[[], uint8], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[bool, uint64], uint64]:
        return closure11(v3_1, v)

    return _arrow127


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
    def _arrow128(v: UH1, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64 | None:
        return closure80(v0_1, v1_1, v)

    return _arrow128


def closure78(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    def _arrow129(v: uint64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[UH1], uint64 | None]:
        return closure79(v0_1, v)

    return _arrow129


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
            _v3 = uint8(0)
            v0_1_mut = UH1(1, value(_v3), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v16: US5 = method16(v0_1, int64(0))
            if v16.tag == 0:
                v17: int64 = v16.fields[0]
                if v17 <= int64(9223372036854775807):
                    return v17

                else: 
                    _v20: uint8 | None = None
                    _v20 = uint8(0)
                    v28: uint8 = value(_v20)
                    _v29: uint8 | None = None
                    _v29 = uint8(0)
                    v35: uint8 = value(_v29)
                    _v36: uint8 | None = None
                    _v36 = uint8(0)
                    v42: uint8 = value(_v36)
                    _v43: uint8 | None = None
                    _v43 = uint8(0)
                    v49: uint8 = value(_v43)
                    _v50: uint8 | None = None
                    _v50 = uint8(0)
                    v56: uint8 = value(_v50)
                    _v57: uint8 | None = None
                    _v57 = uint8(0)
                    v63: uint8 = value(_v57)
                    _v64: uint8 | None = None
                    _v64 = uint8(0)
                    v70: uint8 = value(_v64)
                    _v71: uint8 | None = None
                    _v71 = uint8(0)
                    v77: uint8 = value(_v71)
                    _v78: uint8 | None = None
                    _v78 = uint8(0)
                    v84: uint8 = value(_v78)
                    _v85: uint8 | None = None
                    _v85 = uint8(0)
                    v91: uint8 = value(_v85)
                    _v92: uint8 | None = None
                    _v92 = uint8(0)
                    v98: uint8 = value(_v92)
                    _v99: uint8 | None = None
                    _v99 = uint8(0)
                    v105: uint8 = value(_v99)
                    _v106: uint8 | None = None
                    _v106 = uint8(0)
                    v112: uint8 = value(_v106)
                    _v113: uint8 | None = None
                    _v113 = uint8(0)
                    v119: uint8 = value(_v113)
                    _v120: uint8 | None = None
                    _v120 = uint8(0)
                    v126: uint8 = value(_v120)
                    _v127: uint8 | None = None
                    _v127 = uint8(0)
                    v133: uint8 = value(_v127)
                    _v134: uint8 | None = None
                    _v134 = uint8(0)
                    v140: uint8 = value(_v134)
                    _v141: uint8 | None = None
                    _v141 = uint8(0)
                    v147: uint8 = value(_v141)
                    _v148: uint8 | None = None
                    _v148 = uint8(0)
                    v154: uint8 = value(_v148)
                    _v155: uint8 | None = None
                    _v155 = uint8(0)
                    v161: uint8 = value(_v155)
                    _v162: uint8 | None = None
                    _v162 = uint8(0)
                    v168: uint8 = value(_v162)
                    _v169: uint8 | None = None
                    _v169 = uint8(0)
                    v175: uint8 = value(_v169)
                    _v176: uint8 | None = None
                    _v176 = uint8(0)
                    v0_1_mut = UH1(1, v28, UH1(1, v35, UH1(1, v42, UH1(1, v49, UH1(1, v56, UH1(1, v63, UH1(1, v70, UH1(1, v77, UH1(1, v84, UH1(1, v91, UH1(1, v98, UH1(1, v105, UH1(1, v112, UH1(1, v119, UH1(1, v126, UH1(1, v133, UH1(1, v140, UH1(1, v147, UH1(1, v154, UH1(1, v161, UH1(1, v168, UH1(1, v175, UH1(1, value(_v176), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                _v210: uint8 | None = None
                _v210 = uint8(0)
                v218: uint8 = value(_v210)
                _v219: uint8 | None = None
                _v219 = uint8(0)
                v225: uint8 = value(_v219)
                _v226: uint8 | None = None
                _v226 = uint8(0)
                v232: uint8 = value(_v226)
                _v233: uint8 | None = None
                _v233 = uint8(0)
                v239: uint8 = value(_v233)
                _v240: uint8 | None = None
                _v240 = uint8(0)
                v246: uint8 = value(_v240)
                _v247: uint8 | None = None
                _v247 = uint8(0)
                v253: uint8 = value(_v247)
                _v254: uint8 | None = None
                _v254 = uint8(0)
                v260: uint8 = value(_v254)
                _v261: uint8 | None = None
                _v261 = uint8(0)
                v267: uint8 = value(_v261)
                _v268: uint8 | None = None
                _v268 = uint8(0)
                v274: uint8 = value(_v268)
                _v275: uint8 | None = None
                _v275 = uint8(0)
                v281: uint8 = value(_v275)
                _v282: uint8 | None = None
                _v282 = uint8(0)
                v288: uint8 = value(_v282)
                _v289: uint8 | None = None
                _v289 = uint8(0)
                v295: uint8 = value(_v289)
                _v296: uint8 | None = None
                _v296 = uint8(0)
                v302: uint8 = value(_v296)
                _v303: uint8 | None = None
                _v303 = uint8(0)
                v309: uint8 = value(_v303)
                _v310: uint8 | None = None
                _v310 = uint8(0)
                v316: uint8 = value(_v310)
                _v317: uint8 | None = None
                _v317 = uint8(0)
                v323: uint8 = value(_v317)
                _v324: uint8 | None = None
                _v324 = uint8(0)
                v330: uint8 = value(_v324)
                _v331: uint8 | None = None
                _v331 = uint8(0)
                v337: uint8 = value(_v331)
                _v338: uint8 | None = None
                _v338 = uint8(0)
                v344: uint8 = value(_v338)
                _v345: uint8 | None = None
                _v345 = uint8(0)
                v351: uint8 = value(_v345)
                _v352: uint8 | None = None
                _v352 = uint8(0)
                v358: uint8 = value(_v352)
                _v359: uint8 | None = None
                _v359 = uint8(0)
                v365: uint8 = value(_v359)
                _v366: uint8 | None = None
                _v366 = uint8(0)
                v0_1_mut = UH1(1, v218, UH1(1, v225, UH1(1, v232, UH1(1, v239, UH1(1, v246, UH1(1, v253, UH1(1, v260, UH1(1, v267, UH1(1, v274, UH1(1, v281, UH1(1, v288, UH1(1, v295, UH1(1, v302, UH1(1, v309, UH1(1, v316, UH1(1, v323, UH1(1, v330, UH1(1, v337, UH1(1, v344, UH1(1, v351, UH1(1, v358, UH1(1, v365, UH1(1, value(_v366), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def closure81(unit_var: None, v0_1: Array[str]) -> int:
    print(((((("calculate_dice_count / max: " + str(int64(9223372036854775807))) + " / n: ") + str(int8(24))) + " / p: ") + str(int64(4738381338321616896))) + "")
    print(("result: " + str(method15(UH1(0), int8(0)))) + "")
    return 0


def _arrow130(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow130

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow131(v: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    return closure3(None, v)


v1: Callable[[Callable[[str], None] | None, UH1, None], uint8] = _arrow131

def create_sequential_roller(x: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    return v1(x)


def _arrow132(v: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    return closure10(None, v)


v2: Callable[[Callable[[str], None] | None, Callable[[], uint8], bool, uint64], uint64] = _arrow132

def roll_progressively(x: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    return v2(x)


def _arrow133(v: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    return closure78(None, v)


v3: Callable[[Callable[[str], None] | None, uint64, UH1], uint64 | None] = _arrow133

def roll_within_bounds(x: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    return v3(x)


def _arrow134(v: Array[str]) -> int:
    return closure81(None, v)


v4: Callable[[Array[str]], int] = _arrow134

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


