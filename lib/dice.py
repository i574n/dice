from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
import sys
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, from_value, op_multiply)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, record_type, int64_type, string_type, bool_type, uint64_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, uint64, int8)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, randint)

TraceState_trace_state: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr423() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr423

def _expr424() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr424

def _expr425() -> TypeInfo:
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


US0_reflection = _expr425

def _expr426() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: US0

Mut0_reflection = _expr426

def _expr427() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr427

def _expr428() -> TypeInfo:
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


US1_reflection = _expr428

def _expr429() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", US1_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US1

Mut2_reflection = _expr429

def _expr430() -> TypeInfo:
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


US2_reflection = _expr430

def _expr431() -> TypeInfo:
    return record_type("Dice.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr431

def _expr432() -> TypeInfo:
    return record_type("Dice.Mut4", [], Mut4, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: bool

Mut4_reflection = _expr432

def _expr433() -> TypeInfo:
    return record_type("Dice.Mut5", [], Mut5, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: str

Mut5_reflection = _expr433

def _expr434() -> TypeInfo:
    return record_type("Dice.Mut6", [], Mut6, lambda: [("l0", US2_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut6(Record):
    l0: US2

Mut6_reflection = _expr434

def _expr435() -> TypeInfo:
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


US3_reflection = _expr435

def _expr436() -> TypeInfo:
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


US4_reflection = _expr436

def _expr437() -> TypeInfo:
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


US5_reflection = _expr437

def _expr438() -> TypeInfo:
    return union_type("Dice.US6", [], US6, lambda: [[("f0_0", US5_reflection())], [("f1_0", US5_reflection())], [("f2_0", US5_reflection())], [("f3_0", US5_reflection())], [("f4_0", US5_reflection())]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1", "US6_2", "US6_3", "US6_4"]


US6_reflection = _expr438

def _expr439() -> TypeInfo:
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


US7_reflection = _expr439

def _expr440() -> TypeInfo:
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


US8_reflection = _expr440

def _expr441() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr441

def _expr442() -> TypeInfo:
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


US9_reflection = _expr442

def _expr443() -> TypeInfo:
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


US10_reflection = _expr443

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
    def _arrow444(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow444


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
    def _arrow445(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure6(v0_1, v3_1, None)

    return _arrow445


def method10(__unit: None=None) -> str:
    return ""


def closure10(unit_var: None, v0_1: str) -> US7:
    return US7(0, v0_1)


def method11(__unit: None=None) -> Callable[[str], US7]:
    def _arrow446(v: str) -> US7:
        return closure10(None, v)

    return _arrow446


def method9(v0_1: str) -> str:
    v28: IOsEnviron = os
    v30: Any = v28.environ
    _v34: (str | None) | None = None
    x: str | None = v30.get(v0_1)
    _v34 = some(x)
    v39: str | None
    if _v34 is None:
        raise Exception("optionm\'.of_obj / _v34=None")

    else: 
        v39 = value_3(_v34)

    v55: US7 = default_arg(map(method11(), v39), US7(1))
    if v55.tag == 0:
        return v55.fields[0]

    else: 
        return ""



def method8(__unit: None=None) -> tuple[US3, US4]:
    v1_1: str = method9("TRACE_LEVEL")
    v6: US3 = US3(0, US2(0)) if ("Verbose" == v1_1) else US3(1)
    def _arrow447(__unit: None=None) -> US3:
        v13: US3 = US3(0, US2(1)) if ("Debug" == v1_1) else US3(1)
        if v13.tag == 0:
            return US3(0, v13.fields[0])

        else: 
            v20: US3 = US3(0, US2(2)) if ("Info" == v1_1) else US3(1)
            if v20.tag == 0:
                return US3(0, v20.fields[0])

            else: 
                v27: US3 = US3(0, US2(3)) if ("Warning" == v1_1) else US3(1)
                if v27.tag == 0:
                    return US3(0, v27.fields[0])

                else: 
                    v34: US3 = US3(0, US2(4)) if ("Critical" == v1_1) else US3(1)
                    return US3(0, v34.fields[0]) if (v34.tag == 0) else US3(1)




    return (US3(0, v6.fields[0]) if (v6.tag == 0) else _arrow447(), US4(1) if (method9("AUTOMATION") != "True") else US4(0, from_value(ticks_1(now()), False)))


def closure11(unit_var: None, v0_1: str) -> None:
    pass


def method7(v0_1: US2) -> tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None]:
    pattern_input: tuple[US3, US4] = method8()
    _v1: tuple[US3, US4] = (pattern_input[0], pattern_input[1])
    v132: US4 = _v1[1]
    v131: US3 = _v1[0]
    def v138(v: str, v0_1: Any=v0_1) -> None:
        closure11(None, v)

    return (Mut1(int64(1)), Mut3(v138), Mut4(True), Mut5(""), Mut6(v131.fields[0] if (v131.tag == 0) else v0_1), v132.fields[0] if (v132.tag == 0) else None)


def closure9(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = method7(US2(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method6(v0_1: US2) -> bool:
    v3_1: None
    closure9(None, None)
    v3_1 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v35: US2 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr448:
            @property
            def Compare(self) -> Callable[[US2, US2], int]:
                return compare

        class ObjectExpr449:
            @property
            def Compare(self) -> Callable[[US2, US2], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr448())) >= find(v35, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr449()))



def closure12(unit_var: None, v0_1: int64) -> US4:
    return US4(0, v0_1)


def method13(__unit: None=None) -> Callable[[int64], US4]:
    def _arrow450(v: int64) -> US4:
        return closure12(None, v)

    return _arrow450


def method14(__unit: None=None) -> str:
    return "hh:mm:ss"


def method15(__unit: None=None) -> str:
    return "HH:mm:ss"


def method12(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None=None) -> str:
    v408: US4 = default_arg(map(method13(), v5), US4(1))
    def _arrow451(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1, v5: Any=v5) -> Any:
        v466: Any = create(op_subtraction(from_value(ticks_1(now()), False), v408.fields[0]))
        return create_1(1, 1, 1, hours(v466), minutes(v466), seconds(v466), milliseconds(v466))

    return to_string(_arrow451() if (v408.tag == 0) else now(), method15())


def method18(__unit: None=None) -> str:
    return ""


def closure13(v0_1: Mut5, v1_1: str, unit_var: None) -> None:
    v3_1: str = v0_1.l0 + v1_1
    v0_1.l0 = v3_1


def method17(v0_1: str) -> str:
    v2_1: Mut5 = Mut5(method18())
    v8: None
    closure13(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method19(__unit: None=None) -> str:
    return "\u001b[0m"


def method16(__unit: None=None) -> str:
    v2_1: str = "Debug".lower()
    return ("\u001b[94m" + method17(v2_1[0])) + method19()


def method21(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: str) -> str:
    v5: Mut5 = Mut5(method18())
    v12: None
    closure13(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure13(v5, ("" + "current_index") + "", None)
    v21 = None
    v30: None
    closure13(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure13(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure13(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure13(v5, ("" + "acc") + "", None)
    v56 = None
    v64: None
    closure13(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure13(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure13(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure13(v5, ("" + "len") + "", None)
    v89 = None
    v97: None
    closure13(v5, ("" + " = ") + "", None)
    v97 = None
    v105: None
    closure13(v5, ("" + str(v2_1)) + "", None)
    v105 = None
    v113: None
    closure13(v5, ("" + "; ") + "", None)
    v113 = None
    v122: None
    closure13(v5, ("" + "last_item") + "", None)
    v122 = None
    v130: None
    closure13(v5, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure13(v5, ("" + v3_1) + "", None)
    v138 = None
    v147: None
    closure13(v5, ("" + " }") + "", None)
    v147 = None
    return v5.l0


def method22(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method20(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64, v10: int64, v11: str) -> str:
    v12: str = method21(v8, v9, v10, v11)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll") + " / ") + v12) + "")


def closure14(v0_1: Mut1, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure16(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure15(unit_var: None, v0_1: str) -> None:
    v3_1: None
    closure16(v0_1, None)
    v3_1 = None


def method23(v0_1: str) -> None:
    v3_1: None
    closure9(None, None)
    v3_1 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    closure14(pattern_input[0], None)
    v37 = None
    closure15(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure8(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None, unit_var: None) -> None:
    if method6(US2(1)):
        v8: None
        closure9(None, None)
        v8 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v27: int64 | None = pattern_input[5]
        v26: Mut6 = pattern_input[4]
        v25: Mut5 = pattern_input[3]
        v24: Mut4 = pattern_input[2]
        v23: Mut3 = pattern_input[1]
        v22: Mut1 = pattern_input[0]
        method23(method20(v22, v23, v24, v25, v26, v27, method12(v22, v23, v24, v25, v26, v27), method16(), v0_1, v1_1, v2_1, to_text(interpolate("%A%P()", [v3_1]))))



def method24(v0_1_mut: int64, v1_1_mut: UH0) -> US1:
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


def method26(__unit: None=None) -> str:
    v1_1: Mut5 = Mut5(method18())
    return v1_1.l0


def method25(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method26()
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + v8) + "")


def closure17(unit_var: None, unit_var_1: None) -> None:
    if method6(US2(1)):
        v4_1: None
        closure9(None, None)
        v4_1 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut6 = pattern_input[4]
        v21: Mut5 = pattern_input[3]
        v20: Mut4 = pattern_input[2]
        v19: Mut3 = pattern_input[1]
        v18: Mut1 = pattern_input[0]
        method23(method25(v18, v19, v20, v21, v22, v23, method12(v18, v19, v20, v21, v22, v23), method16()))



def method5(v0_1_mut: Callable[[], UH0], v1_1_mut: Mut1, v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut2) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int64 = v1_1.l0
        v6: int64 = v2_1.l0
        v7: int64 = v3_1.l0
        v8: US1 = v4_1.l0
        v18: None
        closure8(v5, v6, v7, v8.fields[0] if (v8.tag == 0) else None, None)
        v18 = None
        v61: UH0 = v0_1(None)
        v63: US1 = method24(v1_1.l0, v61)
        if v63.tag == 0:
            v64: uint8 = v63.fields[0]
            v66: int64 = op_addition(v1_1.l0, int64(1))
            v1_1.l0 = v66
            v4_1.l0 = US1(0, v64)
            return v64

        else: 
            v70: None
            closure17(None, None)
            v70 = None
            if v3_1.l0 == int64(-1):
                v112: int64 = v1_1.l0
                v3_1.l0 = v112

            v118: int64 = int64(1) if (v2_1.l0 >= v3_1.l0) else op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v118
            v120: int64 = op_subtraction(v2_1.l0, int64(1))
            v1_1.l0 = v120
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


def method29(v0_1: uint64, v1_1: uint64, v2_1: int8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v11: None
    closure13(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure13(v4_1, ("" + "max") + "", None)
    v20 = None
    v29: None
    closure13(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure13(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure13(v4_1, ("" + "p") + "", None)
    v55 = None
    v63: None
    closure13(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure13(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure13(v4_1, ("" + "n") + "", None)
    v88 = None
    v96: None
    closure13(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure13(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def method28(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: uint64, v9: uint64, v10: int8) -> str:
    v11: str = method29(v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v11) + "")


def closure21(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method28(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v2_1, v1_1))



def method27(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64) -> int8:
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
                closure21(v0_1, v1_1, v2_1, None)
                v10 = None
                return v1_1


        else: 
            v53: None
            closure21(v0_1, v1_1, v2_1, None)
            v53 = None
            return v1_1

        break


def method33(v0_1: int8, v1_1: uint64, v2_1: uint64) -> str:
    v4_1: Mut5 = Mut5(method18())
    v11: None
    closure13(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure13(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure13(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure13(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure13(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure13(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure13(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure13(v4_1, ("" + "result") + "", None)
    v88 = None
    v96: None
    closure13(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure13(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def method32(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint64) -> str:
    v11: str = method33(v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure22(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method32(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v1_1, v0_1, v2_1))



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


def method34(v0_1_mut: int8, v1_1_mut: UH2) -> US9:
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


def method36(v0_1: int8, v1_1: uint64, v2_1: uint8, v3_1: uint64) -> str:
    v5: Mut5 = Mut5(method18())
    v12: None
    closure13(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure13(v5, ("" + "power") + "", None)
    v21 = None
    v30: None
    closure13(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure13(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure13(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure13(v5, ("" + "acc") + "", None)
    v56 = None
    v64: None
    closure13(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure13(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure13(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure13(v5, ("" + "roll") + "", None)
    v89 = None
    v97: None
    closure13(v5, ("" + " = ") + "", None)
    v97 = None
    v105: None
    closure13(v5, ("" + str(v2_1)) + "", None)
    v105 = None
    v113: None
    closure13(v5, ("" + "; ") + "", None)
    v113 = None
    v122: None
    closure13(v5, ("" + "value") + "", None)
    v122 = None
    v130: None
    closure13(v5, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure13(v5, ("" + str(v3_1)) + "", None)
    v138 = None
    v147: None
    closure13(v5, ("" + " }") + "", None)
    v147 = None
    return v5.l0


def method35(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8, v11: uint64) -> str:
    v12: str = method36(v8, v9, v10, v11)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure87(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unit_var: None) -> None:
    if method6(US2(1)):
        v8: None
        closure9(None, None)
        v8 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v27: int64 | None = pattern_input[5]
        v26: Mut6 = pattern_input[4]
        v25: Mut5 = pattern_input[3]
        v24: Mut4 = pattern_input[2]
        v23: Mut3 = pattern_input[1]
        v22: Mut1 = pattern_input[0]
        method23(method35(v22, v23, v24, v25, v26, v27, method12(v22, v23, v24, v25, v26, v27), method16(), v1_1, v0_1, v2_1, v3_1))



def method38(v0_1: int8, v1_1: uint64, v2_1: uint8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v11: None
    closure13(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure13(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure13(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure13(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure13(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure13(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure13(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure13(v4_1, ("" + "roll") + "", None)
    v88 = None
    v96: None
    closure13(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure13(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def method37(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8) -> str:
    v11: str = method38(v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure88(v0_1: uint64, v1_1: int8, v2_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method37(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v1_1, v0_1, v2_1))



def method31(v0_1_mut: int8, v1_1_mut: UH1, v2_1_mut: uint64) -> US8:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v0_1 < int8(0):
            v4_1: uint64 = op_addition(v2_1, uint64(1))
            v7: None
            closure22(v2_1, v0_1, v4_1, None)
            v7 = None
            return US8(0, v4_1, v1_1)

        elif v1_1.tag == 0:
            return US8(1)

        else: 
            v50: UH1 = v1_1.fields[1]
            v49: uint8 = v1_1.fields[0]
            if v49 > uint8(1):
                def v53(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH2:
                    return closure23(None, None)

                v55: US9 = method34(v0_1, UH2(0, uint64(1), v53))
                v59: uint64
                if v55.tag == 0:
                    v59 = v55.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v62: uint64 = op_multiply(from_integer(v49 - uint8(1), True, 4), v59)
                v65: None
                closure87(v2_1, v0_1, v49, v62, None)
                v65 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v50
                v2_1_mut = op_addition(v2_1, v62)
                continue

            else: 
                v110: None
                closure88(v2_1, v0_1, v49, None)
                v110 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v50
                v2_1_mut = v2_1
                continue


        break


def method39(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method39(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method40(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int8 = (v3_1 + int8(1)) or 0
        if v3_1 < v5:
            return method30(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)

        else: 
            v11: US8 = method31(v3_1, v4_1, uint64(0))
            if v11.tag == 0:
                v12: uint64 = v11.fields[0]
                if v12 <= v2_1:
                    return v12

                elif v1_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = method39(v3_1, v0_1, int8(0))
                    continue

                else: 
                    return method30(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


            elif v1_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = method39(v3_1, v0_1, int8(0))
                continue

            else: 
                return method30(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


        break


def method30(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1, v5_mut: int8) -> uint64:
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
            v13: US8 = method31(v3_1, v4_1, uint64(0))
            if v13.tag == 0:
                v14: uint64 = v13.fields[0]
                if v14 <= v2_1:
                    return v14

                elif v1_1:
                    return method40(v0_1, v1_1, v2_1, v3_1, method39(v3_1, v0_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = UH1(1, v0_1(None), v4_1)
                    v5_mut = v5 + int8(1)
                    continue


            elif v1_1:
                return method40(v0_1, v1_1, v2_1, v3_1, method39(v3_1, v0_1, int8(0)))

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
    return method30(v0_1, v1_1, v2_1, (int8(1) if (v2_1 == uint64(1)) else method27(v2_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure19(v0_1: Callable[[], uint8], v1_1: bool) -> Callable[[uint64], uint64]:
    def _arrow453(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64:
        return closure20(v0_1, v1_1, v)

    return _arrow453


def closure18(unit_var: None, v0_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow454(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[uint64], uint64]:
        return closure19(v0_1, v)

    return _arrow454


def method41(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
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
    v6: US8 = method31(method41(v1_1, int8(0)) - int8(1), v1_1, uint64(0))
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


def method43(v0_1: int64, v1_1: int64, v2_1: int8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v11: None
    closure13(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure13(v4_1, ("" + "max") + "", None)
    v20 = None
    v29: None
    closure13(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure13(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure13(v4_1, ("" + "p") + "", None)
    v55 = None
    v63: None
    closure13(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure13(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure13(v4_1, ("" + "n") + "", None)
    v88 = None
    v96: None
    closure13(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure13(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def method42(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    v11: str = method43(int64(9223372036854775807), int64(4738381338321616896), int8(24))
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.calculate_dice_count") + " / ") + v11) + "")


def closure92(unit_var: None, unit_var_1: None) -> None:
    if method6(US2(1)):
        v4_1: None
        closure9(None, None)
        v4_1 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut6 = pattern_input[4]
        v21: Mut5 = pattern_input[3]
        v20: Mut4 = pattern_input[2]
        v19: Mut3 = pattern_input[1]
        v18: Mut1 = pattern_input[0]
        method23(method42(v18, v19, v20, v21, v22, v23, method12(v18, v19, v20, v21, v22, v23), method16()))



def method45(__unit: None=None) -> uint8:
    v27: Any = {}
    value_2: int = randint(int(uint8(1)), int(uint8(7))) or 0
    return int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF


def method48(v0_1: int8, v1_1: int64, v2_1: uint8, v3_1: int64) -> str:
    v5: Mut5 = Mut5(method18())
    v12: None
    closure13(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure13(v5, ("" + "power") + "", None)
    v21 = None
    v30: None
    closure13(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure13(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure13(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure13(v5, ("" + "acc") + "", None)
    v56 = None
    v64: None
    closure13(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure13(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure13(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure13(v5, ("" + "roll") + "", None)
    v89 = None
    v97: None
    closure13(v5, ("" + " = ") + "", None)
    v97 = None
    v105: None
    closure13(v5, ("" + str(v2_1)) + "", None)
    v105 = None
    v113: None
    closure13(v5, ("" + "; ") + "", None)
    v113 = None
    v122: None
    closure13(v5, ("" + "value") + "", None)
    v122 = None
    v130: None
    closure13(v5, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure13(v5, ("" + str(v3_1)) + "", None)
    v138 = None
    v147: None
    closure13(v5, ("" + " }") + "", None)
    v147 = None
    return v5.l0


def method47(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(23), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure93(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method47(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method50(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(22), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure94(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method50(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method52(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(21), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure95(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method52(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method54(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(20), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method54(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method56(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(19), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method56(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method58(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(18), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method58(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method60(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(17), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method60(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method62(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(16), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method62(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method64(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(15), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method64(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method66(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(14), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method66(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method68(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(13), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method68(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method70(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(12), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method70(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method72(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(11), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method72(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method74(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(10), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method74(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method76(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(9), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method76(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method78(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(8), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method78(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method80(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(7), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method80(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method82(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(6), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method82(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method84(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(5), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method84(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method86(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(4), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method86(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method88(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(3), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method88(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method90(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(2), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method90(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method92(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(1), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method92(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method94(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    v12: str = method48(int8(0), v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v12) + "")


def closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v7: None
        closure9(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut6 = pattern_input[4]
        v24: Mut5 = pattern_input[3]
        v23: Mut4 = pattern_input[2]
        v22: Mut3 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method23(method94(v21, v22, v23, v24, v25, v26, method12(v21, v22, v23, v24, v25, v26), method16(), v0_1, v1_1, v2_1))



def method97(v0_1: int8, v1_1: int64, v2_1: int64) -> str:
    v4_1: Mut5 = Mut5(method18())
    v11: None
    closure13(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure13(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure13(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure13(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure13(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure13(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure13(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure13(v4_1, ("" + "result") + "", None)
    v88 = None
    v96: None
    closure13(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure13(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def method96(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64) -> str:
    v11: str = method97(int8(-1), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure117(v0_1: int64, v1_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method96(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method95(v0_1: UH1, v1_1: int64) -> US10:
    v2_1: int64 = op_addition(v1_1, int64(1))
    v5: None
    closure117(v1_1, v2_1, None)
    v5 = None
    return US10(0, v2_1, v0_1)


def method99(v0_1: int8, v1_1: int64, v2_1: uint8) -> str:
    v4_1: Mut5 = Mut5(method18())
    v11: None
    closure13(v4_1, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure13(v4_1, ("" + "power") + "", None)
    v20 = None
    v29: None
    closure13(v4_1, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure13(v4_1, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure13(v4_1, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure13(v4_1, ("" + "acc") + "", None)
    v55 = None
    v63: None
    closure13(v4_1, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure13(v4_1, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure13(v4_1, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure13(v4_1, ("" + "roll") + "", None)
    v88 = None
    v96: None
    closure13(v4_1, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure13(v4_1, ("" + str(v2_1)) + "", None)
    v104 = None
    v113: None
    closure13(v4_1, ("" + " }") + "", None)
    v113 = None
    return v4_1.l0


def method98(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(0), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure118(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method98(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method93(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            v10: None
            closure116(v1_1, v3_1, v7, None)
            v10 = None
            return method95(v4_1, op_addition(v1_1, v7))

        else: 
            v54: None
            closure118(v1_1, v3_1, None)
            v54 = None
            return method95(v4_1, v1_1)




def method100(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(1), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure119(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method100(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method91(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            v11: None
            closure115(v1_1, v3_1, v8, None)
            v11 = None
            return method93(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure119(v1_1, v3_1, None)
            v55 = None
            return method93(v4_1, v1_1)




def method101(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(2), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure120(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method101(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method89(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            v11: None
            closure114(v1_1, v3_1, v8, None)
            v11 = None
            return method91(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure120(v1_1, v3_1, None)
            v55 = None
            return method91(v4_1, v1_1)




def method102(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(3), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure121(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method102(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method87(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            v11: None
            closure113(v1_1, v3_1, v8, None)
            v11 = None
            return method89(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure121(v1_1, v3_1, None)
            v55 = None
            return method89(v4_1, v1_1)




def method103(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(4), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure122(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method103(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method85(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            v11: None
            closure112(v1_1, v3_1, v8, None)
            v11 = None
            return method87(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure122(v1_1, v3_1, None)
            v55 = None
            return method87(v4_1, v1_1)




def method104(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(5), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure123(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method104(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method83(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            v11: None
            closure111(v1_1, v3_1, v8, None)
            v11 = None
            return method85(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure123(v1_1, v3_1, None)
            v55 = None
            return method85(v4_1, v1_1)




def method105(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(6), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure124(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method105(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method81(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            v11: None
            closure110(v1_1, v3_1, v8, None)
            v11 = None
            return method83(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure124(v1_1, v3_1, None)
            v55 = None
            return method83(v4_1, v1_1)




def method106(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(7), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure125(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method106(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method79(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            v11: None
            closure109(v1_1, v3_1, v8, None)
            v11 = None
            return method81(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure125(v1_1, v3_1, None)
            v55 = None
            return method81(v4_1, v1_1)




def method107(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(8), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure126(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method107(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method77(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            v11: None
            closure108(v1_1, v3_1, v8, None)
            v11 = None
            return method79(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure126(v1_1, v3_1, None)
            v55 = None
            return method79(v4_1, v1_1)




def method108(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(9), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure127(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method108(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method75(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            v11: None
            closure107(v1_1, v3_1, v8, None)
            v11 = None
            return method77(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure127(v1_1, v3_1, None)
            v55 = None
            return method77(v4_1, v1_1)




def method109(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(10), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure128(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method109(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method73(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            v11: None
            closure106(v1_1, v3_1, v8, None)
            v11 = None
            return method75(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure128(v1_1, v3_1, None)
            v55 = None
            return method75(v4_1, v1_1)




def method110(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(11), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure129(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method110(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method71(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            v11: None
            closure105(v1_1, v3_1, v8, None)
            v11 = None
            return method73(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure129(v1_1, v3_1, None)
            v55 = None
            return method73(v4_1, v1_1)




def method111(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(12), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure130(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method111(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method69(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            v11: None
            closure104(v1_1, v3_1, v8, None)
            v11 = None
            return method71(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure130(v1_1, v3_1, None)
            v55 = None
            return method71(v4_1, v1_1)




def method112(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(13), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure131(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method112(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method67(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            v11: None
            closure103(v1_1, v3_1, v8, None)
            v11 = None
            return method69(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure131(v1_1, v3_1, None)
            v55 = None
            return method69(v4_1, v1_1)




def method113(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(14), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure132(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method113(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method65(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            v11: None
            closure102(v1_1, v3_1, v8, None)
            v11 = None
            return method67(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure132(v1_1, v3_1, None)
            v55 = None
            return method67(v4_1, v1_1)




def method114(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(15), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure133(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method114(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method63(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            v11: None
            closure101(v1_1, v3_1, v8, None)
            v11 = None
            return method65(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure133(v1_1, v3_1, None)
            v55 = None
            return method65(v4_1, v1_1)




def method115(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(16), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure134(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method115(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method61(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            v11: None
            closure100(v1_1, v3_1, v8, None)
            v11 = None
            return method63(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure134(v1_1, v3_1, None)
            v55 = None
            return method63(v4_1, v1_1)




def method116(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(17), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure135(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method116(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method59(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            v11: None
            closure99(v1_1, v3_1, v8, None)
            v11 = None
            return method61(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure135(v1_1, v3_1, None)
            v55 = None
            return method61(v4_1, v1_1)




def method117(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(18), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure136(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method117(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method57(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            v11: None
            closure98(v1_1, v3_1, v8, None)
            v11 = None
            return method59(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure136(v1_1, v3_1, None)
            v55 = None
            return method59(v4_1, v1_1)




def method118(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(19), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure137(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method118(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method55(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            v11: None
            closure97(v1_1, v3_1, v8, None)
            v11 = None
            return method57(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure137(v1_1, v3_1, None)
            v55 = None
            return method57(v4_1, v1_1)




def method119(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(20), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure138(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method119(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method53(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            v11: None
            closure96(v1_1, v3_1, v8, None)
            v11 = None
            return method55(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure138(v1_1, v3_1, None)
            v55 = None
            return method55(v4_1, v1_1)




def method120(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(21), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure139(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method120(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method51(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            v11: None
            closure95(v1_1, v3_1, v8, None)
            v11 = None
            return method53(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure139(v1_1, v3_1, None)
            v55 = None
            return method53(v4_1, v1_1)




def method121(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(22), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure140(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method121(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method49(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            v11: None
            closure94(v1_1, v3_1, v8, None)
            v11 = None
            return method51(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure140(v1_1, v3_1, None)
            v55 = None
            return method51(v4_1, v1_1)




def method122(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    v11: str = method99(int8(23), v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v11) + "")


def closure141(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    if method6(US2(1)):
        v6: None
        closure9(None, None)
        v6 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut6 = pattern_input[4]
        v23: Mut5 = pattern_input[3]
        v22: Mut4 = pattern_input[2]
        v21: Mut3 = pattern_input[1]
        v20: Mut1 = pattern_input[0]
        method23(method122(v20, v21, v22, v23, v24, v25, method12(v20, v21, v22, v23, v24, v25), method16(), v0_1, v1_1))



def method46(v0_1: UH1, v1_1: int64) -> US10:
    if v0_1.tag == 0:
        return US10(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            v11: None
            closure93(v1_1, v3_1, v8, None)
            v11 = None
            return method49(v4_1, op_addition(v1_1, v8))

        else: 
            v55: None
            closure141(v1_1, v3_1, None)
            v55 = None
            return method49(v4_1, v1_1)




def method44(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method45(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US10 = method46(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(1, method45(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def method124(v0_1: int64) -> str:
    v2_1: Mut5 = Mut5(method18())
    v9: None
    closure13(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18: None
    closure13(v2_1, ("" + "result") + "", None)
    v18 = None
    v27: None
    closure13(v2_1, ("" + " = ") + "", None)
    v27 = None
    v35: None
    closure13(v2_1, ("" + str(v0_1)) + "", None)
    v35 = None
    v44: None
    closure13(v2_1, ("" + " }") + "", None)
    v44 = None
    return v2_1.l0


def method123(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64) -> str:
    v9: str = method124(v8)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "dice.main") + " / ") + v9) + "")


def closure142(v0_1: int64, unit_var: None) -> None:
    if method6(US2(1)):
        v5: None
        closure9(None, None)
        v5 = None
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_3(TraceState_trace_state())
        v24: int64 | None = pattern_input[5]
        v23: Mut6 = pattern_input[4]
        v22: Mut5 = pattern_input[3]
        v21: Mut4 = pattern_input[2]
        v20: Mut3 = pattern_input[1]
        v19: Mut1 = pattern_input[0]
        method23(method123(v19, v20, v21, v22, v23, v24, method12(v19, v20, v21, v22, v23, v24), method16(), v0_1))



def closure91(unit_var: None, v0_1: Array[str]) -> int:
    v3_1: None
    closure92(None, None)
    v3_1 = None
    v48: None
    closure142(method44(UH1(0), int8(0)), None)
    v48 = None
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


