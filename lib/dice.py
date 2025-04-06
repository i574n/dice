from __future__ import annotations
from abc import abstractmethod
from fable_modules.fable_library.date import (ticks as ticks_1, now, create as create_1, to_string)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, from_value, op_multiply)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, record_type, int64_type, string_type, bool_type, uint64_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, uint64, int8)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, int64_to_string, randint)
from collections.abc import Callable
from dataclasses import dataclass
import os
import sys
from typing import (Any, Protocol)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


TraceState_trace_state: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] | None = create_atom(None)

def _expr424() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr424

def _expr425() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr425

def _expr426() -> TypeInfo:
    return union_type("Dice.US0", [], US0, lambda: [[("f0_0", lambda_type(unit_type, UH0_reflection()))], [("f1_0", UH0_reflection())]])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr426

def _expr427() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: US0

Mut0_reflection = _expr427

def _expr428() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr428

def _expr429() -> TypeInfo:
    return union_type("Dice.US1", [], US1, lambda: [[("f0_0", uint8_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr429

def _expr430() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", US1_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US1

Mut2_reflection = _expr430

def _expr431() -> TypeInfo:
    return union_type("Dice.US2", [], US2, lambda: [[], [], [], [], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1", "US2_2", "US2_3", "US2_4"]


US2_reflection = _expr431

def _expr432() -> TypeInfo:
    return record_type("Dice.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr432

def _expr433() -> TypeInfo:
    return record_type("Dice.Mut4", [], Mut4, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: bool

Mut4_reflection = _expr433

def _expr434() -> TypeInfo:
    return record_type("Dice.Mut5", [], Mut5, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: str

Mut5_reflection = _expr434

def _expr435() -> TypeInfo:
    return record_type("Dice.Mut6", [], Mut6, lambda: [("l0", US2_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut6(Record):
    l0: US2

Mut6_reflection = _expr435

def _expr436() -> TypeInfo:
    return union_type("Dice.US3", [], US3, lambda: [[("f0_0", US2_reflection())], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr436

def _expr437() -> TypeInfo:
    return union_type("Dice.US4", [], US4, lambda: [[("f0_0", int64_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr437

def _expr438() -> TypeInfo:
    return union_type("Dice.US5", [], US5, lambda: [[], [], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1", "US5_2"]


US5_reflection = _expr438

def _expr439() -> TypeInfo:
    return union_type("Dice.US6", [], US6, lambda: [[("f0_0", US5_reflection())], [("f1_0", US5_reflection())], [("f2_0", US5_reflection())], [("f3_0", US5_reflection())], [("f4_0", US5_reflection())], [("f5_0", US5_reflection())], [("f6_0", US5_reflection())]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1", "US6_2", "US6_3", "US6_4", "US6_5", "US6_6"]


US6_reflection = _expr439

def _expr440() -> TypeInfo:
    return union_type("Dice.US7", [], US7, lambda: [[("f0_0", string_type)], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr440

def _expr441() -> TypeInfo:
    return union_type("Dice.US8", [], US8, lambda: [[("f0_0", uint64_type), ("f0_1", UH1_reflection())], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr441

def _expr442() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr442

def _expr443() -> TypeInfo:
    return union_type("Dice.US9", [], US9, lambda: [[("f0_0", uint64_type)], []])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr443

def _expr444() -> TypeInfo:
    return union_type("Dice.US10", [], US10, lambda: [[("f0_0", int64_type), ("f0_1", UH1_reflection())], []])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr444

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
    def _arrow445(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow445


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



def closure4(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def method3(v0_1: UH1, v1_1: UH0) -> UH0:
    if v0_1.tag == 0:
        return v1_1

    else: 
        v4_1: UH0 = method3(v0_1.fields[1], v1_1)
        def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
            return closure4(v4_1, None)

        return UH0(0, v0_1.fields[0], v5)



def closure5(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def closure6(v0_1: UH0, v1_1: Mut0, unit_var: None) -> UH0:
    v2_1: US0 = v1_1.l0
    if v2_1.tag == 0:
        v5: UH0 = v2_1.fields[0](None)
        v12: UH0 = UH0(1) if (v5.tag == 1) else UH0(0, v5.fields[0], method4(v0_1, v5.fields[1]))
        v1_1.l0 = US0(1, v12)
        return v12

    else: 
        return v2_1.fields[0]



def method4(v0_1: UH0, v1_1: Callable[[], UH0]) -> Callable[[], UH0]:
    v3_1: Mut0 = Mut0(US0(0, v1_1))
    def _arrow446(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure6(v0_1, v3_1, None)

    return _arrow446


def method10(v0_1: str) -> str:
    return v0_1


def method11(__unit: None=None) -> str:
    return ""


def closure10(unit_var: None, v0_1: str) -> US7:
    return US7(0, v0_1)


def method12(__unit: None=None) -> Callable[[str], US7]:
    def _arrow447(v: str) -> US7:
        return closure10(None, v)

    return _arrow447


def method9(v0_1: str) -> str:
    v31: IOsEnviron = os
    v33: Any = v31.environ
    _v38: (str | None) | None = None
    x: str | None = v33.get(v0_1)
    _v38 = some(x)
    v44: str | None
    if _v38 is None:
        raise Exception("optionm\'.of_obj / _v38=None")

    else: 
        v44 = value_3(_v38)

    v71: US7 = default_arg(map(method12(), v44), US7(1))
    if v71.tag == 0:
        return v71.fields[0]

    else: 
        return ""



def method8(__unit: None=None) -> tuple[US3, US4]:
    v1_1: str = method9("TRACE_LEVEL")
    v6: str = "Critical".lower()
    v13: str = "Warning".lower()
    v20: str = "Info".lower()
    v27: str = "Debug".lower()
    v34: str = "Verbose".lower()
    v41: US3 = US3(0, US2(0)) if ("Verbose" == v1_1) else US3(1)
    def _arrow448(__unit: None=None) -> US3:
        v48: US3 = US3(0, US2(1)) if ("Debug" == v1_1) else US3(1)
        if v48.tag == 0:
            return US3(0, v48.fields[0])

        else: 
            v55: US3 = US3(0, US2(2)) if ("Info" == v1_1) else US3(1)
            if v55.tag == 0:
                return US3(0, v55.fields[0])

            else: 
                v62: US3 = US3(0, US2(3)) if ("Warning" == v1_1) else US3(1)
                if v62.tag == 0:
                    return US3(0, v62.fields[0])

                else: 
                    v69: US3 = US3(0, US2(4)) if ("Critical" == v1_1) else US3(1)
                    if v69.tag == 0:
                        return US3(0, v69.fields[0])

                    else: 
                        v76: US3 = US3(0, US2(0)) if (v34 == v1_1) else US3(1)
                        if v76.tag == 0:
                            return US3(0, v76.fields[0])

                        else: 
                            v83: US3 = US3(0, US2(1)) if (v27 == v1_1) else US3(1)
                            if v83.tag == 0:
                                return US3(0, v83.fields[0])

                            else: 
                                v90: US3 = US3(0, US2(2)) if (v20 == v1_1) else US3(1)
                                if v90.tag == 0:
                                    return US3(0, v90.fields[0])

                                else: 
                                    v97: US3 = US3(0, US2(3)) if (v13 == v1_1) else US3(1)
                                    if v97.tag == 0:
                                        return US3(0, v97.fields[0])

                                    else: 
                                        v104: US3 = US3(0, US2(4)) if (v6 == v1_1) else US3(1)
                                        return US3(0, v104.fields[0]) if (v104.tag == 0) else US3(1)









    return (US3(0, v41.fields[0]) if (v41.tag == 0) else _arrow448(), US4(1) if (method9("AUTOMATION") != "True") else US4(0, from_value(ticks_1(now()), False)))


def closure11(unit_var: None, v0_1: str) -> None:
    pass


def method7(v0_1: US2) -> tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None]:
    pattern_input: tuple[US3, US4] = method8()
    _run_target_args_0027_v3: tuple[US3, US4] = (pattern_input[0], pattern_input[1])
    v185: US4 = _run_target_args_0027_v3[1]
    v184: US3 = _run_target_args_0027_v3[0]
    def v191(v: str, v0_1: Any=v0_1) -> None:
        closure11(None, v)

    return (Mut1(int64(1)), Mut3(v191), Mut4(True), Mut5(""), Mut6(v184.fields[0] if (v184.tag == 0) else v0_1), v185.fields[0] if (v185.tag == 0) else None)


def closure9(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = method7(US2(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method6(v0_1: US2) -> bool:
    v17: None
    closure9(None, None)
    v17 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v56: US2 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr449:
            @property
            def Compare(self) -> Callable[[US2, US2], int]:
                return compare

        class ObjectExpr450:
            @property
            def Compare(self) -> Callable[[US2, US2], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr449())) >= find(v56, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr450()))



def closure12(unit_var: None, v0_1: int64) -> US4:
    return US4(0, v0_1)


def method14(__unit: None=None) -> Callable[[int64], US4]:
    def _arrow451(v: int64) -> US4:
        return closure12(None, v)

    return _arrow451


def method15(__unit: None=None) -> str:
    return "hh:mm:ss"


def method16(__unit: None=None) -> str:
    return "HH:mm:ss"


def method13(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None=None) -> str:
    v827: US4 = default_arg(map(method14(), v5), US4(1))
    v967: Any
    if v827.tag == 0:
        v910: Any = create(op_subtraction(from_value(ticks_1(now()), False), v827.fields[0]))
        v967 = create_1(1, 1, 1, hours(v910), minutes(v910), seconds(v910), milliseconds(v910))

    else: 
        v967 = now()

    v968: str = method16()
    return to_string(v967, "M-d-y hh:mm:ss tt" if (v968 == "") else v968)


def method18(__unit: None=None) -> str:
    return ""


def closure13(v0_1: Mut5, v1_1: str, unit_var: None) -> None:
    v4_1: str = v0_1.l0 + v1_1
    v0_1.l0 = v4_1


def method19(__unit: None=None) -> str:
    return "\u001b[0m"


def method17(__unit: None=None) -> str:
    v4_1: str = "Debug".lower()
    v7: str = v4_1[0]
    v9: Mut5 = Mut5(method18())
    v24: None
    closure13(v9, ("" + str(v7)) + "", None)
    v24 = None
    return ("\u001b[94m" + v9.l0) + method19()


def method21(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method20(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64, v10: int64, v11: str) -> str:
    v13: Mut5 = Mut5(method18())
    v27: None
    closure13(v13, "{ ", None)
    v27 = None
    v46: None
    closure13(v13, "current_index", None)
    v46 = None
    v65: None
    closure13(v13, " = ", None)
    v65 = None
    v85: None
    closure13(v13, ("" + str(v8)) + "", None)
    v85 = None
    v104: None
    closure13(v13, "; ", None)
    v104 = None
    v123: None
    closure13(v13, "acc", None)
    v123 = None
    v140: None
    closure13(v13, " = ", None)
    v140 = None
    v160: None
    closure13(v13, ("" + str(v9)) + "", None)
    v160 = None
    v177: None
    closure13(v13, "; ", None)
    v177 = None
    v196: None
    closure13(v13, "len", None)
    v196 = None
    v213: None
    closure13(v13, " = ", None)
    v213 = None
    v233: None
    closure13(v13, ("" + str(v10)) + "", None)
    v233 = None
    v250: None
    closure13(v13, "; ", None)
    v250 = None
    v269: None
    closure13(v13, "last_item", None)
    v269 = None
    v286: None
    closure13(v13, " = ", None)
    v286 = None
    v303: None
    closure13(v13, v11, None)
    v303 = None
    v322: None
    closure13(v13, " }", None)
    v322 = None
    v328: str = v13.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll") + " / ") + v328)


def closure14(v0_1: Mut1, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure16(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure15(unit_var: None, v0_1: str) -> None:
    v4_1: None
    closure16(v0_1, None)
    v4_1 = None


def method22(v0_1: str) -> None:
    v17: None
    closure9(None, None)
    v17 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: None
    closure14(pattern_input[0], None)
    v60 = None
    closure15(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure8(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None, unit_var: None) -> None:
    if method6(US2(1)):
        v22: None
        closure9(None, None)
        v22 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v48: int64 | None = pattern_input[5]
        v47: Mut6 = pattern_input[4]
        v46: Mut5 = pattern_input[3]
        v45: Mut4 = pattern_input[2]
        v44: Mut3 = pattern_input[1]
        v43: Mut1 = pattern_input[0]
        method22(method20(v43, v44, v45, v46, v47, v48, method13(v43, v44, v45, v46, v47, v48), method17(), v0_1, v1_1, v2_1, to_text(interpolate("%A%P()", [v3_1]))))



def method23(v0_1_mut: int64, v1_1_mut: UH0) -> US1:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US1(1)

        elif v0_1 <= int64(0):
            return US1(0, v1_1.fields[0])

        else: 
            v0_1_mut = op_subtraction(v0_1, int64(1))
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method24(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    v9: Mut5 = Mut5(method18())
    v10: str = v9.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + v10)


def closure17(unit_var: None, unit_var_1: None) -> None:
    if method6(US2(1)):
        v18: None
        closure9(None, None)
        v18 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v44: int64 | None = pattern_input[5]
        v43: Mut6 = pattern_input[4]
        v42: Mut5 = pattern_input[3]
        v41: Mut4 = pattern_input[2]
        v40: Mut3 = pattern_input[1]
        v39: Mut1 = pattern_input[0]
        method22(method24(v39, v40, v41, v42, v43, v44, method13(v39, v40, v41, v42, v43, v44), method17()))



def method5(v0_1_mut: Callable[[], UH0], v1_1_mut: Mut1, v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut2) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int64 = v1_1.l0
        v6: int64 = v2_1.l0
        v7: int64 = v3_1.l0
        v8: US1 = v4_1.l0
        v86: None
        closure8(v5, v6, v7, v8.fields[0] if (v8.tag == 0) else None, None)
        v86 = None
        v151: UH0 = v0_1(None)
        v153: US1 = method23(v1_1.l0, v151)
        if v153.tag == 0:
            v154: uint8 = v153.fields[0]
            v156: int64 = op_addition(v1_1.l0, int64(1))
            v1_1.l0 = v156
            v4_1.l0 = US1(0, v154)
            return v154

        else: 
            v220: None
            closure17(None, None)
            v220 = None
            if v3_1.l0 == int64(-1):
                v283: int64 = v1_1.l0
                v3_1.l0 = v283

            v289: int64 = int64(1) if (v2_1.l0 >= v3_1.l0) else op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v289
            v291: int64 = op_subtraction(v2_1.l0, int64(1))
            v1_1.l0 = v291
            v4_1.l0 = US1(1)
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1
            v3_1_mut = v3_1
            v4_1_mut = v4_1
            continue

        break


def closure7(v0_1: Callable[[], UH0], v1_1: Mut1, v2_1: Mut1, v3_1: Mut1, v4_1: Mut2, unit_var: None) -> uint8:
    return method5(v0_1, v1_1, v2_1, v3_1, v4_1)


def closure3(unit_var: None, v0_1: UH1) -> Callable[[], uint8]:
    v5: UH0 = method3(method2(v0_1, method1(v0_1, UH1(0))), UH0(1))
    def v6(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure5(v5, None)

    v7: Callable[[], UH0] = method4(v5, v6)
    v8: Mut1 = Mut1(int64(0))
    v9: Mut1 = Mut1(int64(1))
    v10: Mut1 = Mut1(int64(-1))
    v12: Mut2 = Mut2(US1(1))
    def _arrow452(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint8:
        return closure7(v7, v8, v9, v10, v12, None)

    return _arrow452


def method26(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: uint64, v9: uint64, v10: int8) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "max", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(v8)) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "p", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v9)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "n", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v10)) + "", None)
    v232 = None
    v251: None
    closure13(v12, " }", None)
    v251 = None
    v257: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v257)


def closure21(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method26(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v2_1, v1_1))



def method25(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64) -> int8:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v2_1 < v0_1:
            v4_1: uint64 = op_multiply(v2_1, uint64(6))
            if v4_1 > v2_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1 + int8(1)
                v2_1_mut = v4_1
                continue

            else: 
                v70: None
                closure21(v0_1, v1_1, v2_1, None)
                v70 = None
                return v1_1


        else: 
            v194: None
            closure21(v0_1, v1_1, v2_1, None)
            v194 = None
            return v1_1

        break


def method29(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(v8)) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v9)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "result", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v10)) + "", None)
    v232 = None
    v251: None
    closure13(v12, " }", None)
    v251 = None
    v257: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v257)


def closure22(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method29(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v1_1, v0_1, v2_1))



def closure86(unit_var: None, unit_var_1: None) -> UH2:
    return UH2(1)


def closure85(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure86(None, None)

    return UH2(0, uint64(9223372036854775808), v0_1)


def closure84(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure85(None, None)

    return UH2(0, uint64(4611686018427387904), v0_1)


def closure83(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure84(None, None)

    return UH2(0, uint64(6917529027641081856), v0_1)


def closure82(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure83(None, None)

    return UH2(0, uint64(1152921504606846976), v0_1)


def closure81(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure82(None, None)

    return UH2(0, uint64(15564440312192434176), v0_1)


def closure80(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure81(None, None)

    return UH2(0, uint64(11817445422220181504), v0_1)


def closure79(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure80(None, None)

    return UH2(0, uint64(5044031582654955520), v0_1)


def closure78(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure79(None, None)

    return UH2(0, uint64(6989586621679009792), v0_1)


def closure77(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure78(None, None)

    return UH2(0, uint64(16537217831704461312), v0_1)


def closure76(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure77(None, None)

    return UH2(0, uint64(11979575008805519360), v0_1)


def closure75(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure76(None, None)

    return UH2(0, uint64(14294425217273954304), v0_1)


def closure74(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure75(None, None)

    return UH2(0, uint64(2382404202878992384), v0_1)


def closure73(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure74(None, None)

    return UH2(0, uint64(6545982058383015936), v0_1)


def closure72(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure73(None, None)

    return UH2(0, uint64(10314369046585278464), v0_1)


def closure71(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure72(None, None)

    return UH2(0, uint64(4793518853382471680), v0_1)


def closure70(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure71(None, None)

    return UH2(0, uint64(3873377154515337216), v0_1)


def closure69(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure70(None, None)

    return UH2(0, uint64(645562859085889536), v0_1)


def closure68(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure69(None, None)

    return UH2(0, uint64(107593809847648256), v0_1)


def closure67(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure68(None, None)

    return UH2(0, uint64(3092389647259533312), v0_1)


def closure66(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure67(None, None)

    return UH2(0, uint64(9738770311398031360), v0_1)


def closure65(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure66(None, None)

    return UH2(0, uint64(16995415113324298240), v0_1)


def closure64(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure65(None, None)

    return UH2(0, uint64(8981483876790566912), v0_1)


def closure63(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure64(None, None)

    return UH2(0, uint64(13794743361938128896), v0_1)


def closure62(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure63(None, None)

    return UH2(0, uint64(2299123893656354816), v0_1)


def closure61(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure62(None, None)

    return UH2(0, uint64(3457644661227651072), v0_1)


def closure60(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure61(None, None)

    return UH2(0, uint64(576274110204608512), v0_1)


def closure59(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure60(None, None)

    return UH2(0, uint64(6244960376270618624), v0_1)


def closure58(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure59(None, None)

    return UH2(0, uint64(13338656111851470848), v0_1)


def closure57(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure58(None, None)

    return UH2(0, uint64(14520938734448279552), v0_1)


def closure56(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure57(None, None)

    return UH2(0, uint64(14717985838214414336), v0_1)


def closure55(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure56(None, None)

    return UH2(0, uint64(5527454985320660992), v0_1)


def closure54(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure55(None, None)

    return UH2(0, uint64(16293529225644736512), v0_1)


def closure53(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure54(None, None)

    return UH2(0, uint64(11938960241128898560), v0_1)


def closure52(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure53(None, None)

    return UH2(0, uint64(8138741398091333632), v0_1)


def closure51(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure52(None, None)

    return UH2(0, uint64(7505371590918406144), v0_1)


def closure50(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure51(None, None)

    return UH2(0, uint64(16623181993244360704), v0_1)


def closure49(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure50(None, None)

    return UH2(0, uint64(8919445023443910656), v0_1)


def closure48(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure49(None, None)

    return UH2(0, uint64(4561031516192243712), v0_1)


def closure47(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure48(None, None)

    return UH2(0, uint64(9983543956220149760), v0_1)


def closure46(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure47(None, None)

    return UH2(0, uint64(4738381338321616896), v0_1)


def closure45(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure46(None, None)

    return UH2(0, uint64(789730223053602816), v0_1)


def closure44(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure45(None, None)

    return UH2(0, uint64(131621703842267136), v0_1)


def closure43(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure44(None, None)

    return UH2(0, uint64(21936950640377856), v0_1)


def closure42(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure43(None, None)

    return UH2(0, uint64(3656158440062976), v0_1)


def closure41(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure42(None, None)

    return UH2(0, uint64(609359740010496), v0_1)


def closure40(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure41(None, None)

    return UH2(0, uint64(101559956668416), v0_1)


def closure39(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure40(None, None)

    return UH2(0, uint64(16926659444736), v0_1)


def closure38(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure39(None, None)

    return UH2(0, uint64(2821109907456), v0_1)


def closure37(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure38(None, None)

    return UH2(0, uint64(470184984576), v0_1)


def closure36(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure37(None, None)

    return UH2(0, uint64(78364164096), v0_1)


def closure35(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure36(None, None)

    return UH2(0, uint64(13060694016), v0_1)


def closure34(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure35(None, None)

    return UH2(0, uint64(2176782336), v0_1)


def closure33(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure34(None, None)

    return UH2(0, uint64(362797056), v0_1)


def closure32(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure33(None, None)

    return UH2(0, uint64(60466176), v0_1)


def closure31(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure32(None, None)

    return UH2(0, uint64(10077696), v0_1)


def closure30(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure31(None, None)

    return UH2(0, uint64(1679616), v0_1)


def closure29(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure30(None, None)

    return UH2(0, uint64(279936), v0_1)


def closure28(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure29(None, None)

    return UH2(0, uint64(46656), v0_1)


def closure27(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure28(None, None)

    return UH2(0, uint64(7776), v0_1)


def closure26(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure27(None, None)

    return UH2(0, uint64(1296), v0_1)


def closure25(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure26(None, None)

    return UH2(0, uint64(216), v0_1)


def closure24(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure25(None, None)

    return UH2(0, uint64(36), v0_1)


def closure23(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure24(None, None)

    return UH2(0, uint64(6), v0_1)


def method30(v0_1_mut: int8, v1_1_mut: UH2) -> US9:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US9(1)

        elif v0_1 <= int8(0):
            return US9(0, v1_1.fields[0])

        else: 
            v0_1_mut = v0_1 - int8(1)
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method31(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8, v11: uint64) -> str:
    v13: Mut5 = Mut5(method18())
    v27: None
    closure13(v13, "{ ", None)
    v27 = None
    v46: None
    closure13(v13, "power", None)
    v46 = None
    v65: None
    closure13(v13, " = ", None)
    v65 = None
    v85: None
    closure13(v13, ("" + str(v8)) + "", None)
    v85 = None
    v104: None
    closure13(v13, "; ", None)
    v104 = None
    v123: None
    closure13(v13, "acc", None)
    v123 = None
    v140: None
    closure13(v13, " = ", None)
    v140 = None
    v160: None
    closure13(v13, ("" + str(v9)) + "", None)
    v160 = None
    v177: None
    closure13(v13, "; ", None)
    v177 = None
    v196: None
    closure13(v13, "roll", None)
    v196 = None
    v213: None
    closure13(v13, " = ", None)
    v213 = None
    v233: None
    closure13(v13, ("" + str(v10)) + "", None)
    v233 = None
    v250: None
    closure13(v13, "; ", None)
    v250 = None
    v269: None
    closure13(v13, "value", None)
    v269 = None
    v286: None
    closure13(v13, " = ", None)
    v286 = None
    v306: None
    closure13(v13, ("" + str(v11)) + "", None)
    v306 = None
    v325: None
    closure13(v13, " }", None)
    v325 = None
    v331: str = v13.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v331)


def closure87(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unit_var: None) -> None:
    if method6(US2(1)):
        v22: None
        closure9(None, None)
        v22 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v48: int64 | None = pattern_input[5]
        v47: Mut6 = pattern_input[4]
        v46: Mut5 = pattern_input[3]
        v45: Mut4 = pattern_input[2]
        v44: Mut3 = pattern_input[1]
        v43: Mut1 = pattern_input[0]
        method22(method31(v43, v44, v45, v46, v47, v48, method13(v43, v44, v45, v46, v47, v48), method17(), v1_1, v0_1, v2_1, v3_1))



def method32(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(v8)) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v9)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v10)) + "", None)
    v232 = None
    v251: None
    closure13(v12, " }", None)
    v251 = None
    v257: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v257)


def closure88(v0_1: uint64, v1_1: int8, v2_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method32(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v1_1, v0_1, v2_1))



def method28(v0_1_mut: int8, v1_1_mut: UH1, v2_1_mut: uint64) -> US8:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v0_1 < int8(0):
            v4_1: uint64 = op_addition(v2_1, uint64(1))
            v67: None
            closure22(v2_1, v0_1, v4_1, None)
            v67 = None
            return US8(0, v4_1, v1_1)

        elif v1_1.tag == 0:
            return US8(1)

        else: 
            v131: UH1 = v1_1.fields[1]
            v130: uint8 = v1_1.fields[0]
            if v130 > uint8(1):
                def v134(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH2:
                    return closure23(None, None)

                v136: US9 = method30(v0_1, UH2(0, uint64(1), v134))
                v140: uint64
                if v136.tag == 0:
                    v140 = v136.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v143: uint64 = op_multiply(from_integer(v130 - uint8(1), True, 4), v140)
                v206: None
                closure87(v2_1, v0_1, v130, v143, None)
                v206 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v131
                v2_1_mut = op_addition(v2_1, v143)
                continue

            else: 
                v332: None
                closure88(v2_1, v0_1, v130, None)
                v332 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v131
                v2_1_mut = v2_1
                continue


        break


def method33(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method33(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method34(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int8 = (v3_1 + int8(1)) or 0
        if v3_1 < v5:
            return method27(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)

        else: 
            v11: US8 = method28(v3_1, v4_1, uint64(0))
            if v11.tag == 0:
                v12: uint64 = v11.fields[0]
                if v12 <= v2_1:
                    return v12

                elif v1_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = method33(v3_1, v0_1, int8(0))
                    continue

                else: 
                    return method27(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


            elif v1_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = method33(v3_1, v0_1, int8(0))
                continue

            else: 
                return method27(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


        break


def method27(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1, v5_mut: int8) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut, v5_mut)
        if v5 < (v3_1 + int8(1)):
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1
            v3_1_mut = v3_1
            v4_1_mut = UH1(1, v0_1(None), v4_1)
            v5_mut = v5 + int8(1)
            continue

        else: 
            v13: US8 = method28(v3_1, v4_1, uint64(0))
            if v13.tag == 0:
                v14: uint64 = v13.fields[0]
                if v14 <= v2_1:
                    return v14

                elif v1_1:
                    return method34(v0_1, v1_1, v2_1, v3_1, method33(v3_1, v0_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = UH1(1, v0_1(None), v4_1)
                    v5_mut = v5 + int8(1)
                    continue


            elif v1_1:
                return method34(v0_1, v1_1, v2_1, v3_1, method33(v3_1, v0_1, int8(0)))

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = UH1(1, v0_1(None), v4_1)
                v5_mut = v5 + int8(1)
                continue


        break


def closure20(v0_1: Callable[[], uint8], v1_1: bool, v2_1: uint64) -> uint64:
    return method27(v0_1, v1_1, v2_1, (int8(1) if (v2_1 == uint64(1)) else method25(v2_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure19(v0_1: Callable[[], uint8], v1_1: bool) -> Callable[[uint64], uint64]:
    def _arrow453(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64:
        return closure20(v0_1, v1_1, v)

    return _arrow453


def closure18(unit_var: None, v0_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow454(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[uint64], uint64]:
        return closure19(v0_1, v)

    return _arrow454


def method35(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = v1_1 + int8(1)
            continue

        break


def closure90(v0_1: uint64, v1_1: UH1) -> uint64 | None:
    v6: US8 = method28(method35(v1_1, int8(0)) - int8(1), v1_1, uint64(0))
    v16: US9
    if v6.tag == 0:
        v7: uint64 = v6.fields[0]
        v16 = US9(0, v7) if ((v7 <= v0_1) if (v7 >= uint64(1)) else False) else US9(1)

    else: 
        v16 = US9(1)

    if v16.tag == 0:
        return v16.fields[0]

    else: 
        return None



def closure89(unit_var: None, v0_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow455(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint64 | None:
        return closure90(v0_1, v)

    return _arrow455


def method36(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    v9: Mut5 = Mut5(method18())
    v23: None
    closure13(v9, "{ ", None)
    v23 = None
    v42: None
    closure13(v9, "max", None)
    v42 = None
    v61: None
    closure13(v9, " = ", None)
    v61 = None
    v81: None
    closure13(v9, ("" + str(int64(9223372036854775807))) + "", None)
    v81 = None
    v100: None
    closure13(v9, "; ", None)
    v100 = None
    v119: None
    closure13(v9, "p", None)
    v119 = None
    v136: None
    closure13(v9, " = ", None)
    v136 = None
    v156: None
    closure13(v9, ("" + str(int64(4738381338321616896))) + "", None)
    v156 = None
    v173: None
    closure13(v9, "; ", None)
    v173 = None
    v192: None
    closure13(v9, "n", None)
    v192 = None
    v209: None
    closure13(v9, " = ", None)
    v209 = None
    v229: None
    closure13(v9, ("" + str(int8(24))) + "", None)
    v229 = None
    v248: None
    closure13(v9, " }", None)
    v248 = None
    v254: str = v9.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v254)


def closure92(unit_var: None, unit_var_1: None) -> None:
    if method6(US2(1)):
        v18: None
        closure9(None, None)
        v18 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v44: int64 | None = pattern_input[5]
        v43: Mut6 = pattern_input[4]
        v42: Mut5 = pattern_input[3]
        v41: Mut4 = pattern_input[2]
        v40: Mut3 = pattern_input[1]
        v39: Mut1 = pattern_input[0]
        method22(method36(v39, v40, v41, v42, v43, v44, method13(v39, v40, v41, v42, v43, v44), method17()))



def method38(__unit: None=None) -> uint8:
    v73: Any = {}
    value_2: int = randint(int(uint8(1)), int(uint8(7))) or 0
    return int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF


def method40(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(23))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure93(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method40(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method42(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(22))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure94(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method42(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method44(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(21))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure95(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method44(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method46(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(20))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method46(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method48(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(19))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method48(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method50(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(18))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method50(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method52(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(17))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method52(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method54(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(16))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method54(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method56(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(15))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method56(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method58(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(14))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method58(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method60(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(13))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method60(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method62(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(12))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method62(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method64(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(11))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method64(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method66(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(10))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method66(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method68(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(9))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method68(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method70(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(8))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method70(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method72(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(7))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method72(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method74(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(6))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method74(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method76(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(5))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method76(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method78(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(4))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method78(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method80(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(3))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method80(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method82(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(2))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method82(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method84(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(1))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method84(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method86(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: Mut5 = Mut5(method18())
    v26: None
    closure13(v12, "{ ", None)
    v26 = None
    v45: None
    closure13(v12, "power", None)
    v45 = None
    v64: None
    closure13(v12, " = ", None)
    v64 = None
    v84: None
    closure13(v12, ("" + str(int8(0))) + "", None)
    v84 = None
    v103: None
    closure13(v12, "; ", None)
    v103 = None
    v122: None
    closure13(v12, "acc", None)
    v122 = None
    v139: None
    closure13(v12, " = ", None)
    v139 = None
    v159: None
    closure13(v12, ("" + str(v8)) + "", None)
    v159 = None
    v176: None
    closure13(v12, "; ", None)
    v176 = None
    v195: None
    closure13(v12, "roll", None)
    v195 = None
    v212: None
    closure13(v12, " = ", None)
    v212 = None
    v232: None
    closure13(v12, ("" + str(v9)) + "", None)
    v232 = None
    v249: None
    closure13(v12, "; ", None)
    v249 = None
    v268: None
    closure13(v12, "value", None)
    v268 = None
    v285: None
    closure13(v12, " = ", None)
    v285 = None
    v305: None
    closure13(v12, ("" + str(v10)) + "", None)
    v305 = None
    v324: None
    closure13(v12, " }", None)
    v324 = None
    v330: str = v12.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v330)


def closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v21: None
        closure9(None, None)
        v21 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v47: int64 | None = pattern_input[5]
        v46: Mut6 = pattern_input[4]
        v45: Mut5 = pattern_input[3]
        v44: Mut4 = pattern_input[2]
        v43: Mut3 = pattern_input[1]
        v42: Mut1 = pattern_input[0]
        method22(method86(v42, v43, v44, v45, v46, v47, method13(v42, v43, v44, v45, v46, v47), method17(), v0_1, v1_1, v2_1))



def method88(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(-1))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "result", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure117(v0_1: int64, v1_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method88(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method87(v0_1: UH1, v1_1: int64) -> US10:
    v2_1: int64 = op_addition(v1_1, int64(1))
    v65: None
    closure117(v1_1, v2_1, None)
    v65 = None
    return US10(0, v2_1, v0_1)


def method89(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(0))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure118(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method89(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method85(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            v70: None
            closure116(v1_1, v3_1, v7, None)
            v70 = None
            return method87(v4_1, op_addition(v1_1, v7))

        else: 
            v195: None
            closure118(v1_1, v3_1, None)
            v195 = None
            return method87(v4_1, v1_1)




def method90(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(1))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure119(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method90(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method83(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            v71: None
            closure115(v1_1, v3_1, v8, None)
            v71 = None
            return method85(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure119(v1_1, v3_1, None)
            v196 = None
            return method85(v4_1, v1_1)




def method91(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(2))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure120(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method91(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method81(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            v71: None
            closure114(v1_1, v3_1, v8, None)
            v71 = None
            return method83(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure120(v1_1, v3_1, None)
            v196 = None
            return method83(v4_1, v1_1)




def method92(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(3))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure121(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method92(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method79(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            v71: None
            closure113(v1_1, v3_1, v8, None)
            v71 = None
            return method81(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure121(v1_1, v3_1, None)
            v196 = None
            return method81(v4_1, v1_1)




def method93(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(4))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure122(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method93(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method77(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            v71: None
            closure112(v1_1, v3_1, v8, None)
            v71 = None
            return method79(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure122(v1_1, v3_1, None)
            v196 = None
            return method79(v4_1, v1_1)




def method94(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(5))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure123(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method94(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method75(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            v71: None
            closure111(v1_1, v3_1, v8, None)
            v71 = None
            return method77(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure123(v1_1, v3_1, None)
            v196 = None
            return method77(v4_1, v1_1)




def method95(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(6))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure124(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method95(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method73(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            v71: None
            closure110(v1_1, v3_1, v8, None)
            v71 = None
            return method75(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure124(v1_1, v3_1, None)
            v196 = None
            return method75(v4_1, v1_1)




def method96(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(7))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure125(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method96(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method71(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            v71: None
            closure109(v1_1, v3_1, v8, None)
            v71 = None
            return method73(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure125(v1_1, v3_1, None)
            v196 = None
            return method73(v4_1, v1_1)




def method97(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(8))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure126(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method97(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method69(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            v71: None
            closure108(v1_1, v3_1, v8, None)
            v71 = None
            return method71(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure126(v1_1, v3_1, None)
            v196 = None
            return method71(v4_1, v1_1)




def method98(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(9))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure127(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method98(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method67(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            v71: None
            closure107(v1_1, v3_1, v8, None)
            v71 = None
            return method69(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure127(v1_1, v3_1, None)
            v196 = None
            return method69(v4_1, v1_1)




def method99(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(10))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure128(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method99(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method65(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            v71: None
            closure106(v1_1, v3_1, v8, None)
            v71 = None
            return method67(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure128(v1_1, v3_1, None)
            v196 = None
            return method67(v4_1, v1_1)




def method100(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(11))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure129(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method100(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method63(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            v71: None
            closure105(v1_1, v3_1, v8, None)
            v71 = None
            return method65(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure129(v1_1, v3_1, None)
            v196 = None
            return method65(v4_1, v1_1)




def method101(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(12))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure130(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method101(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method61(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            v71: None
            closure104(v1_1, v3_1, v8, None)
            v71 = None
            return method63(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure130(v1_1, v3_1, None)
            v196 = None
            return method63(v4_1, v1_1)




def method102(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(13))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure131(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method102(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method59(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            v71: None
            closure103(v1_1, v3_1, v8, None)
            v71 = None
            return method61(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure131(v1_1, v3_1, None)
            v196 = None
            return method61(v4_1, v1_1)




def method103(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(14))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure132(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method103(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method57(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            v71: None
            closure102(v1_1, v3_1, v8, None)
            v71 = None
            return method59(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure132(v1_1, v3_1, None)
            v196 = None
            return method59(v4_1, v1_1)




def method104(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(15))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure133(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method104(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method55(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            v71: None
            closure101(v1_1, v3_1, v8, None)
            v71 = None
            return method57(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure133(v1_1, v3_1, None)
            v196 = None
            return method57(v4_1, v1_1)




def method105(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(16))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure134(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method105(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method53(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            v71: None
            closure100(v1_1, v3_1, v8, None)
            v71 = None
            return method55(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure134(v1_1, v3_1, None)
            v196 = None
            return method55(v4_1, v1_1)




def method106(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(17))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure135(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method106(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method51(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            v71: None
            closure99(v1_1, v3_1, v8, None)
            v71 = None
            return method53(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure135(v1_1, v3_1, None)
            v196 = None
            return method53(v4_1, v1_1)




def method107(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(18))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure136(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method107(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method49(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            v71: None
            closure98(v1_1, v3_1, v8, None)
            v71 = None
            return method51(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure136(v1_1, v3_1, None)
            v196 = None
            return method51(v4_1, v1_1)




def method108(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(19))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure137(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method108(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method47(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            v71: None
            closure97(v1_1, v3_1, v8, None)
            v71 = None
            return method49(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure137(v1_1, v3_1, None)
            v196 = None
            return method49(v4_1, v1_1)




def method109(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(20))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure138(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method109(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method45(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            v71: None
            closure96(v1_1, v3_1, v8, None)
            v71 = None
            return method47(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure138(v1_1, v3_1, None)
            v196 = None
            return method47(v4_1, v1_1)




def method110(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(21))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure139(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method110(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method43(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            v71: None
            closure95(v1_1, v3_1, v8, None)
            v71 = None
            return method45(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure139(v1_1, v3_1, None)
            v196 = None
            return method45(v4_1, v1_1)




def method111(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(22))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure140(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method111(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method41(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            v71: None
            closure94(v1_1, v3_1, v8, None)
            v71 = None
            return method43(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure140(v1_1, v3_1, None)
            v196 = None
            return method43(v4_1, v1_1)




def method112(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: Mut5 = Mut5(method18())
    v25: None
    closure13(v11, "{ ", None)
    v25 = None
    v44: None
    closure13(v11, "power", None)
    v44 = None
    v63: None
    closure13(v11, " = ", None)
    v63 = None
    v83: None
    closure13(v11, ("" + str(int8(23))) + "", None)
    v83 = None
    v102: None
    closure13(v11, "; ", None)
    v102 = None
    v121: None
    closure13(v11, "acc", None)
    v121 = None
    v138: None
    closure13(v11, " = ", None)
    v138 = None
    v158: None
    closure13(v11, ("" + str(v8)) + "", None)
    v158 = None
    v175: None
    closure13(v11, "; ", None)
    v175 = None
    v194: None
    closure13(v11, "roll", None)
    v194 = None
    v211: None
    closure13(v11, " = ", None)
    v211 = None
    v231: None
    closure13(v11, ("" + str(v9)) + "", None)
    v231 = None
    v250: None
    closure13(v11, " }", None)
    v250 = None
    v256: str = v11.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v256)


def closure141(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v20: None
        closure9(None, None)
        v20 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v46: int64 | None = pattern_input[5]
        v45: Mut6 = pattern_input[4]
        v44: Mut5 = pattern_input[3]
        v43: Mut4 = pattern_input[2]
        v42: Mut3 = pattern_input[1]
        v41: Mut1 = pattern_input[0]
        method22(method112(v41, v42, v43, v44, v45, v46, method13(v41, v42, v43, v44, v45, v46), method17(), v0_1, v1_1))



def method39(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            v71: None
            closure93(v1_1, v3_1, v8, None)
            v71 = None
            return method41(v4_1, op_addition(v1_1, v8))

        else: 
            v196: None
            closure141(v1_1, v3_1, None)
            v196 = None
            return method41(v4_1, v1_1)




def method37(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method38(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US10 = method39(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(1, method38(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def method113(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64) -> str:
    v10: Mut5 = Mut5(method18())
    v24: None
    closure13(v10, "{ ", None)
    v24 = None
    v43: None
    closure13(v10, "result", None)
    v43 = None
    v62: None
    closure13(v10, " = ", None)
    v62 = None
    v82: None
    closure13(v10, ("" + str(v8)) + "", None)
    v82 = None
    v101: None
    closure13(v10, " }", None)
    v101 = None
    v107: str = v10.l0
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.main") + " / ") + v107)


def closure142(v0_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v19: None
        closure9(None, None)
        v19 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v45: int64 | None = pattern_input[5]
        v44: Mut6 = pattern_input[4]
        v43: Mut5 = pattern_input[3]
        v42: Mut4 = pattern_input[2]
        v41: Mut3 = pattern_input[1]
        v40: Mut1 = pattern_input[0]
        method22(method113(v40, v41, v42, v43, v44, v45, method13(v40, v41, v42, v43, v44, v45), method17(), v0_1))



def closure91(unit_var: None, v0_1: Array[str]) -> int:
    v63: None
    closure92(None, None)
    v63 = None
    v189: None
    closure142(method37(UH1(0), int8(0)), None)
    v189 = None
    return 0


def _arrow456(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow456

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow457(v: UH1) -> Callable[[], uint8]:
    return closure3(None, v)


v1: Callable[[UH1, None], uint8] = _arrow457

def create_sequential_roller(x: UH1) -> Callable[[], uint8]:
    return v1(x)


def _arrow458(v: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return closure18(None, v)


v2: Callable[[Callable[[], uint8], bool, uint64], uint64] = _arrow458

def roll_progressively(x: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return v2(x)


def _arrow459(v: uint64) -> Callable[[UH1], uint64 | None]:
    return closure89(None, v)


v3: Callable[[uint64, UH1], uint64 | None] = _arrow459

def roll_within_bounds(x: uint64) -> Callable[[UH1], uint64 | None]:
    return v3(x)


def _arrow460(v: Array[str]) -> int:
    return closure91(None, v)


v4: Callable[[Array[str]], int] = _arrow460

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


