from __future__ import annotations
from abc import abstractmethod
from fable_modules.fable_library.date import (ticks as ticks_1, now, create as create_1, to_string)
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, from_integer, to_int, from_value, op_multiply)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, uint8_type, unit_type, lambda_type, union_type, record_type, int64_type, string_type, bool_type, class_type, option_type, char_type, int32_type, uint64_type)
from fable_modules.fable_library.string_ import (to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, uint64, int8)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, randint)
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
    return union_type("Dice.US5", [], US5, lambda: [[], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr460

def _expr461() -> TypeInfo:
    return union_type("Dice.US6", [], US6, lambda: [[("f0_0", US5_reflection())], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr461

def _expr462() -> TypeInfo:
    return union_type("Dice.US7", [], US7, lambda: [[], [], [], [], [], [("f5_0", US6_reflection())], [], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1", "US7_2", "US7_3", "US7_4", "US7_5", "US7_6", "US7_7"]


US7_reflection = _expr462

def _expr463() -> TypeInfo:
    return union_type("Dice.US8", [], US8, lambda: [[("f0_0", string_type)], []])


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
    return union_type("Dice.US9", [], US9, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


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
    return union_type("Dice.US10", [], US10, lambda: [[("f0_0", Mut1_reflection()), ("f0_1", Mut3_reflection()), ("f0_2", Mut4_reflection()), ("f0_3", Mut5_reflection()), ("f0_4", Mut6_reflection()), ("f0_5", option_type(int64_type))], []])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr465

def _expr466() -> TypeInfo:
    return union_type("Dice.US11", [], US11, lambda: [[("f0_0", char_type)], []])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr466

def _expr467() -> TypeInfo:
    return record_type("Dice.Mut7", [], Mut7, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut7(Record):
    l0: int

Mut7_reflection = _expr467

def _expr468() -> TypeInfo:
    return union_type("Dice.US12", [], US12, lambda: [[("f0_0", uint64_type), ("f0_1", UH1_reflection())], []])


class US12(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US12_0", "US12_1"]


US12_reflection = _expr468

def _expr469() -> TypeInfo:
    return union_type("Dice.UH2", [], UH2, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH2_reflection()))], []])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr469

def _expr470() -> TypeInfo:
    return union_type("Dice.US13", [], US13, lambda: [[("f0_0", uint64_type)], []])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr470

def _expr471() -> TypeInfo:
    return union_type("Dice.US14", [], US14, lambda: [[("f0_0", int32_type)], [("f1_0", class_type("System.Exception"))]])


class US14(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US14_0", "US14_1"]


US14_reflection = _expr471

def _expr472() -> TypeInfo:
    return union_type("Dice.US15", [], US15, lambda: [[("f0_0", int32_type)], []])


class US15(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US15_0", "US15_1"]


US15_reflection = _expr472

def _expr473() -> TypeInfo:
    return union_type("Dice.US16", [], US16, lambda: [[("f0_0", uint8_type)], [("f1_0", class_type("System.Exception"))]])


class US16(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US16_0", "US16_1"]


US16_reflection = _expr473

def _expr474() -> TypeInfo:
    return union_type("Dice.US17", [], US17, lambda: [[("f0_0", int64_type), ("f0_1", UH1_reflection())], []])


class US17(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US17_0", "US17_1"]


US17_reflection = _expr474

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
    def _arrow475(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure1(v0_1, v)

    return _arrow475


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
    def _arrow476(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> UH0:
        return closure6(v0_1, v3_1, None)

    return _arrow476


def method9(v0_1: str) -> str:
    return v0_1


def method10(__unit: None=None) -> str:
    return ""


def method13(__unit: None=None) -> str:
    return ""


def method14(v0_1: Mut5, v1_1: str) -> None:
    v5: str = v0_1.l0 + v1_1
    v0_1.l0 = v5


def method12(v0_1: US7) -> str:
    v12: Mut5 = Mut5(method13())
    method14(v12, to_text(interpolate("%A%P()", [v0_1])))
    return v12.l0


def method15(v0_1: str) -> str:
    v12: Mut5 = Mut5(method13())
    method14(v12, v0_1)
    return v12.l0


def method11(v0_1: str) -> str:
    raise Exception((("env.get_environment_variable / target: " + method12(US7(5, US6(0, US5(0))))) + " / var: ") + method15(v0_1))


def method16(v0_1: str) -> str:
    raise Exception((("env.get_environment_variable / target: " + method12(US7(5, US6(0, US5(1))))) + " / var: ") + method15(v0_1))


def closure10(unit_var: None, v0_1: str) -> US8:
    return US8(0, v0_1)


def method17(__unit: None=None) -> Callable[[str], US8]:
    def _arrow477(v: str) -> US8:
        return closure10(None, v)

    return _arrow477


def method8(v0_1: str) -> str:
    v66: IOsEnviron = os
    v68: Any = v66.environ
    _v94: (str | None) | None = None
    x: str | None = v68.get(v0_1)
    _v94 = some(x)
    v124: str | None
    if _v94 is None:
        raise Exception("optionm\'.of_obj / _v94=None")

    else: 
        v124 = value_1(_v94)

    v261: US8 = default_arg(map(method17(), v124), US8(1))
    if v261.tag == 0:
        return v261.fields[0]

    else: 
        return ""



def closure11(v0_1: int64, unit_var: None) -> int64:
    return from_value(v0_1, False)


def closure12(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure13(unit_var: None, v0_1: Callable[[], Exception]) -> Exception:
    return v0_1(None)


def closure14(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def method18(v0_1: int64) -> US9:
    try: 
        return closure12(None, closure11(v0_1, None))

    except Exception as ex:
        def v_1(__unit: None=None) -> Exception:
            return ex

        return closure14(None, closure13(None, v_1))



def method7(__unit: None=None) -> tuple[US3, US4]:
    v1_1: str = method8("TRACE_LEVEL")
    v8: str = "Critical".lower()
    v26: str = "Warning".lower()
    v44: str = "Info".lower()
    v62: str = "Debug".lower()
    v80: str = "Verbose".lower()
    v96: US3 = US3(0, US2(0)) if ("Verbose" == v1_1) else US3(1)
    def _arrow478(__unit: None=None) -> US3:
        v103: US3 = US3(0, US2(1)) if ("Debug" == v1_1) else US3(1)
        if v103.tag == 0:
            return US3(0, v103.fields[0])

        else: 
            v110: US3 = US3(0, US2(2)) if ("Info" == v1_1) else US3(1)
            if v110.tag == 0:
                return US3(0, v110.fields[0])

            else: 
                v117: US3 = US3(0, US2(3)) if ("Warning" == v1_1) else US3(1)
                if v117.tag == 0:
                    return US3(0, v117.fields[0])

                else: 
                    v124: US3 = US3(0, US2(4)) if ("Critical" == v1_1) else US3(1)
                    if v124.tag == 0:
                        return US3(0, v124.fields[0])

                    else: 
                        v131: US3 = US3(0, US2(0)) if (v80 == v1_1) else US3(1)
                        if v131.tag == 0:
                            return US3(0, v131.fields[0])

                        else: 
                            v138: US3 = US3(0, US2(1)) if (v62 == v1_1) else US3(1)
                            if v138.tag == 0:
                                return US3(0, v138.fields[0])

                            else: 
                                v145: US3 = US3(0, US2(2)) if (v44 == v1_1) else US3(1)
                                if v145.tag == 0:
                                    return US3(0, v145.fields[0])

                                else: 
                                    v152: US3 = US3(0, US2(3)) if (v26 == v1_1) else US3(1)
                                    if v152.tag == 0:
                                        return US3(0, v152.fields[0])

                                    else: 
                                        v159: US3 = US3(0, US2(4)) if (v8 == v1_1) else US3(1)
                                        return US3(0, v159.fields[0]) if (v159.tag == 0) else US3(1)









    def _arrow480(__unit: None=None) -> US4:
        v463: US9 = method18(ticks_1(now()))
        v484: US4 = US4(0, v463.fields[0]) if (v463.tag == 0) else US4(1)
        def _arrow479(__unit: None=None) -> int64:
            raise Exception("Option does not have a value.")

        return US4(0, v484.fields[0] if (v484.tag == 0) else _arrow479())

    return (US3(0, v96.fields[0]) if (v96.tag == 0) else _arrow478(), US4(1) if (method8("AUTOMATION") != "True") else _arrow480())


def closure15(unit_var: None, v0_1: str) -> None:
    pass


def method6(v0_1: US2) -> tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None]:
    pattern_input: tuple[US3, US4] = method7()
    _run_target_args_0027_v5: tuple[US3, US4] = (pattern_input[0], pattern_input[1])
    v563: US4 = _run_target_args_0027_v5[1]
    v562: US3 = _run_target_args_0027_v5[0]
    def v569(v: str, v0_1: Any=v0_1) -> None:
        closure15(None, v)

    return (Mut1(int64(1)), Mut3(v569), Mut4(True), Mut5(""), Mut6(v562.fields[0] if (v562.tag == 0) else v0_1), v563.fields[0] if (v563.tag == 0) else None)


def closure9(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = method6(US2(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure16(unit_var: None, v0_1: int64) -> US4:
    return US4(0, v0_1)


def method20(__unit: None=None) -> Callable[[int64], US4]:
    def _arrow481(v: int64) -> US4:
        return closure16(None, v)

    return _arrow481


def method21(__unit: None=None) -> str:
    return "hh:mm:ss"


def method22(__unit: None=None) -> str:
    return "HH:mm:ss"


def method19(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None=None) -> str:
    v4570: US4 = default_arg(map(method20(), v5), US4(1))
    v5228: Any
    if v4570.tag == 0:
        v4844: US9 = method18(ticks_1(now()))
        v4865: US4 = US4(0, v4844.fields[0]) if (v4844.tag == 0) else US4(1)
        def _arrow482(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1, v5: Any=v5) -> int64:
            raise Exception("Option does not have a value.")

        v5010: Any = create(op_subtraction(v4865.fields[0] if (v4865.tag == 0) else _arrow482(), v4570.fields[0]))
        v5228 = create_1(1, 1, 1, hours(v5010), minutes(v5010), seconds(v5010), milliseconds(v5010))

    else: 
        v5228 = now()

    v5229: str = method22()
    return to_string(v5228, "M-d-y hh:mm:ss tt" if (v5229 == "") else v5229)


def method24(v0_1: str) -> str:
    v12: Mut5 = Mut5(method13())
    method14(v12, ("" + str(v0_1)) + "")
    return v12.l0


def method23(__unit: None=None) -> str:
    v345: str = "Debug".lower()
    return ("\u001b[94m" + method24(v345[0])) + "\u001b[0m"


def method26(v0_1: int64) -> str:
    v12: Mut5 = Mut5(method13())
    method14(v12, ("" + str(v0_1)) + "")
    return v12.l0


def method28(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "{ "
    v0_1.l0 = v7


def method29(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "current_index"
    v0_1.l0 = v7


def method30(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + " = "
    v0_1.l0 = v7


def method31(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "; "
    v0_1.l0 = v7


def method32(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "acc"
    v0_1.l0 = v7


def method33(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "len"
    v0_1.l0 = v7


def method34(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "last_item"
    v0_1.l0 = v7


def method35(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + " }"
    v0_1.l0 = v7


def method27(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: str) -> str:
    v15: Mut5 = Mut5(method13())
    method28(v15)
    method29(v15)
    method30(v15)
    method14(v15, ("" + str(v0_1)) + "")
    method31(v15)
    method32(v15)
    method30(v15)
    method14(v15, ("" + str(v1_1)) + "")
    method31(v15)
    method33(v15)
    method30(v15)
    method14(v15, ("" + str(v2_1)) + "")
    method31(v15)
    method34(v15)
    method30(v15)
    method14(v15, v3_1)
    method35(v15)
    return v15.l0


def method38(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(4):
            return False

        else: 
            v19: US11
            if v1_1 == int64(0):
                v19 = US11(0, " ")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v19 = US11(0, "\t")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v19 = US11(0, "\r")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        if v11 == int64(0):
                            v19 = US11(0, "\n")

                        else: 
                            v14: int64 = op_subtraction(v11, int64(1))
                            v19 = US11(1)




            def _arrow483(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v19.fields[0] if (v19.tag == 0) else _arrow483()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method37(v0_1_mut: str, v1_1_mut: int, v2_1_mut: int) -> int:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v2_1 >= v1_1:
            return v1_1

        elif method38(v0_1[v2_1], int64(0)):
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1 + 1
            continue

        else: 
            return v2_1

        break


def method40(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(2):
            return False

        else: 
            v11: US11
            if v1_1 == int64(0):
                v11 = US11(0, " ")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v11 = US11(0, "/")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    v11 = US11(1)


            def _arrow484(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v11.fields[0] if (v11.tag == 0) else _arrow484()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method39(v0_1_mut: str, v1_1_mut: int) -> int:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 <= 0:
            return 0

        else: 
            v3_1: int = (v1_1 - 1) or 0
            if method40(v0_1[v3_1], int64(0)):
                v0_1_mut = v0_1
                v1_1_mut = v3_1
                continue

            else: 
                return v3_1


        break


def method36(v0_1: str) -> str:
    v1_1: int = len(v0_1) or 0
    v3_1: int = method37(v0_1, v1_1, 0) or 0
    v716: str = v0_1[v3_1:v1_1 + 1]
    v730: int = method39(v716, len(v716)) or 0
    return v716[0:v730 + 1]


def method25(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64, v10: int64, v11: str) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.create_sequential_roller / roll") + " / ") + method27(v8, v9, v10, v11))


def closure17(v0_1: Mut1, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure19(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure18(unit_var: None, v0_1: str) -> None:
    v33: None
    closure19(v0_1, None)
    v33 = None


def method41(v0_1: int, v1_1: Mut7) -> bool:
    return v1_1.l0 < v0_1


def closure8(v0_1: int64, v1_1: int64, v2_1: int64, v3_1: uint8 | None, unit_var: None) -> None:
    def v65(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v66: None
    v65(None)
    v66 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v162: US2 = pattern_input[4].l0
    v712: US10
    class ObjectExpr485:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v162, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr485())))) == False:
        v712 = US10(1)

    else: 
        v231: None
        v65(None)
        v231 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v285: int64 | None = pattern_input_1[5]
        v284: Mut6 = pattern_input_1[4]
        v283: Mut5 = pattern_input_1[3]
        v282: Mut4 = pattern_input_1[2]
        v281: Mut3 = pattern_input_1[1]
        v280: Mut1 = pattern_input_1[0]
        v343: str = method25(v280, v281, v282, v283, v284, v285, method19(v280, v281, v282, v283, v284, v285), method23(), v0_1, v1_1, v2_1, to_text(interpolate("%A%P()", [v3_1])))
        v405: None
        v65(None)
        v405 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v455: Mut3 = pattern_input_2[1]
        v454: Mut1 = pattern_input_2[0]
        v507: None
        closure17(v454, None)
        v507 = None
        closure18(None, v343)
        v455.l0(v343)
        v712 = US10(0, v454, v455, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method42(v0_1_mut: int64, v1_1_mut: UH0) -> US1:
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


def method44(__unit: None=None) -> str:
    v11: Mut5 = Mut5(method13())
    return v11.l0


def method43(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.create_sequential_roller / roll / None") + " / ") + method44())


def closure20(unit_var: None, unit_var_1: None) -> None:
    def v61(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure9(None, None)

    v62: None
    v61(None)
    v62 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v158: US2 = pattern_input[4].l0
    v694: US10
    class ObjectExpr486:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v158, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr486())))) == False:
        v694 = US10(1)

    else: 
        v227: None
        v61(None)
        v227 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v281: int64 | None = pattern_input_1[5]
        v280: Mut6 = pattern_input_1[4]
        v279: Mut5 = pattern_input_1[3]
        v278: Mut4 = pattern_input_1[2]
        v277: Mut3 = pattern_input_1[1]
        v276: Mut1 = pattern_input_1[0]
        v325: str = method43(v276, v277, v278, v279, v280, v281, method19(v276, v277, v278, v279, v280, v281), method23())
        v387: None
        v61(None)
        v387 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v437: Mut3 = pattern_input_2[1]
        v436: Mut1 = pattern_input_2[0]
        v489: None
        closure17(v436, None)
        v489 = None
        closure18(None, v325)
        v437.l0(v325)
        v694 = US10(0, v436, v437, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method5(v0_1_mut: Callable[[], UH0], v1_1_mut: Mut1, v2_1_mut: Mut1, v3_1_mut: Mut1, v4_1_mut: Mut2) -> uint8:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int64 = v1_1.l0
        v6: int64 = v2_1.l0
        v7: int64 = v3_1.l0
        v8: US1 = v4_1.l0
        v1557: None
        closure8(v5, v6, v7, v8.fields[0] if (v8.tag == 0) else None, None)
        v1557 = None
        v2322: UH0 = v0_1(None)
        v2324: US1 = method42(v1_1.l0, v2322)
        if v2324.tag == 0:
            v2325: uint8 = v2324.fields[0]
            v2327: int64 = op_addition(v1_1.l0, int64(1))
            v1_1.l0 = v2327
            v4_1.l0 = US1(0, v2325)
            return v2325

        else: 
            v3818: None
            closure20(None, None)
            v3818 = None
            if v3_1.l0 == int64(-1):
                v4571: int64 = v1_1.l0
                v3_1.l0 = v4571

            v4577: int64 = int64(1) if (v2_1.l0 >= v3_1.l0) else op_addition(v2_1.l0, int64(1))
            v2_1.l0 = v4577
            v4579: int64 = op_subtraction(v2_1.l0, int64(1))
            v1_1.l0 = v4579
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
    def _arrow487(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint8:
        return closure7(v7, v8, v9, v10, v12, None)

    return _arrow487


def method48(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "max"
    v0_1.l0 = v7


def method49(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "p"
    v0_1.l0 = v7


def method50(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "n"
    v0_1.l0 = v7


def method47(v0_1: uint64, v1_1: uint64, v2_1: int8) -> str:
    v14: Mut5 = Mut5(method13())
    method28(v14)
    method48(v14)
    method30(v14)
    method14(v14, ("" + str(v0_1)) + "")
    method31(v14)
    method49(v14)
    method30(v14)
    method14(v14, ("" + str(v1_1)) + "")
    method31(v14)
    method50(v14)
    method30(v14)
    method14(v14, ("" + str(v2_1)) + "")
    method35(v14)
    return v14.l0


def method46(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: uint64, v9: uint64, v10: int8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.calculate_dice_count") + " / ") + method47(v8, v9, v10))


def closure24(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr488:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr488())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method46(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v2_1, v1_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method45(v0_1_mut: uint64, v1_1_mut: int8, v2_1_mut: uint64) -> int8:
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
                v1497: None
                closure24(v0_1, v1_1, v2_1, None)
                v1497 = None
                return v1_1


        else: 
            v3738: None
            closure24(v0_1, v1_1, v2_1, None)
            v3738 = None
            return v1_1

        break


def method55(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "power"
    v0_1.l0 = v7


def method56(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "result"
    v0_1.l0 = v7


def method54(v0_1: int8, v1_1: uint64, v2_1: uint64) -> str:
    v14: Mut5 = Mut5(method13())
    method28(v14)
    method55(v14)
    method30(v14)
    method14(v14, ("" + str(v0_1)) + "")
    method31(v14)
    method32(v14)
    method30(v14)
    method14(v14, ("" + str(v1_1)) + "")
    method31(v14)
    method56(v14)
    method30(v14)
    method14(v14, ("" + str(v2_1)) + "")
    method35(v14)
    return v14.l0


def method53(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method54(v8, v9, v10))


def closure25(v0_1: uint64, v1_1: int8, v2_1: uint64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr489:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr489())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method53(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v1_1, v0_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



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


def method57(v0_1_mut: int8, v1_1_mut: UH2) -> US13:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1.tag == 1:
            return US13(1)

        elif v0_1 <= int8(0):
            return US13(0, v1_1.fields[0])

        else: 
            v0_1_mut = v0_1 - int8(1)
            v1_1_mut = v1_1.fields[1](None)
            continue

        break


def method60(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "roll"
    v0_1.l0 = v7


def method61(v0_1: Mut5) -> None:
    v7: str = v0_1.l0 + "value"
    v0_1.l0 = v7


def method59(v0_1: int8, v1_1: uint64, v2_1: uint8, v3_1: uint64) -> str:
    v15: Mut5 = Mut5(method13())
    method28(v15)
    method55(v15)
    method30(v15)
    method14(v15, ("" + str(v0_1)) + "")
    method31(v15)
    method32(v15)
    method30(v15)
    method14(v15, ("" + str(v1_1)) + "")
    method31(v15)
    method60(v15)
    method30(v15)
    method14(v15, ("" + str(v2_1)) + "")
    method31(v15)
    method61(v15)
    method30(v15)
    method14(v15, ("" + str(v3_1)) + "")
    method35(v15)
    return v15.l0


def method58(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8, v11: uint64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method59(v8, v9, v10, v11))


def closure90(v0_1: uint64, v1_1: int8, v2_1: uint8, v3_1: uint64, unit_var: None) -> None:
    def v65(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v66: None
    v65(None)
    v66 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v162: US2 = pattern_input[4].l0
    v698: US10
    class ObjectExpr490:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v162, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr490())))) == False:
        v698 = US10(1)

    else: 
        v231: None
        v65(None)
        v231 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v285: int64 | None = pattern_input_1[5]
        v284: Mut6 = pattern_input_1[4]
        v283: Mut5 = pattern_input_1[3]
        v282: Mut4 = pattern_input_1[2]
        v281: Mut3 = pattern_input_1[1]
        v280: Mut1 = pattern_input_1[0]
        v329: str = method58(v280, v281, v282, v283, v284, v285, method19(v280, v281, v282, v283, v284, v285), method23(), v1_1, v0_1, v2_1, v3_1)
        v391: None
        v65(None)
        v391 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v441: Mut3 = pattern_input_2[1]
        v440: Mut1 = pattern_input_2[0]
        v493: None
        closure17(v440, None)
        v493 = None
        closure18(None, v329)
        v441.l0(v329)
        v698 = US10(0, v440, v441, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method63(v0_1: int8, v1_1: uint64, v2_1: uint8) -> str:
    v14: Mut5 = Mut5(method13())
    method28(v14)
    method55(v14)
    method30(v14)
    method14(v14, ("" + str(v0_1)) + "")
    method31(v14)
    method32(v14)
    method30(v14)
    method14(v14, ("" + str(v1_1)) + "")
    method31(v14)
    method60(v14)
    method30(v14)
    method14(v14, ("" + str(v2_1)) + "")
    method35(v14)
    return v14.l0


def method62(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int8, v9: uint64, v10: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method63(v8, v9, v10))


def closure91(v0_1: uint64, v1_1: int8, v2_1: uint8, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr491:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr491())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method62(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v1_1, v0_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method52(v0_1_mut: int8, v1_1_mut: UH1, v2_1_mut: uint64) -> US12:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v0_1 < int8(0):
            v4_1: uint64 = op_addition(v2_1, uint64(1))
            v1494: None
            closure25(v2_1, v0_1, v4_1, None)
            v1494 = None
            return US12(0, v4_1, v1_1)

        elif v1_1.tag == 0:
            return US12(1)

        else: 
            v2248: UH1 = v1_1.fields[1]
            v2247: uint8 = v1_1.fields[0]
            if v2247 > uint8(1):
                def v2251(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> UH2:
                    return closure26(None, None)

                v2253: US13 = method57(v0_1, UH2(0, uint64(1), v2251))
                v2257: uint64
                if v2253.tag == 0:
                    v2257 = v2253.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v2260: uint64 = op_multiply(from_integer(v2247 - uint8(1), True, 4), v2257)
                v3750: None
                closure90(v2_1, v0_1, v2247, v2260, None)
                v3750 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v2248
                v2_1_mut = op_addition(v2_1, v2260)
                continue

            else: 
                v5993: None
                closure91(v2_1, v0_1, v2247, None)
                v5993 = None
                v0_1_mut = v0_1 - int8(1)
                v1_1_mut = v2248
                v2_1_mut = v2_1
                continue


        break


def method64(v0_1: int8, v1_1: Callable[[], uint8], v2_1: int8) -> UH1:
    if v2_1 < v0_1:
        return UH1(1, v1_1(None), method64(v0_1, v1_1, v2_1 + int8(1)))

    else: 
        return UH1(0)



def method65(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1) -> uint64:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5: int8 = (v3_1 + int8(1)) or 0
        if v3_1 < v5:
            return method51(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)

        else: 
            v11: US12 = method52(v3_1, v4_1, uint64(0))
            if v11.tag == 0:
                v12: uint64 = v11.fields[0]
                if v12 <= v2_1:
                    return v12

                elif v1_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = method64(v3_1, v0_1, int8(0))
                    continue

                else: 
                    return method51(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


            elif v1_1:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = method64(v3_1, v0_1, int8(0))
                continue

            else: 
                return method51(v0_1, v1_1, v2_1, v3_1, UH1(1, v0_1(None), v4_1), v5)


        break


def method51(v0_1_mut: Callable[[], uint8], v1_1_mut: bool, v2_1_mut: uint64, v3_1_mut: int8, v4_1_mut: UH1, v5_mut: int8) -> uint64:
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
            v13: US12 = method52(v3_1, v4_1, uint64(0))
            if v13.tag == 0:
                v14: uint64 = v13.fields[0]
                if v14 <= v2_1:
                    return v14

                elif v1_1:
                    return method65(v0_1, v1_1, v2_1, v3_1, method64(v3_1, v0_1, int8(0)))

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v2_1
                    v3_1_mut = v3_1
                    v4_1_mut = UH1(1, v0_1(None), v4_1)
                    v5_mut = v5 + int8(1)
                    continue


            elif v1_1:
                return method65(v0_1, v1_1, v2_1, v3_1, method64(v3_1, v0_1, int8(0)))

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
    return method51(v0_1, v1_1, v2_1, (int8(1) if (v2_1 == uint64(1)) else method45(v2_1, int8(0), uint64(1))) - int8(1), UH1(0), int8(0))


def closure22(v0_1: Callable[[], uint8], v1_1: bool) -> Callable[[uint64], uint64]:
    def _arrow492(v: uint64, v0_1: Any=v0_1, v1_1: Any=v1_1) -> uint64:
        return closure23(v0_1, v1_1, v)

    return _arrow492


def closure21(unit_var: None, v0_1: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    def _arrow493(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[uint64], uint64]:
        return closure22(v0_1, v)

    return _arrow493


def method66(v0_1_mut: UH1, v1_1_mut: int8) -> int8:
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
    v6: US12 = method52(method66(v1_1, int8(0)) - int8(1), v1_1, uint64(0))
    v16: US13
    if v6.tag == 0:
        v7: uint64 = v6.fields[0]
        v16 = US13(0, v7) if ((v7 <= v0_1) if (v7 >= uint64(1)) else False) else US13(1)

    else: 
        v16 = US13(1)

    if v16.tag == 0:
        return v16.fields[0]

    else: 
        return None



def closure92(unit_var: None, v0_1: uint64) -> Callable[[UH1], uint64 | None]:
    def _arrow494(v: UH1, unit_var: Any=unit_var, v0_1: Any=v0_1) -> uint64 | None:
        return closure93(v0_1, v)

    return _arrow494


def method68(v0_1: int64, v1_1: int64, v2_1: int8) -> str:
    v14: Mut5 = Mut5(method13())
    method28(v14)
    method48(v14)
    method30(v14)
    method14(v14, ("" + str(v0_1)) + "")
    method31(v14)
    method49(v14)
    method30(v14)
    method14(v14, ("" + str(v1_1)) + "")
    method31(v14)
    method50(v14)
    method30(v14)
    method14(v14, ("" + str(v2_1)) + "")
    method35(v14)
    return v14.l0


def method67(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.calculate_dice_count") + " / ") + method68(int64(9223372036854775807), int64(4738381338321616896), int8(24)))


def closure95(unit_var: None, unit_var_1: None) -> None:
    def v61(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure9(None, None)

    v62: None
    v61(None)
    v62 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v158: US2 = pattern_input[4].l0
    v694: US10
    class ObjectExpr495:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v158, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr495())))) == False:
        v694 = US10(1)

    else: 
        v227: None
        v61(None)
        v227 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v281: int64 | None = pattern_input_1[5]
        v280: Mut6 = pattern_input_1[4]
        v279: Mut5 = pattern_input_1[3]
        v278: Mut4 = pattern_input_1[2]
        v277: Mut3 = pattern_input_1[1]
        v276: Mut1 = pattern_input_1[0]
        v325: str = method67(v276, v277, v278, v279, v280, v281, method19(v276, v277, v278, v279, v280, v281), method23())
        v387: None
        v61(None)
        v387 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v437: Mut3 = pattern_input_2[1]
        v436: Mut1 = pattern_input_2[0]
        v489: None
        closure17(v436, None)
        v489 = None
        closure18(None, v325)
        v437.l0(v325)
        v694 = US10(0, v436, v437, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure96(unit_var: None, unit_var_1: None) -> int:
    return int(uint8(1))


def closure97(unit_var: None, v0_1: int) -> US14:
    return US14(0, v0_1)


def closure98(unit_var: None, v0_1: Exception) -> US14:
    return US14(1, v0_1)


def method71(__unit: None=None) -> US14:
    try: 
        return closure97(None, closure96(None, None))

    except Exception as ex:
        def v_1(__unit: None=None) -> Exception:
            return ex

        return closure98(None, closure13(None, v_1))



def closure99(unit_var: None, unit_var_1: None) -> int:
    return int(uint8(7))


def method72(__unit: None=None) -> US14:
    try: 
        return closure97(None, closure99(None, None))

    except Exception as ex:
        def v_1(__unit: None=None) -> Exception:
            return ex

        return closure98(None, closure13(None, v_1))



def closure100(v0_1: int, unit_var: None) -> uint8:
    return int(v0_1+0x100 if v0_1 < 0 else v0_1) & 0xFF


def closure101(unit_var: None, v0_1: uint8) -> US16:
    return US16(0, v0_1)


def closure102(unit_var: None, v0_1: Exception) -> US16:
    return US16(1, v0_1)


def method73(v0_1: int) -> US16:
    try: 
        return closure101(None, closure100(v0_1, None))

    except Exception as ex:
        def v_1(__unit: None=None) -> Exception:
            return ex

        return closure102(None, closure13(None, v_1))



def method70(__unit: None=None) -> uint8:
    v2378: Any = {}
    v2567: US14 = method71()
    v2588: US15 = US15(0, v2567.fields[0]) if (v2567.tag == 0) else US15(1)
    v2635: int
    if v2588.tag == 0:
        v2635 = v2588.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v2921: US14 = method72()
    v2942: US15 = US15(0, v2921.fields[0]) if (v2921.tag == 0) else US15(1)
    def _arrow496(__unit: None=None) -> int:
        raise Exception("Option does not have a value.")

    v3101: US16 = method73(randint(v2635, v2942.fields[0] if (v2942.tag == 0) else _arrow496()))
    v3122: US1 = US1(0, v3101.fields[0]) if (v3101.tag == 0) else US1(1)
    if v3122.tag == 0:
        return v3122.fields[0]

    else: 
        raise Exception("Option does not have a value.")



def method76(v0_1: int8, v1_1: int64, v2_1: uint8, v3_1: int64) -> str:
    v15: Mut5 = Mut5(method13())
    method28(v15)
    method55(v15)
    method30(v15)
    method14(v15, ("" + str(v0_1)) + "")
    method31(v15)
    method32(v15)
    method30(v15)
    method14(v15, ("" + str(v1_1)) + "")
    method31(v15)
    method60(v15)
    method30(v15)
    method14(v15, ("" + str(v2_1)) + "")
    method31(v15)
    method61(v15)
    method30(v15)
    method14(v15, ("" + str(v3_1)) + "")
    method35(v15)
    return v15.l0


def method75(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(23), v8, v9, v10))


def closure103(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr497:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr497())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method75(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method78(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(22), v8, v9, v10))


def closure104(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr498:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr498())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method78(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method80(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(21), v8, v9, v10))


def closure105(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr499:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr499())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method80(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method82(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(20), v8, v9, v10))


def closure106(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr500:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr500())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method82(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method84(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(19), v8, v9, v10))


def closure107(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr501:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr501())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method84(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method86(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(18), v8, v9, v10))


def closure108(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr502:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr502())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method86(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method88(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(17), v8, v9, v10))


def closure109(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr503:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr503())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method88(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method90(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(16), v8, v9, v10))


def closure110(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr504:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr504())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method90(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method92(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(15), v8, v9, v10))


def closure111(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr505:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr505())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method92(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method94(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(14), v8, v9, v10))


def closure112(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr506:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr506())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method94(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method96(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(13), v8, v9, v10))


def closure113(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr507:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr507())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method96(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method98(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(12), v8, v9, v10))


def closure114(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr508:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr508())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method98(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method100(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(11), v8, v9, v10))


def closure115(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr509:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr509())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method100(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method102(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(10), v8, v9, v10))


def closure116(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr510:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr510())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method102(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method104(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(9), v8, v9, v10))


def closure117(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr511:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr511())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method104(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method106(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(8), v8, v9, v10))


def closure118(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr512:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr512())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method106(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method108(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(7), v8, v9, v10))


def closure119(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr513:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr513())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method108(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method110(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(6), v8, v9, v10))


def closure120(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr514:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr514())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method110(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method112(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(5), v8, v9, v10))


def closure121(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr515:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr515())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method112(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method114(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(4), v8, v9, v10))


def closure122(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr516:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr516())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method114(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method116(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(3), v8, v9, v10))


def closure123(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr517:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr517())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method116(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method118(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(2), v8, v9, v10))


def closure124(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr518:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr518())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method118(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method120(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(1), v8, v9, v10))


def closure125(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr519:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr519())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method120(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method122(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8, v10: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method76(int8(0), v8, v9, v10))


def closure126(v0_1: int64, v1_1: uint8, v2_1: int64, unit_var: None) -> None:
    def v64(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v65: None
    v64(None)
    v65 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v161: US2 = pattern_input[4].l0
    v697: US10
    class ObjectExpr520:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v161, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr520())))) == False:
        v697 = US10(1)

    else: 
        v230: None
        v64(None)
        v230 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v284: int64 | None = pattern_input_1[5]
        v283: Mut6 = pattern_input_1[4]
        v282: Mut5 = pattern_input_1[3]
        v281: Mut4 = pattern_input_1[2]
        v280: Mut3 = pattern_input_1[1]
        v279: Mut1 = pattern_input_1[0]
        v328: str = method122(v279, v280, v281, v282, v283, v284, method19(v279, v280, v281, v282, v283, v284), method23(), v0_1, v1_1, v2_1)
        v390: None
        v64(None)
        v390 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v440: Mut3 = pattern_input_2[1]
        v439: Mut1 = pattern_input_2[0]
        v492: None
        closure17(v439, None)
        v492 = None
        closure18(None, v328)
        v440.l0(v328)
        v697 = US10(0, v439, v440, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method125(v0_1: int8, v1_1: int64, v2_1: int64) -> str:
    v14: Mut5 = Mut5(method13())
    method28(v14)
    method55(v14)
    method30(v14)
    method14(v14, ("" + str(v0_1)) + "")
    method31(v14)
    method32(v14)
    method30(v14)
    method14(v14, ("" + str(v1_1)) + "")
    method31(v14)
    method56(v14)
    method30(v14)
    method14(v14, ("" + str(v2_1)) + "")
    method35(v14)
    return v14.l0


def method124(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method125(int8(-1), v8, v9))


def closure127(v0_1: int64, v1_1: int64, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr521:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr521())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method124(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method123(v0_1: UH1, v1_1: int64) -> US17:
    v2_1: int64 = op_addition(v1_1, int64(1))
    v1492: None
    closure127(v1_1, v2_1, None)
    v1492 = None
    return US17(0, v2_1, v0_1)


def method127(v0_1: int8, v1_1: int64, v2_1: uint8) -> str:
    v14: Mut5 = Mut5(method13())
    method28(v14)
    method55(v14)
    method30(v14)
    method14(v14, ("" + str(v0_1)) + "")
    method31(v14)
    method32(v14)
    method30(v14)
    method14(v14, ("" + str(v1_1)) + "")
    method31(v14)
    method60(v14)
    method30(v14)
    method14(v14, ("" + str(v2_1)) + "")
    method35(v14)
    return v14.l0


def method126(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(0), v8, v9))


def closure128(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr522:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr522())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method126(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method121(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v7: int64 = from_integer(v3_1 - uint8(1), False, 4)
            v1497: None
            closure126(v1_1, v3_1, v7, None)
            v1497 = None
            return method123(v4_1, op_addition(v1_1, v7))

        else: 
            v3739: None
            closure128(v1_1, v3_1, None)
            v3739 = None
            return method123(v4_1, v1_1)




def method128(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(1), v8, v9))


def closure129(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr523:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr523())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method128(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method119(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(6))
            v1498: None
            closure125(v1_1, v3_1, v8, None)
            v1498 = None
            return method121(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure129(v1_1, v3_1, None)
            v3740 = None
            return method121(v4_1, v1_1)




def method129(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(2), v8, v9))


def closure130(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr524:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr524())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method129(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method117(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(36))
            v1498: None
            closure124(v1_1, v3_1, v8, None)
            v1498 = None
            return method119(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure130(v1_1, v3_1, None)
            v3740 = None
            return method119(v4_1, v1_1)




def method130(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(3), v8, v9))


def closure131(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr525:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr525())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method130(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method115(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(216))
            v1498: None
            closure123(v1_1, v3_1, v8, None)
            v1498 = None
            return method117(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure131(v1_1, v3_1, None)
            v3740 = None
            return method117(v4_1, v1_1)




def method131(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(4), v8, v9))


def closure132(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr526:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr526())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method131(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method113(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1296))
            v1498: None
            closure122(v1_1, v3_1, v8, None)
            v1498 = None
            return method115(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure132(v1_1, v3_1, None)
            v3740 = None
            return method115(v4_1, v1_1)




def method132(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(5), v8, v9))


def closure133(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr527:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr527())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method132(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method111(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(7776))
            v1498: None
            closure121(v1_1, v3_1, v8, None)
            v1498 = None
            return method113(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure133(v1_1, v3_1, None)
            v3740 = None
            return method113(v4_1, v1_1)




def method133(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(6), v8, v9))


def closure134(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr528:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr528())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method133(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method109(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(46656))
            v1498: None
            closure120(v1_1, v3_1, v8, None)
            v1498 = None
            return method111(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure134(v1_1, v3_1, None)
            v3740 = None
            return method111(v4_1, v1_1)




def method134(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(7), v8, v9))


def closure135(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr529:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr529())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method134(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method107(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(279936))
            v1498: None
            closure119(v1_1, v3_1, v8, None)
            v1498 = None
            return method109(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure135(v1_1, v3_1, None)
            v3740 = None
            return method109(v4_1, v1_1)




def method135(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(8), v8, v9))


def closure136(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr530:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr530())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method135(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method105(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(1679616))
            v1498: None
            closure118(v1_1, v3_1, v8, None)
            v1498 = None
            return method107(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure136(v1_1, v3_1, None)
            v3740 = None
            return method107(v4_1, v1_1)




def method136(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(9), v8, v9))


def closure137(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr531:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr531())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method136(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method103(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(10077696))
            v1498: None
            closure117(v1_1, v3_1, v8, None)
            v1498 = None
            return method105(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure137(v1_1, v3_1, None)
            v3740 = None
            return method105(v4_1, v1_1)




def method137(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(10), v8, v9))


def closure138(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr532:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr532())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method137(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method101(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(60466176))
            v1498: None
            closure116(v1_1, v3_1, v8, None)
            v1498 = None
            return method103(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure138(v1_1, v3_1, None)
            v3740 = None
            return method103(v4_1, v1_1)




def method138(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(11), v8, v9))


def closure139(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr533:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr533())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method138(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method99(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(362797056))
            v1498: None
            closure115(v1_1, v3_1, v8, None)
            v1498 = None
            return method101(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure139(v1_1, v3_1, None)
            v3740 = None
            return method101(v4_1, v1_1)




def method139(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(12), v8, v9))


def closure140(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr534:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr534())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method139(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method97(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2176782336))
            v1498: None
            closure114(v1_1, v3_1, v8, None)
            v1498 = None
            return method99(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure140(v1_1, v3_1, None)
            v3740 = None
            return method99(v4_1, v1_1)




def method140(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(13), v8, v9))


def closure141(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr535:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr535())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method140(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method95(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(13060694016))
            v1498: None
            closure113(v1_1, v3_1, v8, None)
            v1498 = None
            return method97(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure141(v1_1, v3_1, None)
            v3740 = None
            return method97(v4_1, v1_1)




def method141(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(14), v8, v9))


def closure142(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr536:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr536())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method141(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method93(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(78364164096))
            v1498: None
            closure112(v1_1, v3_1, v8, None)
            v1498 = None
            return method95(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure142(v1_1, v3_1, None)
            v3740 = None
            return method95(v4_1, v1_1)




def method142(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(15), v8, v9))


def closure143(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr537:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr537())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method142(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method91(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(470184984576))
            v1498: None
            closure111(v1_1, v3_1, v8, None)
            v1498 = None
            return method93(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure143(v1_1, v3_1, None)
            v3740 = None
            return method93(v4_1, v1_1)




def method143(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(16), v8, v9))


def closure144(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr538:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr538())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method143(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method89(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(2821109907456))
            v1498: None
            closure110(v1_1, v3_1, v8, None)
            v1498 = None
            return method91(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure144(v1_1, v3_1, None)
            v3740 = None
            return method91(v4_1, v1_1)




def method144(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(17), v8, v9))


def closure145(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr539:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr539())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method144(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method87(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(16926659444736))
            v1498: None
            closure109(v1_1, v3_1, v8, None)
            v1498 = None
            return method89(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure145(v1_1, v3_1, None)
            v3740 = None
            return method89(v4_1, v1_1)




def method145(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(18), v8, v9))


def closure146(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr540:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr540())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method145(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method85(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(101559956668416))
            v1498: None
            closure108(v1_1, v3_1, v8, None)
            v1498 = None
            return method87(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure146(v1_1, v3_1, None)
            v3740 = None
            return method87(v4_1, v1_1)




def method146(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(19), v8, v9))


def closure147(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr541:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr541())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method146(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method83(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(609359740010496))
            v1498: None
            closure107(v1_1, v3_1, v8, None)
            v1498 = None
            return method85(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure147(v1_1, v3_1, None)
            v3740 = None
            return method85(v4_1, v1_1)




def method147(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(20), v8, v9))


def closure148(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr542:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr542())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method147(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method81(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(3656158440062976))
            v1498: None
            closure106(v1_1, v3_1, v8, None)
            v1498 = None
            return method83(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure148(v1_1, v3_1, None)
            v3740 = None
            return method83(v4_1, v1_1)




def method148(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(21), v8, v9))


def closure149(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr543:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr543())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method148(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method79(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(21936950640377856))
            v1498: None
            closure105(v1_1, v3_1, v8, None)
            v1498 = None
            return method81(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure149(v1_1, v3_1, None)
            v3740 = None
            return method81(v4_1, v1_1)




def method149(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(22), v8, v9))


def closure150(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr544:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr544())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method149(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method77(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(131621703842267136))
            v1498: None
            closure104(v1_1, v3_1, v8, None)
            v1498 = None
            return method79(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure150(v1_1, v3_1, None)
            v3740 = None
            return method79(v4_1, v1_1)




def method150(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64, v9: uint8) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.accumulate_dice_rolls") + " / ") + method127(int8(23), v8, v9))


def closure151(v0_1: int64, v1_1: uint8, unit_var: None) -> None:
    def v63(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v64: None
    v63(None)
    v64 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v160: US2 = pattern_input[4].l0
    v696: US10
    class ObjectExpr545:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v160, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr545())))) == False:
        v696 = US10(1)

    else: 
        v229: None
        v63(None)
        v229 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v283: int64 | None = pattern_input_1[5]
        v282: Mut6 = pattern_input_1[4]
        v281: Mut5 = pattern_input_1[3]
        v280: Mut4 = pattern_input_1[2]
        v279: Mut3 = pattern_input_1[1]
        v278: Mut1 = pattern_input_1[0]
        v327: str = method150(v278, v279, v280, v281, v282, v283, method19(v278, v279, v280, v281, v282, v283), method23(), v0_1, v1_1)
        v389: None
        v63(None)
        v389 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v439: Mut3 = pattern_input_2[1]
        v438: Mut1 = pattern_input_2[0]
        v491: None
        closure17(v438, None)
        v491 = None
        closure18(None, v327)
        v439.l0(v327)
        v696 = US10(0, v438, v439, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method74(v0_1: UH1, v1_1: int64) -> US17:
    if v0_1.tag == 0:
        return US17(1)

    else: 
        v4_1: UH1 = v0_1.fields[1]
        v3_1: uint8 = v0_1.fields[0]
        if v3_1 > uint8(1):
            v8: int64 = op_multiply(from_integer(v3_1 - uint8(1), False, 4), int64(789730223053602816))
            v1498: None
            closure103(v1_1, v3_1, v8, None)
            v1498 = None
            return method77(v4_1, op_addition(v1_1, v8))

        else: 
            v3740: None
            closure151(v1_1, v3_1, None)
            v3740 = None
            return method77(v4_1, v1_1)




def method69(v0_1_mut: UH1, v1_1_mut: int8) -> int64:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 < int8(24):
            v0_1_mut = UH1(1, method70(), v0_1)
            v1_1_mut = v1_1 + int8(1)
            continue

        else: 
            v8: US17 = method74(v0_1, int64(0))
            if v8.tag == 0:
                v9: int64 = v8.fields[0]
                if v9 <= int64(9223372036854775807):
                    return v9

                else: 
                    v0_1_mut = UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(0))))))))))))))))))))))))
                    v1_1_mut = int8(23)
                    continue


            else: 
                v0_1_mut = UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(1, method70(), UH1(0))))))))))))))))))))))))
                v1_1_mut = int8(23)
                continue


        break


def method152(v0_1: int64) -> str:
    v12: Mut5 = Mut5(method13())
    method28(v12)
    method56(v12)
    method30(v12)
    method14(v12, ("" + str(v0_1)) + "")
    method35(v12)
    return v12.l0


def method151(v0_1: Mut1, v1_1: Mut3, v2_1: Mut4, v3_1: Mut5, v4_1: Mut6, v5: int64 | None, v6: str, v7: str, v8: int64) -> str:
    return method36(((((((v6 + " ") + method26(v0_1.l0)) + v7) + " ") + "dice.main") + " / ") + method152(v8))


def closure152(v0_1: int64, unit_var: None) -> None:
    def v62(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure9(None, None)

    v63: None
    v62(None)
    v63 = None
    pattern_input: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
    v159: US2 = pattern_input[4].l0
    v695: US10
    class ObjectExpr546:
        @property
        def Compare(self) -> Callable[[US2, US2], int]:
            return compare

    if (False if (pattern_input[2].l0 == False) else (1 >= find(v159, of_seq(to_enumerable([(US2(0), 0), (US2(1), 1), (US2(2), 2), (US2(3), 3), (US2(4), 4)]), ObjectExpr546())))) == False:
        v695 = US10(1)

    else: 
        v228: None
        v62(None)
        v228 = None
        pattern_input_1: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v282: int64 | None = pattern_input_1[5]
        v281: Mut6 = pattern_input_1[4]
        v280: Mut5 = pattern_input_1[3]
        v279: Mut4 = pattern_input_1[2]
        v278: Mut3 = pattern_input_1[1]
        v277: Mut1 = pattern_input_1[0]
        v326: str = method151(v277, v278, v279, v280, v281, v282, method19(v277, v278, v279, v280, v281, v282), method23(), v0_1)
        v388: None
        v62(None)
        v388 = None
        pattern_input_2: tuple[Mut1, Mut3, Mut4, Mut5, Mut6, int64 | None] = value_1(TraceState_trace_state())
        v438: Mut3 = pattern_input_2[1]
        v437: Mut1 = pattern_input_2[0]
        v490: None
        closure17(v437, None)
        v490 = None
        closure18(None, v326)
        v438.l0(v326)
        v695 = US10(0, v437, v438, pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure94(unit_var: None, v0_1: Array[str]) -> int:
    v1490: None
    closure95(None, None)
    v1490 = None
    v3733: None
    closure152(method69(UH1(0), int8(0)), None)
    v3733 = None
    return 0


def _arrow547(v: int64) -> Callable[[UH0], UH0]:
    return closure0(None, v)


v0: Callable[[int64, UH0], UH0] = _arrow547

def rotate_numbers(x: int64) -> Callable[[UH0], UH0]:
    return v0(x)


def _arrow548(v: UH1) -> Callable[[], uint8]:
    return closure3(None, v)


v1: Callable[[UH1, None], uint8] = _arrow548

def create_sequential_roller(x: UH1) -> Callable[[], uint8]:
    return v1(x)


def _arrow549(v: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return closure21(None, v)


v2: Callable[[Callable[[], uint8], bool, uint64], uint64] = _arrow549

def roll_progressively(x: Callable[[], uint8]) -> Callable[[bool, uint64], uint64]:
    return v2(x)


def _arrow550(v: uint64) -> Callable[[UH1], uint64 | None]:
    return closure92(None, v)


v3: Callable[[uint64, UH1], uint64 | None] = _arrow550

def roll_within_bounds(x: uint64) -> Callable[[UH1], uint64 | None]:
    return v3(x)


def _arrow551(v: Array[str]) -> int:
    return closure94(None, v)


v4: Callable[[Array[str]], int] = _arrow551

def main(args: Array[str]) -> int:
    return v4(args)


if __name__ == "__main__":
    main(sys.argv[1:])


