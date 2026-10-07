kernels_main = r"""
"""
from dice_auto import *
kernels = kernels_aux + kernels_main
import os
try: # CuPy when a CUDA device answers, otherwise numpy under the same name (SPIRAL_CUDA=0 forces numpy).
    if os.environ.get('SPIRAL_CUDA', '1') == '0': raise ImportError('SPIRAL_CUDA=0')
    import cupy as cp
    if cp.cuda.runtime.getDeviceCount() < 1: raise RuntimeError('no CUDA device')
    cuda = True
except Exception:
    import numpy as cp
    cuda = False
from dataclasses import dataclass
from typing import NamedTuple, Union, Callable, Tuple
import os
import datetime
class TraceState: trace_state = None
import math
import random
i8 = int; i16 = int; i32 = int; i64 = int; u8 = int; u16 = int; u32 = int; u64 = int; f32 = float; f64 = float; char = str; string = str

def spiral_object_array(*items):
    import numpy
    array = numpy.empty(len(items), dtype=object)
    for i, x in enumerate(items): array[i] = x
    return array
def spiral_array_index(array, index):
    value = array[index]
    return value.item() if isinstance(array, cp.ndarray) and array.dtype.kind != 'O' else value
UH0 = Union["UH0_0", "UH0_1"]
class US0_0(NamedTuple): # Verbose
    tag = 0
class US0_1(NamedTuple): # Debug
    tag = 1
class US0_2(NamedTuple): # Info
    tag = 2
class US0_3(NamedTuple): # Warning
    tag = 3
class US0_4(NamedTuple): # Critical
    tag = 4
US0 = Union[US0_0, US0_1, US0_2, US0_3, US0_4]
@dataclass
class Mut0:
    v0 : i64
@dataclass
class Mut1:
    v0 : Callable[[string], None]
@dataclass
class Mut2:
    v0 : bool
@dataclass
class Mut3:
    v0 : string
@dataclass
class Mut4:
    v0 : US0
class US1_0(NamedTuple): # Some
    v0 : US0
    tag = 0
class US1_1(NamedTuple): # None
    tag = 1
US1 = Union[US1_0, US1_1]
class US2_0(NamedTuple): # Some
    v0 : i64
    tag = 0
class US2_1(NamedTuple): # None
    tag = 1
US2 = Union[US2_0, US2_1]
class US3_0(NamedTuple): # Some
    v0 : string
    tag = 0
class US3_1(NamedTuple): # None
    tag = 1
US3 = Union[US3_0, US3_1]
@dataclass
class Mut5:
    v0 : i32
    v1 : US1
def Closure1(env_v0 : f64):
    def inner() -> i64:
        nonlocal env_v0
        v0 = env_v0
        v1 = i64(v0)
        del v0
        return v1
    return inner
class US4_0(NamedTuple): # Ok
    v0 : i64
    tag = 0
class US4_1(NamedTuple): # Error
    v0 : 'BaseException'
    tag = 1
US4 = Union[US4_0, US4_1]
def Closure2():
    def inner(v0 : i64) -> US4:
        return US4_0(v0)
    return inner
def Closure3():
    def inner(v0 : 'BaseException') -> US4:
        return US4_1(v0)
    return inner
def Closure4():
    def inner(v0 : Callable[[], 'BaseException']) -> 'BaseException':
        return v0()
    return inner
class US5_0(NamedTuple): # Some
    v0 : i64
    tag = 0
class US5_1(NamedTuple): # None
    tag = 1
US5 = Union[US5_0, US5_1]
def Closure5(env_v0 : i64):
    def inner() -> i64:
        nonlocal env_v0
        v0 = env_v0
        v1 = i64(v0)
        del v0
        return v1
    return inner
class US6_0(NamedTuple): # Ok
    v0 : i64
    tag = 0
class US6_1(NamedTuple): # Error
    v0 : 'BaseException'
    tag = 1
US6 = Union[US6_0, US6_1]
def Closure6():
    def inner(v0 : i64) -> US6:
        return US6_0(v0)
    return inner
def Closure7():
    def inner(v0 : 'BaseException') -> US6:
        return US6_1(v0)
    return inner
def Closure8():
    def inner(v0 : string) -> None:
        return 
    return inner
def Closure0():
    def inner(v0 : US0) -> Tuple[Mut0, Mut1, Mut2, Mut3, Mut4, i64]:
        v1, v2, v3, v4, v5, v6 = method0(v0)
        return v1, v2, v3, v4, v5, v6
    return inner
class US7_0(NamedTuple): # Some
    v0 : Mut0
    v1 : Mut1
    v2 : Mut2
    v3 : Mut3
    v4 : Mut4
    v5 : i64
    tag = 0
class US7_1(NamedTuple): # None
    tag = 1
US7 = Union[US7_0, US7_1]
def Closure9():
    def inner(v0 : string) -> None:
        print(v0)
        return 
    return inner
class UH0_0(NamedTuple): # Nil
    tag = 0
class UH0_1(NamedTuple): # Cons
    v0 : u8
    v1 : UH0
    tag = 1
class US8_0(NamedTuple): # Some
    v0 : i64
    v1 : UH0
    tag = 0
class US8_1(NamedTuple): # None
    tag = 1
US8 = Union[US8_0, US8_1]
def method2(v0 : string) -> string:
    v1 = os.environ
    v2 = v1.get(v0)
    del v0, v1
    v3 = v2 
    del v2
    v4 = None
    v5 = v3 == v4 
    del v4
    if v5:
        v6 = None
        v10 = v6
    else:
        v7 = v3 
        v8 = US3_0(v7)
        del v7
        v9 = v8 
        del v8
        v10 = v9
    del v3, v5
    v11 = US3_1()
    v12 = (v11 if v10 is None else v10)
    del v10, v11
    match v12:
        case US3_1(): # None
            del v12
            v14 = ""
            return v14
        case US3_0(v13): # Some
            del v12
            return v13
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method3(v0 : 'list', v1 : i32, v2 : cp.ndarray, v3 : i32) -> cp.ndarray:
    while True:
        v4 = v3 >= v1
        if v4:
            del v0, v1, v3, v4
            return v2
        else:
            del v4
            v5, v6 = v0[v3]
            v2[v3] = v5, v6
            del v5, v6
            v7 = v3 + 1
            del v3
            v0, v1, v2, v3 = v0, v1, v2, v7
            continue
def method4(v0 : i32, v1 : Mut5) -> bool:
    v2 = v1.v0
    del v1
    v3 = v2 < v0
    del v0, v2
    return v3
def method1() -> Tuple[US1, US2]:
    v0 = "TRACE_LEVEL"
    v1 = method2(v0)
    del v0
    v2 = "Critical"
    v3 = v2.lower()
    v4 = "Warning"
    v5 = v4.lower()
    v6 = "Info"
    v7 = v6.lower()
    v8 = "Debug"
    v9 = v8.lower()
    v10 = "Verbose"
    v11 = v10.lower()
    v12 = []
    v13 = US0_4()
    v12.insert(0, (v3, v13))
    del v3, v13
    v14 = v12 
    del v12
    v15 = US0_3()
    v14.insert(0, (v5, v15))
    del v5, v15
    v16 = v14 
    del v14
    v17 = US0_2()
    v16.insert(0, (v7, v17))
    del v7, v17
    v18 = v16 
    del v16
    v19 = US0_1()
    v18.insert(0, (v9, v19))
    del v9, v19
    v20 = v18 
    del v18
    v21 = US0_0()
    v20.insert(0, (v11, v21))
    del v11, v21
    v22 = v20 
    del v20
    v23 = US0_4()
    v22.insert(0, (v2, v23))
    del v2, v23
    v24 = v22 
    del v22
    v25 = US0_3()
    v24.insert(0, (v4, v25))
    del v4, v25
    v26 = v24 
    del v24
    v27 = US0_2()
    v26.insert(0, (v6, v27))
    del v6, v27
    v28 = v26 
    del v26
    v29 = US0_1()
    v28.insert(0, (v8, v29))
    del v8, v29
    v30 = v28 
    del v28
    v31 = US0_0()
    v30.insert(0, (v10, v31))
    del v10, v31
    v32 = v30 
    del v30
    v33 = len(v32)
    v34 = __import__("numpy").empty(v33, dtype=object)
    v35 = 0
    v36 = method3(v32, v33, v34, v35)
    del v32, v33, v34, v35
    v37 = v36.size
    v38 = US1_1()
    v39 = Mut5(0, v38)
    del v38
    while method4(v37, v39):
        v41 = v39.v0
        v42 = -v41
        v43 = v42 + v37
        del v42
        v44 = v43 - 1
        del v43
        v45 = v39.v1
        v46, v47 = spiral_array_index(v36, v44)
        del v44
        match v45:
            case US1_1(): # None
                v49 = v46 == v1 
                if v49:
                    del v49
                    v54 = US1_0(v47)
                else:
                    del v49
                    v54 = US1_1()
            case US1_0(_): # Some
                v54 = v45
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v45, v46, v47
        v55 = v41 + 1
        del v41
        v39.v0 = v55
        v39.v1 = v54
        del v54, v55
    del v1, v36, v37
    v56 = v39.v1
    del v39
    v57 = "AUTOMATION"
    v58 = method2(v57)
    del v57
    v59 = "True"
    v60 = v58 != v59 
    del v58, v59
    if v60:
        v99 = US2_1()
    else:
        v62 = datetime.datetime.now()
        v63 = datetime.datetime.min
        v64 = v62 - v63 
        del v62, v63
        v65 = v64.total_seconds() * 10000000
        del v64
        v66 = v65 // 10000000
        del v65
        v67 = f64(v66)
        del v66
        v68 = 10000000.0 * v67
        del v67
        v69 = Closure1(v68)
        del v68
        fn = v69 
        del v69
        v70 = Closure2()
        ok = v70 
        del v70
        v71 = Closure3()
        error = v71 
        del v71
        v72 = Closure4()
        ex_fn = v72 
        try: x = ok(fn()) 
        except Exception as ex: x = error(ex_fn(lambda: ex))
        v73 = x
        match v73:
            case US4_1(_): # Error
                v79 = US5_1()
            case US4_0(v74): # Ok
                v79 = US5_0(v74)
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v73
        match v79:
            case US5_1(): # None
                raise Exception("Option does not have a value.")
            case US5_0(v80): # Some
                v83 = v80
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v79
        v84 = Closure5(v83)
        del v83
        fn = v84 
        del v84
        v85 = Closure6()
        ok = v85 
        del v85
        v86 = Closure7()
        error = v86 
        del v86
        ex_fn = v72 
        del v72
        try: x = ok(fn()) 
        except Exception as ex: x = error(ex_fn(lambda: ex))
        v87 = x
        match v87:
            case US6_1(_): # Error
                v93 = US2_1()
            case US6_0(v88): # Ok
                v93 = US2_0(v88)
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v87
        match v93:
            case US2_1(): # None
                raise Exception("Option does not have a value.")
            case US2_0(v94): # Some
                v97 = v94
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v93
        v99 = US2_0(v97)
    del v60
    return v56, v99
def method0(v0 : US0) -> Tuple[Mut0, Mut1, Mut2, Mut3, Mut4, i64]:
    v1, v2 = method1()
    v3 = Mut0(1)
    v4 = Closure8()
    v5 = Mut1(v4)
    del v4
    v6 = Mut2(True)
    v7 = ""
    v8 = Mut3(v7)
    del v7
    match v1:
        case US1_1(): # None
            v11 = v0
        case US1_0(v9): # Some
            v11 = v9
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v0, v1
    v12 = Mut4(v11)
    del v11
    match v2:
        case US2_1(): # None
            v15 = None
            v17 = v15
        case US2_0(v13): # Some
            v14 = v13 # some' 
            del v13
            v17 = v14
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v2
    return v3, v5, v6, v8, v12, v17
def method6(v0 : 'datetime.datetime') -> 'datetime.datetime':
    return v0
def method5(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64) -> string:
    del v0, v1, v2, v3, v4
    v61 = None
    v62 = v5 == v61 
    del v61
    if v62:
        v63 = None
        v67 = v63
    else:
        v64 = v5 
        v65 = US2_0(v64)
        del v64
        v66 = v65 
        del v65
        v67 = v66
    del v5, v62
    v68 = US2_1()
    v69 = (v68 if v67 is None else v67)
    del v67, v68
    match v69:
        case US2_1(): # None
            v114 = datetime.datetime.now()
            v116 = v114
        case US2_0(v70): # Some
            v71 = datetime.datetime.now()
            v72 = datetime.datetime.min
            v73 = v71 - v72 
            del v71, v72
            v74 = v73.total_seconds() * 10000000
            del v73
            v75 = v74 // 10000000
            del v74
            v76 = f64(v75)
            del v75
            v77 = 10000000.0 * v76
            del v76
            v78 = Closure1(v77)
            del v77
            fn = v78 
            del v78
            v79 = Closure2()
            ok = v79 
            del v79
            v80 = Closure3()
            error = v80 
            del v80
            v81 = Closure4()
            ex_fn = v81 
            try: x = ok(fn()) 
            except Exception as ex: x = error(ex_fn(lambda: ex))
            v82 = x
            match v82:
                case US4_1(_): # Error
                    v88 = US5_1()
                case US4_0(v83): # Ok
                    v88 = US5_0(v83)
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v82
            match v88:
                case US5_1(): # None
                    raise Exception("Option does not have a value.")
                case US5_0(v89): # Some
                    v92 = v89
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v88
            v93 = Closure5(v92)
            del v92
            fn = v93 
            del v93
            v94 = Closure6()
            ok = v94 
            del v94
            v95 = Closure7()
            error = v95 
            del v95
            ex_fn = v81 
            del v81
            try: x = ok(fn()) 
            except Exception as ex: x = error(ex_fn(lambda: ex))
            v96 = x
            match v96:
                case US6_1(_): # Error
                    v102 = US2_1()
                case US6_0(v97): # Ok
                    v102 = US2_0(v97)
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v96
            match v102:
                case US2_1(): # None
                    raise Exception("Option does not have a value.")
                case US2_0(v103): # Some
                    v106 = v103
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v102
            v107 = v106 - v70
            del v70, v106
            v108 = datetime.timedelta(v107)
            del v107
            v109 = v108.seconds // 3600
            v110 = (v108.seconds // 60) % 60
            v111 = v108.seconds % 60
            v112 = v108.microseconds // 1000
            del v108
            v113 = datetime.datetime(1, 1, 1, v109, v110, v111, v112 * 1000)
            del v109, v110, v111, v112
            v116 = v113
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v69
    v117 = method6(v116)
    del v116
    v118 = "%H:%M:%S"
    v119 = v117.strftime(v118)
    del v117, v118
    return v119
def method9(v0 : Mut3, v1 : string) -> None:
    v2 = v0.v0
    v3 = v2 + v1 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method8(v0 : char) -> string:
    v1 = ""
    v2 = Mut3(v1)
    del v1
    v4 = f"{v0}"
    del v0
    method9(v2, v4)
    del v4
    v5 = v2.v0
    del v2
    return v5
def method7() -> string:
    v1 = "\u001b[94m"
    v2 = "Debug"
    v3 = v2.lower()
    del v2
    v4 = v3[0]
    del v3
    v5 = method8(v4)
    del v4
    v6 = v1 + v5 
    del v1, v5
    v8 = "\u001b[0m"
    v9 = v6 + v8 
    del v6, v8
    return v9
def method12(v0 : string, v1 : i32, v2 : i32) -> i32:
    while True:
        v3 = v2 >= v1
        if v3:
            del v0, v2, v3
            return v1
        else:
            del v3
            v4 = v0[v2]
            v5 = v4 == ' '
            if v5:
                v11 = True
            else:
                v6 = v4 == '\t'
                if v6:
                    del v6
                    v11 = True
                else:
                    del v6
                    v7 = v4 == '\r'
                    if v7:
                        del v7
                        v11 = True
                    else:
                        del v7
                        v8 = v4 == '\n'
                        v11 = v8
            del v4, v5
            if v11:
                del v11
                v12 = v2 + 1
                del v2
                v0, v1, v2 = v0, v1, v12
                continue
            else:
                del v0, v1, v11
                return v2
def method13(v0 : string, v1 : i32) -> i32:
    while True:
        v2 = v1 <= 0
        if v2:
            del v0, v1, v2
            return -1
        else:
            del v2
            v3 = v1 - 1
            del v1
            v4 = v0[v3]
            v5 = v4 == ' '
            if v5:
                v7 = True
            else:
                v6 = v4 == '/'
                v7 = v6
            del v4, v5
            if v7:
                del v7
                v0, v1 = v0, v3
                continue
            else:
                del v0, v7
                return v3
def method11(v0 : string) -> string:
    v1 = len(v0)
    v2 = 0
    v3 = method12(v0, v1, v2)
    del v2
    v4 = v1 - 1
    del v1
    v6 = v4 + 1
    del v4
    v7 = v0[v3:v6]
    del v0, v3, v6
    v8 = len(v7)
    v9 = method13(v7, v8)
    del v8
    v11 = v9 + 1
    del v9
    v12 = v7[0:v11]
    del v7, v11
    return v12
def method14(v0 : i64) -> string:
    v1 = ""
    v2 = Mut3(v1)
    del v1
    v4 = f"{v0}"
    del v0
    method9(v2, v4)
    del v4
    v5 = v2.v0
    del v2
    return v5
def method16(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "{ "
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method17(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "max"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method18(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = " = "
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method19(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "; "
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method20(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "p"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method21(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "n"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method22(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = " }"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method15(v0 : i64, v1 : i64, v2 : i8) -> string:
    v3 = ""
    v4 = Mut3(v3)
    del v3
    method16(v4)
    method17(v4)
    method18(v4)
    v5 = f"{v0}"
    del v0
    method9(v4, v5)
    del v5
    method19(v4)
    method20(v4)
    method18(v4)
    v6 = f"{v1}"
    del v1
    method9(v4, v6)
    del v6
    method19(v4)
    method21(v4)
    method18(v4)
    v8 = f"{v2}"
    del v2
    method9(v4, v8)
    del v8
    method22(v4)
    v9 = v4.v0
    del v4
    return v9
def method10(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string) -> string:
    del v1, v2, v3, v4, v5
    v8 = v0.v0
    del v0
    v9 = " "
    v10 = v6 + v9 
    del v6
    v11 = method14(v8)
    del v8
    v12 = v10 + v11 
    del v10, v11
    v13 = v12 + v7 
    del v7, v12
    v14 = v13 + v9 
    del v9, v13
    v17 = "dice.calculate_dice_count"
    v18 = v14 + v17 
    del v14, v17
    v21 = " / "
    v22 = v18 + v21 
    del v18, v21
    v23 = 4738381338321616896
    v24 = 4738381338321616896
    v25 = 24
    v26 = method15(v23, v24, v25)
    del v23, v24, v25
    v27 = v22 + v26 
    del v22, v26
    return method11(v27)
def method24() -> u8:
    v36 = random.randrange(1, 7)
    return v36
def method52(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "power"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method53(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "acc"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method54(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "result"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method51(v0 : i8, v1 : i64, v2 : i64) -> string:
    v3 = ""
    v4 = Mut3(v3)
    del v3
    method16(v4)
    method52(v4)
    method18(v4)
    v5 = f"{v0}"
    del v0
    method9(v4, v5)
    del v5
    method19(v4)
    method53(v4)
    method18(v4)
    v6 = f"{v1}"
    del v1
    method9(v4, v6)
    del v6
    method19(v4)
    method54(v4)
    method18(v4)
    v7 = f"{v2}"
    del v2
    method9(v4, v7)
    del v7
    method22(v4)
    v8 = v4.v0
    del v4
    return v8
def method50(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : i64) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = -1
    v22 = method51(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method49(v0 : UH0, v1 : i64) -> US8:
    v2 = v1 + 1
    v3 = Closure0()
    v4 = US0_0()
    if TraceState.trace_state is None: TraceState.trace_state = v3(v4)
    del v4
    v5, v6, v7, v8, v9, v10 = TraceState.trace_state
    del v5, v6, v8, v10
    v11 = v9.v0
    del v9
    match v11:
        case US0_4(): # Critical
            v16 = 50
        case US0_1(): # Debug
            v16 = 20
        case US0_2(): # Info
            v16 = 30
        case US0_0(): # Verbose
            v16 = 10
        case US0_3(): # Warning
            v16 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v11
    v17 = v7.v0
    del v7
    v18 = v17 == False
    del v17
    if v18:
        v20 = False
    else:
        v19 = 20 >= v16
        v20 = v19
    del v16, v18
    v21 = v20 == False
    del v20
    if v21:
        v45 = US7_1()
    else:
        v23 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v3(v23)
        del v23
        v24, v25, v26, v27, v28, v29 = TraceState.trace_state
        v30 = method5(v24, v25, v26, v27, v28, v29)
        v31 = method7()
        v32 = method50(v24, v25, v26, v27, v28, v29, v30, v31, v1, v2)
        del v24, v25, v26, v27, v28, v29, v30, v31
        v33 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v3(v33)
        del v33
        v34, v35, v36, v37, v38, v39 = TraceState.trace_state
        v40 = v34.v0
        v41 = v40 + 1
        del v40
        v34.v0 = v41
        del v41
        v42 = Closure9()
        v42(v32)
        del v42
        v43 = v35.v0
        v43(v32)
        del v32, v43
        v45 = US7_0(v34, v35, v36, v37, v38, v39)
    del v1, v3, v21, v45
    return US8_0(v2, v0)
def method57(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "roll"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method58(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "value"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method56(v0 : i8, v1 : i64, v2 : u8, v3 : i64) -> string:
    v4 = ""
    v5 = Mut3(v4)
    del v4
    method16(v5)
    method52(v5)
    method18(v5)
    v6 = f"{v0}"
    del v0
    method9(v5, v6)
    del v6
    method19(v5)
    method53(v5)
    method18(v5)
    v7 = f"{v1}"
    del v1
    method9(v5, v7)
    del v7
    method19(v5)
    method57(v5)
    method18(v5)
    v9 = f"{v2}"
    del v2
    method9(v5, v9)
    del v9
    method19(v5)
    method58(v5)
    method18(v5)
    v10 = f"{v3}"
    del v3
    method9(v5, v10)
    del v10
    method22(v5)
    v11 = v5.v0
    del v5
    return v11
def method55(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 0
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method60(v0 : i8, v1 : i64, v2 : u8) -> string:
    v3 = ""
    v4 = Mut3(v3)
    del v3
    method16(v4)
    method52(v4)
    method18(v4)
    v5 = f"{v0}"
    del v0
    method9(v4, v5)
    del v5
    method19(v4)
    method53(v4)
    method18(v4)
    v6 = f"{v1}"
    del v1
    method9(v4, v6)
    del v6
    method19(v4)
    method57(v4)
    method18(v4)
    v7 = f"{v2}"
    del v2
    method9(v4, v7)
    del v7
    method22(v4)
    v8 = v4.v0
    del v4
    return v8
def method59(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 0
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method48(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = Closure0()
                v9 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v8(v9)
                del v9
                v10, v11, v12, v13, v14, v15 = TraceState.trace_state
                del v10, v11, v13, v15
                v16 = v14.v0
                del v14
                match v16:
                    case US0_4(): # Critical
                        v21 = 50
                    case US0_1(): # Debug
                        v21 = 20
                    case US0_2(): # Info
                        v21 = 30
                    case US0_0(): # Verbose
                        v21 = 10
                    case US0_3(): # Warning
                        v21 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v16
                v22 = v12.v0
                del v12
                v23 = v22 == False
                del v22
                if v23:
                    v25 = False
                else:
                    v24 = 20 >= v21
                    v25 = v24
                del v21, v23
                v26 = v25 == False
                del v25
                if v26:
                    v50 = US7_1()
                else:
                    v28 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v8(v28)
                    del v28
                    v29, v30, v31, v32, v33, v34 = TraceState.trace_state
                    v35 = method5(v29, v30, v31, v32, v33, v34)
                    v36 = method7()
                    v37 = method55(v29, v30, v31, v32, v33, v34, v35, v36, v1, v3, v7)
                    del v29, v30, v31, v32, v33, v34, v35, v36
                    v38 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v8(v38)
                    del v38
                    v39, v40, v41, v42, v43, v44 = TraceState.trace_state
                    v45 = v39.v0
                    v46 = v45 + 1
                    del v45
                    v39.v0 = v46
                    del v46
                    v47 = Closure9()
                    v47(v37)
                    del v47
                    v48 = v40.v0
                    v48(v37)
                    del v37, v48
                    v50 = US7_0(v39, v40, v41, v42, v43, v44)
                del v3, v8, v26, v50
                v51 = v1 + v7
                del v1, v7
                return method49(v4, v51)
            else:
                del v5
                v53 = Closure0()
                v54 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v53(v54)
                del v54
                v55, v56, v57, v58, v59, v60 = TraceState.trace_state
                del v55, v56, v58, v60
                v61 = v59.v0
                del v59
                match v61:
                    case US0_4(): # Critical
                        v66 = 50
                    case US0_1(): # Debug
                        v66 = 20
                    case US0_2(): # Info
                        v66 = 30
                    case US0_0(): # Verbose
                        v66 = 10
                    case US0_3(): # Warning
                        v66 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v61
                v67 = v57.v0
                del v57
                v68 = v67 == False
                del v67
                if v68:
                    v70 = False
                else:
                    v69 = 20 >= v66
                    v70 = v69
                del v66, v68
                v71 = v70 == False
                del v70
                if v71:
                    v95 = US7_1()
                else:
                    v73 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v53(v73)
                    del v73
                    v74, v75, v76, v77, v78, v79 = TraceState.trace_state
                    v80 = method5(v74, v75, v76, v77, v78, v79)
                    v81 = method7()
                    v82 = method59(v74, v75, v76, v77, v78, v79, v80, v81, v1, v3)
                    del v74, v75, v76, v77, v78, v79, v80, v81
                    v83 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v53(v83)
                    del v83
                    v84, v85, v86, v87, v88, v89 = TraceState.trace_state
                    v90 = v84.v0
                    v91 = v90 + 1
                    del v90
                    v84.v0 = v91
                    del v91
                    v92 = Closure9()
                    v92(v82)
                    del v92
                    v93 = v85.v0
                    v93(v82)
                    del v82, v93
                    v95 = US7_0(v84, v85, v86, v87, v88, v89)
                del v3, v53, v71, v95
                return method49(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method61(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 1
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method62(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 1
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method47(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 6
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method61(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method48(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method62(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method48(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method63(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 2
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method64(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 2
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method46(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 36
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method63(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method47(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method64(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method47(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method65(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 3
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method66(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 3
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method45(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 216
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method65(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method46(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method66(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method46(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method67(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 4
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method68(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 4
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method44(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 1296
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method67(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method45(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method68(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method45(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method69(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 5
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method70(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 5
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method43(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 7776
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method69(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method44(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method70(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method44(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method71(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 6
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method72(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 6
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method42(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 46656
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method71(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method43(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method72(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method43(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method73(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 7
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method74(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 7
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method41(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 279936
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method73(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method42(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method74(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method42(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method75(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 8
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method76(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 8
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method40(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 1679616
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method75(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method41(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method76(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method41(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method77(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 9
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method78(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 9
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method39(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 10077696
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method77(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method40(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method78(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method40(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method79(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 10
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method80(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 10
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method38(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 60466176
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method79(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method39(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method80(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method39(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method81(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 11
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method82(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 11
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method37(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 362797056
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method81(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method38(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method82(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method38(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method83(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 12
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method84(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 12
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method36(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 2176782336
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method83(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method37(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method84(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method37(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method85(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 13
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method86(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 13
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method35(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 13060694016
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method85(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method36(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method86(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method36(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method87(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 14
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method88(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 14
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method34(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 78364164096
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method87(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method35(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method88(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method35(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method89(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 15
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method90(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 15
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method33(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 470184984576
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method89(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method34(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method90(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method34(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method91(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 16
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method92(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 16
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method32(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 2821109907456
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method91(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method33(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method92(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method33(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method93(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 17
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method94(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 17
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method31(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 16926659444736
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method93(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method32(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method94(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method32(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method95(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 18
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method96(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 18
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method30(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 101559956668416
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method95(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method31(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method96(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method31(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method97(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 19
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method98(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 19
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method29(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 609359740010496
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method97(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method30(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method98(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method30(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method99(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 20
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method100(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 20
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method28(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 3656158440062976
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method99(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method29(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method100(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method29(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method101(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 21
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method102(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 21
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method27(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 21936950640377856
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method101(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method28(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method102(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method28(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method103(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v18 = "dice.accumulate_dice_rolls"
    v19 = v17 + v18 
    del v17, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = 22
    v23 = method56(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method11(v24)
def method104(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 22
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method26(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 131621703842267136
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method103(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method27(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method104(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method27(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method105(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method14(v11)
    del v11
    v15 = v13 + v14 
    del v13, v14
    v16 = v15 + v7 
    del v7, v15
    v17 = v16 + v12 
    del v12, v16
    v20 = "dice.accumulate_dice_rolls"
    v21 = v17 + v20 
    del v17, v20
    v22 = " / "
    v23 = v21 + v22 
    del v21, v22
    v24 = 23
    v25 = method56(v24, v8, v9, v10)
    del v8, v9, v10, v24
    v26 = v23 + v25 
    del v23, v25
    return method11(v26)
def method106(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method14(v10)
    del v10
    v14 = v12 + v13 
    del v12, v13
    v15 = v14 + v7 
    del v7, v14
    v16 = v15 + v11 
    del v11, v15
    v17 = "dice.accumulate_dice_rolls"
    v18 = v16 + v17 
    del v16, v17
    v19 = " / "
    v20 = v18 + v19 
    del v18, v19
    v21 = 23
    v22 = method60(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method11(v23)
def method25(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v8 = v7 * 789730223053602816
                del v7
                v9 = Closure0()
                v10 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
                v11, v12, v13, v14, v15, v16 = TraceState.trace_state
                del v11, v12, v14, v16
                v17 = v15.v0
                del v15
                match v17:
                    case US0_4(): # Critical
                        v22 = 50
                    case US0_1(): # Debug
                        v22 = 20
                    case US0_2(): # Info
                        v22 = 30
                    case US0_0(): # Verbose
                        v22 = 10
                    case US0_3(): # Warning
                        v22 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v17
                v23 = v13.v0
                del v13
                v24 = v23 == False
                del v23
                if v24:
                    v26 = False
                else:
                    v25 = 20 >= v22
                    v26 = v25
                del v22, v24
                v27 = v26 == False
                del v26
                if v27:
                    v51 = US7_1()
                else:
                    v29 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method105(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = v46 + 1
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = Closure9()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US7_0(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = v1 + v8
                del v1, v8
                return method26(v4, v52)
            else:
                del v5
                v54 = Closure0()
                v55 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_4(): # Critical
                        v67 = 50
                    case US0_1(): # Debug
                        v67 = 20
                    case US0_2(): # Info
                        v67 = 30
                    case US0_0(): # Verbose
                        v67 = 10
                    case US0_3(): # Warning
                        v67 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v62
                v68 = v58.v0
                del v58
                v69 = v68 == False
                del v68
                if v69:
                    v71 = False
                else:
                    v70 = 20 >= v67
                    v71 = v70
                del v67, v69
                v72 = v71 == False
                del v71
                if v72:
                    v96 = US7_1()
                else:
                    v74 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method106(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = v91 + 1
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = Closure9()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US7_0(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method26(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method23(v0 : UH0, v1 : i8) -> i64:
    while True:
        v2 = v1 < 24
        if v2:
            del v2
            v3 = method24()
            v4 = UH0_1(v3, v0)
            del v0, v3
            v5 = v1 + 1
            del v1
            v0, v1 = v4, v5
            continue
        else:
            del v1, v2
            v7 = 0
            v8 = method25(v0, v7)
            del v0, v7
            match v8:
                case US8_0(v9, _): # Some
                    del v8
                    v11 = v9 <= 4738381338321616896
                    if v11:
                        del v11
                        return v9
                    else:
                        del v9, v11
                        v12 = method24()
                        v13 = method24()
                        v14 = method24()
                        v15 = method24()
                        v16 = method24()
                        v17 = method24()
                        v18 = method24()
                        v19 = method24()
                        v20 = method24()
                        v21 = method24()
                        v22 = method24()
                        v23 = method24()
                        v24 = method24()
                        v25 = method24()
                        v26 = method24()
                        v27 = method24()
                        v28 = method24()
                        v29 = method24()
                        v30 = method24()
                        v31 = method24()
                        v32 = method24()
                        v33 = method24()
                        v34 = method24()
                        v35 = UH0_0()
                        v36 = UH0_1(v34, v35)
                        del v34, v35
                        v37 = UH0_1(v33, v36)
                        del v33, v36
                        v38 = UH0_1(v32, v37)
                        del v32, v37
                        v39 = UH0_1(v31, v38)
                        del v31, v38
                        v40 = UH0_1(v30, v39)
                        del v30, v39
                        v41 = UH0_1(v29, v40)
                        del v29, v40
                        v42 = UH0_1(v28, v41)
                        del v28, v41
                        v43 = UH0_1(v27, v42)
                        del v27, v42
                        v44 = UH0_1(v26, v43)
                        del v26, v43
                        v45 = UH0_1(v25, v44)
                        del v25, v44
                        v46 = UH0_1(v24, v45)
                        del v24, v45
                        v47 = UH0_1(v23, v46)
                        del v23, v46
                        v48 = UH0_1(v22, v47)
                        del v22, v47
                        v49 = UH0_1(v21, v48)
                        del v21, v48
                        v50 = UH0_1(v20, v49)
                        del v20, v49
                        v51 = UH0_1(v19, v50)
                        del v19, v50
                        v52 = UH0_1(v18, v51)
                        del v18, v51
                        v53 = UH0_1(v17, v52)
                        del v17, v52
                        v54 = UH0_1(v16, v53)
                        del v16, v53
                        v55 = UH0_1(v15, v54)
                        del v15, v54
                        v56 = UH0_1(v14, v55)
                        del v14, v55
                        v57 = UH0_1(v13, v56)
                        del v13, v56
                        v58 = UH0_1(v12, v57)
                        del v12, v57
                        v59 = 23
                        v0, v1 = v58, v59
                        continue
                case t:
                    del v8
                    v62 = method24()
                    v63 = method24()
                    v64 = method24()
                    v65 = method24()
                    v66 = method24()
                    v67 = method24()
                    v68 = method24()
                    v69 = method24()
                    v70 = method24()
                    v71 = method24()
                    v72 = method24()
                    v73 = method24()
                    v74 = method24()
                    v75 = method24()
                    v76 = method24()
                    v77 = method24()
                    v78 = method24()
                    v79 = method24()
                    v80 = method24()
                    v81 = method24()
                    v82 = method24()
                    v83 = method24()
                    v84 = method24()
                    v85 = UH0_0()
                    v86 = UH0_1(v84, v85)
                    del v84, v85
                    v87 = UH0_1(v83, v86)
                    del v83, v86
                    v88 = UH0_1(v82, v87)
                    del v82, v87
                    v89 = UH0_1(v81, v88)
                    del v81, v88
                    v90 = UH0_1(v80, v89)
                    del v80, v89
                    v91 = UH0_1(v79, v90)
                    del v79, v90
                    v92 = UH0_1(v78, v91)
                    del v78, v91
                    v93 = UH0_1(v77, v92)
                    del v77, v92
                    v94 = UH0_1(v76, v93)
                    del v76, v93
                    v95 = UH0_1(v75, v94)
                    del v75, v94
                    v96 = UH0_1(v74, v95)
                    del v74, v95
                    v97 = UH0_1(v73, v96)
                    del v73, v96
                    v98 = UH0_1(v72, v97)
                    del v72, v97
                    v99 = UH0_1(v71, v98)
                    del v71, v98
                    v100 = UH0_1(v70, v99)
                    del v70, v99
                    v101 = UH0_1(v69, v100)
                    del v69, v100
                    v102 = UH0_1(v68, v101)
                    del v68, v101
                    v103 = UH0_1(v67, v102)
                    del v67, v102
                    v104 = UH0_1(v66, v103)
                    del v66, v103
                    v105 = UH0_1(v65, v104)
                    del v65, v104
                    v106 = UH0_1(v64, v105)
                    del v64, v105
                    v107 = UH0_1(v63, v106)
                    del v63, v106
                    v108 = UH0_1(v62, v107)
                    del v62, v107
                    v109 = 23
                    v0, v1 = v108, v109
                    continue
def method108(v0 : i64) -> string:
    v1 = ""
    v2 = Mut3(v1)
    del v1
    method16(v2)
    method54(v2)
    method18(v2)
    v3 = f"{v0}"
    del v0
    method9(v2, v3)
    del v3
    method22(v2)
    v4 = v2.v0
    del v2
    return v4
def method107(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64) -> string:
    del v1, v2, v3, v4, v5
    v9 = v0.v0
    del v0
    v10 = " "
    v11 = v6 + v10 
    del v6
    v12 = method14(v9)
    del v9
    v13 = v11 + v12 
    del v11, v12
    v14 = v13 + v7 
    del v7, v13
    v15 = v14 + v10 
    del v10, v14
    v18 = "dice.main"
    v19 = v15 + v18 
    del v15, v18
    v20 = " / "
    v21 = v19 + v20 
    del v19, v20
    v22 = method108(v8)
    del v8
    v23 = v21 + v22 
    del v21, v22
    return method11(v23)
def main():
    v9 = "Python"
    None # backend.backend_switch / record_type_try_find / key: v9 
    None # backend.backend_switch / record_type_try_find / key: v9 
    None # backend.backend_switch / record_type_try_find / key: v9 
    None # backend.backend_switch / record_type_try_find / key: v9 
    del v9
    v35 = spiral_object_array()
    del v35
    v45 = Closure0()
    v46 = US0_0()
    if TraceState.trace_state is None: TraceState.trace_state = v45(v46)
    del v46
    v53, v54, v55, v56, v57, v58 = TraceState.trace_state
    del v53, v54, v56, v58
    v59 = v57.v0
    del v57
    match v59:
        case US0_4(): # Critical
            v64 = 50
        case US0_1(): # Debug
            v64 = 20
        case US0_2(): # Info
            v64 = 30
        case US0_0(): # Verbose
            v64 = 10
        case US0_3(): # Warning
            v64 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v59
    v65 = v55.v0
    del v55
    v66 = v65 == False
    del v65
    if v66:
        v68 = False
    else:
        v67 = 20 >= v64
        v68 = v67
    del v64, v66
    v69 = v68 == False
    del v68
    if v69:
        v93 = US7_1()
    else:
        v71 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v45(v71)
        del v71
        v72, v73, v74, v75, v76, v77 = TraceState.trace_state
        v78 = method5(v72, v73, v74, v75, v76, v77)
        v79 = method7()
        v80 = method10(v72, v73, v74, v75, v76, v77, v78, v79)
        del v72, v73, v74, v75, v76, v77, v78, v79
        v81 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v45(v81)
        del v81
        v82, v83, v84, v85, v86, v87 = TraceState.trace_state
        v88 = v82.v0
        v89 = v88 + 1
        del v88
        v82.v0 = v89
        del v89
        v90 = Closure9()
        v90(v80)
        del v90
        v91 = v83.v0
        v91(v80)
        del v80, v91
        v93 = US7_0(v82, v83, v84, v85, v86, v87)
    del v69, v93
    v94 = UH0_0()
    v95 = 0
    v96 = method23(v94, v95)
    del v94, v95
    v97 = US0_0()
    if TraceState.trace_state is None: TraceState.trace_state = v45(v97)
    del v97
    v98, v99, v100, v101, v102, v103 = TraceState.trace_state
    del v98, v99, v101, v103
    v104 = v102.v0
    del v102
    match v104:
        case US0_4(): # Critical
            v109 = 50
        case US0_1(): # Debug
            v109 = 20
        case US0_2(): # Info
            v109 = 30
        case US0_0(): # Verbose
            v109 = 10
        case US0_3(): # Warning
            v109 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v104
    v110 = v100.v0
    del v100
    v111 = v110 == False
    del v110
    if v111:
        v113 = False
    else:
        v112 = 20 >= v109
        v113 = v112
    del v109, v111
    v114 = v113 == False
    del v113
    if v114:
        v138 = US7_1()
    else:
        v116 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v45(v116)
        del v116
        v117, v118, v119, v120, v121, v122 = TraceState.trace_state
        v123 = method5(v117, v118, v119, v120, v121, v122)
        v124 = method7()
        v125 = method107(v117, v118, v119, v120, v121, v122, v123, v124, v96)
        del v117, v118, v119, v120, v121, v122, v123, v124
        v126 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v45(v126)
        del v126
        v127, v128, v129, v130, v131, v132 = TraceState.trace_state
        v133 = v127.v0
        v134 = v133 + 1
        del v133
        v127.v0 = v134
        del v134
        v135 = Closure9()
        v135(v125)
        del v135
        v136 = v128.v0
        v136(v125)
        del v125, v136
        v138 = US7_0(v127, v128, v129, v130, v131, v132)
    del v45, v96, v114, v138
    return 

if __name__ == '__main__': result = main(); None if result is None else print(result)
