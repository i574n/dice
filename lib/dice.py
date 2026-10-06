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
        return method3(v0, v1, v2, v7)
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
    v6 = None
    v7 = v5 == v6 
    del v6
    if v7:
        v8 = None
        v12 = v8
    else:
        v9 = v5 
        v10 = US2_0(v9)
        del v9
        v11 = v10 
        del v10
        v12 = v11
    del v5, v7
    v13 = US2_1()
    v14 = (v13 if v12 is None else v12)
    del v12, v13
    match v14:
        case US2_1(): # None
            v59 = datetime.datetime.now()
            v61 = v59
        case US2_0(v15): # Some
            v16 = datetime.datetime.now()
            v17 = datetime.datetime.min
            v18 = v16 - v17 
            del v16, v17
            v19 = v18.total_seconds() * 10000000
            del v18
            v20 = v19 // 10000000
            del v19
            v21 = f64(v20)
            del v20
            v22 = 10000000.0 * v21
            del v21
            v23 = Closure1(v22)
            del v22
            fn = v23 
            del v23
            v24 = Closure2()
            ok = v24 
            del v24
            v25 = Closure3()
            error = v25 
            del v25
            v26 = Closure4()
            ex_fn = v26 
            try: x = ok(fn()) 
            except Exception as ex: x = error(ex_fn(lambda: ex))
            v27 = x
            match v27:
                case US4_1(_): # Error
                    v33 = US5_1()
                case US4_0(v28): # Ok
                    v33 = US5_0(v28)
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v27
            match v33:
                case US5_1(): # None
                    raise Exception("Option does not have a value.")
                case US5_0(v34): # Some
                    v37 = v34
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v33
            v38 = Closure5(v37)
            del v37
            fn = v38 
            del v38
            v39 = Closure6()
            ok = v39 
            del v39
            v40 = Closure7()
            error = v40 
            del v40
            ex_fn = v26 
            del v26
            try: x = ok(fn()) 
            except Exception as ex: x = error(ex_fn(lambda: ex))
            v41 = x
            match v41:
                case US6_1(_): # Error
                    v47 = US2_1()
                case US6_0(v42): # Ok
                    v47 = US2_0(v42)
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v41
            match v47:
                case US2_1(): # None
                    raise Exception("Option does not have a value.")
                case US2_0(v48): # Some
                    v51 = v48
                case t:
                    raise Exception(f'Pattern matching miss. Got: {t}')
            del v47
            v52 = v51 - v15
            del v15, v51
            v53 = datetime.timedelta(v52)
            del v52
            v54 = v53.seconds // 3600
            v55 = (v53.seconds // 60) % 60
            v56 = v53.seconds % 60
            v57 = v53.microseconds // 1000
            del v53
            v58 = datetime.datetime(1, 1, 1, v54, v55, v56, v57 * 1000)
            del v54, v55, v56, v57
            v61 = v58
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v14
    v62 = method6(v61)
    del v61
    v63 = "%H:%M:%S"
    v64 = v62.strftime(v63)
    del v62, v63
    return v64
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
    v3 = f"{v0}"
    del v0
    method9(v2, v3)
    del v3
    v4 = v2.v0
    del v2
    return v4
def method7() -> string:
    v0 = "\u001b[94m"
    v1 = "Debug"
    v2 = v1.lower()
    del v1
    v3 = v2[0]
    del v2
    v4 = method8(v3)
    del v3
    v5 = v0 + v4 
    del v0, v4
    v6 = "\u001b[0m"
    v7 = v5 + v6 
    del v5, v6
    return v7
def method11(v0 : i64) -> string:
    v1 = ""
    v2 = Mut3(v1)
    del v1
    v3 = f"{v0}"
    del v0
    method9(v2, v3)
    del v3
    v4 = v2.v0
    del v2
    return v4
def method13(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "{ "
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method14(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "max"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method15(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = " = "
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method16(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "; "
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method17(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "p"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method18(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "n"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method19(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = " }"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method12(v0 : i64, v1 : i64, v2 : i8) -> string:
    v3 = ""
    v4 = Mut3(v3)
    del v3
    method13(v4)
    method14(v4)
    method15(v4)
    v5 = f"{v0}"
    del v0
    method9(v4, v5)
    del v5
    method16(v4)
    method17(v4)
    method15(v4)
    v6 = f"{v1}"
    del v1
    method9(v4, v6)
    del v6
    method16(v4)
    method18(v4)
    method15(v4)
    v7 = f"{v2}"
    del v2
    method9(v4, v7)
    del v7
    method19(v4)
    v8 = v4.v0
    del v4
    return v8
def method21(v0 : string, v1 : i32, v2 : i32) -> i32:
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
            return method21(v0, v1, v12)
        else:
            del v0, v1, v11
            return v2
def method22(v0 : string, v1 : i32) -> i32:
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
            return method22(v0, v3)
        else:
            del v0, v7
            return v3
def method20(v0 : string) -> string:
    v1 = len(v0)
    v2 = 0
    v3 = method21(v0, v1, v2)
    del v2
    v4 = v1 - 1
    del v1
    v5 = v4 + 1
    del v4
    v6 = v0[v3:v5]
    del v0, v3, v5
    v7 = len(v6)
    v8 = method22(v6, v7)
    del v7
    v9 = v8 + 1
    del v8
    v10 = v6[0:v9]
    del v6, v9
    return v10
def method10(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string) -> string:
    del v1, v2, v3, v4, v5
    v8 = v0.v0
    del v0
    v9 = " "
    v10 = v6 + v9 
    del v6
    v11 = method11(v8)
    del v8
    v12 = v10 + v11 
    del v10, v11
    v13 = v12 + v7 
    del v7, v12
    v14 = v13 + v9 
    del v9, v13
    v15 = "dice.calculate_dice_count"
    v16 = v14 + v15 
    del v14, v15
    v17 = " / "
    v18 = v16 + v17 
    del v16, v17
    v19 = 4738381338321616896
    v20 = 4738381338321616896
    v21 = 24
    v22 = method12(v19, v20, v21)
    del v19, v20, v21
    v23 = v18 + v22 
    del v18, v22
    return method20(v23)
def method24() -> u8:
    v79 = random.randrange(1, 7)
    return v79
def method28(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "power"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method29(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "acc"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method30(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "roll"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method31(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "value"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method27(v0 : i8, v1 : i64, v2 : u8, v3 : i64) -> string:
    v4 = ""
    v5 = Mut3(v4)
    del v4
    method13(v5)
    method28(v5)
    method15(v5)
    v6 = f"{v0}"
    del v0
    method9(v5, v6)
    del v6
    method16(v5)
    method29(v5)
    method15(v5)
    v7 = f"{v1}"
    del v1
    method9(v5, v7)
    del v7
    method16(v5)
    method30(v5)
    method15(v5)
    v8 = f"{v2}"
    del v2
    method9(v5, v8)
    del v8
    method16(v5)
    method31(v5)
    method15(v5)
    v9 = f"{v3}"
    del v3
    method9(v5, v9)
    del v9
    method19(v5)
    v10 = v5.v0
    del v5
    return v10
def method26(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v22 = 23
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method33(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method35(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method37(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method39(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method41(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method43(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method45(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method47(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method49(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method51(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method53(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method55(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method57(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method59(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method61(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method63(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method65(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method67(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method69(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method71(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method73(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method75(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method77(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = method11(v11)
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
    v23 = method27(v22, v8, v9, v10)
    del v8, v9, v10, v22
    v24 = v21 + v23 
    del v21, v23
    return method20(v24)
def method81(v0 : Mut3) -> None:
    v1 = v0.v0
    v2 = "result"
    v3 = v1 + v2 
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def method80(v0 : i8, v1 : i64, v2 : i64) -> string:
    v3 = ""
    v4 = Mut3(v3)
    del v3
    method13(v4)
    method28(v4)
    method15(v4)
    v5 = f"{v0}"
    del v0
    method9(v4, v5)
    del v5
    method16(v4)
    method29(v4)
    method15(v4)
    v6 = f"{v1}"
    del v1
    method9(v4, v6)
    del v6
    method16(v4)
    method81(v4)
    method15(v4)
    v7 = f"{v2}"
    del v2
    method9(v4, v7)
    del v7
    method19(v4)
    v8 = v4.v0
    del v4
    return v8
def method79(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : i64) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method80(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method78(v0 : UH0, v1 : i64) -> US8:
    v2 = v1 + 1
    v6 = Closure0()
    v7 = US0_0()
    if TraceState.trace_state is None: TraceState.trace_state = v6(v7)
    del v7
    v8, v9, v10, v11, v12, v13 = TraceState.trace_state
    del v8, v9, v11, v13
    v14 = v12.v0
    del v12
    match v14:
        case US0_4(): # Critical
            v19 = 50
        case US0_1(): # Debug
            v19 = 20
        case US0_2(): # Info
            v19 = 30
        case US0_0(): # Verbose
            v19 = 10
        case US0_3(): # Warning
            v19 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v14
    v20 = v10.v0
    del v10
    v21 = v20 == False
    del v20
    if v21:
        v23 = False
    else:
        v22 = 20 >= v19
        v23 = v22
    del v19, v21
    v24 = v23 == False
    del v23
    if v24:
        v48 = US7_1()
    else:
        v26 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v6(v26)
        del v26
        v27, v28, v29, v30, v31, v32 = TraceState.trace_state
        v33 = method5(v27, v28, v29, v30, v31, v32)
        v34 = method7()
        v35 = method79(v27, v28, v29, v30, v31, v32, v33, v34, v1, v2)
        del v27, v28, v29, v30, v31, v32, v33, v34
        v36 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v6(v36)
        del v36
        v37, v38, v39, v40, v41, v42 = TraceState.trace_state
        v43 = v37.v0
        v44 = v43 + 1
        del v43
        v37.v0 = v44
        del v44
        v45 = Closure9()
        v45(v35)
        del v45
        v46 = v38.v0
        v46(v35)
        del v35, v46
        v48 = US7_0(v37, v38, v39, v40, v41, v42)
    del v1, v6, v24, v48
    return US8_0(v2, v0)
def method83(v0 : i8, v1 : i64, v2 : u8) -> string:
    v3 = ""
    v4 = Mut3(v3)
    del v3
    method13(v4)
    method28(v4)
    method15(v4)
    v5 = f"{v0}"
    del v0
    method9(v4, v5)
    del v5
    method16(v4)
    method29(v4)
    method15(v4)
    v6 = f"{v1}"
    del v1
    method9(v4, v6)
    del v6
    method16(v4)
    method30(v4)
    method15(v4)
    v7 = f"{v2}"
    del v2
    method9(v4, v7)
    del v7
    method19(v4)
    v8 = v4.v0
    del v4
    return v8
def method82(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method76(v0 : UH0, v1 : i64) -> US8:
    match v0:
        case UH0_1(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = v3 - 1
                v7 = i64(v6)
                del v6
                v11 = Closure0()
                v12 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v11(v12)
                del v12
                v13, v14, v15, v16, v17, v18 = TraceState.trace_state
                del v13, v14, v16, v18
                v19 = v17.v0
                del v17
                match v19:
                    case US0_4(): # Critical
                        v24 = 50
                    case US0_1(): # Debug
                        v24 = 20
                    case US0_2(): # Info
                        v24 = 30
                    case US0_0(): # Verbose
                        v24 = 10
                    case US0_3(): # Warning
                        v24 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v19
                v25 = v15.v0
                del v15
                v26 = v25 == False
                del v25
                if v26:
                    v28 = False
                else:
                    v27 = 20 >= v24
                    v28 = v27
                del v24, v26
                v29 = v28 == False
                del v28
                if v29:
                    v53 = US7_1()
                else:
                    v31 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v11(v31)
                    del v31
                    v32, v33, v34, v35, v36, v37 = TraceState.trace_state
                    v38 = method5(v32, v33, v34, v35, v36, v37)
                    v39 = method7()
                    v40 = method77(v32, v33, v34, v35, v36, v37, v38, v39, v1, v3, v7)
                    del v32, v33, v34, v35, v36, v37, v38, v39
                    v41 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v11(v41)
                    del v41
                    v42, v43, v44, v45, v46, v47 = TraceState.trace_state
                    v48 = v42.v0
                    v49 = v48 + 1
                    del v48
                    v42.v0 = v49
                    del v49
                    v50 = Closure9()
                    v50(v40)
                    del v50
                    v51 = v43.v0
                    v51(v40)
                    del v40, v51
                    v53 = US7_0(v42, v43, v44, v45, v46, v47)
                del v3, v11, v29, v53
                v54 = v1 + v7
                del v1, v7
                return method78(v4, v54)
            else:
                del v5
                v59 = Closure0()
                v60 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v59(v60)
                del v60
                v61, v62, v63, v64, v65, v66 = TraceState.trace_state
                del v61, v62, v64, v66
                v67 = v65.v0
                del v65
                match v67:
                    case US0_4(): # Critical
                        v72 = 50
                    case US0_1(): # Debug
                        v72 = 20
                    case US0_2(): # Info
                        v72 = 30
                    case US0_0(): # Verbose
                        v72 = 10
                    case US0_3(): # Warning
                        v72 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v67
                v73 = v63.v0
                del v63
                v74 = v73 == False
                del v73
                if v74:
                    v76 = False
                else:
                    v75 = 20 >= v72
                    v76 = v75
                del v72, v74
                v77 = v76 == False
                del v76
                if v77:
                    v101 = US7_1()
                else:
                    v79 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v59(v79)
                    del v79
                    v80, v81, v82, v83, v84, v85 = TraceState.trace_state
                    v86 = method5(v80, v81, v82, v83, v84, v85)
                    v87 = method7()
                    v88 = method82(v80, v81, v82, v83, v84, v85, v86, v87, v1, v3)
                    del v80, v81, v82, v83, v84, v85, v86, v87
                    v89 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v59(v89)
                    del v89
                    v90, v91, v92, v93, v94, v95 = TraceState.trace_state
                    v96 = v90.v0
                    v97 = v96 + 1
                    del v96
                    v90.v0 = v97
                    del v97
                    v98 = Closure9()
                    v98(v88)
                    del v98
                    v99 = v91.v0
                    v99(v88)
                    del v88, v99
                    v101 = US7_0(v90, v91, v92, v93, v94, v95)
                del v3, v59, v77, v101
                return method78(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method84(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method74(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method75(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method76(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method84(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method76(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method85(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method72(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method73(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method74(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method85(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method74(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method86(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method70(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method71(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method72(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method86(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method72(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method87(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method68(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method69(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method70(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method87(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method70(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method88(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method66(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method67(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method68(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method88(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method68(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method89(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method64(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method65(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method66(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method89(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method66(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method90(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method62(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method63(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method64(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method90(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method64(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method91(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method60(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method61(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method62(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method91(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method62(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method92(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method58(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method59(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method60(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method92(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method60(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method93(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method56(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method57(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method58(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method93(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method58(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method94(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method54(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method55(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method56(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method94(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method56(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method95(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method52(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method53(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method54(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method95(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method54(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method96(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
def method50(v0 : UH0, v1 : i64) -> US8:
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method51(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method52(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method96(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method52(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method97(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 78364164096
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method49(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method50(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method97(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method50(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method98(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 470184984576
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method47(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method48(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method98(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method48(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method99(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 2821109907456
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method45(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method46(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method99(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method46(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method100(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 16926659444736
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method43(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method44(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method100(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method44(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method101(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 101559956668416
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method41(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method42(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method101(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method42(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method102(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 609359740010496
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method39(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method40(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method102(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method40(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method103(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 3656158440062976
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method37(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method38(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method103(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method38(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method104(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 21936950640377856
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method35(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method36(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method104(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method36(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method105(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v8 = v7 * 131621703842267136
                del v7
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method33(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method34(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method105(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method34(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method106(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = method11(v10)
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
    v22 = method83(v21, v8, v9)
    del v8, v9, v21
    v23 = v20 + v22 
    del v20, v22
    return method20(v23)
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
                v12 = Closure0()
                v13 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v12(v13)
                del v13
                v14, v15, v16, v17, v18, v19 = TraceState.trace_state
                del v14, v15, v17, v19
                v20 = v18.v0
                del v18
                match v20:
                    case US0_4(): # Critical
                        v25 = 50
                    case US0_1(): # Debug
                        v25 = 20
                    case US0_2(): # Info
                        v25 = 30
                    case US0_0(): # Verbose
                        v25 = 10
                    case US0_3(): # Warning
                        v25 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v20
                v26 = v16.v0
                del v16
                v27 = v26 == False
                del v26
                if v27:
                    v29 = False
                else:
                    v28 = 20 >= v25
                    v29 = v28
                del v25, v27
                v30 = v29 == False
                del v29
                if v30:
                    v54 = US7_1()
                else:
                    v32 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v32)
                    del v32
                    v33, v34, v35, v36, v37, v38 = TraceState.trace_state
                    v39 = method5(v33, v34, v35, v36, v37, v38)
                    v40 = method7()
                    v41 = method26(v33, v34, v35, v36, v37, v38, v39, v40, v1, v3, v8)
                    del v33, v34, v35, v36, v37, v38, v39, v40
                    v42 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v12(v42)
                    del v42
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = v43.v0
                    v50 = v49 + 1
                    del v49
                    v43.v0 = v50
                    del v50
                    v51 = Closure9()
                    v51(v41)
                    del v51
                    v52 = v44.v0
                    v52(v41)
                    del v41, v52
                    v54 = US7_0(v43, v44, v45, v46, v47, v48)
                del v3, v12, v30, v54
                v55 = v1 + v8
                del v1, v8
                return method32(v4, v55)
            else:
                del v5
                v60 = Closure0()
                v61 = US0_0()
                if TraceState.trace_state is None: TraceState.trace_state = v60(v61)
                del v61
                v62, v63, v64, v65, v66, v67 = TraceState.trace_state
                del v62, v63, v65, v67
                v68 = v66.v0
                del v66
                match v68:
                    case US0_4(): # Critical
                        v73 = 50
                    case US0_1(): # Debug
                        v73 = 20
                    case US0_2(): # Info
                        v73 = 30
                    case US0_0(): # Verbose
                        v73 = 10
                    case US0_3(): # Warning
                        v73 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v68
                v74 = v64.v0
                del v64
                v75 = v74 == False
                del v74
                if v75:
                    v77 = False
                else:
                    v76 = 20 >= v73
                    v77 = v76
                del v73, v75
                v78 = v77 == False
                del v77
                if v78:
                    v102 = US7_1()
                else:
                    v80 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v80)
                    del v80
                    v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                    v87 = method5(v81, v82, v83, v84, v85, v86)
                    v88 = method7()
                    v89 = method106(v81, v82, v83, v84, v85, v86, v87, v88, v1, v3)
                    del v81, v82, v83, v84, v85, v86, v87, v88
                    v90 = US0_0()
                    if TraceState.trace_state is None: TraceState.trace_state = v60(v90)
                    del v90
                    v91, v92, v93, v94, v95, v96 = TraceState.trace_state
                    v97 = v91.v0
                    v98 = v97 + 1
                    del v97
                    v91.v0 = v98
                    del v98
                    v99 = Closure9()
                    v99(v89)
                    del v99
                    v100 = v92.v0
                    v100(v89)
                    del v89, v100
                    v102 = US7_0(v91, v92, v93, v94, v95, v96)
                del v3, v60, v78, v102
                return method32(v4, v1)
        case UH0_0(): # Nil
            del v0, v1
            return US8_1()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method23(v0 : UH0, v1 : i8) -> i64:
    v2 = v1 < 24
    if v2:
        del v2
        v3 = method24()
        v4 = UH0_1(v3, v0)
        del v0, v3
        v5 = v1 + 1
        del v1
        return method23(v4, v5)
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
                    return method23(v58, v59)
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
                return method23(v108, v109)
def method108(v0 : i64) -> string:
    v1 = ""
    v2 = Mut3(v1)
    del v1
    method13(v2)
    method81(v2)
    method15(v2)
    v3 = f"{v0}"
    del v0
    method9(v2, v3)
    del v3
    method19(v2)
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
    v12 = method11(v9)
    del v9
    v13 = v11 + v12 
    del v11, v12
    v14 = v13 + v7 
    del v7, v13
    v15 = v14 + v10 
    del v10, v14
    v16 = "dice.main"
    v17 = v15 + v16 
    del v15, v16
    v18 = " / "
    v19 = v17 + v18 
    del v17, v18
    v20 = method108(v8)
    del v8
    v21 = v19 + v20 
    del v19, v20
    return method20(v21)
def main():
    v9 = "Python"
    None # backend.backend_switch / record_type_try_find / key: v9 
    None # backend.backend_switch / record_type_try_find / key: v9 
    None # backend.backend_switch / record_type_try_find / key: v9 
    None # backend.backend_switch / record_type_try_find / key: v9 
    del v9
    v30 = spiral_object_array()
    del v30
    v34 = Closure0()
    v35 = US0_0()
    if TraceState.trace_state is None: TraceState.trace_state = v34(v35)
    del v35
    v36, v37, v38, v39, v40, v41 = TraceState.trace_state
    del v36, v37, v39, v41
    v42 = v40.v0
    del v40
    match v42:
        case US0_4(): # Critical
            v47 = 50
        case US0_1(): # Debug
            v47 = 20
        case US0_2(): # Info
            v47 = 30
        case US0_0(): # Verbose
            v47 = 10
        case US0_3(): # Warning
            v47 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v42
    v48 = v38.v0
    del v38
    v49 = v48 == False
    del v48
    if v49:
        v51 = False
    else:
        v50 = 20 >= v47
        v51 = v50
    del v47, v49
    v52 = v51 == False
    del v51
    if v52:
        v76 = US7_1()
    else:
        v54 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v34(v54)
        del v54
        v55, v56, v57, v58, v59, v60 = TraceState.trace_state
        v61 = method5(v55, v56, v57, v58, v59, v60)
        v62 = method7()
        v63 = method10(v55, v56, v57, v58, v59, v60, v61, v62)
        del v55, v56, v57, v58, v59, v60, v61, v62
        v64 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v34(v64)
        del v64
        v65, v66, v67, v68, v69, v70 = TraceState.trace_state
        v71 = v65.v0
        v72 = v71 + 1
        del v71
        v65.v0 = v72
        del v72
        v73 = Closure9()
        v73(v63)
        del v73
        v74 = v66.v0
        v74(v63)
        del v63, v74
        v76 = US7_0(v65, v66, v67, v68, v69, v70)
    del v52, v76
    v77 = UH0_0()
    v78 = 0
    v79 = method23(v77, v78)
    del v77, v78
    v83 = US0_0()
    if TraceState.trace_state is None: TraceState.trace_state = v34(v83)
    del v83
    v84, v85, v86, v87, v88, v89 = TraceState.trace_state
    del v84, v85, v87, v89
    v90 = v88.v0
    del v88
    match v90:
        case US0_4(): # Critical
            v95 = 50
        case US0_1(): # Debug
            v95 = 20
        case US0_2(): # Info
            v95 = 30
        case US0_0(): # Verbose
            v95 = 10
        case US0_3(): # Warning
            v95 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v90
    v96 = v86.v0
    del v86
    v97 = v96 == False
    del v96
    if v97:
        v99 = False
    else:
        v98 = 20 >= v95
        v99 = v98
    del v95, v97
    v100 = v99 == False
    del v99
    if v100:
        v124 = US7_1()
    else:
        v102 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v34(v102)
        del v102
        v103, v104, v105, v106, v107, v108 = TraceState.trace_state
        v109 = method5(v103, v104, v105, v106, v107, v108)
        v110 = method7()
        v111 = method107(v103, v104, v105, v106, v107, v108, v109, v110, v79)
        del v103, v104, v105, v106, v107, v108, v109, v110
        v112 = US0_0()
        if TraceState.trace_state is None: TraceState.trace_state = v34(v112)
        del v112
        v113, v114, v115, v116, v117, v118 = TraceState.trace_state
        v119 = v113.v0
        v120 = v119 + 1
        del v119
        v113.v0 = v120
        del v120
        v121 = Closure9()
        v121(v111)
        del v121
        v122 = v114.v0
        v122(v111)
        del v111, v122
        v124 = US7_0(v113, v114, v115, v116, v117, v118)
    del v34, v79, v100, v124
    return 

if __name__ == '__main__': result = main(); None if result is None else print(result)
