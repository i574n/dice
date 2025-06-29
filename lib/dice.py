from __future__ import annotations
from abc import abstractmethod
from fable_modules.fable_library.date import (ticks as ticks_1, now, create as create_1, to_string)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, from_value, op_multiply)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, record_type, int64_type, string_type, bool_type, option_type, uint64_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, uint64, int8)
from fable_modules.fable_library.util import (create_atom, int64_to_string, to_enumerable, compare, randint)
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

def _expr446() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr446

def _expr447() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr447

def _expr448() -> TypeInfo:
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


US0_reflection = _expr448

def _expr449() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: US0

Mut0_reflection = _expr449

def _expr450() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr450

def _expr451() -> TypeInfo:
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


US1_reflection = _expr451

def _expr452() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", US1_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US1

Mut2_reflection = _expr452

def _expr453() -> TypeInfo:
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


US2_reflection = _expr453

def _expr454() -> TypeInfo:
    return record_type("Dice.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr454

def _expr455() -> TypeInfo:
    return record_type("Dice.Mut4", [], Mut4, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: bool

Mut4_reflection = _expr455

def _expr456() -> TypeInfo:
    return record_type("Dice.Mut5", [], Mut5, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: str

Mut5_reflection = _expr456

def _expr457() -> TypeInfo:
    return record_type("Dice.Mut6", [], Mut6, lambda: [("l0", US2_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut6(Record):
    l0: US2

Mut6_reflection = _expr457

def _expr458() -> TypeInfo:
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


US3_reflection = _expr458

def _expr459() -> TypeInfo:
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


US4_reflection = _expr459

def _expr460() -> TypeInfo:
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


US5_reflection = _expr460

def _expr461() -> TypeInfo:
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


US6_reflection = _expr461

def _expr462() -> TypeInfo:
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


US7_reflection = _expr462

def _expr463() -> TypeInfo:
    return union_type("Dice.US8", [], US8, lambda: [[("f0_0", Mut1_reflection()), ("f0_1", Mut3_reflection()), ("f0_2", Mut4_reflection()), ("f0_3", Mut5_reflection()), ("f0_4", Mut6_reflection()), ("f0_5", option_type(int64_type))], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr463

def _expr464() -> TypeInfo:
    return union_type("Dice.US9", [], US9, lambda: [[("f0_0", uint64_type), ("f0_1", UH1_reflection())], []])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr464

def _expr465() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr465

def _expr466() -> TypeInfo:
    return union_type("Dice.US10", [], US10, lambda: [[("f0_0", uint64_type)], []])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr466

def _expr467() -> TypeInfo:
    return union_type("Dice.US11", [], US11, lambda: [[("f0_0", int64_type), ("f0_1", UH1_reflection())], []])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr467

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
    def _arrow468(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow468


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
    def _arrow469(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure6(v0_1, v3_1, None)

    return _arrow469


def method9(v0_1: str) -> str:
    return v0_1


def method10(__unit: None=None) -> str:
    return ""


def closure10(unit_var: None, v0_1: str) -> US7:
    return US7(0, v0_1)


def method11(__unit: None=None) -> Callable[[str], US7]:
    def _arrow470(v: str) -> US7:
        return closure10(None, v)

    return _arrow470


def method8(v0_1: str) -> str:
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

    v71: US7 = default_arg(map(method11(), v44), US7(1))
    if v71.tag == 0:
        return v71.fields[0]

    else: 
        return ""



def method7(__unit: None=None) -> tuple[US3, US4]:
    v1_1: str = method8("TRACE_LEVEL")
    v6: str = "Critical".lower()
    v13: str = "Warning".lower()
    v20: str = "Info".lower()
    v27: str = "Debug".lower()
    v34: str = "Verbose".lower()
    v41: US3 = US3(0, US2(0)) if ("Verbose" == v1_1) else US3(1)
    def _arrow471(__unit: None=None) -> US3:
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









    return (US3(0, v41.fields[0]) if (v41.tag == 0) else _arrow471(), US4(1) if (method8("AUTOMATION") != "True") else US4(0, from_value(ticks_1(now()), False)))


def closure11(unit_var: None, v0_1: str) -> None:
    pass


def method6(v0_1: US2) -> tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None]:
    pattern_input: tuple[US3, US4] = method7()
    _run_target_args_0027_v3: tuple[US3, US4] = (pattern_input[0], pattern_input[1])
    v185: US4 = _run_target_args_0027_v3[1]
    v184: US3 = _run_target_args_0027_v3[0]
    def v191(v: str, v0_1: Any=v0_1) -> None:
        closure11(None, v)

    return (Mut1(int64(1)), Mut3(v191), Mut4(True), Mut5(""), Mut6(v184.fields[0] if (v184.tag == 0) else v0_1), v185.fields[0] if (v185.tag == 0) else None)


def closure9(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = method6(US2(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure12(unit_var: None, v0_1: int64) -> US4:
    return US4(0, v0_1)


def method13(__unit: None=None) -> Callable[[int64], US4]:
    def _arrow472(v: int64) -> US4:
        return closure12(None, v)

    return _arrow472


def method14(__unit: None=None) -> str:
    return "hh:mm:ss"


def method15(__unit: None=None) -> str:
    return "HH:mm:ss"


def method12(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None=None) -> str:
    v920: US4 = default_arg(map(method13(), v5), US4(1))
    v1074: Any
    if v920.tag == 0:
        v1003: Any = create(op_subtraction(from_value(ticks_1(now()), False), v920.fields[0]))
        v1074 = create_1(1, 1, 1, hours(v1003), minutes(v1003), seconds(v1003), milliseconds(v1003))

    else: 
        v1074 = now()

    v1075: str = method15()
    return to_string(v1074, "M-d-y hh:mm:ss tt" if (v1075 == "") else v1075)


def method18(__unit: None=None) -> str:
    return ""


def closure13(v0_1: Mut5, v1_1: str, unit_var: None) -> None:
    v4_1: str = v0_1.l0 + v1_1
    v0_1.l0 = v4_1


def method17(v0_1: str) -> str:
    v2_1: Mut5 = Mut5(method18())
    v17: None
    closure13(v2_1, ("" + str(v0_1)) + "", None)
    v17 = None
    return v2_1.l0


def method16(__unit: None=None) -> str:
    v133: str = "Debug".lower()
    return ("\u001b[94m" + method17(v133[0])) + "\u001b[0m"


def method20(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: str) -> str:
    v5: Mut5 = Mut5(method18())
    v19: None
    closure13(v5, "{ ", None)
    v19 = None
    v38: None
    closure13(v5, "current_index", None)
    v38 = None
    v57: None
    closure13(v5, " = ", None)
    v57 = None
    v77: None
    closure13(v5, ("" + str(v0_1)) + "", None)
    v77 = None
    v96: None
    closure13(v5, "; ", None)
    v96 = None
    v115: None
    closure13(v5, "acc", None)
    v115 = None
    v132: None
    closure13(v5, " = ", None)
    v132 = None
    v152: None
    closure13(v5, ("" + str(v1_1)) + "", None)
    v152 = None
    v169: None
    closure13(v5, "; ", None)
    v169 = None
    v188: None
    closure13(v5, "len", None)
    v188 = None
    v205: None
    closure13(v5, " = ", None)
    v205 = None
    v225: None
    closure13(v5, ("" + str(v2_1)) + "", None)
    v225 = None
    v242: None
    closure13(v5, "; ", None)
    v242 = None
    v261: None
    closure13(v5, "last_item", None)
    v261 = None
    v278: None
    closure13(v5, " = ", None)
    v278 = None
    v295: None
    closure13(v5, v3_1, None)
    v295 = None
    v314: None
    closure13(v5, " }", None)
    v314 = None
    return v5.l0


def method21(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method19(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64, v10: int64, v11: str) -> str:
    v12: str = method20(v8, v9, v10, v11)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll") + " / ") + v12)


def closure14(v0_1: Mut1, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure16(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure15(unit_var: None, v0_1: str) -> None:
    v4_1: None
    closure16(v0_1, None)
    v4_1 = None


def closure8(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None, unit_var: None) -> None:
    def v19(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v20: None
    v19(None)
    v20 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v61: US2 = pattern_input[4].l0
    v305: US8
    class ObjectExpr473:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr473())))) == False:
        v305 = US8(1)

    else: 
        v84: None
        v19(None)
        v84 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v112: int64 | None = pattern_input_1[5]
        v111: Mut6 = pattern_input_1[4]
        v110: Mut5 = pattern_input_1[3]
        v109: Mut4 = pattern_input_1[2]
        v108: Mut3 = pattern_input_1[1]
        v107: Mut1 = pattern_input_1[0]
        v131: str = method19(v107, v108, v109, v110, v111, v112, method12(v107, v108, v109, v110, v111, v112), method16(), v0_1, v1_1, v2_1, to_text(interpolate("%A%P()", [v3_1])))
        v147: None
        v19(None)
        v147 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v171: Mut3 = pattern_input_2[1]
        v170: Mut1 = pattern_input_2[0]
        v192: None
        closure14(v170, None)
        v192 = None
        closure15(None, v131)
        v171.l0(v131)
        v305 = US8(0, v170, v171, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method22(v0_1_mut: int64, v1_1_mut: UH0) -> US1:
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


def method24(__unit: None=None) -> str:
    v1_1: Mut5 = Mut5(method18())
    return v1_1.l0


def method23(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method24()
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + v8)


def closure17(unit_var: None, unit_var_1: None) -> None:
    def v15(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure9(None, None)

    v16: None
    v15(None)
    v16 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v57: US2 = pattern_input[4].l0
    v297: US8
    class ObjectExpr474:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v57, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr474())))) == False:
        v297 = US8(1)

    else: 
        v80: None
        v15(None)
        v80 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v108: int64 | None = pattern_input_1[5]
        v107: Mut6 = pattern_input_1[4]
        v106: Mut5 = pattern_input_1[3]
        v105: Mut4 = pattern_input_1[2]
        v104: Mut3 = pattern_input_1[1]
        v103: Mut1 = pattern_input_1[0]
        v123: str = method23(v103, v104, v105, v106, v107, v108, method12(v103, v104, v105, v106, v107, v108), method16())
        v139: None
        v15(None)
        v139 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v163: Mut3 = pattern_input_2[1]
        v162: Mut1 = pattern_input_2[0]
        v184: None
        closure14(v162, None)
        v184 = None
        closure15(None, v123)
        v163.l0(v123)
        v297 = US8(0, v162, v163, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method5(v0_1_mut: Callable[[], UH0], v1_1_mut: Mut1, v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut2) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int64 = v1_1.l0
        v6: int64 = v2_1.l0
        v7: int64 = v3_1.l0
        v8: US1 = v4_1.l0
        v337: None
        closure8(v5, v6, v7, v8.fields[0] if (v8.tag == 0) else None, None)
        v337 = None
        v656: UH0 = v0_1(None)
        v658: US1 = method22(v1_1.l0, v656)
        if v658.tag == 0:
            v659: uint8 = v658.fields[0]
            v661: int64 = op_addition(v1_1.l0, int64(1))
            v1_1.l0 = v661
            v4_1.l0 = US1(0, v659)
            return v659

        else: 
            v976: None
            closure17(None, None)
            v976 = None
            if v3_1.l0 == int64(-1):
                v1293: int64 = v1_1.l0
                v3_1.l0 = v1293

            v1299: int64 = int64(1) if (v2_1.l0 >= v3_1.l0) else op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v1299
            v1301: int64 = op_subtraction(v2_1.l0, int64(1))
            v1_1.l0 = v1301
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
    def _arrow475(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint8:
        return closure7(v7, v8, v9, v10, v12, None)

    return _arrow475


def method27(v0_1: uint64, v1_1: uint64, v2_1: int8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v18: None
    closure13(v4_1, "{ ", None)
    v18 = None
    v37: None
    closure13(v4_1, "max", None)
    v37 = None
    v56: None
    closure13(v4_1, " = ", None)
    v56 = None
    v76: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v76 = None
    v95: None
    closure13(v4_1, "; ", None)
    v95 = None
    v114: None
    closure13(v4_1, "p", None)
    v114 = None
    v131: None
    closure13(v4_1, " = ", None)
    v131 = None
    v151: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v151 = None
    v168: None
    closure13(v4_1, "; ", None)
    v168 = None
    v187: None
    closure13(v4_1, "n", None)
    v187 = None
    v204: None
    closure13(v4_1, " = ", None)
    v204 = None
    v224: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v224 = None
    v243: None
    closure13(v4_1, " }", None)
    v243 = None
    return v4_1.l0


def method26(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: uint64, v9: uint64, v10: int8) -> str:
    v11: str = method27(v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v11)


def closure21(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr476:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr476())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method26(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v2_1, v1_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



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
                v321: None
                closure21(v0_1, v1_1, v2_1, None)
                v321 = None
                return v1_1


        else: 
            v950: None
            closure21(v0_1, v1_1, v2_1, None)
            v950 = None
            return v1_1

        break


def method31(v0_1: int8, v1_1: uint64, v2_1: uint64) -> str:
    v4_1: Mut5 = Mut5(method18())
    v18: None
    closure13(v4_1, "{ ", None)
    v18 = None
    v37: None
    closure13(v4_1, "power", None)
    v37 = None
    v56: None
    closure13(v4_1, " = ", None)
    v56 = None
    v76: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v76 = None
    v95: None
    closure13(v4_1, "; ", None)
    v95 = None
    v114: None
    closure13(v4_1, "acc", None)
    v114 = None
    v131: None
    closure13(v4_1, " = ", None)
    v131 = None
    v151: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v151 = None
    v168: None
    closure13(v4_1, "; ", None)
    v168 = None
    v187: None
    closure13(v4_1, "result", None)
    v187 = None
    v204: None
    closure13(v4_1, " = ", None)
    v204 = None
    v224: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v224 = None
    v243: None
    closure13(v4_1, " }", None)
    v243 = None
    return v4_1.l0


def method30(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint64) -> str:
    v11: str = method31(v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure22(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr477:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr477())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method30(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v1_1, v0_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



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


def method32(v0_1_mut: int8, v1_1_mut: UH2) -> US10:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US10(1)

        elif v0_1 <= int8(0):
            return US10(0, v1_1.fields[0])

        else: 
            v0_1_mut = v0_1 - int8(1)
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method34(v0_1: int8, v1_1: uint64, v2_1: uint8, v3_1: uint64) -> str:
    v5: Mut5 = Mut5(method18())
    v19: None
    closure13(v5, "{ ", None)
    v19 = None
    v38: None
    closure13(v5, "power", None)
    v38 = None
    v57: None
    closure13(v5, " = ", None)
    v57 = None
    v77: None
    closure13(v5, ("" + str(v0_1)) + "", None)
    v77 = None
    v96: None
    closure13(v5, "; ", None)
    v96 = None
    v115: None
    closure13(v5, "acc", None)
    v115 = None
    v132: None
    closure13(v5, " = ", None)
    v132 = None
    v152: None
    closure13(v5, ("" + str(v1_1)) + "", None)
    v152 = None
    v169: None
    closure13(v5, "; ", None)
    v169 = None
    v188: None
    closure13(v5, "roll", None)
    v188 = None
    v205: None
    closure13(v5, " = ", None)
    v205 = None
    v225: None
    closure13(v5, ("" + str(v2_1)) + "", None)
    v225 = None
    v242: None
    closure13(v5, "; ", None)
    v242 = None
    v261: None
    closure13(v5, "value", None)
    v261 = None
    v278: None
    closure13(v5, " = ", None)
    v278 = None
    v298: None
    closure13(v5, ("" + str(v3_1)) + "", None)
    v298 = None
    v317: None
    closure13(v5, " }", None)
    v317 = None
    return v5.l0


def method33(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8, v11: uint64) -> str:
    v12: str = method34(v8, v9, v10, v11)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure87(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unit_var: None) -> None:
    def v19(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v20: None
    v19(None)
    v20 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v61: US2 = pattern_input[4].l0
    v301: US8
    class ObjectExpr478:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr478())))) == False:
        v301 = US8(1)

    else: 
        v84: None
        v19(None)
        v84 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v112: int64 | None = pattern_input_1[5]
        v111: Mut6 = pattern_input_1[4]
        v110: Mut5 = pattern_input_1[3]
        v109: Mut4 = pattern_input_1[2]
        v108: Mut3 = pattern_input_1[1]
        v107: Mut1 = pattern_input_1[0]
        v127: str = method33(v107, v108, v109, v110, v111, v112, method12(v107, v108, v109, v110, v111, v112), method16(), v1_1, v0_1, v2_1, v3_1)
        v143: None
        v19(None)
        v143 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v167: Mut3 = pattern_input_2[1]
        v166: Mut1 = pattern_input_2[0]
        v188: None
        closure14(v166, None)
        v188 = None
        closure15(None, v127)
        v167.l0(v127)
        v301 = US8(0, v166, v167, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method36(v0_1: int8, v1_1: uint64, v2_1: uint8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v18: None
    closure13(v4_1, "{ ", None)
    v18 = None
    v37: None
    closure13(v4_1, "power", None)
    v37 = None
    v56: None
    closure13(v4_1, " = ", None)
    v56 = None
    v76: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v76 = None
    v95: None
    closure13(v4_1, "; ", None)
    v95 = None
    v114: None
    closure13(v4_1, "acc", None)
    v114 = None
    v131: None
    closure13(v4_1, " = ", None)
    v131 = None
    v151: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v151 = None
    v168: None
    closure13(v4_1, "; ", None)
    v168 = None
    v187: None
    closure13(v4_1, "roll", None)
    v187 = None
    v204: None
    closure13(v4_1, " = ", None)
    v204 = None
    v224: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v224 = None
    v243: None
    closure13(v4_1, " }", None)
    v243 = None
    return v4_1.l0


def method35(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8) -> str:
    v11: str = method36(v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure88(v0_1: uint64, v1_1: int8, v2_1: uint8, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr479:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr479())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method35(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v1_1, v0_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method29(v0_1_mut: int8, v1_1_mut: UH1, v2_1_mut: uint64) -> US9:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v0_1 < int8(0):
            v4_1: uint64 = op_addition(v2_1, uint64(1))
            v318: None
            closure22(v2_1, v0_1, v4_1, None)
            v318 = None
            return US9(0, v4_1, v1_1)

        elif v1_1.tag == 0:
            return US9(1)

        else: 
            v636: UH1 = v1_1.fields[1]
            v635: uint8 = v1_1.fields[0]
            if v635 > uint8(1):
                def v639(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH2:
                    return closure23(None, None)

                v641: US10 = method32(v0_1, UH2(0, uint64(1), v639))
                v645: uint64
                if v641.tag == 0:
                    v645 = v641.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v648: uint64 = op_multiply(from_integer(v635 - uint8(1), True, 4), v645)
                v962: None
                closure87(v2_1, v0_1, v635, v648, None)
                v962 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v636
                v2_1_mut = op_addition(v2_1, v648)
                continue

            else: 
                v1593: None
                closure88(v2_1, v0_1, v635, None)
                v1593 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v636
                v2_1_mut = v2_1
                continue


        break


def method37(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method37(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method38(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int8 = (v3_1 + int8(1)) or 0
        if v3_1 < v5:
            return method28(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)

        else: 
            v11: US9 = method29(v3_1, v4_1, uint64(0))
            if v11.tag == 0:
                v12: uint64 = v11.fields[0]
                if v12 <= v2_1:
                    return v12

                elif v1_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = method37(v3_1, v0_1, int8(0))
                    continue

                else: 
                    return method28(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


            elif v1_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = method37(v3_1, v0_1, int8(0))
                continue

            else: 
                return method28(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


        break


def method28(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1, v5_mut: int8) -> uint64:
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
            v13: US9 = method29(v3_1, v4_1, uint64(0))
            if v13.tag == 0:
                v14: uint64 = v13.fields[0]
                if v14 <= v2_1:
                    return v14

                elif v1_1:
                    return method38(v0_1, v1_1, v2_1, v3_1, method37(v3_1, v0_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = UH1(1, v0_1(None), v4_1)
                    v5_mut = v5 + int8(1)
                    continue


            elif v1_1:
                return method38(v0_1, v1_1, v2_1, v3_1, method37(v3_1, v0_1, int8(0)))

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
    return method28(v0_1, v1_1, v2_1, (int8(1) if (v2_1 == uint64(1)) else method25(v2_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure19(v0_1: Callable[[], uint8], v1_1: bool) -> Callable[[uint64], uint64]:
    def _arrow480(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64:
        return closure20(v0_1, v1_1, v)

    return _arrow480


def closure18(unit_var: None, v0_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow481(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[uint64], uint64]:
        return closure19(v0_1, v)

    return _arrow481


def method39(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
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
    v6: US9 = method29(method39(v1_1, int8(0)) - int8(1), v1_1, uint64(0))
    v16: US10
    if v6.tag == 0:
        v7: uint64 = v6.fields[0]
        v16 = US10(0, v7) if ((v7 <= v0_1) if (v7 >= uint64(1)) else False) else US10(1)

    else: 
        v16 = US10(1)

    if v16.tag == 0:
        return v16.fields[0]

    else: 
        return None



def closure89(unit_var: None, v0_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow482(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint64 | None:
        return closure90(v0_1, v)

    return _arrow482


def method41(v0_1: int64, v1_1: int64, v2_1: int8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v18: None
    closure13(v4_1, "{ ", None)
    v18 = None
    v37: None
    closure13(v4_1, "max", None)
    v37 = None
    v56: None
    closure13(v4_1, " = ", None)
    v56 = None
    v76: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v76 = None
    v95: None
    closure13(v4_1, "; ", None)
    v95 = None
    v114: None
    closure13(v4_1, "p", None)
    v114 = None
    v131: None
    closure13(v4_1, " = ", None)
    v131 = None
    v151: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v151 = None
    v168: None
    closure13(v4_1, "; ", None)
    v168 = None
    v187: None
    closure13(v4_1, "n", None)
    v187 = None
    v204: None
    closure13(v4_1, " = ", None)
    v204 = None
    v224: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v224 = None
    v243: None
    closure13(v4_1, " }", None)
    v243 = None
    return v4_1.l0


def method40(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    v11: str = method41(int64(9223372036854775807), int64(4738381338321616896), int8(24))
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v11)


def closure92(unit_var: None, unit_var_1: None) -> None:
    def v15(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure9(None, None)

    v16: None
    v15(None)
    v16 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v57: US2 = pattern_input[4].l0
    v297: US8
    class ObjectExpr483:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v57, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr483())))) == False:
        v297 = US8(1)

    else: 
        v80: None
        v15(None)
        v80 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v108: int64 | None = pattern_input_1[5]
        v107: Mut6 = pattern_input_1[4]
        v106: Mut5 = pattern_input_1[3]
        v105: Mut4 = pattern_input_1[2]
        v104: Mut3 = pattern_input_1[1]
        v103: Mut1 = pattern_input_1[0]
        v123: str = method40(v103, v104, v105, v106, v107, v108, method12(v103, v104, v105, v106, v107, v108), method16())
        v139: None
        v15(None)
        v139 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v163: Mut3 = pattern_input_2[1]
        v162: Mut1 = pattern_input_2[0]
        v184: None
        closure14(v162, None)
        v184 = None
        closure15(None, v123)
        v163.l0(v123)
        v297 = US8(0, v162, v163, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method43(__unit: None=None) -> uint8:
    v73: Any = {}
    value_2: int = randint(int(uint8(1)), int(uint8(7))) or 0
    return int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF


def method46(v0_1: int8, v1_1: int64, v2_1: uint8, v3_1: int64) -> str:
    v5: Mut5 = Mut5(method18())
    v19: None
    closure13(v5, "{ ", None)
    v19 = None
    v38: None
    closure13(v5, "power", None)
    v38 = None
    v57: None
    closure13(v5, " = ", None)
    v57 = None
    v77: None
    closure13(v5, ("" + str(v0_1)) + "", None)
    v77 = None
    v96: None
    closure13(v5, "; ", None)
    v96 = None
    v115: None
    closure13(v5, "acc", None)
    v115 = None
    v132: None
    closure13(v5, " = ", None)
    v132 = None
    v152: None
    closure13(v5, ("" + str(v1_1)) + "", None)
    v152 = None
    v169: None
    closure13(v5, "; ", None)
    v169 = None
    v188: None
    closure13(v5, "roll", None)
    v188 = None
    v205: None
    closure13(v5, " = ", None)
    v205 = None
    v225: None
    closure13(v5, ("" + str(v2_1)) + "", None)
    v225 = None
    v242: None
    closure13(v5, "; ", None)
    v242 = None
    v261: None
    closure13(v5, "value", None)
    v261 = None
    v278: None
    closure13(v5, " = ", None)
    v278 = None
    v298: None
    closure13(v5, ("" + str(v3_1)) + "", None)
    v298 = None
    v317: None
    closure13(v5, " }", None)
    v317 = None
    return v5.l0


def method45(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(23), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure93(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr484:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr484())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method45(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method48(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(22), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure94(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr485:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr485())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method48(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method50(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(21), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure95(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr486:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr486())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method50(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method52(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(20), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr487:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr487())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method52(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method54(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(19), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr488:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr488())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method54(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method56(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(18), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr489:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr489())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method56(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method58(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(17), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr490:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr490())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method58(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method60(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(16), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr491:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr491())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method60(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method62(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(15), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr492:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr492())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method62(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method64(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(14), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr493:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr493())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method64(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method66(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(13), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr494:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr494())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method66(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method68(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(12), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr495:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr495())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method68(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method70(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(11), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr496:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr496())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method70(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method72(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(10), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr497:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr497())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method72(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method74(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(9), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr498:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr498())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method74(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method76(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(8), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr499:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr499())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method76(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method78(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(7), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr500:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr500())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method78(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method80(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(6), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr501:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr501())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method80(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method82(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(5), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr502:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr502())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method82(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method84(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(4), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr503:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr503())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method84(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method86(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(3), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr504:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr504())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method86(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method88(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(2), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr505:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr505())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method88(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method90(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(1), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr506:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr506())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method90(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method92(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method46(int8(0), v8, v9, v10)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12)


def closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v18(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v19: None
    v18(None)
    v19 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v60: US2 = pattern_input[4].l0
    v300: US8
    class ObjectExpr507:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v60, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr507())))) == False:
        v300 = US8(1)

    else: 
        v83: None
        v18(None)
        v83 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v111: int64 | None = pattern_input_1[5]
        v110: Mut6 = pattern_input_1[4]
        v109: Mut5 = pattern_input_1[3]
        v108: Mut4 = pattern_input_1[2]
        v107: Mut3 = pattern_input_1[1]
        v106: Mut1 = pattern_input_1[0]
        v126: str = method92(v106, v107, v108, v109, v110, v111, method12(v106, v107, v108, v109, v110, v111), method16(), v0_1, v1_1, v2_1)
        v142: None
        v18(None)
        v142 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v166: Mut3 = pattern_input_2[1]
        v165: Mut1 = pattern_input_2[0]
        v187: None
        closure14(v165, None)
        v187 = None
        closure15(None, v126)
        v166.l0(v126)
        v300 = US8(0, v165, v166, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method95(v0_1: int8, v1_1: int64, v2_1: int64) -> str:
    v4_1: Mut5 = Mut5(method18())
    v18: None
    closure13(v4_1, "{ ", None)
    v18 = None
    v37: None
    closure13(v4_1, "power", None)
    v37 = None
    v56: None
    closure13(v4_1, " = ", None)
    v56 = None
    v76: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v76 = None
    v95: None
    closure13(v4_1, "; ", None)
    v95 = None
    v114: None
    closure13(v4_1, "acc", None)
    v114 = None
    v131: None
    closure13(v4_1, " = ", None)
    v131 = None
    v151: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v151 = None
    v168: None
    closure13(v4_1, "; ", None)
    v168 = None
    v187: None
    closure13(v4_1, "result", None)
    v187 = None
    v204: None
    closure13(v4_1, " = ", None)
    v204 = None
    v224: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v224 = None
    v243: None
    closure13(v4_1, " }", None)
    v243 = None
    return v4_1.l0


def method94(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64) -> str:
    v11: str = method95(int8(-1), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure117(v0_1: int64, v1_1: int64, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr508:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr508())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method94(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method93(v0_1: UH1, v1_1: int64) -> US11:
    v2_1: int64 = op_addition(v1_1, int64(1))
    v316: None
    closure117(v1_1, v2_1, None)
    v316 = None
    return US11(0, v2_1, v0_1)


def method97(v0_1: int8, v1_1: int64, v2_1: uint8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v18: None
    closure13(v4_1, "{ ", None)
    v18 = None
    v37: None
    closure13(v4_1, "power", None)
    v37 = None
    v56: None
    closure13(v4_1, " = ", None)
    v56 = None
    v76: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v76 = None
    v95: None
    closure13(v4_1, "; ", None)
    v95 = None
    v114: None
    closure13(v4_1, "acc", None)
    v114 = None
    v131: None
    closure13(v4_1, " = ", None)
    v131 = None
    v151: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v151 = None
    v168: None
    closure13(v4_1, "; ", None)
    v168 = None
    v187: None
    closure13(v4_1, "roll", None)
    v187 = None
    v204: None
    closure13(v4_1, " = ", None)
    v204 = None
    v224: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v224 = None
    v243: None
    closure13(v4_1, " }", None)
    v243 = None
    return v4_1.l0


def method96(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(0), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure118(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr509:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr509())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method96(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method91(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            v321: None
            closure116(v1_1, v3_1, v7, None)
            v321 = None
            return method93(v4_1, op_addition(v1_1, v7))

        else: 
            v951: None
            closure118(v1_1, v3_1, None)
            v951 = None
            return method93(v4_1, v1_1)




def method98(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(1), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure119(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr510:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr510())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method98(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method89(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            v322: None
            closure115(v1_1, v3_1, v8, None)
            v322 = None
            return method91(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure119(v1_1, v3_1, None)
            v952 = None
            return method91(v4_1, v1_1)




def method99(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(2), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure120(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr511:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr511())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method99(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method87(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            v322: None
            closure114(v1_1, v3_1, v8, None)
            v322 = None
            return method89(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure120(v1_1, v3_1, None)
            v952 = None
            return method89(v4_1, v1_1)




def method100(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(3), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure121(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr512:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr512())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method100(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method85(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            v322: None
            closure113(v1_1, v3_1, v8, None)
            v322 = None
            return method87(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure121(v1_1, v3_1, None)
            v952 = None
            return method87(v4_1, v1_1)




def method101(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(4), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure122(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr513:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr513())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method101(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method83(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            v322: None
            closure112(v1_1, v3_1, v8, None)
            v322 = None
            return method85(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure122(v1_1, v3_1, None)
            v952 = None
            return method85(v4_1, v1_1)




def method102(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(5), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure123(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr514:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr514())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method102(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method81(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            v322: None
            closure111(v1_1, v3_1, v8, None)
            v322 = None
            return method83(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure123(v1_1, v3_1, None)
            v952 = None
            return method83(v4_1, v1_1)




def method103(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(6), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure124(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr515:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr515())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method103(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method79(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            v322: None
            closure110(v1_1, v3_1, v8, None)
            v322 = None
            return method81(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure124(v1_1, v3_1, None)
            v952 = None
            return method81(v4_1, v1_1)




def method104(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(7), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure125(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr516:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr516())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method104(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method77(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            v322: None
            closure109(v1_1, v3_1, v8, None)
            v322 = None
            return method79(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure125(v1_1, v3_1, None)
            v952 = None
            return method79(v4_1, v1_1)




def method105(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(8), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure126(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr517:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr517())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method105(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method75(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            v322: None
            closure108(v1_1, v3_1, v8, None)
            v322 = None
            return method77(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure126(v1_1, v3_1, None)
            v952 = None
            return method77(v4_1, v1_1)




def method106(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(9), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure127(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr518:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr518())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method106(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method73(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            v322: None
            closure107(v1_1, v3_1, v8, None)
            v322 = None
            return method75(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure127(v1_1, v3_1, None)
            v952 = None
            return method75(v4_1, v1_1)




def method107(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(10), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure128(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr519:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr519())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method107(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method71(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            v322: None
            closure106(v1_1, v3_1, v8, None)
            v322 = None
            return method73(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure128(v1_1, v3_1, None)
            v952 = None
            return method73(v4_1, v1_1)




def method108(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(11), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure129(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr520:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr520())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method108(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method69(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            v322: None
            closure105(v1_1, v3_1, v8, None)
            v322 = None
            return method71(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure129(v1_1, v3_1, None)
            v952 = None
            return method71(v4_1, v1_1)




def method109(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(12), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure130(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr521:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr521())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method109(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method67(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            v322: None
            closure104(v1_1, v3_1, v8, None)
            v322 = None
            return method69(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure130(v1_1, v3_1, None)
            v952 = None
            return method69(v4_1, v1_1)




def method110(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(13), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure131(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr522:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr522())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method110(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method65(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            v322: None
            closure103(v1_1, v3_1, v8, None)
            v322 = None
            return method67(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure131(v1_1, v3_1, None)
            v952 = None
            return method67(v4_1, v1_1)




def method111(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(14), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure132(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr523:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr523())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method111(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method63(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            v322: None
            closure102(v1_1, v3_1, v8, None)
            v322 = None
            return method65(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure132(v1_1, v3_1, None)
            v952 = None
            return method65(v4_1, v1_1)




def method112(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(15), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure133(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr524:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr524())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method112(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method61(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            v322: None
            closure101(v1_1, v3_1, v8, None)
            v322 = None
            return method63(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure133(v1_1, v3_1, None)
            v952 = None
            return method63(v4_1, v1_1)




def method113(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(16), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure134(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr525:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr525())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method113(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method59(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            v322: None
            closure100(v1_1, v3_1, v8, None)
            v322 = None
            return method61(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure134(v1_1, v3_1, None)
            v952 = None
            return method61(v4_1, v1_1)




def method114(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(17), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure135(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr526:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr526())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method114(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method57(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            v322: None
            closure99(v1_1, v3_1, v8, None)
            v322 = None
            return method59(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure135(v1_1, v3_1, None)
            v952 = None
            return method59(v4_1, v1_1)




def method115(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(18), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure136(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr527:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr527())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method115(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method55(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            v322: None
            closure98(v1_1, v3_1, v8, None)
            v322 = None
            return method57(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure136(v1_1, v3_1, None)
            v952 = None
            return method57(v4_1, v1_1)




def method116(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(19), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure137(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr528:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr528())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method116(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method53(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            v322: None
            closure97(v1_1, v3_1, v8, None)
            v322 = None
            return method55(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure137(v1_1, v3_1, None)
            v952 = None
            return method55(v4_1, v1_1)




def method117(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(20), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure138(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr529:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr529())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method117(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method51(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            v322: None
            closure96(v1_1, v3_1, v8, None)
            v322 = None
            return method53(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure138(v1_1, v3_1, None)
            v952 = None
            return method53(v4_1, v1_1)




def method118(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(21), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure139(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr530:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr530())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method118(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method49(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            v322: None
            closure95(v1_1, v3_1, v8, None)
            v322 = None
            return method51(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure139(v1_1, v3_1, None)
            v952 = None
            return method51(v4_1, v1_1)




def method119(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(22), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure140(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr531:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr531())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method119(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method47(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            v322: None
            closure94(v1_1, v3_1, v8, None)
            v322 = None
            return method49(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure140(v1_1, v3_1, None)
            v952 = None
            return method49(v4_1, v1_1)




def method120(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method97(int8(23), v8, v9)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11)


def closure141(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v17(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v18: None
    v17(None)
    v18 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v59: US2 = pattern_input[4].l0
    v299: US8
    class ObjectExpr532:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v59, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr532())))) == False:
        v299 = US8(1)

    else: 
        v82: None
        v17(None)
        v82 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v110: int64 | None = pattern_input_1[5]
        v109: Mut6 = pattern_input_1[4]
        v108: Mut5 = pattern_input_1[3]
        v107: Mut4 = pattern_input_1[2]
        v106: Mut3 = pattern_input_1[1]
        v105: Mut1 = pattern_input_1[0]
        v125: str = method120(v105, v106, v107, v108, v109, v110, method12(v105, v106, v107, v108, v109, v110), method16(), v0_1, v1_1)
        v141: None
        v17(None)
        v141 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v165: Mut3 = pattern_input_2[1]
        v164: Mut1 = pattern_input_2[0]
        v186: None
        closure14(v164, None)
        v186 = None
        closure15(None, v125)
        v165.l0(v125)
        v299 = US8(0, v164, v165, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method44(v0_1: UH1, v1_1: int64) -> US11:
    if v0_1.tag == 0:
        return US11(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            v322: None
            closure93(v1_1, v3_1, v8, None)
            v322 = None
            return method47(v4_1, op_addition(v1_1, v8))

        else: 
            v952: None
            closure141(v1_1, v3_1, None)
            v952 = None
            return method47(v4_1, v1_1)




def method42(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method43(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US11 = method44(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(1, method43(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def method122(v0_1: int64) -> str:
    v2_1: Mut5 = Mut5(method18())
    v16: None
    closure13(v2_1, "{ ", None)
    v16 = None
    v35: None
    closure13(v2_1, "result", None)
    v35 = None
    v54: None
    closure13(v2_1, " = ", None)
    v54 = None
    v74: None
    closure13(v2_1, ("" + str(v0_1)) + "", None)
    v74 = None
    v93: None
    closure13(v2_1, " }", None)
    v93 = None
    return v2_1.l0


def method121(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64) -> str:
    v9: str = method122(v8)
    return method21((((((((v6 + " ") + v7) + " #") + int64_to_string(v0_1.l0)) + " ") + "dice.main") + " / ") + v9)


def closure142(v0_1: int64, unit_var: None) -> None:
    def v16(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v17: None
    v16(None)
    v17 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v58: US2 = pattern_input[4].l0
    v298: US8
    class ObjectExpr533:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v58, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr533())))) == False:
        v298 = US8(1)

    else: 
        v81: None
        v16(None)
        v81 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v109: int64 | None = pattern_input_1[5]
        v108: Mut6 = pattern_input_1[4]
        v107: Mut5 = pattern_input_1[3]
        v106: Mut4 = pattern_input_1[2]
        v105: Mut3 = pattern_input_1[1]
        v104: Mut1 = pattern_input_1[0]
        v124: str = method121(v104, v105, v106, v107, v108, v109, method12(v104, v105, v106, v107, v108, v109), method16(), v0_1)
        v140: None
        v16(None)
        v140 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v164: Mut3 = pattern_input_2[1]
        v163: Mut1 = pattern_input_2[0]
        v185: None
        closure14(v163, None)
        v185 = None
        closure15(None, v124)
        v164.l0(v124)
        v298 = US8(0, v163, v164, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure91(unit_var: None, v0_1: Array[str]) -> int:
    v314: None
    closure92(None, None)
    v314 = None
    v945: None
    closure142(method42(UH1(0), int8(0)), None)
    v945 = None
    return 0


def _arrow534(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow534

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow535(v: UH1) -> Callable[[], uint8]:
    return closure3(None, v)


v1: Callable[[UH1, None], uint8] = _arrow535

def create_sequential_roller(x: UH1) -> Callable[[], uint8]:
    return v1(x)


def _arrow536(v: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return closure18(None, v)


v2: Callable[[Callable[[], uint8], bool, uint64], uint64] = _arrow536

def roll_progressively(x: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return v2(x)


def _arrow537(v: uint64) -> Callable[[UH1], uint64 | None]:
    return closure89(None, v)


v3: Callable[[uint64, UH1], uint64 | None] = _arrow537

def roll_within_bounds(x: uint64) -> Callable[[UH1], uint64 | None]:
    return v3(x)


def _arrow538(v: Array[str]) -> int:
    return closure91(None, v)


v4: Callable[[Array[str]], int] = _arrow538

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


