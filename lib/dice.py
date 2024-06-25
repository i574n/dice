from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
import sys
from typing import Any
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, op_multiply)
from fable_modules.fable_library.option import default_arg
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, string_type, record_type, int64_type, uint64_type)
from fable_modules.fable_library.string_ import (to_text, interpolate)
from fable_modules.fable_library.types import (Array, Union, Record, int64, FSharpRef, uint8, uint64, int8)
from fable_modules.fable_library.util import randint

def _expr304() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr304

def _expr305() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr305

def _expr306() -> TypeInfo:
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


US0_reflection = _expr306

def _expr307() -> TypeInfo:
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


US1_reflection = _expr307

def _expr308() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US1_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: US1

Mut0_reflection = _expr308

def _expr309() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr309

def _expr310() -> TypeInfo:
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


US2_reflection = _expr310

def _expr311() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", US2_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US2

Mut2_reflection = _expr311

def _expr312() -> TypeInfo:
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


US3_reflection = _expr312

def _expr313() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr313

def _expr314() -> TypeInfo:
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


US4_reflection = _expr314

def _expr315() -> TypeInfo:
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


US5_reflection = _expr315

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
    def _arrow316(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow316


def method1(v0_1_mut: UH1, v1_1_mut: UH1) -> UH1:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH1(1, v0_1.fields[0], v1_1)
            continue

        break


def method2(v0_1: UH1, v1_1: UH1) -> UH1:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return UH1(1, v0_1.fields[0], method2(v0_1.fields[1], v1_1))



def closure5(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def method3(v0_1: UH1, v1_1: UH0) -> UH0:
    if v0_1.tag == 0:
        return v1_1

    else: 
        v4_1: UH0 = method3(v0_1.fields[1], v1_1)
        def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
            return closure5(v4_1, None)

        return UH0(0, v0_1.fields[0], v5)



def closure6(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def closure7(v0_1: UH0, v1_1: Mut0, unit_var: None) -> UH0:
    v2_1: US1 = v1_1.l0
    if v2_1.tag == 0:
        v5: UH0 = v2_1.fields[0](None)
        v12: UH0 = UH0(1) if (v5.tag == 1) else UH0(0, v5.fields[0], method4(v0_1, v5.fields[1]))
        v1_1.l0 = US1(1, v12)
        return v12

    else: 
        return v2_1.fields[0]



def method4(v0_1: UH0, v1_1: Callable[[], UH0]) -> Callable[[], UH0]:
    v3_1: Mut0 = Mut0(US1(0, v1_1))
    def _arrow317(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure7(v0_1, v3_1, None)

    return _arrow317


def method6(v0_1_mut: int64, v1_1_mut: UH0) -> US2:
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


def method5(v0_1_mut: US0, v1_1_mut: Callable[[], UH0], v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut1, v5_mut: Mut2) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut, v5_mut)
        v10: str = to_text(interpolate("create_sequential_roller / roll / current_index: %P() / acc: %P() / len: %P() / last_item: %A%P()", [v2_1.l0, v3_1.l0, v4_1.l0, v5.l0]))
        if v0_1.tag == 0:
            v0_1.fields[0](v10)

        v12: UH0 = v1_1(None)
        v14: US2 = method6(v2_1.l0, v12)
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


def closure8(v0_1: US0, v1_1: Callable[[], UH0], v2_1: Mut1, v3_1: Mut1, v4_1: Mut1, v5: Mut2, unit_var: None) -> uint8:
    return method5(v0_1, v1_1, v2_1, v3_1, v4_1, v5)


def closure4(v0_1: US0, v1_1: UH1) -> Callable[[], uint8]:
    if v0_1.tag == 0:
        v0_1.fields[0]("create_sequential_roller ()")

    v8: UH0 = method3(method2(v1_1, method1(v1_1, UH1(0))), UH0(1))
    def v9(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure6(v8, None)

    v10: Callable[[], UH0] = method4(v8, v9)
    v11: Mut1 = Mut1(int64(0))
    v12: Mut1 = Mut1(int64(1))
    v13: Mut1 = Mut1(int64(-1))
    v15: Mut2 = Mut2(US2(1))
    def _arrow318(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint8:
        return closure8(v0_1, v10, v11, v12, v13, v15, None)

    return _arrow318


def closure3(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    _v1: FSharpRef[US0 | None] = FSharpRef(None)
    x_2: US0 | None
    if v0_1 is None:
        x_2 = None

    else: 
        x: Callable[[str], None] = v0_1
        def x_1(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> US0:
            return US0(0, x)

        x_2 = x_1(None)

    _v1.contents = x_2
    v6: US0 = default_arg(_v1.contents, US0(1))
    def _arrow319(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[], uint8]:
        return closure4(v6, v)

    return _arrow319


def method7(v0_1_mut: US0, v1_1_mut: uint64, v2_1_mut: int8, v3_1_mut: uint64) -> int8:
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


def closure76(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure76(None, None)

    return UH2(0, uint64(0), v0_1)


def closure75(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure76(None, None)

    return UH2(0, uint64(9223372036854775808), v0_1)


def closure74(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure75(None, None)

    return UH2(0, uint64(4611686018427387904), v0_1)


def closure73(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure74(None, None)

    return UH2(0, uint64(6917529027641081856), v0_1)


def closure72(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure73(None, None)

    return UH2(0, uint64(1152921504606846976), v0_1)


def closure71(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure72(None, None)

    return UH2(0, uint64(15564440312192434176), v0_1)


def closure70(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure71(None, None)

    return UH2(0, uint64(11817445422220181504), v0_1)


def closure69(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure70(None, None)

    return UH2(0, uint64(5044031582654955520), v0_1)


def closure68(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure69(None, None)

    return UH2(0, uint64(6989586621679009792), v0_1)


def closure67(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure68(None, None)

    return UH2(0, uint64(16537217831704461312), v0_1)


def closure66(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure67(None, None)

    return UH2(0, uint64(11979575008805519360), v0_1)


def closure65(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure66(None, None)

    return UH2(0, uint64(14294425217273954304), v0_1)


def closure64(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure65(None, None)

    return UH2(0, uint64(2382404202878992384), v0_1)


def closure63(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure64(None, None)

    return UH2(0, uint64(6545982058383015936), v0_1)


def closure62(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure63(None, None)

    return UH2(0, uint64(10314369046585278464), v0_1)


def closure61(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure62(None, None)

    return UH2(0, uint64(4793518853382471680), v0_1)


def closure60(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure61(None, None)

    return UH2(0, uint64(3873377154515337216), v0_1)


def closure59(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure60(None, None)

    return UH2(0, uint64(645562859085889536), v0_1)


def closure58(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure59(None, None)

    return UH2(0, uint64(107593809847648256), v0_1)


def closure57(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure58(None, None)

    return UH2(0, uint64(3092389647259533312), v0_1)


def closure56(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure57(None, None)

    return UH2(0, uint64(9738770311398031360), v0_1)


def closure55(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure56(None, None)

    return UH2(0, uint64(16995415113324298240), v0_1)


def closure54(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure55(None, None)

    return UH2(0, uint64(8981483876790566912), v0_1)


def closure53(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure54(None, None)

    return UH2(0, uint64(13794743361938128896), v0_1)


def closure52(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure53(None, None)

    return UH2(0, uint64(2299123893656354816), v0_1)


def closure51(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure52(None, None)

    return UH2(0, uint64(3457644661227651072), v0_1)


def closure50(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure51(None, None)

    return UH2(0, uint64(576274110204608512), v0_1)


def closure49(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure50(None, None)

    return UH2(0, uint64(6244960376270618624), v0_1)


def closure48(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure49(None, None)

    return UH2(0, uint64(13338656111851470848), v0_1)


def closure47(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure48(None, None)

    return UH2(0, uint64(14520938734448279552), v0_1)


def closure46(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure47(None, None)

    return UH2(0, uint64(14717985838214414336), v0_1)


def closure45(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure46(None, None)

    return UH2(0, uint64(5527454985320660992), v0_1)


def closure44(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure45(None, None)

    return UH2(0, uint64(16293529225644736512), v0_1)


def closure43(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure44(None, None)

    return UH2(0, uint64(11938960241128898560), v0_1)


def closure42(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure43(None, None)

    return UH2(0, uint64(8138741398091333632), v0_1)


def closure41(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure42(None, None)

    return UH2(0, uint64(7505371590918406144), v0_1)


def closure40(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure41(None, None)

    return UH2(0, uint64(16623181993244360704), v0_1)


def closure39(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure40(None, None)

    return UH2(0, uint64(8919445023443910656), v0_1)


def closure38(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure39(None, None)

    return UH2(0, uint64(4561031516192243712), v0_1)


def closure37(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure38(None, None)

    return UH2(0, uint64(9983543956220149760), v0_1)


def closure36(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure37(None, None)

    return UH2(0, uint64(4738381338321616896), v0_1)


def closure35(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure36(None, None)

    return UH2(0, uint64(789730223053602816), v0_1)


def closure34(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure35(None, None)

    return UH2(0, uint64(131621703842267136), v0_1)


def closure33(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure34(None, None)

    return UH2(0, uint64(21936950640377856), v0_1)


def closure32(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure33(None, None)

    return UH2(0, uint64(3656158440062976), v0_1)


def closure31(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure32(None, None)

    return UH2(0, uint64(609359740010496), v0_1)


def closure30(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure31(None, None)

    return UH2(0, uint64(101559956668416), v0_1)


def closure29(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure30(None, None)

    return UH2(0, uint64(16926659444736), v0_1)


def closure28(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure29(None, None)

    return UH2(0, uint64(2821109907456), v0_1)


def closure27(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure28(None, None)

    return UH2(0, uint64(470184984576), v0_1)


def closure26(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure27(None, None)

    return UH2(0, uint64(78364164096), v0_1)


def closure25(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure26(None, None)

    return UH2(0, uint64(13060694016), v0_1)


def closure24(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure25(None, None)

    return UH2(0, uint64(2176782336), v0_1)


def closure23(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure24(None, None)

    return UH2(0, uint64(362797056), v0_1)


def closure22(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure23(None, None)

    return UH2(0, uint64(60466176), v0_1)


def closure21(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure22(None, None)

    return UH2(0, uint64(10077696), v0_1)


def closure20(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure21(None, None)

    return UH2(0, uint64(1679616), v0_1)


def closure19(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure20(None, None)

    return UH2(0, uint64(279936), v0_1)


def closure18(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure19(None, None)

    return UH2(0, uint64(46656), v0_1)


def closure17(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure18(None, None)

    return UH2(0, uint64(7776), v0_1)


def closure16(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure17(None, None)

    return UH2(0, uint64(1296), v0_1)


def closure15(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure16(None, None)

    return UH2(0, uint64(216), v0_1)


def closure14(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure15(None, None)

    return UH2(0, uint64(36), v0_1)


def closure13(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure14(None, None)

    return UH2(0, uint64(6), v0_1)


def method10(v0_1_mut: int8, v1_1_mut: UH2) -> US4:
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


def method9(v0_1_mut: US0, v1_1_mut: int8, v2_1_mut: UH1, v3_1_mut: uint64) -> US3:
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
                    return closure13(None, None)

                v16: US4 = method10(v1_1, UH2(0, uint64(1), v14))
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


def method11(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method11(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method12(v0_1_mut: US0, v1_1_mut: Callable[[], uint8], v2_1_mut: bool, v3_1_mut: uint64, v4_1_mut: int8, v5_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut, v5_mut)
        v6: int8 = (v4_1 + int8(1)) or 0
        if v4_1 < v6:
            return method8(v0_1, v1_1, v2_1, v3_1, v4_1, UH1(1, v1_1(None), v5), v6)

        else: 
            v12: US3 = method9(v0_1, v4_1, v5, uint64(0))
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
                    v5_mut = method11(v4_1, v1_1, int8(0))
                    continue

                else: 
                    return method8(v0_1, v1_1, v2_1, v3_1, v4_1, UH1(1, v1_1(None), v5), v6)


            elif v2_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = v4_1
                v5_mut = method11(v4_1, v1_1, int8(0))
                continue

            else: 
                return method8(v0_1, v1_1, v2_1, v3_1, v4_1, UH1(1, v1_1(None), v5), v6)


        break


def method8(v0_1_mut: US0, v1_1_mut: Callable[[], uint8], v2_1_mut: bool, v3_1_mut: uint64, v4_1_mut: int8, v5_mut: UH1, v6_mut: int8) -> uint64:
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
            v14: US3 = method9(v0_1, v4_1, v5, uint64(0))
            if v14.tag == 0:
                v15: uint64 = v14.fields[0]
                if v15 <= v3_1:
                    return v15

                elif v2_1:
                    return method12(v0_1, v1_1, v2_1, v3_1, v4_1, method11(v4_1, v1_1, int8(0)))

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
                return method12(v0_1, v1_1, v2_1, v3_1, v4_1, method11(v4_1, v1_1, int8(0)))

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


def closure12(v0_1: US0, v1_1: Callable[[], uint8], v2_1: bool, v3_1: uint64) -> uint64:
    return method8(v0_1, v1_1, v2_1, v3_1, (int8(1) if (v3_1 == uint64(1)) else method7(v0_1, v3_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure11(v0_1: US0, v1_1: Callable[[], uint8], v2_1: bool) -> Callable[[uint64], uint64]:
    def _arrow320(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> uint64:
        return closure12(v0_1, v1_1, v2_1, v)

    return _arrow320


def closure10(v0_1: US0, v1_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow321(v: bool, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[uint64], uint64]:
        return closure11(v0_1, v1_1, v)

    return _arrow321


def closure9(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    _v1: FSharpRef[US0 | None] = FSharpRef(None)
    x_2: US0 | None
    if v0_1 is None:
        x_2 = None

    else: 
        x: Callable[[str], None] = v0_1
        def x_1(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> US0:
            return US0(0, x)

        x_2 = x_1(None)

    _v1.contents = x_2
    v6: US0 = default_arg(_v1.contents, US0(1))
    def _arrow322(v: Callable[[], uint8], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[bool, uint64], uint64]:
        return closure10(v6, v)

    return _arrow322


def method13(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = v1_1 + int8(1)
            continue

        break


def closure79(v0_1: Callable[[str], None] | None, v1_1: uint64, v2_1: UH1) -> uint64 | None:
    _v3: FSharpRef[US0 | None] = FSharpRef(None)
    x_2: US0 | None
    if v0_1 is None:
        x_2 = None

    else: 
        x: Callable[[str], None] = v0_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> US0:
            return US0(0, x)

        x_2 = x_1(None)

    _v3.contents = x_2
    v13: US3 = method9(default_arg(_v3.contents, US0(1)), method13(v2_1, int8(0)) - int8(1), v2_1, uint64(0))
    v23: US4
    if v13.tag == 0:
        v14: uint64 = v13.fields[0]
        v23 = US4(0, v14) if ((v14 <= v1_1) if (v14 >= uint64(1)) else False) else US4(1)

    else: 
        v23 = US4(1)

    if v23.tag == 0:
        return v23.fields[0]

    else: 
        return None



def closure78(v0_1: Callable[[str], None] | None, v1_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow323(v: UH1, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64 | None:
        return closure79(v0_1, v1_1, v)

    return _arrow323


def closure77(unit_var: None, v0_1: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    def _arrow324(v: uint64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[UH1], uint64 | None]:
        return closure78(v0_1, v)

    return _arrow324


def method15(__unit: None=None) -> uint8:
    _v0: uint8 | None = None
    v15: Any = {}
    x: uint8
    value_2: int = randint(int(uint8(1)), int(uint8(7))) or 0
    x = int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



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




def method14(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method15(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US5 = method16(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(1, method15(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def closure80(unit_var: None, v0_1: Array[str]) -> int:
    print(((((("calculate_dice_count / max: " + str(int64(9223372036854775807))) + " / n: ") + str(int8(24))) + " / p: ") + str(int64(4738381338321616896))) + "")
    print(("result: " + str(method14(UH1(0), int8(0)))) + "")
    return 0


def _arrow325(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow325

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow326(v: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    return closure3(None, v)


v1: Callable[[Callable[[str], None] | None, UH1, None], uint8] = _arrow326

def create_sequential_roller(x: Callable[[str], None] | None=None) -> Callable[[UH1, None], uint8]:
    return v1(x)


def _arrow327(v: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    return closure9(None, v)


v2: Callable[[Callable[[str], None] | None, Callable[[], uint8], bool, uint64], uint64] = _arrow327

def roll_progressively(x: Callable[[str], None] | None=None) -> Callable[[Callable[[], uint8], bool, uint64], uint64]:
    return v2(x)


def _arrow328(v: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    return closure77(None, v)


v3: Callable[[Callable[[str], None] | None, uint64, UH1], uint64 | None] = _arrow328

def roll_within_bounds(x: Callable[[str], None] | None=None) -> Callable[[uint64, UH1], uint64 | None]:
    return v3(x)


def _arrow329(v: Array[str]) -> int:
    return closure80(None, v)


v4: Callable[[Array[str]], int] = _arrow329

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


