from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
import sys
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, op_multiply)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, int64_type, record_type, string_type, bool_type, uint64_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, uint64, int8)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, randint)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr318() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr318

def _expr319() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr319

def _expr320() -> TypeInfo:
    return union_type("Dice.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr320

def _expr321() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr321

def _expr322() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr322

def _expr323() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr323

def _expr324() -> TypeInfo:
    return record_type("Dice.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr324

def _expr325() -> TypeInfo:
    return record_type("Dice.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr325

def _expr326() -> TypeInfo:
    return union_type("Dice.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr326

def _expr327() -> TypeInfo:
    return union_type("Dice.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr327

def _expr328() -> TypeInfo:
    return union_type("Dice.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr328

def _expr329() -> TypeInfo:
    return union_type("Dice.US4", [], US4, lambda: [[("f0_0", lambda_type(unit_type, UH0_reflection()))], [("f1_0", UH0_reflection())]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr329

def _expr330() -> TypeInfo:
    return record_type("Dice.Mut5", [], Mut5, lambda: [("l0", US4_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: US4

Mut5_reflection = _expr330

def _expr331() -> TypeInfo:
    return union_type("Dice.US5", [], US5, lambda: [[("f0_0", uint8_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr331

def _expr332() -> TypeInfo:
    return record_type("Dice.Mut6", [], Mut6, lambda: [("l0", US5_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut6(Record):
    l0: US5

Mut6_reflection = _expr332

def _expr333() -> TypeInfo:
    return union_type("Dice.US6", [], US6, lambda: [[("f0_0", uint64_type), ("f0_1", UH1_reflection())], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr333

def _expr334() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr334

def _expr335() -> TypeInfo:
    return union_type("Dice.US7", [], US7, lambda: [[("f0_0", uint64_type)], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr335

def _expr336() -> TypeInfo:
    return union_type("Dice.US8", [], US8, lambda: [[("f0_0", int64_type), ("f0_1", UH1_reflection())], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr336

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
    def _arrow337(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow337


def method2(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method4(__unit: None=None) -> str:
    return ""


def closure6(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method5(__unit: None=None) -> Callable[[str], US1]:
    def _arrow338(v: str) -> US1:
        return closure6(None, v)

    return _arrow338


def method3(v0_1: str) -> str:
    v50: IOsEnviron = os
    v52: Any = v50.environ
    _v56: (str | None) | None = None
    x: str | None = v52.get(v0_1)
    _v56 = some(x)
    v61: str | None
    if _v56 is None:
        raise Exception("optionm\'.of_obj / _v56=None")

    else: 
        v61 = value_3(_v56)

    v77: US1 = default_arg(map(method5(), v61), US1(1))
    if v77.tag == 0:
        return v77.fields[0]

    else: 
        return ""



def method6(__unit: None=None) -> str:
    return "AUTOMATION"


def closure7(unit_var: None, v0_1: str) -> None:
    pass


def method1(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v173: str = method3(method2())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow339(__unit: None=None, v0_1: Any=v0_1) -> US2:
        v185: US2 = US2(0, US0(1)) if ("Debug" == v173) else US2(1)
        if v185.tag == 0:
            return US2(0, v185.fields[0])

        else: 
            v192: US2 = US2(0, US0(2)) if ("Info" == v173) else US2(1)
            if v192.tag == 0:
                return US2(0, v192.fields[0])

            else: 
                v199: US2 = US2(0, US0(3)) if ("Warning" == v173) else US2(1)
                if v199.tag == 0:
                    return US2(0, v199.fields[0])

                else: 
                    v206: US2 = US2(0, US0(4)) if ("Critical" == v173) else US2(1)
                    return US2(0, v206.fields[0]) if (v206.tag == 0) else US2(1)




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow339(), US3(0, ticks_1(now())) if (method3(method6()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v360(v: str, v0_1: Any=v0_1) -> None:
        closure7(None, v)

    return (Mut0(int64(1)), Mut1(v360), Mut2(True), Mut3(""), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure5(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method1(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure8(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow340(v: int64) -> US3:
        return closure8(None, v)

    return _arrow340


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3_1: Mut3, v4_1: Mut4, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method8(), v5), US3(1))
    def _arrow341(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow341() if (v238.tag == 0) else now(), method10())


def method12(__unit: None=None) -> str:
    return "\u001b[0m"


def method11(__unit: None=None) -> str:
    return ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method12()


def method14(__unit: None=None) -> str:
    return ""


def method13(__unit: None=None) -> str:
    v1_1: Mut3 = Mut3(method14())
    return v1_1.l0


def method15(v0_1: str, v1_1: str, v2_1: str, v3_1: int64, v4_1: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v3_1)) + " ") + v2_1) + " / ") + v4_1) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure9(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure11(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure10(unit_var: None, v0_1: str) -> None:
    v3_1: None
    closure11(v0_1, None)
    v3_1 = None


def method16(v0_1: str, v1_1: Mut0, v2_1: Mut1, v3_1: Mut2, v4_1: Mut3, v5: Mut4, v6: int64 | None=None) -> None:
    v9: None
    closure9(v1_1, None)
    v9 = None
    closure10(None, v0_1)
    v2_1.l0(v0_1)


def closure4(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure5(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v34: US0 = pattern_input[4].l0
    class ObjectExpr342:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v34, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr342()))):
        v41: None
        v1_1(None)
        v41 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v55: Mut0 = pattern_input_1[0]
        v81: str = method15(method7(v55, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.create_sequential_roller ()", v55.l0, method13())
        v83: None
        v1_1(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v81, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method17(v0_1_mut: UH1, v1_1_mut: UH1) -> UH1:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH1(1, v0_1.fields[0], v1_1)
            continue

        break


def method18(v0_1: UH1, v1_1: UH1) -> UH1:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return UH1(1, v0_1.fields[0], method18(v0_1.fields[1], v1_1))



def closure12(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def method19(v0_1: UH1, v1_1: UH0) -> UH0:
    if v0_1.tag == 0:
        return v1_1

    else: 
        v4_1: UH0 = method19(v0_1.fields[1], v1_1)
        def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
            return closure12(v4_1, None)

        return UH0(0, v0_1.fields[0], v5)



def closure13(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def closure14(v0_1: UH0, v1_1: Mut5, unit_var: None) -> UH0:
    v2_1: US4 = v1_1.l0
    if v2_1.tag == 0:
        v5: UH0 = v2_1.fields[0](None)
        v12: UH0 = UH0(1) if (v5.tag == 1) else UH0(0, v5.fields[0], method20(v0_1, v5.fields[1]))
        v1_1.l0 = US4(1, v12)
        return v12

    else: 
        return v2_1.fields[0]



def method20(v0_1: UH0, v1_1: Callable[[], UH0]) -> Callable[[], UH0]:
    v3_1: Mut5 = Mut5(US4(0, v1_1))
    def _arrow343(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure14(v0_1, v3_1, None)

    return _arrow343


def closure17(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3_1: str = v0_1.l0 + v1_1
    v0_1.l0 = v3_1


def method22(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None=None) -> str:
    v5: Mut3 = Mut3(method14())
    v12: None
    closure17(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure17(v5, ("" + "current_index") + "", None)
    v21 = None
    v30: None
    closure17(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure17(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure17(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure17(v5, ("" + "acc") + "", None)
    v56 = None
    v64: None
    closure17(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure17(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure17(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure17(v5, ("" + "len") + "", None)
    v89 = None
    v97: None
    closure17(v5, ("" + " = ") + "", None)
    v97 = None
    v105: None
    closure17(v5, ("" + str(v2_1)) + "", None)
    v105 = None
    v113: None
    closure17(v5, ("" + "; ") + "", None)
    v113 = None
    v122: None
    closure17(v5, ("" + "last_item") + "", None)
    v122 = None
    v130: None
    closure17(v5, ("" + " = ") + "", None)
    v130 = None
    v165: None
    closure17(v5, ("" + to_text(interpolate("%A%P()", [v3_1]))) + "", None)
    v165 = None
    v174: None
    closure17(v5, ("" + " }") + "", None)
    v174 = None
    return v5.l0


def closure16(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: US0 = pattern_input[4].l0
    class ObjectExpr344:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v38, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr344()))):
        v45: None
        v5(None)
        v45 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v59: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v59, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.create_sequential_roller / roll", v59.l0, method22(v0_1, v1_1, v2_1, v3_1))
        v87: None
        v5(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method23(v0_1_mut: int64, v1_1_mut: UH0) -> US5:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US5(1)

        elif v0_1 <= int64(0):
            return US5(0, v1_1.fields[0])

        else: 
            v0_1_mut = op_subtraction(v0_1, int64(1))
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def closure18(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure5(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v34: US0 = pattern_input[4].l0
    class ObjectExpr345:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v34, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr345()))):
        v41: None
        v1_1(None)
        v41 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v55: Mut0 = pattern_input_1[0]
        v81: str = method15(method7(v55, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.create_sequential_roller / roll / None", v55.l0, method13())
        v83: None
        v1_1(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v81, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method21(v0_1_mut: Callable[[], UH0], v1_1_mut: Mut0, v2_1_mut: Mut0, v3_1_mut: Mut0, v4_1_mut: Mut6) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int64 = v1_1.l0
        v6: int64 = v2_1.l0
        v7: int64 = v3_1.l0
        v8: US5 = v4_1.l0
        v18: None
        closure16(v5, v6, v7, v8.fields[0] if (v8.tag == 0) else None, None)
        v18 = None
        v134: UH0 = v0_1(None)
        v136: US5 = method23(v1_1.l0, v134)
        if v136.tag == 0:
            v137: uint8 = v136.fields[0]
            v139: int64 = op_addition(v1_1.l0, int64(1))
            v1_1.l0 = v139
            v4_1.l0 = US5(0, v137)
            return v137

        else: 
            v143: None
            closure18(None, None)
            v143 = None
            if v3_1.l0 == int64(-1):
                v261: int64 = v1_1.l0
                v3_1.l0 = v261

            v267: int64 = int64(1) if (v2_1.l0 >= v3_1.l0) else op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v267
            v269: int64 = op_subtraction(v2_1.l0, int64(1))
            v1_1.l0 = v269
            v4_1.l0 = US5(1)
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1
            v3_1_mut = v3_1
            v4_1_mut = v4_1
            continue

        break


def closure15(v0_1: Callable[[], UH0], v1_1: Mut0, v2_1: Mut0, v3_1: Mut0, v4_1: Mut6, unit_var: None) -> uint8:
    return method21(v0_1, v1_1, v2_1, v3_1, v4_1)


def closure3(unit_var: None, v0_1: UH1) -> Callable[[], uint8]:
    v3_1: None
    closure4(None, None)
    v3_1 = None
    v123: UH0 = method19(method18(v0_1, method17(v0_1, UH1(0))), UH0(1))
    def v124(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure13(v123, None)

    v125: Callable[[], UH0] = method20(v123, v124)
    v126: Mut0 = Mut0(int64(0))
    v127: Mut0 = Mut0(int64(1))
    v128: Mut0 = Mut0(int64(-1))
    v130: Mut6 = Mut6(US5(1))
    def _arrow346(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint8:
        return closure15(v125, v126, v127, v128, v130, None)

    return _arrow346


def method25(v0_1: uint64, v1_1: int8, v2_1: uint64) -> str:
    v4_1: Mut3 = Mut3(method14())
    v11: None
    closure17(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure17(v4_1, ("" + "max") + "", None)
    v20 = None
    v29: None
    closure17(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure17(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure17(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure17(v4_1, ("" + "n") + "", None)
    v55 = None
    v63: None
    closure17(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure17(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure17(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure17(v4_1, ("" + "p") + "", None)
    v88 = None
    v96: None
    closure17(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure17(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure17(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def closure22(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr347:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr347()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.calculate_dice_count", v58.l0, method25(v0_1, v1_1, v2_1))
        v86: None
        v4_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method24(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64) -> int8:
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
                v10: None
                closure22(v0_1, v1_1, v2_1, None)
                v10 = None
                return v1_1


        else: 
            v129: None
            closure22(v0_1, v1_1, v2_1, None)
            v129 = None
            return v1_1

        break


def method28(v0_1: int8, v1_1: uint64, v2_1: uint64) -> str:
    v4_1: Mut3 = Mut3(method14())
    v11: None
    closure17(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure17(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure17(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure17(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure17(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure17(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure17(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure17(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure17(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure17(v4_1, ("" + "result") + "", None)
    v88 = None
    v96: None
    closure17(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure17(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure17(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def closure23(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr348:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr348()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method28(v1_1, v0_1, v2_1))
        v86: None
        v4_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure87(unit_var: None, unit_var_1: None) -> UH2:
    return UH2(1)


def closure86(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure87(None, None)

    return UH2(0, uint64(9223372036854775808), v0_1)


def closure85(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure86(None, None)

    return UH2(0, uint64(4611686018427387904), v0_1)


def closure84(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure85(None, None)

    return UH2(0, uint64(6917529027641081856), v0_1)


def closure83(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure84(None, None)

    return UH2(0, uint64(1152921504606846976), v0_1)


def closure82(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure83(None, None)

    return UH2(0, uint64(15564440312192434176), v0_1)


def closure81(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure82(None, None)

    return UH2(0, uint64(11817445422220181504), v0_1)


def closure80(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure81(None, None)

    return UH2(0, uint64(5044031582654955520), v0_1)


def closure79(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure80(None, None)

    return UH2(0, uint64(6989586621679009792), v0_1)


def closure78(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure79(None, None)

    return UH2(0, uint64(16537217831704461312), v0_1)


def closure77(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure78(None, None)

    return UH2(0, uint64(11979575008805519360), v0_1)


def closure76(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure77(None, None)

    return UH2(0, uint64(14294425217273954304), v0_1)


def closure75(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure76(None, None)

    return UH2(0, uint64(2382404202878992384), v0_1)


def closure74(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure75(None, None)

    return UH2(0, uint64(6545982058383015936), v0_1)


def closure73(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure74(None, None)

    return UH2(0, uint64(10314369046585278464), v0_1)


def closure72(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure73(None, None)

    return UH2(0, uint64(4793518853382471680), v0_1)


def closure71(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure72(None, None)

    return UH2(0, uint64(3873377154515337216), v0_1)


def closure70(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure71(None, None)

    return UH2(0, uint64(645562859085889536), v0_1)


def closure69(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure70(None, None)

    return UH2(0, uint64(107593809847648256), v0_1)


def closure68(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure69(None, None)

    return UH2(0, uint64(3092389647259533312), v0_1)


def closure67(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure68(None, None)

    return UH2(0, uint64(9738770311398031360), v0_1)


def closure66(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure67(None, None)

    return UH2(0, uint64(16995415113324298240), v0_1)


def closure65(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure66(None, None)

    return UH2(0, uint64(8981483876790566912), v0_1)


def closure64(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure65(None, None)

    return UH2(0, uint64(13794743361938128896), v0_1)


def closure63(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure64(None, None)

    return UH2(0, uint64(2299123893656354816), v0_1)


def closure62(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure63(None, None)

    return UH2(0, uint64(3457644661227651072), v0_1)


def closure61(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure62(None, None)

    return UH2(0, uint64(576274110204608512), v0_1)


def closure60(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure61(None, None)

    return UH2(0, uint64(6244960376270618624), v0_1)


def closure59(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure60(None, None)

    return UH2(0, uint64(13338656111851470848), v0_1)


def closure58(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure59(None, None)

    return UH2(0, uint64(14520938734448279552), v0_1)


def closure57(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure58(None, None)

    return UH2(0, uint64(14717985838214414336), v0_1)


def closure56(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure57(None, None)

    return UH2(0, uint64(5527454985320660992), v0_1)


def closure55(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure56(None, None)

    return UH2(0, uint64(16293529225644736512), v0_1)


def closure54(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure55(None, None)

    return UH2(0, uint64(11938960241128898560), v0_1)


def closure53(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure54(None, None)

    return UH2(0, uint64(8138741398091333632), v0_1)


def closure52(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure53(None, None)

    return UH2(0, uint64(7505371590918406144), v0_1)


def closure51(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure52(None, None)

    return UH2(0, uint64(16623181993244360704), v0_1)


def closure50(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure51(None, None)

    return UH2(0, uint64(8919445023443910656), v0_1)


def closure49(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure50(None, None)

    return UH2(0, uint64(4561031516192243712), v0_1)


def closure48(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure49(None, None)

    return UH2(0, uint64(9983543956220149760), v0_1)


def closure47(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure48(None, None)

    return UH2(0, uint64(4738381338321616896), v0_1)


def closure46(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure47(None, None)

    return UH2(0, uint64(789730223053602816), v0_1)


def closure45(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure46(None, None)

    return UH2(0, uint64(131621703842267136), v0_1)


def closure44(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure45(None, None)

    return UH2(0, uint64(21936950640377856), v0_1)


def closure43(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure44(None, None)

    return UH2(0, uint64(3656158440062976), v0_1)


def closure42(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure43(None, None)

    return UH2(0, uint64(609359740010496), v0_1)


def closure41(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure42(None, None)

    return UH2(0, uint64(101559956668416), v0_1)


def closure40(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure41(None, None)

    return UH2(0, uint64(16926659444736), v0_1)


def closure39(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure40(None, None)

    return UH2(0, uint64(2821109907456), v0_1)


def closure38(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure39(None, None)

    return UH2(0, uint64(470184984576), v0_1)


def closure37(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure38(None, None)

    return UH2(0, uint64(78364164096), v0_1)


def closure36(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure37(None, None)

    return UH2(0, uint64(13060694016), v0_1)


def closure35(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure36(None, None)

    return UH2(0, uint64(2176782336), v0_1)


def closure34(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure35(None, None)

    return UH2(0, uint64(362797056), v0_1)


def closure33(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure34(None, None)

    return UH2(0, uint64(60466176), v0_1)


def closure32(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure33(None, None)

    return UH2(0, uint64(10077696), v0_1)


def closure31(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure32(None, None)

    return UH2(0, uint64(1679616), v0_1)


def closure30(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure31(None, None)

    return UH2(0, uint64(279936), v0_1)


def closure29(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure30(None, None)

    return UH2(0, uint64(46656), v0_1)


def closure28(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure29(None, None)

    return UH2(0, uint64(7776), v0_1)


def closure27(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure28(None, None)

    return UH2(0, uint64(1296), v0_1)


def closure26(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure27(None, None)

    return UH2(0, uint64(216), v0_1)


def closure25(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure26(None, None)

    return UH2(0, uint64(36), v0_1)


def closure24(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure25(None, None)

    return UH2(0, uint64(6), v0_1)


def method29(v0_1_mut: int8, v1_1_mut: UH2) -> US7:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US7(1)

        elif v0_1 <= int8(0):
            return US7(0, v1_1.fields[0])

        else: 
            v0_1_mut = v0_1 - int8(1)
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method30(v0_1: int8, v1_1: uint64, v2_1: uint8, v3_1: uint64) -> str:
    v5: Mut3 = Mut3(method14())
    v12: None
    closure17(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure17(v5, ("" + "power") + "", None)
    v21 = None
    v30: None
    closure17(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure17(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure17(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure17(v5, ("" + "acc") + "", None)
    v56 = None
    v64: None
    closure17(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure17(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure17(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure17(v5, ("" + "roll") + "", None)
    v89 = None
    v97: None
    closure17(v5, ("" + " = ") + "", None)
    v97 = None
    v105: None
    closure17(v5, ("" + str(v2_1)) + "", None)
    v105 = None
    v113: None
    closure17(v5, ("" + "; ") + "", None)
    v113 = None
    v122: None
    closure17(v5, ("" + "value") + "", None)
    v122 = None
    v130: None
    closure17(v5, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure17(v5, ("" + str(v3_1)) + "", None)
    v138 = None
    v147: None
    closure17(v5, ("" + " }") + "", None)
    v147 = None
    return v5.l0


def closure88(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: US0 = pattern_input[4].l0
    class ObjectExpr349:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v38, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr349()))):
        v45: None
        v5(None)
        v45 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v59: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v59, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v59.l0, method30(v1_1, v0_1, v2_1, v3_1))
        v87: None
        v5(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method31(v0_1: int8, v1_1: uint64, v2_1: uint8) -> str:
    v4_1: Mut3 = Mut3(method14())
    v11: None
    closure17(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure17(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure17(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure17(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure17(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure17(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure17(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure17(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure17(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure17(v4_1, ("" + "roll") + "", None)
    v88 = None
    v96: None
    closure17(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure17(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure17(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def closure89(v0_1: uint64, v1_1: int8, v2_1: uint8, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr350:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr350()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method31(v1_1, v0_1, v2_1))
        v86: None
        v4_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method27(v0_1_mut: int8, v1_1_mut: UH1, v2_1_mut: uint64) -> US6:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v0_1 < int8(0):
            v4_1: uint64 = op_addition(v2_1, uint64(1))
            v7: None
            closure23(v2_1, v0_1, v4_1, None)
            v7 = None
            return US6(0, v4_1, v1_1)

        elif v1_1.tag == 0:
            return US6(1)

        else: 
            v126: UH1 = v1_1.fields[1]
            v125: uint8 = v1_1.fields[0]
            if v125 > uint8(1):
                def v129(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH2:
                    return closure24(None, None)

                v131: US7 = method29(v0_1, UH2(0, uint64(1), v129))
                v135: uint64
                if v131.tag == 0:
                    v135 = v131.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v138: uint64 = op_multiply(from_integer(v125 - uint8(1), True, 4), v135)
                v141: None
                closure88(v2_1, v0_1, v125, v138, None)
                v141 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v126
                v2_1_mut = op_addition(v2_1, v138)
                continue

            else: 
                v262: None
                closure89(v2_1, v0_1, v125, None)
                v262 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v126
                v2_1_mut = v2_1
                continue


        break


def method32(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method32(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method33(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int8 = (v3_1 + int8(1)) or 0
        if v3_1 < v5:
            return method26(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)

        else: 
            v11: US6 = method27(v3_1, v4_1, uint64(0))
            if v11.tag == 0:
                v12: uint64 = v11.fields[0]
                if v12 <= v2_1:
                    return v12

                elif v1_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = method32(v3_1, v0_1, int8(0))
                    continue

                else: 
                    return method26(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


            elif v1_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = method32(v3_1, v0_1, int8(0))
                continue

            else: 
                return method26(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


        break


def method26(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1, v5_mut: int8) -> uint64:
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
            v13: US6 = method27(v3_1, v4_1, uint64(0))
            if v13.tag == 0:
                v14: uint64 = v13.fields[0]
                if v14 <= v2_1:
                    return v14

                elif v1_1:
                    return method33(v0_1, v1_1, v2_1, v3_1, method32(v3_1, v0_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = UH1(1, v0_1(None), v4_1)
                    v5_mut = v5 + int8(1)
                    continue


            elif v1_1:
                return method33(v0_1, v1_1, v2_1, v3_1, method32(v3_1, v0_1, int8(0)))

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = UH1(1, v0_1(None), v4_1)
                v5_mut = v5 + int8(1)
                continue


        break


def closure21(v0_1: Callable[[], uint8], v1_1: bool, v2_1: uint64) -> uint64:
    return method26(v0_1, v1_1, v2_1, (int8(1) if (v2_1 == uint64(1)) else method24(v2_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure20(v0_1: Callable[[], uint8], v1_1: bool) -> Callable[[uint64], uint64]:
    def _arrow351(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64:
        return closure21(v0_1, v1_1, v)

    return _arrow351


def closure19(unit_var: None, v0_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow352(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[uint64], uint64]:
        return closure20(v0_1, v)

    return _arrow352


def method34(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = v1_1 + int8(1)
            continue

        break


def closure91(v0_1: uint64, v1_1: UH1) -> uint64 | None:
    v6: US6 = method27(method34(v1_1, int8(0)) - int8(1), v1_1, uint64(0))
    v16: US7
    if v6.tag == 0:
        v7: uint64 = v6.fields[0]
        v16 = US7(0, v7) if ((v7 <= v0_1) if (v7 >= uint64(1)) else False) else US7(1)

    else: 
        v16 = US7(1)

    if v16.tag == 0:
        return v16.fields[0]

    else: 
        return None



def closure90(unit_var: None, v0_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow353(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint64 | None:
        return closure91(v0_1, v)

    return _arrow353


def method35(v0_1: int64, v1_1: int8, v2_1: int64) -> str:
    v4_1: Mut3 = Mut3(method14())
    v11: None
    closure17(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure17(v4_1, ("" + "max") + "", None)
    v20 = None
    v29: None
    closure17(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure17(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure17(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure17(v4_1, ("" + "n") + "", None)
    v55 = None
    v63: None
    closure17(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure17(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure17(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure17(v4_1, ("" + "p") + "", None)
    v88 = None
    v96: None
    closure17(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure17(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure17(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def closure93(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure5(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v34: US0 = pattern_input[4].l0
    class ObjectExpr354:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v34, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr354()))):
        v41: None
        v1_1(None)
        v41 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v55: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v55, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.calculate_dice_count", v55.l0, method35(int64(9223372036854775807), int8(24), int64(4738381338321616896)))
        v86: None
        v1_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method37(__unit: None=None) -> uint8:
    v17: Any = {}
    value_2: int = randint(int(uint8(1)), int(uint8(7))) or 0
    return int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF


def method39(v0_1: int8, v1_1: int64, v2_1: uint8, v3_1: int64) -> str:
    v5: Mut3 = Mut3(method14())
    v12: None
    closure17(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure17(v5, ("" + "power") + "", None)
    v21 = None
    v30: None
    closure17(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure17(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure17(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure17(v5, ("" + "acc") + "", None)
    v56 = None
    v64: None
    closure17(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure17(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure17(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure17(v5, ("" + "roll") + "", None)
    v89 = None
    v97: None
    closure17(v5, ("" + " = ") + "", None)
    v97 = None
    v105: None
    closure17(v5, ("" + str(v2_1)) + "", None)
    v105 = None
    v113: None
    closure17(v5, ("" + "; ") + "", None)
    v113 = None
    v122: None
    closure17(v5, ("" + "value") + "", None)
    v122 = None
    v130: None
    closure17(v5, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure17(v5, ("" + str(v3_1)) + "", None)
    v138 = None
    v147: None
    closure17(v5, ("" + " }") + "", None)
    v147 = None
    return v5.l0


def closure94(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr355:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr355()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(23), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure95(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr356:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr356()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(22), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr357:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr357()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(21), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr358:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr358()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(20), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr359:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr359()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(19), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr360:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr360()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(18), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr361:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr361()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(17), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr362:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr362()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(16), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr363:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr363()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(15), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr364:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr364()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(14), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr365:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr365()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(13), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr366:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr366()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(12), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr367:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr367()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(11), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr368:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr368()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(10), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr369:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr369()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(9), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr370:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr370()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(8), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr371:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr371()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(7), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr372:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr372()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(6), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr373:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr373()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(5), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr374:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr374()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(4), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr375:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr375()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(3), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr376:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr376()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(2), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr377:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr377()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(1), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure117(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr378:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr378()))):
        v44: None
        v4_1(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v85: str = method15(method7(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v58.l0, method39(int8(0), v0_1, v1_1, v2_1))
        v87: None
        v4_1(None)
        v87 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v85, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method64(v0_1: int8, v1_1: int64, v2_1: int64) -> str:
    v4_1: Mut3 = Mut3(method14())
    v11: None
    closure17(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure17(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure17(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure17(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure17(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure17(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure17(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure17(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure17(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure17(v4_1, ("" + "result") + "", None)
    v88 = None
    v96: None
    closure17(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure17(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure17(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def closure118(v0_1: int64, v1_1: int64, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr379:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr379()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method64(int8(-1), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method63(v0_1: UH1, v1_1: int64) -> US8:
    v2_1: int64 = op_addition(v1_1, int64(1))
    v5: None
    closure118(v1_1, v2_1, None)
    v5 = None
    return US8(0, v2_1, v0_1)


def method65(v0_1: int8, v1_1: int64, v2_1: uint8) -> str:
    v4_1: Mut3 = Mut3(method14())
    v11: None
    closure17(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure17(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure17(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure17(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure17(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure17(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure17(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure17(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure17(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure17(v4_1, ("" + "roll") + "", None)
    v88 = None
    v96: None
    closure17(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure17(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure17(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def closure119(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr380:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr380()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(0), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method62(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            v10: None
            closure117(v1_1, v3_1, v7, None)
            v10 = None
            return method63(v4_1, op_addition(v1_1, v7))

        else: 
            v131: None
            closure119(v1_1, v3_1, None)
            v131 = None
            return method63(v4_1, v1_1)




def closure120(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr381:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr381()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(1), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method61(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            v11: None
            closure116(v1_1, v3_1, v8, None)
            v11 = None
            return method62(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure120(v1_1, v3_1, None)
            v132 = None
            return method62(v4_1, v1_1)




def closure121(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr382:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr382()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(2), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method60(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            v11: None
            closure115(v1_1, v3_1, v8, None)
            v11 = None
            return method61(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure121(v1_1, v3_1, None)
            v132 = None
            return method61(v4_1, v1_1)




def closure122(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr383:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr383()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(3), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method59(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            v11: None
            closure114(v1_1, v3_1, v8, None)
            v11 = None
            return method60(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure122(v1_1, v3_1, None)
            v132 = None
            return method60(v4_1, v1_1)




def closure123(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr384:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr384()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(4), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method58(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            v11: None
            closure113(v1_1, v3_1, v8, None)
            v11 = None
            return method59(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure123(v1_1, v3_1, None)
            v132 = None
            return method59(v4_1, v1_1)




def closure124(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr385:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr385()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(5), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method57(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            v11: None
            closure112(v1_1, v3_1, v8, None)
            v11 = None
            return method58(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure124(v1_1, v3_1, None)
            v132 = None
            return method58(v4_1, v1_1)




def closure125(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr386:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr386()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(6), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method56(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            v11: None
            closure111(v1_1, v3_1, v8, None)
            v11 = None
            return method57(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure125(v1_1, v3_1, None)
            v132 = None
            return method57(v4_1, v1_1)




def closure126(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr387:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr387()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(7), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method55(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            v11: None
            closure110(v1_1, v3_1, v8, None)
            v11 = None
            return method56(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure126(v1_1, v3_1, None)
            v132 = None
            return method56(v4_1, v1_1)




def closure127(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr388:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr388()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(8), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method54(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            v11: None
            closure109(v1_1, v3_1, v8, None)
            v11 = None
            return method55(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure127(v1_1, v3_1, None)
            v132 = None
            return method55(v4_1, v1_1)




def closure128(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr389:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr389()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(9), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method53(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            v11: None
            closure108(v1_1, v3_1, v8, None)
            v11 = None
            return method54(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure128(v1_1, v3_1, None)
            v132 = None
            return method54(v4_1, v1_1)




def closure129(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr390:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr390()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(10), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method52(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            v11: None
            closure107(v1_1, v3_1, v8, None)
            v11 = None
            return method53(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure129(v1_1, v3_1, None)
            v132 = None
            return method53(v4_1, v1_1)




def closure130(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr391:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr391()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(11), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method51(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            v11: None
            closure106(v1_1, v3_1, v8, None)
            v11 = None
            return method52(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure130(v1_1, v3_1, None)
            v132 = None
            return method52(v4_1, v1_1)




def closure131(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr392:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr392()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(12), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method50(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            v11: None
            closure105(v1_1, v3_1, v8, None)
            v11 = None
            return method51(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure131(v1_1, v3_1, None)
            v132 = None
            return method51(v4_1, v1_1)




def closure132(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr393:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr393()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(13), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method49(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            v11: None
            closure104(v1_1, v3_1, v8, None)
            v11 = None
            return method50(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure132(v1_1, v3_1, None)
            v132 = None
            return method50(v4_1, v1_1)




def closure133(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr394:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr394()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(14), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method48(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            v11: None
            closure103(v1_1, v3_1, v8, None)
            v11 = None
            return method49(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure133(v1_1, v3_1, None)
            v132 = None
            return method49(v4_1, v1_1)




def closure134(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr395:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr395()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(15), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method47(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            v11: None
            closure102(v1_1, v3_1, v8, None)
            v11 = None
            return method48(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure134(v1_1, v3_1, None)
            v132 = None
            return method48(v4_1, v1_1)




def closure135(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr396:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr396()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(16), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method46(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            v11: None
            closure101(v1_1, v3_1, v8, None)
            v11 = None
            return method47(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure135(v1_1, v3_1, None)
            v132 = None
            return method47(v4_1, v1_1)




def closure136(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr397:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr397()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(17), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method45(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            v11: None
            closure100(v1_1, v3_1, v8, None)
            v11 = None
            return method46(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure136(v1_1, v3_1, None)
            v132 = None
            return method46(v4_1, v1_1)




def closure137(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr398:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr398()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(18), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method44(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            v11: None
            closure99(v1_1, v3_1, v8, None)
            v11 = None
            return method45(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure137(v1_1, v3_1, None)
            v132 = None
            return method45(v4_1, v1_1)




def closure138(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr399:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr399()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(19), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method43(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            v11: None
            closure98(v1_1, v3_1, v8, None)
            v11 = None
            return method44(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure138(v1_1, v3_1, None)
            v132 = None
            return method44(v4_1, v1_1)




def closure139(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr400:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr400()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(20), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method42(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            v11: None
            closure97(v1_1, v3_1, v8, None)
            v11 = None
            return method43(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure139(v1_1, v3_1, None)
            v132 = None
            return method43(v4_1, v1_1)




def closure140(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr401:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr401()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(21), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method41(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            v11: None
            closure96(v1_1, v3_1, v8, None)
            v11 = None
            return method42(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure140(v1_1, v3_1, None)
            v132 = None
            return method42(v4_1, v1_1)




def closure141(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr402:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr402()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(22), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method40(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            v11: None
            closure95(v1_1, v3_1, v8, None)
            v11 = None
            return method41(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure141(v1_1, v3_1, None)
            v132 = None
            return method41(v4_1, v1_1)




def closure142(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr403:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr403()))):
        v43: None
        v3_1(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v84: str = method15(method7(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.accumulate_dice_rolls", v57.l0, method65(int8(23), v0_1, v1_1))
        v86: None
        v3_1(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v84, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method38(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            v11: None
            closure94(v1_1, v3_1, v8, None)
            v11 = None
            return method40(v4_1, op_addition(v1_1, v8))

        else: 
            v132: None
            closure142(v1_1, v3_1, None)
            v132 = None
            return method40(v4_1, v1_1)




def method36(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method37(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US8 = method38(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(1, method37(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def method66(v0_1: int64) -> str:
    v2_1: Mut3 = Mut3(method14())
    v9: None
    closure17(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18: None
    closure17(v2_1, ("" + "result") + "", None)
    v18 = None
    v27: None
    closure17(v2_1, ("" + " = ") + "", None)
    v27 = None
    v35: None
    closure17(v2_1, ("" + str(v0_1)) + "", None)
    v35 = None
    v44: None
    closure17(v2_1, ("" + " }") + "", None)
    v44 = None
    return v2_1.l0


def closure143(v0_1: int64, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v3_1: None
    v2_1(None)
    v3_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    class ObjectExpr404:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr404()))):
        v42: None
        v2_1(None)
        v42 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v56: Mut0 = pattern_input_1[0]
        v82: str = method15(method7(v56, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method11(), "dice.main", v56.l0, method66(v0_1))
        v84: None
        v2_1(None)
        v84 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        method16(v82, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure92(unit_var: None, v0_1: Array[str]) -> int:
    v3_1: None
    closure93(None, None)
    v3_1 = None
    v127: None
    closure143(method36(UH1(0), int8(0)), None)
    v127 = None
    return 0


def _arrow405(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow405

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow406(v: UH1) -> Callable[[], uint8]:
    return closure3(None, v)


v1: Callable[[UH1, None], uint8] = _arrow406

def create_sequential_roller(x: UH1) -> Callable[[], uint8]:
    return v1(x)


def _arrow407(v: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return closure19(None, v)


v2: Callable[[Callable[[], uint8], bool, uint64], uint64] = _arrow407

def roll_progressively(x: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return v2(x)


def _arrow408(v: uint64) -> Callable[[UH1], uint64 | None]:
    return closure90(None, v)


v3: Callable[[uint64, UH1], uint64 | None] = _arrow408

def roll_within_bounds(x: uint64) -> Callable[[UH1], uint64 | None]:
    return v3(x)


def _arrow409(v: Array[str]) -> int:
    return closure92(None, v)


v4: Callable[[Array[str]], int] = _arrow409

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


