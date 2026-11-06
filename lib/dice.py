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
def spiral_try(fn, some, ex_fn):
    try:
        return some(fn())
    except Exception as e:
        return ex_fn(e)
import datetime
class TraceState: trace_state = None
import math
import random
i8 = int; i16 = int; i32 = int; i64 = int; u8 = int; u16 = int; u32 = int; u64 = int; f32 = float; f64 = float; char = str; string = str
import sys
sys.setrecursionlimit(1 << 30)

def spiral_object_array(*items):
    import numpy
    array = numpy.empty(len(items), dtype=object)
    for i, x in enumerate(items): array[i] = x
    return array
def spiral_wrap(x, bits, signed):
    x &= (1 << bits) - 1
    return x - (1 << bits) if signed and x >> (bits - 1) else x
def spiral_array_index(array, index):
    value = array[index]
    return value.item() if isinstance(array, cp.ndarray) and array.dtype.kind != 'O' else value
def spiral_div_trunc(a, b):
    q = abs(a) // abs(b)
    return q if (a < 0) == (b < 0) else -q
def spiral_mod_trunc(a, b):
    r = abs(a) % abs(b)
    return -r if a < 0 else r
import sys
def spiral_utf8(s):
    return s.encode('utf-8', 'surrogateescape')
def spiral_string_length(s):
    return len(s) if s.isascii() else len(spiral_utf8(s))
def spiral_string_index(s, i):
    return s[i] if s.isascii() else chr(spiral_utf8(s)[i])
def spiral_string_slice(s, a, b):
    data = s.encode('ascii') if s.isascii() else spiral_utf8(s)
    n = len(data)
    if a < 0 or a > n or b < a - 1 or b >= n: sys.exit(3)
    if b >= a and ((data[a] & 0xC0) == 0x80 or (b + 1 < n and (data[b + 1] & 0xC0) == 0x80)): sys.exit(3)
    return s[a:b + 1] if s.isascii() else data[a:b + 1].decode('utf-8', 'surrogateescape')
UH0 = Union["UH0_Nil", "UH0_Cons"]
class US0_Verbose(NamedTuple): # Verbose
    tag = 0
US0_Verbose_shared = US0_Verbose()
class US0_Debug(NamedTuple): # Debug
    tag = 1
US0_Debug_shared = US0_Debug()
class US0_Info(NamedTuple): # Info
    tag = 2
US0_Info_shared = US0_Info()
class US0_Warning(NamedTuple): # Warning
    tag = 3
US0_Warning_shared = US0_Warning()
class US0_Critical(NamedTuple): # Critical
    tag = 4
US0_Critical_shared = US0_Critical()
US0 = Union[US0_Verbose, US0_Debug, US0_Info, US0_Warning, US0_Critical]
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
class US1_Some(NamedTuple): # Some
    v0 : US0
    tag = 0
class US1_None(NamedTuple): # None
    tag = 1
US1_None_shared = US1_None()
US1 = Union[US1_Some, US1_None]
class US2_Some(NamedTuple): # Some
    v0 : i64
    tag = 0
class US2_None(NamedTuple): # None
    tag = 1
US2_None_shared = US2_None()
US2 = Union[US2_Some, US2_None]
class US3_Some(NamedTuple): # Some
    v0 : string
    tag = 0
class US3_None(NamedTuple): # None
    tag = 1
US3_None_shared = US3_None()
US3 = Union[US3_Some, US3_None]
@dataclass
class Mut5:
    v0 : i32
    v1 : US1
def closure0():
    def inner(v0 : string) -> None:
        return 
    return inner
class US4_Some(NamedTuple): # Some
    v0 : Mut0
    v1 : Mut1
    v2 : Mut2
    v3 : Mut3
    v4 : Mut4
    v5 : i64
    tag = 0
class US4_None(NamedTuple): # None
    tag = 1
US4_None_shared = US4_None()
US4 = Union[US4_Some, US4_None]
def closure1():
    def inner(v0 : string) -> None:
        print(v0)
        return 
    return inner
class UH0_Nil(NamedTuple): # Nil
    tag = 0
UH0_Nil_shared = UH0_Nil()
class UH0_Cons(NamedTuple): # Cons
    v0 : u8
    v1 : UH0
    tag = 1
class US5_Some(NamedTuple): # Some
    v0 : i64
    v1 : UH0
    tag = 0
class US5_None(NamedTuple): # None
    tag = 1
US5_None_shared = US5_None()
US5 = Union[US5_Some, US5_None]
def get_environment_variable_2(v0 : string) -> string:
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
        v8 = US3_Some(v7)
        del v7
        v9 = v8 
        del v8
        v10 = v9
    del v3, v5
    v11 = v10 is None
    if v11:
        v14 = US3_None_shared
    else:
        v13 = v10
        v14 = v13
    del v10, v11
    match v14:
        case US3_None(): # None
            del v14
            v16 = ""
            return v16
        case US3_Some(v15): # Some
            del v14
            return v15
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
            v7 = spiral_wrap(v3 + 1, 32, True)
            del v3
            v0, v1, v2, v3 = v0, v1, v2, v7
            continue
def method4(v0 : Mut5) -> bool:
    v1 = v0.v0
    del v0
    v2 = v1 > 0
    del v1
    return v2
def method1() -> Tuple[US1, US2]:
    v0 = "TRACE_LEVEL"
    v1 = get_environment_variable_2(v0)
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
    v13 = US0_Critical_shared
    v14 = ([(v3, v13)] + v12)
    del v3, v12, v13
    v15 = US0_Warning_shared
    v16 = ([(v5, v15)] + v14)
    del v5, v14, v15
    v17 = US0_Info_shared
    v18 = ([(v7, v17)] + v16)
    del v7, v16, v17
    v19 = US0_Debug_shared
    v20 = ([(v9, v19)] + v18)
    del v9, v18, v19
    v21 = US0_Verbose_shared
    v22 = ([(v11, v21)] + v20)
    del v11, v20, v21
    v23 = US0_Critical_shared
    v24 = ([(v2, v23)] + v22)
    del v2, v22, v23
    v25 = US0_Warning_shared
    v26 = ([(v4, v25)] + v24)
    del v4, v24, v25
    v27 = US0_Info_shared
    v28 = ([(v6, v27)] + v26)
    del v6, v26, v27
    v29 = US0_Debug_shared
    v30 = ([(v8, v29)] + v28)
    del v8, v28, v29
    v31 = US0_Verbose_shared
    v32 = ([(v10, v31)] + v30)
    del v10, v30, v31
    v33 = len(v32)
    v34 = __import__("numpy").empty(v33, dtype=object)
    v35 = 0
    v36 = method3(v32, v33, v34, v35)
    del v32, v33, v34, v35
    v37 = v36.size
    v38 = US1_None_shared
    v39 = Mut5(v37, v38)
    del v37, v38
    while method4(v39):
        v41 = v39.v0
        v42 = spiral_wrap(v41 - 1, 32, True)
        del v41
        v43 = v39.v1
        v44, v45 = spiral_array_index(v36, v42)
        match v43:
            case US1_None(): # None
                v47 = v44 == v1 
                if v47:
                    del v47
                    v52 = US1_Some(v45)
                else:
                    del v47
                    v52 = US1_None_shared
            case US1_Some(_): # Some
                v52 = v43
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v43, v44, v45
        v39.v0 = v42
        v39.v1 = v52
        del v42, v52
    del v1, v36
    v53 = v39.v1
    del v39
    v54 = "AUTOMATION"
    v55 = get_environment_variable_2(v54)
    del v54
    v56 = "True"
    v57 = v55 != v56 
    del v55, v56
    if v57:
        v62 = US2_None_shared
    else:
        v59 = datetime.datetime.now()
        v60 = (v59.replace(tzinfo=None) - datetime.datetime(1970, 1, 1)) // datetime.timedelta(microseconds=1)
        del v59
        v62 = US2_Some(v60)
    del v57
    return v53, v62
def new_trace_state_0(v0 : US0) -> Tuple[Mut0, Mut1, Mut2, Mut3, Mut4, i64]:
    v1, v2 = method1()
    v3 = Mut0(1)
    v4 = closure0()
    v5 = Mut1(v4)
    del v4
    v6 = Mut2(True)
    v7 = ""
    v8 = Mut3(v7)
    del v7
    match v1:
        case US1_None(): # None
            v11 = v0
        case US1_Some(v9): # Some
            v11 = v9
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v0, v1
    v12 = Mut4(v11)
    del v11
    match v2:
        case US2_None(): # None
            v15 = None
            v17 = v15
        case US2_Some(v13): # Some
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
        v10 = US2_Some(v9)
        del v9
        v11 = v10 
        del v10
        v12 = v11
    del v5, v7
    v13 = v12 is None
    if v13:
        v16 = US2_None_shared
    else:
        v15 = v12
        v16 = v15
    del v12, v13
    match v16:
        case US2_None(): # None
            v32 = datetime.datetime.now()
            v34 = v32
        case US2_Some(v17): # Some
            v18 = datetime.datetime.now()
            v19 = (v18.replace(tzinfo=None) - datetime.datetime(1970, 1, 1)) // datetime.timedelta(microseconds=1)
            del v18
            v20 = spiral_wrap(v19 - v17, 64, True)
            del v17, v19
            v21 = datetime.timedelta(microseconds=v20)
            del v20
            v22 = v21.seconds
            v23 = spiral_wrap(spiral_div_trunc(v22, 3600), 32, True)
            del v22
            v24 = v21.seconds
            v25 = spiral_wrap(spiral_div_trunc(v24, 60), 32, True)
            del v24
            v26 = spiral_mod_trunc(v25, 60)
            del v25
            v27 = v21.seconds
            v28 = spiral_mod_trunc(v27, 60)
            del v27
            v29 = v21.microseconds
            del v21
            v30 = spiral_wrap(spiral_div_trunc(v29, 1000), 32, True)
            del v29
            v31 = datetime.datetime(1, 1, 1, v23, v26, v28, v30 * 1000)
            del v23, v26, v28, v30
            v34 = v31
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v16
    v35 = method6(v34)
    del v34
    v36 = "%H:%M:%S"
    v37 = v35.strftime(v36)
    del v35, v36
    return v37
def method9(v0 : Mut3, v1 : string) -> None:
    v2 = v0.v0
    v3 = v2 + v1
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def format_real_8(v0 : char) -> string:
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
    v3 = spiral_string_index(v2, 0)
    del v2
    v4 = format_real_8(v3)
    del v3
    v5 = v0 + v4
    del v0, v4
    v6 = "\u001b[0m"
    v7 = v5 + v6
    del v5, v6
    return v7
def method12(v0 : string, v1 : i32, v2 : i32) -> i32:
    while True:
        v3 = v2 >= v1
        if v3:
            del v0, v2, v3
            return v1
        else:
            del v3
            v4 = spiral_string_index(v0, v2)
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
                v12 = spiral_wrap(v2 + 1, 32, True)
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
            v3 = spiral_wrap(v1 - 1, 32, True)
            del v1
            v4 = spiral_string_index(v0, v3)
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
    v1 = spiral_string_length(v0)
    v2 = 0
    v3 = method12(v0, v1, v2)
    del v2
    v4 = spiral_wrap(v1 - 1, 32, True)
    del v1
    v5 = spiral_string_slice(v0, v3, v4)
    del v0, v3, v4
    v6 = spiral_string_length(v5)
    v7 = method13(v5, v6)
    del v6
    v8 = spiral_string_slice(v5, 0, v7)
    del v5, v7
    return v8
def format_real_14(v0 : i64) -> string:
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
def format_real_15(v0 : i8) -> string:
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
def method10(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string) -> string:
    del v1, v2, v3, v4, v5
    v8 = v0.v0
    del v0
    v9 = v6 + " "
    del v6
    v10 = format_real_14(v8)
    del v8
    v11 = v9 + v10
    del v9, v10
    v12 = v11 + v7
    del v7, v11
    v13 = v12 + " "
    del v12
    v14 = v13 + "dice.calculate_dice_count"
    del v13
    v15 = v14 + " / "
    del v14
    v16 = 4738381338321616896
    v17 = format_real_14(v16)
    del v16
    v18 = "max = " + v17
    del v17
    v19 = v18 + "; "
    del v18
    v20 = v19 + "p"
    del v19
    v21 = v20 + " = "
    del v20
    v22 = 4738381338321616896
    v23 = format_real_14(v22)
    del v22
    v24 = v21 + v23
    del v21, v23
    v25 = v24 + "; "
    del v24
    v26 = v25 + "n"
    del v25
    v27 = v26 + " = "
    del v26
    v28 = 24
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29
    del v27, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v15 + v32
    del v15, v32
    return method11(v33)
def roll_dice_17() -> u8:
    v0 = random.randrange(1, 7)
    return v0
def method43(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : i64) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = -1
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "result"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_14(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method42(v0 : UH0, v1 : i64) -> US5:
    v2 = spiral_wrap(v1 + 1, 64, True)
    v3 = TraceState.trace_state is None
    if v3:
        v4 = US0_Verbose_shared
        v5, v6, v7, v8, v9, v10 = new_trace_state_0(v4)
        del v4
        TraceState.trace_state = (v5, v6, v7, v8, v9, v10) 
        del v5, v6, v7, v8, v9, v10
    else:
        pass
    del v3
    v11, v12, v13, v14, v15, v16 = TraceState.trace_state
    del v11, v12, v14, v16
    v17 = v15.v0
    del v15
    match v17:
        case US0_Critical(): # Critical
            v22 = 50
        case US0_Debug(): # Debug
            v22 = 20
        case US0_Info(): # Info
            v22 = 30
        case US0_Verbose(): # Verbose
            v22 = 10
        case US0_Warning(): # Warning
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
        v65 = US4_None_shared
    else:
        v29 = TraceState.trace_state is None
        if v29:
            v30 = US0_Verbose_shared
            v31, v32, v33, v34, v35, v36 = new_trace_state_0(v30)
            del v30
            TraceState.trace_state = (v31, v32, v33, v34, v35, v36) 
            del v31, v32, v33, v34, v35, v36
        else:
            pass
        del v29
        v37, v38, v39, v40, v41, v42 = TraceState.trace_state
        v43 = method5(v37, v38, v39, v40, v41, v42)
        v44 = method7()
        v45 = method43(v37, v38, v39, v40, v41, v42, v43, v44, v1, v2)
        del v37, v38, v39, v40, v41, v42, v43, v44
        v46 = TraceState.trace_state is None
        if v46:
            v47 = US0_Verbose_shared
            v48, v49, v50, v51, v52, v53 = new_trace_state_0(v47)
            del v47
            TraceState.trace_state = (v48, v49, v50, v51, v52, v53) 
            del v48, v49, v50, v51, v52, v53
        else:
            pass
        del v46
        v54, v55, v56, v57, v58, v59 = TraceState.trace_state
        v60 = v54.v0
        v61 = spiral_wrap(v60 + 1, 64, True)
        del v60
        v54.v0 = v61
        del v61
        v62 = closure1()
        v62(v45)
        del v62
        v63 = v55.v0
        v63(v45)
        del v45, v63
        v65 = US4_Some(v54, v55, v56, v57, v58, v59)
    del v1, v27, v65
    return US5_Some(v2, v0)
def format_real_45(v0 : u8) -> string:
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
def method44(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 0
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method46(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 0
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method41(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = TraceState.trace_state is None
                if v8:
                    v9 = US0_Verbose_shared
                    v10, v11, v12, v13, v14, v15 = new_trace_state_0(v9)
                    del v9
                    TraceState.trace_state = (v10, v11, v12, v13, v14, v15) 
                    del v10, v11, v12, v13, v14, v15
                else:
                    pass
                del v8
                v16, v17, v18, v19, v20, v21 = TraceState.trace_state
                del v16, v17, v19, v21
                v22 = v20.v0
                del v20
                match v22:
                    case US0_Critical(): # Critical
                        v27 = 50
                    case US0_Debug(): # Debug
                        v27 = 20
                    case US0_Info(): # Info
                        v27 = 30
                    case US0_Verbose(): # Verbose
                        v27 = 10
                    case US0_Warning(): # Warning
                        v27 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v22
                v28 = v18.v0
                del v18
                v29 = v28 == False
                del v28
                if v29:
                    v31 = False
                else:
                    v30 = 20 >= v27
                    v31 = v30
                del v27, v29
                v32 = v31 == False
                del v31
                if v32:
                    v70 = US4_None_shared
                else:
                    v34 = TraceState.trace_state is None
                    if v34:
                        v35 = US0_Verbose_shared
                        v36, v37, v38, v39, v40, v41 = new_trace_state_0(v35)
                        del v35
                        TraceState.trace_state = (v36, v37, v38, v39, v40, v41) 
                        del v36, v37, v38, v39, v40, v41
                    else:
                        pass
                    del v34
                    v42, v43, v44, v45, v46, v47 = TraceState.trace_state
                    v48 = method5(v42, v43, v44, v45, v46, v47)
                    v49 = method7()
                    v50 = method44(v42, v43, v44, v45, v46, v47, v48, v49, v1, v3, v7)
                    del v42, v43, v44, v45, v46, v47, v48, v49
                    v51 = TraceState.trace_state is None
                    if v51:
                        v52 = US0_Verbose_shared
                        v53, v54, v55, v56, v57, v58 = new_trace_state_0(v52)
                        del v52
                        TraceState.trace_state = (v53, v54, v55, v56, v57, v58) 
                        del v53, v54, v55, v56, v57, v58
                    else:
                        pass
                    del v51
                    v59, v60, v61, v62, v63, v64 = TraceState.trace_state
                    v65 = v59.v0
                    v66 = spiral_wrap(v65 + 1, 64, True)
                    del v65
                    v59.v0 = v66
                    del v66
                    v67 = closure1()
                    v67(v50)
                    del v67
                    v68 = v60.v0
                    v68(v50)
                    del v50, v68
                    v70 = US4_Some(v59, v60, v61, v62, v63, v64)
                del v3, v32, v70
                v71 = spiral_wrap(v1 + v7, 64, True)
                del v1, v7
                return method42(v4, v71)
            else:
                del v5
                v73 = TraceState.trace_state is None
                if v73:
                    v74 = US0_Verbose_shared
                    v75, v76, v77, v78, v79, v80 = new_trace_state_0(v74)
                    del v74
                    TraceState.trace_state = (v75, v76, v77, v78, v79, v80) 
                    del v75, v76, v77, v78, v79, v80
                else:
                    pass
                del v73
                v81, v82, v83, v84, v85, v86 = TraceState.trace_state
                del v81, v82, v84, v86
                v87 = v85.v0
                del v85
                match v87:
                    case US0_Critical(): # Critical
                        v92 = 50
                    case US0_Debug(): # Debug
                        v92 = 20
                    case US0_Info(): # Info
                        v92 = 30
                    case US0_Verbose(): # Verbose
                        v92 = 10
                    case US0_Warning(): # Warning
                        v92 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v87
                v93 = v83.v0
                del v83
                v94 = v93 == False
                del v93
                if v94:
                    v96 = False
                else:
                    v95 = 20 >= v92
                    v96 = v95
                del v92, v94
                v97 = v96 == False
                del v96
                if v97:
                    v135 = US4_None_shared
                else:
                    v99 = TraceState.trace_state is None
                    if v99:
                        v100 = US0_Verbose_shared
                        v101, v102, v103, v104, v105, v106 = new_trace_state_0(v100)
                        del v100
                        TraceState.trace_state = (v101, v102, v103, v104, v105, v106) 
                        del v101, v102, v103, v104, v105, v106
                    else:
                        pass
                    del v99
                    v107, v108, v109, v110, v111, v112 = TraceState.trace_state
                    v113 = method5(v107, v108, v109, v110, v111, v112)
                    v114 = method7()
                    v115 = method46(v107, v108, v109, v110, v111, v112, v113, v114, v1, v3)
                    del v107, v108, v109, v110, v111, v112, v113, v114
                    v116 = TraceState.trace_state is None
                    if v116:
                        v117 = US0_Verbose_shared
                        v118, v119, v120, v121, v122, v123 = new_trace_state_0(v117)
                        del v117
                        TraceState.trace_state = (v118, v119, v120, v121, v122, v123) 
                        del v118, v119, v120, v121, v122, v123
                    else:
                        pass
                    del v116
                    v124, v125, v126, v127, v128, v129 = TraceState.trace_state
                    v130 = v124.v0
                    v131 = spiral_wrap(v130 + 1, 64, True)
                    del v130
                    v124.v0 = v131
                    del v131
                    v132 = closure1()
                    v132(v115)
                    del v132
                    v133 = v125.v0
                    v133(v115)
                    del v115, v133
                    v135 = US4_Some(v124, v125, v126, v127, v128, v129)
                del v3, v97, v135
                return method42(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method47(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 1
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method48(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 1
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method40(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 6, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method47(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method41(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method48(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method41(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method49(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 2
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method50(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 2
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method39(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 36, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method49(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method40(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method50(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method40(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method51(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 3
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method52(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 3
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method38(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 216, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method51(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method39(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method52(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method39(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method53(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 4
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method54(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 4
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method37(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 1296, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method53(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method38(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method54(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method38(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method55(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 5
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method56(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 5
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method36(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 7776, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method55(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method37(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method56(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method37(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method57(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 6
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method58(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 6
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method35(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 46656, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method57(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method36(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method58(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method36(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method59(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 7
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method60(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 7
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method34(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 279936, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method59(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method35(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method60(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method35(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method61(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 8
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method62(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 8
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method33(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 1679616, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method61(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method34(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method62(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method34(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method63(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 9
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method64(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 9
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method32(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 10077696, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method63(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method33(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method64(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method33(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method65(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 10
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method66(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 10
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method31(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 60466176, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method65(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method32(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method66(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method32(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method67(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 11
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method68(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 11
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method30(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 362797056, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method67(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method31(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method68(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method31(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method69(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 12
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method70(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 12
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method29(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 2176782336, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method69(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method30(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method70(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method30(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method71(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 13
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method72(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 13
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method28(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 13060694016, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method71(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method29(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method72(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method29(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method73(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 14
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method74(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 14
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method27(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 78364164096, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method73(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method28(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method74(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method28(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method75(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 15
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method76(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 15
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method26(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 470184984576, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method75(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method27(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method76(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method27(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method77(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 16
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method78(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 16
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method25(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 2821109907456, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method77(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method26(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method78(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method26(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method79(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 17
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method80(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 17
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method24(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 16926659444736, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method79(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method25(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method80(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method25(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method81(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 18
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method82(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 18
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method23(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 101559956668416, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method81(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method24(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method82(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method24(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method83(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 19
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method84(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 19
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method22(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 609359740010496, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method83(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method23(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method84(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method23(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method85(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 20
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method86(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 20
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method21(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 3656158440062976, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method85(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method22(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method86(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method22(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method87(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 21
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method88(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 21
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method20(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 21936950640377856, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method87(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method21(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method88(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method21(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method89(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 22
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method90(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 22
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method19(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 131621703842267136, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method89(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method20(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method90(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method20(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method91(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = v6 + " "
    del v6
    v13 = format_real_14(v11)
    del v11
    v14 = v12 + v13
    del v12, v13
    v15 = v14 + v7
    del v7, v14
    v16 = v15 + " "
    del v15
    v17 = v16 + "dice.accumulate_dice_rolls"
    del v16
    v18 = v17 + " / "
    del v17
    v19 = 23
    v20 = format_real_15(v19)
    del v19
    v21 = "power = " + v20
    del v20
    v22 = v21 + "; "
    del v21
    v23 = v22 + "acc"
    del v22
    v24 = v23 + " = "
    del v23
    v25 = format_real_14(v8)
    del v8
    v26 = v24 + v25
    del v24, v25
    v27 = v26 + "; "
    del v26
    v28 = v27 + "roll"
    del v27
    v29 = v28 + " = "
    del v28
    v30 = format_real_45(v9)
    del v9
    v31 = v29 + v30
    del v29, v30
    v32 = v31 + "; "
    del v31
    v33 = v32 + "value"
    del v32
    v34 = v33 + " = "
    del v33
    v35 = format_real_14(v10)
    del v10
    v36 = v34 + v35
    del v34, v35
    v37 = "{ " + v36
    del v36
    v38 = v37 + " }"
    del v37
    v39 = v18 + v38
    del v18, v38
    return method11(v39)
def method92(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = v6 + " "
    del v6
    v12 = format_real_14(v10)
    del v10
    v13 = v11 + v12
    del v11, v12
    v14 = v13 + v7
    del v7, v13
    v15 = v14 + " "
    del v14
    v16 = v15 + "dice.accumulate_dice_rolls"
    del v15
    v17 = v16 + " / "
    del v16
    v18 = 23
    v19 = format_real_15(v18)
    del v18
    v20 = "power = " + v19
    del v19
    v21 = v20 + "; "
    del v20
    v22 = v21 + "acc"
    del v21
    v23 = v22 + " = "
    del v22
    v24 = format_real_14(v8)
    del v8
    v25 = v23 + v24
    del v23, v24
    v26 = v25 + "; "
    del v25
    v27 = v26 + "roll"
    del v26
    v28 = v27 + " = "
    del v27
    v29 = format_real_45(v9)
    del v9
    v30 = v28 + v29
    del v28, v29
    v31 = "{ " + v30
    del v30
    v32 = v31 + " }"
    del v31
    v33 = v17 + v32
    del v17, v32
    return method11(v33)
def method18(v0 : UH0, v1 : i64) -> US5:
    match v0:
        case UH0_Cons(v3, v4): # Cons
            del v0
            v5 = v3 > 1
            if v5:
                del v5
                v6 = spiral_wrap(v3 - 1, 8, False)
                v7 = spiral_wrap(int(v6), 64, True)
                del v6
                v8 = spiral_wrap(v7 * 789730223053602816, 64, True)
                del v7
                v9 = TraceState.trace_state is None
                if v9:
                    v10 = US0_Verbose_shared
                    v11, v12, v13, v14, v15, v16 = new_trace_state_0(v10)
                    del v10
                    TraceState.trace_state = (v11, v12, v13, v14, v15, v16) 
                    del v11, v12, v13, v14, v15, v16
                else:
                    pass
                del v9
                v17, v18, v19, v20, v21, v22 = TraceState.trace_state
                del v17, v18, v20, v22
                v23 = v21.v0
                del v21
                match v23:
                    case US0_Critical(): # Critical
                        v28 = 50
                    case US0_Debug(): # Debug
                        v28 = 20
                    case US0_Info(): # Info
                        v28 = 30
                    case US0_Verbose(): # Verbose
                        v28 = 10
                    case US0_Warning(): # Warning
                        v28 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v23
                v29 = v19.v0
                del v19
                v30 = v29 == False
                del v29
                if v30:
                    v32 = False
                else:
                    v31 = 20 >= v28
                    v32 = v31
                del v28, v30
                v33 = v32 == False
                del v32
                if v33:
                    v71 = US4_None_shared
                else:
                    v35 = TraceState.trace_state is None
                    if v35:
                        v36 = US0_Verbose_shared
                        v37, v38, v39, v40, v41, v42 = new_trace_state_0(v36)
                        del v36
                        TraceState.trace_state = (v37, v38, v39, v40, v41, v42) 
                        del v37, v38, v39, v40, v41, v42
                    else:
                        pass
                    del v35
                    v43, v44, v45, v46, v47, v48 = TraceState.trace_state
                    v49 = method5(v43, v44, v45, v46, v47, v48)
                    v50 = method7()
                    v51 = method91(v43, v44, v45, v46, v47, v48, v49, v50, v1, v3, v8)
                    del v43, v44, v45, v46, v47, v48, v49, v50
                    v52 = TraceState.trace_state is None
                    if v52:
                        v53 = US0_Verbose_shared
                        v54, v55, v56, v57, v58, v59 = new_trace_state_0(v53)
                        del v53
                        TraceState.trace_state = (v54, v55, v56, v57, v58, v59) 
                        del v54, v55, v56, v57, v58, v59
                    else:
                        pass
                    del v52
                    v60, v61, v62, v63, v64, v65 = TraceState.trace_state
                    v66 = v60.v0
                    v67 = spiral_wrap(v66 + 1, 64, True)
                    del v66
                    v60.v0 = v67
                    del v67
                    v68 = closure1()
                    v68(v51)
                    del v68
                    v69 = v61.v0
                    v69(v51)
                    del v51, v69
                    v71 = US4_Some(v60, v61, v62, v63, v64, v65)
                del v3, v33, v71
                v72 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method19(v4, v72)
            else:
                del v5
                v74 = TraceState.trace_state is None
                if v74:
                    v75 = US0_Verbose_shared
                    v76, v77, v78, v79, v80, v81 = new_trace_state_0(v75)
                    del v75
                    TraceState.trace_state = (v76, v77, v78, v79, v80, v81) 
                    del v76, v77, v78, v79, v80, v81
                else:
                    pass
                del v74
                v82, v83, v84, v85, v86, v87 = TraceState.trace_state
                del v82, v83, v85, v87
                v88 = v86.v0
                del v86
                match v88:
                    case US0_Critical(): # Critical
                        v93 = 50
                    case US0_Debug(): # Debug
                        v93 = 20
                    case US0_Info(): # Info
                        v93 = 30
                    case US0_Verbose(): # Verbose
                        v93 = 10
                    case US0_Warning(): # Warning
                        v93 = 40
                    case t:
                        raise Exception(f'Pattern matching miss. Got: {t}')
                del v88
                v94 = v84.v0
                del v84
                v95 = v94 == False
                del v94
                if v95:
                    v97 = False
                else:
                    v96 = 20 >= v93
                    v97 = v96
                del v93, v95
                v98 = v97 == False
                del v97
                if v98:
                    v136 = US4_None_shared
                else:
                    v100 = TraceState.trace_state is None
                    if v100:
                        v101 = US0_Verbose_shared
                        v102, v103, v104, v105, v106, v107 = new_trace_state_0(v101)
                        del v101
                        TraceState.trace_state = (v102, v103, v104, v105, v106, v107) 
                        del v102, v103, v104, v105, v106, v107
                    else:
                        pass
                    del v100
                    v108, v109, v110, v111, v112, v113 = TraceState.trace_state
                    v114 = method5(v108, v109, v110, v111, v112, v113)
                    v115 = method7()
                    v116 = method92(v108, v109, v110, v111, v112, v113, v114, v115, v1, v3)
                    del v108, v109, v110, v111, v112, v113, v114, v115
                    v117 = TraceState.trace_state is None
                    if v117:
                        v118 = US0_Verbose_shared
                        v119, v120, v121, v122, v123, v124 = new_trace_state_0(v118)
                        del v118
                        TraceState.trace_state = (v119, v120, v121, v122, v123, v124) 
                        del v119, v120, v121, v122, v123, v124
                    else:
                        pass
                    del v117
                    v125, v126, v127, v128, v129, v130 = TraceState.trace_state
                    v131 = v125.v0
                    v132 = spiral_wrap(v131 + 1, 64, True)
                    del v131
                    v125.v0 = v132
                    del v132
                    v133 = closure1()
                    v133(v116)
                    del v133
                    v134 = v126.v0
                    v134(v116)
                    del v116, v134
                    v136 = US4_Some(v125, v126, v127, v128, v129, v130)
                del v3, v98, v136
                return method19(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None_shared
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method16(v0 : UH0, v1 : i8) -> i64:
    while True:
        v2 = v1 < 24
        if v2:
            del v2
            v3 = roll_dice_17()
            v4 = UH0_Cons(v3, v0)
            del v0, v3
            v5 = spiral_wrap(v1 + 1, 8, True)
            del v1
            v0, v1 = v4, v5
            continue
        else:
            del v1, v2
            v7 = 0
            v8 = method18(v0, v7)
            del v0, v7
            match v8:
                case US5_Some(v9, _): # Some
                    del v8
                    v11 = v9 <= 4738381338321616896
                    if v11:
                        del v11
                        return v9
                    else:
                        del v9, v11
                        v12 = roll_dice_17()
                        v13 = roll_dice_17()
                        v14 = roll_dice_17()
                        v15 = roll_dice_17()
                        v16 = roll_dice_17()
                        v17 = roll_dice_17()
                        v18 = roll_dice_17()
                        v19 = roll_dice_17()
                        v20 = roll_dice_17()
                        v21 = roll_dice_17()
                        v22 = roll_dice_17()
                        v23 = roll_dice_17()
                        v24 = roll_dice_17()
                        v25 = roll_dice_17()
                        v26 = roll_dice_17()
                        v27 = roll_dice_17()
                        v28 = roll_dice_17()
                        v29 = roll_dice_17()
                        v30 = roll_dice_17()
                        v31 = roll_dice_17()
                        v32 = roll_dice_17()
                        v33 = roll_dice_17()
                        v34 = roll_dice_17()
                        v35 = UH0_Nil_shared
                        v36 = UH0_Cons(v34, v35)
                        del v34, v35
                        v37 = UH0_Cons(v33, v36)
                        del v33, v36
                        v38 = UH0_Cons(v32, v37)
                        del v32, v37
                        v39 = UH0_Cons(v31, v38)
                        del v31, v38
                        v40 = UH0_Cons(v30, v39)
                        del v30, v39
                        v41 = UH0_Cons(v29, v40)
                        del v29, v40
                        v42 = UH0_Cons(v28, v41)
                        del v28, v41
                        v43 = UH0_Cons(v27, v42)
                        del v27, v42
                        v44 = UH0_Cons(v26, v43)
                        del v26, v43
                        v45 = UH0_Cons(v25, v44)
                        del v25, v44
                        v46 = UH0_Cons(v24, v45)
                        del v24, v45
                        v47 = UH0_Cons(v23, v46)
                        del v23, v46
                        v48 = UH0_Cons(v22, v47)
                        del v22, v47
                        v49 = UH0_Cons(v21, v48)
                        del v21, v48
                        v50 = UH0_Cons(v20, v49)
                        del v20, v49
                        v51 = UH0_Cons(v19, v50)
                        del v19, v50
                        v52 = UH0_Cons(v18, v51)
                        del v18, v51
                        v53 = UH0_Cons(v17, v52)
                        del v17, v52
                        v54 = UH0_Cons(v16, v53)
                        del v16, v53
                        v55 = UH0_Cons(v15, v54)
                        del v15, v54
                        v56 = UH0_Cons(v14, v55)
                        del v14, v55
                        v57 = UH0_Cons(v13, v56)
                        del v13, v56
                        v58 = UH0_Cons(v12, v57)
                        del v12, v57
                        v59 = 23
                        v0, v1 = v58, v59
                        continue
                case t:
                    del v8
                    v62 = roll_dice_17()
                    v63 = roll_dice_17()
                    v64 = roll_dice_17()
                    v65 = roll_dice_17()
                    v66 = roll_dice_17()
                    v67 = roll_dice_17()
                    v68 = roll_dice_17()
                    v69 = roll_dice_17()
                    v70 = roll_dice_17()
                    v71 = roll_dice_17()
                    v72 = roll_dice_17()
                    v73 = roll_dice_17()
                    v74 = roll_dice_17()
                    v75 = roll_dice_17()
                    v76 = roll_dice_17()
                    v77 = roll_dice_17()
                    v78 = roll_dice_17()
                    v79 = roll_dice_17()
                    v80 = roll_dice_17()
                    v81 = roll_dice_17()
                    v82 = roll_dice_17()
                    v83 = roll_dice_17()
                    v84 = roll_dice_17()
                    v85 = UH0_Nil_shared
                    v86 = UH0_Cons(v84, v85)
                    del v84, v85
                    v87 = UH0_Cons(v83, v86)
                    del v83, v86
                    v88 = UH0_Cons(v82, v87)
                    del v82, v87
                    v89 = UH0_Cons(v81, v88)
                    del v81, v88
                    v90 = UH0_Cons(v80, v89)
                    del v80, v89
                    v91 = UH0_Cons(v79, v90)
                    del v79, v90
                    v92 = UH0_Cons(v78, v91)
                    del v78, v91
                    v93 = UH0_Cons(v77, v92)
                    del v77, v92
                    v94 = UH0_Cons(v76, v93)
                    del v76, v93
                    v95 = UH0_Cons(v75, v94)
                    del v75, v94
                    v96 = UH0_Cons(v74, v95)
                    del v74, v95
                    v97 = UH0_Cons(v73, v96)
                    del v73, v96
                    v98 = UH0_Cons(v72, v97)
                    del v72, v97
                    v99 = UH0_Cons(v71, v98)
                    del v71, v98
                    v100 = UH0_Cons(v70, v99)
                    del v70, v99
                    v101 = UH0_Cons(v69, v100)
                    del v69, v100
                    v102 = UH0_Cons(v68, v101)
                    del v68, v101
                    v103 = UH0_Cons(v67, v102)
                    del v67, v102
                    v104 = UH0_Cons(v66, v103)
                    del v66, v103
                    v105 = UH0_Cons(v65, v104)
                    del v65, v104
                    v106 = UH0_Cons(v64, v105)
                    del v64, v105
                    v107 = UH0_Cons(v63, v106)
                    del v63, v106
                    v108 = UH0_Cons(v62, v107)
                    del v62, v107
                    v109 = 23
                    v0, v1 = v108, v109
                    continue
def method93(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64) -> string:
    del v1, v2, v3, v4, v5
    v9 = v0.v0
    del v0
    v10 = v6 + " "
    del v6
    v11 = format_real_14(v9)
    del v9
    v12 = v10 + v11
    del v10, v11
    v13 = v12 + v7
    del v7, v12
    v14 = v13 + " "
    del v13
    v15 = v14 + "dice.main"
    del v14
    v16 = v15 + " / "
    del v15
    v17 = format_real_14(v8)
    del v8
    v18 = "result = " + v17
    del v17
    v19 = "{ " + v18
    del v18
    v20 = v19 + " }"
    del v19
    v21 = v16 + v20
    del v16, v20
    return method11(v21)
def main():
    v0 = "Python"
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    del v0
    v1 = spiral_object_array()
    del v1
    v2 = TraceState.trace_state is None
    if v2:
        v3 = US0_Verbose_shared
        v4, v5, v6, v7, v8, v9 = new_trace_state_0(v3)
        del v3
        TraceState.trace_state = (v4, v5, v6, v7, v8, v9) 
        del v4, v5, v6, v7, v8, v9
    else:
        pass
    del v2
    v10, v11, v12, v13, v14, v15 = TraceState.trace_state
    del v10, v11, v13, v15
    v16 = v14.v0
    del v14
    match v16:
        case US0_Critical(): # Critical
            v21 = 50
        case US0_Debug(): # Debug
            v21 = 20
        case US0_Info(): # Info
            v21 = 30
        case US0_Verbose(): # Verbose
            v21 = 10
        case US0_Warning(): # Warning
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
        v64 = US4_None_shared
    else:
        v28 = TraceState.trace_state is None
        if v28:
            v29 = US0_Verbose_shared
            v30, v31, v32, v33, v34, v35 = new_trace_state_0(v29)
            del v29
            TraceState.trace_state = (v30, v31, v32, v33, v34, v35) 
            del v30, v31, v32, v33, v34, v35
        else:
            pass
        del v28
        v36, v37, v38, v39, v40, v41 = TraceState.trace_state
        v42 = method5(v36, v37, v38, v39, v40, v41)
        v43 = method7()
        v44 = method10(v36, v37, v38, v39, v40, v41, v42, v43)
        del v36, v37, v38, v39, v40, v41, v42, v43
        v45 = TraceState.trace_state is None
        if v45:
            v46 = US0_Verbose_shared
            v47, v48, v49, v50, v51, v52 = new_trace_state_0(v46)
            del v46
            TraceState.trace_state = (v47, v48, v49, v50, v51, v52) 
            del v47, v48, v49, v50, v51, v52
        else:
            pass
        del v45
        v53, v54, v55, v56, v57, v58 = TraceState.trace_state
        v59 = v53.v0
        v60 = spiral_wrap(v59 + 1, 64, True)
        del v59
        v53.v0 = v60
        del v60
        v61 = closure1()
        v61(v44)
        del v61
        v62 = v54.v0
        v62(v44)
        del v44, v62
        v64 = US4_Some(v53, v54, v55, v56, v57, v58)
    del v26, v64
    v65 = UH0_Nil_shared
    v66 = 0
    v67 = method16(v65, v66)
    del v65, v66
    v68 = TraceState.trace_state is None
    if v68:
        v69 = US0_Verbose_shared
        v70, v71, v72, v73, v74, v75 = new_trace_state_0(v69)
        del v69
        TraceState.trace_state = (v70, v71, v72, v73, v74, v75) 
        del v70, v71, v72, v73, v74, v75
    else:
        pass
    del v68
    v76, v77, v78, v79, v80, v81 = TraceState.trace_state
    del v76, v77, v79, v81
    v82 = v80.v0
    del v80
    match v82:
        case US0_Critical(): # Critical
            v87 = 50
        case US0_Debug(): # Debug
            v87 = 20
        case US0_Info(): # Info
            v87 = 30
        case US0_Verbose(): # Verbose
            v87 = 10
        case US0_Warning(): # Warning
            v87 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v82
    v88 = v78.v0
    del v78
    v89 = v88 == False
    del v88
    if v89:
        v91 = False
    else:
        v90 = 20 >= v87
        v91 = v90
    del v87, v89
    v92 = v91 == False
    del v91
    if v92:
        v130 = US4_None_shared
    else:
        v94 = TraceState.trace_state is None
        if v94:
            v95 = US0_Verbose_shared
            v96, v97, v98, v99, v100, v101 = new_trace_state_0(v95)
            del v95
            TraceState.trace_state = (v96, v97, v98, v99, v100, v101) 
            del v96, v97, v98, v99, v100, v101
        else:
            pass
        del v94
        v102, v103, v104, v105, v106, v107 = TraceState.trace_state
        v108 = method5(v102, v103, v104, v105, v106, v107)
        v109 = method7()
        v110 = method93(v102, v103, v104, v105, v106, v107, v108, v109, v67)
        del v102, v103, v104, v105, v106, v107, v108, v109
        v111 = TraceState.trace_state is None
        if v111:
            v112 = US0_Verbose_shared
            v113, v114, v115, v116, v117, v118 = new_trace_state_0(v112)
            del v112
            TraceState.trace_state = (v113, v114, v115, v116, v117, v118) 
            del v113, v114, v115, v116, v117, v118
        else:
            pass
        del v111
        v119, v120, v121, v122, v123, v124 = TraceState.trace_state
        v125 = v119.v0
        v126 = spiral_wrap(v125 + 1, 64, True)
        del v125
        v119.v0 = v126
        del v126
        v127 = closure1()
        v127(v110)
        del v127
        v128 = v120.v0
        v128(v110)
        del v110, v128
        v130 = US4_Some(v119, v120, v121, v122, v123, v124)
    del v67, v92, v130
    return 

if __name__ == '__main__': main()
