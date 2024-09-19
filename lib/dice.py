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
from fable_modules.fable_library.option import (some, value as value_3, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, int64_type, record_type, string_type, bool_type, uint64_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef, uint8, uint64, int8)
from fable_modules.fable_library.util import (create_atom, ignore, to_enumerable, compare, randint)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr337() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint8_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr337

def _expr338() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[], [("Item1", uint8_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr338

def _expr339() -> TypeInfo:
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


US0_reflection = _expr339

def _expr340() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr340

def _expr341() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr341

def _expr342() -> TypeInfo:
    return record_type("Dice.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr342

def _expr343() -> TypeInfo:
    return record_type("Dice.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr343

def _expr344() -> TypeInfo:
    return record_type("Dice.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr344

def _expr345() -> TypeInfo:
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


US1_reflection = _expr345

def _expr346() -> TypeInfo:
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


US2_reflection = _expr346

def _expr347() -> TypeInfo:
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


US3_reflection = _expr347

def _expr348() -> TypeInfo:
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


US4_reflection = _expr348

def _expr349() -> TypeInfo:
    return record_type("Dice.Mut5", [], Mut5, lambda: [("l0", US4_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: US4

Mut5_reflection = _expr349

def _expr350() -> TypeInfo:
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


US5_reflection = _expr350

def _expr351() -> TypeInfo:
    return record_type("Dice.Mut6", [], Mut6, lambda: [("l0", US5_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut6(Record):
    l0: US5

Mut6_reflection = _expr351

def _expr352() -> TypeInfo:
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


US6_reflection = _expr352

def _expr353() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr353

def _expr354() -> TypeInfo:
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


US7_reflection = _expr354

def _expr355() -> TypeInfo:
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


US8_reflection = _expr355

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
    def _arrow356(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow356


def method2(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method4(__unit: None=None) -> str:
    return ""


def closure6(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure7(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow357(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow357()))


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

    _v64: FSharpRef[US1 | None] = FSharpRef(None)
    v69: None
    def v66(v: US1 | None=None, v0_1: Any=v0_1) -> FSharpRef[US1 | None]:
        return closure6(_v64, v)

    closure7(v61, v66, None)
    v69 = None
    v84: US1 = default_arg(_v64.contents, US1(1))
    if v84.tag == 0:
        return v84.fields[0]

    else: 
        return ""



def method5(__unit: None=None) -> str:
    return "AUTOMATION"


def closure8(unit_var: None, v0_1: str) -> None:
    pass


def method1(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v173: str = method3(method2())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow358(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow358(), US3(0, ticks_1(now())) if (method3(method5()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v360(v: str, v0_1: Any=v0_1) -> None:
        closure8(None, v)

    return (Mut0(int64(0)), Mut1(v360), Mut2(True), Mut3(""), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure5(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method1(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure9(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure10(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure11(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow359(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow359()))


def method6(__unit: None=None) -> str:
    return "hh:mm:ss"


def method7(__unit: None=None) -> str:
    return "HH:mm:ss"


def method8(__unit: None=None) -> str:
    return "\u001b[0m"


def method9(__unit: None=None) -> str:
    return ""


def closure13(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure12(unit_var: None, v0_1: str) -> None:
    v3_1: None
    closure13(v0_1, None)
    v3_1 = None


def closure4(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure5(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v35: None
    v1_1(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr360:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr360()))):
        v75: None
        closure9(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure10(_v358, v)

        closure11(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow361(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow361() if (v378.tag == 0) else now(), method7())
        v624: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method9())
        v697: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "dice.create_sequential_roller ()") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v697)
        pattern_input[1].l0(v697)



def method10(v0_1_mut: UH1, v1_1_mut: UH1) -> UH1:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH1(1, v0_1.fields[0], v1_1)
            continue

        break


def method11(v0_1: UH1, v1_1: UH1) -> UH1:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return UH1(1, v0_1.fields[0], method11(v0_1.fields[1], v1_1))



def closure14(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def method12(v0_1: UH1, v1_1: UH0) -> UH0:
    if v0_1.tag == 0:
        return v1_1

    else: 
        v4_1: UH0 = method12(v0_1.fields[1], v1_1)
        def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
            return closure14(v4_1, None)

        return UH0(0, v0_1.fields[0], v5)



def closure15(v0_1: UH0, unit_var: None) -> UH0:
    return v0_1


def closure16(v0_1: UH0, v1_1: Mut5, unit_var: None) -> UH0:
    v2_1: US4 = v1_1.l0
    if v2_1.tag == 0:
        v5: UH0 = v2_1.fields[0](None)
        v12: UH0 = UH0(1) if (v5.tag == 1) else UH0(0, v5.fields[0], method13(v0_1, v5.fields[1]))
        v1_1.l0 = US4(1, v12)
        return v12

    else: 
        return v2_1.fields[0]



def method13(v0_1: UH0, v1_1: Callable[[], UH0]) -> Callable[[], UH0]:
    v3_1: Mut5 = Mut5(US4(0, v1_1))
    def _arrow362(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure16(v0_1, v3_1, None)

    return _arrow362


def closure19(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3_1: str = v0_1.l0 + v1_1
    v0_1.l0 = v3_1


def closure18(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v39: None
    v5(None)
    v39 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v71: US0 = pattern_input_1[4].l0
    class ObjectExpr363:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v71, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr363()))):
        v79: None
        closure9(pattern_input[0], None)
        v79 = None
        v83: None
        v5(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v362: FSharpRef[US3 | None] = FSharpRef(None)
        v367: None
        def v364(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v362, v)

        closure11(pattern_input_2[5], v364, None)
        v367 = None
        v382: US3 = default_arg(_v362.contents, US3(1))
        def _arrow364(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> Any:
            v396: Any = create(op_subtraction(ticks_1(now()), v382.fields[0]))
            return create_1(1, 1, 1, hours(v396), minutes(v396), seconds(v396), milliseconds(v396))

        v427: str = to_string(_arrow364() if (v382.tag == 0) else now(), method7())
        v628: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v639: int64 = pattern_input_2[0].l0
        v641: Mut3 = Mut3(method9())
        v648: None
        closure19(v641, ("" + "{ ") + "", None)
        v648 = None
        v657: None
        closure19(v641, ("" + "current_index") + "", None)
        v657 = None
        v666: None
        closure19(v641, ("" + " = ") + "", None)
        v666 = None
        v674: None
        closure19(v641, ("" + str(v0_1)) + "", None)
        v674 = None
        v683: None
        closure19(v641, ("" + "; ") + "", None)
        v683 = None
        v692: None
        closure19(v641, ("" + "acc") + "", None)
        v692 = None
        v700: None
        closure19(v641, ("" + " = ") + "", None)
        v700 = None
        v708: None
        closure19(v641, ("" + str(v1_1)) + "", None)
        v708 = None
        v716: None
        closure19(v641, ("" + "; ") + "", None)
        v716 = None
        v725: None
        closure19(v641, ("" + "len") + "", None)
        v725 = None
        v733: None
        closure19(v641, ("" + " = ") + "", None)
        v733 = None
        v741: None
        closure19(v641, ("" + str(v2_1)) + "", None)
        v741 = None
        v749: None
        closure19(v641, ("" + "; ") + "", None)
        v749 = None
        v758: None
        closure19(v641, ("" + "last_item") + "", None)
        v758 = None
        v766: None
        closure19(v641, ("" + " = ") + "", None)
        v766 = None
        v801: None
        closure19(v641, ("" + to_text(interpolate("%A%P()", [v3_1]))) + "", None)
        v801 = None
        v810: None
        closure19(v641, ("" + " }") + "", None)
        v810 = None
        v872: str = trim_end(trim_start(((((((((("" + v427) + " ") + v628) + " #") + str(v639)) + " ") + "dice.create_sequential_roller / roll") + " / ") + v641.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v872)
        pattern_input[1].l0(v872)



def method15(v0_1_mut: int64, v1_1_mut: UH0) -> US5:
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


def closure20(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure5(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v35: None
    v1_1(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr365:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr365()))):
        v75: None
        closure9(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure10(_v358, v)

        closure11(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow366(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow366() if (v378.tag == 0) else now(), method7())
        v624: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method9())
        v697: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v697)
        pattern_input[1].l0(v697)



def method14(v0_1_mut: Callable[[], UH0], v1_1_mut: Mut0, v2_1_mut: Mut0, v3_1_mut: Mut0, v4_1_mut: Mut6) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int64 = v1_1.l0
        v6: int64 = v2_1.l0
        v7: int64 = v3_1.l0
        v8: US5 = v4_1.l0
        v18: None
        closure18(v5, v6, v7, v8.fields[0] if (v8.tag == 0) else None, None)
        v18 = None
        v942: UH0 = v0_1(None)
        v944: US5 = method15(v1_1.l0, v942)
        if v944.tag == 0:
            v945: uint8 = v944.fields[0]
            v947: int64 = op_addition(v1_1.l0, int64(1))
            v1_1.l0 = v947
            v4_1.l0 = US5(0, v945)
            return v945

        else: 
            v951: None
            closure20(None, None)
            v951 = None
            if v3_1.l0 == int64(-1):
                v1706: int64 = v1_1.l0
                v3_1.l0 = v1706

            v1712: int64 = int64(1) if (v2_1.l0 >= v3_1.l0) else op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v1712
            v1714: int64 = op_subtraction(v2_1.l0, int64(1))
            v1_1.l0 = v1714
            v4_1.l0 = US5(1)
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1
            v3_1_mut = v3_1
            v4_1_mut = v4_1
            continue

        break


def closure17(v0_1: Callable[[], UH0], v1_1: Mut0, v2_1: Mut0, v3_1: Mut0, v4_1: Mut6, unit_var: None) -> uint8:
    return method14(v0_1, v1_1, v2_1, v3_1, v4_1)


def closure3(unit_var: None, v0_1: UH1) -> Callable[[], uint8]:
    v3_1: None
    closure4(None, None)
    v3_1 = None
    v760: UH0 = method12(method11(v0_1, method10(v0_1, UH1(0))), UH0(1))
    def v761(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure15(v760, None)

    v762: Callable[[], UH0] = method13(v760, v761)
    v763: Mut0 = Mut0(int64(0))
    v764: Mut0 = Mut0(int64(1))
    v765: Mut0 = Mut0(int64(-1))
    v767: Mut6 = Mut6(US5(1))
    def _arrow367(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint8:
        return closure17(v762, v763, v764, v765, v767, None)

    return _arrow367


def closure24(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr368:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr368()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow369(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow369() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "max") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "n") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "p") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v740 = None
        v749: None
        closure19(v640, ("" + " }") + "", None)
        v749 = None
        v811: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.calculate_dice_count") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v811)
        pattern_input[1].l0(v811)



def method16(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64) -> int8:
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
                closure24(v0_1, v1_1, v2_1, None)
                v10 = None
                return v1_1


        else: 
            v877: None
            closure24(v0_1, v1_1, v2_1, None)
            v877 = None
            return v1_1

        break


def closure25(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr370:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr370()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow371(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow371() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "result") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v740 = None
        v749: None
        closure19(v640, ("" + " }") + "", None)
        v749 = None
        v811: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v811)
        pattern_input[1].l0(v811)



def closure89(unit_var: None, unit_var_1: None) -> UH2:
    return UH2(1)


def closure88(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure89(None, None)

    return UH2(0, uint64(9223372036854775808), v0_1)


def closure87(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure88(None, None)

    return UH2(0, uint64(4611686018427387904), v0_1)


def closure86(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure87(None, None)

    return UH2(0, uint64(6917529027641081856), v0_1)


def closure85(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure86(None, None)

    return UH2(0, uint64(1152921504606846976), v0_1)


def closure84(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure85(None, None)

    return UH2(0, uint64(15564440312192434176), v0_1)


def closure83(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure84(None, None)

    return UH2(0, uint64(11817445422220181504), v0_1)


def closure82(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure83(None, None)

    return UH2(0, uint64(5044031582654955520), v0_1)


def closure81(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure82(None, None)

    return UH2(0, uint64(6989586621679009792), v0_1)


def closure80(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure81(None, None)

    return UH2(0, uint64(16537217831704461312), v0_1)


def closure79(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure80(None, None)

    return UH2(0, uint64(11979575008805519360), v0_1)


def closure78(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure79(None, None)

    return UH2(0, uint64(14294425217273954304), v0_1)


def closure77(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure78(None, None)

    return UH2(0, uint64(2382404202878992384), v0_1)


def closure76(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure77(None, None)

    return UH2(0, uint64(6545982058383015936), v0_1)


def closure75(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure76(None, None)

    return UH2(0, uint64(10314369046585278464), v0_1)


def closure74(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure75(None, None)

    return UH2(0, uint64(4793518853382471680), v0_1)


def closure73(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure74(None, None)

    return UH2(0, uint64(3873377154515337216), v0_1)


def closure72(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure73(None, None)

    return UH2(0, uint64(645562859085889536), v0_1)


def closure71(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure72(None, None)

    return UH2(0, uint64(107593809847648256), v0_1)


def closure70(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure71(None, None)

    return UH2(0, uint64(3092389647259533312), v0_1)


def closure69(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure70(None, None)

    return UH2(0, uint64(9738770311398031360), v0_1)


def closure68(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure69(None, None)

    return UH2(0, uint64(16995415113324298240), v0_1)


def closure67(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure68(None, None)

    return UH2(0, uint64(8981483876790566912), v0_1)


def closure66(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure67(None, None)

    return UH2(0, uint64(13794743361938128896), v0_1)


def closure65(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure66(None, None)

    return UH2(0, uint64(2299123893656354816), v0_1)


def closure64(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure65(None, None)

    return UH2(0, uint64(3457644661227651072), v0_1)


def closure63(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure64(None, None)

    return UH2(0, uint64(576274110204608512), v0_1)


def closure62(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure63(None, None)

    return UH2(0, uint64(6244960376270618624), v0_1)


def closure61(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure62(None, None)

    return UH2(0, uint64(13338656111851470848), v0_1)


def closure60(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure61(None, None)

    return UH2(0, uint64(14520938734448279552), v0_1)


def closure59(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure60(None, None)

    return UH2(0, uint64(14717985838214414336), v0_1)


def closure58(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure59(None, None)

    return UH2(0, uint64(5527454985320660992), v0_1)


def closure57(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure58(None, None)

    return UH2(0, uint64(16293529225644736512), v0_1)


def closure56(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure57(None, None)

    return UH2(0, uint64(11938960241128898560), v0_1)


def closure55(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure56(None, None)

    return UH2(0, uint64(8138741398091333632), v0_1)


def closure54(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure55(None, None)

    return UH2(0, uint64(7505371590918406144), v0_1)


def closure53(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure54(None, None)

    return UH2(0, uint64(16623181993244360704), v0_1)


def closure52(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure53(None, None)

    return UH2(0, uint64(8919445023443910656), v0_1)


def closure51(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure52(None, None)

    return UH2(0, uint64(4561031516192243712), v0_1)


def closure50(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure51(None, None)

    return UH2(0, uint64(9983543956220149760), v0_1)


def closure49(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure50(None, None)

    return UH2(0, uint64(4738381338321616896), v0_1)


def closure48(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure49(None, None)

    return UH2(0, uint64(789730223053602816), v0_1)


def closure47(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure48(None, None)

    return UH2(0, uint64(131621703842267136), v0_1)


def closure46(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure47(None, None)

    return UH2(0, uint64(21936950640377856), v0_1)


def closure45(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure46(None, None)

    return UH2(0, uint64(3656158440062976), v0_1)


def closure44(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure45(None, None)

    return UH2(0, uint64(609359740010496), v0_1)


def closure43(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure44(None, None)

    return UH2(0, uint64(101559956668416), v0_1)


def closure42(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure43(None, None)

    return UH2(0, uint64(16926659444736), v0_1)


def closure41(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure42(None, None)

    return UH2(0, uint64(2821109907456), v0_1)


def closure40(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure41(None, None)

    return UH2(0, uint64(470184984576), v0_1)


def closure39(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure40(None, None)

    return UH2(0, uint64(78364164096), v0_1)


def closure38(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure39(None, None)

    return UH2(0, uint64(13060694016), v0_1)


def closure37(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure38(None, None)

    return UH2(0, uint64(2176782336), v0_1)


def closure36(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure37(None, None)

    return UH2(0, uint64(362797056), v0_1)


def closure35(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure36(None, None)

    return UH2(0, uint64(60466176), v0_1)


def closure34(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure35(None, None)

    return UH2(0, uint64(10077696), v0_1)


def closure33(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure34(None, None)

    return UH2(0, uint64(1679616), v0_1)


def closure32(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure33(None, None)

    return UH2(0, uint64(279936), v0_1)


def closure31(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure32(None, None)

    return UH2(0, uint64(46656), v0_1)


def closure30(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure31(None, None)

    return UH2(0, uint64(7776), v0_1)


def closure29(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure30(None, None)

    return UH2(0, uint64(1296), v0_1)


def closure28(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure29(None, None)

    return UH2(0, uint64(216), v0_1)


def closure27(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure28(None, None)

    return UH2(0, uint64(36), v0_1)


def closure26(unit_var: None, unit_var_1: None) -> UH2:
    def v0_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> UH2:
        return closure27(None, None)

    return UH2(0, uint64(6), v0_1)


def method19(v0_1_mut: int8, v1_1_mut: UH2) -> US7:
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


def closure90(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v39: None
    v5(None)
    v39 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v71: US0 = pattern_input_1[4].l0
    class ObjectExpr372:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v71, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr372()))):
        v79: None
        closure9(pattern_input[0], None)
        v79 = None
        v83: None
        v5(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v362: FSharpRef[US3 | None] = FSharpRef(None)
        v367: None
        def v364(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v362, v)

        closure11(pattern_input_2[5], v364, None)
        v367 = None
        v382: US3 = default_arg(_v362.contents, US3(1))
        def _arrow373(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> Any:
            v396: Any = create(op_subtraction(ticks_1(now()), v382.fields[0]))
            return create_1(1, 1, 1, hours(v396), minutes(v396), seconds(v396), milliseconds(v396))

        v427: str = to_string(_arrow373() if (v382.tag == 0) else now(), method7())
        v628: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v639: int64 = pattern_input_2[0].l0
        v641: Mut3 = Mut3(method9())
        v648: None
        closure19(v641, ("" + "{ ") + "", None)
        v648 = None
        v657: None
        closure19(v641, ("" + "power") + "", None)
        v657 = None
        v666: None
        closure19(v641, ("" + " = ") + "", None)
        v666 = None
        v674: None
        closure19(v641, ("" + str(v1_1)) + "", None)
        v674 = None
        v683: None
        closure19(v641, ("" + "; ") + "", None)
        v683 = None
        v692: None
        closure19(v641, ("" + "acc") + "", None)
        v692 = None
        v700: None
        closure19(v641, ("" + " = ") + "", None)
        v700 = None
        v708: None
        closure19(v641, ("" + str(v0_1)) + "", None)
        v708 = None
        v716: None
        closure19(v641, ("" + "; ") + "", None)
        v716 = None
        v725: None
        closure19(v641, ("" + "roll") + "", None)
        v725 = None
        v733: None
        closure19(v641, ("" + " = ") + "", None)
        v733 = None
        v741: None
        closure19(v641, ("" + str(v2_1)) + "", None)
        v741 = None
        v749: None
        closure19(v641, ("" + "; ") + "", None)
        v749 = None
        v758: None
        closure19(v641, ("" + "value") + "", None)
        v758 = None
        v766: None
        closure19(v641, ("" + " = ") + "", None)
        v766 = None
        v774: None
        closure19(v641, ("" + str(v3_1)) + "", None)
        v774 = None
        v783: None
        closure19(v641, ("" + " }") + "", None)
        v783 = None
        v845: str = trim_end(trim_start(((((((((("" + v427) + " ") + v628) + " #") + str(v639)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v641.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v845)
        pattern_input[1].l0(v845)



def closure91(v0_1: uint64, v1_1: int8, v2_1: uint8, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr374:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr374()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow375(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow375() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v740 = None
        v749: None
        closure19(v640, ("" + " }") + "", None)
        v749 = None
        v811: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v811)
        pattern_input[1].l0(v811)



def method18(v0_1_mut: int8, v1_1_mut: UH1, v2_1_mut: uint64) -> US6:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v0_1 < int8(0):
            v4_1: uint64 = op_addition(v2_1, uint64(1))
            v7: None
            closure25(v2_1, v0_1, v4_1, None)
            v7 = None
            return US6(0, v4_1, v1_1)

        elif v1_1.tag == 0:
            return US6(1)

        else: 
            v874: UH1 = v1_1.fields[1]
            v873: uint8 = v1_1.fields[0]
            if v873 > uint8(1):
                def v877(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH2:
                    return closure26(None, None)

                v879: US7 = method19(v0_1, UH2(0, uint64(1), v877))
                v883: uint64
                if v879.tag == 0:
                    v883 = v879.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v886: uint64 = op_multiply(from_integer(v873 - uint8(1), True, 4), v883)
                v889: None
                closure90(v2_1, v0_1, v873, v886, None)
                v889 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v874
                v2_1_mut = op_addition(v2_1, v886)
                continue

            else: 
                v1791: None
                closure91(v2_1, v0_1, v873, None)
                v1791 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v874
                v2_1_mut = v2_1
                continue


        break


def method20(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method20(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method21(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int8 = (v3_1 + int8(1)) or 0
        if v3_1 < v5:
            return method17(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)

        else: 
            v11: US6 = method18(v3_1, v4_1, uint64(0))
            if v11.tag == 0:
                v12: uint64 = v11.fields[0]
                if v12 <= v2_1:
                    return v12

                elif v1_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = method20(v3_1, v0_1, int8(0))
                    continue

                else: 
                    return method17(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


            elif v1_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = method20(v3_1, v0_1, int8(0))
                continue

            else: 
                return method17(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


        break


def method17(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1, v5_mut: int8) -> uint64:
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
            v13: US6 = method18(v3_1, v4_1, uint64(0))
            if v13.tag == 0:
                v14: uint64 = v13.fields[0]
                if v14 <= v2_1:
                    return v14

                elif v1_1:
                    return method21(v0_1, v1_1, v2_1, v3_1, method20(v3_1, v0_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = UH1(1, v0_1(None), v4_1)
                    v5_mut = v5 + int8(1)
                    continue


            elif v1_1:
                return method21(v0_1, v1_1, v2_1, v3_1, method20(v3_1, v0_1, int8(0)))

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = UH1(1, v0_1(None), v4_1)
                v5_mut = v5 + int8(1)
                continue


        break


def closure23(v0_1: Callable[[], uint8], v1_1: bool, v2_1: uint64) -> uint64:
    return method17(v0_1, v1_1, v2_1, (int8(1) if (v2_1 == uint64(1)) else method16(v2_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure22(v0_1: Callable[[], uint8], v1_1: bool) -> Callable[[uint64], uint64]:
    def _arrow376(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64:
        return closure23(v0_1, v1_1, v)

    return _arrow376


def closure21(unit_var: None, v0_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow377(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[uint64], uint64]:
        return closure22(v0_1, v)

    return _arrow377


def method22(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = v1_1 + int8(1)
            continue

        break


def closure93(v0_1: uint64, v1_1: UH1) -> uint64 | None:
    v6: US6 = method18(method22(v1_1, int8(0)) - int8(1), v1_1, uint64(0))
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



def closure92(unit_var: None, v0_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow378(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint64 | None:
        return closure93(v0_1, v)

    return _arrow378


def closure95(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure5(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v35: None
    v1_1(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr379:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr379()))):
        v75: None
        closure9(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure10(_v358, v)

        closure11(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow380(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow380() if (v378.tag == 0) else now(), method7())
        v624: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method9())
        v644: None
        closure19(v637, ("" + "{ ") + "", None)
        v644 = None
        v653: None
        closure19(v637, ("" + "max") + "", None)
        v653 = None
        v662: None
        closure19(v637, ("" + " = ") + "", None)
        v662 = None
        v670: None
        closure19(v637, ("" + str(int64(9223372036854775807))) + "", None)
        v670 = None
        v679: None
        closure19(v637, ("" + "; ") + "", None)
        v679 = None
        v688: None
        closure19(v637, ("" + "n") + "", None)
        v688 = None
        v696: None
        closure19(v637, ("" + " = ") + "", None)
        v696 = None
        v704: None
        closure19(v637, ("" + str(int8(24))) + "", None)
        v704 = None
        v712: None
        closure19(v637, ("" + "; ") + "", None)
        v712 = None
        v721: None
        closure19(v637, ("" + "p") + "", None)
        v721 = None
        v729: None
        closure19(v637, ("" + " = ") + "", None)
        v729 = None
        v737: None
        closure19(v637, ("" + str(int64(4738381338321616896))) + "", None)
        v737 = None
        v746: None
        closure19(v637, ("" + " }") + "", None)
        v746 = None
        v808: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "dice.calculate_dice_count") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v808)
        pattern_input[1].l0(v808)



def method24(__unit: None=None) -> uint8:
    v17: Any = {}
    value_2: int = randint(int(uint8(1)), int(uint8(7))) or 0
    return int(value_2+0x100 if value_2 < 0 else value_2) & 0xFF


def closure96(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr381:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr381()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow382(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow382() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(23))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure97(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr383:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr383()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow384(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow384() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(22))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure98(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr385:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr385()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow386(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow386() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(21))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure99(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr387:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr387()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow388(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow388() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(20))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure100(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr389:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr389()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow390(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow390() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(19))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure101(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr391:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr391()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow392(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow392() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(18))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure102(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr393:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr393()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow394(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow394() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(17))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr395:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr395()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow396(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow396() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(16))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr397:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr397()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow398(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow398() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(15))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr399:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr399()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow400(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow400() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(14))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr401:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr401()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow402(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow402() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(13))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr403:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr403()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow404(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow404() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(12))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr405:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr405()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow406(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow406() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(11))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr407:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr407()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow408(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow408() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(10))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr409:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr409()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow410(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow410() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(9))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr411:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr411()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow412(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow412() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(8))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr413:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr413()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow414(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow414() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(7))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr415:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr415()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow416(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow416() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(6))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr417:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr417()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow418(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow418() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(5))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr419:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr419()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow420(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow420() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(4))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr421:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr421()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow422(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow422() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(3))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure117(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr423:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr423()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow424(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow424() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(2))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure118(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr425:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr425()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow426(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow426() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(1))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure119(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v5: None
    v4_1(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4_1(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr427:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr427()))):
        v78: None
        closure9(pattern_input[0], None)
        v78 = None
        v82: None
        v4_1(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v361, v)

        closure11(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow428(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow428() if (v381.tag == 0) else now(), method7())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v638: int64 = pattern_input_2[0].l0
        v640: Mut3 = Mut3(method9())
        v647: None
        closure19(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure19(v640, ("" + "power") + "", None)
        v656 = None
        v665: None
        closure19(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure19(v640, ("" + str(int8(0))) + "", None)
        v673 = None
        v682: None
        closure19(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure19(v640, ("" + "acc") + "", None)
        v691 = None
        v699: None
        closure19(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure19(v640, ("" + str(v0_1)) + "", None)
        v707 = None
        v715: None
        closure19(v640, ("" + "; ") + "", None)
        v715 = None
        v724: None
        closure19(v640, ("" + "roll") + "", None)
        v724 = None
        v732: None
        closure19(v640, ("" + " = ") + "", None)
        v732 = None
        v740: None
        closure19(v640, ("" + str(v1_1)) + "", None)
        v740 = None
        v748: None
        closure19(v640, ("" + "; ") + "", None)
        v748 = None
        v757: None
        closure19(v640, ("" + "value") + "", None)
        v757 = None
        v765: None
        closure19(v640, ("" + " = ") + "", None)
        v765 = None
        v773: None
        closure19(v640, ("" + str(v2_1)) + "", None)
        v773 = None
        v782: None
        closure19(v640, ("" + " }") + "", None)
        v782 = None
        v844: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v844)
        pattern_input[1].l0(v844)



def closure120(v0_1: int64, v1_1: int64, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr429:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr429()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow430(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow430() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(-1))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "result") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method49(v0_1: UH1, v1_1: int64) -> US8:
    v2_1: int64 = op_addition(v1_1, int64(1))
    v5: None
    closure120(v1_1, v2_1, None)
    v5 = None
    return US8(0, v2_1, v0_1)


def closure121(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr431:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr431()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow432(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow432() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(0))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method48(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            v10: None
            closure119(v1_1, v3_1, v7, None)
            v10 = None
            return method49(v4_1, op_addition(v1_1, v7))

        else: 
            v911: None
            closure121(v1_1, v3_1, None)
            v911 = None
            return method49(v4_1, v1_1)




def closure122(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr433:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr433()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow434(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow434() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(1))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method47(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            v11: None
            closure118(v1_1, v3_1, v8, None)
            v11 = None
            return method48(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure122(v1_1, v3_1, None)
            v912 = None
            return method48(v4_1, v1_1)




def closure123(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr435:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr435()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow436(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow436() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(2))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method46(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            v11: None
            closure117(v1_1, v3_1, v8, None)
            v11 = None
            return method47(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure123(v1_1, v3_1, None)
            v912 = None
            return method47(v4_1, v1_1)




def closure124(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr437:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr437()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow438(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow438() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(3))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method45(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            v11: None
            closure116(v1_1, v3_1, v8, None)
            v11 = None
            return method46(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure124(v1_1, v3_1, None)
            v912 = None
            return method46(v4_1, v1_1)




def closure125(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr439:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr439()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow440(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow440() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(4))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method44(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            v11: None
            closure115(v1_1, v3_1, v8, None)
            v11 = None
            return method45(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure125(v1_1, v3_1, None)
            v912 = None
            return method45(v4_1, v1_1)




def closure126(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr441:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr441()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow442(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow442() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(5))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method43(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            v11: None
            closure114(v1_1, v3_1, v8, None)
            v11 = None
            return method44(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure126(v1_1, v3_1, None)
            v912 = None
            return method44(v4_1, v1_1)




def closure127(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr443:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr443()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow444(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow444() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(6))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method42(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            v11: None
            closure113(v1_1, v3_1, v8, None)
            v11 = None
            return method43(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure127(v1_1, v3_1, None)
            v912 = None
            return method43(v4_1, v1_1)




def closure128(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr445:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr445()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow446(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow446() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(7))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method41(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            v11: None
            closure112(v1_1, v3_1, v8, None)
            v11 = None
            return method42(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure128(v1_1, v3_1, None)
            v912 = None
            return method42(v4_1, v1_1)




def closure129(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr447:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr447()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow448(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow448() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(8))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method40(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            v11: None
            closure111(v1_1, v3_1, v8, None)
            v11 = None
            return method41(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure129(v1_1, v3_1, None)
            v912 = None
            return method41(v4_1, v1_1)




def closure130(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr449:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr449()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow450(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow450() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(9))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method39(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            v11: None
            closure110(v1_1, v3_1, v8, None)
            v11 = None
            return method40(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure130(v1_1, v3_1, None)
            v912 = None
            return method40(v4_1, v1_1)




def closure131(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr451:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr451()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow452(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow452() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(10))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method38(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            v11: None
            closure109(v1_1, v3_1, v8, None)
            v11 = None
            return method39(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure131(v1_1, v3_1, None)
            v912 = None
            return method39(v4_1, v1_1)




def closure132(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr453:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr453()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow454(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow454() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(11))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method37(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            v11: None
            closure108(v1_1, v3_1, v8, None)
            v11 = None
            return method38(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure132(v1_1, v3_1, None)
            v912 = None
            return method38(v4_1, v1_1)




def closure133(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr455:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr455()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow456(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow456() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(12))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method36(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            v11: None
            closure107(v1_1, v3_1, v8, None)
            v11 = None
            return method37(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure133(v1_1, v3_1, None)
            v912 = None
            return method37(v4_1, v1_1)




def closure134(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr457:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr457()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow458(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow458() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(13))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method35(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            v11: None
            closure106(v1_1, v3_1, v8, None)
            v11 = None
            return method36(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure134(v1_1, v3_1, None)
            v912 = None
            return method36(v4_1, v1_1)




def closure135(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr459:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr459()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow460(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow460() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(14))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method34(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            v11: None
            closure105(v1_1, v3_1, v8, None)
            v11 = None
            return method35(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure135(v1_1, v3_1, None)
            v912 = None
            return method35(v4_1, v1_1)




def closure136(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr461:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr461()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow462(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow462() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(15))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method33(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            v11: None
            closure104(v1_1, v3_1, v8, None)
            v11 = None
            return method34(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure136(v1_1, v3_1, None)
            v912 = None
            return method34(v4_1, v1_1)




def closure137(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr463:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr463()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow464(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow464() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(16))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method32(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            v11: None
            closure103(v1_1, v3_1, v8, None)
            v11 = None
            return method33(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure137(v1_1, v3_1, None)
            v912 = None
            return method33(v4_1, v1_1)




def closure138(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr465:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr465()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow466(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow466() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(17))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method31(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            v11: None
            closure102(v1_1, v3_1, v8, None)
            v11 = None
            return method32(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure138(v1_1, v3_1, None)
            v912 = None
            return method32(v4_1, v1_1)




def closure139(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr467:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr467()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow468(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow468() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(18))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method30(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            v11: None
            closure101(v1_1, v3_1, v8, None)
            v11 = None
            return method31(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure139(v1_1, v3_1, None)
            v912 = None
            return method31(v4_1, v1_1)




def closure140(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr469:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr469()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow470(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow470() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(19))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method29(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            v11: None
            closure100(v1_1, v3_1, v8, None)
            v11 = None
            return method30(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure140(v1_1, v3_1, None)
            v912 = None
            return method30(v4_1, v1_1)




def closure141(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr471:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr471()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow472(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow472() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(20))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method28(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            v11: None
            closure99(v1_1, v3_1, v8, None)
            v11 = None
            return method29(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure141(v1_1, v3_1, None)
            v912 = None
            return method29(v4_1, v1_1)




def closure142(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr473:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr473()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow474(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow474() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(21))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method27(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            v11: None
            closure98(v1_1, v3_1, v8, None)
            v11 = None
            return method28(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure142(v1_1, v3_1, None)
            v912 = None
            return method28(v4_1, v1_1)




def closure143(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr475:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr475()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow476(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow476() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(22))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method26(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            v11: None
            closure97(v1_1, v3_1, v8, None)
            v11 = None
            return method27(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure143(v1_1, v3_1, None)
            v912 = None
            return method27(v4_1, v1_1)




def closure144(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v4_1: None
    v3_1(None)
    v4_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3_1(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr477:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr477()))):
        v77: None
        closure9(pattern_input[0], None)
        v77 = None
        v81: None
        v3_1(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v360, v)

        closure11(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow478(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow478() if (v380.tag == 0) else now(), method7())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method9())
        v646: None
        closure19(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure19(v639, ("" + "power") + "", None)
        v655 = None
        v664: None
        closure19(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure19(v639, ("" + str(int8(23))) + "", None)
        v672 = None
        v681: None
        closure19(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure19(v639, ("" + "acc") + "", None)
        v690 = None
        v698: None
        closure19(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure19(v639, ("" + str(v0_1)) + "", None)
        v706 = None
        v714: None
        closure19(v639, ("" + "; ") + "", None)
        v714 = None
        v723: None
        closure19(v639, ("" + "roll") + "", None)
        v723 = None
        v731: None
        closure19(v639, ("" + " = ") + "", None)
        v731 = None
        v739: None
        closure19(v639, ("" + str(v1_1)) + "", None)
        v739 = None
        v748: None
        closure19(v639, ("" + " }") + "", None)
        v748 = None
        v810: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "dice.accumulate_dice_rolls") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v810)
        pattern_input[1].l0(v810)



def method25(v0_1: UH1, v1_1: int64) -> US8:
    if v0_1.tag == 0:
        return US8(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            v11: None
            closure96(v1_1, v3_1, v8, None)
            v11 = None
            return method26(v4_1, op_addition(v1_1, v8))

        else: 
            v912: None
            closure144(v1_1, v3_1, None)
            v912 = None
            return method26(v4_1, v1_1)




def method23(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method24(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US8 = method25(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(1, method24(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def closure145(v0_1: int64, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure5(None, None)

    v3_1: None
    v2_1(None)
    v3_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr479:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr479()))):
        v76: None
        closure9(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure10(_v359, v)

        closure11(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow480(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow480() if (v379.tag == 0) else now(), method7())
        v625: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method8()
        v636: int64 = pattern_input_2[0].l0
        v638: Mut3 = Mut3(method9())
        v645: None
        closure19(v638, ("" + "{ ") + "", None)
        v645 = None
        v654: None
        closure19(v638, ("" + "result") + "", None)
        v654 = None
        v663: None
        closure19(v638, ("" + " = ") + "", None)
        v663 = None
        v671: None
        closure19(v638, ("" + str(v0_1)) + "", None)
        v671 = None
        v680: None
        closure19(v638, ("" + " }") + "", None)
        v680 = None
        v742: str = trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + "dice.main") + " / ") + v638.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v742)
        pattern_input[1].l0(v742)



def closure94(unit_var: None, v0_1: Array[str]) -> int:
    v3_1: None
    closure95(None, None)
    v3_1 = None
    v872: None
    closure145(method23(UH1(0), int8(0)), None)
    v872 = None
    return 0


def _arrow481(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow481

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow482(v: UH1) -> Callable[[], uint8]:
    return closure3(None, v)


v1: Callable[[UH1, None], uint8] = _arrow482

def create_sequential_roller(x: UH1) -> Callable[[], uint8]:
    return v1(x)


def _arrow483(v: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return closure21(None, v)


v2: Callable[[Callable[[], uint8], bool, uint64], uint64] = _arrow483

def roll_progressively(x: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return v2(x)


def _arrow484(v: uint64) -> Callable[[UH1], uint64 | None]:
    return closure92(None, v)


v3: Callable[[uint64, UH1], uint64 | None] = _arrow484

def roll_within_bounds(x: uint64) -> Callable[[UH1], uint64 | None]:
    return v3(x)


def _arrow485(v: Array[str]) -> int:
    return closure94(None, v)


v4: Callable[[Array[str]], int] = _arrow485

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


